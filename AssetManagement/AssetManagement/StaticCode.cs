﻿using AssetManagement.Properties;
using DevExpress.XtraEditors;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
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
        #endregion

        #region Db
        public static SqlConnection mainConn { get; set; }
        public static string dbPath = $"{Application.StartupPath}//Db//AssetMngDb.mdf";
        public static string db_logPath = $"{Application.StartupPath}//Db//AssetMngDb_log.ldf";
        public static AssetMngDbDataContext mainDbContext = new AssetMngDbDataContext();
        public static OptionsTbl appOptions { get; set; }
        public static string BackupFolder = $"{Application.StartupPath}//Backup files//";
        public static string PMName = "PM";

        public static void AssignDbParams()
        {
            mainDbContext = new AssetMngDbDataContext();
            mainDbContext.Refresh(RefreshMode.OverwriteCurrentValues);

            activeUser = mainDbContext.UserTbls.Single(usr1 => usr1.ID == activeUser.ID);
            mainConn = new SqlConnection(new Properties.Settings().AssetMngDbConnectionString);
            appOptions = mainDbContext.OptionsTbls.Single(opt => opt.ID == 1);
            activeUserRole = mainDbContext.UserRoleTbls.Single(usrrl => usrrl.ID == activeUser.UserRole);
        }

        public static bool BackupDb(string backupName)
        {
            try
            {
                SqlConnection dbConn = new SqlConnection(new Properties.Settings().AssetMngDbConnectionString);
                if (dbConn.State != System.Data.ConnectionState.Open)
                    dbConn.Open();
                System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder(new Properties.Settings().AssetMngDbConnectionString);
                string server = builder.DataSource;
                string database = builder.InitialCatalog;
                using (SqlCommand backupDbComm = new SqlCommand($"Backup DATABASE {builder.InitialCatalog} TO DISK='{backupName}'", dbConn))
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

        public static bool RestoreDb2(string backupName)
        {
            try
            {
                SqlConnection dbConn = new SqlConnection(new Properties.Settings().AssetMngDbConnectionString);
                if (dbConn.State != System.Data.ConnectionState.Open)
                    dbConn.Open();
                System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder(new Properties.Settings().AssetMngDbConnectionString);
                string server = builder.DataSource;
                string database = builder.InitialCatalog;
                using (SqlCommand backupDbComm = new SqlCommand($"RESTORE DATABASE AssetMngDb FROM DISK='{backupName}' WITH REPLACE", dbConn))
                {
                    backupDbComm.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                string dddd = ex.Message;
                return false;
            }
        }

        public static bool RestoreDb3(string backupName)
        {
            try
            {
                SqlConnection dbConn = new SqlConnection(new Properties.Settings().AssetMngDbConnectionString);
                if (dbConn.State != System.Data.ConnectionState.Open)
                    dbConn.Open();
                string dbName = dbConn.Database;
                using (SqlCommand backupDbComm = new SqlCommand($"ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE ", dbConn))
                {
                    backupDbComm.ExecuteNonQuery();
                    backupDbComm.CommandText = $"USE MASTER RESTORE DATABASE [{dbName}] FROM DISK = '{backupName}' WITH REPLACE";
                    backupDbComm.ExecuteNonQuery();
                    backupDbComm.CommandText = $"ALTER DATABASE [{dbName}] SET MULTI_USER";
                    backupDbComm.ExecuteNonQuery();
                    dbConn.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                string dddd = ex.Message;
                return false;
            }
        }

        public static bool RestoreDb(string backupName)
        {
            try
            {
                Microsoft.Data.SqlClient.SqlConnection sqlConnection = new Microsoft.Data.SqlClient.SqlConnection(new Properties.Settings().AssetMngDbConnectionString);
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                Server dbServer = new Server(new ServerConnection(sqlConnection));
                Restore dbRestore = new Restore() { Database = sqlConnection.Database, Action = RestoreActionType.Database, ReplaceDatabase = true, NoRecovery = false };
                dbRestore.Devices.AddDevice(backupName, DeviceType.File);
                dbRestore.SqlRestoreAsync(dbServer);
                sqlConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                string dddd = ex.Message;
                return false;
            }
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newYear"></param>
        /// <param name="newMonth"></param>
        /// <param name="levelID"></param>
        /// <param name="levelRank">1 for sections, 2 for departments, and 3 for sub-departments</param>
        /// <returns></returns>
        //public virtual int FillByQuery(AssetMngDbDataSet.AssetVwDataTable dataTable, string whereQuery)
        //{
        //    int whereIndex = this.CommandCollection[0].CommandText.IndexOf("WHERE ", 0);
        //    if (whereIndex == -1)
        //    {
        //        this.CommandCollection[0].CommandText += whereQuery;
        //    }
        //    else
        //    {
        //        this.CommandCollection[0].CommandText = this.CommandCollection[0].CommandText.Substring(0, whereIndex - 1) + whereQuery;
        //    }
        //    this.Adapter.SelectCommand = this.CommandCollection[0];
        //    if ((this.ClearBeforeFill == true))
        //    {
        //        dataTable.Clear();
        //    }
        //    int returnValue = this.Adapter.Fill(dataTable);
        //    return returnValue;
        //}

        //public virtual int FillByQuery(AssetMngDbDataSet.FinancialItemVwDataTable dataTable, string whereQuery)
        //{
        //    int whereIndex = this.CommandCollection[0].CommandText.IndexOf("WHERE ", 0);
        //    if (whereIndex == -1)
        //    {
        //        this.CommandCollection[0].CommandText += whereQuery;
        //    }
        //    else
        //    {
        //        this.CommandCollection[0].CommandText = this.CommandCollection[0].CommandText.Substring(0, whereIndex - 1) + whereQuery;
        //    }
        //    this.Adapter.SelectCommand = this.CommandCollection[0];
        //    if ((this.ClearBeforeFill == true))
        //    {
        //        dataTable.Clear();
        //    }
        //    int returnValue = this.Adapter.Fill(dataTable);
        //    return returnValue;
        //}

        //public virtual int FillByQuery(AssetMngDbDataSet.AssetVw_AllDataTable dataTable, string whereQuery)
        //{
        //    int whereIndex = this.CommandCollection[0].CommandText.IndexOf("WHERE ", 0);
        //    if (whereIndex == -1)
        //    {
        //        this.CommandCollection[0].CommandText += whereQuery;
        //    }
        //    else
        //    {
        //        this.CommandCollection[0].CommandText = this.CommandCollection[0].CommandText.Substring(0, whereIndex - 1) + whereQuery;
        //    }
        //    this.Adapter.SelectCommand = this.CommandCollection[0];
        //    if ((this.ClearBeforeFill == true))
        //    {
        //        dataTable.Clear();
        //    }
        //    int returnValue = this.Adapter.Fill(dataTable);
        //    return returnValue;
        //}

        //public virtual int FillByQuery(AssetMngDbDataSet.DepartmentVwDataTable dataTable, string whereQuery)
        //{
        //    int whereIndex = this.CommandCollection[0].CommandText.IndexOf("WHERE ", 0);
        //    if (whereIndex == -1)
        //    {
        //        this.CommandCollection[0].CommandText += whereQuery;
        //    }
        //    else
        //    {
        //        this.CommandCollection[0].CommandText = this.CommandCollection[0].CommandText.Substring(0, whereIndex - 1) + whereQuery;
        //    }
        //    this.Adapter.SelectCommand = this.CommandCollection[0];
        //    if ((this.ClearBeforeFill == true))
        //    {
        //        dataTable.Clear();
        //    }
        //    int returnValue = this.Adapter.Fill(dataTable);
        //    return returnValue;
        //}

        //public virtual int FillByQuery(AssetMngDbDataSet.SubDepartmentVwDataTable dataTable, string whereQuery)
        //{
        //    int whereIndex = this.CommandCollection[0].CommandText.IndexOf("WHERE ", 0);
        //    if (whereIndex == -1)
        //    {
        //        this.CommandCollection[0].CommandText += whereQuery;
        //    }
        //    else
        //    {
        //        this.CommandCollection[0].CommandText = this.CommandCollection[0].CommandText.Substring(0, whereIndex - 1) + whereQuery;
        //    }
        //    this.Adapter.SelectCommand = this.CommandCollection[0];
        //    if ((this.ClearBeforeFill == true))
        //    {
        //        dataTable.Clear();
        //    }
        //    int returnValue = this.Adapter.Fill(dataTable);
        //    return returnValue;
        //}
        #endregion

        #region Assets
        public static IQueryable<AssetTbl> GetAssetsToDestruct()
        {
            ExecuteProcedure("dbo.CalcAssetsLifeSpanSp");
            mainDbContext.Refresh(RefreshMode.KeepChanges, mainDbContext.AssetTbls);
            var availableAssets = mainDbContext.AssetVws;
            IQueryable<AssetTbl> res = mainDbContext.AssetTbls.Where(ast => availableAssets.Select(asv1 => asv1.معرف_الأصل).ToList().Contains(ast.ID) && ast.LifeSpanInMonths > 0 && ast.LifeSpanInMonths <= appOptions.AssetLifeSpanThresholdToWarn).Select(ast1 => ast1);
            return res;
        }

        public static IQueryable<AssetTbl> GetDestructedWithoutTransactionAssets()
        {
            ExecuteProcedure("dbo.CalcAssetsLifeSpanSp");
            mainDbContext.Refresh(RefreshMode.KeepChanges, mainDbContext.AssetTbls);
            var availableAssets = mainDbContext.AssetVws;
            IQueryable<AssetTbl> res = mainDbContext.AssetTbls.Where(ast => availableAssets.Select(asv1 => asv1.معرف_الأصل).ToList().Contains(ast.ID) && ast.LifeSpanInMonths <= 0 && StaticCode.mainDbContext.AssetTransactionTbls.Count(astt2 => astt2.TransactionType == StaticCode.mainDbContext.TransactionTypeTbls.Where(tt1 => tt1.TransactionTypeName == "إهلاك").First().ID && astt2.AssetID == ast.ID) == 0).Select(ast1 => ast1);
            return res;
        }

        public static string GetTheNewAssetCode()
        {
            string currUserPrefix = activeUser.UserPrefix;
            var currUserAssets = mainDbContext.AssetTbls.Where(ast1 => ast1.AssetCode.Contains(currUserPrefix + "-"));
            if (currUserAssets == null || currUserAssets.Count() == 0)
                return ($"{currUserPrefix}-0000001");
            string maxAssetCodeForCurrUser = currUserAssets.Max(ast2 => ast2.AssetCode);
            int maxAssetIDForCurrUser = 1;
            try
            {
                maxAssetIDForCurrUser = Convert.ToInt32(maxAssetCodeForCurrUser.Replace(currUserPrefix + "-", "")) + 1;
            }
            catch
            {
                maxAssetIDForCurrUser = 1;
            }
            string maxAssetIDForCurrUser_Str = maxAssetIDForCurrUser.ToString();
            return ($"{currUserPrefix}-{maxAssetIDForCurrUser_Str.PadLeft(7, '0')}");
        }

        public static double CalcActualPriceForAsset(AssetTbl ast)
        {
            if (ast.PurchaseDate == null || ast.PurchasePrice == null)
                return 0;
            DateTime purchaseDate = Convert.ToDateTime(ast.PurchaseDate);
            int monthsDiff = (DateTime.Today.Year * 12 + DateTime.Today.Month) - (purchaseDate.Year * 12 + purchaseDate.Month);
            int yearsDiff = monthsDiff / 12;
            double destRate = yearsDiff * mainDbContext.MinorCategoryTbls.Single(mica1 => mica1.ID == ast.AssetMinorCategory).DestructionRate;
            double calcPrice = Convert.ToDouble(ast.PurchasePrice) * (1 - destRate);
            return calcPrice;
        }
        #endregion

        #region Login
        public static UserTbl activeUser { get; set; }
        public static UserRoleTbl activeUserRole { get; set; }
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

            List<string> tblsToImport = new List<string>() { "AssetTbl", "FinancialItemTbl", "AssetMovementTbl", "AssetTransactionTbl" };
            List<string> keyFields = new List<string>() { "AssetCode", "FinancialItemCode", "AssetMovementUniqueKey", "AssetTransactionUniqueKey" };

            ExcelPackage srcExcelEp = new ExcelPackage(new FileInfo(excelFilePath));
            ExcelWorkbook srcExcelWb = srcExcelEp.Workbook;
            foreach (string oneTable in tblsToImport)
            {
                Application.DoEvents();
                if (srcExcelWb.Worksheets.Count(sh1 => sh1.Name == oneTable) == 0)
                    continue;
                ExcelWorksheet oneSh = srcExcelWb.Worksheets.Where(sh1 => sh1.Name == oneTable).First();
                try
                {
                    string currKeyField = keyFields[tblsToImport.IndexOf(oneTable)];
                    List<string> tblFields = oneSh.Cells.Where(cl1 => cl1.End.Row == 1 && cl1.Start.Row == 1 && cl1.End.Column <= oneSh.Dimension.End.Column).Select(cl2 => cl2.Value?.ToString()).ToList();
                    int keyIndex = tblFields.IndexOf(currKeyField) + 1;
                    for (int iRow = 2; iRow <= oneSh.Dimension.End.Row; iRow++)
                    {
                        Application.DoEvents();
                        string oneKeyValue = oneSh.Cells[iRow, keyIndex].Value?.ToString();
                        string sqlQry = $"SELECT * FROM {oneTable} where {currKeyField} = N'{oneKeyValue}'";
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.CommandText = sqlQry;
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
                                if (oneField.ToUpper().Contains("DATE") || (oneField.Length > 4 && oneField.ToUpper().Substring(oneField.Length - 4) == "EDON") || (oneField.Length > 4 && oneField.ToUpper().Substring(oneField.Length - 4) == "DEON"))
                                {
                                    DateTime fieldAsDate = new DateTime(1899, 12, 30).AddDays(Convert.ToInt32(oneVal));
                                    fieldsValuesPairs += $"{oneField} = N'{fieldAsDate.ToString("yyyy-MM-dd")}', ";
                                }
                                else
                                {
                                    fieldsValuesPairs += $"{oneField} = N'{oneVal}', ";
                                }
                            }
                            fieldsValuesPairs = fieldsValuesPairs.Trim().Trim(',');
                            string updateQry = $"UPDATE {oneTable} SET {fieldsValuesPairs} WHERE {currKeyField} = N'{oneKeyValue}';";
                            sqlcomm.CommandText = updateQry;
                        }
                        else
                        {
                            string fieldsPairs = "";
                            string valuesPairs = "";

                            for (int iCol = 2; iCol <= oneSh.Dimension.End.Column; iCol++)
                            {
                                string oneField = oneSh.Cells[1, iCol].Value?.ToString();
                                string oneVal = oneSh.Cells[iRow, iCol].Value?.ToString();
                                fieldsPairs += $"{oneField}, ";
                                if (oneField.ToUpper().Contains("DATE") || (oneField.Length > 4 && oneField.ToUpper().Substring(oneField.Length - 4) == "EDON") || (oneField.Length > 4 && oneField.ToUpper().Substring(oneField.Length - 4) == "DEON"))
                                {
                                    DateTime fieldAsDate = new DateTime(1899, 12, 30).AddDays(Convert.ToInt32(oneVal));
                                    valuesPairs += $"N'{fieldAsDate.ToString("yyyy-MM-dd")}', ";
                                }
                                else
                                {
                                    valuesPairs += $"N'{oneVal}', ";
                                }
                            }
                            fieldsPairs = fieldsPairs.Trim().Trim(',');
                            valuesPairs = valuesPairs.Trim().Trim(',');
                            string updateQry = $"INSERT INTO {oneTable}({fieldsPairs}) VALUES ({valuesPairs});";
                            sqlcomm.CommandText = updateQry;
                        }
                        sqlcomm.ExecuteNonQuery();
                    }
                }
                catch
                {
                    continue;
                }
            }

            string qryAfter = "ENABLE TRIGGER SetDateAndUser_Asset on AssetTbl; ENABLE TRIGGER UpdateAssetLifeSpanandDestructionRate on AssetTbl;";
            sqlcomm.CommandText = qryAfter;
            sqlcomm.ExecuteNonQuery();
        }

        public static List<string> ImportAssetsFromExcel_Old(string assetsFilePath, int formNo, bool updateExistedAssets, out string errorMsg)
        {
            errorMsg = "";
            if (!File.Exists(assetsFilePath))
            {
                errorMsg = "مسار الملف غير صحيح";
                return null;
            }
            ExcelPackage srcExcelEp = new ExcelPackage(new FileInfo(assetsFilePath));
            ExcelWorkbook srcExcelWb = srcExcelEp.Workbook;
            ExcelWorksheet srcExcelWs = srcExcelWb.Worksheets.First();
            string sectionName = srcExcelWs.Cells[5, 5].Value?.ToString();
            string departmentName = srcExcelWs.Cells[5, (formNo == 3) ? 11 : 10].Value?.ToString();
            string subDepartmentName = srcExcelWs.Cells[5, (formNo == 3) ? 16 : 15].Value?.ToString();
            var existedSubDept = StaticCode.mainDbContext.SubDepartmentVws.Where(sdpt1 => sdpt1.اسم_الوحدة == subDepartmentName && sdpt1.القسم_التابعة_له == departmentName && sdpt1.الدائرة_التي_يتبع_لها_القسم == sectionName);
            if (existedSubDept == null || existedSubDept.Count() == 0)
            {
                errorMsg = "الدائرة والقسم والوحدة في ملف الإكسل غير موجودة أو غير تابعة لبعضها إدارياً";
                return null;
            }
            List<string> unknownMinorCategories = new List<string>();
            List<AssetTbl> importedAssets = new List<AssetTbl>();
            int rowStartNo = 8;
            try
            {
                int formShift = 0;
                if (formNo == 2)
                    formShift = 4;
                if (formNo == 3)
                    formShift = 7;
                string currMainCategoryName = "";
                while (rowStartNo <= srcExcelWs.Dimension.End.Row)
                {
                    currMainCategoryName = srcExcelWs.Cells[rowStartNo, 3].Value?.ToString();
                    rowStartNo++;
                    while (srcExcelWs.Cells[rowStartNo, 5].Value != null && srcExcelWs.Cells[rowStartNo, 5].Value?.ToString() != "")
                    {
                        Application.DoEvents();

                        string currMinorCategoryName = srcExcelWs.Cells[rowStartNo, 4].Value?.ToString().Split(':')[0].ToString();
                        var existedMiCa = StaticCode.mainDbContext.MinorCategoryVws.Where(mc1 => mc1.اسم_الفئة_الرئيسية == currMainCategoryName && mc1.اسم_الفئة_الفرعية == currMinorCategoryName);
                        if (existedMiCa.Count() != 1)
                        {
                            unknownMinorCategories.Add($"{unknownMinorCategories.Count() + 1}- الفئة الرئيسية: {currMainCategoryName}، الفئة الفرعية: {currMinorCategoryName}");
                        }
                        else
                        {
                            string astCode = srcExcelWs.Cells[rowStartNo, 3].Value?.ToString();
                            AssetTbl newAsset = new AssetTbl();
                            if (StaticCode.mainDbContext.AssetTbls.Any(ast1 => ast1.AssetCode == astCode))
                            {
                                if (!updateExistedAssets)
                                    continue;
                                newAsset = StaticCode.mainDbContext.AssetTbls.Single(ast2 => ast2.AssetCode == astCode);
                            }
                            else
                            {
                                importedAssets.Add(newAsset);
                            }
                            newAsset.AssetCode = srcExcelWs.Cells[rowStartNo, 3].Value?.ToString();
                            newAsset.AssetMinorCategory = existedMiCa.First().معرف_الفئة_الفرعية;
                            newAsset.AssetSpecifications = srcExcelWs.Cells[rowStartNo, 4].Value?.ToString().Substring(srcExcelWs.Cells[rowStartNo, 4].Value.ToString().IndexOf(':') + 1);
                            newAsset.AssetSubDepartment = existedSubDept.First().معرف_الوحدة;
                            newAsset.ItemsQuantity = Convert.ToInt32(srcExcelWs.Cells[rowStartNo, 5].Value);
                            newAsset.IsOldOrNewAsset = "قديم";
                            newAsset.CustodianName = srcExcelWs.Cells[rowStartNo, 14 + formShift].Value?.ToString();
                            newAsset.EstateArea = "";
                            newAsset.EstateAreaUnit = 1;
                            newAsset.CurrentStatus = StaticCode.mainDbContext.StatusTbls.Single(st1 => st1.StatusName == srcExcelWs.Cells[rowStartNo, 11 + formShift].Value.ToString()).ID;
                            newAsset.DestructionRate = existedMiCa.First().معدل_الإهلاك;
                            newAsset.LifeSpanInMonths = 0;
                            newAsset.PlaceOfPresence = srcExcelWs.Cells[rowStartNo, 8 + formShift].Value?.ToString();
                            newAsset.AssetSquare = StaticCode.mainDbContext.SquareTbls.Single(sq1 => sq1.SquareName == srcExcelWs.Cells[rowStartNo, 9 + formShift].Value.ToString()).ID;
                            newAsset.BenefitPercentage = srcExcelWs.Cells[rowStartNo, 12 + formShift].Value?.ToString();
                            newAsset.MoreDetails = srcExcelWs.Cells[rowStartNo, 15 + formShift].Value?.ToString();
                            newAsset.AssetNotes = srcExcelWs.Cells[rowStartNo, 20 + formShift].Value?.ToString();
                            newAsset.Model = (formNo == 3) ? srcExcelWs.Cells[rowStartNo, 6].Value?.ToString() : "";
                            newAsset.Color = (formNo == 3) ? srcExcelWs.Cells[rowStartNo, 8].Value?.ToString() : "";
                            newAsset.Volume = "";
                            newAsset.OfUsed = (formNo == 2) ? srcExcelWs.Cells[rowStartNo, 8].Value?.ToString() : "";
                            newAsset.CarChassisNumber = (formNo == 3) ? srcExcelWs.Cells[rowStartNo, 10].Value?.ToString() : "";
                            newAsset.CarEngineNumber = (formNo == 3) ? srcExcelWs.Cells[rowStartNo, 11].Value?.ToString() : "";
                            newAsset.CarPanelNumber = (formNo == 3) ? srcExcelWs.Cells[rowStartNo, 7].Value?.ToString() : "";
                            newAsset.CarManufacturingYear = (formNo == 3) ? Convert.ToInt32(srcExcelWs.Cells[rowStartNo, 9].Value?.ToString()) : 0;
                            newAsset.EstateAddress = (formNo == 2) ? srcExcelWs.Cells[rowStartNo, 7].Value?.ToString() : "";
                            newAsset.EstateOwnershipDocumentWith = (formNo == 2) ? srcExcelWs.Cells[rowStartNo, 9].Value?.ToString() : "";
                            newAsset.OwnerName = (formNo == 3) ? srcExcelWs.Cells[rowStartNo, 12].Value?.ToString() : ((formNo == 2) ? srcExcelWs.Cells[rowStartNo, 6].Value?.ToString() : "");
                            newAsset.IsSold = false;
                            newAsset.IsOutOfWork = false;
                            if (srcExcelWs.Cells[rowStartNo, 6 + formShift].Value != null)
                            {
                                newAsset.PurchaseDate = Convert.ToDateTime(srcExcelWs.Cells[rowStartNo, 6 + formShift].Value);
                            }
                            if (srcExcelWs.Cells[rowStartNo, 7 + formShift].Value != null)
                            {
                                string strVal = srcExcelWs.Cells[rowStartNo, 7 + formShift].Value?.ToString();
                                newAsset.PurchasePrice = Convert.ToDouble(strVal.Split(' ')[0]);
                                string purchaseCurr = strVal.Replace(newAsset.PurchasePrice.ToString(), "").Trim();
                                newAsset.PurchasePriceCurrency = StaticCode.mainDbContext.CurrencyTbls.Single(cu1 => cu1.CurrencyName == purchaseCurr).ID;
                                int monthsDiff = existedMiCa.First().العمر_الإنتاجي_بالسنوات * 12 - ((DateTime.Today.Year - Convert.ToDateTime(newAsset.PurchaseDate).Year) * 12 + (DateTime.Today.Month - Convert.ToDateTime(newAsset.PurchaseDate).Month));
                                newAsset.LifeSpanInMonths = monthsDiff;
                            }
                            if (srcExcelWs.Cells[rowStartNo, 13 + formShift].Value != null)
                            {
                                string strVal = srcExcelWs.Cells[rowStartNo, 13 + formShift].Value?.ToString();
                                newAsset.ActualCurrentPrice = Convert.ToDouble(strVal.Split(' ')[0]);
                                string activePriceCurr = strVal.Replace(newAsset.ActualCurrentPrice.ToString(), "").Trim();
                                newAsset.ActualCurrentPriceCurrency = StaticCode.mainDbContext.CurrencyTbls.Single(cu1 => cu1.CurrencyName == activePriceCurr).ID;
                            }
                        }
                        rowStartNo++;
                    }
                }
                StaticCode.mainDbContext.AssetTbls.InsertAllOnSubmit(importedAssets);
                StaticCode.mainDbContext.SubmitChanges();
            }
            catch (FormatException)
            {
                errorMsg = $"إحدى القيم في السطر {rowStartNo} ليست صحيحة";
                return null;
            }
            catch (NullReferenceException)
            {
                errorMsg = $"إحدى القيم في السطر {rowStartNo} فارغة";
                return null;
            }
            catch (Exception)
            {
                errorMsg = $"ملف الاستيراد غير صحيح";
                return null;
            }

            if (unknownMinorCategories.Count() > 0)
            {
                string tmp = "";
                foreach (string oneItem in unknownMinorCategories)
                {
                    tmp += oneItem + "\r\n";
                }
                errorMsg = $"هناك بعض الفئات الرئيسية والفرعية غير موجودة في الجداول وهي:\r\n{tmp}\r\n\r\nمن فضلك راجع مسؤول التطبيق لإضافتها";
            }
            return unknownMinorCategories;
        }

        public static string ImportAssetsFromExcel(string assetsFilePath, int formNo, bool updateExistedAssets, out string errorMsg)
        {
            AssetMngDbDataContext tmpMainDbContext = new AssetMngDbDataContext();
            errorMsg = "";
            if (!File.Exists(assetsFilePath))
            {
                errorMsg = "مسار الملف غير صحيح";
                tmpMainDbContext.Dispose();
                return null;
            }
            ExcelPackage srcExcelEp = new ExcelPackage(new FileInfo(assetsFilePath));
            ExcelWorkbook srcExcelWb = srcExcelEp.Workbook;
            ExcelWorksheet srcExcelWs = srcExcelWb.Worksheets.First();
            int headersRow = 7;
            int startRow = headersRow + 1;
            int assetCodeColumn = 3;
            int mainCatColumn = 4;
            int minorCatColumn = 5;
            int specColumn = 6;
            int qtyColumn = 7;
            int prchsDateColumn = 8;
            int prchsValColumn = 9;
            int prchsCurrColumn = 10;
            int actualPriceColumn = 11;
            int sqrColumn = 12;
            int presPlaceColumn = 13;
            int curStatusColumn = 14;
            int benefitPrctgColumn = 15;
            int cstdNameColumn = 16;
            int moreDetailsColumn = 17;
            int notesColumn = 22;

            int modelColumn = 8;
            int ownerNameColumn = (formNo == 2) ? 8 : 14;
            int estateAddress = 9;
            int carPanelNumberAddress = 9;

            int colorColumn = 10;
            int ofUsedColumn = 10;
            int manuYearColumn = 11;
            int estateOwWithColumn = 11;
            int carChasColumn = 12;
            int carEngineColumn = 13;

            List<string> assetsCodes = srcExcelWs.Cells.Where(cl1 => cl1.Start.Column == assetCodeColumn && cl1.End.Column == assetCodeColumn && cl1.Start.Row >= startRow).Select(cl2 => cl2.Value?.ToString()).ToList();
            List<string> newCodes = StaticCode.mainDbContext.AssetTbls.Where(ast1 => !assetsCodes.Contains(ast1.AssetCode)).Select(ast2 => ast2.AssetCode).ToList();
            List<string> existedCodes = StaticCode.mainDbContext.AssetTbls.Where(ast1 => assetsCodes.Contains(ast1.AssetCode)).Select(ast2 => ast2.AssetCode).ToList();
            int existedAssetsCount = existedCodes.Count();
            int newAssetsCount = assetsCodes.Count() - existedAssetsCount;

            string sectionName = srcExcelWs.Cells[5, 5].Value?.ToString().Replace("الدائرة:", "").Trim();
            string departmentName = srcExcelWs.Cells[5, (formNo == 3) ? 11 : 10].Value?.ToString().Trim();
            string subDepartmentName = srcExcelWs.Cells[5, (formNo == 3) ? 16 : 15].Value?.ToString().Trim();
            int sctID = 0;
            if (!StaticCode.mainDbContext.SectionTbls.Any(sct1 => sct1.SectionName == sectionName))
            {
                errorMsg = "الدائرة المضمنة في ملف الإكسل غير موجودة في سجلات الدوائر"
                    ;
                tmpMainDbContext.Dispose();
                return null;
            }
            else
            {
                sctID = StaticCode.mainDbContext.SectionTbls.Where(sct1 => sct1.SectionName == sectionName).First().ID;
            }
            int dptID = 0;
            if (!StaticCode.mainDbContext.DepartmentVws.Any(dpt1 => dpt1.اسم_القسم == departmentName && dpt1.الدائرة_التي_يتبع_لها_القسم == sectionName))
            {
                if (StaticCode.activeUserRole.IsSectionIndependent != true)
                {
                    errorMsg = "القسم المضمن في ملف الإكسل غير موجودة في سجلات الأقسام أو لا يتبع للدائرة المضمنة في ملف الإكسل ذاته";
                    tmpMainDbContext.Dispose();
                    return null;
                }
            }
            else
            {
                dptID = StaticCode.mainDbContext.DepartmentVws.Where(dpt1 => dpt1.اسم_القسم == departmentName && dpt1.الدائرة_التي_يتبع_لها_القسم == sectionName).First().معرف_القسم;
            }
            var existedSubDept = StaticCode.mainDbContext.SubDepartmentVws.Where(fiv1 => fiv1.اسم_الوحدة == subDepartmentName && fiv1.القسم_التابعة_له == departmentName && fiv1.الدائرة_التي_يتبع_لها_القسم == sectionName);
            int assetSubD = 0;
            if (existedSubDept == null || existedSubDept.Count() == 0)
            {
                if (StaticCode.activeUserRole.IsSectionIndependent != true && StaticCode.activeUserRole.IsDepartmentIndependent != true)
                {
                    errorMsg = "الوحدة المضمنة في ملف الإكسل غير موجودة في سجلات الوحدات أو لا تتبع للقسم والدائرة المضمنين في ملف الإكسل ذاته";
                    tmpMainDbContext.Dispose();
                    return null;
                }
            }
            else
            {
                assetSubD = existedSubDept.First().معرف_الوحدة;
            }
            if (String.IsNullOrEmpty(departmentName))
            {
                if (StaticCode.activeUserRole.IsDepartmentIndependent == true)
                {
                    var qry_PM = StaticCode.mainDbContext.SubDepartmentVws.Where(sdptv1 => sdptv1.اسم_الوحدة == ("إدارة " + sectionName) && sdptv1.القسم_التابعة_له == ("إدارة " + sectionName) && sdptv1.الدائرة_التي_يتبع_لها_القسم == sectionName);
                    if (qry_PM == null || qry_PM.Count() == 0)
                    {
                        DepartmentTbl newPM_Dpt = new DepartmentTbl() { DepartmentName = ("إدارة " + sectionName), SectionOfDepartment = sctID };
                        StaticCode.mainDbContext.DepartmentTbls.InsertOnSubmit(newPM_Dpt);
                        StaticCode.mainDbContext.SubmitChanges();
                        SubDepartmentTbl newPM_SDpt = new SubDepartmentTbl() { SubDepartmentName = ("إدارة " + sectionName), MainDepartment = newPM_Dpt.ID };
                        StaticCode.mainDbContext.SubDepartmentTbls.InsertOnSubmit(newPM_SDpt);
                        StaticCode.mainDbContext.SubmitChanges();
                        assetSubD = newPM_SDpt.ID;
                    }
                    else
                    {
                        assetSubD = qry_PM.First().معرف_الوحدة;
                    }
                }
            }
            else if (String.IsNullOrEmpty(subDepartmentName))
            {
                var qry_PM = StaticCode.mainDbContext.SubDepartmentVws.Where(sdptv1 => sdptv1.اسم_الوحدة == ("إدارة " + departmentName) && sdptv1.القسم_التابعة_له == departmentName && sdptv1.الدائرة_التي_يتبع_لها_القسم == sectionName);
                if (qry_PM == null || qry_PM.Count() == 0)
                {
                    SubDepartmentTbl newPM_SDpt = new SubDepartmentTbl() { SubDepartmentName = ("إدارة " + departmentName), MainDepartment = dptID };
                    StaticCode.mainDbContext.SubDepartmentTbls.InsertOnSubmit(newPM_SDpt);
                    StaticCode.mainDbContext.SubmitChanges();
                    assetSubD = newPM_SDpt.ID;
                }
                else
                {
                    assetSubD = qry_PM.First().معرف_الوحدة;
                }
            }
            List<string> unknownMinorCategories = new List<string>();
            List<AssetTbl> importedAssets = new List<AssetTbl>();
            int rowStartNo = 8;
            int formShift = 0;
            if (formNo == 2)
                formShift = 4;
            if (formNo == 3)
                formShift = 7;
            while (rowStartNo <= srcExcelWs.Dimension.End.Row)
            {
                Application.DoEvents();

                try
                {
                    string astCode = srcExcelWs.Cells[rowStartNo, 3].Value?.ToString();
                    AssetTbl newAsset = new AssetTbl();
                    newAsset.IsOldOrNewAsset = "قديم";
                    newAsset.EstateArea = "";
                    newAsset.EstateAreaUnit = 1;
                    newAsset.LifeSpanInMonths = 0;
                    newAsset.IsSold = false;
                    newAsset.IsOutOfWork = false;
                    bool existedAsset = tmpMainDbContext.AssetTbls.Any(ast1 => ast1.AssetCode == astCode);
                    if (existedAsset)
                    {
                        if (!updateExistedAssets)
                        {
                            rowStartNo++;
                            continue;
                        }
                        newAsset = tmpMainDbContext.AssetTbls.Single(ast2 => ast2.AssetCode == astCode);
                        if (newAsset.AddingMethod == "Import/Excel")
                        {
                            rowStartNo++;
                            continue;
                        }
                    }
                    else
                    {
                        importedAssets.Add(newAsset);
                    }

                    string currMainCategoryName = srcExcelWs.Cells[rowStartNo, mainCatColumn].Value?.ToString().Trim();
                    string currMinorCategoryName = srcExcelWs.Cells[rowStartNo, minorCatColumn].Value?.ToString().Trim();
                    var existedMiCa = tmpMainDbContext.MinorCategoryVws.Where(cat1 => cat1.اسم_الفئة_الرئيسية == currMainCategoryName && cat1.اسم_الفئة_الفرعية == currMinorCategoryName);
                    if (existedMiCa == null || existedMiCa.Count() == 0)
                    {
                        unknownMinorCategories.Add($"{unknownMinorCategories.Count() + 1}- كود الأصل:  {srcExcelWs.Cells[rowStartNo, 3].Value?.ToString()}، الفئة الرئيسية: {currMainCategoryName}، الفئة الفرعية: {currMinorCategoryName}");
                        rowStartNo++;
                        continue;
                    }

                    newAsset.AssetCode = srcExcelWs.Cells[rowStartNo, assetCodeColumn].Value?.ToString().Trim();
                    newAsset.AssetMinorCategory = existedMiCa.First().معرف_الفئة_الفرعية;
                    newAsset.AssetSpecifications = srcExcelWs.Cells[rowStartNo, specColumn].Value?.ToString();
                    newAsset.AssetSubDepartment = assetSubD;
                    newAsset.ItemsQuantity = Convert.ToInt32(srcExcelWs.Cells[rowStartNo, qtyColumn].Value);

                    newAsset.Model = (formNo == 3) ? srcExcelWs.Cells[rowStartNo, modelColumn].Value?.ToString() : "";
                    newAsset.OwnerName = (formNo == 1) ? "" : srcExcelWs.Cells[rowStartNo, ownerNameColumn].Value?.ToString();
                    if (srcExcelWs.Cells[rowStartNo, prchsDateColumn + formShift].Value != null)
                    {
                        newAsset.PurchaseDate = Convert.ToDateTime(srcExcelWs.Cells[rowStartNo, prchsDateColumn + formShift].Value);
                        int monthsDiff = existedMiCa.First().العمر_الإنتاجي_بالسنوات * 12 - ((DateTime.Today.Year - Convert.ToDateTime(newAsset.PurchaseDate).Year) * 12 + (DateTime.Today.Month - Convert.ToDateTime(newAsset.PurchaseDate).Month));
                        newAsset.LifeSpanInMonths = monthsDiff;
                    }
                    newAsset.EstateAddress = (formNo == 2) ? srcExcelWs.Cells[rowStartNo, estateAddress].Value?.ToString() : "";
                    newAsset.CarPanelNumber = (formNo == 3) ? srcExcelWs.Cells[rowStartNo, carPanelNumberAddress].Value?.ToString() : "";
                    if (srcExcelWs.Cells[rowStartNo, prchsValColumn + formShift].Value != null)
                    {
                        double prchsPriceVal = 0;
                        if (!Double.TryParse(srcExcelWs.Cells[rowStartNo, prchsValColumn + formShift].Value?.ToString(), out prchsPriceVal))
                        {
                            errorMsg = $"قيمة شراء الأصل في السطر {rowStartNo} غير صحيحة";
                            tmpMainDbContext.Dispose();
                            return null;
                        }
                        newAsset.PurchasePrice = prchsPriceVal;
                        if (!tmpMainDbContext.CurrencyTbls.Any(cu1 => cu1.CurrencyName == srcExcelWs.Cells[rowStartNo, prchsCurrColumn + formShift].Value.ToString().Trim()))
                        {
                            errorMsg = $"عملة الشراء في السطر {rowStartNo} ليست صحيحة";
                            tmpMainDbContext.Dispose();
                            return null;
                        }
                        newAsset.PurchasePriceCurrency = tmpMainDbContext.CurrencyTbls.Single(cu1 => cu1.CurrencyName == srcExcelWs.Cells[rowStartNo, prchsCurrColumn + formShift].Value.ToString()).ID;
                    }
                    double actualPriceVal = 0;
                    if (!Double.TryParse(srcExcelWs.Cells[rowStartNo, actualPriceColumn + formShift].Value?.ToString(), out actualPriceVal))
                    {
                        errorMsg = $"قيمة السعر الفعلي الحالي في السطر {rowStartNo} غير صحيحة";
                        tmpMainDbContext.Dispose();
                        return null;
                    }
                    newAsset.ActualCurrentPrice = actualPriceVal;
                    newAsset.ActualCurrentPriceCurrency = newAsset.PurchasePriceCurrency;
                    newAsset.Color = (formNo == 3) ? srcExcelWs.Cells[rowStartNo, colorColumn].Value?.ToString() : "";
                    newAsset.Volume = "";
                    newAsset.OfUsed = (formNo == 2) ? srcExcelWs.Cells[rowStartNo, ofUsedColumn].Value?.ToString() : "";
                    newAsset.CarManufacturingYear = (formNo == 3) ? Convert.ToInt32(srcExcelWs.Cells[rowStartNo, manuYearColumn].Value?.ToString()) : 0;
                    newAsset.EstateOwnershipDocumentWith = (formNo == 2) ? srcExcelWs.Cells[rowStartNo, estateOwWithColumn].Value?.ToString() : "";
                    newAsset.CarChassisNumber = (formNo == 3) ? srcExcelWs.Cells[rowStartNo, carChasColumn].Value?.ToString() : "";
                    newAsset.CarEngineNumber = (formNo == 3) ? srcExcelWs.Cells[rowStartNo, carEngineColumn].Value?.ToString() : "";
                    if (!tmpMainDbContext.SquareTbls.Any(sq1 => sq1.SquareName == srcExcelWs.Cells[rowStartNo, sqrColumn + formShift].Value.ToString().Trim()))
                    {
                        errorMsg = $"اسم الساحة في السطر {rowStartNo} ليست صحيحة";
                        tmpMainDbContext.Dispose();
                        return null;
                    }
                    newAsset.AssetSquare = tmpMainDbContext.SquareTbls.Single(sq1 => sq1.SquareName == srcExcelWs.Cells[rowStartNo, sqrColumn + formShift].Value.ToString()).ID;
                    newAsset.PlaceOfPresence = srcExcelWs.Cells[rowStartNo, presPlaceColumn + formShift].Value?.ToString();
                    if (!tmpMainDbContext.StatusTbls.Any(st1 => st1.StatusName == srcExcelWs.Cells[rowStartNo, curStatusColumn + formShift].Value.ToString().Trim()))
                    {
                        errorMsg = $"حالة الأصل في السطر {rowStartNo} ليست صحيحة";
                        tmpMainDbContext.Dispose();
                        return null;
                    }
                    newAsset.CurrentStatus = tmpMainDbContext.StatusTbls.Single(st1 => st1.StatusName == srcExcelWs.Cells[rowStartNo, curStatusColumn + formShift].Value.ToString().Trim()).ID;

                    newAsset.BenefitPercentage = srcExcelWs.Cells[rowStartNo, benefitPrctgColumn + formShift].Value?.ToString();
                    newAsset.CustodianName = srcExcelWs.Cells[rowStartNo, cstdNameColumn + formShift].Value?.ToString();
                    newAsset.DestructionRate = existedMiCa.First().معدل_الإهلاك;
                    newAsset.MoreDetails = srcExcelWs.Cells[rowStartNo, moreDetailsColumn + formShift].Value?.ToString();
                    newAsset.AssetNotes = srcExcelWs.Cells[rowStartNo, notesColumn + formShift].Value?.ToString();
                    rowStartNo++;
                    if (!existedAsset)
                    {
                        newAsset.AddingMethod = "Import/Excel";
                        tmpMainDbContext.AssetTbls.InsertOnSubmit(newAsset);
                    }
                }
                catch
                {
                    errorMsg = $"إحدى القيم في السطر {rowStartNo} ليست صحيحة";
                    tmpMainDbContext.Dispose();
                    return null;
                }
            }

            if (unknownMinorCategories.Count() > 0)
            {
                string tmp = "";
                foreach (string oneItem in unknownMinorCategories)
                {
                    tmp += oneItem + "\r\n";
                }
                errorMsg = $"هناك بعض الفئات الرئيسية والفرعية غير موجودة في الجداول أو لا تتبع لبعضها، وهي:\r\n{tmp}\r\n\r\nمن فضلك راجع مسؤول التطبيق لإضافتها أو تعديلها";
                tmpMainDbContext.Dispose();
                return null;
            }
            string newCodesStr = "";
            foreach (string oneN in newCodes)
                newCodesStr += oneN + " , ";
            newCodesStr = newCodesStr.Trim().Trim(',').Trim();
            string existedCodesStr = "";
            foreach (string oneN in existedCodes)
                existedCodesStr += oneN + " , ";
            existedCodesStr = existedCodesStr.Trim().Trim(',').Trim();
            string importNotes = $"1- الأصول المضافة({newAssetsCount}):\r\n{newCodesStr}\r\n2- الأصول التي تم تعديلها({((updateExistedAssets) ? existedAssetsCount : 0)}):\r\n{((updateExistedAssets) ? existedCodesStr : "(لا يوجد)")}";
            ImportExportTbl newImport = new ImportExportTbl()
            {
                ActionDate = DateTime.Today.AddDays(StaticCode.appOptions.ShiftDays),
                ImportOrExport = "استيراد",
                ActionBySection = sectionName,
                ActionByDepartment = departmentName,
                ActionBySubDepartment = subDepartmentName,
                TablesExported = "أصول - النموذج العام",
                ActionNotes = importNotes,
            };
            tmpMainDbContext.ImportExportTbls.InsertOnSubmit(newImport);
            tmpMainDbContext.SubmitChanges();
            return "Done!";
        }

        public static string ImportFinancialItemsFromExcel(string fiItsFilePath)
        {
            if (!File.Exists(fiItsFilePath))
            {
                return ("مسار الملف غير صحيح");
            }
            ExcelPackage srcExcelEp = new ExcelPackage(new FileInfo(fiItsFilePath));
            ExcelWorkbook srcExcelWb = srcExcelEp.Workbook;
            ExcelWorksheet srcExcelWs = srcExcelWb.Worksheets.First();
            string sectionName = srcExcelWs.Cells[2, 1].Value?.ToString().Replace("الدائرة:", "").Trim();
            string departmentName = srcExcelWs.Cells[2, 4].Value?.ToString().Replace("القسم:", "").Trim();
            string subDepartmentName = srcExcelWs.Cells[2, 7].Value?.ToString().Replace("الوحدة:", "").Trim();
            int sctID = 0;
            if (!StaticCode.mainDbContext.SectionTbls.Any(sct1 => sct1.SectionName == sectionName))
            {
                return ("الدائرة المضمنة في ملف الإكسل غير موجودة في سجلات الدوائر"
                    );
            }
            else
            {
                sctID = StaticCode.mainDbContext.SectionTbls.Where(sct1 => sct1.SectionName == sectionName).First().ID;
            }
            int dptID = 0;
            if (!StaticCode.mainDbContext.DepartmentVws.Any(dpt1 => dpt1.اسم_القسم == departmentName && dpt1.الدائرة_التي_يتبع_لها_القسم == sectionName))
            {
                if (StaticCode.activeUserRole.IsSectionIndependent != true)
                {
                    return ("القسم المضمن في ملف الإكسل غير موجودة في سجلات الأقسام أو لا يتبع للدائرة المضمنة في ملف الإكسل ذاته");
                }
            }
            else
            {
                dptID = StaticCode.mainDbContext.DepartmentVws.Where(dpt1 => dpt1.اسم_القسم == departmentName && dpt1.الدائرة_التي_يتبع_لها_القسم == sectionName).First().معرف_القسم;
            }
            var existedSubDept = StaticCode.mainDbContext.SubDepartmentVws.Where(fiv1 => fiv1.اسم_الوحدة == subDepartmentName && fiv1.القسم_التابعة_له == departmentName && fiv1.الدائرة_التي_يتبع_لها_القسم == sectionName);
            int assetSubD = 0;
            if (existedSubDept == null || existedSubDept.Count() == 0)
            {
                if (StaticCode.activeUserRole.IsSectionIndependent != true && StaticCode.activeUserRole.IsDepartmentIndependent != true)
                {
                    return ("الوحدة المضمنة في ملف الإكسل غير موجودة في سجلات الوحدات أو لا تتبع للقسم والدائرة المضمنين في ملف الإكسل ذاته");
                }
            }
            else
            {
                assetSubD = existedSubDept.First().معرف_الوحدة;
            }
            if (String.IsNullOrEmpty(departmentName))
            {
                if (StaticCode.activeUserRole.IsDepartmentIndependent == true)
                {
                    var qry_PM = StaticCode.mainDbContext.SubDepartmentVws.Where(sdptv1 => sdptv1.اسم_الوحدة == ("إدارة " + sectionName) && sdptv1.القسم_التابعة_له == ("إدارة " + sectionName) && sdptv1.الدائرة_التي_يتبع_لها_القسم == sectionName);
                    if (qry_PM == null || qry_PM.Count() == 0)
                    {
                        DepartmentTbl newPM_Dpt = new DepartmentTbl() { DepartmentName = ("إدارة " + sectionName), SectionOfDepartment = sctID };
                        StaticCode.mainDbContext.DepartmentTbls.InsertOnSubmit(newPM_Dpt);
                        StaticCode.mainDbContext.SubmitChanges();
                        SubDepartmentTbl newPM_SDpt = new SubDepartmentTbl() { SubDepartmentName = ("إدارة " + sectionName), MainDepartment = newPM_Dpt.ID };
                        StaticCode.mainDbContext.SubDepartmentTbls.InsertOnSubmit(newPM_SDpt);
                        StaticCode.mainDbContext.SubmitChanges();
                        assetSubD = newPM_SDpt.ID;
                    }
                    else
                    {
                        assetSubD = qry_PM.First().معرف_الوحدة;
                    }
                }
            }
            else if (String.IsNullOrEmpty(subDepartmentName))
            {
                var qry_PM = StaticCode.mainDbContext.SubDepartmentVws.Where(sdptv1 => sdptv1.اسم_الوحدة == ("إدارة " + departmentName) && sdptv1.القسم_التابعة_له == departmentName && sdptv1.الدائرة_التي_يتبع_لها_القسم == sectionName);
                if (qry_PM == null || qry_PM.Count() == 0)
                {
                    SubDepartmentTbl newPM_SDpt = new SubDepartmentTbl() { SubDepartmentName = ("إدارة " + departmentName), MainDepartment = dptID };
                    StaticCode.mainDbContext.SubDepartmentTbls.InsertOnSubmit(newPM_SDpt);
                    StaticCode.mainDbContext.SubmitChanges();
                    assetSubD = newPM_SDpt.ID;
                }
                else
                {
                    assetSubD = qry_PM.First().معرف_الوحدة;
                }
            }

            List<string> unknownMinorCategories = new List<string>();
            List<FinancialItemTbl> importedAssets = new List<FinancialItemTbl>();
            try
            {
                int rowStartNo = 5;
                bool isIncoming = true;
                while (rowStartNo <= srcExcelWs.Dimension.End.Row && srcExcelWs.Cells[rowStartNo, 7].Value?.ToString().Replace("ـ", "") != "الإجمالي")
                {
                    Application.DoEvents();

                    if (srcExcelWs.Cells[rowStartNo, 1].Value?.ToString() == "ثانياً : المصاريف :")
                    {
                        isIncoming = false;
                        rowStartNo++;
                    }
                    string curVal = srcExcelWs.Cells[rowStartNo, 3].Value?.ToString().Trim();
                    string incomingFromVal = srcExcelWs.Cells[rowStartNo, 4].Value?.ToString().Trim();
                    string outgoingTypeVal = srcExcelWs.Cells[rowStartNo, 5].Value?.ToString().Trim();
                    string outgoingToVal = srcExcelWs.Cells[rowStartNo, 6].Value?.ToString().Trim();
                    string ficaVal = srcExcelWs.Cells[rowStartNo, 9].Value?.ToString().Trim();
                    double incomingAmountVal = 0;
                    if (isIncoming && !Double.TryParse(srcExcelWs.Cells[rowStartNo, 1].Value?.ToString(), out incomingAmountVal))
                    {
                        return ($"قيمة الوارد في السطر {rowStartNo} غير صحيحة");
                    }
                    double outgoingAmountVal = 0;
                    if (!isIncoming && !Double.TryParse(srcExcelWs.Cells[rowStartNo, 2].Value?.ToString(), out outgoingAmountVal))
                    {
                        if (String.IsNullOrEmpty(curVal) || String.IsNullOrEmpty(ficaVal))
                        {
                            rowStartNo++;
                            break;
                        }
                        else
                        {
                            return ($"قيمة الصادر في السطر {rowStartNo} غير صحيحة");
                        }
                    }
                    DateTime fiDateVal = DateTime.Today;
                    if (!isIncoming && !DateTime.TryParse(srcExcelWs.Cells[rowStartNo, 8].Value?.ToString(), out fiDateVal))
                    {
                        return ($"قيمة التاريخ في السطر {rowStartNo} غير صحيحة");
                    }

                    if (!StaticCode.mainDbContext.CurrencyTbls.Any(cu1 => cu1.CurrencyName == curVal))
                    {
                        if (String.IsNullOrEmpty(srcExcelWs.Cells[rowStartNo, 2].Value?.ToString()) && String.IsNullOrEmpty(srcExcelWs.Cells[rowStartNo, 8].Value?.ToString()) && String.IsNullOrEmpty(ficaVal))
                        {
                            rowStartNo++;
                            continue;
                        }
                        return ($"العملة في السطر {rowStartNo} غير موجودة في جداول العملات");
                    }
                    int currID = StaticCode.mainDbContext.CurrencyTbls.Where(cu1 => cu1.CurrencyName == curVal).First().ID;
                    if (!StaticCode.mainDbContext.FinancialItemCategoryTbls.Any(fica1 => fica1.FinancialItemCategoryName == ficaVal))
                    {
                        unknownMinorCategories.Add($"{unknownMinorCategories.Count() + 1}- البند المالي: {ficaVal}");
                        continue;
                        //return ($"البند المالي في السطر {rowStartNo} غير موجودة في جداول البنود المالية");
                    }
                    var existedFiItCat = StaticCode.mainDbContext.FinancialItemCategoryTbls.Where(fica1 => fica1.FinancialItemCategoryName == ficaVal);

                    if (ficaVal != null && ficaVal.Contains("مدور"))
                    {
                        rowStartNo++;
                        continue;
                    }
                    if (isIncoming)
                    {
                        if (incomingFromVal == "من المستوى الأعلى")
                        {
                            string levelName = "";
                            if (StaticCode.activeUserRole.IsSectionIndependent == true)
                                levelName = sectionName;
                            else if (StaticCode.activeUserRole.IsDepartmentIndependent == true)
                                levelName = departmentName;
                            else
                                levelName = subDepartmentName;

                            var similarRecord = StaticCode.mainDbContext.FinancialItemVws.Where(fiv1 => fiv1.المبلغ_الصادر == incomingAmountVal && fiv1.العملة == curVal && fiv1.وارد_أم_صادر == "وارد" && fiv1.نوع_الصادر == "صادرات معلقة" && fiv1.صادر_إلى == levelName && fiv1.تاريخ_تحرير_السجل > fiDateVal && fiv1.تاريخ_تحرير_السجل.Month == fiDateVal.Month && fiv1.تاريخ_تحرير_السجل.Year == fiDateVal.Year);
                            if (similarRecord.Any())
                            {
                                rowStartNo++;
                                continue;
                            }
                        }
                    }

                    FinancialItemTbl newFinancialItem = new FinancialItemTbl()
                    {
                        FinancialItemCategory = existedFiItCat.First().ID,
                        FinancialItemDescription = srcExcelWs.Cells[rowStartNo, 7].Value?.ToString(),
                        IncomingFrom = incomingFromVal,
                        OutgoingType = outgoingTypeVal,
                        OutgoingTo = outgoingToVal,
                        FinancialItemSubDept = assetSubD,
                        FinancialItemInsertionDate = fiDateVal,
                        FinancialItemCurrency = currID,
                        IncomingAmount = (isIncoming) ? incomingAmountVal : 0,
                        IncomingOrOutgoing = (isIncoming) ? "وارد" : "صادر",
                        OutgoingAmount = (isIncoming) ? 0 : outgoingAmountVal,
                        AdditionalNotes = "",
                    };
                    importedAssets.Add(newFinancialItem);
                    rowStartNo++;
                }
            }
            catch
            {
                return ("ملف غير صحيح، نحتاج لاستيراد بيانات من ملف قياسي للسجلات المالية وفق النموذج المعتمد");
            }

            if (unknownMinorCategories.Count() > 0)
            {
                string tmp = "";
                foreach (string oneItem in unknownMinorCategories)
                {
                    tmp += oneItem + "\r\n";
                }
                return ($"هناك بعض البنود المالية غير موجودة في الجداول وهي:\r\n{tmp}\r\n\r\nمن فضلك راجع مسؤول التطبيق لإضافتها");
            }
            StaticCode.mainDbContext.FinancialItemTbls.InsertAllOnSubmit(importedAssets);
            StaticCode.mainDbContext.SubmitChanges();
            return "Done!";
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
        public static string FinancialReportPath2 = $"{FinanceFolder}financial blank report2.xlsx";
        public static string SubLevelTotalsPath = $"{FinanceFolder}SubLevelTotalsForm.xlsx";
        public static string SubLevelTotalsOutPath = $"{FinanceFolder}التقرير المالي{DateTime.Today.ToString("yyyy-MM-dd")}.xlsx";

        public static List<double> GetCycledToMonth(IQueryable<FinancialItemTbl> fiQry, int newYear, int newMonth)
        {
            var fiQryCycled = fiQry.Where(fii5 => fii5.FinancialItemInsertionDate.AddMonths(1).Month == newMonth && fii5.FinancialItemInsertionDate.AddMonths(1).Year == newYear);

            double incomes = (fiQry.Count(fii1 => fii1.IncomingOrOutgoing == "وارد") == 0) ? 0 : fiQry.Where(fii1 => fii1.IncomingOrOutgoing == "وارد").Sum(fii2 => fii2.IncomingAmount);
            double outcomes = (fiQry.Count(fii1 => fii1.IncomingOrOutgoing == "صادر") == 0) ? 0 : fiQry.Where(fii1 => fii1.IncomingOrOutgoing == "صادر").Sum(fii2 => fii2.OutgoingAmount);
            double incomes2 = (fiQryCycled.Count(fii1 => fii1.IncomingOrOutgoing == "وارد") == 0) ? 0 : fiQryCycled.Where(fii1 => fii1.IncomingOrOutgoing == "وارد").Sum(fii2 => fii2.IncomingAmount);
            double outcomes2 = (fiQryCycled.Count(fii1 => fii1.IncomingOrOutgoing == "صادر") == 0) ? 0 : fiQryCycled.Where(fii1 => fii1.IncomingOrOutgoing == "صادر").Sum(fii2 => fii2.OutgoingAmount);
            double cycled = incomes2 - outcomes2;
            return new List<double>() { incomes, outcomes, cycled };
        }

        public static double CalcRecycledOfFinancialItems(IQueryable<FinancialItemVw> fivQry)
        {
            if (fivQry == null || fivQry.Count() == 0)
                return 0;
            DateTime today1 = DateTime.Today.AddDays(StaticCode.appOptions.ShiftDays);
            var incomingLastMonth = fivQry.Where(fiv1 => fiv1.وارد_أم_صادر == "وارد" && fiv1.تاريخ_تحرير_السجل.AddMonths(1).Month == today1.Month && fiv1.تاريخ_تحرير_السجل.AddMonths(1).Year == today1.Year);
            double incomingLastMonth_Am = (incomingLastMonth.Any()) ? incomingLastMonth.Sum(fiv11 => fiv11.المبلغ_الوارد) : 0;
            var outgoingLastMonth = fivQry.Where(fiv2 => fiv2.وارد_أم_صادر == "صادر" && fiv2.تاريخ_تحرير_السجل.AddMonths(1).Month == today1.Month && fiv2.تاريخ_تحرير_السجل.AddMonths(1).Year == today1.Year);
            double outgoingLastMonth_Am = (outgoingLastMonth.Any()) ? outgoingLastMonth.Sum(fiv11 => fiv11.المبلغ_الصادر) : 0;
            double recycled_Am = incomingLastMonth_Am - outgoingLastMonth_Am;
            return recycled_Am;
        }

        public static double CalcRecycledOfFinancialItems(IQueryable<FinancialItemTbl> fiitQry)
        {
            List<int> includedIDs = fiitQry.Select(fiit => fiit.ID).ToList();
            var fivQry = StaticCode.mainDbContext.FinancialItemVws.Where(fiv => includedIDs.Contains(fiv.معرف_السجل_المالي));
            return (CalcRecycledOfFinancialItems(fivQry));
        }
        #endregion
    }

    public static class Extensions
    {
        public static double CalcHeadRecycledOfFinancialItems(this IQueryable<FinancialItemVw> fivQry)
        {
            if (fivQry == null || fivQry.Count() == 0)
                return 0;
            DateTime today1 = DateTime.Today.AddDays(StaticCode.appOptions.ShiftDays);
            var incomingLastMonth = fivQry.Where(fiv1 => fiv1.وارد_أم_صادر == "وارد" /*&& fiv1.تاريخ_تحرير_السجل.AddMonths(1).Month == today1.Month && fiv1.تاريخ_تحرير_السجل.AddMonths(1).Year == today1.Year*/).OrderByDescending(fiv22 => fiv22.جهة_الإيراد);
            double incomingLastMonth_Am = (incomingLastMonth.Any()) ? incomingLastMonth.Sum(fiv11 => fiv11.المبلغ_الوارد) : 0;
            var outgoingLastMonth = fivQry.Where(fiv2 => fiv2.وارد_أم_صادر == "صادر" /*&& fiv2.تاريخ_تحرير_السجل.AddMonths(1).Month == today1.Month && fiv2.تاريخ_تحرير_السجل.AddMonths(1).Year == today1.Year*/).OrderByDescending(fiv22 => fiv22.نوع_الصادر);
            double outgoingLastMonth_Am = (outgoingLastMonth.Any()) ? outgoingLastMonth.Sum(fiv11 => fiv11.المبلغ_الصادر) : 0;
            double recycled_Am = incomingLastMonth_Am - outgoingLastMonth_Am;
            return recycled_Am;
        }

        public static double CalcHeadRecycledOfFinancialItems(this IQueryable<FinancialItemTbl> fiitQry)
        {
            List<int> includedIDs = fiitQry.Select(fiit => fiit.ID).ToList();
            var fivQry = StaticCode.mainDbContext.FinancialItemVws.Where(fiv => includedIDs.Contains(fiv.معرف_السجل_المالي));
            return (fivQry.CalcHeadRecycledOfFinancialItems());
        }

        public static double CalcWholeRecycledOfFinancialItems(this IQueryable<FinancialItemVw> fivQry)
        {
            if (fivQry == null || fivQry.Count() == 0)
                return 0;
            DateTime today1 = DateTime.Today.AddDays(StaticCode.appOptions.ShiftDays);
            var incoming_All = fivQry.Where(fiv1 => fiv1.وارد_أم_صادر == "وارد").OrderByDescending(fiv22 => fiv22.جهة_الإيراد);
            double incoming_All_Am = (incoming_All.Any()) ? incoming_All.Sum(fiv11 => fiv11.المبلغ_الوارد) : 0;
            var outgoing_Direct = fivQry.Where(fiv2 => fiv2.وارد_أم_صادر == "صادر" && fiv2.نوع_الصادر == "صادرات مباشرة").OrderByDescending(fiv22 => fiv22.نوع_الصادر);
            double outgoing_Direct_Am = (outgoing_Direct.Any()) ? outgoing_Direct.Sum(fiv11 => fiv11.المبلغ_الصادر) : 0;
            double recycled_Am = incoming_All_Am - outgoing_Direct_Am;
            return recycled_Am;
        }

        public static double CalcWholeRecycledOfFinancialItems(this IQueryable<FinancialItemTbl> fiitQry)
        {
            List<int> includedIDs = fiitQry.Select(fiit => fiit.ID).ToList();
            var fivQry = StaticCode.mainDbContext.FinancialItemVws.Where(fiv => includedIDs.Contains(fiv.معرف_السجل_المالي));
            return (fivQry.CalcWholeRecycledOfFinancialItems());
        }

        public static double CalcIncomingOfFinancialItems(this IQueryable<FinancialItemVw> fivQry)
        {
            if (!fivQry.Any() || !fivQry.Any(fivi => fivi.وارد_أم_صادر == "وارد"))
                return 0;
            return (fivQry.Where(fivi => fivi.وارد_أم_صادر == "وارد").OrderByDescending(fiv22 => fiv22.جهة_الإيراد).Sum(fivi2 => fivi2.المبلغ_الوارد));
        }

        public static double CalcIncomingOfFinancialItems(this IQueryable<FinancialItemTbl> fiitQry)
        {
            List<int> includedIDs = fiitQry.Select(fiit => fiit.ID).ToList();
            var fivQry = StaticCode.mainDbContext.FinancialItemVws.Where(fivi => includedIDs.Contains(fivi.معرف_السجل_المالي));
            return (fivQry.CalcIncomingOfFinancialItems());
        }

        public static double CalcOutgoingOfFinancialItems(this IQueryable<FinancialItemVw> fivQry)
        {
            if (!fivQry.Any() || !fivQry.Any(fivo => fivo.وارد_أم_صادر == "صادر"))
                return 0;
            return (fivQry.Where(fivo => fivo.وارد_أم_صادر == "صادر").OrderByDescending(fiv22 => fiv22.نوع_الصادر).Sum(fivo2 => fivo2.المبلغ_الصادر));
        }

        public static double CalcOutgoingOfFinancialItems(this IQueryable<FinancialItemTbl> fiitQry)
        {
            List<int> includedIDs = fiitQry.Select(fiit => fiit.ID).ToList();
            var fivQry = StaticCode.mainDbContext.FinancialItemVws.Where(fivo => includedIDs.Contains(fivo.معرف_السجل_المالي));
            return (fivQry.CalcOutgoingOfFinancialItems());
        }
    }
}