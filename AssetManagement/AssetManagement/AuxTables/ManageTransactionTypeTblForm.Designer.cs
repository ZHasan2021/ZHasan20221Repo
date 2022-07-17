
namespace AssetManagement.AuxTables
{
    partial class ManageTransactionTypeTblForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTransactionTypeTblForm));
            this.minorCategoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.transactionTypeGridControl = new DevExpress.XtraGrid.GridControl();
            this.transactionTypeTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.transactionTypeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.transactionTypeTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.TransactionTypeTblTableAdapter();
            this.transactionTypeTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.transactionTypeTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeTblBindingNavigator)).BeginInit();
            this.transactionTypeTblBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // minorCategoryGridView
            // 
            this.minorCategoryGridView.GridControl = this.transactionTypeGridControl;
            this.minorCategoryGridView.Name = "minorCategoryGridView";
            // 
            // transactionTypeGridControl
            // 
            this.transactionTypeGridControl.DataSource = this.transactionTypeTblBindingSource;
            this.transactionTypeGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.minorCategoryGridView;
            gridLevelNode1.RelationName = "transactionTypeLevel";
            this.transactionTypeGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.transactionTypeGridControl.Location = new System.Drawing.Point(0, 27);
            this.transactionTypeGridControl.MainView = this.transactionTypeGridView;
            this.transactionTypeGridControl.Name = "transactionTypeGridControl";
            this.transactionTypeGridControl.Size = new System.Drawing.Size(910, 546);
            this.transactionTypeGridControl.TabIndex = 5;
            this.transactionTypeGridControl.UseEmbeddedNavigator = true;
            this.transactionTypeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.transactionTypeGridView,
            this.minorCategoryGridView});
            // 
            // transactionTypeTblBindingSource
            // 
            this.transactionTypeTblBindingSource.DataMember = "TransactionTypeTbl";
            this.transactionTypeTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionTypeGridView
            // 
            this.transactionTypeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTransactionTypeName});
            this.transactionTypeGridView.GridControl = this.transactionTypeGridControl;
            this.transactionTypeGridView.Name = "transactionTypeGridView";
            // 
            // colID
            // 
            this.colID.Caption = "معرف نمط تصريف الأصل";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 80;
            this.colID.Name = "colID";
            this.colID.Width = 80;
            // 
            // colTransactionTypeName
            // 
            this.colTransactionTypeName.Caption = "اسم نمط تصريف الأصل";
            this.colTransactionTypeName.FieldName = "TransactionTypeName";
            this.colTransactionTypeName.MinWidth = 25;
            this.colTransactionTypeName.Name = "colTransactionTypeName";
            this.colTransactionTypeName.Visible = true;
            this.colTransactionTypeName.VisibleIndex = 0;
            this.colTransactionTypeName.Width = 150;
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
            this.tableAdapterManager.MainCategoryTblTableAdapter = null;
            this.tableAdapterManager.MinorCategoryTblTableAdapter = null;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.SectionTblTableAdapter = null;
            this.tableAdapterManager.SquareTblTableAdapter = null;
            this.tableAdapterManager.StatusTblTableAdapter = null;
            this.tableAdapterManager.TransactionTypeTblTableAdapter = this.transactionTypeTblTableAdapter;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // transactionTypeTblTableAdapter
            // 
            this.transactionTypeTblTableAdapter.ClearBeforeFill = true;
            // 
            // transactionTypeTblBindingNavigator
            // 
            this.transactionTypeTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.transactionTypeTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.transactionTypeTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.transactionTypeTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.transactionTypeTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.transactionTypeTblBindingNavigatorSaveItem});
            this.transactionTypeTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.transactionTypeTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.transactionTypeTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.transactionTypeTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.transactionTypeTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.transactionTypeTblBindingNavigator.Name = "transactionTypeTblBindingNavigator";
            this.transactionTypeTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.transactionTypeTblBindingNavigator.Size = new System.Drawing.Size(910, 27);
            this.transactionTypeTblBindingNavigator.TabIndex = 4;
            this.transactionTypeTblBindingNavigator.Text = "bindingNavigator1";
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
            // transactionTypeTblBindingNavigatorSaveItem
            // 
            this.transactionTypeTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.transactionTypeTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("transactionTypeTblBindingNavigatorSaveItem.Image")));
            this.transactionTypeTblBindingNavigatorSaveItem.Name = "transactionTypeTblBindingNavigatorSaveItem";
            this.transactionTypeTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.transactionTypeTblBindingNavigatorSaveItem.Text = "Save Data";
            this.transactionTypeTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.transactionTypeTblBindingNavigatorSaveItem_Click);
            // 
            // ManageTransactionTypeTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 573);
            this.Controls.Add(this.transactionTypeGridControl);
            this.Controls.Add(this.transactionTypeTblBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageTransactionTypeTblForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة جدول أنماط تصريف الأصول";
            this.Load += new System.EventHandler(this.ManageTransactionTypeTblForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeTblBindingNavigator)).EndInit();
            this.transactionTypeTblBindingNavigator.ResumeLayout(false);
            this.transactionTypeTblBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AssetMngDbDataSet assetMngDbDataSet;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator transactionTypeTblBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton transactionTypeTblBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl transactionTypeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView minorCategoryGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView transactionTypeGridView;
        private System.Windows.Forms.BindingSource transactionTypeTblBindingSource;
        private AssetMngDbDataSetTableAdapters.TransactionTypeTblTableAdapter transactionTypeTblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionTypeName;
    }
}