
namespace Kindergarten.AuxTables
{
    partial class ManageEducationalLevelTblForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEducationalLevelTblForm));
            this.educationalLevelGridControl = new DevExpress.XtraGrid.GridControl();
            this.educationalLevelTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindergartenDbDataSet = new Kindergarten.KindergartenDbDataSet();
            this.educationalLevelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.educationalLevelTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.educationalLevelTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.educationalLevelTblTableAdapter = new Kindergarten.KindergartenDbDataSetTableAdapters.EducationalLevelTblTableAdapter();
            this.tableAdapterManager = new Kindergarten.KindergartenDbDataSetTableAdapters.TableAdapterManager();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEducationalLevelName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEducationalLevelMonthlyFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEducationalLevelSemesterFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEducationalLevelAnnualFee = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.educationalLevelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationalLevelTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationalLevelGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationalLevelTblBindingNavigator)).BeginInit();
            this.educationalLevelTblBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // educationalLevelGridControl
            // 
            this.educationalLevelGridControl.DataSource = this.educationalLevelTblBindingSource;
            this.educationalLevelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "educationalLevelLevel";
            this.educationalLevelGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.educationalLevelGridControl.Location = new System.Drawing.Point(0, 31);
            this.educationalLevelGridControl.MainView = this.educationalLevelGridView;
            this.educationalLevelGridControl.Name = "educationalLevelGridControl";
            this.educationalLevelGridControl.Size = new System.Drawing.Size(910, 542);
            this.educationalLevelGridControl.TabIndex = 5;
            this.educationalLevelGridControl.UseEmbeddedNavigator = true;
            this.educationalLevelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.educationalLevelGridView});
            // 
            // educationalLevelTblBindingSource
            // 
            this.educationalLevelTblBindingSource.DataMember = "EducationalLevelTbl";
            this.educationalLevelTblBindingSource.DataSource = this.kindergartenDbDataSet;
            // 
            // kindergartenDbDataSet
            // 
            this.kindergartenDbDataSet.DataSetName = "KindergartenDbDataSet";
            this.kindergartenDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // educationalLevelGridView
            // 
            this.educationalLevelGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colEducationalLevelName,
            this.colEducationalLevelMonthlyFee,
            this.colEducationalLevelSemesterFee,
            this.colEducationalLevelAnnualFee});
            this.educationalLevelGridView.GridControl = this.educationalLevelGridControl;
            this.educationalLevelGridView.Name = "educationalLevelGridView";
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
            // educationalLevelTblBindingNavigator
            // 
            this.educationalLevelTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.educationalLevelTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.educationalLevelTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.educationalLevelTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.educationalLevelTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.educationalLevelTblBindingNavigatorSaveItem});
            this.educationalLevelTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.educationalLevelTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.educationalLevelTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.educationalLevelTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.educationalLevelTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.educationalLevelTblBindingNavigator.Name = "educationalLevelTblBindingNavigator";
            this.educationalLevelTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.educationalLevelTblBindingNavigator.Size = new System.Drawing.Size(910, 31);
            this.educationalLevelTblBindingNavigator.TabIndex = 4;
            this.educationalLevelTblBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // educationalLevelTblBindingNavigatorSaveItem
            // 
            this.educationalLevelTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.educationalLevelTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("educationalLevelTblBindingNavigatorSaveItem.Image")));
            this.educationalLevelTblBindingNavigatorSaveItem.Name = "educationalLevelTblBindingNavigatorSaveItem";
            this.educationalLevelTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.educationalLevelTblBindingNavigatorSaveItem.Text = "Save Data";
            this.educationalLevelTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.educationalLevelTblBindingNavigatorSaveItem_Click);
            // 
            // educationalLevelTblTableAdapter
            // 
            this.educationalLevelTblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EducationalLevelTblTableAdapter = this.educationalLevelTblTableAdapter;
            this.tableAdapterManager.FeePeriodTblTableAdapter = null;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.ScholasticYearTblTableAdapter = null;
            this.tableAdapterManager.StudentFeeTblTableAdapter = null;
            this.tableAdapterManager.StudentTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kindergarten.KindergartenDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // colID
            // 
            this.colID.Caption = "معرف المرحلة الدراسية";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 80;
            this.colID.Name = "colID";
            this.colID.Width = 94;
            // 
            // colEducationalLevelName
            // 
            this.colEducationalLevelName.Caption = "اسم المرحلة الدراسية";
            this.colEducationalLevelName.FieldName = "EducationalLevelName";
            this.colEducationalLevelName.MinWidth = 120;
            this.colEducationalLevelName.Name = "colEducationalLevelName";
            this.colEducationalLevelName.Visible = true;
            this.colEducationalLevelName.VisibleIndex = 0;
            this.colEducationalLevelName.Width = 148;
            // 
            // colEducationalLevelMonthlyFee
            // 
            this.colEducationalLevelMonthlyFee.Caption = "الرسم الشهري";
            this.colEducationalLevelMonthlyFee.FieldName = "EducationalLevelMonthlyFee";
            this.colEducationalLevelMonthlyFee.MinWidth = 100;
            this.colEducationalLevelMonthlyFee.Name = "colEducationalLevelMonthlyFee";
            this.colEducationalLevelMonthlyFee.Visible = true;
            this.colEducationalLevelMonthlyFee.VisibleIndex = 1;
            this.colEducationalLevelMonthlyFee.Width = 100;
            // 
            // colEducationalLevelSemesterFee
            // 
            this.colEducationalLevelSemesterFee.Caption = "الرسم الفصلي";
            this.colEducationalLevelSemesterFee.FieldName = "EducationalLevelSemesterFee";
            this.colEducationalLevelSemesterFee.MinWidth = 100;
            this.colEducationalLevelSemesterFee.Name = "colEducationalLevelSemesterFee";
            this.colEducationalLevelSemesterFee.Visible = true;
            this.colEducationalLevelSemesterFee.VisibleIndex = 2;
            this.colEducationalLevelSemesterFee.Width = 100;
            // 
            // colEducationalLevelAnnualFee
            // 
            this.colEducationalLevelAnnualFee.Caption = "الرسم السنوي";
            this.colEducationalLevelAnnualFee.FieldName = "EducationalLevelAnnualFee";
            this.colEducationalLevelAnnualFee.MinWidth = 100;
            this.colEducationalLevelAnnualFee.Name = "colEducationalLevelAnnualFee";
            this.colEducationalLevelAnnualFee.Visible = true;
            this.colEducationalLevelAnnualFee.VisibleIndex = 3;
            this.colEducationalLevelAnnualFee.Width = 100;
            // 
            // ManageEducationalLevelTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 573);
            this.Controls.Add(this.educationalLevelGridControl);
            this.Controls.Add(this.educationalLevelTblBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageEducationalLevelTblForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة جدول المراحل الدراسية";
            this.Load += new System.EventHandler(this.ManageEducationalLevelTblForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.educationalLevelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationalLevelTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationalLevelGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationalLevelTblBindingNavigator)).EndInit();
            this.educationalLevelTblBindingNavigator.ResumeLayout(false);
            this.educationalLevelTblBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private System.Windows.Forms.BindingNavigator educationalLevelTblBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton educationalLevelTblBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl educationalLevelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView educationalLevelGridView;
        private KindergartenDbDataSet kindergartenDbDataSet;
        private System.Windows.Forms.BindingSource educationalLevelTblBindingSource;
        private KindergartenDbDataSetTableAdapters.EducationalLevelTblTableAdapter educationalLevelTblTableAdapter;
        private KindergartenDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colEducationalLevelName;
        private DevExpress.XtraGrid.Columns.GridColumn colEducationalLevelMonthlyFee;
        private DevExpress.XtraGrid.Columns.GridColumn colEducationalLevelSemesterFee;
        private DevExpress.XtraGrid.Columns.GridColumn colEducationalLevelAnnualFee;
    }
}