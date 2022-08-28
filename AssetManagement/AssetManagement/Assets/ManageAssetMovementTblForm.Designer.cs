
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
            this.assetVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colFieldChanged = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOldValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMovementDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetMovedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetMovedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetMovementUniqueKey = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.assetVwTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetVwTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.astRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementTblBindingNavigator)).BeginInit();
            this.assetMovementTblBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // assetMovementGridControl
            // 
            this.assetMovementGridControl.DataSource = this.assetMovementTblBindingSource;
            this.assetMovementGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "assetMovementLevel";
            this.assetMovementGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.assetMovementGridControl.Location = new System.Drawing.Point(0, 27);
            this.assetMovementGridControl.MainView = this.assetMovementGridView;
            this.assetMovementGridControl.Name = "assetMovementGridControl";
            this.assetMovementGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.astRepositoryItemLookUpEdit});
            this.assetMovementGridControl.Size = new System.Drawing.Size(1282, 726);
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("معرف الأصل", "معرف الأصل", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("كود الأصل", "كود الأصل", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("الدائرة", "الدائرة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("القسم", "القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("الوحدة", "الوحدة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("الساحة", "الساحة", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("الفئة الرئيسية", "الفئة الرئيسية", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("الفئة الفرعية", "الفئة الفرعية", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("مواصفات الأصل", "مواصفات الأصل", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.astRepositoryItemLookUpEdit.DataSource = this.assetVwBindingSource;
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
            this.tableAdapterManager.MainCategoryTblTableAdapter = null;
            this.tableAdapterManager.MinorCategoryTblTableAdapter = null;
            this.tableAdapterManager.ModelTblTableAdapter = null;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
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
            this.assetMovementTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.assetMovementTblBindingNavigatorSaveItem});
            this.assetMovementTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.assetMovementTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.assetMovementTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.assetMovementTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.assetMovementTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.assetMovementTblBindingNavigator.Name = "assetMovementTblBindingNavigator";
            this.assetMovementTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.assetMovementTblBindingNavigator.Size = new System.Drawing.Size(1282, 27);
            this.assetMovementTblBindingNavigator.TabIndex = 4;
            this.assetMovementTblBindingNavigator.Text = "bindingNavigator1";
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
            // assetMovementTblBindingNavigatorSaveItem
            // 
            this.assetMovementTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.assetMovementTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("assetMovementTblBindingNavigatorSaveItem.Image")));
            this.assetMovementTblBindingNavigatorSaveItem.Name = "assetMovementTblBindingNavigatorSaveItem";
            this.assetMovementTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.assetMovementTblBindingNavigatorSaveItem.Text = "Save Data";
            this.assetMovementTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.assetMovementTblBindingNavigatorSaveItem_Click);
            // 
            // assetVwTableAdapter
            // 
            this.assetVwTableAdapter.ClearBeforeFill = true;
            // 
            // ManageAssetMovementTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
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
            ((System.ComponentModel.ISupportInitialize)(this.assetVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementTblBindingNavigator)).EndInit();
            this.assetMovementTblBindingNavigator.ResumeLayout(false);
            this.assetMovementTblBindingNavigator.PerformLayout();
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
    }
}