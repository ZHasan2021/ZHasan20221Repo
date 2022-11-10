using AssetManagement.Assets;
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
        bool updateExisted = false;
        int existedRecord = 0;
        public AddNewFinancialItemForm()
        {
            InitializeComponent();
        }

        public AddNewFinancialItemForm(int recordToUpdate)
        {
            InitializeComponent();
            existedRecord = recordToUpdate;
            updateExisted = true;
        }

        private void AddNewFinancialItemForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SectionTbl' table. You can move, or remove it, as needed.
            this.sectionTblTableAdapter.Fill(this.assetMngDbDataSet.SectionTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SubDepartmentTbl' table. You can move, or remove it, as needed.
            this.subDepartmentTblTableAdapter.Fill(this.assetMngDbDataSet.SubDepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.DepartmentTbl' table. You can move, or remove it, as needed.
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.CurrencyTbl' table. You can move, or remove it, as needed.
            this.currencyTblTableAdapter.Fill(this.assetMngDbDataSet.CurrencyTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.FinancialItemCategoryTbl' table. You can move, or remove it, as needed.
            this.financialItemCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemCategoryTbl);
            this.MinimumSize = this.Size;
            manageFinancialItemCategoryTblBtn.Visible = StaticCode.activeUserRole.ManageFinancialItemCategories == true;
            manageCurrencyTblBtn.Visible = StaticCode.activeUserRole.ManageCurrencies == true;
            manageSectionTblBtn.Visible = StaticCode.activeUserRole.ManageSections == true;
            manageDepartmentTblBtn.Visible = StaticCode.activeUserRole.ManageDepartments == true;
            manageSubDepartmentTblBtn.Visible = StaticCode.activeUserRole.ManageSubDepartments == true;

            if (updateExisted)
            {
                FinancialItemTbl currFiIt = StaticCode.mainDbContext.FinancialItemTbls.Single(fi1 => fi1.ID == existedRecord);
                financialItemSectionLookUpEdit.EditValue = StaticCode.mainDbContext.DepartmentTbls.Single(dpt1 => dpt1.ID == StaticCode.mainDbContext.SubDepartmentTbls.Single(sdpt1 => sdpt1.ID == Convert.ToInt32(currFiIt.FinancialItemSubDept)).MainDepartment).SectionOfDepartment;
                financialItemDeptLookUpEdit.EditValue = StaticCode.mainDbContext.SubDepartmentTbls.Single(sdpt1 => sdpt1.ID == Convert.ToInt32(currFiIt.FinancialItemSubDept)).MainDepartment;
                financialItemSubDeptLookUpEdit.EditValue = currFiIt.FinancialItemSubDept;
                financialItemDescriptionTextBox.Text = currFiIt.FinancialItemDescription;
                financialItemInsertionDateDateEdit.EditValue = currFiIt.FinancialItemInsertionDate;
                incomingRadioButton.Checked = currFiIt.IncomingOrOutgoing == "وارد";
                outgoingRadioButton.Checked = currFiIt.IncomingOrOutgoing == "صادر";
                financialItemCategoryLookUpEdit.EditValue = currFiIt.FinancialItemCategory;
                incomingAmountNumericUpDown.Value = Convert.ToDecimal(currFiIt.IncomingAmount);
                outgoingAmountNumericUpDown.Value = Convert.ToDecimal(currFiIt.OutgoingAmount);
                financialItemCurrencyLookUpEdit.EditValue = currFiIt.FinancialItemCurrency;
                additionalNotesTextBox.Text = currFiIt.AdditionalNotes;
                this.Text = "تعديل سجل مالي موجود";
                addNewFinancialItemBtn_OK.Text = "حفظ";
            }
            else
            {
                if (StaticCode.activeUserRole.IsSectionIndependent != true)
                {
                    try
                    {
                        financialItemSectionLookUpEdit.EditValue = StaticCode.activeUser.UserSection;
                        financialItemSectionLookUpEdit.Enabled = false;
                    }
                    catch
                    {

                    }
                }
                if (StaticCode.activeUserRole.IsDepartmentIndependent != true)
                {
                    try
                    {
                        financialItemSectionLookUpEdit.EditValue = StaticCode.mainDbContext.DepartmentTbls.Single(dpt1 => dpt1.ID == StaticCode.activeUser.UserDept).SectionOfDepartment;
                        financialItemDeptLookUpEdit.EditValue = StaticCode.activeUser.UserDept;
                        financialItemSectionLookUpEdit.Enabled = financialItemDeptLookUpEdit.Enabled = false;
                    }
                    catch
                    {

                    }
                }
            }
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewFinancialItemBtn_OK_Click(object sender, EventArgs e)
        {
            if (financialItemCategoryLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر البند المالي أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (financialItemSectionLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر الدائرة أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (financialItemDeptLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر القسم أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (financialItemSubDeptLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر الوحدة أولاً", StaticCode.ApplicationTitle);
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
            if (!(incomingRadioButton.Checked || outgoingRadioButton.Checked))
            {
                mainAlertControl.Show(this, "قم بتحديد طبيعة السجل المالي (صادر / وارد) أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (incomingRadioButton.Checked && incomingAmountNumericUpDown.Value == 0)
            {
                mainAlertControl.Show(this, "اكتب المبلغ الوارد أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (outgoingRadioButton.Checked && outgoingAmountNumericUpDown.Value == 0)
            {
                mainAlertControl.Show(this, "اكتب المبلغ الصادر أولاً", StaticCode.ApplicationTitle);
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
                FinancialItemTbl newFiIt = new FinancialItemTbl();
                if (updateExisted)
                    newFiIt = StaticCode.mainDbContext.FinancialItemTbls.Single(fi1 => fi1.ID == existedRecord);
                newFiIt.FinancialItemCategory = Convert.ToInt32(financialItemCategoryLookUpEdit.EditValue);
                newFiIt.FinancialItemSubDept = Convert.ToInt32(financialItemSubDeptLookUpEdit.EditValue);
                newFiIt.FinancialItemDescription = financialItemDescriptionTextBox.Text.Trim();
                newFiIt.FinancialItemInsertionDate = Convert.ToDateTime(financialItemInsertionDateDateEdit.EditValue);
                newFiIt.IncomingOrOutgoing = (incomingRadioButton.Checked) ? "وارد" : "صادر";
                newFiIt.IncomingAmount = (incomingRadioButton.Checked) ? Convert.ToDouble(incomingAmountNumericUpDown.Value) : 0;
                newFiIt.OutgoingAmount = (incomingRadioButton.Checked) ? 0 : Convert.ToDouble(outgoingAmountNumericUpDown.Value);
                newFiIt.FinancialItemCurrency = Convert.ToInt32(financialItemCurrencyLookUpEdit.EditValue);
                newFiIt.AdditionalNotes = additionalNotesTextBox.Text.Trim();
                if (!updateExisted)
                    StaticCode.mainDbContext.FinancialItemTbls.InsertOnSubmit(newFiIt);
                StaticCode.mainDbContext.SubmitChanges();

                mainAlertControl.Show(this, $"تمت {((updateExisted) ? "تعديل" : "إضافة")} السجل المالي بنجاح", StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, $"خطأ في {((updateExisted) ? "تعديل" : "إضافة")} السجل المالي، حاول لاحقاً", StaticCode.ApplicationTitle);
            }
            this.Close();
        }

        private void addNewFinancialItemBtn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manageSectionTblBtn_Click(object sender, EventArgs e)
        {
            ManageSectionTblForm sctFrm = new ManageSectionTblForm();
            sctFrm.ShowDialog();
            this.sectionTblTableAdapter.Fill(this.assetMngDbDataSet.SectionTbl);
        }

        private void manageDepartmentTblBtn_Click(object sender, EventArgs e)
        {
            ManageDepartmentTblForm dptFrm = new ManageDepartmentTblForm();
            dptFrm.ShowDialog();
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
        }

        private void manageSubDepartmentTblBtn_Click(object sender, EventArgs e)
        {
            ManageSubDepartmentTblForm sdptFrm = new ManageSubDepartmentTblForm();
            sdptFrm.ShowDialog();
            this.subDepartmentTblTableAdapter.Fill(this.assetMngDbDataSet.SubDepartmentTbl);
        }

        private void financialItemSectionLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (financialItemSectionLookUpEdit.EditValue == null)
                return;
            var deptItems = StaticCode.mainDbContext.DepartmentTbls.Where(sec1 => sec1.SectionOfDepartment == Convert.ToInt32(financialItemSectionLookUpEdit.EditValue));
            financialItemDeptLookUpEdit.Properties.DataSource = deptItems;
            financialItemDeptLookUpEdit_EditValueChanged(sender, e);
            financialItemSubDeptLookUpEdit.EditValue = null;
        }

        private void financialItemDeptLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (financialItemDeptLookUpEdit.EditValue == null)
                return;
            var subDeptItems = StaticCode.mainDbContext.SubDepartmentTbls.Where(subd1 => subd1.MainDepartment == Convert.ToInt32(financialItemDeptLookUpEdit.EditValue));
            financialItemSubDeptLookUpEdit.Properties.DataSource = subDeptItems;
        }

        private void addNewAssetBtn_Click(object sender, EventArgs e)
        {
            AddNewAssetForm newast = new AddNewAssetForm();
            newast.ShowDialog();
        }

        private void incomingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            financialItemCategoryLookUpEdit.Properties.DataSource = StaticCode.mainDbContext.FinancialItemCategoryTbls.Where(fii1 => fii1.IsIncomingOrOutgiung == "وارد");
            incomingAmountNumericUpDown.Enabled = true;
            outgoingAmountNumericUpDown.Enabled = false;
            incomingAmountNumericUpDown.Value =
                outgoingAmountNumericUpDown.Value = 0;
        }

        private void outgoingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            financialItemCategoryLookUpEdit.Properties.DataSource = StaticCode.mainDbContext.FinancialItemCategoryTbls.Where(fii1 => fii1.IsIncomingOrOutgiung == "صادر");
            incomingAmountNumericUpDown.Enabled = false;
            outgoingAmountNumericUpDown.Enabled = true;
            incomingAmountNumericUpDown.Value =
                outgoingAmountNumericUpDown.Value = 0;
        }

        private void incomingOutgoingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            financialItemCategoryLookUpEdit.Properties.DataSource = financialItemCategoryTblBindingSource;
        }

        private void financialItemCategoryLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            addNewFinancialItemBtn_OK.Enabled = true;
            if (financialItemCategoryLookUpEdit.EditValue == null)
                return;
            try
            {
                string fiCaDtl = StaticCode.mainDbContext.FinancialItemCategoryTbls.Single(fica1 => fica1.ID == Convert.ToInt32(financialItemCategoryLookUpEdit.EditValue)).FinancialItemCategoryDetails;
                if (fiCaDtl.Contains("أصل") || fiCaDtl.Contains("أصول"))
                {
                    if (StaticCode.activeUserRole.AddNewAsset == true)
                    {
                        MessageBox.Show("هذا البند المالي يوصف على أنه أصل ثابت، الرجاء إدخال كافة بيانات الأصل ", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        AddNewAssetForm astFrm = new AddNewAssetForm();
                        astFrm.ShowDialog();
                        addNewFinancialItemBtn_OK.Enabled = AddNewAssetForm.AssetAdded;
                    }
                    else
                    {
                        MessageBox.Show("هذا البند المالي يوصف على أنه أصل ثابت لكنك لا تملك الصلاحية لإضافة أصل، الرجاء طلب سماحية لإضافة أصل ثم إدخال كافة بيانات الأصل ", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        addNewFinancialItemBtn_OK.Enabled = false;
                        return;
                    }
                }
            }
            catch
            {

            }
        }
    }
}