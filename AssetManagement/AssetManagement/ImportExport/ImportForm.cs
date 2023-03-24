using AssetManagement.AuxTables;
using OfficeOpenXml;
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
using static AssetManagement.AssetMngDbDataSet;

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
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SubDepartmentVw' table. You can move, or remove it, as needed.
            this.subDepartmentVwTableAdapter.Fill(this.assetMngDbDataSet.SubDepartmentVw);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.DepartmentVw' table. You can move, or remove it, as needed.
            this.departmentVwTableAdapter.Fill(this.assetMngDbDataSet.DepartmentVw);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SubDepartmentTbl' table. You can move, or remove it, as needed.
            this.subDepartmentTblTableAdapter.Fill(this.assetMngDbDataSet.SubDepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.DepartmentTbl' table. You can move, or remove it, as needed.
            this.departmentTblTableAdapter.Fill(this.assetMngDbDataSet.DepartmentTbl);
            // TODO: This line of code loads data into the 'assetMngDbDataSet.SectionTbl' table. You can move, or remove it, as needed.
            this.sectionTblTableAdapter.Fill(this.assetMngDbDataSet.SectionTbl);
            this.MinimumSize = this.Size;

            if (StaticCode.activeUserRole.IsSectionIndependent != true)
            {
                try
                {
                    unknownImportRadioButton.Checked = unknownImportRadioButton.Enabled = importBySectionRadioButton.Checked = importBySectionRadioButton.Enabled = false;
                    importBySectionLookUpEdit.Enabled = false;
                    importBySectionLookUpEdit.EditValue = StaticCode.activeUser.UserSection;
                    importByDepartmentRadioButton_CheckedChanged(sender, e);
                    importBySectionLookUpEdit.Visible = true;
                }
                catch
                {

                }
            }
            if (StaticCode.activeUserRole.IsDepartmentIndependent != true)
            {
                try
                {
                    unknownImportRadioButton.Checked = unknownImportRadioButton.Enabled = importBySectionRadioButton.Checked = importBySectionRadioButton.Enabled = importByDepartmentRadioButton.Checked = importByDepartmentRadioButton.Enabled = false;
                    importBySectionLookUpEdit.Enabled = importByDepartmentSearchLookUpEdit.Enabled = false;
                    importBySectionLookUpEdit.EditValue = StaticCode.mainDbContext.DepartmentTbls.Single(dpt1 => dpt1.ID == StaticCode.activeUser.UserDept).SectionOfDepartment;
                    importByDepartmentSearchLookUpEdit.EditValue = StaticCode.activeUser.UserDept;
                    importBySectionLookUpEdit.Visible = importByDepartmentSearchLookUpEdit.Visible = true;
                }
                catch
                {

                }
            }
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 150);
            e.AlertForm.Location = new Point(200, 200);
        }

        private void importBySectionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            importBySectionLookUpEdit.Visible = importBySectionRadioButton.Checked;
            if (importBySectionRadioButton.Checked || !importBySectionLookUpEdit.Enabled)
            {
                if (importBySectionLookUpEdit.EditValue == null)
                    return;
                List<int> deptIDs = StaticCode.mainDbContext.DepartmentTbls.Where(dpt1 => dpt1.SectionOfDepartment == Convert.ToInt32(importBySectionLookUpEdit.EditValue)).Select(dpt2 => dpt2.ID).ToList();
                string plusQry = "";
                if (deptIDs.Count() == 0)
                    plusQry = " WHERE 1 > 2;";
                else
                {
                    foreach (int oneID in deptIDs)
                        plusQry += oneID + ", ";
                    plusQry = $" WHERE [معرف القسم] IN ({ plusQry.Trim().Trim(',').Trim()});";
                }
                DepartmentVwDataTable customVw = this.assetMngDbDataSet.DepartmentVw;
                for (int i = 0; i < customVw.Rows.Count; i++)
                {
                    try
                    {
                        var oneRow = customVw.Rows[i];
                        object[] oneRowItemArray = oneRow.ItemArray;
                        if (deptIDs.IndexOf(Convert.ToInt32(oneRowItemArray[0])) == -1)
                            customVw.Rows.Remove(oneRow);
                    }
                    catch
                    {
                        this.departmentVwTableAdapter.FillByQuery(this.assetMngDbDataSet.DepartmentVw, " WHERE 1 < 2;");
                        return;
                    }
                }
                this.departmentVwTableAdapter.FillByQuery(customVw, plusQry);
                importBySubDepartmentSearchLookUpEdit.EditValue = null;
            }
            else
            {
                this.departmentVwTableAdapter.FillByQuery(this.assetMngDbDataSet.DepartmentVw, " WHERE 1 < 2;");
            }
            manageSectionTblBtn.Visible = importBySectionRadioButton.Checked && StaticCode.activeUserRole.ManageSections == true;
        }

        private void importByDepartmentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            importByDepartmentSearchLookUpEdit.Visible = importByDepartmentRadioButton.Checked;
            if (importByDepartmentRadioButton.Checked || !importByDepartmentSearchLookUpEdit.Enabled)
            {
                if (importByDepartmentSearchLookUpEdit.EditValue == null)
                    return;
                List<int> subDeptIDs = StaticCode.mainDbContext.SubDepartmentTbls.Where(subd1 => subd1.MainDepartment == Convert.ToInt32(importByDepartmentSearchLookUpEdit.EditValue)).Select(subd2 => subd2.ID).ToList();
                string plusQry = "";
                if (subDeptIDs.Count() == 0)
                    plusQry = " WHERE 1 > 2;";
                else
                {
                    foreach (int oneID in subDeptIDs)
                        plusQry += oneID + ", ";
                    plusQry = $" WHERE [معرف الوحدة] IN ({ plusQry.Trim().Trim(',').Trim()});";
                }
                SubDepartmentVwDataTable customVw = this.assetMngDbDataSet.SubDepartmentVw;
                for (int i = 0; i < customVw.Rows.Count; i++)
                {
                    try
                    {
                        var oneRow = customVw.Rows[i];
                        object[] oneRowItemArray = oneRow.ItemArray;
                        if (subDeptIDs.IndexOf(Convert.ToInt32(oneRowItemArray[0])) == -1)
                            customVw.Rows.Remove(oneRow);
                    }
                    catch
                    {
                        this.subDepartmentVwTableAdapter.FillByQuery(this.assetMngDbDataSet.SubDepartmentVw, " WHERE 1 < 2;");
                        return;
                    }
                }
                this.subDepartmentVwTableAdapter.FillByQuery(customVw, plusQry);
            }
            else
            {
                if (importBySectionRadioButton.Checked || !importBySectionLookUpEdit.Enabled)
                {
                    if (importBySectionLookUpEdit.EditValue == null)
                        return;
                    var deptItems = StaticCode.mainDbContext.DepartmentTbls.Where(dpt1 => dpt1.SectionOfDepartment == Convert.ToInt32(importBySectionLookUpEdit.EditValue));
                    List<int> dptIds = deptItems.Select(dpt2 => dpt2.ID).ToList();
                    List<int> subDeptIDs = StaticCode.mainDbContext.SubDepartmentTbls.Where(subd1 => dptIds.Contains(subd1.MainDepartment)).Select(subd2 => subd2.ID).ToList();
                    string plusQry = "";
                    if (subDeptIDs.Count() == 0)
                        plusQry = " WHERE 1 > 2;";
                    else
                    {
                        foreach (int oneID in subDeptIDs)
                            plusQry += oneID + ", ";
                        plusQry = $" WHERE [معرف الوحدة] IN ({ plusQry.Trim().Trim(',').Trim()});";
                    }
                    SubDepartmentVwDataTable customVw = this.assetMngDbDataSet.SubDepartmentVw;
                    for (int i = 0; i < customVw.Rows.Count; i++)
                    {
                        try
                        {
                            var oneRow = customVw.Rows[i];
                            object[] oneRowItemArray = oneRow.ItemArray;
                            if (subDeptIDs.IndexOf(Convert.ToInt32(oneRowItemArray[0])) == -1)
                                customVw.Rows.Remove(oneRow);
                        }
                        catch
                        {
                            this.subDepartmentVwTableAdapter.FillByQuery(this.assetMngDbDataSet.SubDepartmentVw, " WHERE 1 < 2;");
                            return;
                        }
                    }
                    this.subDepartmentVwTableAdapter.FillByQuery(customVw, plusQry);
                }
                else
                {
                    this.subDepartmentVwTableAdapter.FillByQuery(this.assetMngDbDataSet.SubDepartmentVw, " WHERE 1 < 2;");
                }
            }
            manageDepartmentTblBtn.Visible = importByDepartmentRadioButton.Checked && StaticCode.activeUserRole.ManageDepartments == true;
        }

        private void importBySubDepartmentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            importBySubDepartmentSearchLookUpEdit.Visible = importBySubDepartmentRadioButton.Checked;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importData_OK_Click(object sender, EventArgs e)
        {
            if (importBySectionRadioButton.Checked && importBySectionLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر الدائرة أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (importByDepartmentRadioButton.Checked && importByDepartmentSearchLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر القسم أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (importBySubDepartmentRadioButton.Checked && importBySubDepartmentSearchLookUpEdit.EditValue == null)
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

                ExcelPackage impEp = new ExcelPackage(new FileInfo(importedExcelFilePath));
                ExcelWorkbook impWb = impEp.Workbook;
                if (!impWb.Worksheets.Any(ws1 => ws1.Name == "AssetTbl" || ws1.Name == "FinancialIremTbl"))
                {
                    mainAlertControl.Show(this, "الملف لا يحوي أوراق عمل خاصة بالأصول أو السجلات المالية، لا يمكن المتابعة", StaticCode.ApplicationTitle);
                    if (decryptImportedFileCheckBox.Checked)
                    {
                        if (File.Exists(importedExcelFilePath))
                            File.Delete(importedExcelFilePath);
                    }
                }

                List<int> subDeptList = StaticCode.mainDbContext.SubDepartmentTbls.Select(sdpt1 => sdpt1.ID).ToList();
                if (importBySubDepartmentRadioButton.Checked)
                    subDeptList.Add(Convert.ToInt32(importBySectionLookUpEdit.EditValue));
                else if (importByDepartmentRadioButton.Checked)
                    subDeptList = StaticCode.mainDbContext.SubDepartmentTbls.Where(subd1 => subd1.MainDepartment == Convert.ToInt32(importByDepartmentSearchLookUpEdit.EditValue)).Select(subd2 => subd2.ID).ToList();
                else if (importBySectionRadioButton.Checked)
                {
                    List<int> deptList = StaticCode.mainDbContext.DepartmentTbls.Where(dpt1 => dpt1.SectionOfDepartment == Convert.ToInt32(importBySectionLookUpEdit.EditValue)).Select(dpt2 => dpt2.ID).ToList();
                    subDeptList = StaticCode.mainDbContext.SubDepartmentTbls.Where(subd1 => deptList.Contains(subd1.MainDepartment)).Select(subd2 => subd2.ID).ToList();
                }
                List<string> newAssets = new List<string>();
                List<string> updatedAssets = new List<string>();
                List<string> invalideAssets = new List<string>();
                List<string> newFinancialItems = new List<string>();
                List<string> updatedFinancialItems = new List<string>();
                List<string> invalideFinancialItems = new List<string>();
                StaticCode.ImportDataFromExcel(importedExcelFilePath, subDeptList, out newAssets, out updatedAssets, out invalideAssets, out newFinancialItems, out updatedFinancialItems, out invalideFinancialItems);

                string importReport = $"الاستيراد من قاعدة بيانات:\r\nالأصول المضافة ({newAssets.Count}): {String.Join(",", newAssets.ToArray())}\r\nالأصول المحدثة ({updatedAssets.Count}): {String.Join(",", updatedAssets.ToArray())}\r\nالأصول ذات بيانات خاطئة ({invalideAssets.Count}): {String.Join(",", invalideAssets.ToArray())}\r\nالسجلات المالية المضافة ({newFinancialItems.Count}): {String.Join(",", newFinancialItems.ToArray())}\r\nالسجلات المالية المحدثة ({updatedFinancialItems.Count}): {String.Join(",", updatedFinancialItems.ToArray())}\r\nالسجلات المالية ذات بيانات خاطئة ({invalideFinancialItems.Count}): {String.Join(",", invalideFinancialItems.ToArray())}";

                ImportExportTbl newImport = new ImportExportTbl()
                {
                    ActionDate = DateTime.Today.AddDays(StaticCode.appOptions.ShiftDays),
                    ImportOrExport = "استيراد",
                    ActionByDepartment = (importByDepartmentRadioButton.Checked) ? importByDepartmentSearchLookUpEdit.Text : "",
                    ActionBySection = (importBySectionRadioButton.Checked) ? importBySectionLookUpEdit.Text : "",
                    ActionBySubDepartment = (importBySubDepartmentRadioButton.Checked) ? importBySubDepartmentSearchLookUpEdit.Text : "",
                    ActionNotes = importReport + "\r\n-------------\r\n" + notesTextBox.Text.Trim(),
                };
                StaticCode.mainDbContext.ImportExportTbls.InsertOnSubmit(newImport);
                StaticCode.mainDbContext.SubmitChanges();

                if (decryptImportedFileCheckBox.Checked)
                {
                    if (File.Exists(importedExcelFilePath))
                        File.Delete(importedExcelFilePath);
                }

                mainAlertControl.Show(this, "تم استيراد البيانات بشكل سليم وإضافة سجل تقرير حول العملية", StaticCode.ApplicationTitle);
                StaticCode.activeUserLogin.SessionActions += $"استيراد بيانات{((importBySectionRadioButton.Checked) ? $" ضمن دائرة {importBySectionLookUpEdit.Text}" : "")}{((importByDepartmentRadioButton.Checked) ? $" ضمن قسم {importByDepartmentSearchLookUpEdit.Text}" : "")}{((importBySubDepartmentRadioButton.Checked) ? $" ضمن وحدة {importBySubDepartmentSearchLookUpEdit.Text}" : "")} - {DateTime.Now.AddDays(StaticCode.appOptions.ShiftDays).AddSeconds(StaticCode.appOptions.ShiftSeconds)}\r\n";
            }
            catch
            {
                if (decryptImportedFileCheckBox.Checked)
                {
                    if (File.Exists(importedExcelFilePath))
                        File.Delete(importedExcelFilePath);
                }
                mainAlertControl.Show(this, "خطأ في الوصول إلى الملف، تأكد من سلامة الملف أولاً", StaticCode.ApplicationTitle);
            }
        }

        private void importData_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}