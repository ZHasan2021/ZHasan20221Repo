
namespace AssetManagement.AuxTables
{
    partial class ManageImportExportTblForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageImportExportTblForm));
            this.importExportGridControl = new DevExpress.XtraGrid.GridControl();
            this.importExportTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.importExportGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImportOrExport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTablesExported = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActionBySection = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActionByDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActionBySubDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsertedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModifiedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsertedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActionNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sctRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.importExportTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.ImportExportTblTableAdapter();
            this.importExportTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.importExportTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.importExportGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importExportTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importExportGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sctRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importExportTblBindingNavigator)).BeginInit();
            this.importExportTblBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // importExportGridControl
            // 
            this.importExportGridControl.DataSource = this.importExportTblBindingSource;
            this.importExportGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "importExportLevel";
            this.importExportGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.importExportGridControl.Location = new System.Drawing.Point(0, 47);
            this.importExportGridControl.MainView = this.importExportGridView;
            this.importExportGridControl.Name = "importExportGridControl";
            this.importExportGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.sctRepositoryItemLookUpEdit,
            this.repositoryItemMemoEdit1});
            this.importExportGridControl.Size = new System.Drawing.Size(1289, 713);
            this.importExportGridControl.TabIndex = 5;
            this.importExportGridControl.UseEmbeddedNavigator = true;
            this.importExportGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.importExportGridView});
            // 
            // importExportTblBindingSource
            // 
            this.importExportTblBindingSource.DataMember = "ImportExportTbl";
            this.importExportTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // importExportGridView
            // 
            this.importExportGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colImportOrExport,
            this.colActionDate,
            this.colTablesExported,
            this.colActionBySection,
            this.colActionByDepartment,
            this.colActionBySubDepartment,
            this.colInsertedOn,
            this.colLastModifiedOn,
            this.colInsertedBy,
            this.colLastModifiedBy,
            this.colActionNotes});
            this.importExportGridView.GridControl = this.importExportGridControl;
            this.importExportGridView.Name = "importExportGridView";
            this.importExportGridView.OptionsView.RowAutoHeight = true;
            // 
            // colID
            // 
            this.colID.Caption = "معرف السجل";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 100;
            this.colID.Name = "colID";
            this.colID.Width = 80;
            // 
            // colImportOrExport
            // 
            this.colImportOrExport.Caption = "استيراد أم تصدير";
            this.colImportOrExport.FieldName = "ImportOrExport";
            this.colImportOrExport.MinWidth = 150;
            this.colImportOrExport.Name = "colImportOrExport";
            this.colImportOrExport.Visible = true;
            this.colImportOrExport.VisibleIndex = 0;
            this.colImportOrExport.Width = 150;
            // 
            // colActionDate
            // 
            this.colActionDate.Caption = "تاريخ العملية";
            this.colActionDate.FieldName = "ActionDate";
            this.colActionDate.MinWidth = 100;
            this.colActionDate.Name = "colActionDate";
            this.colActionDate.Visible = true;
            this.colActionDate.VisibleIndex = 1;
            this.colActionDate.Width = 100;
            // 
            // colTablesExported
            // 
            this.colTablesExported.Caption = "الجداول المصدرة أو المستوردة";
            this.colTablesExported.FieldName = "TablesExported";
            this.colTablesExported.MinWidth = 200;
            this.colTablesExported.Name = "colTablesExported";
            this.colTablesExported.Visible = true;
            this.colTablesExported.VisibleIndex = 2;
            this.colTablesExported.Width = 200;
            // 
            // colActionBySection
            // 
            this.colActionBySection.Caption = "اسم الدائرة";
            this.colActionBySection.FieldName = "ActionBySection";
            this.colActionBySection.MinWidth = 150;
            this.colActionBySection.Name = "colActionBySection";
            this.colActionBySection.Visible = true;
            this.colActionBySection.VisibleIndex = 3;
            this.colActionBySection.Width = 150;
            // 
            // colActionByDepartment
            // 
            this.colActionByDepartment.Caption = "اسم القسم";
            this.colActionByDepartment.FieldName = "ActionByDepartment";
            this.colActionByDepartment.MinWidth = 150;
            this.colActionByDepartment.Name = "colActionByDepartment";
            this.colActionByDepartment.Visible = true;
            this.colActionByDepartment.VisibleIndex = 4;
            this.colActionByDepartment.Width = 150;
            // 
            // colActionBySubDepartment
            // 
            this.colActionBySubDepartment.Caption = "اسم الوحدة";
            this.colActionBySubDepartment.FieldName = "ActionBySubDepartment";
            this.colActionBySubDepartment.MinWidth = 150;
            this.colActionBySubDepartment.Name = "colActionBySubDepartment";
            this.colActionBySubDepartment.Visible = true;
            this.colActionBySubDepartment.VisibleIndex = 5;
            this.colActionBySubDepartment.Width = 150;
            // 
            // colInsertedOn
            // 
            this.colInsertedOn.Caption = "تاريخ إضافة السجل";
            this.colInsertedOn.FieldName = "InsertedOn";
            this.colInsertedOn.MinWidth = 100;
            this.colInsertedOn.Name = "colInsertedOn";
            this.colInsertedOn.Width = 100;
            // 
            // colLastModifiedOn
            // 
            this.colLastModifiedOn.Caption = "تاريخ آخر تعديل";
            this.colLastModifiedOn.FieldName = "LastModifiedOn";
            this.colLastModifiedOn.MinWidth = 100;
            this.colLastModifiedOn.Name = "colLastModifiedOn";
            this.colLastModifiedOn.Width = 100;
            // 
            // colInsertedBy
            // 
            this.colInsertedBy.Caption = "المستخدم الذي قام بالإضافة";
            this.colInsertedBy.FieldName = "InsertedBy";
            this.colInsertedBy.MinWidth = 100;
            this.colInsertedBy.Name = "colInsertedBy";
            this.colInsertedBy.Width = 100;
            // 
            // colLastModifiedBy
            // 
            this.colLastModifiedBy.Caption = "المستخدم الذي قام بالتعديل";
            this.colLastModifiedBy.FieldName = "LastModifiedBy";
            this.colLastModifiedBy.MinWidth = 100;
            this.colLastModifiedBy.Name = "colLastModifiedBy";
            this.colLastModifiedBy.Width = 100;
            // 
            // colActionNotes
            // 
            this.colActionNotes.Caption = "ملاحظات";
            this.colActionNotes.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colActionNotes.FieldName = "ActionNotes";
            this.colActionNotes.MinWidth = 300;
            this.colActionNotes.Name = "colActionNotes";
            this.colActionNotes.Visible = true;
            this.colActionNotes.VisibleIndex = 6;
            this.colActionNotes.Width = 300;
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
            this.tableAdapterManager.ImportExportTblTableAdapter = this.importExportTblTableAdapter;
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
            this.tableAdapterManager.UserLoginTblTableAdapter = null;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // importExportTblTableAdapter
            // 
            this.importExportTblTableAdapter.ClearBeforeFill = true;
            // 
            // importExportTblBindingNavigator
            // 
            this.importExportTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.importExportTblBindingNavigator.BindingSource = this.importExportTblBindingSource;
            this.importExportTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.importExportTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.importExportTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.importExportTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.importExportTblBindingNavigatorSaveItem});
            this.importExportTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.importExportTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.importExportTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.importExportTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.importExportTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.importExportTblBindingNavigator.Name = "importExportTblBindingNavigator";
            this.importExportTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.importExportTblBindingNavigator.Size = new System.Drawing.Size(1289, 47);
            this.importExportTblBindingNavigator.TabIndex = 4;
            this.importExportTblBindingNavigator.Text = "bindingNavigator1";
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
            // importExportTblBindingNavigatorSaveItem
            // 
            this.importExportTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.importExportTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("importExportTblBindingNavigatorSaveItem.Image")));
            this.importExportTblBindingNavigatorSaveItem.Name = "importExportTblBindingNavigatorSaveItem";
            this.importExportTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(44, 44);
            this.importExportTblBindingNavigatorSaveItem.Text = "Save Data";
            this.importExportTblBindingNavigatorSaveItem.Visible = false;
            this.importExportTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.importExportTblBindingNavigatorSaveItem_Click);
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // ManageImportExportTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 760);
            this.Controls.Add(this.importExportGridControl);
            this.Controls.Add(this.importExportTblBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageImportExportTblForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة سجلات الاستيراد والتصدير";
            this.Load += new System.EventHandler(this.ManageImportExportTblForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.importExportGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importExportTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importExportGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sctRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importExportTblBindingNavigator)).EndInit();
            this.importExportTblBindingNavigator.ResumeLayout(false);
            this.importExportTblBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AssetMngDbDataSet assetMngDbDataSet;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator importExportTblBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton importExportTblBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl importExportGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView importExportGridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit sctRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource importExportTblBindingSource;
        private AssetMngDbDataSetTableAdapters.ImportExportTblTableAdapter importExportTblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colImportOrExport;
        private DevExpress.XtraGrid.Columns.GridColumn colActionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colActionBySection;
        private DevExpress.XtraGrid.Columns.GridColumn colActionByDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colActionBySubDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colInsertedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModifiedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colInsertedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colActionNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colTablesExported;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    }
}