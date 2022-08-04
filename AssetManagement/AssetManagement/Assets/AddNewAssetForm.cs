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

        public AddNewAssetForm()
        {
            InitializeComponent();
        }

        private void AddNewAssetForm_Load(object sender, EventArgs e)
        {
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

            manageCategoriesTblsBtn.Visible = StaticCode.activeUserRole.ManageMainCategories == true && StaticCode.activeUserRole.ManageMinorCategories == true;
            manageCurrencyTblBtn.Visible = StaticCode.activeUserRole.ManageCurrencies == true;
            manageDepartmentTblBtn.Visible = StaticCode.activeUserRole.ManageDepartments == true;
            manageSectionTblBtn.Visible = StaticCode.activeUserRole.ManageSections == true;
            manageSquareTblBtn.Visible = StaticCode.activeUserRole.ManageSquares == true;
            manageEstateAreaUnitTblBtn.Visible = StaticCode.activeUserRole.ManageEstateAreaUnits == true;
        }

        private void addNewAssetWizardControl_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {

        }

        private void addNewAssetWizardControl_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            string errorMsg = "";
            switch (addNewAssetWizardControl.SelectedPageIndex)
            {
                case 1:
                    if (assetCodeTextBox.Text.Trim() == "")
                        errorMsg += "كود الأصل فارغ\r\n";
                    if (assetDeptLookUpEdit.EditValue == null)
                        errorMsg += "لم يتم تحديد قسم الأصل\r\n";
                    if (assetSectionLookUpEdit.EditValue == null)
                        errorMsg += "لم يتم تحديد دائرة الأصل\r\n";
                    if (assetSquareLookUpEdit.EditValue == null)
                        errorMsg += "لم يتم تحديد ساحة الأصل\r\n";
                    if (mainCategoryLookUpEdit.EditValue == null)
                        errorMsg += "لم يتم تحديد الفئة الرئيسية للأصل\r\n";
                    if (minorCategoryLookUpEdit.EditValue == null)
                        errorMsg += "لم يتم تحديد الفئة الفرعية للأصل\r\n";
                    if (purchaseDateDateEdit.EditValue == null)
                        errorMsg += "لم يتم تحديد تاريخ الشراء\r\n";
                    if (purchasePriceNumericUpDown.Value == 0)
                        errorMsg += "لم يتم تقدير سعر الشراء\r\n";
                    if (purchasePriceCurrencyLookUpEdit.EditValue == null)
                        errorMsg += "لم يتم تحديد عملة سعر الشراء\r\n";
                    if (placeOfPresenceTextBox.Text.Trim() == "")
                        errorMsg += "مكان التواجد غير محدد\r\n";
                    if (currentStatusLookUpEdit.EditValue == null)
                        errorMsg += "لم يتم تحديد الحالة الآنية\r\n";
                    if (actualCurrentPriceNumericUpDown.Value == 0)
                        errorMsg += "لم يتم تقدير السعر الفعلي الحالي\r\n";
                    if (actualCurrentPriceCurrencyLookUpEdit.EditValue == null)
                        errorMsg += "لم يتم تحديد عملة السعر الفعلي الحالي\r\n";
                    if (errorMsg != "")
                    {
                        mainAlertControl.Show(this, $"هناك بعض الإدخالات الناقصة\r\n{errorMsg}", StaticCode.ApplicationTitle);
                    }
                    e.Cancel = errorMsg != "";
                    break;
                case 2:
                    //e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 
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
                AssetTbl newAssetRecord = new AssetTbl()
                {
                    AssetCode = ((StaticCode.appOptions.AssetCodePrefix == "") ? "" : StaticCode.appOptions.AssetCodePrefix + "-") + assetCodeTextBox.Text.Trim(),
                    AssetMinorCategory = Convert.ToInt32(minorCategoryLookUpEdit.EditValue),
                    ItemsQuantity = Convert.ToInt32(itemsQuantityNumericUpDown.Value),
                    DestructionRate = Convert.ToDouble(destructionRateNumericUpDown.Value),
                    LifeSpanInMonths = Convert.ToInt32(lifeSpanInMonthsNumericUpDown.Value),
                    AssetDept = Convert.ToInt32(assetDeptLookUpEdit.EditValue),
                    AssetSection = Convert.ToInt32(assetSectionLookUpEdit.EditValue),
                    AssetSquare = Convert.ToInt32(assetSquareLookUpEdit.EditValue),
                    AssetSpecifications = assetSpecificationsTextBox.Text.Trim(),
                    Model = modelTextBox.Text.Trim(),
                    Color = colorComboBox.Text,
                    Volume = volumeTextBox.Text.Trim(),
                    PurchaseDate = Convert.ToDateTime(purchaseDateDateEdit.EditValue),
                    PurchasePrice = Convert.ToInt32(actualCurrentPriceNumericUpDown.Value),
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
                };
                StaticCode.mainDbContext.AssetTbls.InsertOnSubmit(newAssetRecord);
                StaticCode.mainDbContext.SubmitChanges();
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                mainAlertControl.Show(this, "خطأ في بعص الإدخالات، تأكد ثانية من القيم", StaticCode.ApplicationTitle);
            }
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

        private void manageCategoriesTblsBtn_Click(object sender, EventArgs e)
        {
            ManageCategoriesTblsForm catFrm = new ManageCategoriesTblsForm();
            catFrm.ShowDialog();

            this.mainCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MainCategoryTbl);
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
    }
}