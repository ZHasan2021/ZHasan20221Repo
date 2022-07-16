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
            assetTransactionTblBindingNavigator.Visible = StaticCode.activeUserRole.ManageAssetTransactions == true;
            manageTransactionTypeTblBtn.Visible = StaticCode.activeUserRole.ManageTransactionTypes == true;
            manageCurrencyTblBtn.Visible = StaticCode.activeUserRole.ManageCurrencies == true;
            this.MinimumSize = this.Size;
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
        }

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
            if (moneyAmountCurrencyLookUpEdit.EditValue != null && moneyAmountNumericUpDown.Value == 0)
            {
                mainAlertControl.Show(this, "اكتب مبلغ البيع أو الشراء أولاً", StaticCode.ApplicationTitle);
                return;
            }

            try
            {
                AssetTbl assetToTransact = StaticCode.mainDbContext.AssetTbls.Single(ast => ast.ID == currSrchRes.ID);

                AssetTransactionTbl newAstMv = new AssetTransactionTbl()
                {
                    AssetID = assetToTransact.ID,
                    TransactionType = Convert.ToInt32(transactionTypeLookUpEdit.EditValue),
                    TransactionDate = Convert.ToDateTime(assetTransactionDateDateEdit.EditValue),
                    TransactionNotes = assetNotesTextBox.Text.Trim(),
                    MoneyAmount = Convert.ToDouble(moneyAmountNumericUpDown.Value),
                    MoneyAmountCurrency = (moneyAmountNumericUpDown.Value == 0) ? 1 : Convert.ToInt32(moneyAmountCurrencyLookUpEdit.EditValue),
                    GetAssetOutOfWork = getAssetOutOfWorkCheckBox.Checked,
                    WithDestroying = getAssetOutOfWorkCheckBox.Checked && withDestroyingCheckBox.Checked,
                    CurrentPriceWithDestroying = Convert.ToDouble(currentPriceWithDestroyingNumericUpDown.Value),
                };
                StaticCode.mainDbContext.AssetTransactionTbls.InsertOnSubmit(newAstMv);
                assetToTransact.IsOutOfWork = getAssetOutOfWorkCheckBox.Checked == true;
                if (transactionTypeLookUpEdit.Text.Contains("بيع"))
                    assetToTransact.IsSold = true;
                assetToTransact.AssetNotes = assetNotesTextBox.Text.Trim();
                StaticCode.mainDbContext.SubmitChanges();
                this.Validate();
                this.assetTransactionTblBindingSource.EndEdit();
                assetMoveVwGridControl.DataSource = StaticCode.mainDbContext.AssetTransactionTbls.Where(asmv => asmv.AssetID == currSrchRes.ID);
                mainAlertControl.Show(this, "تم تصريف الأصل وإضافة سجل نقل بنجاح", StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "خطأ في تصريف الأصل، حاول ثانية", StaticCode.ApplicationTitle);
            }
        }

        private void searchAssetBtn_Click(object sender, EventArgs e)
        {
            searchResultsListBox.Visible = viewAssetInformationBtn.Visible = moveAssetGroupBox.Visible = assetMoveVwGridControl.Visible = assetTransactionPanel.Visible = false;
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
            moveAssetGroupBox.Visible = assetMoveVwGridControl.Visible = assetTransactionPanel.Visible = false;
            if (searchResultsListBox.SelectedIndex == -1)
            {
                mainAlertControl.Show(this, "اختر أحد الكودات في القائمة لاستعراض معلوماته", StaticCode.ApplicationTitle);
                return;
            }
            currSrchRes = StaticCode.mainDbContext.AssetMoveVws.Single(astm => astm.ID == Convert.ToInt32(searchResultsListBox.SelectedValue));
            assetInfoLabel.Text = $"فئة الأصل الرئيسية: {currSrchRes.MainCategoryName}، فئة الأصل الثانوية: {currSrchRes.MinorCategoryName}، حالة الأصل {currSrchRes.StatusName}";
            fromDepartmentTextBox.Text = currSrchRes.DepartmentName;
            fromSectionTextBox.Text = currSrchRes.SectionName;
            fromSquareTextBox.Text = currSrchRes.SquareName;
            fromCustodianNameTextBox.Text = currSrchRes.CustodianName;
            assetMoveVwGridControl.DataSource = StaticCode.mainDbContext.AssetMovementTbls.Where(asmv => asmv.AssetID == currSrchRes.ID);
            moveAssetGroupBox.Visible = assetMoveVwGridControl.Visible = assetTransactionPanel.Visible = true;
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
    }
}