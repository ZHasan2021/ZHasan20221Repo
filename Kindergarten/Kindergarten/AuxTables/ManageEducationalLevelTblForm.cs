using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kindergarten.AuxTables
{
    public partial class ManageEducationalLevelTblForm : Form
    {
        public ManageEducationalLevelTblForm()
        {
            InitializeComponent();
        }

        private void ManageEducationalLevelTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kindergartenDbDataSet.EducationalLevelTbl' table. You can move, or remove it, as needed.
            this.educationalLevelTblTableAdapter.Fill(this.kindergartenDbDataSet.EducationalLevelTbl);
            educationalLevelGridControl.EmbeddedNavigator.Buttons.Append.Visible = StaticCode.activeUserRole.AddNewEducationalLevel == true;

            this.MinimumSize = this.Size;
        }

        private void educationalLevelTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.educationalLevelTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kindergartenDbDataSet);
            mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 200);
        }
    }
}