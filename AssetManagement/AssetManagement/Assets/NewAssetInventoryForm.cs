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
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetVw' table. You can move, or remove it, as needed.
            this.assetVwTableAdapter.Fill(this.assetMngDbDataSet.AssetVw);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SubDepartmentTbl' table. You can move, or remove it, as needed.
            this.subDepartmentTblTableAdapter.Fill(this.assetMngDbDataSet.SubDepartmentTbl);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchAssetDropDownButton_Click(object sender, EventArgs e)
        {
            assetGridControl.Visible = false;
            exportToExcelDropDownButton.Enabled = false;
            assetsQry = from ast in StaticCode.mainDbContext.AssetTbls select ast;
            if (customSearchRadioButton.Checked)
            {
                if (searchBySectionCheckBox.Checked)
                {
                    if (searchBySectionLookUpEdit.EditValue == null)
                    {
                        mainAlertControl.Show(this, "حدد الدائرة أولاً", StaticCode.ApplicationTitle);
                        return;
                    }
                    else
                    {
                        List<int> dptQry = (from dpt1 in StaticCode.mainDbContext.DepartmentTbls where dpt1.SectionOfDepartment == Convert.ToInt32(searchBySectionLookUpEdit.EditValue) select dpt1.ID).ToList();
                        List<int> sdptQry = (from sdep1 in StaticCode.mainDbContext.SubDepartmentTbls where dptQry.Contains(sdep1.MainDepartment) select sdep1.ID).ToList();
                        assetsQry = from qry in assetsQry where sdptQry.Contains(qry.AssetSubDepartment) select qry;
                    }
                }
                if (searchByDepartmentCheckBox.Checked)
                {
                    if (searchByDepartmentLookUpEdit.EditValue == null)
                    {
                        mainAlertControl.Show(this, "حدد القسم أولاً", StaticCode.ApplicationTitle);
                        return;
                    }
                    else
                    {
                        List<int> sdptQry = (from sdep1 in StaticCode.mainDbContext.SubDepartmentTbls where sdep1.MainDepartment == Convert.ToInt32(searchByDepartmentLookUpEdit.EditValue) select sdep1.ID).ToList();
                        assetsQry = from qry in assetsQry where sdptQry.Contains(qry.AssetSubDepartment) select qry;
                    }
                }
                if (searchBySubDepartmentCheckBox.Checked)
                {
                    if (searchBySubDepartmentLookUpEdit.EditValue == null)
                    {
                        mainAlertControl.Show(this, "حدد الوحدة أولاً", StaticCode.ApplicationTitle);
                        return;
                    }
                    else
                    {
                        assetsQry = assetsQry.Where(ast => ast.AssetSubDepartment == Convert.ToInt32(searchBySubDepartmentLookUpEdit.EditValue));
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
                        assetsQry = from qry in assetsQry where minorQry.Contains(qry.AssetMinorCategory) select qry;
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

            List<int> assetQryIDs = assetsQry.Select(ast1 => ast1.ID).ToList();
            var assetsVwQry = StaticCode.mainDbContext.AssetVws.Where(ast2 => assetQryIDs.Contains(ast2.معرف_الأصل));
            assetGridControl.DataSource = assetsVwQry;
            assetGridControl.Visible =
            exportToExcelDropDownButton.Enabled = assetsQry.Count() > 0;
            if (assetsQry.Count() == 0)
            {
                mainAlertControl.Show(this, "لا توجد نتائج", StaticCode.ApplicationTitle);
            }
        }

        private void exportToExcelDropDownButton_Click(object sender, EventArgs e)
        {
            ExportAssets(1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formNo">1 for normal, 2 for estates, 3 for vehicles</param>
        private void ExportAssets(int formNo)
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
            List<int> columnsWidths = new List<int>() { 8, 15, 40, 8, 20, 25, 12, 15, 12, 12, 10, 10, 15, 15, 15, 12, 12, 20, 15, 12, 18, 15, 15, 20, 15, 15, 15, 10, 25 };
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
                "نوع السيارة",
                "رقم اللوحة",
                "لونها",
                "سنة الصنع",
                "رقم الشاصيه",
                "رقم الماكينة",
                "المالك",
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
            List<int> hiddenCols = new List<int>() { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            if (formNo == 2)
                hiddenCols = new List<int>() { 10, 11, 12, 13, 14, 15, 16 };
            if (formNo == 3)
                hiddenCols = new List<int>() { 6, 7, 8, 9 };
            for (int col = 2; col <= columnsWidths.Count + 1; col++)
            {
                astWs.Columns[col].Width = columnsWidths[col - 2];
                astWs.Cells[7, col].Value = columnsTitles[col - 2];
                if (hiddenCols.IndexOf(col) > -1)
                    astWs.Columns[col].Hidden = true;
            }
            astWs.Rows[7].Height = 30;
            using (var cells = astWs.Cells[1, 4, 1, 18])
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
            int endCol = 18;
            int startCol3 = 21;
            if (formNo == 2)
            {
                endCol = 7;
                startCol3 = 17;
            }
            if (formNo == 3)
            {
                endCol = 12;
                startCol3 = 15;
            }
            int startCol2 = endCol + 1;
            using (var cells = astWs.Cells[5, 5, 5, endCol])
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
            using (var cells = astWs.Cells[5, startCol2, 5, startCol2 + 1])
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
            using (var cells = astWs.Cells[5, startCol3, 5, startCol3 + 2])
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
            using (var cells = astWs.Cells[5, startCol3 + 3, 5, startCol3 + 4])
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
                cells.Value = "التاريخ";
            }
            using (var cells = astWs.Cells[5, startCol3 + 5, 5, startCol3 + 6])
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
                    astWs.Cells[currentRow, 10].Value = oneAst.Model;
                    astWs.Cells[currentRow, 11].Value = oneAst.CarPanelNumber;
                    astWs.Cells[currentRow, 12].Value = oneAst.Color;
                    astWs.Cells[currentRow, 13].Value = oneAst.CarManufacturingYear;
                    astWs.Cells[currentRow, 14].Value = oneAst.CarChassisNumber;
                    astWs.Cells[currentRow, 15].Value = oneAst.CarEngineNumber;
                    astWs.Cells[currentRow, 16].Value = oneAst.OwnerName;
                    astWs.Cells[currentRow, 17].Value = oneAst.PurchaseDate?.ToShortDateString();
                    astWs.Cells[currentRow, 18].Value = $"{oneAst.PurchasePrice} {StaticCode.mainDbContext.CurrencyTbls.Single(cur => cur.ID == oneAst.PurchasePriceCurrency).CurrencyName}";
                    astWs.Cells[currentRow, 19].Value = oneAst.PlaceOfPresence;
                    astWs.Cells[currentRow, 20].Value = $"{(int)oneAst.LifeSpanInMonths / 12} سنوات و {(int)oneAst.LifeSpanInMonths % 12} أشهر";
                    astWs.Cells[currentRow, 21].Value = StaticCode.mainDbContext.StatusTbls.Single(cur => cur.ID == oneAst.CurrentStatus).StatusName;
                    astWs.Cells[currentRow, 22].Value = oneAst.BenefitPercentage;
                    astWs.Cells[currentRow, 23].Value = $"{oneAst.ActualCurrentPrice} {StaticCode.mainDbContext.CurrencyTbls.Single(cur => cur.ID == oneAst.ActualCurrentPriceCurrency).CurrencyName}";
                    astWs.Cells[currentRow, 24].Value = oneAst.CustodianName;
                    astWs.Cells[currentRow, 25].Value = oneAst.MoreDetails;
                    astWs.Cells[currentRow, 26].Value = StaticCode.mainDbContext.AssetTransactionTbls.Count(astt1 => astt1.AssetID == oneAst.ID && astt1.GetAssetOutOfWork == true);
                    astWs.Cells[currentRow, 27].Value = StaticCode.mainDbContext.AssetMovementTbls.Count(astm1 => astm1.AssetID == oneAst.ID);
                    astWs.Cells[currentRow, 28].Value = StaticCode.mainDbContext.AssetTransactionTbls.Count(astt1 => astt1.AssetID == oneAst.ID && StaticCode.mainDbContext.TransactionTypeTbls.Where(tt1 => tt1.TransactionTypeName == "بيع").Select(tt1 => tt1.ID).ToList().Contains(astt1.TransactionType));
                    astWs.Cells[currentRow, 29].Value = oneAst.DestructionRate;
                    astWs.Cells[currentRow, 30].Value = oneAst.AssetNotes;

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

            for (int iCol = astWs.Dimension.End.Column; iCol >= astWs.Dimension.Start.Column; iCol--)
            {
                if (astWs.Column(iCol).Hidden)
                    astWs.DeleteColumn(iCol);
            }
            astEp.Save();

            mainAlertControl.Show(this, "تم التصدير بنجاح", StaticCode.ApplicationTitle);
        }

        private void allAssetsExportBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportAssets(1);
        }

        private void estatesExportBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportAssets(2);
        }

        private void vehiclesexportBrButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportAssets(3);
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
        }

        private void searchBySubDepartmentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchBySubDepartmentLookUpEdit.Visible = searchBySubDepartmentCheckBox.Checked;
        }

        private void searchBySectionLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (searchBySectionCheckBox.Checked)
            {
                if (searchBySectionLookUpEdit.EditValue == null)
                    return;
                var deptItems = StaticCode.mainDbContext.DepartmentTbls.Where(sec1 => sec1.SectionOfDepartment == Convert.ToInt32(searchBySectionLookUpEdit.EditValue));
                searchByDepartmentLookUpEdit.Properties.DataSource = deptItems;
                searchByDepartmentLookUpEdit_EditValueChanged(sender, e);
                searchBySubDepartmentLookUpEdit.EditValue = null;
            }
        }

        private void searchByDepartmentLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (searchByDepartmentCheckBox.Checked)
            {
                if (searchByDepartmentLookUpEdit.EditValue == null)
                    return;
                var subDeptItems = StaticCode.mainDbContext.SubDepartmentTbls.Where(subd1 => subd1.MainDepartment == Convert.ToInt32(searchByDepartmentLookUpEdit.EditValue));
                searchBySubDepartmentLookUpEdit.Properties.DataSource = subDeptItems;
            }
        }
    }
}