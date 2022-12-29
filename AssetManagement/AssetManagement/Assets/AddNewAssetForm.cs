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
    public partial class AddNewAssetForm : Form
    {
        double assetDesRate = 0;
        int assetProdAge = 0;

        public bool AssetAdded = false;

        public AddNewAssetForm()
        {
            InitializeComponent();
        }

        private void AddNewAssetForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet1.FinancialItemCategoryTbl' table. You can move, or remove it, as needed.
            this.financialItemCategoryTblTableAdapter.Fill(this.assetMngDbDataSet1.FinancialItemCategoryTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet1.SubDepartmentTbl' table. You can move, or remove it, as needed.
            this.subDepartmentTblTableAdapter.Fill(this.assetMngDbDataSet1.SubDepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet1.ModelTbl' table. You can move, or remove it, as needed.
            this.modelTblTableAdapter.Fill(this.assetMngDbDataSet1.ModelTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet1.SquareTbl' table. You can move, or remove it, as needed.
            this.squareTblTableAdapter.Fill(this.assetMngDbDataSet1.SquareTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet1.SectionTbl' table. You can move, or remove it, as needed.
            this.sectionTblTableAdapter.Fill(this.assetMngDbDataSet1.SectionTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet1.DepartmentTbl' table. You can move, or remove it, as needed.
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet1.DepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.EstateAreaUnitTbl' table. You can move, or remove it, as needed.
            this.estateAreaUnitTblTableAdapter.Fill(this.assetMngDbDataSet.EstateAreaUnitTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.CurrencyTbl' table. You can move, or remove it, as needed.
            this.currencyTblTableAdapter.Fill(this.assetMngDbDataSet.CurrencyTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.StatusTbl' table. You can move, or remove it, as needed.
            this.statusTblTableAdapter.Fill(this.assetMngDbDataSet.StatusTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.MainCategoryTbl' table. You can move, or remove it, as needed.
            this.mainCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MainCategoryTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.MinorCategoryTbl' table. You can move, or remove it, as needed.
            this.minorCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MinorCategoryTbl);

            manageMainCategoryTblBtn.Visible = manageMinorCategoryTblBtn.Visible = StaticCode.activeUserRole.ManageMainCategories == true && StaticCode.activeUserRole.ManageMinorCategories == true;
            manageCurrencyTblBtn.Visible = StaticCode.activeUserRole.ManageCurrencies == true;
            manageSectionTblBtn.Visible = StaticCode.activeUserRole.ManageSections == true;
            manageDepartmentTblBtn.Visible = StaticCode.activeUserRole.ManageDepartments == true;
            manageSubDepartmentTblBtn.Visible = StaticCode.activeUserRole.ManageSubDepartments == true;
            manageSquareTblBtn.Visible = StaticCode.activeUserRole.ManageSquares == true;
            manageModelTblBtn.Visible = StaticCode.activeUserRole.ManageModels == true;
            manageEstateAreaUnitTblBtn.Visible = StaticCode.activeUserRole.ManageEstateAreaUnits == true;
            manageFinancialItemCategoryTblBtn.Visible = isNewAssetRadioButton.Checked && StaticCode.activeUserRole.ManageFinancialItemCategories == true;
            assetFinancialItemCategoryLookUpEdit.Properties.DataSource = StaticCode.mainDbContext.FinancialItemCategoryTbls.Where(fica1 => fica1.IsIncomingOrOutgiung == "صادر");

            if (StaticCode.activeUserRole.IsSectionIndependent != true)
            {
                try
                {
                    assetSectionLookUpEdit.EditValue = StaticCode.activeUser.UserSection;
                    assetSectionLookUpEdit.Enabled = false;
                }
                catch
                {

                }
            }
            if (StaticCode.activeUserRole.IsDepartmentIndependent != true)
            {
                try
                {
                    assetSectionLookUpEdit.EditValue = StaticCode.mainDbContext.DepartmentTbls.Single(dpt1 => dpt1.ID == StaticCode.activeUser.UserDept).SectionOfDepartment;
                    assetDeptLookUpEdit.EditValue = StaticCode.activeUser.UserDept;
                    assetSectionLookUpEdit.Enabled = assetDeptLookUpEdit.Enabled = false;
                }
                catch
                {

                }
            }

            assetCodeTextBox.Text = StaticCode.GetTheNewAssetCode();
        }

        private void addNewAssetWizardControl_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {

        }

        /// <summary>
        /// 2- Validate the fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewAssetWizardControl_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            string errorMsg = "";
            switch (addNewAssetWizardControl.SelectedPageIndex)
            {
                case 1:
                    correctPictureBox1.Visible = incorrectPictureBox1.Visible = false;
                    if (assetCodeTextBox.Text.Trim() == "")
                        errorMsg += "كود الأصل فارغ\r\n";
                    if (assetSectionLookUpEdit.EditValue == null && StaticCode.activeUserRole.IsSectionIndependent != true)
                        errorMsg += "لم يتم تحديد الدائرة\r\n";
                    if (assetDeptLookUpEdit.EditValue == null && StaticCode.activeUserRole.IsSectionIndependent != true && StaticCode.activeUserRole.IsDepartmentIndependent != true)
                        errorMsg += "لم يتم تحديد القسم\r\n";
                    if (assetSubDeptLookUpEdit.EditValue == null && StaticCode.activeUserRole.IsSectionIndependent != true && StaticCode.activeUserRole.IsDepartmentIndependent != true)
                        errorMsg += "لم يتم تحديد الوحدة\r\n";
                    if (assetSquareLookUpEdit.EditValue == null)
                        errorMsg += "لم يتم تحديد الساحة\r\n";
                    if (mainCategoryLookUpEdit.EditValue == null)
                        errorMsg += "لم يتم تحديد الفئة الرئيسية للأصل\r\n";
                    if (minorCategoryLookUpEdit.EditValue == null)
                        errorMsg += "لم يتم تحديد الفئة الفرعية للأصل\r\n";
                    if (purchaseDateDateEdit.EditValue != null && DateTime.Today < Convert.ToDateTime(purchaseDateDateEdit.EditValue))
                        errorMsg += "تاريخ الشراء أحدث من تاريخ اليوم\r\n";
                    if (isNewAssetRadioButton.Checked)
                    {
                        if (purchaseDateDateEdit.EditValue == null)
                            errorMsg += "لم يتم تحديد تاريخ الشراء\r\n";
                        if (purchasePriceNumericUpDown.Value == 0)
                            errorMsg += "لم يتم تقدير سعر الشراء\r\n";
                        if (purchasePriceCurrencyLookUpEdit.EditValue == null)
                            errorMsg += "لم يتم تحديد عملة سعر الشراء\r\n";
                        if (assetFinancialItemCategoryLookUpEdit.EditValue == null)
                            errorMsg += "لم يتم تحديد البند المالي للأصل\r\n";
                    }
                    if (placeOfPresenceTextBox.Text.Trim() == "")
                        errorMsg += "مكان التواجد غير محدد\r\n";
                    if (currentStatusLookUpEdit.EditValue == null)
                        errorMsg += "لم يتم تحديد الحالة الآنية\r\n";
                    if (actualCurrentPriceNumericUpDown.Value == 0)
                        errorMsg += "لم يتم تقدير السعر الفعلي الحالي\r\n";
                    if (actualCurrentPriceCurrencyLookUpEdit.EditValue == null)
                        errorMsg += "لم يتم تحديد عملة السعر الفعلي الحالي\r\n";
                    if (modelLookUpEdit.EditValue == null)
                        errorMsg += "لم يتم تحديد الموديل\r\n";
                    errorSummaryLabel1.Text = errorMsg.Replace("\r\n", "، ").Trim().Trim('،').Trim();
                    if (errorMsg != "")
                    {
                        mainAlertControl.Show(this, $"هناك بعض الإدخالات الناقصة\r\n{errorMsg}", StaticCode.ApplicationTitle);
                    }
                    e.Cancel = errorMsg != "";
                    break;
                case 2:
                    if (custodianNameTextBox.Text.Trim() == "")
                        errorMsg += "اسم صاحب العهدة فارغ\r\n";
                    errorSummaryLabel2.Text = errorMsg.Replace("\r\n", "، ").Trim().Trim('،').Trim();
                    if (errorMsg != "")
                    {
                        mainAlertControl.Show(this, $"هناك بعض الإدخالات الناقصة\r\n{errorMsg}", StaticCode.ApplicationTitle);
                    }
                    e.Cancel = errorMsg != "";
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 1- Add the asset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewAssetWizardControl_FinishClick(object sender, CancelEventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من إدخالاتك؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            progressPanel1.Visible = true;

            try
            {
                int assetSubD = Convert.ToInt32(assetSubDeptLookUpEdit.EditValue);
                if (assetSectionLookUpEdit.EditValue == null)
                {
                    if (StaticCode.activeUserRole.IsSectionIndependent == true)
                    {
                        var qry_PM = StaticCode.mainDbContext.SubDepartmentVws.Where(sdptv1 => sdptv1.اسم_الوحدة == StaticCode.PMName && sdptv1.القسم_التابعة_له == StaticCode.PMName && sdptv1.الدائرة_التي_يتبع_لها_القسم == StaticCode.PMName);
                        if (qry_PM == null || qry_PM.Count() == 0)
                        {
                            SectionTbl newPM_Sec = new SectionTbl() { SectionName = StaticCode.PMName };
                            StaticCode.mainDbContext.SectionTbls.InsertOnSubmit(newPM_Sec);
                            StaticCode.mainDbContext.SubmitChanges();
                            DepartmentTbl newPM_Dpt = new DepartmentTbl() { DepartmentName = StaticCode.PMName, SectionOfDepartment = newPM_Sec.ID };
                            StaticCode.mainDbContext.DepartmentTbls.InsertOnSubmit(newPM_Dpt);
                            StaticCode.mainDbContext.SubmitChanges();
                            SubDepartmentTbl newPM_SDpt = new SubDepartmentTbl() { SubDepartmentName = StaticCode.PMName, MainDepartment = newPM_Dpt.ID };
                            StaticCode.mainDbContext.SubDepartmentTbls.InsertOnSubmit(newPM_SDpt);
                            StaticCode.mainDbContext.SubmitChanges();
                            assetSubD = newPM_SDpt.ID;
                        }
                        else
                        {
                            assetSubD = qry_PM.First().معرف_الوحدة;
                        }
                    }
                }
                else if (assetDeptLookUpEdit.EditValue == null)
                {
                    if (StaticCode.activeUserRole.IsDepartmentIndependent == true)
                    {
                        var qry_PM = StaticCode.mainDbContext.SubDepartmentVws.Where(sdptv1 => sdptv1.اسم_الوحدة == ("إدارة " + assetSectionLookUpEdit.Text) && sdptv1.القسم_التابعة_له == ("إدارة " + assetSectionLookUpEdit.Text) && sdptv1.الدائرة_التي_يتبع_لها_القسم == assetSectionLookUpEdit.Text);
                        if (qry_PM == null || qry_PM.Count() == 0)
                        {
                            DepartmentTbl newPM_Dpt = new DepartmentTbl() { DepartmentName = ("إدارة " + assetSectionLookUpEdit.Text), SectionOfDepartment = Convert.ToInt32(assetSectionLookUpEdit.EditValue) };
                            StaticCode.mainDbContext.DepartmentTbls.InsertOnSubmit(newPM_Dpt);
                            StaticCode.mainDbContext.SubmitChanges();
                            SubDepartmentTbl newPM_SDpt = new SubDepartmentTbl() { SubDepartmentName = ("إدارة " + assetSectionLookUpEdit.Text), MainDepartment = newPM_Dpt.ID };
                            StaticCode.mainDbContext.SubDepartmentTbls.InsertOnSubmit(newPM_SDpt);
                            StaticCode.mainDbContext.SubmitChanges();
                            assetSubD = newPM_SDpt.ID;
                        }
                        else
                        {
                            assetSubD = qry_PM.First().معرف_الوحدة;
                        }
                    }
                }

                AssetTbl newAssetRecord = new AssetTbl()
                {
                    AssetCode = assetCodeTextBox.Text.Trim(),
                    IsOldOrNewAsset = (isNewAssetRadioButton.Checked) ? "جديد" : "قديم",
                    AssetMinorCategory = Convert.ToInt32(minorCategoryLookUpEdit.EditValue),
                    ItemsQuantity = Convert.ToInt32(itemsQuantityNumericUpDown.Value),
                    DestructionRate = Convert.ToDouble(destructionRateNumericUpDown.Value),
                    LifeSpanInMonths = Convert.ToInt32(lifeSpanInMonthsNumericUpDown.Value),
                    AssetSubDepartment = assetSubD,
                    AssetSquare = Convert.ToInt32(assetSquareLookUpEdit.EditValue),
                    AssetSpecifications = assetSpecificationsTextBox.Text.Trim(),
                    Model = (modelLookUpEdit.EditValue == null) ? "" : modelLookUpEdit.Text,
                    Color = colorComboBox.Text,
                    Volume = volumeTextBox.Text.Trim(),
                    PurchasePrice = Convert.ToInt32(purchasePriceNumericUpDown.Value),
                    PurchasePriceCurrency = Convert.ToInt32(purchasePriceCurrencyLookUpEdit.EditValue),
                    PlaceOfPresence = placeOfPresenceTextBox.Text.Trim(),
                    CurrentStatus = Convert.ToInt32(currentStatusLookUpEdit.EditValue),
                    BenefitPercentage = benefitPercentageTextBox.Text.Trim(),
                    ActualCurrentPrice = Convert.ToInt32(actualCurrentPriceNumericUpDown.Value),
                    ActualCurrentPriceCurrency = Convert.ToInt32(actualCurrentPriceCurrencyLookUpEdit.EditValue),
                    CustodianName = custodianNameTextBox.Text.Trim(),
                    MoreDetails = moreDetailsTextBox.Text.Trim(),
                    AssetNotes = assetNotesTextBox.Text.Trim(),
                    EstateAddress = estateAddressTextBox.Text.Trim(),
                    OwnerName = ownerNameTextBox.Text.Trim(),
                    OfUsed = ofUsedTextBox.Text.Trim(),
                    EstateOwnershipDocumentWith = estateOwnershipDocumentWithTextBox.Text.Trim(),
                    EstateArea = estateAreaTextBox.Text.Trim(),
                    EstateAreaUnit = (estateAreaUnitLookUpEdit.EditValue == null) ? 1 : Convert.ToInt32(estateAreaUnitLookUpEdit.EditValue),
                    CarPanelNumber = carPanelNumberTextBox.Text.Trim(),
                    CarChassisNumber = carChassisNumberTextBox.Text.Trim(),
                    CarManufacturingYear = Convert.ToInt32(carManufacturingYearNumericUpDown.Value),
                    CarEngineNumber = carEngineNumberTextBox.Text.Trim(),
                    IsSold = false,
                    IsOutOfWork = false,
                    AddingMethod = "UserForm",
                };
                if (purchaseDateDateEdit.EditValue != null)
                    newAssetRecord.PurchaseDate = Convert.ToDateTime(purchaseDateDateEdit.EditValue);
                StaticCode.mainDbContext.AssetTbls.InsertOnSubmit(newAssetRecord);
                if (isNewAssetRadioButton.Checked)
                {
                    StaticCode.mainDbContext.FinancialItemTbls.InsertOnSubmit(new FinancialItemTbl()
                    {
                        FinancialItemSubDept = assetSubD,
                        FinancialItemCategory = Convert.ToInt32(assetFinancialItemCategoryLookUpEdit.EditValue),
                        FinancialItemInsertionDate = Convert.ToDateTime(purchaseDateDateEdit.EditValue),
                        IncomingOrOutgoing = "صادر",
                        OutgoingAmount = Convert.ToDouble(purchasePriceNumericUpDown.Value),
                        OutgoingType = "صادرات مباشرة",
                        OutgoingTo = "",
                        IncomingAmount = 0,
                        IncomingFrom = "",
                        FinancialItemCurrency = Convert.ToInt32(purchasePriceCurrencyLookUpEdit.EditValue),
                        FinancialItemDescription = "شراء أصل",
                        AdditionalNotes = $"شراء أصل من فئة {mainCategoryLookUpEdit.Text}-{minorCategoryLookUpEdit.Text} الذي يحمل الكود {newAssetRecord.AssetCode}",
                    });
                }
                StaticCode.mainDbContext.SubmitChanges();
                this.DialogResult = DialogResult.OK;
                AssetAdded = true;
                e.Cancel = false;
            }
            catch (Exception ex)
            {
                string fff = ex.Message;
                mainAlertControl.Show(this, "خطأ في بعص الإدخالات، تأكد ثانية من القيم", StaticCode.ApplicationTitle);
                AssetAdded = false;
                e.Cancel = true;
            }
            progressPanel1.Visible = false;
        }

        private void mainCategoryLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (mainCategoryLookUpEdit.EditValue == null)
                return;
            var minorItems = StaticCode.mainDbContext.MinorCategoryTbls.Where(mica => mica.MainCategory == Convert.ToInt32(mainCategoryLookUpEdit.EditValue));
            minorCategoryLookUpEdit.Properties.DataSource = minorItems;
        }

        private void mainCategoryLookUpEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addNewAssetWizardControl_PrevClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {

        }

        private void manageDepartmentTblBtn_Click(object sender, EventArgs e)
        {
            ManageDepartmentTblForm dptFrm = new ManageDepartmentTblForm();
            dptFrm.ShowDialog();

            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
        }

        private void manageSectionTblBtn_Click(object sender, EventArgs e)
        {
            ManageSectionTblForm secFrm = new ManageSectionTblForm();
            secFrm.ShowDialog();

            this.sectionTblTableAdapter.Fill(this.assetMngDbDataSet.SectionTbl);
        }

        private void manageMainCategoryTblBtn_Click(object sender, EventArgs e)
        {
            ManageMainCategoryTblForm macaFrm = new ManageMainCategoryTblForm();
            macaFrm.ShowDialog();

            this.mainCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MainCategoryTbl);
        }

        private void manageMinorCategoryTblBtn_Click(object sender, EventArgs e)
        {
            ManageMinorCategoryTblForm micaFrm = new ManageMinorCategoryTblForm();
            micaFrm.ShowDialog();

            this.minorCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MinorCategoryTbl);
        }

        private void manageCurrencyTblBtn_Click(object sender, EventArgs e)
        {
            ManageCurrencyTblForm curFrm = new ManageCurrencyTblForm();
            curFrm.ShowDialog();

            this.currencyTblTableAdapter.Fill(this.assetMngDbDataSet.CurrencyTbl);
        }

        private void manageEstateAreaUnitTblBtn_Click(object sender, EventArgs e)
        {
            ManageEstateAreaUnitTblForm eauFrm = new ManageEstateAreaUnitTblForm();
            eauFrm.ShowDialog();

            this.estateAreaUnitTblTableAdapter.Fill(this.assetMngDbDataSet.EstateAreaUnitTbl);
        }

        private void manageSquareTblBtn_Click(object sender, EventArgs e)
        {
            ManageSquareTblForm squFrm = new ManageSquareTblForm();
            squFrm.ShowDialog();

            this.squareTblTableAdapter.Fill(this.assetMngDbDataSet.SquareTbl);
        }

        private void manageModelTblBtn_Click(object sender, EventArgs e)
        {
            ManageModelTblForm mdlFrm = new ManageModelTblForm();
            mdlFrm.ShowDialog();

            this.modelTblTableAdapter.Fill(this.assetMngDbDataSet.ModelTbl);
        }

        private void minorCategoryLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            destructionRateNumericUpDown.Value = 0;
            if (minorCategoryLookUpEdit.EditValue == null)
                return;
            try
            {
                MinorCategoryTbl currMiCa = StaticCode.mainDbContext.MinorCategoryTbls.Single(mica1 => mica1.ID == Convert.ToInt32(minorCategoryLookUpEdit.EditValue));
                assetDesRate = currMiCa.DestructionRate;
                assetProdAge = currMiCa.ProductiveAgeInYears;
                destructionRateNumericUpDown.Value = Convert.ToDecimal(assetDesRate);
            }
            catch
            {

            }
        }

        private void purchaseDateDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            lifeSpanInMonthsNumericUpDown.Value = 0;
            if (minorCategoryLookUpEdit.EditValue == null || purchaseDateDateEdit.EditValue == null)
                return;
            try
            {
                DateTime dt1 = Convert.ToDateTime(purchaseDateDateEdit.EditValue);
                int monthsDiff = assetProdAge * 12 - ((DateTime.Today.Year - dt1.Year) * 12 + (DateTime.Today.Month - dt1.Month));
                lifeSpanInMonthsNumericUpDown.Value = monthsDiff;
            }
            catch
            {

            }
        }

        private void assetDeptLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (assetDeptLookUpEdit.EditValue == null)
                return;
            var subDeptItems = StaticCode.mainDbContext.SubDepartmentTbls.Where(subd1 => subd1.MainDepartment == Convert.ToInt32(assetDeptLookUpEdit.EditValue));
            assetSubDeptLookUpEdit.Properties.DataSource = subDeptItems;
        }

        private void assetSectionLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (assetSectionLookUpEdit.EditValue == null)
                return;
            var deptItems = StaticCode.mainDbContext.DepartmentTbls.Where(sec1 => sec1.SectionOfDepartment == Convert.ToInt32(assetSectionLookUpEdit.EditValue));
            assetDeptLookUpEdit.Properties.DataSource = deptItems;
            assetDeptLookUpEdit_EditValueChanged(sender, e);
            assetSubDeptLookUpEdit.EditValue = null;
        }

        private void manageSubDepartmentTblBtn_Click(object sender, EventArgs e)
        {
            ManageSubDepartmentTblForm sdptFrm = new ManageSubDepartmentTblForm();
            sdptFrm.ShowDialog();

            this.subDepartmentTblTableAdapter.Fill(this.assetMngDbDataSet.SubDepartmentTbl);
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 500);
        }

        private void manageFinancialItemCategoryTblBtn_Click(object sender, EventArgs e)
        {
            ManageFinancialItemCategoryTblForm ficaFrm = new ManageFinancialItemCategoryTblForm();
            ficaFrm.ShowDialog();

            this.financialItemCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemCategoryTbl);
        }

        private void OldOrNew(object sender, EventArgs e)
        {
            assetFinancialItemCategoryLabel.Visible = assetFinancialItemCategoryLookUpEdit.Visible = isNewAssetRadioButton.Checked;
            manageFinancialItemCategoryTblBtn.Visible = isNewAssetRadioButton.Checked && StaticCode.activeUserRole.ManageFinancialItemCategories == true;
        }

        private void purchasePriceCurrencyLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            actualCurrentPriceCurrencyLookUpEdit.EditValue = purchasePriceCurrencyLookUpEdit.EditValue;
        }
    }
}