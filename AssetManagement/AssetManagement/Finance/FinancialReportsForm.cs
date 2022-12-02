﻿using AssetManagement.AuxTables;
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

namespace AssetManagement.Finance
{
    public partial class FinancialReportsForm : Form
    {
        IQueryable<FinancialItemTbl> financialItemsFromToQry = null;
        int levelSelected = 0;
        int levelID = 0;

        public FinancialReportsForm()
        {
            InitializeComponent();
        }

        private void FinancialReportsForm_Load(object sender, EventArgs e)
        {
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
                    searchBySectionLookUpEdit.EditValue = StaticCode.activeUser.UserSection;
                    searchBySectionLookUpEdit.Enabled = false;
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
                    searchByDepartmentLookUpEdit.EditValue = StaticCode.activeUser.UserDept;
                    searchBySectionLookUpEdit.Enabled = searchByDepartmentLookUpEdit.Enabled = false;
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchFinancialItemDropDownButton_Click(object sender, EventArgs e)
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
            if (searchWithinPeriodCheckBox.Checked)
            {
                if (fromToRadioButton.Checked)
                {
                    if (fromDateDateEdit.EditValue == null)
                    {
                        MessageBox.Show("اكتب تاريخ البداية", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mainAlertControl.Show(this, "اكتب تاريخ البداية", StaticCode.ApplicationTitle);
                        return;
                    }
                    if (toDateDateEdit.EditValue == null)
                    {
                        MessageBox.Show("اكتب تاريخ النهاية", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mainAlertControl.Show(this, "اكتب تاريخ النهاية", StaticCode.ApplicationTitle);
                        return;
                    }
                    if (Convert.ToDateTime(fromDateDateEdit.EditValue) > Convert.ToDateTime(toDateDateEdit.EditValue))
                    {
                        MessageBox.Show("تاريخ البداية أحدث من تاريخ النهاية", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mainAlertControl.Show(this, "تاريخ البداية أحدث من تاريخ النهاية", StaticCode.ApplicationTitle);
                        return;
                    }
                }
            }
            if (searchByCurrencyCheckBox.Checked && searchByCurrencyLookUpEdit.EditValue == null)
            {
                MessageBox.Show("اختر العملة أولاً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mainAlertControl.Show(this, "اختر العملة أولاً", StaticCode.ApplicationTitle);
                return;
            }

            financialItemsFromToQry = StaticCode.mainDbContext.FinancialItemTbls.Select(fi1 => fi1);
            if (searchBySectionRadioButton.Checked)
            {
                levelID = Convert.ToInt32(searchBySectionLookUpEdit.EditValue);
                List<int> dptQry = (from dpt1 in StaticCode.mainDbContext.DepartmentTbls where dpt1.SectionOfDepartment == Convert.ToInt32(searchBySectionLookUpEdit.EditValue) select dpt1.ID).ToList();
                List<int> sdptQry = (from sdep1 in StaticCode.mainDbContext.SubDepartmentTbls where dptQry.Contains(sdep1.MainDepartment) select sdep1.ID).ToList();
                financialItemsFromToQry = from qry in financialItemsFromToQry where sdptQry.Contains(qry.FinancialItemSubDept) select qry;
            }
            if (searchByDepartmentRadioButton.Checked)
            {
                levelID = Convert.ToInt32(searchByDepartmentLookUpEdit.EditValue);
                List<int> sdptQry = (from sdep1 in StaticCode.mainDbContext.SubDepartmentTbls where sdep1.MainDepartment == Convert.ToInt32(searchByDepartmentLookUpEdit.EditValue) select sdep1.ID).ToList();
                financialItemsFromToQry = from qry in financialItemsFromToQry where sdptQry.Contains(qry.FinancialItemSubDept) select qry;
            }
            if (searchBySubDepartmentRadioButton.Checked)
            {
                levelID = Convert.ToInt32(searchBySubDepartmentLookUpEdit.EditValue);
                financialItemsFromToQry = financialItemsFromToQry.Where(fi1 => fi1.FinancialItemSubDept == Convert.ToInt32(searchBySubDepartmentLookUpEdit.EditValue));
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
                financialItemsFromToQry = financialItemsFromToQry.Where(fi => fi.FinancialItemInsertionDate >= fromDate && fi.FinancialItemInsertionDate <= toDate);
            }
            if (searchByCurrencyCheckBox.Checked)
            {
                financialItemsFromToQry = financialItemsFromToQry.Where(fi => fi.FinancialItemCurrency == Convert.ToInt32(searchByCurrencyLookUpEdit.EditValue));
            }
            bool resultsFound = financialItemsFromToQry != null && financialItemsFromToQry.Count() > 0;
            exportFinancialReportToExcelDropDownButton.Enabled = financialReportTabControl.Visible = resultsFound;
            if (!resultsFound)
            {
                mainAlertControl.Show(this, "لا يوجد سجلات مالية ضمن اختياراتك", StaticCode.ApplicationTitle);
                MessageBox.Show("لا يوجد سجلات مالية ضمن اختياراتك", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                List<int> IDsIncluded = financialItemsFromToQry.Select(fii1 => fii1.ID).ToList();
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

                DateTime today1 = DateTime.Today.AddDays(StaticCode.appOptions.ShiftDays);
                List<double> totals1 = StaticCode.GetCycledToMonth(financialItemsFromToQry, today1.Year, today1.Month, levelID, levelSelected);
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
                            var levelQry1 = from qry in financialItemsFromToQry where sdptQry.Contains(qry.FinancialItemSubDept) select qry;

                            TreeNode oneNode = subLevelTotalsTreeView.Nodes.Add(oneItem.SectionName);
                            List<double> totals2 = StaticCode.GetCycledToMonth(levelQry1, today1.Year, today1.Month, oneItem.ID, 1);
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
                            var levelQry2 = from qry in financialItemsFromToQry where sdptQry.Contains(qry.FinancialItemSubDept) select qry;

                            TreeNode oneNode = subLevelTotalsTreeView.Nodes.Add(oneItem.DepartmentName);
                            List<double> totals2 = StaticCode.GetCycledToMonth(levelQry2, today1.Year, today1.Month, oneItem.ID, 2);
                            oneNode.Nodes.Add($"الوارد: {totals2[0]}");
                            oneNode.Nodes.Add($"الصادر: {totals2[1]}");
                            oneNode.Nodes.Add($"المدور: {totals2[2]}");
                        }
                        break;
                    case 2:
                        var subLevelQuery3 = StaticCode.mainDbContext.SubDepartmentTbls.Where(sdpt1 => sdpt1.MainDepartment == Convert.ToInt32(searchByDepartmentLookUpEdit.EditValue));
                        foreach (SubDepartmentTbl oneItem in subLevelQuery3)
                        {
                            Application.DoEvents();
                            var levelQry3 = financialItemsFromToQry.Where(fi1 => fi1.FinancialItemSubDept == oneItem.ID);

                            TreeNode oneNode = subLevelTotalsTreeView.Nodes.Add(oneItem.SubDepartmentName);
                            List<double> totals2 = StaticCode.GetCycledToMonth(levelQry3, today1.Year, today1.Month, oneItem.ID, 3);
                            oneNode.Nodes.Add($"الوارد: {totals2[0]}");
                            oneNode.Nodes.Add($"الصادر: {totals2[1]}");
                            oneNode.Nodes.Add($"المدور: {totals2[2]}");
                        }
                        break;
                    default:
                        break;
                }
                subLevelTotalsTreeView.ExpandAll();
            }
        }

        private void exportFinancialReportToExcelDropDownButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog financialReportSFD = new SaveFileDialog() { Filter = "Excel workbook 2007-2022 (*.xlsx)|*.xlsx" };
            if (financialReportSFD.ShowDialog() != DialogResult.OK)
            {
                mainAlertControl.Show(this, "تم الإلغاء", StaticCode.ApplicationTitle);
                return;
            }
            string targetPath = financialReportSFD.FileName;
            if (!File.Exists(StaticCode.FinancialReportPath))
            {
                mainAlertControl.Show(this, "فورم التقرير المالي غير موجود", StaticCode.ApplicationTitle);
                MessageBox.Show("فورم التقرير المالي غير موجود", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            File.Copy(StaticCode.FinancialReportPath, targetPath, true);
            ExcelPackage fiRpEp = new ExcelPackage(new FileInfo(targetPath));
            ExcelWorkbook fiRpWb = fiRpEp.Workbook;
            ExcelWorksheet fiRpWs = fiRpWb.Worksheets.First();
            fiRpWs.Cells[2, 1, 2, 2].Value = $"الدائرة: {((searchBySectionRadioButton.Checked) ? searchBySectionLookUpEdit.Text : "الكل")}";
            fiRpWs.Cells[2, 3].Value = $"القسم: {((searchByDepartmentRadioButton.Checked) ? searchByDepartmentLookUpEdit.Text : "الكل")}";
            fiRpWs.Cells[2, 4, 2, 5].Value = $"الوحدة: {((searchBySubDepartmentRadioButton.Checked) ? searchBySubDepartmentLookUpEdit.Text : "الكل")}";
            int startRow = 5;
            foreach (FinancialItemTbl oneFiRp in financialItemsFromToQry.Where(fic1 => fic1.IncomingOrOutgoing == "وارد"))
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
            foreach (FinancialItemTbl oneFiRp in financialItemsFromToQry.Where(fic1 => fic1.IncomingOrOutgoing == "صادر"))
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

        private void SelectReportDuration(object sender, EventArgs e)
        {
            fromToPanel.Visible = fromToRadioButton.Checked;
            monthlyDateTimePicker.Visible = monthlyRadioButton.Checked;
            annualDateTimePicker.Visible = annualRadioButton.Checked;
        }

        private void searchInDeptRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchBySectionLookUpEdit.Visible = searchBySectionRadioButton.Checked;
            searchByDepartmentLookUpEdit.Visible = searchByDepartmentRadioButton.Checked;
            searchBySubDepartmentLookUpEdit.Visible = searchBySubDepartmentRadioButton.Checked;
            manageSectionTblBtn.Visible = searchBySectionRadioButton.Checked && StaticCode.activeUserRole.ManageSections == true;
            manageDepartmentTblBtn.Visible = searchByDepartmentRadioButton.Checked && StaticCode.activeUserRole.ManageDepartments == true;
            manageSubDepartmentTblBtn.Visible = searchBySubDepartmentRadioButton.Checked && StaticCode.activeUserRole.ManageSubDepartments == true;
            if (searchAllRadioButton.Checked)
            {
                levelSelected = 0;
                levelID = 0;
            }
            if (searchBySectionRadioButton.Checked)
            {
                levelSelected = 1;
            }
            if (searchByDepartmentRadioButton.Checked)
            {
                levelSelected = 2;
                levelID = 0;
            }
            if (searchBySubDepartmentRadioButton.Checked)
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
    }
}