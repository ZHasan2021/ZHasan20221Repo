
namespace AssetManagement.AuxTables
{
    partial class ManageAssetTransactionTblForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAssetTransactionTblForm));
            this.assetTransactionGridControl = new DevExpress.XtraGrid.GridControl();
            this.assetTransactionTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.assetTransactionGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.astRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.assetVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colTransactionType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.trtyRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.transactionTypeTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionMadeOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionMadeBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoneyAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoneyAmountCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.currRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.currencyTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colGetAssetOutOfWork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWithDestroying = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentPriceWithDestroying = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetTransactionUniqueKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.assetTransactionTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetTransactionTblTableAdapter();
            this.currencyTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.CurrencyTblTableAdapter();
            this.transactionTypeTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.TransactionTypeTblTableAdapter();
            this.assetTransactionTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.assetTransactionTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.assetTransactionTblBindingNavigatorExportToExcelItem = new System.Windows.Forms.ToolStripButton();
            this.assetTransactionTblBindingNavigatorViewAssetCardItem = new System.Windows.Forms.ToolStripButton();
            this.assetVwTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetVwTableAdapter();
            this.assetVwAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetVw_AllTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetVw_AllTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.astRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trtyRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionTblBindingNavigator)).BeginInit();
            this.assetTransactionTblBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwAllBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // assetTransactionGridControl
            // 
            this.assetTransactionGridControl.DataSource = this.assetTransactionTblBindingSource;
            this.assetTransactionGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "assetTransactionLevel";
            this.assetTransactionGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.assetTransactionGridControl.Location = new System.Drawing.Point(0, 47);
            this.assetTransactionGridControl.MainView = this.assetTransactionGridView;
            this.assetTransactionGridControl.Name = "assetTransactionGridControl";
            this.assetTransactionGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.astRepositoryItemLookUpEdit,
            this.currRepositoryItemLookUpEdit,
            this.trtyRepositoryItemLookUpEdit});
            this.assetTransactionGridControl.Size = new System.Drawing.Size(1282, 706);
            this.assetTransactionGridControl.TabIndex = 5;
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
            this.colTransactionNotes,
            this.colTransactionMadeOn,
            this.colTransactionMadeBy,
            this.colMoneyAmount,
            this.colMoneyAmountCurrency,
            this.colGetAssetOutOfWork,
            this.colWithDestroying,
            this.colCurrentPriceWithDestroying,
            this.colAssetTransactionUniqueKey});
            this.assetTransactionGridView.GridControl = this.assetTransactionGridControl;
            this.assetTransactionGridView.Name = "assetTransactionGridView";
            this.assetTransactionGridView.OptionsBehavior.Editable = false;
            this.assetTransactionGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.assetTransactionGridView_RowClick);
            this.assetTransactionGridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.assetTransactionGridView_RowCellClick);
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("معرف الأصل", "معرف الأصل", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("كود الأصل", "كود الأصل", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("الدائرة", "الدائرة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("القسم", "القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("الوحدة", "الوحدة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("الساحة", "الساحة", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("الفئة الرئيسية", "الفئة الرئيسية", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("الفئة الفرعية", "الفئة الفرعية", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("مواصفات الأصل", "مواصفات الأصل", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.astRepositoryItemLookUpEdit.DataSource = this.assetVwAllBindingSource;
            this.astRepositoryItemLookUpEdit.DisplayMember = "كود الأصل";
            this.astRepositoryItemLookUpEdit.Name = "astRepositoryItemLookUpEdit";
            this.astRepositoryItemLookUpEdit.PopupWidth = 800;
            this.astRepositoryItemLookUpEdit.ValueMember = "معرف الأصل";
            // 
            // assetVwBindingSource
            // 
            this.assetVwBindingSource.DataMember = "AssetVw";
            this.assetVwBindingSource.DataSource = this.assetMngDbDataSet;
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
            // colTransactionNotes
            // 
            this.colTransactionNotes.Caption = "ملاحظات";
            this.colTransactionNotes.FieldName = "TransactionNotes";
            this.colTransactionNotes.MinWidth = 150;
            this.colTransactionNotes.Name = "colTransactionNotes";
            this.colTransactionNotes.Visible = true;
            this.colTransactionNotes.VisibleIndex = 3;
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
            this.colMoneyAmount.VisibleIndex = 4;
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
            this.colMoneyAmountCurrency.VisibleIndex = 5;
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
            this.colGetAssetOutOfWork.VisibleIndex = 6;
            this.colGetAssetOutOfWork.Width = 100;
            // 
            // colWithDestroying
            // 
            this.colWithDestroying.Caption = "مع إهلاك";
            this.colWithDestroying.FieldName = "WithDestroying";
            this.colWithDestroying.MinWidth = 100;
            this.colWithDestroying.Name = "colWithDestroying";
            this.colWithDestroying.Visible = true;
            this.colWithDestroying.VisibleIndex = 7;
            this.colWithDestroying.Width = 100;
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
            this.tableAdapterManager.AssetTransactionTblTableAdapter = this.assetTransactionTblTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CurrencyTblTableAdapter = this.currencyTblTableAdapter;
            this.tableAdapterManager.DepartmentTblTableAdapter = null;
            this.tableAdapterManager.EstateAreaUnitTblTableAdapter = null;
            this.tableAdapterManager.FinancialItemCategoryTblTableAdapter = null;
            this.tableAdapterManager.FinancialItemTblTableAdapter = null;
            this.tableAdapterManager.ImportExportTblTableAdapter = null;
            this.tableAdapterManager.MainCategoryTblTableAdapter = null;
            this.tableAdapterManager.MinorCategoryTblTableAdapter = null;
            this.tableAdapterManager.ModelTblTableAdapter = null;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
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
            // assetTransactionTblBindingNavigator
            // 
            this.assetTransactionTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.assetTransactionTblBindingNavigator.BindingSource = this.assetTransactionTblBindingSource;
            this.assetTransactionTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.assetTransactionTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.assetTransactionTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.assetTransactionTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.assetTransactionTblBindingNavigatorSaveItem,
            this.assetTransactionTblBindingNavigatorExportToExcelItem,
            this.assetTransactionTblBindingNavigatorViewAssetCardItem});
            this.assetTransactionTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.assetTransactionTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.assetTransactionTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.assetTransactionTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.assetTransactionTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.assetTransactionTblBindingNavigator.Name = "assetTransactionTblBindingNavigator";
            this.assetTransactionTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.assetTransactionTblBindingNavigator.Size = new System.Drawing.Size(1282, 47);
            this.assetTransactionTblBindingNavigator.TabIndex = 4;
            this.assetTransactionTblBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Visible = false;
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
            this.bindingNavigatorDeleteItem.Visible = false;
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
            // assetTransactionTblBindingNavigatorSaveItem
            // 
            this.assetTransactionTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.assetTransactionTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("assetTransactionTblBindingNavigatorSaveItem.Image")));
            this.assetTransactionTblBindingNavigatorSaveItem.Name = "assetTransactionTblBindingNavigatorSaveItem";
            this.assetTransactionTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(44, 44);
            this.assetTransactionTblBindingNavigatorSaveItem.Text = "Save Data";
            this.assetTransactionTblBindingNavigatorSaveItem.Visible = false;
            this.assetTransactionTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.assetTransactionTblBindingNavigatorSaveItem_Click);
            // 
            // assetTransactionTblBindingNavigatorExportToExcelItem
            // 
            this.assetTransactionTblBindingNavigatorExportToExcelItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.assetTransactionTblBindingNavigatorExportToExcelItem.Image = global::AssetManagement.Properties.Resources._36435172;
            this.assetTransactionTblBindingNavigatorExportToExcelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.assetTransactionTblBindingNavigatorExportToExcelItem.Name = "assetTransactionTblBindingNavigatorExportToExcelItem";
            this.assetTransactionTblBindingNavigatorExportToExcelItem.Size = new System.Drawing.Size(44, 44);
            this.assetTransactionTblBindingNavigatorExportToExcelItem.Text = "تصدير إلى اكسل";
            this.assetTransactionTblBindingNavigatorExportToExcelItem.Click += new System.EventHandler(this.assetTransactionTblBindingNavigatorExportToExcelItem_Click);
            // 
            // assetTransactionTblBindingNavigatorViewAssetCardItem
            // 
            this.assetTransactionTblBindingNavigatorViewAssetCardItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.assetTransactionTblBindingNavigatorViewAssetCardItem.Image = global::AssetManagement.Properties.Resources._8341961;
            this.assetTransactionTblBindingNavigatorViewAssetCardItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.assetTransactionTblBindingNavigatorViewAssetCardItem.Name = "assetTransactionTblBindingNavigatorViewAssetCardItem";
            this.assetTransactionTblBindingNavigatorViewAssetCardItem.Size = new System.Drawing.Size(44, 44);
            this.assetTransactionTblBindingNavigatorViewAssetCardItem.Text = "عرض بطاقة الأصل";
            this.assetTransactionTblBindingNavigatorViewAssetCardItem.Click += new System.EventHandler(this.assetTransactionTblBindingNavigatorViewAssetCardItem_Click);
            // 
            // assetVwTableAdapter
            // 
            this.assetVwTableAdapter.ClearBeforeFill = true;
            // 
            // assetVwAllBindingSource
            // 
            this.assetVwAllBindingSource.DataMember = "AssetVw_All";
            this.assetVwAllBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetVw_AllTableAdapter
            // 
            this.assetVw_AllTableAdapter.ClearBeforeFill = true;
            // 
            // ManageAssetTransactionTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.assetTransactionGridControl);
            this.Controls.Add(this.assetTransactionTblBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageAssetTransactionTblForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة سجلات تصريف الأصول";
            this.Load += new System.EventHandler(this.ManageAssetTransactionTblForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.astRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trtyRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionTblBindingNavigator)).EndInit();
            this.assetTransactionTblBindingNavigator.ResumeLayout(false);
            this.assetTransactionTblBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwAllBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AssetMngDbDataSet assetMngDbDataSet;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator assetTransactionTblBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton assetTransactionTblBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl assetTransactionGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView assetTransactionGridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit astRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource assetVwBindingSource;
        private AssetMngDbDataSetTableAdapters.AssetVwTableAdapter assetVwTableAdapter;
        private System.Windows.Forms.BindingSource assetTransactionTblBindingSource;
        private AssetMngDbDataSetTableAdapters.AssetTransactionTblTableAdapter assetTransactionTblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetID;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionType;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionMadeOn;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionMadeBy;
        private DevExpress.XtraGrid.Columns.GridColumn colMoneyAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colMoneyAmountCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colGetAssetOutOfWork;
        private DevExpress.XtraGrid.Columns.GridColumn colWithDestroying;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentPriceWithDestroying;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetTransactionUniqueKey;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit currRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource currencyTblBindingSource;
        private AssetMngDbDataSetTableAdapters.CurrencyTblTableAdapter currencyTblTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit trtyRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource transactionTypeTblBindingSource;
        private AssetMngDbDataSetTableAdapters.TransactionTypeTblTableAdapter transactionTypeTblTableAdapter;
        private System.Windows.Forms.ToolStripButton assetTransactionTblBindingNavigatorExportToExcelItem;
        private System.Windows.Forms.ToolStripButton assetTransactionTblBindingNavigatorViewAssetCardItem;
        private System.Windows.Forms.BindingSource assetVwAllBindingSource;
        private AssetMngDbDataSetTableAdapters.AssetVw_AllTableAdapter assetVw_AllTableAdapter;
    }
}