
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOutgoingTypeTblForm));
            this.outgoingTypeGridControl = new DevExpress.XtraGrid.GridControl();
            this.outgoingTypeTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.outgoingTypeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.outgoingTypeTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.OutgoingTypeTblTableAdapter();
            this.outgoingTypeTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.outgoingTypeTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutgoingTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutgoingTypeDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.outgoingTypeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outgoingTypeTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outgoingTypeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outgoingTypeTblBindingNavigator)).BeginInit();
            this.outgoingTypeTblBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // outgoingTypeGridControl
            // 
            this.outgoingTypeGridControl.DataSource = this.outgoingTypeTblBindingSource;
            this.outgoingTypeGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "outgoingTypeLevel";
            this.outgoingTypeGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.outgoingTypeGridControl.Location = new System.Drawing.Point(0, 47);
            this.outgoingTypeGridControl.MainView = this.outgoingTypeGridView;
            this.outgoingTypeGridControl.Name = "outgoingTypeGridControl";
            this.outgoingTypeGridControl.Size = new System.Drawing.Size(910, 526);
            this.outgoingTypeGridControl.TabIndex = 5;
            this.outgoingTypeGridControl.UseEmbeddedNavigator = true;
            this.outgoingTypeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.outgoingTypeGridView});
            // 
            // outgoingTypeTblBindingSource
            // 
            this.outgoingTypeTblBindingSource.DataMember = "OutgoingTypeTbl";
            this.outgoingTypeTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // outgoingTypeGridView
            // 
            this.outgoingTypeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colOutgoingTypeName,
            this.colOutgoingTypeDescription});
            this.outgoingTypeGridView.GridControl = this.outgoingTypeGridControl;
            this.outgoingTypeGridView.Name = "outgoingTypeGridView";
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
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.OutgoingTypeTblTableAdapter = this.outgoingTypeTblTableAdapter;
            this.tableAdapterManager.SectionTblTableAdapter = null;
            this.tableAdapterManager.SquareTblTableAdapter = null;
            this.tableAdapterManager.StatusTblTableAdapter = null;
            this.tableAdapterManager.SubDepartmentTblTableAdapter = null;
            this.tableAdapterManager.TransactionTypeTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // outgoingTypeTblTableAdapter
            // 
            this.outgoingTypeTblTableAdapter.ClearBeforeFill = true;
            // 
            // outgoingTypeTblBindingNavigator
            // 
            this.outgoingTypeTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.outgoingTypeTblBindingNavigator.BindingSource = this.outgoingTypeTblBindingSource;
            this.outgoingTypeTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.outgoingTypeTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.outgoingTypeTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.outgoingTypeTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.outgoingTypeTblBindingNavigatorSaveItem});
            this.outgoingTypeTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.outgoingTypeTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.outgoingTypeTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.outgoingTypeTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.outgoingTypeTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.outgoingTypeTblBindingNavigator.Name = "outgoingTypeTblBindingNavigator";
            this.outgoingTypeTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.outgoingTypeTblBindingNavigator.Size = new System.Drawing.Size(910, 47);
            this.outgoingTypeTblBindingNavigator.TabIndex = 4;
            this.outgoingTypeTblBindingNavigator.Text = "bindingNavigator1";
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
            // outgoingTypeTblBindingNavigatorSaveItem
            // 
            this.outgoingTypeTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.outgoingTypeTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("outgoingTypeTblBindingNavigatorSaveItem.Image")));
            this.outgoingTypeTblBindingNavigatorSaveItem.Name = "outgoingTypeTblBindingNavigatorSaveItem";
            this.outgoingTypeTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(44, 44);
            this.outgoingTypeTblBindingNavigatorSaveItem.Text = "Save Data";
            this.outgoingTypeTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.outgoingTypeTblBindingNavigatorSaveItem_Click);
            // 
            // colID
            // 
            this.colID.Caption = "معرف نوع الصادر";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 100;
            this.colID.Name = "colID";
            this.colID.Width = 100;
            // 
            // colOutgoingTypeName
            // 
            this.colOutgoingTypeName.Caption = "اسم نوع الصادر";
            this.colOutgoingTypeName.FieldName = "OutgoingTypeName";
            this.colOutgoingTypeName.MinWidth = 150;
            this.colOutgoingTypeName.Name = "colOutgoingTypeName";
            this.colOutgoingTypeName.Visible = true;
            this.colOutgoingTypeName.VisibleIndex = 0;
            this.colOutgoingTypeName.Width = 150;
            // 
            // colOutgoingTypeDescription
            // 
            this.colOutgoingTypeDescription.Caption = "وصف نوع الصادر";
            this.colOutgoingTypeDescription.FieldName = "OutgoingTypeDescription";
            this.colOutgoingTypeDescription.MinWidth = 200;
            this.colOutgoingTypeDescription.Name = "colOutgoingTypeDescription";
            this.colOutgoingTypeDescription.Visible = true;
            this.colOutgoingTypeDescription.VisibleIndex = 1;
            this.colOutgoingTypeDescription.Width = 1000;
            // 
            // ManageOutgoingTypeTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 573);
            this.Controls.Add(this.outgoingTypeGridControl);
            this.Controls.Add(this.outgoingTypeTblBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageOutgoingTypeTblForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة جدول أنواع الصادرات";
            this.Load += new System.EventHandler(this.ManageOutgoingTypeTblForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outgoingTypeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outgoingTypeTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outgoingTypeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outgoingTypeTblBindingNavigator)).EndInit();
            this.outgoingTypeTblBindingNavigator.ResumeLayout(false);
            this.outgoingTypeTblBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AssetMngDbDataSet assetMngDbDataSet;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator outgoingTypeTblBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton outgoingTypeTblBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl outgoingTypeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView outgoingTypeGridView;
        private System.Windows.Forms.BindingSource outgoingTypeTblBindingSource;
        private AssetMngDbDataSetTableAdapters.OutgoingTypeTblTableAdapter outgoingTypeTblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colOutgoingTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colOutgoingTypeDescription;
    }
}