using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.Assets
{
    public partial class DeleteAssetForm : Form
    {
        IQueryable<AssetMoveVw> srchRes = null;
        AssetMoveVw currSrchRes = null;

        public DeleteAssetForm()
        {
            InitializeComponent();
        }

        public DeleteAssetForm(int assetID)
        {
            InitializeComponent();
            try
            {
                srchRes = StaticCode.mainDbContext.AssetMoveVws.Where(asmv1 => asmv1.ID == assetID);
                currSrchRes = StaticCode.mainDbContext.AssetMoveVws.Where(asmv1 => asmv1.ID == assetID).First();
            }
            catch
            {
                srchRes = null;
                currSrchRes = null;
            }
        }

        private void DeleteAssetForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetMovementTbl' table. You can move, or remove it, as needed.
            this.assetMovementTblTableAdapter.Fill(this.assetMngDbDataSet.AssetMovementTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetMoveVw' table. You can move, or remove it, as needed.
            this.assetMoveVwTableAdapter.Fill(this.assetMngDbDataSet.AssetMoveVw);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SectionTbl' table. You can move, or remove it, as needed.
            this.sectionTblTableAdapter.Fill(this.assetMngDbDataSet.SectionTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SquareTbl' table. You can move, or remove it, as needed.
            this.squareTblTableAdapter.Fill(this.assetMngDbDataSet.SquareTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.DepartmentTbl' table. You can move, or remove it, as needed.
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
            this.MinimumSize = this.Size;

            if (currSrchRes != null)
            {
                assetCodeTextBox.Text = currSrchRes.AssetCode;
                searchResultsListBox.DataSource = srchRes;
                searchResultsListBox.SelectedIndex = 0;
                viewAssetInformationBtn_Click(sender, e);
            }
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 500);
        }

        private void deleteAssetBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من أنك تريد حذف سجل الأصل، سيتم أيضاً حذف سجلات النقل والتصريف والإهلاك الخاصة بهذا الأصل؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                AssetTbl assetToDelete = StaticCode.mainDbContext.AssetTbls.Single(ast => ast.ID == currSrchRes.ID);
                var assetToDelete_Movement = StaticCode.mainDbContext.AssetMovementTbls.Where(astm => astm.AssetID == currSrchRes.ID);
                foreach (AssetMovementTbl oneRec1 in assetToDelete_Movement)
                    StaticCode.mainDbContext.AssetMovementTbls.DeleteOnSubmit(StaticCode.mainDbContext.AssetMovementTbls.Single(astm => astm.ID == oneRec1.ID));
                var assetToDelete_Transaction = StaticCode.mainDbContext.AssetTransactionTbls.Where(astt => astt.AssetID == currSrchRes.ID);
                foreach (AssetTransactionTbl oneRec2 in assetToDelete_Transaction)
                    StaticCode.mainDbContext.AssetTransactionTbls.DeleteOnSubmit(StaticCode.mainDbContext.AssetTransactionTbls.Single(astt => astt.ID == oneRec2.ID));
                StaticCode.mainDbContext.SubmitChanges();
                Thread.Sleep(500);

                StaticCode.mainDbContext.AssetTbls.DeleteOnSubmit(assetToDelete);
                StaticCode.mainDbContext.SubmitChanges();
                this.Validate();
                this.assetMoveVwBindingSource.EndEdit();
                mainAlertControl.Show(this, "تم حذف الأصل وكل سجلات النقل والتصريف والإهلاك بنجاح بنجاح سجل نقل بنجاح", StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "خطأ في حذف كامل بيانات الأصل، حاول ثانية", StaticCode.ApplicationTitle);
            }
        }

        private void searchAssetBtn_Click(object sender, EventArgs e)
        {
            searchResultsListBox.Visible = viewAssetInformationBtn.Visible = deleteAssetGroupBox.Visible = false;
            srchRes = StaticCode.mainDbContext.AssetMoveVws.Where(ast => ast.AssetCode.Contains(assetCodeTextBox.Text.Trim()));
            if (srchRes.Count() == 0)
            {
                mainAlertControl.Show(this, "لا يوجد أصل يحتوي على الكود الذي أدخلته ولو حتى بشكل جزئي", StaticCode.ApplicationTitle);
                return;
            }
            searchResultsListBox.DataSource = srchRes;
            searchResultsListBox.Visible = viewAssetInformationBtn.Visible = true;

        }

        private void viewAssetInformationBtn_Click(object sender, EventArgs e)
        {
            deleteAssetGroupBox.Visible = false;
            if (searchResultsListBox.SelectedIndex == -1)
            {
                mainAlertControl.Show(this, "اختر أحد الكودات في القائمة لاستعراض معلوماته", StaticCode.ApplicationTitle);
                return;
            }
            currSrchRes = StaticCode.mainDbContext.AssetMoveVws.Single(astm => astm.ID == Convert.ToInt32(searchResultsListBox.SelectedValue));
            assetInfoLabel.Text = $"فئة الأصل الرئيسية: {currSrchRes.MainCategoryName}، فئة الأصل الثانوية: {currSrchRes.MinorCategoryName}، حالة الأصل {currSrchRes.StatusName}";
            fromDepartmentTextBox.Text = currSrchRes.DepartmentName;
            fromSectionTextBox.Text = currSrchRes.SectionName;
            fromSquareTextBox.Text = currSrchRes.SquareName;
            fromCustodianNameTextBox.Text = currSrchRes.CustodianName;
            deleteAssetGroupBox.Visible = true;
        }
    }
}