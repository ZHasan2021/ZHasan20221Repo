
namespace Kindergarten.Students
{
    partial class ManageStudentTblForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudentTblForm));
            this.mainTabFormControl = new DevExpress.XtraBars.TabFormControl();
            this.saveChangesBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.viewCardBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.studentGridControl = new DevExpress.XtraGrid.GridControl();
            this.studentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindergartenDbDataSet = new Kindergarten.KindergartenDbDataSet();
            this.studentGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFather = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMother = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNationalCardID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStudentGrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEducationalLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegisteringDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScholasticYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsertedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModifiedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsertedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.studentTblTableAdapter = new Kindergarten.KindergartenDbDataSetTableAdapters.StudentTblTableAdapter();
            this.exportToExcelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tableAdapterManager = new Kindergarten.KindergartenDbDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.mainTabFormControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabFormControl
            // 
            this.mainTabFormControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.saveChangesBarButtonItem,
            this.viewCardBarButtonItem,
            this.exportToExcelBarButtonItem});
            this.mainTabFormControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabFormControl.Name = "mainTabFormControl";
            this.mainTabFormControl.Size = new System.Drawing.Size(1299, 88);
            this.mainTabFormControl.TabForm = this;
            this.mainTabFormControl.TabIndex = 0;
            this.mainTabFormControl.TabStop = false;
            this.mainTabFormControl.TitleItemLinks.Add(this.saveChangesBarButtonItem);
            this.mainTabFormControl.TitleItemLinks.Add(this.viewCardBarButtonItem);
            this.mainTabFormControl.TitleItemLinks.Add(this.exportToExcelBarButtonItem);
            // 
            // saveChangesBarButtonItem
            // 
            this.saveChangesBarButtonItem.Caption = "حفظ التعديلات";
            this.saveChangesBarButtonItem.Id = 0;
            this.saveChangesBarButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("saveChangesBarButtonItem.ImageOptions.SvgImage")));
            this.saveChangesBarButtonItem.Name = "saveChangesBarButtonItem";
            this.saveChangesBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveChangesBarButtonItem_ItemClick);
            // 
            // viewCardBarButtonItem
            // 
            this.viewCardBarButtonItem.Caption = "بطاقة الطالب";
            this.viewCardBarButtonItem.Id = 1;
            this.viewCardBarButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("viewCardBarButtonItem.ImageOptions.SvgImage")));
            this.viewCardBarButtonItem.Name = "viewCardBarButtonItem";
            this.viewCardBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.viewCardBarButtonItem_ItemClick);
            // 
            // studentGridControl
            // 
            this.studentGridControl.DataSource = this.studentTblBindingSource;
            this.studentGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentGridControl.Location = new System.Drawing.Point(0, 88);
            this.studentGridControl.MainView = this.studentGridView;
            this.studentGridControl.Name = "studentGridControl";
            this.studentGridControl.Size = new System.Drawing.Size(1299, 660);
            this.studentGridControl.TabIndex = 1;
            this.studentGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.studentGridView});
            // 
            // studentTblBindingSource
            // 
            this.studentTblBindingSource.DataMember = "StudentTbl";
            this.studentTblBindingSource.DataSource = this.kindergartenDbDataSet;
            // 
            // kindergartenDbDataSet
            // 
            this.kindergartenDbDataSet.DataSetName = "KindergartenDbDataSet";
            this.kindergartenDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentGridView
            // 
            this.studentGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFirstName,
            this.colLastName,
            this.colFather,
            this.colMother,
            this.colNationalCardID,
            this.colDateOfBirth,
            this.colStudentGrade,
            this.colEducationalLevel,
            this.colRegisteringDate,
            this.colScholasticYear,
            this.colNotes,
            this.colInsertedOn,
            this.colLastModifiedOn,
            this.colInsertedBy,
            this.colLastModifiedBy});
            this.studentGridView.GridControl = this.studentGridControl;
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.studentGridView_RowClick);
            this.studentGridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.studentGridView_RowCellClick);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 94;
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.MinWidth = 25;
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            this.colFirstName.Width = 94;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.MinWidth = 25;
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            this.colLastName.Width = 94;
            // 
            // colFather
            // 
            this.colFather.FieldName = "Father";
            this.colFather.MinWidth = 25;
            this.colFather.Name = "colFather";
            this.colFather.Visible = true;
            this.colFather.VisibleIndex = 3;
            this.colFather.Width = 94;
            // 
            // colMother
            // 
            this.colMother.FieldName = "Mother";
            this.colMother.MinWidth = 25;
            this.colMother.Name = "colMother";
            this.colMother.Visible = true;
            this.colMother.VisibleIndex = 4;
            this.colMother.Width = 94;
            // 
            // colNationalCardID
            // 
            this.colNationalCardID.FieldName = "NationalCardID";
            this.colNationalCardID.MinWidth = 25;
            this.colNationalCardID.Name = "colNationalCardID";
            this.colNationalCardID.Visible = true;
            this.colNationalCardID.VisibleIndex = 5;
            this.colNationalCardID.Width = 94;
            // 
            // colDateOfBirth
            // 
            this.colDateOfBirth.FieldName = "DateOfBirth";
            this.colDateOfBirth.MinWidth = 25;
            this.colDateOfBirth.Name = "colDateOfBirth";
            this.colDateOfBirth.Visible = true;
            this.colDateOfBirth.VisibleIndex = 6;
            this.colDateOfBirth.Width = 94;
            // 
            // colStudentGrade
            // 
            this.colStudentGrade.FieldName = "StudentGrade";
            this.colStudentGrade.MinWidth = 25;
            this.colStudentGrade.Name = "colStudentGrade";
            this.colStudentGrade.Visible = true;
            this.colStudentGrade.VisibleIndex = 7;
            this.colStudentGrade.Width = 94;
            // 
            // colEducationalLevel
            // 
            this.colEducationalLevel.FieldName = "EducationalLevel";
            this.colEducationalLevel.MinWidth = 25;
            this.colEducationalLevel.Name = "colEducationalLevel";
            this.colEducationalLevel.Visible = true;
            this.colEducationalLevel.VisibleIndex = 8;
            this.colEducationalLevel.Width = 94;
            // 
            // colRegisteringDate
            // 
            this.colRegisteringDate.FieldName = "RegisteringDate";
            this.colRegisteringDate.MinWidth = 25;
            this.colRegisteringDate.Name = "colRegisteringDate";
            this.colRegisteringDate.Visible = true;
            this.colRegisteringDate.VisibleIndex = 9;
            this.colRegisteringDate.Width = 94;
            // 
            // colScholasticYear
            // 
            this.colScholasticYear.FieldName = "ScholasticYear";
            this.colScholasticYear.MinWidth = 25;
            this.colScholasticYear.Name = "colScholasticYear";
            this.colScholasticYear.Visible = true;
            this.colScholasticYear.VisibleIndex = 10;
            this.colScholasticYear.Width = 94;
            // 
            // colNotes
            // 
            this.colNotes.FieldName = "Notes";
            this.colNotes.MinWidth = 25;
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 11;
            this.colNotes.Width = 94;
            // 
            // colInsertedOn
            // 
            this.colInsertedOn.FieldName = "InsertedOn";
            this.colInsertedOn.MinWidth = 25;
            this.colInsertedOn.Name = "colInsertedOn";
            this.colInsertedOn.Visible = true;
            this.colInsertedOn.VisibleIndex = 12;
            this.colInsertedOn.Width = 94;
            // 
            // colLastModifiedOn
            // 
            this.colLastModifiedOn.FieldName = "LastModifiedOn";
            this.colLastModifiedOn.MinWidth = 25;
            this.colLastModifiedOn.Name = "colLastModifiedOn";
            this.colLastModifiedOn.Visible = true;
            this.colLastModifiedOn.VisibleIndex = 13;
            this.colLastModifiedOn.Width = 94;
            // 
            // colInsertedBy
            // 
            this.colInsertedBy.FieldName = "InsertedBy";
            this.colInsertedBy.MinWidth = 25;
            this.colInsertedBy.Name = "colInsertedBy";
            this.colInsertedBy.Visible = true;
            this.colInsertedBy.VisibleIndex = 14;
            this.colInsertedBy.Width = 94;
            // 
            // colLastModifiedBy
            // 
            this.colLastModifiedBy.FieldName = "LastModifiedBy";
            this.colLastModifiedBy.MinWidth = 25;
            this.colLastModifiedBy.Name = "colLastModifiedBy";
            this.colLastModifiedBy.Visible = true;
            this.colLastModifiedBy.VisibleIndex = 15;
            this.colLastModifiedBy.Width = 94;
            // 
            // studentTblTableAdapter
            // 
            this.studentTblTableAdapter.ClearBeforeFill = true;
            // 
            // exportToExcelBarButtonItem
            // 
            this.exportToExcelBarButtonItem.Caption = "تصدير إلى اكسل";
            this.exportToExcelBarButtonItem.Id = 0;
            this.exportToExcelBarButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.exportToExcelBarButtonItem.Name = "exportToExcelBarButtonItem";
            this.exportToExcelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.exportToExcelBarButtonItem_ItemClick);
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 1000;
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
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EducationalLevelTblTableAdapter = null;
            this.tableAdapterManager.FeePeriodTblTableAdapter = null;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.ScholasticYearTblTableAdapter = null;
            this.tableAdapterManager.StudentFeeTblTableAdapter = null;
            this.tableAdapterManager.StudentTblTableAdapter = this.studentTblTableAdapter;
            this.tableAdapterManager.UpdateOrder = Kindergarten.KindergartenDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // ManageStudentTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 748);
            this.Controls.Add(this.studentGridControl);
            this.Controls.Add(this.mainTabFormControl);
            this.IconOptions.Image = global::Kindergarten.Properties.Resources._3361550;
            this.Name = "ManageStudentTblForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.TabFormControl = this.mainTabFormControl;
            this.Text = "إدارة سجلات الطلاب";
            this.Load += new System.EventHandler(this.ManageStudentTblForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainTabFormControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.TabFormControl mainTabFormControl;
        private DevExpress.XtraGrid.GridControl studentGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView studentGridView;
        private KindergartenDbDataSet kindergartenDbDataSet;
        private System.Windows.Forms.BindingSource studentTblBindingSource;
        private KindergartenDbDataSetTableAdapters.StudentTblTableAdapter studentTblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colFather;
        private DevExpress.XtraGrid.Columns.GridColumn colMother;
        private DevExpress.XtraGrid.Columns.GridColumn colNationalCardID;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfBirth;
        private DevExpress.XtraGrid.Columns.GridColumn colStudentGrade;
        private DevExpress.XtraGrid.Columns.GridColumn colEducationalLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colRegisteringDate;
        private DevExpress.XtraGrid.Columns.GridColumn colScholasticYear;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colInsertedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModifiedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colInsertedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModifiedBy;
        private DevExpress.XtraBars.BarButtonItem saveChangesBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem viewCardBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem exportToExcelBarButtonItem;
        private System.Windows.Forms.Timer mainTimer;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private KindergartenDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}