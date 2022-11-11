using AssetManagement.AuxTables;
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
    public partial class TransacteAssetForm : Form
    {
        IQueryable<AssetMoveVw> srchRes = null;
        AssetMoveVw currSrchRes = null;
        AssetTbl assetToTransact = null;

        public TransacteAssetForm()
        {
            InitializeComponent();
        }

        private void TransacteAssetForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.CurrencyTbl' table. You can move, or remove it, as needed.
            this.currencyTblTableAdapter.Fill(this.assetMngDbDataSet.CurrencyTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.TransactionTypeTbl' table. You can move, or remove it, as needed.
            this.transactionTypeTblTableAdapter.Fill(this.assetMngDbDataSet.TransactionTypeTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetTransactionTbl' table. You can move, or remove it, as needed.
            this.assetTransactionTblTableAdapter.Fill(this.assetMngDbDataSet.AssetTransactionTbl);
            manageTransactionTypeTblBtn.Visible = StaticCode.activeUserRole.ManageTransactionTypes == true;
            manageCurrencyTblBtn.Visible = StaticCode.activeUserRole.ManageCurrencies == true;
            this.MinimumSize = this.Size;
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(500, 400);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void assetTransactBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من إدخالاتك؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (transactionTypeLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر نوع التصريف أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (assetTransactionDateDateEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر تاريخ التصريف أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (moneyAmountCurrencyLookUpEdit.EditValue == null && moneyAmountNumericUpDown.Value != 0)
            {
                mainAlertControl.Show(this, "اختر العملة أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (moneyAmountCurrencyLookUpEdit.EditValue != null && moneyAmountCurrencyLookUpEdit.Text.Contains("بيع") && moneyAmountNumericUpDown.Value == 0)
            {
                mainAlertControl.Show(this, "اكتب مبلغ البيع أو الشراء أولاً", StaticCode.ApplicationTitle);
                return;
            }

            try
            {

                AssetTransactionTbl newAstMv = new AssetTransactionTbl()
                {
                    AssetID = assetToTransact.ID,
                    TransactionType = Convert.ToInt32(transactionTypeLookUpEdit.EditValue),
                    TransactionDate = Convert.ToDateTime(assetTransactionDateDateEdit.EditValue),
                    TransactionNotes = assetNotesTextBox.Text.Trim(),
                    MoneyAmount = Convert.ToDouble(moneyAmountNumericUpDown.Value),
                    MoneyAmountCurrency = (moneyAmountNumericUpDown.Value == 0) ? 1 : Convert.ToInt32(moneyAmountCurrencyLookUpEdit.EditValue),
                    GetAssetOutOfWork = getAssetOutOfWorkCheckBox.Checked,
                    CurrentPriceWithDestroying = Convert.ToDouble(currentPriceWithDestroyingNumericUpDown.Value),
                };
                StaticCode.mainDbContext.AssetTransactionTbls.InsertOnSubmit(newAstMv);
                assetToTransact.IsOutOfWork = getAssetOutOfWorkCheckBox.Checked == true;
                assetToTransact.ItemsQuantity = assetToTransact.ItemsQuantity - Convert.ToInt32(assetItemsQuantityToTransactNumericUpDown.Value);
                bool assetSold = transactionTypeLookUpEdit.Text == "بيع";
                if (assetSold)
                {
                    if (assetToTransact.ItemsQuantity == Convert.ToInt32(assetItemsQuantityToTransactNumericUpDown.Value))
                    {
                        assetToTransact.IsSold = true;
                        assetToTransact.IsOutOfWork = true;
                    }
                    MainCategoryTbl assetMaCa = StaticCode.mainDbContext.MainCategoryTbls.Single(maca1 => maca1.ID == StaticCode.mainDbContext.MinorCategoryTbls.Single(mica1 => mica1.ID == assetToTransact.AssetMinorCategory).MainCategory);
                    if (StaticCode.mainDbContext.FinancialItemCategoryTbls.Count(fic1 => fic1.FinancialItemCategoryName == "واردات بيع أصول") == 0)
                    {
                        StaticCode.mainDbContext.FinancialItemCategoryTbls.InsertOnSubmit(new FinancialItemCategoryTbl() { FinancialItemCategoryName = "واردات بيع أصول", FinancialItemCategoryDetails = "بيع أصل ثابت", IsIncomingOrOutgiung = "وارد" });
                        StaticCode.mainDbContext.SubmitChanges();
                    }
                    StaticCode.mainDbContext.FinancialItemTbls.InsertOnSubmit(new FinancialItemTbl()
                    {
                        FinancialItemSubDept = assetToTransact.AssetSubDepartment,
                        FinancialItemCategory = StaticCode.mainDbContext.FinancialItemCategoryTbls.Where(fic2 => fic2.FinancialItemCategoryName == "واردات بيع أصول").First().ID,
                        FinancialItemInsertionDate = Convert.ToDateTime(assetTransactionDateDateEdit.EditValue),
                        IncomingOrOutgoing = "وارد",
                        IncomingAmount = Convert.ToDouble(moneyAmountNumericUpDown.Value),
                        OutgoingAmount = 0,
                        FinancialItemCurrency = Convert.ToInt32(moneyAmountCurrencyLookUpEdit.EditValue),
                        AdditionalNotes = assetNotesTextBox.Text.Trim(),
                        FinancialItemDescription = $"بيع الأصل الذي يحمل الكود {assetToTransact.AssetCode}"
                    });
                }
                assetToTransact.AssetNotes = assetNotesTextBox.Text.Trim();
                StaticCode.mainDbContext.SubmitChanges();
                this.Validate();
                this.assetTransactionTblBindingSource.EndEdit();
                assetTransactionGridControl.DataSource = StaticCode.mainDbContext.AssetTransactionTbls.Where(asmv => asmv.AssetID == currSrchRes.ID);
                mainAlertControl.Show(this, $"تم تصريف الأصل وإضافة سجل تصريف بنجاح{((assetSold) ? " وإضافة سجل مالي خاص ببيع الأصل" : "")}", StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "خطأ في تصريف الأصل، حاول ثانية", StaticCode.ApplicationTitle);
            }
        }

        private void searchAssetBtn_Click(object sender, EventArgs e)
        {
            searchResultsListBox.Visible = viewAssetInformationBtn.Visible = moveAssetGroupBox.Visible = assetTransactionGridControl.Visible = assetTransactionPanel.Visible = false;
            srchRes = StaticCode.mainDbContext.AssetMoveVws.Where(ast => ast.AssetCode.Contains(assetCodeTextBox.Text.Trim()));
            if (srchRes.Count() == 0)
            {
                mainAlertControl.Show(this, "لا يوجد أصل يحتوي على الكود الذي أدخلته ولو حتى بشكل جزئي", StaticCode.ApplicationTitle);
                return;
            }
            searchResultsListBox.DataSource = srchRes;
            searchResultsListBox.Visible = viewAssetInformationBtn.Visible = true;

        }

        private void viewAssetInformationBtn_Click(object sender, EventArgs e)
        {
            moveAssetGroupBox.Visible = assetTransactionGridControl.Visible = assetTransactionPanel.Visible = false;
            if (searchResultsListBox.SelectedIndex == -1)
            {
                mainAlertControl.Show(this, "اختر أحد الكودات في القائمة لاستعراض معلوماته", StaticCode.ApplicationTitle);
                return;
            }
            assetToTransact = StaticCode.mainDbContext.AssetTbls.Single(ast => ast.ID == currSrchRes.ID);
            currSrchRes = StaticCode.mainDbContext.AssetMoveVws.Single(astm => astm.ID == Convert.ToInt32(searchResultsListBox.SelectedValue));
            assetInfoTextBox.Text = $"الدائرة: {currSrchRes.SectionName}, القسم: {currSrchRes.DepartmentName}، الوحدة: {currSrchRes.SubDepartmentName}، الساحة: {currSrchRes.SquareName}،  صاحب العهدة: {currSrchRes.CustodianName}، فئة الأصل الرئيسية: {currSrchRes.MainCategoryName}، فئة الأصل الثانوية: {currSrchRes.MinorCategoryName}، حالة الأصل: {currSrchRes.StatusName}";
            var assetTrs = StaticCode.mainDbContext.AssetTransactionTbls.Where(asmv => asmv.AssetID == currSrchRes.ID);
            assetCurrentItemsQuantityNumericUpDown.Value = StaticCode.mainDbContext.AssetTbls.Single(ast1 => ast1.ID == currSrchRes.ID).ItemsQuantity;
            assetItemsQuantityToTransactNumericUpDown.Maximum = assetCurrentItemsQuantityNumericUpDown.Value;
            assetItemsQuantityToTransactNumericUpDown.Value = 1;
            assetTransactionGridControl.DataSource = assetTrs;
            moveAssetGroupBox.Visible = assetTransactionGridControl.Visible = assetTransactionPanel.Visible = true;
            assetTransactionDateDateEdit.EditValue = transactionTypeLookUpEdit.EditValue = moneyAmountCurrencyLookUpEdit.EditValue = null;
            getAssetOutOfWorkCheckBox.Checked = false;
            assetNotesTextBox.Text = "";
            moneyAmountNumericUpDown.Value = currentPriceWithDestroyingNumericUpDown.Value = 0;
            if (assetToTransact.IsOldOrNewAsset == "جديد")
            {
                currentPriceWithDestroyingNumericUpDown.Value = Convert.ToDecimal(StaticCode.CalcActualPriceForAsset(assetToTransact));
                currentPriceWithDestroyingNumericUpDown.Enabled = false;
            }
            else
            {
                currentPriceWithDestroyingNumericUpDown.Value = 0;
                currentPriceWithDestroyingNumericUpDown.Enabled = true;

            }
        }

        private void assetTransactionTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            assetTransactionTblBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
        }

        private void manageTransactionTypeTblBtn_Click(object sender, EventArgs e)
        {
            ManageTransactionTypeTblForm tatyFrm = new ManageTransactionTypeTblForm();
            tatyFrm.ShowDialog();
            this.transactionTypeTblTableAdapter.Fill(this.assetMngDbDataSet.TransactionTypeTbl);
        }

        private void manageCurrencyTblBtn_Click(object sender, EventArgs e)
        {
            ManageCurrencyTblForm tatyFrm = new ManageCurrencyTblForm();
            tatyFrm.ShowDialog();
            this.currencyTblTableAdapter.Fill(this.assetMngDbDataSet.CurrencyTbl);
        }

        private void getAssetOutOfWorkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            withDestroyingCheckBox.Visible = getAssetOutOfWorkCheckBox.Checked;
            withDestroyingCheckBox.Checked = false;
        }

        private void assetMoveVwGridControl_Click(object sender, EventArgs e)
        {

        }

        private void transactionTypeLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            getAssetOutOfWorkCheckBox.Visible = transactionTypeLookUpEdit.Text != "بيع";
            getAssetOutOfWorkCheckBox.Checked = withDestroyingCheckBox.Checked = false;
        }
    }
}