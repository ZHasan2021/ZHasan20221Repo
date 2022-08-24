using Kindergarten.Students;
using Kindergarten.AuxTables;
using Kindergarten.Finance;
using Kindergarten.Options;
using Kindergarten.Properties;
using Kindergarten.Users;
using DevExpress.XtraReports.UI;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kindergarten
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ApplyUserRolesOnInterface()
        {
            activeUserToolStripStatusLabel.Text = $"المستخدم النشط: ( {StaticCode.activeUser.Username})";
            activeUserRoleToolStripStatusLabel.Text = $"نوع الحساب النشط: ( {StaticCode.activeUserRole.RoleName})";
            StaticCode.activeUserOptions.ActiveUser = StaticCode.activeUser.ID;
            StaticCode.mainDbContext.SubmitChanges();

            addNewStudentBarButtonItem.Visibility = (StaticCode.activeUserRole.AddNewStudent == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageStudentTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageStudentTbl == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            deleteStudentsBarButtonItem.Visibility = (StaticCode.activeUserRole.DeleteStudentRecord == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageEducationalLevelTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageEducationalLevels == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageFeePeriodTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageFeePeriods == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageScholasticYearTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageScholasticYears == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            addNewUserBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageUsers == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageUserTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageUsers == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageUserRoleTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageUsers == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            backupDbBarButtonItem.Visibility = (StaticCode.activeUserRole.BackupDb == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            restoreDbBarButtonItem.Visibility = (StaticCode.activeUserRole.RestoreDb == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            exportDataBarButtonItem.Visibility = (StaticCode.activeUserRole.ExportAllData == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            importDataBarButtonItem.Visibility = (StaticCode.activeUserRole.ImportAllData == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            viewReportsBarButtonItem.Visibility = (StaticCode.activeUserRole.ViewStudentsReports == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            viewStatsBarButtonItem.Visibility = (StaticCode.activeUserRole.ViewStudentsStats == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            prepareFinancialReportsBarButtonItem.Visibility = (StaticCode.activeUserRole.ViewFinancialReports == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;

            ApplyUserRolesOnInterface();
        }

        private void exportDataBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dataModel = new AttributeMappingSource().GetModel(typeof(KindergartenDbDataContext));
            var tbls = dataModel.GetTables();
            if (!Directory.Exists(StaticCode.ExportFolder))
                Directory.CreateDirectory(StaticCode.ExportFolder);
            string outFile1 = $"{StaticCode.ExportFolder}AssetMngDb{DateTime.Now.Ticks}.xlsx";
            SqlConnection dbConn = new SqlConnection(new Properties.Settings().KindergartenDbConnectionString);
            if (dbConn.State != ConnectionState.Open)
                dbConn.Open();
            try
            {
                using (ExcelPackage pck = new ExcelPackage(outFile1))
                {
                    foreach (var oneModel in tbls)
                    {
                        string oneTblName = oneModel.TableName.Replace("dbo.", "");
                        ExcelWorksheet ws = pck.Workbook.Worksheets[oneTblName];
                        if (ws == null)
                            ws = pck.Workbook.Worksheets.Add(oneTblName);
                        SqlDataAdapter dbAdpt = new SqlDataAdapter($"SELECT * FROM [{oneTblName}]", dbConn);
                        DataTable oneDt = new DataTable();
                        dbAdpt.Fill(oneDt);
                        if (oneDt.Rows.Count > 0)
                        {
                            using (var cells = ws.Cells[1, 1, oneDt.Rows.Count, oneDt.Columns.Count])
                            {
                                cells.Style.Numberformat.Format = "@";
                            }
                        }
                        ws.Cells["A1"].LoadFromDataTable(oneDt, true, OfficeOpenXml.Table.TableStyles.Light19);
                        pck.Save();
                    }
                }
                if (encryptExportedFileBarCheckItem.Checked)
                {
                    #region Aes encryption
                    if (!File.Exists(StaticCode.AesKeyAndIVPath))
                    {
                        if (MessageBox.Show("لا يوجد مفاتيح تشفير حالياً ونحتاج إلى توليد هذه المفاتيح، هل تريد المتابعة؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                            return;
                        StaticCode.GenerateNewAesKeyAndIV();
                    }
                    try
                    {
                        FileStream key_IVRdr = new FileStream(StaticCode.AesKeyAndIVPath, FileMode.Open);
                        byte[] keyArr = new byte[32];
                        byte[] IVArr = new byte[16];
                        key_IVRdr.Read(keyArr, 0, keyArr.Length);
                        key_IVRdr.Read(IVArr, 0, IVArr.Length);
                        key_IVRdr.Close();

                        string outFile_Enc = outFile1.Replace("xlsx", "assf");
                        if (StaticCode.AesEncryption(outFile1, outFile_Enc, keyArr, IVArr))
                        {
                            File.Delete(outFile1);
                            mainAlertControl.Show(this, "تم تصدير قاعدة البيانات مشفرة بنجاح", StaticCode.ApplicationTitle, true);
                        }
                        else
                        {
                            mainAlertControl.Show(this, "لم يتم تصدير قاعدة البيانات المشفرة بسبب خطأ في مفتاح التشفير، يمكنك إعادة توليده مرة ثانية", StaticCode.ApplicationTitle, true);
                        }
                    }
                    catch
                    {
                        mainAlertControl.Show(this, "خطأ في تصدير ملف مشفر", StaticCode.ApplicationTitle, true);
                    }
                    #endregion
                }
                else
                {
                    mainAlertControl.Show(this, "تم تصدير قاعدة البيانات بنجاح", StaticCode.ApplicationTitle, true);
                }
            }
            catch
            {
                mainAlertControl.Show(this, "لم يتم تصدير قاعدة البيانات، حاولا لاحقاً", StaticCode.ApplicationTitle, true);
            }
        }

        private void addNewAssetBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddNewStudentForm stdRes = new AddNewStudentForm();
            stdRes.ShowDialog();
        }

        private void manageAssetTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageStudentTblForm mngFrm = new ManageStudentTblForm();
            mngFrm.ShowDialog();
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            appDateBarStaticItem.Caption = DateTime.Today.AddDays(StaticCode.ShiftDays).ToString("dddd, MMMM dd, yyyy");
            appTimeBarStaticItem.Caption = DateTime.Now.AddSeconds(StaticCode.ShiftSeconds).ToLongTimeString();
        }

        private void viewReportsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //StudentsXtraReport repFrm = new StudentsXtraReport();
            //repFrm.ShowPreviewDialog();
        }

        private void addNewUserBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddNewUserForm usrFrm = new AddNewUserForm();
            usrFrm.ShowDialog();
        }

        private void manageUserTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageUserTblForm mngusrFrm = new ManageUserTblForm();
            mngusrFrm.ShowDialog();
        }

        private void loginBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoginForm logFrm = new LoginForm();
            DialogResult logResult = logFrm.ShowDialog();
            if (logResult == DialogResult.OK)
            {
                ApplyUserRolesOnInterface();
            }
        }

        private void manageUserRoleTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageUserRoleTblForm mngusrrlFrm = new ManageUserRoleTblForm();
            mngusrrlFrm.ShowDialog();

            ApplyUserRolesOnInterface();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("هل تريد بالتاكيد إغلاق البرنامج؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void backupDbBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Directory.Exists(StaticCode.BackupFolder))
                Directory.CreateDirectory(StaticCode.BackupFolder);
            string backupDbFileName = $"{StaticCode.BackupFolder}AssetMngDb{DateTime.Now.Ticks}.bak";
            bool dbBackedup = StaticCode.BackupDb(backupDbFileName);
            if (dbBackedup)
                mainAlertControl.Show(this, "تم النسخ الاحتياطي بنجاح", StaticCode.ApplicationTitle);
            else
                mainAlertControl.Show(this, "لم يتم النسخ الاحتياطي، حاول لاحقاً", StaticCode.ApplicationTitle);
        }

        private void restoreDbBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("هل تريد بالتاكيد استعادة نسخة سابقة من قاعدة البيانات؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            OpenFileDialog bakOFD = new OpenFileDialog() { Filter = "Backup file (*.bak)|*.bak" };
            if (bakOFD.ShowDialog() != DialogResult.OK)
            {
                mainAlertControl.Show(this, "تم الإلغاء", StaticCode.ApplicationTitle);
                return;
            }
            bool dbRestored = StaticCode.RestoreDb(bakOFD.FileName);
            if (dbRestored)
            {
                mainAlertControl.Show(this, "تم استعادة قاعدة البيانات لكن تحتاج لإعادة تشغيل البرنامج ليتم تطبيق التغييرات", StaticCode.ApplicationTitle);
            }
            else
            {
                mainAlertControl.Show(this, "لم يتم استعادة قاعدة البيانات، حاول لاحقاُ", StaticCode.ApplicationTitle);
            }
        }

        private void optionsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OptionsForm optFrm = new OptionsForm();
            optFrm.ShowDialog();
        }

        private void importDataBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog encFileOFD = new OpenFileDialog() { Filter = (decryptImportedFileBarCheckItem.Checked) ? "encrypted database file (*.assf)|*.assf" : "Excel worbook 2007-2022 (*.xlsx)|*.xlsx" };
            if (encFileOFD.ShowDialog() != DialogResult.OK)
            {
                mainAlertControl.Show(this, "تم الإلغاء", StaticCode.ApplicationTitle);
                return;
            }
            string importedExcelFilePath = encFileOFD.FileName;
            if (decryptImportedFileBarCheckItem.Checked)
            {
                FileStream AesKey_IV_Rd = File.Open(StaticCode.AesKeyAndIVPath, FileMode.OpenOrCreate);
                byte[] AesKey_IV_Dec = new byte[48];
                AesKey_IV_Rd.Read(AesKey_IV_Dec, 0, 48);
                AesKey_IV_Rd.Close();
                byte[] AesKey = new byte[32];
                byte[] AesIV = new byte[16];
                Array.Copy(AesKey_IV_Dec, 0, AesKey, 0, 32);
                Array.Copy(AesKey_IV_Dec, 32, AesIV, 0, 16);
                //byte[] outBytes_enc = Encoding.UTF8.GetBytes(encryptedStr);
                importedExcelFilePath = encFileOFD.FileName.Replace(".assf", ".xlsx");
                bool decrypted = StaticCode.AesDecryption(encFileOFD.FileName, importedExcelFilePath, AesKey, AesIV);
                if (!decrypted)
                {
                    mainAlertControl.Show(this, "الملف المستورد غير صالح أو أن مفاتيح فك التشفير تم تغييرها ولا تطابق مفاتيح التشفير", StaticCode.ApplicationTitle);
                    return;
                }
            }
            try
            {
                StaticCode.ImportDataFromExcel(importedExcelFilePath);
                mainAlertControl.Show(this, "تم استيراد البيانات بشكل سليم", StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "خطأ في الوصول إلى الملف، تأكد من سلامة الملف أولاً", StaticCode.ApplicationTitle);
            }
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.BackColor = Color.DarkGreen;
            e.AlertForm.ForeColor = Color.Black;
            e.AlertForm.StartPosition = FormStartPosition.Manual;
            e.AlertForm.Location = new Point(500, 400);
        }

        private void viewStatsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void prepareFinancialReportsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void openAppFolderBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start(Application.StartupPath);
        }

        private void openEencryptionKeysFolderRarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start(StaticCode.AesKeyAndIVFolder);
        }

        private void openBackupFolderBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start(StaticCode.BackupFolder);
        }

        private void openExportFolderBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start(StaticCode.ExportFolder);
        }

        private void manageScholasticYearTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageScholasticYearTblForm schfrm = new ManageScholasticYearTblForm();
            schfrm.ShowDialog();
        }

        private void manageEducationalLevelTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageEducationalLevelTblForm mngel = new ManageEducationalLevelTblForm();
            mngel.ShowDialog();
        }

        private void manageFeePeriodTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageFeePeriodTblForm feefrm = new ManageFeePeriodTblForm();
            feefrm.ShowDialog();
        }

        private void deleteStudentsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}