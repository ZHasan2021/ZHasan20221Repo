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
        IQueryable<FinancialItemTbl> financialItemsQry = null;
        int levelSelected = 0;
        int levelID = 0;

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

            financialItemsQry = StaticCode.mainDbContext.FinancialItemTbls.Select(fi1 => fi1);
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
                    levelID = Convert.ToInt32(searchBySectionLookUpEdit.EditValue);
                    List<int> dptQry = (from dpt1 in StaticCode.mainDbContext.DepartmentTbls where dpt1.SectionOfDepartment == Convert.ToInt32(searchBySectionLookUpEdit.EditValue) select dpt1.ID).ToList();
                    List<int> sdptQry = (from sdep1 in StaticCode.mainDbContext.SubDepartmentTbls where dptQry.Contains(sdep1.MainDepartment) select sdep1.ID).ToList();
                    financialItemsQry = from qry in financialItemsQry where sdptQry.Contains(qry.FinancialItemSubDept) select qry;
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
                    levelID = Convert.ToInt32(searchByDepartmentSearchLookUpEdit.EditValue);
                    List<int> sdptQry = (from sdep1 in StaticCode.mainDbContext.SubDepartmentTbls where sdep1.MainDepartment == Convert.ToInt32(searchByDepartmentSearchLookUpEdit.EditValue) select sdep1.ID).ToList();
                    financialItemsQry = from qry in financialItemsQry where sdptQry.Contains(qry.FinancialItemSubDept) select qry;
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
                    levelID = Convert.ToInt32(searchBySubDepartmentSearchLookUpEdit.EditValue);
                    financialItemsQry = financialItemsQry.Where(fi1 => fi1.FinancialItemSubDept == Convert.ToInt32(searchBySubDepartmentSearchLookUpEdit.EditValue));
                }
            }
            if (searchWithinPeriodCheckBox.Checked)
            {
                DateTime fromDate = DateTime.Today;
                DateTime toDate = DateTime.Today;
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
                financialItemsQry = financialItemsQry.Where(fi => fi.FinancialItemInsertionDate >= fromDate && fi.FinancialItemInsertionDate <= toDate);
            }
            if (searchByCurrencyCheckBox.Checked)
            {
                financialItemsQry = financialItemsQry.Where(fi => fi.FinancialItemCurrency == Convert.ToInt32(searchByCurrencyLookUpEdit.EditValue));
            }
            bool resultsFound = financialItemsQry != null && financialItemsQry.Count() > 0;
            exportFinancialReportToExcelDropDownButton.Enabled = financialReportTabControl.Visible = resultsFound;
            #endregion

            if (!resultsFound)
            {
                mainAlertControl.Show(this, "لا يوجد سجلات مالية ضمن اختياراتك", StaticCode.ApplicationTitle);
                MessageBox.Show("لا يوجد سجلات مالية ضمن اختياراتك", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressPanel1.Visible = false;
                return;
            }
            else
            {
                List<int> IDsIncluded = financialItemsQry.Select(fii1 => fii1.ID).ToList();
                var financialItemsQryVw = StaticCode.mainDbContext.FinancialItemVws.Where(fiv1 => IDsIncluded.Contains(fiv1.معرف_السجل_المالي));
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

                #region Prepare the totals of each sub-level by currency
                DateTime today1 = DateTime.Today.AddDays(StaticCode.appOptions.ShiftDays);
                List<double> totals1 = StaticCode.GetCycledToMonth(financialItemsQry, today1.Year, today1.Month);
                totalIncomesNumericUpDown.Value = Convert.ToDecimal(totals1[0]);
                totalOutcomesNumericUpDown.Value = Convert.ToDecimal(totals1[1]);
                totalCycledNumericUpDown.Value = Convert.ToDecimal(totals1[2]);

                subLevelTotalsTreeView.Nodes.Clear();
                switch (levelSelected)
                {
                    case 0:
                        var subLevelQuery1 = StaticCode.mainDbContext.SectionTbls;
                        foreach (SectionTbl oneItem in subLevelQuery1)
                        {
                            Application.DoEvents();
                            List<int> dptQry = (from dpt1 in StaticCode.mainDbContext.DepartmentTbls where dpt1.SectionOfDepartment == oneItem.ID select dpt1.ID).ToList();
                            List<int> sdptQry = (from sdep1 in StaticCode.mainDbContext.SubDepartmentTbls where dptQry.Contains(sdep1.MainDepartment) select sdep1.ID).ToList();
                            var levelQry1 = from qry in financialItemsQry where sdptQry.Contains(qry.FinancialItemSubDept) select qry;

                            TreeNode oneNode = subLevelTotalsTreeView.Nodes.Add(oneItem.SectionName);
                            List<double> totals2 = StaticCode.GetCycledToMonth(levelQry1, today1.Year, today1.Month);
                            oneNode.Nodes.Add($"الوارد: {totals2[0]}");
                            oneNode.Nodes.Add($"الصادر: {totals2[1]}");
                            oneNode.Nodes.Add($"المدور: {totals2[2]}");
                        }
                        break;
                    case 1:
                        var subLevelQuery2 = StaticCode.mainDbContext.DepartmentTbls.Where(dpt1 => dpt1.SectionOfDepartment == Convert.ToInt32(searchBySectionLookUpEdit.EditValue));
                        foreach (DepartmentTbl oneItem in subLevelQuery2)
                        {
                            Application.DoEvents();
                            List<int> sdptQry = (from sdep1 in StaticCode.mainDbContext.SubDepartmentTbls where sdep1.MainDepartment == oneItem.ID select sdep1.ID).ToList();
                            var levelQry2 = from qry in financialItemsQry where sdptQry.Contains(qry.FinancialItemSubDept) select qry;

                            TreeNode oneNode = subLevelTotalsTreeView.Nodes.Add(oneItem.DepartmentName);
                            List<double> totals2 = StaticCode.GetCycledToMonth(levelQry2, today1.Year, today1.Month);
                            oneNode.Nodes.Add($"الوارد: {totals2[0]}");
                            oneNode.Nodes.Add($"الصادر: {totals2[1]}");
                            oneNode.Nodes.Add($"المدور: {totals2[2]}");
                        }
                        break;
                    case 2:
                        var subLevelQuery3 = StaticCode.mainDbContext.SubDepartmentTbls.Where(sdpt1 => sdpt1.MainDepartment == Convert.ToInt32(searchByDepartmentSearchLookUpEdit.EditValue));
                        foreach (SubDepartmentTbl oneItem in subLevelQuery3)
                        {
                            Application.DoEvents();
                            var levelQry3 = financialItemsQry.Where(fi1 => fi1.FinancialItemSubDept == oneItem.ID);

                            TreeNode oneNode = subLevelTotalsTreeView.Nodes.Add(oneItem.SubDepartmentName);
                            List<double> totals2 = StaticCode.GetCycledToMonth(levelQry3, today1.Year, today1.Month);
                            oneNode.Nodes.Add($"الوارد: {totals2[0]}");
                            oneNode.Nodes.Add($"الصادر: {totals2[1]}");
                            oneNode.Nodes.Add($"المدور: {totals2[2]}");
                        }
                        break;
                    default:
                        break;
                }
                subLevelTotalsTreeView.ExpandAll();
                #endregion

                #region Prepare the excel details of each sub-level by currency
                string financialReportXlsx = StaticCode.SubLevelTotalsOutPath;
                if (File.Exists(financialReportXlsx))
                    File.Delete(financialReportXlsx);
                ExcelPackage financialReport_SubLevelsEp = new ExcelPackage(new FileInfo(financialReportXlsx));
                ExcelWorkbook financialReport_SubLevelsWb = financialReport_SubLevelsEp.Workbook;

                foreach (string oneCurr in StaticCode.mainDbContext.CurrencyTbls.Select(cur1 => cur1.CurrencyName).ToList())
                {
                    Application.DoEvents();

                    var financialItemsQryVw_OneCurr = financialItemsQryVw.Where(asvcu1 => asvcu1.العملة == oneCurr);
                    if (!financialItemsQryVw_OneCurr.Any())
                        continue;

                    #region General financial report
                    string sheet_Title_Name1 = "السجل المالي العام للـ PM";
                    string sheet_Title_Name1_short = "عام PM";
                    int fiSubLevel = 0;
                    if (StaticCode.activeUserRole.IsSectionIndependent == true)
                    {
                        sheet_Title_Name1 = "السجل المالي العام للـ PM";
                        sheet_Title_Name1_short = "عام PM";
                        fiSubLevel = 1;
                    }
                    else if (StaticCode.activeUserRole.IsDepartmentIndependent == true)
                    {
                        sheet_Title_Name1 = "السجل المالي العام للدائرة";
                        sheet_Title_Name1_short = "عام دائرة";
                        fiSubLevel = 2;
                    }
                    else
                    {
                        sheet_Title_Name1 = "السجل المالي العام للقسم";
                        sheet_Title_Name1_short = "عام قسم";
                        fiSubLevel = 3;
                    }
                    sheet_Title_Name1_short += " - " + oneCurr;
                    ExcelWorksheet generalFinancialReportWs = financialReport_SubLevelsWb.Worksheets.Add(sheet_Title_Name1_short);
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
                    int startRow = 6;
                    switch (fiSubLevel)
                    {
                        case 1:
                            List<string> subLevelList1 = financialItemsQryVw_OneCurr.Select(fiv1 => fiv1.الدائرة).Distinct().ToList();
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
                                cells.Value = StaticCode.PMName;
                            }
                            startRow += 2;

                            #region Incoming of sub-level
                            var incomingSubLevelQry1 = financialItemsQryVw_OneCurr.Where(fiv2 => fiv2.وارد_أم_صادر == "وارد").OrderByDescending(fiv22 => fiv22.جهة_الإيراد);
                            double totalIncomingSubLevel1 = financialItemsQryVw_OneCurr.CalcIncomingOfFinancialItems();

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
                            foreach (var oneSubItem in incomingSubLevelQry1)
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
                                cells.Value = totalIncomingSubLevel1;
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
                                cells.Value = "مجموع إيرادات الـ PM";
                            }
                            incomingRow1++;
                            #endregion

                            #region Outgoing of sub-level
                            var outgoingSubLevelQry1 = financialItemsQryVw_OneCurr.Where(fiv2 => fiv2.وارد_أم_صادر == "صادر").OrderByDescending(fiv22 => fiv22.نوع_الصادر);
                            double totalOutgoingSubLevel1 = financialItemsQryVw_OneCurr.CalcOutgoingOfFinancialItems();

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
                            foreach (var oneSubItem in outgoingSubLevelQry1)
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
                                cells.Value = totalOutgoingSubLevel1;
                            }
                            using (var cells = generalFinancialReportWs.Cells[outgoingRow, 6, outgoingRow, 7])
                            {
                                ExcelRichTextCollection textValue = cells.RichText;
                                ExcelRichText richText1 = textValue.Add("مجموع (الصادرات المباشرة والمعلقة) للـ PM");
                                richText1.Color = Color.Black;
                                ExcelRichText richText2 = textValue.Add(" دون أفرع الـ PM");
                                richText2.Color = Color.Red;
                                cells.Merge = true;
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                            }
                            outgoingRow++;
                            #endregion

                            #region Recycled of sub-level
                            startRow = Math.Max(incomingRow1, outgoingRow) + 1;
                            using (var cells = generalFinancialReportWs.Cells[startRow, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                cells.Value = financialItemsQryVw_OneCurr.CalcWholeRecycledOfFinancialItems();
                            }
                            using (var cells = generalFinancialReportWs.Cells[startRow, 3])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                cells.Value = "مدور بيد رئيس الـ PM";
                            }
                            startRow += 5;
                            #endregion
                            break;
                        case 2:
                            List<string> subLevelList2 = financialItemsQryVw_OneCurr.Select(fiv1 => fiv1.الدائرة).Distinct().ToList();
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
                                cells.Value = StaticCode.GetActiveUserSection();
                            }
                            startRow += 2;

                            #region Incoming of sub-level
                            var incomingSubLevelQry2 = financialItemsQryVw_OneCurr.Where(fiv2 => fiv2.وارد_أم_صادر == "وارد").OrderByDescending(fiv22 => fiv22.جهة_الإيراد);
                            double totalIncomingSubLevel2 = financialItemsQryVw_OneCurr.CalcIncomingOfFinancialItems();

                            int incomingRow2 = startRow;
                            using (var cells = generalFinancialReportWs.Cells[incomingRow2, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "إيرادات";
                            }
                            using (var cells = generalFinancialReportWs.Cells[incomingRow2, 3])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "جهة الإيراد";
                            }
                            incomingRow2++;
                            foreach (var oneSubItem in incomingSubLevelQry2)
                            {
                                using (var cells = generalFinancialReportWs.Cells[incomingRow2, 2])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                    cells.Value = oneSubItem.المبلغ_الوارد;
                                }
                                using (var cells = generalFinancialReportWs.Cells[incomingRow2, 3])
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
                                incomingRow2++;
                            }
                            using (var cells = generalFinancialReportWs.Cells[incomingRow2, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                                cells.Value = totalIncomingSubLevel2;
                            }
                            using (var cells = generalFinancialReportWs.Cells[incomingRow2, 3])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                cells.Value = "مجموع إيرادات الدائرة";
                            }
                            incomingRow2++;
                            #endregion

                            #region Outgoing of sub-level
                            var outgoingSubLevelQry2 = financialItemsQryVw_OneCurr.Where(fiv2 => fiv2.وارد_أم_صادر == "صادر").OrderByDescending(fiv22 => fiv22.نوع_الصادر);
                            double totalOutgoingSubLevel2 = financialItemsQryVw_OneCurr.CalcOutgoingOfFinancialItems();

                            int outgoingRow2 = startRow;
                            using (var cells = generalFinancialReportWs.Cells[outgoingRow2, 5])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "صادرات";
                            }
                            using (var cells = generalFinancialReportWs.Cells[outgoingRow2, 6])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "نوع الصادرات";
                            }
                            using (var cells = generalFinancialReportWs.Cells[outgoingRow2, 7])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "صادر إلى";
                            }
                            outgoingRow2++;
                            foreach (var oneSubItem in outgoingSubLevelQry2)
                            {
                                using (var cells = generalFinancialReportWs.Cells[outgoingRow2, 5])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                    cells.Value = oneSubItem.المبلغ_الصادر;
                                }
                                using (var cells = generalFinancialReportWs.Cells[outgoingRow2, 6])
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
                                using (var cells = generalFinancialReportWs.Cells[outgoingRow2, 7])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                    cells.Value = oneSubItem.صادر_إلى;
                                }
                                outgoingRow2++;
                            }
                            using (var cells = generalFinancialReportWs.Cells[outgoingRow2, 5])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                                cells.Value = totalOutgoingSubLevel2;
                            }
                            using (var cells = generalFinancialReportWs.Cells[outgoingRow2, 6, outgoingRow2, 7])
                            {
                                ExcelRichTextCollection textValue = cells.RichText;
                                ExcelRichText richText1 = textValue.Add("مجموع (الصادرات المباشرة والمعلقة) للدائرة");
                                richText1.Color = Color.Black;
                                ExcelRichText richText2 = textValue.Add(" دون أفرع الدائرة");
                                richText2.Color = Color.Red;
                                cells.Merge = true;
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                            }
                            outgoingRow2++;
                            #endregion

                            #region Recycled of sub-level
                            startRow = Math.Max(incomingRow2, outgoingRow2) + 1;
                            using (var cells = generalFinancialReportWs.Cells[startRow, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                cells.Value = financialItemsQryVw_OneCurr.CalcWholeRecycledOfFinancialItems();
                            }
                            using (var cells = generalFinancialReportWs.Cells[startRow, 3])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                cells.Value = "مدور بيد رئيس الدائرة";
                            }
                            startRow += 5;
                            #endregion
                            break;
                        case 3:
                            List<string> subLevelList3 = financialItemsQryVw_OneCurr.Select(fiv1 => fiv1.الدائرة).Distinct().ToList();
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
                                cells.Value = StaticCode.GetActiveUserDept();
                            }
                            startRow += 2;

                            #region Incoming of sub-level
                            var incomingSubLevelQry3 = financialItemsQryVw_OneCurr.Where(fiv2 => fiv2.وارد_أم_صادر == "وارد").OrderByDescending(fiv22 => fiv22.جهة_الإيراد);
                            double totalIncomingSubLevel3 = financialItemsQryVw_OneCurr.CalcIncomingOfFinancialItems();

                            int incomingRow3 = startRow;
                            using (var cells = generalFinancialReportWs.Cells[incomingRow3, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "إيرادات";
                            }
                            using (var cells = generalFinancialReportWs.Cells[incomingRow3, 3])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "جهة الإيراد";
                            }
                            incomingRow3++;
                            foreach (var oneSubItem in incomingSubLevelQry3)
                            {
                                using (var cells = generalFinancialReportWs.Cells[incomingRow3, 2])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                    cells.Value = oneSubItem.المبلغ_الوارد;
                                }
                                using (var cells = generalFinancialReportWs.Cells[incomingRow3, 3])
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
                                incomingRow3++;
                            }
                            using (var cells = generalFinancialReportWs.Cells[incomingRow3, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                                cells.Value = totalIncomingSubLevel3;
                            }
                            using (var cells = generalFinancialReportWs.Cells[incomingRow3, 3])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                cells.Value = "مجموع إيرادات القسم";
                            }
                            incomingRow3++;
                            #endregion

                            #region Outgoing of sub-level
                            var outgoingSubLevelQry3 = financialItemsQryVw_OneCurr.Where(fiv2 => fiv2.وارد_أم_صادر == "صادر").OrderByDescending(fiv22 => fiv22.نوع_الصادر);
                            double totalOutgoingSubLevel3 = financialItemsQryVw_OneCurr.CalcOutgoingOfFinancialItems();

                            int outgoingRow3 = startRow;
                            using (var cells = generalFinancialReportWs.Cells[outgoingRow3, 5])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "صادرات";
                            }
                            using (var cells = generalFinancialReportWs.Cells[outgoingRow3, 6])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "نوع الصادرات";
                            }
                            using (var cells = generalFinancialReportWs.Cells[outgoingRow3, 7])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "صادر إلى";
                            }
                            outgoingRow3++;
                            foreach (var oneSubItem in outgoingSubLevelQry3)
                            {
                                using (var cells = generalFinancialReportWs.Cells[outgoingRow3, 5])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                    cells.Value = oneSubItem.المبلغ_الصادر;
                                }
                                using (var cells = generalFinancialReportWs.Cells[outgoingRow3, 6])
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
                                using (var cells = generalFinancialReportWs.Cells[outgoingRow3, 7])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                    cells.Value = oneSubItem.صادر_إلى;
                                }
                                outgoingRow3++;
                            }
                            using (var cells = generalFinancialReportWs.Cells[outgoingRow3, 5])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                                cells.Value = totalOutgoingSubLevel3;
                            }
                            using (var cells = generalFinancialReportWs.Cells[outgoingRow3, 6, outgoingRow3, 7])
                            {
                                ExcelRichTextCollection textValue = cells.RichText;
                                ExcelRichText richText1 = textValue.Add("مجموع (الصادرات المباشرة والمعلقة) للقسم");
                                richText1.Color = Color.Black;
                                ExcelRichText richText2 = textValue.Add(" دون أفرع القسم");
                                richText2.Color = Color.Red;
                                cells.Merge = true;
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                            }
                            outgoingRow3++;
                            #endregion

                            #region Recycled of sub-level
                            startRow = Math.Max(incomingRow3, outgoingRow3) + 1;
                            using (var cells = generalFinancialReportWs.Cells[startRow, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                cells.Value = financialItemsQryVw_OneCurr.CalcWholeRecycledOfFinancialItems();
                            }
                            using (var cells = generalFinancialReportWs.Cells[startRow, 3])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                cells.Value = "مدور بيد رئيس القسم";
                            }
                            startRow += 5;
                            #endregion
                            break;
                        default:
                            break;
                    }
                    #endregion

                    #region Detailed fincnaial report
                    string sheet_Title_Name2 = "السجل المالي التفصيلي لل PM";
                    string sheet_Title_Name2_short = "تفصيلي PM";
                    if (StaticCode.activeUserRole.IsSectionIndependent == true)
                    {
                        sheet_Title_Name2 = "السجل المالي التفصيلي لل PM";
                        sheet_Title_Name2_short = "تفصيلي PM";
                    }
                    else if (StaticCode.activeUserRole.IsDepartmentIndependent == true)
                    {
                        sheet_Title_Name2 = "السجل المالي التفصيلي للدائرة";
                        sheet_Title_Name2_short = "تفصيلي دائرة";
                    }
                    else
                    {
                        sheet_Title_Name2 = "السجل المالي التفصيلي للقسم";
                        sheet_Title_Name2_short = "تفصيلي قسم";
                    }
                    sheet_Title_Name2_short += " - " + oneCurr;

                    ExcelWorksheet detailedFinancialReportWs = financialReport_SubLevelsWb.Worksheets.Add(sheet_Title_Name2_short);
                    detailedFinancialReportWs.View.ShowGridLines = false;
                    detailedFinancialReportWs.View.RightToLeft = true;
                    detailedFinancialReportWs.View.ZoomScale = 70;
                    detailedFinancialReportWs.Column(2).Width = 15;
                    detailedFinancialReportWs.Column(3).Width = 18;
                    detailedFinancialReportWs.Column(4).Width = 34;
                    detailedFinancialReportWs.Column(5).Width = 38;
                    detailedFinancialReportWs.Column(6).Width = 47;
                    detailedFinancialReportWs.Column(8).Width = 20;
                    detailedFinancialReportWs.Column(9).Width =
                    detailedFinancialReportWs.Column(10).Width =
                    detailedFinancialReportWs.Column(11).Width =
                    detailedFinancialReportWs.Column(12).Width =
                    detailedFinancialReportWs.Column(13).Width =
                    detailedFinancialReportWs.Column(14).Width = 20;
                    detailedFinancialReportWs.Column(15).Width = 45;
                    detailedFinancialReportWs.Column(16).Width = 20;
                    detailedFinancialReportWs.Column(17).Width = 30;
                    using (var cells = detailedFinancialReportWs.Cells[2, 2, 3, 7])
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
                    startRow = 6;
                    switch (fiSubLevel)
                    {
                        case 1:
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
                                cells.Value = StaticCode.PMName;
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
                                cells.Value = "السجل المالي الكلي للـ PM";
                            }
                            startRow += 2;

                            #region Recycled of sub-level in detail
                            double totalIncomingSubLevel1 = financialItemsQryVw_OneCurr.CalcIncomingOfFinancialItems();
                            double totalOutgoingSubLevel1 = financialItemsQryVw_OneCurr.CalcOutgoingOfFinancialItems();
                            var directOutgoingSubLevelQry1 = financialItemsQryVw_OneCurr.Where(idoufv => idoufv.وارد_أم_صادر == "صادر" && idoufv.نوع_الصادر == "صادرات مباشرة");
                            var incomingOrDirectOutgoingSubLevelQry1 = financialItemsQryVw_OneCurr.Where(idoufv => idoufv.وارد_أم_صادر == "وارد" || (idoufv.وارد_أم_صادر == "صادر" && idoufv.نوع_الصادر == "صادرات مباشرة")).OrderByDescending(idoufv2 => idoufv2.وارد_أم_صادر);
                            double totalRecycledSubLevel1 = financialItemsQryVw_OneCurr.CalcWholeRecycledOfFinancialItems();

                            int figuresRow1 = startRow;
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow1, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                                cells.Value = totalIncomingSubLevel1;
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow1, 3])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                                cells.Value = "مجموع إيرادات الـ PM";
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow1, 5])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(248, 230, 173));
                                cells.Value = totalOutgoingSubLevel1;
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow1, 6])
                            {
                                ExcelRichTextCollection textValue = cells.RichText;
                                ExcelRichText richText1 = textValue.Add("مجموع (الصادرات المباشرة والمعلقة) للـ PM");
                                richText1.Color = Color.Black;
                                ExcelRichText richText2 = textValue.Add(" دون أفرع الـ PM");
                                richText2.Color = Color.Red;
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(248, 230, 173));
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow1 + 2, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Value = totalRecycledSubLevel1;
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow1 + 2, 3])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Value = "مدور بيد رئيس الـ PM";
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow1 + 2, 5])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                                cells.Value = directOutgoingSubLevelQry1.CalcOutgoingOfFinancialItems();
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow1 + 2, 6])
                            {
                                ExcelRichTextCollection textValue = cells.RichText;
                                ExcelRichText richText1 = textValue.Add("مجموع (الصادرات المباشرة فقط) للـ PM");
                                richText1.Color = Color.Black;
                                ExcelRichText richText2 = textValue.Add(" وتفرعاته");
                                richText2.Color = Color.Red;
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                            }
                            figuresRow1 += 5;
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow1, 2, figuresRow1, 6])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 14.0F;
                                cells.Merge = true;
                                cells.Style.Font.Bold = true;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "المدور الكلي لل PM وتفرعاته";
                            }
                            figuresRow1++;
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow1, 2, figuresRow1, 6])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 14.0F;
                                cells.Merge = true;
                                cells.Style.Font.Bold = true;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = totalRecycledSubLevel1;
                            }
                            figuresRow1 += 3;
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow1, 2, figuresRow1, 6])
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
                                cells.Value = "تفصيل المدور الكلي للـ PM وتفرعاته";
                            }
                            figuresRow1++;
                            int allRecycledRow1 = figuresRow1;
                            List<string> sects = financialItemsQryVw_OneCurr.Select(fvi1 => fvi1.الدائرة).Distinct().ToList();
                            using (var cells = detailedFinancialReportWs.Cells[allRecycledRow1, 2, allRecycledRow1 + sects.Count() - 1, 4])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                            }
                            using (var cells = detailedFinancialReportWs.Cells[allRecycledRow1, 5, allRecycledRow1 + sects.Count() - 1, 5])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 14.0F;
                                cells.Merge = true;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "المجموع";
                            }
                            using (var cells = detailedFinancialReportWs.Cells[allRecycledRow1, 6, allRecycledRow1 + sects.Count() - 1, 6])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 14.0F;
                                cells.Merge = true;
                                cells.Style.Font.Bold = true;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = financialItemsQryVw_OneCurr.CalcHeadRecycledOfFinancialItems();
                            }
                            foreach (string oneSct in sects)
                            {
                                Application.DoEvents();
                                using (var cells = detailedFinancialReportWs.Cells[allRecycledRow1, 2, allRecycledRow1, 3])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.Font.Bold = true;
                                    cells.Merge = true;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    cells.Value = ("مدور بيد رئيس دائرة " + oneSct);
                                }
                                using (var cells = detailedFinancialReportWs.Cells[allRecycledRow1, 4])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    cells.Value = financialItemsQryVw_OneCurr.Where(fvd1 => fvd1.الدائرة == oneSct).CalcHeadRecycledOfFinancialItems();
                                }
                                allRecycledRow1++;
                            }
                            figuresRow1 = allRecycledRow1;
                            #endregion

                            #region Incoming and Direct outgoing of sub-level in detail
                            int tableRow1 = startRow;
                            using (var cells = detailedFinancialReportWs.Cells[tableRow1, 9, tableRow1, 17])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(208, 206, 206));
                            }
                            detailedFinancialReportWs.Cells[tableRow1, 9].Value = "الوارد";
                            detailedFinancialReportWs.Cells[tableRow1, 10].Value = "الصادر";
                            detailedFinancialReportWs.Cells[tableRow1, 11].Value = "العملة";
                            detailedFinancialReportWs.Cells[tableRow1, 12].Value = "جهة الإيراد";
                            detailedFinancialReportWs.Cells[tableRow1, 13].Value = "نوع الصادر";
                            detailedFinancialReportWs.Cells[tableRow1, 14].Value = "صادر إلى";
                            detailedFinancialReportWs.Cells[tableRow1, 15].Value = "البيان";
                            detailedFinancialReportWs.Cells[tableRow1, 16].Value = "التاريخ";
                            detailedFinancialReportWs.Cells[tableRow1, 17].Value = "لربط الخلايا";
                            if (incomingOrDirectOutgoingSubLevelQry1.Any())
                            {
                                using (var cells = detailedFinancialReportWs.Cells[tableRow1 + 1, 9, tableRow1 + incomingOrDirectOutgoingSubLevelQry1.Count(), 17])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                }
                                using (var cells = detailedFinancialReportWs.Cells[tableRow1 + incomingOrDirectOutgoingSubLevelQry1.Count() + 1, 9, tableRow1 + incomingOrDirectOutgoingSubLevelQry1.Count() + 1, 17])
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
                                tableRow1++;
                                foreach (var oneRec in incomingOrDirectOutgoingSubLevelQry1)
                                {
                                    detailedFinancialReportWs.Cells[tableRow1, 9].Value = oneRec.المبلغ_الوارد;
                                    detailedFinancialReportWs.Cells[tableRow1, 10].Value = oneRec.المبلغ_الصادر;
                                    detailedFinancialReportWs.Cells[tableRow1, 11].Value = oneRec.العملة;
                                    detailedFinancialReportWs.Cells[tableRow1, 12].Value = oneRec.جهة_الإيراد;
                                    detailedFinancialReportWs.Cells[tableRow1, 13].Value = oneRec.نوع_الصادر;
                                    detailedFinancialReportWs.Cells[tableRow1, 14].Value = oneRec.صادر_إلى;
                                    detailedFinancialReportWs.Cells[tableRow1, 15].Value = oneRec.بيان_السجل_المالي;
                                    detailedFinancialReportWs.Cells[tableRow1, 16].Value = oneRec.تاريخ_تحرير_السجل.ToString("d");
                                    detailedFinancialReportWs.Cells[tableRow1, 17].Value = oneRec.اسم_البند_المالي;
                                    tableRow1++;
                                }
                                detailedFinancialReportWs.Cells[tableRow1, 9].Value = incomingOrDirectOutgoingSubLevelQry1.CalcIncomingOfFinancialItems();
                                detailedFinancialReportWs.Cells[tableRow1, 10].Value = incomingOrDirectOutgoingSubLevelQry1.CalcOutgoingOfFinancialItems();
                                tableRow1++;
                            }
                            #endregion

                            #region Total amounts of sub-levels

                            startRow = Math.Max(figuresRow1, tableRow1) + 3;
                            using (var cells = detailedFinancialReportWs.Cells[startRow, 2, startRow, 6])
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
                                cells.Value = "ملخص مختصر لإيرادات وصادرات الـ PM وتفرعاته";
                            }
                            startRow++;
                            using (var cells = detailedFinancialReportWs.Cells[startRow, 2, startRow, 3])
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
                                cells.Value = "";
                            }
                            using (var cells = detailedFinancialReportWs.Cells[startRow, 4])
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
                                cells.Value = "إجمالي إيرادات";
                            }
                            using (var cells = detailedFinancialReportWs.Cells[startRow, 5])
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
                                cells.Value = "إجمالي صادرات (مباشر ومعلق)";
                            }
                            using (var cells = detailedFinancialReportWs.Cells[startRow, 6])
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
                                cells.Value = "مدور المستوى بدون المستوى الادنى";
                            }
                            startRow++;
                            foreach (string oneSct in StaticCode.mainDbContext.SectionTbls.Select(sct1 => sct1.SectionName).ToList())
                            {
                                Application.DoEvents();

                                using (var cells = detailedFinancialReportWs.Cells[startRow, 2, startRow, 3])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Merge = true;
                                    cells.Style.Font.Bold = true;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    cells.Value = oneSct;
                                }
                                using (var cells = detailedFinancialReportWs.Cells[startRow, 4])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    cells.Value = financialItemsQryVw_OneCurr.Where(fvd1 => fvd1.الدائرة == oneSct).CalcIncomingOfFinancialItems();
                                }
                                using (var cells = detailedFinancialReportWs.Cells[startRow, 5])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    cells.Value = financialItemsQryVw_OneCurr.Where(fvd1 => fvd1.الدائرة == oneSct).CalcOutgoingOfFinancialItems();
                                }
                                using (var cells = detailedFinancialReportWs.Cells[startRow, 6])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Merge = true;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    cells.Value = financialItemsQryVw_OneCurr.Where(fvd1 => fvd1.الدائرة == oneSct).CalcHeadRecycledOfFinancialItems();
                                }
                                startRow++;
                            }

                            #region Total Row
                            //using (var cells = detailedFinancialReportWs.Cells[startRow, 2, startRow, 3])
                            //{
                            //    cells.Style.Font.Name = "Calibri";
                            //    cells.Style.Font.Size = 14.0F;
                            //    cells.Merge = true;
                            //    cells.Style.Font.Bold = true;
                            //    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            //    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                            //    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                            //    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                            //    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                            //    cells.Value = "الإجمالي";
                            //}
                            //using (var cells = detailedFinancialReportWs.Cells[startRow, 4])
                            //{
                            //    cells.Style.Font.Name = "Calibri";
                            //    cells.Style.Font.Size = 14.0F;
                            //    cells.Merge = true;
                            //    cells.Style.Font.Bold = true;
                            //    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            //    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                            //    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                            //    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                            //    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                            //    cells.Value = financialItemsQryVw.CalcIncomingOfFinancialItems();
                            //}
                            //using (var cells = detailedFinancialReportWs.Cells[startRow, 5])
                            //{
                            //    cells.Style.Font.Name = "Calibri";
                            //    cells.Style.Font.Size = 14.0F;
                            //    cells.Merge = true;
                            //    cells.Style.Font.Bold = true;
                            //    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            //    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                            //    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                            //    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                            //    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                            //    cells.Value = financialItemsQryVw.CalcOutgoingOfFinancialItems();
                            //}
                            //using (var cells = detailedFinancialReportWs.Cells[startRow, 6])
                            //{
                            //    cells.Style.Font.Name = "Calibri";
                            //    cells.Style.Font.Size = 14.0F;
                            //    cells.Merge = true;
                            //    cells.Style.Font.Bold = true;
                            //    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            //    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                            //    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                            //    cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                            //    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                            //    cells.Value = financialItemsQryVw.CalcHeadRecycledOfFinancialItems();
                            //}
                            //startRow++;
                            #endregion
                            #endregion
                            break;
                        case 2:
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
                                cells.Value = StaticCode.GetActiveUserSection();
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
                                cells.Value = "السجل المالي الكلي للدائرة";
                            }
                            startRow += 2;

                            #region Recycled of sub-level in detail
                            double totalIncomingSubLevel2 = financialItemsQryVw_OneCurr.CalcIncomingOfFinancialItems();
                            double totalOutgoingSubLevel2 = financialItemsQryVw_OneCurr.CalcOutgoingOfFinancialItems();
                            var directOutgoingSubLevelQry2 = financialItemsQryVw_OneCurr.Where(idoufv => idoufv.وارد_أم_صادر == "صادر" && idoufv.نوع_الصادر == "صادرات مباشرة");
                            var incomingOrDirectOutgoingSubLevelQry2 = financialItemsQryVw_OneCurr.Where(idoufv => idoufv.وارد_أم_صادر == "وارد" || (idoufv.وارد_أم_صادر == "صادر" && idoufv.نوع_الصادر == "صادرات مباشرة")).OrderByDescending(idoufv2 => idoufv2.وارد_أم_صادر);
                            double totalRecycledSubLevel2 = financialItemsQryVw_OneCurr.CalcWholeRecycledOfFinancialItems();

                            int figuresRow2 = startRow;
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow2, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                                cells.Value = totalIncomingSubLevel2;
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow2, 3])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                                cells.Value = "مجموع إيرادات الدائرة";
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow2, 5])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(248, 230, 173));
                                cells.Value = totalOutgoingSubLevel2;
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow2, 6])
                            {
                                ExcelRichTextCollection textValue = cells.RichText;
                                ExcelRichText richText1 = textValue.Add("مجموع (الصادرات المباشرة والمعلقة) للدائرة");
                                richText1.Color = Color.Black;
                                ExcelRichText richText2 = textValue.Add(" دون أفرع الدائرة");
                                richText2.Color = Color.Red;
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(248, 230, 173));
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow2 + 2, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Value = totalRecycledSubLevel2;
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow2 + 2, 3])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Value = "مدور بيد رئيس الدائرة";
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow2 + 2, 5])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                                cells.Value = directOutgoingSubLevelQry2.CalcOutgoingOfFinancialItems();
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow2 + 2, 6])
                            {
                                ExcelRichTextCollection textValue = cells.RichText;
                                ExcelRichText richText1 = textValue.Add("مجموع (الصادرات المباشرة فقط) للدائرة");
                                richText1.Color = Color.Black;
                                ExcelRichText richText2 = textValue.Add(" وتفرعاتها");
                                richText2.Color = Color.Red;
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                            }
                            figuresRow2 += 5;
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow2, 2, figuresRow2, 6])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 14.0F;
                                cells.Merge = true;
                                cells.Style.Font.Bold = true;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "المدور الكلي للدائرة وتفرعاتها";
                            }
                            figuresRow2++;
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow2, 2, figuresRow2, 6])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 14.0F;
                                cells.Merge = true;
                                cells.Style.Font.Bold = true;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = totalRecycledSubLevel2;
                            }
                            figuresRow2 += 3;
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow2, 2, figuresRow2, 6])
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
                                cells.Value = "تفصيل المدور الكلي للدائرة وتفرعاتها";
                            }
                            figuresRow2++;
                            int allRecycledRow2 = figuresRow2;
                            List<string> depts = financialItemsQryVw_OneCurr.Select(fvi2 => fvi2.القسم).Distinct().ToList();
                            using (var cells = detailedFinancialReportWs.Cells[allRecycledRow2, 2, allRecycledRow2 + depts.Count() - 1, 4])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                            }
                            using (var cells = detailedFinancialReportWs.Cells[allRecycledRow2, 5, allRecycledRow2 + depts.Count() - 1, 5])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 14.0F;
                                cells.Merge = true;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "المجموع";
                            }
                            using (var cells = detailedFinancialReportWs.Cells[allRecycledRow2, 6, allRecycledRow2 + depts.Count() - 1, 6])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 14.0F;
                                cells.Merge = true;
                                cells.Style.Font.Bold = true;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = financialItemsQryVw_OneCurr.CalcHeadRecycledOfFinancialItems();
                            }
                            foreach (string oneDpt in depts)
                            {
                                Application.DoEvents();
                                using (var cells = detailedFinancialReportWs.Cells[allRecycledRow2, 2, allRecycledRow2, 3])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.Font.Bold = true;
                                    cells.Merge = true;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    cells.Value = ("مدور بيد رئيس قسم " + oneDpt);
                                }
                                using (var cells = detailedFinancialReportWs.Cells[allRecycledRow2, 4])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    cells.Value = financialItemsQryVw_OneCurr.Where(fvd2 => fvd2.القسم == oneDpt).CalcHeadRecycledOfFinancialItems();
                                }
                                allRecycledRow2++;
                            }
                            figuresRow2 = allRecycledRow2;
                            #endregion

                            #region Incoming and Direct outgoing of sub-level in detail
                            int tableRow2 = startRow;
                            using (var cells = detailedFinancialReportWs.Cells[tableRow2, 9, tableRow2, 17])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(208, 206, 206));
                            }
                            detailedFinancialReportWs.Cells[tableRow2, 9].Value = "الوارد";
                            detailedFinancialReportWs.Cells[tableRow2, 10].Value = "الصادر";
                            detailedFinancialReportWs.Cells[tableRow2, 11].Value = "العملة";
                            detailedFinancialReportWs.Cells[tableRow2, 12].Value = "جهة الإيراد";
                            detailedFinancialReportWs.Cells[tableRow2, 13].Value = "نوع الصادر";
                            detailedFinancialReportWs.Cells[tableRow2, 14].Value = "صادر إلى";
                            detailedFinancialReportWs.Cells[tableRow2, 15].Value = "البيان";
                            detailedFinancialReportWs.Cells[tableRow2, 16].Value = "التاريخ";
                            detailedFinancialReportWs.Cells[tableRow2, 17].Value = "لربط الخلايا";
                            if (incomingOrDirectOutgoingSubLevelQry2.Any())
                            {
                                using (var cells = detailedFinancialReportWs.Cells[tableRow2 + 1, 9, tableRow2 + incomingOrDirectOutgoingSubLevelQry2.Count(), 17])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                }
                                using (var cells = detailedFinancialReportWs.Cells[tableRow2 + incomingOrDirectOutgoingSubLevelQry2.Count() + 1, 9, tableRow2 + incomingOrDirectOutgoingSubLevelQry2.Count() + 1, 17])
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
                                tableRow2++;
                                foreach (var oneRec in incomingOrDirectOutgoingSubLevelQry2)
                                {
                                    detailedFinancialReportWs.Cells[tableRow2, 9].Value = oneRec.المبلغ_الوارد;
                                    detailedFinancialReportWs.Cells[tableRow2, 10].Value = oneRec.المبلغ_الصادر;
                                    detailedFinancialReportWs.Cells[tableRow2, 11].Value = oneRec.العملة;
                                    detailedFinancialReportWs.Cells[tableRow2, 12].Value = oneRec.جهة_الإيراد;
                                    detailedFinancialReportWs.Cells[tableRow2, 13].Value = oneRec.نوع_الصادر;
                                    detailedFinancialReportWs.Cells[tableRow2, 14].Value = oneRec.صادر_إلى;
                                    detailedFinancialReportWs.Cells[tableRow2, 15].Value = oneRec.بيان_السجل_المالي;
                                    detailedFinancialReportWs.Cells[tableRow2, 16].Value = oneRec.تاريخ_تحرير_السجل.ToString("d");
                                    detailedFinancialReportWs.Cells[tableRow2, 17].Value = oneRec.اسم_البند_المالي;
                                    tableRow2++;
                                }
                                detailedFinancialReportWs.Cells[tableRow2, 9].Value = incomingOrDirectOutgoingSubLevelQry2.CalcIncomingOfFinancialItems();
                                detailedFinancialReportWs.Cells[tableRow2, 10].Value = incomingOrDirectOutgoingSubLevelQry2.CalcOutgoingOfFinancialItems();
                                tableRow2++;
                            }
                            #endregion

                            #region Total amounts of sub-levels
                            startRow = Math.Max(figuresRow2, tableRow2) + 3;

                            using (var cells = detailedFinancialReportWs.Cells[startRow, 2, startRow, 6])
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
                                cells.Value = "ملخص مختصر لإيرادات وصادرات الدائرة وتفرعاتها";
                            }
                            startRow++;
                            using (var cells = detailedFinancialReportWs.Cells[startRow, 2, startRow, 3])
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
                                cells.Value = "";
                            }
                            using (var cells = detailedFinancialReportWs.Cells[startRow, 4])
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
                                cells.Value = "إجمالي إيرادات";
                            }
                            using (var cells = detailedFinancialReportWs.Cells[startRow, 5])
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
                                cells.Value = "إجمالي صادرات (مباشر ومعلق)";
                            }
                            using (var cells = detailedFinancialReportWs.Cells[startRow, 6])
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
                                cells.Value = "مدور المستوى بدون المستوى الادنى";
                            }
                            startRow++;
                            foreach (string oneDpt in financialItemsQryVw_OneCurr.Select(fvd2 => fvd2.القسم).Distinct())
                            {
                                Application.DoEvents();

                                using (var cells = detailedFinancialReportWs.Cells[startRow, 2, startRow, 3])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Merge = true;
                                    cells.Style.Font.Bold = true;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    string oneDpt1 = oneDpt;
                                    if (oneDpt1 == "")
                                        oneDpt1 = "إدارة الدائرة";
                                    cells.Value = oneDpt1;
                                }
                                using (var cells = detailedFinancialReportWs.Cells[startRow, 4])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    cells.Value = financialItemsQryVw_OneCurr.Where(fvd2 => fvd2.القسم == oneDpt).CalcIncomingOfFinancialItems();
                                }
                                using (var cells = detailedFinancialReportWs.Cells[startRow, 5])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    cells.Value = financialItemsQryVw_OneCurr.Where(fvd2 => fvd2.القسم == oneDpt).CalcOutgoingOfFinancialItems();
                                }
                                using (var cells = detailedFinancialReportWs.Cells[startRow, 6])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Merge = true;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    cells.Value = financialItemsQryVw_OneCurr.Where(fvd2 => fvd2.القسم == oneDpt).CalcHeadRecycledOfFinancialItems();
                                }
                                startRow++;
                            }
                            #endregion
                            break;
                        case 3:
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
                                cells.Value = StaticCode.GetActiveUserDept();
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
                                cells.Value = "السجل المالي الكلي للقسم";
                            }
                            startRow += 2;

                            #region Recycled of sub-level in detail
                            double totalIncomingSubLevel3 = financialItemsQryVw_OneCurr.CalcIncomingOfFinancialItems();
                            double totalOutgoingSubLevel3 = financialItemsQryVw_OneCurr.CalcOutgoingOfFinancialItems();
                            var directOutgoingSubLevelQry3 = financialItemsQryVw_OneCurr.Where(idoufv => idoufv.وارد_أم_صادر == "صادر" && idoufv.نوع_الصادر == "صادرات مباشرة");
                            var incomingOrDirectOutgoingSubLevelQry3 = financialItemsQryVw_OneCurr.Where(idoufv => idoufv.وارد_أم_صادر == "وارد" || (idoufv.وارد_أم_صادر == "صادر" && idoufv.نوع_الصادر == "صادرات مباشرة")).OrderByDescending(idoufv2 => idoufv2.وارد_أم_صادر);
                            double totalRecycledSubLevel3 = financialItemsQryVw_OneCurr.CalcWholeRecycledOfFinancialItems();

                            int figuresRow3 = startRow;
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow3, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                                cells.Value = totalIncomingSubLevel3;
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow3, 3])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                                cells.Value = "مجموع إيرادات القسم";
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow3, 5])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(248, 230, 173));
                                cells.Value = totalOutgoingSubLevel3;
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow3, 6])
                            {
                                ExcelRichTextCollection textValue = cells.RichText;
                                ExcelRichText richText1 = textValue.Add("مجموع (الصادرات المباشرة والمعلقة) للقسم");
                                richText1.Color = Color.Black;
                                ExcelRichText richText2 = textValue.Add(" دون أفرع القسم");
                                richText2.Color = Color.Red;
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(248, 230, 173));
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow3 + 2, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Value = totalRecycledSubLevel3;
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow3 + 2, 3])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Value = "مدور بيد رئيس القسم";
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow3 + 2, 5])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                                cells.Value = directOutgoingSubLevelQry3.CalcOutgoingOfFinancialItems();
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow3 + 2, 6])
                            {
                                ExcelRichTextCollection textValue = cells.RichText;
                                ExcelRichText richText1 = textValue.Add("مجموع (الصادرات المباشرة فقط) للقسم");
                                richText1.Color = Color.Black;
                                ExcelRichText richText2 = textValue.Add(" وتفرعاته");
                                richText2.Color = Color.Red;
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                            }
                            figuresRow3 += 5;
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow3, 2, figuresRow3, 6])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 14.0F;
                                cells.Merge = true;
                                cells.Style.Font.Bold = true;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "المدور الكلي للقسم وتفرعاته";
                            }
                            figuresRow3++;
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow3, 2, figuresRow3, 6])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 14.0F;
                                cells.Merge = true;
                                cells.Style.Font.Bold = true;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = totalRecycledSubLevel3;
                            }
                            figuresRow3 += 3;
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow3, 2, figuresRow3, 6])
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
                                cells.Value = "تفصيل المدور الكلي للقسم وتفرعاته";
                            }
                            figuresRow3++;
                            int allRecycledRow3 = figuresRow3;
                            List<string> sdepts = financialItemsQryVw_OneCurr.Select(fvi3 => fvi3.الوحدة).Distinct().ToList();
                            using (var cells = detailedFinancialReportWs.Cells[allRecycledRow3, 2, allRecycledRow3 + sdepts.Count() - 1, 4])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                            }
                            using (var cells = detailedFinancialReportWs.Cells[allRecycledRow3, 5, allRecycledRow3 + sdepts.Count() - 1, 5])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 14.0F;
                                cells.Merge = true;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "المجموع";
                            }
                            using (var cells = detailedFinancialReportWs.Cells[allRecycledRow3, 6, allRecycledRow3 + sdepts.Count() - 1, 6])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 14.0F;
                                cells.Merge = true;
                                cells.Style.Font.Bold = true;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = financialItemsQryVw_OneCurr.CalcHeadRecycledOfFinancialItems();
                            }
                            foreach (string oneSDpt in sdepts)
                            {
                                Application.DoEvents();
                                using (var cells = detailedFinancialReportWs.Cells[allRecycledRow3, 2, allRecycledRow3, 3])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.Font.Bold = true;
                                    cells.Merge = true;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    cells.Value = ("مدور بيد رئيس وحدة " + oneSDpt);
                                }
                                using (var cells = detailedFinancialReportWs.Cells[allRecycledRow3, 4])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    cells.Value = financialItemsQryVw_OneCurr.Where(fvd3 => fvd3.الوحدة == oneSDpt).CalcHeadRecycledOfFinancialItems();
                                }
                                allRecycledRow3++;
                            }
                            figuresRow3 = allRecycledRow3;
                            #endregion

                            #region Incoming and Direct outgoing of sub-level in detail
                            int tableRow3 = startRow;
                            using (var cells = detailedFinancialReportWs.Cells[tableRow3, 9, tableRow3, 17])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(208, 206, 206));
                            }
                            detailedFinancialReportWs.Cells[tableRow3, 9].Value = "الوارد";
                            detailedFinancialReportWs.Cells[tableRow3, 10].Value = "الصادر";
                            detailedFinancialReportWs.Cells[tableRow3, 11].Value = "العملة";
                            detailedFinancialReportWs.Cells[tableRow3, 12].Value = "جهة الإيراد";
                            detailedFinancialReportWs.Cells[tableRow3, 13].Value = "نوع الصادر";
                            detailedFinancialReportWs.Cells[tableRow3, 14].Value = "صادر إلى";
                            detailedFinancialReportWs.Cells[tableRow3, 15].Value = "البيان";
                            detailedFinancialReportWs.Cells[tableRow3, 16].Value = "التاريخ";
                            detailedFinancialReportWs.Cells[tableRow3, 17].Value = "لربط الخلايا";
                            if (incomingOrDirectOutgoingSubLevelQry3.Any())
                            {
                                using (var cells = detailedFinancialReportWs.Cells[tableRow3 + 1, 9, tableRow3 + incomingOrDirectOutgoingSubLevelQry3.Count(), 17])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                }
                                using (var cells = detailedFinancialReportWs.Cells[tableRow3 + incomingOrDirectOutgoingSubLevelQry3.Count() + 1, 9, tableRow3 + incomingOrDirectOutgoingSubLevelQry3.Count() + 1, 17])
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
                                tableRow3++;
                                foreach (var oneRec in incomingOrDirectOutgoingSubLevelQry3)
                                {
                                    detailedFinancialReportWs.Cells[tableRow3, 9].Value = oneRec.المبلغ_الوارد;
                                    detailedFinancialReportWs.Cells[tableRow3, 10].Value = oneRec.المبلغ_الصادر;
                                    detailedFinancialReportWs.Cells[tableRow3, 11].Value = oneRec.العملة;
                                    detailedFinancialReportWs.Cells[tableRow3, 12].Value = oneRec.جهة_الإيراد;
                                    detailedFinancialReportWs.Cells[tableRow3, 13].Value = oneRec.نوع_الصادر;
                                    detailedFinancialReportWs.Cells[tableRow3, 14].Value = oneRec.صادر_إلى;
                                    detailedFinancialReportWs.Cells[tableRow3, 15].Value = oneRec.بيان_السجل_المالي;
                                    detailedFinancialReportWs.Cells[tableRow3, 16].Value = oneRec.تاريخ_تحرير_السجل.ToString("d");
                                    detailedFinancialReportWs.Cells[tableRow3, 17].Value = oneRec.اسم_البند_المالي;
                                    tableRow3++;
                                }
                                detailedFinancialReportWs.Cells[tableRow3, 9].Value = incomingOrDirectOutgoingSubLevelQry3.CalcIncomingOfFinancialItems();
                                detailedFinancialReportWs.Cells[tableRow3, 10].Value = incomingOrDirectOutgoingSubLevelQry3.CalcOutgoingOfFinancialItems();
                                tableRow3++;
                            }
                            #endregion

                            #region Total amounts of sub-levels
                            startRow = Math.Max(figuresRow3, tableRow3) + 3;

                            using (var cells = detailedFinancialReportWs.Cells[startRow, 2, startRow, 6])
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
                                cells.Value = "ملخص مختصر لإيرادات وصادرات القسم وتفرعاته";
                            }
                            startRow++;
                            using (var cells = detailedFinancialReportWs.Cells[startRow, 2, startRow, 3])
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
                                cells.Value = "";
                            }
                            using (var cells = detailedFinancialReportWs.Cells[startRow, 4])
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
                                cells.Value = "إجمالي إيرادات";
                            }
                            using (var cells = detailedFinancialReportWs.Cells[startRow, 5])
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
                                cells.Value = "إجمالي صادرات (مباشر ومعلق)";
                            }
                            using (var cells = detailedFinancialReportWs.Cells[startRow, 6])
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
                                cells.Value = "مدور المستوى بدون المستوى الادنى";
                            }
                            startRow++;
                            foreach (string oneSDpt in financialItemsQryVw_OneCurr.Select(fvsd3 => fvsd3.الوحدة).Distinct())
                            {
                                Application.DoEvents();

                                using (var cells = detailedFinancialReportWs.Cells[startRow, 2, startRow, 3])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Merge = true;
                                    cells.Style.Font.Bold = true;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    string oneSDpt1 = oneSDpt;
                                    if (oneSDpt1 == "")
                                        oneSDpt1 = "إدارة القسم";
                                    cells.Value = oneSDpt1;
                                }
                                using (var cells = detailedFinancialReportWs.Cells[startRow, 4])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    cells.Value = financialItemsQryVw_OneCurr.Where(fvsd3 => fvsd3.الوحدة == oneSDpt).CalcIncomingOfFinancialItems();
                                }
                                using (var cells = detailedFinancialReportWs.Cells[startRow, 5])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    cells.Value = financialItemsQryVw_OneCurr.Where(fvsd3 => fvsd3.الوحدة == oneSDpt).CalcOutgoingOfFinancialItems();
                                }
                                using (var cells = detailedFinancialReportWs.Cells[startRow, 6])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Merge = true;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    cells.Value = financialItemsQryVw_OneCurr.Where(fvsd3 => fvsd3.الوحدة == oneSDpt).CalcHeadRecycledOfFinancialItems();
                                }
                                startRow++;
                            }
                            #endregion
                            break;
                        default:
                            break;
                    }
                    #endregion

                    financialReport_SubLevelsEp.Save();
                }
                #endregion

                #region Load the excel file to the form
                IWorkbook totalsWorkbook = spreadsheetControl1.Document;
                totalsWorkbook.LoadDocument(financialReportXlsx);
                spreadsheetControl1.ActiveWorksheet.ActiveView.ShowRightToLeft = true;
                #endregion

                progressPanel1.Visible = false;
                mainAlertControl.Show(this, StaticCode.ApplicationTitle, "النتائج جاهزة");
            }
        }

        private void exportFinancialReportToExcelDropDownButton_Click_Old(object sender, EventArgs e)
        {
            SaveFileDialog financialReportSFD = new SaveFileDialog() { Filter = "Excel workbook 2007-2022 (*.xlsx)|*.xlsx" };
            if (financialReportSFD.ShowDialog() != DialogResult.OK)
            {
                mainAlertControl.Show(this, "تم الإلغاء", StaticCode.ApplicationTitle);
                return;
            }
            string targetPath = financialReportSFD.FileName;
            if (!File.Exists(StaticCode.FinancialReportPath2))
            {
                mainAlertControl.Show(this, "فورم التقرير المالي غير موجود", StaticCode.ApplicationTitle);
                MessageBox.Show("فورم التقرير المالي غير موجود", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            File.Copy(StaticCode.FinancialReportPath2, targetPath, true);
            ExcelPackage fiRpEp = new ExcelPackage(new FileInfo(targetPath));
            ExcelWorkbook fiRpWb = fiRpEp.Workbook;
            ExcelWorksheet fiRpWs = fiRpWb.Worksheets.First();
            string sectionVal = (StaticCode.activeUserRole.IsSectionIndependent != true) ? $"الدائرة: {StaticCode.mainDbContext.SectionTbls.Single(sct1 => sct1.ID == StaticCode.activeUser.UserSection).SectionName}" : "";
            string departmentVal = (StaticCode.activeUserRole.IsSectionIndependent != true) ? $"الدائرة: {StaticCode.mainDbContext.SectionTbls.Single(sct1 => sct1.ID == StaticCode.activeUser.UserSection).SectionName}" : "";
            fiRpWs.Cells[2, 1, 2, 2].Value = $"الدائرة: {((searchBySectionCheckBox.Checked) ? searchBySectionLookUpEdit.Text : "الكل")}";
            fiRpWs.Cells[2, 3].Value = $"القسم: {((searchByDepartmentCheckBox.Checked) ? searchByDepartmentSearchLookUpEdit.Text : "الكل")}";
            fiRpWs.Cells[2, 4, 2, 5].Value = $"الوحدة: {((searchBySubDepartmentCheckBox.Checked) ? searchBySubDepartmentSearchLookUpEdit.Text : "الكل")}";
            int startRow = 5;
            foreach (FinancialItemTbl oneFiRp in financialItemsQry.Where(fic1 => fic1.IncomingOrOutgoing == "وارد"))
            {
                Application.DoEvents();
                fiRpWs.Cells[startRow, 1].Value = oneFiRp.IncomingAmount;
                fiRpWs.Cells[startRow, 3].Value = oneFiRp.FinancialItemDescription;
                fiRpWs.Cells[startRow, 4].Value = oneFiRp.FinancialItemInsertionDate.ToShortDateString();
                fiRpWs.Cells[startRow, 5].Value = StaticCode.mainDbContext.FinancialItemCategoryTbls.Single(fic1 => fic1.ID == oneFiRp.FinancialItemCategory).FinancialItemCategoryName;
                startRow++;
            }
            using (var cells = fiRpWs.Cells[startRow, 1, startRow, 5])
            {
                cells.Merge = true;
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                cells.Style.Font.Color.SetColor(Color.FromArgb(31, 73, 125));
                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(242, 220, 219));
                cells.Value = "ثانياً : المصاريف :";
            }
            startRow++;
            foreach (FinancialItemTbl oneFiRp in financialItemsQry.Where(fic1 => fic1.IncomingOrOutgoing == "صادر"))
            {
                Application.DoEvents();
                fiRpWs.Cells[startRow, 2].Value = oneFiRp.OutgoingAmount;
                fiRpWs.Cells[startRow, 3].Value = oneFiRp.FinancialItemDescription;
                fiRpWs.Cells[startRow, 4].Value = oneFiRp.FinancialItemInsertionDate.ToShortDateString();
                fiRpWs.Cells[startRow, 5].Value = StaticCode.mainDbContext.FinancialItemCategoryTbls.Single(fic1 => fic1.ID == oneFiRp.FinancialItemCategory).FinancialItemCategoryName;
                startRow++;
            }
            List<string> mainCategoriesNames = StaticCode.mainDbContext.MainCategoryTbls.Select(maca1 => maca1.MainCategoryName).ToList();
            int macaStartRow = 70;
            foreach (string oneMaCa in mainCategoriesNames)
            {
                fiRpWs.Cells[macaStartRow, 7].Value = oneMaCa;
                macaStartRow++;
            }
            fiRpEp.Save();
            mainAlertControl.Show(this, "تم التصدير بنجاح", StaticCode.ApplicationTitle);
            MessageBox.Show("تم التصدير بنجاح", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            SaveFileDialog financialReportSFD = new SaveFileDialog() { Filter = "Excel workbook 2007-2022 (*.xlsx)|*.xlsx" };
            if (financialReportSFD.ShowDialog() != DialogResult.OK)
            {
                mainAlertControl.Show(this, "تم الإلغاء", StaticCode.ApplicationTitle);
                return;
            }
            string targetPath = financialReportSFD.FileName;
            if (!File.Exists(StaticCode.FinancialReportPath2))
            {
                mainAlertControl.Show(this, "فورم التقرير المالي غير موجود", StaticCode.ApplicationTitle);
                MessageBox.Show("فورم التقرير المالي غير موجود", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            File.Copy(StaticCode.FinancialReportPath2, targetPath, true);
            ExcelPackage fiRpEp = new ExcelPackage(new FileInfo(targetPath));
            ExcelWorkbook fiRpWb = fiRpEp.Workbook;
            ExcelWorksheet fiRpWs = fiRpWb.Worksheets.First();
            ExcelWorksheet listsWs = fiRpWb.Worksheets["Lists"];

            int ficaRowStart = 3;
            int curRowStart = 97;
            int curRowStart2 = 3;
            int curColStart = 13;
            foreach (FinancialItemCategoryTbl oneFiCa in StaticCode.mainDbContext.FinancialItemCategoryTbls)
            {
                listsWs.Cells[ficaRowStart, 3].Value = oneFiCa.FinancialItemCategoryName;
                listsWs.Cells[ficaRowStart, 4].Value = oneFiCa.FinancialItemCategoryDetails;
                ficaRowStart++;
            }
            foreach (CurrencyTbl oneCu in StaticCode.mainDbContext.CurrencyTbls)
            {
                fiRpWs.Cells[curRowStart, 2].Value =
                listsWs.Cells[curRowStart2, 9].Value =
                fiRpWs.Cells[4, curColStart].Value =
                fiRpWs.Cells[14, curColStart].Value =
                fiRpWs.Cells[61, curColStart].Value =
                fiRpWs.Cells[69, curColStart].Value =
                fiRpWs.Cells[82, curColStart].Value =
                fiRpWs.Cells[89, curColStart].Value = oneCu.CurrencyName;
                curRowStart++;
                curRowStart2++;
                curColStart++;
            }
            for (int iCol = 20; iCol >= curColStart; iCol--)
                fiRpWs.DeleteColumn(iCol);

            string sectionOfSearch = "";
            string departmentOfSearch = "";
            string subDepartmentOfSearch = "";
            if (searchBySectionCheckBox.Checked)
            {
                sectionOfSearch = searchBySectionLookUpEdit.Text;
            }
            else if (searchByDepartmentCheckBox.Checked)
            {
                sectionOfSearch = StaticCode.mainDbContext.DepartmentVws.Where(dptv1 => dptv1.اسم_القسم == searchByDepartmentSearchLookUpEdit.Text).First().الدائرة_التي_يتبع_لها_القسم;
                departmentOfSearch = searchByDepartmentSearchLookUpEdit.Text;
            }
            else if (searchBySubDepartmentCheckBox.Checked)
            {
                sectionOfSearch = StaticCode.mainDbContext.SubDepartmentVws.Where(sdtv1 => sdtv1.اسم_الوحدة == searchBySubDepartmentSearchLookUpEdit.Text).First().الدائرة_التي_يتبع_لها_القسم;
                departmentOfSearch = StaticCode.mainDbContext.SubDepartmentVws.Where(sdtv1 => sdtv1.اسم_الوحدة == searchBySubDepartmentSearchLookUpEdit.Text).First().القسم_التابعة_له;
                subDepartmentOfSearch = searchBySubDepartmentSearchLookUpEdit.Text;
            }
            string sectionVal = $"الدائرة: {sectionOfSearch}";
            string departmentVal = $"القسم: {departmentOfSearch}";
            string subDepartmentVal = $"الوحدة: {subDepartmentOfSearch}";
            fiRpWs.Cells[2, 2, 2, 4].Value = sectionVal;
            fiRpWs.Cells[2, 5, 2, 7].Value = departmentVal;
            fiRpWs.Cells[2, 8].Value = subDepartmentVal;
            fiRpWs.Cells[2, 9, 2, 10].Value = $"التاريخ: {DateTime.Today.ToString("yyyy-MM-dd")}";
            int startRow = 5;
            foreach (FinancialItemTbl oneFiRp in financialItemsQry.Where(fic1 => fic1.IncomingOrOutgoing == "وارد"))
            {
                Application.DoEvents();
                fiRpWs.Cells[startRow, 2].Value = oneFiRp.IncomingAmount;
                fiRpWs.Cells[startRow, 4].Value = StaticCode.mainDbContext.CurrencyTbls.Single(cu1 => cu1.ID == oneFiRp.FinancialItemCurrency).CurrencyName;
                fiRpWs.Cells[startRow, 5].Value = oneFiRp.IncomingFrom?.Trim();
                fiRpWs.Cells[startRow, 8].Value = oneFiRp.FinancialItemDescription;
                fiRpWs.Cells[startRow, 9].Value = oneFiRp.FinancialItemInsertionDate.ToShortDateString();
                fiRpWs.Cells[startRow, 10].Value = StaticCode.mainDbContext.FinancialItemCategoryTbls.Single(fic1 => fic1.ID == oneFiRp.FinancialItemCategory).FinancialItemCategoryName;
                startRow++;
            }
            using (var cells = fiRpWs.Cells[startRow, 2, startRow, 10])
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
            foreach (FinancialItemTbl oneFiRp in financialItemsQry.Where(fic1 => fic1.IncomingOrOutgoing == "صادر"))
            {
                Application.DoEvents();
                fiRpWs.Cells[startRow, 3].Value = oneFiRp.OutgoingAmount;
                fiRpWs.Cells[startRow, 4].Value = StaticCode.mainDbContext.CurrencyTbls.Single(cu1 => cu1.ID == oneFiRp.FinancialItemCurrency).CurrencyName;
                fiRpWs.Cells[startRow, 6].Value = oneFiRp.OutgoingType?.Trim();
                fiRpWs.Cells[startRow, 7].Value = oneFiRp.OutgoingTo?.Trim();
                fiRpWs.Cells[startRow, 8].Value = oneFiRp.FinancialItemDescription;
                fiRpWs.Cells[startRow, 9].Value = oneFiRp.FinancialItemInsertionDate.ToShortDateString();
                fiRpWs.Cells[startRow, 10].Value = StaticCode.mainDbContext.FinancialItemCategoryTbls.Single(fic1 => fic1.ID == oneFiRp.FinancialItemCategory).FinancialItemCategoryName;
                startRow++;
            }
            List<string> mainCategoriesNames = StaticCode.mainDbContext.MainCategoryTbls.Select(maca1 => maca1.MainCategoryName).ToList();
            int macaStartRow = 70;
            int macaStartCol = 12;
            foreach (string oneMaCa in mainCategoriesNames)
            {
                fiRpWs.Cells[macaStartRow, macaStartCol].Value = oneMaCa;
                macaStartRow++;
            }
            fiRpEp.Save();
            mainAlertControl.Show(this, "تم التصدير بنجاح", StaticCode.ApplicationTitle);
            MessageBox.Show("تم التصدير بنجاح", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SelectReportDuration(object sender, EventArgs e)
        {
            fromToPanel.Visible = fromToRadioButton.Checked;
            monthlyDateTimePicker.Visible = monthlyRadioButton.Checked;
            annualDateTimePicker.Visible = annualRadioButton.Checked;
        }

        private void searchInDeptRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchBySectionLookUpEdit.Visible = searchBySectionCheckBox.Checked;
            searchByDepartmentSearchLookUpEdit.Visible = searchByDepartmentCheckBox.Checked;
            searchBySubDepartmentSearchLookUpEdit.Visible = searchBySubDepartmentCheckBox.Checked;
            manageSectionTblBtn.Visible = searchBySectionCheckBox.Checked && StaticCode.activeUserRole.ManageSections == true;
            manageDepartmentTblBtn.Visible = searchByDepartmentCheckBox.Checked && StaticCode.activeUserRole.ManageDepartments == true;
            manageSubDepartmentTblBtn.Visible = searchBySubDepartmentCheckBox.Checked && StaticCode.activeUserRole.ManageSubDepartments == true;
            if (searchAllRadioButton.Checked)
            {
                levelSelected = 0;
                levelID = 0;
            }
            if (searchBySectionCheckBox.Checked)
            {
                levelSelected = 1;
            }
            if (searchByDepartmentCheckBox.Checked)
            {
                levelSelected = 2;
                levelID = 0;
            }
            if (searchBySubDepartmentCheckBox.Checked)
            {
                levelSelected = 3;
                levelID = 0;
            }
            subLevelTotalsTreeView.Visible = levelSelected < 3;
        }

        private void manageDepartmentTblBtn_Click(object sender, EventArgs e)
        {
            ManageDepartmentTblForm dptFrm = new ManageDepartmentTblForm();
            dptFrm.ShowDialog();
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
        }

        private void searchWithinPeriodCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchWithinPeriodPanel.Visible = searchWithinPeriodCheckBox.Checked;
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
        }

        private void exportDetailedFormBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog financialReportSFD = new SaveFileDialog() { FileName = $"التقرير المالي{DateTime.Today.ToString("yyyy-MM-dd")}.xlsx", Filter = "Excel workbook 2007-2022 (*.xlsx)|*.xlsx" };
            if (financialReportSFD.ShowDialog() != DialogResult.OK)
            {
                mainAlertControl.Show(this, "لم يتم حفظ ملف الإكسل", StaticCode.ApplicationTitle);
                return;
            }
            string financialReportXlsx = financialReportSFD.FileName;
            File.Copy(StaticCode.SubLevelTotalsOutPath, financialReportSFD.FileName, true);
            mainAlertControl.Show(this, "تم حفظ ملف الإكسل", StaticCode.ApplicationTitle);
        }

        private void exportStandardFormBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            exportFinancialReportToExcelDropDownButton_Click(sender, e);
        }
    }
}