
namespace AssetManagement.Finance
{
    partial class FinancialReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialReportsForm));
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.toDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.fromDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.fromDateLabel = new System.Windows.Forms.Label();
            this.toDateLabel = new System.Windows.Forms.Label();
            this.financialItemGridControl = new DevExpress.XtraGrid.GridControl();
            this.financialItemGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colمعرفالسجلالمالي = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colكودالسجلالمالي = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colاسمالبندالمالي = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colبيانالسجلالمالي = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالدائرة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالقسم = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالوحدة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colتاريختحريرالسجل = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colواردأمصادر = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالمبلغالوارد = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالمبلغالصادر = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالعملة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colملاحظاتإضافية = new DevExpress.XtraGrid.Columns.GridColumn();
            this.financialItemCategoryRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.financialItemCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.currencyRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.currencyTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.departmentTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subdRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.subDepartmentTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.financialItemTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialItemTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.FinancialItemTblTableAdapter();
            this.searchFinancialItemDropDownButton = new DevExpress.XtraEditors.DropDownButton();
            this.exportFinancialReportToExcelDropDownButton = new DevExpress.XtraEditors.DropDownButton();
            this.financialItemCategoryTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.FinancialItemCategoryTblTableAdapter();
            this.currencyTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.CurrencyTblTableAdapter();
            this.fromToPanel = new System.Windows.Forms.Panel();
            this.fromToRadioButton = new System.Windows.Forms.RadioButton();
            this.monthlyRadioButton = new System.Windows.Forms.RadioButton();
            this.annualRadioButton = new System.Windows.Forms.RadioButton();
            this.monthlyDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.annualDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchWithinPeriodPanel = new System.Windows.Forms.Panel();
            this.searchByDepartmentRadioButton = new System.Windows.Forms.RadioButton();
            this.searchAllRadioButton = new System.Windows.Forms.RadioButton();
            this.searchWithinPeriodCheckBox = new System.Windows.Forms.CheckBox();
            this.manageDepartmentTblBtn = new System.Windows.Forms.Button();
            this.searchByDepartmentLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.departmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter();
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.sectionTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SectionTblTableAdapter();
            this.subDepartmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SubDepartmentTblTableAdapter();
            this.searchBySectionRadioButton = new System.Windows.Forms.RadioButton();
            this.searchBySubDepartmentRadioButton = new System.Windows.Forms.RadioButton();
            this.manageSectionTblBtn = new System.Windows.Forms.Button();
            this.searchBySectionLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.sectionTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manageSubDepartmentTblBtn = new System.Windows.Forms.Button();
            this.searchBySubDepartmentLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.subDepartmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialItemVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialItemVwTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.FinancialItemVwTableAdapter();
            this.financialItemVwBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.toDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subdRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemTblBindingSource)).BeginInit();
            this.fromToPanel.SuspendLayout();
            this.searchWithinPeriodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchByDepartmentLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBySectionLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBySubDepartmentLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemVwBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // toDateDateEdit
            // 
            this.toDateDateEdit.EditValue = null;
            this.toDateDateEdit.Location = new System.Drawing.Point(19, 73);
            this.toDateDateEdit.Name = "toDateDateEdit";
            this.toDateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.toDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDateDateEdit.Size = new System.Drawing.Size(243, 28);
            this.toDateDateEdit.TabIndex = 85;
            // 
            // fromDateDateEdit
            // 
            this.fromDateDateEdit.EditValue = null;
            this.fromDateDateEdit.Location = new System.Drawing.Point(19, 18);
            this.fromDateDateEdit.Name = "fromDateDateEdit";
            this.fromDateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.fromDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDateDateEdit.Size = new System.Drawing.Size(243, 28);
            this.fromDateDateEdit.TabIndex = 75;
            // 
            // fromDateLabel
            // 
            this.fromDateLabel.AutoSize = true;
            this.fromDateLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateLabel.Location = new System.Drawing.Point(296, 22);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.Size = new System.Drawing.Size(67, 21);
            this.fromDateLabel.TabIndex = 70;
            this.fromDateLabel.Text = "من تاريخ:";
            // 
            // toDateLabel
            // 
            this.toDateLabel.AutoSize = true;
            this.toDateLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateLabel.Location = new System.Drawing.Point(282, 77);
            this.toDateLabel.Name = "toDateLabel";
            this.toDateLabel.Size = new System.Drawing.Size(77, 21);
            this.toDateLabel.TabIndex = 80;
            this.toDateLabel.Text = "لغاية تاريخ:";
            // 
            // financialItemGridControl
            // 
            this.financialItemGridControl.DataSource = this.financialItemVwBindingSource;
            this.financialItemGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.financialItemGridControl.Location = new System.Drawing.Point(590, 0);
            this.financialItemGridControl.MainView = this.financialItemGridView;
            this.financialItemGridControl.Name = "financialItemGridControl";
            this.financialItemGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.financialItemCategoryRepositoryItemLookUpEdit,
            this.currencyRepositoryItemLookUpEdit,
            this.repositoryItemLookUpEdit1,
            this.subdRepositoryItemLookUpEdit});
            this.financialItemGridControl.Size = new System.Drawing.Size(791, 726);
            this.financialItemGridControl.TabIndex = 600;
            this.financialItemGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.financialItemGridView});
            this.financialItemGridControl.Visible = false;
            // 
            // financialItemGridView
            // 
            this.financialItemGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colمعرفالسجلالمالي,
            this.colكودالسجلالمالي,
            this.colاسمالبندالمالي,
            this.colبيانالسجلالمالي,
            this.colالدائرة,
            this.colالقسم,
            this.colالوحدة,
            this.colتاريختحريرالسجل,
            this.colواردأمصادر,
            this.colالمبلغالوارد,
            this.colالمبلغالصادر,
            this.colالعملة,
            this.colملاحظاتإضافية});
            this.financialItemGridView.GridControl = this.financialItemGridControl;
            this.financialItemGridView.Name = "financialItemGridView";
            // 
            // colمعرفالسجلالمالي
            // 
            this.colمعرفالسجلالمالي.FieldName = "معرف السجل المالي";
            this.colمعرفالسجلالمالي.MinWidth = 100;
            this.colمعرفالسجلالمالي.Name = "colمعرفالسجلالمالي";
            this.colمعرفالسجلالمالي.Width = 94;
            // 
            // colكودالسجلالمالي
            // 
            this.colكودالسجلالمالي.FieldName = "كود السجل المالي";
            this.colكودالسجلالمالي.MinWidth = 120;
            this.colكودالسجلالمالي.Name = "colكودالسجلالمالي";
            this.colكودالسجلالمالي.Width = 94;
            // 
            // colاسمالبندالمالي
            // 
            this.colاسمالبندالمالي.FieldName = "اسم البند المالي";
            this.colاسمالبندالمالي.MinWidth = 150;
            this.colاسمالبندالمالي.Name = "colاسمالبندالمالي";
            this.colاسمالبندالمالي.Visible = true;
            this.colاسمالبندالمالي.VisibleIndex = 0;
            this.colاسمالبندالمالي.Width = 150;
            // 
            // colبيانالسجلالمالي
            // 
            this.colبيانالسجلالمالي.FieldName = "بيان السجل المالي";
            this.colبيانالسجلالمالي.MinWidth = 200;
            this.colبيانالسجلالمالي.Name = "colبيانالسجلالمالي";
            this.colبيانالسجلالمالي.Visible = true;
            this.colبيانالسجلالمالي.VisibleIndex = 1;
            this.colبيانالسجلالمالي.Width = 200;
            // 
            // colالدائرة
            // 
            this.colالدائرة.FieldName = "الدائرة";
            this.colالدائرة.MinWidth = 150;
            this.colالدائرة.Name = "colالدائرة";
            this.colالدائرة.Visible = true;
            this.colالدائرة.VisibleIndex = 2;
            this.colالدائرة.Width = 150;
            // 
            // colالقسم
            // 
            this.colالقسم.FieldName = "القسم";
            this.colالقسم.MinWidth = 150;
            this.colالقسم.Name = "colالقسم";
            this.colالقسم.Visible = true;
            this.colالقسم.VisibleIndex = 3;
            this.colالقسم.Width = 150;
            // 
            // colالوحدة
            // 
            this.colالوحدة.FieldName = "الوحدة";
            this.colالوحدة.MinWidth = 150;
            this.colالوحدة.Name = "colالوحدة";
            this.colالوحدة.Visible = true;
            this.colالوحدة.VisibleIndex = 4;
            this.colالوحدة.Width = 150;
            // 
            // colتاريختحريرالسجل
            // 
            this.colتاريختحريرالسجل.FieldName = "تاريخ تحرير السجل";
            this.colتاريختحريرالسجل.MinWidth = 120;
            this.colتاريختحريرالسجل.Name = "colتاريختحريرالسجل";
            this.colتاريختحريرالسجل.Visible = true;
            this.colتاريختحريرالسجل.VisibleIndex = 5;
            this.colتاريختحريرالسجل.Width = 120;
            // 
            // colواردأمصادر
            // 
            this.colواردأمصادر.FieldName = "وارد أم صادر";
            this.colواردأمصادر.MinWidth = 120;
            this.colواردأمصادر.Name = "colواردأمصادر";
            this.colواردأمصادر.Visible = true;
            this.colواردأمصادر.VisibleIndex = 6;
            this.colواردأمصادر.Width = 120;
            // 
            // colالمبلغالوارد
            // 
            this.colالمبلغالوارد.FieldName = "المبلغ الوارد";
            this.colالمبلغالوارد.MinWidth = 120;
            this.colالمبلغالوارد.Name = "colالمبلغالوارد";
            this.colالمبلغالوارد.Visible = true;
            this.colالمبلغالوارد.VisibleIndex = 7;
            this.colالمبلغالوارد.Width = 120;
            // 
            // colالمبلغالصادر
            // 
            this.colالمبلغالصادر.FieldName = "المبلغ الصادر";
            this.colالمبلغالصادر.MinWidth = 120;
            this.colالمبلغالصادر.Name = "colالمبلغالصادر";
            this.colالمبلغالصادر.Visible = true;
            this.colالمبلغالصادر.VisibleIndex = 8;
            this.colالمبلغالصادر.Width = 120;
            // 
            // colالعملة
            // 
            this.colالعملة.FieldName = "العملة";
            this.colالعملة.MinWidth = 120;
            this.colالعملة.Name = "colالعملة";
            this.colالعملة.Visible = true;
            this.colالعملة.VisibleIndex = 9;
            this.colالعملة.Width = 120;
            // 
            // colملاحظاتإضافية
            // 
            this.colملاحظاتإضافية.FieldName = "ملاحظات إضافية";
            this.colملاحظاتإضافية.MinWidth = 200;
            this.colملاحظاتإضافية.Name = "colملاحظاتإضافية";
            this.colملاحظاتإضافية.Visible = true;
            this.colملاحظاتإضافية.VisibleIndex = 10;
            this.colملاحظاتإضافية.Width = 200;
            // 
            // financialItemCategoryRepositoryItemLookUpEdit
            // 
            this.financialItemCategoryRepositoryItemLookUpEdit.AutoHeight = false;
            this.financialItemCategoryRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.financialItemCategoryRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف البند المالي", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FinancialItemCategoryName", "اسم البند المالي", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FinancialItemCategoryDetails", "وصف البند المالي", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.financialItemCategoryRepositoryItemLookUpEdit.DataSource = this.financialItemCategoryTblBindingSource;
            this.financialItemCategoryRepositoryItemLookUpEdit.DisplayMember = "FinancialItemCategoryName";
            this.financialItemCategoryRepositoryItemLookUpEdit.Name = "financialItemCategoryRepositoryItemLookUpEdit";
            this.financialItemCategoryRepositoryItemLookUpEdit.PopupWidth = 500;
            this.financialItemCategoryRepositoryItemLookUpEdit.ValueMember = "ID";
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
            // currencyRepositoryItemLookUpEdit
            // 
            this.currencyRepositoryItemLookUpEdit.AutoHeight = false;
            this.currencyRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.currencyRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف العملة", 80, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyName", "اسم العملة", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.currencyRepositoryItemLookUpEdit.DataSource = this.currencyTblBindingSource;
            this.currencyRepositoryItemLookUpEdit.DisplayMember = "CurrencyName";
            this.currencyRepositoryItemLookUpEdit.Name = "currencyRepositoryItemLookUpEdit";
            this.currencyRepositoryItemLookUpEdit.PopupWidth = 500;
            this.currencyRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // currencyTblBindingSource
            // 
            this.currencyTblBindingSource.DataMember = "CurrencyTbl";
            this.currencyTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف القسم", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "اسم القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentHQ", "مقر القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEdit1.DataSource = this.departmentTblBindingSource1;
            this.repositoryItemLookUpEdit1.DisplayMember = "DepartmentName";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.PopupWidth = 500;
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // departmentTblBindingSource1
            // 
            this.departmentTblBindingSource1.DataMember = "DepartmentTbl";
            this.departmentTblBindingSource1.DataSource = this.assetMngDbDataSet;
            // 
            // subdRepositoryItemLookUpEdit
            // 
            this.subdRepositoryItemLookUpEdit.AutoHeight = false;
            this.subdRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.subdRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الوحدة", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubDepartmentName", "اسم الوحدة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainDepartment", "معرف القسم", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.subdRepositoryItemLookUpEdit.DataSource = this.subDepartmentTblBindingSource1;
            this.subdRepositoryItemLookUpEdit.DisplayMember = "SubDepartmentName";
            this.subdRepositoryItemLookUpEdit.Name = "subdRepositoryItemLookUpEdit";
            this.subdRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // subDepartmentTblBindingSource1
            // 
            this.subDepartmentTblBindingSource1.DataMember = "SubDepartmentTbl";
            this.subDepartmentTblBindingSource1.DataSource = this.assetMngDbDataSet;
            // 
            // financialItemTblBindingSource
            // 
            this.financialItemTblBindingSource.DataMember = "FinancialItemTbl";
            this.financialItemTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // financialItemTblTableAdapter
            // 
            this.financialItemTblTableAdapter.ClearBeforeFill = true;
            // 
            // searchFinancialItemDropDownButton
            // 
            this.searchFinancialItemDropDownButton.ImageOptions.Image = global::AssetManagement.Properties.Resources._2719309;
            this.searchFinancialItemDropDownButton.Location = new System.Drawing.Point(65, 633);
            this.searchFinancialItemDropDownButton.Name = "searchFinancialItemDropDownButton";
            this.searchFinancialItemDropDownButton.Size = new System.Drawing.Size(163, 73);
            this.searchFinancialItemDropDownButton.TabIndex = 300;
            this.searchFinancialItemDropDownButton.Text = "بحث";
            this.searchFinancialItemDropDownButton.Click += new System.EventHandler(this.searchFinancialItemDropDownButton_Click);
            // 
            // exportFinancialReportToExcelDropDownButton
            // 
            this.exportFinancialReportToExcelDropDownButton.Enabled = false;
            this.exportFinancialReportToExcelDropDownButton.ImageOptions.Image = global::AssetManagement.Properties.Resources._3643510;
            this.exportFinancialReportToExcelDropDownButton.Location = new System.Drawing.Point(270, 633);
            this.exportFinancialReportToExcelDropDownButton.Name = "exportFinancialReportToExcelDropDownButton";
            this.exportFinancialReportToExcelDropDownButton.Size = new System.Drawing.Size(163, 73);
            this.exportFinancialReportToExcelDropDownButton.TabIndex = 350;
            this.exportFinancialReportToExcelDropDownButton.Text = "تصدير الجرد";
            this.exportFinancialReportToExcelDropDownButton.Click += new System.EventHandler(this.exportFinancialReportToExcelDropDownButton_Click);
            // 
            // financialItemCategoryTblTableAdapter
            // 
            this.financialItemCategoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // currencyTblTableAdapter
            // 
            this.currencyTblTableAdapter.ClearBeforeFill = true;
            // 
            // fromToPanel
            // 
            this.fromToPanel.Controls.Add(this.fromDateLabel);
            this.fromToPanel.Controls.Add(this.fromDateDateEdit);
            this.fromToPanel.Controls.Add(this.toDateLabel);
            this.fromToPanel.Controls.Add(this.toDateDateEdit);
            this.fromToPanel.Location = new System.Drawing.Point(37, 50);
            this.fromToPanel.Name = "fromToPanel";
            this.fromToPanel.Size = new System.Drawing.Size(398, 129);
            this.fromToPanel.TabIndex = 65;
            // 
            // fromToRadioButton
            // 
            this.fromToRadioButton.AutoSize = true;
            this.fromToRadioButton.Checked = true;
            this.fromToRadioButton.Location = new System.Drawing.Point(342, 19);
            this.fromToRadioButton.Name = "fromToRadioButton";
            this.fromToRadioButton.Size = new System.Drawing.Size(93, 25);
            this.fromToRadioButton.TabIndex = 60;
            this.fromToRadioButton.TabStop = true;
            this.fromToRadioButton.Text = "بين تاريخين";
            this.fromToRadioButton.UseVisualStyleBackColor = true;
            this.fromToRadioButton.CheckedChanged += new System.EventHandler(this.SelectReportDuration);
            // 
            // monthlyRadioButton
            // 
            this.monthlyRadioButton.AutoSize = true;
            this.monthlyRadioButton.Location = new System.Drawing.Point(369, 199);
            this.monthlyRadioButton.Name = "monthlyRadioButton";
            this.monthlyRadioButton.Size = new System.Drawing.Size(66, 25);
            this.monthlyRadioButton.TabIndex = 90;
            this.monthlyRadioButton.Text = "شهري";
            this.monthlyRadioButton.UseVisualStyleBackColor = true;
            this.monthlyRadioButton.CheckedChanged += new System.EventHandler(this.SelectReportDuration);
            // 
            // annualRadioButton
            // 
            this.annualRadioButton.AutoSize = true;
            this.annualRadioButton.Location = new System.Drawing.Point(370, 248);
            this.annualRadioButton.Name = "annualRadioButton";
            this.annualRadioButton.Size = new System.Drawing.Size(65, 25);
            this.annualRadioButton.TabIndex = 100;
            this.annualRadioButton.Text = "سنوي";
            this.annualRadioButton.UseVisualStyleBackColor = true;
            this.annualRadioButton.CheckedChanged += new System.EventHandler(this.SelectReportDuration);
            // 
            // monthlyDateTimePicker
            // 
            this.monthlyDateTimePicker.CustomFormat = "yyyy. MMMM";
            this.monthlyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthlyDateTimePicker.Location = new System.Drawing.Point(76, 197);
            this.monthlyDateTimePicker.Name = "monthlyDateTimePicker";
            this.monthlyDateTimePicker.Size = new System.Drawing.Size(243, 28);
            this.monthlyDateTimePicker.TabIndex = 95;
            this.monthlyDateTimePicker.Visible = false;
            // 
            // annualDateTimePicker
            // 
            this.annualDateTimePicker.CustomFormat = "yyyy";
            this.annualDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.annualDateTimePicker.Location = new System.Drawing.Point(76, 246);
            this.annualDateTimePicker.Name = "annualDateTimePicker";
            this.annualDateTimePicker.Size = new System.Drawing.Size(243, 28);
            this.annualDateTimePicker.TabIndex = 105;
            this.annualDateTimePicker.Visible = false;
            // 
            // searchWithinPeriodPanel
            // 
            this.searchWithinPeriodPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchWithinPeriodPanel.Controls.Add(this.fromToRadioButton);
            this.searchWithinPeriodPanel.Controls.Add(this.annualDateTimePicker);
            this.searchWithinPeriodPanel.Controls.Add(this.fromToPanel);
            this.searchWithinPeriodPanel.Controls.Add(this.monthlyDateTimePicker);
            this.searchWithinPeriodPanel.Controls.Add(this.monthlyRadioButton);
            this.searchWithinPeriodPanel.Controls.Add(this.annualRadioButton);
            this.searchWithinPeriodPanel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchWithinPeriodPanel.Location = new System.Drawing.Point(21, 288);
            this.searchWithinPeriodPanel.Name = "searchWithinPeriodPanel";
            this.searchWithinPeriodPanel.Size = new System.Drawing.Size(459, 294);
            this.searchWithinPeriodPanel.TabIndex = 55;
            this.searchWithinPeriodPanel.Visible = false;
            // 
            // searchByDepartmentRadioButton
            // 
            this.searchByDepartmentRadioButton.AutoSize = true;
            this.searchByDepartmentRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByDepartmentRadioButton.Location = new System.Drawing.Point(21, 135);
            this.searchByDepartmentRadioButton.Name = "searchByDepartmentRadioButton";
            this.searchByDepartmentRadioButton.Size = new System.Drawing.Size(124, 25);
            this.searchByDepartmentRadioButton.TabIndex = 5;
            this.searchByDepartmentRadioButton.Text = "ضمن قسم معين";
            this.searchByDepartmentRadioButton.UseVisualStyleBackColor = true;
            this.searchByDepartmentRadioButton.CheckedChanged += new System.EventHandler(this.searchInDeptRadioButton_CheckedChanged);
            // 
            // searchAllRadioButton
            // 
            this.searchAllRadioButton.AutoSize = true;
            this.searchAllRadioButton.Checked = true;
            this.searchAllRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchAllRadioButton.Location = new System.Drawing.Point(21, 15);
            this.searchAllRadioButton.Name = "searchAllRadioButton";
            this.searchAllRadioButton.Size = new System.Drawing.Size(144, 25);
            this.searchAllRadioButton.TabIndex = 15;
            this.searchAllRadioButton.TabStop = true;
            this.searchAllRadioButton.Text = "كل السجلات المالية";
            this.searchAllRadioButton.UseVisualStyleBackColor = true;
            this.searchAllRadioButton.CheckedChanged += new System.EventHandler(this.searchInDeptRadioButton_CheckedChanged);
            // 
            // searchWithinPeriodCheckBox
            // 
            this.searchWithinPeriodCheckBox.AutoSize = true;
            this.searchWithinPeriodCheckBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchWithinPeriodCheckBox.Location = new System.Drawing.Point(21, 255);
            this.searchWithinPeriodCheckBox.Name = "searchWithinPeriodCheckBox";
            this.searchWithinPeriodCheckBox.Size = new System.Drawing.Size(165, 25);
            this.searchWithinPeriodCheckBox.TabIndex = 50;
            this.searchWithinPeriodCheckBox.Text = "بحث ضمن فترة محددة";
            this.searchWithinPeriodCheckBox.UseVisualStyleBackColor = true;
            this.searchWithinPeriodCheckBox.CheckedChanged += new System.EventHandler(this.searchWithinPeriodCheckBox_CheckedChanged);
            // 
            // manageDepartmentTblBtn
            // 
            this.manageDepartmentTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageDepartmentTblBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageDepartmentTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageDepartmentTblBtn.Location = new System.Drawing.Point(422, 120);
            this.manageDepartmentTblBtn.Name = "manageDepartmentTblBtn";
            this.manageDepartmentTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageDepartmentTblBtn.TabIndex = 206;
            this.manageDepartmentTblBtn.UseVisualStyleBackColor = true;
            this.manageDepartmentTblBtn.Visible = false;
            this.manageDepartmentTblBtn.Click += new System.EventHandler(this.manageDepartmentTblBtn_Click);
            // 
            // searchByDepartmentLookUpEdit
            // 
            this.searchByDepartmentLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByDepartmentLookUpEdit.Location = new System.Drawing.Point(162, 133);
            this.searchByDepartmentLookUpEdit.Name = "searchByDepartmentLookUpEdit";
            this.searchByDepartmentLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByDepartmentLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.searchByDepartmentLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchByDepartmentLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف القسم", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "اسم القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentHQ", "مقر القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.searchByDepartmentLookUpEdit.Properties.DataSource = this.departmentTblBindingSource;
            this.searchByDepartmentLookUpEdit.Properties.DisplayMember = "DepartmentName";
            this.searchByDepartmentLookUpEdit.Properties.PopupWidth = 500;
            this.searchByDepartmentLookUpEdit.Properties.ValueMember = "ID";
            this.searchByDepartmentLookUpEdit.Size = new System.Drawing.Size(243, 28);
            this.searchByDepartmentLookUpEdit.TabIndex = 205;
            this.searchByDepartmentLookUpEdit.Visible = false;
            // 
            // departmentTblBindingSource
            // 
            this.departmentTblBindingSource.DataMember = "DepartmentTbl";
            this.departmentTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // departmentTblTableAdapter
            // 
            this.departmentTblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssetMovementTblTableAdapter = null;
            this.tableAdapterManager.AssetTblTableAdapter = null;
            this.tableAdapterManager.AssetTransactionTblTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CurrencyTblTableAdapter = this.currencyTblTableAdapter;
            this.tableAdapterManager.DepartmentTblTableAdapter = this.departmentTblTableAdapter;
            this.tableAdapterManager.EstateAreaUnitTblTableAdapter = null;
            this.tableAdapterManager.FinancialItemCategoryTblTableAdapter = this.financialItemCategoryTblTableAdapter;
            this.tableAdapterManager.FinancialItemTblTableAdapter = this.financialItemTblTableAdapter;
            this.tableAdapterManager.ImportExportTblTableAdapter = null;
            this.tableAdapterManager.MainCategoryTblTableAdapter = null;
            this.tableAdapterManager.MinorCategoryTblTableAdapter = null;
            this.tableAdapterManager.ModelTblTableAdapter = null;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.SectionTblTableAdapter = this.sectionTblTableAdapter;
            this.tableAdapterManager.SquareTblTableAdapter = null;
            this.tableAdapterManager.StatusTblTableAdapter = null;
            this.tableAdapterManager.SubDepartmentTblTableAdapter = this.subDepartmentTblTableAdapter;
            this.tableAdapterManager.TransactionTypeTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // sectionTblTableAdapter
            // 
            this.sectionTblTableAdapter.ClearBeforeFill = true;
            // 
            // subDepartmentTblTableAdapter
            // 
            this.subDepartmentTblTableAdapter.ClearBeforeFill = true;
            // 
            // searchBySectionRadioButton
            // 
            this.searchBySectionRadioButton.AutoSize = true;
            this.searchBySectionRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBySectionRadioButton.Location = new System.Drawing.Point(21, 75);
            this.searchBySectionRadioButton.Name = "searchBySectionRadioButton";
            this.searchBySectionRadioButton.Size = new System.Drawing.Size(128, 25);
            this.searchBySectionRadioButton.TabIndex = 601;
            this.searchBySectionRadioButton.Text = "ضمن دائرة معينة";
            this.searchBySectionRadioButton.UseVisualStyleBackColor = true;
            this.searchBySectionRadioButton.CheckedChanged += new System.EventHandler(this.searchInDeptRadioButton_CheckedChanged);
            // 
            // searchBySubDepartmentRadioButton
            // 
            this.searchBySubDepartmentRadioButton.AutoSize = true;
            this.searchBySubDepartmentRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBySubDepartmentRadioButton.Location = new System.Drawing.Point(21, 195);
            this.searchBySubDepartmentRadioButton.Name = "searchBySubDepartmentRadioButton";
            this.searchBySubDepartmentRadioButton.Size = new System.Drawing.Size(132, 25);
            this.searchBySubDepartmentRadioButton.TabIndex = 602;
            this.searchBySubDepartmentRadioButton.Text = "ضمن وحدة معينة";
            this.searchBySubDepartmentRadioButton.UseVisualStyleBackColor = true;
            this.searchBySubDepartmentRadioButton.CheckedChanged += new System.EventHandler(this.searchInDeptRadioButton_CheckedChanged);
            // 
            // manageSectionTblBtn
            // 
            this.manageSectionTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageSectionTblBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageSectionTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageSectionTblBtn.Location = new System.Drawing.Point(422, 60);
            this.manageSectionTblBtn.Name = "manageSectionTblBtn";
            this.manageSectionTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageSectionTblBtn.TabIndex = 604;
            this.manageSectionTblBtn.UseVisualStyleBackColor = true;
            this.manageSectionTblBtn.Visible = false;
            this.manageSectionTblBtn.Click += new System.EventHandler(this.manageSectionTblBtn_Click);
            // 
            // searchBySectionLookUpEdit
            // 
            this.searchBySectionLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBySectionLookUpEdit.Location = new System.Drawing.Point(162, 73);
            this.searchBySectionLookUpEdit.Name = "searchBySectionLookUpEdit";
            this.searchBySectionLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBySectionLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.searchBySectionLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchBySectionLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الدائرة", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SectionName", "اسم الدائرة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.searchBySectionLookUpEdit.Properties.DataSource = this.sectionTblBindingSource;
            this.searchBySectionLookUpEdit.Properties.DisplayMember = "SectionName";
            this.searchBySectionLookUpEdit.Properties.PopupWidth = 500;
            this.searchBySectionLookUpEdit.Properties.ValueMember = "ID";
            this.searchBySectionLookUpEdit.Size = new System.Drawing.Size(243, 28);
            this.searchBySectionLookUpEdit.TabIndex = 603;
            this.searchBySectionLookUpEdit.Visible = false;
            // 
            // sectionTblBindingSource
            // 
            this.sectionTblBindingSource.DataMember = "SectionTbl";
            this.sectionTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // manageSubDepartmentTblBtn
            // 
            this.manageSubDepartmentTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageSubDepartmentTblBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageSubDepartmentTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageSubDepartmentTblBtn.Location = new System.Drawing.Point(422, 180);
            this.manageSubDepartmentTblBtn.Name = "manageSubDepartmentTblBtn";
            this.manageSubDepartmentTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageSubDepartmentTblBtn.TabIndex = 606;
            this.manageSubDepartmentTblBtn.UseVisualStyleBackColor = true;
            this.manageSubDepartmentTblBtn.Visible = false;
            this.manageSubDepartmentTblBtn.Click += new System.EventHandler(this.manageSubDepartmentTblBtn_Click);
            // 
            // searchBySubDepartmentLookUpEdit
            // 
            this.searchBySubDepartmentLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBySubDepartmentLookUpEdit.Location = new System.Drawing.Point(162, 193);
            this.searchBySubDepartmentLookUpEdit.Name = "searchBySubDepartmentLookUpEdit";
            this.searchBySubDepartmentLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBySubDepartmentLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.searchBySubDepartmentLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchBySubDepartmentLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الوحدة", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubDepartmentName", "اسم الوحدة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainDepartment", "معرف القسم", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.searchBySubDepartmentLookUpEdit.Properties.DataSource = this.subDepartmentTblBindingSource;
            this.searchBySubDepartmentLookUpEdit.Properties.DisplayMember = "SubDepartmentName";
            this.searchBySubDepartmentLookUpEdit.Properties.PopupWidth = 500;
            this.searchBySubDepartmentLookUpEdit.Properties.ValueMember = "ID";
            this.searchBySubDepartmentLookUpEdit.Size = new System.Drawing.Size(243, 28);
            this.searchBySubDepartmentLookUpEdit.TabIndex = 605;
            this.searchBySubDepartmentLookUpEdit.Visible = false;
            // 
            // subDepartmentTblBindingSource
            // 
            this.subDepartmentTblBindingSource.DataMember = "SubDepartmentTbl";
            this.subDepartmentTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // financialItemVwBindingSource
            // 
            this.financialItemVwBindingSource.DataMember = "FinancialItemVw";
            this.financialItemVwBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // financialItemVwTableAdapter
            // 
            this.financialItemVwTableAdapter.ClearBeforeFill = true;
            // 
            // financialItemVwBindingSource1
            // 
            this.financialItemVwBindingSource1.DataMember = "FinancialItemVw";
            this.financialItemVwBindingSource1.DataSource = this.assetMngDbDataSet;
            // 
            // FinancialReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 726);
            this.Controls.Add(this.manageSubDepartmentTblBtn);
            this.Controls.Add(this.searchBySubDepartmentLookUpEdit);
            this.Controls.Add(this.manageSectionTblBtn);
            this.Controls.Add(this.searchBySectionLookUpEdit);
            this.Controls.Add(this.searchBySubDepartmentRadioButton);
            this.Controls.Add(this.searchBySectionRadioButton);
            this.Controls.Add(this.manageDepartmentTblBtn);
            this.Controls.Add(this.searchByDepartmentLookUpEdit);
            this.Controls.Add(this.searchWithinPeriodCheckBox);
            this.Controls.Add(this.searchAllRadioButton);
            this.Controls.Add(this.searchByDepartmentRadioButton);
            this.Controls.Add(this.searchWithinPeriodPanel);
            this.Controls.Add(this.searchFinancialItemDropDownButton);
            this.Controls.Add(this.exportFinancialReportToExcelDropDownButton);
            this.Controls.Add(this.financialItemGridControl);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FinancialReportsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التقارير المالية";
            this.Load += new System.EventHandler(this.FinancialReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subdRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemTblBindingSource)).EndInit();
            this.fromToPanel.ResumeLayout(false);
            this.fromToPanel.PerformLayout();
            this.searchWithinPeriodPanel.ResumeLayout(false);
            this.searchWithinPeriodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchByDepartmentLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBySectionLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBySubDepartmentLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemVwBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private DevExpress.XtraEditors.DateEdit toDateDateEdit;
        private DevExpress.XtraEditors.DateEdit fromDateDateEdit;
        private System.Windows.Forms.Label fromDateLabel;
        private System.Windows.Forms.Label toDateLabel;
        private DevExpress.XtraGrid.GridControl financialItemGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView financialItemGridView;
        private AssetMngDbDataSet assetMngDbDataSet;
        private System.Windows.Forms.BindingSource financialItemTblBindingSource;
        private AssetMngDbDataSetTableAdapters.FinancialItemTblTableAdapter financialItemTblTableAdapter;
        private DevExpress.XtraEditors.DropDownButton searchFinancialItemDropDownButton;
        private DevExpress.XtraEditors.DropDownButton exportFinancialReportToExcelDropDownButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit financialItemCategoryRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource financialItemCategoryTblBindingSource;
        private AssetMngDbDataSetTableAdapters.FinancialItemCategoryTblTableAdapter financialItemCategoryTblTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit currencyRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource currencyTblBindingSource;
        private AssetMngDbDataSetTableAdapters.CurrencyTblTableAdapter currencyTblTableAdapter;
        private System.Windows.Forms.Panel fromToPanel;
        private System.Windows.Forms.RadioButton fromToRadioButton;
        private System.Windows.Forms.RadioButton monthlyRadioButton;
        private System.Windows.Forms.RadioButton annualRadioButton;
        private System.Windows.Forms.DateTimePicker monthlyDateTimePicker;
        private System.Windows.Forms.DateTimePicker annualDateTimePicker;
        private System.Windows.Forms.Panel searchWithinPeriodPanel;
        private System.Windows.Forms.RadioButton searchByDepartmentRadioButton;
        private System.Windows.Forms.RadioButton searchAllRadioButton;
        private System.Windows.Forms.CheckBox searchWithinPeriodCheckBox;
        private System.Windows.Forms.Button manageDepartmentTblBtn;
        private DevExpress.XtraEditors.LookUpEdit searchByDepartmentLookUpEdit;
        private System.Windows.Forms.BindingSource departmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter departmentTblTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource departmentTblBindingSource1;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.RadioButton searchBySectionRadioButton;
        private System.Windows.Forms.RadioButton searchBySubDepartmentRadioButton;
        private System.Windows.Forms.Button manageSectionTblBtn;
        private DevExpress.XtraEditors.LookUpEdit searchBySectionLookUpEdit;
        private System.Windows.Forms.Button manageSubDepartmentTblBtn;
        private DevExpress.XtraEditors.LookUpEdit searchBySubDepartmentLookUpEdit;
        private System.Windows.Forms.BindingSource sectionTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SectionTblTableAdapter sectionTblTableAdapter;
        private System.Windows.Forms.BindingSource subDepartmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SubDepartmentTblTableAdapter subDepartmentTblTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit subdRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource subDepartmentTblBindingSource1;
        private System.Windows.Forms.BindingSource financialItemVwBindingSource;
        private AssetMngDbDataSetTableAdapters.FinancialItemVwTableAdapter financialItemVwTableAdapter;
        private System.Windows.Forms.BindingSource financialItemVwBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colمعرفالسجلالمالي;
        private DevExpress.XtraGrid.Columns.GridColumn colكودالسجلالمالي;
        private DevExpress.XtraGrid.Columns.GridColumn colاسمالبندالمالي;
        private DevExpress.XtraGrid.Columns.GridColumn colبيانالسجلالمالي;
        private DevExpress.XtraGrid.Columns.GridColumn colالدائرة;
        private DevExpress.XtraGrid.Columns.GridColumn colالقسم;
        private DevExpress.XtraGrid.Columns.GridColumn colالوحدة;
        private DevExpress.XtraGrid.Columns.GridColumn colتاريختحريرالسجل;
        private DevExpress.XtraGrid.Columns.GridColumn colواردأمصادر;
        private DevExpress.XtraGrid.Columns.GridColumn colالمبلغالوارد;
        private DevExpress.XtraGrid.Columns.GridColumn colالمبلغالصادر;
        private DevExpress.XtraGrid.Columns.GridColumn colالعملة;
        private DevExpress.XtraGrid.Columns.GridColumn colملاحظاتإضافية;
    }
}