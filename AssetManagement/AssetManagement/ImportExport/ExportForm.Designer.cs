
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
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.manageSubDepartmentTblBtn = new System.Windows.Forms.Button();
            this.exportBySubDepartmentLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.subDepartmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.manageSectionTblBtn = new System.Windows.Forms.Button();
            this.exportBySectionLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.sectionTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exportBySubDepartmentRadioButton = new System.Windows.Forms.RadioButton();
            this.exportBySectionRadioButton = new System.Windows.Forms.RadioButton();
            this.manageDepartmentTblBtn = new System.Windows.Forms.Button();
            this.exportByDepartmentLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.departmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exportByDepartmentRadioButton = new System.Windows.Forms.RadioButton();
            this.sectionTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SectionTblTableAdapter();
            this.departmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter();
            this.subDepartmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SubDepartmentTblTableAdapter();
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.exportData_Cancel = new System.Windows.Forms.Button();
            this.exportData_OK = new System.Windows.Forms.Button();
            this.encryptExportedFileCheckBox = new System.Windows.Forms.CheckBox();
            this.unknownImportRadioButton = new System.Windows.Forms.RadioButton();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.exportBySubDepartmentLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportBySectionLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportByDepartmentLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).BeginInit();
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
            // manageSubDepartmentTblBtn
            // 
            this.manageSubDepartmentTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageSubDepartmentTblBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageSubDepartmentTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageSubDepartmentTblBtn.Location = new System.Drawing.Point(433, 145);
            this.manageSubDepartmentTblBtn.Name = "manageSubDepartmentTblBtn";
            this.manageSubDepartmentTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageSubDepartmentTblBtn.TabIndex = 31;
            this.manageSubDepartmentTblBtn.UseVisualStyleBackColor = true;
            this.manageSubDepartmentTblBtn.Visible = false;
            this.manageSubDepartmentTblBtn.Click += new System.EventHandler(this.manageSubDepartmentTblBtn_Click);
            // 
            // exportBySubDepartmentLookUpEdit
            // 
            this.exportBySubDepartmentLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportBySubDepartmentLookUpEdit.Location = new System.Drawing.Point(173, 158);
            this.exportBySubDepartmentLookUpEdit.Name = "exportBySubDepartmentLookUpEdit";
            this.exportBySubDepartmentLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBySubDepartmentLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.exportBySubDepartmentLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.exportBySubDepartmentLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الوحدة", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubDepartmentName", "اسم الوحدة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainDepartment", "معرف القسم", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.exportBySubDepartmentLookUpEdit.Properties.DataSource = this.subDepartmentTblBindingSource;
            this.exportBySubDepartmentLookUpEdit.Properties.DisplayMember = "SubDepartmentName";
            this.exportBySubDepartmentLookUpEdit.Properties.PopupWidth = 500;
            this.exportBySubDepartmentLookUpEdit.Properties.ValueMember = "ID";
            this.exportBySubDepartmentLookUpEdit.Size = new System.Drawing.Size(243, 28);
            this.exportBySubDepartmentLookUpEdit.TabIndex = 30;
            this.exportBySubDepartmentLookUpEdit.Visible = false;
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
            this.manageSectionTblBtn.Location = new System.Drawing.Point(433, 25);
            this.manageSectionTblBtn.Name = "manageSectionTblBtn";
            this.manageSectionTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageSectionTblBtn.TabIndex = 11;
            this.manageSectionTblBtn.UseVisualStyleBackColor = true;
            this.manageSectionTblBtn.Visible = false;
            this.manageSectionTblBtn.Click += new System.EventHandler(this.manageSectionTblBtn_Click);
            // 
            // exportBySectionLookUpEdit
            // 
            this.exportBySectionLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportBySectionLookUpEdit.Location = new System.Drawing.Point(173, 38);
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
            this.exportBySectionLookUpEdit.TabIndex = 10;
            this.exportBySectionLookUpEdit.Visible = false;
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
            this.exportBySubDepartmentRadioButton.Location = new System.Drawing.Point(32, 160);
            this.exportBySubDepartmentRadioButton.Name = "exportBySubDepartmentRadioButton";
            this.exportBySubDepartmentRadioButton.Size = new System.Drawing.Size(132, 25);
            this.exportBySubDepartmentRadioButton.TabIndex = 25;
            this.exportBySubDepartmentRadioButton.Text = "ضمن وحدة معينة";
            this.exportBySubDepartmentRadioButton.UseVisualStyleBackColor = true;
            this.exportBySubDepartmentRadioButton.CheckedChanged += new System.EventHandler(this.importBySectionRadioButton_CheckedChanged);
            // 
            // exportBySectionRadioButton
            // 
            this.exportBySectionRadioButton.AutoSize = true;
            this.exportBySectionRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBySectionRadioButton.Location = new System.Drawing.Point(32, 40);
            this.exportBySectionRadioButton.Name = "exportBySectionRadioButton";
            this.exportBySectionRadioButton.Size = new System.Drawing.Size(128, 25);
            this.exportBySectionRadioButton.TabIndex = 5;
            this.exportBySectionRadioButton.Text = "ضمن دائرة معينة";
            this.exportBySectionRadioButton.UseVisualStyleBackColor = true;
            this.exportBySectionRadioButton.CheckedChanged += new System.EventHandler(this.importBySectionRadioButton_CheckedChanged);
            // 
            // manageDepartmentTblBtn
            // 
            this.manageDepartmentTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageDepartmentTblBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageDepartmentTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageDepartmentTblBtn.Location = new System.Drawing.Point(433, 85);
            this.manageDepartmentTblBtn.Name = "manageDepartmentTblBtn";
            this.manageDepartmentTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageDepartmentTblBtn.TabIndex = 21;
            this.manageDepartmentTblBtn.UseVisualStyleBackColor = true;
            this.manageDepartmentTblBtn.Visible = false;
            this.manageDepartmentTblBtn.Click += new System.EventHandler(this.manageDepartmentTblBtn_Click);
            // 
            // exportByDepartmentLookUpEdit
            // 
            this.exportByDepartmentLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportByDepartmentLookUpEdit.Location = new System.Drawing.Point(173, 98);
            this.exportByDepartmentLookUpEdit.Name = "exportByDepartmentLookUpEdit";
            this.exportByDepartmentLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportByDepartmentLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.exportByDepartmentLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.exportByDepartmentLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف القسم", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "اسم القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentHQ", "مقر القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.exportByDepartmentLookUpEdit.Properties.DataSource = this.departmentTblBindingSource;
            this.exportByDepartmentLookUpEdit.Properties.DisplayMember = "DepartmentName";
            this.exportByDepartmentLookUpEdit.Properties.PopupWidth = 500;
            this.exportByDepartmentLookUpEdit.Properties.ValueMember = "ID";
            this.exportByDepartmentLookUpEdit.Size = new System.Drawing.Size(243, 28);
            this.exportByDepartmentLookUpEdit.TabIndex = 20;
            this.exportByDepartmentLookUpEdit.Visible = false;
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
            this.exportByDepartmentRadioButton.Location = new System.Drawing.Point(32, 100);
            this.exportByDepartmentRadioButton.Name = "exportByDepartmentRadioButton";
            this.exportByDepartmentRadioButton.Size = new System.Drawing.Size(124, 25);
            this.exportByDepartmentRadioButton.TabIndex = 15;
            this.exportByDepartmentRadioButton.Text = "ضمن قسم معين";
            this.exportByDepartmentRadioButton.UseVisualStyleBackColor = true;
            this.exportByDepartmentRadioButton.CheckedChanged += new System.EventHandler(this.importBySectionRadioButton_CheckedChanged);
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
            // exportData_Cancel
            // 
            this.exportData_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exportData_Cancel.Image = global::AssetManagement.Properties.Resources._2137707;
            this.exportData_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportData_Cancel.Location = new System.Drawing.Point(773, 352);
            this.exportData_Cancel.Name = "exportData_Cancel";
            this.exportData_Cancel.Size = new System.Drawing.Size(156, 65);
            this.exportData_Cancel.TabIndex = 325;
            this.exportData_Cancel.Text = "إغلاق";
            this.exportData_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportData_Cancel.UseVisualStyleBackColor = true;
            this.exportData_Cancel.Click += new System.EventHandler(this.importData_Cancel_Click);
            // 
            // exportData_OK
            // 
            this.exportData_OK.Image = global::AssetManagement.Properties.Resources._3643510;
            this.exportData_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportData_OK.Location = new System.Drawing.Point(773, 252);
            this.exportData_OK.Name = "exportData_OK";
            this.exportData_OK.Size = new System.Drawing.Size(156, 65);
            this.exportData_OK.TabIndex = 300;
            this.exportData_OK.Text = "تصدير";
            this.exportData_OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportData_OK.UseVisualStyleBackColor = true;
            this.exportData_OK.Click += new System.EventHandler(this.importData_OK_Click);
            // 
            // encryptExportedFileCheckBox
            // 
            this.encryptExportedFileCheckBox.AutoSize = true;
            this.encryptExportedFileCheckBox.Location = new System.Drawing.Point(32, 280);
            this.encryptExportedFileCheckBox.Name = "encryptExportedFileCheckBox";
            this.encryptExportedFileCheckBox.Size = new System.Drawing.Size(167, 28);
            this.encryptExportedFileCheckBox.TabIndex = 40;
            this.encryptExportedFileCheckBox.Text = "تشفير ملف التصدير";
            this.encryptExportedFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // unknownImportRadioButton
            // 
            this.unknownImportRadioButton.AutoSize = true;
            this.unknownImportRadioButton.Checked = true;
            this.unknownImportRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unknownImportRadioButton.Location = new System.Drawing.Point(32, 220);
            this.unknownImportRadioButton.Name = "unknownImportRadioButton";
            this.unknownImportRadioButton.Size = new System.Drawing.Size(86, 25);
            this.unknownImportRadioButton.TabIndex = 35;
            this.unknownImportRadioButton.TabStop = true;
            this.unknownImportRadioButton.Text = "غير محدد";
            this.unknownImportRadioButton.UseVisualStyleBackColor = true;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(28, 340);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(78, 24);
            this.notesLabel.TabIndex = 45;
            this.notesLabel.Text = "ملاحظات:";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(173, 336);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(315, 81);
            this.notesTextBox.TabIndex = 50;
            // 
            // ExportForm
            // 
            this.AcceptButton = this.exportData_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exportData_Cancel;
            this.ClientSize = new System.Drawing.Size(963, 440);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.unknownImportRadioButton);
            this.Controls.Add(this.encryptExportedFileCheckBox);
            this.Controls.Add(this.exportData_Cancel);
            this.Controls.Add(this.exportData_OK);
            this.Controls.Add(this.manageSubDepartmentTblBtn);
            this.Controls.Add(this.exportBySubDepartmentLookUpEdit);
            this.Controls.Add(this.manageSectionTblBtn);
            this.Controls.Add(this.exportBySectionLookUpEdit);
            this.Controls.Add(this.exportBySubDepartmentRadioButton);
            this.Controls.Add(this.exportBySectionRadioButton);
            this.Controls.Add(this.manageDepartmentTblBtn);
            this.Controls.Add(this.exportByDepartmentLookUpEdit);
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
            ((System.ComponentModel.ISupportInitialize)(this.exportBySubDepartmentLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportBySectionLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportByDepartmentLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private System.Windows.Forms.Button manageSubDepartmentTblBtn;
        private DevExpress.XtraEditors.LookUpEdit exportBySubDepartmentLookUpEdit;
        private System.Windows.Forms.Button manageSectionTblBtn;
        private DevExpress.XtraEditors.LookUpEdit exportBySectionLookUpEdit;
        private System.Windows.Forms.RadioButton exportBySubDepartmentRadioButton;
        private System.Windows.Forms.RadioButton exportBySectionRadioButton;
        private System.Windows.Forms.Button manageDepartmentTblBtn;
        private DevExpress.XtraEditors.LookUpEdit exportByDepartmentLookUpEdit;
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
        private System.Windows.Forms.RadioButton unknownImportRadioButton;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox notesTextBox;
    }
}