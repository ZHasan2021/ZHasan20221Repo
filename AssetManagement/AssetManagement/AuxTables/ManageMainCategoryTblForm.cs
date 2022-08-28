﻿using System;
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
    public partial class ManageMainCategoryTblForm : Form
    {
        public ManageMainCategoryTblForm()
        {
            InitializeComponent();
        }

        private void ManageMainCategoryTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.MainCategoryTbl' table. You can move, or remove it, as needed.
            this.mainCategoryTblTableAdapter.Fill(this.assetMngDbDataSet.MainCategoryTbl);

            mainCategoryGridControl.EmbeddedNavigator.Buttons.Append.Visible = StaticCode.activeUserRole.AddNewMainCategory == true;

            this.MinimumSize = this.Size;
        }

        private void mainCategoryTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            mainCategoryTblBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
            mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 200);
        }

        private void manageMinorCategoryTblToolStripButton_Click(object sender, EventArgs e)
        {
            ManageMinorCategoryTblForm mica = new ManageMinorCategoryTblForm();
            mica.ShowDialog();
        }
    }
}