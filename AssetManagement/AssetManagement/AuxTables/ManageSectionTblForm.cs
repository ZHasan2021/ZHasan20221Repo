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
    public partial class ManageSectionTblForm : Form
    {
        public ManageSectionTblForm()
        {
            InitializeComponent();
        }

        private void ManageSectionTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SectionTbl' table. You can move, or remove it, as needed.
            this.sectionTblTableAdapter.Fill(this.assetMngDbDataSet.SectionTbl);

            sectionGridControl.EmbeddedNavigator.Buttons.Append.Visible = StaticCode.activeUserRole.AddNewSection == true;

            this.MinimumSize = this.Size;
        }

        private void sectionTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sectionTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
            mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
        }
    }
}