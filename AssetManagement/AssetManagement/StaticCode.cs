﻿using AssetManagement.Properties;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement
{
    public class StaticCode
    {
        #region General members
        public static string appGuid = "c0a76b5a-12ab-45c5-b9d9-d693faa6e7b9";
        public static string ApplicationTitle = "إدارة الأصول - Asset management";
        public static int ShiftDays = 0;
        public static int ShiftSeconds = 0;
        #endregion

        #region Db
        public static string dbPath = $"{Application.StartupPath}//Db//AssetMngDb.mdf";
        public static string db_logPath = $"{Application.StartupPath}//Db//AssetMngDb_log.ldf";
        public static string dbPath_stat = $"{Application.StartupPath}//Db//AssetMngDb2.mdf";
        public static string db_logPath_stat = $"{Application.StartupPath}//Db//AssetMngDb2_log.ldf";
        public static AssetMngDbDataContext mainDbContext = new AssetMngDbDataContext();
        public static OptionsTbl appOptions = mainDbContext.OptionsTbls.Single(opt => opt.ID == 1);
        public static string BackupFolder = $"{Application.StartupPath}//Backup files//";

        public static bool BackupDb(string backupName)
        {
            try
            {
                SqlConnection dbConn = new SqlConnection(new Settings().AssetMngDbConnectionString);
                if (dbConn.State != System.Data.ConnectionState.Open)
                    dbConn.Open();
                using (SqlCommand backupDbComm = new SqlCommand($"Backup DATABASE AssetMngDb TO DISK='{backupName}'", dbConn))
                {
                    backupDbComm.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool RestoreDb(string backupName)
        {
            try
            {
                SqlConnection dbConn = new SqlConnection(new Settings().AssetMngDbConnectionString);
                if (dbConn.State != System.Data.ConnectionState.Open)
                    dbConn.Open();
                using (SqlCommand backupDbComm = new SqlCommand($"RESTORE DATABASE AssetMngDb FROM DISK='{backupName}' WITH REPLACE", dbConn))
                {
                    backupDbComm.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static IQueryable<AssetTbl> GetAssetsToDestruct()
        {
            ExecuteProcedure("dbo.CalcAssetsLifeSpanSp");
            mainDbContext.Refresh(RefreshMode.KeepChanges, mainDbContext.AssetTbls);
            IQueryable<AssetTbl> res = mainDbContext.AssetTbls.Where(ast => ast.LifeSpanInMonths >= 0 && ast.LifeSpanInMonths <= appOptions.AssetLifeSpanThresholdToWarn).Select(ast1 => ast1);
            return res;
        }

        public static void ExecuteProcedure(string procName)
        {
            SqlConnection sqlConn = new SqlConnection(new Properties.Settings().AssetMngDbConnectionString);
            if (sqlConn.State != System.Data.ConnectionState.Open)
                sqlConn.Open();
            SqlCommand sqlComm = new SqlCommand(procName, sqlConn);
            sqlComm.CommandType = System.Data.CommandType.StoredProcedure;
            sqlComm.ExecuteNonQuery();
        }
        #endregion

        #region Login
        public static UserTbl activeUser { get; set; }
        public static UserRoleTbl activeUserRole { get; set; }
        public static OptionsTbl activeUserOptions { get; set; }
        #endregion

        #region Export and Import
        public static string ExportFolder = $"{Application.StartupPath}//Export files//";

        public static void ImportDataFromExcel(string excelFilePath)
        {
            //create our connection strings
            string ssqlconnectionstring = new Properties.Settings().AssetMngDbConnectionString;
            //execute a query to erase any previous data from our destination table
            SqlConnection sqlconn = new SqlConnection(ssqlconnectionstring);
            if (sqlconn.State != ConnectionState.Open)
                sqlconn.Open();
            string qryBefore = "DISABLE TRIGGER SetDateAndUser_Asset on AssetTbl; DISABLE TRIGGER UpdateAssetLifeSpanandDestructionRate on AssetTbl;";
            SqlCommand sqlcomm = new SqlCommand(qryBefore, sqlconn);
            sqlcomm.ExecuteNonQuery();

            List<string> tblsToImport = new List<string>() { "AssetTbl", "FinancialItemTbl", "UserTbl", "AssetMovementTbl" };
            List<string> keyFields = new List<string>() { "AssetCode", "ID", "PasswordUpdatedOn", "MovementDate" };

            ExcelPackage srcExcelEp = new ExcelPackage(new FileInfo(excelFilePath));
            ExcelWorkbook srcExcelWb = srcExcelEp.Workbook;
            foreach (ExcelWorksheet oneSh in srcExcelWb.Worksheets)
            {
                Application.DoEvents();
                //declare variables - edit these based on your particular situation   
                string ssqltable = oneSh.Name;
                if (ssqltable != "AssetTbl")
                    continue;
                if (tblsToImport.IndexOf(ssqltable) == -1)
                    continue;
                // make sure your sheet name is correct, here sheet name is sheet1,
                //so you can change your sheet name if have different
                try
                {
                    string currKeyField = keyFields[tblsToImport.IndexOf(ssqltable)];
                    List<string> tblFields = oneSh.Cells.Where(cl1 => cl1.End.Row == 1 && cl1.Start.Row == 1 && cl1.End.Column <= oneSh.Dimension.End.Column).Select(cl2 => cl2.Value?.ToString()).ToList();
                    int keyIndex = tblFields.IndexOf(currKeyField) + 1;
                    for (int iRow = 2; iRow <= oneSh.Dimension.End.Row; iRow++)
                    {
                        Application.DoEvents();
                        string oneKeyValue = oneSh.Cells[iRow, keyIndex].Value?.ToString();
                        string sqlQry = $"SELECT * FROM {ssqltable} where {currKeyField} = N'{oneKeyValue}'";
                        sqlcomm.CommandType = CommandType.Text;
                        SqlDataReader sqlRdr = sqlcomm.ExecuteReader();
                        bool recordExisted = sqlRdr.HasRows;
                        sqlRdr.Close();
                        if (recordExisted)
                        {
                            string fieldsValuesPairs = "";
                            for (int iCol = 2; iCol <= oneSh.Dimension.End.Column; iCol++)
                            {
                                string oneField = oneSh.Cells[1, iCol].Value?.ToString();
                                string oneVal = oneSh.Cells[iRow, iCol].Value?.ToString();
                                if (oneField.ToUpper().Contains("DATE") || oneField.ToUpper().Contains("MODIFIEDON") || oneField.ToUpper().Contains("CREATEDON") || oneField.ToUpper().Contains("INSERTEDON"))
                                {
                                    fieldsValuesPairs += $"{oneField} = N'{Convert.ToDateTime(oneVal).ToString("yyyy-MM-dd")}', ";
                                }
                                else
                                {
                                    fieldsValuesPairs += $"{oneField} = N'{oneVal}', ";
                                }
                            }
                            fieldsValuesPairs = fieldsValuesPairs.Trim().Trim(',');
                            string updateQry = $"UPDATE {ssqltable} SET {fieldsValuesPairs} WHERE {currKeyField} = N'{oneKeyValue}';";
                            sqlcomm.CommandText = updateQry;
                        }
                        else
                        {
                            string fieldsPairs = "";
                            string valuesPairs = "";

                            //fieldsPairs = tblFields.Select(fp1 => fp1 + ", ").ToString().Trim().Trim(',');

                            // valuesPairs = oneSh.Cells.Where(cl1 => cl1.End.Row == iRow && cl1.Start.Row == iRow && cl1.End.Column <= oneSh.Dimension.End.Column).Select(cl2 => cl2.Value?.ToString()+",").ToString().Trim().Trim(',');
                            for (int iCol = 2; iCol <= oneSh.Dimension.End.Column; iCol++)
                            {
                                string oneField = oneSh.Cells[1, iCol].Value?.ToString();
                                string oneVal = oneSh.Cells[iRow, iCol].Value?.ToString();
                                fieldsPairs += $"{oneField}, ";
                                if (oneField.ToUpper().Contains("DATE") || oneField.ToUpper().Contains("MODIFIEDON") || oneField.ToUpper().Contains("CREATEDON") || oneField.ToUpper().Contains("INSERTEDON"))
                                {
                                    valuesPairs += $"N'{Convert.ToDateTime(oneVal).ToString("yyyy-MM-dd")}', ";
                                }
                                else
                                {
                                    valuesPairs += $"N'{oneVal}', ";
                                }
                            }
                            fieldsPairs = fieldsPairs.Trim().Trim(',');
                            valuesPairs = valuesPairs.Trim().Trim(',');
                            string updateQry = $"INSERT INTO {ssqltable}({fieldsPairs}) VALUES ({valuesPairs});";
                            sqlcomm.CommandText = updateQry;
                        }
                        sqlcomm.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    continue;
                }
            }

            string qryAfter = "ENABLE TRIGGER SetDateAndUser_Asset on AssetTbl; ENABLE TRIGGER UpdateAssetLifeSpanandDestructionRate on AssetTbl;";
            sqlcomm.CommandText = qryAfter;
            sqlcomm.ExecuteNonQuery();
        }
        #endregion

        #region RSA
        public static string RSAKeysFolder = $"{Application.StartupPath}//RSA keys//";
        public static string RSAPublicKeyPath = $"{RSAKeysFolder}Public key.asset";
        public static string RSAPrivateKeyPath = $"{RSAKeysFolder}Private key.asset";

        public static void GenerateNewRSAPublicAndPrivateKeys()
        {
            if (!Directory.Exists(RSAKeysFolder))
                Directory.CreateDirectory(RSAKeysFolder);
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            string publicKey = RSA.ToXmlString(false);
            string privateKey = RSA.ToXmlString(true);
            StreamWriter publicKeyPath = new StreamWriter(RSAPublicKeyPath, false);
            StreamWriter privateKeyPath = new StreamWriter(RSAPrivateKeyPath, false);
            publicKeyPath.Write(publicKey);
            privateKeyPath.Write(privateKey);
            publicKeyPath.Close();
            privateKeyPath.Close();
        }

        static public string RSAEncryption(byte[] dataBytes)
        {
            try
            {
                if (!File.Exists(StaticCode.RSAPublicKeyPath))
                    return null;
                StreamReader pubKeyRdr = new StreamReader(StaticCode.RSAPublicKeyPath);
                string publicKeyStr = pubKeyRdr.ReadToEnd();
                pubKeyRdr.Close();

                string base64Encrypted = "";
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024))
                {
                    RSA.FromXmlString(publicKeyStr);
                    byte[] encryptedData = RSA.Encrypt(dataBytes, true);
                    base64Encrypted = Convert.ToBase64String(encryptedData);
                }
                return base64Encrypted;
            }
            catch
            {
                return null;
            }
        }

        static public byte[] RSADecryption(byte[] Data)
        {
            try
            {
                if (!File.Exists(StaticCode.RSAPrivateKeyPath))
                    return null;
                StreamReader priKeyRdr = new StreamReader(StaticCode.RSAPrivateKeyPath);
                string privateKeyStr = priKeyRdr.ReadToEnd();
                priKeyRdr.Close();

                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.FromXmlString(privateKeyStr);
                    decryptedData = RSA.Decrypt(Data, true);
                }
                return decryptedData;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region DES
        public static string DESKeyAndIVFolder = $"{Application.StartupPath}//DES key and IV//";
        public static string DESKeyAndIVPath = $"{DESKeyAndIVFolder}key_IV.asset";

        public static void GenerateNewDESKeyAndIV()
        {
            if (!Directory.Exists(DESKeyAndIVFolder))
                Directory.CreateDirectory(DESKeyAndIVFolder);
            DES DES_1 = DES.Create();
            byte[] DESKey = DES_1.Key;
            byte[] DESIV = DES_1.IV;
            FileStream key_IVPathWr = File.Open(DESKeyAndIVPath, FileMode.OpenOrCreate, FileAccess.Write);
            key_IVPathWr.Write(DESKey, 0, DESKey.Length);
            key_IVPathWr.Write(DESIV, 0, DESIV.Length);
            key_IVPathWr.Close();

            //FileStream fs = new FileStream(DESKeyAndIVPath, FileMode.Open, FileAccess.Read);
            //byte[] outBytes = new byte[fs.Length];
            //fs.Read(outBytes, 0, outBytes.Length);
            //if (!File.Exists(StaticCode.RSAPublicKeyPath) || !File.Exists(StaticCode.RSAPublicKeyPath))
            //{
            //    StaticCode.GenerateNewRSAPublicAndPrivateKeys();
            //}
            //string encryptedStr = StaticCode.RSAEncryption(outBytes);
            //fs.Close();
            //fs = File.Open(DESKeyAndIVPath, FileMode.Create);
            //byte[] outBytes_enc = Encoding.UTF8.GetBytes(encryptedStr);
            //fs.Write(outBytes_enc, 0, outBytes_enc.Length);
            //fs.Close();
        }

        public static bool DESEncryption(string inName, string outName, byte[] DESKey, byte[] DESIV)
        {
            if (!File.Exists(inName))
                return false;

            try
            {
                //Create the file streams to handle the input and output files.
                FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read);
                FileStream fout = new FileStream(outName, FileMode.OpenOrCreate, FileAccess.Write);
                fout.SetLength(0);

                //Create variables to help with read and write.
                byte[] bin = new byte[100]; //This is intermediate storage for the encryption.
                long rdlen = 0;              //This is the total number of bytes written.
                long totlen = fin.Length;    //This is the total length of the input file.
                int len;                     //This is the number of bytes to be written at a time.

                DES DES = DES.Create();
                CryptoStream encStream = new CryptoStream(fout, DES.CreateEncryptor(DESKey, DESIV), CryptoStreamMode.Write);

                //Read from the input file, then encrypt and write to the output file.
                while (rdlen < totlen)
                {
                    len = fin.Read(bin, 0, 100);
                    encStream.Write(bin, 0, len);
                    rdlen = rdlen + len;
                    Application.DoEvents();
                }

                encStream.Close();
                fout.Close();
                fin.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DESDecryption(string inName, string outName, byte[] DESKey, byte[] DESIV)
        {
            if (!File.Exists(inName))
                return false;

            try
            {
                //Create the file streams to handle the input and output files.
                FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read);
                FileStream fout = new FileStream(outName, FileMode.OpenOrCreate, FileAccess.Write);
                fout.SetLength(0);

                //Create variables to help with read and write.
                byte[] bin = new byte[100]; //This is intermediate storage for the encryption.
                long rdlen = 0;              //This is the total number of bytes written.
                long totlen = fin.Length;    //This is the total length of the input file.
                int len;                     //This is the number of bytes to be written at a time.

                DES DES = DES.Create();
                CryptoStream decStream = new CryptoStream(fout, DES.CreateDecryptor(DESKey, DESIV), CryptoStreamMode.Write);

                //Read from the input file, then encrypt and write to the output file.
                while (rdlen < totlen)
                {
                    len = fin.Read(bin, 0, 100);
                    decStream.Write(bin, 0, len);
                    rdlen = rdlen + len;
                    Application.DoEvents();
                }

                decStream.Close();
                fout.Close();
                fin.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Aes
        public static string AesKeyAndIVFolder = $"{Application.StartupPath}//Aes key and IV//";
        public static string AesKeyAndIVPath = $"{AesKeyAndIVFolder}key_IV.asset";

        public static void GenerateNewAesKeyAndIV()
        {
            if (!Directory.Exists(AesKeyAndIVFolder))
                Directory.CreateDirectory(AesKeyAndIVFolder);
            Aes Aes_1 = Aes.Create();
            byte[] AesKey = Aes_1.Key;
            byte[] AesIV = Aes_1.IV;
            List<byte> ddd = new List<byte>();
            ddd.AddRange(AesKey);
            ddd.AddRange(AesIV);
            byte[] AesKey_IV = ddd.ToArray();



            FileStream key_IVPathWr = File.Open(AesKeyAndIVPath, FileMode.OpenOrCreate, FileAccess.Write);
            key_IVPathWr.Write(AesKey, 0, AesKey.Length);
            key_IVPathWr.Write(AesIV, 0, AesIV.Length);
            key_IVPathWr.Close();
        }

        public static bool AesEncryption(string inName, string outName, byte[] aesKey, byte[] aesIV)
        {
            if (!File.Exists(inName))
                return false;

            try
            {
                //Create the file streams to handle the input and output files.
                FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read);
                FileStream fout = new FileStream(outName, FileMode.OpenOrCreate, FileAccess.Write);
                fout.SetLength(0);

                //Create variables to help with read and write.
                byte[] bin = new byte[100]; //This is intermediate storage for the encryption.
                long rdlen = 0;              //This is the total number of bytes written.
                long totlen = fin.Length;    //This is the total length of the input file.
                int len;                     //This is the number of bytes to be written at a time.

                Aes aes = Aes.Create();
                //aes.Padding = PaddingMode.PKCS7;
                CryptoStream encStream = new CryptoStream(fout, aes.CreateEncryptor(aesKey, aesIV), CryptoStreamMode.Write);

                //Read from the input file, then encrypt and write to the output file.
                while (rdlen < totlen)
                {
                    len = fin.Read(bin, 0, 100);
                    encStream.Write(bin, 0, len);
                    rdlen = rdlen + len;
                    Application.DoEvents();
                }

                encStream.Close();
                fout.Close();
                fin.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool AesDecryption(string inName, string outName, byte[] aesKey, byte[] aesIV)
        {
            if (!File.Exists(inName))
                return false;

            try
            {
                //Create the file streams to handle the input and output files.
                FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read);
                FileStream fout = new FileStream(outName, FileMode.OpenOrCreate, FileAccess.Write);
                fout.SetLength(0);

                //Create variables to help with read and write.
                byte[] bin = new byte[100]; //This is intermediate storage for the encryption.
                long rdlen = 0;              //This is the total number of bytes written.
                long totlen = fin.Length;    //This is the total length of the input file.
                int len;                     //This is the number of bytes to be written at a time.

                Aes aes = Aes.Create();
                //aes.Padding = PaddingMode.PKCS7;
                CryptoStream decStream = new CryptoStream(fout, aes.CreateDecryptor(aesKey, aesIV), CryptoStreamMode.Write);

                //Read from the input file, then encrypt and write to the output file.
                while (rdlen < totlen)
                {
                    len = fin.Read(bin, 0, 100);
                    decStream.Write(bin, 0, len);
                    rdlen = rdlen + len;
                    Application.DoEvents();
                }

                decStream.Close();
                fout.Close();
                fin.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Finance
        public static string FinanceFolder = $"{Application.StartupPath}//Finance forms//";
        public static string FinancialReportPath = $"{FinanceFolder}financial blank report.xlsx";
        #endregion
    }
}