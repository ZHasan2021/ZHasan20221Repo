using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            try
            {
                this.Validate();
                userRoleTblBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(this.assetMngDbDataSet);

                StaticCode.mainConn.Close();
                StaticCode.mainConn.Open();

                mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
            }
            catch (SqlException)
            {
                mainAlertControl.Show(this, StaticCode.ApplicationTitle, "لا يمكن تكرار نوع الحساب لأكثر من سجل، حاول تعديل المدخلات لتوافق القيود الموضوعة");
                MessageBox.Show("لا يمكن تكرار نوع الحساب لأكثر من سجل، حاول تعديل المدخلات لتوافق القيود الموضوعة", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StaticCode.mainConn.Close();
            StaticCode.mainConn.Open();

            mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 150);
            e.AlertForm.Location = new Point(500, 200);
        }
    }
}