
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageFinancialItemCategoryTblForm));
            this.financialItemCategoryGridControl = new DevExpress.XtraGrid.GridControl();
            this.financialItemCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.financialItemCategoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinancialItemCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinancialItemCategoryDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsIncomingOrOutgiung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.financialItemCategoryTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.FinancialItemCategoryTblTableAdapter();
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
            this.financialItemCategoryTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.financialItemCategoryTblBindingNavigatorExportToExcelItem = new System.Windows.Forms.ToolStripButton();
            this.colGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingNavigator)).BeginInit();
            this.financialItemCategoryTblBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // financialItemCategoryGridControl
            // 
            this.financialItemCategoryGridControl.DataSource = this.financialItemCategoryTblBindingSource;
            this.financialItemCategoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "financialItemCategoryLevel";
            this.financialItemCategoryGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.financialItemCategoryGridControl.Location = new System.Drawing.Point(0, 47);
            this.financialItemCategoryGridControl.MainView = this.financialItemCategoryGridView;
            this.financialItemCategoryGridControl.Name = "financialItemCategoryGridControl";
            this.financialItemCategoryGridControl.Size = new System.Drawing.Size(1211, 735);
            this.financialItemCategoryGridControl.TabIndex = 5;
            this.financialItemCategoryGridControl.UseEmbeddedNavigator = true;
            this.financialItemCategoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.financialItemCategoryGridView});
            // 
            // financialItemCategoryTblBindingSource
            // 
            this.financialItemCategoryTblBindingSource.DataMember = "FinancialItemCategoryTbl";
            this.financialItemCategoryTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // financialItemCategoryGridView
            // 
            this.financialItemCategoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFinancialItemCategoryName,
            this.colFinancialItemCategoryDetails,
            this.colIsIncomingOrOutgiung,
            this.colGroupName});
            this.financialItemCategoryGridView.GridControl = this.financialItemCategoryGridControl;
            this.financialItemCategoryGridView.Name = "financialItemCategoryGridView";
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
            // colIsIncomingOrOutgiung
            // 
            this.colIsIncomingOrOutgiung.Caption = "صادر أم وارد";
            this.colIsIncomingOrOutgiung.FieldName = "IsIncomingOrOutgiung";
            this.colIsIncomingOrOutgiung.MinWidth = 120;
            this.colIsIncomingOrOutgiung.Name = "colIsIncomingOrOutgiung";
            this.colIsIncomingOrOutgiung.Visible = true;
            this.colIsIncomingOrOutgiung.VisibleIndex = 2;
            this.colIsIncomingOrOutgiung.Width = 120;
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
            this.tableAdapterManager.FinancialItemCategoryTblTableAdapter = this.financialItemCategoryTblTableAdapter;
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
            this.tableAdapterManager.UserLoginTblTableAdapter = null;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // financialItemCategoryTblTableAdapter
            // 
            this.financialItemCategoryTblTableAdapter.ClearBeforeFill = true;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 44);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // financialItemCategoryTblBindingNavigatorSaveItem
            // 
            this.financialItemCategoryTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.financialItemCategoryTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("financialItemCategoryTblBindingNavigatorSaveItem.Image")));
            this.financialItemCategoryTblBindingNavigatorSaveItem.Name = "financialItemCategoryTblBindingNavigatorSaveItem";
            this.financialItemCategoryTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(44, 44);
            this.financialItemCategoryTblBindingNavigatorSaveItem.Text = "حفظ التعديلات";
            this.financialItemCategoryTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.financialItemCategoryTblBindingNavigatorSaveItem_Click);
            // 
            // financialItemCategoryTblBindingNavigator
            // 
            this.financialItemCategoryTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.financialItemCategoryTblBindingNavigator.BindingSource = this.financialItemCategoryTblBindingSource;
            this.financialItemCategoryTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.financialItemCategoryTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.financialItemCategoryTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.financialItemCategoryTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.financialItemCategoryTblBindingNavigatorSaveItem,
            this.financialItemCategoryTblBindingNavigatorExportToExcelItem});
            this.financialItemCategoryTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.financialItemCategoryTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.financialItemCategoryTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.financialItemCategoryTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.financialItemCategoryTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.financialItemCategoryTblBindingNavigator.Name = "financialItemCategoryTblBindingNavigator";
            this.financialItemCategoryTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.financialItemCategoryTblBindingNavigator.Size = new System.Drawing.Size(1211, 47);
            this.financialItemCategoryTblBindingNavigator.TabIndex = 4;
            this.financialItemCategoryTblBindingNavigator.Text = "bindingNavigator1";
            // 
            // financialItemCategoryTblBindingNavigatorExportToExcelItem
            // 
            this.financialItemCategoryTblBindingNavigatorExportToExcelItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.financialItemCategoryTblBindingNavigatorExportToExcelItem.Image = global::AssetManagement.Properties.Resources._3643517;
            this.financialItemCategoryTblBindingNavigatorExportToExcelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.financialItemCategoryTblBindingNavigatorExportToExcelItem.Name = "financialItemCategoryTblBindingNavigatorExportToExcelItem";
            this.financialItemCategoryTblBindingNavigatorExportToExcelItem.Size = new System.Drawing.Size(44, 44);
            this.financialItemCategoryTblBindingNavigatorExportToExcelItem.Text = "تصدير إلى إكسل";
            this.financialItemCategoryTblBindingNavigatorExportToExcelItem.Click += new System.EventHandler(this.financialItemCategoryTblBindingNavigatorExportToExcelItem_Click);
            // 
            // colGroupName
            // 
            this.colGroupName.Caption = "اسم المجموعة التي يندرج تحتها البند المالي";
            this.colGroupName.FieldName = "GroupName";
            this.colGroupName.MinWidth = 150;
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.Visible = true;
            this.colGroupName.VisibleIndex = 3;
            this.colGroupName.Width = 150;
            // 
            // ManageFinancialItemCategoryTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 782);
            this.Controls.Add(this.financialItemCategoryGridControl);
            this.Controls.Add(this.financialItemCategoryTblBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageFinancialItemCategoryTblForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة جدول البنود المالية";
            this.Load += new System.EventHandler(this.ManageFinancialItemCategoryTblForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingNavigator)).EndInit();
            this.financialItemCategoryTblBindingNavigator.ResumeLayout(false);
            this.financialItemCategoryTblBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AssetMngDbDataSet assetMngDbDataSet;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private DevExpress.XtraGrid.GridControl financialItemCategoryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView financialItemCategoryGridView;
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
        private System.Windows.Forms.BindingNavigator financialItemCategoryTblBindingNavigator;
        private DevExpress.XtraGrid.Columns.GridColumn colIsIncomingOrOutgiung;
        private System.Windows.Forms.ToolStripButton financialItemCategoryTblBindingNavigatorExportToExcelItem;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupName;
    }
}