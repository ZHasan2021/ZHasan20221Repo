using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.AuxTables
{
    public partial class ManageCategoriesTblsForm : Form
    {
        public ManageCategoriesTblsForm()
        {
            InitializeComponent();
        }

        private void ManageCategoriesTblsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.MinorCategoryTbl' table. You can move, or remove it, as needed.
            this.minorCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MinorCategoryTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.MainCategoryTbl' table. You can move, or remove it, as needed.
            this.mainCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MainCategoryTbl);

            addNewMainCategoryBtn.Visible = StaticCode.activeUserRole.AddNewMainCategory == true;
            minorCategoryGridControl.EmbeddedNavigator.Buttons.Append.Visible = StaticCode.activeUserRole.AddNewMinorCategory == true;
            minorCategoryGridControl.EmbeddedNavigator.Buttons.Edit.Visible =
            minorCategoryGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = StaticCode.activeUserRole.ManageMinorCategories == true;

            this.MinimumSize = this.Size;
        }

        private void findMinorCategoriesBtn_Click(object sender, EventArgs e)
        {
            if (mainCategoryLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر الفئة الرئيسية أولاً", StaticCode.ApplicationTitle);
                return;
            }

            var minorCats = StaticCode.mainDbContext.MinorCategoryTbls.Where(mica => mica.MainCategory == Convert.ToInt32(mainCategoryLookUpEdit.EditValue));
            minorCategoryGridControl.DataSource = minorCats;
        }

        private void addNewMainCategoryBtn_Click(object sender, EventArgs e)
        {
            addNewMainCategoryGroupBox.Visible = true;
        }

        private void addNewMainCategoryBtn_OK_Click(object sender, EventArgs e)
        {
            if (newMainCategoryNameTextBox.Text.Trim() == "")
            {

                mainAlertControl.Show(this, "اكتب اسم الفئة الرئيسية أولاً", StaticCode.ApplicationTitle);
                return;
            }

            bool addFinancialCategoryItem = StaticCode.activeUserRole.AddNewFinancialItemCategory == true && StaticCode.mainDbContext.FinancialItemCategoryTbls.Count(fica => fica.FinancialItemCategoryName == newMainCategoryNameTextBox.Text.Trim()) == 0;

            StaticCode.mainDbContext.MainCategoryTbls.InsertOnSubmit(new MainCategoryTbl() { MainCategoryName = newMainCategoryNameTextBox.Text.Trim(), MainCategoryDescription = newMainCategoryDescriptionTextBox.Text.Trim() });
            if (addFinancialCategoryItem)
            {
                FinancialItemCategoryTbl newFICat = new FinancialItemCategoryTbl()
                {
                    FinancialItemCategoryName = newMainCategoryDescriptionTextBox.Text.Trim(),
                    FinancialItemCategoryDetails = "أصول ثابتة",
                };
                StaticCode.mainDbContext.FinancialItemCategoryTbls.InsertOnSubmit(newFICat);
            }
            StaticCode.mainDbContext.SubmitChanges();

            this.mainCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MainCategoryTbl);
            this.minorCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MinorCategoryTbl);

            mainAlertControl.Show(this, $"تم إضافة فئة رئيسية{((addFinancialCategoryItem) ? " مع بند مالي جديد كذلك" : "")}", StaticCode.ApplicationTitle);
            addNewMainCategoryGroupBox.Visible = false;
        }

        private void addNewMainCategoryBtn_Cancel_Click(object sender, EventArgs e)
        {
            newMainCategoryNameTextBox.Text = "";
            addNewMainCategoryGroupBox.Visible = false;
        }

        private void minorCategoryGridControl_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Append)
            {
                minorCategoryGridView.SetRowCellValue(minorCategoryGridView.DataRowCount - 1, colMainCategory, mainCategoryLookUpEdit.EditValue);
            }
        }

        private void saveChangesTileNavItem_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {

        }

        private void discardChangesTileNavItem_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {

        }

        private void saveChangesTileNavSubItem_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Validate();
            minorCategoryTblBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
        }

        private void discardChangesTileNavSubItem_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.minorCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MinorCategoryTbl);
        }

        private void findAllMinorCategoriestBtn_Click(object sender, EventArgs e)
        {
            minorCategoryGridControl.DataSource = minorCategoryTblBindingSource;
        }

        private void minorCategoryTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            minorCategoryTblBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
            mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 200);
        }
    }
}