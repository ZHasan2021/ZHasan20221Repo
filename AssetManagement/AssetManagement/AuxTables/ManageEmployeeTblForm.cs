using AssetManagement.Assets;
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
    public partial class ManageEmployeeTblForm : Form
    {
        int currRow = -1;

        public ManageEmployeeTblForm()
        {
            InitializeComponent();
        }

        private void ManageEmployeeTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.EmployeeTbl' table. You can move, or remove it, as needed.
            this.employeeTblTableAdapter.Fill(this.assetMngDbDataSet.EmployeeTbl);

            employeeGridControl.EmbeddedNavigator.Buttons.Append.Visible = StaticCode.activeUserRole.AddNewSquare == true;

            this.MinimumSize = this.Size;

            employeeTblBindingNavigatorViewCustodiesItem.Visible = StaticCode.activeUserRole.ViewEmployeeCustodies == true;
        }

        private void employeeTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                employeeTblBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
                mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
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

        private void employeeTblBindingNavigatorExportToExcelItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog exportDlg = new SaveFileDialog() { Filter = "Excel workbook (2007-2022)(*.xlsx)|*.xlsx", FileName = "الموظفين" };
            if (exportDlg.ShowDialog() != DialogResult.OK)
                return;
            employeeGridControl.ExportToXlsx(exportDlg.FileName, new DevExpress.XtraPrinting.XlsxExportOptions() { ShowGridLines = false, SheetName = "جدول الموظفين" });
            mainAlertControl.Show(this, "تم تصدير بيانات الموظفين إلى اكسل", StaticCode.ApplicationTitle);
        }

        private void employeeTblBindingNavigatorViewCustodiesItem_Click(object sender, EventArgs e)
        {
            if (currRow < 0)
            {
                mainAlertControl.Show(this, "اختر سطراً كاملاً ليتم تعديل بياناته", StaticCode.ApplicationTitle);
                return;
            }
            try
            {
                string currEmployeeFirstName = employeeGridView.GetRowCellValue(currRow, colFirstName).ToString().Trim();
                var employeeAssets = StaticCode.mainDbContext.AssetTbls.Where(ast1 => ast1.CustodianName == currEmployeeFirstName);
                ManageAssetTblForm desFrm1 = new ManageAssetTblForm(employeeAssets, "العهدات المستلمة من قبل الموظف " + employeeGridView.GetRowCellValue(currRow, colFirstName));
                desFrm1.ShowDialog();
                GC.Collect();
                currRow = 0;
            }
            catch
            {
                mainAlertControl.Show(this, "اختر سجلاً واحداً ليتم تعديل بياناته", StaticCode.ApplicationTitle);
            }
        }

        private void employeeGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            currRow = e.RowHandle;
        }

        private void employeeGridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            currRow = e.RowHandle;
        }
    }
}