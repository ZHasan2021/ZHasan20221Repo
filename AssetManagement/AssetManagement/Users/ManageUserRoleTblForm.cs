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

            bindingNavigatorAddNewItem.Visible = userRoleGridControl.EmbeddedNavigator.Buttons.Append.Visible = StaticCode.activeUserRole.AddNewFinancialItem == true;
            bindingNavigatorDeleteItem.Visible = userRoleGridControl.EmbeddedNavigator.Buttons.Remove.Visible = StaticCode.activeUserRole.DeleteFinancialItemRecord == true;
            userRoleTblBindingNavigatorSaveItem.Visible = userRoleGridControl.EmbeddedNavigator.Buttons.Edit.Visible = userRoleGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = StaticCode.activeUserRole.UpdateExistedFinancialItem == true;
        }

        private void userRoleTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            userRoleTblBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.assetMngDbDataSet);

            StaticCode.mainDbContext.SubmitChanges();
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(500, 200);
        }
    }
}