
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
            this.financialItemTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.financialItemGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinancialItemCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.financialItemCategoryRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.financialItemCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colFinancialItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinancialItemInsertionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncomingOrOutgoing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncomingAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutgoingAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinancialItemCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.currencyRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.currencyTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colAdditionalNotes = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.searchInDeptRadioButton = new System.Windows.Forms.RadioButton();
            this.searchAllDeptsRadioButton = new System.Windows.Forms.RadioButton();
            this.searchWithinPeriodCheckBox = new System.Windows.Forms.CheckBox();
            this.manageDepartmentTblBtn = new System.Windows.Forms.Button();
            this.financialItemDeptToSearchLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.departmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter();
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.colFinancialItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinancialItemDept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.departmentTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.toDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).BeginInit();
            this.fromToPanel.SuspendLayout();
            this.searchWithinPeriodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemDeptToSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource1)).BeginInit();
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
            this.toDateDateEdit.TabIndex = 30;
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
            this.fromDateDateEdit.TabIndex = 20;
            // 
            // fromDateLabel
            // 
            this.fromDateLabel.AutoSize = true;
            this.fromDateLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateLabel.Location = new System.Drawing.Point(296, 22);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.Size = new System.Drawing.Size(67, 21);
            this.fromDateLabel.TabIndex = 15;
            this.fromDateLabel.Text = "من تاريخ:";
            // 
            // toDateLabel
            // 
            this.toDateLabel.AutoSize = true;
            this.toDateLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateLabel.Location = new System.Drawing.Point(282, 77);
            this.toDateLabel.Name = "toDateLabel";
            this.toDateLabel.Size = new System.Drawing.Size(77, 21);
            this.toDateLabel.TabIndex = 25;
            this.toDateLabel.Text = "لغاية تاريخ:";
            // 
            // financialItemGridControl
            // 
            this.financialItemGridControl.DataSource = this.financialItemTblBindingSource;
            this.financialItemGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.financialItemGridControl.Location = new System.Drawing.Point(495, 0);
            this.financialItemGridControl.MainView = this.financialItemGridView;
            this.financialItemGridControl.Name = "financialItemGridControl";
            this.financialItemGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.financialItemCategoryRepositoryItemLookUpEdit,
            this.currencyRepositoryItemLookUpEdit,
            this.repositoryItemLookUpEdit1});
            this.financialItemGridControl.Size = new System.Drawing.Size(879, 655);
            this.financialItemGridControl.TabIndex = 200;
            this.financialItemGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.financialItemGridView});
            this.financialItemGridControl.Visible = false;
            // 
            // financialItemTblBindingSource
            // 
            this.financialItemTblBindingSource.DataMember = "FinancialItemTbl";
            this.financialItemTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // financialItemGridView
            // 
            this.financialItemGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFinancialItemCode,
            this.colFinancialItemCategory,
            this.colFinancialItemDept,
            this.colFinancialItemDescription,
            this.colFinancialItemInsertionDate,
            this.colIncomingOrOutgoing,
            this.colIncomingAmount,
            this.colOutgoingAmount,
            this.colFinancialItemCurrency,
            this.colAdditionalNotes});
            this.financialItemGridView.GridControl = this.financialItemGridControl;
            this.financialItemGridView.Name = "financialItemGridView";
            // 
            // colID
            // 
            this.colID.Caption = "معرف السجل المالي";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 80;
            this.colID.Name = "colID";
            this.colID.Width = 94;
            // 
            // colFinancialItemCategory
            // 
            this.colFinancialItemCategory.Caption = "البند المالي";
            this.colFinancialItemCategory.ColumnEdit = this.financialItemCategoryRepositoryItemLookUpEdit;
            this.colFinancialItemCategory.FieldName = "FinancialItemCategory";
            this.colFinancialItemCategory.MinWidth = 150;
            this.colFinancialItemCategory.Name = "colFinancialItemCategory";
            this.colFinancialItemCategory.Visible = true;
            this.colFinancialItemCategory.VisibleIndex = 0;
            this.colFinancialItemCategory.Width = 150;
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
            this.financialItemCategoryRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // financialItemCategoryTblBindingSource
            // 
            this.financialItemCategoryTblBindingSource.DataMember = "FinancialItemCategoryTbl";
            this.financialItemCategoryTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // colFinancialItemDescription
            // 
            this.colFinancialItemDescription.Caption = "بيان السجل المالي";
            this.colFinancialItemDescription.FieldName = "FinancialItemDescription";
            this.colFinancialItemDescription.MinWidth = 150;
            this.colFinancialItemDescription.Name = "colFinancialItemDescription";
            this.colFinancialItemDescription.Visible = true;
            this.colFinancialItemDescription.VisibleIndex = 2;
            this.colFinancialItemDescription.Width = 150;
            // 
            // colFinancialItemInsertionDate
            // 
            this.colFinancialItemInsertionDate.Caption = "تاريخ السجل المالي";
            this.colFinancialItemInsertionDate.FieldName = "FinancialItemInsertionDate";
            this.colFinancialItemInsertionDate.MinWidth = 80;
            this.colFinancialItemInsertionDate.Name = "colFinancialItemInsertionDate";
            this.colFinancialItemInsertionDate.Visible = true;
            this.colFinancialItemInsertionDate.VisibleIndex = 3;
            this.colFinancialItemInsertionDate.Width = 1000;
            // 
            // colIncomingOrOutgoing
            // 
            this.colIncomingOrOutgoing.Caption = "صادر أو وارد";
            this.colIncomingOrOutgoing.FieldName = "IncomingOrOutgoing";
            this.colIncomingOrOutgoing.MinWidth = 50;
            this.colIncomingOrOutgoing.Name = "colIncomingOrOutgoing";
            this.colIncomingOrOutgoing.Visible = true;
            this.colIncomingOrOutgoing.VisibleIndex = 4;
            this.colIncomingOrOutgoing.Width = 94;
            // 
            // colIncomingAmount
            // 
            this.colIncomingAmount.Caption = "المبلغ الوارد";
            this.colIncomingAmount.FieldName = "IncomingAmount";
            this.colIncomingAmount.MinWidth = 80;
            this.colIncomingAmount.Name = "colIncomingAmount";
            this.colIncomingAmount.Visible = true;
            this.colIncomingAmount.VisibleIndex = 5;
            this.colIncomingAmount.Width = 100;
            // 
            // colOutgoingAmount
            // 
            this.colOutgoingAmount.Caption = "المبلغ الصادر";
            this.colOutgoingAmount.FieldName = "OutgoingAmount";
            this.colOutgoingAmount.MinWidth = 80;
            this.colOutgoingAmount.Name = "colOutgoingAmount";
            this.colOutgoingAmount.Visible = true;
            this.colOutgoingAmount.VisibleIndex = 6;
            this.colOutgoingAmount.Width = 94;
            // 
            // colFinancialItemCurrency
            // 
            this.colFinancialItemCurrency.Caption = "العملة";
            this.colFinancialItemCurrency.ColumnEdit = this.currencyRepositoryItemLookUpEdit;
            this.colFinancialItemCurrency.FieldName = "FinancialItemCurrency";
            this.colFinancialItemCurrency.MinWidth = 100;
            this.colFinancialItemCurrency.Name = "colFinancialItemCurrency";
            this.colFinancialItemCurrency.Visible = true;
            this.colFinancialItemCurrency.VisibleIndex = 7;
            this.colFinancialItemCurrency.Width = 100;
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
            this.currencyRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // currencyTblBindingSource
            // 
            this.currencyTblBindingSource.DataMember = "CurrencyTbl";
            this.currencyTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // colAdditionalNotes
            // 
            this.colAdditionalNotes.Caption = "ملاحظات إضافية";
            this.colAdditionalNotes.FieldName = "AdditionalNotes";
            this.colAdditionalNotes.MinWidth = 150;
            this.colAdditionalNotes.Name = "colAdditionalNotes";
            this.colAdditionalNotes.Visible = true;
            this.colAdditionalNotes.VisibleIndex = 8;
            this.colAdditionalNotes.Width = 150;
            // 
            // financialItemTblTableAdapter
            // 
            this.financialItemTblTableAdapter.ClearBeforeFill = true;
            // 
            // searchFinancialItemDropDownButton
            // 
            this.searchFinancialItemDropDownButton.ImageOptions.Image = global::AssetManagement.Properties.Resources._2719309;
            this.searchFinancialItemDropDownButton.Location = new System.Drawing.Point(74, 533);
            this.searchFinancialItemDropDownButton.Name = "searchFinancialItemDropDownButton";
            this.searchFinancialItemDropDownButton.Size = new System.Drawing.Size(163, 73);
            this.searchFinancialItemDropDownButton.TabIndex = 100;
            this.searchFinancialItemDropDownButton.Text = "بحث";
            this.searchFinancialItemDropDownButton.Click += new System.EventHandler(this.searchFinancialItemDropDownButton_Click);
            // 
            // exportFinancialReportToExcelDropDownButton
            // 
            this.exportFinancialReportToExcelDropDownButton.Enabled = false;
            this.exportFinancialReportToExcelDropDownButton.ImageOptions.Image = global::AssetManagement.Properties.Resources._3643510;
            this.exportFinancialReportToExcelDropDownButton.Location = new System.Drawing.Point(279, 533);
            this.exportFinancialReportToExcelDropDownButton.Name = "exportFinancialReportToExcelDropDownButton";
            this.exportFinancialReportToExcelDropDownButton.Size = new System.Drawing.Size(163, 73);
            this.exportFinancialReportToExcelDropDownButton.TabIndex = 105;
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
            this.fromToPanel.Location = new System.Drawing.Point(29, 50);
            this.fromToPanel.Name = "fromToPanel";
            this.fromToPanel.Size = new System.Drawing.Size(398, 129);
            this.fromToPanel.TabIndex = 10;
            // 
            // fromToRadioButton
            // 
            this.fromToRadioButton.AutoSize = true;
            this.fromToRadioButton.Checked = true;
            this.fromToRadioButton.Location = new System.Drawing.Point(334, 19);
            this.fromToRadioButton.Name = "fromToRadioButton";
            this.fromToRadioButton.Size = new System.Drawing.Size(93, 25);
            this.fromToRadioButton.TabIndex = 5;
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
            this.monthlyRadioButton.TabIndex = 35;
            this.monthlyRadioButton.Text = "شهري";
            this.monthlyRadioButton.UseVisualStyleBackColor = true;
            this.monthlyRadioButton.CheckedChanged += new System.EventHandler(this.SelectReportDuration);
            // 
            // annualRadioButton
            // 
            this.annualRadioButton.AutoSize = true;
            this.annualRadioButton.Location = new System.Drawing.Point(369, 248);
            this.annualRadioButton.Name = "annualRadioButton";
            this.annualRadioButton.Size = new System.Drawing.Size(65, 25);
            this.annualRadioButton.TabIndex = 45;
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
            this.monthlyDateTimePicker.TabIndex = 40;
            this.monthlyDateTimePicker.Visible = false;
            // 
            // annualDateTimePicker
            // 
            this.annualDateTimePicker.CustomFormat = "yyyy";
            this.annualDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.annualDateTimePicker.Location = new System.Drawing.Point(76, 246);
            this.annualDateTimePicker.Name = "annualDateTimePicker";
            this.annualDateTimePicker.Size = new System.Drawing.Size(243, 28);
            this.annualDateTimePicker.TabIndex = 50;
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
            this.searchWithinPeriodPanel.Location = new System.Drawing.Point(22, 209);
            this.searchWithinPeriodPanel.Name = "searchWithinPeriodPanel";
            this.searchWithinPeriodPanel.Size = new System.Drawing.Size(459, 294);
            this.searchWithinPeriodPanel.TabIndex = 201;
            this.searchWithinPeriodPanel.Visible = false;
            // 
            // searchInDeptRadioButton
            // 
            this.searchInDeptRadioButton.AutoSize = true;
            this.searchInDeptRadioButton.Checked = true;
            this.searchInDeptRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInDeptRadioButton.Location = new System.Drawing.Point(22, 34);
            this.searchInDeptRadioButton.Name = "searchInDeptRadioButton";
            this.searchInDeptRadioButton.Size = new System.Drawing.Size(92, 25);
            this.searchInDeptRadioButton.TabIndex = 202;
            this.searchInDeptRadioButton.Text = "اختر القسم";
            this.searchInDeptRadioButton.UseVisualStyleBackColor = true;
            this.searchInDeptRadioButton.CheckedChanged += new System.EventHandler(this.searchInDeptRadioButton_CheckedChanged);
            // 
            // searchAllDeptsRadioButton
            // 
            this.searchAllDeptsRadioButton.AutoSize = true;
            this.searchAllDeptsRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchAllDeptsRadioButton.Location = new System.Drawing.Point(22, 91);
            this.searchAllDeptsRadioButton.Name = "searchAllDeptsRadioButton";
            this.searchAllDeptsRadioButton.Size = new System.Drawing.Size(91, 25);
            this.searchAllDeptsRadioButton.TabIndex = 203;
            this.searchAllDeptsRadioButton.Text = "كل الأقسام";
            this.searchAllDeptsRadioButton.UseVisualStyleBackColor = true;
            this.searchAllDeptsRadioButton.CheckedChanged += new System.EventHandler(this.searchInDeptRadioButton_CheckedChanged);
            // 
            // searchWithinPeriodCheckBox
            // 
            this.searchWithinPeriodCheckBox.AutoSize = true;
            this.searchWithinPeriodCheckBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchWithinPeriodCheckBox.Location = new System.Drawing.Point(22, 168);
            this.searchWithinPeriodCheckBox.Name = "searchWithinPeriodCheckBox";
            this.searchWithinPeriodCheckBox.Size = new System.Drawing.Size(165, 25);
            this.searchWithinPeriodCheckBox.TabIndex = 204;
            this.searchWithinPeriodCheckBox.Text = "بحث ضمن فترة محددة";
            this.searchWithinPeriodCheckBox.UseVisualStyleBackColor = true;
            this.searchWithinPeriodCheckBox.CheckedChanged += new System.EventHandler(this.searchWithinPeriodCheckBox_CheckedChanged);
            // 
            // manageDepartmentTblBtn
            // 
            this.manageDepartmentTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageDepartmentTblBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageDepartmentTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageDepartmentTblBtn.Location = new System.Drawing.Point(416, 21);
            this.manageDepartmentTblBtn.Name = "manageDepartmentTblBtn";
            this.manageDepartmentTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageDepartmentTblBtn.TabIndex = 206;
            this.manageDepartmentTblBtn.UseVisualStyleBackColor = true;
            this.manageDepartmentTblBtn.Click += new System.EventHandler(this.manageDepartmentTblBtn_Click);
            // 
            // financialItemDeptToSearchLookUpEdit
            // 
            this.financialItemDeptToSearchLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financialItemDeptToSearchLookUpEdit.Location = new System.Drawing.Point(152, 34);
            this.financialItemDeptToSearchLookUpEdit.Name = "financialItemDeptToSearchLookUpEdit";
            this.financialItemDeptToSearchLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialItemDeptToSearchLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.financialItemDeptToSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.financialItemDeptToSearchLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف القسم", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "اسم القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentHQ", "مقر القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.financialItemDeptToSearchLookUpEdit.Properties.DataSource = this.departmentTblBindingSource;
            this.financialItemDeptToSearchLookUpEdit.Properties.DisplayMember = "DepartmentName";
            this.financialItemDeptToSearchLookUpEdit.Properties.PopupWidth = 500;
            this.financialItemDeptToSearchLookUpEdit.Properties.ValueMember = "ID";
            this.financialItemDeptToSearchLookUpEdit.Size = new System.Drawing.Size(243, 28);
            this.financialItemDeptToSearchLookUpEdit.TabIndex = 205;
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
            this.tableAdapterManager.MainCategoryTblTableAdapter = null;
            this.tableAdapterManager.MinorCategoryTblTableAdapter = null;
            this.tableAdapterManager.ModelTblTableAdapter = null;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.SectionTblTableAdapter = null;
            this.tableAdapterManager.SquareTblTableAdapter = null;
            this.tableAdapterManager.StatusTblTableAdapter = null;
            this.tableAdapterManager.TransactionTypeTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // colFinancialItemCode
            // 
            this.colFinancialItemCode.Caption = "كود السجل المالي";
            this.colFinancialItemCode.FieldName = "FinancialItemCode";
            this.colFinancialItemCode.MinWidth = 150;
            this.colFinancialItemCode.Name = "colFinancialItemCode";
            this.colFinancialItemCode.Width = 150;
            // 
            // colFinancialItemDept
            // 
            this.colFinancialItemDept.Caption = "القسم";
            this.colFinancialItemDept.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colFinancialItemDept.FieldName = "FinancialItemDept";
            this.colFinancialItemDept.MinWidth = 150;
            this.colFinancialItemDept.Name = "colFinancialItemDept";
            this.colFinancialItemDept.Visible = true;
            this.colFinancialItemDept.VisibleIndex = 1;
            this.colFinancialItemDept.Width = 150;
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
            // FinancialReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 655);
            this.Controls.Add(this.manageDepartmentTblBtn);
            this.Controls.Add(this.financialItemDeptToSearchLookUpEdit);
            this.Controls.Add(this.searchWithinPeriodCheckBox);
            this.Controls.Add(this.searchAllDeptsRadioButton);
            this.Controls.Add(this.searchInDeptRadioButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.financialItemTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).EndInit();
            this.fromToPanel.ResumeLayout(false);
            this.fromToPanel.PerformLayout();
            this.searchWithinPeriodPanel.ResumeLayout(false);
            this.searchWithinPeriodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemDeptToSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource1)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFinancialItemCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colFinancialItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colFinancialItemInsertionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIncomingOrOutgoing;
        private DevExpress.XtraGrid.Columns.GridColumn colIncomingAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colOutgoingAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colFinancialItemCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colAdditionalNotes;
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
        private System.Windows.Forms.RadioButton searchInDeptRadioButton;
        private System.Windows.Forms.RadioButton searchAllDeptsRadioButton;
        private System.Windows.Forms.CheckBox searchWithinPeriodCheckBox;
        private System.Windows.Forms.Button manageDepartmentTblBtn;
        private DevExpress.XtraEditors.LookUpEdit financialItemDeptToSearchLookUpEdit;
        private System.Windows.Forms.BindingSource departmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter departmentTblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colFinancialItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFinancialItemDept;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource departmentTblBindingSource1;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}