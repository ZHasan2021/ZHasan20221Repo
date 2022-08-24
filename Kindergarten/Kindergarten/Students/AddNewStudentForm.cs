using Kindergarten.AuxTables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kindergarten.Students
{
    public partial class AddNewStudentForm : Form
    {
        string errorSummaryMessage = "";
        EducationalLevelTbl selectedEdLv = null;
        public AddNewStudentForm()
        {
            InitializeComponent();
        }

        private void AddNewStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kindergartenDbDataSet.ScholasticYearTbl' table. You can move, or remove it, as needed.
            this.scholasticYearTblTableAdapter.Fill(this.kindergartenDbDataSet.ScholasticYearTbl);
            // TODO: This line of code loads data into the 'kindergartenDbDataSet.FeePeriodTbl' table. You can move, or remove it, as needed.
            this.feePeriodTblTableAdapter.Fill(this.kindergartenDbDataSet.FeePeriodTbl);
            // TODO: This line of code loads data into the 'kindergartenDbDataSet.EducationalLevelTbl' table. You can move, or remove it, as needed.
            this.educationalLevelTblTableAdapter.Fill(this.kindergartenDbDataSet.EducationalLevelTbl);
            manageEducationalLevelTblBtn.Visible = StaticCode.activeUserRole.ManageEducationalLevels == true;
            this.MinimumSize = this.Size;
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(200, 500);
        }

        private void manageEducationalLevelTblBtn_Click(object sender, EventArgs e)
        {
            ManageEducationalLevelTblForm mngel = new ManageEducationalLevelTblForm();
            mngel.ShowDialog();
            this.educationalLevelTblTableAdapter.Fill(this.kindergartenDbDataSet.EducationalLevelTbl);
        }

        private void addNewStudentBtn_OK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من إدخالاتك؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            errorSummaryMessage = "";
            if (firstNameTextBox.Text.Trim() == "")
            {
                errorSummaryMessage += "اسم الطالب غير موجود، ";
            }
            if (lastNameTextBox.Text.Trim() == "")
            {
                errorSummaryMessage += "كنية الطالب غير موجودة، ";
            }
            if (fatherTextBox.Text.Trim() == "")
            {
                errorSummaryMessage += "اسم الأب غير موجود، ";
            }
            if (motherTextBox.Text.Trim() == "")
            {
                errorSummaryMessage += "اسم الأم غير موجود، ";
            }
            if (nationalCardIDTextBox.Text.Trim() == "")
            {
                errorSummaryMessage += "رقم البطاقة الشخصية غير موجود، ";
            }
            if (dateOfBirthDateEdit.EditValue == null)
            {
                errorSummaryMessage += "تاريخ ميلاد الطالب غير موجود، ";
            }
            if (educationalLevelLookUpEdit.EditValue == null)
            {
                errorSummaryMessage += "المرحلة الدراسية غير محددة، ";
            }
            if (registeringDateDateEdit.EditValue == null)
            {
                errorSummaryMessage += "تاريخ التسجيل غير موجود، ";
            }
            if (studentPaidFeeCheckBox.Checked)
            {
                if (feePeriodLookUpEdit.EditValue == null)
                {
                    errorSummaryMessage += "فترة الرسم الدراسي غير محددة، ";
                }
                if (feePayingDateDateEdit.EditValue == null)
                {
                    errorSummaryMessage += "تاريخ دفع الرسوم غير موجود، ";
                }
                if (feeScholasticYearLookUpEdit.EditValue == null)
                {
                    errorSummaryMessage += "الموسم الدراسي غير محدد، ";
                }
            }
            errorSummaryMessage = errorSummaryMessage.Trim().Trim('،').Trim();
            if (errorSummaryMessage == "")
            {
                try
                {
                    StudentTbl newStudentRecord = new StudentTbl()
                    {
                        FirstName = firstNameTextBox.Text.Trim(),
                        LastName = lastNameTextBox.Text.Trim(),
                        Father = fatherTextBox.Text.Trim(),
                        Mother = motherTextBox.Text.Trim(),
                        NationalCardID = nationalCardIDTextBox.Text.Trim(),
                        DateOfBirth = Convert.ToDateTime(dateOfBirthDateEdit.EditValue),
                        StudentGrade = Convert.ToInt32(studentGradeNumericUpDown.Value),
                        EducationalLevel = Convert.ToInt32(educationalLevelLookUpEdit.EditValue),
                        RegisteringDate = Convert.ToDateTime(registeringDateDateEdit.EditValue),
                        ScholasticYear = Convert.ToInt32(scholasticYearLookUpEdit.EditValue),
                        Notes = notesTextBox.Text.Trim(),
                    };
                    if (studentPaidFeeCheckBox.Checked)
                    {
                        newStudentRecord.StudentFeeTbls.Add(new StudentFeeTbl()
                        {
                            FeePeriod = Convert.ToInt32(feePeriodLookUpEdit.EditValue),
                            FeePayingDate = Convert.ToDateTime(feePayingDateDateEdit.EditValue),
                            FeeScholasticYear = Convert.ToInt32(feeScholasticYearLookUpEdit.EditValue),
                            FeeAmount = Convert.ToInt32(feeAmountNumericUpDown.Value),
                            VoucherNumber = voucherNumberTextBox.Text.Trim(),
                            VoucherPreparedBy = voucherPreparedByTextBox.Text.Trim(),
                        });
                    }
                    StaticCode.mainDbContext.StudentTbls.InsertOnSubmit(newStudentRecord);
                    StaticCode.mainDbContext.SubmitChanges();
                    errorSummaryMessage = "تمت الإضافة بنجاح";
                    mainAlertControl.Show(this, "تمت الإضافة بنجاح", StaticCode.ApplicationTitle);
                    errorSummaryPanel.BackColor = Color.Green;
                    correctPictureBox.Visible = true;
                    incorrectPictureBox.Visible = false;
                    addNewStudentBtn_OK.Enabled = false;
                    addNewStudentBtn_Reset.Enabled = true;
                }
                catch (Exception ex)
                {
                    errorSummaryMessage += "خطأ في الإدخال، لا يمكن الاتصال بقاعدة البيانات حالياً";
                    errorSummaryPanel.BackColor = Color.Red;
                    correctPictureBox.Visible = false;
                    incorrectPictureBox.Visible = true;
                }
            }
            else
            {
                errorSummaryPanel.BackColor = Color.Red;
                correctPictureBox.Visible = false;
                incorrectPictureBox.Visible = true;
            }
            errorSummaryLabel.Text = errorSummaryMessage;
            errorSummaryPanel.Visible = true;
        }

        private void addNewStudentBtn_Reset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            firstNameTextBox.Text = lastNameTextBox.Text = fatherTextBox.Text = motherTextBox.Text = nationalCardIDTextBox.Text = "";
            studentGradeNumericUpDown.Value = 0;
            educationalLevelLookUpEdit.EditValue = null;
            dateOfBirthDateEdit.EditValue = registeringDateDateEdit.EditValue = null;
            addNewStudentBtn_OK.Enabled = true;
            addNewStudentBtn_Reset.Enabled = false;
            errorSummaryPanel.Visible = false;
            studentPaidFeeCheckBox.Checked = false;
            feePeriodLookUpEdit.EditValue = feePayingDateDateEdit.EditValue = feeScholasticYearLookUpEdit.EditValue = null;
            voucherNumberTextBox.Text = voucherPreparedByTextBox.Text = "";
            firstNameTextBox.Focus();
        }

        private void addNewStudentBtn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void studentPaidFeeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            studentFeePanel.Visible = studentPaidFeeCheckBox.Checked;
        }

        private void educationalLevelLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (educationalLevelLookUpEdit.EditValue == null)
                selectedEdLv = null;
            else
                selectedEdLv = StaticCode.mainDbContext.EducationalLevelTbls.Single(el1 => el1.ID == Convert.ToInt32(educationalLevelLookUpEdit.EditValue));
            feePeriodLookUpEdit_EditValueChanged(sender, e);
        }

        private void manageFeePeriodTblBtn_Click(object sender, EventArgs e)
        {
            ManageFeePeriodTblForm mngfp = new ManageFeePeriodTblForm();
            mngfp.ShowDialog();
            this.feePeriodTblTableAdapter.Fill(this.kindergartenDbDataSet.FeePeriodTbl);
        }

        private void manageScholasticYearTblBtn_Click(object sender, EventArgs e)
        {
            ManageScholasticYearTblForm mngsch = new ManageScholasticYearTblForm();
            mngsch.ShowDialog();
            this.scholasticYearTblTableAdapter.Fill(this.kindergartenDbDataSet.ScholasticYearTbl);
        }

        private void feePeriodLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            feeAmountNumericUpDown.Value = 0;
            if (feePeriodLookUpEdit.EditValue == null || selectedEdLv == null)
                return;
            if (feePeriodLookUpEdit.Text == "شهري")
                feeAmountNumericUpDown.Value = Convert.ToDecimal(selectedEdLv.EducationalLevelMonthlyFee);
            if (feePeriodLookUpEdit.Text == "فصلي")
                feeAmountNumericUpDown.Value = Convert.ToDecimal(selectedEdLv.EducationalLevelSemesterFee);
            if (feePeriodLookUpEdit.Text == "سنوي")
                feeAmountNumericUpDown.Value = Convert.ToDecimal(selectedEdLv.EducationalLevelAnnualFee);
        }
    }
}