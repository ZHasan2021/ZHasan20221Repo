
namespace AssetManagement.AuxTables
{
    partial class ManageFinancialItemCategoryTblForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageFinancialItemCategoryTblForm));
            this.minorCategoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.financialItemCategoryGridControl = new DevExpress.XtraGrid.GridControl();
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.currencyGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.financialItemCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialItemCategoryTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.FinancialItemCategoryTblTableAdapter();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinancialItemCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinancialItemCategoryDetails = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.financialItemCategoryTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.currencyTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingNavigator)).BeginInit();
            this.currencyTblBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // minorCategoryGridView
            // 
            this.minorCategoryGridView.GridControl = this.financialItemCategoryGridControl;
            this.minorCategoryGridView.Name = "minorCategoryGridView";
            // 
            // financialItemCategoryGridControl
            // 
            this.financialItemCategoryGridControl.DataSource = this.financialItemCategoryTblBindingSource;
            this.financialItemCategoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.LevelTemplate = this.minorCategoryGridView;
            gridLevelNode2.RelationName = "currencyLevel";
            this.financialItemCategoryGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.financialItemCategoryGridControl.Location = new System.Drawing.Point(0, 27);
            this.financialItemCategoryGridControl.MainView = this.currencyGridView;
            this.financialItemCategoryGridControl.Name = "financialItemCategoryGridControl";
            this.financialItemCategoryGridControl.Size = new System.Drawing.Size(910, 546);
            this.financialItemCategoryGridControl.TabIndex = 5;
            this.financialItemCategoryGridControl.UseEmbeddedNavigator = true;
            this.financialItemCategoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.currencyGridView,
            this.minorCategoryGridView});
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // currencyGridView
            // 
            this.currencyGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFinancialItemCategoryName,
            this.colFinancialItemCategoryDetails});
            this.currencyGridView.GridControl = this.financialItemCategoryGridControl;
            this.currencyGridView.Name = "currencyGridView";
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
            this.tableAdapterManager.DepartmentTblTableAdapter = null;
            this.tableAdapterManager.EstateAreaUnitTblTableAdapter = null;
            this.tableAdapterManager.FinancialItemCategoryTblTableAdapter = this.financialItemCategoryTblTableAdapter;
            this.tableAdapterManager.FinancialItemTblTableAdapter = null;
            this.tableAdapterManager.MainCategoryTblTableAdapter = null;
            this.tableAdapterManager.MinorCategoryTblTableAdapter = null;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.SectionTblTableAdapter = null;
            this.tableAdapterManager.SquareTblTableAdapter = null;
            this.tableAdapterManager.StatusTblTableAdapter = null;
            this.tableAdapterManager.TransactionTypeTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // financialItemCategoryTblBindingSource
            // 
            this.financialItemCategoryTblBindingSource.DataMember = "FinancialItemCategoryTbl";
            this.financialItemCategoryTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // financialItemCategoryTblTableAdapter
            // 
            this.financialItemCategoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // colID
            // 
            this.colID.Caption = "معرف البند المالي";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 80;
            this.colID.Name = "colID";
            this.colID.Width = 94;
            // 
            // colFinancialItemCategoryName
            // 
            this.colFinancialItemCategoryName.Caption = "اسم البند المالي";
            this.colFinancialItemCategoryName.FieldName = "FinancialItemCategoryName";
            this.colFinancialItemCategoryName.MinWidth = 150;
            this.colFinancialItemCategoryName.Name = "colFinancialItemCategoryName";
            this.colFinancialItemCategoryName.Visible = true;
            this.colFinancialItemCategoryName.VisibleIndex = 0;
            this.colFinancialItemCategoryName.Width = 178;
            // 
            // colFinancialItemCategoryDetails
            // 
            this.colFinancialItemCategoryDetails.Caption = "وصف البند المالي";
            this.colFinancialItemCategoryDetails.FieldName = "FinancialItemCategoryDetails";
            this.colFinancialItemCategoryDetails.MinWidth = 200;
            this.colFinancialItemCategoryDetails.Name = "colFinancialItemCategoryDetails";
            this.colFinancialItemCategoryDetails.Visible = true;
            this.colFinancialItemCategoryDetails.VisibleIndex = 1;
            this.colFinancialItemCategoryDetails.Width = 200;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // financialItemCategoryTblBindingNavigatorSaveItem
            // 
            this.financialItemCategoryTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.financialItemCategoryTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("financialItemCategoryTblBindingNavigatorSaveItem.Image")));
            this.financialItemCategoryTblBindingNavigatorSaveItem.Name = "financialItemCategoryTblBindingNavigatorSaveItem";
            this.financialItemCategoryTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.financialItemCategoryTblBindingNavigatorSaveItem.Text = "Save Data";
            this.financialItemCategoryTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.financialItemCategoryTblBindingNavigatorSaveItem_Click);
            // 
            // currencyTblBindingNavigator
            // 
            this.currencyTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.currencyTblBindingNavigator.BindingSource = this.financialItemCategoryTblBindingSource;
            this.currencyTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.currencyTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.currencyTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.currencyTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.financialItemCategoryTblBindingNavigatorSaveItem});
            this.currencyTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.currencyTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.currencyTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.currencyTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.currencyTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.currencyTblBindingNavigator.Name = "currencyTblBindingNavigator";
            this.currencyTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.currencyTblBindingNavigator.Size = new System.Drawing.Size(910, 27);
            this.currencyTblBindingNavigator.TabIndex = 4;
            this.currencyTblBindingNavigator.Text = "bindingNavigator1";
            // 
            // ManageFinancialItemCategoryTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 573);
            this.Controls.Add(this.financialItemCategoryGridControl);
            this.Controls.Add(this.currencyTblBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageFinancialItemCategoryTblForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة جدول البنود المالية";
            this.Load += new System.EventHandler(this.ManageFinancialItemCategoryTblForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingNavigator)).EndInit();
            this.currencyTblBindingNavigator.ResumeLayout(false);
            this.currencyTblBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AssetMngDbDataSet assetMngDbDataSet;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private DevExpress.XtraGrid.GridControl financialItemCategoryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView minorCategoryGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView currencyGridView;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource financialItemCategoryTblBindingSource;
        private AssetMngDbDataSetTableAdapters.FinancialItemCategoryTblTableAdapter financialItemCategoryTblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFinancialItemCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colFinancialItemCategoryDetails;
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
        private System.Windows.Forms.ToolStripButton financialItemCategoryTblBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator currencyTblBindingNavigator;
    }
}