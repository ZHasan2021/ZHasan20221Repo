using DevExpress.XtraGrid.Columns;
using System;
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

            colMainCategoryName.FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo("[MainCategoryName] <> 'بيانات الأصل ناقصة'");
        }

        private void mainCategoryTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                mainCategoryTblBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
                mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
                StaticCode.activeUserLogin.SessionActions += $"تعديل في جدول الفئات الرئيسية - {DateTime.Now.AddDays(StaticCode.appOptions.ShiftDays).AddSeconds(StaticCode.appOptions.ShiftSeconds)}\r\n";
            }
            catch (SqlException)
            {
                mainAlertControl.Show(this, StaticCode.ApplicationTitle, "بعض السجلات التي حذفتها مرتبطة بسجلات فرعية في جداول الفئات الفرعية وكذلك ضمن سجلات الأصول، لذا لا يمكن حذفها حالياً");
                MessageBox.Show("بعض السجلات التي حذفتها مرتبطة بسجلات فرعية في جداول الفئات الفرعية وكذلك ضمن سجلات الأصول، لذا لا يمكن حذفها حالياً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void manageMinorCategoryTblToolStripButton_Click(object sender, EventArgs e)
        {
            StaticCode.activeUserLogin.SessionActions += $"نافذة إدارة جدول الفئات الفرعية - {DateTime.Now.AddDays(StaticCode.appOptions.ShiftDays).AddSeconds(StaticCode.appOptions.ShiftSeconds)}\r\n";
            ManageMinorCategoryTblForm mica = new ManageMinorCategoryTblForm();
            mica.ShowDialog();
        }
    }
}