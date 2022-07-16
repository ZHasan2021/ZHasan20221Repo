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
        AssetMoveVw srchRes = null;

        public DeleteAssetForm()
        {
            InitializeComponent();
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
        }

        private void deleteMoveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من أنك تريد حذف سجل الأصل، سيتم أيضاً حذف سجلات النقل والتصريف والإهلاك الخاصة بهذا الأصل؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                AssetTbl assetToDelete = StaticCode.mainDbContext.AssetTbls.Single(ast => ast.ID == srchRes.ID);
                var assetToDelete_Movement = StaticCode.mainDbContext.AssetMovementTbls.Where(astm => astm.AssetID == srchRes.ID);
                foreach (AssetMovementTbl oneRec1 in assetToDelete_Movement)
                    StaticCode.mainDbContext.AssetMovementTbls.DeleteOnSubmit(StaticCode.mainDbContext.AssetMovementTbls.Single(astm => astm.ID == oneRec1.ID));
                var assetToDelete_Transaction = StaticCode.mainDbContext.AssetTransactionTbls.Where(astt => astt.AssetID == srchRes.ID);
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
            moveAssetGroupBox.Visible = false;
            var assetsByCodeQry = StaticCode.mainDbContext.AssetTbls.Where(ast => ast.AssetCode == assetCodeTextBox.Text.Trim());
            if (assetsByCodeQry.Count() == 0)
            {
                mainAlertControl.Show(this, "لا يوجد أصل يحمل رقم الكود الذي أدخلته", StaticCode.ApplicationTitle);
                return;
            }
            srchRes = StaticCode.mainDbContext.AssetMoveVws.Single(ast => ast.ID == assetsByCodeQry.First().ID);
            moveAssetGroupBox.Visible = true;
            assetInfoLabel.Text = $"فئة الأصل الرئيسية: {srchRes.MainCategoryName}، فئة الأصل الثانوية: {srchRes.MinorCategoryName}، حالة الأصل {srchRes.StatusName}";
            fromDepartmentTextBox.Text = srchRes.DepartmentName;
            fromSectionTextBox.Text = srchRes.SectionName;
            fromSquareTextBox.Text = srchRes.SquareName;
            fromCustodianNameTextBox.Text = srchRes.CustodianName;
        }
    }
}