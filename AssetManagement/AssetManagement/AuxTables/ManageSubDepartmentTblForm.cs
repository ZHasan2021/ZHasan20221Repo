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
                departmentTblBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
                mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
                StaticCode.activeUserLogin.SessionActions += $"تعديل في جدول الوحدات - {DateTime.Now.AddDays(StaticCode.appOptions.ShiftDays).AddSeconds(StaticCode.appOptions.ShiftSeconds)}\r\n";
            }
            catch (SqlException)
            {
                mainAlertControl.Show(this, StaticCode.ApplicationTitle, "بعض السجلات التي حذفتها مرتبطة بسجلات فرعية ضمن سجلات الأصول والسجلات المالية، لذا لا يمكن حذفها حالياً");
                MessageBox.Show("بعض السجلات التي حذفتها مرتبطة بسجلات فرعية ضمن سجلات الأصول والسجلات المالية، لذا لا يمكن حذفها حالياً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch
            {
                mainAlertControl.Show(this, "هناك تكرار في أسماء الوحدات، أزل التكرار أولاً", StaticCode.ApplicationTitle);
                return;
            }
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 150);
            e.AlertForm.Location = new Point(200, 200);
        }

        private void subDepartmentTblBindingNavigatorExportToExcelItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog exportDlg = new SaveFileDialog() { Filter = "Excel workbook (2007-2022)(*.xlsx)|*.xlsx", FileName = "الوحدات" };
            if (exportDlg.ShowDialog() != DialogResult.OK)
                return;
            subDepartmentGridControl.ExportToXlsx(exportDlg.FileName, new DevExpress.XtraPrinting.XlsxExportOptions() { ShowGridLines = false, SheetName = "جدول الوحدات" });
            mainAlertControl.Show(this, "تم تصدير بيانات الوحدات إلى اكسل", StaticCode.ApplicationTitle);
            StaticCode.activeUserLogin.SessionActions += $"تصدير جدول الوحدات - {DateTime.Now.AddDays(StaticCode.appOptions.ShiftDays).AddSeconds(StaticCode.appOptions.ShiftSeconds)}\r\n";
        }
    }
}