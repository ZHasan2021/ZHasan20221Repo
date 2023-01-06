using DevExpress.XtraCharts;
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
    public partial class AssetsStatsForm3 : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        IQueryable<AssetVw> searchResults = null;
        List<string> groupList = new List<string>();
        List<string> stackList = new List<string>();
        DataTable oneFieldDataSource = new DataTable();
        DataTable twoFieldsDataSource = new DataTable();

        public AssetsStatsForm3()
        {
            InitializeComponent();
        }

        void PrepareListsForDataSources(List<AssetVw> assetsToView, string groupField, string seriesField, string aggValue)
        {
            groupList.Clear();
            stackList.Clear();
            switch (groupField)
            {
                case "قديم أو جديد":
                    groupList.Add("قديم");
                    groupList.Add("جديد");
                    break;
                case "الدائرة":
                    groupList = assetsToView.Select(asvg1 => asvg1.الدائرة).Distinct().ToList();
                    break;
                case "القسم":
                    groupList = assetsToView.Select(asvg1 => asvg1.القسم).Distinct().ToList();
                    break;
                case "الوحدة":
                    groupList = assetsToView.Select(asvg1 => asvg1.الوحدة).Distinct().ToList();
                    break;
                case "الفئة الرئيسية":
                    groupList = assetsToView.Select(asvg1 => asvg1.الفئة_الرئيسية).Distinct().ToList();
                    break;
                case "الفئة الفرعية":
                    groupList = assetsToView.Select(asvg1 => asvg1.الفئة_الفرعية).Distinct().ToList();
                    break;
                case "حالة الأصل الآنية":
                    groupList = assetsToView.Select(asvg1 => asvg1.حالة_الأصل_الآنية).Distinct().ToList();
                    break;
                case "عملة الشراء":
                    groupList = assetsToView.Select(asvg1 => asvg1.عملة_سعر_الشراء).Distinct().ToList();
                    break;
                case "الساحة":
                    groupList = assetsToView.Select(asvg1 => asvg1.الساحة).Distinct().ToList();
                    break;
                case "سنة الشراء":
                    groupList = assetsToView.Where(asvg1 => asvg1.تاريخ_الشراء != null).Select(asvd1 => Convert.ToDateTime(asvd1.تاريخ_الشراء).Year.ToString()).Distinct().ToList();
                    break;
                case "سنة إدراج الأصل في السجلات":
                    groupList = assetsToView.Where(asvg1 => asvg1.تاريخ_الإدخال != null).Select(asvd1 => Convert.ToDateTime(asvd1.تاريخ_الإدخال).Year.ToString()).Distinct().ToList();
                    break;
                default:
                    break;
            }
            switch (seriesField)
            {
                case "قديم أو جديد":
                    stackList.Add("قديم");
                    stackList.Add("جديد");
                    break;
                case "الدائرة":
                    stackList = assetsToView.Select(asvs1 => asvs1.الدائرة).Distinct().ToList();
                    break;
                case "القسم":
                    stackList = assetsToView.Select(asvs1 => asvs1.القسم).Distinct().ToList();
                    break;
                case "الوحدة":
                    stackList = assetsToView.Select(asvs1 => asvs1.الوحدة).Distinct().ToList();
                    break;
                case "الفئة الرئيسية":
                    stackList = assetsToView.Select(asvs1 => asvs1.الفئة_الرئيسية).Distinct().ToList();
                    break;
                case "الفئة الفرعية":
                    stackList = assetsToView.Select(asvs1 => asvs1.الفئة_الفرعية).Distinct().ToList();
                    break;
                case "حالة الأصل الآنية":
                    stackList = assetsToView.Select(asvs1 => asvs1.حالة_الأصل_الآنية).Distinct().ToList();
                    break;
                case "عملة الشراء":
                    stackList = assetsToView.Select(asvs1 => asvs1.عملة_سعر_الشراء).Distinct().ToList();
                    break;
                case "الساحة":
                    stackList = assetsToView.Select(asvs1 => asvs1.الساحة).Distinct().ToList();
                    break;
                case "سنة الشراء":
                    stackList = assetsToView.Where(asvs1 => asvs1.تاريخ_الشراء != null).Select(asvd1 => Convert.ToDateTime(asvd1.تاريخ_الشراء).Year.ToString()).Distinct().ToList();
                    break;
                case "سنة إدراج الأصل في السجلات":
                    stackList = assetsToView.Where(asvs1 => asvs1.تاريخ_الإدخال != null).Select(asvd1 => Convert.ToDateTime(asvd1.تاريخ_الإدخال).Year.ToString()).Distinct().ToList();
                    break;
                default:
                    break;
            }

            oneFieldDataSource.Columns.Clear();
            twoFieldsDataSource.Columns.Clear();
            oneFieldDataSource.Columns.AddRange(new DataColumn[] { new DataColumn(groupField, typeof(string)), new DataColumn(seriesField, typeof(string)), new DataColumn(aggValue, typeof(double)) });
            twoFieldsDataSource.Columns.AddRange(new DataColumn[] { new DataColumn(groupField, typeof(string)), new DataColumn(seriesField, typeof(string)), new DataColumn(aggValue, typeof(double)) });

            oneFieldDataSource.Rows.Clear();
            twoFieldsDataSource.Rows.Clear();
            foreach (string oneFItem in groupList)
            {
                Application.DoEvents();

                List<AssetVw> assetsOccur = new List<AssetVw> ();
                switch (groupField)
                {
                    case "قديم أو جديد":
                        assetsOccur = assetsToView.Where(asv1 => StaticCode.mainDbContext.AssetTbls.Single(ast1 => ast1.ID == asv1.معرف_الأصل).IsOldOrNewAsset == oneFItem).ToList();
                        break;
                    case "الدائرة":
                        assetsOccur = assetsToView.Where(asv1 => asv1.الدائرة == oneFItem).ToList();
                        break;
                    case "القسم":
                        assetsOccur = assetsToView.Where(asv1 => asv1.القسم == oneFItem).ToList();
                        break;
                    case "الوحدة":
                        assetsOccur = assetsToView.Where(asv1 => asv1.الوحدة == oneFItem).ToList();
                        break;
                    case "الفئة الرئيسية":
                        assetsOccur = assetsToView.Where(asv1 => asv1.الفئة_الرئيسية == oneFItem).ToList();
                        break;
                    case "الفئة الفرعية":
                        assetsOccur = assetsToView.Where(asv1 => asv1.الفئة_الفرعية == oneFItem).ToList();
                        break;
                    case "حالة الأصل الآنية":
                        assetsOccur = assetsToView.Where(asv1 => asv1.حالة_الأصل_الآنية == oneFItem).ToList();
                        break;
                    case "عملة الشراء":
                        assetsOccur = assetsToView.Where(asv1 => asv1.عملة_سعر_الشراء == oneFItem).ToList();
                        break;
                    case "الساحة":
                        assetsOccur = assetsToView.Where(asv1 => asv1.الساحة == oneFItem).ToList();
                        break;
                    case "سنة الشراء":
                        assetsOccur = assetsToView.Where(asv1 => Convert.ToDateTime(asv1.تاريخ_الشراء).Year.ToString() == oneFItem).ToList();
                        break;
                    case "سنة إدراج الأصل في السجلات":
                        assetsOccur = assetsToView.Where(asv1 => Convert.ToDateTime(asv1.تاريخ_الإدخال).Year.ToString() == oneFItem).ToList();
                        break;
                    default:
                        break;
                }
                foreach (string oneSItem in stackList)
                {
                    Application.DoEvents();

                List<AssetVw> assetsOccur2 = new List<AssetVw> ();
                    switch (seriesField)
                    {
                        case "قديم أو جديد":
                            assetsOccur = assetsOccur.Where(asv1 => StaticCode.mainDbContext.AssetTbls.Single(ast1 => ast1.ID == asv1.معرف_الأصل).IsOldOrNewAsset == oneSItem).ToList();
                            break;
                        case "الدائرة":
                            assetsOccur2 = assetsOccur.Where(asv1 => asv1.الدائرة == oneSItem).ToList();
                            break;
                        case "القسم":
                            assetsOccur2 = assetsOccur.Where(asv1 => asv1.القسم == oneSItem).ToList();
                            break;
                        case "الوحدة":
                            assetsOccur2 = assetsOccur.Where(asv1 => asv1.الوحدة == oneSItem).ToList();
                            break;
                        case "الفئة الرئيسية":
                            assetsOccur2 = assetsOccur.Where(asv1 => asv1.الفئة_الرئيسية == oneSItem).ToList();
                            break;
                        case "الفئة الفرعية":
                            assetsOccur2 = assetsOccur.Where(asv1 => asv1.الفئة_الفرعية == oneSItem).ToList();
                            break;
                        case "حالة الأصل الآنية":
                            assetsOccur2 = assetsOccur.Where(asv1 => asv1.حالة_الأصل_الآنية == oneSItem).ToList();
                            break;
                        case "عملة الشراء":
                            assetsOccur2 = assetsOccur.Where(asv1 => asv1.عملة_سعر_الشراء == oneSItem).ToList();
                            break;
                        case "الساحة":
                            assetsOccur2 = assetsOccur.Where(asv1 => asv1.الساحة == oneSItem).ToList();
                            break;
                        case "سنة الشراء":
                            assetsOccur2 = assetsOccur.Where(asv1 => Convert.ToDateTime(asv1.تاريخ_الشراء).Year.ToString() == oneSItem).ToList();
                            break;
                        case "سنة إدراج الأصل في السجلات":
                            assetsOccur2 = assetsOccur.Where(asv1 => Convert.ToDateTime(asv1.تاريخ_الإدخال).Year.ToString() == oneSItem).ToList();
                            break;
                        default:
                            break;
                    }

                    int countOfAssets = 0;
                    double sumOfPrchs = 0;
                    if (!assetsOccur2.Any())
                        continue;
                    countOfAssets = assetsOccur2.Sum(asvc1 => asvc1.العدد);
                    sumOfPrchs = assetsOccur2.Where(asvp1 => asvp1.سعر_الشراء != null).Sum(asvp2 => Convert.ToDouble(asvp2.سعر_الشراء));
                    switch (aggValue)
                    {
                        case "أعداد الأصول":
                            oneFieldDataSource.Rows.Add(oneFItem, oneSItem, countOfAssets);
                            twoFieldsDataSource.Rows.Add(oneFItem, oneSItem, countOfAssets);
                            break;
                        case "مجموع مبالغ الشراء":
                            oneFieldDataSource.Rows.Add(oneFItem, oneSItem, sumOfPrchs);
                            twoFieldsDataSource.Rows.Add(oneFItem, oneSItem, sumOfPrchs);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void AssetsStatsForm3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetVw' table. You can move, or remove it, as needed.
            this.assetVwTableAdapter.Fill(this.assetMngDbDataSet.AssetVw);
            searchResults = StaticCode.mainDbContext.AssetVws.Select(asv1 => asv1);
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
            if (addSeriesBarCheckItem.Checked)
            {
                if (seriesFieldBarEditItem.EditValue == null)
                {
                    mainAlertControl.Show(this, "اختر خانة الحقل التراكمي", StaticCode.ApplicationTitle);
                    return;
                }
                if (groupFieldBarEditItem.EditValue.ToString() == seriesFieldBarEditItem.EditValue.ToString())
                {
                    mainAlertControl.Show(this, "الحقل التجميعي لا يجب أن يكون نفسه الحقل التراكمي", StaticCode.ApplicationTitle);
                    return;
                }
            }
            PrepareListsForDataSources(searchResults.ToList(), groupFieldBarEditItem.EditValue.ToString(), ((addSeriesBarCheckItem.Checked) ? seriesFieldBarEditItem.EditValue.ToString() : ""), aggValueBarEditItem.EditValue.ToString());

            List<ChartControl> chartsIncluded = new List<ChartControl>()
            {
                chartBar,
                chartFullStackedBar,
            };
            foreach (ChartControl oneChart in chartsIncluded)
            {
                oneChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
                oneChart.SeriesDataMember = seriesFieldBarEditItem.EditValue.ToString();
                oneChart.SeriesTemplate.ArgumentDataMember = groupFieldBarEditItem.EditValue.ToString();
                oneChart.SeriesTemplate.SeriesDataMember = seriesFieldBarEditItem.EditValue.ToString();
                oneChart.SeriesTemplate.ValueDataMembersSerializable = aggValueBarEditItem.EditValue.ToString();
                oneChart.SeriesTemplate.CrosshairLabelPattern = "{S}: {V:0.0}";
                //fullStackedBarSeriesLabel1.TextPattern = "{VP:P0}";

                oneChart.Titles[0].Text = $"{aggValueBarEditItem.EditValue} حسب {groupFieldBarEditItem.EditValue}{((addSeriesBarCheckItem.Checked) ? " و " + seriesFieldBarEditItem.EditValue.ToString() : "")}";

                XYDiagram xyDiagram1 = (oneChart.Diagram as XYDiagram);
                xyDiagram1.AxisX.Title.Text = seriesFieldBarEditItem.EditValue.ToString();
                xyDiagram1.AxisY.NumericScaleOptions.AutoGrid = true;
                xyDiagram1.AxisY.Title.Text = aggValueBarEditItem.EditValue.ToString();
                xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
                //xyDiagram1.Rotated = true;
            }

            FullStackedBarSeriesLabel fulllStackedBarSeriesLabel1 = chartFullStackedBar.SeriesTemplate.Label as FullStackedBarSeriesLabel;
            fulllStackedBarSeriesLabel1.TextPattern = "{S}: {V:0,,.0}";
            chartFullStackedBar.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;

            chartFullStackedBar.DataSource = twoFieldsDataSource;
            chartBar.DataSource = twoFieldsDataSource;
        }

        private void addSeriesBarCheckItem_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            seriesFieldBarEditItem.Visibility = (addSeriesBarCheckItem.Checked) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void toolbarFormControl1_Click(object sender, EventArgs e)
        {

        }
    }
}