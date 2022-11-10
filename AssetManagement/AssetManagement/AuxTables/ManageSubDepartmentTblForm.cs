using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.AuxTables
{
    public partial class ManageSubDepartmentTblForm : Form
    {
        public ManageSubDepartmentTblForm()
        {
            InitializeComponent();
        }

        private void ManageSubDepartmentTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.DepartmentVw' table. You can move, or remove it, as needed.
            this.departmentVwTableAdapter.Fill(this.assetMngDbDataSet.DepartmentVw);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SubDepartmentTbl' table. You can move, or remove it, as needed.
            this.subDepartmentTblTableAdapter.Fill(this.assetMngDbDataSet.SubDepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.DepartmentTbl' table. You can move, or remove it, as needed.
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);

            subDepartmentGridControl.EmbeddedNavigator.Buttons.Append.Visible = StaticCode.activeUserRole.AddNewSubDepartment == true;

            this.MinimumSize = this.Size;
        }

        private void subDepartmentTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                subDepartmentTblBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
                mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "هناك تكرار في أسماء الوحدات، أزل التكرار أولاً", StaticCode.ApplicationTitle);
            }
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 200);
        }
    }
}