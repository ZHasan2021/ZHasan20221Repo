using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.Assets
{
    public partial class NewAssetInventoryForm : Form
    {
        IQueryable<AssetTbl> assetsQry = null;
        public NewAssetInventoryForm()
        {
            InitializeComponent();
        }

        private void NewAssetInventoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetTbl' table. You can move, or remove it, as needed.
            this.assetTblTableAdapter.Fill(this.assetMngDbDataSet.AssetTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.StatusTbl' table. You can move, or remove it, as needed.
            this.statusTblTableAdapter.Fill(this.assetMngDbDataSet.StatusTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.MinorCategoryTbl' table. You can move, or remove it, as needed.
            this.minorCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MinorCategoryTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.MainCategoryTbl' table. You can move, or remove it, as needed.
            this.mainCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MainCategoryTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SquareTbl' table. You can move, or remove it, as needed.
            this.squareTblTableAdapter.Fill(this.assetMngDbDataSet.SquareTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SectionTbl' table. You can move, or remove it, as needed.
            this.sectionTblTableAdapter.Fill(this.assetMngDbDataSet.SectionTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.DepartmentTbl' table. You can move, or remove it, as needed.
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
            this.MinimumSize = this.Size;
        }

        private void searchAllRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            customSearchGroupBox.Visible = customSearchRadioButton.Checked;
        }

        private void searchByDepartmentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchByDepartmentLookUpEdit.Visible = searchByDepartmentCheckBox.Checked;
        }

        private void searchBySectionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchBySectionLookUpEdit.Visible = searchBySectionCheckBox.Checked;
        }

        private void searchBySquareCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchBySquareLookUpEdit.Visible = searchBySquareCheckBox.Checked;
        }

        private void searchByMainCategoryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchByMainCategoryLookUpEdit.Visible = searchByMainCategoryCheckBox.Checked;
        }

        private void searchByMinorCategoryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchByMinorCategoryLookUpEdit.Visible = searchByMinorCategoryCheckBox.Checked;
        }

        private void searchByAssetCodeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchByAssetCodeTextBox.Visible = searchByAssetCodeCheckBox.Checked;
        }

        private void searchByCustodianNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchByCustodianNameTextBox.Visible = searchByCustodianNameCheckBox.Checked;
        }

        private void searchByAssetDescriptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchByAssetDescriptionTextBox.Visible = searchByAssetDescriptionCheckBox.Checked;
        }

        private void searchByPurchaseDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchByPurchaseDatePanel.Visible = searchByPurchaseDateCheckBox.Checked;
        }

        private void searchByStatusCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchByStatusLookUpEdit.Visible = searchByStatusCheckBox.Checked;
        }

        private void searchByInsertionDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchByInsertionDatePanel.Visible = searchByInsertionDateCheckBox.Checked;
        }

        private void searchAssetDropDownButton_Click(object sender, EventArgs e)
        {
            assetGridControl.Visible = false;
            exportToExcelDropDownButton.Enabled = false;
            assetsQry = from ast in StaticCode.mainDbContext.AssetTbls select ast;
            if (customSearchRadioButton.Checked)
            {
                if (searchByDepartmentCheckBox.Checked)
                {
                    if (searchByDepartmentLookUpEdit.EditValue == null)
                    {
                        mainAlertControl.Show(this, "حدد القسم أولاً", StaticCode.ApplicationTitle);
                        return;
                    }
                    else
                    {
                        assetsQry = assetsQry.Where(ast => ast.AssetDept == Convert.ToInt32(searchByDepartmentLookUpEdit.EditValue));
                    }
                }
                if (searchBySectionCheckBox.Checked)
                {
                    if (searchBySectionLookUpEdit.EditValue == null)
                    {
                        mainAlertControl.Show(this, "حدد الدائرة أولاً", StaticCode.ApplicationTitle);
                        return;
                    }
                    else
                    {
                        assetsQry = assetsQry.Where(ast => ast.AssetSection == Convert.ToInt32(searchBySectionLookUpEdit.EditValue));
                    }
                }
                if (searchBySquareCheckBox.Checked)
                {
                    if (searchBySquareLookUpEdit.EditValue == null)
                    {
                        mainAlertControl.Show(this, "حدد الساحة أولاً", StaticCode.ApplicationTitle);
                        return;
                    }
                    else
                    {
                        assetsQry = assetsQry.Where(ast => ast.AssetSquare == Convert.ToInt32(searchBySquareLookUpEdit.EditValue));
                    }
                }
                if (searchByMainCategoryCheckBox.Checked)
                {
                    if (searchByMainCategoryLookUpEdit.EditValue == null)
                    {
                        mainAlertControl.Show(this, "حدد الفئة الرئيسية أولاً", StaticCode.ApplicationTitle);
                        return;
                    }
                    else
                    {
                        List<int> minorQry = (from minorCat in StaticCode.mainDbContext.MinorCategoryTbls where minorCat.MainCategory == Convert.ToInt32(searchByMainCategoryLookUpEdit.EditValue) select minorCat.ID).ToList();
                        assetsQry = from qry in assetsQry where minorQry.IndexOf(qry.AssetMinorCategory) > -1 select qry;
                    }
                }
                if (searchByMinorCategoryCheckBox.Checked)
                {
                    if (searchByMinorCategoryLookUpEdit.EditValue == null)
                    {
                        mainAlertControl.Show(this, "حدد الفئة الفرعية أولاً", StaticCode.ApplicationTitle);
                        return;
                    }
                    else
                    {
                        assetsQry = assetsQry.Where(ast => ast.AssetMinorCategory == Convert.ToInt32(searchByMinorCategoryLookUpEdit.EditValue));
                    }
                }
            }

            assetGridControl.DataSource = assetsQry;
            assetGridControl.Visible = true;
            exportToExcelDropDownButton.Enabled = true;
        }

        private void exportToExcelDropDownButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog assetsInvPath = new SaveFileDialog() { Filter = "Excel workbook 2007-2022 (*.xlsx)|*.xlsx" };
            if (assetsInvPath.ShowDialog() != DialogResult.OK)
            {
                mainAlertControl.Show(this, "تم الإلغاء", StaticCode.ApplicationTitle);
                return;
            }

            ExcelPackage astEp = new ExcelPackage(new System.IO.FileInfo(assetsInvPath.FileName));
            ExcelWorkbook astWb = astEp.Workbook;
            ExcelWorksheet astWs = astWb.Worksheets.Add("جرد الأصول");
            astWs.View.RightToLeft = true;
            List<int> columnsWidths = new List<int>() { 10, 15, 55, 10, 25, 30, 15, 25, 12, 12, 20, 15, 18, 18, 15, 15, 20, 15, 15, 15, 15, 25 };
            List<string> columnsTitles = new List<string>()
            {
                "التسلسل",
                "الرمز",
                "بيان تفصيلي للاصل ( النوع / الموديل / اللون / الرقم / الحجم / ..... )",
                "العدد",
                "اسم المالك",
                "العنوان بالضبط",
                "المستغل منه",
                "مع من ورقة الملكية",
                "تاريخ الشراء",
                "قيمة الشراء",
                "مكان وجوده",
                "العمر الافتراضي المتبقي",
                "حالته الآنية",
                "مدى الاستفاده الحالية منه",
                "قيمته الفعلية الحالية",
                "صاحب العهدة",
                "إضافات أخرى",
                "ما أتلف سابقاً",
                "ما تم تحويله سابقاً",
                "ما بيع سابقاً",
                "الرصيد",
                "ملاحظات",
            };
            for (int col = 2; col <= columnsWidths.Count + 1; col++)
            {
                astWs.Columns[col].Width = columnsWidths[col - 2];
                astWs.Cells[7, col].Value = columnsTitles[col - 2];
            }
            astWs.Rows[7].Height = 30;
            using (var cells = astWs.Cells[1, 5, 1, 14])
            {
                cells.Style.Font.Name = "Sakkal Majalla";
                cells.Style.Font.Size = 16.0F;
                cells.Merge = true;
                cells.Style.Font.Bold = true;
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Value = "بسم الله الرحمن الرحيم";
            }
            using (var cells = astWs.Cells[3, 2, 3, columnsWidths.Count + 1])
            {
                cells.Style.Font.Name = "Sakkal Majalla";
                cells.Style.Font.Size = 16.0F;
                cells.Merge = true;
                cells.Style.Font.Bold = true;
                cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Medium;
                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(221, 217, 196));
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Value = $"الجرد السنوي للأصول الثابتة - {DateTime.Today.Year}";
            }
            using (var cells = astWs.Cells[5, 4])
            {
                cells.Style.Font.Name = "Sakkal Majalla";
                cells.Style.Font.Size = 12.0F;
                cells.Style.Font.Bold = true;
                cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Double;
                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(197, 217, 241));
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Value = "الدائرة";
            }
            using (var cells = astWs.Cells[5, 5, 5, 12])
            {
                cells.Style.Font.Name = "Sakkal Majalla";
                cells.Style.Font.Size = 12.0F;
                cells.Merge = true;
                cells.Style.Font.Bold = true;
                cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Double;
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Value = (customSearchGroupBox.Visible && searchBySectionCheckBox.Checked) ? searchBySectionLookUpEdit.Text : "";
            }
            using (var cells = astWs.Cells[5, 13, 5, 14])
            {
                cells.Style.Font.Name = "Sakkal Majalla";
                cells.Style.Font.Size = 12.0F;
                cells.Style.Font.Bold = true;
                cells.Merge = true;
                cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Double;
                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(197, 217, 241));
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Value = "القسم";
            }
            using (var cells = astWs.Cells[5, 15, 5, 17])
            {
                cells.Style.Font.Name = "Sakkal Majalla";
                cells.Style.Font.Size = 12.0F;
                cells.Merge = true;
                cells.Style.Font.Bold = true;
                cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Double;
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Value = (customSearchGroupBox.Visible && searchByDepartmentCheckBox.Checked) ? searchByDepartmentLookUpEdit.Text : "";
            }
            using (var cells = astWs.Cells[5, 18])
            {
                cells.Style.Font.Name = "Sakkal Majalla";
                cells.Style.Font.Size = 12.0F;
                cells.Style.Font.Bold = true;
                cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Double;
                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(197, 217, 241));
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Value = "التاريخ";
            }
            using (var cells = astWs.Cells[5, 19, 5, 22])
            {
                cells.Style.Font.Name = "Sakkal Majalla";
                cells.Style.Font.Size = 12.0F;
                cells.Merge = true;
                cells.Style.Font.Bold = true;
                cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Double;
                cells.Value = DateTime.Today.ToString("dd-MM-yyyy");
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Value = DateTime.Today.ToString("dd-MM-yyyy");
            }
            int startRow = 7;
            int currentRow = startRow;
            using (var cells = astWs.Cells[currentRow, 2, currentRow, columnsWidths.Count + 1])
            {
                cells.Style.Font.Name = "Sakkal Majalla";
                cells.Style.Font.Size = 11.0F;
                cells.Style.WrapText = true;
                cells.Style.Font.Bold = true;
                cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Medium;
                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(217, 217, 217));
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            }
            if (assetsQry.Count() == 0)
                return;

            int astCount = 1;
            currentRow++;
            List<MainCategoryTbl> allMainCategories = StaticCode.mainDbContext.MainCategoryTbls.Select(maca => maca).ToList();
            foreach (MainCategoryTbl oneMaCa in allMainCategories)
            {
                List<int> micaIDs = StaticCode.mainDbContext.MinorCategoryTbls.Where(mica1 => mica1.MainCategory == oneMaCa.ID).Select(mica1 => mica1.ID).ToList();
                var assetsQryByMaCa = assetsQry.Where(ast => micaIDs.Contains(ast.AssetMinorCategory));
                if (assetsQryByMaCa == null || assetsQryByMaCa.Count() == 0)
                    continue;

                using (var cells = astWs.Cells[currentRow, 3, currentRow, 4])
                {
                    cells.Style.Font.Name = "Sakkal Majalla";
                    cells.Style.Font.Size = 12.0F;
                    cells.Merge = true;
                    cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Medium;
                    cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cells.Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                    cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    cells.Value = oneMaCa.MainCategoryName;
                }
                currentRow++;

                foreach (var oneAst in assetsQryByMaCa)
                {
                    Application.DoEvents();

                    astWs.Cells[currentRow, 2].Value = astCount;
                    astWs.Cells[currentRow, 3].Value = oneAst.AssetCode;
                    astWs.Cells[currentRow, 4].Value = oneAst.AssetSpecifications;
                    astWs.Cells[currentRow, 5].Value = oneAst.ItemsQuantity;
                    astWs.Cells[currentRow, 6].Value = oneAst.OwnerName;
                    astWs.Cells[currentRow, 7].Value = oneAst.EstateAddress;
                    astWs.Cells[currentRow, 8].Value = oneAst.OfUsed;
                    astWs.Cells[currentRow, 9].Value = oneAst.EstateOwnershipDocumentWith;
                    astWs.Cells[currentRow, 10].Value = oneAst.PurchaseDate?.ToShortDateString();
                    astWs.Cells[currentRow, 11].Value = $"{oneAst.PurchasePrice} {StaticCode.mainDbContext.CurrencyTbls.Single(cur => cur.ID == oneAst.PurchasePriceCurrency).CurrencyName}";
                    astWs.Cells[currentRow, 12].Value = oneAst.PlaceOfPresence;
                    astWs.Cells[currentRow, 13].Value = $"{(int)oneAst.LifeSpanInMonths / 12} سنوات و {(int)oneAst.LifeSpanInMonths % 12} أشهر";
                    astWs.Cells[currentRow, 14].Value = StaticCode.mainDbContext.StatusTbls.Single(cur => cur.ID == oneAst.CurrentStatus).StatusName;
                    astWs.Cells[currentRow, 15].Value = oneAst.BenefitPercentage;
                    astWs.Cells[currentRow, 16].Value = $"{oneAst.ActualCurrentPrice} {StaticCode.mainDbContext.CurrencyTbls.Single(cur => cur.ID == oneAst.ActualCurrentPriceCurrency).CurrencyName}";
                    astWs.Cells[currentRow, 17].Value = oneAst.CustodianName;
                    astWs.Cells[currentRow, 18].Value = oneAst.MoreDetails;
                    astWs.Cells[currentRow, 19].Value = "";
                    astWs.Cells[currentRow, 20].Value = "";
                    astWs.Cells[currentRow, 21].Value = "";
                    astWs.Cells[currentRow, 22].Value = oneAst.DestructionRate;
                    astWs.Cells[currentRow, 23].Value = oneAst.AssetNotes;

                    currentRow++;
                    astCount++;
                }
            }

            using (var cells = astWs.Cells[startRow + 1, 2, currentRow - 1, columnsWidths.Count + 1])
            {
                cells.Style.Font.Name = "Sakkal Majalla";
                cells.Style.Font.Size = 11.0F;
                cells.Style.Border.BorderAround(ExcelBorderStyle.Medium);
                cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            }
            astEp.Save();

            mainAlertControl.Show(this, "تم التصدير بنجاح", StaticCode.ApplicationTitle);
        }
    }
}