﻿
namespace AssetManagement.Assets
{
    partial class TransacteAssetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransacteAssetForm));
            this.moveAssetGroupBox = new System.Windows.Forms.GroupBox();
            this.assetTransactionPanel = new System.Windows.Forms.Panel();
            this.currentPriceWithDestroyingLabel = new System.Windows.Forms.Label();
            this.currentPriceWithDestroyingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.withDestroyingCheckBox = new System.Windows.Forms.CheckBox();
            this.manageCurrencyTblBtn = new System.Windows.Forms.Button();
            this.moneyAmountCurrencyLabel = new System.Windows.Forms.Label();
            this.moneyAmountCurrencyLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.currencyTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.manageTransactionTypeTblBtn = new System.Windows.Forms.Button();
            this.moneyAmountLabel = new System.Windows.Forms.Label();
            this.moneyAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.assetNotesLabel = new System.Windows.Forms.Label();
            this.assetNotesTextBox = new System.Windows.Forms.TextBox();
            this.getAssetOutOfWorkCheckBox = new System.Windows.Forms.CheckBox();
            this.assetTransactBtn = new System.Windows.Forms.Button();
            this.assetTransactionDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.transactionTypeLabel = new System.Windows.Forms.Label();
            this.assetTransactionDateLabel = new System.Windows.Forms.Label();
            this.transactionTypeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.transactionTypeTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetInfoLabel = new System.Windows.Forms.Label();
            this.assetTransactionTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.assetTransactionTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.assetTransactionTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.assetMoveVwGridControl = new DevExpress.XtraGrid.GridControl();
            this.assetMoveVwGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.transactionTypeRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.transactionTypeTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionMadeOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionMadeBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoneyAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoneyAmountCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.moneyAmountCurrencyRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.currencyTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colGetAssetOutOfWork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWithDestroying = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentPriceWithDestroying = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fromSquareTextBox = new System.Windows.Forms.TextBox();
            this.fromSectionTextBox = new System.Windows.Forms.TextBox();
            this.fromDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.fromCustodianNameTextBox = new System.Windows.Forms.TextBox();
            this.fromCustodianNameLabel = new System.Windows.Forms.Label();
            this.fromSquareLabel = new System.Windows.Forms.Label();
            this.fromSectionLabel = new System.Windows.Forms.Label();
            this.fromDepartmentLabel = new System.Windows.Forms.Label();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.assetTransactionTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetTransactionTblTableAdapter();
            this.currencyTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.CurrencyTblTableAdapter();
            this.transactionTypeTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.TransactionTypeTblTableAdapter();
            this.viewAssetInformationBtn = new System.Windows.Forms.Button();
            this.searchResultsListBox = new System.Windows.Forms.ListBox();
            this.searchAssetBtn = new System.Windows.Forms.Button();
            this.assetCodeLabel = new System.Windows.Forms.Label();
            this.assetCodeTextBox = new System.Windows.Forms.TextBox();
            this.moveAssetGroupBox.SuspendLayout();
            this.assetTransactionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentPriceWithDestroyingNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyAmountCurrencyLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyAmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionTblBindingNavigator)).BeginInit();
            this.assetTransactionTblBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMoveVwGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMoveVwGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyAmountCurrencyRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // moveAssetGroupBox
            // 
            this.moveAssetGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.moveAssetGroupBox.Controls.Add(this.assetTransactionPanel);
            this.moveAssetGroupBox.Controls.Add(this.assetInfoLabel);
            this.moveAssetGroupBox.Controls.Add(this.assetTransactionTblBindingNavigator);
            this.moveAssetGroupBox.Controls.Add(this.assetMoveVwGridControl);
            this.moveAssetGroupBox.Controls.Add(this.fromSquareTextBox);
            this.moveAssetGroupBox.Controls.Add(this.fromSectionTextBox);
            this.moveAssetGroupBox.Controls.Add(this.fromDepartmentTextBox);
            this.moveAssetGroupBox.Controls.Add(this.fromCustodianNameTextBox);
            this.moveAssetGroupBox.Controls.Add(this.fromCustodianNameLabel);
            this.moveAssetGroupBox.Controls.Add(this.fromSquareLabel);
            this.moveAssetGroupBox.Controls.Add(this.fromSectionLabel);
            this.moveAssetGroupBox.Controls.Add(this.fromDepartmentLabel);
            this.moveAssetGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.moveAssetGroupBox.Location = new System.Drawing.Point(0, 179);
            this.moveAssetGroupBox.Name = "moveAssetGroupBox";
            this.moveAssetGroupBox.Size = new System.Drawing.Size(1276, 622);
            this.moveAssetGroupBox.TabIndex = 100;
            this.moveAssetGroupBox.TabStop = false;
            this.moveAssetGroupBox.Text = "معلومات الأصل الحالية والجديدة";
            this.moveAssetGroupBox.Visible = false;
            // 
            // assetTransactionPanel
            // 
            this.assetTransactionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assetTransactionPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.assetTransactionPanel.Controls.Add(this.currentPriceWithDestroyingLabel);
            this.assetTransactionPanel.Controls.Add(this.currentPriceWithDestroyingNumericUpDown);
            this.assetTransactionPanel.Controls.Add(this.withDestroyingCheckBox);
            this.assetTransactionPanel.Controls.Add(this.manageCurrencyTblBtn);
            this.assetTransactionPanel.Controls.Add(this.moneyAmountCurrencyLabel);
            this.assetTransactionPanel.Controls.Add(this.moneyAmountCurrencyLookUpEdit);
            this.assetTransactionPanel.Controls.Add(this.manageTransactionTypeTblBtn);
            this.assetTransactionPanel.Controls.Add(this.moneyAmountLabel);
            this.assetTransactionPanel.Controls.Add(this.moneyAmountNumericUpDown);
            this.assetTransactionPanel.Controls.Add(this.assetNotesLabel);
            this.assetTransactionPanel.Controls.Add(this.assetNotesTextBox);
            this.assetTransactionPanel.Controls.Add(this.getAssetOutOfWorkCheckBox);
            this.assetTransactionPanel.Controls.Add(this.assetTransactBtn);
            this.assetTransactionPanel.Controls.Add(this.assetTransactionDateDateEdit);
            this.assetTransactionPanel.Controls.Add(this.transactionTypeLabel);
            this.assetTransactionPanel.Controls.Add(this.assetTransactionDateLabel);
            this.assetTransactionPanel.Controls.Add(this.transactionTypeLookUpEdit);
            this.assetTransactionPanel.Location = new System.Drawing.Point(3, 140);
            this.assetTransactionPanel.Name = "assetTransactionPanel";
            this.assetTransactionPanel.Size = new System.Drawing.Size(1270, 224);
            this.assetTransactionPanel.TabIndex = 200;
            this.assetTransactionPanel.Visible = false;
            // 
            // currentPriceWithDestroyingLabel
            // 
            this.currentPriceWithDestroyingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPriceWithDestroyingLabel.AutoSize = true;
            this.currentPriceWithDestroyingLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPriceWithDestroyingLabel.Location = new System.Drawing.Point(1080, 181);
            this.currentPriceWithDestroyingLabel.Name = "currentPriceWithDestroyingLabel";
            this.currentPriceWithDestroyingLabel.Size = new System.Drawing.Size(158, 21);
            this.currentPriceWithDestroyingLabel.TabIndex = 275;
            this.currentPriceWithDestroyingLabel.Text = "القيمة الحالية مع الإهلاك:";
            // 
            // currentPriceWithDestroyingNumericUpDown
            // 
            this.currentPriceWithDestroyingNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPriceWithDestroyingNumericUpDown.DecimalPlaces = 2;
            this.currentPriceWithDestroyingNumericUpDown.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPriceWithDestroyingNumericUpDown.Location = new System.Drawing.Point(871, 177);
            this.currentPriceWithDestroyingNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.currentPriceWithDestroyingNumericUpDown.Name = "currentPriceWithDestroyingNumericUpDown";
            this.currentPriceWithDestroyingNumericUpDown.Size = new System.Drawing.Size(188, 28);
            this.currentPriceWithDestroyingNumericUpDown.TabIndex = 280;
            // 
            // withDestroyingCheckBox
            // 
            this.withDestroyingCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.withDestroyingCheckBox.AutoSize = true;
            this.withDestroyingCheckBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withDestroyingCheckBox.Location = new System.Drawing.Point(871, 75);
            this.withDestroyingCheckBox.Name = "withDestroyingCheckBox";
            this.withDestroyingCheckBox.Size = new System.Drawing.Size(86, 25);
            this.withDestroyingCheckBox.TabIndex = 235;
            this.withDestroyingCheckBox.Text = "مع إهلاك";
            this.withDestroyingCheckBox.UseVisualStyleBackColor = true;
            this.withDestroyingCheckBox.Visible = false;
            // 
            // manageCurrencyTblBtn
            // 
            this.manageCurrencyTblBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCurrencyTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageCurrencyTblBtn.Location = new System.Drawing.Point(264, 110);
            this.manageCurrencyTblBtn.Name = "manageCurrencyTblBtn";
            this.manageCurrencyTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageCurrencyTblBtn.TabIndex = 270;
            this.manageCurrencyTblBtn.UseVisualStyleBackColor = true;
            this.manageCurrencyTblBtn.Click += new System.EventHandler(this.manageCurrencyTblBtn_Click);
            // 
            // moneyAmountCurrencyLabel
            // 
            this.moneyAmountCurrencyLabel.AutoSize = true;
            this.moneyAmountCurrencyLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyAmountCurrencyLabel.Location = new System.Drawing.Point(732, 127);
            this.moneyAmountCurrencyLabel.Name = "moneyAmountCurrencyLabel";
            this.moneyAmountCurrencyLabel.Size = new System.Drawing.Size(49, 21);
            this.moneyAmountCurrencyLabel.TabIndex = 260;
            this.moneyAmountCurrencyLabel.Text = "العملة:";
            // 
            // moneyAmountCurrencyLookUpEdit
            // 
            this.moneyAmountCurrencyLookUpEdit.Location = new System.Drawing.Point(403, 123);
            this.moneyAmountCurrencyLookUpEdit.Name = "moneyAmountCurrencyLookUpEdit";
            this.moneyAmountCurrencyLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyAmountCurrencyLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.moneyAmountCurrencyLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.moneyAmountCurrencyLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف العملة", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyName", "اسم العملة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.moneyAmountCurrencyLookUpEdit.Properties.DataSource = this.currencyTblBindingSource;
            this.moneyAmountCurrencyLookUpEdit.Properties.DisplayMember = "CurrencyName";
            this.moneyAmountCurrencyLookUpEdit.Properties.ValueMember = "ID";
            this.moneyAmountCurrencyLookUpEdit.Size = new System.Drawing.Size(261, 28);
            this.moneyAmountCurrencyLookUpEdit.TabIndex = 265;
            // 
            // currencyTblBindingSource
            // 
            this.currencyTblBindingSource.DataMember = "CurrencyTbl";
            this.currencyTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manageTransactionTypeTblBtn
            // 
            this.manageTransactionTypeTblBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageTransactionTypeTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageTransactionTypeTblBtn.Location = new System.Drawing.Point(264, 10);
            this.manageTransactionTypeTblBtn.Name = "manageTransactionTypeTblBtn";
            this.manageTransactionTypeTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageTransactionTypeTblBtn.TabIndex = 225;
            this.manageTransactionTypeTblBtn.UseVisualStyleBackColor = true;
            this.manageTransactionTypeTblBtn.Click += new System.EventHandler(this.manageTransactionTypeTblBtn_Click);
            // 
            // moneyAmountLabel
            // 
            this.moneyAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moneyAmountLabel.AutoSize = true;
            this.moneyAmountLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyAmountLabel.Location = new System.Drawing.Point(1167, 127);
            this.moneyAmountLabel.Name = "moneyAmountLabel";
            this.moneyAmountLabel.Size = new System.Drawing.Size(71, 21);
            this.moneyAmountLabel.TabIndex = 250;
            this.moneyAmountLabel.Text = "سعر البيع:";
            // 
            // moneyAmountNumericUpDown
            // 
            this.moneyAmountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moneyAmountNumericUpDown.DecimalPlaces = 2;
            this.moneyAmountNumericUpDown.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyAmountNumericUpDown.Location = new System.Drawing.Point(871, 123);
            this.moneyAmountNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.moneyAmountNumericUpDown.Name = "moneyAmountNumericUpDown";
            this.moneyAmountNumericUpDown.Size = new System.Drawing.Size(188, 28);
            this.moneyAmountNumericUpDown.TabIndex = 255;
            // 
            // assetNotesLabel
            // 
            this.assetNotesLabel.AutoSize = true;
            this.assetNotesLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetNotesLabel.Location = new System.Drawing.Point(710, 77);
            this.assetNotesLabel.Name = "assetNotesLabel";
            this.assetNotesLabel.Size = new System.Drawing.Size(70, 21);
            this.assetNotesLabel.TabIndex = 240;
            this.assetNotesLabel.Text = "ملاحظات:";
            // 
            // assetNotesTextBox
            // 
            this.assetNotesTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetNotesTextBox.Location = new System.Drawing.Point(250, 73);
            this.assetNotesTextBox.Name = "assetNotesTextBox";
            this.assetNotesTextBox.Size = new System.Drawing.Size(414, 28);
            this.assetNotesTextBox.TabIndex = 245;
            // 
            // getAssetOutOfWorkCheckBox
            // 
            this.getAssetOutOfWorkCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getAssetOutOfWorkCheckBox.AutoSize = true;
            this.getAssetOutOfWorkCheckBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAssetOutOfWorkCheckBox.Location = new System.Drawing.Point(1071, 75);
            this.getAssetOutOfWorkCheckBox.Name = "getAssetOutOfWorkCheckBox";
            this.getAssetOutOfWorkCheckBox.Size = new System.Drawing.Size(167, 25);
            this.getAssetOutOfWorkCheckBox.TabIndex = 230;
            this.getAssetOutOfWorkCheckBox.Text = "إخراج الأصل من الخدمة";
            this.getAssetOutOfWorkCheckBox.UseVisualStyleBackColor = true;
            this.getAssetOutOfWorkCheckBox.CheckedChanged += new System.EventHandler(this.getAssetOutOfWorkCheckBox_CheckedChanged);
            // 
            // assetTransactBtn
            // 
            this.assetTransactBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetTransactBtn.Image = global::AssetManagement.Properties.Resources._1592276;
            this.assetTransactBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.assetTransactBtn.Location = new System.Drawing.Point(52, 131);
            this.assetTransactBtn.Name = "assetTransactBtn";
            this.assetTransactBtn.Size = new System.Drawing.Size(163, 74);
            this.assetTransactBtn.TabIndex = 400;
            this.assetTransactBtn.Text = "تصريف";
            this.assetTransactBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.assetTransactBtn.UseVisualStyleBackColor = true;
            this.assetTransactBtn.Click += new System.EventHandler(this.assetTransactBtn_Click);
            // 
            // assetTransactionDateDateEdit
            // 
            this.assetTransactionDateDateEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assetTransactionDateDateEdit.EditValue = null;
            this.assetTransactionDateDateEdit.Location = new System.Drawing.Point(871, 23);
            this.assetTransactionDateDateEdit.Name = "assetTransactionDateDateEdit";
            this.assetTransactionDateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetTransactionDateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.assetTransactionDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.assetTransactionDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.assetTransactionDateDateEdit.Size = new System.Drawing.Size(259, 28);
            this.assetTransactionDateDateEdit.TabIndex = 210;
            // 
            // transactionTypeLabel
            // 
            this.transactionTypeLabel.AutoSize = true;
            this.transactionTypeLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionTypeLabel.Location = new System.Drawing.Point(688, 27);
            this.transactionTypeLabel.Name = "transactionTypeLabel";
            this.transactionTypeLabel.Size = new System.Drawing.Size(86, 21);
            this.transactionTypeLabel.TabIndex = 215;
            this.transactionTypeLabel.Text = "نوع التصريف:";
            // 
            // assetTransactionDateLabel
            // 
            this.assetTransactionDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assetTransactionDateLabel.AutoSize = true;
            this.assetTransactionDateLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetTransactionDateLabel.Location = new System.Drawing.Point(1140, 27);
            this.assetTransactionDateLabel.Name = "assetTransactionDateLabel";
            this.assetTransactionDateLabel.Size = new System.Drawing.Size(98, 21);
            this.assetTransactionDateLabel.TabIndex = 205;
            this.assetTransactionDateLabel.Text = "تاريخ التصريف:";
            // 
            // transactionTypeLookUpEdit
            // 
            this.transactionTypeLookUpEdit.Location = new System.Drawing.Point(403, 23);
            this.transactionTypeLookUpEdit.Name = "transactionTypeLookUpEdit";
            this.transactionTypeLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionTypeLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.transactionTypeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.transactionTypeLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف نوع تصريف الأصل", 23, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TransactionTypeName", "اسم نوع تصريف الأصل", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.transactionTypeLookUpEdit.Properties.DataSource = this.transactionTypeTblBindingSource;
            this.transactionTypeLookUpEdit.Properties.DisplayMember = "TransactionTypeName";
            this.transactionTypeLookUpEdit.Properties.ValueMember = "ID";
            this.transactionTypeLookUpEdit.Size = new System.Drawing.Size(261, 28);
            this.transactionTypeLookUpEdit.TabIndex = 220;
            // 
            // transactionTypeTblBindingSource
            // 
            this.transactionTypeTblBindingSource.DataMember = "TransactionTypeTbl";
            this.transactionTypeTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetInfoLabel
            // 
            this.assetInfoLabel.AutoSize = true;
            this.assetInfoLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.assetInfoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.assetInfoLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetInfoLabel.Location = new System.Drawing.Point(3, 28);
            this.assetInfoLabel.Name = "assetInfoLabel";
            this.assetInfoLabel.Size = new System.Drawing.Size(0, 29);
            this.assetInfoLabel.TabIndex = 310;
            // 
            // assetTransactionTblBindingNavigator
            // 
            this.assetTransactionTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.assetTransactionTblBindingNavigator.BindingSource = this.assetTransactionTblBindingSource;
            this.assetTransactionTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.assetTransactionTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.assetTransactionTblBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.assetTransactionTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.assetTransactionTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.assetTransactionTblBindingNavigatorSaveItem});
            this.assetTransactionTblBindingNavigator.Location = new System.Drawing.Point(3, 364);
            this.assetTransactionTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.assetTransactionTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.assetTransactionTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.assetTransactionTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.assetTransactionTblBindingNavigator.Name = "assetTransactionTblBindingNavigator";
            this.assetTransactionTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.assetTransactionTblBindingNavigator.Size = new System.Drawing.Size(1270, 27);
            this.assetTransactionTblBindingNavigator.TabIndex = 500;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // assetTransactionTblBindingSource
            // 
            this.assetTransactionTblBindingSource.DataMember = "AssetTransactionTbl";
            this.assetTransactionTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // assetTransactionTblBindingNavigatorSaveItem
            // 
            this.assetTransactionTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.assetTransactionTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("assetTransactionTblBindingNavigatorSaveItem.Image")));
            this.assetTransactionTblBindingNavigatorSaveItem.Name = "assetTransactionTblBindingNavigatorSaveItem";
            this.assetTransactionTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.assetTransactionTblBindingNavigatorSaveItem.Text = "Save Data";
            this.assetTransactionTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.assetTransactionTblBindingNavigatorSaveItem_Click);
            // 
            // assetMoveVwGridControl
            // 
            this.assetMoveVwGridControl.DataSource = this.assetTransactionTblBindingSource;
            this.assetMoveVwGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.assetMoveVwGridControl.Location = new System.Drawing.Point(3, 391);
            this.assetMoveVwGridControl.MainView = this.assetMoveVwGridView;
            this.assetMoveVwGridControl.Name = "assetMoveVwGridControl";
            this.assetMoveVwGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.transactionTypeRepositoryItemLookUpEdit,
            this.moneyAmountCurrencyRepositoryItemLookUpEdit});
            this.assetMoveVwGridControl.Size = new System.Drawing.Size(1270, 228);
            this.assetMoveVwGridControl.TabIndex = 600;
            this.assetMoveVwGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.assetMoveVwGridView});
            this.assetMoveVwGridControl.Click += new System.EventHandler(this.assetMoveVwGridControl_Click);
            // 
            // assetMoveVwGridView
            // 
            this.assetMoveVwGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colAssetID,
            this.colTransactionType,
            this.colTransactionDate,
            this.colTransactionNotes,
            this.colTransactionMadeOn,
            this.colTransactionMadeBy,
            this.colMoneyAmount,
            this.colMoneyAmountCurrency,
            this.colGetAssetOutOfWork,
            this.colWithDestroying,
            this.colCurrentPriceWithDestroying});
            this.assetMoveVwGridView.GridControl = this.assetMoveVwGridControl;
            this.assetMoveVwGridView.Name = "assetMoveVwGridView";
            // 
            // colID
            // 
            this.colID.Caption = "معرف سجل التصريف";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Width = 80;
            // 
            // colAssetID
            // 
            this.colAssetID.Caption = "معرف الأصل";
            this.colAssetID.FieldName = "AssetID";
            this.colAssetID.MinWidth = 25;
            this.colAssetID.Name = "colAssetID";
            this.colAssetID.Width = 80;
            // 
            // colTransactionType
            // 
            this.colTransactionType.Caption = "نوع التصريف";
            this.colTransactionType.ColumnEdit = this.transactionTypeRepositoryItemLookUpEdit;
            this.colTransactionType.FieldName = "TransactionType";
            this.colTransactionType.MinWidth = 25;
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.Visible = true;
            this.colTransactionType.VisibleIndex = 0;
            this.colTransactionType.Width = 48;
            // 
            // transactionTypeRepositoryItemLookUpEdit
            // 
            this.transactionTypeRepositoryItemLookUpEdit.AutoHeight = false;
            this.transactionTypeRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.transactionTypeRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف نوع تصريف العملة", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TransactionTypeName", "اسم نوع تصريف العملة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.transactionTypeRepositoryItemLookUpEdit.DataSource = this.transactionTypeTblBindingSource1;
            this.transactionTypeRepositoryItemLookUpEdit.DisplayMember = "TransactionTypeName";
            this.transactionTypeRepositoryItemLookUpEdit.Name = "transactionTypeRepositoryItemLookUpEdit";
            this.transactionTypeRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // transactionTypeTblBindingSource1
            // 
            this.transactionTypeTblBindingSource1.DataMember = "TransactionTypeTbl";
            this.transactionTypeTblBindingSource1.DataSource = this.assetMngDbDataSet;
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.Caption = "تاريخ التصريف";
            this.colTransactionDate.FieldName = "TransactionDate";
            this.colTransactionDate.MinWidth = 25;
            this.colTransactionDate.Name = "colTransactionDate";
            this.colTransactionDate.Visible = true;
            this.colTransactionDate.VisibleIndex = 1;
            this.colTransactionDate.Width = 72;
            // 
            // colTransactionNotes
            // 
            this.colTransactionNotes.Caption = "ملاحظات التصريف";
            this.colTransactionNotes.FieldName = "TransactionNotes";
            this.colTransactionNotes.MinWidth = 25;
            this.colTransactionNotes.Name = "colTransactionNotes";
            this.colTransactionNotes.Visible = true;
            this.colTransactionNotes.VisibleIndex = 2;
            this.colTransactionNotes.Width = 200;
            // 
            // colTransactionMadeOn
            // 
            this.colTransactionMadeOn.Caption = "تاريخ إنشاء سجل التصريف";
            this.colTransactionMadeOn.FieldName = "TransactionMadeOn";
            this.colTransactionMadeOn.MinWidth = 25;
            this.colTransactionMadeOn.Name = "colTransactionMadeOn";
            this.colTransactionMadeOn.Width = 80;
            // 
            // colTransactionMadeBy
            // 
            this.colTransactionMadeBy.Caption = "الحساب الذي قام بالإنشاء";
            this.colTransactionMadeBy.FieldName = "TransactionMadeBy";
            this.colTransactionMadeBy.MinWidth = 25;
            this.colTransactionMadeBy.Name = "colTransactionMadeBy";
            this.colTransactionMadeBy.Width = 80;
            // 
            // colMoneyAmount
            // 
            this.colMoneyAmount.Caption = "مبلغ البيع";
            this.colMoneyAmount.FieldName = "MoneyAmount";
            this.colMoneyAmount.MinWidth = 25;
            this.colMoneyAmount.Name = "colMoneyAmount";
            this.colMoneyAmount.Visible = true;
            this.colMoneyAmount.VisibleIndex = 3;
            this.colMoneyAmount.Width = 80;
            // 
            // colMoneyAmountCurrency
            // 
            this.colMoneyAmountCurrency.Caption = "عملة البيع";
            this.colMoneyAmountCurrency.ColumnEdit = this.moneyAmountCurrencyRepositoryItemLookUpEdit;
            this.colMoneyAmountCurrency.FieldName = "MoneyAmountCurrency";
            this.colMoneyAmountCurrency.MinWidth = 25;
            this.colMoneyAmountCurrency.Name = "colMoneyAmountCurrency";
            this.colMoneyAmountCurrency.Visible = true;
            this.colMoneyAmountCurrency.VisibleIndex = 4;
            this.colMoneyAmountCurrency.Width = 120;
            // 
            // moneyAmountCurrencyRepositoryItemLookUpEdit
            // 
            this.moneyAmountCurrencyRepositoryItemLookUpEdit.AutoHeight = false;
            this.moneyAmountCurrencyRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.moneyAmountCurrencyRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف العملة", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyName", "اسم العملة", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.moneyAmountCurrencyRepositoryItemLookUpEdit.DataSource = this.currencyTblBindingSource1;
            this.moneyAmountCurrencyRepositoryItemLookUpEdit.DisplayMember = "CurrencyName";
            this.moneyAmountCurrencyRepositoryItemLookUpEdit.Name = "moneyAmountCurrencyRepositoryItemLookUpEdit";
            this.moneyAmountCurrencyRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // currencyTblBindingSource1
            // 
            this.currencyTblBindingSource1.DataMember = "CurrencyTbl";
            this.currencyTblBindingSource1.DataSource = this.assetMngDbDataSet;
            // 
            // colGetAssetOutOfWork
            // 
            this.colGetAssetOutOfWork.Caption = "إخراج الأصل من الخدمة";
            this.colGetAssetOutOfWork.FieldName = "GetAssetOutOfWork";
            this.colGetAssetOutOfWork.MinWidth = 25;
            this.colGetAssetOutOfWork.Name = "colGetAssetOutOfWork";
            this.colGetAssetOutOfWork.Visible = true;
            this.colGetAssetOutOfWork.VisibleIndex = 5;
            this.colGetAssetOutOfWork.Width = 50;
            // 
            // colWithDestroying
            // 
            this.colWithDestroying.Caption = "مع إهلاك";
            this.colWithDestroying.FieldName = "WithDestroying";
            this.colWithDestroying.MinWidth = 25;
            this.colWithDestroying.Name = "colWithDestroying";
            this.colWithDestroying.Visible = true;
            this.colWithDestroying.VisibleIndex = 6;
            this.colWithDestroying.Width = 50;
            // 
            // colCurrentPriceWithDestroying
            // 
            this.colCurrentPriceWithDestroying.Caption = "القيمة الحالية مع الإهلاك";
            this.colCurrentPriceWithDestroying.FieldName = "CurrentPriceWithDestroying";
            this.colCurrentPriceWithDestroying.MinWidth = 25;
            this.colCurrentPriceWithDestroying.Name = "colCurrentPriceWithDestroying";
            this.colCurrentPriceWithDestroying.Visible = true;
            this.colCurrentPriceWithDestroying.VisibleIndex = 7;
            this.colCurrentPriceWithDestroying.Width = 80;
            // 
            // fromSquareTextBox
            // 
            this.fromSquareTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromSquareTextBox.Location = new System.Drawing.Point(290, 41);
            this.fromSquareTextBox.Name = "fromSquareTextBox";
            this.fromSquareTextBox.ReadOnly = true;
            this.fromSquareTextBox.Size = new System.Drawing.Size(261, 28);
            this.fromSquareTextBox.TabIndex = 120;
            // 
            // fromSectionTextBox
            // 
            this.fromSectionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromSectionTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromSectionTextBox.Location = new System.Drawing.Point(756, 88);
            this.fromSectionTextBox.Name = "fromSectionTextBox";
            this.fromSectionTextBox.ReadOnly = true;
            this.fromSectionTextBox.Size = new System.Drawing.Size(261, 28);
            this.fromSectionTextBox.TabIndex = 130;
            // 
            // fromDepartmentTextBox
            // 
            this.fromDepartmentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromDepartmentTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDepartmentTextBox.Location = new System.Drawing.Point(756, 41);
            this.fromDepartmentTextBox.Name = "fromDepartmentTextBox";
            this.fromDepartmentTextBox.ReadOnly = true;
            this.fromDepartmentTextBox.Size = new System.Drawing.Size(261, 28);
            this.fromDepartmentTextBox.TabIndex = 110;
            // 
            // fromCustodianNameTextBox
            // 
            this.fromCustodianNameTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromCustodianNameTextBox.Location = new System.Drawing.Point(290, 88);
            this.fromCustodianNameTextBox.Name = "fromCustodianNameTextBox";
            this.fromCustodianNameTextBox.ReadOnly = true;
            this.fromCustodianNameTextBox.Size = new System.Drawing.Size(261, 28);
            this.fromCustodianNameTextBox.TabIndex = 140;
            // 
            // fromCustodianNameLabel
            // 
            this.fromCustodianNameLabel.AutoSize = true;
            this.fromCustodianNameLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromCustodianNameLabel.Location = new System.Drawing.Point(571, 92);
            this.fromCustodianNameLabel.Name = "fromCustodianNameLabel";
            this.fromCustodianNameLabel.Size = new System.Drawing.Size(97, 21);
            this.fromCustodianNameLabel.TabIndex = 135;
            this.fromCustodianNameLabel.Text = "صاحب العهدة:";
            // 
            // fromSquareLabel
            // 
            this.fromSquareLabel.AutoSize = true;
            this.fromSquareLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromSquareLabel.Location = new System.Drawing.Point(619, 45);
            this.fromSquareLabel.Name = "fromSquareLabel";
            this.fromSquareLabel.Size = new System.Drawing.Size(54, 21);
            this.fromSquareLabel.TabIndex = 115;
            this.fromSquareLabel.Text = "الساحة:";
            // 
            // fromSectionLabel
            // 
            this.fromSectionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromSectionLabel.AutoSize = true;
            this.fromSectionLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromSectionLabel.Location = new System.Drawing.Point(1093, 92);
            this.fromSectionLabel.Name = "fromSectionLabel";
            this.fromSectionLabel.Size = new System.Drawing.Size(49, 21);
            this.fromSectionLabel.TabIndex = 125;
            this.fromSectionLabel.Text = "الدائرة:";
            // 
            // fromDepartmentLabel
            // 
            this.fromDepartmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromDepartmentLabel.AutoSize = true;
            this.fromDepartmentLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDepartmentLabel.Location = new System.Drawing.Point(1093, 45);
            this.fromDepartmentLabel.Name = "fromDepartmentLabel";
            this.fromDepartmentLabel.Size = new System.Drawing.Size(49, 21);
            this.fromDepartmentLabel.TabIndex = 105;
            this.fromDepartmentLabel.Text = "القسم:";
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
            this.tableAdapterManager.AssetTransactionTblTableAdapter = this.assetTransactionTblTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CurrencyTblTableAdapter = this.currencyTblTableAdapter;
            this.tableAdapterManager.DepartmentTblTableAdapter = null;
            this.tableAdapterManager.EstateAreaUnitTblTableAdapter = null;
            this.tableAdapterManager.MainCategoryTblTableAdapter = null;
            this.tableAdapterManager.MinorCategoryTblTableAdapter = null;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.SectionTblTableAdapter = null;
            this.tableAdapterManager.SquareTblTableAdapter = null;
            this.tableAdapterManager.StatusTblTableAdapter = null;
            this.tableAdapterManager.TransactionTypeTblTableAdapter = this.transactionTypeTblTableAdapter;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // assetTransactionTblTableAdapter
            // 
            this.assetTransactionTblTableAdapter.ClearBeforeFill = true;
            // 
            // currencyTblTableAdapter
            // 
            this.currencyTblTableAdapter.ClearBeforeFill = true;
            // 
            // transactionTypeTblTableAdapter
            // 
            this.transactionTypeTblTableAdapter.ClearBeforeFill = true;
            // 
            // viewAssetInformationBtn
            // 
            this.viewAssetInformationBtn.Image = global::AssetManagement.Properties.Resources._8341961;
            this.viewAssetInformationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewAssetInformationBtn.Location = new System.Drawing.Point(1058, 45);
            this.viewAssetInformationBtn.Name = "viewAssetInformationBtn";
            this.viewAssetInformationBtn.Size = new System.Drawing.Size(163, 74);
            this.viewAssetInformationBtn.TabIndex = 105;
            this.viewAssetInformationBtn.Text = "عرض معلومات الأصل";
            this.viewAssetInformationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewAssetInformationBtn.UseVisualStyleBackColor = true;
            this.viewAssetInformationBtn.Visible = false;
            this.viewAssetInformationBtn.Click += new System.EventHandler(this.viewAssetInformationBtn_Click);
            // 
            // searchResultsListBox
            // 
            this.searchResultsListBox.DisplayMember = "AssetCode";
            this.searchResultsListBox.FormattingEnabled = true;
            this.searchResultsListBox.ItemHeight = 24;
            this.searchResultsListBox.Location = new System.Drawing.Point(598, 25);
            this.searchResultsListBox.Name = "searchResultsListBox";
            this.searchResultsListBox.Size = new System.Drawing.Size(440, 124);
            this.searchResultsListBox.TabIndex = 104;
            this.searchResultsListBox.ValueMember = "ID";
            this.searchResultsListBox.Visible = false;
            this.searchResultsListBox.DoubleClick += new System.EventHandler(this.viewAssetInformationBtn_Click);
            // 
            // searchAssetBtn
            // 
            this.searchAssetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchAssetBtn.Image = global::AssetManagement.Properties.Resources._2719309;
            this.searchAssetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchAssetBtn.Location = new System.Drawing.Point(225, 78);
            this.searchAssetBtn.Name = "searchAssetBtn";
            this.searchAssetBtn.Size = new System.Drawing.Size(163, 74);
            this.searchAssetBtn.TabIndex = 103;
            this.searchAssetBtn.Text = "بحث";
            this.searchAssetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchAssetBtn.UseVisualStyleBackColor = true;
            this.searchAssetBtn.Click += new System.EventHandler(this.searchAssetBtn_Click);
            // 
            // assetCodeLabel
            // 
            this.assetCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assetCodeLabel.AutoSize = true;
            this.assetCodeLabel.Location = new System.Drawing.Point(57, 29);
            this.assetCodeLabel.Name = "assetCodeLabel";
            this.assetCodeLabel.Size = new System.Drawing.Size(86, 24);
            this.assetCodeLabel.TabIndex = 101;
            this.assetCodeLabel.Text = "كود الأصل:";
            // 
            // assetCodeTextBox
            // 
            this.assetCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assetCodeTextBox.Location = new System.Drawing.Point(185, 25);
            this.assetCodeTextBox.Name = "assetCodeTextBox";
            this.assetCodeTextBox.Size = new System.Drawing.Size(288, 32);
            this.assetCodeTextBox.TabIndex = 102;
            // 
            // TransacteAssetForm
            // 
            this.AcceptButton = this.searchAssetBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 801);
            this.Controls.Add(this.viewAssetInformationBtn);
            this.Controls.Add(this.searchResultsListBox);
            this.Controls.Add(this.searchAssetBtn);
            this.Controls.Add(this.assetCodeLabel);
            this.Controls.Add(this.assetCodeTextBox);
            this.Controls.Add(this.moveAssetGroupBox);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TransacteAssetForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تصريف أصل";
            this.Load += new System.EventHandler(this.TransacteAssetForm_Load);
            this.moveAssetGroupBox.ResumeLayout(false);
            this.moveAssetGroupBox.PerformLayout();
            this.assetTransactionPanel.ResumeLayout(false);
            this.assetTransactionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentPriceWithDestroyingNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyAmountCurrencyLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyAmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionTblBindingNavigator)).EndInit();
            this.assetTransactionTblBindingNavigator.ResumeLayout(false);
            this.assetTransactionTblBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransactionTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMoveVwGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMoveVwGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyAmountCurrencyRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox moveAssetGroupBox;
        private System.Windows.Forms.Label fromCustodianNameLabel;
        private DevExpress.XtraEditors.LookUpEdit transactionTypeLookUpEdit;
        private System.Windows.Forms.Label fromSquareLabel;
        private System.Windows.Forms.Label fromSectionLabel;
        private System.Windows.Forms.Label fromDepartmentLabel;
        private System.Windows.Forms.TextBox fromCustodianNameTextBox;
        private System.Windows.Forms.TextBox fromSquareTextBox;
        private System.Windows.Forms.TextBox fromSectionTextBox;
        private System.Windows.Forms.TextBox fromDepartmentTextBox;
        private System.Windows.Forms.Label assetTransactionDateLabel;
        private DevExpress.XtraEditors.DateEdit assetTransactionDateDateEdit;
        private System.Windows.Forms.Button assetTransactBtn;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private AssetMngDbDataSet assetMngDbDataSet;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl assetMoveVwGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView assetMoveVwGridView;
        private System.Windows.Forms.BindingSource assetTransactionTblBindingSource;
        private AssetMngDbDataSetTableAdapters.AssetTransactionTblTableAdapter assetTransactionTblTableAdapter;
        private System.Windows.Forms.BindingNavigator assetTransactionTblBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton assetTransactionTblBindingNavigatorSaveItem;
        private System.Windows.Forms.Label transactionTypeLabel;
        private System.Windows.Forms.Label assetInfoLabel;
        private System.Windows.Forms.Panel assetTransactionPanel;
        private System.Windows.Forms.Label assetNotesLabel;
        private System.Windows.Forms.TextBox assetNotesTextBox;
        private System.Windows.Forms.CheckBox getAssetOutOfWorkCheckBox;
        private System.Windows.Forms.BindingSource transactionTypeTblBindingSource;
        private AssetMngDbDataSetTableAdapters.TransactionTypeTblTableAdapter transactionTypeTblTableAdapter;
        private System.Windows.Forms.Label moneyAmountLabel;
        private System.Windows.Forms.NumericUpDown moneyAmountNumericUpDown;
        private System.Windows.Forms.Button manageCurrencyTblBtn;
        private System.Windows.Forms.Label moneyAmountCurrencyLabel;
        private DevExpress.XtraEditors.LookUpEdit moneyAmountCurrencyLookUpEdit;
        private System.Windows.Forms.Button manageTransactionTypeTblBtn;
        private System.Windows.Forms.BindingSource currencyTblBindingSource;
        private AssetMngDbDataSetTableAdapters.CurrencyTblTableAdapter currencyTblTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit transactionTypeRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource transactionTypeTblBindingSource1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit moneyAmountCurrencyRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource currencyTblBindingSource1;
        private System.Windows.Forms.CheckBox withDestroyingCheckBox;
        private System.Windows.Forms.Label currentPriceWithDestroyingLabel;
        private System.Windows.Forms.NumericUpDown currentPriceWithDestroyingNumericUpDown;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetID;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionType;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionMadeOn;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionMadeBy;
        private DevExpress.XtraGrid.Columns.GridColumn colMoneyAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colMoneyAmountCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colGetAssetOutOfWork;
        private DevExpress.XtraGrid.Columns.GridColumn colWithDestroying;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentPriceWithDestroying;
        private System.Windows.Forms.Button viewAssetInformationBtn;
        private System.Windows.Forms.ListBox searchResultsListBox;
        private System.Windows.Forms.Button searchAssetBtn;
        private System.Windows.Forms.Label assetCodeLabel;
        private System.Windows.Forms.TextBox assetCodeTextBox;
    }
}