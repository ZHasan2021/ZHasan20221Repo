
namespace AssetManagement.AuxTables
{
    partial class ManageAssetMovementTblForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAssetMovementTblForm));
            this.assetMovementGridControl = new DevExpress.XtraGrid.GridControl();
            this.assetMovementTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.assetMovementGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.astRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.assetVwAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colFieldChanged = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOldValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMovementDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetMovedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetMovedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetMovementUniqueKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.assetVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.assetMovementTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetMovementTblTableAdapter();
            this.assetMovementTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.assetMovementTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.assetMovementTblBindingNavigatorExportToExcelItem = new System.Windows.Forms.ToolStripButton();
            this.assetMovementTblBindingNavigatorViewAssetCardItem = new System.Windows.Forms.ToolStripButton();
            this.assetVwTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetVwTableAdapter();
            this.assetVw_AllTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetVw_AllTableAdapter();
            this.assetVwGridControl = new DevExpress.XtraGrid.GridControl();
            this.assetLayoutView = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colمعرفالأصل = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colمعرفالأصل = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colكودالأصل = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colكودالأصل = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colالعدد = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colالعدد = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colالقسم = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colالقسم = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colالدائرة = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colالدائرة = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colالساحة = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colالساحة = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colالفئةالرئيسية = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colالفئةالرئيسية = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colالفئةالفرعية = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colالفئةالفرعية = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colمواصفاتالأصل = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colمواصفاتالأصل = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colالموديل = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colالموديل = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colاللون = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colاللون = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colتاريخالشراء = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colتاريخالشراء = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colسعرالشراء = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colسعرالشراء = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colعملةسعرالشراء = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colعملةسعرالشراء = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colمكانالتواجد = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colمكانالتواجد = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colحالةالأصلالآنية = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colحالةالأصلالآنية = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colنسبةالاستفادةمنه = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colنسبةالاستفادةمنه = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colالسعرالفعليالحالي = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colالسعرالفعليالحالي = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colعملةالسعرالفعليالحالي = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colعملةالسعرالفعليالحالي = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colاسمصاحبالعهدة = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colاسمصاحبالعهدة = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colتفاصيلإضافية = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colتفاصيلإضافية = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colملاحظاتأخرى = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colملاحظاتأخرى = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colعنوانالعقار = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colعنوانالعقار = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colاسمالمالك = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colاسمالمالك = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colالمستغلمنه = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colالمستغلمنه = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colمعمنورقةالملكية = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colمعمنورقةالملكية = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colمساحةالعقار = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colمساحةالعقار = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colوحدةمساحةالعقار = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colوحدةمساحةالعقار = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colرقملوحةالمركبة = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colرقملوحةالمركبة = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colسنةصنعالمركبة = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colسنةصنعالمركبة = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colرقمالمحركللمركبة = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colرقمالمحركللمركبة = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colمعدلالإهلاكللأصل = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colمعدلالإهلاكللأصل = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colالعمرالافتراضيالمتبقيللأصل = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colالعمرالافتراضيالمتبقيللأصل = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.assetTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.astRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementTblBindingNavigator)).BeginInit();
            this.assetMovementTblBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetLayoutView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colمعرفالأصل)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colكودالأصل)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colالعدد)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colالقسم)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colالدائرة)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colالساحة)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colالفئةالرئيسية)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colالفئةالفرعية)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colمواصفاتالأصل)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colالموديل)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colاللون)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colتاريخالشراء)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colسعرالشراء)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colعملةسعرالشراء)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colمكانالتواجد)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colحالةالأصلالآنية)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colنسبةالاستفادةمنه)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colالسعرالفعليالحالي)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colعملةالسعرالفعليالحالي)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colاسمصاحبالعهدة)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colتفاصيلإضافية)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colملاحظاتأخرى)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colعنوانالعقار)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colاسمالمالك)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colالمستغلمنه)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colمعمنورقةالملكية)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colمساحةالعقار)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colوحدةمساحةالعقار)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colرقملوحةالمركبة)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colسنةصنعالمركبة)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colرقمالمحركللمركبة)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colمعدلالإهلاكللأصل)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colالعمرالافتراضيالمتبقيللأصل)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // assetMovementGridControl
            // 
            this.assetMovementGridControl.DataSource = this.assetMovementTblBindingSource;
            this.assetMovementGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            gridLevelNode1.RelationName = "assetMovementLevel";
            this.assetMovementGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.assetMovementGridControl.Location = new System.Drawing.Point(0, 47);
            this.assetMovementGridControl.MainView = this.assetMovementGridView;
            this.assetMovementGridControl.Name = "assetMovementGridControl";
            this.assetMovementGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.astRepositoryItemLookUpEdit});
            this.assetMovementGridControl.Size = new System.Drawing.Size(1282, 322);
            this.assetMovementGridControl.TabIndex = 5;
            this.assetMovementGridControl.UseEmbeddedNavigator = true;
            this.assetMovementGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.assetMovementGridView});
            // 
            // assetMovementTblBindingSource
            // 
            this.assetMovementTblBindingSource.DataMember = "AssetMovementTbl";
            this.assetMovementTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetMovementGridView
            // 
            this.assetMovementGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colAssetID,
            this.colFieldChanged,
            this.colOldValue,
            this.colNewValue,
            this.colMovementDate,
            this.colAssetMovedOn,
            this.colAssetMovedBy,
            this.colAssetMovementUniqueKey});
            this.assetMovementGridView.GridControl = this.assetMovementGridControl;
            this.assetMovementGridView.Name = "assetMovementGridView";
            this.assetMovementGridView.OptionsBehavior.Editable = false;
            this.assetMovementGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.assetMovementGridView_RowClick);
            this.assetMovementGridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.assetMovementGridView_RowCellClick);
            // 
            // colID
            // 
            this.colID.Caption = "معرف السجل";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Width = 94;
            // 
            // colAssetID
            // 
            this.colAssetID.Caption = "معلومات الأصل";
            this.colAssetID.ColumnEdit = this.astRepositoryItemLookUpEdit;
            this.colAssetID.FieldName = "AssetID";
            this.colAssetID.MinWidth = 25;
            this.colAssetID.Name = "colAssetID";
            this.colAssetID.Visible = true;
            this.colAssetID.VisibleIndex = 0;
            this.colAssetID.Width = 120;
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
            this.astRepositoryItemLookUpEdit.DataSource = this.assetTblBindingSource;
            this.astRepositoryItemLookUpEdit.DisplayMember = "AssetCode";
            this.astRepositoryItemLookUpEdit.Name = "astRepositoryItemLookUpEdit";
            this.astRepositoryItemLookUpEdit.PopupWidth = 800;
            this.astRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // assetVwAllBindingSource
            // 
            this.assetVwAllBindingSource.DataMember = "AssetVw_All";
            this.assetVwAllBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // colFieldChanged
            // 
            this.colFieldChanged.Caption = "الحقل المحدث بعملية النقل";
            this.colFieldChanged.FieldName = "FieldChanged";
            this.colFieldChanged.MinWidth = 25;
            this.colFieldChanged.Name = "colFieldChanged";
            this.colFieldChanged.Visible = true;
            this.colFieldChanged.VisibleIndex = 1;
            this.colFieldChanged.Width = 150;
            // 
            // colOldValue
            // 
            this.colOldValue.Caption = "من";
            this.colOldValue.FieldName = "OldValue";
            this.colOldValue.MinWidth = 25;
            this.colOldValue.Name = "colOldValue";
            this.colOldValue.Visible = true;
            this.colOldValue.VisibleIndex = 2;
            this.colOldValue.Width = 150;
            // 
            // colNewValue
            // 
            this.colNewValue.Caption = "إلى";
            this.colNewValue.FieldName = "NewValue";
            this.colNewValue.MinWidth = 25;
            this.colNewValue.Name = "colNewValue";
            this.colNewValue.Visible = true;
            this.colNewValue.VisibleIndex = 3;
            this.colNewValue.Width = 150;
            // 
            // colMovementDate
            // 
            this.colMovementDate.Caption = "تاريخ النقل";
            this.colMovementDate.FieldName = "MovementDate";
            this.colMovementDate.MinWidth = 25;
            this.colMovementDate.Name = "colMovementDate";
            this.colMovementDate.Visible = true;
            this.colMovementDate.VisibleIndex = 4;
            this.colMovementDate.Width = 100;
            // 
            // colAssetMovedOn
            // 
            this.colAssetMovedOn.Caption = "تاريخ إضافة السجل";
            this.colAssetMovedOn.FieldName = "AssetMovedOn";
            this.colAssetMovedOn.MinWidth = 25;
            this.colAssetMovedOn.Name = "colAssetMovedOn";
            this.colAssetMovedOn.Width = 100;
            // 
            // colAssetMovedBy
            // 
            this.colAssetMovedBy.Caption = "المستخدم الذي قام بالإضافة";
            this.colAssetMovedBy.FieldName = "AssetMovedBy";
            this.colAssetMovedBy.MinWidth = 25;
            this.colAssetMovedBy.Name = "colAssetMovedBy";
            this.colAssetMovedBy.Width = 100;
            // 
            // colAssetMovementUniqueKey
            // 
            this.colAssetMovementUniqueKey.Caption = "رقم فريد لسجل النقل";
            this.colAssetMovementUniqueKey.FieldName = "AssetMovementUniqueKey";
            this.colAssetMovementUniqueKey.MinWidth = 25;
            this.colAssetMovementUniqueKey.Name = "colAssetMovementUniqueKey";
            this.colAssetMovementUniqueKey.Width = 100;
            // 
            // assetVwBindingSource
            // 
            this.assetVwBindingSource.DataMember = "AssetVw";
            this.assetVwBindingSource.DataSource = this.assetMngDbDataSet;
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
            this.tableAdapterManager.AssetMovementTblTableAdapter = this.assetMovementTblTableAdapter;
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
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.OutgoingTypeTblTableAdapter = null;
            this.tableAdapterManager.SectionTblTableAdapter = null;
            this.tableAdapterManager.SquareTblTableAdapter = null;
            this.tableAdapterManager.StatusTblTableAdapter = null;
            this.tableAdapterManager.SubDepartmentTblTableAdapter = null;
            this.tableAdapterManager.TransactionTypeTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // assetMovementTblTableAdapter
            // 
            this.assetMovementTblTableAdapter.ClearBeforeFill = true;
            // 
            // assetMovementTblBindingNavigator
            // 
            this.assetMovementTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.assetMovementTblBindingNavigator.BindingSource = this.assetMovementTblBindingSource;
            this.assetMovementTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.assetMovementTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.assetMovementTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.assetMovementTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.assetMovementTblBindingNavigatorSaveItem,
            this.assetMovementTblBindingNavigatorExportToExcelItem,
            this.assetMovementTblBindingNavigatorViewAssetCardItem});
            this.assetMovementTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.assetMovementTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.assetMovementTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.assetMovementTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.assetMovementTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.assetMovementTblBindingNavigator.Name = "assetMovementTblBindingNavigator";
            this.assetMovementTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.assetMovementTblBindingNavigator.Size = new System.Drawing.Size(1282, 47);
            this.assetMovementTblBindingNavigator.Stretch = true;
            this.assetMovementTblBindingNavigator.TabIndex = 4;
            this.assetMovementTblBindingNavigator.Text = "bindingNavigator1";
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
            // assetMovementTblBindingNavigatorSaveItem
            // 
            this.assetMovementTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.assetMovementTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("assetMovementTblBindingNavigatorSaveItem.Image")));
            this.assetMovementTblBindingNavigatorSaveItem.Name = "assetMovementTblBindingNavigatorSaveItem";
            this.assetMovementTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(44, 44);
            this.assetMovementTblBindingNavigatorSaveItem.Text = "حفظ التعديلات";
            this.assetMovementTblBindingNavigatorSaveItem.Visible = false;
            this.assetMovementTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.assetMovementTblBindingNavigatorSaveItem_Click);
            // 
            // assetMovementTblBindingNavigatorExportToExcelItem
            // 
            this.assetMovementTblBindingNavigatorExportToExcelItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.assetMovementTblBindingNavigatorExportToExcelItem.Image = global::AssetManagement.Properties.Resources._36435172;
            this.assetMovementTblBindingNavigatorExportToExcelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.assetMovementTblBindingNavigatorExportToExcelItem.Name = "assetMovementTblBindingNavigatorExportToExcelItem";
            this.assetMovementTblBindingNavigatorExportToExcelItem.Size = new System.Drawing.Size(44, 44);
            this.assetMovementTblBindingNavigatorExportToExcelItem.Text = "تصدير إلى اكسل";
            this.assetMovementTblBindingNavigatorExportToExcelItem.Click += new System.EventHandler(this.assetMovementTblBindingNavigatorExportToExcelItem_Click);
            // 
            // assetMovementTblBindingNavigatorViewAssetCardItem
            // 
            this.assetMovementTblBindingNavigatorViewAssetCardItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.assetMovementTblBindingNavigatorViewAssetCardItem.Image = global::AssetManagement.Properties.Resources._8341961;
            this.assetMovementTblBindingNavigatorViewAssetCardItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.assetMovementTblBindingNavigatorViewAssetCardItem.Name = "assetMovementTblBindingNavigatorViewAssetCardItem";
            this.assetMovementTblBindingNavigatorViewAssetCardItem.Size = new System.Drawing.Size(44, 44);
            this.assetMovementTblBindingNavigatorViewAssetCardItem.Text = "عرض بطاقة الأصل";
            this.assetMovementTblBindingNavigatorViewAssetCardItem.Click += new System.EventHandler(this.assetMovementTblBindingNavigatorViewAssetCardItem_Click);
            // 
            // assetVwTableAdapter
            // 
            this.assetVwTableAdapter.ClearBeforeFill = true;
            // 
            // assetVw_AllTableAdapter
            // 
            this.assetVw_AllTableAdapter.ClearBeforeFill = true;
            // 
            // assetVwGridControl
            // 
            this.assetVwGridControl.DataSource = this.assetVwAllBindingSource;
            this.assetVwGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetVwGridControl.Location = new System.Drawing.Point(0, 369);
            this.assetVwGridControl.MainView = this.assetLayoutView;
            this.assetVwGridControl.Name = "assetVwGridControl";
            this.assetVwGridControl.Size = new System.Drawing.Size(1282, 384);
            this.assetVwGridControl.TabIndex = 16;
            this.assetVwGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.assetLayoutView});
            this.assetVwGridControl.Visible = false;
            // 
            // assetLayoutView
            // 
            this.assetLayoutView.Appearance.Card.Font = new System.Drawing.Font("Sakkal Majalla", 10.2F);
            this.assetLayoutView.Appearance.Card.Options.UseFont = true;
            this.assetLayoutView.Appearance.CardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.assetLayoutView.Appearance.CardCaption.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.assetLayoutView.Appearance.CardCaption.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F);
            this.assetLayoutView.Appearance.CardCaption.Options.UseBackColor = true;
            this.assetLayoutView.Appearance.CardCaption.Options.UseFont = true;
            this.assetLayoutView.Appearance.FieldCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.assetLayoutView.Appearance.FieldCaption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.assetLayoutView.Appearance.FieldCaption.Options.UseBackColor = true;
            this.assetLayoutView.Appearance.FieldCaption.Options.UseFont = true;
            this.assetLayoutView.Appearance.FieldValue.BackColor = System.Drawing.Color.Silver;
            this.assetLayoutView.Appearance.FieldValue.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.assetLayoutView.Appearance.FieldValue.Options.UseBackColor = true;
            this.assetLayoutView.Appearance.FieldValue.Options.UseFont = true;
            this.assetLayoutView.CardMinSize = new System.Drawing.Size(500, 300);
            this.assetLayoutView.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colمعرفالأصل,
            this.colكودالأصل,
            this.colالعدد,
            this.colالقسم,
            this.colالدائرة,
            this.colالساحة,
            this.colالفئةالرئيسية,
            this.colالفئةالفرعية,
            this.colمواصفاتالأصل,
            this.colالموديل,
            this.colاللون,
            this.layoutViewColumn1,
            this.colتاريخالشراء,
            this.colسعرالشراء,
            this.colعملةسعرالشراء,
            this.colمكانالتواجد,
            this.colحالةالأصلالآنية,
            this.colنسبةالاستفادةمنه,
            this.colالسعرالفعليالحالي,
            this.colعملةالسعرالفعليالحالي,
            this.colاسمصاحبالعهدة,
            this.colتفاصيلإضافية,
            this.colملاحظاتأخرى,
            this.colعنوانالعقار,
            this.colاسمالمالك,
            this.colالمستغلمنه,
            this.colمعمنورقةالملكية,
            this.colمساحةالعقار,
            this.colوحدةمساحةالعقار,
            this.colرقملوحةالمركبة,
            this.colسنةصنعالمركبة,
            this.layoutViewColumn2,
            this.colرقمالمحركللمركبة,
            this.colمعدلالإهلاكللأصل,
            this.colالعمرالافتراضيالمتبقيللأصل});
            this.assetLayoutView.DetailHeight = 300;
            this.assetLayoutView.GridControl = this.assetVwGridControl;
            this.assetLayoutView.Name = "assetLayoutView";
            this.assetLayoutView.TemplateCard = this.layoutViewCard1;
            // 
            // colمعرفالأصل
            // 
            this.colمعرفالأصل.FieldName = "معرف الأصل";
            this.colمعرفالأصل.LayoutViewField = this.layoutViewField_colمعرفالأصل;
            this.colمعرفالأصل.MinWidth = 25;
            this.colمعرفالأصل.Name = "colمعرفالأصل";
            this.colمعرفالأصل.Width = 94;
            // 
            // layoutViewField_colمعرفالأصل
            // 
            this.layoutViewField_colمعرفالأصل.EditorPreferredWidth = -6;
            this.layoutViewField_colمعرفالأصل.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colمعرفالأصل.Name = "layoutViewField_colمعرفالأصل";
            this.layoutViewField_colمعرفالأصل.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colمعرفالأصل.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colكودالأصل
            // 
            this.colكودالأصل.FieldName = "كود الأصل";
            this.colكودالأصل.LayoutViewField = this.layoutViewField_colكودالأصل;
            this.colكودالأصل.MinWidth = 25;
            this.colكودالأصل.Name = "colكودالأصل";
            this.colكودالأصل.Width = 94;
            // 
            // layoutViewField_colكودالأصل
            // 
            this.layoutViewField_colكودالأصل.EditorPreferredWidth = -6;
            this.layoutViewField_colكودالأصل.Location = new System.Drawing.Point(0, 26);
            this.layoutViewField_colكودالأصل.Name = "layoutViewField_colكودالأصل";
            this.layoutViewField_colكودالأصل.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colكودالأصل.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colالعدد
            // 
            this.colالعدد.FieldName = "العدد";
            this.colالعدد.LayoutViewField = this.layoutViewField_colالعدد;
            this.colالعدد.MinWidth = 25;
            this.colالعدد.Name = "colالعدد";
            this.colالعدد.Width = 94;
            // 
            // layoutViewField_colالعدد
            // 
            this.layoutViewField_colالعدد.EditorPreferredWidth = -6;
            this.layoutViewField_colالعدد.Location = new System.Drawing.Point(0, 52);
            this.layoutViewField_colالعدد.Name = "layoutViewField_colالعدد";
            this.layoutViewField_colالعدد.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colالعدد.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colالقسم
            // 
            this.colالقسم.FieldName = "القسم";
            this.colالقسم.LayoutViewField = this.layoutViewField_colالقسم;
            this.colالقسم.MinWidth = 25;
            this.colالقسم.Name = "colالقسم";
            this.colالقسم.Width = 94;
            // 
            // layoutViewField_colالقسم
            // 
            this.layoutViewField_colالقسم.EditorPreferredWidth = -6;
            this.layoutViewField_colالقسم.Location = new System.Drawing.Point(0, 78);
            this.layoutViewField_colالقسم.Name = "layoutViewField_colالقسم";
            this.layoutViewField_colالقسم.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colالقسم.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colالدائرة
            // 
            this.colالدائرة.FieldName = "الدائرة";
            this.colالدائرة.LayoutViewField = this.layoutViewField_colالدائرة;
            this.colالدائرة.MinWidth = 25;
            this.colالدائرة.Name = "colالدائرة";
            this.colالدائرة.Width = 94;
            // 
            // layoutViewField_colالدائرة
            // 
            this.layoutViewField_colالدائرة.EditorPreferredWidth = -6;
            this.layoutViewField_colالدائرة.Location = new System.Drawing.Point(0, 104);
            this.layoutViewField_colالدائرة.Name = "layoutViewField_colالدائرة";
            this.layoutViewField_colالدائرة.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colالدائرة.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colالساحة
            // 
            this.colالساحة.FieldName = "الساحة";
            this.colالساحة.LayoutViewField = this.layoutViewField_colالساحة;
            this.colالساحة.MinWidth = 25;
            this.colالساحة.Name = "colالساحة";
            this.colالساحة.Width = 94;
            // 
            // layoutViewField_colالساحة
            // 
            this.layoutViewField_colالساحة.EditorPreferredWidth = -6;
            this.layoutViewField_colالساحة.Location = new System.Drawing.Point(0, 130);
            this.layoutViewField_colالساحة.Name = "layoutViewField_colالساحة";
            this.layoutViewField_colالساحة.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colالساحة.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colالفئةالرئيسية
            // 
            this.colالفئةالرئيسية.FieldName = "الفئة الرئيسية";
            this.colالفئةالرئيسية.LayoutViewField = this.layoutViewField_colالفئةالرئيسية;
            this.colالفئةالرئيسية.MinWidth = 25;
            this.colالفئةالرئيسية.Name = "colالفئةالرئيسية";
            this.colالفئةالرئيسية.Width = 94;
            // 
            // layoutViewField_colالفئةالرئيسية
            // 
            this.layoutViewField_colالفئةالرئيسية.EditorPreferredWidth = -6;
            this.layoutViewField_colالفئةالرئيسية.Location = new System.Drawing.Point(0, 156);
            this.layoutViewField_colالفئةالرئيسية.Name = "layoutViewField_colالفئةالرئيسية";
            this.layoutViewField_colالفئةالرئيسية.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colالفئةالرئيسية.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colالفئةالفرعية
            // 
            this.colالفئةالفرعية.FieldName = "الفئة الفرعية";
            this.colالفئةالفرعية.LayoutViewField = this.layoutViewField_colالفئةالفرعية;
            this.colالفئةالفرعية.MinWidth = 25;
            this.colالفئةالفرعية.Name = "colالفئةالفرعية";
            this.colالفئةالفرعية.Width = 94;
            // 
            // layoutViewField_colالفئةالفرعية
            // 
            this.layoutViewField_colالفئةالفرعية.EditorPreferredWidth = -6;
            this.layoutViewField_colالفئةالفرعية.Location = new System.Drawing.Point(0, 182);
            this.layoutViewField_colالفئةالفرعية.Name = "layoutViewField_colالفئةالفرعية";
            this.layoutViewField_colالفئةالفرعية.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colالفئةالفرعية.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colمواصفاتالأصل
            // 
            this.colمواصفاتالأصل.FieldName = "مواصفات الأصل";
            this.colمواصفاتالأصل.LayoutViewField = this.layoutViewField_colمواصفاتالأصل;
            this.colمواصفاتالأصل.MinWidth = 25;
            this.colمواصفاتالأصل.Name = "colمواصفاتالأصل";
            this.colمواصفاتالأصل.Width = 94;
            // 
            // layoutViewField_colمواصفاتالأصل
            // 
            this.layoutViewField_colمواصفاتالأصل.EditorPreferredWidth = -6;
            this.layoutViewField_colمواصفاتالأصل.Location = new System.Drawing.Point(0, 208);
            this.layoutViewField_colمواصفاتالأصل.Name = "layoutViewField_colمواصفاتالأصل";
            this.layoutViewField_colمواصفاتالأصل.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colمواصفاتالأصل.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colالموديل
            // 
            this.colالموديل.FieldName = "الموديل";
            this.colالموديل.LayoutViewField = this.layoutViewField_colالموديل;
            this.colالموديل.MinWidth = 25;
            this.colالموديل.Name = "colالموديل";
            this.colالموديل.Width = 94;
            // 
            // layoutViewField_colالموديل
            // 
            this.layoutViewField_colالموديل.EditorPreferredWidth = -6;
            this.layoutViewField_colالموديل.Location = new System.Drawing.Point(0, 234);
            this.layoutViewField_colالموديل.Name = "layoutViewField_colالموديل";
            this.layoutViewField_colالموديل.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colالموديل.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colاللون
            // 
            this.colاللون.FieldName = "اللون";
            this.colاللون.LayoutViewField = this.layoutViewField_colاللون;
            this.colاللون.MinWidth = 25;
            this.colاللون.Name = "colاللون";
            this.colاللون.Width = 94;
            // 
            // layoutViewField_colاللون
            // 
            this.layoutViewField_colاللون.EditorPreferredWidth = -6;
            this.layoutViewField_colاللون.Location = new System.Drawing.Point(0, 260);
            this.layoutViewField_colاللون.Name = "layoutViewField_colاللون";
            this.layoutViewField_colاللون.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colاللون.TextSize = new System.Drawing.Size(185, 17);
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.FieldName = "الحجم / السعة";
            this.layoutViewColumn1.LayoutViewField = this.layoutViewField_layoutViewColumn1;
            this.layoutViewColumn1.MinWidth = 25;
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            this.layoutViewColumn1.Width = 94;
            // 
            // layoutViewField_layoutViewColumn1
            // 
            this.layoutViewField_layoutViewColumn1.EditorPreferredWidth = -6;
            this.layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(0, 286);
            this.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            this.layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colتاريخالشراء
            // 
            this.colتاريخالشراء.FieldName = "تاريخ الشراء";
            this.colتاريخالشراء.LayoutViewField = this.layoutViewField_colتاريخالشراء;
            this.colتاريخالشراء.MinWidth = 25;
            this.colتاريخالشراء.Name = "colتاريخالشراء";
            this.colتاريخالشراء.Width = 94;
            // 
            // layoutViewField_colتاريخالشراء
            // 
            this.layoutViewField_colتاريخالشراء.EditorPreferredWidth = -6;
            this.layoutViewField_colتاريخالشراء.Location = new System.Drawing.Point(0, 312);
            this.layoutViewField_colتاريخالشراء.Name = "layoutViewField_colتاريخالشراء";
            this.layoutViewField_colتاريخالشراء.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colتاريخالشراء.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colسعرالشراء
            // 
            this.colسعرالشراء.FieldName = "سعر الشراء";
            this.colسعرالشراء.LayoutViewField = this.layoutViewField_colسعرالشراء;
            this.colسعرالشراء.MinWidth = 25;
            this.colسعرالشراء.Name = "colسعرالشراء";
            this.colسعرالشراء.Width = 94;
            // 
            // layoutViewField_colسعرالشراء
            // 
            this.layoutViewField_colسعرالشراء.EditorPreferredWidth = -6;
            this.layoutViewField_colسعرالشراء.Location = new System.Drawing.Point(0, 338);
            this.layoutViewField_colسعرالشراء.Name = "layoutViewField_colسعرالشراء";
            this.layoutViewField_colسعرالشراء.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colسعرالشراء.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colعملةسعرالشراء
            // 
            this.colعملةسعرالشراء.FieldName = "عملة سعر الشراء";
            this.colعملةسعرالشراء.LayoutViewField = this.layoutViewField_colعملةسعرالشراء;
            this.colعملةسعرالشراء.MinWidth = 25;
            this.colعملةسعرالشراء.Name = "colعملةسعرالشراء";
            this.colعملةسعرالشراء.Width = 94;
            // 
            // layoutViewField_colعملةسعرالشراء
            // 
            this.layoutViewField_colعملةسعرالشراء.EditorPreferredWidth = -6;
            this.layoutViewField_colعملةسعرالشراء.Location = new System.Drawing.Point(0, 364);
            this.layoutViewField_colعملةسعرالشراء.Name = "layoutViewField_colعملةسعرالشراء";
            this.layoutViewField_colعملةسعرالشراء.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colعملةسعرالشراء.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colمكانالتواجد
            // 
            this.colمكانالتواجد.FieldName = "مكان التواجد";
            this.colمكانالتواجد.LayoutViewField = this.layoutViewField_colمكانالتواجد;
            this.colمكانالتواجد.MinWidth = 25;
            this.colمكانالتواجد.Name = "colمكانالتواجد";
            this.colمكانالتواجد.Width = 94;
            // 
            // layoutViewField_colمكانالتواجد
            // 
            this.layoutViewField_colمكانالتواجد.EditorPreferredWidth = -6;
            this.layoutViewField_colمكانالتواجد.Location = new System.Drawing.Point(0, 390);
            this.layoutViewField_colمكانالتواجد.Name = "layoutViewField_colمكانالتواجد";
            this.layoutViewField_colمكانالتواجد.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colمكانالتواجد.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colحالةالأصلالآنية
            // 
            this.colحالةالأصلالآنية.FieldName = "حالة الأصل الآنية";
            this.colحالةالأصلالآنية.LayoutViewField = this.layoutViewField_colحالةالأصلالآنية;
            this.colحالةالأصلالآنية.MinWidth = 25;
            this.colحالةالأصلالآنية.Name = "colحالةالأصلالآنية";
            this.colحالةالأصلالآنية.Width = 94;
            // 
            // layoutViewField_colحالةالأصلالآنية
            // 
            this.layoutViewField_colحالةالأصلالآنية.EditorPreferredWidth = -6;
            this.layoutViewField_colحالةالأصلالآنية.Location = new System.Drawing.Point(0, 416);
            this.layoutViewField_colحالةالأصلالآنية.Name = "layoutViewField_colحالةالأصلالآنية";
            this.layoutViewField_colحالةالأصلالآنية.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colحالةالأصلالآنية.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colنسبةالاستفادةمنه
            // 
            this.colنسبةالاستفادةمنه.FieldName = "نسبة الاستفادة منه";
            this.colنسبةالاستفادةمنه.LayoutViewField = this.layoutViewField_colنسبةالاستفادةمنه;
            this.colنسبةالاستفادةمنه.MinWidth = 25;
            this.colنسبةالاستفادةمنه.Name = "colنسبةالاستفادةمنه";
            this.colنسبةالاستفادةمنه.Width = 94;
            // 
            // layoutViewField_colنسبةالاستفادةمنه
            // 
            this.layoutViewField_colنسبةالاستفادةمنه.EditorPreferredWidth = -6;
            this.layoutViewField_colنسبةالاستفادةمنه.Location = new System.Drawing.Point(0, 442);
            this.layoutViewField_colنسبةالاستفادةمنه.Name = "layoutViewField_colنسبةالاستفادةمنه";
            this.layoutViewField_colنسبةالاستفادةمنه.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colنسبةالاستفادةمنه.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colالسعرالفعليالحالي
            // 
            this.colالسعرالفعليالحالي.FieldName = "السعر الفعلي الحالي";
            this.colالسعرالفعليالحالي.LayoutViewField = this.layoutViewField_colالسعرالفعليالحالي;
            this.colالسعرالفعليالحالي.MinWidth = 25;
            this.colالسعرالفعليالحالي.Name = "colالسعرالفعليالحالي";
            this.colالسعرالفعليالحالي.Width = 94;
            // 
            // layoutViewField_colالسعرالفعليالحالي
            // 
            this.layoutViewField_colالسعرالفعليالحالي.EditorPreferredWidth = -6;
            this.layoutViewField_colالسعرالفعليالحالي.Location = new System.Drawing.Point(0, 468);
            this.layoutViewField_colالسعرالفعليالحالي.Name = "layoutViewField_colالسعرالفعليالحالي";
            this.layoutViewField_colالسعرالفعليالحالي.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colالسعرالفعليالحالي.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colعملةالسعرالفعليالحالي
            // 
            this.colعملةالسعرالفعليالحالي.FieldName = "عملة السعر الفعلي الحالي";
            this.colعملةالسعرالفعليالحالي.LayoutViewField = this.layoutViewField_colعملةالسعرالفعليالحالي;
            this.colعملةالسعرالفعليالحالي.MinWidth = 25;
            this.colعملةالسعرالفعليالحالي.Name = "colعملةالسعرالفعليالحالي";
            this.colعملةالسعرالفعليالحالي.Width = 94;
            // 
            // layoutViewField_colعملةالسعرالفعليالحالي
            // 
            this.layoutViewField_colعملةالسعرالفعليالحالي.EditorPreferredWidth = -6;
            this.layoutViewField_colعملةالسعرالفعليالحالي.Location = new System.Drawing.Point(0, 494);
            this.layoutViewField_colعملةالسعرالفعليالحالي.Name = "layoutViewField_colعملةالسعرالفعليالحالي";
            this.layoutViewField_colعملةالسعرالفعليالحالي.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colعملةالسعرالفعليالحالي.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colاسمصاحبالعهدة
            // 
            this.colاسمصاحبالعهدة.FieldName = "اسم صاحب العهدة";
            this.colاسمصاحبالعهدة.LayoutViewField = this.layoutViewField_colاسمصاحبالعهدة;
            this.colاسمصاحبالعهدة.MinWidth = 25;
            this.colاسمصاحبالعهدة.Name = "colاسمصاحبالعهدة";
            this.colاسمصاحبالعهدة.Width = 94;
            // 
            // layoutViewField_colاسمصاحبالعهدة
            // 
            this.layoutViewField_colاسمصاحبالعهدة.EditorPreferredWidth = -6;
            this.layoutViewField_colاسمصاحبالعهدة.Location = new System.Drawing.Point(0, 520);
            this.layoutViewField_colاسمصاحبالعهدة.Name = "layoutViewField_colاسمصاحبالعهدة";
            this.layoutViewField_colاسمصاحبالعهدة.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colاسمصاحبالعهدة.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colتفاصيلإضافية
            // 
            this.colتفاصيلإضافية.FieldName = "تفاصيل إضافية";
            this.colتفاصيلإضافية.LayoutViewField = this.layoutViewField_colتفاصيلإضافية;
            this.colتفاصيلإضافية.MinWidth = 25;
            this.colتفاصيلإضافية.Name = "colتفاصيلإضافية";
            this.colتفاصيلإضافية.Width = 94;
            // 
            // layoutViewField_colتفاصيلإضافية
            // 
            this.layoutViewField_colتفاصيلإضافية.EditorPreferredWidth = -6;
            this.layoutViewField_colتفاصيلإضافية.Location = new System.Drawing.Point(0, 546);
            this.layoutViewField_colتفاصيلإضافية.Name = "layoutViewField_colتفاصيلإضافية";
            this.layoutViewField_colتفاصيلإضافية.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colتفاصيلإضافية.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colملاحظاتأخرى
            // 
            this.colملاحظاتأخرى.FieldName = "ملاحظات أخرى";
            this.colملاحظاتأخرى.LayoutViewField = this.layoutViewField_colملاحظاتأخرى;
            this.colملاحظاتأخرى.MinWidth = 25;
            this.colملاحظاتأخرى.Name = "colملاحظاتأخرى";
            this.colملاحظاتأخرى.Width = 94;
            // 
            // layoutViewField_colملاحظاتأخرى
            // 
            this.layoutViewField_colملاحظاتأخرى.EditorPreferredWidth = -6;
            this.layoutViewField_colملاحظاتأخرى.Location = new System.Drawing.Point(0, 572);
            this.layoutViewField_colملاحظاتأخرى.Name = "layoutViewField_colملاحظاتأخرى";
            this.layoutViewField_colملاحظاتأخرى.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colملاحظاتأخرى.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colعنوانالعقار
            // 
            this.colعنوانالعقار.FieldName = "عنوان العقار";
            this.colعنوانالعقار.LayoutViewField = this.layoutViewField_colعنوانالعقار;
            this.colعنوانالعقار.MinWidth = 25;
            this.colعنوانالعقار.Name = "colعنوانالعقار";
            this.colعنوانالعقار.Width = 94;
            // 
            // layoutViewField_colعنوانالعقار
            // 
            this.layoutViewField_colعنوانالعقار.EditorPreferredWidth = -6;
            this.layoutViewField_colعنوانالعقار.Location = new System.Drawing.Point(0, 598);
            this.layoutViewField_colعنوانالعقار.Name = "layoutViewField_colعنوانالعقار";
            this.layoutViewField_colعنوانالعقار.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colعنوانالعقار.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colاسمالمالك
            // 
            this.colاسمالمالك.FieldName = "اسم المالك";
            this.colاسمالمالك.LayoutViewField = this.layoutViewField_colاسمالمالك;
            this.colاسمالمالك.MinWidth = 25;
            this.colاسمالمالك.Name = "colاسمالمالك";
            this.colاسمالمالك.Width = 94;
            // 
            // layoutViewField_colاسمالمالك
            // 
            this.layoutViewField_colاسمالمالك.EditorPreferredWidth = -6;
            this.layoutViewField_colاسمالمالك.Location = new System.Drawing.Point(0, 624);
            this.layoutViewField_colاسمالمالك.Name = "layoutViewField_colاسمالمالك";
            this.layoutViewField_colاسمالمالك.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colاسمالمالك.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colالمستغلمنه
            // 
            this.colالمستغلمنه.FieldName = "المستغل منه";
            this.colالمستغلمنه.LayoutViewField = this.layoutViewField_colالمستغلمنه;
            this.colالمستغلمنه.MinWidth = 25;
            this.colالمستغلمنه.Name = "colالمستغلمنه";
            this.colالمستغلمنه.Width = 94;
            // 
            // layoutViewField_colالمستغلمنه
            // 
            this.layoutViewField_colالمستغلمنه.EditorPreferredWidth = -6;
            this.layoutViewField_colالمستغلمنه.Location = new System.Drawing.Point(0, 650);
            this.layoutViewField_colالمستغلمنه.Name = "layoutViewField_colالمستغلمنه";
            this.layoutViewField_colالمستغلمنه.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colالمستغلمنه.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colمعمنورقةالملكية
            // 
            this.colمعمنورقةالملكية.FieldName = "مع من ورقة الملكية";
            this.colمعمنورقةالملكية.LayoutViewField = this.layoutViewField_colمعمنورقةالملكية;
            this.colمعمنورقةالملكية.MinWidth = 25;
            this.colمعمنورقةالملكية.Name = "colمعمنورقةالملكية";
            this.colمعمنورقةالملكية.Width = 94;
            // 
            // layoutViewField_colمعمنورقةالملكية
            // 
            this.layoutViewField_colمعمنورقةالملكية.EditorPreferredWidth = -6;
            this.layoutViewField_colمعمنورقةالملكية.Location = new System.Drawing.Point(0, 676);
            this.layoutViewField_colمعمنورقةالملكية.Name = "layoutViewField_colمعمنورقةالملكية";
            this.layoutViewField_colمعمنورقةالملكية.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colمعمنورقةالملكية.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colمساحةالعقار
            // 
            this.colمساحةالعقار.FieldName = "مساحة العقار";
            this.colمساحةالعقار.LayoutViewField = this.layoutViewField_colمساحةالعقار;
            this.colمساحةالعقار.MinWidth = 25;
            this.colمساحةالعقار.Name = "colمساحةالعقار";
            this.colمساحةالعقار.Width = 94;
            // 
            // layoutViewField_colمساحةالعقار
            // 
            this.layoutViewField_colمساحةالعقار.EditorPreferredWidth = -6;
            this.layoutViewField_colمساحةالعقار.Location = new System.Drawing.Point(0, 702);
            this.layoutViewField_colمساحةالعقار.Name = "layoutViewField_colمساحةالعقار";
            this.layoutViewField_colمساحةالعقار.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colمساحةالعقار.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colوحدةمساحةالعقار
            // 
            this.colوحدةمساحةالعقار.FieldName = "وحدة مساحة العقار";
            this.colوحدةمساحةالعقار.LayoutViewField = this.layoutViewField_colوحدةمساحةالعقار;
            this.colوحدةمساحةالعقار.MinWidth = 25;
            this.colوحدةمساحةالعقار.Name = "colوحدةمساحةالعقار";
            this.colوحدةمساحةالعقار.Width = 94;
            // 
            // layoutViewField_colوحدةمساحةالعقار
            // 
            this.layoutViewField_colوحدةمساحةالعقار.EditorPreferredWidth = -6;
            this.layoutViewField_colوحدةمساحةالعقار.Location = new System.Drawing.Point(0, 728);
            this.layoutViewField_colوحدةمساحةالعقار.Name = "layoutViewField_colوحدةمساحةالعقار";
            this.layoutViewField_colوحدةمساحةالعقار.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colوحدةمساحةالعقار.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colرقملوحةالمركبة
            // 
            this.colرقملوحةالمركبة.FieldName = "رقم لوحة المركبة";
            this.colرقملوحةالمركبة.LayoutViewField = this.layoutViewField_colرقملوحةالمركبة;
            this.colرقملوحةالمركبة.MinWidth = 25;
            this.colرقملوحةالمركبة.Name = "colرقملوحةالمركبة";
            this.colرقملوحةالمركبة.Width = 94;
            // 
            // layoutViewField_colرقملوحةالمركبة
            // 
            this.layoutViewField_colرقملوحةالمركبة.EditorPreferredWidth = -6;
            this.layoutViewField_colرقملوحةالمركبة.Location = new System.Drawing.Point(0, 754);
            this.layoutViewField_colرقملوحةالمركبة.Name = "layoutViewField_colرقملوحةالمركبة";
            this.layoutViewField_colرقملوحةالمركبة.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colرقملوحةالمركبة.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colسنةصنعالمركبة
            // 
            this.colسنةصنعالمركبة.FieldName = "سنة صنع المركبة";
            this.colسنةصنعالمركبة.LayoutViewField = this.layoutViewField_colسنةصنعالمركبة;
            this.colسنةصنعالمركبة.MinWidth = 25;
            this.colسنةصنعالمركبة.Name = "colسنةصنعالمركبة";
            this.colسنةصنعالمركبة.Width = 94;
            // 
            // layoutViewField_colسنةصنعالمركبة
            // 
            this.layoutViewField_colسنةصنعالمركبة.EditorPreferredWidth = -6;
            this.layoutViewField_colسنةصنعالمركبة.Location = new System.Drawing.Point(0, 780);
            this.layoutViewField_colسنةصنعالمركبة.Name = "layoutViewField_colسنةصنعالمركبة";
            this.layoutViewField_colسنةصنعالمركبة.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colسنةصنعالمركبة.TextSize = new System.Drawing.Size(185, 17);
            // 
            // layoutViewColumn2
            // 
            this.layoutViewColumn2.FieldName = "رقم الهيكل (الشاصيه) للمركبة";
            this.layoutViewColumn2.LayoutViewField = this.layoutViewField_layoutViewColumn2;
            this.layoutViewColumn2.MinWidth = 25;
            this.layoutViewColumn2.Name = "layoutViewColumn2";
            this.layoutViewColumn2.Width = 94;
            // 
            // layoutViewField_layoutViewColumn2
            // 
            this.layoutViewField_layoutViewColumn2.EditorPreferredWidth = -6;
            this.layoutViewField_layoutViewColumn2.Location = new System.Drawing.Point(0, 806);
            this.layoutViewField_layoutViewColumn2.Name = "layoutViewField_layoutViewColumn2";
            this.layoutViewField_layoutViewColumn2.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_layoutViewColumn2.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colرقمالمحركللمركبة
            // 
            this.colرقمالمحركللمركبة.FieldName = "رقم المحرك للمركبة";
            this.colرقمالمحركللمركبة.LayoutViewField = this.layoutViewField_colرقمالمحركللمركبة;
            this.colرقمالمحركللمركبة.MinWidth = 25;
            this.colرقمالمحركللمركبة.Name = "colرقمالمحركللمركبة";
            this.colرقمالمحركللمركبة.Width = 94;
            // 
            // layoutViewField_colرقمالمحركللمركبة
            // 
            this.layoutViewField_colرقمالمحركللمركبة.EditorPreferredWidth = -6;
            this.layoutViewField_colرقمالمحركللمركبة.Location = new System.Drawing.Point(0, 832);
            this.layoutViewField_colرقمالمحركللمركبة.Name = "layoutViewField_colرقمالمحركللمركبة";
            this.layoutViewField_colرقمالمحركللمركبة.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colرقمالمحركللمركبة.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colمعدلالإهلاكللأصل
            // 
            this.colمعدلالإهلاكللأصل.FieldName = "معدل الإهلاك للأصل";
            this.colمعدلالإهلاكللأصل.LayoutViewField = this.layoutViewField_colمعدلالإهلاكللأصل;
            this.colمعدلالإهلاكللأصل.MinWidth = 25;
            this.colمعدلالإهلاكللأصل.Name = "colمعدلالإهلاكللأصل";
            this.colمعدلالإهلاكللأصل.Width = 94;
            // 
            // layoutViewField_colمعدلالإهلاكللأصل
            // 
            this.layoutViewField_colمعدلالإهلاكللأصل.EditorPreferredWidth = -6;
            this.layoutViewField_colمعدلالإهلاكللأصل.Location = new System.Drawing.Point(0, 858);
            this.layoutViewField_colمعدلالإهلاكللأصل.Name = "layoutViewField_colمعدلالإهلاكللأصل";
            this.layoutViewField_colمعدلالإهلاكللأصل.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colمعدلالإهلاكللأصل.TextSize = new System.Drawing.Size(185, 17);
            // 
            // colالعمرالافتراضيالمتبقيللأصل
            // 
            this.colالعمرالافتراضيالمتبقيللأصل.FieldName = "العمر الافتراضي المتبقي للأصل";
            this.colالعمرالافتراضيالمتبقيللأصل.LayoutViewField = this.layoutViewField_colالعمرالافتراضيالمتبقيللأصل;
            this.colالعمرالافتراضيالمتبقيللأصل.MinWidth = 25;
            this.colالعمرالافتراضيالمتبقيللأصل.Name = "colالعمرالافتراضيالمتبقيللأصل";
            this.colالعمرالافتراضيالمتبقيللأصل.Width = 94;
            // 
            // layoutViewField_colالعمرالافتراضيالمتبقيللأصل
            // 
            this.layoutViewField_colالعمرالافتراضيالمتبقيللأصل.EditorPreferredWidth = -6;
            this.layoutViewField_colالعمرالافتراضيالمتبقيللأصل.Location = new System.Drawing.Point(0, 884);
            this.layoutViewField_colالعمرالافتراضيالمتبقيللأصل.Name = "layoutViewField_colالعمرالافتراضيالمتبقيللأصل";
            this.layoutViewField_colالعمرالافتراضيالمتبقيللأصل.Size = new System.Drawing.Size(221, 26);
            this.layoutViewField_colالعمرالافتراضيالمتبقيللأصل.TextSize = new System.Drawing.Size(185, 17);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colمعرفالأصل,
            this.layoutViewField_colكودالأصل,
            this.layoutViewField_colالعدد,
            this.layoutViewField_colالقسم,
            this.layoutViewField_colالدائرة,
            this.layoutViewField_colالساحة,
            this.layoutViewField_colالفئةالرئيسية,
            this.layoutViewField_colالفئةالفرعية,
            this.layoutViewField_colمواصفاتالأصل,
            this.layoutViewField_colالموديل,
            this.layoutViewField_colاللون,
            this.layoutViewField_layoutViewColumn1,
            this.layoutViewField_colتاريخالشراء,
            this.layoutViewField_colسعرالشراء,
            this.layoutViewField_colعملةسعرالشراء,
            this.layoutViewField_colمكانالتواجد,
            this.layoutViewField_colحالةالأصلالآنية,
            this.layoutViewField_colنسبةالاستفادةمنه,
            this.layoutViewField_colالسعرالفعليالحالي,
            this.layoutViewField_colعملةالسعرالفعليالحالي,
            this.layoutViewField_colاسمصاحبالعهدة,
            this.layoutViewField_colتفاصيلإضافية,
            this.layoutViewField_colملاحظاتأخرى,
            this.layoutViewField_colعنوانالعقار,
            this.layoutViewField_colاسمالمالك,
            this.layoutViewField_colالمستغلمنه,
            this.layoutViewField_colمعمنورقةالملكية,
            this.layoutViewField_colمساحةالعقار,
            this.layoutViewField_colوحدةمساحةالعقار,
            this.layoutViewField_colرقملوحةالمركبة,
            this.layoutViewField_colسنةصنعالمركبة,
            this.layoutViewField_layoutViewColumn2,
            this.layoutViewField_colرقمالمحركللمركبة,
            this.layoutViewField_colمعدلالإهلاكللأصل,
            this.layoutViewField_colالعمرالافتراضيالمتبقيللأصل});
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // assetTblBindingSource
            // 
            this.assetTblBindingSource.DataMember = "AssetTbl";
            this.assetTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetTblTableAdapter
            // 
            this.assetTblTableAdapter.ClearBeforeFill = true;
            // 
            // ManageAssetMovementTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.assetVwGridControl);
            this.Controls.Add(this.assetMovementGridControl);
            this.Controls.Add(this.assetMovementTblBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageAssetMovementTblForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة سجلات نقل الأصول";
            this.Load += new System.EventHandler(this.ManageAssetMovementTblForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.astRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementTblBindingNavigator)).EndInit();
            this.assetMovementTblBindingNavigator.ResumeLayout(false);
            this.assetMovementTblBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetLayoutView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colمعرفالأصل)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colكودالأصل)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colالعدد)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colالقسم)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colالدائرة)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colالساحة)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colالفئةالرئيسية)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colالفئةالفرعية)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colمواصفاتالأصل)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colالموديل)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colاللون)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colتاريخالشراء)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colسعرالشراء)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colعملةسعرالشراء)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colمكانالتواجد)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colحالةالأصلالآنية)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colنسبةالاستفادةمنه)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colالسعرالفعليالحالي)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colعملةالسعرالفعليالحالي)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colاسمصاحبالعهدة)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colتفاصيلإضافية)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colملاحظاتأخرى)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colعنوانالعقار)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colاسمالمالك)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colالمستغلمنه)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colمعمنورقةالملكية)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colمساحةالعقار)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colوحدةمساحةالعقار)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colرقملوحةالمركبة)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colسنةصنعالمركبة)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colرقمالمحركللمركبة)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colمعدلالإهلاكللأصل)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colالعمرالافتراضيالمتبقيللأصل)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AssetMngDbDataSet assetMngDbDataSet;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator assetMovementTblBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton assetMovementTblBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl assetMovementGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView assetMovementGridView;
        private System.Windows.Forms.BindingSource assetMovementTblBindingSource;
        private AssetMngDbDataSetTableAdapters.AssetMovementTblTableAdapter assetMovementTblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit astRepositoryItemLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colFieldChanged;
        private DevExpress.XtraGrid.Columns.GridColumn colOldValue;
        private DevExpress.XtraGrid.Columns.GridColumn colNewValue;
        private DevExpress.XtraGrid.Columns.GridColumn colMovementDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetMovedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetMovedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetMovementUniqueKey;
        private System.Windows.Forms.BindingSource assetVwBindingSource;
        private AssetMngDbDataSetTableAdapters.AssetVwTableAdapter assetVwTableAdapter;
        private System.Windows.Forms.ToolStripButton assetMovementTblBindingNavigatorExportToExcelItem;
        private System.Windows.Forms.ToolStripButton assetMovementTblBindingNavigatorViewAssetCardItem;
        private System.Windows.Forms.BindingSource assetVwAllBindingSource;
        private AssetMngDbDataSetTableAdapters.AssetVw_AllTableAdapter assetVw_AllTableAdapter;
        private DevExpress.XtraGrid.GridControl assetVwGridControl;
        private DevExpress.XtraGrid.Views.Layout.LayoutView assetLayoutView;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colمعرفالأصل;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colمعرفالأصل;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colكودالأصل;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colكودالأصل;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colالعدد;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colالعدد;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colالقسم;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colالقسم;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colالدائرة;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colالدائرة;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colالساحة;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colالساحة;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colالفئةالرئيسية;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colالفئةالرئيسية;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colالفئةالفرعية;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colالفئةالفرعية;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colمواصفاتالأصل;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colمواصفاتالأصل;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colالموديل;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colالموديل;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colاللون;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colاللون;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colتاريخالشراء;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colتاريخالشراء;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colسعرالشراء;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colسعرالشراء;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colعملةسعرالشراء;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colعملةسعرالشراء;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colمكانالتواجد;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colمكانالتواجد;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colحالةالأصلالآنية;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colحالةالأصلالآنية;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colنسبةالاستفادةمنه;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colنسبةالاستفادةمنه;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colالسعرالفعليالحالي;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colالسعرالفعليالحالي;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colعملةالسعرالفعليالحالي;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colعملةالسعرالفعليالحالي;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colاسمصاحبالعهدة;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colاسمصاحبالعهدة;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colتفاصيلإضافية;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colتفاصيلإضافية;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colملاحظاتأخرى;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colملاحظاتأخرى;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colعنوانالعقار;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colعنوانالعقار;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colاسمالمالك;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colاسمالمالك;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colالمستغلمنه;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colالمستغلمنه;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colمعمنورقةالملكية;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colمعمنورقةالملكية;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colمساحةالعقار;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colمساحةالعقار;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colوحدةمساحةالعقار;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colوحدةمساحةالعقار;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colرقملوحةالمركبة;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colرقملوحةالمركبة;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colسنةصنعالمركبة;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colسنةصنعالمركبة;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colرقمالمحركللمركبة;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colرقمالمحركللمركبة;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colمعدلالإهلاكللأصل;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colمعدلالإهلاكللأصل;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colالعمرالافتراضيالمتبقيللأصل;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colالعمرالافتراضيالمتبقيللأصل;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private System.Windows.Forms.BindingSource assetTblBindingSource;
        private AssetMngDbDataSetTableAdapters.AssetTblTableAdapter assetTblTableAdapter;
    }
}