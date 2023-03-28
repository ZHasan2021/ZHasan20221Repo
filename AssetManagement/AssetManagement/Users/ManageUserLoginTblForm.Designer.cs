
using AssetManagement.AuxTables;

namespace AssetManagement.Users
{
    partial class ManageUserLoginTblForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUserLoginTblForm));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.userLoginTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.UserLoginTblTableAdapter();
            this.userTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.UserTblTableAdapter();
            this.userLoginTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.userLoginTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.userLoginTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.userLoginTblBindingNavigatorExportToExcelItem = new System.Windows.Forms.ToolStripButton();
            this.userLoginTblBindingNavigatorSaveLogItem = new System.Windows.Forms.ToolStripButton();
            this.userLoginGridControl = new DevExpress.XtraGrid.GridControl();
            this.userLoginGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.userTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colLoggedInAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateTimeOffsetEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit();
            this.colLoggedOutAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSessionActions = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginTblBindingNavigator)).BeginInit();
            this.userLoginTblBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTimeOffsetEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.UserLoginTblTableAdapter = this.userLoginTblTableAdapter;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = this.userTblTableAdapter;
            // 
            // userLoginTblTableAdapter
            // 
            this.userLoginTblTableAdapter.ClearBeforeFill = true;
            // 
            // userTblTableAdapter
            // 
            this.userTblTableAdapter.ClearBeforeFill = true;
            // 
            // userLoginTblBindingNavigator
            // 
            this.userLoginTblBindingNavigator.AddNewItem = null;
            this.userLoginTblBindingNavigator.BindingSource = this.userLoginTblBindingSource;
            this.userLoginTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userLoginTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.userLoginTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.userLoginTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.userLoginTblBindingNavigatorSaveItem,
            this.userLoginTblBindingNavigatorExportToExcelItem,
            this.userLoginTblBindingNavigatorSaveLogItem});
            this.userLoginTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userLoginTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userLoginTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userLoginTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userLoginTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userLoginTblBindingNavigator.Name = "userLoginTblBindingNavigator";
            this.userLoginTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userLoginTblBindingNavigator.Size = new System.Drawing.Size(1274, 47);
            this.userLoginTblBindingNavigator.TabIndex = 6;
            this.userLoginTblBindingNavigator.Text = "bindingNavigator1";
            // 
            // userLoginTblBindingSource
            // 
            this.userLoginTblBindingSource.DataMember = "UserLoginTbl";
            this.userLoginTblBindingSource.DataSource = this.assetMngDbDataSet;
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Visible = false;
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // userLoginTblBindingNavigatorSaveItem
            // 
            this.userLoginTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userLoginTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userLoginTblBindingNavigatorSaveItem.Image")));
            this.userLoginTblBindingNavigatorSaveItem.Name = "userLoginTblBindingNavigatorSaveItem";
            this.userLoginTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(44, 44);
            this.userLoginTblBindingNavigatorSaveItem.Text = "Save Data";
            this.userLoginTblBindingNavigatorSaveItem.Visible = false;
            this.userLoginTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.userLoginTblBindingNavigatorSaveItem_Click);
            // 
            // userLoginTblBindingNavigatorExportToExcelItem
            // 
            this.userLoginTblBindingNavigatorExportToExcelItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userLoginTblBindingNavigatorExportToExcelItem.Image = global::AssetManagement.Properties.Resources._36435172;
            this.userLoginTblBindingNavigatorExportToExcelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userLoginTblBindingNavigatorExportToExcelItem.Name = "userLoginTblBindingNavigatorExportToExcelItem";
            this.userLoginTblBindingNavigatorExportToExcelItem.Size = new System.Drawing.Size(44, 44);
            this.userLoginTblBindingNavigatorExportToExcelItem.Text = "تصدير إلى إكسل";
            this.userLoginTblBindingNavigatorExportToExcelItem.Click += new System.EventHandler(this.userLoginTblBindingNavigatorExportToExcelItem_Click);
            // 
            // userLoginTblBindingNavigatorSaveLogItem
            // 
            this.userLoginTblBindingNavigatorSaveLogItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userLoginTblBindingNavigatorSaveLogItem.Image = global::AssetManagement.Properties.Resources._3393734;
            this.userLoginTblBindingNavigatorSaveLogItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userLoginTblBindingNavigatorSaveLogItem.Name = "userLoginTblBindingNavigatorSaveLogItem";
            this.userLoginTblBindingNavigatorSaveLogItem.Size = new System.Drawing.Size(44, 44);
            this.userLoginTblBindingNavigatorSaveLogItem.Text = "حفظ ملف Log";
            this.userLoginTblBindingNavigatorSaveLogItem.Click += new System.EventHandler(this.userLoginTblBindingNavigatorSaveLogItem_Click);
            // 
            // userLoginGridControl
            // 
            this.userLoginGridControl.DataSource = this.userLoginTblBindingSource;
            this.userLoginGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "userLoginLevel";
            this.userLoginGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.userLoginGridControl.Location = new System.Drawing.Point(0, 47);
            this.userLoginGridControl.MainView = this.userLoginGridView;
            this.userLoginGridControl.Name = "userLoginGridControl";
            this.userLoginGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateTimeOffsetEdit1,
            this.repositoryItemLookUpEdit1});
            this.userLoginGridControl.Size = new System.Drawing.Size(1274, 652);
            this.userLoginGridControl.TabIndex = 9;
            this.userLoginGridControl.UseEmbeddedNavigator = true;
            this.userLoginGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.userLoginGridView});
            // 
            // userLoginGridView
            // 
            this.userLoginGridView.Appearance.Row.Options.UseTextOptions = true;
            this.userLoginGridView.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.userLoginGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colUserID,
            this.colLoggedInAt,
            this.colLoggedOutAt,
            this.colSessionActions});
            this.userLoginGridView.GridControl = this.userLoginGridControl;
            this.userLoginGridView.Name = "userLoginGridView";
            this.userLoginGridView.OptionsBehavior.Editable = false;
            this.userLoginGridView.OptionsView.RowAutoHeight = true;
            this.userLoginGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.userGridView_RowClick);
            this.userLoginGridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.userGridView_RowCellClick);
            // 
            // colID
            // 
            this.colID.Caption = "معرف نشاط الحساب";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 80;
            this.colID.Name = "colID";
            this.colID.Width = 94;
            // 
            // colUserID
            // 
            this.colUserID.Caption = "معلومات المستخدم";
            this.colUserID.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colUserID.FieldName = "UserID";
            this.colUserID.MinWidth = 150;
            this.colUserID.Name = "colUserID";
            this.colUserID.Visible = true;
            this.colUserID.VisibleIndex = 0;
            this.colUserID.Width = 150;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الحساب", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Username", "اسم المستخدم", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserPrefix", "بادئة المستخدم", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEdit1.DataSource = this.userTblBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Username";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.PopupWidth = 500;
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // userTblBindingSource
            // 
            this.userTblBindingSource.DataMember = "UserTbl";
            this.userTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // colLoggedInAt
            // 
            this.colLoggedInAt.Caption = "ساعة الدخول";
            this.colLoggedInAt.ColumnEdit = this.repositoryItemDateTimeOffsetEdit1;
            this.colLoggedInAt.FieldName = "LoggedInAt";
            this.colLoggedInAt.MinWidth = 120;
            this.colLoggedInAt.Name = "colLoggedInAt";
            this.colLoggedInAt.Visible = true;
            this.colLoggedInAt.VisibleIndex = 1;
            this.colLoggedInAt.Width = 120;
            // 
            // repositoryItemDateTimeOffsetEdit1
            // 
            this.repositoryItemDateTimeOffsetEdit1.AutoHeight = false;
            this.repositoryItemDateTimeOffsetEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateTimeOffsetEdit1.Name = "repositoryItemDateTimeOffsetEdit1";
            // 
            // colLoggedOutAt
            // 
            this.colLoggedOutAt.Caption = "ساعة الخروج";
            this.colLoggedOutAt.ColumnEdit = this.repositoryItemDateTimeOffsetEdit1;
            this.colLoggedOutAt.FieldName = "LoggedOutAt";
            this.colLoggedOutAt.MinWidth = 120;
            this.colLoggedOutAt.Name = "colLoggedOutAt";
            this.colLoggedOutAt.Visible = true;
            this.colLoggedOutAt.VisibleIndex = 2;
            this.colLoggedOutAt.Width = 120;
            // 
            // colSessionActions
            // 
            this.colSessionActions.AppearanceCell.Options.UseTextOptions = true;
            this.colSessionActions.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSessionActions.Caption = "النشاطات التي قام بها";
            this.colSessionActions.FieldName = "SessionActions";
            this.colSessionActions.MinWidth = 250;
            this.colSessionActions.Name = "colSessionActions";
            this.colSessionActions.Visible = true;
            this.colSessionActions.VisibleIndex = 3;
            this.colSessionActions.Width = 250;
            // 
            // ManageUserLoginTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 699);
            this.Controls.Add(this.userLoginGridControl);
            this.Controls.Add(this.userLoginTblBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageUserLoginTblForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة جدول نشاطات المستخدمين";
            this.Load += new System.EventHandler(this.ManageUserLoginTblForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginTblBindingNavigator)).EndInit();
            this.userLoginTblBindingNavigator.ResumeLayout(false);
            this.userLoginTblBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTimeOffsetEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AssetMngDbDataSet assetMngDbDataSet;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator userLoginTblBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton userLoginTblBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource userLoginTblBindingSource;
        private AssetMngDbDataSetTableAdapters.UserLoginTblTableAdapter userLoginTblTableAdapter;
        private DevExpress.XtraGrid.GridControl userLoginGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView userLoginGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colLoggedInAt;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit repositoryItemDateTimeOffsetEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colLoggedOutAt;
        private DevExpress.XtraGrid.Columns.GridColumn colSessionActions;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource userTblBindingSource;
        private AssetMngDbDataSetTableAdapters.UserTblTableAdapter userTblTableAdapter;
        private System.Windows.Forms.ToolStripButton userLoginTblBindingNavigatorSaveLogItem;
        private System.Windows.Forms.ToolStripButton userLoginTblBindingNavigatorExportToExcelItem;
    }
}