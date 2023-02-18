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
    public partial class ManageMinorCategoryTblForm : Form
    {
        public ManageMinorCategoryTblForm()
        {
            InitializeComponent();
        }

        private void ManageMinorCategoryTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.MainCategoryTbl' table. You can move, or remove it, as needed.
            this.mainCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MainCategoryTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.MinorCategoryTbl' table. You can move, or remove it, as needed.
            this.minorCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MinorCategoryTbl);

            minorCategoryGridControl.EmbeddedNavigator.Buttons.Append.Visible = StaticCode.activeUserRole.AddNewMinorCategory == true;

            this.MinimumSize = this.Size;
        }

        private void minorCategoryTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                minorCategoryTblBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
                mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
            }
            catch (SqlException)
            {
                mainAlertControl.Show(this, StaticCode.ApplicationTitle, "بعض السجلات التي حذفتها مرتبطة بسجلات فرعية في جداول الفئات الفرعية وكذلك ضمن سجلات الأصول، لذا لا يمكن حذفها حالياً");
                MessageBox.Show("بعض السجلات التي حذفتها مرتبطة بسجلات فرعية في جداول الفئات الفرعية وكذلك ضمن سجلات الأصول، لذا لا يمكن حذفها حالياً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch
            {
                mainAlertControl.Show(this, StaticCode.ApplicationTitle, "لم يتم الحفظ، حاول لاحقاً");
                MessageBox.Show("لم يتم الحفظ، حاول لاحقاً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void minorCategoryTblBindingNavigatorExportToExcelItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog exportDlg = new SaveFileDialog() { Filter = "Excel workbook (2007-2022)(*.xlsx)|*.xlsx", FileName = "الفئات الفرعية" };
            if (exportDlg.ShowDialog() != DialogResult.OK)
                return;
            minorCategoryGridControl.ExportToXlsx(exportDlg.FileName, new DevExpress.XtraPrinting.XlsxExportOptions() { ShowGridLines = false, SheetName = "جدول الفئات الفرعية" });
            mainAlertControl.Show(this, "تم تصدير بيانات الفئات الفرعية إلى اكسل", StaticCode.ApplicationTitle);
        }
        private void minorCategoryTblBindingNavigatorManageMainCategoriesItem_Click(object sender, EventArgs e)
        {
            ManageMainCategoryTblForm maca = new ManageMainCategoryTblForm();
            maca.ShowDialog();
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 150);
            e.AlertForm.Location = new Point(200, 200);
        }

        private void manageMinorCategoryTblToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}