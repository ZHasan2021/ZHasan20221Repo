using AssetManagement.AuxTables;
using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AssetManagement.AssetMngDbDataSet;

namespace AssetManagement.Finance
{
    public partial class FinancialReportsForm : Form
    {
        IQueryable<FinancialItemVw> financialItemsQryVw = null;
        int reportLevel = 0;
        string reportSectionName = "";
        string reportDeptName = "";
        string reportSubDeptName = "";
        bool isDurationReport = false;
        DateTime fromDate = DateTime.Today;
        DateTime toDate = DateTime.Today;

        public FinancialReportsForm()
        {
            InitializeComponent();
        }

        private void FinancialReportsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SubDepartmentVw' table. You can move, or remove it, as needed.
            this.subDepartmentVwTableAdapter.Fill(this.assetMngDbDataSet.SubDepartmentVw);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.DepartmentVw' table. You can move, or remove it, as needed.
            this.departmentVwTableAdapter.Fill(this.assetMngDbDataSet.DepartmentVw);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.FinancialItemVw' table. You can move, or remove it, as needed.
            this.financialItemVwTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemVw);
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
                    if (StaticCode.activeUserRole.IsDepartmentIndependent == true)
                    {
                        searchAllRadioButton.Checked = searchAllRadioButton.Enabled = false;
                        searchBySectionLookUpEdit.EditValue = StaticCode.activeUser.UserSection;
                        searchBySectionCheckBox.Checked = true;
                        searchBySectionLookUpEdit.Enabled = searchBySectionCheckBox.Enabled = false;
                    }
                    else
                    {
                        searchAllRadioButton.Checked = searchAllRadioButton.Enabled = false;
                        searchBySectionLookUpEdit.EditValue = StaticCode.mainDbContext.DepartmentTbls.Single(dpt1 => dpt1.ID == Convert.ToInt32(StaticCode.activeUser.UserDept)).SectionOfDepartment;
                        searchBySectionCheckBox.Checked = true;
                        searchByDepartmentSearchLookUpEdit.EditValue = StaticCode.activeUser.UserDept;
                        searchByDepartmentCheckBox.Checked = true;
                        searchBySectionLookUpEdit.Enabled = searchBySectionCheckBox.Enabled = searchByDepartmentSearchLookUpEdit.Enabled = searchByDepartmentCheckBox.Enabled = false;
                    }
                }
                catch
                {

                }
            }
        }

        private void FinancialReportsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(StaticCode.DetailedFinancialReportPath))
                File.Delete(StaticCode.DetailedFinancialReportPath);
            if (File.Exists(StaticCode.ExpensesAnalysisReportPath))
                File.Delete(StaticCode.ExpensesAnalysisReportPath);
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 500);
        }

        /// <summary>
        /// 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchFinancialItemDropDownButton_Click(object sender, EventArgs e)
        {
            progressPanel1.Visible = true;

            #region Set and apply the financial items query
            reportSectionName = "";
            reportDeptName = "";
            reportSubDeptName = "";
            if (!(searchAllRadioButton.Checked || searchBySectionCheckBox.Checked || searchByDepartmentCheckBox.Checked || searchBySubDepartmentCheckBox.Checked))
            {
                mainAlertControl.Show(this, "اختر البحث حسب أحد المستويات الإدارية أولاً", StaticCode.ApplicationTitle);
                MessageBox.Show("اختر البحث حسب أحد المستويات الإدارية أولاً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressPanel1.Visible = false;
                return;
            }

            if (searchWithinPeriodCheckBox.Checked)
            {
                if (fromToRadioButton.Checked)
                {
                    if (fromDateDateEdit.EditValue == null)
                    {
                        mainAlertControl.Show(this, "اكتب تاريخ البداية", StaticCode.ApplicationTitle);
                        MessageBox.Show("اكتب تاريخ البداية", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        progressPanel1.Visible = false;
                        return;
                    }
                    if (toDateDateEdit.EditValue == null)
                    {
                        mainAlertControl.Show(this, "اكتب تاريخ النهاية", StaticCode.ApplicationTitle);
                        MessageBox.Show("اكتب تاريخ النهاية", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        progressPanel1.Visible = false;
                        return;
                    }
                    if (Convert.ToDateTime(fromDateDateEdit.EditValue) > Convert.ToDateTime(toDateDateEdit.EditValue))
                    {
                        mainAlertControl.Show(this, "تاريخ البداية أحدث من تاريخ النهاية", StaticCode.ApplicationTitle);
                        MessageBox.Show("تاريخ البداية أحدث من تاريخ النهاية", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        progressPanel1.Visible = false;
                        return;
                    }
                }
            }
            if (searchByCurrencyCheckBox.Checked && searchByCurrencyLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر العملة أولاً", StaticCode.ApplicationTitle);
                MessageBox.Show("اختر العملة أولاً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressPanel1.Visible = false;
                return;
            }

            financialItemsQryVw = StaticCode.mainDbContext.FinancialItemVws.Select(fiv1 => fiv1);
            reportLevel = 1;
            if (searchBySectionCheckBox.Checked)
            {
                if (searchBySectionLookUpEdit.EditValue == null)
                {
                    mainAlertControl.Show(this, "حدد الدائرة أولاً", StaticCode.ApplicationTitle);
                    progressPanel1.Visible = false;
                    return;
                }
                else
                {
                    financialItemsQryVw = financialItemsQryVw.Where(fi1 => fi1.الدائرة == searchBySectionLookUpEdit.Text);
                    reportSectionName = searchBySectionLookUpEdit.Text;
                    reportLevel = 2;
                }
            }
            if (searchByDepartmentCheckBox.Checked)
            {
                if (searchByDepartmentSearchLookUpEdit.EditValue == null)
                {
                    mainAlertControl.Show(this, "حدد القسم أولاً", StaticCode.ApplicationTitle);
                    progressPanel1.Visible = false;
                    return;
                }
                else
                {
                    financialItemsQryVw = financialItemsQryVw.Where(fi1 => fi1.القسم == searchByDepartmentSearchLookUpEdit.Text);
                    reportDeptName = searchByDepartmentSearchLookUpEdit.Text;
                    reportLevel = 3;
                }
            }
            if (searchBySubDepartmentCheckBox.Checked)
            {
                if (searchBySubDepartmentSearchLookUpEdit.EditValue == null)
                {
                    mainAlertControl.Show(this, "حدد الوحدة أولاً", StaticCode.ApplicationTitle);
                    progressPanel1.Visible = false;
                    return;
                }
                else
                {
                    financialItemsQryVw = financialItemsQryVw.Where(fi1 => fi1.الوحدة == searchBySubDepartmentSearchLookUpEdit.Text);
                    reportSubDeptName = searchBySubDepartmentSearchLookUpEdit.Text;
                    reportLevel = 4;
                }
            }
            var financialItemsQryVw_Prev = financialItemsQryVw.Where(fiit1 => fiit1.تاريخ_تحرير_السجل < fromDate);
            if (searchWithinPeriodCheckBox.Checked)
            {
                fromDate = DateTime.Today;
                toDate = DateTime.Today;
                if (fromToRadioButton.Checked)
                {
                    fromDate = Convert.ToDateTime(fromDateDateEdit.EditValue);
                    toDate = Convert.ToDateTime(toDateDateEdit.EditValue);
                }
                else if (monthlyRadioButton.Checked)
                {
                    fromDate = new DateTime(monthlyDateTimePicker.Value.Year, monthlyDateTimePicker.Value.Month, 1);
                    toDate = new DateTime(monthlyDateTimePicker.Value.Year, monthlyDateTimePicker.Value.Month, DateTime.DaysInMonth(monthlyDateTimePicker.Value.Year, monthlyDateTimePicker.Value.Month));
                }
                else if (annualRadioButton.Checked)
                {
                    fromDate = new DateTime(annualDateTimePicker.Value.Year, 1, 1);
                    toDate = new DateTime(annualDateTimePicker.Value.Year, 12, 31);
                }
                financialItemsQryVw = financialItemsQryVw.Where(fi => fi.تاريخ_تحرير_السجل >= fromDate && fi.تاريخ_تحرير_السجل <= toDate);
            }
            if (searchByCurrencyCheckBox.Checked)
            {
                financialItemsQryVw = financialItemsQryVw.Where(fi => fi.العملة == searchByCurrencyLookUpEdit.Text);
                financialItemsQryVw_Prev = financialItemsQryVw_Prev.Where(fi => fi.العملة == searchByCurrencyLookUpEdit.Text);
            }
            bool resultsFound = financialItemsQryVw.Any();
            exportFinancialReportToExcelDropDownButton.Enabled = financialReportTabControl.Visible = resultsFound;
            #endregion

            if (!resultsFound)
            {
                mainAlertControl.Show(this, "لا يوجد سجلات مالية ضمن اختياراتك", StaticCode.ApplicationTitle);
                MessageBox.Show("لا يوجد سجلات مالية ضمن اختياراتك", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressPanel1.Visible = false;
                return;
            }
            #region Fille the report's tbale
            List<int> IDsIncluded = financialItemsQryVw.Select(fii1 => fii1.معرف_السجل_المالي).ToList();
            string plusQry = "";
            if (IDsIncluded.Count() == 0)
                plusQry = " WHERE 1 > 2;";
            else
            {
                foreach (int oneID in IDsIncluded)
                    plusQry += oneID + ", ";
                plusQry = $" WHERE [معرف السجل المالي] IN ({ plusQry.Trim().Trim(',').Trim()});";
            }
            FinancialItemVwDataTable customVw = this.assetMngDbDataSet.FinancialItemVw;
            for (int i = 0; i < customVw.Rows.Count; i++)
            {
                Application.DoEvents();
                try
                {
                    var oneRow = customVw.Rows[i];
                    object[] oneRowItemArray = oneRow.ItemArray;
                    if (IDsIncluded.IndexOf(Convert.ToInt32(oneRowItemArray[0])) == -1)
                        customVw.Rows.Remove(oneRow);
                }
                catch
                {
                    this.financialItemVwTableAdapter.FillByQuery(customVw, " WHERE 1 > 2;");
                    progressPanel1.Visible = false;
                    return;
                }
            }
            this.financialItemVwTableAdapter.FillByQuery(customVw, plusQry);
            #endregion

            if (!financialItemsQryVw.Any())
            {
                mainAlertControl.Show(this, "لا يوجد سجلات مالية ضمن اختياراتك", StaticCode.ApplicationTitle);
                MessageBox.Show("لا يوجد سجلات مالية ضمن اختياراتك", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressPanel1.Visible = false;
                return;
            }

            #region Prepare the totals of each sub-level by currency
            if (searchAllRadioButton.Checked)
            {
                reportLevel = 1;
            }
            if (searchBySectionCheckBox.Checked)
            {
                reportLevel = 2;
            }
            if (searchByDepartmentCheckBox.Checked)
            {
                reportLevel = 3;
            }
            if (searchBySubDepartmentCheckBox.Checked)
            {
                reportLevel = 4;
            }
            subLevelTotalsTreeView.Visible = reportLevel < 4;
            subLevelTotalsTreeView.Nodes.Clear();
            totalIncomesNumericUpDown.Value = Convert.ToDecimal(financialItemsQryVw.CalcIncomingOfFinancialItems());
            totalOutcomesNumericUpDown.Value = Convert.ToDecimal(financialItemsQryVw.CalcOutgoingOfFinancialItems());
            totalCycledNumericUpDown.Value = Convert.ToDecimal(financialItemsQryVw.CalcRecycledOfFinancialItems());

            switch (reportLevel)
            {
                case 1:
                    var subLevelQuery1 = StaticCode.mainDbContext.SectionTbls;
                    foreach (SectionTbl oneItem in subLevelQuery1)
                    {
                        Application.DoEvents();
                        List<int> dptQry = (from dpt1 in StaticCode.mainDbContext.DepartmentTbls where dpt1.SectionOfDepartment == oneItem.ID select dpt1.ID).ToList();
                        List<int> sdptQry = (from sdep1 in StaticCode.mainDbContext.SubDepartmentTbls where dptQry.Contains(sdep1.MainDepartment) select sdep1.ID).ToList();
                        var levelQry1 = financialItemsQryVw.Where(fiv1 => fiv1.الدائرة == oneItem.SectionName);

                        TreeNode oneNode = subLevelTotalsTreeView.Nodes.Add(oneItem.SectionName);
                        oneNode.Nodes.Add($"الوارد: {levelQry1.CalcIncomingOfFinancialItems()}");
                        oneNode.Nodes.Add($"الصادر: {levelQry1.CalcOutgoingOfFinancialItems()}");
                        oneNode.Nodes.Add($"المدور: {levelQry1.CalcRecycledOfFinancialItems()}");
                    }
                    break;
                case 2:
                    var subLevelQuery2 = StaticCode.mainDbContext.DepartmentTbls.Where(dpt1 => dpt1.SectionOfDepartment == Convert.ToInt32(searchBySectionLookUpEdit.EditValue));
                    foreach (DepartmentTbl oneItem in subLevelQuery2)
                    {
                        Application.DoEvents();
                        List<int> sdptQry = (from sdep1 in StaticCode.mainDbContext.SubDepartmentTbls where sdep1.MainDepartment == oneItem.ID select sdep1.ID).ToList();
                        var levelQry2 = financialItemsQryVw.Where(fiv2 => fiv2.القسم == oneItem.DepartmentName);

                        TreeNode oneNode = subLevelTotalsTreeView.Nodes.Add(oneItem.DepartmentName);
                        oneNode.Nodes.Add($"الوارد: {levelQry2.CalcIncomingOfFinancialItems()}");
                        oneNode.Nodes.Add($"الصادر: {levelQry2.CalcOutgoingOfFinancialItems()}");
                        oneNode.Nodes.Add($"المدور: {levelQry2.CalcRecycledOfFinancialItems()}");
                    }
                    break;
                case 3:
                    var subLevelQuery3 = StaticCode.mainDbContext.SubDepartmentTbls.Where(sdpt1 => sdpt1.MainDepartment == Convert.ToInt32(searchByDepartmentSearchLookUpEdit.EditValue));
                    foreach (SubDepartmentTbl oneItem in subLevelQuery3)
                    {
                        Application.DoEvents();
                        var levelQry3 = financialItemsQryVw.Where(fiv3 => fiv3.الوحدة == oneItem.SubDepartmentName);

                        TreeNode oneNode = subLevelTotalsTreeView.Nodes.Add(oneItem.SubDepartmentName);
                        oneNode.Nodes.Add($"الوارد: {levelQry3.CalcIncomingOfFinancialItems()}");
                        oneNode.Nodes.Add($"الصادر: {levelQry3.CalcOutgoingOfFinancialItems()}");
                        oneNode.Nodes.Add($"المدور: {levelQry3.CalcRecycledOfFinancialItems()}");
                    }
                    break;
                default:
                    break;
            }
            subLevelTotalsTreeView.ExpandAll();
            #endregion

            #region Prepare the excel details of each sub-level by currency
            string financialReportXlsx = StaticCode.DetailedFinancialReportPath;
            if (File.Exists(financialReportXlsx))
                File.Delete(financialReportXlsx);
            ExcelPackage detailedFinancialReportEp = new ExcelPackage(new FileInfo(financialReportXlsx));
            ExcelWorkbook detailedFinancialReportWb = detailedFinancialReportEp.Workbook;

            foreach (string oneCurr in StaticCode.mainDbContext.CurrencyTbls.Select(cur1 => cur1.CurrencyName).ToList())
            {
                Application.DoEvents();

                #region Prepare the reports' variables
                var financialItemsQryVw_OneCurr = financialItemsQryVw.Where(asvcu1 => asvcu1.العملة == oneCurr);
                var financialItemsQryVw_OneCurr_Prev = financialItemsQryVw_Prev.Where(asvcu1 => asvcu1.العملة == oneCurr);
                if (!financialItemsQryVw_OneCurr.Any())
                    continue;
                string sheet_Title_Name1 = "";
                string sheet_Title_Name1_short = "";
                string sheet_Title_Name2 = "";
                string sheet_Title_Name2_short = "";
                string levelName = StaticCode.PMName;
                var incomingOrDirectOutgoingSubLevelQry = financialItemsQryVw_OneCurr.GetTotalFinancialTableOfLevel(reportLevel, reportSectionName, reportDeptName, reportSubDeptName);
                var incomingOrDirectOutgoingSubLevelQry_Prev = incomingOrDirectOutgoingSubLevelQry.Where(fivp1 => fivp1.تاريخ_تحرير_السجل < fromDate);
                var financialItemsQryVw_OneCurr_Head = financialItemsQryVw_OneCurr;
                var financialItemsQryVw_OneCurr_Head_Prev = financialItemsQryVw_OneCurr_Prev;
                int startRow = 6;
                string generalText = "";
                string levelHeadName = "";
                var financialItemsQryVw_OneCurr_Head1 = financialItemsQryVw_OneCurr.Where(fivh1 => fivh1.الدائرة == StaticCode.PMName && fivh1.القسم == StaticCode.PMName && fivh1.الوحدة == StaticCode.PMName);
                var financialItemsQryVw_OneCurr_Head1_Prev = financialItemsQryVw_OneCurr_Prev.Where(fivh1 => fivh1.الدائرة == StaticCode.PMName && fivh1.القسم == StaticCode.PMName && fivh1.الوحدة == StaticCode.PMName);
                switch (reportLevel)
                {
                    case 1:
                        sheet_Title_Name1 = "السجل المالي العام للـ " + StaticCode.PMName;
                        sheet_Title_Name1_short = "عام " + StaticCode.PMName;
                        sheet_Title_Name2 = "السجل المالي التفصيلي لل " + StaticCode.PMName;
                        sheet_Title_Name2_short = "تفصيلي " + StaticCode.PMName;
                        levelName = StaticCode.PMName;
                        financialItemsQryVw_OneCurr_Head = financialItemsQryVw_OneCurr.Where(fivh1 => fivh1.الدائرة == StaticCode.PMName && fivh1.القسم == StaticCode.PMName && fivh1.الوحدة == StaticCode.PMName);
                        financialItemsQryVw_OneCurr_Head_Prev = financialItemsQryVw_OneCurr_Prev.Where(fivh1 => fivh1.الدائرة == StaticCode.PMName && fivh1.القسم == StaticCode.PMName && fivh1.الوحدة == StaticCode.PMName);
                        generalText = StaticCode.PMName;
                        levelHeadName = "الـ " + StaticCode.PMName;
                        financialItemsQryVw_OneCurr_Head1 = financialItemsQryVw_OneCurr.Where(fivh1 => fivh1.الدائرة == StaticCode.PMName && fivh1.القسم == StaticCode.PMName && fivh1.الوحدة == StaticCode.PMName);
                        financialItemsQryVw_OneCurr_Head1_Prev = financialItemsQryVw_OneCurr_Prev.Where(fivhp1 => fivhp1.الدائرة == StaticCode.PMName && fivhp1.القسم == StaticCode.PMName && fivhp1.الوحدة == StaticCode.PMName);
                        break;
                    case 2:
                        sheet_Title_Name1 = "السجل المالي العام للدائرة";
                        sheet_Title_Name1_short = "عام دائرة";
                        sheet_Title_Name2 = "السجل المالي التفصيلي للدائرة";
                        sheet_Title_Name2_short = "تفصيلي دائرة";
                        levelName = reportSectionName;
                        financialItemsQryVw_OneCurr_Head = financialItemsQryVw_OneCurr.Where(fivh2 => fivh2.القسم == reportDeptName && fivh2.الوحدة == reportSubDeptName);
                        financialItemsQryVw_OneCurr_Head_Prev = financialItemsQryVw_OneCurr_Prev.Where(fivh2 => fivh2.القسم == reportDeptName && fivh2.الوحدة == reportSubDeptName);
                        generalText = searchBySectionLookUpEdit.Text;
                        levelHeadName = "رئيس الدائرة";
                        financialItemsQryVw_OneCurr_Head1 = financialItemsQryVw_OneCurr.Where(fivh1 => fivh1.القسم == "" && fivh1.الوحدة == "");
                        financialItemsQryVw_OneCurr_Head1_Prev = financialItemsQryVw_OneCurr_Prev.Where(fivhp1 => fivhp1.القسم == "" && fivhp1.الوحدة == "");
                        break;
                    case 3:
                        sheet_Title_Name1 = "السجل المالي العام للقسم";
                        sheet_Title_Name1_short = "عام قسم";
                        sheet_Title_Name2 = "السجل المالي التفصيلي للقسم";
                        sheet_Title_Name2_short = "تفصيلي قسم";
                        levelName = reportDeptName;
                        financialItemsQryVw_OneCurr_Head = financialItemsQryVw_OneCurr.Where(fivh3 => fivh3.الوحدة == reportSubDeptName);
                        financialItemsQryVw_OneCurr_Head_Prev = financialItemsQryVw_OneCurr_Prev.Where(fivh3 => fivh3.الوحدة == reportSubDeptName);
                        generalText = searchByDepartmentSearchLookUpEdit.Text;
                        levelHeadName = "رئيس القسم";
                        financialItemsQryVw_OneCurr_Head1 = financialItemsQryVw_OneCurr.Where(fivh1 => fivh1.الوحدة == "");
                        financialItemsQryVw_OneCurr_Head1_Prev = financialItemsQryVw_OneCurr_Prev.Where(fivhp1 => fivhp1.الوحدة == "");
                        break;
                    case 4:
                        sheet_Title_Name1 = "السجل المالي العام للوحدة";
                        sheet_Title_Name1_short = "عام وحدة";
                        sheet_Title_Name2 = "السجل المالي التفصيلي للوحدة";
                        sheet_Title_Name2_short = "تفصيلي وحدة";
                        levelName = reportSubDeptName;
                        generalText = searchBySubDepartmentSearchLookUpEdit.Text;
                        levelHeadName = "رئيس الوحدة";
                        financialItemsQryVw_OneCurr_Head1 = financialItemsQryVw_OneCurr.Where(fivh1 => fivh1.الوحدة == searchBySubDepartmentSearchLookUpEdit.Text);
                        financialItemsQryVw_OneCurr_Head1_Prev = financialItemsQryVw_OneCurr_Prev.Where(fivhp1 => fivhp1.الوحدة == searchBySubDepartmentSearchLookUpEdit.Text);
                        break;
                    default:
                        break;
                }
                sheet_Title_Name1_short += " - " + oneCurr;
                sheet_Title_Name2_short += " - " + oneCurr;

                double totalIncoming_HeadSubLevel = financialItemsQryVw_OneCurr_Head.CalcIncomingOfFinancialItems();
                double totalOutgoing_HeadSubLevel = financialItemsQryVw_OneCurr_Head.CalcOutgoingOfFinancialItems();
                var directOutgoingSubLevelQry = financialItemsQryVw_OneCurr.Where(idoufv => idoufv.وارد_أم_صادر == "صادر" && idoufv.نوع_الصادر == "صادرات مباشرة");
                double totalRecycled_HeadSubLevel = financialItemsQryVw_OneCurr_Head.CalcRecycledOfFinancialItems();
                double totalRecycled_HeadSubLevel_Prev = financialItemsQryVw_OneCurr_Head_Prev.CalcRecycledOfFinancialItems();
                #endregion

                #region General financial report
                ExcelWorksheet generalFinancialReportWs = detailedFinancialReportWb.Worksheets.Add(sheet_Title_Name1_short);
                generalFinancialReportWs.View.ShowGridLines = false;
                generalFinancialReportWs.View.RightToLeft = true;
                generalFinancialReportWs.Column(2).Width =
                generalFinancialReportWs.Column(5).Width = 13;
                generalFinancialReportWs.Column(3).Width = 47;
                generalFinancialReportWs.Column(6).Width =
                generalFinancialReportWs.Column(7).Width = 29;
                using (var cells = generalFinancialReportWs.Cells[2, 2, 3, 7])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 18.0F;
                    cells.Merge = true;
                    cells.Style.Font.Bold = true;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(248, 203, 173));
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Thick);
                    cells.Value = sheet_Title_Name1;
                }

                generalFinancialReportWs.Row(startRow).Height = 27;
                using (var cells = generalFinancialReportWs.Cells[startRow, 2, startRow, 7])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 14.0F;
                    cells.Merge = true;
                    cells.Style.Font.Bold = true;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                    cells.Value = generalText;
                }
                startRow += 2;

                #region Incoming of sub-level
                var incoming_HeadSubLevelQry1 = financialItemsQryVw_OneCurr_Head1.Where(fiv1 => fiv1.وارد_أم_صادر == "وارد").OrderByDescending(fiv11 => fiv11.جهة_الإيراد);
                double totalIncomingSubLevel1 = financialItemsQryVw_OneCurr_Head1.CalcIncomingOfFinancialItems();

                int incomingRow1 = startRow;
                using (var cells = generalFinancialReportWs.Cells[incomingRow1, 2])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    cells.Value = "إيرادات";
                }
                using (var cells = generalFinancialReportWs.Cells[incomingRow1, 3])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    cells.Value = "جهة الإيراد";
                }
                incomingRow1++;
                foreach (var oneSubItem in incoming_HeadSubLevelQry1)
                {
                    using (var cells = generalFinancialReportWs.Cells[incomingRow1, 2])
                    {
                        cells.Style.Font.Name = "Calibri";
                        cells.Style.Font.Size = 11.0F;
                        cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                        cells.Value = oneSubItem.المبلغ_الوارد;
                    }
                    using (var cells = generalFinancialReportWs.Cells[incomingRow1, 3])
                    {
                        cells.Style.Font.Name = "Calibri";
                        cells.Style.Font.Size = 11.0F;
                        cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(214, 220, 228));
                        cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                        cells.Value = oneSubItem.جهة_الإيراد;
                    }
                    incomingRow1++;
                }
                using (var cells = generalFinancialReportWs.Cells[incomingRow1, 2])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                    cells.Value = Math.Round(totalIncomingSubLevel1);
                }
                using (var cells = generalFinancialReportWs.Cells[incomingRow1, 3])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                    cells.Value = "مجموع إيرادات " + levelHeadName;
                }
                incomingRow1++;
                #endregion

                #region Outgoing of sub-level
                var outgoing_HeadSubLevelQry1 = financialItemsQryVw_OneCurr_Head1.Where(fiv2 => fiv2.وارد_أم_صادر == "صادر").OrderByDescending(fiv22 => fiv22.نوع_الصادر);
                double totalOutgoing_HeadSubLevel1 = financialItemsQryVw_OneCurr_Head1.CalcOutgoingOfFinancialItems();

                int outgoingRow = startRow;
                using (var cells = generalFinancialReportWs.Cells[outgoingRow, 5])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    cells.Value = "صادرات";
                }
                using (var cells = generalFinancialReportWs.Cells[outgoingRow, 6])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    cells.Value = "نوع الصادرات";
                }
                using (var cells = generalFinancialReportWs.Cells[outgoingRow, 7])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    cells.Value = "صادر إلى";
                }
                outgoingRow++;
                foreach (var oneSubItem in outgoing_HeadSubLevelQry1)
                {
                    using (var cells = generalFinancialReportWs.Cells[outgoingRow, 5])
                    {
                        cells.Style.Font.Name = "Calibri";
                        cells.Style.Font.Size = 11.0F;
                        cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                        cells.Value = oneSubItem.المبلغ_الصادر;
                    }
                    using (var cells = generalFinancialReportWs.Cells[outgoingRow, 6])
                    {
                        cells.Style.Font.Name = "Calibri";
                        cells.Style.Font.Size = 11.0F;
                        cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(214, 220, 228));
                        cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                        cells.Value = oneSubItem.نوع_الصادر;
                    }
                    using (var cells = generalFinancialReportWs.Cells[outgoingRow, 7])
                    {
                        cells.Style.Font.Name = "Calibri";
                        cells.Style.Font.Size = 11.0F;
                        cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                        cells.Value = oneSubItem.صادر_إلى;
                    }
                    outgoingRow++;
                }
                using (var cells = generalFinancialReportWs.Cells[outgoingRow, 5])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                    cells.Value = Math.Round(totalOutgoing_HeadSubLevel1);
                }
                using (var cells = generalFinancialReportWs.Cells[outgoingRow, 6, outgoingRow, 7])
                {
                    cells.Merge = true;
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                    cells.Value = $"مجموع صادرات {levelHeadName} (المباشرة والمعلقة)";
                }
                outgoingRow++;
                #endregion

                #region Recycled of sub-level
                int recycledRow1 = incomingRow1 + 1;
                using (var cells = generalFinancialReportWs.Cells[recycledRow1, 2])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                    cells.Value = Math.Round(financialItemsQryVw_OneCurr_Head1.CalcRecycledOfFinancialItems() + ((isDurationReport) ? financialItemsQryVw_OneCurr_Head1_Prev.CalcRecycledOfFinancialItems() : 0));
                }
                using (var cells = generalFinancialReportWs.Cells[recycledRow1, 3])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                    cells.Value = "مدور بيد " + levelHeadName;
                }
                #endregion
                #endregion

                #region Detailed fincnaial report
                ExcelWorksheet detailedFinancialReportWs = detailedFinancialReportWb.Worksheets.Add(sheet_Title_Name2_short);
                detailedFinancialReportWs.View.ShowGridLines = false;
                detailedFinancialReportWs.View.RightToLeft = true;
                detailedFinancialReportWs.View.ZoomScale = 70;
                detailedFinancialReportWs.Column(2).Width = 15;
                detailedFinancialReportWs.Column(3).Width = 35;
                detailedFinancialReportWs.Column(4).Width = 34;
                detailedFinancialReportWs.Column(5).Width = 44;
                detailedFinancialReportWs.Column(6).Width = 41;
                detailedFinancialReportWs.Column(8).Width = 20;
                detailedFinancialReportWs.Column(9).Width =
                detailedFinancialReportWs.Column(10).Width =
                detailedFinancialReportWs.Column(11).Width =
                detailedFinancialReportWs.Column(12).Width =
                detailedFinancialReportWs.Column(13).Width = 20;
                detailedFinancialReportWs.Column(14).Width = 45;
                detailedFinancialReportWs.Column(15).Width = 20;
                detailedFinancialReportWs.Column(16).Width = 30;
                detailedFinancialReportWs.Row(8).Height =
                detailedFinancialReportWs.Row(9).Height =
                detailedFinancialReportWs.Row(10).Height = 22;
                startRow = 6;
                using (var cells = detailedFinancialReportWs.Cells[2, 2, 3, 6])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 18.0F;
                    cells.Merge = true;
                    cells.Style.Font.Bold = true;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(248, 203, 173));
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Thick);
                    cells.Value = sheet_Title_Name2;
                }
                detailedFinancialReportWs.Row(startRow).Height = 27;
                using (var cells = detailedFinancialReportWs.Cells[startRow, 2, startRow, 6])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 14.0F;
                    cells.Merge = true;
                    cells.Style.Font.Bold = true;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                    cells.Value = levelName;
                }
                int finalRow = startRow;

                #region Totals of current level
                int figuresRow = startRow + 2;
                using (var cells = detailedFinancialReportWs.Cells[figuresRow, 2])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(255, 242, 204));
                    cells.Value = Math.Round(totalIncoming_HeadSubLevel);
                }
                string totalIncomingHeadText = "مجموع إيرادات الـ PM";
                string totalOutgoingHeadText = "مجموع صادرات الـ PM المباشرة والمعلقة";
                string recycledHeadText = "مدور بيد الـ PM";
                string totalDirectOutgoingHeadText_Part1 = "إجمالي الصادرات العامة (المباشرة فقط) للـ PM";
                string totalDirectOutgoingHeadText_Part2 = " وتفرعاته";
                switch (reportLevel)
                {
                    case 1:
                        totalIncomingHeadText = "مجموع إيرادات الـ PM";
                        totalOutgoingHeadText = "مجموع صادرات الـ PM المباشرة والمعلقة";
                        recycledHeadText = "مدور بيد الـ PM";
                        totalDirectOutgoingHeadText_Part1 = "إجمالي الصادرات العامة (المباشرة فقط) للـ PM";
                        totalDirectOutgoingHeadText_Part2 = " وتفرعاته";
                        break;
                    case 2:
                        totalIncomingHeadText = "مجموع إيرادات رئيس الدائرة";
                        totalOutgoingHeadText = "مجموع صادرات رئيس الدائرة المباشرة والمعلقة";
                        recycledHeadText = "مدور بيد رئيس الدائرة";
                        totalDirectOutgoingHeadText_Part1 = "إجمالي الصادرات العامة (المباشرة فقط) للدائرة";
                        totalDirectOutgoingHeadText_Part2 = " وتفرعاتها";
                        break;
                    case 3:
                        totalIncomingHeadText = "مجموع إيرادات رئيس القسم";
                        totalOutgoingHeadText = "مجموع صادرات رئيس القسم المباشرة والمعلقة";
                        recycledHeadText = "مدور بيد رئيس القسم";
                        totalDirectOutgoingHeadText_Part1 = "إجمالي الصادرات العامة (المباشرة فقط) للقسم";
                        totalDirectOutgoingHeadText_Part2 = " وتفرعاته";
                        break;
                    case 4:
                        totalIncomingHeadText = "مجموع إيرادات رئيس الوحدة";
                        totalOutgoingHeadText = "مجموع صادرات رئيس الوحدة المباشرة والمعلقة";
                        recycledHeadText = "مدور بيد رئيس الوحدة";
                        totalDirectOutgoingHeadText_Part1 = "إجمالي الصادرات العامة (المباشرة فقط) للوحدة";
                        totalDirectOutgoingHeadText_Part2 = " وتفرعاتها";
                        break;
                    default:
                        break;
                }
                using (var cells = detailedFinancialReportWs.Cells[figuresRow, 3])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(255, 242, 204));
                    cells.Value = totalIncomingHeadText;
                }
                using (var cells = detailedFinancialReportWs.Cells[figuresRow, 5])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                    cells.Value = Math.Round(incomingOrDirectOutgoingSubLevelQry.CalcIncomingOfFinancialItems());
                }
                using (var cells = detailedFinancialReportWs.Cells[figuresRow, 6])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                    cells.Value = "إجمالي الإيرادات العامة";
                }
                using (var cells = detailedFinancialReportWs.Cells[figuresRow + 1, 2])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(255, 230, 153));
                    cells.Value = Math.Round(totalOutgoing_HeadSubLevel);
                }
                using (var cells = detailedFinancialReportWs.Cells[figuresRow + 1, 3])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(255, 230, 153));
                    cells.Value = totalOutgoingHeadText;
                }
                using (var cells = detailedFinancialReportWs.Cells[figuresRow + 1, 5])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(248, 203, 173));
                    cells.Value = Math.Round(incomingOrDirectOutgoingSubLevelQry.CalcOutgoingOfFinancialItems());
                }
                using (var cells = detailedFinancialReportWs.Cells[figuresRow + 1, 6])
                {
                    ExcelRichTextCollection textValue = cells.RichText;
                    ExcelRichText richText1 = textValue.Add(totalDirectOutgoingHeadText_Part1);
                    richText1.Color = Color.Black;
                    ExcelRichText richText2 = textValue.Add(totalDirectOutgoingHeadText_Part2);
                    richText2.Color = Color.Red;
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(248, 203, 173));
                }
                using (var cells = detailedFinancialReportWs.Cells[figuresRow + 2, 2])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.Font.Color.SetColor(Color.Red);
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(198, 224, 180));
                    cells.Value = Math.Round(totalRecycled_HeadSubLevel + ((isDurationReport) ? totalRecycled_HeadSubLevel_Prev : 0));
                }

                using (var cells = detailedFinancialReportWs.Cells[figuresRow + 2, 3])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(198, 224, 180));
                    cells.Value = recycledHeadText;
                }
                using (var cells = detailedFinancialReportWs.Cells[figuresRow + 2, 5])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.Font.Color.SetColor(Color.Red);
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                    cells.Value = Math.Round(incomingOrDirectOutgoingSubLevelQry.CalcRecycledOfFinancialItems() + ((isDurationReport) ? incomingOrDirectOutgoingSubLevelQry_Prev.CalcRecycledOfFinancialItems() : 0));
                }
                using (var cells = detailedFinancialReportWs.Cells[figuresRow + 2, 6])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.Font.Bold = true;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                    cells.Value = "إجمالي المدور العام";
                }
                using (var cells = detailedFinancialReportWs.Cells[figuresRow, 5, figuresRow + 2, 6])
                {
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Medium);
                }
                figuresRow += 6;
                #endregion

                #region Incoming and Direct outgoing of sub-level in detail
                string totalFinancialText = "السجل المالي الكلي للـ PM";
                switch (reportLevel)
                {
                    case 1:
                        totalFinancialText = "السجل المالي الكلي للـ PM";
                        break;
                    case 2:
                        totalFinancialText = "السجل المالي الكلي للدائرة";
                        break;
                    case 3:
                        totalFinancialText = "السجل المالي الكلي للقسم";
                        break;
                    case 4:
                        totalFinancialText = "السجل المالي الكلي للوحدة";
                        break;
                    default:
                        break;
                }
                using (var cells = detailedFinancialReportWs.Cells[startRow, 10, startRow, 12])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 14.0F;
                    cells.Merge = true;
                    cells.Style.Font.Bold = true;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(255, 192, 0));
                    cells.Value = totalFinancialText;
                }
                int tableRow = startRow + 2;
                using (var cells = detailedFinancialReportWs.Cells[tableRow, 9, tableRow, 16])
                {
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 11.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(208, 206, 206));
                }
                detailedFinancialReportWs.Cells[tableRow, 9].Value = "الإيرادات العامة";
                detailedFinancialReportWs.Cells[tableRow, 10].Value = "الصادرات العامة";
                detailedFinancialReportWs.Cells[tableRow, 11].Value = "العملة";
                detailedFinancialReportWs.Cells[tableRow, 12].Value = "جهة الإيراد";
                detailedFinancialReportWs.Cells[tableRow, 13].Value = "نوع الصادر";
                detailedFinancialReportWs.Cells[tableRow, 14].Value = "البيان";
                detailedFinancialReportWs.Cells[tableRow, 15].Value = "التاريخ";
                detailedFinancialReportWs.Cells[tableRow, 16].Value = "لربط الخلايا";
                if (incomingOrDirectOutgoingSubLevelQry.Any())
                {
                    using (var cells = detailedFinancialReportWs.Cells[tableRow + 1, 9, tableRow + incomingOrDirectOutgoingSubLevelQry.Count(), 16])
                    {
                        cells.Style.Font.Name = "Calibri";
                        cells.Style.Font.Size = 11.0F;
                        cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    }
                    using (var cells = detailedFinancialReportWs.Cells[tableRow + incomingOrDirectOutgoingSubLevelQry.Count() + 1, 9, tableRow + incomingOrDirectOutgoingSubLevelQry.Count() + 1, 16])
                    {
                        cells.Style.Font.Name = "Calibri";
                        cells.Style.Font.Bold = true;
                        cells.Style.Font.Size = 12.0F;
                        cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        cells.Style.Border.BorderAround(ExcelBorderStyle.Medium);
                        cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(192, 153, 239));
                    }
                    tableRow++;
                    foreach (var oneRec in incomingOrDirectOutgoingSubLevelQry)
                    {
                        detailedFinancialReportWs.Cells[tableRow, 9].Value = oneRec.المبلغ_الوارد;
                        detailedFinancialReportWs.Cells[tableRow, 10].Value = oneRec.المبلغ_الصادر;
                        detailedFinancialReportWs.Cells[tableRow, 11].Value = oneRec.العملة;
                        detailedFinancialReportWs.Cells[tableRow, 12].Value = oneRec.جهة_الإيراد;
                        detailedFinancialReportWs.Cells[tableRow, 13].Value = oneRec.نوع_الصادر;
                        detailedFinancialReportWs.Cells[tableRow, 14].Value = oneRec.بيان_السجل_المالي;
                        detailedFinancialReportWs.Cells[tableRow, 15].Value = oneRec.تاريخ_تحرير_السجل.ToString("d");
                        detailedFinancialReportWs.Cells[tableRow, 16].Value = oneRec.اسم_البند_المالي;
                        tableRow++;
                    }
                    detailedFinancialReportWs.Cells[tableRow, 9].Value = incomingOrDirectOutgoingSubLevelQry.CalcIncomingOfFinancialItems();
                    detailedFinancialReportWs.Cells[tableRow, 10].Value = incomingOrDirectOutgoingSubLevelQry.CalcOutgoingOfFinancialItems();
                    tableRow++;
                    using (var cells = detailedFinancialReportWs.Cells[tableRow, 9])
                    {
                        cells.Style.Font.Name = "Calibri";
                        cells.Style.Font.Bold = true;
                        cells.Style.Font.Size = 12.0F;
                        cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        cells.Style.Border.BorderAround(ExcelBorderStyle.Medium);
                        cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(45, 211, 199));
                        cells.Value = "قيمة المدور العام";
                    }
                    using (var cells = detailedFinancialReportWs.Cells[tableRow, 10])
                    {
                        cells.Style.Font.Name = "Calibri";
                        cells.Style.Font.Bold = true;
                        cells.Style.Font.Size = 12.0F;
                        cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        cells.Style.Border.BorderAround(ExcelBorderStyle.Medium);
                        cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(45, 211, 199));
                        cells.Value = Math.Round(incomingOrDirectOutgoingSubLevelQry.CalcRecycledOfFinancialItems() + ((isDurationReport) ? incomingOrDirectOutgoingSubLevelQry_Prev.CalcRecycledOfFinancialItems() : 0));
                    }
                    tableRow++;
                }
                #endregion

                #region Recycled of sub-levels of current level
                List<string> subLevelNames = new List<string>();
                if (reportLevel <= 3)
                {
                    string detailedRecycledText = "تفصيل المدور العام للـ PM وتفرعاته";
                    switch (reportLevel)
                    {
                        case 1:
                            detailedRecycledText = "تفصيل المدور العام للـ PM وتفرعاته";
                            break;
                        case 2:
                            detailedRecycledText = "تفصيل المدور العام للدائرة وتفرعاتها";
                            break;
                        case 3:
                            detailedRecycledText = "تفصيل المدور العام للقسم وتفرعاته";
                            break;
                        default:
                            break;
                    }
                    using (var cells = detailedFinancialReportWs.Cells[figuresRow, 2, figuresRow, 6])
                    {
                        cells.Style.Font.Name = "Calibri";
                        cells.Style.Font.Size = 14.0F;
                        cells.Merge = true;
                        cells.Style.Font.Bold = true;
                        cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                        cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        cells.Value = detailedRecycledText;
                    }
                    figuresRow++;
                    int allRecycledRow = figuresRow;
                    switch (reportLevel)
                    {
                        case 1:
                            subLevelNames = financialItemsQryVw_OneCurr.Select(sln1 => sln1.الدائرة).Distinct().OrderBy(sln1 => sln1).Distinct().ToList();
                            break;
                        case 2:
                            subLevelNames = financialItemsQryVw_OneCurr.Select(sln2 => sln2.القسم).Distinct().OrderBy(sln2 => sln2).Distinct().ToList();
                            break;
                        case 3:
                            subLevelNames = financialItemsQryVw_OneCurr.Select(sln3 => sln3.الوحدة).Distinct().OrderBy(sln3 => sln3).Distinct().ToList();
                            break;
                        default:
                            break;
                    }
                    using (var cells = detailedFinancialReportWs.Cells[allRecycledRow, 2, allRecycledRow + subLevelNames.Count() - 1, 4])
                    {
                        cells.Style.Font.Name = "Calibri";
                        cells.Style.Font.Size = 11.0F;
                        cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    }
                    using (var cells = detailedFinancialReportWs.Cells[allRecycledRow, 5, allRecycledRow + subLevelNames.Count() - 1, 5])
                    {
                        cells.Style.Font.Name = "Calibri";
                        cells.Style.Font.Size = 14.0F;
                        cells.Merge = true;
                        cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        cells.Value = "المجموع";
                    }
                    using (var cells = detailedFinancialReportWs.Cells[allRecycledRow, 6, allRecycledRow + subLevelNames.Count() - 1, 6])
                    {
                        cells.Style.Font.Name = "Calibri";
                        cells.Style.Font.Size = 14.0F;
                        cells.Merge = true;
                        cells.Style.Font.Bold = true;
                        cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        cells.Value = Math.Round(incomingOrDirectOutgoingSubLevelQry.CalcRecycledOfFinancialItems() + ((isDurationReport) ? incomingOrDirectOutgoingSubLevelQry_Prev.CalcRecycledOfFinancialItems() : 0));
                    }

                    foreach (string oneSLN in subLevelNames)
                    {
                        var subLevelRecords = incomingOrDirectOutgoingSubLevelQry.Where(sln1 => sln1.الدائرة == oneSLN);
                        var subLevelRecords_Prev = incomingOrDirectOutgoingSubLevelQry_Prev.Where(sln1 => sln1.الدائرة == oneSLN);
                        switch (reportLevel)
                        {
                            case 1:
                                subLevelRecords = incomingOrDirectOutgoingSubLevelQry.Where(sln1 => sln1.الدائرة == oneSLN);
                                subLevelRecords_Prev = incomingOrDirectOutgoingSubLevelQry_Prev.Where(sln1 => sln1.الدائرة == oneSLN);
                                break;
                            case 2:
                                subLevelRecords = incomingOrDirectOutgoingSubLevelQry.Where(sln2 => sln2.القسم == oneSLN);
                                subLevelRecords_Prev = incomingOrDirectOutgoingSubLevelQry_Prev.Where(sln2 => sln2.القسم == oneSLN);
                                break;
                            case 3:
                                subLevelRecords = incomingOrDirectOutgoingSubLevelQry.Where(sln3 => sln3.الوحدة == oneSLN);
                                subLevelRecords_Prev = incomingOrDirectOutgoingSubLevelQry_Prev.Where(sln3 => sln3.الوحدة == oneSLN);
                                break;
                            default:
                                break;
                        }
                        string recycledHeadSubText = "";
                        switch (reportLevel)
                        {
                            case 1:
                                recycledHeadSubText = ((oneSLN == StaticCode.PMName) ? "مدور بيد PM" : ("المدور العام لدائرة " + oneSLN));
                                break;
                            case 2:
                                recycledHeadSubText = ((oneSLN == "") ? "مدور بيد رئيس الدائرة" : ("المدور العام لقسم " + oneSLN));
                                break;
                            case 3:
                                recycledHeadSubText = ((oneSLN == "") ? "مدور بيد رئيس القسم" : ("المدور العام لوحدة " + oneSLN));
                                break;
                            default:
                                break;
                        }

                        Application.DoEvents();
                        using (var cells = detailedFinancialReportWs.Cells[allRecycledRow, 2, allRecycledRow, 3])
                        {
                            cells.Style.Font.Name = "Calibri";
                            cells.Style.Font.Size = 11.0F;
                            cells.Style.Font.Bold = true;
                            cells.Merge = true;
                            cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                            cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                            cells.Value = recycledHeadSubText;
                        }
                        using (var cells = detailedFinancialReportWs.Cells[allRecycledRow, 4])
                        {
                            cells.Style.Font.Name = "Calibri";
                            cells.Style.Font.Size = 11.0F;
                            cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                            cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                            cells.Value = Math.Round(subLevelRecords.CalcRecycledOfFinancialItems() + ((isDurationReport) ? subLevelRecords_Prev.CalcRecycledOfFinancialItems() : 0));
                        }
                        detailedFinancialReportWs.Row(allRecycledRow).Height = 22;
                        allRecycledRow++;
                    }
                    figuresRow = allRecycledRow;
                }
                #endregion

                #region Total amounts of sub-levels
                if (reportLevel <= 3)
                {
                    finalRow = figuresRow + 2;
                    string subLevelsOutlineText = "ملخص مختصر لإيرادات وصادرات الـ PM وتفرعاته";
                    switch (reportLevel)
                    {
                        case 1:
                            subLevelsOutlineText = "ملخص مختصر لإيرادات وصادرات الـ PM وتفرعاته";
                            break;
                        case 2:
                            subLevelsOutlineText = "ملخص مختصر لإيرادات وصادرات الدائرة وتفرعاتها";
                            break;
                        case 3:
                            subLevelsOutlineText = "ملخص مختصر لإيرادات وصادرات القسم وتفرعاته";
                            break;
                        default:
                            break;
                    }
                    using (var cells = detailedFinancialReportWs.Cells[finalRow, 2, finalRow, 6])
                    {
                        cells.Style.Font.Name = "Calibri";
                        cells.Style.Font.Size = 14.0F;
                        cells.Merge = true;
                        cells.Style.Font.Bold = true;
                        cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(155, 194, 230));
                        cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        cells.Value = subLevelsOutlineText;
                    }
                    finalRow++;
                    using (var cells = detailedFinancialReportWs.Cells[finalRow, 2, finalRow, 3])
                    {
                        cells.Style.Font.Name = "Calibri";
                        cells.Style.Font.Size = 14.0F;
                        cells.Merge = true;
                        cells.Style.Font.Bold = true;
                        cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                        cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        cells.Value = "المستوى";
                    }
                    using (var cells = detailedFinancialReportWs.Cells[finalRow, 4])
                    {
                        cells.Style.Font.Name = "Calibri";
                        cells.Style.Font.Size = 14.0F;
                        cells.Merge = true;
                        cells.Style.Font.Bold = true;
                        cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                        cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        cells.Value = "إجمالي إيرادات رئيس المستوى";
                    }
                    using (var cells = detailedFinancialReportWs.Cells[finalRow, 5])
                    {
                        cells.Style.Font.Name = "Calibri";
                        cells.Style.Font.Size = 14.0F;
                        cells.Merge = true;
                        cells.Style.Font.Bold = true;
                        cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                        cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        cells.Value = "إجمالي صادرات رئيس المستوى (مباشر ومعلق)";
                    }
                    using (var cells = detailedFinancialReportWs.Cells[finalRow, 6])
                    {
                        cells.Style.Font.Name = "Calibri";
                        cells.Style.Font.Size = 14.0F;
                        cells.Merge = true;
                        cells.Style.Font.Bold = true;
                        cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                        cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        cells.Value = "مدور بيد رئيس المستوى";
                    }
                    finalRow++;
                    foreach (string oneSLN in subLevelNames)
                    {
                        var subLevel_HeadRecords = financialItemsQryVw_OneCurr.GetTotalFinancialTableOfLevel_Default();
                        var subLevel_HeadRecords_Prev = financialItemsQryVw_OneCurr_Prev.GetTotalFinancialTableOfLevel_Default();
                        switch (reportLevel)
                        {
                            case 1:
                                subLevel_HeadRecords = financialItemsQryVw_OneCurr.Where(sln1 => sln1.الدائرة == oneSLN && sln1.القسم == "" && sln1.الوحدة == "");
                                if (oneSLN == StaticCode.PMName)
                                    subLevel_HeadRecords = financialItemsQryVw_OneCurr.Where(sln1 => sln1.الدائرة == StaticCode.PMName && sln1.القسم == StaticCode.PMName && sln1.الوحدة == StaticCode.PMName);
                                subLevel_HeadRecords_Prev = financialItemsQryVw_OneCurr_Prev.Where(sln1 => sln1.الدائرة == oneSLN && sln1.القسم == "" && sln1.الوحدة == "");
                                if (oneSLN == StaticCode.PMName)
                                    subLevel_HeadRecords_Prev = financialItemsQryVw_OneCurr_Prev.Where(sln1 => sln1.الدائرة == StaticCode.PMName && sln1.القسم == StaticCode.PMName && sln1.الوحدة == StaticCode.PMName);
                                break;
                            case 2:
                                subLevel_HeadRecords = financialItemsQryVw_OneCurr.Where(sln2 => sln2.الدائرة == reportSectionName && sln2.القسم == oneSLN && sln2.الوحدة == "");
                                subLevel_HeadRecords_Prev = financialItemsQryVw_OneCurr_Prev.Where(sln2 => sln2.الدائرة == reportSectionName && sln2.القسم == oneSLN && sln2.الوحدة == "");
                                break;
                            case 3:
                                subLevel_HeadRecords = financialItemsQryVw_OneCurr.Where(sln3 => sln3.الدائرة == reportSectionName && sln3.القسم == reportDeptName && sln3.الوحدة == oneSLN);
                                subLevel_HeadRecords_Prev = financialItemsQryVw_OneCurr_Prev.Where(sln3 => sln3.الدائرة == reportSectionName && sln3.القسم == reportDeptName && sln3.الوحدة == oneSLN);
                                break;
                            default:
                                break;
                        }
                        string outlineHeadSubText = "";
                        switch (reportLevel)
                        {
                            case 1:
                                outlineHeadSubText = ((oneSLN == StaticCode.PMName) ? StaticCode.PMName : ("رئيس دائرة " + oneSLN));
                                break;
                            case 2:
                                outlineHeadSubText = ((oneSLN == "") ? "إدارة الدائرة" : ("رئيس قسم " + oneSLN));
                                break;
                            case 3:
                                outlineHeadSubText = ((oneSLN == "") ? "إدارة القسم" : ("رئيس وحدة " + oneSLN));
                                break;
                            default:
                                break;
                        }

                        Application.DoEvents();

                        using (var cells = detailedFinancialReportWs.Cells[finalRow, 2, finalRow, 3])
                        {
                            cells.Style.Font.Name = "Calibri";
                            cells.Style.Font.Size = 11.0F;
                            cells.Merge = true;
                            cells.Style.Font.Bold = true;
                            cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                            cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                            cells.Value = outlineHeadSubText;
                        }
                        using (var cells = detailedFinancialReportWs.Cells[finalRow, 4])
                        {
                            cells.Style.Font.Name = "Calibri";
                            cells.Style.Font.Size = 11.0F;
                            cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                            cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                            cells.Value = Math.Round(subLevel_HeadRecords.CalcIncomingOfFinancialItems());
                        }
                        using (var cells = detailedFinancialReportWs.Cells[finalRow, 5])
                        {
                            cells.Style.Font.Name = "Calibri";
                            cells.Style.Font.Size = 11.0F;
                            cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                            cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                            cells.Value = Math.Round(subLevel_HeadRecords.CalcOutgoingOfFinancialItems());
                        }
                        using (var cells = detailedFinancialReportWs.Cells[finalRow, 6])
                        {
                            cells.Style.Font.Name = "Calibri";
                            cells.Style.Font.Size = 11.0F;
                            cells.Merge = true;
                            cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                            cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                            cells.Value = Math.Round(subLevel_HeadRecords.CalcRecycledOfFinancialItems() + ((isDurationReport) ? subLevel_HeadRecords_Prev.CalcRecycledOfFinancialItems() : 0));
                        }
                        finalRow++;
                    }
                }
                #endregion

                for (int iRow = startRow + 2; iRow <= Math.Max(tableRow, finalRow); iRow++)
                {
                    detailedFinancialReportWs.Row(iRow).Height = 23;
                }
                #endregion

                detailedFinancialReportEp.Save();
            }
            #endregion

            #region Load the excel file to the form
            IWorkbook totalsWorkbook = spreadsheetControl1.Document;
            totalsWorkbook.LoadDocument(financialReportXlsx);
            spreadsheetControl1.ActiveWorksheet.ActiveView.ShowRightToLeft = true;
            #endregion

            #region Prepare the expenses analysis report
            string ExpensesAnalysisReportXlsx = StaticCode.ExpensesAnalysisReportPath;
            if (File.Exists(ExpensesAnalysisReportXlsx))
                File.Delete(ExpensesAnalysisReportXlsx);
            ExcelPackage ExpensesAnalysisReport_Ep = new ExcelPackage(new FileInfo(ExpensesAnalysisReportXlsx));
            ExcelWorkbook ExpensesAnalysisReport_Wb = ExpensesAnalysisReport_Ep.Workbook;
            string fiCaIncoming_WsName = "";
            string fiCaOutgoing_WsName = "";
            string fiCaSubLevelName = "";
            switch (reportLevel)
            {
                case 1:
                    fiCaIncoming_WsName = "بنود واردة - دوائر";
                    fiCaOutgoing_WsName = "بنود صادرة - دوائر";
                    fiCaSubLevelName = "البند المالي / الدائرة";
                    break;
                case 2:
                    fiCaIncoming_WsName = "بنود واردة - أقسام";
                    fiCaOutgoing_WsName = "بنود صادرة - أقسام";
                    fiCaSubLevelName = "البند المالي / القسم";
                    break;
                case 3:
                    fiCaIncoming_WsName = "بنود واردة - وحدات";
                    fiCaOutgoing_WsName = "بنود صادرة - وحدات";
                    fiCaSubLevelName = "البند المالي / الوحدة";
                    break;
                case 4:
                    fiCaIncoming_WsName = "بنود واردة - وحدات";
                    fiCaOutgoing_WsName = "بنود صادرة - وحدات";
                    fiCaSubLevelName = "البند المالي / الوحدة";
                    break;
                default:
                    break;
            }
            ExcelWorksheet fiCaIncoming_Ws = ExpensesAnalysisReport_Wb.Worksheets.Add(fiCaIncoming_WsName);
            ExcelWorksheet fiCaOutgoing_Ws = ExpensesAnalysisReport_Wb.Worksheets.Add(fiCaOutgoing_WsName);

            List<string> subLevelNamesList = new List<string>();
            switch (reportLevel)
            {
                case 1:
                    subLevelNamesList = financialItemsQryVw.Select(fiv1 => fiv1.الدائرة).Distinct().OrderBy(fiv2 => fiv2).ToList();
                    break;
                case 2:
                    subLevelNamesList = financialItemsQryVw.Select(fiv1 => fiv1.القسم).Distinct().OrderBy(fiv2 => fiv2).ToList();
                    break;
                case 3:
                    subLevelNamesList = financialItemsQryVw.Select(fiv1 => fiv1.الوحدة).Distinct().OrderBy(fiv2 => fiv2).ToList();
                    break;
                case 4:
                    subLevelNamesList = financialItemsQryVw.Select(fiv1 => fiv1.الوحدة).Distinct().OrderBy(fiv2 => fiv2).ToList();
                    break;
                default:
                    break;
            }
            List<string> currenciesList = StaticCode.mainDbContext.CurrencyTbls.Select(cu1 => cu1.CurrencyName).ToList();
            int subLevelByCurrenyColumn = subLevelNamesList.Count() * currenciesList.Count();
            List<ExcelWorksheet> allSheets = new List<ExcelWorksheet>() { fiCaIncoming_Ws, fiCaOutgoing_Ws };
            foreach (ExcelWorksheet oneSh in allSheets)
            {
                Application.DoEvents();

                string inOutSh = (oneSh.Index == 0) ? "وارد" : "صادر";
                using (var cells = oneSh.Cells[2, 2, 3, 10])
                {
                    cells.Merge = true;
                    cells.Style.Font.Bold = true;
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(91, 155, 213));
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Medium);
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 18.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Value = $"تحليل المصروفات - البنود المالية ال{inOutSh}ة";
                }
                using (var cells = oneSh.Cells[5, 2])
                {
                    cells.Merge = true;
                    cells.Style.Font.Bold = true;
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(245, 245, 77));
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Medium);
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 14.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Value = fiCaSubLevelName;
                }
                using (var cells = oneSh.Cells[6, 2])
                {
                    cells.Merge = true;
                    cells.Style.Font.Bold = true;
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(217, 217, 217));
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Medium);
                    cells.Style.Font.Name = "Sakkal Majalla";
                    cells.Style.Font.Size = 12.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Value = "العملة";
                }
                oneSh.Row(2).Height = 25;
                oneSh.Row(5).Height = 35;
                oneSh.Row(6).Height = 24;
                oneSh.View.RightToLeft = true;
                oneSh.Column(2).Width = 31;
                int startCol = 3;
                List<Color> currColors = new List<Color>()
                    {
                        Color.FromArgb(198,224,180),
                        Color.FromArgb(255,255,0),
                        Color.FromArgb(217,225,242),
                        Color.FromArgb(190,151,253),
                        Color.FromArgb(200,246,158),
                        Color.FromArgb(200,246,158),
                        Color.FromArgb(212,192,209),
                        Color.FromArgb(63,239,49),
                    };
                for (int iSubLevel = 0; iSubLevel < subLevelNamesList.Count(); iSubLevel++)
                {
                    for (int iCurr = 0; iCurr < currenciesList.Count(); iCurr++)
                    {
                        string oneSubLevelName = subLevelNamesList[iSubLevel];
                        if (iCurr == 0)
                        {
                            using (var cells = oneSh.Cells[5, startCol, 5, startCol + currenciesList.Count() - 1])
                            {
                                cells.Merge = true;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Medium);
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 14.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Value = oneSubLevelName;
                            }
                        }
                        using (var cells = oneSh.Cells[6, startCol])
                        {
                            cells.Merge = true;
                            cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                            cells.Style.Fill.BackgroundColor.SetColor(currColors[iCurr]);
                            cells.Style.Border.BorderAround(ExcelBorderStyle.Medium);
                            cells.Style.Font.Name = "Sakkal Majalla";
                            cells.Style.Font.Size = 12.0F;
                            cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                            cells.Value = currenciesList[iCurr];
                        }
                        oneSh.Column(startCol).Width = 12.5;
                        startCol++;
                    }
                }
                List<string> fiCasList = financialItemsQryVw.Where(fiv1 => fiv1.وارد_أم_صادر == inOutSh).Select(fiv2 => fiv2.مجموعة_البند_المالي).Distinct().ToList();
                if (!fiCasList.Any())
                {
                    ExpensesAnalysisReport_Wb.Worksheets.Delete(oneSh);
                    continue;
                }
                int fiCasNamesStartRow = 7;
                using (var cells = oneSh.Cells[fiCasNamesStartRow, 2, fiCasList.Count() + fiCasNamesStartRow - 1, startCol - 1])
                {
                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    cells.Style.Font.Name = "Calibri";
                    cells.Style.Font.Size = 10.0F;
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Numberformat.Format = "#,##0.0_);(#,##0.0)";
                }
                using (var cells = oneSh.Cells[fiCasNamesStartRow, 2, fiCasList.Count() + fiCasNamesStartRow - 1, 2])
                {
                    cells.Style.Font.Size = 11.0F;
                }
                using (var cells = oneSh.Cells[fiCasList.Count() + fiCasNamesStartRow, 2, fiCasList.Count() + fiCasNamesStartRow, subLevelByCurrenyColumn + 2])
                {
                    cells.Style.Border.BorderAround(ExcelBorderStyle.Medium);
                    cells.Style.Font.Name = "Sakkal Majalla";
                    cells.Style.Font.Size = 10.0F;
                    cells.Style.Font.Bold = true;
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(180, 198, 231));
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Style.Numberformat.Format = "#,##0.0_);(#,##0.0)";
                }
                oneSh.Row(fiCasList.Count() + fiCasNamesStartRow).Height = 28;
                startCol = 3;
                int currRow = fiCasNamesStartRow;
                foreach (string oneFiCa in fiCasList)
                {
                    oneSh.Cells[currRow, 2].Value = oneFiCa;
                    for (int iCol = startCol; iCol < subLevelByCurrenyColumn + startCol; iCol++)
                    {
                        Application.DoEvents();

                        string subLevelName = oneSh.Cells[5, iCol].Value?.ToString();
                        string currName = oneSh.Cells[6, iCol].Value?.ToString();
                        var fiAmountFv = financialItemsQryVw.Where(fiv1 => fiv1.العملة == currName && fiv1.مجموعة_البند_المالي == oneFiCa);
                        switch (reportLevel)
                        {
                            case 1:
                                fiAmountFv = fiAmountFv.Where(fiv1 => fiv1.الدائرة == subLevelName);
                                break;
                            case 2:
                                fiAmountFv = fiAmountFv.Where(fiv1 => fiv1.القسم == subLevelName);
                                break;
                            case 3:
                                fiAmountFv = fiAmountFv.Where(fiv1 => fiv1.الوحدة == subLevelName);
                                break;
                            case 4:
                                fiAmountFv = fiAmountFv.Where(fiv1 => fiv1.الوحدة == subLevelName);
                                break;
                            default:
                                break;
                        }
                        oneSh.Cells[currRow, iCol].Value = (inOutSh == "وارد") ? fiAmountFv.CalcIncomingOfFinancialItems() : fiAmountFv.CalcOutgoingOfFinancialItems();
                    }
                    currRow++;
                }
                using (var cells = oneSh.Cells[currRow, 2])
                {
                    cells.Style.Font.Size = 11.0F;
                    cells.Value = "المجموع";
                }
                for (int iCol = startCol; iCol < subLevelByCurrenyColumn + startCol; iCol++)
                {
                    Application.DoEvents();

                    ExcelRange oneRng = oneSh.Cells[fiCasNamesStartRow, iCol, currRow - 1, iCol];
                    oneSh.Cells[currRow, iCol].Formula = $"=SUM({oneRng.Address})";
                }
                string emptySubLevelName = oneSh.Cells[5, startCol].Value?.ToString();
                if (emptySubLevelName == "")
                {
                    switch (reportLevel)
                    {
                        case 1:
                            emptySubLevelName = StaticCode.PMName;
                            break;
                        case 2:
                            emptySubLevelName = "إدارة الدائرة";
                            break;
                        case 3:
                            emptySubLevelName = "إدارة القسم";
                            break;
                        case 4:
                            emptySubLevelName = "إدارة الوحدة";
                            break;
                        default:
                            break;
                    }
                }
                oneSh.Cells[5, startCol].Value = emptySubLevelName;
                int leftTotalsColumn = subLevelByCurrenyColumn + startCol;
                oneSh.Column(leftTotalsColumn).Width = 16;
                int lowerTotalsRow = currRow;
                for (int iRow = fiCasNamesStartRow - 1; iRow <= lowerTotalsRow; iRow++)
                {
                    Application.DoEvents();

                    ExcelRange oneRng = oneSh.Cells[iRow, startCol, iRow, leftTotalsColumn - 1];
                    using (var cells = oneSh.Cells[iRow, leftTotalsColumn])
                    {
                        cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        if (iRow == fiCasNamesStartRow - 1 || iRow == lowerTotalsRow)
                        {
                            cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                            cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                        }
                        if (iRow == fiCasNamesStartRow - 1)
                            cells.Value = "المجموع";
                        else
                            cells.Formula = $"=SUM({oneRng.Address})";
                    }
                }
            }
            ExpensesAnalysisReport_Ep.Save();
            #endregion

            progressPanel1.Visible = false;
            mainAlertControl.Show(this, StaticCode.ApplicationTitle, "النتائج جاهزة");
        }

        /// <summary>
        /// 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportFinancialReportToExcelDropDownButton_Click(object sender, EventArgs e)
        {
            if (sender is DropDownButton)
            {
                exportFinancialReportToExcelDropDownButton.ShowDropDown();
                return;
            }
            SaveFileDialog financialReportSFD = new SaveFileDialog() { Filter = "Excel workbook 2007-2022 (*.xlsx)|*.xlsx", FileName = StaticCode.GeneralFinancialReportPath };
            if (financialReportSFD.ShowDialog() != DialogResult.OK)
            {
                mainAlertControl.Show(this, "تم الإلغاء", StaticCode.ApplicationTitle);
                return;
            }
            if (File.Exists(financialReportSFD.FileName))
                File.Delete(financialReportSFD.FileName);
            string targetPath = financialReportSFD.FileName;
            if (!File.Exists(StaticCode.BlankFinancialReportPath))
            {
                mainAlertControl.Show(this, "فورم التقرير المالي غير موجود", StaticCode.ApplicationTitle);
                return;
            }
            if (File.Exists(targetPath))
                File.Delete(targetPath);
            File.Copy(StaticCode.BlankFinancialReportPath, targetPath, true);
            ExcelPackage fiRpEp = new ExcelPackage(new FileInfo(targetPath));
            ExcelWorkbook fiRpWb = fiRpEp.Workbook;
            ExcelWorksheet fiRpWs = fiRpWb.Worksheets.First();
            ExcelWorksheet listsWs = fiRpWb.Worksheets["Lists"];

            int ficaRowStart = 3;
            int incomingAmountCol = 2;
            int outgoingAmountCol = 3;
            int currCol = 4;
            int incomingFromCol = 5;
            int outgoingTypeCol = 6;
            int descriptionCol = 7;
            int fiDateCol = 8;
            int fiCaCol = 9;
            int firstCurrRow = 4;
            int fiCaRowStart = firstCurrRow + 1;
            int toalsByCurrRowStart = 1705;
            int lastRecordRow = 1700;
            int listsRowStart = 3;
            int fiCaCol_Left = 11;
            int currColStart = 12;
            int emptyCurrenciesColumn = 8;
            int fiCaDetColumn = fiCaCol_Left + emptyCurrenciesColumn + 1;
            var fiCaCount_In = StaticCode.mainDbContext.FinancialItemCategoryTbls.Where(ficai1 => ficai1.IsIncomingOrOutgiung == "وارد");
            var fiCaCount_Out = StaticCode.mainDbContext.FinancialItemCategoryTbls.Where(ficao1 => ficao1.IsIncomingOrOutgiung == "صادر");
            List<string> fiCaGroupsList_In = StaticCode.mainDbContext.FinancialItemCategoryTbls.Where(fica1 => fica1.IsIncomingOrOutgiung == "وارد").Select(fica2 => fica2.GroupName).Distinct().ToList();
            List<string> fiCaGroupsList_Out = StaticCode.mainDbContext.FinancialItemCategoryTbls.Where(fica1 => fica1.IsIncomingOrOutgiung == "صادر").Select(fica2 => fica2.GroupName).Distinct().ToList();
            foreach (FinancialItemCategoryTbl oneFiCa in StaticCode.mainDbContext.FinancialItemCategoryTbls)
            {
                listsWs.Cells[ficaRowStart, 3].Value = oneFiCa.FinancialItemCategoryName;
                listsWs.Cells[ficaRowStart, 4].Value = oneFiCa.FinancialItemCategoryDetails;
                listsWs.Cells[ficaRowStart, 5].Value = oneFiCa.GroupName;
                ficaRowStart++;
            }
            List<int> currRows = new List<int>();
            currRows.Add(firstCurrRow);
            int rowsPointer = fiCaRowStart;
            foreach (var oneFiCaName in fiCaCount_In)
            {
                fiRpWs.Cells[rowsPointer, fiCaCol_Left].Value = oneFiCaName.FinancialItemCategoryName;
                using (var cells = fiRpWs.Cells[rowsPointer, fiCaDetColumn])
                {
                    cells.Value = oneFiCaName.FinancialItemCategoryDetails;
                    cells.Style.Font.Size = 12.0F;
                    cells.Style.Font.Color.SetColor(Color.Red);
                    //cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    //cells.Style.Fill.BackgroundColor.SetColor(Color.Red);
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                }
                rowsPointer++;
            }
            int emptyRows_In = 25 - fiCaCount_In.Count();
            fiRpWs.DeleteRow(rowsPointer, emptyRows_In);
            rowsPointer++;
            toalsByCurrRowStart -= emptyRows_In;
            lastRecordRow -= emptyRows_In;
            fiRpWs.Column(fiCaDetColumn).Width = 50;
            foreach (string oneFiCaGroupName in fiCaGroupsList_Out)
            {
                using (var cells = fiRpWs.Cells[rowsPointer, fiCaCol_Left])
                {
                    cells.Style.Font.Size = 14.0F;
                    cells.Style.Font.UnderLine = true;
                    cells.Style.Font.Color.SetColor(Color.Red);
                    cells.Value = oneFiCaGroupName;
                }
                using (var cells = fiRpWs.Cells[rowsPointer, currColStart - 1, rowsPointer, currColStart + StaticCode.mainDbContext.CurrencyTbls.Count() - 1])
                {
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(242, 220, 219));
                }
                currRows.Add(rowsPointer);
                rowsPointer++;
                foreach (var oneFiCaName in fiCaCount_Out.Where(fica1 => fica1.GroupName == oneFiCaGroupName))
                {
                    Application.DoEvents();
                    fiRpWs.Cells[rowsPointer, fiCaCol_Left].Value = oneFiCaName.FinancialItemCategoryName;
                    using (var cells = fiRpWs.Cells[rowsPointer, fiCaDetColumn])
                    {
                        cells.Value = oneFiCaName.FinancialItemCategoryDetails;
                        cells.Style.Font.Size = 12.0F;
                        cells.Style.Font.Color.SetColor(Color.Red);
                        //cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        //cells.Style.Fill.BackgroundColor.SetColor(Color.Red);
                        cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    }
                    rowsPointer++;
                }
            }
            int totalsRow = 106 - emptyRows_In;
            int emptyRows_Out = totalsRow - rowsPointer;
            toalsByCurrRowStart -= emptyRows_Out;
            lastRecordRow -= emptyRows_Out;
            fiRpWs.DeleteRow(rowsPointer, emptyRows_Out);
            int lastTotalRow = rowsPointer + 7;
            foreach (CurrencyTbl oneCu in StaticCode.mainDbContext.CurrencyTbls)
            {
                fiRpWs.Cells[toalsByCurrRowStart, 2].Value =
                listsWs.Cells[listsRowStart, 9].Value = oneCu.CurrencyName;
                toalsByCurrRowStart++;
                listsRowStart++;
                foreach (int oneCurrRow in currRows)
                {
                    fiRpWs.Cells[oneCurrRow, currColStart].Value = oneCu.CurrencyName;
                }
                currColStart++;
            }
            fiRpWs.DeleteColumn(currColStart, emptyCurrenciesColumn - StaticCode.mainDbContext.CurrencyTbls.Count());

            string sectionOfSearch = "";
            string departmentOfSearch = "";
            string subDepartmentOfSearch = "";
            if (StaticCode.activeUserRole.IsSectionIndependent == true)
            {
                sectionOfSearch = StaticCode.PMName;
            }
            else if (StaticCode.activeUserRole.IsDepartmentIndependent == true)
            {
                sectionOfSearch = StaticCode.mainDbContext.SectionTbls.Single(sct1 => sct1.ID == Convert.ToInt32(StaticCode.activeUser.UserSection)).SectionName;
            }
            else
            {
                sectionOfSearch = StaticCode.mainDbContext.DepartmentVws.Single(dptv1 => dptv1.معرف_القسم == Convert.ToInt32(StaticCode.activeUser.UserDept)).الدائرة_التي_يتبع_لها_القسم;
                departmentOfSearch = StaticCode.mainDbContext.DepartmentTbls.Single(dpt1 => dpt1.ID == Convert.ToInt32(StaticCode.activeUser.UserDept)).DepartmentName;
            }
            if (!searchAllRadioButton.Checked)
            {
                if (StaticCode.activeUserRole.IsSectionIndependent == true)
                {
                    if (searchBySectionCheckBox.Checked)
                    {
                        sectionOfSearch = searchBySectionLookUpEdit.Text;
                    }
                    if (searchByDepartmentCheckBox.Checked)
                    {
                        departmentOfSearch = searchByDepartmentSearchLookUpEdit.Text;
                        sectionOfSearch = StaticCode.mainDbContext.DepartmentVws.Single(dptv1 => dptv1.معرف_القسم == Convert.ToInt32(searchByDepartmentSearchLookUpEdit.EditValue)).الدائرة_التي_يتبع_لها_القسم;
                    }
                    if (searchBySubDepartmentCheckBox.Checked)
                    {
                        subDepartmentOfSearch = searchBySubDepartmentSearchLookUpEdit.Text;
                        departmentOfSearch = StaticCode.mainDbContext.SubDepartmentVws.Single(sdptv1 => sdptv1.معرف_الوحدة == Convert.ToInt32(searchBySubDepartmentSearchLookUpEdit.EditValue)).القسم_التابعة_له;
                        sectionOfSearch = StaticCode.mainDbContext.SubDepartmentVws.Single(sdptv1 => sdptv1.معرف_الوحدة == Convert.ToInt32(searchBySubDepartmentSearchLookUpEdit.EditValue)).الدائرة_التي_يتبع_لها_القسم;
                    }
                }
                else if (StaticCode.activeUserRole.IsDepartmentIndependent == true)
                {
                    if (searchByDepartmentCheckBox.Checked)
                    {
                        departmentOfSearch = searchByDepartmentSearchLookUpEdit.Text;
                        sectionOfSearch = StaticCode.mainDbContext.DepartmentVws.Single(dptv1 => dptv1.معرف_القسم == Convert.ToInt32(searchByDepartmentSearchLookUpEdit.EditValue)).الدائرة_التي_يتبع_لها_القسم;
                    }
                    if (searchBySubDepartmentCheckBox.Checked)
                    {
                        subDepartmentOfSearch = searchBySubDepartmentSearchLookUpEdit.Text;
                        departmentOfSearch = StaticCode.mainDbContext.SubDepartmentVws.Single(sdptv1 => sdptv1.معرف_الوحدة == Convert.ToInt32(searchBySubDepartmentSearchLookUpEdit.EditValue)).القسم_التابعة_له;
                        sectionOfSearch = StaticCode.mainDbContext.SubDepartmentVws.Single(sdptv1 => sdptv1.معرف_الوحدة == Convert.ToInt32(searchBySubDepartmentSearchLookUpEdit.EditValue)).الدائرة_التي_يتبع_لها_القسم;
                    }
                }
                else
                {
                    if (searchBySubDepartmentCheckBox.Checked)
                    {
                        subDepartmentOfSearch = searchBySubDepartmentSearchLookUpEdit.Text;
                        departmentOfSearch = StaticCode.mainDbContext.SubDepartmentVws.Single(sdptv1 => sdptv1.معرف_الوحدة == Convert.ToInt32(searchBySubDepartmentSearchLookUpEdit.EditValue)).القسم_التابعة_له;
                        sectionOfSearch = StaticCode.mainDbContext.SubDepartmentVws.Single(sdptv1 => sdptv1.معرف_الوحدة == Convert.ToInt32(searchBySubDepartmentSearchLookUpEdit.EditValue)).الدائرة_التي_يتبع_لها_القسم;
                    }
                }
            }

            string sectionVal = $"الدائرة: {sectionOfSearch}";
            string departmentVal = $"القسم: {departmentOfSearch}";
            string subDepartmentVal = $"الوحدة: {subDepartmentOfSearch}";
            fiRpWs.Cells[2, 2, 2, 4].Value = sectionVal;
            fiRpWs.Cells[2, 5, 2, 6].Value = departmentVal;
            fiRpWs.Cells[2, 7].Value = subDepartmentVal;
            fiRpWs.Cells[2, 8, 2, 9].Value = $"التاريخ: {DateTime.Today.ToString("yyyy-MM-dd")}";
            int startRow = 5;
            var financialItemsQry2 = financialItemsQryVw.GetTotalFinancialTableOfLevel(reportLevel, reportSectionName, reportDeptName, reportSubDeptName);
            if (isDurationReport)
            {
                foreach (CurrencyTbl oneCurr in StaticCode.mainDbContext.CurrencyTbls)
                {
                    Application.DoEvents();

                    var financialItemsQry2_Prev_Curr = StaticCode.mainDbContext.FinancialItemVws.Where(fivp1 => fivp1.العملة == oneCurr.CurrencyName && fivp1.تاريخ_تحرير_السجل < fromDate);
                    if (financialItemsQry2_Prev_Curr.Any())
                    {
                        fiRpWs.Cells[startRow, incomingAmountCol].Value = financialItemsQry2_Prev_Curr.CalcRecycledOfFinancialItems();
                        fiRpWs.Cells[startRow, currCol].Value = oneCurr.CurrencyName;
                        fiRpWs.Cells[startRow, incomingFromCol].Value = "أخرى";
                        fiRpWs.Cells[startRow, descriptionCol].Value = "مدور ما قبل " + fromDate.ToString("yyyy-MM-dd");
                        fiRpWs.Cells[startRow, fiDateCol].Value = fromDate.ToShortDateString();
                        fiRpWs.Cells[startRow, fiCaCol].Value = "رصيد مدور";
                        startRow++;
                    }
                }
            }
            if (financialItemsQry2.Any(fici1 => fici1.وارد_أم_صادر == "وارد"))
            {
                foreach (FinancialItemVw oneFiV in financialItemsQry2.Where(fici1 => fici1.وارد_أم_صادر == "وارد"))
                {
                    Application.DoEvents();

                    FinancialItemTbl oneFiRp = StaticCode.mainDbContext.FinancialItemTbls.Single(fit1 => fit1.ID == oneFiV.معرف_السجل_المالي);
                    fiRpWs.Cells[startRow, incomingAmountCol].Value = oneFiRp.IncomingAmount;
                    fiRpWs.Cells[startRow, currCol].Value = StaticCode.mainDbContext.CurrencyTbls.Single(cu1 => cu1.ID == oneFiRp.FinancialItemCurrency).CurrencyName;
                    fiRpWs.Cells[startRow, incomingFromCol].Value = oneFiRp.IncomingFrom?.Trim();
                    fiRpWs.Cells[startRow, descriptionCol].Value = oneFiRp.FinancialItemDescription;
                    fiRpWs.Cells[startRow, fiDateCol].Value = oneFiRp.FinancialItemInsertionDate.ToShortDateString();
                    fiRpWs.Cells[startRow, fiCaCol].Value = StaticCode.mainDbContext.FinancialItemCategoryTbls.Single(fic1 => fic1.ID == oneFiRp.FinancialItemCategory).FinancialItemCategoryName;
                    startRow++;
                }
            }
            using (var cells = fiRpWs.Cells[startRow, 2, startRow, 9])
            {
                cells.Merge = true;
                cells.Style.Font.Name = "Calibri";
                cells.Style.Font.Size = 14.0F;
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                cells.Style.Font.Color.SetColor(Color.FromArgb(31, 73, 125));
                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(242, 220, 219));
                cells.Value = "ثانياً : المصاريف :";
            }
            startRow++;
            if (financialItemsQry2.Any(fico1 => fico1.وارد_أم_صادر == "صادر"))
            {
                foreach (FinancialItemVw oneFiV in financialItemsQry2.Where(fico1 => fico1.وارد_أم_صادر == "صادر"))
                {
                    Application.DoEvents();
                    FinancialItemTbl oneFiRp = StaticCode.mainDbContext.FinancialItemTbls.Single(fit1 => fit1.ID == oneFiV.معرف_السجل_المالي);
                    fiRpWs.Cells[startRow, outgoingAmountCol].Value = oneFiRp.OutgoingAmount;
                    fiRpWs.Cells[startRow, currCol].Value = StaticCode.mainDbContext.CurrencyTbls.Single(cu1 => cu1.ID == oneFiRp.FinancialItemCurrency).CurrencyName;
                    fiRpWs.Cells[startRow, outgoingTypeCol].Value = oneFiRp.OutgoingType?.Trim();
                    fiRpWs.Cells[startRow, descriptionCol].Value = oneFiRp.FinancialItemDescription;
                    fiRpWs.Cells[startRow, fiDateCol].Value = oneFiRp.FinancialItemInsertionDate.ToShortDateString();
                    fiRpWs.Cells[startRow, fiCaCol].Value = StaticCode.mainDbContext.FinancialItemCategoryTbls.Single(fic1 => fic1.ID == oneFiRp.FinancialItemCategory).FinancialItemCategoryName;
                    startRow++;
                }
            }
            fiRpWs.DeleteRow(Math.Max(startRow, lastTotalRow), lastRecordRow - Math.Max(startRow, lastTotalRow));
            fiRpEp.Save();
            mainAlertControl.Show(this, "تم التصدير بنجاح", StaticCode.ApplicationTitle);
        }

        private void SelectReportDuration(object sender, EventArgs e)
        {
            fromToPanel.Visible = fromToRadioButton.Checked;
            monthlyDateTimePicker.Visible = monthlyRadioButton.Checked;
            annualDateTimePicker.Visible = annualRadioButton.Checked;
        }

        private void searchAllRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (searchAllRadioButton.Checked)
                searchBySectionCheckBox.Checked = searchByDepartmentCheckBox.Checked = searchBySubDepartmentCheckBox.Checked = false;
        }

        private void manageDepartmentTblBtn_Click(object sender, EventArgs e)
        {
            ManageDepartmentTblForm dptFrm = new ManageDepartmentTblForm();
            dptFrm.ShowDialog();
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
        }

        private void searchWithinPeriodCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchWithinPeriodPanel.Visible = isDurationReport = searchWithinPeriodCheckBox.Checked;
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

        private void moneySummaryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchByCurrencyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchByCurrencyLookUpEdit.Visible = manageCurrencyTblBtn.Visible = searchByCurrencyCheckBox.Checked;
        }

        private void manageCurrencyTblBtn_Click(object sender, EventArgs e)
        {
            ManageCurrencyTblForm curFrm = new ManageCurrencyTblForm();
            curFrm.ShowDialog();
            this.currencyTblTableAdapter.Fill(this.assetMngDbDataSet.CurrencyTbl);
        }

        private void searchBySectionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (searchBySectionCheckBox.Checked)
                searchAllRadioButton.Checked = false;
            searchBySectionLookUpEdit.Visible = searchBySectionCheckBox.Checked;
            manageSectionTblBtn.Visible = searchBySectionCheckBox.Checked && StaticCode.activeUserRole.ManageSections == true;
            if (searchBySectionCheckBox.Checked)
            {
                if (searchBySectionLookUpEdit.EditValue == null)
                    return;
                List<int> deptIDs = StaticCode.mainDbContext.DepartmentTbls.Where(dpt1 => dpt1.SectionOfDepartment == Convert.ToInt32(searchBySectionLookUpEdit.EditValue)).Select(dpt2 => dpt2.ID).ToList();
                string plusQry = "";
                if (deptIDs.Count() == 0)
                    plusQry = " WHERE 1 > 2;";
                else
                {
                    foreach (int oneID in deptIDs)
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
                        if (deptIDs.IndexOf(Convert.ToInt32(oneRowItemArray[0])) == -1)
                            customVw.Rows.Remove(oneRow);
                    }
                    catch
                    {
                        this.departmentVwTableAdapter.FillByQuery(this.assetMngDbDataSet.DepartmentVw, " WHERE 1 < 2;");
                        return;
                    }
                }
                this.departmentVwTableAdapter.FillByQuery(customVw, plusQry);
                searchBySubDepartmentSearchLookUpEdit.EditValue = null;
            }
            else
            {
                this.departmentVwTableAdapter.FillByQuery(this.assetMngDbDataSet.DepartmentVw, " WHERE 1 < 2;");
            }
        }

        private void searchByDepartmentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (searchByDepartmentCheckBox.Checked)
                searchAllRadioButton.Checked = false;
            searchByDepartmentSearchLookUpEdit.Visible = searchByDepartmentCheckBox.Checked;
            manageDepartmentTblBtn.Visible = searchByDepartmentCheckBox.Checked && StaticCode.activeUserRole.ManageDepartments == true;
            if (searchByDepartmentCheckBox.Checked)
            {
                if (searchByDepartmentSearchLookUpEdit.EditValue == null)
                    return;
                List<int> subDeptIDs = StaticCode.mainDbContext.SubDepartmentTbls.Where(subd1 => subd1.MainDepartment == Convert.ToInt32(searchByDepartmentSearchLookUpEdit.EditValue)).Select(subd2 => subd2.ID).ToList();
                string plusQry = "";
                if (subDeptIDs.Count() == 0)
                    plusQry = " WHERE 1 > 2;";
                else
                {
                    foreach (int oneID in subDeptIDs)
                        plusQry += oneID + ", ";
                    plusQry = $" WHERE [معرف الوحدة] IN ({ plusQry.Trim().Trim(',').Trim()});";
                }
                SubDepartmentVwDataTable customVw = this.assetMngDbDataSet.SubDepartmentVw;
                for (int i = 0; i < customVw.Rows.Count; i++)
                {
                    try
                    {
                        var oneRow = customVw.Rows[i];
                        object[] oneRowItemArray = oneRow.ItemArray;
                        if (subDeptIDs.IndexOf(Convert.ToInt32(oneRowItemArray[0])) == -1)
                            customVw.Rows.Remove(oneRow);
                    }
                    catch
                    {
                        this.subDepartmentVwTableAdapter.FillByQuery(this.assetMngDbDataSet.SubDepartmentVw, " WHERE 1 < 2;");
                        return;
                    }
                }
                this.subDepartmentVwTableAdapter.FillByQuery(customVw, plusQry);
            }
            else
            {
                if (searchBySectionCheckBox.Checked)
                {
                    if (searchBySectionLookUpEdit.EditValue == null)
                        return;
                    var deptItems = StaticCode.mainDbContext.DepartmentTbls.Where(dpt1 => dpt1.SectionOfDepartment == Convert.ToInt32(searchBySectionLookUpEdit.EditValue));
                    List<int> dptIds = deptItems.Select(dpt2 => dpt2.ID).ToList();
                    List<int> subDeptIDs = StaticCode.mainDbContext.SubDepartmentTbls.Where(subd1 => dptIds.Contains(subd1.MainDepartment)).Select(subd2 => subd2.ID).ToList();
                    string plusQry = "";
                    if (subDeptIDs.Count() == 0)
                        plusQry = " WHERE 1 > 2;";
                    else
                    {
                        foreach (int oneID in subDeptIDs)
                            plusQry += oneID + ", ";
                        plusQry = $" WHERE [معرف الوحدة] IN ({ plusQry.Trim().Trim(',').Trim()});";
                    }
                    SubDepartmentVwDataTable customVw = this.assetMngDbDataSet.SubDepartmentVw;
                    for (int i = 0; i < customVw.Rows.Count; i++)
                    {
                        try
                        {
                            var oneRow = customVw.Rows[i];
                            object[] oneRowItemArray = oneRow.ItemArray;
                            if (subDeptIDs.IndexOf(Convert.ToInt32(oneRowItemArray[0])) == -1)
                                customVw.Rows.Remove(oneRow);
                        }
                        catch
                        {
                            this.subDepartmentVwTableAdapter.FillByQuery(this.assetMngDbDataSet.SubDepartmentVw, " WHERE 1 < 2;");
                            return;
                        }
                    }
                    this.subDepartmentVwTableAdapter.FillByQuery(customVw, plusQry);
                }
                else
                {
                    this.subDepartmentVwTableAdapter.FillByQuery(this.assetMngDbDataSet.SubDepartmentVw, " WHERE 1 < 2;");
                }
            }
        }

        private void searchBySubDepartmentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (searchBySubDepartmentCheckBox.Checked)
                searchAllRadioButton.Checked = false;
            searchBySubDepartmentSearchLookUpEdit.Visible = searchBySubDepartmentCheckBox.Checked;
            manageSubDepartmentTblBtn.Visible = searchBySubDepartmentCheckBox.Checked && StaticCode.activeUserRole.ManageSubDepartments == true;
        }

        private void exportDetailedFormBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog financialReportSFD = new SaveFileDialog() { FileName = $"التقرير المالي التفصيلي{DateTime.Today.ToString("yyyy-MM-dd")}.xlsx", Filter = "Excel workbook 2007-2022 (*.xlsx)|*.xlsx" };
            if (financialReportSFD.ShowDialog() != DialogResult.OK)
            {
                mainAlertControl.Show(this, "لم يتم حفظ ملف الإكسل", StaticCode.ApplicationTitle);
                return;
            }
            string financialReportXlsx = financialReportSFD.FileName;
            File.Copy(StaticCode.DetailedFinancialReportPath, financialReportSFD.FileName, true);
            mainAlertControl.Show(this, "تم حفظ ملف الإكسل", StaticCode.ApplicationTitle);
        }

        private void exportStandardFormBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            exportFinancialReportToExcelDropDownButton_Click(sender, e);
        }

        private void exportExpensesAnalysisFormBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog financialReportSFD = new SaveFileDialog() { FileName = $"تحليل المصروفات{DateTime.Today.ToString("yyyy-MM-dd")}.xlsx", Filter = "Excel workbook 2007-2022 (*.xlsx)|*.xlsx" };
            if (financialReportSFD.ShowDialog() != DialogResult.OK)
            {
                mainAlertControl.Show(this, "لم يتم حفظ ملف الإكسل", StaticCode.ApplicationTitle);
                return;
            }
            string financialReportXlsx = financialReportSFD.FileName;
            File.Copy(StaticCode.ExpensesAnalysisReportPath, financialReportSFD.FileName, true);
            mainAlertControl.Show(this, "تم حفظ ملف الإكسل", StaticCode.ApplicationTitle);
        }
    }
}