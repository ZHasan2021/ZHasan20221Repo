using OfficeOpenXml;
using OfficeOpenXml.DataValidation;
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
    public partial class NewAssetInventoryForm : Form
    {
        IQueryable<AssetTbl> assetsQry = null;
        public NewAssetInventoryForm()
        {
            InitializeComponent();
        }

        private void NewAssetInventoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SubDepartmentVw' table. You can move, or remove it, as needed.
            this.subDepartmentVwTableAdapter.Fill(this.assetMngDbDataSet.SubDepartmentVw);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.DepartmentVw' table. You can move, or remove it, as needed.
            this.departmentVwTableAdapter.Fill(this.assetMngDbDataSet.DepartmentVw);
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

            if (StaticCode.activeUserRole.IsSectionIndependent != true)
            {
                try
                {
                    if (StaticCode.activeUserRole.IsDepartmentIndependent == true)
                    {
                        searchBySectionLookUpEdit.EditValue = StaticCode.activeUser.UserSection;
                        searchBySectionCheckBox.Checked = true;
                        searchBySectionLookUpEdit.Enabled = searchBySectionCheckBox.Enabled = false;
                    }
                    else
                    {
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

            moveAllDropDownButton.Visible = moveAllAssetsToolStripMenuItem.Visible = StaticCode.activeUserRole.AddNewAssetMovement == true;
        }

        private void searchAllRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            customSearchGroupBox.Visible = customSearchRadioButton.Checked;
        }

        private void searchByDepartmentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
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
            searchByAssetSpecificationsTextBox.Visible = searchByAssetSpecificationsCheckBox.Checked;
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
            exportToExcelDropDownButton.Enabled = moveAllDropDownButton.Enabled = false;
            assetsQry = from ast in StaticCode.mainDbContext.AssetTbls where (from asv in StaticCode.mainDbContext.AssetVws select asv.معرف_الأصل).Contains(ast.ID) == true select ast;
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
                    if (searchByDepartmentSearchLookUpEdit.EditValue == null)
                    {
                        mainAlertControl.Show(this, "حدد القسم أولاً", StaticCode.ApplicationTitle);
                        return;
                    }
                    else
                    {
                        var fff = searchByDepartmentSearchLookUpEdit.EditValue;

                        List<int> sdptQry = (from sdep1 in StaticCode.mainDbContext.SubDepartmentTbls where sdep1.MainDepartment == Convert.ToInt32(searchByDepartmentSearchLookUpEdit.EditValue) select sdep1.ID).ToList();
                        assetsQry = from qry in assetsQry where sdptQry.Contains(qry.AssetSubDepartment) select qry;
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
                        assetsQry = assetsQry.Where(ast => ast.AssetSubDepartment == Convert.ToInt32(searchBySubDepartmentSearchLookUpEdit.EditValue));
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
                if (searchByStatusCheckBox.Checked)
                {
                    if (searchByStatusLookUpEdit.EditValue == null)
                    {
                        mainAlertControl.Show(this, "حدد الحالة أولاً", StaticCode.ApplicationTitle);
                        return;
                    }
                    else
                    {
                        assetsQry = assetsQry.Where(ast => ast.CurrentStatus == Convert.ToInt32(searchByStatusLookUpEdit.EditValue));
                    }
                }
                if (searchByAssetCodeCheckBox.Checked)
                {
                    if (searchByAssetCodeTextBox.Text.Trim() == "")
                    {
                        mainAlertControl.Show(this, "اكتب كود الأصل أولاً", StaticCode.ApplicationTitle);
                        return;
                    }
                    else
                    {
                        assetsQry = assetsQry.Where(ast => ast.AssetCode.Contains(searchByAssetCodeTextBox.Text.Trim()));
                    }
                }
                if (searchByCustodianNameCheckBox.Checked)
                {
                    if (searchByCustodianNameTextBox.Text.Trim() == "")
                    {
                        mainAlertControl.Show(this, "اكتب صاحب العهدة أولاً", StaticCode.ApplicationTitle);
                        return;
                    }
                    else
                    {
                        assetsQry = assetsQry.Where(ast => ast.CustodianName.Contains(searchByCustodianNameTextBox.Text.Trim()));
                    }
                }
                if (searchByAssetSpecificationsCheckBox.Checked)
                {
                    if (searchByAssetSpecificationsTextBox.Text.Trim() == "")
                    {
                        mainAlertControl.Show(this, "اكتب مواصفات الأصل أولاً", StaticCode.ApplicationTitle);
                        return;
                    }
                    else
                    {
                        assetsQry = assetsQry.Where(ast => ast.AssetSpecifications.Contains(searchByAssetSpecificationsTextBox.Text.Trim()));
                    }
                }
                if (searchByPurchaseDateCheckBox.Checked)
                {
                    if (searchByPurchaseDateDateEdit_From.EditValue == null)
                    {
                        mainAlertControl.Show(this, "اكتب بداية تاريخ الشراء أولاً", StaticCode.ApplicationTitle);
                        return;
                    }
                    if (searchByPurchaseDateDateEdit_To.EditValue == null)
                    {
                        mainAlertControl.Show(this, "اكتب نهاية تاريخ الشراء أولاً", StaticCode.ApplicationTitle);
                        return;
                    }
                    if (Convert.ToDateTime(searchByPurchaseDateDateEdit_From.EditValue) > Convert.ToDateTime(searchByPurchaseDateDateEdit_To.EditValue))
                    {
                        mainAlertControl.Show(this, "بداية تاريخ الشراء أحدث من نهاية تاريخ الشراء", StaticCode.ApplicationTitle);
                        return;
                    }
                    assetsQry = assetsQry.Where(ast => ast.PurchaseDate != null && ast.PurchaseDate >= Convert.ToDateTime(searchByPurchaseDateDateEdit_From.EditValue) && ast.PurchaseDate <= Convert.ToDateTime(searchByPurchaseDateDateEdit_To.EditValue));
                }
                if (searchByInsertionDateCheckBox.Checked)
                {
                    if (searchByInsertionDateDateEdit_From.EditValue == null)
                    {
                        mainAlertControl.Show(this, "اكتب بداية تاريخ الإدخال أولاً", StaticCode.ApplicationTitle);
                        return;
                    }
                    if (searchByInsertionDateDateEdit_To.EditValue == null)
                    {
                        mainAlertControl.Show(this, "اكتب نهاية تاريخ الإدخال أولاً", StaticCode.ApplicationTitle);
                        return;
                    }
                    if (Convert.ToDateTime(searchByInsertionDateDateEdit_From.EditValue) > Convert.ToDateTime(searchByInsertionDateDateEdit_To.EditValue))
                    {
                        mainAlertControl.Show(this, "بداية تاريخ الإدخال أحدث من نهاية تاريخ الإدخال", StaticCode.ApplicationTitle);
                        return;
                    }
                    assetsQry = assetsQry.Where(ast => ast.InsertedOn != null && ast.InsertedOn >= Convert.ToDateTime(searchByInsertionDateDateEdit_From.EditValue) && ast.InsertedOn <= Convert.ToDateTime(searchByInsertionDateDateEdit_To.EditValue));
                }
            }

            assetGridControl.Visible =
            exportToExcelDropDownButton.Enabled = moveAllDropDownButton.Enabled = assetsQry.Count() > 0;
            if (assetsQry.Count() == 0)
            {
                mainAlertControl.Show(this, "لا توجد نتائج", StaticCode.ApplicationTitle);
            }
            else
            {
                List<int> IDsIncluded = assetsQry.Select(as1 => as1.ID).ToList();
                string plusQry = "";
                foreach (int oneID in IDsIncluded)
                    plusQry += oneID + ", ";
                plusQry = $" WHERE [معرف الأصل] IN ({ plusQry.Trim().Trim(',').Trim()});";
                AssetVwDataTable customVw = this.assetMngDbDataSet.AssetVw;
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
                        continue;
                    }
                }
                this.assetVwTableAdapter.FillByQuery(customVw, plusQry);
                moveAllDropDownButton.Text = $"نقل ({assetsQry.Count()}) أصل/أصول";
            }
        }

        private void exportToExcelDropDownButton_Click(object sender, EventArgs e)
        {
            exportToExcelDropDownButton.ShowDropDown();
            //ExportAssets(1);
        }

        private void ExportAssets_Old(int formNo)
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
            List<int> columnsWidths = new List<int>() { 8, 15, 40, 8, 20, 25, 12, 15, 12, 12, 10, 10, 15, 15, 15, 12, 12, 20, 15, 15, 12, 18, 15, 15, 20, 15, 15, 15, 10, 25 };
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
                "الساحة",
                "العمر الافتراضي المتبقي",
                "حالته الآنية",
                "مدى الاستفاده الحالية منه",
                "قيمته الفعلية الحالية",
                "صاحب العهدة",
                "إضافات أخرى",
                "ما تم تصريفه",
                "ما تم نقله",
                "ما تم بيعه",
                "معدل الإهلاك",
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
                string sectionName = "";
                if (customSearchGroupBox.Visible && searchBySectionCheckBox.Checked)
                    sectionName = searchBySectionLookUpEdit.Text;
                if (customSearchGroupBox.Visible && searchByDepartmentCheckBox.Checked)
                    sectionName = StaticCode.mainDbContext.SectionTbls.Single(sc1 => sc1.ID == StaticCode.mainDbContext.DepartmentTbls.Single(dpt1 => dpt1.ID == Convert.ToInt32(searchByDepartmentSearchLookUpEdit.EditValue)).SectionOfDepartment).SectionName;
                if (customSearchGroupBox.Visible && searchBySubDepartmentCheckBox.Checked)
                    sectionName = StaticCode.mainDbContext.SectionTbls.Single(sc1 => sc1.ID == StaticCode.mainDbContext.DepartmentTbls.Single(dpt1 => dpt1.ID == StaticCode.mainDbContext.SubDepartmentTbls.Single(sdpt1 => sdpt1.ID == Convert.ToInt32(searchBySubDepartmentSearchLookUpEdit.EditValue)).MainDepartment).SectionOfDepartment).SectionName;
                cells.Value = sectionName;
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
                string deptName = "";
                if (customSearchGroupBox.Visible && searchByDepartmentCheckBox.Checked)
                    deptName = searchByDepartmentSearchLookUpEdit.Text;
                if (customSearchGroupBox.Visible && searchBySubDepartmentCheckBox.Checked)
                    deptName = StaticCode.mainDbContext.DepartmentTbls.Single(dpt1 => dpt1.ID == StaticCode.mainDbContext.SubDepartmentTbls.Single(sdpt1 => sdpt1.ID == Convert.ToInt32(searchBySubDepartmentSearchLookUpEdit.EditValue)).MainDepartment).DepartmentName;
                cells.Value = deptName;
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
                cells.Value = "الوحدة";
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
                cells.Value = (customSearchGroupBox.Visible && searchBySubDepartmentCheckBox.Checked) ? searchBySubDepartmentSearchLookUpEdit.Text : "";
            }
            using (var cells = astWs.Cells[5, startCol3 + 7, 5, startCol3 + 8])
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
            using (var cells = astWs.Cells[5, startCol3 + 9, 5, startCol3 + 10])
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
                    astWs.Cells[currentRow, 4].Value = $"{StaticCode.mainDbContext.MinorCategoryTbls.Single(mica1 => mica1.ID == oneAst.AssetMinorCategory).MinorCategoryName}: {oneAst.AssetSpecifications}";
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
                    astWs.Cells[currentRow, 20].Value = StaticCode.mainDbContext.SquareTbls.Single(sqr1 => sqr1.ID == oneAst.AssetSquare).SquareName;
                    astWs.Cells[currentRow, 21].Value = $"{(int)oneAst.LifeSpanInMonths / 12} سنوات و {(int)oneAst.LifeSpanInMonths % 12} أشهر";
                    astWs.Cells[currentRow, 22].Value = StaticCode.mainDbContext.StatusTbls.Single(cur => cur.ID == oneAst.CurrentStatus).StatusName;
                    astWs.Cells[currentRow, 23].Value = oneAst.BenefitPercentage;
                    astWs.Cells[currentRow, 24].Value = $"{oneAst.ActualCurrentPrice} {StaticCode.mainDbContext.CurrencyTbls.Single(cur => cur.ID == oneAst.ActualCurrentPriceCurrency).CurrencyName}";
                    astWs.Cells[currentRow, 25].Value = oneAst.CustodianName;
                    astWs.Cells[currentRow, 26].Value = oneAst.MoreDetails;
                    astWs.Cells[currentRow, 27].Value = StaticCode.mainDbContext.AssetTransactionTbls.Count(astt1 => astt1.AssetID == oneAst.ID && astt1.GetAssetOutOfWork == true);
                    astWs.Cells[currentRow, 28].Value = StaticCode.mainDbContext.AssetMovementTbls.Count(astm1 => astm1.AssetID == oneAst.ID);
                    astWs.Cells[currentRow, 29].Value = StaticCode.mainDbContext.AssetTransactionTbls.Count(astt1 => astt1.AssetID == oneAst.ID && StaticCode.mainDbContext.TransactionTypeTbls.Where(tt1 => tt1.TransactionTypeName == "بيع").Select(tt1 => tt1.ID).ToList().Contains(astt1.TransactionType));
                    astWs.Cells[currentRow, 30].Value = oneAst.DestructionRate;
                    astWs.Cells[currentRow, 31].Value = oneAst.AssetNotes;

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
            if (File.Exists(assetsInvPath.FileName))
                File.Delete(assetsInvPath.FileName);

            #region Fill the headers
            ExcelPackage astEp = new ExcelPackage(new System.IO.FileInfo(assetsInvPath.FileName));
            ExcelWorkbook astWb = astEp.Workbook;
            ExcelWorksheet astWs = astWb.Worksheets.Add("جرد الأصول");
            astWs.View.RightToLeft = true;
            List<int> columnsWidths = new List<int>()
            {
                8, 15, 20, 20, 40,
                10, 12, 15, 12, 12,
                10, 10, 18, 15, 15,
                12, 12, 15, 15, 15,
                15, 20, 12, 18, 15,
                15, 15, 12, 12, 18,
                10, 25
            };
            List<string> columnsTitles = new List<string>()
            {
                "التسلسل",
                "الرمز",
                "الفئة الرئيسية",
                "الفئة الفرعية",
                "البيان التفصيلي لمواصفات الأصل",
                //"بيان تفصيلي للاصل ( النوع / الموديل / اللون / الرقم / الحجم / ..... )",
                
                
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
                "نوع العملة",


                "قيمته الفعلية الحالية",
                "الساحة",
                "مكان وجوده",
                "حالته الآنية",
                "مدى الاستفاده الحالية منه",


                "صاحب العهدة",
                "إضافات أخرى",
                "ما تم تصريفه",
                "ما تم نقله",
                "العمر الافتراضي المتبقي",


                "معدل الإهلاك",
                "ملاحظات",
            };
            List<int> hiddenCols = new List<int>() { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            if (formNo == 2)
                hiddenCols = new List<int>() { 12, 13, 14, 15, 16, 17, 18 };
            if (formNo == 3)
                hiddenCols = new List<int>() { 8, 9, 10, 11 };
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
            string sectionOfSearch = "";
            string departmentOfSearch = "";
            string subDepartmentOfSearch = "";
            if (customSearchGroupBox.Visible && searchBySectionCheckBox.Checked)
            {
                sectionOfSearch = searchBySectionLookUpEdit.Text;
            }
            else if (customSearchGroupBox.Visible && searchByDepartmentCheckBox.Checked)
            {
                sectionOfSearch = StaticCode.mainDbContext.DepartmentVws.Where(dptv1 => dptv1.اسم_القسم == searchByDepartmentSearchLookUpEdit.Text).First().الدائرة_التي_يتبع_لها_القسم;
                departmentOfSearch = searchByDepartmentSearchLookUpEdit.Text;
            }
            else if (customSearchGroupBox.Visible && searchBySubDepartmentCheckBox.Checked)
            {
                sectionOfSearch = StaticCode.mainDbContext.SubDepartmentVws.Where(sdtv1 => sdtv1.اسم_الوحدة == searchBySubDepartmentSearchLookUpEdit.Text).First().الدائرة_التي_يتبع_لها_القسم;
                departmentOfSearch = StaticCode.mainDbContext.SubDepartmentVws.Where(sdtv1 => sdtv1.اسم_الوحدة == searchBySubDepartmentSearchLookUpEdit.Text).First().القسم_التابعة_له;
                subDepartmentOfSearch = searchBySubDepartmentSearchLookUpEdit.Text;
            }
            using (var cells = astWs.Cells[5, 5, 5, endCol])
            {
                cells.Style.Font.Name = "Sakkal Majalla";
                cells.Style.Font.Size = 12.0F;
                cells.Merge = true;
                cells.Style.Font.Bold = true;
                cells.Style.Border.Top.Style = cells.Style.Border.Bottom.Style = cells.Style.Border.Right.Style = cells.Style.Border.Left.Style = ExcelBorderStyle.Double;
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Value = sectionOfSearch;
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
                cells.Value = departmentOfSearch;
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
                cells.Value = "الوحدة";
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
                cells.Value = subDepartmentOfSearch;
            }
            using (var cells = astWs.Cells[5, startCol3 + 7, 5, startCol3 + 8])
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
            using (var cells = astWs.Cells[5, startCol3 + 9, 5, startCol3 + 10])
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
            #endregion

            var assetsQry_Export = assetsQry.Where(ast1 => ast1.IsOutOfWork == null || ast1.IsOutOfWork != true);
            if (includeOutOfWorkAssetsCheckBox.Checked)
                assetsQry_Export = assetsQry;

            if (assetsQry_Export.Count() == 0)
                return;

            #region Fill the rows
            int astCount = 1;
            currentRow++;
            foreach (var oneAst in assetsQry_Export)
            {
                Application.DoEvents();

                var assetTrans = StaticCode.mainDbContext.AssetTransactionTbls.Where(astt1 => astt1.AssetID == oneAst.ID);
                var assetTrans_Tasreef = assetTrans.Where(astt1 => StaticCode.mainDbContext.TransactionTypeTbls.Where(tt1 => tt1.TransactionTypeName == "تصريف").Select(tt1 => tt1.ID).Contains(astt1.TransactionType));
                var assetMvs = StaticCode.mainDbContext.AssetMovementTbls.Where(astm1 => astm1.AssetID == oneAst.ID);
                int assetTransCount = (assetTrans == null || assetTrans.Count() == 0) ? 0 : assetTrans.Sum(ast1 => ast1.QuantityTransacted);
                int assetTrans_TasreefCount = (assetTrans_Tasreef == null || assetTrans_Tasreef.Count() == 0) ? 0 : assetTrans_Tasreef.Sum(ast1 => ast1.QuantityTransacted);
                int assetMvsCount = (assetMvs == null || assetMvs.Count() == 0) ? 0 : assetMvs.Count();

                List<object> oneRowData = new List<object>()
                {
                    astCount,
                    oneAst.AssetCode,
                    StaticCode.mainDbContext.MainCategoryTbls.Single(maca1 => maca1.ID == StaticCode.mainDbContext.MinorCategoryTbls.Single(mica2 => mica2.ID == oneAst.AssetMinorCategory).MainCategory).MainCategoryName,
                    StaticCode.mainDbContext.MinorCategoryTbls.Single(mica1 => mica1.ID == oneAst.AssetMinorCategory).MinorCategoryName,
                    oneAst.AssetSpecifications,
                    oneAst.ItemsQuantity,
                    oneAst.OwnerName,
                    oneAst.EstateAddress,
                    oneAst.OfUsed,
                    oneAst.EstateOwnershipDocumentWith,
                    oneAst.Model,
                    oneAst.CarPanelNumber,
                    oneAst.Color,
                    oneAst.CarManufacturingYear,
                    oneAst.CarChassisNumber,
                    oneAst.CarEngineNumber,
                    oneAst.OwnerName,
                    oneAst.PurchaseDate?.ToShortDateString(),
                    oneAst.PurchasePrice,
                    StaticCode.mainDbContext.CurrencyTbls.Single(cur => cur.ID == oneAst.PurchasePriceCurrency).CurrencyName,
                    oneAst.ActualCurrentPrice,
                    StaticCode.mainDbContext.SquareTbls.Single(sqr1 => sqr1.ID == oneAst.AssetSquare).SquareName,
                     oneAst.PlaceOfPresence,
                     StaticCode.mainDbContext.StatusTbls.Single(cur => cur.ID == oneAst.CurrentStatus).StatusName,
                    oneAst.BenefitPercentage,
                    oneAst.CustodianName,
                    oneAst.MoreDetails,
                    assetTransCount,
                    assetMvsCount,
                     "", //StaticCode.mainDbContext.AssetVw_Alls.Single(astv1=>astv1.معرف_الأصل==oneAst.ID).العمر_الافتراضي_المتبقي_للأصل.Trim('-'),
                    oneAst.DestructionRate,
                    oneAst.AssetNotes,
                };
                for (int iCo = 0; iCo < oneRowData.Count; iCo++)
                    astWs.Cells[currentRow, iCo + 2].Value = oneRowData[iCo];

                currentRow++;
                astCount++;
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
            #endregion

            #region Data validation rules
            int shiftOfFormNo = 0;
            if (formNo == 2)
                shiftOfFormNo = 4;
            if (formNo == 3)
                shiftOfFormNo = 7;
            int macaCol = 4;
            int micaCol = 5;
            int curr1Col = 10 + shiftOfFormNo;
            int squCol = 12 + shiftOfFormNo;
            int statusCol = 14 + shiftOfFormNo;
            var curr1DataValidtion = astWs.DataValidations.AddListValidation(new ExcelAddress(startRow + 1, curr1Col, startRow + assetsQry_Export.Count(), curr1Col).ToString());
            var statusDataValidtion = astWs.DataValidations.AddListValidation(new ExcelAddress(startRow + 1, statusCol, startRow + assetsQry_Export.Count(), statusCol).ToString());
            var macaDataValidtion = astWs.DataValidations.AddListValidation(new ExcelAddress(startRow + 1, macaCol, startRow + assetsQry_Export.Count(), macaCol).ToString());
            var micaDataValidtion = astWs.DataValidations.AddListValidation(new ExcelAddress(startRow + 1, micaCol, startRow + assetsQry_Export.Count(), micaCol).ToString());
            var squareDataValidtion = astWs.DataValidations.AddListValidation(new ExcelAddress(startRow + 1, squCol, startRow + assetsQry_Export.Count(), squCol).ToString());
            curr1DataValidtion.ShowErrorMessage =
                statusDataValidtion.ShowErrorMessage =
                macaDataValidtion.ShowErrorMessage =
                micaDataValidtion.ShowErrorMessage =
                squareDataValidtion.ShowErrorMessage = true;
            curr1DataValidtion.ErrorStyle =
                statusDataValidtion.ErrorStyle =
                macaDataValidtion.ErrorStyle =
                micaDataValidtion.ErrorStyle =
                squareDataValidtion.ErrorStyle = ExcelDataValidationWarningStyle.stop;
            curr1DataValidtion.ErrorTitle = "خطأ في قيمة العملة المدخلة";
            statusDataValidtion.ErrorTitle = "خطأ في قيمة حالة الأصل المدخلة";
            macaDataValidtion.ErrorTitle = "خطأ في قيمة الفئة الرئيسية المدخلة";
            micaDataValidtion.ErrorTitle = "خطأ في قيمة الفئة الفرعية المدخلة";
            squareDataValidtion.ErrorTitle = "خطأ في قيمة الساحة المدخلة";
            curr1DataValidtion.Error = "اختر العملة من القائمة";
            statusDataValidtion.Error = "اختر حالة الأصل من القائمة";
            macaDataValidtion.Error = "اختر الفئة الرئيسية من القائمة";
            micaDataValidtion.Error = "اختر الفئة الفرعية من القائمة";
            squareDataValidtion.Error = "اختر الساحة من القائمة";
            foreach (string oneCurr in StaticCode.mainDbContext.CurrencyTbls.Select(cu1 => cu1.CurrencyName))
            {
                curr1DataValidtion.Formula.Values.Add(oneCurr);
            }
            foreach (string oneSta in StaticCode.mainDbContext.StatusTbls.Select(stu1 => stu1.StatusName))
            {
                statusDataValidtion.Formula.Values.Add(oneSta);
            }
            foreach (string oneMaCa in StaticCode.mainDbContext.MainCategoryTbls.Select(maca1 => maca1.MainCategoryName))
            {
                macaDataValidtion.Formula.Values.Add(oneMaCa);
            }
            foreach (string oneMiCa in StaticCode.mainDbContext.MinorCategoryTbls.Select(mica1 => mica1.MinorCategoryName))
            {
                micaDataValidtion.Formula.Values.Add(oneMiCa);
            }
            foreach (string oneSqu in StaticCode.mainDbContext.SquareTbls.Select(squ1 => squ1.SquareName))
            {
                squareDataValidtion.Formula.Values.Add(oneSqu);
            }
            #endregion

            #region Conditional formatting rules
            ExcelAddress _formatRangeAddress = new ExcelAddress($"$B${startRow + 1}:$V${startRow + assetsQry_Export.Count()}");
            string _statement = "=$G8=0";
            var _cond4 = astWs.ConditionalFormatting.AddExpression(_formatRangeAddress);
            _cond4.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            _cond4.Style.Fill.BackgroundColor.Color = Color.FromArgb(180, 198, 230);
            _cond4.Formula = _statement;
            #endregion

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
            e.AlertForm.Location = new Point(500, 400);
        }

        private void searchBySubDepartmentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchBySubDepartmentSearchLookUpEdit.Visible = searchBySubDepartmentCheckBox.Checked;
        }

        private void moveAllAssetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveAllAssetsForm mvAllFrm = new MoveAllAssetsForm(assetsQry);
            mvAllFrm.ShowDialog();
        }

        private void moveAllDropDownButton_Click(object sender, EventArgs e)
        {
            moveAllAssetsToolStripMenuItem_Click(sender, e);
        }
    }
}