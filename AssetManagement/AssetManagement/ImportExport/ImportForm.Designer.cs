
namespace AssetManagement.Finance
{
    partial class ImportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportForm));
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.subDepartmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.sectionTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.importBySubDepartmentRadioButton = new System.Windows.Forms.RadioButton();
            this.importBySectionRadioButton = new System.Windows.Forms.RadioButton();
            this.departmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.importByDepartmentRadioButton = new System.Windows.Forms.RadioButton();
            this.sectionTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SectionTblTableAdapter();
            this.departmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter();
            this.subDepartmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SubDepartmentTblTableAdapter();
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.decryptImportedFileCheckBox = new System.Windows.Forms.CheckBox();
            this.unknownImportRadioButton = new System.Windows.Forms.RadioButton();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.importData_OK = new System.Windows.Forms.Button();
            this.importData_Cancel = new System.Windows.Forms.Button();
            this.manageSubDepartmentTblBtn = new System.Windows.Forms.Button();
            this.importBySubDepartmentLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.manageSectionTblBtn = new System.Windows.Forms.Button();
            this.importBySectionLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.manageDepartmentTblBtn = new System.Windows.Forms.Button();
            this.importByDepartmentLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importBySubDepartmentLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importBySectionLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importByDepartmentLookUpEdit.Properties)).BeginInit();
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
            // sectionTblBindingSource
            // 
            this.sectionTblBindingSource.DataMember = "SectionTbl";
            this.sectionTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // importBySubDepartmentRadioButton
            // 
            this.importBySubDepartmentRadioButton.AutoSize = true;
            this.importBySubDepartmentRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importBySubDepartmentRadioButton.Location = new System.Drawing.Point(32, 160);
            this.importBySubDepartmentRadioButton.Name = "importBySubDepartmentRadioButton";
            this.importBySubDepartmentRadioButton.Size = new System.Drawing.Size(132, 25);
            this.importBySubDepartmentRadioButton.TabIndex = 25;
            this.importBySubDepartmentRadioButton.Text = "ضمن وحدة معينة";
            this.importBySubDepartmentRadioButton.UseVisualStyleBackColor = true;
            this.importBySubDepartmentRadioButton.CheckedChanged += new System.EventHandler(this.importBySectionRadioButton_CheckedChanged);
            // 
            // importBySectionRadioButton
            // 
            this.importBySectionRadioButton.AutoSize = true;
            this.importBySectionRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importBySectionRadioButton.Location = new System.Drawing.Point(32, 40);
            this.importBySectionRadioButton.Name = "importBySectionRadioButton";
            this.importBySectionRadioButton.Size = new System.Drawing.Size(128, 25);
            this.importBySectionRadioButton.TabIndex = 5;
            this.importBySectionRadioButton.Text = "ضمن دائرة معينة";
            this.importBySectionRadioButton.UseVisualStyleBackColor = true;
            this.importBySectionRadioButton.CheckedChanged += new System.EventHandler(this.importBySectionRadioButton_CheckedChanged);
            // 
            // departmentTblBindingSource
            // 
            this.departmentTblBindingSource.DataMember = "DepartmentTbl";
            this.departmentTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // importByDepartmentRadioButton
            // 
            this.importByDepartmentRadioButton.AutoSize = true;
            this.importByDepartmentRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importByDepartmentRadioButton.Location = new System.Drawing.Point(32, 100);
            this.importByDepartmentRadioButton.Name = "importByDepartmentRadioButton";
            this.importByDepartmentRadioButton.Size = new System.Drawing.Size(124, 25);
            this.importByDepartmentRadioButton.TabIndex = 15;
            this.importByDepartmentRadioButton.Text = "ضمن قسم معين";
            this.importByDepartmentRadioButton.UseVisualStyleBackColor = true;
            this.importByDepartmentRadioButton.CheckedChanged += new System.EventHandler(this.importBySectionRadioButton_CheckedChanged);
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
            // decryptImportedFileCheckBox
            // 
            this.decryptImportedFileCheckBox.AutoSize = true;
            this.decryptImportedFileCheckBox.Location = new System.Drawing.Point(32, 280);
            this.decryptImportedFileCheckBox.Name = "decryptImportedFileCheckBox";
            this.decryptImportedFileCheckBox.Size = new System.Drawing.Size(157, 28);
            this.decryptImportedFileCheckBox.TabIndex = 40;
            this.decryptImportedFileCheckBox.Text = "استيراد ملف مشفر";
            this.decryptImportedFileCheckBox.UseVisualStyleBackColor = true;
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
            // importData_OK
            // 
            this.importData_OK.Image = global::AssetManagement.Properties.Resources._36435172;
            this.importData_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importData_OK.Location = new System.Drawing.Point(773, 252);
            this.importData_OK.Name = "importData_OK";
            this.importData_OK.Size = new System.Drawing.Size(156, 65);
            this.importData_OK.TabIndex = 300;
            this.importData_OK.Text = "استيراد";
            this.importData_OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importData_OK.UseVisualStyleBackColor = true;
            this.importData_OK.Click += new System.EventHandler(this.importData_OK_Click);
            // 
            // importData_Cancel
            // 
            this.importData_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.importData_Cancel.Image = global::AssetManagement.Properties.Resources._2137707;
            this.importData_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importData_Cancel.Location = new System.Drawing.Point(773, 352);
            this.importData_Cancel.Name = "importData_Cancel";
            this.importData_Cancel.Size = new System.Drawing.Size(156, 65);
            this.importData_Cancel.TabIndex = 325;
            this.importData_Cancel.Text = "إغلاق";
            this.importData_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importData_Cancel.UseVisualStyleBackColor = true;
            this.importData_Cancel.Click += new System.EventHandler(this.importData_Cancel_Click);
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
            // importBySubDepartmentLookUpEdit
            // 
            this.importBySubDepartmentLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.importBySubDepartmentLookUpEdit.Location = new System.Drawing.Point(173, 158);
            this.importBySubDepartmentLookUpEdit.Name = "importBySubDepartmentLookUpEdit";
            this.importBySubDepartmentLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importBySubDepartmentLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.importBySubDepartmentLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.importBySubDepartmentLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الوحدة", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubDepartmentName", "اسم الوحدة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainDepartment", "معرف القسم", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.importBySubDepartmentLookUpEdit.Properties.DataSource = this.subDepartmentTblBindingSource;
            this.importBySubDepartmentLookUpEdit.Properties.DisplayMember = "SubDepartmentName";
            this.importBySubDepartmentLookUpEdit.Properties.PopupWidth = 500;
            this.importBySubDepartmentLookUpEdit.Properties.ValueMember = "ID";
            this.importBySubDepartmentLookUpEdit.Size = new System.Drawing.Size(243, 28);
            this.importBySubDepartmentLookUpEdit.TabIndex = 30;
            this.importBySubDepartmentLookUpEdit.Visible = false;
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
            // importBySectionLookUpEdit
            // 
            this.importBySectionLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.importBySectionLookUpEdit.Location = new System.Drawing.Point(173, 38);
            this.importBySectionLookUpEdit.Name = "importBySectionLookUpEdit";
            this.importBySectionLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importBySectionLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.importBySectionLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.importBySectionLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الدائرة", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SectionName", "اسم الدائرة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.importBySectionLookUpEdit.Properties.DataSource = this.sectionTblBindingSource;
            this.importBySectionLookUpEdit.Properties.DisplayMember = "SectionName";
            this.importBySectionLookUpEdit.Properties.PopupWidth = 500;
            this.importBySectionLookUpEdit.Properties.ValueMember = "ID";
            this.importBySectionLookUpEdit.Size = new System.Drawing.Size(243, 28);
            this.importBySectionLookUpEdit.TabIndex = 10;
            this.importBySectionLookUpEdit.Visible = false;
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
            // importByDepartmentLookUpEdit
            // 
            this.importByDepartmentLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.importByDepartmentLookUpEdit.Location = new System.Drawing.Point(173, 98);
            this.importByDepartmentLookUpEdit.Name = "importByDepartmentLookUpEdit";
            this.importByDepartmentLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importByDepartmentLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.importByDepartmentLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.importByDepartmentLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف القسم", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "اسم القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentHQ", "مقر القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.importByDepartmentLookUpEdit.Properties.DataSource = this.departmentTblBindingSource;
            this.importByDepartmentLookUpEdit.Properties.DisplayMember = "DepartmentName";
            this.importByDepartmentLookUpEdit.Properties.PopupWidth = 500;
            this.importByDepartmentLookUpEdit.Properties.ValueMember = "ID";
            this.importByDepartmentLookUpEdit.Size = new System.Drawing.Size(243, 28);
            this.importByDepartmentLookUpEdit.TabIndex = 20;
            this.importByDepartmentLookUpEdit.Visible = false;
            // 
            // ImportForm
            // 
            this.AcceptButton = this.importData_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.importData_Cancel;
            this.ClientSize = new System.Drawing.Size(963, 440);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.unknownImportRadioButton);
            this.Controls.Add(this.decryptImportedFileCheckBox);
            this.Controls.Add(this.importData_Cancel);
            this.Controls.Add(this.importData_OK);
            this.Controls.Add(this.manageSubDepartmentTblBtn);
            this.Controls.Add(this.importBySubDepartmentLookUpEdit);
            this.Controls.Add(this.manageSectionTblBtn);
            this.Controls.Add(this.importBySectionLookUpEdit);
            this.Controls.Add(this.importBySubDepartmentRadioButton);
            this.Controls.Add(this.importBySectionRadioButton);
            this.Controls.Add(this.manageDepartmentTblBtn);
            this.Controls.Add(this.importByDepartmentLookUpEdit);
            this.Controls.Add(this.importByDepartmentRadioButton);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ImportForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "استيراد بيانات";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importBySubDepartmentLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importBySectionLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importByDepartmentLookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private System.Windows.Forms.Button manageSubDepartmentTblBtn;
        private DevExpress.XtraEditors.LookUpEdit importBySubDepartmentLookUpEdit;
        private System.Windows.Forms.Button manageSectionTblBtn;
        private DevExpress.XtraEditors.LookUpEdit importBySectionLookUpEdit;
        private System.Windows.Forms.RadioButton importBySubDepartmentRadioButton;
        private System.Windows.Forms.RadioButton importBySectionRadioButton;
        private System.Windows.Forms.Button manageDepartmentTblBtn;
        private DevExpress.XtraEditors.LookUpEdit importByDepartmentLookUpEdit;
        private System.Windows.Forms.RadioButton importByDepartmentRadioButton;
        private AssetMngDbDataSet assetMngDbDataSet;
        private System.Windows.Forms.BindingSource sectionTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SectionTblTableAdapter sectionTblTableAdapter;
        private System.Windows.Forms.BindingSource departmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter departmentTblTableAdapter;
        private System.Windows.Forms.BindingSource subDepartmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SubDepartmentTblTableAdapter subDepartmentTblTableAdapter;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button importData_Cancel;
        private System.Windows.Forms.Button importData_OK;
        private System.Windows.Forms.CheckBox decryptImportedFileCheckBox;
        private System.Windows.Forms.RadioButton unknownImportRadioButton;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox notesTextBox;
    }
}