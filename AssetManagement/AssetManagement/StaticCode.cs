using AssetManagement.Properties;
using DevExpress.XtraEditors;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.VisualBasic.FileIO;
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
using System.Text.RegularExpressions;
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
        public static string MngAbbr = "Mng_";
        public static string TmpRestoreFilePath = StaticCode.BackupFolder + "tmp_Restore.txt";

        public static void AssignDbParams()
        {
            mainDbContext = new AssetMngDbDataContext();
            mainDbContext.Refresh(RefreshMode.OverwriteCurrentValues);

            activeUser = mainDbContext.UserTbls.Single(usr1 => usr1.ID == activeUser.ID);
            mainConn = new SqlConnection(new Properties.Settings().AssetMngDbConnectionString);
            appOptions = mainDbContext.OptionsTbls.Single(opt => opt.ID == 1);
            MngAbbr = appOptions.MngAbbr;
            activeUserRole = mainDbContext.UserRoleTbls.Single(usrrl => usrrl.ID == activeUser.UserRole);
        }

        public static void SqlToCsv(string csvFilePath)
        {
            SqlConnection sqlCon = new SqlConnection(new Properties.Settings().AssetMngDbConnectionString);
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandText = "SELECT * FROM AssetTbl";
            sqlCmd.Connection = sqlCon;
            sqlCon.Open();

            using (var CommandText = new SqlCommand("SELECT * FROM AssetTbl"))
            using (var reader = sqlCmd.ExecuteReader())
            using (var outFile = File.CreateText(csvFilePath))
            {
                string[] columnNames = GetColumnNames(reader).ToArray();
                int numFields = columnNames.Length;
                outFile.WriteLine(string.Join(",", columnNames));
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] columnValues =
                            Enumerable.Range(0, numFields)
                                      .Select(i => reader.GetValue(i).ToString())
                                      .Select(field => string.Concat("\"", field.Replace("\"", "\"\""), "\""))
                                      .ToArray();
                        outFile.WriteLine(string.Join(",", columnValues));
                    }
                }
            }
        }

        public static DataTable GetDataTabletFromCSVFile(string csv_file_path)
        {
            DataTable csvData = new DataTable();
            try
            {
                using (TextFieldParser csvReader = new TextFieldParser(csv_file_path))
                {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }
                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        //Making empty value as null
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }
                        csvData.Rows.Add(fieldData);
                    }
                }
            }
            catch
            {
                return null;
            }
            return csvData;
        }

        public static IEnumerable<string> GetColumnNames(IDataReader reader)
        {
            foreach (DataRow row in reader.GetSchemaTable().Rows)
            {
                yield return (string)row["ColumnName"];
            }
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

        public static bool RestoreDb3(string backupName)
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

        public static bool AutoBackup()
        {
            if (!Directory.Exists(BackupFolder))
                Directory.CreateDirectory(BackupFolder);
            string autoBackupName = $"{DateTime.Now.AddDays(appOptions.ShiftDays).AddSeconds(appOptions.ShiftSeconds).ToString("yyyy-MM-dd, HH-mm-ss")}.bak";
            return BackupDb(BackupFolder + autoBackupName);
        }

        public static int CountOfBackupFiles()
        {
            if (!Directory.Exists(BackupFolder))
                return 0;
            return Directory.GetFiles(BackupFolder).Count(oneF => Path.GetExtension(oneF) == ".bak");
        }

        public static bool RestoreDb(string backupName)
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

        public static bool RestoreDb2(string backupName)
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
            catch
            {
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

        public static DateTime AppToday
        {
            get
            {
                return DateTime.Today.AddDays(appOptions.ShiftDays);
            }
        }

        public static DateTime AppNow
        {
            get
            {
                return DateTime.Now.AddSeconds(appOptions.ShiftSeconds);
            }
        }

        public static int GetDefaultSubDeptForPM()
        {
            int assetSubD = 0;
            var qry_PM = mainDbContext.SubDepartmentVws.Where(sdptv1 => sdptv1.اسم_الوحدة == (PMName) && sdptv1.القسم_التابعة_له == (PMName) && sdptv1.الدائرة_التي_يتبع_لها_القسم == PMName);
            if (qry_PM == null || qry_PM.Count() == 0)
            {
                SectionTbl newPM_Sct = new SectionTbl() { SectionName = (PMName), };
                mainDbContext.SectionTbls.InsertOnSubmit(newPM_Sct);
                mainDbContext.SubmitChanges();
                DepartmentTbl newPM_Dpt = new DepartmentTbl() { DepartmentName = (PMName), SectionOfDepartment = newPM_Sct.ID };
                mainDbContext.DepartmentTbls.InsertOnSubmit(newPM_Dpt);
                mainDbContext.SubmitChanges();
                SubDepartmentTbl newPM_SDpt = new SubDepartmentTbl() { SubDepartmentName = (PMName), MainDepartment = newPM_Dpt.ID };
                mainDbContext.SubDepartmentTbls.InsertOnSubmit(newPM_SDpt);
                mainDbContext.SubmitChanges();
                assetSubD = newPM_SDpt.ID;
            }
            else
            {
                assetSubD = qry_PM.First().معرف_الوحدة;
            }
            return assetSubD;
        }

        public static int GetDefaultSubDeptBySectionID(int sctID)
        {
            int assetSubD = 0;
            string sctName = "";
            try
            {
                sctName = mainDbContext.SectionTbls.Single(sct1 => sct1.ID == sctID).SectionName;
            }
            catch
            {
                return 0;
            }
            var qry_PM = mainDbContext.SubDepartmentVws.Where(sdptv1 => sdptv1.اسم_الوحدة == (MngAbbr + sctName) && sdptv1.القسم_التابعة_له == (MngAbbr + sctName) && sdptv1.الدائرة_التي_يتبع_لها_القسم == sctName);
            if (qry_PM == null || qry_PM.Count() == 0)
            {
                DepartmentTbl newPM_Dpt = new DepartmentTbl() { DepartmentName = (MngAbbr + sctName), SectionOfDepartment = sctID };
                mainDbContext.DepartmentTbls.InsertOnSubmit(newPM_Dpt);
                mainDbContext.SubmitChanges();
                SubDepartmentTbl newPM_SDpt = new SubDepartmentTbl() { SubDepartmentName = (MngAbbr + sctName), MainDepartment = newPM_Dpt.ID };
                mainDbContext.SubDepartmentTbls.InsertOnSubmit(newPM_SDpt);
                mainDbContext.SubmitChanges();
                assetSubD = newPM_SDpt.ID;
            }
            else
            {
                assetSubD = qry_PM.First().معرف_الوحدة;
            }
            return assetSubD;
        }

        public static int GetDefaultSubDeptByDeptID(int dptID)
        {
            int assetSubD = 0;
            string sctName = "";
            string dptName = "";
            try
            {
                dptName = mainDbContext.DepartmentVws.Single(dptv1 => dptv1.معرف_القسم == dptID).اسم_القسم;
                sctName = mainDbContext.DepartmentVws.Single(dptv1 => dptv1.معرف_القسم == dptID).الدائرة_التي_يتبع_لها_القسم;
            }
            catch
            {
                return 0;
            }
            var qry_PM = mainDbContext.SubDepartmentVws.Where(sdptv1 => sdptv1.اسم_الوحدة == (MngAbbr + dptName) && sdptv1.القسم_التابعة_له == dptName && sdptv1.الدائرة_التي_يتبع_لها_القسم == sctName);
            if (qry_PM == null || qry_PM.Count() == 0)
            {
                SubDepartmentTbl newPM_SDpt = new SubDepartmentTbl() { SubDepartmentName = (MngAbbr + dptName), MainDepartment = dptID };
                mainDbContext.SubDepartmentTbls.InsertOnSubmit(newPM_SDpt);
                mainDbContext.SubmitChanges();
                assetSubD = newPM_SDpt.ID;
            }
            else
            {
                assetSubD = qry_PM.First().معرف_الوحدة;
            }
            return assetSubD;
        }

        public static int GetDefaultSubDeptForActiveUser()
        {
            int subDept = 0;
            if (activeUserRole.IsSectionIndependent == true)
                subDept = GetDefaultSubDeptForPM();
            else if (activeUserRole.IsDepartmentIndependent == true)
                subDept = GetDefaultSubDeptBySectionID(Convert.ToInt32(activeUser.UserSection));
            else
                subDept = GetDefaultSubDeptByDeptID(Convert.ToInt32(activeUser.UserDept));
            return subDept;
        }

        public static List<int> GetSubDeptsListByDeptID(int dptID)
        {
            if (!StaticCode.mainDbContext.SubDepartmentTbls.Any(sdpt1 => sdpt1.MainDepartment == dptID))
                return null;
            return StaticCode.mainDbContext.SubDepartmentTbls.Where(sdpt1 => sdpt1.MainDepartment == dptID).Select(sdpt2 => sdpt2.ID).ToList();
        }

        public static List<int> GetSubDeptsListBySectionID(int sctID)
        {
            if (!StaticCode.mainDbContext.DepartmentTbls.Any(sct1 => sct1.SectionOfDepartment == sctID))
                return null;
            List<int> dptIDs = StaticCode.mainDbContext.DepartmentTbls.Where(sct1 => sct1.SectionOfDepartment == sctID).Select(sct2 => sct2.ID).ToList();
            if (!StaticCode.mainDbContext.SubDepartmentTbls.Any(sdpt1 => dptIDs.Contains(sdpt1.MainDepartment)))
                return null;
            return StaticCode.mainDbContext.SubDepartmentTbls.Where(sdpt1 => dptIDs.Contains(sdpt1.MainDepartment)).Select(sdpt2 => sdpt2.ID).ToList();
        }

        public static int SubDeptByThreeLevels(string sectionName, string deptName, string subDeptName)
        {
            int sectionID = 0;
            int deptID = 0;
            int subDeptID = 0;
            if (!StaticCode.mainDbContext.SectionTbls.Any(sct1 => sct1.SectionName == sectionName))
            {
                SectionTbl newSection = new SectionTbl() { SectionName = sectionName };
                StaticCode.mainDbContext.SectionTbls.InsertOnSubmit(newSection);
                StaticCode.mainDbContext.SubmitChanges();
                sectionID = newSection.ID;
                DepartmentTbl newDept = new DepartmentTbl() { DepartmentName = deptName, SectionOfDepartment = sectionID };
                StaticCode.mainDbContext.DepartmentTbls.InsertOnSubmit(newDept);
                StaticCode.mainDbContext.SubmitChanges();
                deptID = newDept.ID;
                SubDepartmentTbl newSDept = new SubDepartmentTbl() { SubDepartmentName = subDeptName, MainDepartment = deptID };
                StaticCode.mainDbContext.SubDepartmentTbls.InsertOnSubmit(newSDept);
                StaticCode.mainDbContext.SubmitChanges();
                subDeptID = newSDept.ID;
            }
            else
            {
                sectionID = StaticCode.mainDbContext.SectionTbls.First(sct1 => sct1.SectionName == sectionName).ID;
                if (!StaticCode.mainDbContext.DepartmentTbls.Any(dpt1 => dpt1.DepartmentName == deptName && dpt1.SectionOfDepartment == sectionID))
                {
                    DepartmentTbl newDept = new DepartmentTbl() { DepartmentName = deptName, SectionOfDepartment = sectionID };
                    StaticCode.mainDbContext.DepartmentTbls.InsertOnSubmit(newDept);
                    StaticCode.mainDbContext.SubmitChanges();
                    deptID = newDept.ID;
                    SubDepartmentTbl newSDept = new SubDepartmentTbl() { SubDepartmentName = subDeptName, MainDepartment = deptID };
                    StaticCode.mainDbContext.SubDepartmentTbls.InsertOnSubmit(newSDept);
                    StaticCode.mainDbContext.SubmitChanges();
                    subDeptID = newSDept.ID;
                }
                else
                {
                    deptID = StaticCode.mainDbContext.DepartmentTbls.First(dpt1 => dpt1.DepartmentName == deptName && dpt1.SectionOfDepartment == sectionID).ID;
                    if (!StaticCode.mainDbContext.SubDepartmentTbls.Any(sdpt1 => sdpt1.SubDepartmentName == subDeptName && sdpt1.MainDepartment == deptID))
                    {
                        SubDepartmentTbl newSDept = new SubDepartmentTbl() { SubDepartmentName = subDeptName, MainDepartment = deptID };
                        StaticCode.mainDbContext.SubDepartmentTbls.InsertOnSubmit(newSDept);
                        StaticCode.mainDbContext.SubmitChanges();
                        subDeptID = newSDept.ID;
                    }
                    else
                    {
                        subDeptID = StaticCode.mainDbContext.SubDepartmentTbls.First(sdpt1 => sdpt1.SubDepartmentName == subDeptName && sdpt1.MainDepartment == deptID).ID;
                    }
                }
            }

            return subDeptID;
        }

        public static List<int> GetAssetsSubDeptsOfActiveUser()
        {
            return (StaticCode.mainDbContext.AssetTbls.Where(ast1 => StaticCode.mainDbContext.AssetVws.Select(astv1 => astv1.معرف_الأصل).Contains(ast1.ID)).Select(ast2 => ast2.AssetSubDepartment).ToList());
        }

        public static int GetMissingDataMinorCategory()
        {
            var missingDataMiCaQry = StaticCode.mainDbContext.MinorCategoryVws.Where(mica1 => mica1.اسم_الفئة_الرئيسية == missingDataStatement && mica1.اسم_الفئة_الفرعية == missingDataStatement);
            if (missingDataMiCaQry.Any())
                return missingDataMiCaQry.First().معرف_الفئة_الفرعية;
            var missingDataMaCaQry = StaticCode.mainDbContext.MainCategoryTbls.Where(maca1 => maca1.MainCategoryName == missingDataStatement);
            if (missingDataMaCaQry.Any())
            {
                int micaID = missingDataMaCaQry.First().ID;
                MinorCategoryTbl newMiCa = new MinorCategoryTbl() { MinorCategoryName = missingDataStatement, MainCategory = micaID, ProductiveAgeInYears = 1000, DestructionRate = 0.001 };
                StaticCode.mainDbContext.MinorCategoryTbls.InsertOnSubmit(newMiCa);
                StaticCode.mainDbContext.SubmitChanges();
                return newMiCa.ID;
            }
            else
            {
                MainCategoryTbl newMaCa = new MainCategoryTbl() { MainCategoryName = missingDataStatement };
                StaticCode.mainDbContext.MainCategoryTbls.InsertOnSubmit(newMaCa);
                StaticCode.mainDbContext.SubmitChanges();
                int micaID = newMaCa.ID;
                MinorCategoryTbl newMiCa = new MinorCategoryTbl() { MinorCategoryName = missingDataStatement, MainCategory = micaID, ProductiveAgeInYears = 1000, DestructionRate = 0.001 };
                StaticCode.mainDbContext.MinorCategoryTbls.InsertOnSubmit(newMiCa);
                StaticCode.mainDbContext.SubmitChanges();
                return newMiCa.ID;
            }
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
        #endregion

        #region Assets
        public static List<string> assetsStatements = new List<string>()
            {
                "اصل ثابت",
                "أصل ثابت",
                "أصول ثابتة",
                "اصول ثابتة"
            };
        public static string missingDataStatement = "بيانات الأصل ناقصة";
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

            int sectionCol = 5;
            int departmentCol = (formNo == 3) ? 11 : 10;
            int subDepartmentCol = (formNo == 3) ? 16 : 15;
            int threeLevelsRow = 5;
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

            List<string> assetsCodes = srcExcelWs.Cells.Where(cl1 => cl1.Start.Column == assetCodeColumn && cl1.End.Column == assetCodeColumn && cl1.Start.Row >= startRow && !cl1.Offset(0, -1).Value.ToString().Contains("ملاحظة:")).Select(cl2 => cl2.Value?.ToString()).ToList();
            List<string> newCodes = assetsCodes.Where(code1 => !mainDbContext.AssetTbls.Select(ast1 => ast1.AssetCode).Contains(code1)).Select(code2 => code2).ToList();
            List<string> existedCodes = assetsCodes.Where(code1 => mainDbContext.AssetTbls.Select(ast1 => ast1.AssetCode).Contains(code1)).Select(code2 => code2).ToList();
            int existedAssetsCount = existedCodes.Count();
            int newAssetsCount = assetsCodes.Count() - existedAssetsCount;

            string sectionName = srcExcelWs.Cells[threeLevelsRow, sectionCol].Value?.ToString().Replace("الدائرة:", "").Trim();
            string departmentName = srcExcelWs.Cells[threeLevelsRow, departmentCol].Value?.ToString().Trim();
            string subDepartmentName = srcExcelWs.Cells[threeLevelsRow, subDepartmentCol].Value?.ToString().Trim();
            int sctID = 0;
            int dptID = 0;
            int assetSubD = 0;
            if (activeUserRole.IsSectionIndependent != true)
            {
                if (sectionName != UserSectionName)
                {
                    errorMsg = "الدائرة المضمنة في ملف الإكسل غير مطابقة للدائرة التي يتبع لها الحساب النشط، لذا لا يمكن استيراد البيانات";
                    tmpMainDbContext.Dispose();
                    return null;
                }
            }
            if (activeUserRole.IsDepartmentIndependent != true)
            {
                if (sectionName != UserSectionName)
                {
                    errorMsg = "الدائرة المضمنة في ملف الإكسل غير مطابقة للدائرة التي يتبع لها الحساب النشط، لذا لا يمكن استيراد البيانات";
                    tmpMainDbContext.Dispose();
                    return null;
                }
                if (departmentName != UserDeptName)
                {
                    errorMsg = "القسم المضمن في ملف الإكسل غير مطابق للقسم الذي يتبع له الحساب النشط، لذا لا يمكن استيراد البيانات";
                    tmpMainDbContext.Dispose();
                    return null;
                }
            }
            if (!mainDbContext.SectionTbls.Any(sct1 => sct1.SectionName == sectionName)) // Section
            {
                if (sectionName == StaticCode.PMName)
                {
                    assetSubD = StaticCode.GetDefaultSubDeptForPM();
                }
                else
                {
                    if (String.IsNullOrEmpty(sectionName) && String.IsNullOrEmpty(departmentName) && String.IsNullOrEmpty(subDepartmentName))
                    {
                        assetSubD = StaticCode.GetDefaultSubDeptForPM();
                    }
                    else
                    {
                        errorMsg = "الدائرة المضمنة في ملف الإكسل غير موجودة في سجلات الدوائر";
                        tmpMainDbContext.Dispose();
                        return null;
                    }
                }
            }
            else
            {
                sctID = mainDbContext.SectionTbls.Where(sct1 => sct1.SectionName == sectionName).First().ID;
                if (activeUserRole.IsSectionIndependent == true)
                {
                    if (sectionName.ToUpper() == StaticCode.PMName)
                    {
                        assetSubD = StaticCode.GetDefaultSubDeptForPM();
                    }
                    else
                    {
                        assetSubD = GetDefaultSubDeptBySectionID(sctID);
                    }
                }
                else // Department
                {
                    if (!mainDbContext.DepartmentVws.Any(dpt1 => dpt1.اسم_القسم == departmentName && dpt1.الدائرة_التي_يتبع_لها_القسم == sectionName))
                    {
                        if (String.IsNullOrEmpty(departmentName))
                        {
                            assetSubD = StaticCode.GetDefaultSubDeptBySectionID(sctID);
                        }
                        else
                        {
                            errorMsg = "القسم المضمن في ملف الإكسل غير موجودة في سجلات الأقسام أو لا يتبع للدائرة المضمنة في ملف الإكسل ذاته";
                            tmpMainDbContext.Dispose();
                            return null;
                        }
                    }
                    else
                    {
                        dptID = mainDbContext.DepartmentVws.Where(dpt1 => dpt1.اسم_القسم == departmentName && dpt1.الدائرة_التي_يتبع_لها_القسم == sectionName).First().معرف_القسم;
                        if (activeUserRole.IsDepartmentIndependent == true)
                        {
                            assetSubD = GetDefaultSubDeptByDeptID(dptID);
                        }
                        else // SubDepartment
                        {
                            var existedSubDept = mainDbContext.SubDepartmentVws.Where(fiv1 => fiv1.اسم_الوحدة == subDepartmentName && fiv1.القسم_التابعة_له == departmentName && fiv1.الدائرة_التي_يتبع_لها_القسم == sectionName);

                            if (!existedSubDept.Any())
                            {
                                if (String.IsNullOrEmpty(subDepartmentName))
                                {
                                    if (String.IsNullOrEmpty(departmentName))
                                    {
                                        assetSubD = StaticCode.GetDefaultSubDeptForPM();
                                    }
                                    else
                                    {
                                        assetSubD = StaticCode.GetDefaultSubDeptByDeptID(dptID);
                                    }
                                }
                                else
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
                        }
                    }
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
            if (!StaticCode.mainDbContext.EstateAreaUnitTbls.Any())
            {
                tmpMainDbContext.EstateAreaUnitTbls.InsertOnSubmit(new EstateAreaUnitTbl() { EstateAreaUnitName = StaticCode.missingDataStatement });
                tmpMainDbContext.SubmitChanges();
            }
            while (rowStartNo <= srcExcelWs.Dimension.End.Row)
            {
                Application.DoEvents();

                try
                {
                    if (!String.IsNullOrEmpty(srcExcelWs.Cells[rowStartNo + 1, 2].Value?.ToString()) &&
                    srcExcelWs.Cells[rowStartNo + 1, 2].Value.ToString().Contains("ملاحظة:"))
                        break;
                    if (!String.IsNullOrEmpty(srcExcelWs.Cells[rowStartNo, 2].Value?.ToString()) &&
                   srcExcelWs.Cells[rowStartNo, 2].Value.ToString().Contains("ملاحظة:"))
                        break;

                    if (String.IsNullOrEmpty(srcExcelWs.Cells[rowStartNo, assetCodeColumn].Value?.ToString().Trim()))
                    {
                        errorMsg = $"كود الأصل في السطر {rowStartNo} غير موجود";
                        tmpMainDbContext.Dispose();
                        return null;
                    }
                    string astCode = srcExcelWs.Cells[rowStartNo, assetCodeColumn].Value?.ToString().Trim();
                    AssetTbl newAsset = new AssetTbl();
                    newAsset.IsOldOrNewAsset = "قديم";
                    newAsset.EstateArea = "";
                    newAsset.EstateAreaUnit = tmpMainDbContext.EstateAreaUnitTbls.First().ID;
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
                        unknownMinorCategories.Add($"{unknownMinorCategories.Count() + 1}- كود الأصل:  {srcExcelWs.Cells[rowStartNo, 3].Value?.ToString().Trim()}، الفئة الرئيسية: {currMainCategoryName}، الفئة الفرعية: {currMinorCategoryName}");
                        rowStartNo++;
                        continue;
                    }

                    newAsset.AssetCode = srcExcelWs.Cells[rowStartNo, assetCodeColumn].Value?.ToString().Trim();
                    newAsset.AssetMinorCategory = existedMiCa.First().معرف_الفئة_الفرعية;
                    if (String.IsNullOrEmpty(srcExcelWs.Cells[rowStartNo, specColumn].Value?.ToString().Trim()))
                    {
                        errorMsg = $"مواصفات الأصل في السطر {rowStartNo} غير موجودة";
                        tmpMainDbContext.Dispose();
                        return null;
                    }
                    newAsset.AssetSpecifications = srcExcelWs.Cells[rowStartNo, specColumn].Value?.ToString().Trim();
                    newAsset.AssetSubDepartment = assetSubD;
                    int itemQtyVal = 0;
                    if (!Int32.TryParse(srcExcelWs.Cells[rowStartNo, qtyColumn].Value?.ToString().Trim(), out itemQtyVal))
                    {
                        errorMsg = $"قيمة العدد في السطر {rowStartNo} غير صحيحة";
                        tmpMainDbContext.Dispose();
                        return null;
                    }
                    newAsset.ItemsQuantity = itemQtyVal;

                    newAsset.Model = (formNo == 3) ? srcExcelWs.Cells[rowStartNo, modelColumn].Value?.ToString().Trim() : "";
                    newAsset.OwnerName = (formNo == 1) ? "" : srcExcelWs.Cells[rowStartNo, ownerNameColumn].Value?.ToString().Trim();
                    if (srcExcelWs.Cells[rowStartNo, prchsDateColumn + formShift].Value != null)
                    {
                        DateTime prchsDateVal = DateTime.Today;
                        if (!DateTime.TryParse(srcExcelWs.Cells[rowStartNo, prchsDateColumn + formShift].Value?.ToString().Trim(), out prchsDateVal))
                        {
                            errorMsg = $"تاريخ شراء الأصل في السطر {rowStartNo} غير صحيح";
                            tmpMainDbContext.Dispose();
                            return null;
                        }
                        newAsset.PurchaseDate = prchsDateVal;
                        int monthsDiff = existedMiCa.First().العمر_الإنتاجي_بالسنوات * 12 - ((DateTime.Today.Year - Convert.ToDateTime(newAsset.PurchaseDate).Year) * 12 + (DateTime.Today.Month - Convert.ToDateTime(newAsset.PurchaseDate).Month));
                        newAsset.LifeSpanInMonths = monthsDiff;
                    }
                    else
                    {
                        newAsset.LifeSpanInMonths = 0;
                    }
                    newAsset.EstateAddress = (formNo == 2) ? srcExcelWs.Cells[rowStartNo, estateAddress].Value?.ToString().Trim() : "";
                    newAsset.CarPanelNumber = (formNo == 3) ? srcExcelWs.Cells[rowStartNo, carPanelNumberAddress].Value?.ToString().Trim() : "";
                    if (String.IsNullOrEmpty(srcExcelWs.Cells[rowStartNo, prchsValColumn + formShift].Value?.ToString().Trim()))
                    {
                        newAsset.PurchasePrice = 0;
                        newAsset.PurchasePriceCurrency = tmpMainDbContext.CurrencyTbls.First().ID;
                    }
                    else
                    {
                        double prchsPriceVal = 0;
                        if (!Double.TryParse(srcExcelWs.Cells[rowStartNo, prchsValColumn + formShift].Value?.ToString().Trim(), out prchsPriceVal))
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
                        if (!tmpMainDbContext.CurrencyTbls.Any(cu1 => cu1.CurrencyName == srcExcelWs.Cells[rowStartNo, prchsCurrColumn + formShift].Value.ToString().Trim()))
                        {
                            errorMsg = $"اسم العملة في السطر {rowStartNo} ليست صحيحة";
                            tmpMainDbContext.Dispose();
                            return null;
                        }
                        newAsset.PurchasePriceCurrency = tmpMainDbContext.CurrencyTbls.Single(cu1 => cu1.CurrencyName == srcExcelWs.Cells[rowStartNo, prchsCurrColumn + formShift].Value.ToString().Trim()).ID;
                    }

                    double actualPriceVal = 0;
                    if (!Double.TryParse(srcExcelWs.Cells[rowStartNo, actualPriceColumn + formShift].Value?.ToString().Trim(), out actualPriceVal))
                    {
                        errorMsg = $"قيمة السعر الفعلي الحالي في السطر {rowStartNo} غير صحيحة";
                        tmpMainDbContext.Dispose();
                        return null;
                    }
                    newAsset.ActualCurrentPrice = actualPriceVal;
                    newAsset.Color = (formNo == 3) ? srcExcelWs.Cells[rowStartNo, colorColumn].Value?.ToString().Trim() : "";
                    newAsset.Volume = "";
                    newAsset.OfUsed = (formNo == 2) ? srcExcelWs.Cells[rowStartNo, ofUsedColumn].Value?.ToString().Trim() : "";
                    if (formNo == 3)
                    {
                        int manuYearVal = 0;
                        if (!Int32.TryParse(srcExcelWs.Cells[rowStartNo, manuYearColumn].Value?.ToString().Trim(), out manuYearVal))
                        {
                            errorMsg = $"قيمة سنة الصنع في السطر {rowStartNo} ليست صحيحة";
                            tmpMainDbContext.Dispose();
                            return null;
                        }
                        if (manuYearVal <= 0)
                        {
                            errorMsg = $"قيمة سنة الصنع في السطر {rowStartNo} ليست صحيحة";
                            tmpMainDbContext.Dispose();
                            return null;
                        }
                        newAsset.CarManufacturingYear = manuYearVal;
                    }
                    newAsset.EstateOwnershipDocumentWith = (formNo == 2) ? srcExcelWs.Cells[rowStartNo, estateOwWithColumn].Value?.ToString().Trim() : "";
                    newAsset.CarChassisNumber = (formNo == 3) ? srcExcelWs.Cells[rowStartNo, carChasColumn].Value?.ToString().Trim() : "";
                    newAsset.CarEngineNumber = (formNo == 3) ? srcExcelWs.Cells[rowStartNo, carEngineColumn].Value?.ToString().Trim() : "";
                    if (String.IsNullOrEmpty(srcExcelWs.Cells[rowStartNo, sqrColumn + formShift].Value?.ToString().Trim()))
                    {
                        errorMsg = $"اسم الساحة في السطر {rowStartNo} فارغة";
                        tmpMainDbContext.Dispose();
                        return null;
                    }
                    if (!tmpMainDbContext.SquareTbls.Any(sq1 => sq1.SquareName == srcExcelWs.Cells[rowStartNo, sqrColumn + formShift].Value.ToString().Trim()))
                    {
                        errorMsg = $"اسم الساحة في السطر {rowStartNo} ليست صحيحة";
                        tmpMainDbContext.Dispose();
                        return null;
                    }
                    newAsset.AssetSquare = tmpMainDbContext.SquareTbls.Single(sq1 => sq1.SquareName == srcExcelWs.Cells[rowStartNo, sqrColumn + formShift].Value.ToString().Trim()).ID;
                    newAsset.PlaceOfPresence = srcExcelWs.Cells[rowStartNo, presPlaceColumn + formShift].Value?.ToString().Trim();
                    if (String.IsNullOrEmpty(srcExcelWs.Cells[rowStartNo, curStatusColumn + formShift].Value?.ToString().Trim()))
                    {
                        errorMsg = $"حالة الأصل في السطر {rowStartNo} فارغة";
                        tmpMainDbContext.Dispose();
                        return null;
                    }
                    if (!tmpMainDbContext.StatusTbls.Any(st1 => st1.StatusName == srcExcelWs.Cells[rowStartNo, curStatusColumn + formShift].Value.ToString().Trim()))
                    {
                        errorMsg = $"حالة الأصل في السطر {rowStartNo} ليست صحيحة";
                        tmpMainDbContext.Dispose();
                        return null;
                    }
                    newAsset.CurrentStatus = tmpMainDbContext.StatusTbls.Single(st1 => st1.StatusName == srcExcelWs.Cells[rowStartNo, curStatusColumn + formShift].Value.ToString().Trim()).ID;
                    newAsset.BenefitPercentage = srcExcelWs.Cells[rowStartNo, benefitPrctgColumn + formShift].Value?.ToString().Trim();
                    if (String.IsNullOrEmpty(srcExcelWs.Cells[rowStartNo, cstdNameColumn + formShift].Value?.ToString().Trim()))
                    {
                        errorMsg = $"اسم صاحب العهدة في السطر {rowStartNo} فارغ";
                        tmpMainDbContext.Dispose();
                        return null;
                    }
                    newAsset.CustodianName = srcExcelWs.Cells[rowStartNo, cstdNameColumn + formShift].Value?.ToString().Trim();
                    newAsset.DestructionRate = existedMiCa.First().معدل_الإهلاك;
                    newAsset.MoreDetails = srcExcelWs.Cells[rowStartNo, moreDetailsColumn + formShift].Value?.ToString().Trim();
                    newAsset.AssetNotes = srcExcelWs.Cells[rowStartNo, notesColumn + formShift].Value?.ToString().Trim();
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
            string newCodesStr = String.Join(", ", newCodes);
            string existedCodesStr = String.Join(", ", existedCodes);
            string importNotes = $"الاستيراد من نموذج أصول:\r\n1- الأصول المضافة({newAssetsCount}):\r\n{newCodesStr}\r\n2- الأصول التي تم تعديلها({((updateExistedAssets) ? existedAssetsCount : 0)}):\r\n{((updateExistedAssets) ? existedCodesStr : "(لا يوجد)")}";
            ImportExportTbl newImport = new ImportExportTbl()
            {
                ActionDate = DateTime.Today.AddDays(appOptions.ShiftDays),
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

        public static string AssetsAttachmentsFolder = $"{Application.StartupPath}//Assets attachments//";

        public static IQueryable<AssetTbl> GetAssetsToDestruct()
        {
            ExecuteProcedure("dbo.CalcAssetsLifeSpanSp");
            mainDbContext.Refresh(RefreshMode.KeepChanges, mainDbContext.AssetTbls);
            var availableAssets = mainDbContext.AssetVws;
            IQueryable<AssetTbl> res = mainDbContext.AssetTbls.Where(ast => availableAssets.Select(asv1 => asv1.معرف_الأصل).ToList().Contains(ast.ID) && ast.PurchaseDate != null && ast.LifeSpanInMonths > 0 && ast.LifeSpanInMonths <= appOptions.AssetLifeSpanThresholdToWarn).Select(ast1 => ast1);
            return res;
        }

        public static IQueryable<AssetTbl> GetDestructedWithoutTransactionAssets()
        {
            ExecuteProcedure("dbo.CalcAssetsLifeSpanSp");
            mainDbContext.Refresh(RefreshMode.KeepChanges, mainDbContext.AssetTbls);
            var availableAssets = mainDbContext.AssetVws;
            IQueryable<AssetTbl> res = mainDbContext.AssetTbls.Where(ast => availableAssets.Select(asv1 => asv1.معرف_الأصل).ToList().Contains(ast.ID) && ast.PurchaseDate != null && ast.LifeSpanInMonths <= 0 && mainDbContext.AssetTransactionTbls.Count(astt2 => astt2.TransactionType == mainDbContext.TransactionTypeTbls.Where(tt1 => tt1.TransactionTypeName == "إهلاك").First().ID && astt2.AssetID == ast.ID) == 0).Select(ast1 => ast1);
            return res;
        }

        public static IQueryable<AssetTbl> GetAssetsWithoutPurchaseDate()
        {
            mainDbContext.Refresh(RefreshMode.KeepChanges, mainDbContext.AssetTbls);
            var availableAssets = mainDbContext.AssetVws;
            IQueryable<AssetTbl> res = mainDbContext.AssetTbls.Where(ast => availableAssets.Select(asv1 => asv1.معرف_الأصل).ToList().Contains(ast.ID) && ast.PurchaseDate == null).Select(ast1 => ast1);
            return res;
        }

        public static IQueryable<AssetTbl> GetMissingDataAssets()
        {
            mainDbContext.Refresh(RefreshMode.KeepChanges, mainDbContext.AssetTbls);
            var availableAssets = mainDbContext.AssetVws;
            IQueryable<AssetTbl> res = mainDbContext.AssetTbls.Where(ast => availableAssets.Select(asv1 => asv1.معرف_الأصل).ToList().Contains(ast.ID) && ast.AssetNotes != null && ast.AssetNotes.Contains("بيانات الأصل ناقصة")).Select(ast1 => ast1);
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

        public static string GetTheNewAssetCode(int incrementValue)
        {
            string currUserPrefix = activeUser.UserPrefix;
            var currUserAssets = mainDbContext.AssetTbls.Where(ast1 => ast1.AssetCode.Contains(currUserPrefix + "-"));
            if (currUserAssets == null || currUserAssets.Count() == 0)
                return ($"{currUserPrefix}-{(incrementValue + 1).ToString().PadLeft(7, '0')}");
            string maxAssetCodeForCurrUser = currUserAssets.Max(ast2 => ast2.AssetCode);
            int maxAssetIDForCurrUser = 1;
            try
            {
                maxAssetIDForCurrUser = Convert.ToInt32(maxAssetCodeForCurrUser.Replace(currUserPrefix + "-", "")) + 1 + incrementValue;
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
            int monthsDiff = (AppToday.Year * 12 + AppToday.Month) - (purchaseDate.Year * 12 + purchaseDate.Month);
            double yearsDiff = (double)monthsDiff / 12.0;
            double destRate = yearsDiff * ast.DestructionRate;
            double calcPrice = Convert.ToDouble(ast.PurchasePrice) * (100 - destRate) / 100.0;
            if (calcPrice < 0)
                return 0;
            return calcPrice;
        }
        #endregion

        #region Login
        public static UserTbl activeUser { get; set; }
        public static UserRoleTbl activeUserRole { get; set; }
        public static UserLoginTbl activeUserLogin { get; set; }
        public static string UserSectionName
        {
            get
            {
                if (activeUserRole.IsSectionIndependent == true)
                    return "";
                else
                {
                    int userSectionID = 0;
                    if (!Int32.TryParse(activeUser.UserSection?.ToString(), out userSectionID))
                        return "";
                    if (!StaticCode.mainDbContext.SectionTbls.Any(sct1 => sct1.ID == userSectionID))
                        return "";
                    string usrSecName = StaticCode.mainDbContext.SectionTbls.Single(sct1 => sct1.ID == userSectionID).SectionName;
                    return usrSecName;
                }
            }
        }
        public static string UserDeptName
        {
            get
            {
                if (activeUserRole.IsDepartmentIndependent == true)
                    return "";
                else
                {
                    int userDeptID = 0;
                    if (!Int32.TryParse(activeUser.UserDept?.ToString(), out userDeptID))
                        return "";
                    if (!StaticCode.mainDbContext.DepartmentTbls.Any(dpt1 => dpt1.ID == userDeptID))
                        return "";
                    string usrDptName = StaticCode.mainDbContext.DepartmentTbls.Single(dpt1 => dpt1.ID == userDeptID).DepartmentName;
                    return usrDptName;
                }
            }
        }
        #endregion

        #region Export and Import
        public static string ExportFolder = $"{Application.StartupPath}//Export files//";

        public static void ImportDataFromExcel(string excelFilePath, List<int> filtered_SubDepts, out List<string> newAssets, out List<string> updatedAssets, out List<string> invalidAssets, out List<string> newFinancialItems, out List<string> updatedFinancialItems, out List<string> invalidFinancialItems)
        {
            newAssets = new List<string>();
            updatedAssets = new List<string>();
            invalidAssets = new List<string>();
            newFinancialItems = new List<string>();
            updatedFinancialItems = new List<string>();
            invalidFinancialItems = new List<string>();

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
            List<string> subDFields = new List<string>() { "AssetSubDepartment", "FinancialItemSubDept", "AssetID", "AssetID" };

            ExcelPackage srcExcelEp = new ExcelPackage(new FileInfo(excelFilePath));
            ExcelWorkbook srcExcelWb = srcExcelEp.Workbook;

            foreach (string oneTable in tblsToImport)
            {
                Application.DoEvents();
                if (!srcExcelWb.Worksheets.Any(sh1 => sh1.Name == oneTable))
                    continue;
                ExcelWorksheet oneSh = srcExcelWb.Worksheets.Where(sh1 => sh1.Name == oneTable).First();
                for (int iRow = 2; iRow <= oneSh.Dimension.End.Row; iRow++)
                {
                    Application.DoEvents();

                    string oneKeyValue = "";
                    try
                    {
                        string currKeyField = keyFields[tblsToImport.IndexOf(oneTable)];
                        string currSubDField = subDFields[tblsToImport.IndexOf(oneTable)];
                        List<string> tblFields = oneSh.Cells.Where(cl1 => cl1.End.Row == 1 && cl1.Start.Row == 1 && cl1.End.Column <= oneSh.Dimension.End.Column).Select(cl2 => cl2.Value?.ToString()).ToList();
                        int keyIndex = tblFields.IndexOf(currKeyField) + 1;
                        int subIndex = tblFields.IndexOf(currSubDField) + 1;
                        if (oneTable == "FinancialItemTbl" && tblFields.Contains("IncomingFrom") && tblFields.Contains("FinancialItemCategory"))
                        {
                            int fiCaVal = Convert.ToInt32(oneSh.Cells[iRow, tblFields.IndexOf("FinancialItemCategory") + 1].Value);
                            string fiCaName = StaticCode.mainDbContext.FinancialItemCategoryTbls.Single(fica1 => fica1.ID == fiCaVal).FinancialItemCategoryName;
                            string incomingFromVal = oneSh.Cells[iRow, tblFields.IndexOf("IncomingFrom") + 1].Value?.ToString();
                            if (fiCaName.Contains("مدور") || incomingFromVal == "من المستوى الأعلى")
                                continue;
                        }
                        int oneSubDValue = 0;

                        oneKeyValue = oneSh.Cells[iRow, keyIndex].Value?.ToString();
                        if (oneTable == "AssetTbl" || oneTable == "FinancialItemTbl")
                        {
                            oneSubDValue = Convert.ToInt32(oneSh.Cells[iRow, subIndex].Value);
                        }
                        if (oneTable == "AssetMovementTbl" || oneTable == "AssetTransactionTbl")
                        {
                            string assetCode = oneSh.Cells[iRow, subIndex].Value?.ToString();
                            if (!StaticCode.mainDbContext.AssetTbls.Any(ast1 => ast1.AssetCode == assetCode))
                                continue;
                            oneSubDValue = StaticCode.mainDbContext.AssetTbls.Where(ast1 => ast1.AssetCode == assetCode).First().AssetSubDepartment;
                        }
                        if (!filtered_SubDepts.Contains(oneSubDValue))
                        {
                            continue;
                        }
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

                                if (oneTable == "AssetMovementTbl" || oneTable == "AssetTransactionTbl")
                                {
                                    if (oneField == "AssetID")
                                    {
                                        string assetCode = oneSh.Cells[iRow, iCol].Value?.ToString();
                                        if (!StaticCode.mainDbContext.AssetTbls.Any(ast1 => ast1.AssetCode == assetCode))
                                            continue;
                                        oneVal = StaticCode.mainDbContext.AssetTbls.Where(ast1 => ast1.AssetCode == assetCode).First().ID.ToString();
                                    }
                                }

                                if (oneField.ToUpper().Contains("DATE") || (oneField.Length > 4 && oneField.ToUpper().Substring(oneField.Length - 4) == "EDON") || (oneField.Length > 4 && oneField.ToUpper().Substring(oneField.Length - 4) == "DEON"))
                                {
                                    if (String.IsNullOrEmpty(oneVal))
                                    {
                                        fieldsValuesPairs += $"{oneField} = NULL, ";
                                    }
                                    else
                                    {
                                        DateTime fieldAsDate = new DateTime(1899, 12, 30).AddDays(Convert.ToInt32(oneVal));
                                        fieldsValuesPairs += $"{oneField} = N'{fieldAsDate.ToString("yyyy-MM-dd")}', ";
                                    }
                                }
                                else
                                {
                                    fieldsValuesPairs += $"{oneField} = N'{oneVal}', ";
                                }
                            }
                            fieldsValuesPairs = fieldsValuesPairs.Trim().Trim(',');
                            string updateQry = $"UPDATE {oneTable} SET {fieldsValuesPairs} WHERE {currKeyField} = N'{oneKeyValue}';";
                            sqlcomm.CommandText = updateQry;
                            sqlcomm.ExecuteNonQuery();
                            switch (oneTable)
                            {
                                case "AssetTbl":
                                    updatedAssets.Add(oneKeyValue);
                                    break;
                                case "FinancialItemTbl":
                                    updatedFinancialItems.Add(oneKeyValue);
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            string fieldsPairs = "";
                            string valuesPairs = "";

                            for (int iCol = 2; iCol <= oneSh.Dimension.End.Column; iCol++)
                            {
                                string oneField = oneSh.Cells[1, iCol].Value?.ToString();
                                string oneVal = oneSh.Cells[iRow, iCol].Value?.ToString();

                                if (oneTable == "AssetMovementTbl" || oneTable == "AssetTransactionTbl")
                                {
                                    if (oneField == "AssetID")
                                    {
                                        string assetCode = oneSh.Cells[iRow, iCol].Value?.ToString();
                                        if (!StaticCode.mainDbContext.AssetTbls.Any(ast1 => ast1.AssetCode == assetCode))
                                            continue;
                                        oneVal = StaticCode.mainDbContext.AssetTbls.Where(ast1 => ast1.AssetCode == assetCode).First().ID.ToString();
                                    }
                                }

                                fieldsPairs += $"{oneField}, ";
                                if (oneField.ToUpper().Contains("DATE") || (oneField.Length > 4 && oneField.ToUpper().Substring(oneField.Length - 4) == "EDON") || (oneField.Length > 4 && oneField.ToUpper().Substring(oneField.Length - 4) == "DEON"))
                                {
                                    if (String.IsNullOrEmpty(oneVal))
                                    {
                                        valuesPairs += $"NULL, ";
                                    }
                                    else
                                    {
                                        DateTime fieldAsDate = new DateTime(1899, 12, 30).AddDays(Convert.ToInt32(oneVal));
                                        valuesPairs += $"N'{fieldAsDate.ToString("yyyy-MM-dd")}', ";
                                    }
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
                            sqlcomm.ExecuteNonQuery();
                            switch (oneTable)
                            {
                                case "AssetTbl":
                                    newAssets.Add(oneKeyValue);
                                    break;
                                case "FinancialItemTbl":
                                    newFinancialItems.Add(oneKeyValue);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    catch
                    {
                        switch (oneTable)
                        {
                            case "AssetTbl":
                                invalidAssets.Add(oneKeyValue);
                                break;
                            case "FinancialItemTbl":
                                invalidFinancialItems.Add(oneKeyValue);
                                break;
                            default:
                                break;
                        }
                    }
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
                if (!File.Exists(RSAPublicKeyPath))
                    return null;
                StreamReader pubKeyRdr = new StreamReader(RSAPublicKeyPath);
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
                if (!File.Exists(RSAPrivateKeyPath))
                    return null;
                StreamReader priKeyRdr = new StreamReader(RSAPrivateKeyPath);
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
            //if (!File.Exists(RSAPublicKeyPath) || !File.Exists(RSAPublicKeyPath))
            //{
            //    GenerateNewRSAPublicAndPrivateKeys();
            //}
            //string encryptedStr = RSAEncryption(outBytes);
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
        public static string BlankFinancialReportPath = $"{FinanceFolder}financial blank report.xlsx";
        public static string GeneralFinancialReportPath = $"{FinanceFolder}التقرير المالي العام{DateTime.Today.ToString("yyyy-MM-dd")}.xlsx";
        public static string DetailedFinancialReportPath = $"{FinanceFolder}التقرير المالي التفصيلي{DateTime.Today.ToString("yyyy-MM-dd")}.xlsx";
        public static string ExpensesAnalysisReportPath = $"{FinanceFolder}تحليل المصروفات{DateTime.Today.ToString("yyyy-MM-dd")}.xlsx";
        public static string AssetAsFiCaStatement = "أصول ثابتة";
        public static string FinancialItemsAttachmentsFolder = $"{Application.StartupPath}//Financial items attachments//";

        public static string GetTheNewFinancialItemCode()
        {
            string currUserPrefix = activeUser.UserPrefix;
            var currUserAssets = mainDbContext.AssetTbls.Where(ast1 => ast1.AssetCode.Contains(currUserPrefix + "-"));
            if (currUserAssets == null || currUserAssets.Count() == 0)
                return ($"{currUserPrefix}-1");
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
            return ($"{currUserPrefix}-{maxAssetIDForCurrUser}");
        }

        public static string ImportFinancialItemsFromExcel(string fiItsFilePath, out int codeIncVal)
        {
            codeIncVal = 0;
            if (!File.Exists(fiItsFilePath))
            {
                return ("مسار الملف غير صحيح");
            }
            ExcelPackage srcExcelEp = new ExcelPackage(new FileInfo(fiItsFilePath));
            ExcelWorkbook srcExcelWb = srcExcelEp.Workbook;
            ExcelWorksheet srcExcelWs = srcExcelWb.Worksheets.First();
            string sectionName = srcExcelWs.Cells[2, 2].Value?.ToString().Replace("الدائرة:", "").Trim();
            string departmentName = srcExcelWs.Cells[2, 5].Value?.ToString().Replace("القسم:", "").Trim();
            string subDepartmentName = srcExcelWs.Cells[2, 7].Value?.ToString().Replace("الوحدة:", "").Trim();
            int sctID = 0;
            int dptID = 0;
            int assetSubD = 0;
            List<string> newAssetsFoundByCodesList = new List<string>();
            if (activeUserRole.IsSectionIndependent != true)
            {
                if (sectionName != UserSectionName)
                {
                    return ("الدائرة المضمنة في ملف الإكسل غير مطابقة للدائرة التي يتبع لها الحساب النشط، لذا لا يمكن استيراد البيانات");
                }
            }
            if (activeUserRole.IsDepartmentIndependent != true)
            {
                if (sectionName != UserSectionName)
                {
                    return ("الدائرة المضمنة في ملف الإكسل غير مطابقة للدائرة التي يتبع لها الحساب النشط، لذا لا يمكن استيراد البيانات");
                }
                if (departmentName != UserDeptName)
                {
                    return ("القسم المضمن في ملف الإكسل غير مطابق للقسم الذي يتبع له الحساب النشط، لذا لا يمكن استيراد البيانات");
                }
            }
            if (!mainDbContext.SectionTbls.Any(sct1 => sct1.SectionName == sectionName)) // Section
            {
                if (sectionName.ToUpper() == StaticCode.PMName)
                {
                    assetSubD = StaticCode.GetDefaultSubDeptForPM();
                }
                else
                {
                    if (String.IsNullOrEmpty(sectionName) && String.IsNullOrEmpty(departmentName) && String.IsNullOrEmpty(subDepartmentName))
                    {
                        assetSubD = StaticCode.GetDefaultSubDeptForPM();
                    }
                    else
                    {
                        return ("الدائرة المضمنة في ملف الإكسل غير موجودة في سجلات الدوائر");
                    }
                }
            }
            else
            {
                sctID = mainDbContext.SectionTbls.Where(sct1 => sct1.SectionName == sectionName).First().ID;
                if (activeUserRole.IsSectionIndependent == true)
                {
                    if (sectionName.ToUpper() == StaticCode.PMName)
                    {
                        assetSubD = StaticCode.GetDefaultSubDeptForPM();
                    }
                    else
                    {
                        assetSubD = GetDefaultSubDeptBySectionID(sctID);
                    }
                }
                else // Department
                {
                    if (!mainDbContext.DepartmentVws.Any(dpt1 => dpt1.اسم_القسم == departmentName && dpt1.الدائرة_التي_يتبع_لها_القسم == sectionName))
                    {
                        if (String.IsNullOrEmpty(departmentName))
                        {
                            assetSubD = StaticCode.GetDefaultSubDeptBySectionID(sctID);
                        }
                        else
                        {
                            return ("القسم المضمن في ملف الإكسل غير موجودة في سجلات الأقسام أو لا يتبع للدائرة المضمنة في ملف الإكسل ذاته");
                        }
                    }
                    else
                    {
                        dptID = mainDbContext.DepartmentVws.Where(dpt1 => dpt1.اسم_القسم == departmentName && dpt1.الدائرة_التي_يتبع_لها_القسم == sectionName).First().معرف_القسم;
                        if (activeUserRole.IsDepartmentIndependent == true)
                        {
                            assetSubD = GetDefaultSubDeptByDeptID(dptID);
                        }
                        else // SubDepartment
                        {
                            var existedSubDept = mainDbContext.SubDepartmentVws.Where(fiv1 => fiv1.اسم_الوحدة == subDepartmentName && fiv1.القسم_التابعة_له == departmentName && fiv1.الدائرة_التي_يتبع_لها_القسم == sectionName);

                            if (!existedSubDept.Any())
                            {
                                if (String.IsNullOrEmpty(subDepartmentName))
                                {
                                    if (String.IsNullOrEmpty(departmentName))
                                    {
                                        assetSubD = StaticCode.GetDefaultSubDeptForPM();
                                    }
                                    else
                                    {
                                        assetSubD = StaticCode.GetDefaultSubDeptByDeptID(dptID);
                                    }
                                }
                                else
                                {
                                    return ("الوحدة المضمنة في ملف الإكسل غير موجودة في سجلات الوحدات أو لا تتبع للقسم والدائرة المضمنين في ملف الإكسل ذاته");
                                }
                            }
                            else
                            {
                                assetSubD = existedSubDept.First().معرف_الوحدة;
                            }
                        }
                    }
                }
            }

            List<string> unknownMinorCategories = new List<string>();
            List<int> existedFinancialItems = new List<int>();
            List<string> addedAssetsByCode = new List<string>();
            List<FinancialItemTbl> importedAssets = new List<FinancialItemTbl>();
            try
            {
                int rowStartNo = 5;
                int incomingAmountCol = 2;
                int outgoingAmountCol = 3;
                int currCol = 4;
                int incomingFromCol = 5;
                int outgoingTypeCol = 6;
                int descriptionCol = 7;
                int fiDateCol = 8;
                int fiCaCol = 9;
                bool isIncoming = true;
                while (rowStartNo <= srcExcelWs.Dimension.End.Row && srcExcelWs.Cells[rowStartNo, 7].Value?.ToString().Replace("ـ", "") != "الإجمالي")
                {
                    Application.DoEvents();

                    if (srcExcelWs.Cells[rowStartNo, 2].Value?.ToString() == "ثانياً : المصاريف :")
                    {
                        isIncoming = false;
                        rowStartNo++;
                    }
                    string ficaVal = srcExcelWs.Cells[rowStartNo, fiCaCol].Value?.ToString().Trim();
                    string curVal = srcExcelWs.Cells[rowStartNo, currCol].Value?.ToString().Trim();
                    if (String.IsNullOrEmpty(srcExcelWs.Cells[rowStartNo, descriptionCol].Value?.ToString().Trim()))
                    {
                        if (String.IsNullOrEmpty(curVal) || String.IsNullOrEmpty(ficaVal))
                        {
                            rowStartNo++;
                            break;
                        }
                        else
                        {
                            return ($"وصف السجل المالي في السطر {rowStartNo} فارغ");
                        }
                    }
                    string fiDescVal = srcExcelWs.Cells[rowStartNo, descriptionCol].Value?.ToString().Trim();
                    string incomingFromVal = (srcExcelWs.Cells[rowStartNo, incomingFromCol].Value == null) ? "" : srcExcelWs.Cells[rowStartNo, incomingFromCol].Value?.ToString().Trim();
                    string outgoingTypeVal = (srcExcelWs.Cells[rowStartNo, outgoingTypeCol].Value == null) ? "" : srcExcelWs.Cells[rowStartNo, outgoingTypeCol].Value?.ToString().Trim();
                    if (String.IsNullOrEmpty(srcExcelWs.Cells[rowStartNo, fiCaCol].Value?.ToString().Trim()))
                    {
                        return ($"اسم البند المالي في السطر {rowStartNo} فارغ");
                    }

                    double incomingAmountVal = 0;
                    if (isIncoming && !Double.TryParse(srcExcelWs.Cells[rowStartNo, incomingAmountCol].Value?.ToString(), out incomingAmountVal))
                    {
                        return ($"قيمة الوارد في السطر {rowStartNo} غير صحيحة");
                    }
                    incomingAmountVal = Math.Round(incomingAmountVal, 1);
                    double outgoingAmountVal = 0;
                    if (!isIncoming && !Double.TryParse(srcExcelWs.Cells[rowStartNo, outgoingAmountCol].Value?.ToString(), out outgoingAmountVal))
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
                    outgoingAmountVal = Math.Round(outgoingAmountVal, 1);
                    string incomingOrOutgoingVal = (isIncoming) ? "وارد" : "صادر";

                    string dateVal = srcExcelWs.Cells[rowStartNo, fiDateCol].Value?.ToString();
                    string dateExp = @"^[0-9]{2}-[0-9]{2}-[0-9]{4}$";
                    if (String.IsNullOrEmpty(dateVal) || !Regex.IsMatch(dateVal, dateExp))
                    {
                        return ($"قيمة التاريخ في السطر {rowStartNo} غير صحيحة");
                    }
                    int yearPart = Convert.ToInt32(dateVal.Substring(6, 4));
                    int monthPart = Convert.ToInt32(dateVal.Substring(3, 2));
                    int dayPart = Convert.ToInt32(dateVal.Substring(0, 2));
                    DateTime fiDateVal = new DateTime(yearPart, monthPart, dayPart);

                    if (!mainDbContext.CurrencyTbls.Any(cu1 => cu1.CurrencyName == curVal))
                    {
                        if (String.IsNullOrEmpty(srcExcelWs.Cells[rowStartNo, 3].Value?.ToString()) && String.IsNullOrEmpty(srcExcelWs.Cells[rowStartNo, fiDateCol].Value?.ToString()) && String.IsNullOrEmpty(ficaVal))
                        {
                            rowStartNo++;
                            continue;
                        }
                        return ($"العملة في السطر {rowStartNo} غير موجودة في جداول العملات");
                    }
                    int currID = mainDbContext.CurrencyTbls.Where(cu1 => cu1.CurrencyName == curVal).First().ID;
                    if (!mainDbContext.FinancialItemCategoryTbls.Any(fica1 => fica1.FinancialItemCategoryName == ficaVal))
                    {
                        unknownMinorCategories.Add($"{unknownMinorCategories.Count() + 1}- البند المالي: {ficaVal}");
                        rowStartNo++;
                        continue;
                    }
                    var existedFiItCat = mainDbContext.FinancialItemCategoryTbls.Where(fica1 => fica1.FinancialItemCategoryName == ficaVal);

                    var existedFiIt = StaticCode.mainDbContext.FinancialItemVws.Where(fiv1 => fiv1.الدائرة == sectionName && fiv1.القسم == departmentName && fiv1.الوحدة == subDepartmentName && fiv1.تاريخ_تحرير_السجل.Year == fiDateVal.Year && fiv1.تاريخ_تحرير_السجل.Month == fiDateVal.Month && fiv1.تاريخ_تحرير_السجل.Day == fiDateVal.Day && fiv1.وارد_أم_صادر == incomingOrOutgoingVal && fiv1.اسم_البند_المالي == ficaVal && fiv1.المبلغ_الوارد == incomingAmountVal && fiv1.المبلغ_الصادر == outgoingAmountVal && fiv1.العملة == curVal && fiv1.جهة_الإيراد == incomingFromVal && fiv1.نوع_الصادر == outgoingTypeVal);
                    if (existedFiIt.Any())
                    {
                        existedFinancialItems.Add(rowStartNo);
                        rowStartNo++;
                        continue;
                    }

                    if (ficaVal != null && ficaVal.Contains("مدور"))
                    {
                        rowStartNo++;
                        continue;
                    }
                    if (isIncoming)
                    {
                        if (incomingFromVal == "من المستوى الأعلى")
                        {
                            rowStartNo++;
                            continue;
                        }
                    }

                    FinancialItemTbl newFinancialItem = new FinancialItemTbl()
                    {
                        FinancialItemCategory = existedFiItCat.First().ID,
                        FinancialItemDescription = fiDescVal,
                        IncomingFrom = incomingFromVal,
                        OutgoingType = outgoingTypeVal,
                        OutgoingTo = "",
                        FinancialItemSubDept = assetSubD,
                        FinancialItemInsertionDate = fiDateVal,
                        FinancialItemCurrency = currID,
                        IncomingAmount = (isIncoming) ? incomingAmountVal : 0,
                        IncomingOrOutgoing = incomingOrOutgoingVal,
                        OutgoingAmount = (isIncoming) ? 0 : outgoingAmountVal,
                        AdditionalNotes = "",
                        AddingMethod = "Import/Excel",
                    };
                    importedAssets.Add(newFinancialItem);
                    rowStartNo++;

                    string ficaDesc = existedFiItCat.First().FinancialItemCategoryDetails;
                    //if (assetsStatements.Any(ast1 => ficaDesc.Contains(ast1)))
                    if (!isIncoming && ficaDesc.Contains(StaticCode.AssetAsFiCaStatement) && StaticCode.activeUserRole.AddNewAsset == true)
                    {
                        if (!StaticCode.mainDbContext.SquareTbls.Any(sq1 => sq1.SquareName == StaticCode.missingDataStatement))
                        {
                            StaticCode.mainDbContext.SquareTbls.InsertOnSubmit(new SquareTbl() { SquareName = StaticCode.missingDataStatement, SquareLocation = StaticCode.missingDataStatement });
                            StaticCode.mainDbContext.SubmitChanges();
                        }
                        if (!StaticCode.mainDbContext.EstateAreaUnitTbls.Any(esu1 => esu1.EstateAreaUnitName == StaticCode.missingDataStatement))
                        {
                            StaticCode.mainDbContext.EstateAreaUnitTbls.InsertOnSubmit(new EstateAreaUnitTbl() { EstateAreaUnitName = StaticCode.missingDataStatement });
                            StaticCode.mainDbContext.SubmitChanges();
                        }
                        AssetTbl newAssetByFoundCode = new AssetTbl()
                        {
                            AssetCode = GetTheNewAssetCode(codeIncVal++),
                            AssetSubDepartment = assetSubD,
                            AssetSpecifications = fiDescVal,
                            PurchaseDate = fiDateVal,
                            PurchasePrice = outgoingAmountVal,
                            PurchasePriceCurrency = currID,
                            ActualCurrentPrice = outgoingAmountVal,
                            AssetMinorCategory = GetMissingDataMinorCategory(),
                            DestructionRate = 0,
                            LifeSpanInMonths = 10000,
                            AssetSquare = StaticCode.mainDbContext.SquareTbls.Where(sq1 => sq1.SquareName == StaticCode.missingDataStatement).First().ID,
                            CurrentStatus = 1,
                            AddingMethod = "Import/Excel",
                            BenefitPercentage = "",
                            CarChassisNumber = "",
                            CarManufacturingYear = 0,
                            CarPanelNumber = "",
                            CarEngineNumber = "",
                            Color = "",
                            Volume = "",
                            OwnerName = "",
                            EstateOwnershipDocumentWith = "",
                            EstateAddress = "",
                            EstateArea = "",
                            EstateAreaUnit = StaticCode.mainDbContext.EstateAreaUnitTbls.Where(esu1 => esu1.EstateAreaUnitName == StaticCode.missingDataStatement).First().ID,
                            IsOldOrNewAsset = "جديد",
                            IsOutOfWork = false,
                            IsSold = false,
                            ItemsQuantity = 1,
                            Model = "",
                            OfUsed = "",
                            PlaceOfPresence = "",
                            CustodianName = StaticCode.missingDataStatement,
                            AssetNotes = missingDataStatement,
                            MoreDetails = missingDataStatement,
                        };

                        StaticCode.mainDbContext.AssetTbls.InsertOnSubmit(newAssetByFoundCode);
                    }
                }
            }
            catch
            {
                return ("ملف غير صحيح، نحتاج لاستيراد بيانات من ملف قياسي للسجلات المالية وفق النموذج المعتمد");
            }

            if (unknownMinorCategories.Any() || existedFinancialItems.Any())
            {
                string reportMsg = "";
                if (unknownMinorCategories.Count() > 0)
                {
                    reportMsg += $"هناك بعض البنود المالية غير موجودة في الجداول وهي:\r\n{String.Join("\r\n", unknownMinorCategories.ToArray())}\r\n\r\n";
                }
                if (existedFinancialItems.Count() > 0)
                {
                    reportMsg += $"هناك بعض السجلات المالية موجودة مسبقاً في الجداول وهي الأسطر ذات الأرقام: ({String.Join(", ", existedFinancialItems.ToArray())})\r\n\r\n";
                }
                return reportMsg;
            }
            mainDbContext.FinancialItemTbls.InsertAllOnSubmit(importedAssets);
            mainDbContext.SubmitChanges();
            return "Done!";
        }

        public static void AddRecycledOfLastYear()
        {
            string recycledStatement = "مدور محسوب لسنة " + (StaticCode.AppToday.Year - 1);
            int fiCaID = 0;
            if (!StaticCode.mainDbContext.FinancialItemCategoryTbls.Any(fica1 => fica1.FinancialItemCategoryName == "رصيد مدور" && fica1.IsIncomingOrOutgiung == "وارد"))

            {
                StaticCode.mainDbContext.FinancialItemCategoryTbls.InsertOnSubmit(new FinancialItemCategoryTbl() { FinancialItemCategoryName = "رصيد مدور", IsIncomingOrOutgiung = "وارد", FinancialItemCategoryDetails = "رصيد مدور", GroupName = "وارد" });
                StaticCode.mainDbContext.SubmitChanges();
            }
            fiCaID = StaticCode.mainDbContext.FinancialItemCategoryTbls.First(fica1 => fica1.FinancialItemCategoryName == "رصيد مدور" && fica1.IsIncomingOrOutgiung == "وارد").ID;
            foreach (CurrencyTbl oneCurr in StaticCode.mainDbContext.CurrencyTbls)
            {
                if (StaticCode.mainDbContext.FinancialItemVws.Any(fiv1 => fiv1.بيان_السجل_المالي == recycledStatement && fiv1.وارد_أم_صادر == "وارد" && fiv1.العملة == oneCurr.CurrencyName && fiv1.طريقة_الإضافة == "Calculated"))
                    continue;

                var allFiItsBeforeToday = StaticCode.mainDbContext.FinancialItemVws.Where(fiv1 => fiv1.تاريخ_تحرير_السجل < AppToday && fiv1.العملة == oneCurr.CurrencyName).GetTotalFinancialTableOfLevel_Default();

                FinancialItemTbl lastYearRecycledFiIt = new FinancialItemTbl()
                {
                    FinancialItemInsertionDate = StaticCode.AppToday,
                    IncomingOrOutgoing = "وارد",
                    IncomingAmount = allFiItsBeforeToday.CalcRecycledOfFinancialItems(),
                    OutgoingAmount = 0,
                    FinancialItemDescription = recycledStatement,
                    FinancialItemCurrency = oneCurr.ID,
                    IncomingFrom = "أخرى",
                    OutgoingTo = "",
                    OutgoingType = "",
                    FinancialItemSubDept = GetDefaultSubDeptForActiveUser(),
                    AddingMethod = "Calculated",
                    FinancialItemCategory = fiCaID,
                    AdditionalNotes = "",
                };
                StaticCode.mainDbContext.FinancialItemTbls.InsertOnSubmit(lastYearRecycledFiIt);
            }
            StaticCode.mainDbContext.SubmitChanges();
        }
        #endregion
    }

    public static class Extensions
    {
        public static double CalcIncomingOfFinancialItems(this IQueryable<FinancialItemVw> fivQry)
        {
            if (!fivQry.Any() || !fivQry.Any(fivi => fivi.وارد_أم_صادر == "وارد" && fivi.طريقة_الإضافة != "Calculated"))
                return 0;
            return (fivQry.Where(fivi => fivi.وارد_أم_صادر == "وارد" && fivi.طريقة_الإضافة != "Calculated").OrderByDescending(fiv22 => fiv22.جهة_الإيراد).Sum(fivi2 => fivi2.المبلغ_الوارد));
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

        public static double CalcRecycledOfFinancialItems(this IQueryable<FinancialItemVw> fivQry)
        {
            return fivQry.CalcIncomingOfFinancialItems() - fivQry.CalcOutgoingOfFinancialItems();
        }

        public static double CalcRecycledOfFinancialItems(this IQueryable<FinancialItemTbl> fiitQry)
        {
            List<int> includedIDs = fiitQry.Select(fiit => fiit.ID).ToList();
            var fivQry = StaticCode.mainDbContext.FinancialItemVws.Where(fiv => includedIDs.Contains(fiv.معرف_السجل_المالي));
            return (fivQry.CalcRecycledOfFinancialItems());
        }

        /// <summary>
        /// للحصول على الواردات من المستوى الأعلى مع الصادرات المباشرة فقط دون المعلقة للمستخدم الحالي فقط
        /// </summary>
        /// <param name="fivQry"></param>
        /// <returns></returns>
        public static IQueryable<FinancialItemVw> GetTotalFinancialTableOfLevel_Default(this IQueryable<FinancialItemVw> fivQry)
        {
            var fivResult = fivQry.Where(fiv1 => fiv1.طريقة_الإضافة != "Calculated");
            if (StaticCode.activeUserRole.IsSectionIndependent == true)
                fivResult = fivQry.Where(idoufv1 => (idoufv1.وارد_أم_صادر == "وارد" && (idoufv1.جهة_الإيراد == "أخرى" || (idoufv1.جهة_الإيراد == "من المستوى الأعلى" && idoufv1.الدائرة == StaticCode.PMName && idoufv1.القسم == StaticCode.PMName && idoufv1.الوحدة == StaticCode.PMName))) || (idoufv1.وارد_أم_صادر == "صادر" && idoufv1.نوع_الصادر == "صادرات مباشرة")).OrderByDescending(idoufv2 => idoufv2.وارد_أم_صادر);
            else if (StaticCode.activeUserRole.IsDepartmentIndependent == true)
                fivResult = fivQry.Where(idoufv2 => (idoufv2.وارد_أم_صادر == "وارد" && (idoufv2.جهة_الإيراد == "أخرى" || (idoufv2.جهة_الإيراد == "من المستوى الأعلى" && idoufv2.القسم == "" && idoufv2.الوحدة == ""))) || (idoufv2.وارد_أم_صادر == "صادر" && idoufv2.نوع_الصادر == "صادرات مباشرة")).OrderByDescending(idoufv2 => idoufv2.وارد_أم_صادر);
            else
                fivResult = fivQry.Where(idoufv3 => (idoufv3.وارد_أم_صادر == "وارد" && (idoufv3.جهة_الإيراد == "أخرى" || (idoufv3.جهة_الإيراد == "من المستوى الأعلى" && idoufv3.الوحدة == ""))) || (idoufv3.وارد_أم_صادر == "صادر" && idoufv3.نوع_الصادر == "صادرات مباشرة")).OrderByDescending(idoufv2 => idoufv2.وارد_أم_صادر);
            return (fivResult);
        }

        public static IQueryable<FinancialItemVw> GetTotalFinancialTableOfLevel_Default(this IQueryable<FinancialItemTbl> fiitQry)
        {
            List<int> includedIDs = fiitQry.Select(fiit => fiit.ID).ToList();
            var fivQry = StaticCode.mainDbContext.FinancialItemVws.Where(fivi => includedIDs.Contains(fivi.معرف_السجل_المالي));
            return (fivQry.GetTotalFinancialTableOfLevel_Default());
        }

        /// <summary>
        /// للحصول على الورادات من المستوى الأعلى مع الصادرات المباشرة فقط دون المعلقة حسب الدائرة والقسم والوحدة
        /// </summary>
        /// <param name="fivQry"></param>
        /// <param name="levelRank"></param>
        /// <param name="sectionName"></param>
        /// <param name="deptName"></param>
        /// <param name="subDeptName"></param>
        /// <returns></returns>
        public static IQueryable<FinancialItemVw> GetTotalFinancialTableOfLevel(this IQueryable<FinancialItemVw> fivQry, int levelRank, string sectionName, string deptName, string subDeptName)
        {
            var fivResult = fivQry;
            switch (levelRank)
            {
                case 1:
                    fivResult = fivQry.Where(idoufv1 => (idoufv1.وارد_أم_صادر == "وارد" && (idoufv1.جهة_الإيراد == "أخرى" || (idoufv1.جهة_الإيراد == "من المستوى الأعلى" && idoufv1.الدائرة == StaticCode.PMName && idoufv1.القسم == StaticCode.PMName && idoufv1.الوحدة == StaticCode.PMName))) || (idoufv1.وارد_أم_صادر == "صادر" && idoufv1.نوع_الصادر == "صادرات مباشرة")).OrderByDescending(idoufv2 => idoufv2.وارد_أم_صادر);
                    break;
                case 2:
                    fivResult = fivQry.Where(idoufv2 => (idoufv2.وارد_أم_صادر == "وارد" && (idoufv2.جهة_الإيراد == "أخرى" || (idoufv2.جهة_الإيراد == "من المستوى الأعلى" && idoufv2.الدائرة == sectionName && idoufv2.القسم == "" && idoufv2.الوحدة == ""))) || (idoufv2.وارد_أم_صادر == "صادر" && idoufv2.نوع_الصادر == "صادرات مباشرة")).OrderByDescending(idoufv2 => idoufv2.وارد_أم_صادر);
                    break;
                case 3:
                    fivResult = fivQry.Where(idoufv3 => (idoufv3.وارد_أم_صادر == "وارد" && (idoufv3.جهة_الإيراد == "أخرى" || (idoufv3.جهة_الإيراد == "من المستوى الأعلى" && idoufv3.الدائرة == sectionName && idoufv3.القسم == deptName && idoufv3.الوحدة == ""))) || (idoufv3.وارد_أم_صادر == "صادر" && idoufv3.نوع_الصادر == "صادرات مباشرة")).OrderByDescending(idoufv2 => idoufv2.وارد_أم_صادر);
                    break;
                case 4:
                    fivResult = fivQry.Where(idoufv4 => (idoufv4.وارد_أم_صادر == "وارد" && (idoufv4.جهة_الإيراد == "أخرى" || (idoufv4.جهة_الإيراد == "من المستوى الأعلى" && idoufv4.الدائرة == sectionName && idoufv4.القسم == deptName && idoufv4.الوحدة == subDeptName))) || (idoufv4.وارد_أم_صادر == "صادر" && idoufv4.نوع_الصادر == "صادرات مباشرة")).OrderByDescending(idoufv2 => idoufv2.وارد_أم_صادر);
                    break;
                default:
                    break;
            }
            return (fivResult);
        }

        public static IQueryable<FinancialItemVw> GetTotalFinancialTableOfLevel(this IQueryable<FinancialItemTbl> fiitQry, int levelRank, string sectionName, string deptName, string subDeptName)
        {
            List<int> includedIDs = fiitQry.Select(fiit => fiit.ID).ToList();
            var fivQry = StaticCode.mainDbContext.FinancialItemVws.Where(fivi => includedIDs.Contains(fivi.معرف_السجل_المالي));
            return (fivQry.GetTotalFinancialTableOfLevel(levelRank, sectionName, deptName, subDeptName));
        }

        public static int FindRelevantFinancialItem(this FinancialItemTbl currFiIt)
        {
            int releventRecordID = 0;
            string fiCaName = StaticCode.mainDbContext.FinancialItemCategoryTbls.Single(fica1 => fica1.ID == currFiIt.FinancialItemCategory).FinancialItemCategoryName;
            if (fiCaName == "موازنات صادرة")
            {
                var relativeRecordQry = StaticCode.mainDbContext.FinancialItemTbls.Where(rfi1 => rfi1.IncomingOrOutgoing == "وارد" && rfi1.IncomingAmount == currFiIt.OutgoingAmount && rfi1.FinancialItemCurrency == currFiIt.FinancialItemCurrency && rfi1.FinancialItemInsertionDate.Year == currFiIt.FinancialItemInsertionDate.Year && rfi1.FinancialItemInsertionDate.Month == currFiIt.FinancialItemInsertionDate.Month && rfi1.FinancialItemInsertionDate.Day == currFiIt.FinancialItemInsertionDate.Day && rfi1.IncomingFrom == "من المستوى الأعلى" && StaticCode.mainDbContext.FinancialItemCategoryTbls.Single(fica1 => fica1.ID == rfi1.FinancialItemCategory).FinancialItemCategoryName == "موازنات واردة");
                if (relativeRecordQry.Any())
                {
                    releventRecordID = relativeRecordQry.First().ID;
                }
            }
            else if (fiCaName == "موازنات واردة")
            {
                var relativeRecordQry = StaticCode.mainDbContext.FinancialItemTbls.Where(rfi1 => rfi1.IncomingOrOutgoing == "صادر" && rfi1.OutgoingAmount == currFiIt.IncomingAmount && rfi1.FinancialItemCurrency == currFiIt.FinancialItemCurrency && rfi1.FinancialItemInsertionDate.Year == currFiIt.FinancialItemInsertionDate.Year && rfi1.FinancialItemInsertionDate.Month == currFiIt.FinancialItemInsertionDate.Month && rfi1.FinancialItemInsertionDate.Day == currFiIt.FinancialItemInsertionDate.Day && rfi1.OutgoingType == "صادرات معلقة" && StaticCode.mainDbContext.FinancialItemCategoryTbls.Single(fica1 => fica1.ID == rfi1.FinancialItemCategory).FinancialItemCategoryName == "موازنات صادرة");
                if (relativeRecordQry.Any())
                {
                    releventRecordID = relativeRecordQry.First().ID;
                }
            }
            return releventRecordID;
        }
    }
}