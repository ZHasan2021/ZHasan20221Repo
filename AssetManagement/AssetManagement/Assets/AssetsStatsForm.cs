using DevExpress.DashboardCommon;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
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
    public partial class AssetsStatsForm : Form
    {
        public AssetsStatsForm()
        {
            InitializeComponent();
        }

        private void AssetsStatsForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;

            MsSqlConnectionParameters msSqlParams = new MsSqlConnectionParameters();
            msSqlParams.AuthorizationType = MsSqlAuthorizationType.Windows;
            msSqlParams.ServerName = @"(localdb)\MSSQLLocalDB";
            msSqlParams.DatabaseName = "AssetMngDb";

            DashboardSqlDataSource sqlDataSource = new DashboardSqlDataSource("Data Source 1", msSqlParams);
            SelectQuery selectQuery = SelectQueryFluentBuilder
                .AddTable("AssetTbl")
                .SelectColumns("AssetCode", "AssetDept")
                .Build("Query 1");
            sqlDataSource.Queries.Add(selectQuery);
            sqlDataSource.Fill();
            dashboardDesigner1.Dashboard.DataSources.Add(sqlDataSource);
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
        }
    }
}