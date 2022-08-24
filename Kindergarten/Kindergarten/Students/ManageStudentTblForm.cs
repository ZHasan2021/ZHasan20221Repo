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
    public partial class ManageStudentTblForm : DevExpress.XtraBars.TabForm
    {
        int currRow = -1;

        public ManageStudentTblForm()
        {
            InitializeComponent();
        }

        private void ManageStudentTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kindergartenDbDataSet.EducationalLevelTbl' table. You can move, or remove it, as needed.
            this.educationalLevelTblTableAdapter.Fill(this.kindergartenDbDataSet.EducationalLevelTbl);
            // TODO: This line of code loads data into the 'kindergartenDbDataSet.ScholasticYearTbl' table. You can move, or remove it, as needed.
            this.scholasticYearTblTableAdapter.Fill(this.kindergartenDbDataSet.ScholasticYearTbl);
            // TODO: This line of code loads data into the 'kindergartenDbDataSet.StudentTbl' table. You can move, or remove it, as needed.
            this.studentTblTableAdapter.Fill(this.kindergartenDbDataSet.StudentTbl);

            studentGridControl.EmbeddedNavigator.Buttons.Edit.Visible = studentGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = StaticCode.activeUserRole.UpdateExistedStudent == true;
            saveChangesBarButtonItem.Visibility = (StaticCode.activeUserRole.UpdateExistedStudent == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            studentGridControl.EmbeddedNavigator.Buttons.Remove.Visible = StaticCode.activeUserRole.DeleteStudentRecord == true;
        }

        private void saveChangesBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Validate();
            studentTblBindingSource.EndEdit();
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
                int currAssetID = Convert.ToInt32(studentGridView.GetRowCellValue(currRow, colID));
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
            studentGridControl.ExportToXlsx(exportDlg.FileName, new DevExpress.XtraPrinting.XlsxExportOptions() { ShowGridLines = false, SheetName = "جدول الطلاب" });
            mainAlertControl.Show(this, "تم تصدير بيانات الطلاب إلى اكسل", StaticCode.ApplicationTitle);
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