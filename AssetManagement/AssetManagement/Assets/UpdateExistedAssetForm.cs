using AssetManagement.AuxTables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.Assets
{
    public partial class UpdateExistedAssetForm : Form
    {
        IQueryable<AssetTbl> srchRes = null;
        AssetTbl currSrchRes = null;
        double assetDesRate = 0;
        int assetProdAge = 0;

        public UpdateExistedAssetForm()
        {
            InitializeComponent();
        }

        private void UpdateExistedAssetForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.EstateAreaUnitTbl' table. You can move, or remove it, as needed.
            this.estateAreaUnitTblTableAdapter.Fill(this.assetMngDbDataSet.EstateAreaUnitTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.StatusTbl' table. You can move, or remove it, as needed.
            this.statusTblTableAdapter.Fill(this.assetMngDbDataSet.StatusTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetTbl' table. You can move, or remove it, as needed.
            this.assetTblTableAdapter.Fill(this.assetMngDbDataSet.AssetTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.CurrencyTbl' table. You can move, or remove it, as needed.
            this.currencyTblTableAdapter.Fill(this.assetMngDbDataSet.CurrencyTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.MinorCategoryTbl' table. You can move, or remove it, as needed.
            this.minorCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MinorCategoryTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.MainCategoryTbl' table. You can move, or remove it, as needed.
            this.mainCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MainCategoryTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SquareTbl' table. You can move, or remove it, as needed.
            this.squareTblTableAdapter.Fill(this.assetMngDbDataSet.SquareTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SectionTbl' table. You can move, or remove it, as needed.
            this.sectionTblTableAdapter.Fill(this.assetMngDbDataSet.SectionTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.DepartmentTbl' table. You can move, or remove it, as needed.
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
            this.MinimumSize = this.Size;

            manageCategoriesTblsBtn.Visible = StaticCode.activeUserRole.ManageMainCategories == true && StaticCode.activeUserRole.ManageMinorCategories == true;
            manageCurrencyTblBtn.Visible = StaticCode.activeUserRole.ManageCurrencies == true;
            manageDepartmentTblBtn.Visible = StaticCode.activeUserRole.ManageDepartments == true;
            manageSectionTblBtn.Visible = StaticCode.activeUserRole.ManageSections == true;
            manageSquareTblBtn.Visible = StaticCode.activeUserRole.ManageSquares == true;
            manageEstateAreaUnitTblBtn.Visible = StaticCode.activeUserRole.ManageEstateAreaUnits == true;
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
        }

        private void searchAssetBtn_Click(object sender, EventArgs e)
        {
            searchResultsListBox.Visible = viewAssetInformationBtn.Visible = false;
            srchRes = StaticCode.mainDbContext.AssetTbls.Where(ast => ast.AssetCode.Contains(assetCodeToSearchTextBox.Text.Trim()));
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
            if (searchResultsListBox.SelectedIndex == -1)
            {
                mainAlertControl.Show(this, "اختر أحد الكودات في القائمة لاستعراض معلوماته", StaticCode.ApplicationTitle);
                return;
            }
            try
            {
                currSrchRes = StaticCode.mainDbContext.AssetTbls.Single(astm => astm.ID == Convert.ToInt32(searchResultsListBox.SelectedValue));
                assetCodeTextBox.Text = currSrchRes.AssetCode;
                if (currSrchRes.IsOldOrNewAsset == "جديد")
                    isNewAssetRadioButton.Checked = true;
                if (currSrchRes.IsOldOrNewAsset == "قديم")
                    isOldAssetRadioButton.Checked = true;
                assetDeptLookUpEdit.EditValue = currSrchRes.AssetDept;
                assetSectionLookUpEdit.EditValue = currSrchRes.AssetSection;
                assetSquareLookUpEdit.EditValue = currSrchRes.AssetSquare;
                minorCategoryLookUpEdit.EditValue = currSrchRes.AssetMinorCategory;
                mainCategoryLookUpEdit.EditValue = StaticCode.mainDbContext.MinorCategoryTbls.Single(mica1 => mica1.ID == currSrchRes.AssetMinorCategory).MainCategory;
                itemsQuantityNumericUpDown.Value = currSrchRes.ItemsQuantity;
                assetSpecificationsTextBox.Text = currSrchRes.AssetSpecifications;
                purchaseDateDateEdit.EditValue = currSrchRes.PurchaseDate;
                purchasePriceNumericUpDown.Value = Convert.ToDecimal(currSrchRes.PurchasePrice);
                purchasePriceCurrencyLookUpEdit.EditValue = currSrchRes.PurchasePriceCurrency;
                placeOfPresenceTextBox.Text = currSrchRes.PlaceOfPresence;
                currentStatusLookUpEdit.EditValue = currSrchRes.CurrentStatus;
                actualCurrentPriceNumericUpDown.Value = Convert.ToDecimal(currSrchRes.ActualCurrentPrice);
                actualCurrentPriceCurrencyLookUpEdit.EditValue = currSrchRes.ActualCurrentPriceCurrency;
                modelTextBox.Text = currSrchRes.Model;
                colorColorPickEdit.EditValue = currSrchRes.Color;
                volumeTextBox.Text = currSrchRes.Volume;
                custodianNameTextBox.Text = currSrchRes.CustodianName;
                ownerNameTextBox.Text = currSrchRes.OwnerName;
                benefitPercentageTextBox.Text = currSrchRes.BenefitPercentage;
                moreDetailsTextBox.Text = currSrchRes.MoreDetails;
                assetNotesTextBox.Text = currSrchRes.AssetNotes;
                ofUsedTextBox.Text = currSrchRes.OfUsed;
                estateAddressTextBox.Text = currSrchRes.EstateAddress;
                estateOwnershipDocumentWithTextBox.Text = currSrchRes.EstateOwnershipDocumentWith;
                estateAreaTextBox.Text = currSrchRes.EstateArea;
                estateAreaUnitLookUpEdit.EditValue = currSrchRes.EstateAreaUnit;
                carPanelNumberTextBox.Text = currSrchRes.CarPanelNumber;
                carManufacturingYearNumericUpDown.Value = Convert.ToDecimal(currSrchRes.CarManufacturingYear);
                carChassisNumberTextBox.Text = currSrchRes.CarChassisNumber;
                carEngineNumberTextBox.Text = currSrchRes.CarEngineNumber;

                assetInformationGroupBox.Visible = true;
            }
            catch
            {
                assetInformationGroupBox.Visible = false;
            }
        }

        private void mainCategoryLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (mainCategoryLookUpEdit.EditValue == null)
                return;
            var minorItems = StaticCode.mainDbContext.MinorCategoryTbls.Where(mica => mica.MainCategory == Convert.ToInt32(mainCategoryLookUpEdit.EditValue));
            minorCategoryLookUpEdit.Properties.DataSource = minorItems;
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

        private void manageSquareTblBtn_Click(object sender, EventArgs e)
        {
            ManageSquareTblForm squFrm = new ManageSquareTblForm();
            squFrm.ShowDialog();

            this.squareTblTableAdapter.Fill(this.assetMngDbDataSet.SquareTbl);
        }

        private void manageCurrencyTblBtn_Click(object sender, EventArgs e)
        {
            ManageCurrencyTblForm curFrm = new ManageCurrencyTblForm();
            curFrm.ShowDialog();

            this.currencyTblTableAdapter.Fill(this.assetMngDbDataSet.CurrencyTbl);
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من إدخالاتك؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                mainAlertControl.Show(this, "تم الإلغاء", StaticCode.ApplicationTitle);
                return;
            }
            try
            {
                currSrchRes.AssetCode = assetCodeTextBox.Text.Trim();
                currSrchRes.IsOldOrNewAsset = (isNewAssetRadioButton.Checked) ? "جديد" : "قديم";
                currSrchRes.AssetDept = Convert.ToInt32(assetDeptLookUpEdit.EditValue);
                currSrchRes.AssetSection = Convert.ToInt32(assetSectionLookUpEdit.EditValue);
                currSrchRes.AssetSquare = Convert.ToInt32(assetSquareLookUpEdit.EditValue);
                currSrchRes.AssetMinorCategory = Convert.ToInt32(minorCategoryLookUpEdit.EditValue);
                currSrchRes.ItemsQuantity = Convert.ToInt32(itemsQuantityNumericUpDown.Value);
                currSrchRes.AssetSpecifications = assetSpecificationsTextBox.Text.Trim();
                currSrchRes.PurchaseDate = Convert.ToDateTime(purchaseDateDateEdit.EditValue);
                currSrchRes.PurchasePrice = Convert.ToDouble(purchasePriceNumericUpDown.Value);
                currSrchRes.PurchasePriceCurrency = Convert.ToInt32(purchasePriceCurrencyLookUpEdit.EditValue);
                currSrchRes.PlaceOfPresence = placeOfPresenceTextBox.Text.Trim();
                currSrchRes.CurrentStatus = Convert.ToInt32(currentStatusLookUpEdit.EditValue);
                currSrchRes.ActualCurrentPrice = Convert.ToDouble(actualCurrentPriceNumericUpDown.Value);
                currSrchRes.ActualCurrentPriceCurrency = Convert.ToInt32(actualCurrentPriceCurrencyLookUpEdit.EditValue);
                currSrchRes.Model = modelTextBox.Text.Trim();
                currSrchRes.Color = colorColorPickEdit.EditValue.ToString();
                currSrchRes.Volume = volumeTextBox.Text.Trim();
                currSrchRes.CustodianName = custodianNameTextBox.Text.Trim();
                currSrchRes.OwnerName = ownerNameTextBox.Text.Trim();
                currSrchRes.BenefitPercentage = benefitPercentageTextBox.Text.Trim();
                currSrchRes.MoreDetails = moreDetailsTextBox.Text.Trim();
                currSrchRes.AssetNotes = assetNotesTextBox.Text.Trim();
                currSrchRes.OfUsed = ofUsedTextBox.Text.Trim();
                currSrchRes.EstateAddress = estateAddressTextBox.Text.Trim();
                currSrchRes.EstateOwnershipDocumentWith = estateOwnershipDocumentWithTextBox.Text.Trim();
                currSrchRes.EstateArea = estateAreaTextBox.Text.Trim();
                currSrchRes.EstateAreaUnit = Convert.ToInt32(estateAreaUnitLookUpEdit.EditValue);
                currSrchRes.CarPanelNumber = carPanelNumberTextBox.Text.Trim();
                currSrchRes.CarManufacturingYear = Convert.ToInt32(carManufacturingYearNumericUpDown.Value);
                currSrchRes.CarChassisNumber = carChassisNumberTextBox.Text.Trim();
                currSrchRes.CarEngineNumber = carEngineNumberTextBox.Text.Trim();
                StaticCode.mainDbContext.SubmitChanges();
                Thread.Sleep(500);
                this.assetTblTableAdapter.Fill(this.assetMngDbDataSet.AssetTbl);
                mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "خطأ في الحفظ", StaticCode.ApplicationTitle);
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

        private void manageEstateAreaUnitTblBtn_Click(object sender, EventArgs e)
        {
            ManageEstateAreaUnitTblForm eauFrm = new ManageEstateAreaUnitTblForm();
            eauFrm.ShowDialog();

            this.estateAreaUnitTblTableAdapter.Fill(this.assetMngDbDataSet.EstateAreaUnitTbl);
        }
    }
}