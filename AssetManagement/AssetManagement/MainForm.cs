﻿using AssetManagement.Assets;
using AssetManagement.AuxTables;
using AssetManagement.Finance;
using AssetManagement.Options;
using AssetManagement.Properties;
using AssetManagement.Users;
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

namespace AssetManagement
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        IQueryable<AssetTbl> assetsToDestructList = null;

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

            addNewAssetBarButtonItem.Visibility = importFormerAssetsFromExcelBarButtonItem.Visibility = (StaticCode.activeUserRole.AddNewAsset == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            addNewMainCategoryBarButtonItem.Visibility = (StaticCode.activeUserRole.AddNewMainCategory == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            addNewMinorCategoryBarButtonItem.Visibility = (StaticCode.activeUserRole.AddNewMinorCategory == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            updateExistedAssetBarButtonItem.Visibility = (StaticCode.activeUserRole.UpdateExistedAsset == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageAssetTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageAssetTbl == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            addNewAssetMovementBarButtonItem.Visibility = (StaticCode.activeUserRole.AddNewAssetMovement == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            addNewAssetTransactionBarButtonItem.Visibility = (StaticCode.activeUserRole.AddNewAssetTransaction == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageAssetMovementTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageAssetMovements == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageAssetTransactionTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageAssetTransactions == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageCategoriesBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageMainCategories == true && StaticCode.activeUserRole.ManageMinorCategories == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageCurrencyTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageCurrencies == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageDepartmentTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageDepartments == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageSubDepartmentTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageSubDepartments == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageSectionTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageSections == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageSquareTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageSquares == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageModelTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageModels == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageEstateAreaUnitTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageEstateAreaUnits == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageTransactionTypeTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageTransactionTypes == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            addNewAssetInventoryBarButtonItem.Visibility = (StaticCode.activeUserRole.CreateInventoryReport == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            setAppDateAndTimeBarButtonItem.Visibility = (StaticCode.activeUserRole.SetDateAndTime == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            addNewUserBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageUsers == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageUserTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageUsers == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageUserRoleTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageUsers == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            backupDbBarButtonItem.Visibility = (StaticCode.activeUserRole.BackupDb == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            restoreDbBarButtonItem.Visibility = (StaticCode.activeUserRole.RestoreDb == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            deleteAssetsBarButtonItem.Visibility = (StaticCode.activeUserRole.DeleteAssetRecord == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            exportDataBarButtonItem.Visibility = (StaticCode.activeUserRole.ExportAllData == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            importDataBarButtonItem.Visibility = (StaticCode.activeUserRole.ImportAllData == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageImportExportTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageImportExportTbl == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            viewReportsBarButtonItem.Visibility = (StaticCode.activeUserRole.ViewAssetsReports == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            viewStatsBarButtonItem.Visibility = (StaticCode.activeUserRole.ViewAssetsStats == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            addNewFinancialItemBarButtonItem.Visibility = (StaticCode.activeUserRole.AddNewFinancialItem == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageFinancialItemsBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageFinancialItems == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageFinancialItemCategoryTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageFinancialItemCategories == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            prepareFinancialReportsBarButtonItem.Visibility = (StaticCode.activeUserRole.ViewFinancialReports == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void UpdateAssetToDestructLabel()
        {
            assetsToDestructList = StaticCode.GetAssetsToDestruct();
            assetsToDestructBarStaticItem.Visibility = (assetsToDestructList.Count() > 0) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            assetsToDestructBarStaticItem.Caption = $"عدد الأصول التي أوشكت على الاهتلاك هو: ({assetsToDestructList.Count()})";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;

            ApplyUserRolesOnInterface();
            UpdateAssetToDestructLabel();
        }

        private void exportDataBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportForm expFrm = new ExportForm();
            expFrm.ShowDialog();
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
            CustomAssetsForm cuFrm = new CustomAssetsForm();
            cuFrm.ShowDialog();
            UpdateAssetToDestructLabel();
        }

        private void categoriesBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //ManageCategoriesTblsForm catFrm = new ManageCategoriesTblsForm();
            //catFrm.ShowDialog();
            ManageMainCategoryTblForm macaFrm = new ManageMainCategoryTblForm();
            macaFrm.ShowDialog();
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            appDateBarStaticItem.Caption = DateTime.Today.AddDays(StaticCode.appOptions.ShiftDays).ToString("dddd, MMMM dd, yyyy");
            appTimeBarStaticItem.Caption = DateTime.Now.AddSeconds(StaticCode.appOptions.ShiftSeconds).ToLongTimeString();
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
            AssetsXtraReport repFrm = new AssetsXtraReport();
            repFrm.ShowPreviewDialog();
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
            ManageAssetMovementTblForm astmvFrm = new ManageAssetMovementTblForm();
            astmvFrm.ShowDialog();
        }

        private void manageAssetTransactionTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageAssetTransactionTblForm asttsFrm = new ManageAssetTransactionTblForm();
            asttsFrm.ShowDialog();
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
            UpdateAssetToDestructLabel();
        }

        private void importDataBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ImportForm impFrm = new ImportForm();
            impFrm.ShowDialog();
            UpdateAssetToDestructLabel();
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
            AssetsStatsForm statFrm = new AssetsStatsForm();
            statFrm.ShowDialog();
        }

        private void setAppDateAndTimeBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetAppDateAndTimeForm appDtFrm = new SetAppDateAndTimeForm();
            appDtFrm.ShowDialog();
        }

        private void manageFinancialItemCategoryTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageFinancialItemCategoryTblForm ficFrm = new ManageFinancialItemCategoryTblForm();
            ficFrm.ShowDialog();
        }

        private void addNewFinancialItemBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddNewFinancialItemForm newFinFrm = new AddNewFinancialItemForm();
            newFinFrm.ShowDialog();
        }

        private void manageFinancialItemsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageFinancialItemTblForm fiItFrm = new ManageFinancialItemTblForm();
            fiItFrm.Show();
        }

        private void prepareFinancialReportsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FinancialReportsForm fiRpFrm = new FinancialReportsForm();
            fiRpFrm.ShowDialog();
        }

        private void updateExistedAssetBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateExistedAssetForm updFrm = new UpdateExistedAssetForm();
            updFrm.ShowDialog();
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

        private void assetsToDestructBarStaticItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AssetsToDestructForm desFrm = new AssetsToDestructForm(assetsToDestructList);
            desFrm.ShowDialog();
            UpdateAssetToDestructLabel();
        }

        private void openExportFolderBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start(StaticCode.ExportFolder);
        }

        private void manageModelTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageModelTblForm mdlFrm = new ManageModelTblForm();
            mdlFrm.ShowDialog();
        }

        private void manageSubDepartmentTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageSubDepartmentTblForm sdptFrm = new ManageSubDepartmentTblForm();
            sdptFrm.ShowDialog();
        }

        private void importFormerAssetsFromExcelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void manageImportExportTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageImportExportTblForm ieFrm = new ManageImportExportTblForm();
            ieFrm.ShowDialog();
        }

        private void helpBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start($"{Application.StartupPath}//Help//مساعد إدارة الأصول.docx");
        }
    }
}