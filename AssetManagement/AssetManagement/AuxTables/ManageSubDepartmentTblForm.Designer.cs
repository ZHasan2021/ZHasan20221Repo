﻿
namespace AssetManagement.AuxTables
{
    partial class ManageSubDepartmentTblForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSubDepartmentTblForm));
            this.subDepartmentGridControl = new DevExpress.XtraGrid.GridControl();
            this.subDepartmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.subDepartmentGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubDepartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMainDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dptRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.departmentVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sctRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.departmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.departmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter();
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.subDepartmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SubDepartmentTblTableAdapter();
            this.subDepartmentTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.subDepartmentTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.departmentVwTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.DepartmentVwTableAdapter();
            this.subDepartmentTblBindingNavigatorExportToExcelItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sctRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingNavigator)).BeginInit();
            this.subDepartmentTblBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // subDepartmentGridControl
            // 
            this.subDepartmentGridControl.DataSource = this.subDepartmentTblBindingSource;
            this.subDepartmentGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "subDepartmentLevel";
            this.subDepartmentGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.subDepartmentGridControl.Location = new System.Drawing.Point(0, 47);
            this.subDepartmentGridControl.MainView = this.subDepartmentGridView;
            this.subDepartmentGridControl.Name = "subDepartmentGridControl";
            this.subDepartmentGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.sctRepositoryItemLookUpEdit,
            this.dptRepositoryItemLookUpEdit});
            this.subDepartmentGridControl.Size = new System.Drawing.Size(1149, 626);
            this.subDepartmentGridControl.TabIndex = 5;
            this.subDepartmentGridControl.UseEmbeddedNavigator = true;
            this.subDepartmentGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.subDepartmentGridView});
            // 
            // subDepartmentTblBindingSource
            // 
            this.subDepartmentTblBindingSource.DataMember = "SubDepartmentTbl";
            this.subDepartmentTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subDepartmentGridView
            // 
            this.subDepartmentGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSubDepartmentName,
            this.colMainDepartment});
            this.subDepartmentGridView.GridControl = this.subDepartmentGridControl;
            this.subDepartmentGridView.Name = "subDepartmentGridView";
            // 
            // colID
            // 
            this.colID.Caption = "معرف الوحدة";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 80;
            this.colID.Name = "colID";
            this.colID.Width = 108;
            // 
            // colSubDepartmentName
            // 
            this.colSubDepartmentName.Caption = "اسم الوحدة";
            this.colSubDepartmentName.FieldName = "SubDepartmentName";
            this.colSubDepartmentName.MinWidth = 150;
            this.colSubDepartmentName.Name = "colSubDepartmentName";
            this.colSubDepartmentName.Visible = true;
            this.colSubDepartmentName.VisibleIndex = 0;
            this.colSubDepartmentName.Width = 178;
            // 
            // colMainDepartment
            // 
            this.colMainDepartment.Caption = "القسم التابعة له";
            this.colMainDepartment.ColumnEdit = this.dptRepositoryItemLookUpEdit;
            this.colMainDepartment.FieldName = "MainDepartment";
            this.colMainDepartment.MinWidth = 150;
            this.colMainDepartment.Name = "colMainDepartment";
            this.colMainDepartment.Visible = true;
            this.colMainDepartment.VisibleIndex = 1;
            this.colMainDepartment.Width = 150;
            // 
            // dptRepositoryItemLookUpEdit
            // 
            this.dptRepositoryItemLookUpEdit.AutoHeight = false;
            this.dptRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dptRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("معرف القسم", "معرف القسم", 120, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("اسم القسم", "اسم القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("الدائرة التي يتبع لها القسم", "الدائرة التي يتبع لها القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.dptRepositoryItemLookUpEdit.DataSource = this.departmentVwBindingSource;
            this.dptRepositoryItemLookUpEdit.DisplayMember = "اسم القسم";
            this.dptRepositoryItemLookUpEdit.Name = "dptRepositoryItemLookUpEdit";
            this.dptRepositoryItemLookUpEdit.PopupWidth = 500;
            this.dptRepositoryItemLookUpEdit.ValueMember = "معرف القسم";
            // 
            // departmentVwBindingSource
            // 
            this.departmentVwBindingSource.DataMember = "DepartmentVw";
            this.departmentVwBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // sctRepositoryItemLookUpEdit
            // 
            this.sctRepositoryItemLookUpEdit.AutoHeight = false;
            this.sctRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sctRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الدائرة", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SectionName", "اسم الدائرة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.sctRepositoryItemLookUpEdit.DisplayMember = "SectionName";
            this.sctRepositoryItemLookUpEdit.Name = "sctRepositoryItemLookUpEdit";
            this.sctRepositoryItemLookUpEdit.PopupWidth = 500;
            this.sctRepositoryItemLookUpEdit.ValueMember = "ID";
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
            // departmentTblTableAdapter
            // 
            this.departmentTblTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SubDepartmentTblTableAdapter = this.subDepartmentTblTableAdapter;
            this.tableAdapterManager.TransactionTypeTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserLoginTblTableAdapter = null;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // subDepartmentTblTableAdapter
            // 
            this.subDepartmentTblTableAdapter.ClearBeforeFill = true;
            // 
            // subDepartmentTblBindingNavigator
            // 
            this.subDepartmentTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.subDepartmentTblBindingNavigator.BindingSource = this.subDepartmentTblBindingSource;
            this.subDepartmentTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.subDepartmentTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.subDepartmentTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.subDepartmentTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.subDepartmentTblBindingNavigatorSaveItem,
            this.subDepartmentTblBindingNavigatorExportToExcelItem});
            this.subDepartmentTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.subDepartmentTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.subDepartmentTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.subDepartmentTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.subDepartmentTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.subDepartmentTblBindingNavigator.Name = "subDepartmentTblBindingNavigator";
            this.subDepartmentTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.subDepartmentTblBindingNavigator.Size = new System.Drawing.Size(1149, 47);
            this.subDepartmentTblBindingNavigator.TabIndex = 4;
            this.subDepartmentTblBindingNavigator.Text = "bindingNavigator1";
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
            // subDepartmentTblBindingNavigatorSaveItem
            // 
            this.subDepartmentTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.subDepartmentTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("subDepartmentTblBindingNavigatorSaveItem.Image")));
            this.subDepartmentTblBindingNavigatorSaveItem.Name = "subDepartmentTblBindingNavigatorSaveItem";
            this.subDepartmentTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(44, 44);
            this.subDepartmentTblBindingNavigatorSaveItem.Text = "Save Data";
            this.subDepartmentTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.subDepartmentTblBindingNavigatorSaveItem_Click);
            // 
            // departmentVwTableAdapter
            // 
            this.departmentVwTableAdapter.ClearBeforeFill = true;
            // 
            // subDepartmentTblBindingNavigatorExportToExcelItem
            // 
            this.subDepartmentTblBindingNavigatorExportToExcelItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.subDepartmentTblBindingNavigatorExportToExcelItem.Image = global::AssetManagement.Properties.Resources._36435172;
            this.subDepartmentTblBindingNavigatorExportToExcelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.subDepartmentTblBindingNavigatorExportToExcelItem.Name = "subDepartmentTblBindingNavigatorExportToExcelItem";
            this.subDepartmentTblBindingNavigatorExportToExcelItem.Size = new System.Drawing.Size(44, 44);
            this.subDepartmentTblBindingNavigatorExportToExcelItem.Text = "تصدير إلى إكسل";
            this.subDepartmentTblBindingNavigatorExportToExcelItem.Click += new System.EventHandler(this.subDepartmentTblBindingNavigatorExportToExcelItem_Click);
            // 
            // ManageSubDepartmentTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 673);
            this.Controls.Add(this.subDepartmentGridControl);
            this.Controls.Add(this.subDepartmentTblBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageSubDepartmentTblForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة جدول الوحدات";
            this.Load += new System.EventHandler(this.ManageSubDepartmentTblForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sctRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingNavigator)).EndInit();
            this.subDepartmentTblBindingNavigator.ResumeLayout(false);
            this.subDepartmentTblBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AssetMngDbDataSet assetMngDbDataSet;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private System.Windows.Forms.BindingSource departmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter departmentTblTableAdapter;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator subDepartmentTblBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton subDepartmentTblBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl subDepartmentGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView subDepartmentGridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit sctRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource subDepartmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SubDepartmentTblTableAdapter subDepartmentTblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSubDepartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colMainDepartment;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit dptRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource departmentVwBindingSource;
        private AssetMngDbDataSetTableAdapters.DepartmentVwTableAdapter departmentVwTableAdapter;
        private System.Windows.Forms.ToolStripButton subDepartmentTblBindingNavigatorExportToExcelItem;
    }
}