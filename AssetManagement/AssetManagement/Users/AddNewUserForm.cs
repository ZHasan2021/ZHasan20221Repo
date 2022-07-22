﻿using AssetManagement.AuxTables;
using AssetManagement.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.Users
{
    public partial class AddNewUserForm : Form
    {
        public AddNewUserForm()
        {
            InitializeComponent();
        }

        private void AddNewUserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.DepartmentTbl' table. You can move, or remove it, as needed.
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.UserRoleTbl' table. You can move, or remove it, as needed.
            manageDepartmentTblBtn.Visible = StaticCode.activeUserRole.ManageDepartments == true;
            this.userRoleTblTableAdapter.Fill(this.assetMngDbDataSet.UserRoleTbl);
            this.MinimumSize = this.Size;
        }

        private void showHidePasswordBtn_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.PasswordChar == '_')
            {
                passwordTextBox.PasswordChar = confirmPasswordTextBox.PasswordChar = '\0';
                showHidePasswordBtn.Image = Resources._2072008;
            }
            else
            {
                passwordTextBox.PasswordChar = confirmPasswordTextBox.PasswordChar = '_';
                showHidePasswordBtn.Image = Resources._2072009;
            }
        }

        private void addNewUserBtn_OK_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text.Trim() == "")
            {
                mainAlertControl.Show(this, "أدخل اسم المستخدم أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (passwordTextBox.Text.Trim() == "")
            {
                mainAlertControl.Show(this, "أدخل كلمة المرور أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (passwordTextBox.Text.Trim() != confirmPasswordTextBox.Text.Trim())
            {
                mainAlertControl.Show(this, "كلمة المرور غير متطابقة", StaticCode.ApplicationTitle);
                return;
            }
            if (passwordTextBox.Text.Length < 8)
            {
                mainAlertControl.Show(this, "كلمة المرور يجب أن تتألف من 8 محارف على الأقل", StaticCode.ApplicationTitle);
                return;
            }
            if (userRoleComboBox.SelectedIndex == -1)
            {
                mainAlertControl.Show(this, "اختر نوع الحساب أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (userDeptLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر القسم أولاً", StaticCode.ApplicationTitle);
                return;
            }

            try
            {
                UserTbl newUrs = new UserTbl()
                {
                    Username = userNameTextBox.Text.Trim(),
                    Password = passwordTextBox.Text.Trim(),
                    UserRole = Convert.ToInt32(userRoleComboBox.SelectedValue),
                    UserDept = Convert.ToInt32(userDeptLookUpEdit.EditValue),
                };
                StaticCode.mainDbContext.UserTbls.InsertOnSubmit(newUrs);
                StaticCode.mainDbContext.SubmitChanges();
                mainAlertControl.Show(this, "تم إضافة الحساب بنجاح", StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "حدثت مشكلة أثناء إضافة الحساب، حاول ثانية", StaticCode.ApplicationTitle);
            }
            this.Close();
        }

        private void addNewUserBtn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manageUserRoleTblBtn_Click(object sender, EventArgs e)
        {
            ManageUserRoleTblForm usrrlFrm = new ManageUserRoleTblForm();
            usrrlFrm.ShowDialog();
            this.userRoleTblTableAdapter.Fill(this.assetMngDbDataSet.UserRoleTbl);
        }

        private void manageDepartmentTblBtn_Click(object sender, EventArgs e)
        {
            ManageDepartmentTblForm dptFrm = new ManageDepartmentTblForm();
            dptFrm.ShowDialog();
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
        }
    }
}