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
    public partial class AssetCardViewForm : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        int assetID = 0;
        public AssetCardViewForm()
        {
            InitializeComponent();
        }

        public AssetCardViewForm(int assetIDPrm)
        {
            this.assetID = assetIDPrm;
            InitializeComponent();
        }

        private void AssetCardViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetVw' table. You can move, or remove it, as needed.
            this.assetVwTableAdapter.Fill(this.assetMngDbDataSet.AssetVw);
            this.MinimumSize = this.Size;

            if (assetID != 0)
                assetVwGridControl.DataSource = StaticCode.mainDbContext.AssetVws.Where(astv1 => astv1.معرف_الأصل == assetID);
        }

        private void saveChangesBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Validate();
            assetVwBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
            mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 500);
        }
    }
}