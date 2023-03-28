
using AssetManagement.AuxTables;

namespace AssetManagement.Users
{
    partial class ManageUserRoleTblForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUserRoleTblForm));
            this.userRoleGridControl = new DevExpress.XtraGrid.GridControl();
            this.userRoleTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.userRoleGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewAsset = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageAssetTbl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateExistedAsset = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateSubDepartmentForExistedAsset = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdatePurchasePriceForExistedAsset = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleteAssetRecord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewAssetsReports = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewAssetsStats = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateInventoryReport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewAssetMovement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageAssetMovements = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewAssetTransaction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageAssetTransactions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExportAllData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImportAllData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageImportExportTbl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageUsers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewSessionActionsLog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPromoteDb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewMainCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageMainCategories = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewMinorCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageMinorCategories = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewSection = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageSections = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageDepartments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewSubDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageSubDepartments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewSquare = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageSquares = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageCurrencies = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageModels = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewEstateAreaUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageEstateAreaUnits = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewTransactionType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageTransactionTypes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewIncomingType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageIncomingTypes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewOutgoingType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageOutgoingTypes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewFinancialItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageFinancialItems = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateExistedFinancialItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleteFinancialItemRecord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewFinancialReports = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewFinancialItemsStats = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewFinancialItemCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageFinancialItemCategories = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSetDateAndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBackupDb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRestoreDb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateAssetsReports = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSectionIndependent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDepartmentIndependent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.userRoleTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.UserRoleTblTableAdapter();
            this.userRoleTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.userRoleTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleTblBindingNavigator)).BeginInit();
            this.userRoleTblBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // userRoleGridControl
            // 
            this.userRoleGridControl.DataSource = this.userRoleTblBindingSource;
            this.userRoleGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "userRoleLevel";
            this.userRoleGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.userRoleGridControl.Location = new System.Drawing.Point(0, 47);
            this.userRoleGridControl.MainView = this.userRoleGridView;
            this.userRoleGridControl.Name = "userRoleGridControl";
            this.userRoleGridControl.Size = new System.Drawing.Size(1301, 701);
            this.userRoleGridControl.TabIndex = 8;
            this.userRoleGridControl.UseEmbeddedNavigator = true;
            this.userRoleGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.userRoleGridView});
            // 
            // userRoleTblBindingSource
            // 
            this.userRoleTblBindingSource.DataMember = "UserRoleTbl";
            this.userRoleTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userRoleGridView
            // 
            this.userRoleGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colRoleName,
            this.colAddNewAsset,
            this.colManageAssetTbl,
            this.colUpdateExistedAsset,
            this.colUpdateSubDepartmentForExistedAsset,
            this.colUpdatePurchasePriceForExistedAsset,
            this.colDeleteAssetRecord,
            this.colViewAssetsReports,
            this.colViewAssetsStats,
            this.colCreateInventoryReport,
            this.colAddNewAssetMovement,
            this.colManageAssetMovements,
            this.colAddNewAssetTransaction,
            this.colManageAssetTransactions,
            this.colExportAllData,
            this.colImportAllData,
            this.colManageImportExportTbl,
            this.colManageUsers,
            this.colViewSessionActionsLog,
            this.colPromoteDb,
            this.colAddNewMainCategory,
            this.colManageMainCategories,
            this.colAddNewMinorCategory,
            this.colManageMinorCategories,
            this.colAddNewSection,
            this.colManageSections,
            this.colAddNewDepartment,
            this.colManageDepartments,
            this.colAddNewSubDepartment,
            this.colManageSubDepartments,
            this.colAddNewSquare,
            this.colManageSquares,
            this.colAddNewCurrency,
            this.colManageCurrencies,
            this.colAddNewModel,
            this.colManageModels,
            this.colAddNewEstateAreaUnit,
            this.colManageEstateAreaUnits,
            this.colAddNewTransactionType,
            this.colManageTransactionTypes,
            this.colAddNewIncomingType,
            this.colManageIncomingTypes,
            this.colAddNewOutgoingType,
            this.colManageOutgoingTypes,
            this.colAddNewFinancialItem,
            this.colManageFinancialItems,
            this.colUpdateExistedFinancialItem,
            this.colDeleteFinancialItemRecord,
            this.colViewFinancialReports,
            this.colViewFinancialItemsStats,
            this.colAddNewFinancialItemCategory,
            this.colManageFinancialItemCategories,
            this.colSetDateAndTime,
            this.colBackupDb,
            this.colRestoreDb,
            this.colCreateAssetsReports,
            this.colIsSectionIndependent,
            this.colIsDepartmentIndependent});
            this.userRoleGridView.GridControl = this.userRoleGridControl;
            this.userRoleGridView.Name = "userRoleGridView";
            // 
            // colID
            // 
            this.colID.Caption = "معرف نوع الحساب";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 80;
            this.colID.Name = "colID";
            this.colID.Width = 94;
            // 
            // colRoleName
            // 
            this.colRoleName.Caption = "اسم نوع الحساب";
            this.colRoleName.FieldName = "RoleName";
            this.colRoleName.MinWidth = 150;
            this.colRoleName.Name = "colRoleName";
            this.colRoleName.Visible = true;
            this.colRoleName.VisibleIndex = 0;
            this.colRoleName.Width = 178;
            // 
            // colAddNewAsset
            // 
            this.colAddNewAsset.Caption = "إضافة أصل جديد";
            this.colAddNewAsset.FieldName = "AddNewAsset";
            this.colAddNewAsset.MinWidth = 150;
            this.colAddNewAsset.Name = "colAddNewAsset";
            this.colAddNewAsset.Visible = true;
            this.colAddNewAsset.VisibleIndex = 1;
            this.colAddNewAsset.Width = 150;
            // 
            // colManageAssetTbl
            // 
            this.colManageAssetTbl.Caption = "إدارة سجلات الأصول";
            this.colManageAssetTbl.FieldName = "ManageAssetTbl";
            this.colManageAssetTbl.MinWidth = 150;
            this.colManageAssetTbl.Name = "colManageAssetTbl";
            this.colManageAssetTbl.Visible = true;
            this.colManageAssetTbl.VisibleIndex = 55;
            this.colManageAssetTbl.Width = 150;
            // 
            // colUpdateExistedAsset
            // 
            this.colUpdateExistedAsset.Caption = "تعديل أصل موجود";
            this.colUpdateExistedAsset.FieldName = "UpdateExistedAsset";
            this.colUpdateExistedAsset.MinWidth = 150;
            this.colUpdateExistedAsset.Name = "colUpdateExistedAsset";
            this.colUpdateExistedAsset.Visible = true;
            this.colUpdateExistedAsset.VisibleIndex = 2;
            this.colUpdateExistedAsset.Width = 150;
            // 
            // colUpdateSubDepartmentForExistedAsset
            // 
            this.colUpdateSubDepartmentForExistedAsset.Caption = "تعديل المعلومات الإدارية لأصل موجود";
            this.colUpdateSubDepartmentForExistedAsset.FieldName = "UpdateSubDepartmentForExistedAsset";
            this.colUpdateSubDepartmentForExistedAsset.MinWidth = 200;
            this.colUpdateSubDepartmentForExistedAsset.Name = "colUpdateSubDepartmentForExistedAsset";
            this.colUpdateSubDepartmentForExistedAsset.Visible = true;
            this.colUpdateSubDepartmentForExistedAsset.VisibleIndex = 3;
            this.colUpdateSubDepartmentForExistedAsset.Width = 200;
            // 
            // colUpdatePurchasePriceForExistedAsset
            // 
            this.colUpdatePurchasePriceForExistedAsset.Caption = "تعديل سعر الشراء لأصل موجود";
            this.colUpdatePurchasePriceForExistedAsset.FieldName = "UpdatePurchasePriceForExistedAsset";
            this.colUpdatePurchasePriceForExistedAsset.MinWidth = 200;
            this.colUpdatePurchasePriceForExistedAsset.Name = "colUpdatePurchasePriceForExistedAsset";
            this.colUpdatePurchasePriceForExistedAsset.Visible = true;
            this.colUpdatePurchasePriceForExistedAsset.VisibleIndex = 4;
            this.colUpdatePurchasePriceForExistedAsset.Width = 200;
            // 
            // colDeleteAssetRecord
            // 
            this.colDeleteAssetRecord.Caption = "حذف سجل أصل";
            this.colDeleteAssetRecord.FieldName = "DeleteAssetRecord";
            this.colDeleteAssetRecord.MinWidth = 150;
            this.colDeleteAssetRecord.Name = "colDeleteAssetRecord";
            this.colDeleteAssetRecord.Visible = true;
            this.colDeleteAssetRecord.VisibleIndex = 5;
            this.colDeleteAssetRecord.Width = 150;
            // 
            // colViewAssetsReports
            // 
            this.colViewAssetsReports.Caption = "عرض تقارير الأصول";
            this.colViewAssetsReports.FieldName = "ViewAssetsReports";
            this.colViewAssetsReports.MinWidth = 150;
            this.colViewAssetsReports.Name = "colViewAssetsReports";
            this.colViewAssetsReports.Visible = true;
            this.colViewAssetsReports.VisibleIndex = 6;
            this.colViewAssetsReports.Width = 150;
            // 
            // colViewAssetsStats
            // 
            this.colViewAssetsStats.Caption = "عرض إحصائيات الأصول";
            this.colViewAssetsStats.FieldName = "ViewAssetsStats";
            this.colViewAssetsStats.MinWidth = 150;
            this.colViewAssetsStats.Name = "colViewAssetsStats";
            this.colViewAssetsStats.Visible = true;
            this.colViewAssetsStats.VisibleIndex = 7;
            this.colViewAssetsStats.Width = 150;
            // 
            // colCreateInventoryReport
            // 
            this.colCreateInventoryReport.Caption = "إنشاء جرد جديد للأصول";
            this.colCreateInventoryReport.FieldName = "CreateInventoryReport";
            this.colCreateInventoryReport.MinWidth = 150;
            this.colCreateInventoryReport.Name = "colCreateInventoryReport";
            this.colCreateInventoryReport.Visible = true;
            this.colCreateInventoryReport.VisibleIndex = 8;
            this.colCreateInventoryReport.Width = 150;
            // 
            // colAddNewAssetMovement
            // 
            this.colAddNewAssetMovement.Caption = "نقل أصل";
            this.colAddNewAssetMovement.FieldName = "AddNewAssetMovement";
            this.colAddNewAssetMovement.MinWidth = 150;
            this.colAddNewAssetMovement.Name = "colAddNewAssetMovement";
            this.colAddNewAssetMovement.Visible = true;
            this.colAddNewAssetMovement.VisibleIndex = 9;
            this.colAddNewAssetMovement.Width = 150;
            // 
            // colManageAssetMovements
            // 
            this.colManageAssetMovements.Caption = "إدارة سجلات نقل الأصول";
            this.colManageAssetMovements.FieldName = "ManageAssetMovements";
            this.colManageAssetMovements.MinWidth = 150;
            this.colManageAssetMovements.Name = "colManageAssetMovements";
            this.colManageAssetMovements.Visible = true;
            this.colManageAssetMovements.VisibleIndex = 10;
            this.colManageAssetMovements.Width = 150;
            // 
            // colAddNewAssetTransaction
            // 
            this.colAddNewAssetTransaction.Caption = "تصريف أصل";
            this.colAddNewAssetTransaction.FieldName = "AddNewAssetTransaction";
            this.colAddNewAssetTransaction.MinWidth = 150;
            this.colAddNewAssetTransaction.Name = "colAddNewAssetTransaction";
            this.colAddNewAssetTransaction.Visible = true;
            this.colAddNewAssetTransaction.VisibleIndex = 11;
            this.colAddNewAssetTransaction.Width = 150;
            // 
            // colManageAssetTransactions
            // 
            this.colManageAssetTransactions.Caption = "إدارة سجلات تصريف الأصول";
            this.colManageAssetTransactions.FieldName = "ManageAssetTransactions";
            this.colManageAssetTransactions.MinWidth = 150;
            this.colManageAssetTransactions.Name = "colManageAssetTransactions";
            this.colManageAssetTransactions.Visible = true;
            this.colManageAssetTransactions.VisibleIndex = 12;
            this.colManageAssetTransactions.Width = 150;
            // 
            // colExportAllData
            // 
            this.colExportAllData.Caption = "تصدير البيانات";
            this.colExportAllData.FieldName = "ExportAllData";
            this.colExportAllData.MinWidth = 150;
            this.colExportAllData.Name = "colExportAllData";
            this.colExportAllData.Visible = true;
            this.colExportAllData.VisibleIndex = 13;
            this.colExportAllData.Width = 150;
            // 
            // colImportAllData
            // 
            this.colImportAllData.Caption = "استيراد البيانات";
            this.colImportAllData.FieldName = "ImportAllData";
            this.colImportAllData.MinWidth = 150;
            this.colImportAllData.Name = "colImportAllData";
            this.colImportAllData.Visible = true;
            this.colImportAllData.VisibleIndex = 14;
            this.colImportAllData.Width = 150;
            // 
            // colManageImportExportTbl
            // 
            this.colManageImportExportTbl.Caption = "إدارة سجلات الاستيراد والتصدير";
            this.colManageImportExportTbl.FieldName = "ManageImportExportTbl";
            this.colManageImportExportTbl.MinWidth = 200;
            this.colManageImportExportTbl.Name = "colManageImportExportTbl";
            this.colManageImportExportTbl.Visible = true;
            this.colManageImportExportTbl.VisibleIndex = 15;
            this.colManageImportExportTbl.Width = 200;
            // 
            // colManageUsers
            // 
            this.colManageUsers.Caption = "إدارة حسابات المستخدمين";
            this.colManageUsers.FieldName = "ManageUsers";
            this.colManageUsers.MinWidth = 150;
            this.colManageUsers.Name = "colManageUsers";
            this.colManageUsers.Visible = true;
            this.colManageUsers.VisibleIndex = 16;
            this.colManageUsers.Width = 150;
            // 
            // colViewSessionActionsLog
            // 
            this.colViewSessionActionsLog.Caption = "عرض ملف الأنشطة لحساب معين";
            this.colViewSessionActionsLog.FieldName = "ViewSessionActionsLog";
            this.colViewSessionActionsLog.MinWidth = 150;
            this.colViewSessionActionsLog.Name = "colViewSessionActionsLog";
            this.colViewSessionActionsLog.Visible = true;
            this.colViewSessionActionsLog.VisibleIndex = 17;
            this.colViewSessionActionsLog.Width = 150;
            // 
            // colPromoteDb
            // 
            this.colPromoteDb.Caption = "ترقية قاعدة البيانات";
            this.colPromoteDb.FieldName = "PromoteDb";
            this.colPromoteDb.MinWidth = 150;
            this.colPromoteDb.Name = "colPromoteDb";
            this.colPromoteDb.Visible = true;
            this.colPromoteDb.VisibleIndex = 18;
            this.colPromoteDb.Width = 150;
            // 
            // colAddNewMainCategory
            // 
            this.colAddNewMainCategory.Caption = "إضافة فئة رئيسية جديدة";
            this.colAddNewMainCategory.FieldName = "AddNewMainCategory";
            this.colAddNewMainCategory.MinWidth = 150;
            this.colAddNewMainCategory.Name = "colAddNewMainCategory";
            this.colAddNewMainCategory.Visible = true;
            this.colAddNewMainCategory.VisibleIndex = 19;
            this.colAddNewMainCategory.Width = 150;
            // 
            // colManageMainCategories
            // 
            this.colManageMainCategories.Caption = "إدارة سجلات الفئات الرئيسية";
            this.colManageMainCategories.FieldName = "ManageMainCategories";
            this.colManageMainCategories.MinWidth = 150;
            this.colManageMainCategories.Name = "colManageMainCategories";
            this.colManageMainCategories.Visible = true;
            this.colManageMainCategories.VisibleIndex = 20;
            this.colManageMainCategories.Width = 150;
            // 
            // colAddNewMinorCategory
            // 
            this.colAddNewMinorCategory.Caption = "إضافة فئة فرعية جديدة";
            this.colAddNewMinorCategory.FieldName = "AddNewMinorCategory";
            this.colAddNewMinorCategory.MinWidth = 150;
            this.colAddNewMinorCategory.Name = "colAddNewMinorCategory";
            this.colAddNewMinorCategory.Visible = true;
            this.colAddNewMinorCategory.VisibleIndex = 21;
            this.colAddNewMinorCategory.Width = 258;
            // 
            // colManageMinorCategories
            // 
            this.colManageMinorCategories.Caption = "إدارة سجلات الفئات الفرعية";
            this.colManageMinorCategories.FieldName = "ManageMinorCategories";
            this.colManageMinorCategories.MinWidth = 150;
            this.colManageMinorCategories.Name = "colManageMinorCategories";
            this.colManageMinorCategories.Visible = true;
            this.colManageMinorCategories.VisibleIndex = 22;
            this.colManageMinorCategories.Width = 150;
            // 
            // colAddNewSection
            // 
            this.colAddNewSection.Caption = "إضافة دائرة جديدة";
            this.colAddNewSection.FieldName = "AddNewSection";
            this.colAddNewSection.MinWidth = 150;
            this.colAddNewSection.Name = "colAddNewSection";
            this.colAddNewSection.Visible = true;
            this.colAddNewSection.VisibleIndex = 23;
            this.colAddNewSection.Width = 150;
            // 
            // colManageSections
            // 
            this.colManageSections.Caption = "إدارة جدول الدوائر";
            this.colManageSections.FieldName = "ManageSections";
            this.colManageSections.MinWidth = 150;
            this.colManageSections.Name = "colManageSections";
            this.colManageSections.Visible = true;
            this.colManageSections.VisibleIndex = 24;
            this.colManageSections.Width = 150;
            // 
            // colAddNewDepartment
            // 
            this.colAddNewDepartment.Caption = "إضافة قسم جديد";
            this.colAddNewDepartment.FieldName = "AddNewDepartment";
            this.colAddNewDepartment.MinWidth = 150;
            this.colAddNewDepartment.Name = "colAddNewDepartment";
            this.colAddNewDepartment.Visible = true;
            this.colAddNewDepartment.VisibleIndex = 25;
            this.colAddNewDepartment.Width = 258;
            // 
            // colManageDepartments
            // 
            this.colManageDepartments.Caption = "إدارة جدول الأقسام";
            this.colManageDepartments.FieldName = "ManageDepartments";
            this.colManageDepartments.MinWidth = 150;
            this.colManageDepartments.Name = "colManageDepartments";
            this.colManageDepartments.Visible = true;
            this.colManageDepartments.VisibleIndex = 26;
            this.colManageDepartments.Width = 150;
            // 
            // colAddNewSubDepartment
            // 
            this.colAddNewSubDepartment.Caption = "إضافة وحدة جديدة";
            this.colAddNewSubDepartment.FieldName = "AddNewSubDepartment";
            this.colAddNewSubDepartment.MinWidth = 150;
            this.colAddNewSubDepartment.Name = "colAddNewSubDepartment";
            this.colAddNewSubDepartment.Visible = true;
            this.colAddNewSubDepartment.VisibleIndex = 27;
            this.colAddNewSubDepartment.Width = 150;
            // 
            // colManageSubDepartments
            // 
            this.colManageSubDepartments.Caption = "إدارة جدول الوحدات";
            this.colManageSubDepartments.FieldName = "ManageSubDepartments";
            this.colManageSubDepartments.MinWidth = 150;
            this.colManageSubDepartments.Name = "colManageSubDepartments";
            this.colManageSubDepartments.Visible = true;
            this.colManageSubDepartments.VisibleIndex = 28;
            this.colManageSubDepartments.Width = 150;
            // 
            // colAddNewSquare
            // 
            this.colAddNewSquare.Caption = "إضافة ساحة جديدة";
            this.colAddNewSquare.FieldName = "AddNewSquare";
            this.colAddNewSquare.MinWidth = 150;
            this.colAddNewSquare.Name = "colAddNewSquare";
            this.colAddNewSquare.Visible = true;
            this.colAddNewSquare.VisibleIndex = 29;
            this.colAddNewSquare.Width = 150;
            // 
            // colManageSquares
            // 
            this.colManageSquares.Caption = "إدارة جدول الساحات";
            this.colManageSquares.FieldName = "ManageSquares";
            this.colManageSquares.MinWidth = 150;
            this.colManageSquares.Name = "colManageSquares";
            this.colManageSquares.Visible = true;
            this.colManageSquares.VisibleIndex = 30;
            this.colManageSquares.Width = 150;
            // 
            // colAddNewCurrency
            // 
            this.colAddNewCurrency.Caption = "إضافة عملة جديدة";
            this.colAddNewCurrency.FieldName = "AddNewCurrency";
            this.colAddNewCurrency.MinWidth = 150;
            this.colAddNewCurrency.Name = "colAddNewCurrency";
            this.colAddNewCurrency.Visible = true;
            this.colAddNewCurrency.VisibleIndex = 31;
            this.colAddNewCurrency.Width = 150;
            // 
            // colManageCurrencies
            // 
            this.colManageCurrencies.Caption = "إدارة جدول العملات";
            this.colManageCurrencies.FieldName = "ManageCurrencies";
            this.colManageCurrencies.MinWidth = 150;
            this.colManageCurrencies.Name = "colManageCurrencies";
            this.colManageCurrencies.Visible = true;
            this.colManageCurrencies.VisibleIndex = 32;
            this.colManageCurrencies.Width = 150;
            // 
            // colAddNewModel
            // 
            this.colAddNewModel.Caption = "إضافة موديل جديد";
            this.colAddNewModel.FieldName = "AddNewModel";
            this.colAddNewModel.MinWidth = 150;
            this.colAddNewModel.Name = "colAddNewModel";
            this.colAddNewModel.Visible = true;
            this.colAddNewModel.VisibleIndex = 33;
            this.colAddNewModel.Width = 150;
            // 
            // colManageModels
            // 
            this.colManageModels.Caption = "إدارة جدول الموديلات";
            this.colManageModels.FieldName = "ManageModels";
            this.colManageModels.MinWidth = 150;
            this.colManageModels.Name = "colManageModels";
            this.colManageModels.Visible = true;
            this.colManageModels.VisibleIndex = 34;
            this.colManageModels.Width = 150;
            // 
            // colAddNewEstateAreaUnit
            // 
            this.colAddNewEstateAreaUnit.Caption = "إضافة وحدة مساحة عقار جديدة";
            this.colAddNewEstateAreaUnit.FieldName = "AddNewEstateAreaUnit";
            this.colAddNewEstateAreaUnit.MinWidth = 200;
            this.colAddNewEstateAreaUnit.Name = "colAddNewEstateAreaUnit";
            this.colAddNewEstateAreaUnit.Visible = true;
            this.colAddNewEstateAreaUnit.VisibleIndex = 35;
            this.colAddNewEstateAreaUnit.Width = 200;
            // 
            // colManageEstateAreaUnits
            // 
            this.colManageEstateAreaUnits.Caption = "إدارة جدول وحدات مساحات العقارات";
            this.colManageEstateAreaUnits.FieldName = "ManageEstateAreaUnits";
            this.colManageEstateAreaUnits.MinWidth = 200;
            this.colManageEstateAreaUnits.Name = "colManageEstateAreaUnits";
            this.colManageEstateAreaUnits.Visible = true;
            this.colManageEstateAreaUnits.VisibleIndex = 36;
            this.colManageEstateAreaUnits.Width = 1000;
            // 
            // colAddNewTransactionType
            // 
            this.colAddNewTransactionType.Caption = "إضافة نوع تصريف أصل جديد";
            this.colAddNewTransactionType.FieldName = "AddNewTransactionType";
            this.colAddNewTransactionType.MinWidth = 150;
            this.colAddNewTransactionType.Name = "colAddNewTransactionType";
            this.colAddNewTransactionType.Visible = true;
            this.colAddNewTransactionType.VisibleIndex = 37;
            this.colAddNewTransactionType.Width = 150;
            // 
            // colManageTransactionTypes
            // 
            this.colManageTransactionTypes.Caption = "إدارة جدول أنواع تصريف الأصول";
            this.colManageTransactionTypes.FieldName = "ManageTransactionTypes";
            this.colManageTransactionTypes.MinWidth = 200;
            this.colManageTransactionTypes.Name = "colManageTransactionTypes";
            this.colManageTransactionTypes.Visible = true;
            this.colManageTransactionTypes.VisibleIndex = 38;
            this.colManageTransactionTypes.Width = 200;
            // 
            // colAddNewIncomingType
            // 
            this.colAddNewIncomingType.Caption = "إضافة جهة إيراد جديدة";
            this.colAddNewIncomingType.FieldName = "AddNewIncomingType";
            this.colAddNewIncomingType.MinWidth = 150;
            this.colAddNewIncomingType.Name = "colAddNewIncomingType";
            this.colAddNewIncomingType.Visible = true;
            this.colAddNewIncomingType.VisibleIndex = 39;
            this.colAddNewIncomingType.Width = 150;
            // 
            // colManageIncomingTypes
            // 
            this.colManageIncomingTypes.Caption = "إدارة جدول جهات الإيراد";
            this.colManageIncomingTypes.FieldName = "ManageIncomingTypes";
            this.colManageIncomingTypes.MinWidth = 150;
            this.colManageIncomingTypes.Name = "colManageIncomingTypes";
            this.colManageIncomingTypes.Visible = true;
            this.colManageIncomingTypes.VisibleIndex = 40;
            this.colManageIncomingTypes.Width = 150;
            // 
            // colAddNewOutgoingType
            // 
            this.colAddNewOutgoingType.Caption = "إضافة نوع صادر جديد";
            this.colAddNewOutgoingType.FieldName = "AddNewOutgoingType";
            this.colAddNewOutgoingType.MinWidth = 150;
            this.colAddNewOutgoingType.Name = "colAddNewOutgoingType";
            this.colAddNewOutgoingType.Visible = true;
            this.colAddNewOutgoingType.VisibleIndex = 41;
            this.colAddNewOutgoingType.Width = 150;
            // 
            // colManageOutgoingTypes
            // 
            this.colManageOutgoingTypes.Caption = "إدارة جدول أنواع الصادرات";
            this.colManageOutgoingTypes.FieldName = "ManageOutgoingTypes";
            this.colManageOutgoingTypes.MinWidth = 150;
            this.colManageOutgoingTypes.Name = "colManageOutgoingTypes";
            this.colManageOutgoingTypes.Visible = true;
            this.colManageOutgoingTypes.VisibleIndex = 42;
            this.colManageOutgoingTypes.Width = 150;
            // 
            // colAddNewFinancialItem
            // 
            this.colAddNewFinancialItem.Caption = "إضافة سجل مالي جديد";
            this.colAddNewFinancialItem.FieldName = "AddNewFinancialItem";
            this.colAddNewFinancialItem.MinWidth = 150;
            this.colAddNewFinancialItem.Name = "colAddNewFinancialItem";
            this.colAddNewFinancialItem.Visible = true;
            this.colAddNewFinancialItem.VisibleIndex = 43;
            this.colAddNewFinancialItem.Width = 150;
            // 
            // colManageFinancialItems
            // 
            this.colManageFinancialItems.Caption = "إدارة جدول السجلات المالية";
            this.colManageFinancialItems.FieldName = "ManageFinancialItems";
            this.colManageFinancialItems.MinWidth = 150;
            this.colManageFinancialItems.Name = "colManageFinancialItems";
            this.colManageFinancialItems.Visible = true;
            this.colManageFinancialItems.VisibleIndex = 44;
            this.colManageFinancialItems.Width = 150;
            // 
            // colUpdateExistedFinancialItem
            // 
            this.colUpdateExistedFinancialItem.Caption = "تعديل سجل مالي موجود";
            this.colUpdateExistedFinancialItem.FieldName = "UpdateExistedFinancialItem";
            this.colUpdateExistedFinancialItem.MinWidth = 150;
            this.colUpdateExistedFinancialItem.Name = "colUpdateExistedFinancialItem";
            this.colUpdateExistedFinancialItem.Visible = true;
            this.colUpdateExistedFinancialItem.VisibleIndex = 45;
            this.colUpdateExistedFinancialItem.Width = 150;
            // 
            // colDeleteFinancialItemRecord
            // 
            this.colDeleteFinancialItemRecord.Caption = "حذف سجل مالي موجود";
            this.colDeleteFinancialItemRecord.FieldName = "DeleteFinancialItemRecord";
            this.colDeleteFinancialItemRecord.MinWidth = 150;
            this.colDeleteFinancialItemRecord.Name = "colDeleteFinancialItemRecord";
            this.colDeleteFinancialItemRecord.Visible = true;
            this.colDeleteFinancialItemRecord.VisibleIndex = 46;
            this.colDeleteFinancialItemRecord.Width = 150;
            // 
            // colViewFinancialReports
            // 
            this.colViewFinancialReports.Caption = "عرض وتصدير التقارير المالية";
            this.colViewFinancialReports.FieldName = "ViewFinancialReports";
            this.colViewFinancialReports.MinWidth = 150;
            this.colViewFinancialReports.Name = "colViewFinancialReports";
            this.colViewFinancialReports.Visible = true;
            this.colViewFinancialReports.VisibleIndex = 47;
            this.colViewFinancialReports.Width = 150;
            // 
            // colViewFinancialItemsStats
            // 
            this.colViewFinancialItemsStats.Caption = "عرض إحصائيات السجلات المالية";
            this.colViewFinancialItemsStats.FieldName = "ViewFinancialItemsStats";
            this.colViewFinancialItemsStats.MinWidth = 150;
            this.colViewFinancialItemsStats.Name = "colViewFinancialItemsStats";
            this.colViewFinancialItemsStats.Visible = true;
            this.colViewFinancialItemsStats.VisibleIndex = 48;
            this.colViewFinancialItemsStats.Width = 150;
            // 
            // colAddNewFinancialItemCategory
            // 
            this.colAddNewFinancialItemCategory.Caption = "إضافة بند مالي جديد";
            this.colAddNewFinancialItemCategory.FieldName = "AddNewFinancialItemCategory";
            this.colAddNewFinancialItemCategory.MinWidth = 150;
            this.colAddNewFinancialItemCategory.Name = "colAddNewFinancialItemCategory";
            this.colAddNewFinancialItemCategory.Visible = true;
            this.colAddNewFinancialItemCategory.VisibleIndex = 49;
            this.colAddNewFinancialItemCategory.Width = 150;
            // 
            // colManageFinancialItemCategories
            // 
            this.colManageFinancialItemCategories.Caption = "إدارة جدول البنود المالية";
            this.colManageFinancialItemCategories.FieldName = "ManageFinancialItemCategories";
            this.colManageFinancialItemCategories.MinWidth = 150;
            this.colManageFinancialItemCategories.Name = "colManageFinancialItemCategories";
            this.colManageFinancialItemCategories.Visible = true;
            this.colManageFinancialItemCategories.VisibleIndex = 50;
            this.colManageFinancialItemCategories.Width = 150;
            // 
            // colSetDateAndTime
            // 
            this.colSetDateAndTime.Caption = "تغيير وقت وتاريخ التطبيق";
            this.colSetDateAndTime.FieldName = "SetDateAndTime";
            this.colSetDateAndTime.MinWidth = 150;
            this.colSetDateAndTime.Name = "colSetDateAndTime";
            this.colSetDateAndTime.Visible = true;
            this.colSetDateAndTime.VisibleIndex = 51;
            this.colSetDateAndTime.Width = 150;
            // 
            // colBackupDb
            // 
            this.colBackupDb.Caption = "نسخ احتياطي لقاعدة البيانات";
            this.colBackupDb.FieldName = "BackupDb";
            this.colBackupDb.MinWidth = 150;
            this.colBackupDb.Name = "colBackupDb";
            this.colBackupDb.Visible = true;
            this.colBackupDb.VisibleIndex = 52;
            this.colBackupDb.Width = 150;
            // 
            // colRestoreDb
            // 
            this.colRestoreDb.Caption = "استعادة قاعدة البيانات";
            this.colRestoreDb.FieldName = "RestoreDb";
            this.colRestoreDb.MinWidth = 150;
            this.colRestoreDb.Name = "colRestoreDb";
            this.colRestoreDb.Visible = true;
            this.colRestoreDb.VisibleIndex = 53;
            this.colRestoreDb.Width = 150;
            // 
            // colCreateAssetsReports
            // 
            this.colCreateAssetsReports.Caption = "إنشاء تقارير الأصول";
            this.colCreateAssetsReports.FieldName = "CreateAssetsReports";
            this.colCreateAssetsReports.MinWidth = 150;
            this.colCreateAssetsReports.Name = "colCreateAssetsReports";
            this.colCreateAssetsReports.Visible = true;
            this.colCreateAssetsReports.VisibleIndex = 54;
            this.colCreateAssetsReports.Width = 150;
            // 
            // colIsSectionIndependent
            // 
            this.colIsSectionIndependent.Caption = "الحساب لا يتبع لدائرة محددة";
            this.colIsSectionIndependent.FieldName = "IsSectionIndependent";
            this.colIsSectionIndependent.MinWidth = 150;
            this.colIsSectionIndependent.Name = "colIsSectionIndependent";
            this.colIsSectionIndependent.Visible = true;
            this.colIsSectionIndependent.VisibleIndex = 56;
            this.colIsSectionIndependent.Width = 150;
            // 
            // colIsDepartmentIndependent
            // 
            this.colIsDepartmentIndependent.Caption = "الحساب لا يتبع لقسم محدد";
            this.colIsDepartmentIndependent.FieldName = "IsDepartmentIndependent";
            this.colIsDepartmentIndependent.MinWidth = 150;
            this.colIsDepartmentIndependent.Name = "colIsDepartmentIndependent";
            this.colIsDepartmentIndependent.Visible = true;
            this.colIsDepartmentIndependent.VisibleIndex = 57;
            this.colIsDepartmentIndependent.Width = 150;
            // 
            // mainAlertControl
            // 
            this.mainAlertControl.AppearanceCaption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainAlertControl.AppearanceCaption.Options.UseFont = true;
            this.mainAlertControl.AppearanceCaption.Options.UseTextOptions = true;
            this.mainAlertControl.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.mainAlertControl.AppearanceText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainAlertControl.AppearanceText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mainAlertControl.AppearanceText.Options.UseFont = true;
            this.mainAlertControl.AppearanceText.Options.UseForeColor = true;
            this.mainAlertControl.AppearanceText.Options.UseTextOptions = true;
            this.mainAlertControl.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.mainAlertControl.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight;
            this.mainAlertControl.FormLoad += new DevExpress.XtraBars.Alerter.AlertFormLoadEventHandler(this.mainAlertControl_FormLoad);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssetMovementTblTableAdapter = null;
            this.tableAdapterManager.AssetTblTableAdapter = null;
            this.tableAdapterManager.AssetTransactionTblTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CurrencyTblTableAdapter = null;
            this.tableAdapterManager.DepartmentTblTableAdapter = null;
            this.tableAdapterManager.EstateAreaUnitTblTableAdapter = null;
            this.tableAdapterManager.FinancialItemCategoryTblTableAdapter = null;
            this.tableAdapterManager.FinancialItemTblTableAdapter = null;
            this.tableAdapterManager.ImportExportTblTableAdapter = null;
            this.tableAdapterManager.IncomingTypeTblTableAdapter = null;
            this.tableAdapterManager.MainCategoryTblTableAdapter = null;
            this.tableAdapterManager.MinorCategoryTblTableAdapter = null;
            this.tableAdapterManager.ModelTblTableAdapter = null;
            this.tableAdapterManager.NumberingTblTableAdapter = null;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.OutgoingTypeTblTableAdapter = null;
            this.tableAdapterManager.SectionTblTableAdapter = null;
            this.tableAdapterManager.SquareTblTableAdapter = null;
            this.tableAdapterManager.StatusTblTableAdapter = null;
            this.tableAdapterManager.SubDepartmentTblTableAdapter = null;
            this.tableAdapterManager.TransactionTypeTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserLoginTblTableAdapter = null;
            this.tableAdapterManager.UserRoleTblTableAdapter = this.userRoleTblTableAdapter;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // userRoleTblTableAdapter
            // 
            this.userRoleTblTableAdapter.ClearBeforeFill = true;
            // 
            // userRoleTblBindingNavigator
            // 
            this.userRoleTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.userRoleTblBindingNavigator.BindingSource = this.userRoleTblBindingSource;
            this.userRoleTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userRoleTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.userRoleTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.userRoleTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.userRoleTblBindingNavigatorSaveItem});
            this.userRoleTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userRoleTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userRoleTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userRoleTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userRoleTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userRoleTblBindingNavigator.Name = "userRoleTblBindingNavigator";
            this.userRoleTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userRoleTblBindingNavigator.Size = new System.Drawing.Size(1301, 47);
            this.userRoleTblBindingNavigator.TabIndex = 6;
            this.userRoleTblBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 44);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 47);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // userRoleTblBindingNavigatorSaveItem
            // 
            this.userRoleTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userRoleTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userRoleTblBindingNavigatorSaveItem.Image")));
            this.userRoleTblBindingNavigatorSaveItem.Name = "userRoleTblBindingNavigatorSaveItem";
            this.userRoleTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(44, 44);
            this.userRoleTblBindingNavigatorSaveItem.Text = "Save Data";
            this.userRoleTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.userRoleTblBindingNavigatorSaveItem_Click);
            // 
            // ManageUserRoleTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 748);
            this.Controls.Add(this.userRoleGridControl);
            this.Controls.Add(this.userRoleTblBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageUserRoleTblForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة جدول أنواع حسابات المستخدمين";
            this.Load += new System.EventHandler(this.ManageUserRoleTblForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userRoleGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleTblBindingNavigator)).EndInit();
            this.userRoleTblBindingNavigator.ResumeLayout(false);
            this.userRoleTblBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AssetMngDbDataSet assetMngDbDataSet;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator userRoleTblBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton userRoleTblBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl userRoleGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView userRoleGridView;
        private System.Windows.Forms.BindingSource userRoleTblBindingSource;
        private AssetMngDbDataSetTableAdapters.UserRoleTblTableAdapter userRoleTblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewAsset;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateExistedAsset;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleteAssetRecord;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewAssetMovement;
        private DevExpress.XtraGrid.Columns.GridColumn colManageAssetMovements;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewAssetTransaction;
        private DevExpress.XtraGrid.Columns.GridColumn colManageAssetTransactions;
        private DevExpress.XtraGrid.Columns.GridColumn colExportAllData;
        private DevExpress.XtraGrid.Columns.GridColumn colImportAllData;
        private DevExpress.XtraGrid.Columns.GridColumn colManageUsers;
        private DevExpress.XtraGrid.Columns.GridColumn colPromoteDb;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewMainCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colManageMainCategories;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewMinorCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colManageMinorCategories;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colManageDepartments;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewSection;
        private DevExpress.XtraGrid.Columns.GridColumn colManageSections;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewSquare;
        private DevExpress.XtraGrid.Columns.GridColumn colManageSquares;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colManageCurrencies;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewEstateAreaUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colManageEstateAreaUnits;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewTransactionType;
        private DevExpress.XtraGrid.Columns.GridColumn colManageTransactionTypes;
        private DevExpress.XtraGrid.Columns.GridColumn colSetDateAndTime;
        private DevExpress.XtraGrid.Columns.GridColumn colBackupDb;
        private DevExpress.XtraGrid.Columns.GridColumn colRestoreDb;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateAssetsReports;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewFinancialItem;
        private DevExpress.XtraGrid.Columns.GridColumn colManageFinancialItems;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateExistedFinancialItem;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleteFinancialItemRecord;
        private DevExpress.XtraGrid.Columns.GridColumn colViewFinancialReports;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewFinancialItemCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colManageFinancialItemCategories;
        private DevExpress.XtraGrid.Columns.GridColumn colManageAssetTbl;
        private DevExpress.XtraGrid.Columns.GridColumn colViewAssetsReports;
        private DevExpress.XtraGrid.Columns.GridColumn colViewAssetsStats;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewModel;
        private DevExpress.XtraGrid.Columns.GridColumn colManageModels;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewSubDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colManageSubDepartments;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateInventoryReport;
        private DevExpress.XtraGrid.Columns.GridColumn colManageImportExportTbl;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateSubDepartmentForExistedAsset;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDepartmentIndependent;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSectionIndependent;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatePurchasePriceForExistedAsset;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewIncomingType;
        private DevExpress.XtraGrid.Columns.GridColumn colManageIncomingTypes;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewOutgoingType;
        private DevExpress.XtraGrid.Columns.GridColumn colManageOutgoingTypes;
        private DevExpress.XtraGrid.Columns.GridColumn colViewFinancialItemsStats;
        private DevExpress.XtraGrid.Columns.GridColumn colViewSessionActionsLog;
    }
}