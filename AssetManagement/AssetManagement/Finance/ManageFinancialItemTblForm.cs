using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.Finance
{
    public partial class ManageFinancialItemTblForm : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        int currRow = -1;
        public ManageFinancialItemTblForm()
        {
            InitializeComponent();
        }

        void UpdateTotals(IQueryable<FinancialItemVw> qryToGetTotals)
        {
            totalsDataGridView.Rows.Clear();
            List<string> currenciesList = StaticCode.mainDbContext.CurrencyTbls.Select(cu1 => cu1.CurrencyName).ToList();
            foreach (string oneCu in currenciesList)
            {
                var qryToGetTotals_OneCurr = qryToGetTotals.Where(fiv1 => fiv1.العملة == oneCu).GetTotalFinancialTableOfLevel_Default();
                totalsDataGridView.Rows.Add(new object[] { oneCu, qryToGetTotals_OneCurr.CalcIncomingOfFinancialItems(), qryToGetTotals_OneCurr.CalcOutgoingOfFinancialItems(), qryToGetTotals_OneCurr.CalcRecycledOfFinancialItems() });
            }
        }

        void UpdateTotalsAsFiltered()
        {
            List<int> IDsVisible = new List<int>();
            for (int i = 0; i < financialItemGridView.RowCount; i++)
            {
                IDsVisible.Add(Convert.ToInt32(financialItemGridView.GetRowCellValue(i, colمعرفالسجلالمالي)));
            }
            var fiVAsFiltered = StaticCode.mainDbContext.FinancialItemVws.Where(fiv1 => IDsVisible.Contains(fiv1.معرف_السجل_المالي));
            UpdateTotals(fiVAsFiltered);
        }

        private void ManageFinancialItemTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.FinancialItemVw' table. You can move, or remove it, as needed.
            this.financialItemVwTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemVw);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SubDepartmentTbl' table. You can move, or remove it, as needed.
            this.subDepartmentTblTableAdapter.Fill(this.assetMngDbDataSet.SubDepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.DepartmentTbl' table. You can move, or remove it, as needed.
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.CurrencyTbl' table. You can move, or remove it, as needed.
            this.currencyTblTableAdapter.Fill(this.assetMngDbDataSet.CurrencyTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.FinancialItemTbl' table. You can move, or remove it, as needed.
            this.financialItemTblTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.FinancialItemCategoryTbl' table. You can move, or remove it, as needed.
            this.financialItemCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemCategoryTbl);

            financialItemCategoryGridControl.EmbeddedNavigator.Buttons.Remove.Visible = bindingNavigatorDeleteItem.Visible = StaticCode.activeUserRole.DeleteFinancialItemRecord == true;
            financialItemCategoryGridControl.EmbeddedNavigator.Buttons.Edit.Visible =
                financialItemCategoryGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = financialItemTblBindingNavigatorSaveItem.Visible = StaticCode.activeUserRole.UpdateExistedFinancialItem == true;
            financialItemCategoryGridControl.EmbeddedNavigator.Buttons.Append.Visible =
            financialItemCategoryGridControl.EmbeddedNavigator.Buttons.Remove.Visible = false;
            editFinancialItemBarButtonItem.Visibility = (StaticCode.activeUserRole.UpdateExistedFinancialItem == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            deleteFinancialItemBarButtonItem.Visibility = (StaticCode.activeUserRole.DeleteFinancialItemRecord == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;

            this.UpdateTotals(StaticCode.mainDbContext.FinancialItemVws);

            this.MinimumSize = this.Size;
        }

        private void financialItemTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            financialItemTblBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
            mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 500);
        }

        private void financialItemGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            currRow = e.RowHandle;
        }

        private void financialItemGridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            currRow = e.RowHandle;
        }

        private void editFinancialItemBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (currRow < 0)
            {
                mainAlertControl.Show(this, "اختر سطراً كاملاً ليتم تعديل بياناته", StaticCode.ApplicationTitle);
                return;
            }
            try
            {
                int currAssetID = Convert.ToInt32(financialItemGridView.GetRowCellValue(currRow, colمعرفالسجلالمالي));
                AddNewFinancialItemForm cardVwFrm = new AddNewFinancialItemForm(currAssetID);
                cardVwFrm.ShowDialog();
                currRow = 0;
                this.financialItemVwTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemVw);
                //this.financialItemTblTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemTbl);
                this.UpdateTotalsAsFiltered();
                //mainAlertControl.Show(this, "تم تعديل السجل المالي", StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "اختر سطراً كاملاً ليتم تعديل بياناته", StaticCode.ApplicationTitle);
            }
        }

        private void deleteFinancialItemBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("للتذكير أن سجل الصادر المعلق عادة ما يرتبط بسجل وارد من المستوى الأعلى والعكس صحيح، هل تريد بالتأكيد حذف السجل الحالي وأي سجل متعلق به في حال وجوده؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            if (currRow < 0)
            {
                mainAlertControl.Show(this, "اختر سطراً كاملاً ليتم تعديل بياناته", StaticCode.ApplicationTitle);
                return;
            }
            try
            {
                int currFiItID = Convert.ToInt32(financialItemGridView.GetRowCellValue(currRow, colمعرفالسجلالمالي));
                FinancialItemTbl recToDelte = StaticCode.mainDbContext.FinancialItemTbls.Single(fii1 => fii1.ID == currFiItID);
                StaticCode.mainDbContext.FinancialItemTbls.DeleteOnSubmit(recToDelte);
                int relevantRecordID = recToDelte.FindRelevantFinancialItem();
                if (relevantRecordID > 0)
                {
                    FinancialItemTbl relevantRecToDelte = StaticCode.mainDbContext.FinancialItemTbls.Single(fii1 => fii1.ID == relevantRecordID);
                    StaticCode.mainDbContext.FinancialItemTbls.DeleteOnSubmit(relevantRecToDelte);
                }
                StaticCode.mainDbContext.SubmitChanges();
                currRow = 0;
                this.financialItemVwTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemVw);
                UpdateTotalsAsFiltered();
                string deleteSuccessMsg = "تم حذف السجل المالي";
                if (relevantRecordID > 0)
                    deleteSuccessMsg += " وسجل إضافي مرتبط به";
                mainAlertControl.Show(this, deleteSuccessMsg, StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "اختر سطراً كاملاً ليتم تعديل بياناته", StaticCode.ApplicationTitle);
            }
        }

        private void mainTabFormControl_Click(object sender, EventArgs e)
        {

        }

        private void financialItemGridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            UpdateTotalsAsFiltered();
        }

        private void openFinancialItemFolderBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (currRow < 0)
            {
                mainAlertControl.Show(this, "اختر سطراً واحداً فقط", StaticCode.ApplicationTitle);
                return;
            }
            try
            {
                int currFiItID = Convert.ToInt32(financialItemGridView.GetRowCellValue(currRow, colمعرفالسجلالمالي));
                string fiItCode = StaticCode.mainDbContext.FinancialItemTbls.Single(fiit1 => fiit1.ID == currFiItID).FinancialItemCode;
                string fiItFolder = StaticCode.FinancialItemsAttachmentsFolder + fiItCode + "//";
                if (!Directory.Exists(fiItFolder))
                    Directory.CreateDirectory(fiItFolder);
                Process.Start(fiItFolder);
            }
            catch
            {
                mainAlertControl.Show(this, "اختر سجلاً واحداً فقط", StaticCode.ApplicationTitle);
            }
        }

        private void addFilesToFinancialItemFolderBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                int currFiItID = Convert.ToInt32(financialItemGridView.GetRowCellValue(currRow, colمعرفالسجلالمالي));
                string fiItCode = StaticCode.mainDbContext.FinancialItemTbls.Single(fiit1 => fiit1.ID == currFiItID).FinancialItemCode;
                string fiItFolder = StaticCode.FinancialItemsAttachmentsFolder + fiItCode + "//";
                if (!Directory.Exists(fiItFolder))
                    Directory.CreateDirectory(fiItFolder);
                foreach (string oneFile in assetOFD.FileNames)
                {
                    File.Copy(oneFile, fiItFolder + Path.GetFileName(oneFile), true);
                }
                mainAlertControl.Show(this, $"تم إضافة ({assetOFD.FileNames.Count()}) مرفق/ات", StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "اختر سجلاً واحداً فقط", StaticCode.ApplicationTitle);
            }
        }
    }
}