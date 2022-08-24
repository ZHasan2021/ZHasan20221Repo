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
    public partial class ManageFeePeriodTblForm : Form
    {
        public ManageFeePeriodTblForm()
        {
            InitializeComponent();
        }

        private void ManageFeePeriodTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kindergartenDbDataSet.FeePeriodTbl' table. You can move, or remove it, as needed.
            this.feePeriodTblTableAdapter.Fill(this.kindergartenDbDataSet.FeePeriodTbl);
            feePeriodGridControl.EmbeddedNavigator.Buttons.Append.Visible = StaticCode.activeUserRole.AddNewFeePeriod == true;

            this.MinimumSize = this.Size;
        }

        private void educationalLevelTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.feePeriodTblBindingSource.EndEdit();
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