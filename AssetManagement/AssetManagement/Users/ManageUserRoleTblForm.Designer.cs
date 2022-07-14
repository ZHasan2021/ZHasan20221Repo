
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
            this.minorCategoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.userRoleGridControl = new DevExpress.XtraGrid.GridControl();
            this.userRoleTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.userRoleGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewAsset = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateExistedAsset = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSearchAssets = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewAssets = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleteAssetRecord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDropAssets = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewInventory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateExistedInventory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSearchInventories = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewInventories = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleteInventoryRecord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewAssetMovement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageAssetMovements = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewAssetTransaction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageAssetTransactions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExportAllData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImportAllData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageUsers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPromoteDb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewMainCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageMainCategories = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewMinorCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageMinorCategories = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageDepartments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewSection = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageSections = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewSquare = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageSquares = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageCurrencies = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewEstateAreaUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageEstateAreaUnits = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewTransactionType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageTransactionTypes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSetDateAndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBackupDb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRestoreDb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewStats = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateAssetsReports = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleTblBindingNavigator)).BeginInit();
            this.userRoleTblBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // minorCategoryGridView
            // 
            this.minorCategoryGridView.GridControl = this.userRoleGridControl;
            this.minorCategoryGridView.Name = "minorCategoryGridView";
            // 
            // userRoleGridControl
            // 
            this.userRoleGridControl.DataSource = this.userRoleTblBindingSource;
            this.userRoleGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.minorCategoryGridView;
            gridLevelNode1.RelationName = "userRoleLevel";
            this.userRoleGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.userRoleGridControl.Location = new System.Drawing.Point(0, 27);
            this.userRoleGridControl.MainView = this.userRoleGridView;
            this.userRoleGridControl.Name = "userRoleGridControl";
            this.userRoleGridControl.Size = new System.Drawing.Size(1213, 634);
            this.userRoleGridControl.TabIndex = 8;
            this.userRoleGridControl.UseEmbeddedNavigator = true;
            this.userRoleGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.userRoleGridView,
            this.minorCategoryGridView});
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
            this.colUpdateExistedAsset,
            this.colSearchAssets,
            this.colViewAssets,
            this.colDeleteAssetRecord,
            this.colDropAssets,
            this.colAddNewInventory,
            this.colUpdateExistedInventory,
            this.colSearchInventories,
            this.colViewInventories,
            this.colDeleteInventoryRecord,
            this.colAddNewAssetMovement,
            this.colManageAssetMovements,
            this.colAddNewAssetTransaction,
            this.colManageAssetTransactions,
            this.colExportAllData,
            this.colImportAllData,
            this.colManageUsers,
            this.colPromoteDb,
            this.colAddNewMainCategory,
            this.colManageMainCategories,
            this.colAddNewMinorCategory,
            this.colManageMinorCategories,
            this.colAddNewDepartment,
            this.colManageDepartments,
            this.colAddNewSection,
            this.colManageSections,
            this.colAddNewSquare,
            this.colManageSquares,
            this.colAddNewCurrency,
            this.colManageCurrencies,
            this.colAddNewEstateAreaUnit,
            this.colManageEstateAreaUnits,
            this.colAddNewTransactionType,
            this.colManageTransactionTypes,
            this.colSetDateAndTime,
            this.colBackupDb,
            this.colRestoreDb,
            this.colViewStats,
            this.colCreateAssetsReports});
            this.userRoleGridView.GridControl = this.userRoleGridControl;
            this.userRoleGridView.Name = "userRoleGridView";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 94;
            // 
            // colRoleName
            // 
            this.colRoleName.FieldName = "RoleName";
            this.colRoleName.MinWidth = 25;
            this.colRoleName.Name = "colRoleName";
            this.colRoleName.Visible = true;
            this.colRoleName.VisibleIndex = 1;
            this.colRoleName.Width = 94;
            // 
            // colAddNewAsset
            // 
            this.colAddNewAsset.FieldName = "AddNewAsset";
            this.colAddNewAsset.MinWidth = 25;
            this.colAddNewAsset.Name = "colAddNewAsset";
            this.colAddNewAsset.Visible = true;
            this.colAddNewAsset.VisibleIndex = 2;
            this.colAddNewAsset.Width = 94;
            // 
            // colUpdateExistedAsset
            // 
            this.colUpdateExistedAsset.FieldName = "UpdateExistedAsset";
            this.colUpdateExistedAsset.MinWidth = 25;
            this.colUpdateExistedAsset.Name = "colUpdateExistedAsset";
            this.colUpdateExistedAsset.Visible = true;
            this.colUpdateExistedAsset.VisibleIndex = 3;
            this.colUpdateExistedAsset.Width = 94;
            // 
            // colSearchAssets
            // 
            this.colSearchAssets.FieldName = "SearchAssets";
            this.colSearchAssets.MinWidth = 25;
            this.colSearchAssets.Name = "colSearchAssets";
            this.colSearchAssets.Visible = true;
            this.colSearchAssets.VisibleIndex = 4;
            this.colSearchAssets.Width = 94;
            // 
            // colViewAssets
            // 
            this.colViewAssets.FieldName = "ViewAssets";
            this.colViewAssets.MinWidth = 25;
            this.colViewAssets.Name = "colViewAssets";
            this.colViewAssets.Visible = true;
            this.colViewAssets.VisibleIndex = 5;
            this.colViewAssets.Width = 94;
            // 
            // colDeleteAssetRecord
            // 
            this.colDeleteAssetRecord.FieldName = "DeleteAssetRecord";
            this.colDeleteAssetRecord.MinWidth = 25;
            this.colDeleteAssetRecord.Name = "colDeleteAssetRecord";
            this.colDeleteAssetRecord.Visible = true;
            this.colDeleteAssetRecord.VisibleIndex = 6;
            this.colDeleteAssetRecord.Width = 94;
            // 
            // colDropAssets
            // 
            this.colDropAssets.FieldName = "DropAssets";
            this.colDropAssets.MinWidth = 25;
            this.colDropAssets.Name = "colDropAssets";
            this.colDropAssets.Visible = true;
            this.colDropAssets.VisibleIndex = 7;
            this.colDropAssets.Width = 94;
            // 
            // colAddNewInventory
            // 
            this.colAddNewInventory.FieldName = "AddNewInventory";
            this.colAddNewInventory.MinWidth = 25;
            this.colAddNewInventory.Name = "colAddNewInventory";
            this.colAddNewInventory.Visible = true;
            this.colAddNewInventory.VisibleIndex = 8;
            this.colAddNewInventory.Width = 94;
            // 
            // colUpdateExistedInventory
            // 
            this.colUpdateExistedInventory.FieldName = "UpdateExistedInventory";
            this.colUpdateExistedInventory.MinWidth = 25;
            this.colUpdateExistedInventory.Name = "colUpdateExistedInventory";
            this.colUpdateExistedInventory.Visible = true;
            this.colUpdateExistedInventory.VisibleIndex = 9;
            this.colUpdateExistedInventory.Width = 94;
            // 
            // colSearchInventories
            // 
            this.colSearchInventories.FieldName = "SearchInventories";
            this.colSearchInventories.MinWidth = 25;
            this.colSearchInventories.Name = "colSearchInventories";
            this.colSearchInventories.Visible = true;
            this.colSearchInventories.VisibleIndex = 10;
            this.colSearchInventories.Width = 94;
            // 
            // colViewInventories
            // 
            this.colViewInventories.FieldName = "ViewInventories";
            this.colViewInventories.MinWidth = 25;
            this.colViewInventories.Name = "colViewInventories";
            this.colViewInventories.Visible = true;
            this.colViewInventories.VisibleIndex = 11;
            this.colViewInventories.Width = 94;
            // 
            // colDeleteInventoryRecord
            // 
            this.colDeleteInventoryRecord.FieldName = "DeleteInventoryRecord";
            this.colDeleteInventoryRecord.MinWidth = 25;
            this.colDeleteInventoryRecord.Name = "colDeleteInventoryRecord";
            this.colDeleteInventoryRecord.Visible = true;
            this.colDeleteInventoryRecord.VisibleIndex = 12;
            this.colDeleteInventoryRecord.Width = 94;
            // 
            // colAddNewAssetMovement
            // 
            this.colAddNewAssetMovement.FieldName = "AddNewAssetMovement";
            this.colAddNewAssetMovement.MinWidth = 25;
            this.colAddNewAssetMovement.Name = "colAddNewAssetMovement";
            this.colAddNewAssetMovement.Visible = true;
            this.colAddNewAssetMovement.VisibleIndex = 13;
            this.colAddNewAssetMovement.Width = 94;
            // 
            // colManageAssetMovements
            // 
            this.colManageAssetMovements.FieldName = "ManageAssetMovements";
            this.colManageAssetMovements.MinWidth = 25;
            this.colManageAssetMovements.Name = "colManageAssetMovements";
            this.colManageAssetMovements.Visible = true;
            this.colManageAssetMovements.VisibleIndex = 14;
            this.colManageAssetMovements.Width = 94;
            // 
            // colAddNewAssetTransaction
            // 
            this.colAddNewAssetTransaction.FieldName = "AddNewAssetTransaction";
            this.colAddNewAssetTransaction.MinWidth = 25;
            this.colAddNewAssetTransaction.Name = "colAddNewAssetTransaction";
            this.colAddNewAssetTransaction.Visible = true;
            this.colAddNewAssetTransaction.VisibleIndex = 15;
            this.colAddNewAssetTransaction.Width = 94;
            // 
            // colManageAssetTransactions
            // 
            this.colManageAssetTransactions.FieldName = "ManageAssetTransactions";
            this.colManageAssetTransactions.MinWidth = 25;
            this.colManageAssetTransactions.Name = "colManageAssetTransactions";
            this.colManageAssetTransactions.Visible = true;
            this.colManageAssetTransactions.VisibleIndex = 16;
            this.colManageAssetTransactions.Width = 94;
            // 
            // colExportAllData
            // 
            this.colExportAllData.FieldName = "ExportAllData";
            this.colExportAllData.MinWidth = 25;
            this.colExportAllData.Name = "colExportAllData";
            this.colExportAllData.Visible = true;
            this.colExportAllData.VisibleIndex = 17;
            this.colExportAllData.Width = 94;
            // 
            // colImportAllData
            // 
            this.colImportAllData.FieldName = "ImportAllData";
            this.colImportAllData.MinWidth = 25;
            this.colImportAllData.Name = "colImportAllData";
            this.colImportAllData.Visible = true;
            this.colImportAllData.VisibleIndex = 18;
            this.colImportAllData.Width = 94;
            // 
            // colManageUsers
            // 
            this.colManageUsers.FieldName = "ManageUsers";
            this.colManageUsers.MinWidth = 25;
            this.colManageUsers.Name = "colManageUsers";
            this.colManageUsers.Visible = true;
            this.colManageUsers.VisibleIndex = 19;
            this.colManageUsers.Width = 94;
            // 
            // colPromoteDb
            // 
            this.colPromoteDb.FieldName = "PromoteDb";
            this.colPromoteDb.MinWidth = 25;
            this.colPromoteDb.Name = "colPromoteDb";
            this.colPromoteDb.Visible = true;
            this.colPromoteDb.VisibleIndex = 20;
            this.colPromoteDb.Width = 94;
            // 
            // colAddNewMainCategory
            // 
            this.colAddNewMainCategory.FieldName = "AddNewMainCategory";
            this.colAddNewMainCategory.MinWidth = 25;
            this.colAddNewMainCategory.Name = "colAddNewMainCategory";
            this.colAddNewMainCategory.Visible = true;
            this.colAddNewMainCategory.VisibleIndex = 21;
            this.colAddNewMainCategory.Width = 94;
            // 
            // colManageMainCategories
            // 
            this.colManageMainCategories.FieldName = "ManageMainCategories";
            this.colManageMainCategories.MinWidth = 25;
            this.colManageMainCategories.Name = "colManageMainCategories";
            this.colManageMainCategories.Visible = true;
            this.colManageMainCategories.VisibleIndex = 22;
            this.colManageMainCategories.Width = 94;
            // 
            // colAddNewMinorCategory
            // 
            this.colAddNewMinorCategory.FieldName = "AddNewMinorCategory";
            this.colAddNewMinorCategory.MinWidth = 25;
            this.colAddNewMinorCategory.Name = "colAddNewMinorCategory";
            this.colAddNewMinorCategory.Visible = true;
            this.colAddNewMinorCategory.VisibleIndex = 23;
            this.colAddNewMinorCategory.Width = 94;
            // 
            // colManageMinorCategories
            // 
            this.colManageMinorCategories.FieldName = "ManageMinorCategories";
            this.colManageMinorCategories.MinWidth = 25;
            this.colManageMinorCategories.Name = "colManageMinorCategories";
            this.colManageMinorCategories.Visible = true;
            this.colManageMinorCategories.VisibleIndex = 24;
            this.colManageMinorCategories.Width = 94;
            // 
            // colAddNewDepartment
            // 
            this.colAddNewDepartment.FieldName = "AddNewDepartment";
            this.colAddNewDepartment.MinWidth = 25;
            this.colAddNewDepartment.Name = "colAddNewDepartment";
            this.colAddNewDepartment.Visible = true;
            this.colAddNewDepartment.VisibleIndex = 25;
            this.colAddNewDepartment.Width = 94;
            // 
            // colManageDepartments
            // 
            this.colManageDepartments.FieldName = "ManageDepartments";
            this.colManageDepartments.MinWidth = 25;
            this.colManageDepartments.Name = "colManageDepartments";
            this.colManageDepartments.Visible = true;
            this.colManageDepartments.VisibleIndex = 26;
            this.colManageDepartments.Width = 94;
            // 
            // colAddNewSection
            // 
            this.colAddNewSection.FieldName = "AddNewSection";
            this.colAddNewSection.MinWidth = 25;
            this.colAddNewSection.Name = "colAddNewSection";
            this.colAddNewSection.Visible = true;
            this.colAddNewSection.VisibleIndex = 27;
            this.colAddNewSection.Width = 94;
            // 
            // colManageSections
            // 
            this.colManageSections.FieldName = "ManageSections";
            this.colManageSections.MinWidth = 25;
            this.colManageSections.Name = "colManageSections";
            this.colManageSections.Visible = true;
            this.colManageSections.VisibleIndex = 28;
            this.colManageSections.Width = 94;
            // 
            // colAddNewSquare
            // 
            this.colAddNewSquare.FieldName = "AddNewSquare";
            this.colAddNewSquare.MinWidth = 25;
            this.colAddNewSquare.Name = "colAddNewSquare";
            this.colAddNewSquare.Visible = true;
            this.colAddNewSquare.VisibleIndex = 29;
            this.colAddNewSquare.Width = 94;
            // 
            // colManageSquares
            // 
            this.colManageSquares.FieldName = "ManageSquares";
            this.colManageSquares.MinWidth = 25;
            this.colManageSquares.Name = "colManageSquares";
            this.colManageSquares.Visible = true;
            this.colManageSquares.VisibleIndex = 30;
            this.colManageSquares.Width = 94;
            // 
            // colAddNewCurrency
            // 
            this.colAddNewCurrency.FieldName = "AddNewCurrency";
            this.colAddNewCurrency.MinWidth = 25;
            this.colAddNewCurrency.Name = "colAddNewCurrency";
            this.colAddNewCurrency.Visible = true;
            this.colAddNewCurrency.VisibleIndex = 31;
            this.colAddNewCurrency.Width = 94;
            // 
            // colManageCurrencies
            // 
            this.colManageCurrencies.FieldName = "ManageCurrencies";
            this.colManageCurrencies.MinWidth = 25;
            this.colManageCurrencies.Name = "colManageCurrencies";
            this.colManageCurrencies.Visible = true;
            this.colManageCurrencies.VisibleIndex = 32;
            this.colManageCurrencies.Width = 94;
            // 
            // colAddNewEstateAreaUnit
            // 
            this.colAddNewEstateAreaUnit.FieldName = "AddNewEstateAreaUnit";
            this.colAddNewEstateAreaUnit.MinWidth = 25;
            this.colAddNewEstateAreaUnit.Name = "colAddNewEstateAreaUnit";
            this.colAddNewEstateAreaUnit.Visible = true;
            this.colAddNewEstateAreaUnit.VisibleIndex = 33;
            this.colAddNewEstateAreaUnit.Width = 94;
            // 
            // colManageEstateAreaUnits
            // 
            this.colManageEstateAreaUnits.FieldName = "ManageEstateAreaUnits";
            this.colManageEstateAreaUnits.MinWidth = 25;
            this.colManageEstateAreaUnits.Name = "colManageEstateAreaUnits";
            this.colManageEstateAreaUnits.Visible = true;
            this.colManageEstateAreaUnits.VisibleIndex = 34;
            this.colManageEstateAreaUnits.Width = 94;
            // 
            // colAddNewTransactionType
            // 
            this.colAddNewTransactionType.FieldName = "AddNewTransactionType";
            this.colAddNewTransactionType.MinWidth = 25;
            this.colAddNewTransactionType.Name = "colAddNewTransactionType";
            this.colAddNewTransactionType.Visible = true;
            this.colAddNewTransactionType.VisibleIndex = 35;
            this.colAddNewTransactionType.Width = 94;
            // 
            // colManageTransactionTypes
            // 
            this.colManageTransactionTypes.FieldName = "ManageTransactionTypes";
            this.colManageTransactionTypes.MinWidth = 25;
            this.colManageTransactionTypes.Name = "colManageTransactionTypes";
            this.colManageTransactionTypes.Visible = true;
            this.colManageTransactionTypes.VisibleIndex = 36;
            this.colManageTransactionTypes.Width = 94;
            // 
            // colSetDateAndTime
            // 
            this.colSetDateAndTime.FieldName = "SetDateAndTime";
            this.colSetDateAndTime.MinWidth = 25;
            this.colSetDateAndTime.Name = "colSetDateAndTime";
            this.colSetDateAndTime.Visible = true;
            this.colSetDateAndTime.VisibleIndex = 37;
            this.colSetDateAndTime.Width = 94;
            // 
            // colBackupDb
            // 
            this.colBackupDb.FieldName = "BackupDb";
            this.colBackupDb.MinWidth = 25;
            this.colBackupDb.Name = "colBackupDb";
            this.colBackupDb.Visible = true;
            this.colBackupDb.VisibleIndex = 38;
            this.colBackupDb.Width = 94;
            // 
            // colRestoreDb
            // 
            this.colRestoreDb.FieldName = "RestoreDb";
            this.colRestoreDb.MinWidth = 25;
            this.colRestoreDb.Name = "colRestoreDb";
            this.colRestoreDb.Visible = true;
            this.colRestoreDb.VisibleIndex = 39;
            this.colRestoreDb.Width = 94;
            // 
            // colViewStats
            // 
            this.colViewStats.FieldName = "ViewStats";
            this.colViewStats.MinWidth = 25;
            this.colViewStats.Name = "colViewStats";
            this.colViewStats.Visible = true;
            this.colViewStats.VisibleIndex = 40;
            this.colViewStats.Width = 94;
            // 
            // colCreateAssetsReports
            // 
            this.colCreateAssetsReports.FieldName = "CreateAssetsReports";
            this.colCreateAssetsReports.MinWidth = 25;
            this.colCreateAssetsReports.Name = "colCreateAssetsReports";
            this.colCreateAssetsReports.Visible = true;
            this.colCreateAssetsReports.VisibleIndex = 41;
            this.colCreateAssetsReports.Width = 94;
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
            this.mainAlertControl.AutoHeight = true;
            this.mainAlertControl.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight;
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
            this.tableAdapterManager.MainCategoryTblTableAdapter = null;
            this.tableAdapterManager.MinorCategoryTblTableAdapter = null;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.SectionTblTableAdapter = null;
            this.tableAdapterManager.SquareTblTableAdapter = null;
            this.tableAdapterManager.StatusTblTableAdapter = null;
            this.tableAdapterManager.TransactionTypeTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.userRoleTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userRoleTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.userRoleTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.userRoleTblBindingNavigator.Size = new System.Drawing.Size(1213, 27);
            this.userRoleTblBindingNavigator.TabIndex = 6;
            this.userRoleTblBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // userRoleTblBindingNavigatorSaveItem
            // 
            this.userRoleTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userRoleTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userRoleTblBindingNavigatorSaveItem.Image")));
            this.userRoleTblBindingNavigatorSaveItem.Name = "userRoleTblBindingNavigatorSaveItem";
            this.userRoleTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.userRoleTblBindingNavigatorSaveItem.Text = "Save Data";
            this.userRoleTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.userRoleTblBindingNavigatorSaveItem_Click);
            // 
            // ManageUserRoleTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 661);
            this.Controls.Add(this.userRoleGridControl);
            this.Controls.Add(this.userRoleTblBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageUserRoleTblForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة جدول أنواع حسابات المستخدمين";
            this.Load += new System.EventHandler(this.ManageUserRoleTblForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryGridView)).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView minorCategoryGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView userRoleGridView;
        private System.Windows.Forms.BindingSource userRoleTblBindingSource;
        private AssetMngDbDataSetTableAdapters.UserRoleTblTableAdapter userRoleTblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewAsset;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateExistedAsset;
        private DevExpress.XtraGrid.Columns.GridColumn colSearchAssets;
        private DevExpress.XtraGrid.Columns.GridColumn colViewAssets;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleteAssetRecord;
        private DevExpress.XtraGrid.Columns.GridColumn colDropAssets;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewInventory;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateExistedInventory;
        private DevExpress.XtraGrid.Columns.GridColumn colSearchInventories;
        private DevExpress.XtraGrid.Columns.GridColumn colViewInventories;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleteInventoryRecord;
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
        private DevExpress.XtraGrid.Columns.GridColumn colViewStats;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateAssetsReports;
    }
}