
namespace AssetManagement.AuxTables
{
    partial class AddNewMinorCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewMinorCategoryForm));
            this.minorCategoryNameLabel = new System.Windows.Forms.Label();
            this.minorCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.mainCategoryLabel = new System.Windows.Forms.Label();
            this.minorCategoryDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.minorCategoryDescriptionLabel = new System.Windows.Forms.Label();
            this.mainCategoryLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.mainCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.mainCategoryTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.MainCategoryTblTableAdapter();
            this.productiveAgeInYearsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.productiveAgeInYearsLabel = new System.Windows.Forms.Label();
            this.destructionRateLabel = new System.Windows.Forms.Label();
            this.destructionRateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addNewMinorCategoryBtn_Cancel = new System.Windows.Forms.Button();
            this.addNewMinorCategoryBtn_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productiveAgeInYearsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destructionRateNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // minorCategoryNameLabel
            // 
            this.minorCategoryNameLabel.AutoSize = true;
            this.minorCategoryNameLabel.Location = new System.Drawing.Point(42, 46);
            this.minorCategoryNameLabel.Name = "minorCategoryNameLabel";
            this.minorCategoryNameLabel.Size = new System.Drawing.Size(132, 24);
            this.minorCategoryNameLabel.TabIndex = 0;
            this.minorCategoryNameLabel.Text = "اسم الفئة الفرعية:";
            // 
            // minorCategoryNameTextBox
            // 
            this.minorCategoryNameTextBox.Location = new System.Drawing.Point(255, 42);
            this.minorCategoryNameTextBox.Name = "minorCategoryNameTextBox";
            this.minorCategoryNameTextBox.Size = new System.Drawing.Size(249, 32);
            this.minorCategoryNameTextBox.TabIndex = 5;
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
            // mainCategoryLabel
            // 
            this.mainCategoryLabel.AutoSize = true;
            this.mainCategoryLabel.Location = new System.Drawing.Point(42, 182);
            this.mainCategoryLabel.Name = "mainCategoryLabel";
            this.mainCategoryLabel.Size = new System.Drawing.Size(177, 24);
            this.mainCategoryLabel.TabIndex = 20;
            this.mainCategoryLabel.Text = "الفئة الرئيسية التابعة لها:";
            // 
            // minorCategoryDescriptionTextBox
            // 
            this.minorCategoryDescriptionTextBox.Location = new System.Drawing.Point(255, 111);
            this.minorCategoryDescriptionTextBox.Name = "minorCategoryDescriptionTextBox";
            this.minorCategoryDescriptionTextBox.Size = new System.Drawing.Size(249, 32);
            this.minorCategoryDescriptionTextBox.TabIndex = 15;
            // 
            // minorCategoryDescriptionLabel
            // 
            this.minorCategoryDescriptionLabel.AutoSize = true;
            this.minorCategoryDescriptionLabel.Location = new System.Drawing.Point(42, 114);
            this.minorCategoryDescriptionLabel.Name = "minorCategoryDescriptionLabel";
            this.minorCategoryDescriptionLabel.Size = new System.Drawing.Size(146, 24);
            this.minorCategoryDescriptionLabel.TabIndex = 10;
            this.minorCategoryDescriptionLabel.Text = "وصف الفئة الفرعية:";
            // 
            // mainCategoryLookUpEdit
            // 
            this.mainCategoryLookUpEdit.Location = new System.Drawing.Point(255, 179);
            this.mainCategoryLookUpEdit.Name = "mainCategoryLookUpEdit";
            this.mainCategoryLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCategoryLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.mainCategoryLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mainCategoryLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف القسم الرئيسي", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainCategoryName", "اسم القسم الرئيسي", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainCategoryDescription", "وصف الفئة الرئيسية", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.mainCategoryLookUpEdit.Properties.DataSource = this.mainCategoryTblBindingSource;
            this.mainCategoryLookUpEdit.Properties.DisplayMember = "MainCategoryName";
            this.mainCategoryLookUpEdit.Properties.ValueMember = "ID";
            this.mainCategoryLookUpEdit.Size = new System.Drawing.Size(249, 30);
            this.mainCategoryLookUpEdit.TabIndex = 25;
            // 
            // mainCategoryTblBindingSource
            // 
            this.mainCategoryTblBindingSource.DataMember = "MainCategoryTbl";
            this.mainCategoryTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainCategoryTblTableAdapter
            // 
            this.mainCategoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // productiveAgeInYearsNumericUpDown
            // 
            this.productiveAgeInYearsNumericUpDown.Location = new System.Drawing.Point(255, 248);
            this.productiveAgeInYearsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productiveAgeInYearsNumericUpDown.Name = "productiveAgeInYearsNumericUpDown";
            this.productiveAgeInYearsNumericUpDown.Size = new System.Drawing.Size(249, 32);
            this.productiveAgeInYearsNumericUpDown.TabIndex = 35;
            this.productiveAgeInYearsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productiveAgeInYearsNumericUpDown.ValueChanged += new System.EventHandler(this.productiveAgeInYearsNumericUpDown_ValueChanged);
            // 
            // productiveAgeInYearsLabel
            // 
            this.productiveAgeInYearsLabel.AutoSize = true;
            this.productiveAgeInYearsLabel.Location = new System.Drawing.Point(42, 250);
            this.productiveAgeInYearsLabel.Name = "productiveAgeInYearsLabel";
            this.productiveAgeInYearsLabel.Size = new System.Drawing.Size(185, 24);
            this.productiveAgeInYearsLabel.TabIndex = 30;
            this.productiveAgeInYearsLabel.Text = "العمر الإنتاجي (بالسنوات):";
            // 
            // destructionRateLabel
            // 
            this.destructionRateLabel.AutoSize = true;
            this.destructionRateLabel.Location = new System.Drawing.Point(42, 323);
            this.destructionRateLabel.Name = "destructionRateLabel";
            this.destructionRateLabel.Size = new System.Drawing.Size(108, 24);
            this.destructionRateLabel.TabIndex = 40;
            this.destructionRateLabel.Text = "معدل الإهلاك:";
            // 
            // destructionRateNumericUpDown
            // 
            this.destructionRateNumericUpDown.DecimalPlaces = 2;
            this.destructionRateNumericUpDown.Location = new System.Drawing.Point(255, 321);
            this.destructionRateNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.destructionRateNumericUpDown.Name = "destructionRateNumericUpDown";
            this.destructionRateNumericUpDown.ReadOnly = true;
            this.destructionRateNumericUpDown.Size = new System.Drawing.Size(249, 32);
            this.destructionRateNumericUpDown.TabIndex = 45;
            this.destructionRateNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addNewMinorCategoryBtn_Cancel
            // 
            this.addNewMinorCategoryBtn_Cancel.Image = global::AssetManagement.Properties.Resources._2137707;
            this.addNewMinorCategoryBtn_Cancel.Location = new System.Drawing.Point(772, 303);
            this.addNewMinorCategoryBtn_Cancel.Name = "addNewMinorCategoryBtn_Cancel";
            this.addNewMinorCategoryBtn_Cancel.Size = new System.Drawing.Size(69, 65);
            this.addNewMinorCategoryBtn_Cancel.TabIndex = 105;
            this.addNewMinorCategoryBtn_Cancel.UseVisualStyleBackColor = true;
            this.addNewMinorCategoryBtn_Cancel.Click += new System.EventHandler(this.addNewMinorCategoryBtn_Cancel_Click);
            // 
            // addNewMinorCategoryBtn_OK
            // 
            this.addNewMinorCategoryBtn_OK.Image = global::AssetManagement.Properties.Resources._2137710;
            this.addNewMinorCategoryBtn_OK.Location = new System.Drawing.Point(653, 303);
            this.addNewMinorCategoryBtn_OK.Name = "addNewMinorCategoryBtn_OK";
            this.addNewMinorCategoryBtn_OK.Size = new System.Drawing.Size(69, 65);
            this.addNewMinorCategoryBtn_OK.TabIndex = 100;
            this.addNewMinorCategoryBtn_OK.UseVisualStyleBackColor = true;
            this.addNewMinorCategoryBtn_OK.Click += new System.EventHandler(this.addNewMinorCategoryBtn_OK_Click);
            // 
            // AddNewMinorCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 384);
            this.Controls.Add(this.addNewMinorCategoryBtn_Cancel);
            this.Controls.Add(this.addNewMinorCategoryBtn_OK);
            this.Controls.Add(this.destructionRateLabel);
            this.Controls.Add(this.destructionRateNumericUpDown);
            this.Controls.Add(this.productiveAgeInYearsLabel);
            this.Controls.Add(this.productiveAgeInYearsNumericUpDown);
            this.Controls.Add(this.minorCategoryDescriptionTextBox);
            this.Controls.Add(this.minorCategoryDescriptionLabel);
            this.Controls.Add(this.mainCategoryLabel);
            this.Controls.Add(this.mainCategoryLookUpEdit);
            this.Controls.Add(this.minorCategoryNameTextBox);
            this.Controls.Add(this.minorCategoryNameLabel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddNewMinorCategoryForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة فئة فرعية جديدة";
            this.Load += new System.EventHandler(this.AddNewMinorCategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productiveAgeInYearsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destructionRateNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minorCategoryNameLabel;
        private System.Windows.Forms.TextBox minorCategoryNameTextBox;
        private DevExpress.XtraEditors.LookUpEdit mainCategoryLookUpEdit;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private System.Windows.Forms.Label mainCategoryLabel;
        private System.Windows.Forms.TextBox minorCategoryDescriptionTextBox;
        private System.Windows.Forms.Label minorCategoryDescriptionLabel;
        private AssetMngDbDataSet assetMngDbDataSet;
        private System.Windows.Forms.BindingSource mainCategoryTblBindingSource;
        private AssetMngDbDataSetTableAdapters.MainCategoryTblTableAdapter mainCategoryTblTableAdapter;
        private System.Windows.Forms.NumericUpDown productiveAgeInYearsNumericUpDown;
        private System.Windows.Forms.Label productiveAgeInYearsLabel;
        private System.Windows.Forms.Label destructionRateLabel;
        private System.Windows.Forms.NumericUpDown destructionRateNumericUpDown;
        private System.Windows.Forms.Button addNewMinorCategoryBtn_Cancel;
        private System.Windows.Forms.Button addNewMinorCategoryBtn_OK;
    }
}