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
    public partial class ManageEstateAreaUnitTblForm : Form
    {
        public ManageEstateAreaUnitTblForm()
        {
            InitializeComponent();
        }

        private void ManageEstateAreaUnitTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.EstateAreaUnitTbl' table. You can move, or remove it, as needed.
            this.estateAreaUnitTblTableAdapter.Fill(this.assetMngDbDataSet.EstateAreaUnitTbl);

            estateAreaUnitGridControl.EmbeddedNavigator.Buttons.Append.Visible = StaticCode.activeUserRole.AddNewEstateAreaUnit == true;

            this.MinimumSize = this.Size;
        }

        private void estateAreaUnitTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            estateAreaUnitTblBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
            mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
            StaticCode.activeUserLogin.SessionActions += $"تعديل في جدول واحدات مساحات العقار - {DateTime.Now.AddDays(StaticCode.appOptions.ShiftDays).AddSeconds(StaticCode.appOptions.ShiftSeconds)}\r\n";
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 200);
        }
    }
}