using AssetManagement.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.AuxTables
{
    public partial class ManageAssetMovementTblForm : Form
    {
        int currRow = -1;

        public ManageAssetMovementTblForm()
        {
            InitializeComponent();
        }

        private void ManageAssetMovementTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetVw_All' table. You can move, or remove it, as needed.
            this.assetVw_AllTableAdapter.Fill(this.assetMngDbDataSet.AssetVw_All);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetVw' table. You can move, or remove it, as needed.
            this.assetVwTableAdapter.Fill(this.assetMngDbDataSet.AssetVw);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetMovementTbl' table. You can move, or remove it, as needed.
            this.assetMovementTblTableAdapter.Fill(this.assetMngDbDataSet.AssetMovementTbl);

            this.MinimumSize = this.Size;
        }

        private void assetMovementTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assetMovementTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
            mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 200);
        }

        private void assetMovementTblBindingNavigatorExportToExcelItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog exportDlg = new SaveFileDialog() { Filter = "Excel workbook (2007-2022)(*.xlsx)|*.xlsx" };
            if (exportDlg.ShowDialog() != DialogResult.OK)
                return;
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
        }

        private void assetMovementGridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            currRow = e.RowHandle;
        }
    }
}