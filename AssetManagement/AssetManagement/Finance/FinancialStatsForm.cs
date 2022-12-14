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
    public partial class FinancialStatsForm : Form
    {
        IQueryable<FinancialItemVw> fiItemsQry = null;
        public FinancialStatsForm()
        {
            InitializeComponent();
        }

        private void FinancialStatsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.OutgoingTypeTbl' table. You can move, or remove it, as needed.
            this.outgoingTypeTblTableAdapter.Fill(this.assetMngDbDataSet.OutgoingTypeTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.IncomingTypeTbl' table. You can move, or remove it, as needed.
            this.incomingTypeTblTableAdapter.Fill(this.assetMngDbDataSet.IncomingTypeTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.FinancialItemCategoryTbl' table. You can move, or remove it, as needed.
            this.financialItemCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemCategoryTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.FinancialItemVw' table. You can move, or remove it, as needed.
            this.financialItemVwTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemVw);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.CurrencyTbl' table. You can move, or remove it, as needed.
            this.currencyTblTableAdapter.Fill(this.assetMngDbDataSet.CurrencyTbl);
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
            e.AlertForm.Location = new Point(500, 400);
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

        private void searchByPurchaseDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchByPurchaseDatePanel.Visible = searchByPurchaseDateCheckBox.Checked;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchAssetDropDownButton_Click(object sender, EventArgs e)
        {
            mainChartControl.Visible = false;
            fiItemsQry = from fiv in StaticCode.mainDbContext.FinancialItemVws select fiv;
            if (searchBySectionCheckBox.Checked)
            {
                if (searchBySectionLookUpEdit.EditValue == null)
                {
                    mainAlertControl.Show(this, "حدد الدائرة أولاً", StaticCode.ApplicationTitle);
                    return;
                }
                else
                {
                    fiItemsQry = fiItemsQry.Where(fiv1 => fiv1.الدائرة == searchBySectionLookUpEdit.Text);
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
                    fiItemsQry = fiItemsQry.Where(fiv1 => fiv1.القسم == searchByDepartmentLookUpEdit.Text);
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
                    fiItemsQry = fiItemsQry.Where(fiv1 => fiv1.الوحدة == searchBySubDepartmentCheckBox.Text);
                }
            }
            if (searchByMainCategoryCheckBox.Checked)
            {
                if (searchByMainCategoryLookUpEdit.EditValue == null)
                {
                    mainAlertControl.Show(this, "حدد اسم البند المالي أولاً", StaticCode.ApplicationTitle);
                    return;
                }
                else
                {
                    fiItemsQry = fiItemsQry.Where(fiv1 => fiv1.اسم_البند_المالي == searchByMainCategoryLookUpEdit.Text);
                }
            }
            if (searchByCurrencyCheckBox.Checked)
            {
                if (searchByCurrencyLookUpEdit.EditValue == null)
                {
                    mainAlertControl.Show(this, "حدد العملة أولاً", StaticCode.ApplicationTitle);
                    return;
                }
                else
                {
                    fiItemsQry = fiItemsQry.Where(astv1 => astv1.العملة == searchByCurrencyLookUpEdit.Text);
                }
            }
            if (searchByPurchaseDateCheckBox.Checked)
            {
                if (searchByPurchaseDateDateEdit_From.EditValue == null)
                {
                    mainAlertControl.Show(this, "اكتب بداية تاريخ السجل المالي أولاً", StaticCode.ApplicationTitle);
                    return;
                }
                if (searchByPurchaseDateDateEdit_To.EditValue == null)
                {
                    mainAlertControl.Show(this, "اكتب نهاية تاريخ السجل المالي أولاً", StaticCode.ApplicationTitle);
                    return;
                }
                if (Convert.ToDateTime(searchByPurchaseDateDateEdit_From.EditValue) > Convert.ToDateTime(searchByPurchaseDateDateEdit_To.EditValue))
                {
                    mainAlertControl.Show(this, "تاريخ البداية أحدث من تاريخ النهاية", StaticCode.ApplicationTitle);
                    return;
                }
                fiItemsQry = fiItemsQry.Where(ast => ast.تاريخ_تحرير_السجل != null && ast.تاريخ_تحرير_السجل >= Convert.ToDateTime(searchByPurchaseDateDateEdit_From.EditValue) && ast.تاريخ_تحرير_السجل <= Convert.ToDateTime(searchByPurchaseDateDateEdit_To.EditValue));
            }

            mainChartControl.Visible = fiItemsQry.Count() > 0;
            if (fiItemsQry.Count() == 0)
            {
                mainAlertControl.Show(this, "لا توجد نتائج", StaticCode.ApplicationTitle);
            }
            else
            {
                List<int> IDsIncluded = fiItemsQry.Select(as1 => as1.معرف_السجل_المالي).ToList();
                string plusQry = "";
                foreach (int oneID in IDsIncluded)
                    plusQry += oneID + ", ";
                plusQry = $" WHERE [معرف السجل المالي] IN ({ plusQry.Trim().Trim(',').Trim()});";
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
                        continue;
                    }
                }
                this.financialItemVwTableAdapter.FillByQuery(customVw, plusQry);
            }
        }

        private void aggregateStatTypeBarEditItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void aggregateStatTypeBarEditItem_EditValueChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewStatsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (byFieldBarEditItem.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر حقل الإحصائية أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (secondFieldBarCheckItem.Checked && byField2BarEditItem.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر حقل الإحصائية الثاني أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (aggregateStatTypeBarEditItem.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر الدالة التجميعية أولاً", StaticCode.ApplicationTitle);
                return;
            }
            mainChartControl.Series.Clear();

            if (secondFieldBarCheckItem.Checked)
            {
                mainChartControl.SeriesTemplate.ChangeView(ViewType.StackedBar);
                mainChartControl.SeriesTemplate.SeriesDataMember = byFieldBarEditItem.EditValue.ToString();
                //mainChartControl.SeriesTemplate.ArgumentDataMember = byFieldBarEditItem.EditValue.ToString();
                mainChartControl.SeriesTemplate.SetDataMembers(byField2BarEditItem.EditValue.ToString(), aggregateStatTypeBarEditItem.EditValue.ToString().Replace("عدد الأصول", "العدد").Replace("مجموع مبالغ الشراء", "سعر الشراء"));

                // Enable series point labels, specify their text pattern and position:
                mainChartControl.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                mainChartControl.SeriesTemplate.Label.TextPattern = "{A}:{G}";
                ((BarSeriesLabel)mainChartControl.SeriesTemplate.Label).Position = BarSeriesLabelPosition.Center;

                // Customize series view settings (for example, bar width):
                StackedBarSeriesView view = (StackedBarSeriesView)mainChartControl.SeriesTemplate.View;
                view.AggregateFunction = SeriesAggregateFunction.Sum;
                switch (aggregateStatTypeBarEditItem.EditValue.ToString())
                {
                    case "عدد السجلات المالية":
                        view.AggregateFunction = SeriesAggregateFunction.Count;
                        break;
                    case "مجموع المبالغ":
                        view.AggregateFunction = SeriesAggregateFunction.Sum;
                        break;
                    default:
                        break;
                }
                view.BarWidth = 0.7;

                // Disable minor tickmarks on the x-axis:
                XYDiagram diagram = (XYDiagram)mainChartControl.Diagram;
                diagram.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
                diagram.AxisX.Title.Text = byField2BarEditItem.EditValue.ToString();
                diagram.AxisX.Tickmarks.MinorVisible = false;
                diagram.Rotated = true;

                // Specify legend settings:
                mainChartControl.Legend.MarkerMode = LegendMarkerMode.CheckBoxAndMarker;
                mainChartControl.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center;
                mainChartControl.Legend.AlignmentVertical = LegendAlignmentVertical.TopOutside;
            }
            else
            {
                mainChartControl.SeriesTemplate.ChangeView(ViewType.Bar);
                mainChartControl.SeriesTemplate.SeriesDataMember = byFieldBarEditItem.EditValue.ToString();
                //mainChartControl.SeriesTemplate.ArgumentDataMember = byFieldBarEditItem.EditValue.ToString();
                mainChartControl.SeriesTemplate.ValueDataMembers.AddRange(aggregateStatTypeBarEditItem.EditValue.ToString().Replace("عدد الأصول", "العدد").Replace("مجموع مبالغ الشراء", "سعر الشراء"));
                //mainChartControl.SeriesTemplate.SetDataMembers(byField2BarEditItem.EditValue.ToString(), "العدد");

                // Enable series point labels, specify their text pattern and position:
                mainChartControl.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                mainChartControl.SeriesTemplate.Label.TextPattern = ((aggregateStatTypeBarEditItem.EditValue.ToString() == "عدد الأصول") ? "" : "$") + "{A}:{V}";
                ((BarSeriesLabel)mainChartControl.SeriesTemplate.Label).Position = BarSeriesLabelPosition.Center;

                // Customize series view settings (for example, bar width):
                BarSeriesView view = (BarSeriesView)mainChartControl.SeriesTemplate.View;
                view.AggregateFunction = SeriesAggregateFunction.Sum;
                switch(aggregateStatTypeBarEditItem.EditValue.ToString())
                {
                    case "عدد السجلات المالية":
                view.AggregateFunction = SeriesAggregateFunction.Count;
                        break;
                    case "مجموع المبالغ":
                view.AggregateFunction = SeriesAggregateFunction.Sum;
                        break;
                    default:
                        break;
                }
                view.BarWidth = 0.7;

                // Disable minor tickmarks on the x-axis:
                XYDiagram diagram = (XYDiagram)mainChartControl.Diagram;
                diagram.AxisX.Tickmarks.MinorVisible = false;
                diagram.Rotated = true;

                // Specify legend settings:
                mainChartControl.Legend.MarkerMode = LegendMarkerMode.CheckBoxAndMarker;
                mainChartControl.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center;
                mainChartControl.Legend.AlignmentVertical = LegendAlignmentVertical.TopOutside;
            }

            //Series series1 = mainChartControl.Series[0];
            //switch (aggregateStatTypeBarEditItem.EditValue.ToString())
            //{
            //    case "عدد الأصول":
            //        switch (byFieldBarEditItem.EditValue.ToString())
            //        {
            //            case "القسم":
            //                series1.ArgumentDataMember = "القسم";
            //                series1.QualitativeSummaryOptions.SummaryFunction = "SUM([العدد])";
            //                series1.Visible = true;
            //                break;
            //            case "الفئة الرئيسية":
            //                series1.ArgumentDataMember = "الفئة الرئيسية";
            //                series1.QualitativeSummaryOptions.SummaryFunction = "COUNT()";
            //                series1.Visible = true;
            //                break;
            //            case "الفئة الفرعية":
            //                series1.ArgumentDataMember = "الفئة الفرعية";
            //                series1.QualitativeSummaryOptions.SummaryFunction = "COUNT()";
            //                series1.Visible = true;
            //                break;
            //            case "الفئة الرئيسية وحالة الأصل":
            //                mainChartControl.SeriesTemplate.ChangeView(ViewType.StackedBar);
            //                mainChartControl.SeriesTemplate.SeriesDataMember = "الفئة الرئيسية";
            //                mainChartControl.SeriesTemplate.SetDataMembers("حالة الأصل الآنية", "العدد");

            //                // Enable series point labels, specify their text pattern and position:
            //                mainChartControl.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            //                mainChartControl.SeriesTemplate.Label.TextPattern = "${V}";
            //                ((BarSeriesLabel)mainChartControl.SeriesTemplate.Label).Position = BarSeriesLabelPosition.Center;

            //                // Customize series view settings (for example, bar width):
            //                StackedBarSeriesView view = (StackedBarSeriesView)mainChartControl.SeriesTemplate.View;
            //                view.BarWidth = 0.8;

            //                // Disable minor tickmarks on the x-axis:
            //                XYDiagram diagram = (XYDiagram)mainChartControl.Diagram;
            //                diagram.AxisX.Tickmarks.MinorVisible = false;

            //                // Specify legend settings:
            //                mainChartControl.Legend.MarkerMode = LegendMarkerMode.CheckBoxAndMarker;
            //                mainChartControl.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center;
            //                mainChartControl.Legend.AlignmentVertical = LegendAlignmentVertical.TopOutside;

            //                series1.Visible = false;
            //                break;
            //            default:
            //                break;
            //        }
            //        break;
            //case "مجموع مبالغ الشراء":
            //    switch (byFieldBarEditItem.EditValue.ToString())
            //    {
            //        case "القسم":
            //            series1.ArgumentDataMember = "القسم";
            //            series1.QualitativeSummaryOptions.SummaryFunction = "SUM([سعر الشراء])";
            //            series1.Visible = true;
            //            series2.Visible = false;
            //            break;
            //        case "الفئة الرئيسية":
            //            series1.ArgumentDataMember = "الفئة الرئيسية";
            //            series1.QualitativeSummaryOptions.SummaryFunction = "SUM([سعر الشراء])";
            //            series1.Visible = true;
            //            series2.Visible = false;
            //            break;
            //        case "الفئة الفرعية":
            //            series1.ArgumentDataMember = "الفئة الفرعية";
            //            series1.QualitativeSummaryOptions.SummaryFunction = "SUM([سعر الشراء])";
            //            series1.Visible = true;
            //            series2.Visible = false;
            //            break;
            //        case "الفئة الرئيسية وحالة الأصل":
            //            series2.ArgumentDataMember = "الفئة الرئيسية";
            //            series2.ColorDataMember = "حالة الأصل الآنية";
            //            series2.QualitativeSummaryOptions.SummaryFunction = "SUM([سعر الشراء])";
            //            series1.Visible = false;
            //            series2.Visible = true;
            //            break;
            //        default:
            //            break;
            //    }
            //    break;
            //    default:
            //        break;
            //}

            mainChartControl.Visible = true;
            mainChartControl.Titles.Clear();
            ChartTitle mainTitle = new ChartTitle() { Alignment = StringAlignment.Center, Font = new Font("Sakkal Majalla", 16.0F), Text = $"إجمالي {aggregateStatTypeBarEditItem.EditValue.ToString()} حسب {byFieldBarEditItem.EditValue.ToString()}" };
            mainChartControl.Titles.Add(mainTitle);
        }

        private void searchBySectionLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void searchByDepartmentLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void secondFieldBarCheckItem_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            byField2BarEditItem.Visibility = (secondFieldBarCheckItem.Checked) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void searchByCurrencyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchByCurrencyLookUpEdit.Visible = searchByCurrencyCheckBox.Checked;
        }
    }
}