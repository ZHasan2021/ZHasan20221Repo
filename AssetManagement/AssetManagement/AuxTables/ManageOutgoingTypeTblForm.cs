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
    public partial class ManageOutgoingTypeTblForm : Form
    {
        public ManageOutgoingTypeTblForm()
        {
            InitializeComponent();
        }

        private void ManageOutgoingTypeTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.IncomingTypeTbl' table. You can move, or remove it, as needed.
            this.incomingTypeTblTableAdapter.Fill(this.assetMngDbDataSet.IncomingTypeTbl);

            incomingTypeGridControl.EmbeddedNavigator.Buttons.Append.Visible = StaticCode.activeUserRole.AddNewSquare == true;

            this.MinimumSize = this.Size;
        }

        private void incomingTypeTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.incomingTypeTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
            mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 200);
        }
    }
}