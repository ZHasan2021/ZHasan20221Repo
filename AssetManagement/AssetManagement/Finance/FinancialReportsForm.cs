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

namespace AssetManagement.Finance
{
    public partial class FinancialReportsForm : Form
    {
        IQueryable<FinancialItemTbl> financialItemsFromToQry = null;

        public FinancialReportsForm()
        {
            InitializeComponent();
        }

        private void FinancialReportsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.CurrencyTbl' table. You can move, or remove it, as needed.
            this.currencyTblTableAdapter.Fill(this.assetMngDbDataSet.CurrencyTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.FinancialItemCategoryTbl' table. You can move, or remove it, as needed.
            this.financialItemCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemCategoryTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.FinancialItemTbl' table. You can move, or remove it, as needed.
            this.financialItemTblTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemTbl);
            this.MinimumSize = this.Size;
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
        }

        private void searchFinancialItemDropDownButton_Click(object sender, EventArgs e)
        {
            if (fromDateDateEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اكتب تاريخ البداية", StaticCode.ApplicationTitle);
                return;
            }
            if (toDateDateEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اكتب تاريخ النهاية", StaticCode.ApplicationTitle);
                return;
            }
            if (Convert.ToDateTime(fromDateDateEdit.EditValue) > Convert.ToDateTime(toDateDateEdit.EditValue))
            {
                mainAlertControl.Show(this, "تاريخ البداية أحدث من تاريخ النهاية", StaticCode.ApplicationTitle);
                return;
            }

            financialItemsFromToQry = StaticCode.mainDbContext.FinancialItemTbls.Where(fi => fi.FinancialItemInsertionDate >= Convert.ToDateTime(fromDateDateEdit.EditValue) && fi.FinancialItemInsertionDate <= Convert.ToDateTime(toDateDateEdit.EditValue));
            financialItemGridControl.DataSource = financialItemsFromToQry;
            exportFinancialReportToExcelDropDownButton.Enabled = financialItemGridControl.Visible = financialItemsFromToQry.Count() > 0;
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
                return;
            }
            File.Copy(StaticCode.FinancialReportPath, targetPath, true);
            ExcelPackage fiRpEp = new ExcelPackage(new FileInfo(targetPath));
            ExcelWorkbook fiRpWb = fiRpEp.Workbook;
            ExcelWorksheet fiRpWs = fiRpWb.Worksheets.First();
            int startRow = 5;
            foreach (FinancialItemTbl oneFiRp in financialItemsFromToQry.Where(fic1 => fic1.IncomingOrOutgoing == 1))
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
            foreach (FinancialItemTbl oneFiRp in financialItemsFromToQry.Where(fic1 => fic1.IncomingOrOutgoing == 2))
            {
                Application.DoEvents();
                fiRpWs.Cells[startRow, 2].Value = oneFiRp.OutgoingAmount;
                fiRpWs.Cells[startRow, 3].Value = oneFiRp.FinancialItemDescription;
                fiRpWs.Cells[startRow, 4].Value = oneFiRp.FinancialItemInsertionDate.ToShortDateString();
                fiRpWs.Cells[startRow, 5].Value = StaticCode.mainDbContext.FinancialItemCategoryTbls.Single(fic1 => fic1.ID == oneFiRp.FinancialItemCategory).FinancialItemCategoryName;
                startRow++;
            }
            List<string> mainCategoriesNames = StaticCode.mainDbContext.MainCategoryTbls.Select(maca1 => maca1.MainCategoryName).ToList();
            int macaStartRow = 12;
            foreach (string oneMaCa in mainCategoriesNames)
            {
                fiRpWs.Cells[macaStartRow, 7].Value = oneMaCa;
                macaStartRow++;
            }
            fiRpEp.Save();
            mainAlertControl.Show(this, "تم التصدير بنجاح", StaticCode.ApplicationTitle);
        }
    }
}