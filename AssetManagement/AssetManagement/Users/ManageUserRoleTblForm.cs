using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.Users
{
    public partial class ManageUserRoleTblForm : Form
    {
        public ManageUserRoleTblForm()
        {
            InitializeComponent();
        }

        private void ManageUserRoleTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.UserRoleTbl' table. You can move, or remove it, as needed.
            this.userRoleTblTableAdapter.Fill(this.assetMngDbDataSet.UserRoleTbl);

            this.MinimumSize = this.Size;
        }

        private void userRoleTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            userRoleTblBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.assetMngDbDataSet);

            StaticCode.mainDbContext.SubmitChanges();
        }
    }
}