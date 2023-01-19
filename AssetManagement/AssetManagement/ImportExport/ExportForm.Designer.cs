﻿
namespace AssetManagement.Finance
{
    partial class ExportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportForm));
            this.manageSubDepartmentTblBtn = new System.Windows.Forms.Button();
            this.subDepartmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.manageSectionTblBtn = new System.Windows.Forms.Button();
            this.exportBySectionLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.sectionTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exportBySubDepartmentRadioButton = new System.Windows.Forms.RadioButton();
            this.exportBySectionRadioButton = new System.Windows.Forms.RadioButton();
            this.manageDepartmentTblBtn = new System.Windows.Forms.Button();
            this.departmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exportByDepartmentRadioButton = new System.Windows.Forms.RadioButton();
            this.sectionTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SectionTblTableAdapter();
            this.departmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter();
            this.subDepartmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SubDepartmentTblTableAdapter();
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.exportData_Cancel = new System.Windows.Forms.Button();
            this.exportData_OK = new System.Windows.Forms.Button();
            this.encryptExportedFileCheckBox = new System.Windows.Forms.CheckBox();
            this.unknownExportRadioButton = new System.Windows.Forms.RadioButton();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.tablesExportedPanel = new System.Windows.Forms.Panel();
            this.exportAssetsAndFinancialItemsRadioButton = new System.Windows.Forms.RadioButton();
            this.exportFinancialItemsRadioButton = new System.Windows.Forms.RadioButton();
            this.exportAssetsRadioButton = new System.Windows.Forms.RadioButton();
            this.exportBySubDepartmentSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.subDepartmentVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exportByDepartmentSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.departmentVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colمعرفالقسم = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colاسمالقسم = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالدائرةالتييتبعلهاالقسم = new DevExpress.XtraGrid.Columns.GridColumn();
            this.departmentVwTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.DepartmentVwTableAdapter();
            this.subDepartmentVwTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SubDepartmentVwTableAdapter();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportBySectionLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).BeginInit();
            this.tablesExportedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportBySubDepartmentSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportByDepartmentSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // manageSubDepartmentTblBtn
            // 
            this.manageSubDepartmentTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageSubDepartmentTblBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageSubDepartmentTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageSubDepartmentTblBtn.Location = new System.Drawing.Point(477, 215);
            this.manageSubDepartmentTblBtn.Name = "manageSubDepartmentTblBtn";
            this.manageSubDepartmentTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageSubDepartmentTblBtn.TabIndex = 76;
            this.manageSubDepartmentTblBtn.UseVisualStyleBackColor = true;
            this.manageSubDepartmentTblBtn.Visible = false;
            this.manageSubDepartmentTblBtn.Click += new System.EventHandler(this.manageSubDepartmentTblBtn_Click);
            // 
            // subDepartmentTblBindingSource
            // 
            this.subDepartmentTblBindingSource.DataMember = "SubDepartmentTbl";
            this.subDepartmentTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manageSectionTblBtn
            // 
            this.manageSectionTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageSectionTblBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageSectionTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageSectionTblBtn.Location = new System.Drawing.Point(477, 95);
            this.manageSectionTblBtn.Name = "manageSectionTblBtn";
            this.manageSectionTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageSectionTblBtn.TabIndex = 56;
            this.manageSectionTblBtn.UseVisualStyleBackColor = true;
            this.manageSectionTblBtn.Visible = false;
            this.manageSectionTblBtn.Click += new System.EventHandler(this.manageSectionTblBtn_Click);
            // 
            // exportBySectionLookUpEdit
            // 
            this.exportBySectionLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportBySectionLookUpEdit.Location = new System.Drawing.Point(217, 108);
            this.exportBySectionLookUpEdit.Name = "exportBySectionLookUpEdit";
            this.exportBySectionLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBySectionLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.exportBySectionLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.exportBySectionLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الدائرة", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SectionName", "اسم الدائرة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.exportBySectionLookUpEdit.Properties.DataSource = this.sectionTblBindingSource;
            this.exportBySectionLookUpEdit.Properties.DisplayMember = "SectionName";
            this.exportBySectionLookUpEdit.Properties.PopupWidth = 500;
            this.exportBySectionLookUpEdit.Properties.ValueMember = "ID";
            this.exportBySectionLookUpEdit.Size = new System.Drawing.Size(243, 28);
            this.exportBySectionLookUpEdit.TabIndex = 55;
            this.exportBySectionLookUpEdit.Visible = false;
            this.exportBySectionLookUpEdit.EditValueChanged += new System.EventHandler(this.exportBySectionRadioButton_CheckedChanged);
            // 
            // sectionTblBindingSource
            // 
            this.sectionTblBindingSource.DataMember = "SectionTbl";
            this.sectionTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // exportBySubDepartmentRadioButton
            // 
            this.exportBySubDepartmentRadioButton.AutoSize = true;
            this.exportBySubDepartmentRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBySubDepartmentRadioButton.Location = new System.Drawing.Point(32, 230);
            this.exportBySubDepartmentRadioButton.Name = "exportBySubDepartmentRadioButton";
            this.exportBySubDepartmentRadioButton.Size = new System.Drawing.Size(132, 25);
            this.exportBySubDepartmentRadioButton.TabIndex = 70;
            this.exportBySubDepartmentRadioButton.Text = "ضمن وحدة معينة";
            this.exportBySubDepartmentRadioButton.UseVisualStyleBackColor = true;
            this.exportBySubDepartmentRadioButton.CheckedChanged += new System.EventHandler(this.exportBySubDepartmentRadioButton_CheckedChanged);
            // 
            // exportBySectionRadioButton
            // 
            this.exportBySectionRadioButton.AutoSize = true;
            this.exportBySectionRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBySectionRadioButton.Location = new System.Drawing.Point(32, 110);
            this.exportBySectionRadioButton.Name = "exportBySectionRadioButton";
            this.exportBySectionRadioButton.Size = new System.Drawing.Size(128, 25);
            this.exportBySectionRadioButton.TabIndex = 50;
            this.exportBySectionRadioButton.Text = "ضمن دائرة معينة";
            this.exportBySectionRadioButton.UseVisualStyleBackColor = true;
            this.exportBySectionRadioButton.CheckedChanged += new System.EventHandler(this.exportBySectionRadioButton_CheckedChanged);
            // 
            // manageDepartmentTblBtn
            // 
            this.manageDepartmentTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageDepartmentTblBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageDepartmentTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageDepartmentTblBtn.Location = new System.Drawing.Point(477, 155);
            this.manageDepartmentTblBtn.Name = "manageDepartmentTblBtn";
            this.manageDepartmentTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageDepartmentTblBtn.TabIndex = 66;
            this.manageDepartmentTblBtn.UseVisualStyleBackColor = true;
            this.manageDepartmentTblBtn.Visible = false;
            this.manageDepartmentTblBtn.Click += new System.EventHandler(this.manageDepartmentTblBtn_Click);
            // 
            // departmentTblBindingSource
            // 
            this.departmentTblBindingSource.DataMember = "DepartmentTbl";
            this.departmentTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // exportByDepartmentRadioButton
            // 
            this.exportByDepartmentRadioButton.AutoSize = true;
            this.exportByDepartmentRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportByDepartmentRadioButton.Location = new System.Drawing.Point(32, 170);
            this.exportByDepartmentRadioButton.Name = "exportByDepartmentRadioButton";
            this.exportByDepartmentRadioButton.Size = new System.Drawing.Size(124, 25);
            this.exportByDepartmentRadioButton.TabIndex = 60;
            this.exportByDepartmentRadioButton.Text = "ضمن قسم معين";
            this.exportByDepartmentRadioButton.UseVisualStyleBackColor = true;
            this.exportByDepartmentRadioButton.CheckedChanged += new System.EventHandler(this.exportByDepartmentRadioButton_CheckedChanged);
            // 
            // sectionTblTableAdapter
            // 
            this.sectionTblTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTblTableAdapter
            // 
            this.departmentTblTableAdapter.ClearBeforeFill = true;
            // 
            // subDepartmentTblTableAdapter
            // 
            this.subDepartmentTblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssetMovementTblTableAdapter = null;
            this.tableAdapterManager.AssetTblTableAdapter = null;
            this.tableAdapterManager.AssetTransactionTblTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CurrencyTblTableAdapter = null;
            this.tableAdapterManager.DepartmentTblTableAdapter = this.departmentTblTableAdapter;
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
            this.tableAdapterManager.SectionTblTableAdapter = this.sectionTblTableAdapter;
            this.tableAdapterManager.SquareTblTableAdapter = null;
            this.tableAdapterManager.StatusTblTableAdapter = null;
            this.tableAdapterManager.SubDepartmentTblTableAdapter = this.subDepartmentTblTableAdapter;
            this.tableAdapterManager.TransactionTypeTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserLoginTblTableAdapter = null;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // exportData_Cancel
            // 
            this.exportData_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exportData_Cancel.Image = global::AssetManagement.Properties.Resources._2137707;
            this.exportData_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportData_Cancel.Location = new System.Drawing.Point(796, 399);
            this.exportData_Cancel.Name = "exportData_Cancel";
            this.exportData_Cancel.Size = new System.Drawing.Size(156, 65);
            this.exportData_Cancel.TabIndex = 325;
            this.exportData_Cancel.Text = "إغلاق";
            this.exportData_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportData_Cancel.UseVisualStyleBackColor = true;
            this.exportData_Cancel.Click += new System.EventHandler(this.exportData_Cancel_Click);
            // 
            // exportData_OK
            // 
            this.exportData_OK.Image = global::AssetManagement.Properties.Resources._3643510;
            this.exportData_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportData_OK.Location = new System.Drawing.Point(796, 299);
            this.exportData_OK.Name = "exportData_OK";
            this.exportData_OK.Size = new System.Drawing.Size(156, 65);
            this.exportData_OK.TabIndex = 300;
            this.exportData_OK.Text = "تصدير";
            this.exportData_OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportData_OK.UseVisualStyleBackColor = true;
            this.exportData_OK.Click += new System.EventHandler(this.exportData_OK_Click);
            // 
            // encryptExportedFileCheckBox
            // 
            this.encryptExportedFileCheckBox.AutoSize = true;
            this.encryptExportedFileCheckBox.Location = new System.Drawing.Point(32, 345);
            this.encryptExportedFileCheckBox.Name = "encryptExportedFileCheckBox";
            this.encryptExportedFileCheckBox.Size = new System.Drawing.Size(167, 28);
            this.encryptExportedFileCheckBox.TabIndex = 85;
            this.encryptExportedFileCheckBox.Text = "تشفير ملف التصدير";
            this.encryptExportedFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // unknownExportRadioButton
            // 
            this.unknownExportRadioButton.AutoSize = true;
            this.unknownExportRadioButton.Checked = true;
            this.unknownExportRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unknownExportRadioButton.Location = new System.Drawing.Point(32, 290);
            this.unknownExportRadioButton.Name = "unknownExportRadioButton";
            this.unknownExportRadioButton.Size = new System.Drawing.Size(86, 25);
            this.unknownExportRadioButton.TabIndex = 80;
            this.unknownExportRadioButton.TabStop = true;
            this.unknownExportRadioButton.Text = "غير محدد";
            this.unknownExportRadioButton.UseVisualStyleBackColor = true;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(28, 405);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(78, 24);
            this.notesLabel.TabIndex = 90;
            this.notesLabel.Text = "ملاحظات:";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(173, 401);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(481, 81);
            this.notesTextBox.TabIndex = 95;
            // 
            // tablesExportedPanel
            // 
            this.tablesExportedPanel.Controls.Add(this.exportAssetsAndFinancialItemsRadioButton);
            this.tablesExportedPanel.Controls.Add(this.exportFinancialItemsRadioButton);
            this.tablesExportedPanel.Controls.Add(this.exportAssetsRadioButton);
            this.tablesExportedPanel.Location = new System.Drawing.Point(32, 22);
            this.tablesExportedPanel.Name = "tablesExportedPanel";
            this.tablesExportedPanel.Size = new System.Drawing.Size(790, 52);
            this.tablesExportedPanel.TabIndex = 5;
            // 
            // exportAssetsAndFinancialItemsRadioButton
            // 
            this.exportAssetsAndFinancialItemsRadioButton.AutoSize = true;
            this.exportAssetsAndFinancialItemsRadioButton.Checked = true;
            this.exportAssetsAndFinancialItemsRadioButton.Location = new System.Drawing.Point(358, 11);
            this.exportAssetsAndFinancialItemsRadioButton.Name = "exportAssetsAndFinancialItemsRadioButton";
            this.exportAssetsAndFinancialItemsRadioButton.Size = new System.Drawing.Size(173, 28);
            this.exportAssetsAndFinancialItemsRadioButton.TabIndex = 20;
            this.exportAssetsAndFinancialItemsRadioButton.TabStop = true;
            this.exportAssetsAndFinancialItemsRadioButton.Text = "أصول وسجلات مالية";
            this.exportAssetsAndFinancialItemsRadioButton.UseVisualStyleBackColor = true;
            this.exportAssetsAndFinancialItemsRadioButton.CheckedChanged += new System.EventHandler(this.exportAssetsRadioButton_CheckedChanged);
            // 
            // exportFinancialItemsRadioButton
            // 
            this.exportFinancialItemsRadioButton.AutoSize = true;
            this.exportFinancialItemsRadioButton.Location = new System.Drawing.Point(551, 11);
            this.exportFinancialItemsRadioButton.Name = "exportFinancialItemsRadioButton";
            this.exportFinancialItemsRadioButton.Size = new System.Drawing.Size(122, 28);
            this.exportFinancialItemsRadioButton.TabIndex = 15;
            this.exportFinancialItemsRadioButton.Text = "سجلات مالية";
            this.exportFinancialItemsRadioButton.UseVisualStyleBackColor = true;
            this.exportFinancialItemsRadioButton.CheckedChanged += new System.EventHandler(this.exportAssetsRadioButton_CheckedChanged);
            // 
            // exportAssetsRadioButton
            // 
            this.exportAssetsRadioButton.AutoSize = true;
            this.exportAssetsRadioButton.Location = new System.Drawing.Point(693, 11);
            this.exportAssetsRadioButton.Name = "exportAssetsRadioButton";
            this.exportAssetsRadioButton.Size = new System.Drawing.Size(69, 28);
            this.exportAssetsRadioButton.TabIndex = 10;
            this.exportAssetsRadioButton.Text = "أصول";
            this.exportAssetsRadioButton.UseVisualStyleBackColor = true;
            this.exportAssetsRadioButton.CheckedChanged += new System.EventHandler(this.exportAssetsRadioButton_CheckedChanged);
            // 
            // exportBySubDepartmentSearchLookUpEdit
            // 
            this.exportBySubDepartmentSearchLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportBySubDepartmentSearchLookUpEdit.Location = new System.Drawing.Point(217, 228);
            this.exportBySubDepartmentSearchLookUpEdit.Name = "exportBySubDepartmentSearchLookUpEdit";
            this.exportBySubDepartmentSearchLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBySubDepartmentSearchLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.exportBySubDepartmentSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.exportBySubDepartmentSearchLookUpEdit.Properties.DataSource = this.subDepartmentVwBindingSource;
            this.exportBySubDepartmentSearchLookUpEdit.Properties.DisplayMember = "اسم الوحدة";
            this.exportBySubDepartmentSearchLookUpEdit.Properties.ValueMember = "معرف الوحدة";
            this.exportBySubDepartmentSearchLookUpEdit.Size = new System.Drawing.Size(243, 28);
            this.exportBySubDepartmentSearchLookUpEdit.TabIndex = 75;
            this.exportBySubDepartmentSearchLookUpEdit.Visible = false;
            // 
            // subDepartmentVwBindingSource
            // 
            this.subDepartmentVwBindingSource.DataMember = "SubDepartmentVw";
            this.subDepartmentVwBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // exportByDepartmentSearchLookUpEdit
            // 
            this.exportByDepartmentSearchLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportByDepartmentSearchLookUpEdit.Location = new System.Drawing.Point(217, 168);
            this.exportByDepartmentSearchLookUpEdit.Name = "exportByDepartmentSearchLookUpEdit";
            this.exportByDepartmentSearchLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportByDepartmentSearchLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.exportByDepartmentSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.exportByDepartmentSearchLookUpEdit.Properties.DataSource = this.departmentVwBindingSource;
            this.exportByDepartmentSearchLookUpEdit.Properties.DisplayMember = "اسم القسم";
            this.exportByDepartmentSearchLookUpEdit.Properties.PopupView = this.searchLookUpEdit1View;
            this.exportByDepartmentSearchLookUpEdit.Properties.ValueMember = "معرف القسم";
            this.exportByDepartmentSearchLookUpEdit.Size = new System.Drawing.Size(243, 28);
            this.exportByDepartmentSearchLookUpEdit.TabIndex = 65;
            this.exportByDepartmentSearchLookUpEdit.Visible = false;
            this.exportByDepartmentSearchLookUpEdit.EditValueChanged += new System.EventHandler(this.exportByDepartmentRadioButton_CheckedChanged);
            // 
            // departmentVwBindingSource
            // 
            this.departmentVwBindingSource.DataMember = "DepartmentVw";
            this.departmentVwBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colمعرفالقسم,
            this.colاسمالقسم,
            this.colالدائرةالتييتبعلهاالقسم});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colمعرفالقسم
            // 
            this.colمعرفالقسم.FieldName = "معرف القسم";
            this.colمعرفالقسم.MinWidth = 100;
            this.colمعرفالقسم.Name = "colمعرفالقسم";
            this.colمعرفالقسم.Width = 100;
            // 
            // colاسمالقسم
            // 
            this.colاسمالقسم.FieldName = "اسم القسم";
            this.colاسمالقسم.MinWidth = 150;
            this.colاسمالقسم.Name = "colاسمالقسم";
            this.colاسمالقسم.Visible = true;
            this.colاسمالقسم.VisibleIndex = 0;
            this.colاسمالقسم.Width = 150;
            // 
            // colالدائرةالتييتبعلهاالقسم
            // 
            this.colالدائرةالتييتبعلهاالقسم.FieldName = "الدائرة التي يتبع لها القسم";
            this.colالدائرةالتييتبعلهاالقسم.MinWidth = 150;
            this.colالدائرةالتييتبعلهاالقسم.Name = "colالدائرةالتييتبعلهاالقسم";
            this.colالدائرةالتييتبعلهاالقسم.Visible = true;
            this.colالدائرةالتييتبعلهاالقسم.VisibleIndex = 1;
            this.colالدائرةالتييتبعلهاالقسم.Width = 150;
            // 
            // departmentVwTableAdapter
            // 
            this.departmentVwTableAdapter.ClearBeforeFill = true;
            // 
            // subDepartmentVwTableAdapter
            // 
            this.subDepartmentVwTableAdapter.ClearBeforeFill = true;
            // 
            // mainAlertControl
            // 
            this.mainAlertControl.AppearanceCaption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainAlertControl.AppearanceCaption.Options.UseFont = true;
            this.mainAlertControl.AppearanceCaption.Options.UseTextOptions = true;
            this.mainAlertControl.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.mainAlertControl.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.mainAlertControl.AppearanceText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainAlertControl.AppearanceText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mainAlertControl.AppearanceText.Options.UseFont = true;
            this.mainAlertControl.AppearanceText.Options.UseForeColor = true;
            this.mainAlertControl.AppearanceText.Options.UseTextOptions = true;
            this.mainAlertControl.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.mainAlertControl.AppearanceText.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.mainAlertControl.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight;
            // 
            // ExportForm
            // 
            this.AcceptButton = this.exportData_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exportData_Cancel;
            this.ClientSize = new System.Drawing.Size(1007, 517);
            this.Controls.Add(this.exportBySubDepartmentSearchLookUpEdit);
            this.Controls.Add(this.exportByDepartmentSearchLookUpEdit);
            this.Controls.Add(this.tablesExportedPanel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.unknownExportRadioButton);
            this.Controls.Add(this.encryptExportedFileCheckBox);
            this.Controls.Add(this.exportData_Cancel);
            this.Controls.Add(this.exportData_OK);
            this.Controls.Add(this.manageSubDepartmentTblBtn);
            this.Controls.Add(this.manageSectionTblBtn);
            this.Controls.Add(this.exportBySectionLookUpEdit);
            this.Controls.Add(this.exportBySubDepartmentRadioButton);
            this.Controls.Add(this.exportBySectionRadioButton);
            this.Controls.Add(this.manageDepartmentTblBtn);
            this.Controls.Add(this.exportByDepartmentRadioButton);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ExportForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تصدير بيانات";
            this.Load += new System.EventHandler(this.ExportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportBySectionLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).EndInit();
            this.tablesExportedPanel.ResumeLayout(false);
            this.tablesExportedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportBySubDepartmentSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportByDepartmentSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button manageSubDepartmentTblBtn;
        private System.Windows.Forms.Button manageSectionTblBtn;
        private DevExpress.XtraEditors.LookUpEdit exportBySectionLookUpEdit;
        private System.Windows.Forms.RadioButton exportBySubDepartmentRadioButton;
        private System.Windows.Forms.RadioButton exportBySectionRadioButton;
        private System.Windows.Forms.Button manageDepartmentTblBtn;
        private System.Windows.Forms.RadioButton exportByDepartmentRadioButton;
        private AssetMngDbDataSet assetMngDbDataSet;
        private System.Windows.Forms.BindingSource sectionTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SectionTblTableAdapter sectionTblTableAdapter;
        private System.Windows.Forms.BindingSource departmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter departmentTblTableAdapter;
        private System.Windows.Forms.BindingSource subDepartmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SubDepartmentTblTableAdapter subDepartmentTblTableAdapter;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button exportData_Cancel;
        private System.Windows.Forms.Button exportData_OK;
        private System.Windows.Forms.CheckBox encryptExportedFileCheckBox;
        private System.Windows.Forms.RadioButton unknownExportRadioButton;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Panel tablesExportedPanel;
        private System.Windows.Forms.RadioButton exportAssetsAndFinancialItemsRadioButton;
        private System.Windows.Forms.RadioButton exportFinancialItemsRadioButton;
        private System.Windows.Forms.RadioButton exportAssetsRadioButton;
        private DevExpress.XtraEditors.SearchLookUpEdit exportBySubDepartmentSearchLookUpEdit;
        private DevExpress.XtraEditors.SearchLookUpEdit exportByDepartmentSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colمعرفالقسم;
        private DevExpress.XtraGrid.Columns.GridColumn colاسمالقسم;
        private DevExpress.XtraGrid.Columns.GridColumn colالدائرةالتييتبعلهاالقسم;
        private System.Windows.Forms.BindingSource departmentVwBindingSource;
        private AssetMngDbDataSetTableAdapters.DepartmentVwTableAdapter departmentVwTableAdapter;
        private System.Windows.Forms.BindingSource subDepartmentVwBindingSource;
        private AssetMngDbDataSetTableAdapters.SubDepartmentVwTableAdapter subDepartmentVwTableAdapter;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
    }
}