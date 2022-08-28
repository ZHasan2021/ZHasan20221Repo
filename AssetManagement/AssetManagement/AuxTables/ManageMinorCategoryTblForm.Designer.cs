
namespace AssetManagement.AuxTables
{
    partial class ManageMinorCategoryTblForm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMinorCategoryTblForm));
            this.minorCategoryGridControl = new DevExpress.XtraGrid.GridControl();
            this.minorCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.minorCategoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.minorCategoryTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.MinorCategoryTblTableAdapter();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.minorCategoryTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.minorCategoryTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinorCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinorCategoryDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMainCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductiveAgeInYears = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDestructionRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.macaRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.minorCategoryTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mainCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainCategoryTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.MainCategoryTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryTblBindingNavigator)).BeginInit();
            this.minorCategoryTblBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.macaRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // minorCategoryGridControl
            // 
            this.minorCategoryGridControl.DataSource = this.minorCategoryTblBindingSource;
            this.minorCategoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.RelationName = "minorCategoryLevel";
            this.minorCategoryGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.minorCategoryGridControl.Location = new System.Drawing.Point(0, 31);
            this.minorCategoryGridControl.MainView = this.minorCategoryGridView;
            this.minorCategoryGridControl.Name = "minorCategoryGridControl";
            this.minorCategoryGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.macaRepositoryItemLookUpEdit});
            this.minorCategoryGridControl.Size = new System.Drawing.Size(1180, 639);
            this.minorCategoryGridControl.TabIndex = 5;
            this.minorCategoryGridControl.UseEmbeddedNavigator = true;
            this.minorCategoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.minorCategoryGridView});
            // 
            // minorCategoryTblBindingSource
            // 
            this.minorCategoryTblBindingSource.DataMember = "MinorCategoryTbl";
            this.minorCategoryTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // minorCategoryGridView
            // 
            this.minorCategoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMinorCategoryName,
            this.colMinorCategoryDescription,
            this.colMainCategory,
            this.colProductiveAgeInYears,
            this.colDestructionRate});
            this.minorCategoryGridView.GridControl = this.minorCategoryGridControl;
            this.minorCategoryGridView.Name = "minorCategoryGridView";
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
            this.tableAdapterManager.MainCategoryTblTableAdapter = this.mainCategoryTblTableAdapter;
            this.tableAdapterManager.MinorCategoryTblTableAdapter = this.minorCategoryTblTableAdapter;
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
            // minorCategoryTblTableAdapter
            // 
            this.minorCategoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // minorCategoryTblBindingNavigatorSaveItem
            // 
            this.minorCategoryTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.minorCategoryTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("minorCategoryTblBindingNavigatorSaveItem.Image")));
            this.minorCategoryTblBindingNavigatorSaveItem.Name = "minorCategoryTblBindingNavigatorSaveItem";
            this.minorCategoryTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.minorCategoryTblBindingNavigatorSaveItem.Text = "Save Data";
            this.minorCategoryTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.minorCategoryTblBindingNavigatorSaveItem_Click);
            // 
            // minorCategoryTblBindingNavigator
            // 
            this.minorCategoryTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.minorCategoryTblBindingNavigator.BindingSource = this.minorCategoryTblBindingSource;
            this.minorCategoryTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.minorCategoryTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.minorCategoryTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.minorCategoryTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.minorCategoryTblBindingNavigatorSaveItem});
            this.minorCategoryTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.minorCategoryTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.minorCategoryTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.minorCategoryTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.minorCategoryTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.minorCategoryTblBindingNavigator.Name = "minorCategoryTblBindingNavigator";
            this.minorCategoryTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.minorCategoryTblBindingNavigator.Size = new System.Drawing.Size(1180, 31);
            this.minorCategoryTblBindingNavigator.TabIndex = 4;
            this.minorCategoryTblBindingNavigator.Text = "bindingNavigator1";
            // 
            // colID
            // 
            this.colID.Caption = "معرف الفئة الفرعية";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Width = 80;
            // 
            // colMinorCategoryName
            // 
            this.colMinorCategoryName.Caption = "اسم الفئة الفرعية";
            this.colMinorCategoryName.FieldName = "MinorCategoryName";
            this.colMinorCategoryName.MinWidth = 25;
            this.colMinorCategoryName.Name = "colMinorCategoryName";
            this.colMinorCategoryName.Visible = true;
            this.colMinorCategoryName.VisibleIndex = 0;
            this.colMinorCategoryName.Width = 150;
            // 
            // colMinorCategoryDescription
            // 
            this.colMinorCategoryDescription.Caption = "وصف الفئة الفرعية";
            this.colMinorCategoryDescription.FieldName = "MinorCategoryDescription";
            this.colMinorCategoryDescription.MinWidth = 25;
            this.colMinorCategoryDescription.Name = "colMinorCategoryDescription";
            this.colMinorCategoryDescription.Visible = true;
            this.colMinorCategoryDescription.VisibleIndex = 1;
            this.colMinorCategoryDescription.Width = 200;
            // 
            // colMainCategory
            // 
            this.colMainCategory.Caption = "الفئة الرئيسية";
            this.colMainCategory.ColumnEdit = this.macaRepositoryItemLookUpEdit;
            this.colMainCategory.FieldName = "MainCategory";
            this.colMainCategory.MinWidth = 25;
            this.colMainCategory.Name = "colMainCategory";
            this.colMainCategory.Visible = true;
            this.colMainCategory.VisibleIndex = 2;
            this.colMainCategory.Width = 150;
            // 
            // colProductiveAgeInYears
            // 
            this.colProductiveAgeInYears.Caption = "العمر الإنتاجي بالسنوات";
            this.colProductiveAgeInYears.FieldName = "ProductiveAgeInYears";
            this.colProductiveAgeInYears.MinWidth = 25;
            this.colProductiveAgeInYears.Name = "colProductiveAgeInYears";
            this.colProductiveAgeInYears.Visible = true;
            this.colProductiveAgeInYears.VisibleIndex = 3;
            this.colProductiveAgeInYears.Width = 80;
            // 
            // colDestructionRate
            // 
            this.colDestructionRate.Caption = "معدل الإهلاك";
            this.colDestructionRate.FieldName = "DestructionRate";
            this.colDestructionRate.MinWidth = 25;
            this.colDestructionRate.Name = "colDestructionRate";
            this.colDestructionRate.Visible = true;
            this.colDestructionRate.VisibleIndex = 4;
            this.colDestructionRate.Width = 80;
            // 
            // macaRepositoryItemLookUpEdit
            // 
            this.macaRepositoryItemLookUpEdit.AutoHeight = false;
            this.macaRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.macaRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الفئة الرئيسية", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainCategoryName", "اسم الفئة الرئيسية", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainCategoryDescription", "وصف الفئة الرئيسية", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.macaRepositoryItemLookUpEdit.DataSource = this.mainCategoryTblBindingSource;
            this.macaRepositoryItemLookUpEdit.DisplayMember = "MainCategoryName";
            this.macaRepositoryItemLookUpEdit.Name = "macaRepositoryItemLookUpEdit";
            this.macaRepositoryItemLookUpEdit.PopupWidth = 500;
            this.macaRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // minorCategoryTblBindingSource1
            // 
            this.minorCategoryTblBindingSource1.DataMember = "MinorCategoryTbl";
            this.minorCategoryTblBindingSource1.DataSource = this.assetMngDbDataSet;
            // 
            // mainCategoryTblBindingSource
            // 
            this.mainCategoryTblBindingSource.DataMember = "MainCategoryTbl";
            this.mainCategoryTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // mainCategoryTblTableAdapter
            // 
            this.mainCategoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // ManageMinorCategoryTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 670);
            this.Controls.Add(this.minorCategoryGridControl);
            this.Controls.Add(this.minorCategoryTblBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageMinorCategoryTblForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة جدول الفئات الفرعية";
            this.Load += new System.EventHandler(this.ManageMinorCategoryTblForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryTblBindingNavigator)).EndInit();
            this.minorCategoryTblBindingNavigator.ResumeLayout(false);
            this.minorCategoryTblBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.macaRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AssetMngDbDataSet assetMngDbDataSet;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private DevExpress.XtraGrid.GridControl minorCategoryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView minorCategoryGridView;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton minorCategoryTblBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator minorCategoryTblBindingNavigator;
        private System.Windows.Forms.BindingSource minorCategoryTblBindingSource;
        private AssetMngDbDataSetTableAdapters.MinorCategoryTblTableAdapter minorCategoryTblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMinorCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colMinorCategoryDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colMainCategory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit macaRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource minorCategoryTblBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductiveAgeInYears;
        private DevExpress.XtraGrid.Columns.GridColumn colDestructionRate;
        private System.Windows.Forms.BindingSource mainCategoryTblBindingSource;
        private AssetMngDbDataSetTableAdapters.MainCategoryTblTableAdapter mainCategoryTblTableAdapter;
    }
}