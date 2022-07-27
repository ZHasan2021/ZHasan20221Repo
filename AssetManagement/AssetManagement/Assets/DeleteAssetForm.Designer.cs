
namespace AssetManagement.Assets
{
    partial class DeleteAssetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAssetForm));
            this.deleteAssetGroupBox = new System.Windows.Forms.GroupBox();
            this.assetInfoLabel = new System.Windows.Forms.Label();
            this.deleteAssetBtn = new System.Windows.Forms.Button();
            this.fromSquareTextBox = new System.Windows.Forms.TextBox();
            this.fromSectionTextBox = new System.Windows.Forms.TextBox();
            this.fromDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.fromCustodianNameTextBox = new System.Windows.Forms.TextBox();
            this.fromCustodianNameLabel = new System.Windows.Forms.Label();
            this.fromSquareLabel = new System.Windows.Forms.Label();
            this.fromSectionLabel = new System.Windows.Forms.Label();
            this.fromDepartmentLabel = new System.Windows.Forms.Label();
            this.assetMovementTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.squareTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.departmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter();
            this.squareTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SquareTblTableAdapter();
            this.sectionTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SectionTblTableAdapter();
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.assetMoveVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMoveVwTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetMoveVwTableAdapter();
            this.assetMovementTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetMovementTblTableAdapter();
            this.viewAssetInformationBtn = new System.Windows.Forms.Button();
            this.searchResultsListBox = new System.Windows.Forms.ListBox();
            this.searchAssetBtn = new System.Windows.Forms.Button();
            this.assetCodeLabel = new System.Windows.Forms.Label();
            this.assetCodeTextBox = new System.Windows.Forms.TextBox();
            this.deleteAssetGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMoveVwBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteAssetGroupBox
            // 
            this.deleteAssetGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteAssetGroupBox.Controls.Add(this.assetInfoLabel);
            this.deleteAssetGroupBox.Controls.Add(this.deleteAssetBtn);
            this.deleteAssetGroupBox.Controls.Add(this.fromSquareTextBox);
            this.deleteAssetGroupBox.Controls.Add(this.fromSectionTextBox);
            this.deleteAssetGroupBox.Controls.Add(this.fromDepartmentTextBox);
            this.deleteAssetGroupBox.Controls.Add(this.fromCustodianNameTextBox);
            this.deleteAssetGroupBox.Controls.Add(this.fromCustodianNameLabel);
            this.deleteAssetGroupBox.Controls.Add(this.fromSquareLabel);
            this.deleteAssetGroupBox.Controls.Add(this.fromSectionLabel);
            this.deleteAssetGroupBox.Controls.Add(this.fromDepartmentLabel);
            this.deleteAssetGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deleteAssetGroupBox.Location = new System.Drawing.Point(0, 187);
            this.deleteAssetGroupBox.Name = "deleteAssetGroupBox";
            this.deleteAssetGroupBox.Size = new System.Drawing.Size(1198, 317);
            this.deleteAssetGroupBox.TabIndex = 100;
            this.deleteAssetGroupBox.TabStop = false;
            this.deleteAssetGroupBox.Text = "معلومات الأصل الحالية والجديدة";
            this.deleteAssetGroupBox.Visible = false;
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
            this.assetInfoLabel.TabIndex = 301;
            // 
            // deleteAssetBtn
            // 
            this.deleteAssetBtn.Image = global::AssetManagement.Properties.Resources._1087037;
            this.deleteAssetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteAssetBtn.Location = new System.Drawing.Point(63, 120);
            this.deleteAssetBtn.Name = "deleteAssetBtn";
            this.deleteAssetBtn.Size = new System.Drawing.Size(163, 74);
            this.deleteAssetBtn.TabIndex = 300;
            this.deleteAssetBtn.Text = "حذف";
            this.deleteAssetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteAssetBtn.UseVisualStyleBackColor = true;
            this.deleteAssetBtn.Click += new System.EventHandler(this.deleteAssetBtn_Click);
            // 
            // fromSquareTextBox
            // 
            this.fromSquareTextBox.Location = new System.Drawing.Point(792, 142);
            this.fromSquareTextBox.Name = "fromSquareTextBox";
            this.fromSquareTextBox.ReadOnly = true;
            this.fromSquareTextBox.Size = new System.Drawing.Size(261, 32);
            this.fromSquareTextBox.TabIndex = 150;
            // 
            // fromSectionTextBox
            // 
            this.fromSectionTextBox.Location = new System.Drawing.Point(792, 95);
            this.fromSectionTextBox.Name = "fromSectionTextBox";
            this.fromSectionTextBox.ReadOnly = true;
            this.fromSectionTextBox.Size = new System.Drawing.Size(261, 32);
            this.fromSectionTextBox.TabIndex = 130;
            // 
            // fromDepartmentTextBox
            // 
            this.fromDepartmentTextBox.Location = new System.Drawing.Point(792, 48);
            this.fromDepartmentTextBox.Name = "fromDepartmentTextBox";
            this.fromDepartmentTextBox.ReadOnly = true;
            this.fromDepartmentTextBox.Size = new System.Drawing.Size(261, 32);
            this.fromDepartmentTextBox.TabIndex = 110;
            // 
            // fromCustodianNameTextBox
            // 
            this.fromCustodianNameTextBox.Location = new System.Drawing.Point(792, 189);
            this.fromCustodianNameTextBox.Name = "fromCustodianNameTextBox";
            this.fromCustodianNameTextBox.ReadOnly = true;
            this.fromCustodianNameTextBox.Size = new System.Drawing.Size(261, 32);
            this.fromCustodianNameTextBox.TabIndex = 170;
            // 
            // fromCustodianNameLabel
            // 
            this.fromCustodianNameLabel.AutoSize = true;
            this.fromCustodianNameLabel.Location = new System.Drawing.Point(1088, 193);
            this.fromCustodianNameLabel.Name = "fromCustodianNameLabel";
            this.fromCustodianNameLabel.Size = new System.Drawing.Size(50, 24);
            this.fromCustodianNameLabel.TabIndex = 165;
            this.fromCustodianNameLabel.Text = "عهدة:";
            // 
            // fromSquareLabel
            // 
            this.fromSquareLabel.AutoSize = true;
            this.fromSquareLabel.Location = new System.Drawing.Point(1074, 146);
            this.fromSquareLabel.Name = "fromSquareLabel";
            this.fromSquareLabel.Size = new System.Drawing.Size(64, 24);
            this.fromSquareLabel.TabIndex = 145;
            this.fromSquareLabel.Text = "الساحة:";
            // 
            // fromSectionLabel
            // 
            this.fromSectionLabel.AutoSize = true;
            this.fromSectionLabel.Location = new System.Drawing.Point(1082, 99);
            this.fromSectionLabel.Name = "fromSectionLabel";
            this.fromSectionLabel.Size = new System.Drawing.Size(56, 24);
            this.fromSectionLabel.TabIndex = 125;
            this.fromSectionLabel.Text = "الدائرة:";
            // 
            // fromDepartmentLabel
            // 
            this.fromDepartmentLabel.AutoSize = true;
            this.fromDepartmentLabel.Location = new System.Drawing.Point(1082, 52);
            this.fromDepartmentLabel.Name = "fromDepartmentLabel";
            this.fromDepartmentLabel.Size = new System.Drawing.Size(56, 24);
            this.fromDepartmentLabel.TabIndex = 105;
            this.fromDepartmentLabel.Text = "القسم:";
            // 
            // assetMovementTblBindingSource
            // 
            this.assetMovementTblBindingSource.DataMember = "AssetMovementTbl";
            this.assetMovementTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // squareTblBindingSource
            // 
            this.squareTblBindingSource.DataMember = "SquareTbl";
            this.squareTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // sectionTblBindingSource
            // 
            this.sectionTblBindingSource.DataMember = "SectionTbl";
            this.sectionTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // departmentTblBindingSource
            // 
            this.departmentTblBindingSource.DataMember = "DepartmentTbl";
            this.departmentTblBindingSource.DataSource = this.assetMngDbDataSet;
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
            // departmentTblTableAdapter
            // 
            this.departmentTblTableAdapter.ClearBeforeFill = true;
            // 
            // squareTblTableAdapter
            // 
            this.squareTblTableAdapter.ClearBeforeFill = true;
            // 
            // sectionTblTableAdapter
            // 
            this.sectionTblTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MainCategoryTblTableAdapter = null;
            this.tableAdapterManager.MinorCategoryTblTableAdapter = null;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.SectionTblTableAdapter = this.sectionTblTableAdapter;
            this.tableAdapterManager.SquareTblTableAdapter = this.squareTblTableAdapter;
            this.tableAdapterManager.StatusTblTableAdapter = null;
            this.tableAdapterManager.TransactionTypeTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // assetMoveVwBindingSource
            // 
            this.assetMoveVwBindingSource.DataMember = "AssetMoveVw";
            this.assetMoveVwBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMoveVwTableAdapter
            // 
            this.assetMoveVwTableAdapter.ClearBeforeFill = true;
            // 
            // assetMovementTblTableAdapter
            // 
            this.assetMovementTblTableAdapter.ClearBeforeFill = true;
            // 
            // viewAssetInformationBtn
            // 
            this.viewAssetInformationBtn.Image = global::AssetManagement.Properties.Resources._8341961;
            this.viewAssetInformationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewAssetInformationBtn.Location = new System.Drawing.Point(996, 60);
            this.viewAssetInformationBtn.Name = "viewAssetInformationBtn";
            this.viewAssetInformationBtn.Size = new System.Drawing.Size(163, 74);
            this.viewAssetInformationBtn.TabIndex = 80;
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
            this.searchResultsListBox.Location = new System.Drawing.Point(511, 23);
            this.searchResultsListBox.Name = "searchResultsListBox";
            this.searchResultsListBox.Size = new System.Drawing.Size(440, 124);
            this.searchResultsListBox.TabIndex = 70;
            this.searchResultsListBox.ValueMember = "ID";
            this.searchResultsListBox.Visible = false;
            this.searchResultsListBox.DoubleClick += new System.EventHandler(this.viewAssetInformationBtn_Click);
            // 
            // searchAssetBtn
            // 
            this.searchAssetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchAssetBtn.Image = global::AssetManagement.Properties.Resources._2719309;
            this.searchAssetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchAssetBtn.Location = new System.Drawing.Point(207, 75);
            this.searchAssetBtn.Name = "searchAssetBtn";
            this.searchAssetBtn.Size = new System.Drawing.Size(163, 74);
            this.searchAssetBtn.TabIndex = 50;
            this.searchAssetBtn.Text = "بحث";
            this.searchAssetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchAssetBtn.UseVisualStyleBackColor = true;
            this.searchAssetBtn.Click += new System.EventHandler(this.searchAssetBtn_Click);
            // 
            // assetCodeLabel
            // 
            this.assetCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assetCodeLabel.AutoSize = true;
            this.assetCodeLabel.Location = new System.Drawing.Point(39, 26);
            this.assetCodeLabel.Name = "assetCodeLabel";
            this.assetCodeLabel.Size = new System.Drawing.Size(86, 24);
            this.assetCodeLabel.TabIndex = 0;
            this.assetCodeLabel.Text = "كود الأصل:";
            // 
            // assetCodeTextBox
            // 
            this.assetCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assetCodeTextBox.Location = new System.Drawing.Point(167, 22);
            this.assetCodeTextBox.Name = "assetCodeTextBox";
            this.assetCodeTextBox.Size = new System.Drawing.Size(288, 32);
            this.assetCodeTextBox.TabIndex = 5;
            // 
            // DeleteAssetForm
            // 
            this.AcceptButton = this.searchAssetBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 504);
            this.Controls.Add(this.viewAssetInformationBtn);
            this.Controls.Add(this.searchResultsListBox);
            this.Controls.Add(this.searchAssetBtn);
            this.Controls.Add(this.assetCodeLabel);
            this.Controls.Add(this.assetCodeTextBox);
            this.Controls.Add(this.deleteAssetGroupBox);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DeleteAssetForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حذف أصل";
            this.Load += new System.EventHandler(this.DeleteAssetForm_Load);
            this.deleteAssetGroupBox.ResumeLayout(false);
            this.deleteAssetGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMoveVwBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox deleteAssetGroupBox;
        private System.Windows.Forms.Label fromCustodianNameLabel;
        private System.Windows.Forms.Label fromSquareLabel;
        private System.Windows.Forms.Label fromSectionLabel;
        private System.Windows.Forms.Label fromDepartmentLabel;
        private System.Windows.Forms.TextBox fromCustodianNameTextBox;
        private System.Windows.Forms.TextBox fromSquareTextBox;
        private System.Windows.Forms.TextBox fromSectionTextBox;
        private System.Windows.Forms.TextBox fromDepartmentTextBox;
        private System.Windows.Forms.Button deleteAssetBtn;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private AssetMngDbDataSet assetMngDbDataSet;
        private System.Windows.Forms.BindingSource departmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter departmentTblTableAdapter;
        private System.Windows.Forms.BindingSource squareTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SquareTblTableAdapter squareTblTableAdapter;
        private System.Windows.Forms.BindingSource sectionTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SectionTblTableAdapter sectionTblTableAdapter;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label assetInfoLabel;
        private System.Windows.Forms.BindingSource assetMoveVwBindingSource;
        private AssetMngDbDataSetTableAdapters.AssetMoveVwTableAdapter assetMoveVwTableAdapter;
        private System.Windows.Forms.BindingSource assetMovementTblBindingSource;
        private AssetMngDbDataSetTableAdapters.AssetMovementTblTableAdapter assetMovementTblTableAdapter;
        private System.Windows.Forms.Button viewAssetInformationBtn;
        private System.Windows.Forms.ListBox searchResultsListBox;
        private System.Windows.Forms.Button searchAssetBtn;
        private System.Windows.Forms.Label assetCodeLabel;
        private System.Windows.Forms.TextBox assetCodeTextBox;
    }
}