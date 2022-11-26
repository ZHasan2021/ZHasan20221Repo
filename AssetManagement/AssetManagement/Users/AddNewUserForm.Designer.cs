
namespace AssetManagement.Users
{
    partial class AddNewUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewUserForm));
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.userRoleComboBox = new System.Windows.Forms.ComboBox();
            this.userRoleTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.userRoleLabel = new System.Windows.Forms.Label();
            this.userRoleTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.UserRoleTblTableAdapter();
            this.showHidePasswordBtn = new System.Windows.Forms.Button();
            this.addNewUserBtn_Cancel = new System.Windows.Forms.Button();
            this.addNewUserBtn_OK = new System.Windows.Forms.Button();
            this.manageUserRoleTblBtn = new System.Windows.Forms.Button();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.manageDepartmentTblBtn = new System.Windows.Forms.Button();
            this.userDeptLabel = new System.Windows.Forms.Label();
            this.userDeptLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.departmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter();
            this.userSectionLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.sectionTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userSectionLabel = new System.Windows.Forms.Label();
            this.manageSectionTblBtn = new System.Windows.Forms.Button();
            this.sectionTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SectionTblTableAdapter();
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.userPrefixTextBox = new System.Windows.Forms.TextBox();
            this.userPrefixLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSectionLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(33, 20);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(117, 24);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "اسم المستخدم:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(190, 16);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(261, 32);
            this.userNameTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(190, 76);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '_';
            this.passwordTextBox.Size = new System.Drawing.Size(261, 32);
            this.passwordTextBox.TabIndex = 15;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(33, 80);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(90, 24);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "كلمة المرور:";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(190, 136);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '_';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(261, 32);
            this.confirmPasswordTextBox.TabIndex = 25;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(33, 140);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(128, 24);
            this.confirmPasswordLabel.TabIndex = 20;
            this.confirmPasswordLabel.Text = "تأكيد كلمة المرور:";
            // 
            // userRoleComboBox
            // 
            this.userRoleComboBox.DataSource = this.userRoleTblBindingSource;
            this.userRoleComboBox.DisplayMember = "RoleName";
            this.userRoleComboBox.FormattingEnabled = true;
            this.userRoleComboBox.Location = new System.Drawing.Point(190, 196);
            this.userRoleComboBox.Name = "userRoleComboBox";
            this.userRoleComboBox.Size = new System.Drawing.Size(261, 32);
            this.userRoleComboBox.TabIndex = 40;
            this.userRoleComboBox.ValueMember = "ID";
            this.userRoleComboBox.SelectedIndexChanged += new System.EventHandler(this.userRoleComboBox_SelectedIndexChanged);
            // 
            // userRoleTblBindingSource
            // 
            this.userRoleTblBindingSource.DataMember = "UserRoleTbl";
            this.userRoleTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userRoleLabel
            // 
            this.userRoleLabel.AutoSize = true;
            this.userRoleLabel.Location = new System.Drawing.Point(33, 200);
            this.userRoleLabel.Name = "userRoleLabel";
            this.userRoleLabel.Size = new System.Drawing.Size(99, 24);
            this.userRoleLabel.TabIndex = 35;
            this.userRoleLabel.Text = "نوع الحساب:";
            // 
            // userRoleTblTableAdapter
            // 
            this.userRoleTblTableAdapter.ClearBeforeFill = true;
            // 
            // showHidePasswordBtn
            // 
            this.showHidePasswordBtn.Image = global::AssetManagement.Properties.Resources._2072009;
            this.showHidePasswordBtn.Location = new System.Drawing.Point(513, 92);
            this.showHidePasswordBtn.Name = "showHidePasswordBtn";
            this.showHidePasswordBtn.Size = new System.Drawing.Size(55, 55);
            this.showHidePasswordBtn.TabIndex = 30;
            this.showHidePasswordBtn.UseVisualStyleBackColor = true;
            this.showHidePasswordBtn.Click += new System.EventHandler(this.showHidePasswordBtn_Click);
            // 
            // addNewUserBtn_Cancel
            // 
            this.addNewUserBtn_Cancel.Image = global::AssetManagement.Properties.Resources._2137707;
            this.addNewUserBtn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewUserBtn_Cancel.Location = new System.Drawing.Point(674, 331);
            this.addNewUserBtn_Cancel.Name = "addNewUserBtn_Cancel";
            this.addNewUserBtn_Cancel.Size = new System.Drawing.Size(152, 65);
            this.addNewUserBtn_Cancel.TabIndex = 205;
            this.addNewUserBtn_Cancel.Text = "إغلاق";
            this.addNewUserBtn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewUserBtn_Cancel.UseVisualStyleBackColor = true;
            this.addNewUserBtn_Cancel.Click += new System.EventHandler(this.addNewUserBtn_Cancel_Click);
            // 
            // addNewUserBtn_OK
            // 
            this.addNewUserBtn_OK.Image = global::AssetManagement.Properties.Resources._2137710;
            this.addNewUserBtn_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewUserBtn_OK.Location = new System.Drawing.Point(674, 240);
            this.addNewUserBtn_OK.Name = "addNewUserBtn_OK";
            this.addNewUserBtn_OK.Size = new System.Drawing.Size(152, 65);
            this.addNewUserBtn_OK.TabIndex = 200;
            this.addNewUserBtn_OK.Text = "إضافة";
            this.addNewUserBtn_OK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewUserBtn_OK.UseVisualStyleBackColor = true;
            this.addNewUserBtn_OK.Click += new System.EventHandler(this.addNewUserBtn_OK_Click);
            // 
            // manageUserRoleTblBtn
            // 
            this.manageUserRoleTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageUserRoleTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageUserRoleTblBtn.Location = new System.Drawing.Point(513, 185);
            this.manageUserRoleTblBtn.Name = "manageUserRoleTblBtn";
            this.manageUserRoleTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageUserRoleTblBtn.TabIndex = 41;
            this.manageUserRoleTblBtn.UseVisualStyleBackColor = true;
            this.manageUserRoleTblBtn.Click += new System.EventHandler(this.manageUserRoleTblBtn_Click);
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
            // manageDepartmentTblBtn
            // 
            this.manageDepartmentTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageDepartmentTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageDepartmentTblBtn.Location = new System.Drawing.Point(513, 305);
            this.manageDepartmentTblBtn.Name = "manageDepartmentTblBtn";
            this.manageDepartmentTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageDepartmentTblBtn.TabIndex = 60;
            this.manageDepartmentTblBtn.UseVisualStyleBackColor = true;
            this.manageDepartmentTblBtn.Click += new System.EventHandler(this.manageDepartmentTblBtn_Click);
            // 
            // userDeptLabel
            // 
            this.userDeptLabel.AutoSize = true;
            this.userDeptLabel.Location = new System.Drawing.Point(33, 320);
            this.userDeptLabel.Name = "userDeptLabel";
            this.userDeptLabel.Size = new System.Drawing.Size(56, 24);
            this.userDeptLabel.TabIndex = 55;
            this.userDeptLabel.Text = "القسم:";
            // 
            // userDeptLookUpEdit
            // 
            this.userDeptLookUpEdit.Location = new System.Drawing.Point(190, 317);
            this.userDeptLookUpEdit.Name = "userDeptLookUpEdit";
            this.userDeptLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDeptLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.userDeptLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.userDeptLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف القسم", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "اسم القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentHQ", "مقر القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.userDeptLookUpEdit.Properties.DataSource = this.departmentTblBindingSource;
            this.userDeptLookUpEdit.Properties.DisplayMember = "DepartmentName";
            this.userDeptLookUpEdit.Properties.ValueMember = "ID";
            this.userDeptLookUpEdit.Size = new System.Drawing.Size(261, 30);
            this.userDeptLookUpEdit.TabIndex = 60;
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
            // userSectionLookUpEdit
            // 
            this.userSectionLookUpEdit.Location = new System.Drawing.Point(190, 257);
            this.userSectionLookUpEdit.Name = "userSectionLookUpEdit";
            this.userSectionLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSectionLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.userSectionLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.userSectionLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الدائرة", 100, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SectionName", "اسم الدائرة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.userSectionLookUpEdit.Properties.DataSource = this.sectionTblBindingSource;
            this.userSectionLookUpEdit.Properties.DisplayMember = "SectionName";
            this.userSectionLookUpEdit.Properties.ValueMember = "ID";
            this.userSectionLookUpEdit.Size = new System.Drawing.Size(261, 30);
            this.userSectionLookUpEdit.TabIndex = 50;
            this.userSectionLookUpEdit.EditValueChanged += new System.EventHandler(this.userSectionLookUpEdit_EditValueChanged);
            // 
            // sectionTblBindingSource
            // 
            this.sectionTblBindingSource.DataMember = "SectionTbl";
            this.sectionTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // userSectionLabel
            // 
            this.userSectionLabel.AutoSize = true;
            this.userSectionLabel.Location = new System.Drawing.Point(33, 260);
            this.userSectionLabel.Name = "userSectionLabel";
            this.userSectionLabel.Size = new System.Drawing.Size(56, 24);
            this.userSectionLabel.TabIndex = 45;
            this.userSectionLabel.Text = "الدائرة:";
            // 
            // manageSectionTblBtn
            // 
            this.manageSectionTblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageSectionTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageSectionTblBtn.Location = new System.Drawing.Point(513, 245);
            this.manageSectionTblBtn.Name = "manageSectionTblBtn";
            this.manageSectionTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageSectionTblBtn.TabIndex = 51;
            this.manageSectionTblBtn.UseVisualStyleBackColor = true;
            this.manageSectionTblBtn.Click += new System.EventHandler(this.manageSectionTblBtn_Click);
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
            this.tableAdapterManager.SubDepartmentTblTableAdapter = null;
            this.tableAdapterManager.TransactionTypeTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTblTableAdapter = this.userRoleTblTableAdapter;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // userPrefixTextBox
            // 
            this.userPrefixTextBox.Location = new System.Drawing.Point(190, 376);
            this.userPrefixTextBox.Name = "userPrefixTextBox";
            this.userPrefixTextBox.Size = new System.Drawing.Size(261, 32);
            this.userPrefixTextBox.TabIndex = 70;
            // 
            // userPrefixLabel
            // 
            this.userPrefixLabel.AutoSize = true;
            this.userPrefixLabel.Location = new System.Drawing.Point(33, 380);
            this.userPrefixLabel.Name = "userPrefixLabel";
            this.userPrefixLabel.Size = new System.Drawing.Size(122, 24);
            this.userPrefixLabel.TabIndex = 65;
            this.userPrefixLabel.Text = "بادئة المستخدم:";
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 457);
            this.Controls.Add(this.userPrefixTextBox);
            this.Controls.Add(this.userPrefixLabel);
            this.Controls.Add(this.manageSectionTblBtn);
            this.Controls.Add(this.userSectionLookUpEdit);
            this.Controls.Add(this.userSectionLabel);
            this.Controls.Add(this.userDeptLookUpEdit);
            this.Controls.Add(this.manageDepartmentTblBtn);
            this.Controls.Add(this.userDeptLabel);
            this.Controls.Add(this.manageUserRoleTblBtn);
            this.Controls.Add(this.addNewUserBtn_Cancel);
            this.Controls.Add(this.addNewUserBtn_OK);
            this.Controls.Add(this.showHidePasswordBtn);
            this.Controls.Add(this.userRoleLabel);
            this.Controls.Add(this.userRoleComboBox);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddNewUserForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة حساب جديد";
            this.Load += new System.EventHandler(this.AddNewUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userRoleTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDeptLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSectionLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.ComboBox userRoleComboBox;
        private System.Windows.Forms.Label userRoleLabel;
        private AssetMngDbDataSet assetMngDbDataSet;
        private System.Windows.Forms.BindingSource userRoleTblBindingSource;
        private AssetMngDbDataSetTableAdapters.UserRoleTblTableAdapter userRoleTblTableAdapter;
        private System.Windows.Forms.Button showHidePasswordBtn;
        private System.Windows.Forms.Button addNewUserBtn_Cancel;
        private System.Windows.Forms.Button addNewUserBtn_OK;
        private System.Windows.Forms.Button manageUserRoleTblBtn;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private System.Windows.Forms.Button manageDepartmentTblBtn;
        private System.Windows.Forms.Label userDeptLabel;
        private DevExpress.XtraEditors.LookUpEdit userDeptLookUpEdit;
        private System.Windows.Forms.BindingSource departmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter departmentTblTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit userSectionLookUpEdit;
        private System.Windows.Forms.Label userSectionLabel;
        private System.Windows.Forms.Button manageSectionTblBtn;
        private System.Windows.Forms.BindingSource sectionTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SectionTblTableAdapter sectionTblTableAdapter;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox userPrefixTextBox;
        private System.Windows.Forms.Label userPrefixLabel;
    }
}