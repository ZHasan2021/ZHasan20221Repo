using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.Finance
{
    public partial class ManageFinancialItemTblForm : DevExpress.XtraBars.TabForm
    {
        int currRow = -1;
        public ManageFinancialItemTblForm()
        {
            InitializeComponent();
        }

        void UpdateTotals()
        {
            var incomingUSD = StaticCode.mainDbContext.FinancialItemVws.Where(fiv1 => fiv1.العملة == "دولار أمريكي" && fiv1.وارد_أم_صادر == "وارد");
            double incomingUSD_Am = 0;
            if (incomingUSD != null && incomingUSD.Count() > 0)
                incomingUSD_Am = incomingUSD.Sum(fiv2 => fiv2.المبلغ_الوارد);
            var incomingEUR = StaticCode.mainDbContext.FinancialItemVws.Where(fiv1 => fiv1.العملة == "يورو أوروبي" && fiv1.وارد_أم_صادر == "وارد");
            double incomingEUR_Am = 0;
            if (incomingEUR != null && incomingEUR.Count() > 0)
                incomingEUR_Am = incomingEUR.Sum(fiv2 => fiv2.المبلغ_الوارد);
            var incomingSYP = StaticCode.mainDbContext.FinancialItemVws.Where(fiv1 => fiv1.العملة == "ليرة تركية" && fiv1.وارد_أم_صادر == "وارد");
            double incomingSYP_Am = 0;
            if (incomingSYP != null && incomingSYP.Count() > 0)
                incomingSYP_Am = incomingSYP.Sum(fiv2 => fiv2.المبلغ_الوارد);
            var outgoingUSD = StaticCode.mainDbContext.FinancialItemVws.Where(fiv1 => fiv1.العملة == "دولار أمريكي" && fiv1.وارد_أم_صادر == "صادر");
            double outgoingUSD_Am = 0;
            if (outgoingUSD != null && outgoingUSD.Count() > 0)
                outgoingUSD_Am = outgoingUSD.Sum(fiv2 => fiv2.المبلغ_الصادر);
            var outgoingEUR = StaticCode.mainDbContext.FinancialItemVws.Where(fiv1 => fiv1.العملة == "يورو أوروبي" && fiv1.وارد_أم_صادر == "صادر");
            double outgoingEUR_Am = 0;
            if (outgoingEUR != null && outgoingEUR.Count() > 0)
                outgoingEUR_Am = outgoingEUR.Sum(fiv2 => fiv2.المبلغ_الصادر);
            var outgoingSYP = StaticCode.mainDbContext.FinancialItemVws.Where(fiv1 => fiv1.العملة == "ليرة تركية" && fiv1.وارد_أم_صادر == "صادر");
            double outgoingSYP_Am = 0;
            if (outgoingSYP != null && outgoingSYP.Count() > 0)
                outgoingSYP_Am = outgoingSYP.Sum(fiv2 => fiv2.المبلغ_الصادر);

            incomesInUSDToolStripStatusLabel.Text = $"مجموع الواردات بالدولار: {incomingUSD_Am}";
            incomesInEURToolStripStatusLabel.Text = $"مجموع الواردات باليورو: {incomingEUR_Am}";
            incomesInSYPToolStripStatusLabel.Text = $"مجموع الواردات بالليرة: {incomingSYP_Am}";
            outgoingInUSDToolStripStatusLabel.Text = $"مجموع الصادرات بالدولار: {outgoingUSD_Am}";
            outgoingInEURToolStripStatusLabel.Text = $"مجموع الصادرات باليورو: {outgoingEUR_Am}";
            outgoingInSYPToolStripStatusLabel.Text = $"مجموع الصادرات بالليرة: {outgoingSYP_Am}";
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

            this.UpdateTotals();

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
                this.financialItemTblTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemTbl);
                this.UpdateTotals();
            }
            catch
            {
                mainAlertControl.Show(this, "اختر سطراً كاملاً ليتم تعديل بياناته", StaticCode.ApplicationTitle);
            }
        }

        private void deleteFinancialItemBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("هل تريد بالتأكيد حذف السجل؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
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
                StaticCode.mainDbContext.SubmitChanges();
                currRow = 0;
                this.financialItemVwTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemVw);
                this.financialItemTblTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemTbl);
                mainAlertControl.Show(this, "تم حذف السجل المالي", StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "اختر سطراً كاملاً ليتم تعديل بياناته", StaticCode.ApplicationTitle);
            }
        }

        private void mainTabFormControl_Click(object sender, EventArgs e)
        {

        }
    }
}