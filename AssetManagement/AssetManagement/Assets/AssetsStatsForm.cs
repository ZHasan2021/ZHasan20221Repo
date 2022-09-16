﻿using DevExpress.DashboardCommon;
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

namespace AssetManagement.Assets
{
    public partial class AssetsStatsForm : Form
    {
        public AssetsStatsForm()
        {
            InitializeComponent();
        }

        private void AssetsStatsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetTbl' table. You can move, or remove it, as needed.
            this.assetTblTableAdapter.Fill(this.assetMngDbDataSet.AssetTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetVw' table. You can move, or remove it, as needed.
            this.assetVwTableAdapter.Fill(this.assetMngDbDataSet.AssetVw);
            this.MinimumSize = this.Size;
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
        }

        private void ViewStatInChartControl(object sender, EventArgs e)
        {
            Series series1 = mainChartControl.Series[0];
            switch (aggregateStatTypeComboBox.Text)
            {
                case "عدد الأصول":
                    switch (byFieldComboBox.Text)
                    {
                        case "القسم":
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
                    switch (byFieldComboBox.Text)
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