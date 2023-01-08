﻿using AssetManagement.Assets;
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
            // TODO: This line of code loads data into the 'assetMngDbDataSet.IncomingTypeTbl' table. You can move, or remove it, as needed.
            this.incomingTypeTblTableAdapter.Fill(this.assetMngDbDataSet.IncomingTypeTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.OutgoingTypeTbl' table. You can move, or remove it, as needed.
            this.outgoingTypeTblTableAdapter.Fill(this.assetMngDbDataSet.OutgoingTypeTbl);
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
            manageIncomingTypeBtn.Visible = StaticCode.activeUserRole.ManageIncomingTypes == true;
            manageOutgoingTypeBtn.Visible = StaticCode.activeUserRole.ManageOutgoingTypes == true;

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
                if (currFiIt.IncomingOrOutgoing == "وارد")
                {
                    incomingTypeLookUpEdit.Text = currFiIt.IncomingFrom;
                }
                if (currFiIt.IncomingOrOutgoing == "صادر")
                {
                    outgoingTypeLookUpEdit.Text = currFiIt.OutgoingType;
                    if (currFiIt.OutgoingType == "صادرات معلقة")
                    {
                        if (StaticCode.activeUserRole.IsSectionIndependent == true)
                        {
                            outgoingToSectionLookUpEdit.Text = currFiIt.OutgoingTo;
                        }
                        if (StaticCode.activeUserRole.IsDepartmentIndependent == true)
                        {
                            outgoingToDeptLookUpEdit.Text = currFiIt.OutgoingTo;
                        }
                        else
                        {
                            outgoingToSubDeptLookUpEdit.Text = currFiIt.OutgoingTo;
                        }
                    }
                }
                financialItemCategoryLookUpEdit.EditValue = currFiIt.FinancialItemCategory;
                incomingAmountNumericUpDown.Value = Convert.ToDecimal(currFiIt.IncomingAmount);
                outgoingAmountNumericUpDown.Value = Convert.ToDecimal(currFiIt.OutgoingAmount);
                financialItemCurrencyLookUpEdit.EditValue = currFiIt.FinancialItemCurrency;
                additionalNotesTextBox.Text = currFiIt.AdditionalNotes;
                this.Text = "تعديل سجل مالي موجود";
                addNewFinancialItemBtn_OK.Text = "حفظ";
                incomingOrOutgoingPanel.Enabled = false;
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

                if (StaticCode.activeUserRole.IsSectionIndependent == true)
                {

                }
                else if (StaticCode.activeUserRole.IsDepartmentIndependent == true)
                {
                    outgoingToDeptLookUpEdit.Properties.DataSource = StaticCode.mainDbContext.DepartmentTbls.Where(dpt1 => dpt1.SectionOfDepartment == StaticCode.activeUser.UserSection);
                }
                else
                {
                    outgoingToSubDeptLookUpEdit.Properties.DataSource = StaticCode.mainDbContext.SubDepartmentTbls.Where(sdt1 => sdt1.MainDepartment == StaticCode.activeUser.UserDept);
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
        /// 1- Add new/Update existed
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
            if (financialItemSectionLookUpEdit.EditValue == null && StaticCode.activeUserRole.IsSectionIndependent != true)
            {
                mainAlertControl.Show(this, "اختر الدائرة أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (financialItemDeptLookUpEdit.EditValue == null && StaticCode.activeUserRole.IsSectionIndependent != true && StaticCode.activeUserRole.IsDepartmentIndependent != true)
            {
                mainAlertControl.Show(this, "اختر القسم أولاً", StaticCode.ApplicationTitle);
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
            else
            {
                if (Convert.ToDateTime(financialItemInsertionDateDateEdit.EditValue) > DateTime.Today)
                {
                    mainAlertControl.Show(this, "تاريخ السجل المالي أحدث من تاريخ اليوم", StaticCode.ApplicationTitle);
                    return;
                }
            }
            if (!(incomingRadioButton.Checked || outgoingRadioButton.Checked))
            {
                mainAlertControl.Show(this, "قم بتحديد طبيعة السجل المالي (صادر / وارد) أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (incomingRadioButton.Checked)
            {
                if (incomingAmountNumericUpDown.Value == 0)
                {
                    mainAlertControl.Show(this, "اكتب المبلغ الوارد أولاً", StaticCode.ApplicationTitle);
                    return;
                }
                if (incomingTypeLookUpEdit.EditValue == null)
                {
                    mainAlertControl.Show(this, "اختر جهة الإيراد أولاً", StaticCode.ApplicationTitle);
                    return;
                }
            }
            if (outgoingRadioButton.Checked)
            {
                if (outgoingAmountNumericUpDown.Value == 0)
                {
                    mainAlertControl.Show(this, "اكتب المبلغ الصادر أولاً", StaticCode.ApplicationTitle);
                    return;
                }
                if (outgoingTypeLookUpEdit.EditValue == null)
                {
                    mainAlertControl.Show(this, "اختر نوع الصادر أولاً", StaticCode.ApplicationTitle);
                    return;
                }
                if (outgoingTypeLookUpEdit.Text == "صادرات معلقة")
                {
                    if (outgoingToSectionLookUpEdit.Visible && outgoingToSectionLookUpEdit.EditValue == null)
                    {
                        mainAlertControl.Show(this, "اختر الدائرة التي سيصدر إليها السجل المالي أولاً", StaticCode.ApplicationTitle);
                        return;
                    }
                    if (outgoingToDeptLookUpEdit.Visible && outgoingToDeptLookUpEdit.EditValue == null)
                    {
                        mainAlertControl.Show(this, "اختر القسم التي سيصدر إليه السجل المالي أولاً", StaticCode.ApplicationTitle);
                        return;
                    }
                    if (outgoingToSubDeptLookUpEdit.Visible && outgoingToSubDeptLookUpEdit.EditValue == null)
                    {
                        mainAlertControl.Show(this, "اختر الوحدة التي سيصدر إليها السجل المالي أولاً", StaticCode.ApplicationTitle);
                        return;
                    }
                }
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
                int assetSubD = 0;
                if (financialItemSubDeptLookUpEdit.EditValue != null)
                    assetSubD = Convert.ToInt32(financialItemSubDeptLookUpEdit.EditValue);
                else
                {
                    if (StaticCode.activeUserRole.IsSectionIndependent == true)
                    {
                        assetSubD = StaticCode.GetSubDeptForPM();

                    }
                    else
                    {
                        assetSubD = StaticCode.GetSubDeptBySectionName(Convert.ToInt32(financialItemSectionLookUpEdit.EditValue));
                        if (StaticCode.activeUserRole.IsDepartmentIndependent != true)
                            assetSubD = StaticCode.GetSubDeptByDeptName(Convert.ToInt32(financialItemDeptLookUpEdit.EditValue));
                    }
                }

                FinancialItemTbl newFiIt = new FinancialItemTbl();
                if (updateExisted)
                    newFiIt = StaticCode.mainDbContext.FinancialItemTbls.Single(fi1 => fi1.ID == existedRecord);
                newFiIt.FinancialItemCategory = Convert.ToInt32(financialItemCategoryLookUpEdit.EditValue);
                newFiIt.FinancialItemSubDept = assetSubD;
                newFiIt.FinancialItemDescription = financialItemDescriptionTextBox.Text.Trim();
                newFiIt.FinancialItemInsertionDate = Convert.ToDateTime(financialItemInsertionDateDateEdit.EditValue);
                if (incomingRadioButton.Checked)
                {
                    newFiIt.IncomingOrOutgoing = "وارد";
                    newFiIt.IncomingFrom = incomingTypeLookUpEdit.Text;
                    newFiIt.OutgoingType = newFiIt.OutgoingTo = "";
                }
                if (outgoingRadioButton.Checked)
                {
                    newFiIt.IncomingOrOutgoing = "صادر";
                    newFiIt.OutgoingType = outgoingTypeLookUpEdit.Text;
                    if (outgoingTypeLookUpEdit.Text == "صادرات معلقة")
                    {
                        if (outgoingToSectionLookUpEdit.Visible)
                            newFiIt.OutgoingTo = outgoingToSectionLookUpEdit.Text;
                        if (outgoingToDeptLookUpEdit.Visible)
                            newFiIt.OutgoingTo = outgoingToDeptLookUpEdit.Text;
                        if (outgoingToSubDeptLookUpEdit.Visible)
                            newFiIt.OutgoingTo = outgoingToSubDeptLookUpEdit.Text;
                        if (!updateExisted)
                        {
                            int subD_Incoming = 0;
                            if (StaticCode.activeUserRole.IsSectionIndependent == true)
                                subD_Incoming = StaticCode.GetSubDeptBySectionName(Convert.ToInt32(outgoingToSectionLookUpEdit.EditValue));
                            else if (StaticCode.activeUserRole.IsDepartmentIndependent == true)
                                subD_Incoming = StaticCode.GetSubDeptByDeptName(Convert.ToInt32(outgoingToDeptLookUpEdit.EditValue));
                            else
                                subD_Incoming = Convert.ToInt32(outgoingToSubDeptLookUpEdit.EditValue);
                            FinancialItemTbl newIcomingRec = new FinancialItemTbl()
                            {
                                FinancialItemCategory = Convert.ToInt32(financialItemCategoryLookUpEdit.EditValue),
                                FinancialItemSubDept = subD_Incoming,
                                FinancialItemDescription = financialItemDescriptionTextBox.Text.Trim(),
                                FinancialItemInsertionDate = Convert.ToDateTime(financialItemInsertionDateDateEdit.EditValue),
                                IncomingOrOutgoing = "وارد",
                                IncomingAmount = Convert.ToDouble(outgoingAmountNumericUpDown.Value),
                                IncomingFrom = "من المستوى الأعلى",
                                OutgoingAmount = 0,
                                OutgoingTo = "",
                                OutgoingType = "",
                                FinancialItemCurrency = Convert.ToInt32(financialItemCurrencyLookUpEdit.EditValue),
                                AdditionalNotes = additionalNotesTextBox.Text.Trim(),
                            };
                            StaticCode.mainDbContext.FinancialItemTbls.InsertOnSubmit(newIcomingRec);
                        }
                    }
                    newFiIt.IncomingFrom = "";
                }
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
            financialItemCategoryLookUpEdit.EditValue = null;
            incomingAmountNumericUpDown.Enabled = incomingFromLabel.Visible = incomingFromPanel.Visible = true;
            outgoingAmountNumericUpDown.Enabled = outgoingToPanel.Visible = false;
            incomingAmountNumericUpDown.Value =
                outgoingAmountNumericUpDown.Value = 0;

            financialItemSectionLookUpEdit.Enabled = financialItemDeptLookUpEdit.Enabled = financialItemSubDeptLookUpEdit.Enabled = true;
            if (StaticCode.activeUserRole.IsSectionIndependent != true)
            {
                financialItemSectionLookUpEdit.Enabled = false;
            }
            if (StaticCode.activeUserRole.IsDepartmentIndependent != true)
            {
                financialItemSectionLookUpEdit.Enabled = financialItemDeptLookUpEdit.Enabled = false;
            }
            if (incomingRadioButton.Checked)
            {
                if (StaticCode.activeUserRole.IsSectionIndependent == true)
                {
                    financialItemSectionLookUpEdit.Enabled = financialItemDeptLookUpEdit.Enabled = financialItemSubDeptLookUpEdit.Enabled = false;
                }
                if (StaticCode.activeUserRole.IsDepartmentIndependent == true)
                {
                    financialItemDeptLookUpEdit.Enabled = financialItemSubDeptLookUpEdit.Enabled = false;
                }
            }
        }

        private void outgoingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            financialItemCategoryLookUpEdit.Properties.DataSource = StaticCode.mainDbContext.FinancialItemCategoryTbls.Where(fii1 => fii1.IsIncomingOrOutgiung == "صادر");
            financialItemCategoryLookUpEdit.EditValue = null;
            incomingAmountNumericUpDown.Enabled = incomingFromLabel.Visible = incomingFromPanel.Visible = false;
            outgoingAmountNumericUpDown.Enabled = outgoingToPanel.Visible = true;
            incomingAmountNumericUpDown.Value =
                outgoingAmountNumericUpDown.Value = 0;
            outgoingTypeLookUpEdit_EditValueChanged(sender, e);
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
                FinancialItemCategoryTbl selectedFiCa = StaticCode.mainDbContext.FinancialItemCategoryTbls.Single(fica1 => fica1.ID == Convert.ToInt32(financialItemCategoryLookUpEdit.EditValue));
                string fiCaNml = selectedFiCa.FinancialItemCategoryName;
                string fiCaDtl = selectedFiCa.FinancialItemCategoryDetails;
                if (fiCaNml.Contains("أصل") || fiCaNml.Contains("أصول") || fiCaDtl.Contains("أصل") || fiCaDtl.Contains("أصول"))
                {
                    if (StaticCode.activeUserRole.AddNewAsset == true)
                    {
                        MessageBox.Show("هذا البند المالي يوصف على أنه أصل ثابت، الرجاء إدخال كافة بيانات الأصل ", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        AddNewAssetForm astFrm = new AddNewAssetForm();
                        astFrm.ShowDialog();
                        addNewFinancialItemBtn_OK.Enabled = astFrm.AssetAdded;
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

        private void outgoingTypeLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            relatedOutgoingLabel.Visible = outgoingToSectionLookUpEdit.Visible = outgoingToDeptLookUpEdit.Visible = outgoingToSubDeptLookUpEdit.Visible = outgoingTypeLookUpEdit.Text == "صادرات معلقة";
            financialItemSectionLookUpEdit.Enabled = financialItemDeptLookUpEdit.Enabled = financialItemSubDeptLookUpEdit.Enabled = true;
            if (StaticCode.activeUserRole.IsSectionIndependent != true)
            {
                financialItemSectionLookUpEdit.Enabled = false;
            }
            if (StaticCode.activeUserRole.IsDepartmentIndependent != true)
            {
                financialItemSectionLookUpEdit.Enabled = financialItemDeptLookUpEdit.Enabled = false;
            }
            if (outgoingTypeLookUpEdit.Text == "صادرات معلقة")
            {
                if (StaticCode.activeUserRole.IsSectionIndependent == true)
                {
                    outgoingToSectionLookUpEdit.Visible = true;
                    outgoingToDeptLookUpEdit.Visible =
                    outgoingToSubDeptLookUpEdit.Visible = false;
                }
                else if (StaticCode.activeUserRole.IsDepartmentIndependent == true)
                {
                    outgoingToDeptLookUpEdit.Visible = true;
                    outgoingToSectionLookUpEdit.Visible =
                    outgoingToSubDeptLookUpEdit.Visible = false;
                }
                else
                {
                    outgoingToSubDeptLookUpEdit.Visible = true;
                    outgoingToSectionLookUpEdit.Visible =
                    outgoingToDeptLookUpEdit.Visible = false;
                }
                if (StaticCode.activeUserRole.IsSectionIndependent == true)
                {
                    financialItemSectionLookUpEdit.Enabled = financialItemDeptLookUpEdit.Enabled = financialItemSubDeptLookUpEdit.Enabled = false;
                }
                if (StaticCode.activeUserRole.IsDepartmentIndependent == true)
                {
                    financialItemDeptLookUpEdit.Enabled = financialItemSubDeptLookUpEdit.Enabled = false;
                }
            }

            outgoingToSectionLookUpEdit.EditValue =
            outgoingToDeptLookUpEdit.EditValue =
            outgoingToSubDeptLookUpEdit.EditValue = null;
        }

        private void manageOutgoingTypeBtn_Click(object sender, EventArgs e)
        {
            ManageOutgoingTypeTblForm ouTyFrm = new ManageOutgoingTypeTblForm();
            ouTyFrm.ShowDialog();
            this.outgoingTypeTblTableAdapter.Fill(this.assetMngDbDataSet.OutgoingTypeTbl);
        }

        private void manageIncomingTypeBtn_Click(object sender, EventArgs e)
        {
            ManageIncomingTypeTblForm inTyFrm = new ManageIncomingTypeTblForm();
            inTyFrm.ShowDialog();
            this.incomingTypeTblTableAdapter.Fill(this.assetMngDbDataSet.IncomingTypeTbl);
        }
    }
}