﻿
using AssetManagement.AuxTables;

namespace AssetManagement.Users
{
    partial class ManageUserTblForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUserTblForm));
            this.minorCategoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.userGridControl = new DevExpress.XtraGrid.GridControl();
            this.userTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.userGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userRoleRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.userRoleTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colPasswordUpdatedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserSection = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sectionRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.sectionTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colUserDept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userDeptRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.departmentVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colUserPrefix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.departmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.departmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter();
            this.sectionTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SectionTblTableAdapter();
            this.userRoleTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.UserRoleTblTableAdapter();
            this.userTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.UserTblTableAdapter();
            this.userTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.userTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.userTblBindingNavigatorManageUserRolesItem = new System.Windows.Forms.ToolStripButton();
            this.departmentVwTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.DepartmentVwTableAdapter();
            this.userTblBindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTblBindingNavigator)).BeginInit();
            this.userTblBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // minorCategoryGridView
            // 
            this.minorCategoryGridView.GridControl = this.userGridControl;
            this.minorCategoryGridView.Name = "minorCategoryGridView";
            // 
            // userGridControl
            // 
            this.userGridControl.DataSource = this.userTblBindingSource;
            this.userGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.minorCategoryGridView;
            gridLevelNode1.RelationName = "userLevel";
            this.userGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.userGridControl.Location = new System.Drawing.Point(0, 47);
            this.userGridControl.MainView = this.userGridView;
            this.userGridControl.Name = "userGridControl";
            this.userGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.userRoleRepositoryItemLookUpEdit,
            this.userDeptRepositoryItemLookUpEdit,
            this.sectionRepositoryItemLookUpEdit});
            this.userGridControl.Size = new System.Drawing.Size(1274, 652);
            this.userGridControl.TabIndex = 8;
            this.userGridControl.UseEmbeddedNavigator = true;
            this.userGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.userGridView,
            this.minorCategoryGridView});
            // 
            // userTblBindingSource
            // 
            this.userTblBindingSource.DataMember = "UserTbl";
            this.userTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userGridView
            // 
            this.userGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colUsername,
            this.colPassword,
            this.colUserRole,
            this.colPasswordUpdatedOn,
            this.colUserSection,
            this.colUserDept,
            this.colUserPrefix,
            this.colUserNotes});
            this.userGridView.GridControl = this.userGridControl;
            this.userGridView.Name = "userGridView";
            this.userGridView.OptionsBehavior.Editable = false;
            this.userGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.userGridView_RowClick);
            this.userGridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.userGridView_RowCellClick);
            // 
            // colID
            // 
            this.colID.Caption = "معرف الحساب";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 80;
            this.colID.Name = "colID";
            this.colID.Width = 108;
            // 
            // colUsername
            // 
            this.colUsername.Caption = "اسم المستخدم";
            this.colUsername.FieldName = "Username";
            this.colUsername.MinWidth = 120;
            this.colUsername.Name = "colUsername";
            this.colUsername.Visible = true;
            this.colUsername.VisibleIndex = 0;
            this.colUsername.Width = 226;
            // 
            // colPassword
            // 
            this.colPassword.Caption = "كلمة المرور";
            this.colPassword.FieldName = "Password";
            this.colPassword.MinWidth = 120;
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 1;
            this.colPassword.Width = 183;
            // 
            // colUserRole
            // 
            this.colUserRole.Caption = "نوع الحساب";
            this.colUserRole.ColumnEdit = this.userRoleRepositoryItemLookUpEdit;
            this.colUserRole.FieldName = "UserRole";
            this.colUserRole.MinWidth = 120;
            this.colUserRole.Name = "colUserRole";
            this.colUserRole.Visible = true;
            this.colUserRole.VisibleIndex = 2;
            this.colUserRole.Width = 183;
            // 
            // userRoleRepositoryItemLookUpEdit
            // 
            this.userRoleRepositoryItemLookUpEdit.AutoHeight = false;
            this.userRoleRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.userRoleRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف نوع الحساب", 100, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleName", "اسم نوع الحساب", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.userRoleRepositoryItemLookUpEdit.DataSource = this.userRoleTblBindingSource;
            this.userRoleRepositoryItemLookUpEdit.DisplayMember = "RoleName";
            this.userRoleRepositoryItemLookUpEdit.Name = "userRoleRepositoryItemLookUpEdit";
            this.userRoleRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // userRoleTblBindingSource
            // 
            this.userRoleTblBindingSource.DataMember = "UserRoleTbl";
            this.userRoleTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // colPasswordUpdatedOn
            // 
            this.colPasswordUpdatedOn.Caption = "تاريخ تعديل كلمة المرور";
            this.colPasswordUpdatedOn.FieldName = "PasswordUpdatedOn";
            this.colPasswordUpdatedOn.MinWidth = 25;
            this.colPasswordUpdatedOn.Name = "colPasswordUpdatedOn";
            this.colPasswordUpdatedOn.Width = 120;
            // 
            // colUserSection
            // 
            this.colUserSection.Caption = "الدائرة";
            this.colUserSection.ColumnEdit = this.sectionRepositoryItemLookUpEdit;
            this.colUserSection.FieldName = "UserSection";
            this.colUserSection.MinWidth = 150;
            this.colUserSection.Name = "colUserSection";
            this.colUserSection.Visible = true;
            this.colUserSection.VisibleIndex = 3;
            this.colUserSection.Width = 150;
            // 
            // sectionRepositoryItemLookUpEdit
            // 
            this.sectionRepositoryItemLookUpEdit.AutoHeight = false;
            this.sectionRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sectionRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الدائرة", 100, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SectionName", "اسم الدائرة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.sectionRepositoryItemLookUpEdit.DataSource = this.sectionTblBindingSource;
            this.sectionRepositoryItemLookUpEdit.DisplayMember = "SectionName";
            this.sectionRepositoryItemLookUpEdit.Name = "sectionRepositoryItemLookUpEdit";
            this.sectionRepositoryItemLookUpEdit.PopupWidth = 500;
            this.sectionRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // sectionTblBindingSource
            // 
            this.sectionTblBindingSource.DataMember = "SectionTbl";
            this.sectionTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // colUserDept
            // 
            this.colUserDept.Caption = "القسم";
            this.colUserDept.ColumnEdit = this.userDeptRepositoryItemLookUpEdit;
            this.colUserDept.FieldName = "UserDept";
            this.colUserDept.MinWidth = 200;
            this.colUserDept.Name = "colUserDept";
            this.colUserDept.Visible = true;
            this.colUserDept.VisibleIndex = 4;
            this.colUserDept.Width = 200;
            // 
            // userDeptRepositoryItemLookUpEdit
            // 
            this.userDeptRepositoryItemLookUpEdit.AutoHeight = false;
            this.userDeptRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.userDeptRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("معرف القسم", "معرف القسم", 100, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("اسم القسم", "اسم القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("الدائرة التي يتبع لها القسم", "الدائرة التي يتبع لها القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.userDeptRepositoryItemLookUpEdit.DataSource = this.departmentVwBindingSource;
            this.userDeptRepositoryItemLookUpEdit.DisplayMember = "اسم القسم";
            this.userDeptRepositoryItemLookUpEdit.Name = "userDeptRepositoryItemLookUpEdit";
            this.userDeptRepositoryItemLookUpEdit.PopupWidth = 500;
            this.userDeptRepositoryItemLookUpEdit.ValueMember = "معرف القسم";
            // 
            // departmentVwBindingSource
            // 
            this.departmentVwBindingSource.DataMember = "DepartmentVw";
            this.departmentVwBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // colUserPrefix
            // 
            this.colUserPrefix.Caption = "البادئة الخاصة بالمستخدم";
            this.colUserPrefix.FieldName = "UserPrefix";
            this.colUserPrefix.MinWidth = 150;
            this.colUserPrefix.Name = "colUserPrefix";
            this.colUserPrefix.Visible = true;
            this.colUserPrefix.VisibleIndex = 5;
            this.colUserPrefix.Width = 150;
            // 
            // colUserNotes
            // 
            this.colUserNotes.Caption = "ملاحظات";
            this.colUserNotes.FieldName = "UserNotes";
            this.colUserNotes.MinWidth = 200;
            this.colUserNotes.Name = "colUserNotes";
            this.colUserNotes.Width = 200;
            // 
            // departmentTblBindingSource
            // 
            this.departmentTblBindingSource.DataMember = "DepartmentTbl";
            this.departmentTblBindingSource.DataSource = this.assetMngDbDataSet;
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
            this.tableAdapterManager.DepartmentTblTableAdapter = this.departmentTblTableAdapter;
            this.tableAdapterManager.EstateAreaUnitTblTableAdapter = null;
            this.tableAdapterManager.FinancialItemCategoryTblTableAdapter = null;
            this.tableAdapterManager.FinancialItemTblTableAdapter = null;
            this.tableAdapterManager.ImportExportTblTableAdapter = null;
            this.tableAdapterManager.MainCategoryTblTableAdapter = null;
            this.tableAdapterManager.MinorCategoryTblTableAdapter = null;
            this.tableAdapterManager.ModelTblTableAdapter = null;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.SectionTblTableAdapter = this.sectionTblTableAdapter;
            this.tableAdapterManager.SquareTblTableAdapter = null;
            this.tableAdapterManager.StatusTblTableAdapter = null;
            this.tableAdapterManager.SubDepartmentTblTableAdapter = null;
            this.tableAdapterManager.TransactionTypeTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTblTableAdapter = this.userRoleTblTableAdapter;
            this.tableAdapterManager.UserTblTableAdapter = this.userTblTableAdapter;
            // 
            // departmentTblTableAdapter
            // 
            this.departmentTblTableAdapter.ClearBeforeFill = true;
            // 
            // sectionTblTableAdapter
            // 
            this.sectionTblTableAdapter.ClearBeforeFill = true;
            // 
            // userRoleTblTableAdapter
            // 
            this.userRoleTblTableAdapter.ClearBeforeFill = true;
            // 
            // userTblTableAdapter
            // 
            this.userTblTableAdapter.ClearBeforeFill = true;
            // 
            // userTblBindingNavigator
            // 
            this.userTblBindingNavigator.AddNewItem = null;
            this.userTblBindingNavigator.BindingSource = this.userTblBindingSource;
            this.userTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.userTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.userTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.userTblBindingNavigatorSaveItem,
            this.userTblBindingNavigatorManageUserRolesItem,
            this.userTblBindingNavigatorEditItem});
            this.userTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userTblBindingNavigator.Name = "userTblBindingNavigator";
            this.userTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userTblBindingNavigator.Size = new System.Drawing.Size(1274, 47);
            this.userTblBindingNavigator.TabIndex = 6;
            this.userTblBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // userTblBindingNavigatorSaveItem
            // 
            this.userTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userTblBindingNavigatorSaveItem.Image")));
            this.userTblBindingNavigatorSaveItem.Name = "userTblBindingNavigatorSaveItem";
            this.userTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(44, 44);
            this.userTblBindingNavigatorSaveItem.Text = "Save Data";
            this.userTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.userTblBindingNavigatorSaveItem_Click);
            // 
            // userTblBindingNavigatorManageUserRolesItem
            // 
            this.userTblBindingNavigatorManageUserRolesItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userTblBindingNavigatorManageUserRolesItem.Image = global::AssetManagement.Properties.Resources._968279;
            this.userTblBindingNavigatorManageUserRolesItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userTblBindingNavigatorManageUserRolesItem.Name = "userTblBindingNavigatorManageUserRolesItem";
            this.userTblBindingNavigatorManageUserRolesItem.Size = new System.Drawing.Size(44, 44);
            this.userTblBindingNavigatorManageUserRolesItem.Text = "toolStripButton1";
            this.userTblBindingNavigatorManageUserRolesItem.Click += new System.EventHandler(this.userTblBindingNavigatorManageUserRolesItem_Click);
            // 
            // departmentVwTableAdapter
            // 
            this.departmentVwTableAdapter.ClearBeforeFill = true;
            // 
            // userTblBindingNavigatorEditItem
            // 
            this.userTblBindingNavigatorEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userTblBindingNavigatorEditItem.Image = global::AssetManagement.Properties.Resources._1573959;
            this.userTblBindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userTblBindingNavigatorEditItem.Name = "userTblBindingNavigatorEditItem";
            this.userTblBindingNavigatorEditItem.Size = new System.Drawing.Size(44, 44);
            this.userTblBindingNavigatorEditItem.Text = "تعديل";
            this.userTblBindingNavigatorEditItem.Click += new System.EventHandler(this.userTblBindingNavigatorEditItem_Click);
            // 
            // ManageUserTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 699);
            this.Controls.Add(this.userGridControl);
            this.Controls.Add(this.userTblBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageUserTblForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة جدول حسابات المستخدمين";
            this.Load += new System.EventHandler(this.ManageUserTblForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTblBindingNavigator)).EndInit();
            this.userTblBindingNavigator.ResumeLayout(false);
            this.userTblBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AssetMngDbDataSet assetMngDbDataSet;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource userTblBindingSource;
        private AssetMngDbDataSetTableAdapters.UserTblTableAdapter userTblTableAdapter;
        private System.Windows.Forms.BindingNavigator userTblBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton userTblBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton userTblBindingNavigatorManageUserRolesItem;
        private DevExpress.XtraGrid.GridControl userGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView minorCategoryGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView userGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colUserRole;
        private DevExpress.XtraGrid.Columns.GridColumn colPasswordUpdatedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colUserDept;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit userRoleRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource userRoleTblBindingSource;
        private AssetMngDbDataSetTableAdapters.UserRoleTblTableAdapter userRoleTblTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit userDeptRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource departmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter departmentTblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colUserPrefix;
        private System.Windows.Forms.BindingSource departmentVwBindingSource;
        private AssetMngDbDataSetTableAdapters.DepartmentVwTableAdapter departmentVwTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colUserSection;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit sectionRepositoryItemLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colUserNotes;
        private System.Windows.Forms.BindingSource sectionTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SectionTblTableAdapter sectionTblTableAdapter;
        private System.Windows.Forms.ToolStripButton userTblBindingNavigatorEditItem;
    }
}