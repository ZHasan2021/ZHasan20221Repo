
namespace AssetManagement.AuxTables
{
    partial class ManageEmployeeTblForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmployeeTblForm));
            this.employeeGridControl = new DevExpress.XtraGrid.GridControl();
            this.employeeTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.employeeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkingAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.employeeTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.EmployeeTblTableAdapter();
            this.employeeTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.employeeTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employeeTblBindingNavigatorExportToExcelItem = new System.Windows.Forms.ToolStripButton();
            this.employeeTblBindingNavigatorViewCustodiesItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTblBindingNavigator)).BeginInit();
            this.employeeTblBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeGridControl
            // 
            this.employeeGridControl.DataSource = this.employeeTblBindingSource;
            this.employeeGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "employeeLevel";
            this.employeeGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.employeeGridControl.Location = new System.Drawing.Point(0, 47);
            this.employeeGridControl.MainView = this.employeeGridView;
            this.employeeGridControl.Name = "employeeGridControl";
            this.employeeGridControl.Size = new System.Drawing.Size(1249, 688);
            this.employeeGridControl.TabIndex = 5;
            this.employeeGridControl.UseEmbeddedNavigator = true;
            this.employeeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.employeeGridView});
            // 
            // employeeTblBindingSource
            // 
            this.employeeTblBindingSource.DataMember = "EmployeeTbl";
            this.employeeTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeGridView
            // 
            this.employeeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colEmployeeCode,
            this.colFirstName,
            this.colLastName,
            this.colWorkingAt});
            this.employeeGridView.GridControl = this.employeeGridControl;
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.employeeGridView_RowClick);
            this.employeeGridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.employeeGridView_RowCellClick);
            // 
            // colID
            // 
            this.colID.Caption = "معرف الموظف";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 100;
            this.colID.Name = "colID";
            this.colID.Width = 94;
            // 
            // colEmployeeCode
            // 
            this.colEmployeeCode.Caption = "الرقم الوظيفي";
            this.colEmployeeCode.FieldName = "EmployeeCode";
            this.colEmployeeCode.MinWidth = 120;
            this.colEmployeeCode.Name = "colEmployeeCode";
            this.colEmployeeCode.Visible = true;
            this.colEmployeeCode.VisibleIndex = 0;
            this.colEmployeeCode.Width = 148;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "الاسم الأول";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.MinWidth = 100;
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            this.colFirstName.Width = 100;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "اللقب";
            this.colLastName.FieldName = "LastName";
            this.colLastName.MinWidth = 100;
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            this.colLastName.Width = 100;
            // 
            // colWorkingAt
            // 
            this.colWorkingAt.Caption = "مكان العمل";
            this.colWorkingAt.FieldName = "WorkingAt";
            this.colWorkingAt.MinWidth = 150;
            this.colWorkingAt.Name = "colWorkingAt";
            this.colWorkingAt.Visible = true;
            this.colWorkingAt.VisibleIndex = 3;
            this.colWorkingAt.Width = 150;
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
            this.tableAdapterManager.EmployeeTblTableAdapter = this.employeeTblTableAdapter;
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
            this.tableAdapterManager.SubDepartmentTblTableAdapter = null;
            this.tableAdapterManager.TransactionTypeTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserLoginTblTableAdapter = null;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // employeeTblTableAdapter
            // 
            this.employeeTblTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTblBindingNavigator
            // 
            this.employeeTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeeTblBindingNavigator.BindingSource = this.employeeTblBindingSource;
            this.employeeTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeeTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeeTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.employeeTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.employeeTblBindingNavigatorSaveItem,
            this.employeeTblBindingNavigatorExportToExcelItem,
            this.employeeTblBindingNavigatorViewCustodiesItem});
            this.employeeTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeeTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeeTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeeTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeeTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeeTblBindingNavigator.Name = "employeeTblBindingNavigator";
            this.employeeTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeeTblBindingNavigator.Size = new System.Drawing.Size(1249, 47);
            this.employeeTblBindingNavigator.TabIndex = 4;
            this.employeeTblBindingNavigator.Text = "bindingNavigator1";
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
            // employeeTblBindingNavigatorSaveItem
            // 
            this.employeeTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeTblBindingNavigatorSaveItem.Image")));
            this.employeeTblBindingNavigatorSaveItem.Name = "employeeTblBindingNavigatorSaveItem";
            this.employeeTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(44, 44);
            this.employeeTblBindingNavigatorSaveItem.Text = "Save Data";
            this.employeeTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeeTblBindingNavigatorSaveItem_Click);
            // 
            // employeeTblBindingNavigatorExportToExcelItem
            // 
            this.employeeTblBindingNavigatorExportToExcelItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeTblBindingNavigatorExportToExcelItem.Image = global::AssetManagement.Properties.Resources._36435172;
            this.employeeTblBindingNavigatorExportToExcelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.employeeTblBindingNavigatorExportToExcelItem.Name = "employeeTblBindingNavigatorExportToExcelItem";
            this.employeeTblBindingNavigatorExportToExcelItem.Size = new System.Drawing.Size(44, 44);
            this.employeeTblBindingNavigatorExportToExcelItem.Text = "تصدير إلى إكسل";
            this.employeeTblBindingNavigatorExportToExcelItem.Click += new System.EventHandler(this.employeeTblBindingNavigatorExportToExcelItem_Click);
            // 
            // employeeTblBindingNavigatorViewCustodiesItem
            // 
            this.employeeTblBindingNavigatorViewCustodiesItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeTblBindingNavigatorViewCustodiesItem.Image = global::AssetManagement.Properties.Resources._6001301;
            this.employeeTblBindingNavigatorViewCustodiesItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.employeeTblBindingNavigatorViewCustodiesItem.Name = "employeeTblBindingNavigatorViewCustodiesItem";
            this.employeeTblBindingNavigatorViewCustodiesItem.Size = new System.Drawing.Size(44, 44);
            this.employeeTblBindingNavigatorViewCustodiesItem.Text = "عرض العهدات المستلمة";
            this.employeeTblBindingNavigatorViewCustodiesItem.Click += new System.EventHandler(this.employeeTblBindingNavigatorViewCustodiesItem_Click);
            // 
            // ManageEmployeeTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 735);
            this.Controls.Add(this.employeeGridControl);
            this.Controls.Add(this.employeeTblBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageEmployeeTblForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة جدول الموظفين";
            this.Load += new System.EventHandler(this.ManageEmployeeTblForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTblBindingNavigator)).EndInit();
            this.employeeTblBindingNavigator.ResumeLayout(false);
            this.employeeTblBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AssetMngDbDataSet assetMngDbDataSet;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employeeTblBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton employeeTblBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl employeeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView employeeGridView;
        private System.Windows.Forms.ToolStripButton employeeTblBindingNavigatorExportToExcelItem;
        private System.Windows.Forms.BindingSource employeeTblBindingSource;
        private AssetMngDbDataSetTableAdapters.EmployeeTblTableAdapter employeeTblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkingAt;
        private System.Windows.Forms.ToolStripButton employeeTblBindingNavigatorViewCustodiesItem;
    }
}