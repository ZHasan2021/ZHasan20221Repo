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
        IQueryable<AssetMoveVw> srchRes = null;
        AssetMoveVw currSrchRes = null;

        public MoveAssetForm()
        {
            InitializeComponent();
        }

        private void MoveAssetForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SubDepartmentTbl' table. You can move, or remove it, as needed.
            this.subDepartmentTblTableAdapter.Fill(this.assetMngDbDataSet.SubDepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetTbl' table. You can move, or remove it, as needed.
            this.assetTblTableAdapter.Fill(this.assetMngDbDataSet.AssetTbl);
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

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(500, 400);
        }

        private void assetMoveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من إدخالاتك؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (toSectionDepartmentSubDepartmentCheckBox.Checked)
            {
                if (toSectionLookUpEdit.EditValue == null)
                {
                    mainAlertControl.Show(this, "اختر الدائرة المنقول إليها أولاً", StaticCode.ApplicationTitle);
                    return;
                }
                if (toDepartmentLookUpEdit.EditValue == null)
                {
                    mainAlertControl.Show(this, "اختر القسم المنقول إليها أولاً", StaticCode.ApplicationTitle);
                    return;
                }
                if (toSubDepartmentLookUpEdit.EditValue == null)
                {
                    mainAlertControl.Show(this, "اختر الوحدة المنقول إليها أولاً", StaticCode.ApplicationTitle);
                    return;
                }
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
                AssetTbl assetToMove = StaticCode.mainDbContext.AssetTbls.Single(ast => ast.ID == currSrchRes.ID);
                if (toSectionDepartmentSubDepartmentCheckBox.Checked)
                    assetToMove.AssetSubDepartment = Convert.ToInt32(toSubDepartmentLookUpEdit.EditValue);
                if (toSquareCheckBox.Checked)
                    assetToMove.AssetSquare = Convert.ToInt32(toSquareLookUpEdit.EditValue);
                if (toCustodianNameCheckBox.Checked)
                    assetToMove.CustodianName = toCustodianNameTextBox.Text.Trim();

                if (toSectionDepartmentSubDepartmentCheckBox.Checked)
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
                    newAstMv = new AssetMovementTbl()
                    {
                        AssetID = assetToMove.ID,
                        FieldChanged = "القسم",
                        OldValue = fromDepartmentTextBox.Text.Trim(),
                        NewValue = toDepartmentLookUpEdit.Text,
                        MovementDate = Convert.ToDateTime(assetMovementDateDateEdit.EditValue),
                    };
                    StaticCode.mainDbContext.AssetMovementTbls.InsertOnSubmit(newAstMv);
                    newAstMv = new AssetMovementTbl()
                    {
                        AssetID = assetToMove.ID,
                        FieldChanged = "الوحدة",
                        OldValue = fromSubDepartmentTextBox.Text.Trim(),
                        NewValue = toSubDepartmentLookUpEdit.Text,
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
                assetMoveVwGridControl.DataSource = StaticCode.mainDbContext.AssetMovementTbls.Where(asmv => asmv.AssetID == currSrchRes.ID);
                mainAlertControl.Show(this, "تم نقل الأصل وإضافة سجل نقل بنجاح", StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "خطأ في نقل الأصل، حاول ثانية", StaticCode.ApplicationTitle);
            }
        }

        private void searchAssetBtn_Click(object sender, EventArgs e)
        {
            searchResultsListBox.Visible = viewAssetInformationBtn.Visible = moveAssetGroupBox.Visible = assetMoveVwGridControl.Visible = false;
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
            moveAssetGroupBox.Visible = assetMoveVwGridControl.Visible = false;
            if (searchResultsListBox.SelectedIndex == -1)
            {
                mainAlertControl.Show(this, "اختر أحد الكودات في القائمة لاستعراض معلوماته", StaticCode.ApplicationTitle);
                return;
            }
            currSrchRes = StaticCode.mainDbContext.AssetMoveVws.Single(astm => astm.ID == Convert.ToInt32(searchResultsListBox.SelectedValue));
            assetInfoLabel.Text = $"فئة الأصل الرئيسية: {currSrchRes.MainCategoryName}، فئة الأصل الثانوية: {currSrchRes.MinorCategoryName}، حالة الأصل {currSrchRes.StatusName}";
            fromSectionTextBox.Text = currSrchRes.SectionName;
            fromDepartmentTextBox.Text = currSrchRes.DepartmentName;
            fromSubDepartmentTextBox.Text = currSrchRes.SubDepartmentName;
            fromSquareTextBox.Text = currSrchRes.SquareName;
            fromCustodianNameTextBox.Text = currSrchRes.CustodianName;
            assetMoveVwGridControl.DataSource = StaticCode.mainDbContext.AssetMovementTbls.Where(asmv => asmv.AssetID == currSrchRes.ID);
            moveAssetGroupBox.Visible = assetMoveVwGridControl.Visible = true;
            toSectionDepartmentSubDepartmentCheckBox.Checked = toSquareCheckBox.Checked = toCustodianNameCheckBox.Checked = false;
        }

        private void toDepartmentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            toSectionLookUpEdit.Visible = toDepartmentLookUpEdit.Visible = toSubDepartmentLookUpEdit.Visible = toSectionDepartmentSubDepartmentCheckBox.Checked;
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

        private void toDepartmentLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (toDepartmentLookUpEdit.EditValue == null)
                return;
            var subDeptItems = StaticCode.mainDbContext.SubDepartmentTbls.Where(subd1 => subd1.MainDepartment == Convert.ToInt32(toDepartmentLookUpEdit.EditValue));
            toSubDepartmentLookUpEdit.Properties.DataSource = subDeptItems;
        }

        private void toSectionLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (toSectionLookUpEdit.EditValue == null)
                return;
            var deptItems = StaticCode.mainDbContext.DepartmentTbls.Where(sec1 => sec1.SectionOfDepartment == Convert.ToInt32(toSectionLookUpEdit.EditValue));
            toDepartmentLookUpEdit.Properties.DataSource = deptItems;
            toDepartmentLookUpEdit_EditValueChanged(sender, e);
            toSubDepartmentLookUpEdit.EditValue = null;
        }
    }
}