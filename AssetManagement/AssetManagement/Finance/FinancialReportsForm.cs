﻿using AssetManagement.AuxTables;
using DevExpress.Spreadsheet;
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
            #region Set and apply the financial items query
            if (!(searchAllRadioButton.Checked || searchBySectionCheckBox.Checked || searchByDepartmentCheckBox.Checked || searchBySubDepartmentCheckBox.Checked))
            {
                mainAlertControl.Show(this, "اختر البحث حسب أحد المستويات الإدارية أولاً", StaticCode.ApplicationTitle);
                MessageBox.Show("اختر البحث حسب أحد المستويات الإدارية أولاً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        return;
                    }
                    if (toDateDateEdit.EditValue == null)
                    {
                        mainAlertControl.Show(this, "اكتب تاريخ النهاية", StaticCode.ApplicationTitle);
                        MessageBox.Show("اكتب تاريخ النهاية", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Convert.ToDateTime(fromDateDateEdit.EditValue) > Convert.ToDateTime(toDateDateEdit.EditValue))
                    {
                        mainAlertControl.Show(this, "تاريخ البداية أحدث من تاريخ النهاية", StaticCode.ApplicationTitle);
                        MessageBox.Show("تاريخ البداية أحدث من تاريخ النهاية", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            if (searchByCurrencyCheckBox.Checked && searchByCurrencyLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر العملة أولاً", StaticCode.ApplicationTitle);
                MessageBox.Show("اختر العملة أولاً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            financialItemsQry = StaticCode.mainDbContext.FinancialItemTbls.Select(fi1 => fi1);
            if (searchBySectionCheckBox.Checked)
            {
                if (searchBySectionLookUpEdit.EditValue == null)
                {
                    mainAlertControl.Show(this, "حدد الدائرة أولاً", StaticCode.ApplicationTitle);
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
                        return;
                    }
                }
                this.financialItemVwTableAdapter.FillByQuery(customVw, plusQry);

                #region Prepare the totals of each sub-level
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

                #region Prepare the excel details of each sub-level
                SaveFileDialog financialReportSFD = new SaveFileDialog() { FileName = $"التقرير المالي{DateTime.Today.ToString("yyyy-MM-dd")}.xlsx", Filter = "Excel workbook 2007-2022 (*.xlsx)|*.xlsx" };
                if (financialReportSFD.ShowDialog() != DialogResult.OK)
                {
                    mainAlertControl.Show(this, "لم يتم حفظ ملف الإكسل", StaticCode.ApplicationTitle);
                    return;
                }
                string financialReportXlsx = financialReportSFD.FileName;
                if (File.Exists(financialReportXlsx))
                    File.Delete(financialReportXlsx);
                ExcelPackage financialReport_SubLevelsEp = new ExcelPackage(new FileInfo(financialReportXlsx));
                ExcelWorkbook financialReport_SubLevelsWb = financialReport_SubLevelsEp.Workbook;

                #region General financial report
                string sheet_Title_Name1 = "السجل المالي العام للدوائر";
                int fiSubLevel = 0;
                if (StaticCode.activeUserRole.IsSectionIndependent == true)
                {
                    sheet_Title_Name1 = "السجل المالي العام للدوائر";
                    fiSubLevel = 1;
                }
                else if (StaticCode.activeUserRole.IsDepartmentIndependent == true)
                {
                    sheet_Title_Name1 = "السجل المالي العام للأقسام";
                    fiSubLevel = 2;
                }
                else
                {
                    sheet_Title_Name1 = "السجل المالي العام للوحدات";
                    fiSubLevel = 3;
                }
                ExcelWorksheet generalFinancialReportWs = financialReport_SubLevelsWb.Worksheets.Add(sheet_Title_Name1);
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
                        List<string> subLevelList1 = financialItemsQryVw.Select(fiv1 => fiv1.الدائرة).Distinct().ToList();
                        foreach (string oneItem in subLevelList1)
                        {
                            Application.DoEvents();
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
                                cells.Value = oneItem;
                            }
                            startRow += 2;

                            #region Incoming of sub-level
                            var financialItemsQryVw_SubLevel = financialItemsQryVw.Where(fivsl => fivsl.الدائرة == oneItem);
                            var incomingSubLevelQry = financialItemsQryVw_SubLevel.Where(fiv2 => fiv2.وارد_أم_صادر == "وارد").OrderByDescending(fiv22 => fiv22.جهة_الإيراد);
                            double totalIncomingSubLevel = (incomingSubLevelQry.Any()) ? incomingSubLevelQry.Sum(fiv3 => fiv3.المبلغ_الوارد) : 0;

                            int incomingRow = startRow;
                            using (var cells = generalFinancialReportWs.Cells[incomingRow, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "إيرادات";
                            }
                            using (var cells = generalFinancialReportWs.Cells[incomingRow, 3])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "جهة الإيراد";
                            }
                            incomingRow++;
                            foreach (var oneSubItem in incomingSubLevelQry)
                            {
                                using (var cells = generalFinancialReportWs.Cells[incomingRow, 2])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                    cells.Value = oneSubItem.المبلغ_الوارد;
                                }
                                using (var cells = generalFinancialReportWs.Cells[incomingRow, 3])
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
                                incomingRow++;
                            }
                            using (var cells = generalFinancialReportWs.Cells[incomingRow, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                                cells.Value = totalIncomingSubLevel;
                            }
                            using (var cells = generalFinancialReportWs.Cells[incomingRow, 3])
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
                            incomingRow++;
                            #endregion

                            #region Outgoing of sub-level
                            var outgoingSubLevelQry = financialItemsQryVw_SubLevel.Where(fiv2 => fiv2.وارد_أم_صادر == "صادر").OrderByDescending(fiv22 => fiv22.نوع_الصادر);
                            double totalOutgoingSubLevel = (outgoingSubLevelQry.Any()) ? outgoingSubLevelQry.Sum(fiv3 => fiv3.المبلغ_الصادر) : 0;

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
                            foreach (var oneSubItem in outgoingSubLevelQry)
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
                                cells.Value = totalOutgoingSubLevel;
                            }
                            using (var cells = generalFinancialReportWs.Cells[outgoingRow, 6, outgoingRow, 7])
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
                            outgoingRow++;
                            #endregion

                            #region Recycled of sub-level
                            startRow = Math.Max(incomingRow, outgoingRow) + 1;
                            using (var cells = generalFinancialReportWs.Cells[startRow, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                cells.Value = financialItemsQryVw_SubLevel.CalcRecycledOfFinancialItems();
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
                        }
                        break;
                    case 2:
                        List<string> subLevelList2 = financialItemsQryVw.Select(fiv2 => fiv2.القسم).Distinct().ToList();
                        foreach (string oneItem2 in subLevelList2)
                        {
                            Application.DoEvents();
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
                                cells.Value = oneItem2;
                            }
                            startRow += 2;

                            #region Incoming of sub-level
                            var financialItemsQryVw_SubLevel = financialItemsQryVw.Where(fivsl2 => fivsl2.القسم == oneItem2);
                            var incomingSubLevelQry = financialItemsQryVw_SubLevel.Where(fiv2 => fiv2.وارد_أم_صادر == "وارد" && fiv2.القسم == oneItem2).OrderByDescending(fiv22 => fiv22.جهة_الإيراد);
                            double totalIncomingSubLevel = (incomingSubLevelQry.Any()) ? incomingSubLevelQry.Sum(fiv3 => fiv3.المبلغ_الوارد) : 0;

                            int incomingRow = startRow;
                            using (var cells = generalFinancialReportWs.Cells[incomingRow, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "إيرادات";
                            }
                            using (var cells = generalFinancialReportWs.Cells[incomingRow, 3])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "جهة الإيراد";
                            }
                            incomingRow++;
                            foreach (var oneSubItem in incomingSubLevelQry)
                            {
                                using (var cells = generalFinancialReportWs.Cells[incomingRow, 2])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                    cells.Value = oneSubItem.المبلغ_الوارد;
                                }
                                using (var cells = generalFinancialReportWs.Cells[incomingRow, 3])
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
                                incomingRow++;
                            }
                            using (var cells = generalFinancialReportWs.Cells[incomingRow, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                                cells.Value = totalIncomingSubLevel;
                            }
                            using (var cells = generalFinancialReportWs.Cells[incomingRow, 3])
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
                            incomingRow++;
                            #endregion

                            #region Outgoing of sub-level
                            var outgoingSubLevelQry = financialItemsQryVw_SubLevel.Where(fiv2 => fiv2.وارد_أم_صادر == "صادر" && fiv2.القسم == oneItem2).OrderByDescending(fiv22 => fiv22.نوع_الصادر);
                            double totalOutgoingSubLevel = (outgoingSubLevelQry.Any()) ? outgoingSubLevelQry.Sum(fiv3 => fiv3.المبلغ_الصادر) : 0;

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
                            foreach (var oneSubItem in outgoingSubLevelQry)
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
                                cells.Value = totalOutgoingSubLevel;
                            }
                            using (var cells = generalFinancialReportWs.Cells[outgoingRow, 6, outgoingRow, 7])
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
                            outgoingRow++;
                            #endregion

                            #region Recycled of sub-level
                            startRow = Math.Max(incomingRow, outgoingRow) + 1;
                            using (var cells = generalFinancialReportWs.Cells[startRow, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                cells.Value = financialItemsQryVw_SubLevel.CalcRecycledOfFinancialItems();
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
                        }
                        break;
                    case 3:
                        List<string> subLevelList3 = financialItemsQryVw.Select(fiv3 => fiv3.الوحدة).Distinct().ToList();
                        foreach (string oneItem3 in subLevelList3)
                        {
                            Application.DoEvents();
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
                                cells.Value = oneItem3;
                            }
                            startRow += 2;

                            #region Incoming of sub-level
                            var financialItemsQryVw_SubLevel = financialItemsQryVw.Where(fivsl3 => fivsl3.القسم == oneItem3);
                            var incomingSubLevelQry = financialItemsQryVw.Where(fiv2 => fiv2.وارد_أم_صادر == "وارد" && fiv2.الوحدة == oneItem3).OrderByDescending(fiv22 => fiv22.جهة_الإيراد);
                            double totalIncomingSubLevel = (incomingSubLevelQry.Any()) ? incomingSubLevelQry.Sum(fiv3 => fiv3.المبلغ_الوارد) : 0;

                            int incomingRow = startRow;
                            using (var cells = generalFinancialReportWs.Cells[incomingRow, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "إيرادات";
                            }
                            using (var cells = generalFinancialReportWs.Cells[incomingRow, 3])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "جهة الإيراد";
                            }
                            incomingRow++;
                            foreach (var oneSubItem in incomingSubLevelQry)
                            {
                                using (var cells = generalFinancialReportWs.Cells[incomingRow, 2])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                    cells.Value = oneSubItem.المبلغ_الوارد;
                                }
                                using (var cells = generalFinancialReportWs.Cells[incomingRow, 3])
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
                                incomingRow++;
                            }
                            using (var cells = generalFinancialReportWs.Cells[incomingRow, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                                cells.Value = totalIncomingSubLevel;
                            }
                            using (var cells = generalFinancialReportWs.Cells[incomingRow, 3])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                cells.Value = "مجموع إيرادات الوحدة";
                            }
                            incomingRow++;
                            #endregion

                            #region Outgoing of sub-level
                            var outgoingSubLevelQry = financialItemsQryVw_SubLevel.Where(fiv2 => fiv2.وارد_أم_صادر == "صادر" && fiv2.الوحدة == oneItem3).OrderByDescending(fiv22 => fiv22.نوع_الصادر);
                            double totalOutgoingSubLevel = (outgoingSubLevelQry.Any()) ? outgoingSubLevelQry.Sum(fiv3 => fiv3.المبلغ_الصادر) : 0;

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
                            foreach (var oneSubItem in outgoingSubLevelQry)
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
                                cells.Value = totalOutgoingSubLevel;
                            }
                            using (var cells = generalFinancialReportWs.Cells[outgoingRow, 6, outgoingRow, 7])
                            {
                                cells.Value = "مجموع (الصادرات المباشرة والمعلقة) للوحدة";
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
                            startRow = Math.Max(incomingRow, outgoingRow) + 1;
                            using (var cells = generalFinancialReportWs.Cells[startRow, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Dotted);
                                cells.Value = financialItemsQryVw_SubLevel.CalcRecycledOfFinancialItems();
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
                        }
                        break;
                    default:
                        break;
                }
                #endregion

                #region Detailed fincnaial report
                string sheet_Title_Name2 = sheet_Title_Name1.Replace("العام", "التفصيلي");
                ExcelWorksheet detailedFinancialReportWs = financialReport_SubLevelsWb.Worksheets.Add(sheet_Title_Name2);
                detailedFinancialReportWs.View.ShowGridLines = false;
                detailedFinancialReportWs.View.RightToLeft = true;
                detailedFinancialReportWs.View.ZoomScale = 70;
                detailedFinancialReportWs.Column(2).Width = 15;
                detailedFinancialReportWs.Column(3).Width = 18;
                detailedFinancialReportWs.Column(4).Width = 34;
                detailedFinancialReportWs.Column(5).Width = 38;
                detailedFinancialReportWs.Column(6).Width = 47;
                detailedFinancialReportWs.Column(8).Width = 20;
                detailedFinancialReportWs.Column(9).Width = 20;
                detailedFinancialReportWs.Column(10).Width = 35;
                detailedFinancialReportWs.Column(11).Width = 20;
                detailedFinancialReportWs.Column(12).Width = 15;
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
                    cells.Value = sheet_Title_Name1;
                }
                startRow = 6;
                switch (fiSubLevel)
                {
                    case 1:
                        List<string> subLevelList1 = financialItemsQryVw.Select(fiv1 => fiv1.الدائرة).Distinct().ToList();
                        foreach (string oneItem in subLevelList1)
                        {
                            Application.DoEvents();
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
                                cells.Value = oneItem;
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
                            var financialItemsQryVw_OneItem = financialItemsQryVw.Where(fi1v => fi1v.الدائرة == oneItem);
                            var incomingSubLevelQry = financialItemsQryVw_OneItem.Where(fiv2 => fiv2.وارد_أم_صادر == "وارد").OrderByDescending(fiv22 => fiv22.جهة_الإيراد);
                            double totalIncomingSubLevel = (incomingSubLevelQry.Any()) ? incomingSubLevelQry.Sum(fiv3 => fiv3.المبلغ_الوارد) : 0;
                            var outgoingSubLevelQry = financialItemsQryVw_OneItem.Where(fiv2 => fiv2.وارد_أم_صادر == "صادر").OrderByDescending(fiv22 => fiv22.نوع_الصادر);
                            double totalOutgoingSubLevel = (outgoingSubLevelQry.Any()) ? outgoingSubLevelQry.Sum(fiv3 => fiv3.المبلغ_الصادر) : 0;
                            var outgoingSubLevelQry_Direct = outgoingSubLevelQry.Where(oufv => oufv.نوع_الصادر == "صادرات مباشرة");
                            double totalRecycledSubLevel = financialItemsQryVw_OneItem.CalcRecycledOfFinancialItems();
                            var financialItemsQryVw_OneItem_Head = financialItemsQryVw_OneItem.Where(fvh => fvh.القسم == "إدارة " + oneItem);
                            double totalRecycledSubLevel_Head = financialItemsQryVw_OneItem_Head.CalcRecycledOfFinancialItems();

                            int figuresRow = startRow;
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(169, 208, 142));
                                cells.Value = totalIncomingSubLevel;
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow, 3])
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
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow, 5])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(248, 230, 173));
                                cells.Value = totalOutgoingSubLevel;
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow, 6])
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
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow + 2, 2])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(226, 239, 218));
                                cells.Value = totalRecycledSubLevel_Head;
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow + 2, 3])
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
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow + 2, 5])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                                cells.Value = (outgoingSubLevelQry_Direct.Any()) ? outgoingSubLevelQry_Direct.Sum(fvo1 => fvo1.المبلغ_الصادر) : 0;
                            }
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow + 2, 6])
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
                            figuresRow += 5;
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow, 2, figuresRow, 6])
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
                            figuresRow++;
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow, 2, figuresRow, 6])
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
                                cells.Value = totalRecycledSubLevel;
                            }
                            figuresRow += 3;
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
                                cells.Value = "تفصيل المدور الكلي للدائرة وتفرعاتها";
                            }
                            figuresRow++;
                            int allRecycledRow = figuresRow;
                            List<string> depts = financialItemsQryVw_OneItem.Select(fvi1 => fvi1.القسم).Distinct().ToList();
                            using (var cells = detailedFinancialReportWs.Cells[allRecycledRow, 2, allRecycledRow + depts.Count() - 1, 4])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                            }
                            using (var cells = detailedFinancialReportWs.Cells[allRecycledRow, 5, allRecycledRow + depts.Count() - 1, 5])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 14.0F;
                                cells.Merge = true;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = "المجموع";
                            }
                            using (var cells = detailedFinancialReportWs.Cells[allRecycledRow, 6, allRecycledRow + depts.Count() - 1, 6])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 14.0F;
                                cells.Merge = true;
                                cells.Style.Font.Bold = true;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Value = financialItemsQryVw_OneItem.CalcRecycledOfFinancialItems();
                            }
                            foreach (string oneDpt in depts)
                            {
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
                                    cells.Value = ("مدور بيد رئيس قسم " + oneDpt).Replace("رئيس قسم إدارة" + oneItem, "رئيس الدائرة");
                                }
                                using (var cells = detailedFinancialReportWs.Cells[allRecycledRow, 4])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    cells.Value = financialItemsQryVw_OneItem.Where(fvd1 => fvd1.القسم == oneDpt).CalcRecycledOfFinancialItems();
                                }
                                allRecycledRow++;
                            }
                            figuresRow = allRecycledRow + 3;
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow, 2, figuresRow, 6])
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
                            figuresRow++;
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow, 2])
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
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow, 3])
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
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow, 4])
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
                            using (var cells = detailedFinancialReportWs.Cells[figuresRow, 5])
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
                            figuresRow++;
                            foreach (string oneDpt in depts)
                            {
                                Application.DoEvents();
                                using (var cells = detailedFinancialReportWs.Cells[figuresRow, 2])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.Font.Bold = true;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    cells.Value = oneDpt.Replace("إدارة" + oneItem, "رئيس الدائرة");
                                }
                                using (var cells = detailedFinancialReportWs.Cells[figuresRow, 3])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    cells.Value = financialItemsQryVw_OneItem.Where(fvd1 => fvd1.القسم == oneDpt).CalcIncomingOfFinancialItems();
                                }
                                using (var cells = detailedFinancialReportWs.Cells[figuresRow, 4])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    cells.Value = financialItemsQryVw_OneItem.Where(fvd1 => fvd1.القسم == oneDpt).CalcOutgoingOfFinancialItems();
                                }
                                using (var cells = detailedFinancialReportWs.Cells[figuresRow, 5])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    cells.Value = financialItemsQryVw_OneItem.Where(fvd1 => fvd1.القسم == oneDpt).CalcRecycledOfFinancialItems();
                                }
                                figuresRow++;
                            }
                            figuresRow += 3;
                            #endregion

                            #region Direct outgoing of sub-level in detail
                            int tableRow = startRow;
                            using (var cells = detailedFinancialReportWs.Cells[tableRow, 9, tableRow, 14])
                            {
                                cells.Style.Font.Name = "Calibri";
                                cells.Style.Font.Size = 11.0F;
                                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(208, 206, 206));
                            }
                            detailedFinancialReportWs.Cells[tableRow, 9].Value = "اسم البند المالي";
                            detailedFinancialReportWs.Cells[tableRow, 10].Value = "بيان السجل المالي";
                            detailedFinancialReportWs.Cells[tableRow, 11].Value = "الدائرة";
                            detailedFinancialReportWs.Cells[tableRow, 12].Value = "تاريخ السجل";
                            detailedFinancialReportWs.Cells[tableRow, 13].Value = "";
                            detailedFinancialReportWs.Cells[tableRow, 14].Value = "";
                            if (outgoingSubLevelQry_Direct.Any())
                            {
                                using (var cells = detailedFinancialReportWs.Cells[tableRow + 1, 9, tableRow + outgoingSubLevelQry_Direct.Count(), 14])
                                {
                                    cells.Style.Font.Name = "Calibri";
                                    cells.Style.Font.Size = 11.0F;
                                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    cells.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                }
                                tableRow++;
                                foreach (var oneRec in outgoingSubLevelQry_Direct)
                                {
                                    detailedFinancialReportWs.Cells[tableRow, 9].Value = oneRec.اسم_البند_المالي;
                                    detailedFinancialReportWs.Cells[tableRow, 10].Value = oneRec.بيان_السجل_المالي;
                                    detailedFinancialReportWs.Cells[tableRow, 11].Value = oneRec.الدائرة;
                                    detailedFinancialReportWs.Cells[tableRow, 12].Value = oneRec.تاريخ_تحرير_السجل.ToString("d");
                                    detailedFinancialReportWs.Cells[tableRow, 13].Value = "";
                                    detailedFinancialReportWs.Cells[tableRow, 14].Value = "";
                                    tableRow++;
                                }
                            }
                            #endregion

                            startRow = Math.Max(figuresRow, tableRow) + 6;
                        }
                        break;
                    default:
                        break;
                }
                #endregion

                financialReport_SubLevelsEp.Save();
                mainAlertControl.Show(this, StaticCode.ApplicationTitle, "تم الحفظ");
                Process.Start(financialReportXlsx);
                #endregion

                #region Load the excel file to the form
                IWorkbook totalsWorkbook = spreadsheetControl1.Document;
                totalsWorkbook.LoadDocument(financialReportXlsx);
                spreadsheetControl1.ActiveWorksheet.ActiveView.ShowRightToLeft = true;
                #endregion
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
            int curRowStart = 96;
            int curRowStart2 = 3;
            int curColStart = 12;
            foreach (FinancialItemCategoryTbl oneFiCa in StaticCode.mainDbContext.FinancialItemCategoryTbls)
            {
                listsWs.Cells[ficaRowStart, 3].Value = oneFiCa.FinancialItemCategoryName;
                listsWs.Cells[ficaRowStart, 4].Value = oneFiCa.FinancialItemCategoryDetails;
                ficaRowStart++;
            }
            foreach (CurrencyTbl oneCu in StaticCode.mainDbContext.CurrencyTbls)
            {
                fiRpWs.Cells[curRowStart, 1].Value =
                listsWs.Cells[curRowStart2, 9].Value =
                fiRpWs.Cells[4, curColStart].Value =
                fiRpWs.Cells[14, curColStart].Value =
                fiRpWs.Cells[60, curColStart].Value =
                fiRpWs.Cells[68, curColStart].Value =
                fiRpWs.Cells[81, curColStart].Value =
                fiRpWs.Cells[88, curColStart].Value = oneCu.CurrencyName;
                curRowStart++;
                curRowStart2++;
                curColStart++;
            }
            for (int iCol = 19; iCol >= curColStart; iCol--)
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
            fiRpWs.Cells[2, 1, 2, 3].Value = sectionVal;
            fiRpWs.Cells[2, 4, 2, 6].Value = departmentVal;
            fiRpWs.Cells[2, 7].Value = subDepartmentVal;
            fiRpWs.Cells[2, 8, 2, 9].Value = $"التاريخ: {DateTime.Today.ToString("yyyy-MM-dd")}";
            int startRow = 5;
            foreach (FinancialItemTbl oneFiRp in financialItemsQry.Where(fic1 => fic1.IncomingOrOutgoing == "وارد"))
            {
                Application.DoEvents();
                fiRpWs.Cells[startRow, 1].Value = oneFiRp.IncomingAmount;
                fiRpWs.Cells[startRow, 3].Value = StaticCode.mainDbContext.CurrencyTbls.Single(cu1 => cu1.ID == oneFiRp.FinancialItemCurrency).CurrencyName;
                fiRpWs.Cells[startRow, 4].Value = oneFiRp.IncomingFrom?.Trim();
                fiRpWs.Cells[startRow, 7].Value = oneFiRp.FinancialItemDescription;
                fiRpWs.Cells[startRow, 8].Value = oneFiRp.FinancialItemInsertionDate.ToShortDateString();
                fiRpWs.Cells[startRow, 9].Value = StaticCode.mainDbContext.FinancialItemCategoryTbls.Single(fic1 => fic1.ID == oneFiRp.FinancialItemCategory).FinancialItemCategoryName;
                startRow++;
            }
            using (var cells = fiRpWs.Cells[startRow, 1, startRow, 9])
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
                fiRpWs.Cells[startRow, 3].Value = StaticCode.mainDbContext.CurrencyTbls.Single(cu1 => cu1.ID == oneFiRp.FinancialItemCurrency).CurrencyName;
                fiRpWs.Cells[startRow, 5].Value = oneFiRp.OutgoingType?.Trim();
                fiRpWs.Cells[startRow, 6].Value = oneFiRp.OutgoingTo?.Trim();
                fiRpWs.Cells[startRow, 7].Value = oneFiRp.FinancialItemDescription;
                fiRpWs.Cells[startRow, 8].Value = oneFiRp.FinancialItemInsertionDate.ToShortDateString();
                fiRpWs.Cells[startRow, 9].Value = StaticCode.mainDbContext.FinancialItemCategoryTbls.Single(fic1 => fic1.ID == oneFiRp.FinancialItemCategory).FinancialItemCategoryName;
                startRow++;
            }
            List<string> mainCategoriesNames = StaticCode.mainDbContext.MainCategoryTbls.Select(maca1 => maca1.MainCategoryName).ToList();
            int macaStartRow = 70;
            int macaStartCol = 11;
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

        private void searchBySubDepartmentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (searchBySubDepartmentCheckBox.Checked)
                searchAllRadioButton.Checked = false;
            searchBySubDepartmentSearchLookUpEdit.Visible = searchBySubDepartmentCheckBox.Checked;
        }
    }
}