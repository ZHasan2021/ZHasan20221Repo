using AssetManagement.Assets;
using AssetManagement.AuxTables;
using AssetManagement.Options;
using AssetManagement.Properties;
using AssetManagement.Users;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ApplyUserRolesOnInterface()
        {
            activeUserRoleBarStaticItem.Caption = $"الحساب النشط {StaticCode.activeUserRole.RoleName}";
            StaticCode.activeUserOptions.ActiveUser = StaticCode.activeUser.ID;
            StaticCode.mainDbContext.SubmitChanges();

            addNewAssetBarButtonItem.Visibility = (StaticCode.activeUserRole.AddNewAsset == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            addNewMainCategoryBarButtonItem.Visibility = (StaticCode.activeUserRole.AddNewMainCategory == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            addNewMinorCategoryBarButtonItem.Visibility = (StaticCode.activeUserRole.AddNewMinorCategory == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            modifyExistedAssetBarButtonItem.Visibility = (StaticCode.activeUserRole.UpdateExistedAsset == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageCategoriesBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageMainCategories == true && StaticCode.activeUserRole.ManageMinorCategories == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageCurrencyTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageCurrencies == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageDepartmentTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageDepartments == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageSectionTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageSections == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageSquareTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageSquares == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageEstateAreaUnitTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageEstateAreaUnits == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageTransactionTypeTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageTransactionTypes == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            addNewAssetInventoryBarButtonItem.Visibility = (StaticCode.activeUserRole.AddNewInventory == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageAssetInventoryTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ViewInventories == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            setAppDateAndTimeBarButtonItem.Visibility = (StaticCode.activeUserRole.SetDateAndTime == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            addNewAssetMovementBarButtonItem.Visibility = (StaticCode.activeUserRole.AddNewAssetMovement == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            addNewAssetTransactionBarButtonItem.Visibility = (StaticCode.activeUserRole.AddNewAssetTransaction == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            addNewUserBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageUsers == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageUserTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageUsers == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageUserRoleTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageUsers == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            backupDbBarButtonItem.Visibility = (StaticCode.activeUserRole.BackupDb == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            restoreDbBarButtonItem.Visibility = (StaticCode.activeUserRole.RestoreDb == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            deleteAssetsBarButtonItem.Visibility = (StaticCode.activeUserRole.DeleteAssetRecord == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            exportDataBarButtonItem.Visibility = (StaticCode.activeUserRole.ExportAllData == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            importDataBarButtonItem.Visibility = (StaticCode.activeUserRole.ImportAllData == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            viewStatsBarButtonItem.Visibility = (StaticCode.activeUserRole.ViewStats == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;

            ApplyUserRolesOnInterface();
        }

        private void exportDataBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dataModel = new AttributeMappingSource().GetModel(typeof(AssetMngDbDataContext));
            var tbls = dataModel.GetTables();
            if (!Directory.Exists(StaticCode.ExportFolder))
                Directory.CreateDirectory(StaticCode.ExportFolder);
            string outFile1 = $"{StaticCode.ExportFolder}AssetMngDb{DateTime.Now.Ticks}.xlsx";
            SqlConnection dbConn = new SqlConnection(new Properties.Settings().AssetMngDbConnectionString);
            if (dbConn.State != ConnectionState.Open)
                dbConn.Open();
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
                    mainAlertControl.Show(this, "Error exporting encrypted file!", StaticCode.ApplicationTitle, true);
                }
                #endregion
            }
        }

        private void addNewAssetBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddNewAssetForm newAsstFrm = new AddNewAssetForm();
            DialogResult frmRes = newAsstFrm.ShowDialog();
            if (frmRes == DialogResult.OK)
                mainAlertControl.Show(this, "تم إضافة الأصل بنجاح", StaticCode.ApplicationTitle);
        }

        private void manageAssetTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageAssetTblForm mngFrm = new ManageAssetTblForm();
            mngFrm.ShowDialog();
        }

        private void categoriesBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageCategoriesTblsForm catFrm = new ManageCategoriesTblsForm();
            catFrm.ShowDialog();
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            appDateBarStaticItem.Caption = DateTime.Today.AddDays(StaticCode.ShiftDays).ToString("dddd, MMMM dd, yyyy");
            appTimeBarStaticItem.Caption = DateTime.Now.AddSeconds(StaticCode.ShiftSeconds).ToLongTimeString();
        }

        private void setAppDateAndTimeBarStaticItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (StaticCode.activeUserRole.SetDateAndTime == true)
            {
                SetAppDateAndTimeForm setdtFrm = new SetAppDateAndTimeForm();
                setdtFrm.ShowDialog();
            }
        }

        private void viewReportsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void manageCurrencyTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageCurrencyTblForm curFrm = new ManageCurrencyTblForm();
            curFrm.ShowDialog();
        }

        private void manageDepartmentTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageDepartmentTblForm dptFrm = new ManageDepartmentTblForm();
            dptFrm.ShowDialog();
        }

        private void manageSectionTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageSectionTblForm secFrm = new ManageSectionTblForm();
            secFrm.ShowDialog();
        }

        private void manageSquareTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageSquareTblForm squFrm = new ManageSquareTblForm();
            squFrm.ShowDialog();
        }

        private void manageEstateAreaUnitTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageEstateAreaUnitTblForm eauFrm = new ManageEstateAreaUnitTblForm();
            eauFrm.ShowDialog();
        }

        private void manageTransactionTypeTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageTransactionTypeTblForm ttyFrm = new ManageTransactionTypeTblForm();
            ttyFrm.ShowDialog();
        }

        private void addNewMainCategoryBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageCategoriesTblsForm catFrm = new ManageCategoriesTblsForm();
            catFrm.ShowDialog();
        }

        private void addNewMinorCategoryBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddNewMinorCategoryForm addFrm = new AddNewMinorCategoryForm();
            addFrm.ShowDialog();
        }

        private void addNewAssetMovementBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MoveAssetForm mvFrm = new MoveAssetForm();
            mvFrm.ShowDialog();
        }

        private void addNewAssetTransactionBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TransacteAssetForm trsFrm = new TransacteAssetForm();
            trsFrm.ShowDialog();
        }

        private void manageAssetMovementTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void manageAssetTransactionTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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

        private void addNewAssetInventoryBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewAssetInventoryForm invFrm = new NewAssetInventoryForm();
            invFrm.ShowDialog();
        }

        private void manageAssetInventoryTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void deleteAssetsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteAssetForm dFrm = new DeleteAssetForm();
            dFrm.ShowDialog();
        }

        private void optionsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OptionsForm optFrm = new OptionsForm();
            optFrm.ShowDialog();
        }

        private void importDataBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //StreamReader AesKey_IV_Rd = new StreamReader(StaticCode.AesKeyAndIVPath);
            //string qqq = AesKey_IV_Rd.ReadLine();
            //AesKey_IV_Rd.Close();
            //byte[] aaa = Convert.FromBase64String(qqq);
            //byte[] AesKey_IV_Enc = StaticCode.RSADecryption(aaa);

            //byte[] outBytes_enc = Encoding.UTF8.GetBytes(encryptedStr);
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
        }

        private void viewStatsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AssetsStatsForm statFrm = new AssetsStatsForm();
            statFrm.ShowDialog();
        }

        private void setAppDateAndTimeBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetAppDateAndTimeForm appDtFrm = new SetAppDateAndTimeForm();
            appDtFrm.ShowDialog();
        }
    }
}