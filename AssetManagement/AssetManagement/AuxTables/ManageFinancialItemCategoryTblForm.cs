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
    public partial class ManageFinancialItemCategoryTblForm : Form
    {
        public ManageFinancialItemCategoryTblForm()
        {
            InitializeComponent();
        }

        private void ManageFinancialItemCategoryTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.FinancialItemCategoryTbl' table. You can move, or remove it, as needed.
            this.financialItemCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemCategoryTbl);

            financialItemCategoryGridControl.EmbeddedNavigator.Buttons.Append.Visible = StaticCode.activeUserRole.AddNewFinancialItemCategory == true;

            this.MinimumSize = this.Size;
        }

        private void financialItemCategoryTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                financialItemCategoryTblBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
                mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
                StaticCode.activeUserLogin.SessionActions += $"تعديل في جدول البنود المالية - {DateTime.Now.AddDays(StaticCode.appOptions.ShiftDays).AddSeconds(StaticCode.appOptions.ShiftSeconds)}\r\n";
            }
            catch (SqlException)
            {
                mainAlertControl.Show(this, StaticCode.ApplicationTitle, "بعض السجلات التي حذفتها مرتبطة بسجلات فرعية ضمن سجلات السجلات المالية، لذا لا يمكن حذفها حالياً");
                MessageBox.Show("بعض السجلات التي حذفتها مرتبطة بسجلات فرعية ضمن سجلات السجلات المالية، لذا لا يمكن حذفها حالياً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch
            {
                mainAlertControl.Show(this, StaticCode.ApplicationTitle, "لم يتم الحفظ، حاول لاحقاً");
                MessageBox.Show("لم يتم الحفظ، حاول لاحقاً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void financialItemCategoryTblBindingNavigatorExportToExcelItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog exportDlg = new SaveFileDialog() { Filter = "Excel workbook (2007-2022)(*.xlsx)|*.xlsx", FileName = "البنود المالية" };
            if (exportDlg.ShowDialog() != DialogResult.OK)
                return;
            financialItemCategoryGridControl.ExportToXlsx(exportDlg.FileName, new DevExpress.XtraPrinting.XlsxExportOptions() { ShowGridLines = false, SheetName = "جدول البنود المالية" });
            mainAlertControl.Show(this, "تم تصدير بيانات البنود المالية إلى اكسل", StaticCode.ApplicationTitle);
            StaticCode.activeUserLogin.SessionActions += $"تصدير جدول البنود المالية - {DateTime.Now.AddDays(StaticCode.appOptions.ShiftDays).AddSeconds(StaticCode.appOptions.ShiftSeconds)}\r\n";
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 150);
            e.AlertForm.Location = new Point(200, 200);
        }
    }
}