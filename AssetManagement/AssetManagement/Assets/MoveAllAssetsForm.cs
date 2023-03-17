using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AssetManagement.AssetMngDbDataSet;

namespace AssetManagement.Assets
{
    public partial class MoveAllAssetsForm : Form
    {
        IQueryable<AssetVw> srchRes = null;

        public MoveAllAssetsForm()
        {
            InitializeComponent();
        }

        public MoveAllAssetsForm(IQueryable<AssetVw> assetsToMove)
        {
            srchRes = assetsToMove;
            InitializeComponent();
        }

        public MoveAllAssetsForm(IQueryable<AssetTbl> assetsToMove)
        {
            List<int> assetsIDs = assetsToMove.Select(ast1 => ast1.ID).ToList();
            srchRes = StaticCode.mainDbContext.AssetVws.Where(asv1 => assetsIDs.Contains(asv1.معرف_الأصل));
            InitializeComponent();
        }

        private void MoveAllAssetsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.EmployeeTbl' table. You can move, or remove it, as needed.
            this.employeeTblTableAdapter.Fill(this.assetMngDbDataSet.EmployeeTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.AssetVw' table. You can move, or remove it, as needed.
            this.assetVwTableAdapter.Fill(this.assetMngDbDataSet.AssetVw);
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
            this.MinimumSize = this.Size;
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 200);
            e.AlertForm.Location = new Point(500, 400);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void assetsMoveAllBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من إدخالاتك؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!(toSectionDepartmentSubDepartmentCheckBox.Checked || toSquareCheckBox.Checked || toCustodianNameCheckBox.Checked || toPlaceOfPresenceCheckBox.Checked))
            {
                mainAlertControl.Show(this, "اختر واحدة من معلومات النقل على الأقل", StaticCode.ApplicationTitle);
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
            if (toPlaceOfPresenceCheckBox.Checked && toPlaceOfPresenceTextBox.Text.Trim() == "")
            {
                mainAlertControl.Show(this, "اختر اسم مكان التواجد المنقول إليه أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (assetMovementDateDateEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر تاريخ النقل أولاً", StaticCode.ApplicationTitle);
                return;
            }

            try
            {
                foreach (AssetVw oneAsset_Vw in srchRes)
                {

                    AssetTbl oneAsset_Tbl = StaticCode.mainDbContext.AssetTbls.Single(ast => ast.ID == oneAsset_Vw.معرف_الأصل);
                    if (toSectionDepartmentSubDepartmentCheckBox.Checked)
                        oneAsset_Tbl.AssetSubDepartment = Convert.ToInt32(toSubDepartmentLookUpEdit.EditValue);
                    if (toSquareCheckBox.Checked)
                        oneAsset_Tbl.AssetSquare = Convert.ToInt32(toSquareLookUpEdit.EditValue);
                    if (toCustodianNameCheckBox.Checked)
                        oneAsset_Tbl.CustodianName = toCustodianNameTextBox.Text.Trim();
                    if (toPlaceOfPresenceCheckBox.Checked)
                        oneAsset_Tbl.PlaceOfPresence = toPlaceOfPresenceTextBox.Text.Trim();

                    if (toSectionDepartmentSubDepartmentCheckBox.Checked)
                    {
                        AssetMovementTbl newAstMv = new AssetMovementTbl()
                        {
                            AssetID = oneAsset_Tbl.ID,
                            FieldChanged = "الدائرة",
                            OldValue = oneAsset_Vw.الدائرة,
                            NewValue = toSectionLookUpEdit.Text,
                            MovementDate = Convert.ToDateTime(assetMovementDateDateEdit.EditValue),
                        };
                        StaticCode.mainDbContext.AssetMovementTbls.InsertOnSubmit(newAstMv);
                        newAstMv = new AssetMovementTbl()
                        {
                            AssetID = oneAsset_Tbl.ID,
                            FieldChanged = "القسم",
                            OldValue = oneAsset_Vw.القسم,
                            NewValue = toDepartmentLookUpEdit.Text,
                            MovementDate = Convert.ToDateTime(assetMovementDateDateEdit.EditValue),
                        };
                        StaticCode.mainDbContext.AssetMovementTbls.InsertOnSubmit(newAstMv);
                        newAstMv = new AssetMovementTbl()
                        {
                            AssetID = oneAsset_Tbl.ID,
                            FieldChanged = "الوحدة",
                            OldValue = oneAsset_Vw.الوحدة,
                            NewValue = toSubDepartmentLookUpEdit.Text,
                            MovementDate = Convert.ToDateTime(assetMovementDateDateEdit.EditValue),
                        };
                        StaticCode.mainDbContext.AssetMovementTbls.InsertOnSubmit(newAstMv);
                    }
                    if (toSquareCheckBox.Checked)
                    {
                        AssetMovementTbl newAstMv = new AssetMovementTbl()
                        {
                            AssetID = oneAsset_Tbl.ID,
                            FieldChanged = "الساحة",
                            OldValue = oneAsset_Vw.الساحة,
                            NewValue = toSquareLookUpEdit.Text,
                            MovementDate = Convert.ToDateTime(assetMovementDateDateEdit.EditValue),
                        };
                        StaticCode.mainDbContext.AssetMovementTbls.InsertOnSubmit(newAstMv);
                    }
                    if (toCustodianNameCheckBox.Checked)
                    {
                        AssetMovementTbl newAstMv = new AssetMovementTbl()
                        {
                            AssetID = oneAsset_Tbl.ID,
                            FieldChanged = "صاحب العهدة",
                            OldValue = oneAsset_Vw.اسم_صاحب_العهدة,
                            NewValue = toCustodianNameTextBox.Text.Trim(),
                            MovementDate = Convert.ToDateTime(assetMovementDateDateEdit.EditValue),
                        };
                        StaticCode.mainDbContext.AssetMovementTbls.InsertOnSubmit(newAstMv);
                    }
                    if (toPlaceOfPresenceCheckBox.Checked)
                    {
                        AssetMovementTbl newAstMv = new AssetMovementTbl()
                        {
                            AssetID = oneAsset_Tbl.ID,
                            FieldChanged = "مكان التواجد",
                            OldValue = oneAsset_Vw.مكان_التواجد,
                            NewValue = toPlaceOfPresenceTextBox.Text.Trim(),
                            MovementDate = Convert.ToDateTime(assetMovementDateDateEdit.EditValue),
                        };
                        StaticCode.mainDbContext.AssetMovementTbls.InsertOnSubmit(newAstMv);
                    }
                }
                StaticCode.mainDbContext.SubmitChanges();
                this.Validate();
                mainAlertControl.Show(this, $"تم نقل ({srchRes.Count()}) أصل / أصول وإضافة سجل نقل بنجاح", StaticCode.ApplicationTitle);
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                mainAlertControl.Show(this, "خطأ في نقل الأصل، حاول ثانية", StaticCode.ApplicationTitle);
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void toDepartmentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            toSectionLookUpEdit.Visible = toDepartmentLookUpEdit.Visible = toSubDepartmentLookUpEdit.Visible = toSectionDepartmentSubDepartmentCheckBox.Checked;
            if (toSectionDepartmentSubDepartmentCheckBox.Checked)
            {
                if (StaticCode.activeUserRole.IsSectionIndependent != true)
                {
                    toSectionLookUpEdit.EditValue = StaticCode.activeUser.UserSection;
                    toSectionLookUpEdit.Enabled = false;
                }
                if (StaticCode.activeUserRole.IsDepartmentIndependent != true)
                {
                    toDepartmentLookUpEdit.EditValue = StaticCode.activeUser.UserDept;
                    toDepartmentLookUpEdit.Enabled = false;
                }
            }
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

        private void toPlaceOfPresenceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            toPlaceOfPresenceTextBox.Visible = toPlaceOfPresenceCheckBox.Checked;
        }
    }
}