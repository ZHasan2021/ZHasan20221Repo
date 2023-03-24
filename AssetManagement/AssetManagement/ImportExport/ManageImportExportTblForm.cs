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
    public partial class ManageImportExportTblForm : Form
    {
        public ManageImportExportTblForm()
        {
            InitializeComponent();
        }

        private void ManageImportExportTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.ImportExportTbl' table. You can move, or remove it, as needed.
            this.importExportTblTableAdapter.Fill(this.assetMngDbDataSet.ImportExportTbl);

            this.MinimumSize = this.Size;
        }

        private void importExportTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            importExportTblBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
            mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
            StaticCode.activeUserLogin.SessionActions += $"تعديل في جدول سجلات الاستيراد والتصدير - {DateTime.Now.AddDays(StaticCode.appOptions.ShiftDays).AddSeconds(StaticCode.appOptions.ShiftSeconds)}\r\n";
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 200);
        }
    }
}