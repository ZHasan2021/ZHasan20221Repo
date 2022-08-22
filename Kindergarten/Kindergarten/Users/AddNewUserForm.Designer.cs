
namespace Kindergarten.Users
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
            this.kindergartenDbDataSet = new Kindergarten.KindergartenDbDataSet();
            this.userRoleLabel = new System.Windows.Forms.Label();
            this.showHidePasswordBtn = new System.Windows.Forms.Button();
            this.addNewUserBtn_Cancel = new System.Windows.Forms.Button();
            this.addNewUserBtn_OK = new System.Windows.Forms.Button();
            this.manageUserRoleTblBtn = new System.Windows.Forms.Button();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.userRoleTblTableAdapter = new Kindergarten.KindergartenDbDataSetTableAdapters.UserRoleTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(33, 28);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(117, 24);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "اسم المستخدم:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(190, 24);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(261, 32);
            this.userNameTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(190, 94);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '_';
            this.passwordTextBox.Size = new System.Drawing.Size(261, 32);
            this.passwordTextBox.TabIndex = 15;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(33, 98);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(90, 24);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "كلمة المرور:";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(190, 164);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '_';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(261, 32);
            this.confirmPasswordTextBox.TabIndex = 25;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(33, 168);
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
            this.userRoleComboBox.Location = new System.Drawing.Point(190, 234);
            this.userRoleComboBox.Name = "userRoleComboBox";
            this.userRoleComboBox.Size = new System.Drawing.Size(261, 32);
            this.userRoleComboBox.TabIndex = 40;
            this.userRoleComboBox.ValueMember = "ID";
            // 
            // userRoleTblBindingSource
            // 
            this.userRoleTblBindingSource.DataMember = "UserRoleTbl";
            this.userRoleTblBindingSource.DataSource = this.kindergartenDbDataSet;
            // 
            // kindergartenDbDataSet
            // 
            this.kindergartenDbDataSet.DataSetName = "KindergartenDbDataSet";
            this.kindergartenDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userRoleLabel
            // 
            this.userRoleLabel.AutoSize = true;
            this.userRoleLabel.Location = new System.Drawing.Point(33, 238);
            this.userRoleLabel.Name = "userRoleLabel";
            this.userRoleLabel.Size = new System.Drawing.Size(99, 24);
            this.userRoleLabel.TabIndex = 35;
            this.userRoleLabel.Text = "نوع الحساب:";
            // 
            // showHidePasswordBtn
            // 
            this.showHidePasswordBtn.Image = global::Kindergarten.Properties.Resources._2072009;
            this.showHidePasswordBtn.Location = new System.Drawing.Point(513, 120);
            this.showHidePasswordBtn.Name = "showHidePasswordBtn";
            this.showHidePasswordBtn.Size = new System.Drawing.Size(55, 55);
            this.showHidePasswordBtn.TabIndex = 30;
            this.showHidePasswordBtn.UseVisualStyleBackColor = true;
            this.showHidePasswordBtn.Click += new System.EventHandler(this.showHidePasswordBtn_Click);
            // 
            // addNewUserBtn_Cancel
            // 
            this.addNewUserBtn_Cancel.Image = global::Kindergarten.Properties.Resources._2137707;
            this.addNewUserBtn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewUserBtn_Cancel.Location = new System.Drawing.Point(674, 277);
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
            this.addNewUserBtn_OK.Image = global::Kindergarten.Properties.Resources._2137710;
            this.addNewUserBtn_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewUserBtn_OK.Location = new System.Drawing.Point(674, 186);
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
            this.manageUserRoleTblBtn.Image = global::Kindergarten.Properties.Resources._981382;
            this.manageUserRoleTblBtn.Location = new System.Drawing.Point(513, 223);
            this.manageUserRoleTblBtn.Name = "manageUserRoleTblBtn";
            this.manageUserRoleTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageUserRoleTblBtn.TabIndex = 45;
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
            this.mainAlertControl.AutoHeight = true;
            this.mainAlertControl.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight;
            // 
            // userRoleTblTableAdapter
            // 
            this.userRoleTblTableAdapter.ClearBeforeFill = true;
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 377);
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
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDbDataSet)).EndInit();
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
        private System.Windows.Forms.Button showHidePasswordBtn;
        private System.Windows.Forms.Button addNewUserBtn_Cancel;
        private System.Windows.Forms.Button addNewUserBtn_OK;
        private System.Windows.Forms.Button manageUserRoleTblBtn;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private KindergartenDbDataSet kindergartenDbDataSet;
        private System.Windows.Forms.BindingSource userRoleTblBindingSource;
        private KindergartenDbDataSetTableAdapters.UserRoleTblTableAdapter userRoleTblTableAdapter;
    }
}