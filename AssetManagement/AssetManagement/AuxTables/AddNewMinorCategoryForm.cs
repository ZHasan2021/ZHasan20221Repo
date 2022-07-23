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
    public partial class AddNewMinorCategoryForm : Form
    {
        public AddNewMinorCategoryForm()
        {
            InitializeComponent();
        }

        private void AddNewMinorCategoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.MainCategoryTbl' table. You can move, or remove it, as needed.
            this.mainCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MainCategoryTbl);
            this.MinimumSize = this.Size;
        }

        private void productiveAgeInYearsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            destructionRateNumericUpDown.Value = (decimal)100 / productiveAgeInYearsNumericUpDown.Value;
        }

        private void addNewMinorCategoryBtn_OK_Click(object sender, EventArgs e)
        {
            if (mainCategoryLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر الفئة الرئيسية أولاً", StaticCode.ApplicationTitle);
                return;
            }

            MinorCategoryTbl newMiCaRecord = new MinorCategoryTbl()
            {
                MinorCategoryName = minorCategoryNameTextBox.Text.Trim(),
                MinorCategoryDescription = minorCategoryDescriptionTextBox.Text.Trim(),
                MainCategory = Convert.ToInt32(mainCategoryLookUpEdit.EditValue),
                ProductiveAgeInYears = Convert.ToInt32(productiveAgeInYearsNumericUpDown.Value),
                DestructionRate = Convert.ToDouble(destructionRateNumericUpDown.Value),
            };
            StaticCode.mainDbContext.MinorCategoryTbls.InsertOnSubmit(newMiCaRecord);
            StaticCode.mainDbContext.SubmitChanges();
            mainAlertControl.Show(this, "تمت إضافة الفئة الفرعية", StaticCode.ApplicationTitle);

            minorCategoryNameTextBox.Text = minorCategoryDescriptionTextBox.Text = "";
            mainCategoryLookUpEdit.EditValue = null;
            productiveAgeInYearsNumericUpDown.Value = 1;
            minorCategoryNameTextBox.Focus();
            this.Close();
        }

        private void addNewMinorCategoryBtn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(500, 200);
        }
    }
}