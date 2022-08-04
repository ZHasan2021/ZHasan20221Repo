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

namespace AssetManagement.Finance
{
    public partial class AddNewFinancialItemForm : Form
    {
        public AddNewFinancialItemForm()
        {
            InitializeComponent();
        }

        private void AddNewFinancialItemForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.CurrencyTbl' table. You can move, or remove it, as needed.
            this.currencyTblTableAdapter.Fill(this.assetMngDbDataSet.CurrencyTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.FinancialItemCategoryTbl' table. You can move, or remove it, as needed.
            this.financialItemCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemCategoryTbl);
            this.MinimumSize = this.Size;
            manageFinancialItemCategoryTblBtn.Visible = StaticCode.activeUserRole.ManageFinancialItemCategories == true;
            manageCurrencyTblBtn.Visible = StaticCode.activeUserRole.ManageCurrencies == true;
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(500, 200);
        }

        private void manageFinancialItemCategoryTblBtn_Click(object sender, EventArgs e)
        {
            ManageFinancialItemCategoryTblForm facFrm = new ManageFinancialItemCategoryTblForm();
            facFrm.ShowDialog();
            this.financialItemCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemCategoryTbl);
        }

        private void manageCurrencyTblBtn_Click(object sender, EventArgs e)
        {
            ManageCurrencyTblForm curFrm = new ManageCurrencyTblForm();
            curFrm.ShowDialog();
            this.currencyTblTableAdapter.Fill(this.assetMngDbDataSet.CurrencyTbl);
        }

        private void addNewFinancialItemBtn_OK_Click(object sender, EventArgs e)
        {
            if (financialItemCategoryLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر البند المالي أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (financialItemDescriptionTextBox.Text.Trim() == "")
            {
                mainAlertControl.Show(this, "املأ بيان السجل المالي أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (financialItemInsertionDateDateEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اكتب تاريخ السجل المالي أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (amountNumericUpDown.Value == 0)
            {
                mainAlertControl.Show(this, "اكتب المبلغ أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (financialItemCurrencyLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر عملة المبلغ أولاً", StaticCode.ApplicationTitle);
                return;
            }

            if (MessageBox.Show("هل أنت متأكد من إدخالاتك؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            try
            {
                FinancialItemTbl newFiIt = new FinancialItemTbl()
                {
                    FinancialItemCategory = Convert.ToInt32(financialItemCategoryLookUpEdit.EditValue),
                    FinancialItemDescription = financialItemDescriptionTextBox.Text.Trim(),
                    FinancialItemInsertionDate = Convert.ToDateTime(financialItemInsertionDateDateEdit.EditValue),
                    IncomingOrOutgoing = (incomingRadioButton.Checked) ? "وارد" : "صادر",
                    IncomingAmount = (incomingRadioButton.Checked) ? Convert.ToDouble(amountNumericUpDown.Value) : 0,
                    OutgoingAmount = (incomingRadioButton.Checked) ? 0 : Convert.ToDouble(amountNumericUpDown.Value),
                    FinancialItemCurrency = Convert.ToInt32(financialItemCurrencyLookUpEdit.EditValue),
                    AdditionalNotes = additionalNotesTextBox.Text.Trim(),
                };
                StaticCode.mainDbContext.FinancialItemTbls.InsertOnSubmit(newFiIt);
                StaticCode.mainDbContext.SubmitChanges();

                mainAlertControl.Show(this, "تمت إضافة السجل المالي بنجاح", StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "خطأ في إضافة السجل المالي، حاول لاحقاً", StaticCode.ApplicationTitle);
            }
            this.Close();
        }

        private void addNewFinancialItemBtn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}