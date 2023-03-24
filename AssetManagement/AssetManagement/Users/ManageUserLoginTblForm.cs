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

namespace AssetManagement.Users
{
    public partial class ManageUserLoginTblForm : Form
    {
        int currRow = -1;

        public ManageUserLoginTblForm()
        {
            InitializeComponent();
        }

        private void ManageUserLoginTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.UserLoginTbl' table. You can move, or remove it, as needed.
            this.userLoginTblTableAdapter.Fill(this.assetMngDbDataSet.UserLoginTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.UserTbl' table. You can move, or remove it, as needed.
            this.userTblTableAdapter.Fill(this.assetMngDbDataSet.UserTbl);

            this.MinimumSize = this.Size;
        }

        private void userLoginTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                userLoginTblBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(this.assetMngDbDataSet);

                StaticCode.mainConn.Close();
                StaticCode.mainConn.Open();

                mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
            }
            catch (SqlException)
            {
                mainAlertControl.Show(this, "لم يتم الحفظ", StaticCode.ApplicationTitle);
                return;
            }
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 150);
            e.AlertForm.Location = new Point(200, 200);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AddNewUserForm usrFrm = new AddNewUserForm();
            usrFrm.ShowDialog();
            this.userTblTableAdapter.Fill(this.assetMngDbDataSet.UserTbl);
        }

        private void userTblBindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            if (currRow < 0)
            {
                mainAlertControl.Show(this, "اختر سطراً كاملاً ليتم تعديل بياناته", StaticCode.ApplicationTitle);
                return;
            }
            try
            {
                int currAssetID = Convert.ToInt32(userLoginGridView.GetRowCellValue(currRow, colID));
                AddNewUserForm usrFrm = new AddNewUserForm(currAssetID);
                usrFrm.ShowDialog();
                currRow = 0;
                this.userTblTableAdapter.Fill(this.assetMngDbDataSet.UserTbl);
            }
            catch
            {
                mainAlertControl.Show(this, "اختر سجلاً واحداً ليتم تعديل بياناته", StaticCode.ApplicationTitle);
            }
        }

        private void userGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            currRow = e.RowHandle;
        }

        private void userGridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            currRow = e.RowHandle;
        }

        private void userLoginTblBindingNavigatorExportToExcelItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog exportDlg = new SaveFileDialog() { Filter = "Excel workbook (2007-2022)(*.xlsx)|*.xlsx", FileName = "نشاطات المستخدمين" };
            if (exportDlg.ShowDialog() != DialogResult.OK)
                return;
            userLoginGridControl.ExportToXlsx(exportDlg.FileName, new DevExpress.XtraPrinting.XlsxExportOptions() { ShowGridLines = false, SheetName = "جدول نشاطات المستخدمين" });
            mainAlertControl.Show(this, "تم تصدير بيانات نشاطات المستخدمين إلى اكسل", StaticCode.ApplicationTitle);
        }

        private void userLoginTblBindingNavigatorSaveLogItem_Click(object sender, EventArgs e)
        {
            if (currRow < 0)
            {
                mainAlertControl.Show(this, "اختر سطراً كاملاً ليتم تعديل بياناته", StaticCode.ApplicationTitle);
                return;
            }
            try
            {
                string currUserName = userLoginGridView.GetRowCellDisplayText(currRow, colUserID).ToString();
                string currLoginTime = userLoginGridView.GetRowCellDisplayText(currRow, colLoggedInAt).ToString();
                string currLogoutTime = userLoginGridView.GetRowCellDisplayText(currRow, colLoggedOutAt).ToString();
                SaveFileDialog logSFD = new SaveFileDialog() { Filter = "Plain text(*.txt)|*.txt", FileName = $"تقرير نشاط المستخدم ({currUserName})" };
                if (logSFD.ShowDialog() != DialogResult.OK)
                    return;
                string currSessionText = userLoginGridView.GetRowCellValue(currRow, colSessionActions).ToString();

                StreamWriter sessionWr = new StreamWriter(logSFD.FileName, false);
                sessionWr.WriteLine($"اسم المستخدم: {currUserName}");
                sessionWr.WriteLine($"وقت الدخول: {currLoginTime}");
                sessionWr.WriteLine($"وقت الخروج: {currLogoutTime}");
                sessionWr.WriteLine($"{currSessionText}");
                sessionWr.Close();
                mainAlertControl.Show(this, "تم حفظ الملف", StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "اختر سجلاً واحداً ليتم تعديل بياناته", StaticCode.ApplicationTitle);
            }
        }
    }
}