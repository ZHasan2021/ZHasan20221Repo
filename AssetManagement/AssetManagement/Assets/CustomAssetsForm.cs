using AssetManagement.AuxTables;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.Assets
{
    public partial class CustomAssetsForm : Form
    {
        IQueryable<AssetTbl> assetsQry = null;

        public CustomAssetsForm()
        {
            InitializeComponent();
        }

        private void CustomAssetsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SubDepartmentTbl' table. You can move, or remove it, as needed.
            this.subDepartmentTblTableAdapter.Fill(this.assetMngDbDataSet.SubDepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SectionTbl' table. You can move, or remove it, as needed.
            this.sectionTblTableAdapter.Fill(this.assetMngDbDataSet.SectionTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.DepartmentTbl' table. You can move, or remove it, as needed.
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.CurrencyTbl' table. You can move, or remove it, as needed.
            this.currencyTblTableAdapter.Fill(this.assetMngDbDataSet.CurrencyTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.FinancialItemCategoryTbl' table. You can move, or remove it, as needed.
            this.financialItemCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemCategoryTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.FinancialItemTbl' table. You can move, or remove it, as needed.
            this.financialItemTblTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemTbl);
            //manageSectionTblBtn.Visible = StaticCode.activeUserRole.ManageSections == true;
            //manageDepartmentTblBtn.Visible = StaticCode.activeUserRole.ManageDepartments == true;
            //manageSubDepartmentTblBtn.Visible = StaticCode.activeUserRole.ManageSubDepartments == true;
            this.MinimumSize = this.Size;
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 500);
        }

        private void searchInDeptRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchBySectionLookUpEdit.Visible = searchBySectionRadioButton.Checked;
            searchByDepartmentLookUpEdit.Visible = searchByDepartmentRadioButton.Checked;
            searchBySubDepartmentLookUpEdit.Visible = searchBySubDepartmentRadioButton.Checked;
            manageSectionTblBtn.Visible = searchBySectionRadioButton.Checked && StaticCode.activeUserRole.ManageSections == true;
            manageDepartmentTblBtn.Visible = searchByDepartmentRadioButton.Checked && StaticCode.activeUserRole.ManageDepartments == true;
            manageSubDepartmentTblBtn.Visible = searchBySubDepartmentRadioButton.Checked && StaticCode.activeUserRole.ManageSubDepartments == true;
        }

        private void manageDepartmentTblBtn_Click(object sender, EventArgs e)
        {
            ManageDepartmentTblForm dptFrm = new ManageDepartmentTblForm();
            dptFrm.ShowDialog();
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
        }

        private void manageSectionTblBtn_Click(object sender, EventArgs e)
        {
            ManageSectionTblForm sctFrm = new ManageSectionTblForm();
            sctFrm.ShowDialog();
            this.sectionTblTableAdapter.Fill(this.assetMngDbDataSet.SectionTbl);
        }

        private void manageSubDepartmentTblBtn_Click(object sender, EventArgs e)
        {
            ManageSubDepartmentTblForm sdptFrm = new ManageSubDepartmentTblForm();
            sdptFrm.ShowDialog();
            this.subDepartmentTblTableAdapter.Fill(this.assetMngDbDataSet.SubDepartmentTbl);

        }

        private void searchAssetsBtn_Click(object sender, EventArgs e)
        {
            if (searchBySectionRadioButton.Checked && searchBySectionLookUpEdit.EditValue == null)
            {
                MessageBox.Show("اختر الدائرة أولاً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mainAlertControl.Show(this, "اختر الدائرة أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (searchByDepartmentRadioButton.Checked && searchByDepartmentLookUpEdit.EditValue == null)
            {
                MessageBox.Show("اختر القسم أولاً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mainAlertControl.Show(this, "اختر القسم أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (searchBySubDepartmentRadioButton.Checked && searchBySubDepartmentLookUpEdit.EditValue == null)
            {
                MessageBox.Show("اختر الوحدة أولاً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mainAlertControl.Show(this, "اختر الوحدة أولاً", StaticCode.ApplicationTitle);
                return;
            }

            assetsQry = StaticCode.mainDbContext.AssetTbls.Select(asv1 => asv1);
            if (searchBySectionRadioButton.Checked)
            {
                List<int> dptQry = (from dpt1 in StaticCode.mainDbContext.DepartmentTbls where dpt1.SectionOfDepartment == Convert.ToInt32(searchBySectionLookUpEdit.EditValue) select dpt1.ID).ToList();
                List<int> sdptQry = (from sdep1 in StaticCode.mainDbContext.SubDepartmentTbls where dptQry.Contains(sdep1.MainDepartment) select sdep1.ID).ToList();
                assetsQry = from qry in assetsQry where sdptQry.Contains(qry.AssetSubDepartment) select qry;
            }
            if (searchByDepartmentRadioButton.Checked)
            {
                List<int> sdptQry = (from sdep1 in StaticCode.mainDbContext.SubDepartmentTbls where sdep1.MainDepartment == Convert.ToInt32(searchByDepartmentLookUpEdit.EditValue) select sdep1.ID).ToList();
                assetsQry = from qry in assetsQry where sdptQry.Contains(qry.AssetSubDepartment) select qry;
            }
            if (searchBySubDepartmentRadioButton.Checked)
            {
                assetsQry = from qry in assetsQry where qry.AssetSubDepartment == Convert.ToInt32(searchBySubDepartmentLookUpEdit.EditValue) select qry;
            }
            bool resultsFound = assetsQry != null && assetsQry.Count() > 0;
            if (!resultsFound)
            {
                mainAlertControl.Show(this, "لا يوجد أصول ضمن اختياراتك", StaticCode.ApplicationTitle);
                MessageBox.Show("لا يوجد أصول ضمن اختياراتك", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
            ManageAssetTblForm mngFrm = new ManageAssetTblForm(assetsQry);
            mngFrm.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}