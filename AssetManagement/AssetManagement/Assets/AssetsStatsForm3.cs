﻿using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AssetManagement.AssetMngDbDataSet;

namespace AssetManagement.Assets
{
    public partial class AssetsStatsForm3 : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        IQueryable<AssetVw> searchResults = null;

        public AssetsStatsForm3()
        {
            InitializeComponent();
        }

        private void AssetsStatsForm3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.CurrencyTbl' table. You can move, or remove it, as needed.
            this.currencyTblTableAdapter.Fill(this.assetMngDbDataSet.CurrencyTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.MinorCategoryTbl' table. You can move, or remove it, as needed.
            this.minorCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MinorCategoryTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.MainCategoryTbl' table. You can move, or remove it, as needed.
            this.mainCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MainCategoryTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SubDepartmentTbl' table. You can move, or remove it, as needed.
            this.subDepartmentTblTableAdapter.Fill(this.assetMngDbDataSet.SubDepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.DepartmentTbl' table. You can move, or remove it, as needed.
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SectionTbl' table. You can move, or remove it, as needed.
            this.sectionTblTableAdapter.Fill(this.assetMngDbDataSet.SectionTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetStatVw' table. You can move, or remove it, as needed.
            this.assetStatVwTableAdapter.Fill(this.assetMngDbDataSet.AssetStatVw);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetVw' table. You can move, or remove it, as needed.
            this.assetVwTableAdapter.Fill(this.assetMngDbDataSet.AssetVw);
            searchResults = StaticCode.mainDbContext.AssetVws.Select(asv1 => asv1);

            BarSeriesLabel barSeriesLabel2 = chartControl_Bar.SeriesTemplate.Label as BarSeriesLabel;
            barSeriesLabel2.TextPattern = "{S} - {V}";
            chartControl_Bar.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(500, 400);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showStatsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (aggValueBarEditItem.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر خانة قيم العرض", StaticCode.ApplicationTitle);
                return;
            }
            if (groupFieldBarEditItem.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر خانة الحقل التجميعي", StaticCode.ApplicationTitle);
                return;
            }
            if (aggValueBarEditItem.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر خانة حقل القيم", StaticCode.ApplicationTitle);
                return;
            }
            string aggField = "";
            switch (aggValueBarEditItem.EditValue.ToString())
            {
                case "أعداد الأصول":
                    aggField = "العدد";
                    break;
                case "مجموع مبالغ الشراء":
                    aggField = "سعر الشراء";
                    break;
                default:
                    break;
            }
            List<ChartControl> chartsIncluded = new List<ChartControl>()
            {
                chartControl_Bar,
                chartFullStackedBar,
            };
            foreach (ChartControl oneChart in chartsIncluded)
            {
                oneChart.Titles[0].Text = $"{aggValueBarEditItem.EditValue} حسب {groupFieldBarEditItem.EditValue} و {seriesFieldBarEditItem.EditValue.ToString()}";

                oneChart.SeriesDataMember = groupFieldBarEditItem.EditValue.ToString();
                oneChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
                oneChart.SeriesTemplate.ArgumentDataMember = seriesFieldBarEditItem.EditValue.ToString();

                oneChart.SeriesTemplate.QualitativeSummaryOptions.SummaryFunction = $"SUM([{aggField}])";
                oneChart.SeriesTemplate.SeriesDataMember = groupFieldBarEditItem.EditValue.ToString();
                oneChart.SeriesTemplate.ValueDataMembersSerializable = aggField;
                oneChart.RefreshData();
                oneChart.Refresh();
            }
        }

        private void toolbarFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void searchBySectionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchBySectionLookUpEdit.Visible = searchBySectionCheckBox.Checked;
            if (searchBySectionCheckBox.Checked)
            {
                if (searchBySectionLookUpEdit.EditValue == null)
                    return;
                var deptItems = StaticCode.mainDbContext.DepartmentTbls.Where(dpt1 => dpt1.SectionOfDepartment == Convert.ToInt32(searchBySectionLookUpEdit.EditValue));
                searchByDepartmentLookUpEdit.Properties.DataSource = deptItems;
                searchBySubDepartmentLookUpEdit.EditValue = null;
            }
            else
            {
                searchByDepartmentLookUpEdit.Properties.DataSource = StaticCode.mainDbContext.DepartmentTbls;
                this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
            }
        }

        private void searchByDepartmentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchByDepartmentLookUpEdit.Visible = searchByDepartmentCheckBox.Checked;
            if (searchByDepartmentCheckBox.Checked)
            {
                if (searchByDepartmentLookUpEdit.EditValue == null)
                    return;
                var subDeptItems = StaticCode.mainDbContext.SubDepartmentTbls.Where(subd1 => subd1.MainDepartment == Convert.ToInt32(searchByDepartmentLookUpEdit.EditValue));
                searchBySubDepartmentLookUpEdit.Properties.DataSource = subDeptItems;
            }
            else
            {
                if (searchBySectionCheckBox.Checked)
                {
                    if (searchBySectionLookUpEdit.EditValue == null)
                        return;
                    var deptItems = StaticCode.mainDbContext.DepartmentTbls.Where(dpt1 => dpt1.SectionOfDepartment == Convert.ToInt32(searchBySectionLookUpEdit.EditValue));
                    List<int> dptIds = deptItems.Select(dpt2 => dpt2.ID).ToList();
                    var subDeptItems = StaticCode.mainDbContext.SubDepartmentTbls.Where(subd1 => dptIds.Contains(subd1.MainDepartment));
                    int jj = subDeptItems.Count();
                    searchBySubDepartmentLookUpEdit.Properties.DataSource = subDeptItems;
                }
                else
                {
                    searchBySubDepartmentLookUpEdit.Properties.DataSource = StaticCode.mainDbContext.SubDepartmentTbls;
                    this.subDepartmentTblTableAdapter.Fill(this.assetMngDbDataSet.SubDepartmentTbl);
                }
            }
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

        private void searchByCurrencyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchByCurrencyLookUpEdit.Visible = searchByCurrencyCheckBox.Checked;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchAssetDropDownButton_Click(object sender, EventArgs e)
        {
            searchResults = from ast in StaticCode.mainDbContext.AssetVws select ast;
            if (searchBySectionCheckBox.Checked)
            {
                if (searchBySectionLookUpEdit.EditValue == null)
                {
                    mainAlertControl.Show(this, "حدد الدائرة أولاً", StaticCode.ApplicationTitle);
                    return;
                }
                else
                {
                    searchResults = searchResults.Where(astv1 => astv1.الدائرة == searchBySectionLookUpEdit.Text);
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
                    searchResults = searchResults.Where(astv1 => astv1.القسم == searchByDepartmentLookUpEdit.Text);
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
                    searchResults = searchResults.Where(astv1 => astv1.الوحدة == searchBySubDepartmentCheckBox.Text);
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
                    searchResults = searchResults.Where(astv1 => astv1.الفئة_الرئيسية == searchByMainCategoryLookUpEdit.Text);
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
                    searchResults = searchResults.Where(astv1 => astv1.الفئة_الفرعية == searchByMinorCategoryLookUpEdit.Text);
                }
            }
            if (searchByCurrencyCheckBox.Checked)
            {
                if (searchByCurrencyLookUpEdit.EditValue == null)
                {
                    mainAlertControl.Show(this, "حدد عملة سعر الشراء أولاً", StaticCode.ApplicationTitle);
                    return;
                }
                else
                {
                    searchResults = searchResults.Where(astv1 => astv1.عملة_سعر_الشراء == searchByCurrencyLookUpEdit.Text);
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
                searchResults = searchResults.Where(ast => ast.تاريخ_الشراء != null && ast.تاريخ_الشراء >= Convert.ToDateTime(searchByPurchaseDateDateEdit_From.EditValue) && ast.تاريخ_الشراء <= Convert.ToDateTime(searchByPurchaseDateDateEdit_To.EditValue));
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
                searchResults = searchResults.Where(ast => ast.تاريخ_الإدخال != null && ast.تاريخ_الإدخال >= Convert.ToDateTime(searchByInsertionDateDateEdit_From.EditValue) && ast.تاريخ_الإدخال <= Convert.ToDateTime(searchByInsertionDateDateEdit_To.EditValue));
            }

            showStatsBarButtonItem_ItemClick(sender, null);
        }
    }
}