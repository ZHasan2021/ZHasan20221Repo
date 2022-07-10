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
    public partial class ManageCurrencyTblForm : Form
    {
        public ManageCurrencyTblForm()
        {
            InitializeComponent();
        }

        private void ManageCurrencyTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.CurrencyTbl' table. You can move, or remove it, as needed.
            this.currencyTblTableAdapter.Fill(this.assetMngDbDataSet.CurrencyTbl);

            currencyGridControl.EmbeddedNavigator.Buttons.Append.Visible = StaticCode.activeUserRole.AddNewCurrency == true;

            this.MinimumSize = this.Size;
        }

        private void currencyTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            currencyTblBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
        }
    }
}