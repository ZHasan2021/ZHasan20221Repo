using AssetManagement.AuxTables;
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
        UserTbl existedUser = null;
        UserRoleTbl selectedUserRole = null;
        bool updateExisted = false;

        public AddNewUserForm()
        {
            InitializeComponent();
        }

        public AddNewUserForm(int existedUserID)
        {
            InitializeComponent();

            existedUser = StaticCode.mainDbContext.UserTbls.Single(usr1 => usr1.ID == existedUserID);
            updateExisted = true;
        }

        private void AddNewUserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SectionTbl' table. You can move, or remove it, as needed.
            this.sectionTblTableAdapter.Fill(this.assetMngDbDataSet.SectionTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.DepartmentTbl' table. You can move, or remove it, as needed.
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.UserRoleTbl' table. You can move, or remove it, as needed.
            manageSectionTblBtn.Visible = StaticCode.activeUserRole.ManageSections == true;
            manageDepartmentTblBtn.Visible = StaticCode.activeUserRole.ManageDepartments == true;
            this.userRoleTblTableAdapter.Fill(this.assetMngDbDataSet.UserRoleTbl);
            this.MinimumSize = this.Size;

            if (updateExisted)
            {
                userNameTextBox.Text = existedUser.Username;
                passwordTextBox.Text = confirmPasswordTextBox.Text = existedUser.Password;
                userRoleComboBox.SelectedValue = existedUser.UserRole;
                userSectionLookUpEdit.EditValue = existedUser.UserSection;
                userDeptLookUpEdit.EditValue = existedUser.UserDept;

                addNewUserBtn_OK.Text = "حفظ";
            }
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            if (userSectionLookUpEdit.Enabled && userSectionLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر الدائرة أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (userDeptLookUpEdit.Enabled && userDeptLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر القسم أولاً", StaticCode.ApplicationTitle);
                return;
            }

            if (MessageBox.Show("هل أنت متأكد من المعلومات المدخلة؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                UserTbl newUrs = new UserTbl();
                if (updateExisted)
                {
                    newUrs = existedUser;
                    newUrs.UserSection = null;
                    newUrs.UserDept = null;
                }
                newUrs.Username = userNameTextBox.Text.Trim();
                newUrs.Password = passwordTextBox.Text.Trim();
                newUrs.UserRole = Convert.ToInt32(userRoleComboBox.SelectedValue);
                if(userSectionLookUpEdit.Enabled)
                newUrs.UserSection = Convert.ToInt32(userSectionLookUpEdit.EditValue);
                if (userDeptLookUpEdit.Enabled)
                    newUrs.UserDept = Convert.ToInt32(userDeptLookUpEdit.EditValue);
                if (!updateExisted)
                StaticCode.mainDbContext.UserTbls.InsertOnSubmit(newUrs);
                StaticCode.mainDbContext.SubmitChanges();
                mainAlertControl.Show(this, $"تم {((updateExisted)?"حفظ التعديلات": "إضافة الحساب")} بنجاح", StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "حدثت مشكلة أثناء حفظ البيانات، حاول ثانية", StaticCode.ApplicationTitle);
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

        private void userSectionLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if(userSectionLookUpEdit.EditValue==null)
            {
            userDeptLookUpEdit.Properties.DataSource = StaticCode.mainDbContext.DepartmentTbls;
                return;
            }
            var deptItems = StaticCode.mainDbContext.DepartmentTbls.Where(dpt1 => dpt1.SectionOfDepartment == Convert.ToInt32(userSectionLookUpEdit.EditValue));
            userDeptLookUpEdit.Properties.DataSource = deptItems;
            userDeptLookUpEdit.EditValue = null;
        }

        private void manageSectionTblBtn_Click(object sender, EventArgs e)
        {
            ManageSectionTblForm sctFrm = new ManageSectionTblForm();
            sctFrm.ShowDialog();
            this.sectionTblTableAdapter.Fill(this.assetMngDbDataSet.SectionTbl);
        }

        private void userRoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUserRole = null;
            if (userRoleComboBox.SelectedIndex == -1)
                return;
            selectedUserRole = StaticCode.mainDbContext.UserRoleTbls.Single(usrl => usrl.ID == Convert.ToInt32(userRoleComboBox.SelectedValue));
            userSectionLookUpEdit.Enabled = selectedUserRole.IsSectionIndependent != true;
            userSectionLookUpEdit.EditValue = null;
            userDeptLookUpEdit.Enabled = selectedUserRole.IsDepartmentIndependent != true;
            userDeptLookUpEdit.EditValue = null;
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 200);
        }
    }
}