using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.AuxTables
{
    public partial class ManageSquareTblForm : Form
    {
        public ManageSquareTblForm()
        {
            InitializeComponent();
        }

        private void ManageSquareTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SquareTbl' table. You can move, or remove it, as needed.
            this.squareTblTableAdapter.Fill(this.assetMngDbDataSet.SquareTbl);

            squareGridControl.EmbeddedNavigator.Buttons.Append.Visible = StaticCode.activeUserRole.AddNewSquare == true;

            this.MinimumSize = this.Size;
        }

        private void squareTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                squareTblBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
                mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
                StaticCode.activeUserLogin.SessionActions += $"تعديل في جدول الساحات - {DateTime.Now.AddDays(StaticCode.appOptions.ShiftDays).AddSeconds(StaticCode.appOptions.ShiftSeconds)}\r\n";
            }
            catch (SqlException)
            {
                mainAlertControl.Show(this, StaticCode.ApplicationTitle, "بعض السجلات التي حذفتها مرتبطة بسجلات فرعية ضمن سجلات الأصول، لذا لا يمكن حذفها حالياً");
                MessageBox.Show("بعض السجلات التي حذفتها مرتبطة بسجلات فرعية ضمن سجلات الأصول، لذا لا يمكن حذفها حالياً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch
            {
                mainAlertControl.Show(this, StaticCode.ApplicationTitle, "لم يتم الحفظ، حاول لاحقاً");
                MessageBox.Show("لم يتم الحفظ، حاول لاحقاً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 200);
        }

        private void squareTblBindingNavigatorExportToExcelItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog exportDlg = new SaveFileDialog() { Filter = "Excel workbook (2007-2022)(*.xlsx)|*.xlsx", FileName = "الساحات" };
            if (exportDlg.ShowDialog() != DialogResult.OK)
                return;
            squareGridControl.ExportToXlsx(exportDlg.FileName, new DevExpress.XtraPrinting.XlsxExportOptions() { ShowGridLines = false, SheetName = "جدول الساحات" });
            mainAlertControl.Show(this, "تم تصدير بيانات الساحات إلى اكسل", StaticCode.ApplicationTitle);
            StaticCode.activeUserLogin.SessionActions += $"تصدير جدول الساحات - {DateTime.Now.AddDays(StaticCode.appOptions.ShiftDays).AddSeconds(StaticCode.appOptions.ShiftSeconds)}\r\n";
        }
    }
}