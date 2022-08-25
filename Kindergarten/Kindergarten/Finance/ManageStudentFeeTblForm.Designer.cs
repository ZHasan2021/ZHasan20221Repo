
namespace Kindergarten.Students
{
    partial class ManageStudentFeeTblForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudentFeeTblForm));
            this.mainTabFormControl = new DevExpress.XtraBars.TabFormControl();
            this.saveChangesBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.viewCardBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.exportToExcelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.studentFeeGridControl = new DevExpress.XtraGrid.GridControl();
            this.studentFeeTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindergartenDbDataSet = new Kindergarten.KindergartenDbDataSet();
            this.studentFeeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStudentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stuRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.studentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colFeePeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fePrRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.feePeriodTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colFeePayingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFeeScholasticYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.shYeRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.scholasticYearTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colFeeAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVoucherNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVoucherPreparedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsertedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModifiedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsertedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.edLeRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dateEditRepositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tableAdapterManager = new Kindergarten.KindergartenDbDataSetTableAdapters.TableAdapterManager();
            this.feePeriodTblTableAdapter = new Kindergarten.KindergartenDbDataSetTableAdapters.FeePeriodTblTableAdapter();
            this.studentFeeTblTableAdapter = new Kindergarten.KindergartenDbDataSetTableAdapters.StudentFeeTblTableAdapter();
            this.studentTblTableAdapter = new Kindergarten.KindergartenDbDataSetTableAdapters.StudentTblTableAdapter();
            this.scholasticYearTblTableAdapter = new Kindergarten.KindergartenDbDataSetTableAdapters.ScholasticYearTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mainTabFormControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentFeeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentFeeTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentFeeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fePrRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feePeriodTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shYeRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scholasticYearTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edLeRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditRepositoryItemDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditRepositoryItemDateEdit.CalendarTimeProperties)).BeginInit();
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
            this.mainTabFormControl.Click += new System.EventHandler(this.mainTabFormControl_Click);
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
            // exportToExcelBarButtonItem
            // 
            this.exportToExcelBarButtonItem.Caption = "تصدير إلى اكسل";
            this.exportToExcelBarButtonItem.Id = 0;
            this.exportToExcelBarButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("exportToExcelBarButtonItem.ImageOptions.SvgImage")));
            this.exportToExcelBarButtonItem.Name = "exportToExcelBarButtonItem";
            this.exportToExcelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.exportToExcelBarButtonItem_ItemClick);
            // 
            // studentFeeGridControl
            // 
            this.studentFeeGridControl.DataSource = this.studentFeeTblBindingSource;
            this.studentFeeGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentFeeGridControl.Location = new System.Drawing.Point(0, 88);
            this.studentFeeGridControl.MainView = this.studentFeeGridView;
            this.studentFeeGridControl.Name = "studentFeeGridControl";
            this.studentFeeGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.shYeRepositoryItemLookUpEdit,
            this.edLeRepositoryItemLookUpEdit,
            this.dateEditRepositoryItemDateEdit,
            this.fePrRepositoryItemLookUpEdit,
            this.stuRepositoryItemLookUpEdit});
            this.studentFeeGridControl.Size = new System.Drawing.Size(1299, 660);
            this.studentFeeGridControl.TabIndex = 1;
            this.studentFeeGridControl.UseEmbeddedNavigator = true;
            this.studentFeeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.studentFeeGridView});
            // 
            // studentFeeTblBindingSource
            // 
            this.studentFeeTblBindingSource.DataMember = "StudentFeeTbl";
            this.studentFeeTblBindingSource.DataSource = this.kindergartenDbDataSet;
            // 
            // kindergartenDbDataSet
            // 
            this.kindergartenDbDataSet.DataSetName = "KindergartenDbDataSet";
            this.kindergartenDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentFeeGridView
            // 
            this.studentFeeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colStudentID,
            this.colFeePeriod,
            this.colFeePayingDate,
            this.colFeeScholasticYear,
            this.colFeeAmount,
            this.colVoucherNumber,
            this.colVoucherPreparedBy,
            this.colInsertedOn,
            this.colLastModifiedOn,
            this.colInsertedBy,
            this.colLastModifiedBy});
            this.studentFeeGridView.GridControl = this.studentFeeGridControl;
            this.studentFeeGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FeeAmount", null, "(إجمالي وارد الرسوم={0:0.##})")});
            this.studentFeeGridView.Name = "studentFeeGridView";
            this.studentFeeGridView.OptionsView.ShowFooter = true;
            this.studentFeeGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.studentGridView_RowClick);
            this.studentFeeGridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.studentGridView_RowCellClick);
            // 
            // colID
            // 
            this.colID.Caption = "معرف الرسم الدراسي";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Width = 80;
            // 
            // colStudentID
            // 
            this.colStudentID.Caption = "اسم الطالب";
            this.colStudentID.ColumnEdit = this.stuRepositoryItemLookUpEdit;
            this.colStudentID.FieldName = "StudentID";
            this.colStudentID.MinWidth = 25;
            this.colStudentID.Name = "colStudentID";
            this.colStudentID.Visible = true;
            this.colStudentID.VisibleIndex = 0;
            this.colStudentID.Width = 150;
            // 
            // stuRepositoryItemLookUpEdit
            // 
            this.stuRepositoryItemLookUpEdit.AutoHeight = false;
            this.stuRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.stuRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الطالب", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FirstName", "الاسم", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LastName", "الكنية", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Father", "الأب", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mother", "الأم", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "الاسم بالكامل", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NationalCardID", "رقم البطاقة الشخصية", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DateOfBirth", "تاريخ الميلاد", 100, DevExpress.Utils.FormatType.DateTime, "dd-MM-yyyy", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.stuRepositoryItemLookUpEdit.DataSource = this.studentTblBindingSource;
            this.stuRepositoryItemLookUpEdit.DisplayMember = "FullName";
            this.stuRepositoryItemLookUpEdit.Name = "stuRepositoryItemLookUpEdit";
            this.stuRepositoryItemLookUpEdit.PopupWidth = 500;
            this.stuRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // studentTblBindingSource
            // 
            this.studentTblBindingSource.DataMember = "StudentTbl";
            this.studentTblBindingSource.DataSource = this.kindergartenDbDataSet;
            // 
            // colFeePeriod
            // 
            this.colFeePeriod.Caption = "فترة الرسم الدراسي";
            this.colFeePeriod.ColumnEdit = this.fePrRepositoryItemLookUpEdit;
            this.colFeePeriod.FieldName = "FeePeriod";
            this.colFeePeriod.MinWidth = 25;
            this.colFeePeriod.Name = "colFeePeriod";
            this.colFeePeriod.Visible = true;
            this.colFeePeriod.VisibleIndex = 1;
            this.colFeePeriod.Width = 150;
            // 
            // fePrRepositoryItemLookUpEdit
            // 
            this.fePrRepositoryItemLookUpEdit.AutoHeight = false;
            this.fePrRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fePrRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف فترة الرسم الدراسي", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FeePeriodName", "اسم فترة الرسم الدراسي", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.fePrRepositoryItemLookUpEdit.DataSource = this.feePeriodTblBindingSource;
            this.fePrRepositoryItemLookUpEdit.DisplayMember = "FeePeriodName";
            this.fePrRepositoryItemLookUpEdit.Name = "fePrRepositoryItemLookUpEdit";
            this.fePrRepositoryItemLookUpEdit.PopupWidth = 500;
            this.fePrRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // feePeriodTblBindingSource
            // 
            this.feePeriodTblBindingSource.DataMember = "FeePeriodTbl";
            this.feePeriodTblBindingSource.DataSource = this.kindergartenDbDataSet;
            // 
            // colFeePayingDate
            // 
            this.colFeePayingDate.Caption = "تاريخ الدفع";
            this.colFeePayingDate.FieldName = "FeePayingDate";
            this.colFeePayingDate.MinWidth = 25;
            this.colFeePayingDate.Name = "colFeePayingDate";
            this.colFeePayingDate.Visible = true;
            this.colFeePayingDate.VisibleIndex = 2;
            this.colFeePayingDate.Width = 100;
            // 
            // colFeeScholasticYear
            // 
            this.colFeeScholasticYear.Caption = "الموسم الدراسي";
            this.colFeeScholasticYear.ColumnEdit = this.shYeRepositoryItemLookUpEdit;
            this.colFeeScholasticYear.FieldName = "FeeScholasticYear";
            this.colFeeScholasticYear.MinWidth = 25;
            this.colFeeScholasticYear.Name = "colFeeScholasticYear";
            this.colFeeScholasticYear.Visible = true;
            this.colFeeScholasticYear.VisibleIndex = 3;
            this.colFeeScholasticYear.Width = 100;
            // 
            // shYeRepositoryItemLookUpEdit
            // 
            this.shYeRepositoryItemLookUpEdit.AutoHeight = false;
            this.shYeRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shYeRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الموسم الدراسي", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ScholasticYearName", "اسم الموسم الدراسي", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.shYeRepositoryItemLookUpEdit.DataSource = this.scholasticYearTblBindingSource;
            this.shYeRepositoryItemLookUpEdit.DisplayMember = "ScholasticYearName";
            this.shYeRepositoryItemLookUpEdit.Name = "shYeRepositoryItemLookUpEdit";
            this.shYeRepositoryItemLookUpEdit.PopupWidth = 500;
            this.shYeRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // scholasticYearTblBindingSource
            // 
            this.scholasticYearTblBindingSource.DataMember = "ScholasticYearTbl";
            this.scholasticYearTblBindingSource.DataSource = this.kindergartenDbDataSet;
            // 
            // colFeeAmount
            // 
            this.colFeeAmount.Caption = "قيمة الرسم";
            this.colFeeAmount.FieldName = "FeeAmount";
            this.colFeeAmount.MinWidth = 25;
            this.colFeeAmount.Name = "colFeeAmount";
            this.colFeeAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FeeAmount", "مجموع وارد الرسوم={0:0.##}")});
            this.colFeeAmount.Visible = true;
            this.colFeeAmount.VisibleIndex = 4;
            this.colFeeAmount.Width = 100;
            // 
            // colVoucherNumber
            // 
            this.colVoucherNumber.Caption = "رقم الايصال";
            this.colVoucherNumber.FieldName = "VoucherNumber";
            this.colVoucherNumber.MinWidth = 25;
            this.colVoucherNumber.Name = "colVoucherNumber";
            this.colVoucherNumber.Visible = true;
            this.colVoucherNumber.VisibleIndex = 5;
            this.colVoucherNumber.Width = 100;
            // 
            // colVoucherPreparedBy
            // 
            this.colVoucherPreparedBy.Caption = "منظم الايصال";
            this.colVoucherPreparedBy.FieldName = "VoucherPreparedBy";
            this.colVoucherPreparedBy.MinWidth = 25;
            this.colVoucherPreparedBy.Name = "colVoucherPreparedBy";
            this.colVoucherPreparedBy.Visible = true;
            this.colVoucherPreparedBy.VisibleIndex = 6;
            this.colVoucherPreparedBy.Width = 120;
            // 
            // colInsertedOn
            // 
            this.colInsertedOn.Caption = "تاريخ الإضافة";
            this.colInsertedOn.FieldName = "InsertedOn";
            this.colInsertedOn.MinWidth = 25;
            this.colInsertedOn.Name = "colInsertedOn";
            this.colInsertedOn.Width = 100;
            // 
            // colLastModifiedOn
            // 
            this.colLastModifiedOn.Caption = "تاريخ آخر تعديل";
            this.colLastModifiedOn.FieldName = "LastModifiedOn";
            this.colLastModifiedOn.MinWidth = 25;
            this.colLastModifiedOn.Name = "colLastModifiedOn";
            this.colLastModifiedOn.Width = 100;
            // 
            // colInsertedBy
            // 
            this.colInsertedBy.Caption = "من قام بالإصافة";
            this.colInsertedBy.FieldName = "InsertedBy";
            this.colInsertedBy.MinWidth = 25;
            this.colInsertedBy.Name = "colInsertedBy";
            this.colInsertedBy.Width = 80;
            // 
            // colLastModifiedBy
            // 
            this.colLastModifiedBy.Caption = "من قام بالتعديل";
            this.colLastModifiedBy.FieldName = "LastModifiedBy";
            this.colLastModifiedBy.MinWidth = 25;
            this.colLastModifiedBy.Name = "colLastModifiedBy";
            this.colLastModifiedBy.Width = 80;
            // 
            // edLeRepositoryItemLookUpEdit
            // 
            this.edLeRepositoryItemLookUpEdit.AutoHeight = false;
            this.edLeRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edLeRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف المرجلة الدراسية", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EducationalLevelName", "اسم المرحلة الدراسية", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EducationalLevelMonthlyFee", "الرسم الشهري", 100, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EducationalLevelSemesterFee", "الرسم الفصلي", 100, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EducationalLevelAnnualFee", "الرسم السنوي", 100, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.edLeRepositoryItemLookUpEdit.DisplayMember = "EducationalLevelName";
            this.edLeRepositoryItemLookUpEdit.Name = "edLeRepositoryItemLookUpEdit";
            this.edLeRepositoryItemLookUpEdit.PopupWidth = 500;
            this.edLeRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // dateEditRepositoryItemDateEdit
            // 
            this.dateEditRepositoryItemDateEdit.AutoHeight = false;
            this.dateEditRepositoryItemDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditRepositoryItemDateEdit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditRepositoryItemDateEdit.Name = "dateEditRepositoryItemDateEdit";
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
            this.tableAdapterManager.FeePeriodTblTableAdapter = this.feePeriodTblTableAdapter;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.ScholasticYearTblTableAdapter = null;
            this.tableAdapterManager.StudentFeeTblTableAdapter = this.studentFeeTblTableAdapter;
            this.tableAdapterManager.StudentTblTableAdapter = this.studentTblTableAdapter;
            this.tableAdapterManager.UpdateOrder = Kindergarten.KindergartenDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // feePeriodTblTableAdapter
            // 
            this.feePeriodTblTableAdapter.ClearBeforeFill = true;
            // 
            // studentFeeTblTableAdapter
            // 
            this.studentFeeTblTableAdapter.ClearBeforeFill = true;
            // 
            // studentTblTableAdapter
            // 
            this.studentTblTableAdapter.ClearBeforeFill = true;
            // 
            // scholasticYearTblTableAdapter
            // 
            this.scholasticYearTblTableAdapter.ClearBeforeFill = true;
            // 
            // ManageStudentFeeTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 748);
            this.Controls.Add(this.studentFeeGridControl);
            this.Controls.Add(this.mainTabFormControl);
            this.IconOptions.Image = global::Kindergarten.Properties.Resources._3361550;
            this.Name = "ManageStudentFeeTblForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabFormControl = this.mainTabFormControl;
            this.Text = "إدارة سجلات الطلاب";
            this.Load += new System.EventHandler(this.ManageStudentFeeTblForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainTabFormControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentFeeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentFeeTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentFeeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fePrRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feePeriodTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shYeRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scholasticYearTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edLeRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditRepositoryItemDateEdit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditRepositoryItemDateEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.TabFormControl mainTabFormControl;
        private DevExpress.XtraGrid.GridControl studentFeeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView studentFeeGridView;
        private KindergartenDbDataSet kindergartenDbDataSet;
        private DevExpress.XtraBars.BarButtonItem saveChangesBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem viewCardBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem exportToExcelBarButtonItem;
        private System.Windows.Forms.Timer mainTimer;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private KindergartenDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit shYeRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource scholasticYearTblBindingSource;
        private KindergartenDbDataSetTableAdapters.ScholasticYearTblTableAdapter scholasticYearTblTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit edLeRepositoryItemLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dateEditRepositoryItemDateEdit;
        private System.Windows.Forms.BindingSource studentFeeTblBindingSource;
        private KindergartenDbDataSetTableAdapters.StudentFeeTblTableAdapter studentFeeTblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colStudentID;
        private DevExpress.XtraGrid.Columns.GridColumn colFeePeriod;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit fePrRepositoryItemLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colFeePayingDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFeeScholasticYear;
        private DevExpress.XtraGrid.Columns.GridColumn colFeeAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colVoucherNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colVoucherPreparedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colInsertedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModifiedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colInsertedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModifiedBy;
        private System.Windows.Forms.BindingSource feePeriodTblBindingSource;
        private KindergartenDbDataSetTableAdapters.FeePeriodTblTableAdapter feePeriodTblTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit stuRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource studentTblBindingSource;
        private KindergartenDbDataSetTableAdapters.StudentTblTableAdapter studentTblTableAdapter;
    }
}