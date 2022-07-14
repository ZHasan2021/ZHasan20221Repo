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
        AssetMoveVw srchRes = null;

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
                AssetTbl assetToTransact = StaticCode.mainDbContext.AssetTbls.Single(ast => ast.ID == srchRes.ID);

                AssetTransactionTbl newAstMv = new AssetTransactionTbl()
                {
                    AssetID = assetToTransact.ID,
                    TransactionType = Convert.ToInt32(transactionTypeLookUpEdit.EditValue),
                    TransactionDate = Convert.ToDateTime(assetTransactionDateDateEdit.EditValue),
                    TransactionNotes = assetNotesTextBox.Text.Trim(),
                    MoneyAmount = Convert.ToDouble(moneyAmountNumericUpDown.Value),
                    MoneyAmountCurrency = (moneyAmountNumericUpDown.Value == 0) ? 1 : Convert.ToInt32(moneyAmountCurrencyLookUpEdit.EditValue),
                };
                StaticCode.mainDbContext.AssetTransactionTbls.InsertOnSubmit(newAstMv);
                assetToTransact.IsOutOfWork = getAssetOutOfWorkCheckBox.Checked == true;
                if (transactionTypeLookUpEdit.Text.Contains("بيع"))
                    assetToTransact.IsSold = true;
                assetToTransact.AssetNotes = assetNotesTextBox.Text.Trim();
                StaticCode.mainDbContext.SubmitChanges();
                this.Validate();
                this.assetTransactionTblBindingSource.EndEdit();
                assetMoveVwGridControl.DataSource = StaticCode.mainDbContext.AssetTransactionTbls.Where(asmv => asmv.AssetID == srchRes.ID);
                mainAlertControl.Show(this, "تم تصريف الأصل وإضافة سجل نقل بنجاح", StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "خطأ في تصريف الأصل، حاول ثانية", StaticCode.ApplicationTitle);
            }
        }

        private void searchAssetBtn_Click(object sender, EventArgs e)
        {
            moveAssetGroupBox.Visible = false;
            var assetsByCodeQry = StaticCode.mainDbContext.AssetMoveVws.Where(ast => ast.AssetCode == assetCodeTextBox.Text.Trim());
            if (assetsByCodeQry.Count() == 0)
            {
                mainAlertControl.Show(this, "لا يوجد أصل يحمل رقم الكود الذي أدخلته", StaticCode.ApplicationTitle);
                return;
            }
            srchRes = assetsByCodeQry.First();
            moveAssetGroupBox.Visible = true;
            assetInfoLabel.Text = $"فئة الأصل الرئيسية: {srchRes.MainCategoryName}، فئة الأصل الثانوية: {srchRes.MinorCategoryName}، حالة الأصل {srchRes.StatusName}";
            fromDepartmentTextBox.Text = srchRes.DepartmentName;
            fromSectionTextBox.Text = srchRes.SectionName;
            fromSquareTextBox.Text = srchRes.SquareName;
            fromCustodianNameTextBox.Text = srchRes.CustodianName;
            assetMoveVwGridControl.DataSource = StaticCode.mainDbContext.AssetTransactionTbls.Where(astr => astr.AssetID == srchRes.ID);
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
    }
}