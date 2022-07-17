
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
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.financialItemCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialItemCategoryTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.FinancialItemCategoryTblTableAdapter();
            this.financialItemInsertionDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.financialItemInsertionDateLabel = new System.Windows.Forms.Label();
            this.incomingOrOutgoingPanel = new System.Windows.Forms.Panel();
            this.incomingRadioButton = new System.Windows.Forms.RadioButton();
            this.outgoingRadioButton = new System.Windows.Forms.RadioButton();
            this.financialItemDescriptionLabel = new System.Windows.Forms.Label();
            this.financialItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.financialItemCurrencyLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.manageCurrencyTblBtn = new System.Windows.Forms.Button();
            this.currencyTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currencyTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.CurrencyTblTableAdapter();
            this.addNewFinancialItemBtn_Cancel = new System.Windows.Forms.Button();
            this.addNewFinancialItemBtn_OK = new System.Windows.Forms.Button();
            this.additionalNotesTextBox = new System.Windows.Forms.TextBox();
            this.additionalNotesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemInsertionDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemInsertionDateDateEdit.Properties)).BeginInit();
            this.incomingOrOutgoingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCurrencyLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // financialItemCategoryLabel
            // 
            this.financialItemCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financialItemCategoryLabel.AutoSize = true;
            this.financialItemCategoryLabel.Location = new System.Drawing.Point(46, 40);
            this.financialItemCategoryLabel.Name = "financialItemCategoryLabel";
            this.financialItemCategoryLabel.Size = new System.Drawing.Size(87, 24);
            this.financialItemCategoryLabel.TabIndex = 0;
            this.financialItemCategoryLabel.Text = "البند المالي:";
            // 
            // manageFinancialItemCategoryTblBtn
            // 
            this.manageFinancialItemCategoryTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageFinancialItemCategoryTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageFinancialItemCategoryTblBtn.Location = new System.Drawing.Point(576, 25);
            this.manageFinancialItemCategoryTblBtn.Name = "manageFinancialItemCategoryTblBtn";
            this.manageFinancialItemCategoryTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageFinancialItemCategoryTblBtn.TabIndex = 6;
            this.manageFinancialItemCategoryTblBtn.UseVisualStyleBackColor = true;
            this.manageFinancialItemCategoryTblBtn.Click += new System.EventHandler(this.manageFinancialItemCategoryTblBtn_Click);
            // 
            // financialItemCategoryLookUpEdit
            // 
            this.financialItemCategoryLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financialItemCategoryLookUpEdit.Location = new System.Drawing.Point(229, 37);
            this.financialItemCategoryLookUpEdit.Name = "financialItemCategoryLookUpEdit";
            this.financialItemCategoryLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialItemCategoryLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.financialItemCategoryLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.financialItemCategoryLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف البند المالي", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FinancialItemCategoryName", "اسم البند المالي", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FinancialItemCategoryDetails", "وصف البند المالي", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.financialItemCategoryLookUpEdit.Properties.DataSource = this.financialItemCategoryTblBindingSource;
            this.financialItemCategoryLookUpEdit.Properties.DisplayMember = "FinancialItemCategoryName";
            this.financialItemCategoryLookUpEdit.Properties.ValueMember = "ID";
            this.financialItemCategoryLookUpEdit.Size = new System.Drawing.Size(321, 30);
            this.financialItemCategoryLookUpEdit.TabIndex = 5;
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
            // financialItemCategoryTblTableAdapter
            // 
            this.financialItemCategoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // financialItemInsertionDateDateEdit
            // 
            this.financialItemInsertionDateDateEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financialItemInsertionDateDateEdit.EditValue = null;
            this.financialItemInsertionDateDateEdit.Location = new System.Drawing.Point(229, 247);
            this.financialItemInsertionDateDateEdit.Name = "financialItemInsertionDateDateEdit";
            this.financialItemInsertionDateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialItemInsertionDateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.financialItemInsertionDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.financialItemInsertionDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.financialItemInsertionDateDateEdit.Size = new System.Drawing.Size(321, 30);
            this.financialItemInsertionDateDateEdit.TabIndex = 25;
            // 
            // financialItemInsertionDateLabel
            // 
            this.financialItemInsertionDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financialItemInsertionDateLabel.AutoSize = true;
            this.financialItemInsertionDateLabel.Location = new System.Drawing.Point(46, 250);
            this.financialItemInsertionDateLabel.Name = "financialItemInsertionDateLabel";
            this.financialItemInsertionDateLabel.Size = new System.Drawing.Size(104, 24);
            this.financialItemInsertionDateLabel.TabIndex = 20;
            this.financialItemInsertionDateLabel.Text = "تاريخ السجل:";
            // 
            // incomingOrOutgoingPanel
            // 
            this.incomingOrOutgoingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.incomingOrOutgoingPanel.Controls.Add(this.outgoingRadioButton);
            this.incomingOrOutgoingPanel.Controls.Add(this.incomingRadioButton);
            this.incomingOrOutgoingPanel.Location = new System.Drawing.Point(38, 320);
            this.incomingOrOutgoingPanel.Name = "incomingOrOutgoingPanel";
            this.incomingOrOutgoingPanel.Size = new System.Drawing.Size(310, 85);
            this.incomingOrOutgoingPanel.TabIndex = 30;
            // 
            // incomingRadioButton
            // 
            this.incomingRadioButton.AutoSize = true;
            this.incomingRadioButton.Checked = true;
            this.incomingRadioButton.Location = new System.Drawing.Point(220, 28);
            this.incomingRadioButton.Name = "incomingRadioButton";
            this.incomingRadioButton.Size = new System.Drawing.Size(56, 28);
            this.incomingRadioButton.TabIndex = 35;
            this.incomingRadioButton.TabStop = true;
            this.incomingRadioButton.Text = "وارد";
            this.incomingRadioButton.UseVisualStyleBackColor = true;
            // 
            // outgoingRadioButton
            // 
            this.outgoingRadioButton.AutoSize = true;
            this.outgoingRadioButton.Location = new System.Drawing.Point(51, 28);
            this.outgoingRadioButton.Name = "outgoingRadioButton";
            this.outgoingRadioButton.Size = new System.Drawing.Size(67, 28);
            this.outgoingRadioButton.TabIndex = 40;
            this.outgoingRadioButton.Text = "صادر";
            this.outgoingRadioButton.UseVisualStyleBackColor = true;
            // 
            // financialItemDescriptionLabel
            // 
            this.financialItemDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financialItemDescriptionLabel.AutoSize = true;
            this.financialItemDescriptionLabel.Location = new System.Drawing.Point(46, 110);
            this.financialItemDescriptionLabel.Name = "financialItemDescriptionLabel";
            this.financialItemDescriptionLabel.Size = new System.Drawing.Size(95, 24);
            this.financialItemDescriptionLabel.TabIndex = 10;
            this.financialItemDescriptionLabel.Text = "بيان السجل:";
            // 
            // financialItemDescriptionTextBox
            // 
            this.financialItemDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financialItemDescriptionTextBox.Location = new System.Drawing.Point(229, 110);
            this.financialItemDescriptionTextBox.Multiline = true;
            this.financialItemDescriptionTextBox.Name = "financialItemDescriptionTextBox";
            this.financialItemDescriptionTextBox.Size = new System.Drawing.Size(321, 105);
            this.financialItemDescriptionTextBox.TabIndex = 15;
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(46, 440);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(54, 24);
            this.amountLabel.TabIndex = 45;
            this.amountLabel.Text = "المبلغ:";
            // 
            // financialItemCurrencyLookUpEdit
            // 
            this.financialItemCurrencyLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financialItemCurrencyLookUpEdit.Location = new System.Drawing.Point(333, 437);
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
            this.financialItemCurrencyLookUpEdit.Properties.ValueMember = "ID";
            this.financialItemCurrencyLookUpEdit.Size = new System.Drawing.Size(217, 30);
            this.financialItemCurrencyLookUpEdit.TabIndex = 55;
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountNumericUpDown.DecimalPlaces = 2;
            this.amountNumericUpDown.Location = new System.Drawing.Point(144, 436);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(153, 32);
            this.amountNumericUpDown.TabIndex = 50;
            // 
            // manageCurrencyTblBtn
            // 
            this.manageCurrencyTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageCurrencyTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageCurrencyTblBtn.Location = new System.Drawing.Point(576, 425);
            this.manageCurrencyTblBtn.Name = "manageCurrencyTblBtn";
            this.manageCurrencyTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageCurrencyTblBtn.TabIndex = 56;
            this.manageCurrencyTblBtn.UseVisualStyleBackColor = true;
            this.manageCurrencyTblBtn.Click += new System.EventHandler(this.manageCurrencyTblBtn_Click);
            // 
            // currencyTblBindingSource
            // 
            this.currencyTblBindingSource.DataMember = "CurrencyTbl";
            this.currencyTblBindingSource.DataSource = this.assetMngDbDataSet;
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
            this.addNewFinancialItemBtn_Cancel.Location = new System.Drawing.Point(890, 433);
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
            this.addNewFinancialItemBtn_OK.Location = new System.Drawing.Point(890, 343);
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
            this.additionalNotesTextBox.Location = new System.Drawing.Point(751, 84);
            this.additionalNotesTextBox.Multiline = true;
            this.additionalNotesTextBox.Name = "additionalNotesTextBox";
            this.additionalNotesTextBox.Size = new System.Drawing.Size(321, 105);
            this.additionalNotesTextBox.TabIndex = 65;
            // 
            // additionalNotesLabel
            // 
            this.additionalNotesLabel.AutoSize = true;
            this.additionalNotesLabel.Location = new System.Drawing.Point(751, 40);
            this.additionalNotesLabel.Name = "additionalNotesLabel";
            this.additionalNotesLabel.Size = new System.Drawing.Size(129, 24);
            this.additionalNotesLabel.TabIndex = 60;
            this.additionalNotesLabel.Text = "ملاحظات إضافية:";
            // 
            // AddNewFinancialItemForm
            // 
            this.AcceptButton = this.addNewFinancialItemBtn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.addNewFinancialItemBtn_Cancel;
            this.ClientSize = new System.Drawing.Size(1110, 535);
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
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemInsertionDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemInsertionDateDateEdit.Properties)).EndInit();
            this.incomingOrOutgoingPanel.ResumeLayout(false);
            this.incomingOrOutgoingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCurrencyLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).EndInit();
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
    }
}