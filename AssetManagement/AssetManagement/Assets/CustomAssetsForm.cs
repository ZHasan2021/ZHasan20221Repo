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
using static AssetManagement.AssetMngDbDataSet;

namespace AssetManagement.Assets
{
    public partial class CustomAssetsForm : Form
    {
        IQueryable<AssetTbl> assetsQry = null;
        int parentForm = 0;

        public CustomAssetsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 1: AssetTbl
        /// 2: AssetMovementTbl
        /// 3: AssetTransactionTbl
        /// </summary>
        /// <param name="parentForm"></param>
        public CustomAssetsForm(int parentFormParam)
        {
            parentForm = parentFormParam;
            InitializeComponent();
        }

        private void CustomAssetsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SubDepartmentVw' table. You can move, or remove it, as needed.
            this.subDepartmentVwTableAdapter.Fill(this.assetMngDbDataSet.SubDepartmentVw);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.DepartmentVw' table. You can move, or remove it, as needed.
            this.departmentVwTableAdapter.Fill(this.assetMngDbDataSet.DepartmentVw);
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

            if (StaticCode.activeUserRole.IsSectionIndependent != true)
            {
                try
                {
                    searchBySectionLookUpEdit.EditValue = StaticCode.activeUser.UserSection;
                    searchBySectionRadioButton.Enabled = searchBySectionLookUpEdit.Enabled = false;

                    List<int> IDsIncluded = StaticCode.mainDbContext.DepartmentTbls.Where(dpt1 => dpt1.SectionOfDepartment == StaticCode.activeUser.UserSection).Select(dpt2 => dpt2.ID).ToList();
                    string plusQry = "";
                    if (IDsIncluded.Count() == 0)
                        plusQry = " WHERE 1 > 2;";
                    else
                    {
                        foreach (int oneID in IDsIncluded)
                            plusQry += oneID + ", ";
                        plusQry = $" WHERE [معرف القسم] IN ({ plusQry.Trim().Trim(',').Trim()});";
                    }
                    DepartmentVwDataTable customVw = this.assetMngDbDataSet.DepartmentVw;
                    for (int i = 0; i < customVw.Rows.Count; i++)
                    {
                        try
                        {
                            var oneRow = customVw.Rows[i];
                            object[] oneRowItemArray = oneRow.ItemArray;
                            if (IDsIncluded.IndexOf(Convert.ToInt32(oneRowItemArray[0])) == -1)
                                customVw.Rows.Remove(oneRow);
                        }
                        catch
                        {
                            this.departmentVwTableAdapter.FillByQuery(customVw, " WHERE 1 > 2;");
                            return;
                        }
                    }
                    this.departmentVwTableAdapter.FillByQuery(customVw, plusQry);

                    List<int> IDsIncluded2 = StaticCode.mainDbContext.SubDepartmentTbls.Where(sdpt1 => IDsIncluded.Contains(sdpt1.MainDepartment)).Select(sdpt2 => sdpt2.ID).ToList();
                    string plusQry2 = "";
                    if (IDsIncluded2.Count() == 0)
                        plusQry2 = " WHERE 1 > 2;";
                    else
                    {
                        foreach (int oneID in IDsIncluded2)
                            plusQry2 += oneID + ", ";
                        plusQry2 = $" WHERE [معرف الوحدة] IN ({ plusQry2.Trim().Trim(',').Trim()});";
                    }
                    SubDepartmentVwDataTable customVw2 = this.assetMngDbDataSet.SubDepartmentVw;
                    for (int i = 0; i < customVw2.Rows.Count; i++)
                    {
                        try
                        {
                            var oneRow = customVw2.Rows[i];
                            object[] oneRowItemArray = oneRow.ItemArray;
                            if (IDsIncluded2.IndexOf(Convert.ToInt32(oneRowItemArray[0])) == -1)
                                customVw2.Rows.Remove(oneRow);
                        }
                        catch
                        {
                            this.subDepartmentVwTableAdapter.FillByQuery(customVw2, " WHERE 1 > 2;");
                            return;
                        }
                    }
                    this.subDepartmentVwTableAdapter.FillByQuery(customVw2, plusQry2);
                }
                catch
                {

                }
            }
            if (StaticCode.activeUserRole.IsDepartmentIndependent != true)
            {
                try
                {
                    searchBySectionLookUpEdit.EditValue = StaticCode.mainDbContext.DepartmentTbls.Single(dpt1 => dpt1.ID == StaticCode.activeUser.UserDept).SectionOfDepartment;
                    searchByDepartmentSearchLookUpEdit.EditValue = StaticCode.activeUser.UserDept;
                    searchBySectionRadioButton.Enabled = searchBySectionLookUpEdit.Enabled = searchByDepartmentRadioButton.Enabled = searchByDepartmentSearchLookUpEdit.Enabled = false;

                    List<int> IDsIncluded2 = StaticCode.mainDbContext.SubDepartmentTbls.Where(sdpt1 => sdpt1.MainDepartment == StaticCode.activeUser.UserDept).Select(sdpt2 => sdpt2.ID).ToList();
                    string plusQry2 = "";
                    if (IDsIncluded2.Count() == 0)
                        plusQry2 = " WHERE 1 > 2;";
                    else
                    {
                        foreach (int oneID in IDsIncluded2)
                            plusQry2 += oneID + ", ";
                        plusQry2 = $" WHERE [معرف الوحدة] IN ({ plusQry2.Trim().Trim(',').Trim()});";
                    }
                    SubDepartmentVwDataTable customVw2 = this.assetMngDbDataSet.SubDepartmentVw;
                    for (int i = 0; i < customVw2.Rows.Count; i++)
                    {
                        try
                        {
                            var oneRow = customVw2.Rows[i];
                            object[] oneRowItemArray = oneRow.ItemArray;
                            if (IDsIncluded2.IndexOf(Convert.ToInt32(oneRowItemArray[0])) == -1)
                                customVw2.Rows.Remove(oneRow);
                        }
                        catch
                        {
                            this.subDepartmentVwTableAdapter.FillByQuery(customVw2, " WHERE 1 > 2;");
                            return;
                        }
                    }
                    this.subDepartmentVwTableAdapter.FillByQuery(customVw2, plusQry2);
                }
                catch
                {

                }
            }
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 500);
        }

        private void searchInDeptRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchBySectionLookUpEdit.Visible = searchBySectionRadioButton.Checked;
            searchByDepartmentSearchLookUpEdit.Visible = searchByDepartmentRadioButton.Checked;
            searchBySubDepartmentSearchLookUpEdit.Visible = searchBySubDepartmentRadioButton.Checked;
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
            if (searchByDepartmentRadioButton.Checked && searchByDepartmentSearchLookUpEdit.EditValue == null)
            {
                MessageBox.Show("اختر القسم أولاً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mainAlertControl.Show(this, "اختر القسم أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (searchBySubDepartmentRadioButton.Checked && searchBySubDepartmentSearchLookUpEdit.EditValue == null)
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
                List<int> sdptQry = (from sdep1 in StaticCode.mainDbContext.SubDepartmentTbls where sdep1.MainDepartment == Convert.ToInt32(searchByDepartmentSearchLookUpEdit.EditValue) select sdep1.ID).ToList();
                assetsQry = from qry in assetsQry where sdptQry.Contains(qry.AssetSubDepartment) select qry;
            }
            if (searchBySubDepartmentRadioButton.Checked)
            {
                assetsQry = from qry in assetsQry where qry.AssetSubDepartment == Convert.ToInt32(searchBySubDepartmentSearchLookUpEdit.EditValue) select qry;
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
            switch (parentForm)
            {
                case 1:
                    ManageAssetTblForm mngAssetFrm = new ManageAssetTblForm(assetsQry);
                    mngAssetFrm.ShowDialog();
                    break;
                case 2:
                    ManageAssetMovementTblForm mngAssetMvFrm = new ManageAssetMovementTblForm(assetsQry);
                    mngAssetMvFrm.ShowDialog();
                    break;
                case 3:
                    ManageAssetTransactionTblForm mngAssetTrFrm = new ManageAssetTransactionTblForm(assetsQry);
                    mngAssetTrFrm.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}