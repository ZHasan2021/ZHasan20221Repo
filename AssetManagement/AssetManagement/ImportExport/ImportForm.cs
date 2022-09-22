using AssetManagement.AuxTables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.Finance
{
    public partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SubDepartmentTbl' table. You can move, or remove it, as needed.
            this.subDepartmentTblTableAdapter.Fill(this.assetMngDbDataSet.SubDepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.DepartmentTbl' table. You can move, or remove it, as needed.
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SectionTbl' table. You can move, or remove it, as needed.
            this.sectionTblTableAdapter.Fill(this.assetMngDbDataSet.SectionTbl);
            this.MinimumSize = this.Size;
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(500, 400);
        }

        private void importBySectionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            importBySectionLookUpEdit.Visible = importBySectionRadioButton.Checked;
            importByDepartmentLookUpEdit.Visible = importByDepartmentRadioButton.Checked;
            importBySubDepartmentLookUpEdit.Visible = importBySubDepartmentRadioButton.Checked;
            manageSectionTblBtn.Visible = importBySectionRadioButton.Checked && StaticCode.activeUserRole.ManageSections == true;
            manageDepartmentTblBtn.Visible = importByDepartmentRadioButton.Checked && StaticCode.activeUserRole.ManageDepartments == true;
            manageSubDepartmentTblBtn.Visible = importBySubDepartmentRadioButton.Checked && StaticCode.activeUserRole.ManageSubDepartments == true;
        }

        private void manageDepartmentTblBtn_Click(object sender, EventArgs e)
        {
            ManageDepartmentTblForm dptFrm = new ManageDepartmentTblForm();
            dptFrm.ShowDialog();
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
        }

        private void manageSectionTblBtn_Click(object sender, EventArgs e)
        {
            ManageSectionTblForm sctFrm = new ManageSectionTblForm();
            sctFrm.ShowDialog();
            this.sectionTblTableAdapter.Fill(this.assetMngDbDataSet.SectionTbl);
        }

        private void manageSubDepartmentTblBtn_Click(object sender, EventArgs e)
        {
            ManageSubDepartmentTblForm sdptFrm = new ManageSubDepartmentTblForm();
            sdptFrm.ShowDialog();
            this.subDepartmentTblTableAdapter.Fill(this.assetMngDbDataSet.SubDepartmentTbl);

        }

        private void importData_OK_Click(object sender, EventArgs e)
        {
            if (importBySectionRadioButton.Checked && importBySectionLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر الدائرة أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (importByDepartmentRadioButton.Checked && importByDepartmentLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر القسم أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (importBySubDepartmentRadioButton.Checked && importBySubDepartmentLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر الوحدة أولاً", StaticCode.ApplicationTitle);
                return;
            }
            OpenFileDialog encFileOFD = new OpenFileDialog() { Filter = (decryptImportedFileCheckBox.Checked) ? "encrypted database file (*.assf)|*.assf" : "Excel worbook 2007-2022 (*.xlsx)|*.xlsx" };
            if (encFileOFD.ShowDialog() != DialogResult.OK)
            {
                mainAlertControl.Show(this, "تم الإلغاء", StaticCode.ApplicationTitle);
                return;
            }
            string importedExcelFilePath = encFileOFD.FileName;
            if (MessageBox.Show("هل أنت متأكد من رغبتك في الاستيراد؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            try
            {
                if (decryptImportedFileCheckBox.Checked)
                {
                    FileStream AesKey_IV_Rd = File.Open(StaticCode.AesKeyAndIVPath, FileMode.OpenOrCreate);
                    byte[] AesKey_IV_Dec = new byte[48];
                    AesKey_IV_Rd.Read(AesKey_IV_Dec, 0, 48);
                    AesKey_IV_Rd.Close();
                    byte[] AesKey = new byte[32];
                    byte[] AesIV = new byte[16];
                    Array.Copy(AesKey_IV_Dec, 0, AesKey, 0, 32);
                    Array.Copy(AesKey_IV_Dec, 32, AesIV, 0, 16);
                    //byte[] outBytes_enc = Encoding.UTF8.GetBytes(encryptedStr);
                    importedExcelFilePath = encFileOFD.FileName.Replace(".assf", ".xlsx");
                    bool decrypted = StaticCode.AesDecryption(encFileOFD.FileName, importedExcelFilePath, AesKey, AesIV);
                    if (!decrypted)
                    {
                        mainAlertControl.Show(this, "الملف المستورد غير صالح أو أن مفاتيح فك التشفير تم تغييرها ولا تطابق مفاتيح التشفير", StaticCode.ApplicationTitle);
                        return;
                    }
                }

                StaticCode.ImportDataFromExcel(importedExcelFilePath);

                ImportExportTbl newImport = new ImportExportTbl()
                {
                    ActionDate = DateTime.Today.AddDays(StaticCode.appOptions.ShiftDays),
                    ImportOrExport = "استيراد",
                    ActionByDepartment = (importByDepartmentRadioButton.Checked) ? importByDepartmentLookUpEdit.Text : "",
                    ActionBySection = (importBySectionRadioButton.Checked) ? importBySectionLookUpEdit.Text : "",
                    ActionBySubDepartment = (importBySubDepartmentRadioButton.Checked) ? importBySubDepartmentLookUpEdit.Text : "",
                    ActionNotes = notesTextBox.Text.Trim(),
                };
                StaticCode.mainDbContext.ImportExportTbls.InsertOnSubmit(newImport);
                StaticCode.mainDbContext.SubmitChanges();

                mainAlertControl.Show(this, "تم استيراد البيانات بشكل سليم وإضافة سجل تقرير حول العملية", StaticCode.ApplicationTitle);
            }
            catch
            {
                mainAlertControl.Show(this, "خطأ في الوصول إلى الملف، تأكد من سلامة الملف أولاً", StaticCode.ApplicationTitle);
            }
        }

        private void importData_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}