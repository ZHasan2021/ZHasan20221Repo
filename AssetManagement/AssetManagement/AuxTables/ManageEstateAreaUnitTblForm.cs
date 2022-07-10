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
    public partial class ManageEstateAreaUnitTblForm : Form
    {
        public ManageEstateAreaUnitTblForm()
        {
            InitializeComponent();
        }

        private void ManageEstateAreaUnitTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.EstateAreaUnitTbl' table. You can move, or remove it, as needed.
            this.estateAreaUnitTblTableAdapter.Fill(this.assetMngDbDataSet.EstateAreaUnitTbl);

            estateAreaUnitGridControl.EmbeddedNavigator.Buttons.Append.Visible = StaticCode.activeUserRole.AddNewEstateAreaUnit == true;

            this.MinimumSize = this.Size;
        }

        private void estateAreaUnitTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            estateAreaUnitTblBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
        }
    }
}