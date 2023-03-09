using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
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
        int cardType = 0;
        IQueryable<AssetTbl> customDS = null;
        string optionalFormTitle = "";
        IQueryable<AssetTbl> filteredAssets = null;

        void LoadAssets()
        {
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

        public ManageAssetTblForm()
        {
            InitializeComponent();
        }

        public ManageAssetTblForm(IQueryable<AssetTbl> customDS, string formTitle = "")
        {
            InitializeComponent();
            this.customDS = customDS;
            optionalFormTitle = formTitle;
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
            moveAllBarButtonItem.Visibility = (StaticCode.activeUserRole.AddNewAssetMovement == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            LoadAssets();
            if (optionalFormTitle != "")
            {
                this.Text = optionalFormTitle;
                destructBarButtonItem.Visibility = destructAllBarButtonItem.Visibility = getAssetsOutOfWorkBarCheckItem.Visibility = (StaticCode.activeUserRole.AddNewAssetTransaction == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
                moveAllBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            assetGridView_ColumnFilterChanged(sender, e);
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
                AssetCardViewForm cardVwFrm = new AssetCardViewForm(currAssetID, cardType);
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
            var ff = e.Column;
            var aaa = e.CellValue;
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
                StaticCode.mainDbContext = new AssetMngDbDataContext();
                GC.Collect();
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

        private void destructBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من ذلك؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            var ihlakTrnsType = StaticCode.mainDbContext.TransactionTypeTbls.Where(tt1 => tt1.TransactionTypeName == "إهلاك");
            if (!ihlakTrnsType.Any())
            {
                mainAlertControl.Show(this, "نوع التصريف (إهلاك) غير موجود في جدول أنواع التصريف، قم بإضافته أولاً لكي تستطيع المتابعة في عملية التصريف الحالية", StaticCode.ApplicationTitle);
                return;
            }

            try
            {
                AssetTbl assetToTransact = StaticCode.mainDbContext.AssetTbls.Single(ast1 => ast1.ID == Convert.ToInt32(assetGridView.GetRowCellValue(currRow, colمعرفالأصل)));
                StaticCode.mainDbContext.AssetTransactionTbls.InsertOnSubmit(new AssetTransactionTbl()
                {
                    AssetID = assetToTransact.ID,
                    TransactionDate = DateTime.Today.AddDays(StaticCode.appOptions.ShiftDays),
                    TransactionType = ihlakTrnsType.First().ID,
                    GetAssetOutOfWork = getAssetsOutOfWorkBarCheckItem.Checked,
                    MoneyAmount = 0,
                    MoneyAmountCurrency = 1,
                    CurrentPriceWithDestroying = 0,
                    QuantityTransacted = assetToTransact.ItemsQuantity,
                    TransactionNotes = $"تم إهلاك ({assetToTransact.ItemsQuantity}) من الأصل",
                });
                assetToTransact.IsOutOfWork = getAssetsOutOfWorkBarCheckItem.Checked;
                if (getAssetsOutOfWorkBarCheckItem.Checked)
                    assetToTransact.ItemsQuantity = 0;
                assetToTransact.AssetNotes += $"[تم إهلاك ({assetToTransact.ItemsQuantity}) من الأصل]";
                StaticCode.mainDbContext.SubmitChanges();
                mainAlertControl.Show(this, "تم إهلاك الأصل" + ((getAssetsOutOfWorkBarCheckItem.Checked) ? " وإخراجه من الخدمة" : ""), StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "لم يتم إهلاك الأصل", StaticCode.ApplicationTitle);
            }
        }

        private void destructAllBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من ذلك؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            var ihlakTrnsType = StaticCode.mainDbContext.TransactionTypeTbls.Where(tt1 => tt1.TransactionTypeName == "إهلاك");
            if (!ihlakTrnsType.Any())
            {
                mainAlertControl.Show(this, "نوع التصريف (إهلاك) غير موجود في جدول أنواع التصريف، قم بإضافته أولاً لكي تستطيع المتابعة في عملية التصريف الحالية", StaticCode.ApplicationTitle);
                return;
            }

            try
            {
                for (int i = 0; i < assetGridView.RowCount; i++)
                {
                    Application.DoEvents();

                    AssetTbl assetToTransact = StaticCode.mainDbContext.AssetTbls.Single(ast1 => ast1.ID == Convert.ToInt32(assetGridView.GetRowCellValue(i, colمعرفالأصل)));
                    StaticCode.mainDbContext.AssetTransactionTbls.InsertOnSubmit(new AssetTransactionTbl()
                    {
                        AssetID = assetToTransact.ID,
                        TransactionDate = DateTime.Today.AddDays(StaticCode.appOptions.ShiftDays),
                        TransactionType = ihlakTrnsType.First().ID,
                        GetAssetOutOfWork = getAssetsOutOfWorkBarCheckItem.Checked,
                        MoneyAmount = 0,
                        MoneyAmountCurrency = 1,
                        CurrentPriceWithDestroying = 0,
                        QuantityTransacted = assetToTransact.ItemsQuantity,
                        TransactionNotes = $"تم إهلاك ({assetToTransact.ItemsQuantity}) من الأصل",
                    });
                    assetToTransact.IsOutOfWork = getAssetsOutOfWorkBarCheckItem.Checked;
                    if (getAssetsOutOfWorkBarCheckItem.Checked)
                        assetToTransact.ItemsQuantity = 0;
                    assetToTransact.AssetNotes += $"[تم إهلاك ({assetToTransact.ItemsQuantity}) من الأصل]";
                }
                StaticCode.mainDbContext.SubmitChanges();
                mainAlertControl.Show(this, $"تم إهلاك ({assetGridView.RowCount}) أصل / أصول {((getAssetsOutOfWorkBarCheckItem.Checked) ? " وإخراجها من الخدمة" : "")}", StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "لم يتم إهلاك الأصول", StaticCode.ApplicationTitle);
            }
        }

        private void moveAllBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MoveAllAssetsForm mvAllFrm = new MoveAllAssetsForm(filteredAssets);
            mvAllFrm.ShowDialog();
            LoadAssets();
        }

        private void assetGridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            List<int> IDsVisible = new List<int>();
            for (int i = 0; i < assetGridView.RowCount; i++)
            {
                IDsVisible.Add(Convert.ToInt32(assetGridView.GetRowCellValue(i, colمعرفالأصل)));
            }
            filteredAssets = StaticCode.mainDbContext.AssetTbls.Where(asv1 => IDsVisible.Contains(asv1.ID));
        }

        private void openAssetFolderBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (currRow < 0)
            {
                mainAlertControl.Show(this, "اختر سطراً واحداً فقط", StaticCode.ApplicationTitle);
                return;
            }
            try
            {
                int currAssetID = Convert.ToInt32(assetGridView.GetRowCellValue(currRow, colمعرفالأصل));
                string assetCode = assetGridView.GetRowCellValue(currRow, colكودالأصل).ToString();
                string assetFolder = StaticCode.AssetsAttachmentsFolder + assetCode + "//";
                if (!Directory.Exists(assetFolder))
                    Directory.CreateDirectory(assetFolder);
                Process.Start(assetFolder);
            }
            catch
            {
                mainAlertControl.Show(this, "اختر سجلاً واحداً فقط", StaticCode.ApplicationTitle);
            }
        }

        private void addFilesToAssetFolderBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (currRow < 0)
            {
                mainAlertControl.Show(this, "اختر سطراً واحداً فقط", StaticCode.ApplicationTitle);
                return;
            }
            try
            {
                OpenFileDialog assetOFD = new OpenFileDialog();
                assetOFD.Multiselect = true;
                if (assetOFD.ShowDialog() != DialogResult.OK)
                    return;
                int currAssetID = Convert.ToInt32(assetGridView.GetRowCellValue(currRow, colمعرفالأصل));
                string assetCode = assetGridView.GetRowCellValue(currRow, colكودالأصل).ToString();
                string assetFolder = StaticCode.AssetsAttachmentsFolder + assetCode + "//";
                if (!Directory.Exists(assetFolder))
                    Directory.CreateDirectory(assetFolder);
                foreach (string oneFile in assetOFD.FileNames)
                {
                    File.Copy(oneFile, assetFolder + Path.GetFileName(oneFile), true);
                }
                mainAlertControl.Show(this, $"تم إضافة ({assetOFD.FileNames.Count()}) مرفق/ات", StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "اختر سجلاً واحداً فقط", StaticCode.ApplicationTitle);
            }
        }

        private void generalCardBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cardType = 1;
            showAssetCardBarButtonItem_ItemClick(sender, e);
        }

        private void estatesCardBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cardType = 2;
            showAssetCardBarButtonItem_ItemClick(sender, e);
        }

        private void vehiclesCardBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cardType = 3;
            showAssetCardBarButtonItem_ItemClick(sender, e);
        }
    }
}