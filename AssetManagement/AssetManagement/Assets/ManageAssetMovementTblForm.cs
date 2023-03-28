using AssetManagement.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AssetManagement.AssetMngDbDataSet;

namespace AssetManagement.AuxTables
{
    public partial class ManageAssetMovementTblForm : Form
    {
        int currRow = -1;
        IQueryable<AssetTbl> customDS = null;

        public ManageAssetMovementTblForm()
        {
            InitializeComponent();
        }

        public ManageAssetMovementTblForm(IQueryable<AssetTbl> customAssets)
        {
            customDS = customAssets;
            InitializeComponent();
        }

        void LoadAssets()
        {
            List<int> IDsIncluded = StaticCode.mainDbContext.AssetVw_Alls.Select(astv1 => astv1.معرف_الأصل).ToList();
            if (customDS != null)
                IDsIncluded = customDS.Select(ast1 => ast1.ID).ToList();
            string plusQry = "";
            if (IDsIncluded.Count() == 0)
                plusQry = " WHERE 1 > 2;";
            else
            {
                foreach (int oneID in IDsIncluded)
                    plusQry += oneID + ", ";
                plusQry = $" WHERE [AssetID] IN ({ plusQry.Trim().Trim(',').Trim()});";
            }
            AssetMovementTblDataTable customVw = this.assetMngDbDataSet.AssetMovementTbl;
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
                    this.assetMovementTblTableAdapter.FillByQuery(customVw, " WHERE 1 > 2;");
                    return;
                }
            }
            this.assetMovementTblTableAdapter.FillByQuery(customVw, plusQry);
        }

        private void ManageAssetMovementTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetTbl' table. You can move, or remove it, as needed.
            this.assetTblTableAdapter.Fill(this.assetMngDbDataSet.AssetTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetVw_All' table. You can move, or remove it, as needed.
            this.assetVw_AllTableAdapter.Fill(this.assetMngDbDataSet.AssetVw_All);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetVw' table. You can move, or remove it, as needed.
            this.assetVwTableAdapter.Fill(this.assetMngDbDataSet.AssetVw);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetMovementTbl' table. You can move, or remove it, as needed.
            //this.assetMovementTblTableAdapter.Fill(this.assetMngDbDataSet.AssetMovementTbl);

            this.MinimumSize = this.Size;

            LoadAssets();
        }

        private void assetMovementTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assetMovementTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
            mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
            StaticCode.activeUserLogin.SessionActions += $"تعديل في سجلات نقل الأصول - {DateTime.Now.AddDays(StaticCode.appOptions.ShiftDays).AddSeconds(StaticCode.appOptions.ShiftSeconds)}\r\n";
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 200);
        }

        private void assetMovementTblBindingNavigatorExportToExcelItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog exportDlg = new SaveFileDialog() { Filter = "Excel workbook (2007-2022)(*.xlsx)|*.xlsx", FileName = "سجلات نقل الأصول" };
            if (exportDlg.ShowDialog() != DialogResult.OK)
                return;
            StaticCode.activeUserLogin.SessionActions += $"تصدير سجلات نقل الأصول - {DateTime.Now.AddDays(StaticCode.appOptions.ShiftDays).AddSeconds(StaticCode.appOptions.ShiftSeconds)}\r\n";
            assetMovementGridControl.ExportToXlsx(exportDlg.FileName, new DevExpress.XtraPrinting.XlsxExportOptions() { ShowGridLines = false, SheetName = "سجلات نقل الأصول" });
            mainAlertControl.Show(this, "تم تصدير سجلات نقل الأصول إلى اكسل", StaticCode.ApplicationTitle);
        }

        private void assetMovementTblBindingNavigatorViewAssetCardItem_Click(object sender, EventArgs e)
        {
            if (currRow < 0)
            {
                mainAlertControl.Show(this, "اختر سطراً كاملاً ليتم عرض بطاقته", StaticCode.ApplicationTitle);
                return;
            }
            try
            {
                int currAssetID = Convert.ToInt32(assetMovementGridView.GetRowCellValue(currRow, colAssetID));
                StaticCode.activeUserLogin.SessionActions += $"عرض بطاقة الأصل ذو الكود {StaticCode.mainDbContext.AssetTbls.Single(ast1 => ast1.ID == currAssetID).AssetCode} - {DateTime.Now.AddDays(StaticCode.appOptions.ShiftDays).AddSeconds(StaticCode.appOptions.ShiftSeconds)}\r\n";
                AssetCardViewForm cardVwFrm = new AssetCardViewForm(currAssetID);
                cardVwFrm.ShowDialog();
                currRow = 0;
            }
            catch
            {
                mainAlertControl.Show(this, "اختر سجلاً واحداً ليتم عرض بطاقته", StaticCode.ApplicationTitle);
            }
        }

        private void assetMovementGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            currRow = e.RowHandle;
            ShowAssetCard();
        }

        private void assetMovementGridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            currRow = e.RowHandle;
            ShowAssetCard();
        }

        void ShowAssetCard()
        {
            assetVwGridControl.Visible = false;
            if (currRow < 0)
            {
                return;
            }
            try
            {
                int currAssetID = Convert.ToInt32(assetMovementGridView.GetRowCellValue(currRow, colAssetID));
                string plusQry = $" WHERE [معرف الأصل] = ({currAssetID});";
                AssetVw_AllDataTable customVw = this.assetMngDbDataSet.AssetVw_All;
                for (int i = 0; i < customVw.Rows.Count; i++)
                {
                    try
                    {
                        var oneRow = customVw.Rows[i];
                        object[] oneRowItemArray = oneRow.ItemArray;
                        if (currAssetID != Convert.ToInt32(oneRowItemArray[0]))
                            customVw.Rows.Remove(oneRow);
                    }
                    catch
                    {
                        continue;
                    }
                }
                this.assetVw_AllTableAdapter.FillByQuery(customVw, plusQry);
                assetVwGridControl.Visible = true;
            }
            catch
            {
            }
        }

        private void assetMovementTblBindingNavigatorAddFilesToAssetFolderItem_Click(object sender, EventArgs e)
        {
            if (currRow < 0)
            {
                mainAlertControl.Show(this, "اختر سطراً واحداً فقط", StaticCode.ApplicationTitle);
                return;
            }
            try
            {
                OpenFileDialog assetOFD = new OpenFileDialog();
                assetOFD.Multiselect = true;
                if (assetOFD.ShowDialog() != DialogResult.OK)
                    return;
                int assetID = Convert.ToInt32(assetMovementGridView.GetRowCellValue(currRow, colAssetID));
                string assetCode = StaticCode.mainDbContext.AssetTbls.Single(ast1 => ast1.ID == assetID).AssetCode;
                StaticCode.activeUserLogin.SessionActions += $"إضافة مرفقات لمجلد الأصل ذو الكود {assetCode} - {DateTime.Now.AddDays(StaticCode.appOptions.ShiftDays).AddSeconds(StaticCode.appOptions.ShiftSeconds)}\r\n";
                string assetFolder = StaticCode.AssetsAttachmentsFolder + assetCode + "//";
                if (!Directory.Exists(assetFolder))
                    Directory.CreateDirectory(assetFolder);
                foreach (string oneFile in assetOFD.FileNames)
                {
                    File.Copy(oneFile, assetFolder + Path.GetFileName(oneFile), true);
                }
                mainAlertControl.Show(this, $"تم إضافة ({assetOFD.FileNames.Count()}) مرفق/ات", StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "اختر سجلاً واحداً فقط", StaticCode.ApplicationTitle);
            }
        }

        private void assetMovementTblBindingNavigatorOpenAssetFolderItem_Click(object sender, EventArgs e)
        {
            if (currRow < 0)
            {
                mainAlertControl.Show(this, "اختر سطراً واحداً فقط", StaticCode.ApplicationTitle);
                return;
            }
            try
            {
                int assetID = Convert.ToInt32(assetMovementGridView.GetRowCellValue(currRow, colAssetID));
                string assetCode = StaticCode.mainDbContext.AssetTbls.Single(ast1 => ast1.ID == assetID).AssetCode;
                StaticCode.activeUserLogin.SessionActions += $"فتح مجلد الأصل ذو الكود {assetCode} - {DateTime.Now.AddDays(StaticCode.appOptions.ShiftDays).AddSeconds(StaticCode.appOptions.ShiftSeconds)}\r\n";
                string assetFolder = StaticCode.AssetsAttachmentsFolder + assetCode + "//";
                if (!Directory.Exists(assetFolder))
                    Directory.CreateDirectory(assetFolder);
                Process.Start(assetFolder);
            }
            catch
            {
                mainAlertControl.Show(this, "اختر سجلاً واحداً فقط", StaticCode.ApplicationTitle);
            }
        }
    }
}