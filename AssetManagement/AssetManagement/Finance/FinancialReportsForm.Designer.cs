
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialReportsForm));
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.toDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.fromDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.fromDateLabel = new System.Windows.Forms.Label();
            this.toDateLabel = new System.Windows.Forms.Label();
            this.financialItemVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.financialItemCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currencyTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.searchBySubDepartmentLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.subDepartmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialItemVwTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.FinancialItemVwTableAdapter();
            this.financialItemVwBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.manageSubDepartmentTblBtn = new System.Windows.Forms.Button();
            this.manageDepartmentTblBtn = new System.Windows.Forms.Button();
            this.financialReportTabControl = new System.Windows.Forms.TabControl();
            this.detailedFiguresTabPage = new System.Windows.Forms.TabPage();
            this.financialItemCategoryGridControl = new DevExpress.XtraGrid.GridControl();
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
            this.colجهةالإيراد = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colنوعالصادر = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colصادرإلى = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالمبلغالوارد = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالمبلغالصادر = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالعملة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colملاحظاتإضافية = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ficatRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.curRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.subdRpositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.financialItemTblPanel = new System.Windows.Forms.Panel();
            this.moneySummaryPanel = new System.Windows.Forms.Panel();
            this.subLevelTotalsTreeView = new System.Windows.Forms.TreeView();
            this.totalCycledNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.totalCycledLabel = new System.Windows.Forms.Label();
            this.totalOutcomesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.totalOutcomesLabel = new System.Windows.Forms.Label();
            this.totalIncomesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.totalIncomesLabel = new System.Windows.Forms.Label();
            this.aggFiguesTabPage = new System.Windows.Forms.TabPage();
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.manageCurrencyTblBtn = new System.Windows.Forms.Button();
            this.searchByCurrencyLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.searchByCurrencyCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.toDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource1)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.financialItemVwBindingSource1)).BeginInit();
            this.financialReportTabControl.SuspendLayout();
            this.detailedFiguresTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ficatRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subdRpositoryItemLookUpEdit)).BeginInit();
            this.financialItemTblPanel.SuspendLayout();
            this.moneySummaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalCycledNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalOutcomesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalIncomesNumericUpDown)).BeginInit();
            this.aggFiguesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchByCurrencyLookUpEdit.Properties)).BeginInit();
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
            // financialItemVwBindingSource
            // 
            this.financialItemVwBindingSource.DataMember = "FinancialItemVw";
            this.financialItemVwBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // financialItemCategoryTblBindingSource
            // 
            this.financialItemCategoryTblBindingSource.DataMember = "FinancialItemCategoryTbl";
            this.financialItemCategoryTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // currencyTblBindingSource
            // 
            this.currencyTblBindingSource.DataMember = "CurrencyTbl";
            this.currencyTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // departmentTblBindingSource1
            // 
            this.departmentTblBindingSource1.DataMember = "DepartmentTbl";
            this.departmentTblBindingSource1.DataSource = this.assetMngDbDataSet;
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
            this.searchFinancialItemDropDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchFinancialItemDropDownButton.ImageOptions.Image = global::AssetManagement.Properties.Resources._2719309;
            this.searchFinancialItemDropDownButton.Location = new System.Drawing.Point(74, 651);
            this.searchFinancialItemDropDownButton.Name = "searchFinancialItemDropDownButton";
            this.searchFinancialItemDropDownButton.Size = new System.Drawing.Size(163, 73);
            this.searchFinancialItemDropDownButton.TabIndex = 300;
            this.searchFinancialItemDropDownButton.Text = "بحث";
            this.searchFinancialItemDropDownButton.Click += new System.EventHandler(this.searchFinancialItemDropDownButton_Click);
            // 
            // exportFinancialReportToExcelDropDownButton
            // 
            this.exportFinancialReportToExcelDropDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportFinancialReportToExcelDropDownButton.Enabled = false;
            this.exportFinancialReportToExcelDropDownButton.ImageOptions.Image = global::AssetManagement.Properties.Resources._3643510;
            this.exportFinancialReportToExcelDropDownButton.Location = new System.Drawing.Point(279, 651);
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
            this.searchWithinPeriodPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchWithinPeriodPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchWithinPeriodPanel.Controls.Add(this.fromToRadioButton);
            this.searchWithinPeriodPanel.Controls.Add(this.annualDateTimePicker);
            this.searchWithinPeriodPanel.Controls.Add(this.fromToPanel);
            this.searchWithinPeriodPanel.Controls.Add(this.monthlyDateTimePicker);
            this.searchWithinPeriodPanel.Controls.Add(this.monthlyRadioButton);
            this.searchWithinPeriodPanel.Controls.Add(this.annualRadioButton);
            this.searchWithinPeriodPanel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchWithinPeriodPanel.Location = new System.Drawing.Point(30, 288);
            this.searchWithinPeriodPanel.Name = "searchWithinPeriodPanel";
            this.searchWithinPeriodPanel.Size = new System.Drawing.Size(459, 294);
            this.searchWithinPeriodPanel.TabIndex = 55;
            this.searchWithinPeriodPanel.Visible = false;
            // 
            // searchByDepartmentRadioButton
            // 
            this.searchByDepartmentRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByDepartmentRadioButton.AutoSize = true;
            this.searchByDepartmentRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByDepartmentRadioButton.Location = new System.Drawing.Point(30, 135);
            this.searchByDepartmentRadioButton.Name = "searchByDepartmentRadioButton";
            this.searchByDepartmentRadioButton.Size = new System.Drawing.Size(124, 25);
            this.searchByDepartmentRadioButton.TabIndex = 30;
            this.searchByDepartmentRadioButton.Text = "ضمن قسم معين";
            this.searchByDepartmentRadioButton.UseVisualStyleBackColor = true;
            this.searchByDepartmentRadioButton.CheckedChanged += new System.EventHandler(this.searchInDeptRadioButton_CheckedChanged);
            // 
            // searchAllRadioButton
            // 
            this.searchAllRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchAllRadioButton.AutoSize = true;
            this.searchAllRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchAllRadioButton.Location = new System.Drawing.Point(30, 15);
            this.searchAllRadioButton.Name = "searchAllRadioButton";
            this.searchAllRadioButton.Size = new System.Drawing.Size(144, 25);
            this.searchAllRadioButton.TabIndex = 15;
            this.searchAllRadioButton.Text = "كل السجلات المالية";
            this.searchAllRadioButton.UseVisualStyleBackColor = true;
            this.searchAllRadioButton.CheckedChanged += new System.EventHandler(this.searchInDeptRadioButton_CheckedChanged);
            // 
            // searchWithinPeriodCheckBox
            // 
            this.searchWithinPeriodCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchWithinPeriodCheckBox.AutoSize = true;
            this.searchWithinPeriodCheckBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchWithinPeriodCheckBox.Location = new System.Drawing.Point(30, 255);
            this.searchWithinPeriodCheckBox.Name = "searchWithinPeriodCheckBox";
            this.searchWithinPeriodCheckBox.Size = new System.Drawing.Size(165, 25);
            this.searchWithinPeriodCheckBox.TabIndex = 50;
            this.searchWithinPeriodCheckBox.Text = "بحث ضمن فترة محددة";
            this.searchWithinPeriodCheckBox.UseVisualStyleBackColor = true;
            this.searchWithinPeriodCheckBox.CheckedChanged += new System.EventHandler(this.searchWithinPeriodCheckBox_CheckedChanged);
            // 
            // searchByDepartmentLookUpEdit
            // 
            this.searchByDepartmentLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByDepartmentLookUpEdit.Location = new System.Drawing.Point(200, 133);
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
            this.searchByDepartmentLookUpEdit.TabIndex = 35;
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
            this.tableAdapterManager.IncomingTypeTblTableAdapter = null;
            this.tableAdapterManager.MainCategoryTblTableAdapter = null;
            this.tableAdapterManager.MinorCategoryTblTableAdapter = null;
            this.tableAdapterManager.ModelTblTableAdapter = null;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.OutgoingTypeTblTableAdapter = null;
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
            this.searchBySectionRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBySectionRadioButton.AutoSize = true;
            this.searchBySectionRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBySectionRadioButton.Location = new System.Drawing.Point(30, 75);
            this.searchBySectionRadioButton.Name = "searchBySectionRadioButton";
            this.searchBySectionRadioButton.Size = new System.Drawing.Size(128, 25);
            this.searchBySectionRadioButton.TabIndex = 20;
            this.searchBySectionRadioButton.Text = "ضمن دائرة معينة";
            this.searchBySectionRadioButton.UseVisualStyleBackColor = true;
            this.searchBySectionRadioButton.CheckedChanged += new System.EventHandler(this.searchInDeptRadioButton_CheckedChanged);
            // 
            // searchBySubDepartmentRadioButton
            // 
            this.searchBySubDepartmentRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBySubDepartmentRadioButton.AutoSize = true;
            this.searchBySubDepartmentRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBySubDepartmentRadioButton.Location = new System.Drawing.Point(30, 195);
            this.searchBySubDepartmentRadioButton.Name = "searchBySubDepartmentRadioButton";
            this.searchBySubDepartmentRadioButton.Size = new System.Drawing.Size(132, 25);
            this.searchBySubDepartmentRadioButton.TabIndex = 40;
            this.searchBySubDepartmentRadioButton.Text = "ضمن وحدة معينة";
            this.searchBySubDepartmentRadioButton.UseVisualStyleBackColor = true;
            this.searchBySubDepartmentRadioButton.CheckedChanged += new System.EventHandler(this.searchInDeptRadioButton_CheckedChanged);
            // 
            // manageSectionTblBtn
            // 
            this.manageSectionTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageSectionTblBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageSectionTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageSectionTblBtn.Location = new System.Drawing.Point(460, 60);
            this.manageSectionTblBtn.Name = "manageSectionTblBtn";
            this.manageSectionTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageSectionTblBtn.TabIndex = 26;
            this.manageSectionTblBtn.UseVisualStyleBackColor = true;
            this.manageSectionTblBtn.Visible = false;
            this.manageSectionTblBtn.Click += new System.EventHandler(this.manageSectionTblBtn_Click);
            // 
            // searchBySectionLookUpEdit
            // 
            this.searchBySectionLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBySectionLookUpEdit.Location = new System.Drawing.Point(200, 73);
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
            this.searchBySectionLookUpEdit.TabIndex = 25;
            this.searchBySectionLookUpEdit.Visible = false;
            // 
            // sectionTblBindingSource
            // 
            this.sectionTblBindingSource.DataMember = "SectionTbl";
            this.sectionTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // searchBySubDepartmentLookUpEdit
            // 
            this.searchBySubDepartmentLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBySubDepartmentLookUpEdit.Location = new System.Drawing.Point(200, 193);
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
            this.searchBySubDepartmentLookUpEdit.TabIndex = 45;
            this.searchBySubDepartmentLookUpEdit.Visible = false;
            // 
            // subDepartmentTblBindingSource
            // 
            this.subDepartmentTblBindingSource.DataMember = "SubDepartmentTbl";
            this.subDepartmentTblBindingSource.DataSource = this.assetMngDbDataSet;
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
            // manageSubDepartmentTblBtn
            // 
            this.manageSubDepartmentTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageSubDepartmentTblBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageSubDepartmentTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageSubDepartmentTblBtn.Location = new System.Drawing.Point(460, 180);
            this.manageSubDepartmentTblBtn.Name = "manageSubDepartmentTblBtn";
            this.manageSubDepartmentTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageSubDepartmentTblBtn.TabIndex = 46;
            this.manageSubDepartmentTblBtn.UseVisualStyleBackColor = true;
            this.manageSubDepartmentTblBtn.Visible = false;
            this.manageSubDepartmentTblBtn.Click += new System.EventHandler(this.manageSubDepartmentTblBtn_Click);
            // 
            // manageDepartmentTblBtn
            // 
            this.manageDepartmentTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageDepartmentTblBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageDepartmentTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageDepartmentTblBtn.Location = new System.Drawing.Point(460, 120);
            this.manageDepartmentTblBtn.Name = "manageDepartmentTblBtn";
            this.manageDepartmentTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageDepartmentTblBtn.TabIndex = 36;
            this.manageDepartmentTblBtn.UseVisualStyleBackColor = true;
            this.manageDepartmentTblBtn.Visible = false;
            this.manageDepartmentTblBtn.Click += new System.EventHandler(this.manageDepartmentTblBtn_Click);
            // 
            // financialReportTabControl
            // 
            this.financialReportTabControl.Controls.Add(this.detailedFiguresTabPage);
            this.financialReportTabControl.Controls.Add(this.aggFiguesTabPage);
            this.financialReportTabControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.financialReportTabControl.Location = new System.Drawing.Point(574, 0);
            this.financialReportTabControl.Name = "financialReportTabControl";
            this.financialReportTabControl.RightToLeftLayout = true;
            this.financialReportTabControl.SelectedIndex = 0;
            this.financialReportTabControl.Size = new System.Drawing.Size(736, 737);
            this.financialReportTabControl.TabIndex = 351;
            this.financialReportTabControl.Visible = false;
            // 
            // detailedFiguresTabPage
            // 
            this.detailedFiguresTabPage.Controls.Add(this.financialItemCategoryGridControl);
            this.detailedFiguresTabPage.Controls.Add(this.financialItemTblPanel);
            this.detailedFiguresTabPage.Location = new System.Drawing.Point(4, 33);
            this.detailedFiguresTabPage.Name = "detailedFiguresTabPage";
            this.detailedFiguresTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.detailedFiguresTabPage.Size = new System.Drawing.Size(728, 700);
            this.detailedFiguresTabPage.TabIndex = 0;
            this.detailedFiguresTabPage.Text = "الأرقام التفصيلية";
            this.detailedFiguresTabPage.UseVisualStyleBackColor = true;
            // 
            // financialItemCategoryGridControl
            // 
            this.financialItemCategoryGridControl.DataSource = this.financialItemVwBindingSource;
            this.financialItemCategoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financialItemCategoryGridControl.EmbeddedNavigator.Buttons.Append.Visible = false;
            gridLevelNode1.RelationName = "financialItemLevel";
            this.financialItemCategoryGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.financialItemCategoryGridControl.Location = new System.Drawing.Point(3, 322);
            this.financialItemCategoryGridControl.MainView = this.financialItemGridView;
            this.financialItemCategoryGridControl.Name = "financialItemCategoryGridControl";
            this.financialItemCategoryGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ficatRepositoryItemLookUpEdit,
            this.curRepositoryItemLookUpEdit,
            this.repositoryItemDateEdit1,
            this.repositoryItemLookUpEdit3,
            this.subdRpositoryItemLookUpEdit});
            this.financialItemCategoryGridControl.Size = new System.Drawing.Size(722, 375);
            this.financialItemCategoryGridControl.TabIndex = 653;
            this.financialItemCategoryGridControl.UseEmbeddedNavigator = true;
            this.financialItemCategoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.financialItemGridView});
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
            this.colجهةالإيراد,
            this.colنوعالصادر,
            this.colصادرإلى,
            this.colالمبلغالوارد,
            this.colالمبلغالصادر,
            this.colالعملة,
            this.colملاحظاتإضافية});
            this.financialItemGridView.GridControl = this.financialItemCategoryGridControl;
            this.financialItemGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "المبلغ الوارد", null, "(مجموع المبالغ الواردة={0:0.##})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "المبلغ الصادر", null, "(مجموع المبالغ الصادرة={0:0.##})")});
            this.financialItemGridView.Name = "financialItemGridView";
            this.financialItemGridView.OptionsBehavior.Editable = false;
            this.financialItemGridView.OptionsView.ShowFooter = true;
            this.financialItemGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colتاريختحريرالسجل, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colمعرفالسجلالمالي
            // 
            this.colمعرفالسجلالمالي.FieldName = "معرف السجل المالي";
            this.colمعرفالسجلالمالي.MinWidth = 100;
            this.colمعرفالسجلالمالي.Name = "colمعرفالسجلالمالي";
            this.colمعرفالسجلالمالي.Width = 100;
            // 
            // colكودالسجلالمالي
            // 
            this.colكودالسجلالمالي.FieldName = "كود السجل المالي";
            this.colكودالسجلالمالي.MinWidth = 150;
            this.colكودالسجلالمالي.Name = "colكودالسجلالمالي";
            this.colكودالسجلالمالي.Width = 150;
            // 
            // colاسمالبندالمالي
            // 
            this.colاسمالبندالمالي.FieldName = "اسم البند المالي";
            this.colاسمالبندالمالي.MinWidth = 200;
            this.colاسمالبندالمالي.Name = "colاسمالبندالمالي";
            this.colاسمالبندالمالي.Visible = true;
            this.colاسمالبندالمالي.VisibleIndex = 0;
            this.colاسمالبندالمالي.Width = 200;
            // 
            // colبيانالسجلالمالي
            // 
            this.colبيانالسجلالمالي.FieldName = "بيان السجل المالي";
            this.colبيانالسجلالمالي.MinWidth = 250;
            this.colبيانالسجلالمالي.Name = "colبيانالسجلالمالي";
            this.colبيانالسجلالمالي.Visible = true;
            this.colبيانالسجلالمالي.VisibleIndex = 1;
            this.colبيانالسجلالمالي.Width = 250;
            // 
            // colالدائرة
            // 
            this.colالدائرة.FieldName = "الدائرة";
            this.colالدائرة.MinWidth = 120;
            this.colالدائرة.Name = "colالدائرة";
            this.colالدائرة.Visible = true;
            this.colالدائرة.VisibleIndex = 2;
            this.colالدائرة.Width = 120;
            // 
            // colالقسم
            // 
            this.colالقسم.FieldName = "القسم";
            this.colالقسم.MinWidth = 120;
            this.colالقسم.Name = "colالقسم";
            this.colالقسم.Visible = true;
            this.colالقسم.VisibleIndex = 3;
            this.colالقسم.Width = 120;
            // 
            // colالوحدة
            // 
            this.colالوحدة.FieldName = "الوحدة";
            this.colالوحدة.MinWidth = 120;
            this.colالوحدة.Name = "colالوحدة";
            this.colالوحدة.Visible = true;
            this.colالوحدة.VisibleIndex = 4;
            this.colالوحدة.Width = 120;
            // 
            // colتاريختحريرالسجل
            // 
            this.colتاريختحريرالسجل.FieldName = "تاريخ تحرير السجل";
            this.colتاريختحريرالسجل.MinWidth = 150;
            this.colتاريختحريرالسجل.Name = "colتاريختحريرالسجل";
            this.colتاريختحريرالسجل.Visible = true;
            this.colتاريختحريرالسجل.VisibleIndex = 5;
            this.colتاريختحريرالسجل.Width = 150;
            // 
            // colواردأمصادر
            // 
            this.colواردأمصادر.FieldName = "وارد أم صادر";
            this.colواردأمصادر.MinWidth = 100;
            this.colواردأمصادر.Name = "colواردأمصادر";
            this.colواردأمصادر.Visible = true;
            this.colواردأمصادر.VisibleIndex = 6;
            this.colواردأمصادر.Width = 100;
            // 
            // colجهةالإيراد
            // 
            this.colجهةالإيراد.FieldName = "جهة الإيراد";
            this.colجهةالإيراد.MinWidth = 150;
            this.colجهةالإيراد.Name = "colجهةالإيراد";
            this.colجهةالإيراد.Visible = true;
            this.colجهةالإيراد.VisibleIndex = 7;
            this.colجهةالإيراد.Width = 150;
            // 
            // colنوعالصادر
            // 
            this.colنوعالصادر.FieldName = "نوع الصادر";
            this.colنوعالصادر.MinWidth = 150;
            this.colنوعالصادر.Name = "colنوعالصادر";
            this.colنوعالصادر.Visible = true;
            this.colنوعالصادر.VisibleIndex = 8;
            this.colنوعالصادر.Width = 150;
            // 
            // colصادرإلى
            // 
            this.colصادرإلى.FieldName = "صادر إلى";
            this.colصادرإلى.MinWidth = 150;
            this.colصادرإلى.Name = "colصادرإلى";
            this.colصادرإلى.Visible = true;
            this.colصادرإلى.VisibleIndex = 9;
            this.colصادرإلى.Width = 150;
            // 
            // colالمبلغالوارد
            // 
            this.colالمبلغالوارد.FieldName = "المبلغ الوارد";
            this.colالمبلغالوارد.MinWidth = 200;
            this.colالمبلغالوارد.Name = "colالمبلغالوارد";
            this.colالمبلغالوارد.Visible = true;
            this.colالمبلغالوارد.VisibleIndex = 10;
            this.colالمبلغالوارد.Width = 200;
            // 
            // colالمبلغالصادر
            // 
            this.colالمبلغالصادر.FieldName = "المبلغ الصادر";
            this.colالمبلغالصادر.MinWidth = 200;
            this.colالمبلغالصادر.Name = "colالمبلغالصادر";
            this.colالمبلغالصادر.Visible = true;
            this.colالمبلغالصادر.VisibleIndex = 11;
            this.colالمبلغالصادر.Width = 200;
            // 
            // colالعملة
            // 
            this.colالعملة.FieldName = "العملة";
            this.colالعملة.MinWidth = 100;
            this.colالعملة.Name = "colالعملة";
            this.colالعملة.Visible = true;
            this.colالعملة.VisibleIndex = 12;
            this.colالعملة.Width = 100;
            // 
            // colملاحظاتإضافية
            // 
            this.colملاحظاتإضافية.FieldName = "ملاحظات إضافية";
            this.colملاحظاتإضافية.MinWidth = 200;
            this.colملاحظاتإضافية.Name = "colملاحظاتإضافية";
            this.colملاحظاتإضافية.Visible = true;
            this.colملاحظاتإضافية.VisibleIndex = 13;
            this.colملاحظاتإضافية.Width = 200;
            // 
            // ficatRepositoryItemLookUpEdit
            // 
            this.ficatRepositoryItemLookUpEdit.AutoHeight = false;
            this.ficatRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ficatRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف البند المالي", 87, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FinancialItemCategoryName", "اسم البند المالي", 175, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FinancialItemCategoryDetails", "وصف البند المالي", 175, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsIncomingOrOutgiung", "صادر أو وارد", 87, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.ficatRepositoryItemLookUpEdit.DisplayMember = "FinancialItemCategoryName";
            this.ficatRepositoryItemLookUpEdit.Name = "ficatRepositoryItemLookUpEdit";
            this.ficatRepositoryItemLookUpEdit.PopupWidth = 437;
            this.ficatRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // curRepositoryItemLookUpEdit
            // 
            this.curRepositoryItemLookUpEdit.AutoHeight = false;
            this.curRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.curRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف العملة", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyName", "اسم العملة", 105, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.curRepositoryItemLookUpEdit.DataSource = this.currencyTblBindingSource;
            this.curRepositoryItemLookUpEdit.DisplayMember = "CurrencyName";
            this.curRepositoryItemLookUpEdit.Name = "curRepositoryItemLookUpEdit";
            this.curRepositoryItemLookUpEdit.PopupWidth = 437;
            this.curRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف القسم", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "اسم القسم", 131, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentHQ", "مقر القسم", 131, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEdit3.DataSource = this.departmentTblBindingSource;
            this.repositoryItemLookUpEdit3.DisplayMember = "DepartmentName";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.PopupWidth = 437;
            this.repositoryItemLookUpEdit3.ValueMember = "ID";
            // 
            // subdRpositoryItemLookUpEdit
            // 
            this.subdRpositoryItemLookUpEdit.AutoHeight = false;
            this.subdRpositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.subdRpositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الوحدة", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubDepartmentName", "اسم الوحدة", 131, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainDepartment", "معرف القسم", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.subdRpositoryItemLookUpEdit.DataSource = this.subDepartmentTblBindingSource;
            this.subdRpositoryItemLookUpEdit.DisplayMember = "SubDepartmentName";
            this.subdRpositoryItemLookUpEdit.Name = "subdRpositoryItemLookUpEdit";
            this.subdRpositoryItemLookUpEdit.PopupWidth = 437;
            this.subdRpositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // financialItemTblPanel
            // 
            this.financialItemTblPanel.Controls.Add(this.moneySummaryPanel);
            this.financialItemTblPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.financialItemTblPanel.Location = new System.Drawing.Point(3, 3);
            this.financialItemTblPanel.Name = "financialItemTblPanel";
            this.financialItemTblPanel.Size = new System.Drawing.Size(722, 319);
            this.financialItemTblPanel.TabIndex = 652;
            this.financialItemTblPanel.Visible = false;
            // 
            // moneySummaryPanel
            // 
            this.moneySummaryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.moneySummaryPanel.Controls.Add(this.subLevelTotalsTreeView);
            this.moneySummaryPanel.Controls.Add(this.totalCycledNumericUpDown);
            this.moneySummaryPanel.Controls.Add(this.totalCycledLabel);
            this.moneySummaryPanel.Controls.Add(this.totalOutcomesNumericUpDown);
            this.moneySummaryPanel.Controls.Add(this.totalOutcomesLabel);
            this.moneySummaryPanel.Controls.Add(this.totalIncomesNumericUpDown);
            this.moneySummaryPanel.Controls.Add(this.totalIncomesLabel);
            this.moneySummaryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.moneySummaryPanel.Location = new System.Drawing.Point(0, 0);
            this.moneySummaryPanel.Name = "moneySummaryPanel";
            this.moneySummaryPanel.Size = new System.Drawing.Size(722, 313);
            this.moneySummaryPanel.TabIndex = 652;
            // 
            // subLevelTotalsTreeView
            // 
            this.subLevelTotalsTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.subLevelTotalsTreeView.Location = new System.Drawing.Point(0, 0);
            this.subLevelTotalsTreeView.Name = "subLevelTotalsTreeView";
            this.subLevelTotalsTreeView.RightToLeftLayout = true;
            this.subLevelTotalsTreeView.Size = new System.Drawing.Size(391, 313);
            this.subLevelTotalsTreeView.TabIndex = 700;
            // 
            // totalCycledNumericUpDown
            // 
            this.totalCycledNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalCycledNumericUpDown.DecimalPlaces = 2;
            this.totalCycledNumericUpDown.Enabled = false;
            this.totalCycledNumericUpDown.Location = new System.Drawing.Point(420, 116);
            this.totalCycledNumericUpDown.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.totalCycledNumericUpDown.Minimum = new decimal(new int[] {
            -727379968,
            232,
            0,
            -2147483648});
            this.totalCycledNumericUpDown.Name = "totalCycledNumericUpDown";
            this.totalCycledNumericUpDown.Size = new System.Drawing.Size(153, 32);
            this.totalCycledNumericUpDown.TabIndex = 680;
            // 
            // totalCycledLabel
            // 
            this.totalCycledLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalCycledLabel.AutoSize = true;
            this.totalCycledLabel.Location = new System.Drawing.Point(590, 120);
            this.totalCycledLabel.Name = "totalCycledLabel";
            this.totalCycledLabel.Size = new System.Drawing.Size(109, 24);
            this.totalCycledLabel.TabIndex = 675;
            this.totalCycledLabel.Text = "الرصيد المدور:";
            // 
            // totalOutcomesNumericUpDown
            // 
            this.totalOutcomesNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalOutcomesNumericUpDown.DecimalPlaces = 2;
            this.totalOutcomesNumericUpDown.Enabled = false;
            this.totalOutcomesNumericUpDown.Location = new System.Drawing.Point(420, 66);
            this.totalOutcomesNumericUpDown.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.totalOutcomesNumericUpDown.Name = "totalOutcomesNumericUpDown";
            this.totalOutcomesNumericUpDown.Size = new System.Drawing.Size(153, 32);
            this.totalOutcomesNumericUpDown.TabIndex = 670;
            // 
            // totalOutcomesLabel
            // 
            this.totalOutcomesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalOutcomesLabel.AutoSize = true;
            this.totalOutcomesLabel.Location = new System.Drawing.Point(591, 70);
            this.totalOutcomesLabel.Name = "totalOutcomesLabel";
            this.totalOutcomesLabel.Size = new System.Drawing.Size(108, 24);
            this.totalOutcomesLabel.TabIndex = 665;
            this.totalOutcomesLabel.Text = "إجمالي الصادر:";
            // 
            // totalIncomesNumericUpDown
            // 
            this.totalIncomesNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalIncomesNumericUpDown.DecimalPlaces = 2;
            this.totalIncomesNumericUpDown.Enabled = false;
            this.totalIncomesNumericUpDown.Location = new System.Drawing.Point(420, 16);
            this.totalIncomesNumericUpDown.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.totalIncomesNumericUpDown.Name = "totalIncomesNumericUpDown";
            this.totalIncomesNumericUpDown.Size = new System.Drawing.Size(153, 32);
            this.totalIncomesNumericUpDown.TabIndex = 660;
            // 
            // totalIncomesLabel
            // 
            this.totalIncomesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalIncomesLabel.AutoSize = true;
            this.totalIncomesLabel.Location = new System.Drawing.Point(602, 20);
            this.totalIncomesLabel.Name = "totalIncomesLabel";
            this.totalIncomesLabel.Size = new System.Drawing.Size(97, 24);
            this.totalIncomesLabel.TabIndex = 655;
            this.totalIncomesLabel.Text = "إجمالي الوارد:";
            // 
            // aggFiguesTabPage
            // 
            this.aggFiguesTabPage.Controls.Add(this.spreadsheetControl1);
            this.aggFiguesTabPage.Location = new System.Drawing.Point(4, 33);
            this.aggFiguesTabPage.Name = "aggFiguesTabPage";
            this.aggFiguesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.aggFiguesTabPage.Size = new System.Drawing.Size(728, 700);
            this.aggFiguesTabPage.TabIndex = 1;
            this.aggFiguesTabPage.Text = "الأرقام الإجمالية";
            this.aggFiguesTabPage.UseVisualStyleBackColor = true;
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.spreadsheetControl1.Location = new System.Drawing.Point(3, 3);
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.ReadOnly = true;
            this.spreadsheetControl1.Size = new System.Drawing.Size(722, 608);
            this.spreadsheetControl1.TabIndex = 0;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // manageCurrencyTblBtn
            // 
            this.manageCurrencyTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageCurrencyTblBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCurrencyTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageCurrencyTblBtn.Location = new System.Drawing.Point(460, 589);
            this.manageCurrencyTblBtn.Name = "manageCurrencyTblBtn";
            this.manageCurrencyTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageCurrencyTblBtn.TabIndex = 116;
            this.manageCurrencyTblBtn.UseVisualStyleBackColor = true;
            this.manageCurrencyTblBtn.Visible = false;
            this.manageCurrencyTblBtn.Click += new System.EventHandler(this.manageCurrencyTblBtn_Click);
            // 
            // searchByCurrencyLookUpEdit
            // 
            this.searchByCurrencyLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByCurrencyLookUpEdit.Location = new System.Drawing.Point(200, 602);
            this.searchByCurrencyLookUpEdit.Name = "searchByCurrencyLookUpEdit";
            this.searchByCurrencyLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByCurrencyLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.searchByCurrencyLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchByCurrencyLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف العملة", 100, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyName", "اسم العملة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.searchByCurrencyLookUpEdit.Properties.DataSource = this.currencyTblBindingSource;
            this.searchByCurrencyLookUpEdit.Properties.DisplayMember = "CurrencyName";
            this.searchByCurrencyLookUpEdit.Properties.PopupWidth = 500;
            this.searchByCurrencyLookUpEdit.Properties.ValueMember = "ID";
            this.searchByCurrencyLookUpEdit.Size = new System.Drawing.Size(243, 28);
            this.searchByCurrencyLookUpEdit.TabIndex = 115;
            this.searchByCurrencyLookUpEdit.Visible = false;
            // 
            // searchByCurrencyCheckBox
            // 
            this.searchByCurrencyCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByCurrencyCheckBox.AutoSize = true;
            this.searchByCurrencyCheckBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByCurrencyCheckBox.Location = new System.Drawing.Point(30, 604);
            this.searchByCurrencyCheckBox.Name = "searchByCurrencyCheckBox";
            this.searchByCurrencyCheckBox.Size = new System.Drawing.Size(140, 25);
            this.searchByCurrencyCheckBox.TabIndex = 110;
            this.searchByCurrencyCheckBox.Text = "بحث حسب العملة";
            this.searchByCurrencyCheckBox.UseVisualStyleBackColor = true;
            this.searchByCurrencyCheckBox.CheckedChanged += new System.EventHandler(this.searchByCurrencyCheckBox_CheckedChanged);
            // 
            // FinancialReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 737);
            this.Controls.Add(this.searchByCurrencyCheckBox);
            this.Controls.Add(this.manageCurrencyTblBtn);
            this.Controls.Add(this.searchByCurrencyLookUpEdit);
            this.Controls.Add(this.financialReportTabControl);
            this.Controls.Add(this.manageDepartmentTblBtn);
            this.Controls.Add(this.manageSubDepartmentTblBtn);
            this.Controls.Add(this.searchBySubDepartmentLookUpEdit);
            this.Controls.Add(this.manageSectionTblBtn);
            this.Controls.Add(this.searchBySectionLookUpEdit);
            this.Controls.Add(this.searchBySubDepartmentRadioButton);
            this.Controls.Add(this.searchBySectionRadioButton);
            this.Controls.Add(this.searchByDepartmentLookUpEdit);
            this.Controls.Add(this.searchWithinPeriodCheckBox);
            this.Controls.Add(this.searchAllRadioButton);
            this.Controls.Add(this.searchByDepartmentRadioButton);
            this.Controls.Add(this.searchWithinPeriodPanel);
            this.Controls.Add(this.searchFinancialItemDropDownButton);
            this.Controls.Add(this.exportFinancialReportToExcelDropDownButton);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
            ((System.ComponentModel.ISupportInitialize)(this.financialItemVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource1)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.financialItemVwBindingSource1)).EndInit();
            this.financialReportTabControl.ResumeLayout(false);
            this.detailedFiguresTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ficatRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subdRpositoryItemLookUpEdit)).EndInit();
            this.financialItemTblPanel.ResumeLayout(false);
            this.moneySummaryPanel.ResumeLayout(false);
            this.moneySummaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalCycledNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalOutcomesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalIncomesNumericUpDown)).EndInit();
            this.aggFiguesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchByCurrencyLookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private DevExpress.XtraEditors.DateEdit toDateDateEdit;
        private DevExpress.XtraEditors.DateEdit fromDateDateEdit;
        private System.Windows.Forms.Label fromDateLabel;
        private System.Windows.Forms.Label toDateLabel;
        private AssetMngDbDataSet assetMngDbDataSet;
        private System.Windows.Forms.BindingSource financialItemTblBindingSource;
        private AssetMngDbDataSetTableAdapters.FinancialItemTblTableAdapter financialItemTblTableAdapter;
        private DevExpress.XtraEditors.DropDownButton searchFinancialItemDropDownButton;
        private DevExpress.XtraEditors.DropDownButton exportFinancialReportToExcelDropDownButton;
        private System.Windows.Forms.BindingSource financialItemCategoryTblBindingSource;
        private AssetMngDbDataSetTableAdapters.FinancialItemCategoryTblTableAdapter financialItemCategoryTblTableAdapter;
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
        private DevExpress.XtraEditors.LookUpEdit searchByDepartmentLookUpEdit;
        private System.Windows.Forms.BindingSource departmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter departmentTblTableAdapter;
        private System.Windows.Forms.BindingSource departmentTblBindingSource1;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.RadioButton searchBySectionRadioButton;
        private System.Windows.Forms.RadioButton searchBySubDepartmentRadioButton;
        private System.Windows.Forms.Button manageSectionTblBtn;
        private DevExpress.XtraEditors.LookUpEdit searchBySectionLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit searchBySubDepartmentLookUpEdit;
        private System.Windows.Forms.BindingSource sectionTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SectionTblTableAdapter sectionTblTableAdapter;
        private System.Windows.Forms.BindingSource subDepartmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SubDepartmentTblTableAdapter subDepartmentTblTableAdapter;
        private System.Windows.Forms.BindingSource subDepartmentTblBindingSource1;
        private System.Windows.Forms.BindingSource financialItemVwBindingSource;
        private AssetMngDbDataSetTableAdapters.FinancialItemVwTableAdapter financialItemVwTableAdapter;
        private System.Windows.Forms.BindingSource financialItemVwBindingSource1;
        private System.Windows.Forms.Button manageSubDepartmentTblBtn;
        private System.Windows.Forms.Button manageDepartmentTblBtn;
        private System.Windows.Forms.TabControl financialReportTabControl;
        private System.Windows.Forms.TabPage detailedFiguresTabPage;
        private System.Windows.Forms.Panel financialItemTblPanel;
        private System.Windows.Forms.Panel moneySummaryPanel;
        private System.Windows.Forms.TreeView subLevelTotalsTreeView;
        private System.Windows.Forms.NumericUpDown totalCycledNumericUpDown;
        private System.Windows.Forms.Label totalCycledLabel;
        private System.Windows.Forms.NumericUpDown totalOutcomesNumericUpDown;
        private System.Windows.Forms.Label totalOutcomesLabel;
        private System.Windows.Forms.NumericUpDown totalIncomesNumericUpDown;
        private System.Windows.Forms.Label totalIncomesLabel;
        private System.Windows.Forms.TabPage aggFiguesTabPage;
        private DevExpress.XtraGrid.GridControl financialItemCategoryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView financialItemGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colمعرفالسجلالمالي;
        private DevExpress.XtraGrid.Columns.GridColumn colكودالسجلالمالي;
        private DevExpress.XtraGrid.Columns.GridColumn colاسمالبندالمالي;
        private DevExpress.XtraGrid.Columns.GridColumn colبيانالسجلالمالي;
        private DevExpress.XtraGrid.Columns.GridColumn colالدائرة;
        private DevExpress.XtraGrid.Columns.GridColumn colالقسم;
        private DevExpress.XtraGrid.Columns.GridColumn colالوحدة;
        private DevExpress.XtraGrid.Columns.GridColumn colتاريختحريرالسجل;
        private DevExpress.XtraGrid.Columns.GridColumn colواردأمصادر;
        private DevExpress.XtraGrid.Columns.GridColumn colجهةالإيراد;
        private DevExpress.XtraGrid.Columns.GridColumn colنوعالصادر;
        private DevExpress.XtraGrid.Columns.GridColumn colصادرإلى;
        private DevExpress.XtraGrid.Columns.GridColumn colالمبلغالوارد;
        private DevExpress.XtraGrid.Columns.GridColumn colالمبلغالصادر;
        private DevExpress.XtraGrid.Columns.GridColumn colالعملة;
        private DevExpress.XtraGrid.Columns.GridColumn colملاحظاتإضافية;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ficatRepositoryItemLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit curRepositoryItemLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit subdRpositoryItemLookUpEdit;
        private System.Windows.Forms.Button manageCurrencyTblBtn;
        private DevExpress.XtraEditors.LookUpEdit searchByCurrencyLookUpEdit;
        private System.Windows.Forms.CheckBox searchByCurrencyCheckBox;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
    }
}