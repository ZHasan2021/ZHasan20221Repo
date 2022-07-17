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
    public partial class ManageFinancialItemCategoryTblForm : Form
    {
        public ManageFinancialItemCategoryTblForm()
        {
            InitializeComponent();
        }

        private void ManageFinancialItemCategoryTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.FinancialItemCategoryTbl' table. You can move, or remove it, as needed.
            this.financialItemCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.FinancialItemCategoryTbl);

            financialItemCategoryGridControl.EmbeddedNavigator.Buttons.Append.Visible = StaticCode.activeUserRole.AddNewFinancialItemCategory == true;

            this.MinimumSize = this.Size;
        }

        private void financialItemCategoryTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            financialItemCategoryTblBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
            mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
        }
    }
}