
using Kindergarten.AuxTables;

namespace Kindergarten.Users
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
            this.kindergartenDbDataSet = new Kindergarten.KindergartenDbDataSet();
            this.userRoleGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewStudent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageStudentTbl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateExistedStudent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleteStudentRecord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewStudentFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageStudentFeeTbl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateExistedStudentFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleteStudentFeeRecord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewScholasticYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageScholasticYears = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddNewFeePeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageFeePeriods = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExportAllData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImportAllData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManageUsers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPromoteDb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBackupDb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRestoreDb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
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
            this.userRoleTblTableAdapter = new Kindergarten.KindergartenDbDataSetTableAdapters.UserRoleTblTableAdapter();
            this.tableAdapterManager = new Kindergarten.KindergartenDbDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDbDataSet)).BeginInit();
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
            this.userRoleGridControl.Location = new System.Drawing.Point(0, 27);
            this.userRoleGridControl.MainView = this.userRoleGridView;
            this.userRoleGridControl.Name = "userRoleGridControl";
            this.userRoleGridControl.Size = new System.Drawing.Size(1213, 634);
            this.userRoleGridControl.TabIndex = 8;
            this.userRoleGridControl.UseEmbeddedNavigator = true;
            this.userRoleGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.userRoleGridView});
            // 
            // userRoleTblBindingSource
            // 
            this.userRoleTblBindingSource.DataMember = "UserRoleTbl";
            this.userRoleTblBindingSource.DataSource = this.kindergartenDbDataSet;
            // 
            // kindergartenDbDataSet
            // 
            this.kindergartenDbDataSet.DataSetName = "KindergartenDbDataSet";
            this.kindergartenDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userRoleGridView
            // 
            this.userRoleGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colRoleName,
            this.colAddNewStudent,
            this.colManageStudentTbl,
            this.colUpdateExistedStudent,
            this.colDeleteStudentRecord,
            this.colAddNewStudentFee,
            this.colManageStudentFeeTbl,
            this.colUpdateExistedStudentFee,
            this.colDeleteStudentFeeRecord,
            this.colAddNewScholasticYear,
            this.colManageScholasticYears,
            this.colAddNewFeePeriod,
            this.colManageFeePeriods,
            this.colExportAllData,
            this.colImportAllData,
            this.colManageUsers,
            this.colPromoteDb,
            this.colBackupDb,
            this.colRestoreDb});
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
            // colAddNewStudent
            // 
            this.colAddNewStudent.FieldName = "AddNewStudent";
            this.colAddNewStudent.MinWidth = 25;
            this.colAddNewStudent.Name = "colAddNewStudent";
            this.colAddNewStudent.Visible = true;
            this.colAddNewStudent.VisibleIndex = 2;
            this.colAddNewStudent.Width = 94;
            // 
            // colManageStudentTbl
            // 
            this.colManageStudentTbl.FieldName = "ManageStudentTbl";
            this.colManageStudentTbl.MinWidth = 25;
            this.colManageStudentTbl.Name = "colManageStudentTbl";
            this.colManageStudentTbl.Visible = true;
            this.colManageStudentTbl.VisibleIndex = 3;
            this.colManageStudentTbl.Width = 94;
            // 
            // colUpdateExistedStudent
            // 
            this.colUpdateExistedStudent.FieldName = "UpdateExistedStudent";
            this.colUpdateExistedStudent.MinWidth = 25;
            this.colUpdateExistedStudent.Name = "colUpdateExistedStudent";
            this.colUpdateExistedStudent.Visible = true;
            this.colUpdateExistedStudent.VisibleIndex = 4;
            this.colUpdateExistedStudent.Width = 94;
            // 
            // colDeleteStudentRecord
            // 
            this.colDeleteStudentRecord.FieldName = "DeleteStudentRecord";
            this.colDeleteStudentRecord.MinWidth = 25;
            this.colDeleteStudentRecord.Name = "colDeleteStudentRecord";
            this.colDeleteStudentRecord.Visible = true;
            this.colDeleteStudentRecord.VisibleIndex = 5;
            this.colDeleteStudentRecord.Width = 94;
            // 
            // colAddNewStudentFee
            // 
            this.colAddNewStudentFee.FieldName = "AddNewStudentFee";
            this.colAddNewStudentFee.MinWidth = 25;
            this.colAddNewStudentFee.Name = "colAddNewStudentFee";
            this.colAddNewStudentFee.Visible = true;
            this.colAddNewStudentFee.VisibleIndex = 6;
            this.colAddNewStudentFee.Width = 94;
            // 
            // colManageStudentFeeTbl
            // 
            this.colManageStudentFeeTbl.FieldName = "ManageStudentFeeTbl";
            this.colManageStudentFeeTbl.MinWidth = 25;
            this.colManageStudentFeeTbl.Name = "colManageStudentFeeTbl";
            this.colManageStudentFeeTbl.Visible = true;
            this.colManageStudentFeeTbl.VisibleIndex = 7;
            this.colManageStudentFeeTbl.Width = 94;
            // 
            // colUpdateExistedStudentFee
            // 
            this.colUpdateExistedStudentFee.FieldName = "UpdateExistedStudentFee";
            this.colUpdateExistedStudentFee.MinWidth = 25;
            this.colUpdateExistedStudentFee.Name = "colUpdateExistedStudentFee";
            this.colUpdateExistedStudentFee.Visible = true;
            this.colUpdateExistedStudentFee.VisibleIndex = 8;
            this.colUpdateExistedStudentFee.Width = 94;
            // 
            // colDeleteStudentFeeRecord
            // 
            this.colDeleteStudentFeeRecord.FieldName = "DeleteStudentFeeRecord";
            this.colDeleteStudentFeeRecord.MinWidth = 25;
            this.colDeleteStudentFeeRecord.Name = "colDeleteStudentFeeRecord";
            this.colDeleteStudentFeeRecord.Visible = true;
            this.colDeleteStudentFeeRecord.VisibleIndex = 9;
            this.colDeleteStudentFeeRecord.Width = 94;
            // 
            // colAddNewScholasticYear
            // 
            this.colAddNewScholasticYear.FieldName = "AddNewScholasticYear";
            this.colAddNewScholasticYear.MinWidth = 25;
            this.colAddNewScholasticYear.Name = "colAddNewScholasticYear";
            this.colAddNewScholasticYear.Visible = true;
            this.colAddNewScholasticYear.VisibleIndex = 10;
            this.colAddNewScholasticYear.Width = 94;
            // 
            // colManageScholasticYears
            // 
            this.colManageScholasticYears.FieldName = "ManageScholasticYears";
            this.colManageScholasticYears.MinWidth = 25;
            this.colManageScholasticYears.Name = "colManageScholasticYears";
            this.colManageScholasticYears.Visible = true;
            this.colManageScholasticYears.VisibleIndex = 11;
            this.colManageScholasticYears.Width = 94;
            // 
            // colAddNewFeePeriod
            // 
            this.colAddNewFeePeriod.FieldName = "AddNewFeePeriod";
            this.colAddNewFeePeriod.MinWidth = 25;
            this.colAddNewFeePeriod.Name = "colAddNewFeePeriod";
            this.colAddNewFeePeriod.Visible = true;
            this.colAddNewFeePeriod.VisibleIndex = 12;
            this.colAddNewFeePeriod.Width = 94;
            // 
            // colManageFeePeriods
            // 
            this.colManageFeePeriods.FieldName = "ManageFeePeriods";
            this.colManageFeePeriods.MinWidth = 25;
            this.colManageFeePeriods.Name = "colManageFeePeriods";
            this.colManageFeePeriods.Visible = true;
            this.colManageFeePeriods.VisibleIndex = 13;
            this.colManageFeePeriods.Width = 94;
            // 
            // colExportAllData
            // 
            this.colExportAllData.FieldName = "ExportAllData";
            this.colExportAllData.MinWidth = 25;
            this.colExportAllData.Name = "colExportAllData";
            this.colExportAllData.Visible = true;
            this.colExportAllData.VisibleIndex = 14;
            this.colExportAllData.Width = 94;
            // 
            // colImportAllData
            // 
            this.colImportAllData.FieldName = "ImportAllData";
            this.colImportAllData.MinWidth = 25;
            this.colImportAllData.Name = "colImportAllData";
            this.colImportAllData.Visible = true;
            this.colImportAllData.VisibleIndex = 15;
            this.colImportAllData.Width = 94;
            // 
            // colManageUsers
            // 
            this.colManageUsers.FieldName = "ManageUsers";
            this.colManageUsers.MinWidth = 25;
            this.colManageUsers.Name = "colManageUsers";
            this.colManageUsers.Visible = true;
            this.colManageUsers.VisibleIndex = 16;
            this.colManageUsers.Width = 94;
            // 
            // colPromoteDb
            // 
            this.colPromoteDb.FieldName = "PromoteDb";
            this.colPromoteDb.MinWidth = 25;
            this.colPromoteDb.Name = "colPromoteDb";
            this.colPromoteDb.Visible = true;
            this.colPromoteDb.VisibleIndex = 17;
            this.colPromoteDb.Width = 94;
            // 
            // colBackupDb
            // 
            this.colBackupDb.FieldName = "BackupDb";
            this.colBackupDb.MinWidth = 25;
            this.colBackupDb.Name = "colBackupDb";
            this.colBackupDb.Visible = true;
            this.colBackupDb.VisibleIndex = 18;
            this.colBackupDb.Width = 94;
            // 
            // colRestoreDb
            // 
            this.colRestoreDb.FieldName = "RestoreDb";
            this.colRestoreDb.MinWidth = 25;
            this.colRestoreDb.Name = "colRestoreDb";
            this.colRestoreDb.Visible = true;
            this.colRestoreDb.VisibleIndex = 19;
            this.colRestoreDb.Width = 94;
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
            // userRoleTblTableAdapter
            // 
            this.userRoleTblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EducationalLevelTblTableAdapter = null;
            this.tableAdapterManager.FeePeriodTblTableAdapter = null;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.ScholasticYearTblTableAdapter = null;
            this.tableAdapterManager.StudentFeeTblTableAdapter = null;
            this.tableAdapterManager.StudentTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kindergarten.KindergartenDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTblTableAdapter = this.userRoleTblTableAdapter;
            this.tableAdapterManager.UserTblTableAdapter = null;
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
            ((System.ComponentModel.ISupportInitialize)(this.userRoleGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleTblBindingNavigator)).EndInit();
            this.userRoleTblBindingNavigator.ResumeLayout(false);
            this.userRoleTblBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
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
        private KindergartenDbDataSet kindergartenDbDataSet;
        private System.Windows.Forms.BindingSource userRoleTblBindingSource;
        private KindergartenDbDataSetTableAdapters.UserRoleTblTableAdapter userRoleTblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewStudent;
        private DevExpress.XtraGrid.Columns.GridColumn colManageStudentTbl;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateExistedStudent;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleteStudentRecord;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewStudentFee;
        private DevExpress.XtraGrid.Columns.GridColumn colManageStudentFeeTbl;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateExistedStudentFee;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleteStudentFeeRecord;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewScholasticYear;
        private DevExpress.XtraGrid.Columns.GridColumn colManageScholasticYears;
        private DevExpress.XtraGrid.Columns.GridColumn colAddNewFeePeriod;
        private DevExpress.XtraGrid.Columns.GridColumn colManageFeePeriods;
        private DevExpress.XtraGrid.Columns.GridColumn colExportAllData;
        private DevExpress.XtraGrid.Columns.GridColumn colImportAllData;
        private DevExpress.XtraGrid.Columns.GridColumn colManageUsers;
        private DevExpress.XtraGrid.Columns.GridColumn colPromoteDb;
        private DevExpress.XtraGrid.Columns.GridColumn colBackupDb;
        private DevExpress.XtraGrid.Columns.GridColumn colRestoreDb;
        private KindergartenDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}