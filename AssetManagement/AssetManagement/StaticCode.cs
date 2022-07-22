﻿using AssetManagement.Properties;
using System;
using System.Collections.Generic;
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

        public static List<AssetTbl> GetAssetsToDestruct()
        {
            List<AssetTbl> res = mainDbContext.AssetTbls.Where(ast => ast.LifeSpanInMonths <= appOptions.AssetLifeSpanThresholdToWarn).Select(ast1 => ast1).ToList();
            return res;
        }
        #endregion

        #region Login
        public static UserTbl activeUser { get; set; }
        public static UserRoleTbl activeUserRole { get; set; }
        public static OptionsTbl activeUserOptions { get; set; }
        #endregion

        #region Export and Import
        public static string ExportFolder = $"{Application.StartupPath}//Export files//";
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