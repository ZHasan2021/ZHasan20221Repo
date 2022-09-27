using DevExpress.DashboardCommon;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AssetManagement.AssetMngDbDataSet;

namespace AssetManagement.Assets
{
    public partial class AssetsStatsForm : Form
    {
        IQueryable<AssetTbl> assetsQry = null;
        public AssetsStatsForm()
        {
            InitializeComponent();
        }

        private void AssetsStatsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.MinorCategoryTbl' table. You can move, or remove it, as needed.
            this.minorCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MinorCategoryTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.MinorCategoryVw' table. You can move, or remove it, as needed.
            this.minorCategoryVwTableAdapter.Fill(this.assetMngDbDataSet.MinorCategoryVw);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.MainCategoryTbl' table. You can move, or remove it, as needed.
            this.mainCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MainCategoryTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SubDepartmentTbl' table. You can move, or remove it, as needed.
            this.subDepartmentTblTableAdapter.Fill(this.assetMngDbDataSet.SubDepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.DepartmentTbl' table. You can move, or remove it, as needed.
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SectionTbl' table. You can move, or remove it, as needed.
            this.sectionTblTableAdapter.Fill(this.assetMngDbDataSet.SectionTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetTbl' table. You can move, or remove it, as needed.
            this.assetTblTableAdapter.Fill(this.assetMngDbDataSet.AssetTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetVw' table. You can move, or remove it, as needed.
            this.assetVwTableAdapter.Fill(this.assetMngDbDataSet.AssetVw);
            this.MinimumSize = this.Size;
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(500, 400);
        }

        private void searchBySectionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchBySectionLookUpEdit.Visible = searchBySectionCheckBox.Checked;
        }

        private void searchByDepartmentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchByDepartmentLookUpEdit.Visible = searchByDepartmentCheckBox.Checked;
        }

        private void searchBySubDepartmentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchBySubDepartmentLookUpEdit.Visible = searchBySubDepartmentCheckBox.Checked;
        }

        private void searchByMainCategoryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchByMainCategoryLookUpEdit.Visible = searchByMainCategoryCheckBox.Checked;
        }

        private void searchByMinorCategoryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchByMinorCategoryLookUpEdit.Visible = searchByMinorCategoryCheckBox.Checked;
        }

        private void searchByPurchaseDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchByPurchaseDatePanel.Visible = searchByPurchaseDateCheckBox.Checked;
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
            mainChartControl.Visible = false;
            assetsQry = from ast in StaticCode.mainDbContext.AssetTbls select ast;
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
            if (soldAssetsCheckBox.Checked)
            {
                assetsQry = assetsQry.Where(ast => ast.IsSold == true);
            }
            if (outOfWorkCheckBox.Checked)
            {
                assetsQry = assetsQry.Where(ast => ast.IsOutOfWork == true);
            }

            mainChartControl.Visible = assetsQry.Count() > 0;
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
            }
        }

        private void aggregateStatTypeBarEditItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aggregateStatTypeBarEditItem_EditValueChanged(object sender, EventArgs e)
        {
            if (aggregateStatTypeBarEditItem.EditValue == null || byFieldBarEditItem.EditValue == null) return;
            Series series1 = mainChartControl.Series[0];
            switch (aggregateStatTypeBarEditItem.EditValue.ToString())
            {
                case "عدد الأصول":
                    switch (byFieldBarEditItem.EditValue.ToString())
                    {
                        case "القسم":
                            var ggg = series1.View.DiagramType;
                            series1.ArgumentDataMember = "القسم";
                            series1.QualitativeSummaryOptions.SummaryFunction = "COUNT()";
                            break;
                        case "الفئة الرئيسية":
                            series1.ArgumentDataMember = "الفئة الرئيسية";
                            series1.QualitativeSummaryOptions.SummaryFunction = "COUNT()";
                            break;
                        case "الفئة الفرعية":
                            series1.ArgumentDataMember = "الفئة الفرعية";
                            series1.QualitativeSummaryOptions.SummaryFunction = "COUNT()";
                            break;
                        default:
                            break;
                    }
                    break;
                case "مجموع مبالغ الشراء":
                    switch (byFieldBarEditItem.EditValue.ToString())
                    {
                        case "القسم":
                            series1.ArgumentDataMember = "القسم";
                            series1.QualitativeSummaryOptions.SummaryFunction = "SUM([سعر الشراء])";
                            break;
                        case "الفئة الرئيسية":
                            series1.ArgumentDataMember = "الفئة الرئيسية";
                            series1.QualitativeSummaryOptions.SummaryFunction = "SUM([سعر الشراء])";
                            break;
                        case "الفئة الفرعية":
                            series1.ArgumentDataMember = "الفئة الفرعية";
                            series1.QualitativeSummaryOptions.SummaryFunction = "SUM([سعر الشراء])";
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}