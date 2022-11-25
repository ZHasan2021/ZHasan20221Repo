using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AssetManagement.AssetMngDbDataSet;

namespace AssetManagement.Assets
{
    public partial class ManageAssetTblForm : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        int currRow = -1;
        IQueryable<AssetTbl> customDS = null;
        public ManageAssetTblForm()
        {
            InitializeComponent();
        }

        public ManageAssetTblForm(IQueryable<AssetTbl> customDS)
        {
            InitializeComponent();
            this.customDS = customDS;
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

            assetGridControl.EmbeddedNavigator.Buttons.Append.Visible = StaticCode.activeUserRole.AddNewAsset == true;
            editDataBarButtonItem.Visibility = (StaticCode.activeUserRole.UpdateExistedAsset == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            assetGridControl.EmbeddedNavigator.Buttons.Edit.Visible = assetGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = StaticCode.activeUserRole.UpdateExistedAsset == true;
            deleteAssetBarButtonItem.Visibility = (StaticCode.activeUserRole.DeleteAssetRecord == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            saveChangesBarButtonItem.Visibility = (StaticCode.activeUserRole.UpdateExistedAsset == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            assetGridControl.EmbeddedNavigator.Buttons.Remove.Visible = StaticCode.activeUserRole.DeleteAssetRecord == true;
            assetGridControl.EmbeddedNavigator.Buttons.Append.Visible = false;
            saveChangesBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            if (customDS != null)
            {
                List<int> IDsIncluded = customDS.Select(as1 => as1.ID).ToList();
                string plusQry = "";
                if (IDsIncluded.Count() == 0)
                    plusQry = " WHERE 1 > 2;";
                else
                {
                    foreach (int oneID in IDsIncluded)
                        plusQry += oneID + ", ";
                    plusQry = $" WHERE [معرف الأصل] IN ({ plusQry.Trim().Trim(',').Trim()});";
                }
                AssetVwDataTable customVw = this.assetMngDbDataSet.AssetVw;
                for (int i = 0; i < customVw.Rows.Count; i++)
                {
                    try
                    {
                        var oneRow = customVw.Rows[i];
                        object[] oneRowItemArray = oneRow.ItemArray;
                        if (IDsIncluded.IndexOf(Convert.ToInt32(oneRowItemArray[0])) == -1)
                            customVw.Rows.Remove(oneRow);
                    }
                    catch
                    {
                        this.assetVwTableAdapter.FillByQuery(customVw, " WHERE 1 > 2;");
                        return;
                    }
                }
                this.assetVwTableAdapter.FillByQuery(customVw, plusQry);
            }
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
            assetVwBindingSource.EndEdit();
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
            if (currRow < 0)
            {
                mainAlertControl.Show(this, "اختر سطراً كاملاً ليتم عرض بطاقته", StaticCode.ApplicationTitle);
                return;
            }
            try
            {
                int currAssetID = Convert.ToInt32(assetGridView.GetRowCellValue(currRow, colمعرفالأصل));
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

        private void editDataBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (currRow < 0)
            {
                mainAlertControl.Show(this, "اختر سطراً كاملاً ليتم تعديل بياناته", StaticCode.ApplicationTitle);
                return;
            }
            try
            {
                int currAssetID = Convert.ToInt32(assetGridView.GetRowCellValue(currRow, colمعرفالأصل));
                UpdateExistedAssetForm cardVwFrm = new UpdateExistedAssetForm(currAssetID);
                cardVwFrm.ShowDialog();
                currRow = 0;
                this.assetVwTableAdapter.Fill(this.assetMngDbDataSet.AssetVw);
                this.assetTblTableAdapter.Fill(this.assetMngDbDataSet.AssetTbl);
            }
            catch
            {
                mainAlertControl.Show(this, "اختر سجلاً واحداً ليتم تعديل بياناته", StaticCode.ApplicationTitle);
            }
        }

        private void toolbarFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void deleteAssetBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (currRow < 0)
            {
                mainAlertControl.Show(this, "اختر سطراً واحداً فقط", StaticCode.ApplicationTitle);
                return;
            }
            try
            {
                int currAssetID = Convert.ToInt32(assetGridView.GetRowCellValue(currRow, colمعرفالأصل));
                DeleteAssetForm cardVwFrm = new DeleteAssetForm(currAssetID);
                cardVwFrm.ShowDialog();
                currRow = 0;
                this.assetVwTableAdapter.Fill(this.assetMngDbDataSet.AssetVw);
                this.assetTblTableAdapter.Fill(this.assetMngDbDataSet.AssetTbl);
            }
            catch
            {
                mainAlertControl.Show(this, "اختر سجلاً واحداً فقط", StaticCode.ApplicationTitle);
            }
        }

        private void assetGridView_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}