using AssetManagement.Properties;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newYear"></param>
        /// <param name="newMonth"></param>
        /// <param name="levelID"></param>
        /// <param name="levelRank">1 for sections, 2 for departments, and 3 for sub-departments</param>
        /// <returns></returns>
        public static List<double> GetCycledToMonth(IQueryable<FinancialItemTbl> fiQry, int newYear, int newMonth, int levelID, int levelRank)
        {
            DateTime firstDayInNewMonth = new DateTime(newYear, newMonth, 1);
            DateTime lastDayInOldMonth = firstDayInNewMonth.AddDays(-1);
            DateTime firstDayInOldMonth = new DateTime(lastDayInOldMonth.Year, lastDayInOldMonth.Month, 1);
            var fiQryCycled = fiQry.Where(fii5 => fii5.FinancialItemInsertionDate >= firstDayInOldMonth && fii5.FinancialItemInsertionDate <= lastDayInOldMonth);

            double incomes = (fiQry.Count(fii1 => fii1.IncomingOrOutgoing == "وارد") == 0) ? 0 : fiQry.Where(fii1 => fii1.IncomingOrOutgoing == "وارد").Sum(fii2 => fii2.IncomingAmount);
            double outcomes = (fiQry.Count(fii1 => fii1.IncomingOrOutgoing == "صادر") == 0) ? 0 : fiQry.Where(fii1 => fii1.IncomingOrOutgoing == "صادر").Sum(fii2 => fii2.OutgoingAmount);
            double incomes2 = (fiQryCycled.Count(fii1 => fii1.IncomingOrOutgoing == "وارد") == 0) ? 0 : fiQryCycled.Where(fii1 => fii1.IncomingOrOutgoing == "وارد").Sum(fii2 => fii2.IncomingAmount);
            double outcomes2 = (fiQryCycled.Count(fii1 => fii1.IncomingOrOutgoing == "صادر") == 0) ? 0 : fiQryCycled.Where(fii1 => fii1.IncomingOrOutgoing == "صادر").Sum(fii2 => fii2.OutgoingAmount);
            double cycled = incomes2 - outcomes2;
            return new List<double>() { incomes, outcomes, cycled };
        }
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
        #endregion

        #region Assets
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
                                if (oneField.ToUpper().Contains("DATE") || (oneField.Length > 4 && oneField.ToUpper().Substring(oneField.Length - 4) == "EDON"))
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
                                if (oneField.ToUpper().Contains("DATE") || (oneField.Length > 4 && oneField.ToUpper().Substring(oneField.Length - 4) == "EDON"))
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

        public static List<string> ImportAssetsFromExcel(string assetsFilePath, int formNo, out int errorCat)
        {
            errorCat = 0;
            if (!File.Exists(assetsFilePath))
            {
                errorCat = 1;
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
                errorCat = 2;
                return null;
            }
            List<string> unknownMinorCategories = new List<string>();
            List<AssetTbl> importedAssets = new List<AssetTbl>();
            try
            {
                int rowStartNo = 8;
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
                            AssetTbl newAsset = new AssetTbl()
                            {
                                AssetCode = srcExcelWs.Cells[rowStartNo, 3].Value?.ToString(),
                                AssetMinorCategory = existedMiCa.First().معرف_الفئة_الفرعية,
                                AssetSpecifications = srcExcelWs.Cells[rowStartNo, 4].Value?.ToString().Substring(srcExcelWs.Cells[rowStartNo, 4].Value.ToString().IndexOf(':') + 1),
                                AssetSubDepartment = existedSubDept.First().معرف_الوحدة,
                                ItemsQuantity = Convert.ToInt32(srcExcelWs.Cells[rowStartNo, 5].Value),
                                IsOldOrNewAsset = "قديم",
                                CustodianName = srcExcelWs.Cells[rowStartNo, 13 + formShift].Value?.ToString(),
                                EstateArea = "",
                                EstateAreaUnit = 1,
                                CurrentStatus = StaticCode.mainDbContext.StatusTbls.Single(st1 => st1.StatusName == srcExcelWs.Cells[rowStartNo, 10 + formShift].Value.ToString()).ID,
                                DestructionRate = existedMiCa.First().معدل_الإهلاك,
                                LifeSpanInMonths = 0,
                                PlaceOfPresence = srcExcelWs.Cells[rowStartNo, 8 + formShift].Value?.ToString(),
                                BenefitPercentage = srcExcelWs.Cells[rowStartNo, 11 + formShift].Value?.ToString(),
                                MoreDetails = srcExcelWs.Cells[rowStartNo, 14 + formShift].Value?.ToString(),
                                AssetNotes = srcExcelWs.Cells[rowStartNo, 19 + formShift].Value?.ToString(),
                                Model = (formNo == 6) ? srcExcelWs.Cells[rowStartNo, 10].Value?.ToString() : "",
                                Color = (formNo == 8) ? srcExcelWs.Cells[rowStartNo, 10].Value?.ToString() : "",
                                Volume = "",
                                OfUsed = (formNo == 2) ? srcExcelWs.Cells[rowStartNo, 8].Value?.ToString() : "",
                                CarChassisNumber = (formNo == 3) ? srcExcelWs.Cells[rowStartNo, 10].Value?.ToString() : "",
                                CarEngineNumber = (formNo == 3) ? srcExcelWs.Cells[rowStartNo, 11].Value?.ToString() : "",
                                CarPanelNumber = (formNo == 3) ? srcExcelWs.Cells[rowStartNo, 7].Value?.ToString() : "",
                                CarManufacturingYear = (formNo == 3) ? Convert.ToInt32(srcExcelWs.Cells[rowStartNo, 9].Value?.ToString()) : 0,
                                EstateAddress = (formNo == 2) ? srcExcelWs.Cells[rowStartNo, 7].Value?.ToString() : "",
                                EstateOwnershipDocumentWith = (formNo == 2) ? srcExcelWs.Cells[rowStartNo, 9].Value?.ToString() : "",
                                OwnerName = (formNo == 3) ? srcExcelWs.Cells[rowStartNo, 12].Value?.ToString() : ((formNo == 2) ? srcExcelWs.Cells[rowStartNo, 6].Value?.ToString() : ""),
                                AssetSquare = 1,
                                IsSold = false,
                                IsOutOfWork = false,
                            };
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
                            if (srcExcelWs.Cells[rowStartNo, 12 + formShift].Value != null)
                            {
                                string strVal = srcExcelWs.Cells[rowStartNo, 12 + formShift].Value?.ToString();
                                newAsset.ActualCurrentPrice = Convert.ToDouble(strVal.Split(' ')[0]);
                                string activePriceCurr = strVal.Replace(newAsset.ActualCurrentPrice.ToString(), "").Trim();
                                newAsset.ActualCurrentPriceCurrency = StaticCode.mainDbContext.CurrencyTbls.Single(cu1 => cu1.CurrencyName == activePriceCurr).ID;
                            }
                            importedAssets.Add(newAsset);
                        }
                        rowStartNo++;
                    }
                }
                StaticCode.mainDbContext.AssetTbls.InsertAllOnSubmit(importedAssets);
                StaticCode.mainDbContext.SubmitChanges();
            }
            catch
            {
                errorCat = 3;
                return null;
            }

            if (unknownMinorCategories.Count() > 0)
                errorCat = 4;
            return unknownMinorCategories;
        }

        public static List<string> ImportFinancialItemsFromExcel(string fiItsFilePath, out int errorCat)
        {
            errorCat = 0;
            if (!File.Exists(fiItsFilePath))
            {
                errorCat = 1;
                return null;
            }
            ExcelPackage srcExcelEp = new ExcelPackage(new FileInfo(fiItsFilePath));
            ExcelWorkbook srcExcelWb = srcExcelEp.Workbook;
            ExcelWorksheet srcExcelWs = srcExcelWb.Worksheets.First();
            string sectionName = srcExcelWs.Cells[2, 1].Value?.ToString().Replace("الدائرة:", "").Trim();
            string departmentName = srcExcelWs.Cells[2, 3].Value?.ToString().Replace("القسم:", "").Trim();
            string subDepartmentName = srcExcelWs.Cells[2, 4].Value?.ToString().Replace("الوحدة:", "").Trim();
            var existedSubDept = StaticCode.mainDbContext.SubDepartmentVws.Where(fiv1 => fiv1.اسم_الوحدة == subDepartmentName && fiv1.القسم_التابعة_له == departmentName && fiv1.الدائرة_التي_يتبع_لها_القسم == sectionName);
            if (existedSubDept == null || existedSubDept.Count() == 0)
            {
                errorCat = 2;
                return null;
            }
            List<string> unknownMinorCategories = new List<string>();
            List<FinancialItemTbl> importedAssets = new List<FinancialItemTbl>();
            try
            {
                int usdDollarCurrID = StaticCode.mainDbContext.CurrencyTbls.Where(cu1 => cu1.CurrencyName.Contains("دولار")).First().ID;
                int rowStartNo = 5;
                bool isIncoming = true;
                while (rowStartNo <= srcExcelWs.Dimension.End.Row)
                {
                    Application.DoEvents();

                    if (srcExcelWs.Cells[rowStartNo, 1].Value?.ToString() == "ثانياً : المصاريف :")
                    {
                        isIncoming = false;
                        rowStartNo++;
                    }
                    if (srcExcelWs.Cells[rowStartNo, 5].Value == null || srcExcelWs.Cells[rowStartNo, 5].Value?.ToString() == "")
                    {
                        rowStartNo++;
                        continue;
                    }
                    string fiItCatName = srcExcelWs.Cells[rowStartNo, 5].Value?.ToString().Split(':')[0].ToString();
                    var existedFiItCat = StaticCode.mainDbContext.FinancialItemCategoryTbls.Where(fica1 => fica1.FinancialItemCategoryName == fiItCatName);
                    if (existedFiItCat.Count() != 1)
                    {
                        unknownMinorCategories.Add($"{unknownMinorCategories.Count() + 1}- البند المالي: {fiItCatName}");
                    }
                    else
                    {
                        FinancialItemTbl newFinancialItem = new FinancialItemTbl()
                        {
                            FinancialItemCategory = existedFiItCat.First().ID,
                            FinancialItemDescription = srcExcelWs.Cells[rowStartNo, 3].Value?.ToString(),
                            FinancialItemSubDept = existedSubDept.First().معرف_الوحدة,
                            FinancialItemInsertionDate = Convert.ToDateTime(srcExcelWs.Cells[rowStartNo, 4].Value),
                            FinancialItemCurrency = usdDollarCurrID,
                            IncomingAmount = (isIncoming) ? Convert.ToDouble(srcExcelWs.Cells[rowStartNo, 1].Value) : 0,
                            IncomingOrOutgoing = (isIncoming) ? "وارد" : "صادر",
                            OutgoingAmount = (isIncoming) ? 0 : Convert.ToDouble(srcExcelWs.Cells[rowStartNo, 2].Value),
                            AdditionalNotes = "",
                        };
                        importedAssets.Add(newFinancialItem);
                    }
                    rowStartNo++;
                }
                StaticCode.mainDbContext.FinancialItemTbls.InsertAllOnSubmit(importedAssets);
                StaticCode.mainDbContext.SubmitChanges();
            }
            catch
            {
                errorCat = 3;
                return null;
            }

            if (unknownMinorCategories.Count() > 0)
                errorCat = 4;
            return unknownMinorCategories;
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