
namespace AssetManagement.AuxTables
{
    partial class ManageMainCategoryTblForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMainCategoryTblForm));
            this.mainCategoryGridControl = new DevExpress.XtraGrid.GridControl();
            this.mainCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.mainCategoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMainCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMainCategoryDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.mainCategoryTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.MainCategoryTblTableAdapter();
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
            this.mainCategoryTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mainCategoryTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.manageMinorCategoryTblToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addAllMicaToFicaToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryTblBindingNavigator)).BeginInit();
            this.mainCategoryTblBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainCategoryGridControl
            // 
            this.mainCategoryGridControl.DataSource = this.mainCategoryTblBindingSource;
            this.mainCategoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "mainCategoryLevel";
            this.mainCategoryGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.mainCategoryGridControl.Location = new System.Drawing.Point(0, 47);
            this.mainCategoryGridControl.MainView = this.mainCategoryGridView;
            this.mainCategoryGridControl.Name = "mainCategoryGridControl";
            this.mainCategoryGridControl.Size = new System.Drawing.Size(1180, 623);
            this.mainCategoryGridControl.TabIndex = 5;
            this.mainCategoryGridControl.UseEmbeddedNavigator = true;
            this.mainCategoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mainCategoryGridView});
            // 
            // mainCategoryTblBindingSource
            // 
            this.mainCategoryTblBindingSource.DataMember = "MainCategoryTbl";
            this.mainCategoryTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainCategoryGridView
            // 
            this.mainCategoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMainCategoryName,
            this.colMainCategoryDescription});
            this.mainCategoryGridView.GridControl = this.mainCategoryGridControl;
            this.mainCategoryGridView.Name = "mainCategoryGridView";
            // 
            // colID
            // 
            this.colID.Caption = "معرف الفئة الرئيسية";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Width = 80;
            // 
            // colMainCategoryName
            // 
            this.colMainCategoryName.Caption = "اسم الفئة الرئيسية";
            this.colMainCategoryName.FieldName = "MainCategoryName";
            this.colMainCategoryName.MinWidth = 25;
            this.colMainCategoryName.Name = "colMainCategoryName";
            this.colMainCategoryName.Visible = true;
            this.colMainCategoryName.VisibleIndex = 0;
            this.colMainCategoryName.Width = 150;
            // 
            // colMainCategoryDescription
            // 
            this.colMainCategoryDescription.Caption = "وصف الفئة الرئيسية";
            this.colMainCategoryDescription.FieldName = "MainCategoryDescription";
            this.colMainCategoryDescription.MinWidth = 25;
            this.colMainCategoryDescription.Name = "colMainCategoryDescription";
            this.colMainCategoryDescription.Visible = true;
            this.colMainCategoryDescription.VisibleIndex = 1;
            this.colMainCategoryDescription.Width = 200;
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
            this.tableAdapterManager.MainCategoryTblTableAdapter = this.mainCategoryTblTableAdapter;
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
            // mainCategoryTblTableAdapter
            // 
            this.mainCategoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(84, 44);
            this.bindingNavigatorMoveFirstItem.Text = "الأول";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(95, 44);
            this.bindingNavigatorMovePreviousItem.Text = "السابق";
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
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(89, 44);
            this.bindingNavigatorMoveNextItem.Text = "التالي";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(86, 44);
            this.bindingNavigatorMoveLastItem.Text = "الأخير";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(126, 44);
            this.bindingNavigatorAddNewItem.Text = "إضافة جديد";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(85, 44);
            this.bindingNavigatorDeleteItem.Text = "حذف";
            // 
            // mainCategoryTblBindingNavigatorSaveItem
            // 
            this.mainCategoryTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mainCategoryTblBindingNavigatorSaveItem.Image")));
            this.mainCategoryTblBindingNavigatorSaveItem.Name = "mainCategoryTblBindingNavigatorSaveItem";
            this.mainCategoryTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(143, 44);
            this.mainCategoryTblBindingNavigatorSaveItem.Text = "حفظ التغييرات";
            this.mainCategoryTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.mainCategoryTblBindingNavigatorSaveItem_Click);
            // 
            // mainCategoryTblBindingNavigator
            // 
            this.mainCategoryTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mainCategoryTblBindingNavigator.BindingSource = this.mainCategoryTblBindingSource;
            this.mainCategoryTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mainCategoryTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mainCategoryTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mainCategoryTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mainCategoryTblBindingNavigatorSaveItem,
            this.manageMinorCategoryTblToolStripButton,
            this.addAllMicaToFicaToolStripButton});
            this.mainCategoryTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mainCategoryTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mainCategoryTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mainCategoryTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mainCategoryTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mainCategoryTblBindingNavigator.Name = "mainCategoryTblBindingNavigator";
            this.mainCategoryTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mainCategoryTblBindingNavigator.Size = new System.Drawing.Size(1180, 47);
            this.mainCategoryTblBindingNavigator.TabIndex = 4;
            this.mainCategoryTblBindingNavigator.Text = "bindingNavigator1";
            // 
            // manageMinorCategoryTblToolStripButton
            // 
            this.manageMinorCategoryTblToolStripButton.Image = global::AssetManagement.Properties.Resources._228050;
            this.manageMinorCategoryTblToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.manageMinorCategoryTblToolStripButton.Name = "manageMinorCategoryTblToolStripButton";
            this.manageMinorCategoryTblToolStripButton.Size = new System.Drawing.Size(213, 44);
            this.manageMinorCategoryTblToolStripButton.Text = "إدارة جدول الفئات الفرعية";
            this.manageMinorCategoryTblToolStripButton.Click += new System.EventHandler(this.manageMinorCategoryTblToolStripButton_Click);
            // 
            // addAllMicaToFicaToolStripButton
            // 
            this.addAllMicaToFicaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addAllMicaToFicaToolStripButton.Image")));
            this.addAllMicaToFicaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addAllMicaToFicaToolStripButton.Name = "addAllMicaToFicaToolStripButton";
            this.addAllMicaToFicaToolStripButton.Size = new System.Drawing.Size(263, 44);
            this.addAllMicaToFicaToolStripButton.Text = "إضافة الفئات الرئيسية كبنود مالية";
            this.addAllMicaToFicaToolStripButton.Click += new System.EventHandler(this.addAllMicaToFicaToolStripButton_Click);
            // 
            // ManageMainCategoryTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 670);
            this.Controls.Add(this.mainCategoryGridControl);
            this.Controls.Add(this.mainCategoryTblBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageMainCategoryTblForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة جدول الفئات الرئيسية";
            this.Load += new System.EventHandler(this.ManageMainCategoryTblForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryTblBindingNavigator)).EndInit();
            this.mainCategoryTblBindingNavigator.ResumeLayout(false);
            this.mainCategoryTblBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AssetMngDbDataSet assetMngDbDataSet;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private DevExpress.XtraGrid.GridControl mainCategoryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView mainCategoryGridView;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.ToolStripButton mainCategoryTblBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator mainCategoryTblBindingNavigator;
        private System.Windows.Forms.BindingSource mainCategoryTblBindingSource;
        private AssetMngDbDataSetTableAdapters.MainCategoryTblTableAdapter mainCategoryTblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMainCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colMainCategoryDescription;
        private System.Windows.Forms.ToolStripButton manageMinorCategoryTblToolStripButton;
        private System.Windows.Forms.ToolStripButton addAllMicaToFicaToolStripButton;
    }
}