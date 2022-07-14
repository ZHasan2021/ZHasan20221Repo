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
    public partial class ManageUserTblForm : Form
    {
        public ManageUserTblForm()
        {
            InitializeComponent();
        }

        private void ManageUserTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.DepartmentTbl' table. You can move, or remove it, as needed.
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.UserRoleTbl' table. You can move, or remove it, as needed.
            this.userRoleTblTableAdapter.Fill(this.assetMngDbDataSet.UserRoleTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.UserTbl' table. You can move, or remove it, as needed.
            this.userTblTableAdapter.Fill(this.assetMngDbDataSet.UserTbl);

            this.MinimumSize = this.Size;
        }

        private void userTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            userTblBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
        }

        private void userTblBindingNavigatorManageUserRolesItem_Click(object sender, EventArgs e)
        {
            ManageUserRoleTblForm usrrlFrm = new ManageUserRoleTblForm();
            usrrlFrm.ShowDialog();
            this.userRoleTblTableAdapter.Fill(this.assetMngDbDataSet.UserRoleTbl);
        }
    }
}