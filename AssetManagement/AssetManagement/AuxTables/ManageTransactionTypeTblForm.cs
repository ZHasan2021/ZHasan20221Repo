﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.AuxTables
{
    public partial class ManageTransactionTypeTblForm : Form
    {
        public ManageTransactionTypeTblForm()
        {
            InitializeComponent();
        }

        private void ManageTransactionTypeTblForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.TransactionTypeTbl' table. You can move, or remove it, as needed.
            this.transactionTypeTblTableAdapter.Fill(this.assetMngDbDataSet.TransactionTypeTbl);

            transactionTypeGridControl.EmbeddedNavigator.Buttons.Append.Visible = StaticCode.activeUserRole.AddNewTransactionType == true;

            this.MinimumSize = this.Size;
        }

        private void transactionTypeTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                transactionTypeTblBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
                mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
            }
            catch (SqlException)
            {
                mainAlertControl.Show(this, StaticCode.ApplicationTitle, "بعض السجلات التي حذفتها مرتبطة بسجلات فرعية ضمن سجلات تصريف الأصول، لذا لا يمكن حذفها حالياً");
                MessageBox.Show("بعض السجلات التي حذفتها مرتبطة بسجلات فرعية ضمن سجلات تصريف الأصول، لذا لا يمكن حذفها حالياً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch
            {
                mainAlertControl.Show(this, StaticCode.ApplicationTitle, "لم يتم الحفظ، حاول لاحقاً");
                MessageBox.Show("لم يتم الحفظ، حاول لاحقاً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 150);
            e.AlertForm.Location = new Point(200, 200);
        }
    }
}