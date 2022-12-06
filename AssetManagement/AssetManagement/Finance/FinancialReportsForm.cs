using AssetManagement.AuxTables;
using DevExpress.Spreadsheet;
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
        IQueryable<FinancialItemTbl> financialItemsQry = null;
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
                    searchAllRadioButton.Checked = searchAllRadioButton.Enabled = false;
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
                    searchAllRadioButton.Checked = searchAllRadioButton.Enabled = searchBySectionRadioButton.Checked = searchBySectionRadioButton.Enabled = false;
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
            if (!File.Exists(StaticCode.SubLevelTotalsPath))
            {
                mainAlertControl.Show(this, "نموذج إحصائيات المستوى الأدنى غير موجود", StaticCode.ApplicationTitle);
                MessageBox.Show("نموذج إحصائيات المستوى الأدنى غير موجود", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!(searchAllRadioButton.Checked || searchBySectionRadioButton.Checked || searchByDepartmentRadioButton.Checked || searchBySubDepartmentRadioButton.Checked))
            {
                mainAlertControl.Show(this, "اختر البحث حسب أحد المستويات الإدارية أولاً", StaticCode.ApplicationTitle);
                MessageBox.Show("اختر البحث حسب أحد المستويات الإدارية أولاً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (searchBySectionRadioButton.Checked && searchBySectionLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر الدائرة أولاً", StaticCode.ApplicationTitle);
                MessageBox.Show("اختر الدائرة أولاً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (searchByDepartmentRadioButton.Checked && searchByDepartmentLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر القسم أولاً", StaticCode.ApplicationTitle);
                MessageBox.Show("اختر القسم أولاً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (searchBySubDepartmentRadioButton.Checked && searchBySubDepartmentLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر الوحدة أولاً", StaticCode.ApplicationTitle);
                MessageBox.Show("اختر الوحدة أولاً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (searchBySectionRadioButton.Checked)
            {
                levelID = Convert.ToInt32(searchBySectionLookUpEdit.EditValue);
                List<int> dptQry = (from dpt1 in StaticCode.mainDbContext.DepartmentTbls where dpt1.SectionOfDepartment == Convert.ToInt32(searchBySectionLookUpEdit.EditValue) select dpt1.ID).ToList();
                List<int> sdptQry = (from sdep1 in StaticCode.mainDbContext.SubDepartmentTbls where dptQry.Contains(sdep1.MainDepartment) select sdep1.ID).ToList();
                financialItemsQry = from qry in financialItemsQry where sdptQry.Contains(qry.FinancialItemSubDept) select qry;
            }
            if (searchByDepartmentRadioButton.Checked)
            {
                levelID = Convert.ToInt32(searchByDepartmentLookUpEdit.EditValue);
                List<int> sdptQry = (from sdep1 in StaticCode.mainDbContext.SubDepartmentTbls where sdep1.MainDepartment == Convert.ToInt32(searchByDepartmentLookUpEdit.EditValue) select sdep1.ID).ToList();
                financialItemsQry = from qry in financialItemsQry where sdptQry.Contains(qry.FinancialItemSubDept) select qry;
            }
            if (searchBySubDepartmentRadioButton.Checked)
            {
                levelID = Convert.ToInt32(searchBySubDepartmentLookUpEdit.EditValue);
                financialItemsQry = financialItemsQry.Where(fi1 => fi1.FinancialItemSubDept == Convert.ToInt32(searchBySubDepartmentLookUpEdit.EditValue));
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
            if (!resultsFound)
            {
                mainAlertControl.Show(this, "لا يوجد سجلات مالية ضمن اختياراتك", StaticCode.ApplicationTitle);
                MessageBox.Show("لا يوجد سجلات مالية ضمن اختياراتك", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                IWorkbook totalsWorkbook = spreadsheetControl1.Document;
                totalsWorkbook.LoadDocument(StaticCode.SubLevelTotalsPath);

                List<int> IDsIncluded = financialItemsQry.Select(fii1 => fii1.ID).ToList();
                var financialItemsQryVw = StaticCode.mainDbContext.FinancialItemVws.Where(fiv1 => IDsIncluded.Contains(fiv1.معرف_السجل_المالي));
                foreach (FinancialItemVw oneFiVw1 in financialItemsQryVw.Where(fi1 => fi1.وارد_أم_صادر == "وارد"))
                {
                    Application.DoEvents();
                    string subLevelName = "";
                    if (StaticCode.activeUserRole.IsSectionIndependent == true)
                    {
                        subLevelName = oneFiVw1.الدائرة;
                    }
                    else if (StaticCode.activeUserRole.IsDepartmentIndependent == true)
                    {
                        subLevelName = oneFiVw1.القسم;
                    }
                    else
                    {
                        subLevelName = oneFiVw1.الوحدة;
                    }
                }
                foreach (FinancialItemVw oneFiVw2 in financialItemsQryVw.Where(fi1 => fi1.وارد_أم_صادر == "صادر"))
                {
                    Application.DoEvents();
                    string subLevelName = "";
                    if (StaticCode.activeUserRole.IsSectionIndependent == true)
                    {
                        subLevelName = oneFiVw2.الدائرة;
                    }
                    else if (StaticCode.activeUserRole.IsDepartmentIndependent == true)
                    {
                        subLevelName = oneFiVw2.القسم;
                    }
                    else
                    {
                        subLevelName = oneFiVw2.الوحدة;
                    }
                }
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

                DateTime today1 = DateTime.Today.AddDays(StaticCode.appOptions.ShiftDays);
                List<double> totals1 = StaticCode.GetCycledToMonth(financialItemsQry, today1.Year, today1.Month, levelID, levelSelected);
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
                            var levelQry2 = from qry in financialItemsQry where sdptQry.Contains(qry.FinancialItemSubDept) select qry;

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
                            var levelQry3 = financialItemsQry.Where(fi1 => fi1.FinancialItemSubDept == oneItem.ID);

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
            fiRpWs.Cells[2, 1, 2, 2].Value = $"الدائرة: {((searchBySectionRadioButton.Checked) ? searchBySectionLookUpEdit.Text : "الكل")}";
            fiRpWs.Cells[2, 3].Value = $"القسم: {((searchByDepartmentRadioButton.Checked) ? searchByDepartmentLookUpEdit.Text : "الكل")}";
            fiRpWs.Cells[2, 4, 2, 5].Value = $"الوحدة: {((searchBySubDepartmentRadioButton.Checked) ? searchBySubDepartmentLookUpEdit.Text : "الكل")}";
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

            string sectionVal = (StaticCode.activeUserRole.IsSectionIndependent != true) ? $"الدائرة: {StaticCode.mainDbContext.SectionTbls.Single(sct1 => sct1.ID == StaticCode.activeUser.UserSection).SectionName}" : "";
            string departmentVal = (StaticCode.activeUserRole.IsDepartmentIndependent != true) ? $"القسم: {((searchByDepartmentRadioButton.Checked) ? searchByDepartmentLookUpEdit.Text : "الكل")}" : "";
            string subDepartmentVal = (StaticCode.activeUserRole.IsSectionIndependent != true && StaticCode.activeUserRole.IsDepartmentIndependent != true) ? $"الوحدة: {((searchBySubDepartmentRadioButton.Checked) ? searchBySubDepartmentLookUpEdit.Text : "الكل")}" : "";
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
                fiRpWs.Cells[startRow, 4].Value = oneFiRp.IncomingFrom;
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
                fiRpWs.Cells[startRow, 5].Value = oneFiRp.OutgoingType;
                fiRpWs.Cells[startRow, 6].Value = oneFiRp.OutgoingTo;
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