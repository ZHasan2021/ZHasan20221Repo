﻿
namespace AssetManagement.Assets
{
    partial class TransacteAssetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransacteAssetForm));
            this.transactAssetGroupBox = new System.Windows.Forms.GroupBox();
            this.assetTransactionGridControl = new DevExpress.XtraGrid.GridControl();
            this.assetTransactionTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.assetTransactionGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.astRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.assetVwAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colTransactionType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.trtyRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.transactionTypeTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityTransacted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionMadeOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionMadeBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoneyAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoneyAmountCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.currRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.currencyTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colGetAssetOutOfWork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentPriceWithDestroying = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetTransactionUniqueKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.assetTransactionPanel = new System.Windows.Forms.Panel();
            this.assetCurrentItemsQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.qtyOutOfLabel = new System.Windows.Forms.Label();
            this.assetItemsQuantityLabel = new System.Windows.Forms.Label();
            this.assetItemsQuantityToTransactNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.currentPriceWithDestroyingLabel = new System.Windows.Forms.Label();
            this.currentPriceWithDestroyingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.manageCurrencyTblBtn = new System.Windows.Forms.Button();
            this.moneyAmountCurrencyLabel = new System.Windows.Forms.Label();
            this.moneyAmountCurrencyLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.manageTransactionTypeTblBtn = new System.Windows.Forms.Button();
            this.moneyAmountLabel = new System.Windows.Forms.Label();
            this.moneyAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.assetNotesLabel = new System.Windows.Forms.Label();
            this.assetNotesTextBox = new System.Windows.Forms.TextBox();
            this.getAssetOutOfWorkCheckBox = new System.Windows.Forms.CheckBox();
            this.assetTransactBtn = new System.Windows.Forms.Button();
            this.assetTransactionDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.transactionTypeLabel = new System.Windows.Forms.Label();
            this.assetTransactionDateLabel = new System.Windows.Forms.Label();
            this.transactionTypeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.assetInfoTextBox = new System.Windows.Forms.TextBox();
            this.transactionTypeTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.currencyTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.assetTransactionTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetTransactionTblTableAdapter();
            this.currencyTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.CurrencyTblTableAdapter();
            this.transactionTypeTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.TransactionTypeTblTableAdapter();
            this.viewAssetInformationBtn = new System.Windows.Forms.Button();
            this.searchResultsListBox = new System.Windows.Forms.ListBox();
            this.assetVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchAssetBtn = new System.Windows.Forms.Button();
            this.assetCodeLabel = new System.Windows.Forms.Label();
            this.assetCodeTextBox = new System.Windows.Forms.TextBox();
            this.assetVwTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetVwTableAdapter();
            this.assetVw_AllTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetVw_AllTableAdapter();
            this.transactAssetGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.astRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trtyRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).BeginInit();
            this.assetTransactionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetCurrentItemsQuantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetItemsQuantityToTransactNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPriceWithDestroyingNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyAmountCurrencyLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyAmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // transactAssetGroupBox
            // 
            this.transactAssetGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.transactAssetGroupBox.Controls.Add(this.assetTransactionGridControl);
            this.transactAssetGroupBox.Controls.Add(this.assetTransactionPanel);
            this.transactAssetGroupBox.Controls.Add(this.assetInfoTextBox);
            this.transactAssetGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.transactAssetGroupBox.Location = new System.Drawing.Point(0, 168);
            this.transactAssetGroupBox.Name = "transactAssetGroupBox";
            this.transactAssetGroupBox.Size = new System.Drawing.Size(1276, 633);
            this.transactAssetGroupBox.TabIndex = 100;
            this.transactAssetGroupBox.TabStop = false;
            this.transactAssetGroupBox.Text = "معلومات الأصل الحالية والجديدة";
            this.transactAssetGroupBox.Visible = false;
            // 
            // assetTransactionGridControl
            // 
            this.assetTransactionGridControl.DataSource = this.assetTransactionTblBindingSource;
            this.assetTransactionGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "assetTransactionLevel";
            this.assetTransactionGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.assetTransactionGridControl.Location = new System.Drawing.Point(3, 335);
            this.assetTransactionGridControl.MainView = this.assetTransactionGridView;
            this.assetTransactionGridControl.Name = "assetTransactionGridControl";
            this.assetTransactionGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.astRepositoryItemLookUpEdit,
            this.currRepositoryItemLookUpEdit,
            this.trtyRepositoryItemLookUpEdit});
            this.assetTransactionGridControl.Size = new System.Drawing.Size(1270, 295);
            this.assetTransactionGridControl.TabIndex = 608;
            this.assetTransactionGridControl.UseEmbeddedNavigator = true;
            this.assetTransactionGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.assetTransactionGridView});
            // 
            // assetTransactionTblBindingSource
            // 
            this.assetTransactionTblBindingSource.DataMember = "AssetTransactionTbl";
            this.assetTransactionTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetTransactionGridView
            // 
            this.assetTransactionGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colAssetID,
            this.colTransactionType,
            this.colTransactionDate,
            this.colQuantityTransacted,
            this.colTransactionNotes,
            this.colTransactionMadeOn,
            this.colTransactionMadeBy,
            this.colMoneyAmount,
            this.colMoneyAmountCurrency,
            this.colGetAssetOutOfWork,
            this.colCurrentPriceWithDestroying,
            this.colAssetTransactionUniqueKey});
            this.assetTransactionGridView.GridControl = this.assetTransactionGridControl;
            this.assetTransactionGridView.Name = "assetTransactionGridView";
            this.assetTransactionGridView.OptionsBehavior.Editable = false;
            // 
            // colID
            // 
            this.colID.Caption = "معرف السجل";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 80;
            this.colID.Name = "colID";
            this.colID.Width = 94;
            // 
            // colAssetID
            // 
            this.colAssetID.Caption = "معلومات الأصل";
            this.colAssetID.ColumnEdit = this.astRepositoryItemLookUpEdit;
            this.colAssetID.FieldName = "AssetID";
            this.colAssetID.MinWidth = 150;
            this.colAssetID.Name = "colAssetID";
            this.colAssetID.Visible = true;
            this.colAssetID.VisibleIndex = 0;
            this.colAssetID.Width = 150;
            // 
            // astRepositoryItemLookUpEdit
            // 
            this.astRepositoryItemLookUpEdit.AutoHeight = false;
            this.astRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.astRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 23, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AssetCode", "كود الأصل", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsOldOrNewAsset", "Is Old Or New Asset", 126, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AssetSubDepartment", "Asset Sub Department", 139, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AssetSquare", "Asset Square", 87, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AssetMinorCategory", "Asset Minor Category", 133, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AssetSpecifications", "Asset Specifications", 124, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemsQuantity", "Items Quantity", 94, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Model", "Model", 45, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Color", "Color", 41, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Volume", "Volume", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PurchaseDate", "Purchase Date", 93, DevExpress.Utils.FormatType.DateTime, "dd-MM-yyyy", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PurchasePrice", "Purchase Price", 95, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PurchasePriceCurrency", "Purchase Price Currency", 150, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PlaceOfPresence", "Place Of Presence", 114, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrentStatus", "Current Status", 94, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BenefitPercentage", "Benefit Percentage", 118, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ActualCurrentPrice", "Actual Current Price", 125, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ActualCurrentPriceCurrency", "Actual Current Price Currency", 180, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustodianName", "Custodian Name", 104, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MoreDetails", "More Details", 82, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AssetNotes", "Asset Notes", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstateAddress", "Estate Address", 96, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OwnerName", "Owner Name", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OfUsed", "Of Used", 56, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstateOwnershipDocumentWith", "Estate Ownership Document With", 202, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstateArea", "Estate Area", 77, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstateAreaUnit", "Estate Area Unit", 103, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarPanelNumber", "Car Panel Number", 115, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarManufacturingYear", "Car Manufacturing Year", 146, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarChassisNumber", "Car Chassis Number", 127, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarEngineNumber", "Car Engine Number", 122, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DestructionRate", "Destruction Rate", 105, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LifeSpanInMonths", "Life Span In Months", 124, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsSold", "Is Sold", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsOutOfWork", "Is Out Of Work", 97, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("InsertedOn", "Inserted On", 78, DevExpress.Utils.FormatType.DateTime, "dd-MM-yyyy", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LastModifiedOn", "Last Modified On", 106, DevExpress.Utils.FormatType.DateTime, "dd-MM-yyyy", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("InsertedBy", "Inserted By", 75, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LastModifiedBy", "Last Modified By", 103, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.astRepositoryItemLookUpEdit.DataSource = this.assetVwAllBindingSource;
            this.astRepositoryItemLookUpEdit.DisplayMember = "كود الأصل";
            this.astRepositoryItemLookUpEdit.Name = "astRepositoryItemLookUpEdit";
            this.astRepositoryItemLookUpEdit.PopupWidth = 800;
            this.astRepositoryItemLookUpEdit.ValueMember = "معرف الأصل";
            // 
            // assetVwAllBindingSource
            // 
            this.assetVwAllBindingSource.DataMember = "AssetVw_All";
            this.assetVwAllBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // colTransactionType
            // 
            this.colTransactionType.Caption = "نوع التصريف";
            this.colTransactionType.ColumnEdit = this.trtyRepositoryItemLookUpEdit;
            this.colTransactionType.FieldName = "TransactionType";
            this.colTransactionType.MinWidth = 100;
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.Visible = true;
            this.colTransactionType.VisibleIndex = 1;
            this.colTransactionType.Width = 100;
            // 
            // trtyRepositoryItemLookUpEdit
            // 
            this.trtyRepositoryItemLookUpEdit.AutoHeight = false;
            this.trtyRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.trtyRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف نوع التصريف", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TransactionTypeName", "اسم نوع التصريف", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.trtyRepositoryItemLookUpEdit.DataSource = this.transactionTypeTblBindingSource;
            this.trtyRepositoryItemLookUpEdit.DisplayMember = "TransactionTypeName";
            this.trtyRepositoryItemLookUpEdit.Name = "trtyRepositoryItemLookUpEdit";
            this.trtyRepositoryItemLookUpEdit.PopupWidth = 500;
            this.trtyRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // transactionTypeTblBindingSource
            // 
            this.transactionTypeTblBindingSource.DataMember = "TransactionTypeTbl";
            this.transactionTypeTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.Caption = "تاريخ التصريف";
            this.colTransactionDate.FieldName = "TransactionDate";
            this.colTransactionDate.MinWidth = 100;
            this.colTransactionDate.Name = "colTransactionDate";
            this.colTransactionDate.Visible = true;
            this.colTransactionDate.VisibleIndex = 2;
            this.colTransactionDate.Width = 100;
            // 
            // colQuantityTransacted
            // 
            this.colQuantityTransacted.Caption = "العدد";
            this.colQuantityTransacted.FieldName = "QuantityTransacted";
            this.colQuantityTransacted.MinWidth = 100;
            this.colQuantityTransacted.Name = "colQuantityTransacted";
            this.colQuantityTransacted.Visible = true;
            this.colQuantityTransacted.VisibleIndex = 3;
            this.colQuantityTransacted.Width = 100;
            // 
            // colTransactionNotes
            // 
            this.colTransactionNotes.Caption = "ملاحظات";
            this.colTransactionNotes.FieldName = "TransactionNotes";
            this.colTransactionNotes.MinWidth = 150;
            this.colTransactionNotes.Name = "colTransactionNotes";
            this.colTransactionNotes.Visible = true;
            this.colTransactionNotes.VisibleIndex = 4;
            this.colTransactionNotes.Width = 150;
            // 
            // colTransactionMadeOn
            // 
            this.colTransactionMadeOn.Caption = "تاريخ إضافة السجل ";
            this.colTransactionMadeOn.FieldName = "TransactionMadeOn";
            this.colTransactionMadeOn.MinWidth = 100;
            this.colTransactionMadeOn.Name = "colTransactionMadeOn";
            this.colTransactionMadeOn.Width = 94;
            // 
            // colTransactionMadeBy
            // 
            this.colTransactionMadeBy.Caption = "المستخدم الذي قام بالإضافة";
            this.colTransactionMadeBy.FieldName = "TransactionMadeBy";
            this.colTransactionMadeBy.MinWidth = 100;
            this.colTransactionMadeBy.Name = "colTransactionMadeBy";
            this.colTransactionMadeBy.Width = 94;
            // 
            // colMoneyAmount
            // 
            this.colMoneyAmount.Caption = "مبلغ البيع";
            this.colMoneyAmount.FieldName = "MoneyAmount";
            this.colMoneyAmount.MinWidth = 100;
            this.colMoneyAmount.Name = "colMoneyAmount";
            this.colMoneyAmount.Visible = true;
            this.colMoneyAmount.VisibleIndex = 5;
            this.colMoneyAmount.Width = 100;
            // 
            // colMoneyAmountCurrency
            // 
            this.colMoneyAmountCurrency.Caption = "عملة مبلغ البيع";
            this.colMoneyAmountCurrency.ColumnEdit = this.currRepositoryItemLookUpEdit;
            this.colMoneyAmountCurrency.FieldName = "MoneyAmountCurrency";
            this.colMoneyAmountCurrency.MinWidth = 100;
            this.colMoneyAmountCurrency.Name = "colMoneyAmountCurrency";
            this.colMoneyAmountCurrency.Visible = true;
            this.colMoneyAmountCurrency.VisibleIndex = 6;
            this.colMoneyAmountCurrency.Width = 100;
            // 
            // currRepositoryItemLookUpEdit
            // 
            this.currRepositoryItemLookUpEdit.AutoHeight = false;
            this.currRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.currRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف العملة", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyName", "اسم العملة", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.currRepositoryItemLookUpEdit.DataSource = this.currencyTblBindingSource;
            this.currRepositoryItemLookUpEdit.DisplayMember = "CurrencyName";
            this.currRepositoryItemLookUpEdit.Name = "currRepositoryItemLookUpEdit";
            this.currRepositoryItemLookUpEdit.PopupWidth = 500;
            this.currRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // currencyTblBindingSource
            // 
            this.currencyTblBindingSource.DataMember = "CurrencyTbl";
            this.currencyTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // colGetAssetOutOfWork
            // 
            this.colGetAssetOutOfWork.Caption = "إخراج الأصل من الخدمة";
            this.colGetAssetOutOfWork.FieldName = "GetAssetOutOfWork";
            this.colGetAssetOutOfWork.MinWidth = 100;
            this.colGetAssetOutOfWork.Name = "colGetAssetOutOfWork";
            this.colGetAssetOutOfWork.Visible = true;
            this.colGetAssetOutOfWork.VisibleIndex = 7;
            this.colGetAssetOutOfWork.Width = 100;
            // 
            // colCurrentPriceWithDestroying
            // 
            this.colCurrentPriceWithDestroying.Caption = "السعر الحالي مع الإهلاك";
            this.colCurrentPriceWithDestroying.FieldName = "CurrentPriceWithDestroying";
            this.colCurrentPriceWithDestroying.MinWidth = 100;
            this.colCurrentPriceWithDestroying.Name = "colCurrentPriceWithDestroying";
            this.colCurrentPriceWithDestroying.Visible = true;
            this.colCurrentPriceWithDestroying.VisibleIndex = 8;
            this.colCurrentPriceWithDestroying.Width = 100;
            // 
            // colAssetTransactionUniqueKey
            // 
            this.colAssetTransactionUniqueKey.Caption = "رقم فريد لسجل التصريف";
            this.colAssetTransactionUniqueKey.FieldName = "AssetTransactionUniqueKey";
            this.colAssetTransactionUniqueKey.MinWidth = 120;
            this.colAssetTransactionUniqueKey.Name = "colAssetTransactionUniqueKey";
            this.colAssetTransactionUniqueKey.Width = 94;
            // 
            // assetTransactionPanel
            // 
            this.assetTransactionPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.assetTransactionPanel.Controls.Add(this.assetCurrentItemsQuantityNumericUpDown);
            this.assetTransactionPanel.Controls.Add(this.qtyOutOfLabel);
            this.assetTransactionPanel.Controls.Add(this.assetItemsQuantityLabel);
            this.assetTransactionPanel.Controls.Add(this.assetItemsQuantityToTransactNumericUpDown);
            this.assetTransactionPanel.Controls.Add(this.currentPriceWithDestroyingLabel);
            this.assetTransactionPanel.Controls.Add(this.currentPriceWithDestroyingNumericUpDown);
            this.assetTransactionPanel.Controls.Add(this.manageCurrencyTblBtn);
            this.assetTransactionPanel.Controls.Add(this.moneyAmountCurrencyLabel);
            this.assetTransactionPanel.Controls.Add(this.moneyAmountCurrencyLookUpEdit);
            this.assetTransactionPanel.Controls.Add(this.manageTransactionTypeTblBtn);
            this.assetTransactionPanel.Controls.Add(this.moneyAmountLabel);
            this.assetTransactionPanel.Controls.Add(this.moneyAmountNumericUpDown);
            this.assetTransactionPanel.Controls.Add(this.assetNotesLabel);
            this.assetTransactionPanel.Controls.Add(this.assetNotesTextBox);
            this.assetTransactionPanel.Controls.Add(this.getAssetOutOfWorkCheckBox);
            this.assetTransactionPanel.Controls.Add(this.assetTransactBtn);
            this.assetTransactionPanel.Controls.Add(this.assetTransactionDateDateEdit);
            this.assetTransactionPanel.Controls.Add(this.transactionTypeLabel);
            this.assetTransactionPanel.Controls.Add(this.assetTransactionDateLabel);
            this.assetTransactionPanel.Controls.Add(this.transactionTypeLookUpEdit);
            this.assetTransactionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.assetTransactionPanel.Location = new System.Drawing.Point(3, 110);
            this.assetTransactionPanel.Name = "assetTransactionPanel";
            this.assetTransactionPanel.Size = new System.Drawing.Size(1270, 225);
            this.assetTransactionPanel.TabIndex = 607;
            this.assetTransactionPanel.Visible = false;
            // 
            // assetCurrentItemsQuantityNumericUpDown
            // 
            this.assetCurrentItemsQuantityNumericUpDown.DecimalPlaces = 2;
            this.assetCurrentItemsQuantityNumericUpDown.Enabled = false;
            this.assetCurrentItemsQuantityNumericUpDown.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetCurrentItemsQuantityNumericUpDown.Location = new System.Drawing.Point(264, 176);
            this.assetCurrentItemsQuantityNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.assetCurrentItemsQuantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.assetCurrentItemsQuantityNumericUpDown.Name = "assetCurrentItemsQuantityNumericUpDown";
            this.assetCurrentItemsQuantityNumericUpDown.Size = new System.Drawing.Size(126, 28);
            this.assetCurrentItemsQuantityNumericUpDown.TabIndex = 402;
            this.assetCurrentItemsQuantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // qtyOutOfLabel
            // 
            this.qtyOutOfLabel.AutoSize = true;
            this.qtyOutOfLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyOutOfLabel.Location = new System.Drawing.Point(447, 180);
            this.qtyOutOfLabel.Name = "qtyOutOfLabel";
            this.qtyOutOfLabel.Size = new System.Drawing.Size(62, 21);
            this.qtyOutOfLabel.TabIndex = 401;
            this.qtyOutOfLabel.Text = "من أصل:";
            // 
            // assetItemsQuantityLabel
            // 
            this.assetItemsQuantityLabel.AutoSize = true;
            this.assetItemsQuantityLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetItemsQuantityLabel.Location = new System.Drawing.Point(688, 180);
            this.assetItemsQuantityLabel.Name = "assetItemsQuantityLabel";
            this.assetItemsQuantityLabel.Size = new System.Drawing.Size(97, 21);
            this.assetItemsQuantityLabel.TabIndex = 285;
            this.assetItemsQuantityLabel.Text = "الكمية المصرفة:";
            // 
            // assetItemsQuantityToTransactNumericUpDown
            // 
            this.assetItemsQuantityToTransactNumericUpDown.DecimalPlaces = 2;
            this.assetItemsQuantityToTransactNumericUpDown.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetItemsQuantityToTransactNumericUpDown.Location = new System.Drawing.Point(538, 176);
            this.assetItemsQuantityToTransactNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.assetItemsQuantityToTransactNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.assetItemsQuantityToTransactNumericUpDown.Name = "assetItemsQuantityToTransactNumericUpDown";
            this.assetItemsQuantityToTransactNumericUpDown.Size = new System.Drawing.Size(126, 28);
            this.assetItemsQuantityToTransactNumericUpDown.TabIndex = 290;
            this.assetItemsQuantityToTransactNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.assetItemsQuantityToTransactNumericUpDown.ValueChanged += new System.EventHandler(this.assetItemsQuantityToTransactNumericUpDown_ValueChanged);
            // 
            // currentPriceWithDestroyingLabel
            // 
            this.currentPriceWithDestroyingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPriceWithDestroyingLabel.AutoSize = true;
            this.currentPriceWithDestroyingLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPriceWithDestroyingLabel.Location = new System.Drawing.Point(1080, 180);
            this.currentPriceWithDestroyingLabel.Name = "currentPriceWithDestroyingLabel";
            this.currentPriceWithDestroyingLabel.Size = new System.Drawing.Size(158, 21);
            this.currentPriceWithDestroyingLabel.TabIndex = 275;
            this.currentPriceWithDestroyingLabel.Text = "القيمة الحالية مع الإهلاك:";
            // 
            // currentPriceWithDestroyingNumericUpDown
            // 
            this.currentPriceWithDestroyingNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPriceWithDestroyingNumericUpDown.DecimalPlaces = 2;
            this.currentPriceWithDestroyingNumericUpDown.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPriceWithDestroyingNumericUpDown.Location = new System.Drawing.Point(871, 176);
            this.currentPriceWithDestroyingNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.currentPriceWithDestroyingNumericUpDown.Name = "currentPriceWithDestroyingNumericUpDown";
            this.currentPriceWithDestroyingNumericUpDown.Size = new System.Drawing.Size(188, 28);
            this.currentPriceWithDestroyingNumericUpDown.TabIndex = 280;
            // 
            // manageCurrencyTblBtn
            // 
            this.manageCurrencyTblBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCurrencyTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageCurrencyTblBtn.Location = new System.Drawing.Point(264, 113);
            this.manageCurrencyTblBtn.Name = "manageCurrencyTblBtn";
            this.manageCurrencyTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageCurrencyTblBtn.TabIndex = 270;
            this.manageCurrencyTblBtn.UseVisualStyleBackColor = true;
            this.manageCurrencyTblBtn.Click += new System.EventHandler(this.manageCurrencyTblBtn_Click);
            // 
            // moneyAmountCurrencyLabel
            // 
            this.moneyAmountCurrencyLabel.AutoSize = true;
            this.moneyAmountCurrencyLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyAmountCurrencyLabel.Location = new System.Drawing.Point(736, 130);
            this.moneyAmountCurrencyLabel.Name = "moneyAmountCurrencyLabel";
            this.moneyAmountCurrencyLabel.Size = new System.Drawing.Size(49, 21);
            this.moneyAmountCurrencyLabel.TabIndex = 260;
            this.moneyAmountCurrencyLabel.Text = "العملة:";
            // 
            // moneyAmountCurrencyLookUpEdit
            // 
            this.moneyAmountCurrencyLookUpEdit.Location = new System.Drawing.Point(403, 126);
            this.moneyAmountCurrencyLookUpEdit.Name = "moneyAmountCurrencyLookUpEdit";
            this.moneyAmountCurrencyLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyAmountCurrencyLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.moneyAmountCurrencyLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.moneyAmountCurrencyLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف العملة", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyName", "اسم العملة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.moneyAmountCurrencyLookUpEdit.Properties.DataSource = this.currencyTblBindingSource;
            this.moneyAmountCurrencyLookUpEdit.Properties.DisplayMember = "CurrencyName";
            this.moneyAmountCurrencyLookUpEdit.Properties.PopupWidth = 500;
            this.moneyAmountCurrencyLookUpEdit.Properties.ValueMember = "ID";
            this.moneyAmountCurrencyLookUpEdit.Size = new System.Drawing.Size(261, 28);
            this.moneyAmountCurrencyLookUpEdit.TabIndex = 265;
            // 
            // manageTransactionTypeTblBtn
            // 
            this.manageTransactionTypeTblBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageTransactionTypeTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageTransactionTypeTblBtn.Location = new System.Drawing.Point(264, 13);
            this.manageTransactionTypeTblBtn.Name = "manageTransactionTypeTblBtn";
            this.manageTransactionTypeTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageTransactionTypeTblBtn.TabIndex = 225;
            this.manageTransactionTypeTblBtn.UseVisualStyleBackColor = true;
            this.manageTransactionTypeTblBtn.Click += new System.EventHandler(this.manageTransactionTypeTblBtn_Click);
            // 
            // moneyAmountLabel
            // 
            this.moneyAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moneyAmountLabel.AutoSize = true;
            this.moneyAmountLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyAmountLabel.Location = new System.Drawing.Point(1167, 130);
            this.moneyAmountLabel.Name = "moneyAmountLabel";
            this.moneyAmountLabel.Size = new System.Drawing.Size(71, 21);
            this.moneyAmountLabel.TabIndex = 250;
            this.moneyAmountLabel.Text = "سعر البيع:";
            // 
            // moneyAmountNumericUpDown
            // 
            this.moneyAmountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moneyAmountNumericUpDown.DecimalPlaces = 2;
            this.moneyAmountNumericUpDown.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyAmountNumericUpDown.Location = new System.Drawing.Point(871, 126);
            this.moneyAmountNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.moneyAmountNumericUpDown.Name = "moneyAmountNumericUpDown";
            this.moneyAmountNumericUpDown.Size = new System.Drawing.Size(188, 28);
            this.moneyAmountNumericUpDown.TabIndex = 255;
            // 
            // assetNotesLabel
            // 
            this.assetNotesLabel.AutoSize = true;
            this.assetNotesLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetNotesLabel.Location = new System.Drawing.Point(715, 80);
            this.assetNotesLabel.Name = "assetNotesLabel";
            this.assetNotesLabel.Size = new System.Drawing.Size(70, 21);
            this.assetNotesLabel.TabIndex = 240;
            this.assetNotesLabel.Text = "ملاحظات:";
            // 
            // assetNotesTextBox
            // 
            this.assetNotesTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetNotesTextBox.Location = new System.Drawing.Point(250, 76);
            this.assetNotesTextBox.Name = "assetNotesTextBox";
            this.assetNotesTextBox.Size = new System.Drawing.Size(414, 28);
            this.assetNotesTextBox.TabIndex = 245;
            // 
            // getAssetOutOfWorkCheckBox
            // 
            this.getAssetOutOfWorkCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getAssetOutOfWorkCheckBox.AutoSize = true;
            this.getAssetOutOfWorkCheckBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAssetOutOfWorkCheckBox.Location = new System.Drawing.Point(1071, 78);
            this.getAssetOutOfWorkCheckBox.Name = "getAssetOutOfWorkCheckBox";
            this.getAssetOutOfWorkCheckBox.Size = new System.Drawing.Size(167, 25);
            this.getAssetOutOfWorkCheckBox.TabIndex = 230;
            this.getAssetOutOfWorkCheckBox.Text = "إخراج الأصل من الخدمة";
            this.getAssetOutOfWorkCheckBox.UseVisualStyleBackColor = true;
            this.getAssetOutOfWorkCheckBox.CheckedChanged += new System.EventHandler(this.getAssetOutOfWorkCheckBox_CheckedChanged);
            // 
            // assetTransactBtn
            // 
            this.assetTransactBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetTransactBtn.Image = global::AssetManagement.Properties.Resources._1592276;
            this.assetTransactBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.assetTransactBtn.Location = new System.Drawing.Point(25, 80);
            this.assetTransactBtn.Name = "assetTransactBtn";
            this.assetTransactBtn.Size = new System.Drawing.Size(163, 74);
            this.assetTransactBtn.TabIndex = 400;
            this.assetTransactBtn.Text = "تصريف";
            this.assetTransactBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.assetTransactBtn.UseVisualStyleBackColor = true;
            this.assetTransactBtn.Click += new System.EventHandler(this.assetTransactBtn_Click);
            // 
            // assetTransactionDateDateEdit
            // 
            this.assetTransactionDateDateEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assetTransactionDateDateEdit.EditValue = null;
            this.assetTransactionDateDateEdit.Location = new System.Drawing.Point(871, 26);
            this.assetTransactionDateDateEdit.Name = "assetTransactionDateDateEdit";
            this.assetTransactionDateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetTransactionDateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.assetTransactionDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.assetTransactionDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.assetTransactionDateDateEdit.Size = new System.Drawing.Size(259, 28);
            this.assetTransactionDateDateEdit.TabIndex = 210;
            // 
            // transactionTypeLabel
            // 
            this.transactionTypeLabel.AutoSize = true;
            this.transactionTypeLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionTypeLabel.Location = new System.Drawing.Point(699, 30);
            this.transactionTypeLabel.Name = "transactionTypeLabel";
            this.transactionTypeLabel.Size = new System.Drawing.Size(86, 21);
            this.transactionTypeLabel.TabIndex = 215;
            this.transactionTypeLabel.Text = "نوع التصريف:";
            // 
            // assetTransactionDateLabel
            // 
            this.assetTransactionDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assetTransactionDateLabel.AutoSize = true;
            this.assetTransactionDateLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetTransactionDateLabel.Location = new System.Drawing.Point(1140, 30);
            this.assetTransactionDateLabel.Name = "assetTransactionDateLabel";
            this.assetTransactionDateLabel.Size = new System.Drawing.Size(98, 21);
            this.assetTransactionDateLabel.TabIndex = 205;
            this.assetTransactionDateLabel.Text = "تاريخ التصريف:";
            // 
            // transactionTypeLookUpEdit
            // 
            this.transactionTypeLookUpEdit.Location = new System.Drawing.Point(403, 26);
            this.transactionTypeLookUpEdit.Name = "transactionTypeLookUpEdit";
            this.transactionTypeLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionTypeLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.transactionTypeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.transactionTypeLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف نوع تصريف الأصل", 100, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TransactionTypeName", "اسم نوع تصريف الأصل", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TransactionTypeDescription", "وصف نوع تصريف الأصل", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.transactionTypeLookUpEdit.Properties.DataSource = this.transactionTypeTblBindingSource;
            this.transactionTypeLookUpEdit.Properties.DisplayMember = "TransactionTypeName";
            this.transactionTypeLookUpEdit.Properties.PopupWidth = 500;
            this.transactionTypeLookUpEdit.Properties.ValueMember = "ID";
            this.transactionTypeLookUpEdit.Size = new System.Drawing.Size(261, 28);
            this.transactionTypeLookUpEdit.TabIndex = 220;
            this.transactionTypeLookUpEdit.EditValueChanged += new System.EventHandler(this.transactionTypeLookUpEdit_EditValueChanged);
            // 
            // assetInfoTextBox
            // 
            this.assetInfoTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.assetInfoTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetInfoTextBox.Location = new System.Drawing.Point(3, 28);
            this.assetInfoTextBox.Multiline = true;
            this.assetInfoTextBox.Name = "assetInfoTextBox";
            this.assetInfoTextBox.ReadOnly = true;
            this.assetInfoTextBox.Size = new System.Drawing.Size(1270, 82);
            this.assetInfoTextBox.TabIndex = 606;
            // 
            // transactionTypeTblBindingSource1
            // 
            this.transactionTypeTblBindingSource1.DataMember = "TransactionTypeTbl";
            this.transactionTypeTblBindingSource1.DataSource = this.assetMngDbDataSet;
            // 
            // currencyTblBindingSource1
            // 
            this.currencyTblBindingSource1.DataMember = "CurrencyTbl";
            this.currencyTblBindingSource1.DataSource = this.assetMngDbDataSet;
            // 
            // mainAlertControl
            // 
            this.mainAlertControl.AppearanceCaption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainAlertControl.AppearanceCaption.Options.UseFont = true;
            this.mainAlertControl.AppearanceCaption.Options.UseTextOptions = true;
            this.mainAlertControl.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.mainAlertControl.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.mainAlertControl.AppearanceText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainAlertControl.AppearanceText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mainAlertControl.AppearanceText.Options.UseFont = true;
            this.mainAlertControl.AppearanceText.Options.UseForeColor = true;
            this.mainAlertControl.AppearanceText.Options.UseTextOptions = true;
            this.mainAlertControl.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.mainAlertControl.AppearanceText.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.mainAlertControl.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight;
            this.mainAlertControl.FormLoad += new DevExpress.XtraBars.Alerter.AlertFormLoadEventHandler(this.mainAlertControl_FormLoad);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssetMovementTblTableAdapter = null;
            this.tableAdapterManager.AssetTblTableAdapter = null;
            this.tableAdapterManager.AssetTransactionTblTableAdapter = this.assetTransactionTblTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CurrencyTblTableAdapter = this.currencyTblTableAdapter;
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
            this.tableAdapterManager.TransactionTypeTblTableAdapter = this.transactionTypeTblTableAdapter;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // assetTransactionTblTableAdapter
            // 
            this.assetTransactionTblTableAdapter.ClearBeforeFill = true;
            // 
            // currencyTblTableAdapter
            // 
            this.currencyTblTableAdapter.ClearBeforeFill = true;
            // 
            // transactionTypeTblTableAdapter
            // 
            this.transactionTypeTblTableAdapter.ClearBeforeFill = true;
            // 
            // viewAssetInformationBtn
            // 
            this.viewAssetInformationBtn.Image = global::AssetManagement.Properties.Resources._8341961;
            this.viewAssetInformationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewAssetInformationBtn.Location = new System.Drawing.Point(1085, 53);
            this.viewAssetInformationBtn.Name = "viewAssetInformationBtn";
            this.viewAssetInformationBtn.Size = new System.Drawing.Size(163, 74);
            this.viewAssetInformationBtn.TabIndex = 105;
            this.viewAssetInformationBtn.Text = "عرض معلومات الأصل";
            this.viewAssetInformationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewAssetInformationBtn.UseVisualStyleBackColor = true;
            this.viewAssetInformationBtn.Visible = false;
            this.viewAssetInformationBtn.Click += new System.EventHandler(this.viewAssetInformationBtn_Click);
            // 
            // searchResultsListBox
            // 
            this.searchResultsListBox.DataSource = this.assetVwBindingSource;
            this.searchResultsListBox.DisplayMember = "كود الأصل";
            this.searchResultsListBox.FormattingEnabled = true;
            this.searchResultsListBox.ItemHeight = 24;
            this.searchResultsListBox.Location = new System.Drawing.Point(598, 25);
            this.searchResultsListBox.Name = "searchResultsListBox";
            this.searchResultsListBox.Size = new System.Drawing.Size(440, 124);
            this.searchResultsListBox.TabIndex = 104;
            this.searchResultsListBox.ValueMember = "معرف الأصل";
            this.searchResultsListBox.Visible = false;
            this.searchResultsListBox.DoubleClick += new System.EventHandler(this.viewAssetInformationBtn_Click);
            // 
            // assetVwBindingSource
            // 
            this.assetVwBindingSource.DataMember = "AssetVw";
            this.assetVwBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // searchAssetBtn
            // 
            this.searchAssetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchAssetBtn.Image = global::AssetManagement.Properties.Resources._2719309;
            this.searchAssetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchAssetBtn.Location = new System.Drawing.Point(225, 78);
            this.searchAssetBtn.Name = "searchAssetBtn";
            this.searchAssetBtn.Size = new System.Drawing.Size(163, 74);
            this.searchAssetBtn.TabIndex = 103;
            this.searchAssetBtn.Text = "بحث";
            this.searchAssetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchAssetBtn.UseVisualStyleBackColor = true;
            this.searchAssetBtn.Click += new System.EventHandler(this.searchAssetBtn_Click);
            // 
            // assetCodeLabel
            // 
            this.assetCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assetCodeLabel.AutoSize = true;
            this.assetCodeLabel.Location = new System.Drawing.Point(57, 29);
            this.assetCodeLabel.Name = "assetCodeLabel";
            this.assetCodeLabel.Size = new System.Drawing.Size(86, 24);
            this.assetCodeLabel.TabIndex = 101;
            this.assetCodeLabel.Text = "كود الأصل:";
            // 
            // assetCodeTextBox
            // 
            this.assetCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assetCodeTextBox.Location = new System.Drawing.Point(185, 25);
            this.assetCodeTextBox.Name = "assetCodeTextBox";
            this.assetCodeTextBox.Size = new System.Drawing.Size(288, 32);
            this.assetCodeTextBox.TabIndex = 102;
            // 
            // assetVwTableAdapter
            // 
            this.assetVwTableAdapter.ClearBeforeFill = true;
            // 
            // assetVw_AllTableAdapter
            // 
            this.assetVw_AllTableAdapter.ClearBeforeFill = true;
            // 
            // TransacteAssetForm
            // 
            this.AcceptButton = this.searchAssetBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 801);
            this.Controls.Add(this.viewAssetInformationBtn);
            this.Controls.Add(this.searchResultsListBox);
            this.Controls.Add(this.searchAssetBtn);
            this.Controls.Add(this.assetCodeLabel);
            this.Controls.Add(this.assetCodeTextBox);
            this.Controls.Add(this.transactAssetGroupBox);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TransacteAssetForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تصريف أصل";
            this.Load += new System.EventHandler(this.TransacteAssetForm_Load);
            this.transactAssetGroupBox.ResumeLayout(false);
            this.transactAssetGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.astRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trtyRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).EndInit();
            this.assetTransactionPanel.ResumeLayout(false);
            this.assetTransactionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetCurrentItemsQuantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetItemsQuantityToTransactNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPriceWithDestroyingNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyAmountCurrencyLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyAmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox transactAssetGroupBox;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private AssetMngDbDataSet assetMngDbDataSet;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource assetTransactionTblBindingSource;
        private AssetMngDbDataSetTableAdapters.AssetTransactionTblTableAdapter assetTransactionTblTableAdapter;
        private System.Windows.Forms.BindingSource transactionTypeTblBindingSource;
        private AssetMngDbDataSetTableAdapters.TransactionTypeTblTableAdapter transactionTypeTblTableAdapter;
        private System.Windows.Forms.BindingSource currencyTblBindingSource;
        private AssetMngDbDataSetTableAdapters.CurrencyTblTableAdapter currencyTblTableAdapter;
        private System.Windows.Forms.BindingSource transactionTypeTblBindingSource1;
        private System.Windows.Forms.BindingSource currencyTblBindingSource1;
        private System.Windows.Forms.Button viewAssetInformationBtn;
        private System.Windows.Forms.ListBox searchResultsListBox;
        private System.Windows.Forms.Button searchAssetBtn;
        private System.Windows.Forms.Label assetCodeLabel;
        private System.Windows.Forms.TextBox assetCodeTextBox;
        private System.Windows.Forms.TextBox assetInfoTextBox;
        private System.Windows.Forms.Panel assetTransactionPanel;
        private System.Windows.Forms.Label currentPriceWithDestroyingLabel;
        private System.Windows.Forms.NumericUpDown currentPriceWithDestroyingNumericUpDown;
        private System.Windows.Forms.Button manageCurrencyTblBtn;
        private System.Windows.Forms.Label moneyAmountCurrencyLabel;
        private DevExpress.XtraEditors.LookUpEdit moneyAmountCurrencyLookUpEdit;
        private System.Windows.Forms.Button manageTransactionTypeTblBtn;
        private System.Windows.Forms.Label moneyAmountLabel;
        private System.Windows.Forms.NumericUpDown moneyAmountNumericUpDown;
        private System.Windows.Forms.Label assetNotesLabel;
        private System.Windows.Forms.TextBox assetNotesTextBox;
        private System.Windows.Forms.CheckBox getAssetOutOfWorkCheckBox;
        private System.Windows.Forms.Button assetTransactBtn;
        private DevExpress.XtraEditors.DateEdit assetTransactionDateDateEdit;
        private System.Windows.Forms.Label transactionTypeLabel;
        private System.Windows.Forms.Label assetTransactionDateLabel;
        private DevExpress.XtraEditors.LookUpEdit transactionTypeLookUpEdit;
        private System.Windows.Forms.Label assetItemsQuantityLabel;
        private System.Windows.Forms.NumericUpDown assetItemsQuantityToTransactNumericUpDown;
        private System.Windows.Forms.NumericUpDown assetCurrentItemsQuantityNumericUpDown;
        private System.Windows.Forms.Label qtyOutOfLabel;
        private System.Windows.Forms.BindingSource assetVwBindingSource;
        private AssetMngDbDataSetTableAdapters.AssetVwTableAdapter assetVwTableAdapter;
        private DevExpress.XtraGrid.GridControl assetTransactionGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView assetTransactionGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit astRepositoryItemLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit trtyRepositoryItemLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityTransacted;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionMadeOn;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionMadeBy;
        private DevExpress.XtraGrid.Columns.GridColumn colMoneyAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colMoneyAmountCurrency;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit currRepositoryItemLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colGetAssetOutOfWork;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentPriceWithDestroying;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetTransactionUniqueKey;
        private System.Windows.Forms.BindingSource assetVwAllBindingSource;
        private AssetMngDbDataSetTableAdapters.AssetVw_AllTableAdapter assetVw_AllTableAdapter;
    }
}