
namespace AssetManagement.AuxTables
{
    partial class ManageOutgoingTypeTblForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageIncomingTypeTblForm));
            this.incomingTypeGridControl = new DevExpress.XtraGrid.GridControl();
            this.incomingTypeTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.incomingTypeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncomingTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncomingTypeDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.incomingTypeTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.IncomingTypeTblTableAdapter();
            this.incomingTypeTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.incomingTypeTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.incomingTypeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomingTypeTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomingTypeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomingTypeTblBindingNavigator)).BeginInit();
            this.incomingTypeTblBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // incomingTypeGridControl
            // 
            this.incomingTypeGridControl.DataSource = this.incomingTypeTblBindingSource;
            this.incomingTypeGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.RelationName = "incomingTypeLevel";
            this.incomingTypeGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.incomingTypeGridControl.Location = new System.Drawing.Point(0, 47);
            this.incomingTypeGridControl.MainView = this.incomingTypeGridView;
            this.incomingTypeGridControl.Name = "incomingTypeGridControl";
            this.incomingTypeGridControl.Size = new System.Drawing.Size(910, 526);
            this.incomingTypeGridControl.TabIndex = 5;
            this.incomingTypeGridControl.UseEmbeddedNavigator = true;
            this.incomingTypeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.incomingTypeGridView});
            // 
            // incomingTypeTblBindingSource
            // 
            this.incomingTypeTblBindingSource.DataMember = "IncomingTypeTbl";
            this.incomingTypeTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incomingTypeGridView
            // 
            this.incomingTypeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colIncomingTypeName,
            this.colIncomingTypeDescription});
            this.incomingTypeGridView.GridControl = this.incomingTypeGridControl;
            this.incomingTypeGridView.Name = "incomingTypeGridView";
            // 
            // colID
            // 
            this.colID.Caption = "معرف جهة الإيراد";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 100;
            this.colID.Name = "colID";
            this.colID.Width = 100;
            // 
            // colIncomingTypeName
            // 
            this.colIncomingTypeName.Caption = "اسم جهة الإيراد";
            this.colIncomingTypeName.FieldName = "IncomingTypeName";
            this.colIncomingTypeName.MinWidth = 150;
            this.colIncomingTypeName.Name = "colIncomingTypeName";
            this.colIncomingTypeName.Visible = true;
            this.colIncomingTypeName.VisibleIndex = 0;
            this.colIncomingTypeName.Width = 150;
            // 
            // colIncomingTypeDescription
            // 
            this.colIncomingTypeDescription.Caption = "وصف جهة الإيراد";
            this.colIncomingTypeDescription.FieldName = "IncomingTypeDescription";
            this.colIncomingTypeDescription.MinWidth = 200;
            this.colIncomingTypeDescription.Name = "colIncomingTypeDescription";
            this.colIncomingTypeDescription.Visible = true;
            this.colIncomingTypeDescription.VisibleIndex = 1;
            this.colIncomingTypeDescription.Width = 200;
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
            this.tableAdapterManager.IncomingTypeTblTableAdapter = this.incomingTypeTblTableAdapter;
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
            // incomingTypeTblTableAdapter
            // 
            this.incomingTypeTblTableAdapter.ClearBeforeFill = true;
            // 
            // incomingTypeTblBindingNavigator
            // 
            this.incomingTypeTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.incomingTypeTblBindingNavigator.BindingSource = this.incomingTypeTblBindingSource;
            this.incomingTypeTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.incomingTypeTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.incomingTypeTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.incomingTypeTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.incomingTypeTblBindingNavigatorSaveItem});
            this.incomingTypeTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.incomingTypeTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.incomingTypeTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.incomingTypeTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.incomingTypeTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.incomingTypeTblBindingNavigator.Name = "incomingTypeTblBindingNavigator";
            this.incomingTypeTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.incomingTypeTblBindingNavigator.Size = new System.Drawing.Size(910, 47);
            this.incomingTypeTblBindingNavigator.TabIndex = 4;
            this.incomingTypeTblBindingNavigator.Text = "bindingNavigator1";
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
            // incomingTypeTblBindingNavigatorSaveItem
            // 
            this.incomingTypeTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.incomingTypeTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("incomingTypeTblBindingNavigatorSaveItem.Image")));
            this.incomingTypeTblBindingNavigatorSaveItem.Name = "incomingTypeTblBindingNavigatorSaveItem";
            this.incomingTypeTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(44, 44);
            this.incomingTypeTblBindingNavigatorSaveItem.Text = "Save Data";
            this.incomingTypeTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.incomingTypeTblBindingNavigatorSaveItem_Click);
            // 
            // ManageIncomingTypeTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 573);
            this.Controls.Add(this.incomingTypeGridControl);
            this.Controls.Add(this.incomingTypeTblBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageIncomingTypeTblForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة جدول جهات الإيراد";
            this.Load += new System.EventHandler(this.ManageOutgoingTypeTblForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incomingTypeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomingTypeTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomingTypeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomingTypeTblBindingNavigator)).EndInit();
            this.incomingTypeTblBindingNavigator.ResumeLayout(false);
            this.incomingTypeTblBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AssetMngDbDataSet assetMngDbDataSet;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator incomingTypeTblBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton incomingTypeTblBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl incomingTypeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView incomingTypeGridView;
        private System.Windows.Forms.BindingSource incomingTypeTblBindingSource;
        private AssetMngDbDataSetTableAdapters.IncomingTypeTblTableAdapter incomingTypeTblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIncomingTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colIncomingTypeDescription;
    }
}