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
    public partial class ManageScholasticYearTblForm : Form
    {
        public ManageScholasticYearTblForm()
        {
            InitializeComponent();
        }

        private void ManageScholasticYearTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kindergartenDbDataSet.ScholasticYearTbl' table. You can move, or remove it, as needed.
            this.scholasticYearTblTableAdapter.Fill(this.kindergartenDbDataSet.ScholasticYearTbl);
            educationalLevelGridControl.EmbeddedNavigator.Buttons.Append.Visible = StaticCode.activeUserRole.AddNewScholasticYear == true;

            this.MinimumSize = this.Size;
        }

        private void scholasticYearTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scholasticYearTblBindingSource.EndEdit();
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