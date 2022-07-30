using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.Assets
{
    public partial class ManageAssetTblForm : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        int currRow = -1;
        public ManageAssetTblForm()
        {
            InitializeComponent();
        }

        private void ManageAssetTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.EstateAreaUnitTbl' table. You can move, or remove it, as needed.
            this.estateAreaUnitTblTableAdapter.Fill(this.assetMngDbDataSet.EstateAreaUnitTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.StatusTbl' table. You can move, or remove it, as needed.
            this.statusTblTableAdapter.Fill(this.assetMngDbDataSet.StatusTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.CurrencyTbl' table. You can move, or remove it, as needed.
            this.currencyTblTableAdapter.Fill(this.assetMngDbDataSet.CurrencyTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SquareTbl' table. You can move, or remove it, as needed.
            this.squareTblTableAdapter.Fill(this.assetMngDbDataSet.SquareTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.DepartmentTbl' table. You can move, or remove it, as needed.
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SectionTbl' table. You can move, or remove it, as needed.
            this.sectionTblTableAdapter.Fill(this.assetMngDbDataSet.SectionTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetVw' table. You can move, or remove it, as needed.
            this.assetVwTableAdapter.Fill(this.assetMngDbDataSet.AssetVw);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.MainCategoryTbl' table. You can move, or remove it, as needed.
            this.mainCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MainCategoryTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.MinorCategoryTbl' table. You can move, or remove it, as needed.
            this.minorCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MinorCategoryTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetTbl' table. You can move, or remove it, as needed.
            this.assetTblTableAdapter.Fill(this.assetMngDbDataSet.AssetTbl);

            this.MinimumSize = this.Size;

            assetGridControl.EmbeddedNavigator.Buttons.Edit.Visible = assetGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = StaticCode.activeUserRole.UpdateExistedAsset == true;
            saveChangesBarButtonItem.Visibility = (StaticCode.activeUserRole.UpdateExistedAsset == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            assetGridControl.EmbeddedNavigator.Buttons.Remove.Visible = StaticCode.activeUserRole.DeleteAssetRecord == true;
        }

        private void assetGridView_AfterPrintRow(object sender, DevExpress.XtraGrid.Views.Printing.PrintRowEventArgs e)
        {

        }

        private void assetGridView_AsyncCompleted(object sender, EventArgs e)
        {

        }

        private void assetGridView_RowLoaded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {

        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {

        }

        private void saveChangesBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Validate();
            assetTblBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
            mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
        }

        private void exportToExcelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog exportDlg = new SaveFileDialog() { Filter = "Excel workbook (2007-2022)(*.xlsx)|*.xlsx" };
            if (exportDlg.ShowDialog() != DialogResult.OK)
                return;
            assetGridControl.ExportToXlsx(exportDlg.FileName, new DevExpress.XtraPrinting.XlsxExportOptions() { ShowGridLines = false, SheetName = "جدول الأصول" });
            mainAlertControl.Show(this, "تم تصدير بيانات الأصول إلى اكسل", StaticCode.ApplicationTitle);
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 500);
        }

        private void showAssetCardBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int currAssetID = Convert.ToInt32(assetTblGridView.GetRowCellValue(currRow, colID));
                AssetCardViewForm cardVwFrm = new AssetCardViewForm(currAssetID);
                cardVwFrm.ShowDialog();
                currRow = 0;
            }
            catch
            {
                mainAlertControl.Show(this, "اختر سجلاً واحداً ليتم عرض بطاقته", StaticCode.ApplicationTitle);
            }
        }

        private void assetTblGridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            currRow = e.RowHandle;
        }

        private void assetTblGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            currRow = e.RowHandle;
        }

        private void assetTblGridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            currRow = e.ControllerRow;
        }
    }
}