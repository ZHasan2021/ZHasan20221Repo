using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.Assets
{
    public partial class MoveAssetForm : Form
    {
        AssetMoveVw srchRes = null;

        public MoveAssetForm()
        {
            InitializeComponent();
        }

        private void MoveAssetForm_Load(object sender, EventArgs e)
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
            assetMovementTblBindingNavigator.Visible = StaticCode.activeUserRole.ManageAssetMovements == true;
            this.MinimumSize = this.Size;
        }

        private void assetMoveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من إدخالاتك؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (toDepartmentCheckBox.Checked && toDepartmentLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر القسم المنقول إليه أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (toSectionCheckBox.Checked && toSectionLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر الدائرة المنقول إليها أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (toSquareCheckBox.Checked && toSquareLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر الساحة المنقول إليها أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (toCustodianNameCheckBox.Checked && toCustodianNameTextBox.Text.Trim() == "")
            {
                mainAlertControl.Show(this, "اختر اسم صاحب العهدة المنقول إليه أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (assetMovementDateDateEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر تاريخ النقل أولاً", StaticCode.ApplicationTitle);
                return;
            }

            try
            {
                AssetTbl assetToMove = StaticCode.mainDbContext.AssetTbls.Single(ast => ast.ID == srchRes.ID);
                if (toDepartmentCheckBox.Checked)
                    assetToMove.AssetDept = Convert.ToInt32(toDepartmentLookUpEdit.EditValue);
                if (toSectionCheckBox.Checked)
                    assetToMove.AssetSection = Convert.ToInt32(toSectionLookUpEdit.EditValue);
                if (toSquareCheckBox.Checked)
                    assetToMove.AssetSquare = Convert.ToInt32(toSquareLookUpEdit.EditValue);
                if (toCustodianNameCheckBox.Checked)
                    assetToMove.CustodianName = toCustodianNameTextBox.Text.Trim();

                if (toDepartmentCheckBox.Checked)
                {
                    AssetMovementTbl newAstMv = new AssetMovementTbl()
                    {
                        AssetID = assetToMove.ID,
                        FieldChanged = "القسم",
                        OldValue = fromDepartmentTextBox.Text.Trim(),
                        NewValue = toDepartmentLookUpEdit.Text,
                        MovementDate = Convert.ToDateTime(assetMovementDateDateEdit.EditValue),
                    };
                    StaticCode.mainDbContext.AssetMovementTbls.InsertOnSubmit(newAstMv);
                }
                if (toSectionCheckBox.Checked)
                {
                    AssetMovementTbl newAstMv = new AssetMovementTbl()
                    {
                        AssetID = assetToMove.ID,
                        FieldChanged = "الدائرة",
                        OldValue = fromSectionTextBox.Text.Trim(),
                        NewValue = toSectionLookUpEdit.Text,
                        MovementDate = Convert.ToDateTime(assetMovementDateDateEdit.EditValue),
                    };
                    StaticCode.mainDbContext.AssetMovementTbls.InsertOnSubmit(newAstMv);
                }
                if (toSquareCheckBox.Checked)
                {
                    AssetMovementTbl newAstMv = new AssetMovementTbl()
                    {
                        AssetID = assetToMove.ID,
                        FieldChanged = "الساحة",
                        OldValue = fromSquareTextBox.Text.Trim(),
                        NewValue = toSquareLookUpEdit.Text,
                        MovementDate = Convert.ToDateTime(assetMovementDateDateEdit.EditValue),
                    };
                    StaticCode.mainDbContext.AssetMovementTbls.InsertOnSubmit(newAstMv);
                }
                if (toCustodianNameCheckBox.Checked)
                {
                    AssetMovementTbl newAstMv = new AssetMovementTbl()
                    {
                        AssetID = assetToMove.ID,
                        FieldChanged = "صاحب العهدة",
                        OldValue = fromCustodianNameTextBox.Text.Trim(),
                        NewValue = toCustodianNameTextBox.Text.Trim(),
                        MovementDate = Convert.ToDateTime(assetMovementDateDateEdit.EditValue),
                    };
                    StaticCode.mainDbContext.AssetMovementTbls.InsertOnSubmit(newAstMv);
                }
                StaticCode.mainDbContext.SubmitChanges();
                this.Validate();
                this.assetMoveVwBindingSource.EndEdit();
                assetMoveVwGridControl.DataSource = StaticCode.mainDbContext.AssetMovementTbls.Where(asmv => asmv.AssetID == srchRes.ID);
                mainAlertControl.Show(this, "تم نقل الأصل وإضافة سجل نقل بنجاح", StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "خطأ في نقل الأصل، حاول ثانية", StaticCode.ApplicationTitle);
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
            assetMoveVwGridControl.DataSource = StaticCode.mainDbContext.AssetMovementTbls.Where(asmv => asmv.AssetID == srchRes.ID);
        }

        private void toDepartmentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            toDepartmentLookUpEdit.Visible = toDepartmentCheckBox.Checked;
        }

        private void toSectionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            toSectionLookUpEdit.Visible = toSectionCheckBox.Checked;
        }

        private void toSquareCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            toSquareLookUpEdit.Visible = toSquareCheckBox.Checked;
        }

        private void toCustodianNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            toCustodianNameTextBox.Visible = toCustodianNameCheckBox.Checked;
        }

        private void assetMovementTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            assetMovementTblBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.assetMngDbDataSet);
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
        }
    }
}