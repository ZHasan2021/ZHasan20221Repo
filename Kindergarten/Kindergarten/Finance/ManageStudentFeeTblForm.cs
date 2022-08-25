using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kindergarten.Students
{
    public partial class ManageStudentFeeTblForm : DevExpress.XtraBars.TabForm
    {
        int currRow = -1;

        public ManageStudentFeeTblForm()
        {
            InitializeComponent();
        }

        private void ManageStudentFeeTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kindergartenDbDataSet.StudentTbl' table. You can move, or remove it, as needed.
            this.studentTblTableAdapter.Fill(this.kindergartenDbDataSet.StudentTbl);
            // TODO: This line of code loads data into the 'kindergartenDbDataSet.FeePeriodTbl' table. You can move, or remove it, as needed.
            this.feePeriodTblTableAdapter.Fill(this.kindergartenDbDataSet.FeePeriodTbl);
            // TODO: This line of code loads data into the 'kindergartenDbDataSet.StudentFeeTbl' table. You can move, or remove it, as needed.
            this.studentFeeTblTableAdapter.Fill(this.kindergartenDbDataSet.StudentFeeTbl);
            // TODO: This line of code loads data into the 'kindergartenDbDataSet.ScholasticYearTbl' table. You can move, or remove it, as needed.
            this.scholasticYearTblTableAdapter.Fill(this.kindergartenDbDataSet.ScholasticYearTbl);
            // TODO: This line of code loads data into the 'kindergartenDbDataSet.StudentTbl' table. You can move, or remove it, as needed.
            this.studentTblTableAdapter.Fill(this.kindergartenDbDataSet.StudentTbl);

            studentFeeGridControl.EmbeddedNavigator.Buttons.Edit.Visible = studentFeeGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = StaticCode.activeUserRole.UpdateExistedStudentFee == true;
            saveChangesBarButtonItem.Visibility = (StaticCode.activeUserRole.UpdateExistedStudentFee == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            studentFeeGridControl.EmbeddedNavigator.Buttons.Remove.Visible = StaticCode.activeUserRole.DeleteStudentFeeRecord == true;
        }

        private void saveChangesBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Validate();
            studentFeeTblBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.kindergartenDbDataSet);
            mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
        }

        private void viewCardBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (currRow < 0)
            {
                mainAlertControl.Show(this, "اختر سطراً كاملاً ليتم عرض بطاقته", StaticCode.ApplicationTitle);
                return;
            }
            try
            {
                int currAssetID = Convert.ToInt32(studentFeeGridView.GetRowCellValue(currRow, colID));
                //AssetCardViewForm cardVwFrm = new AssetCardViewForm(currAssetID);
                //cardVwFrm.ShowDialog();
                currRow = 0;
            }
            catch
            {
                mainAlertControl.Show(this, "اختر سجلاً واحداً ليتم عرض بطاقته", StaticCode.ApplicationTitle);
            }
        }

        private void exportToExcelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog exportDlg = new SaveFileDialog() { Filter = "Excel workbook (2007-2022)(*.xlsx)|*.xlsx" };
            if (exportDlg.ShowDialog() != DialogResult.OK)
                return;
            studentFeeGridControl.ExportToXlsx(exportDlg.FileName, new DevExpress.XtraPrinting.XlsxExportOptions() { ShowGridLines = false, SheetName = "جدول الطلاب" });
            mainAlertControl.Show(this, "تم تصدير بيانات الرسوم إلى اكسل", StaticCode.ApplicationTitle);
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 500);
        }

        private void studentGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            currRow = e.RowHandle;
        }

        private void studentGridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            currRow = e.RowHandle;
        }

        private void mainTabFormControl_Click(object sender, EventArgs e)
        {

        }
    }
}