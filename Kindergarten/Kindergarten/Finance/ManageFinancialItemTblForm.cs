﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kindergarten.AuxTables
{
    public partial class ManageFinancialItemTblForm : Form
    {
        public ManageFinancialItemTblForm()
        {
            InitializeComponent();
        }

        private void ManageFinancialItemTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kindergartenDbDataSet.CurrencyTbl' table. You can move, or remove it, as needed.
            this.currencyTblTableAdapter.Fill(this.kindergartenDbDataSet.CurrencyTbl);
            // TODO: This line of code loads data into the 'kindergartenDbDataSet.FinancialItemCategoryTbl' table. You can move, or remove it, as needed.
            this.financialItemCategoryTblTableAdapter.Fill(this.kindergartenDbDataSet.FinancialItemCategoryTbl);
            // TODO: This line of code loads data into the 'kindergartenDbDataSet.FinancialItemTbl' table. You can move, or remove it, as needed.
            this.financialItemTblTableAdapter.Fill(this.kindergartenDbDataSet.FinancialItemTbl);
            // TODO: This line of code loads data into the 'kindergartenDbDataSet.CurrencyTbl' table. You can move, or remove it, as needed.
            this.currencyTblTableAdapter.Fill(this.kindergartenDbDataSet.CurrencyTbl);
            financialItemGridControl.EmbeddedNavigator.Buttons.Edit.Visible = financialItemGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = StaticCode.activeUserRole.UpdateExistedFinancialItem == true;
            financialItemGridControl.EmbeddedNavigator.Buttons.Remove.Visible = StaticCode.activeUserRole.DeleteFinancialItemRecord == true;

            this.MinimumSize = this.Size;
        }

        private void currencyTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.currencyTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kindergartenDbDataSet);
            mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 200);
        }
    }
}