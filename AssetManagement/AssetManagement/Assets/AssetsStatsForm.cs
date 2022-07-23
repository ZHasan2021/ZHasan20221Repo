using DevExpress.DashboardCommon;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
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
            this.MinimumSize = this.Size;

            SqlConnection dbConn = new SqlConnection(new Properties.Settings().AssetMngDbConnectionString);
            if (dbConn.State != ConnectionState.Closed)
                dbConn.Close();
            //File.Copy(StaticCode.dbPath, StaticCode.db_logPath, true);
            //File.Copy(StaticCode.db_logPath, StaticCode.db_logPath_stat, true);

            MsSqlCEConnectionParameters msSqlParams = new MsSqlCEConnectionParameters();
            msSqlParams.FileName = StaticCode.dbPath_stat;
            DashboardSqlDataSource sqlDataSource = new DashboardSqlDataSource("Data Source 1", msSqlParams);
            SelectQuery selectQuery = SelectQueryFluentBuilder
                .AddTable("AssetTbl")
                .SelectColumns("AssetCode", "AssetDept")
                .Build("Query 1");
            sqlDataSource.Queries.Add(selectQuery);
            sqlDataSource.Fill();
            dashboardDesigner1.Dashboard.DataSources.Add(sqlDataSource);
                dbConn.Open();
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
        }
    }
}