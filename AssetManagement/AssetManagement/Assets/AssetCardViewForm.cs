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
    public partial class AssetCardViewForm : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        int assetID = 0;
        int cardType = 0;
        public AssetCardViewForm()
        {
            InitializeComponent();
        }

        public AssetCardViewForm(int assetIDPrm)
        {
            this.assetID = assetIDPrm;
            InitializeComponent();
        }

        public AssetCardViewForm(int assetIDPrm, int cardTypePrm)
        {
            this.assetID = assetIDPrm;
            this.cardType = cardTypePrm;
            InitializeComponent();
        }

        private void AssetCardViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetVw_All' table. You can move, or remove it, as needed.
            this.assetVw_AllTableAdapter.Fill(this.assetMngDbDataSet.AssetVw_All);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetVw' table. You can move, or remove it, as needed.
            this.assetVwTableAdapter.Fill(this.assetMngDbDataSet.AssetVw);
            this.MinimumSize = this.Size;

            if (assetID != 0)
            {
                string plusQry = $" WHERE [معرف الأصل] = ({assetID});";
                AssetVw_AllDataTable customVw = this.assetMngDbDataSet.AssetVw_All;
                for (int i = 0; i < customVw.Rows.Count; i++)
                {
                    try
                    {
                        var oneRow = customVw.Rows[i];
                        object[] oneRowItemArray = oneRow.ItemArray;
                        if (assetID != Convert.ToInt32(oneRowItemArray[0]))
                            customVw.Rows.Remove(oneRow);
                    }
                    catch
                    {
                        continue;
                    }
                }
                this.assetVw_AllTableAdapter.FillByQuery(customVw, plusQry);
            }

            switch (cardType)
            {
                case 1:
                    assetLayoutView.Columns.Remove(colاسمالمالك);
                    assetLayoutView.Columns.Remove(colالمستغلمنه);
                    assetLayoutView.Columns.Remove(colرقمالمحركللمركبة);
                    assetLayoutView.Columns.Remove(colرقملوحةالمركبة);
                    assetLayoutView.Columns.Remove(colسنةصنعالمركبة);
                    assetLayoutView.Columns.Remove(colعنوانالعقار);
                    assetLayoutView.Columns.Remove(colمساحةالعقار);
                    assetLayoutView.Columns.Remove(colمعمنورقةالملكية);
                    assetLayoutView.Columns.Remove(colوحدةمساحةالعقار);
                    assetLayoutView.Columns.Remove(colرقمالهيكلالشاصيهللمركبة);
                    //colاسمالمالك.Visible = colالمستغلمنه.Visible = colرقمالمحركللمركبة.Visible = colرقملوحةالمركبة.Visible = colسنةصنعالمركبة.Visible = colعنوانالعقار.Visible = colمساحةالعقار.Visible = colمعمنورقةالملكية.Visible = colوحدةمساحةالعقار.Visible = colرقملوحةالمركبة.Visible = false;
                    break;
                case 2:
                    assetLayoutView.Columns.Remove(colرقمالمحركللمركبة);
                    assetLayoutView.Columns.Remove(colرقملوحةالمركبة);
                    assetLayoutView.Columns.Remove(colسنةصنعالمركبة);
                    assetLayoutView.Columns.Remove(colاللون);
                    assetLayoutView.Columns.Remove(colالموديل);
                    assetLayoutView.Columns.Remove(colرقمالهيكلالشاصيهللمركبة);
                    //colرقمالمحركللمركبة.Visible = colرقملوحةالمركبة.Visible = colسنةصنعالمركبة.Visible =  colالموديل.Visible = colاللون.Visible = false;
                    break;
                case 3:
                    assetLayoutView.Columns.Remove(colالمستغلمنه);
                    assetLayoutView.Columns.Remove(colعنوانالعقار);
                    assetLayoutView.Columns.Remove(colمساحةالعقار);
                    assetLayoutView.Columns.Remove(colمعمنورقةالملكية);
                    assetLayoutView.Columns.Remove(colوحدةمساحةالعقار);
                    //colالمستغلمنه.Visible = colعنوانالعقار.Visible = colمساحةالعقار.Visible = colمعمنورقةالملكية.Visible = colوحدةمساحةالعقار.Visible = false;
                    break;
                default:
                    break;
            }
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