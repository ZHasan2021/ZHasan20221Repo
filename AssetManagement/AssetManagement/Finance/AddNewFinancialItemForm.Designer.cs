
namespace AssetManagement.Finance
{
    partial class AddNewFinancialItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewFinancialItemForm));
            this.financialItemCategoryLabel = new System.Windows.Forms.Label();
            this.manageFinancialItemCategoryTblBtn = new System.Windows.Forms.Button();
            this.financialItemCategoryLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.financialItemCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.financialItemCategoryTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.FinancialItemCategoryTblTableAdapter();
            this.financialItemInsertionDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.financialItemInsertionDateLabel = new System.Windows.Forms.Label();
            this.incomingOrOutgoingPanel = new System.Windows.Forms.Panel();
            this.incomingOutgoingRadioButton = new System.Windows.Forms.RadioButton();
            this.outgoingRadioButton = new System.Windows.Forms.RadioButton();
            this.incomingRadioButton = new System.Windows.Forms.RadioButton();
            this.financialItemDescriptionLabel = new System.Windows.Forms.Label();
            this.financialItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.financialItemCurrencyLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.currencyTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.manageCurrencyTblBtn = new System.Windows.Forms.Button();
            this.currencyTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.CurrencyTblTableAdapter();
            this.addNewFinancialItemBtn_Cancel = new System.Windows.Forms.Button();
            this.addNewFinancialItemBtn_OK = new System.Windows.Forms.Button();
            this.additionalNotesTextBox = new System.Windows.Forms.TextBox();
            this.additionalNotesLabel = new System.Windows.Forms.Label();
            this.manageDepartmentTblBtn = new System.Windows.Forms.Button();
            this.departmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter();
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.sectionTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SectionTblTableAdapter();
            this.subDepartmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SubDepartmentTblTableAdapter();
            this.manageSubDepartmentTblBtn = new System.Windows.Forms.Button();
            this.financialItemSubDeptLabel = new System.Windows.Forms.Label();
            this.financialItemSubDeptLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.subDepartmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manageSectionTblBtn = new System.Windows.Forms.Button();
            this.financialItemSectionLabel = new System.Windows.Forms.Label();
            this.financialItemSectionLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.sectionTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialItemDeptLabel = new System.Windows.Forms.Label();
            this.financialItemDeptLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.addNewAssetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemInsertionDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemInsertionDateDateEdit.Properties)).BeginInit();
            this.incomingOrOutgoingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCurrencyLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemSubDeptLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemSectionLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemDeptLookUpEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // financialItemCategoryLabel
            // 
            this.financialItemCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financialItemCategoryLabel.AutoSize = true;
            this.financialItemCategoryLabel.Location = new System.Drawing.Point(50, 30);
            this.financialItemCategoryLabel.Name = "financialItemCategoryLabel";
            this.financialItemCategoryLabel.Size = new System.Drawing.Size(87, 24);
            this.financialItemCategoryLabel.TabIndex = 0;
            this.financialItemCategoryLabel.Text = "البند المالي:";
            // 
            // manageFinancialItemCategoryTblBtn
            // 
            this.manageFinancialItemCategoryTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageFinancialItemCategoryTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageFinancialItemCategoryTblBtn.Location = new System.Drawing.Point(580, 15);
            this.manageFinancialItemCategoryTblBtn.Name = "manageFinancialItemCategoryTblBtn";
            this.manageFinancialItemCategoryTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageFinancialItemCategoryTblBtn.TabIndex = 6;
            this.manageFinancialItemCategoryTblBtn.UseVisualStyleBackColor = true;
            this.manageFinancialItemCategoryTblBtn.Click += new System.EventHandler(this.manageFinancialItemCategoryTblBtn_Click);
            // 
            // financialItemCategoryLookUpEdit
            // 
            this.financialItemCategoryLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financialItemCategoryLookUpEdit.Location = new System.Drawing.Point(233, 27);
            this.financialItemCategoryLookUpEdit.Name = "financialItemCategoryLookUpEdit";
            this.financialItemCategoryLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialItemCategoryLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.financialItemCategoryLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.financialItemCategoryLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف البند المالي", 100, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FinancialItemCategoryName", "اسم البند المالي", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FinancialItemCategoryDetails", "وصف البند المالي", 300, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsIncomingOrOutgiung", "صادر أم وارد", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.financialItemCategoryLookUpEdit.Properties.DataSource = this.financialItemCategoryTblBindingSource;
            this.financialItemCategoryLookUpEdit.Properties.DisplayMember = "FinancialItemCategoryName";
            this.financialItemCategoryLookUpEdit.Properties.PopupWidth = 800;
            this.financialItemCategoryLookUpEdit.Properties.ValueMember = "ID";
            this.financialItemCategoryLookUpEdit.Size = new System.Drawing.Size(321, 30);
            this.financialItemCategoryLookUpEdit.TabIndex = 5;
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
            // financialItemCategoryTblTableAdapter
            // 
            this.financialItemCategoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // financialItemInsertionDateDateEdit
            // 
            this.financialItemInsertionDateDateEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financialItemInsertionDateDateEdit.EditValue = null;
            this.financialItemInsertionDateDateEdit.Location = new System.Drawing.Point(233, 385);
            this.financialItemInsertionDateDateEdit.Name = "financialItemInsertionDateDateEdit";
            this.financialItemInsertionDateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialItemInsertionDateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.financialItemInsertionDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.financialItemInsertionDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.financialItemInsertionDateDateEdit.Size = new System.Drawing.Size(321, 30);
            this.financialItemInsertionDateDateEdit.TabIndex = 55;
            // 
            // financialItemInsertionDateLabel
            // 
            this.financialItemInsertionDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financialItemInsertionDateLabel.AutoSize = true;
            this.financialItemInsertionDateLabel.Location = new System.Drawing.Point(50, 388);
            this.financialItemInsertionDateLabel.Name = "financialItemInsertionDateLabel";
            this.financialItemInsertionDateLabel.Size = new System.Drawing.Size(104, 24);
            this.financialItemInsertionDateLabel.TabIndex = 50;
            this.financialItemInsertionDateLabel.Text = "تاريخ السجل:";
            // 
            // incomingOrOutgoingPanel
            // 
            this.incomingOrOutgoingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.incomingOrOutgoingPanel.Controls.Add(this.incomingOutgoingRadioButton);
            this.incomingOrOutgoingPanel.Controls.Add(this.outgoingRadioButton);
            this.incomingOrOutgoingPanel.Controls.Add(this.incomingRadioButton);
            this.incomingOrOutgoingPanel.Location = new System.Drawing.Point(50, 440);
            this.incomingOrOutgoingPanel.Name = "incomingOrOutgoingPanel";
            this.incomingOrOutgoingPanel.Size = new System.Drawing.Size(441, 62);
            this.incomingOrOutgoingPanel.TabIndex = 60;
            // 
            // incomingOutgoingRadioButton
            // 
            this.incomingOutgoingRadioButton.AutoSize = true;
            this.incomingOutgoingRadioButton.Location = new System.Drawing.Point(41, 18);
            this.incomingOutgoingRadioButton.Name = "incomingOutgoingRadioButton";
            this.incomingOutgoingRadioButton.Size = new System.Drawing.Size(105, 28);
            this.incomingOutgoingRadioButton.TabIndex = 75;
            this.incomingOutgoingRadioButton.Text = "وارد وصادر";
            this.incomingOutgoingRadioButton.UseVisualStyleBackColor = true;
            this.incomingOutgoingRadioButton.CheckedChanged += new System.EventHandler(this.incomingOutgoingRadioButton_CheckedChanged);
            // 
            // outgoingRadioButton
            // 
            this.outgoingRadioButton.AutoSize = true;
            this.outgoingRadioButton.Location = new System.Drawing.Point(212, 18);
            this.outgoingRadioButton.Name = "outgoingRadioButton";
            this.outgoingRadioButton.Size = new System.Drawing.Size(67, 28);
            this.outgoingRadioButton.TabIndex = 70;
            this.outgoingRadioButton.Text = "صادر";
            this.outgoingRadioButton.UseVisualStyleBackColor = true;
            this.outgoingRadioButton.CheckedChanged += new System.EventHandler(this.outgoingRadioButton_CheckedChanged);
            // 
            // incomingRadioButton
            // 
            this.incomingRadioButton.AutoSize = true;
            this.incomingRadioButton.Location = new System.Drawing.Point(345, 18);
            this.incomingRadioButton.Name = "incomingRadioButton";
            this.incomingRadioButton.Size = new System.Drawing.Size(56, 28);
            this.incomingRadioButton.TabIndex = 65;
            this.incomingRadioButton.Text = "وارد";
            this.incomingRadioButton.UseVisualStyleBackColor = true;
            this.incomingRadioButton.CheckedChanged += new System.EventHandler(this.incomingRadioButton_CheckedChanged);
            // 
            // financialItemDescriptionLabel
            // 
            this.financialItemDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financialItemDescriptionLabel.AutoSize = true;
            this.financialItemDescriptionLabel.Location = new System.Drawing.Point(50, 274);
            this.financialItemDescriptionLabel.Name = "financialItemDescriptionLabel";
            this.financialItemDescriptionLabel.Size = new System.Drawing.Size(95, 24);
            this.financialItemDescriptionLabel.TabIndex = 40;
            this.financialItemDescriptionLabel.Text = "بيان السجل:";
            // 
            // financialItemDescriptionTextBox
            // 
            this.financialItemDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financialItemDescriptionTextBox.Location = new System.Drawing.Point(233, 271);
            this.financialItemDescriptionTextBox.Multiline = true;
            this.financialItemDescriptionTextBox.Name = "financialItemDescriptionTextBox";
            this.financialItemDescriptionTextBox.Size = new System.Drawing.Size(556, 94);
            this.financialItemDescriptionTextBox.TabIndex = 45;
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(50, 524);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(54, 24);
            this.amountLabel.TabIndex = 80;
            this.amountLabel.Text = "المبلغ:";
            // 
            // financialItemCurrencyLookUpEdit
            // 
            this.financialItemCurrencyLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financialItemCurrencyLookUpEdit.Location = new System.Drawing.Point(341, 521);
            this.financialItemCurrencyLookUpEdit.Name = "financialItemCurrencyLookUpEdit";
            this.financialItemCurrencyLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialItemCurrencyLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.financialItemCurrencyLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.financialItemCurrencyLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف العملة", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyName", "اسم العملة", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.financialItemCurrencyLookUpEdit.Properties.DataSource = this.currencyTblBindingSource;
            this.financialItemCurrencyLookUpEdit.Properties.DisplayMember = "CurrencyName";
            this.financialItemCurrencyLookUpEdit.Properties.PopupWidth = 500;
            this.financialItemCurrencyLookUpEdit.Properties.ValueMember = "ID";
            this.financialItemCurrencyLookUpEdit.Size = new System.Drawing.Size(217, 30);
            this.financialItemCurrencyLookUpEdit.TabIndex = 90;
            // 
            // currencyTblBindingSource
            // 
            this.currencyTblBindingSource.DataMember = "CurrencyTbl";
            this.currencyTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountNumericUpDown.DecimalPlaces = 2;
            this.amountNumericUpDown.Location = new System.Drawing.Point(152, 520);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(153, 32);
            this.amountNumericUpDown.TabIndex = 85;
            // 
            // manageCurrencyTblBtn
            // 
            this.manageCurrencyTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageCurrencyTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageCurrencyTblBtn.Location = new System.Drawing.Point(584, 509);
            this.manageCurrencyTblBtn.Name = "manageCurrencyTblBtn";
            this.manageCurrencyTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageCurrencyTblBtn.TabIndex = 91;
            this.manageCurrencyTblBtn.UseVisualStyleBackColor = true;
            this.manageCurrencyTblBtn.Click += new System.EventHandler(this.manageCurrencyTblBtn_Click);
            // 
            // currencyTblTableAdapter
            // 
            this.currencyTblTableAdapter.ClearBeforeFill = true;
            // 
            // addNewFinancialItemBtn_Cancel
            // 
            this.addNewFinancialItemBtn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addNewFinancialItemBtn_Cancel.Image = global::AssetManagement.Properties.Resources._2137707;
            this.addNewFinancialItemBtn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewFinancialItemBtn_Cancel.Location = new System.Drawing.Point(907, 536);
            this.addNewFinancialItemBtn_Cancel.Name = "addNewFinancialItemBtn_Cancel";
            this.addNewFinancialItemBtn_Cancel.Size = new System.Drawing.Size(182, 65);
            this.addNewFinancialItemBtn_Cancel.TabIndex = 205;
            this.addNewFinancialItemBtn_Cancel.Text = "إغلاق";
            this.addNewFinancialItemBtn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewFinancialItemBtn_Cancel.UseVisualStyleBackColor = true;
            this.addNewFinancialItemBtn_Cancel.Click += new System.EventHandler(this.addNewFinancialItemBtn_Cancel_Click);
            // 
            // addNewFinancialItemBtn_OK
            // 
            this.addNewFinancialItemBtn_OK.Image = global::AssetManagement.Properties.Resources._2137710;
            this.addNewFinancialItemBtn_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewFinancialItemBtn_OK.Location = new System.Drawing.Point(907, 440);
            this.addNewFinancialItemBtn_OK.Name = "addNewFinancialItemBtn_OK";
            this.addNewFinancialItemBtn_OK.Size = new System.Drawing.Size(182, 65);
            this.addNewFinancialItemBtn_OK.TabIndex = 200;
            this.addNewFinancialItemBtn_OK.Text = "إضافة";
            this.addNewFinancialItemBtn_OK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewFinancialItemBtn_OK.UseVisualStyleBackColor = true;
            this.addNewFinancialItemBtn_OK.Click += new System.EventHandler(this.addNewFinancialItemBtn_OK_Click);
            // 
            // additionalNotesTextBox
            // 
            this.additionalNotesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalNotesTextBox.Location = new System.Drawing.Point(237, 571);
            this.additionalNotesTextBox.Name = "additionalNotesTextBox";
            this.additionalNotesTextBox.Size = new System.Drawing.Size(411, 32);
            this.additionalNotesTextBox.TabIndex = 100;
            // 
            // additionalNotesLabel
            // 
            this.additionalNotesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalNotesLabel.AutoSize = true;
            this.additionalNotesLabel.Location = new System.Drawing.Point(50, 575);
            this.additionalNotesLabel.Name = "additionalNotesLabel";
            this.additionalNotesLabel.Size = new System.Drawing.Size(129, 24);
            this.additionalNotesLabel.TabIndex = 95;
            this.additionalNotesLabel.Text = "ملاحظات إضافية:";
            // 
            // manageDepartmentTblBtn
            // 
            this.manageDepartmentTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageDepartmentTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageDepartmentTblBtn.Location = new System.Drawing.Point(580, 135);
            this.manageDepartmentTblBtn.Name = "manageDepartmentTblBtn";
            this.manageDepartmentTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageDepartmentTblBtn.TabIndex = 26;
            this.manageDepartmentTblBtn.UseVisualStyleBackColor = true;
            this.manageDepartmentTblBtn.Click += new System.EventHandler(this.manageDepartmentTblBtn_Click);
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
            this.tableAdapterManager.FinancialItemTblTableAdapter = null;
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
            // manageSubDepartmentTblBtn
            // 
            this.manageSubDepartmentTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageSubDepartmentTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageSubDepartmentTblBtn.Location = new System.Drawing.Point(580, 195);
            this.manageSubDepartmentTblBtn.Name = "manageSubDepartmentTblBtn";
            this.manageSubDepartmentTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageSubDepartmentTblBtn.TabIndex = 36;
            this.manageSubDepartmentTblBtn.UseVisualStyleBackColor = true;
            this.manageSubDepartmentTblBtn.Click += new System.EventHandler(this.manageSubDepartmentTblBtn_Click);
            // 
            // financialItemSubDeptLabel
            // 
            this.financialItemSubDeptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financialItemSubDeptLabel.AutoSize = true;
            this.financialItemSubDeptLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialItemSubDeptLabel.Location = new System.Drawing.Point(50, 210);
            this.financialItemSubDeptLabel.Name = "financialItemSubDeptLabel";
            this.financialItemSubDeptLabel.Size = new System.Drawing.Size(61, 24);
            this.financialItemSubDeptLabel.TabIndex = 30;
            this.financialItemSubDeptLabel.Text = "الوحدة:";
            // 
            // financialItemSubDeptLookUpEdit
            // 
            this.financialItemSubDeptLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financialItemSubDeptLookUpEdit.Location = new System.Drawing.Point(233, 207);
            this.financialItemSubDeptLookUpEdit.Name = "financialItemSubDeptLookUpEdit";
            this.financialItemSubDeptLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialItemSubDeptLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.financialItemSubDeptLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.financialItemSubDeptLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الوحدة", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubDepartmentName", "اسم الوحدة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainDepartment", "معرف القسم", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.financialItemSubDeptLookUpEdit.Properties.DataSource = this.subDepartmentTblBindingSource;
            this.financialItemSubDeptLookUpEdit.Properties.DisplayMember = "SubDepartmentName";
            this.financialItemSubDeptLookUpEdit.Properties.PopupWidth = 500;
            this.financialItemSubDeptLookUpEdit.Properties.ValueMember = "ID";
            this.financialItemSubDeptLookUpEdit.Size = new System.Drawing.Size(321, 30);
            this.financialItemSubDeptLookUpEdit.TabIndex = 35;
            // 
            // subDepartmentTblBindingSource
            // 
            this.subDepartmentTblBindingSource.DataMember = "SubDepartmentTbl";
            this.subDepartmentTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // manageSectionTblBtn
            // 
            this.manageSectionTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageSectionTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageSectionTblBtn.Location = new System.Drawing.Point(580, 75);
            this.manageSectionTblBtn.Name = "manageSectionTblBtn";
            this.manageSectionTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageSectionTblBtn.TabIndex = 16;
            this.manageSectionTblBtn.UseVisualStyleBackColor = true;
            this.manageSectionTblBtn.Click += new System.EventHandler(this.manageSectionTblBtn_Click);
            // 
            // financialItemSectionLabel
            // 
            this.financialItemSectionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financialItemSectionLabel.AutoSize = true;
            this.financialItemSectionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialItemSectionLabel.Location = new System.Drawing.Point(50, 90);
            this.financialItemSectionLabel.Name = "financialItemSectionLabel";
            this.financialItemSectionLabel.Size = new System.Drawing.Size(56, 24);
            this.financialItemSectionLabel.TabIndex = 10;
            this.financialItemSectionLabel.Text = "الدائرة:";
            // 
            // financialItemSectionLookUpEdit
            // 
            this.financialItemSectionLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financialItemSectionLookUpEdit.Location = new System.Drawing.Point(233, 87);
            this.financialItemSectionLookUpEdit.Name = "financialItemSectionLookUpEdit";
            this.financialItemSectionLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialItemSectionLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.financialItemSectionLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.financialItemSectionLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الدائرة", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SectionName", "اسم الدائرة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.financialItemSectionLookUpEdit.Properties.DataSource = this.sectionTblBindingSource;
            this.financialItemSectionLookUpEdit.Properties.DisplayMember = "SectionName";
            this.financialItemSectionLookUpEdit.Properties.PopupWidth = 500;
            this.financialItemSectionLookUpEdit.Properties.ValueMember = "ID";
            this.financialItemSectionLookUpEdit.Size = new System.Drawing.Size(321, 30);
            this.financialItemSectionLookUpEdit.TabIndex = 15;
            this.financialItemSectionLookUpEdit.EditValueChanged += new System.EventHandler(this.financialItemSectionLookUpEdit_EditValueChanged);
            // 
            // sectionTblBindingSource
            // 
            this.sectionTblBindingSource.DataMember = "SectionTbl";
            this.sectionTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // financialItemDeptLabel
            // 
            this.financialItemDeptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financialItemDeptLabel.AutoSize = true;
            this.financialItemDeptLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialItemDeptLabel.Location = new System.Drawing.Point(50, 150);
            this.financialItemDeptLabel.Name = "financialItemDeptLabel";
            this.financialItemDeptLabel.Size = new System.Drawing.Size(56, 24);
            this.financialItemDeptLabel.TabIndex = 20;
            this.financialItemDeptLabel.Text = "القسم:";
            // 
            // financialItemDeptLookUpEdit
            // 
            this.financialItemDeptLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financialItemDeptLookUpEdit.Location = new System.Drawing.Point(233, 147);
            this.financialItemDeptLookUpEdit.Name = "financialItemDeptLookUpEdit";
            this.financialItemDeptLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialItemDeptLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.financialItemDeptLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.financialItemDeptLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف القسم", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "اسم القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SectionOfDepartment", "معرف الدائرة", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.financialItemDeptLookUpEdit.Properties.DataSource = this.departmentTblBindingSource;
            this.financialItemDeptLookUpEdit.Properties.DisplayMember = "DepartmentName";
            this.financialItemDeptLookUpEdit.Properties.PopupWidth = 500;
            this.financialItemDeptLookUpEdit.Properties.ValueMember = "ID";
            this.financialItemDeptLookUpEdit.Size = new System.Drawing.Size(321, 30);
            this.financialItemDeptLookUpEdit.TabIndex = 25;
            this.financialItemDeptLookUpEdit.EditValueChanged += new System.EventHandler(this.financialItemDeptLookUpEdit_EditValueChanged);
            // 
            // addNewAssetBtn
            // 
            this.addNewAssetBtn.Image = global::AssetManagement.Properties.Resources._223645;
            this.addNewAssetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewAssetBtn.Location = new System.Drawing.Point(662, 10);
            this.addNewAssetBtn.Name = "addNewAssetBtn";
            this.addNewAssetBtn.Size = new System.Drawing.Size(182, 65);
            this.addNewAssetBtn.TabIndex = 7;
            this.addNewAssetBtn.Text = "إضافة أصل جديد";
            this.addNewAssetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewAssetBtn.UseVisualStyleBackColor = true;
            this.addNewAssetBtn.Click += new System.EventHandler(this.addNewAssetBtn_Click);
            // 
            // AddNewFinancialItemForm
            // 
            this.AcceptButton = this.addNewFinancialItemBtn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.addNewFinancialItemBtn_Cancel;
            this.ClientSize = new System.Drawing.Size(1136, 640);
            this.Controls.Add(this.addNewAssetBtn);
            this.Controls.Add(this.manageSubDepartmentTblBtn);
            this.Controls.Add(this.financialItemSubDeptLabel);
            this.Controls.Add(this.financialItemSubDeptLookUpEdit);
            this.Controls.Add(this.manageSectionTblBtn);
            this.Controls.Add(this.financialItemSectionLabel);
            this.Controls.Add(this.financialItemSectionLookUpEdit);
            this.Controls.Add(this.financialItemDeptLabel);
            this.Controls.Add(this.financialItemDeptLookUpEdit);
            this.Controls.Add(this.manageDepartmentTblBtn);
            this.Controls.Add(this.additionalNotesTextBox);
            this.Controls.Add(this.additionalNotesLabel);
            this.Controls.Add(this.addNewFinancialItemBtn_Cancel);
            this.Controls.Add(this.addNewFinancialItemBtn_OK);
            this.Controls.Add(this.manageCurrencyTblBtn);
            this.Controls.Add(this.amountNumericUpDown);
            this.Controls.Add(this.financialItemCurrencyLookUpEdit);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.financialItemDescriptionTextBox);
            this.Controls.Add(this.financialItemDescriptionLabel);
            this.Controls.Add(this.incomingOrOutgoingPanel);
            this.Controls.Add(this.financialItemInsertionDateLabel);
            this.Controls.Add(this.financialItemInsertionDateDateEdit);
            this.Controls.Add(this.manageFinancialItemCategoryTblBtn);
            this.Controls.Add(this.financialItemCategoryLookUpEdit);
            this.Controls.Add(this.financialItemCategoryLabel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "AddNewFinancialItemForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة سجل مالي جديد";
            this.Load += new System.EventHandler(this.AddNewFinancialItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemInsertionDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemInsertionDateDateEdit.Properties)).EndInit();
            this.incomingOrOutgoingPanel.ResumeLayout(false);
            this.incomingOrOutgoingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCurrencyLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemSubDeptLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemSectionLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemDeptLookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label financialItemCategoryLabel;
        private System.Windows.Forms.Button manageFinancialItemCategoryTblBtn;
        private DevExpress.XtraEditors.LookUpEdit financialItemCategoryLookUpEdit;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private AssetMngDbDataSet assetMngDbDataSet;
        private System.Windows.Forms.BindingSource financialItemCategoryTblBindingSource;
        private AssetMngDbDataSetTableAdapters.FinancialItemCategoryTblTableAdapter financialItemCategoryTblTableAdapter;
        private DevExpress.XtraEditors.DateEdit financialItemInsertionDateDateEdit;
        private System.Windows.Forms.Label financialItemInsertionDateLabel;
        private System.Windows.Forms.Panel incomingOrOutgoingPanel;
        private System.Windows.Forms.RadioButton outgoingRadioButton;
        private System.Windows.Forms.RadioButton incomingRadioButton;
        private System.Windows.Forms.Label financialItemDescriptionLabel;
        private System.Windows.Forms.TextBox financialItemDescriptionTextBox;
        private System.Windows.Forms.Label amountLabel;
        private DevExpress.XtraEditors.LookUpEdit financialItemCurrencyLookUpEdit;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.Button manageCurrencyTblBtn;
        private System.Windows.Forms.BindingSource currencyTblBindingSource;
        private AssetMngDbDataSetTableAdapters.CurrencyTblTableAdapter currencyTblTableAdapter;
        private System.Windows.Forms.Button addNewFinancialItemBtn_Cancel;
        private System.Windows.Forms.Button addNewFinancialItemBtn_OK;
        private System.Windows.Forms.TextBox additionalNotesTextBox;
        private System.Windows.Forms.Label additionalNotesLabel;
        private System.Windows.Forms.Button manageDepartmentTblBtn;
        private System.Windows.Forms.BindingSource departmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter departmentTblTableAdapter;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button manageSubDepartmentTblBtn;
        private System.Windows.Forms.Label financialItemSubDeptLabel;
        private DevExpress.XtraEditors.LookUpEdit financialItemSubDeptLookUpEdit;
        private System.Windows.Forms.Button manageSectionTblBtn;
        private System.Windows.Forms.Label financialItemSectionLabel;
        private DevExpress.XtraEditors.LookUpEdit financialItemSectionLookUpEdit;
        private System.Windows.Forms.Label financialItemDeptLabel;
        private DevExpress.XtraEditors.LookUpEdit financialItemDeptLookUpEdit;
        private System.Windows.Forms.BindingSource subDepartmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SubDepartmentTblTableAdapter subDepartmentTblTableAdapter;
        private System.Windows.Forms.BindingSource sectionTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SectionTblTableAdapter sectionTblTableAdapter;
        private System.Windows.Forms.Button addNewAssetBtn;
        private System.Windows.Forms.RadioButton incomingOutgoingRadioButton;
    }
}