using AssetManagement.AuxTables;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AssetManagement.AssetMngDbDataSet;

namespace AssetManagement.Finance
{
    public partial class ExportForm : Form
    {
        string tablesExported = "";
        public ExportForm()
        {
            InitializeComponent();
        }

        private void ExportForm_Load(object sender, EventArgs e)
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
                    unknownExportRadioButton.Checked = unknownExportRadioButton.Enabled = exportBySectionRadioButton.Checked = exportBySectionRadioButton.Enabled = false;
                    exportBySectionLookUpEdit.Enabled = false;
                    exportBySectionLookUpEdit.EditValue = StaticCode.activeUser.UserSection;
                    exportByDepartmentRadioButton_CheckedChanged(sender, e);
                    exportBySectionLookUpEdit.Visible = true;
                }
                catch
                {

                }
            }
            if (StaticCode.activeUserRole.IsDepartmentIndependent != true)
            {
                try
                {
                    unknownExportRadioButton.Checked = unknownExportRadioButton.Enabled = exportBySectionRadioButton.Checked = exportBySectionRadioButton.Enabled = exportByDepartmentRadioButton.Checked = exportByDepartmentRadioButton.Enabled = false;
                    exportBySectionLookUpEdit.Enabled = exportByDepartmentSearchLookUpEdit.Enabled = false;
                    exportBySectionLookUpEdit.EditValue = StaticCode.mainDbContext.DepartmentTbls.Single(dpt1 => dpt1.ID == StaticCode.activeUser.UserDept).SectionOfDepartment;
                    exportByDepartmentSearchLookUpEdit.EditValue = StaticCode.activeUser.UserDept;
                    exportBySectionLookUpEdit.Visible = exportByDepartmentSearchLookUpEdit.Visible = true;
                }
                catch
                {

                }
            }
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(500, 400);
        }

        private void exportBySectionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            exportBySectionLookUpEdit.Visible = exportBySectionRadioButton.Checked;
            if (exportBySectionRadioButton.Checked || !exportBySectionLookUpEdit.Enabled)
            {
                if (exportBySectionLookUpEdit.EditValue == null)
                    return;
                List<int> deptIDs = StaticCode.mainDbContext.DepartmentTbls.Where(dpt1 => dpt1.SectionOfDepartment == Convert.ToInt32(exportBySectionLookUpEdit.EditValue)).Select(dpt2 => dpt2.ID).ToList();
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
                exportBySubDepartmentSearchLookUpEdit.EditValue = null;
            }
            else
            {
                this.departmentVwTableAdapter.FillByQuery(this.assetMngDbDataSet.DepartmentVw, " WHERE 1 < 2;");
            }
            manageSectionTblBtn.Visible = exportBySectionRadioButton.Checked && StaticCode.activeUserRole.ManageSections == true;
        }

        private void exportByDepartmentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            exportByDepartmentSearchLookUpEdit.Visible = exportByDepartmentRadioButton.Checked;
            if (exportByDepartmentRadioButton.Checked || !exportByDepartmentSearchLookUpEdit.Enabled)
            {
                if (exportByDepartmentSearchLookUpEdit.EditValue == null)
                    return;
                List<int> subDeptIDs = StaticCode.mainDbContext.SubDepartmentTbls.Where(subd1 => subd1.MainDepartment == Convert.ToInt32(exportByDepartmentSearchLookUpEdit.EditValue)).Select(subd2 => subd2.ID).ToList();
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
                if (exportBySectionRadioButton.Checked || !exportBySectionLookUpEdit.Enabled)
                {
                    if (exportBySectionLookUpEdit.EditValue == null)
                        return;
                    var deptItems = StaticCode.mainDbContext.DepartmentTbls.Where(dpt1 => dpt1.SectionOfDepartment == Convert.ToInt32(exportBySectionLookUpEdit.EditValue));
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
            manageDepartmentTblBtn.Visible = exportByDepartmentRadioButton.Checked && StaticCode.activeUserRole.ManageDepartments == true;
        }

        private void exportBySubDepartmentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            exportBySubDepartmentSearchLookUpEdit.Visible = exportBySubDepartmentRadioButton.Checked;
            manageSubDepartmentTblBtn.Visible = exportBySubDepartmentRadioButton.Checked && StaticCode.activeUserRole.ManageSubDepartments == true;
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

        private void exportData_OK_Click(object sender, EventArgs e)
        {
            if (exportBySectionRadioButton.Checked && exportBySectionLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر الدائرة أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (exportByDepartmentRadioButton.Checked && exportByDepartmentSearchLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر القسم أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (exportBySubDepartmentRadioButton.Checked && exportBySubDepartmentSearchLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر الوحدة أولاً", StaticCode.ApplicationTitle);
                return;
            }

            var dataModel = new AttributeMappingSource().GetModel(typeof(AssetMngDbDataContext));
            var tbls = dataModel.GetTables();
            List<string> tbls2 = new List<string>();
            if (exportAssetsRadioButton.Checked)
            {
                tbls2 = new List<string>() { "AssetTbl" };
                tablesExported = "أصول وسجلات نقل وتصريف";
                tbls2.Add("AssetMovementTbl");
                tbls2.Add("AssetTransactionTbl");
            }
            if (exportFinancialItemsRadioButton.Checked)
            {
                tbls2 = new List<string>() { "FinancialItemTbl" };
                tablesExported = "سجلات مالية";
            }
            if (exportAssetsAndFinancialItemsRadioButton.Checked)
            {
                tbls2 = new List<string>() { "AssetTbl", "FinancialItemTbl" };
                tablesExported = "أصول وسجلات مالية وسجلات نقل وتصريف";
                tbls2.Add("AssetMovementTbl");
                tbls2.Add("AssetTransactionTbl");
            }
            if (!Directory.Exists(StaticCode.ExportFolder))
                Directory.CreateDirectory(StaticCode.ExportFolder);
            string outFile1 = $"Export{DateTime.Now.Ticks}{((exportBySectionRadioButton.Checked) ? $"-الدائرة {exportBySectionLookUpEdit.Text}" : "")}{((exportByDepartmentRadioButton.Checked) ? $"-القسم {exportByDepartmentSearchLookUpEdit.Text}" : "")}{((exportBySubDepartmentRadioButton.Checked) ? $"-الوحدة {exportBySubDepartmentSearchLookUpEdit.Text}" : "")}.xlsx";
            SaveFileDialog exportSFD = new SaveFileDialog() { Filter = (encryptExportedFileCheckBox.Checked) ? "encrypted database file (*.assf)|*.assf" : "Excel worbook 2007-2022 (*.xlsx)|*.xlsx", FileName = outFile1 };
            if (exportSFD.ShowDialog() != DialogResult.OK)
            {
                mainAlertControl.Show(this, "تم الإلغاء", StaticCode.ApplicationTitle);
                return;
            }
            SqlConnection dbConn = new SqlConnection(new Properties.Settings().AssetMngDbConnectionString);
            if (dbConn.State != ConnectionState.Open)
                dbConn.Open();
            string excelFilePath = exportSFD.FileName.Replace(".assf", ".xlsx");
            string encryptedFilePath = exportSFD.FileName.Replace(".xlsx", ".assf");
            try
            {
                using (ExcelPackage pck = new ExcelPackage(excelFilePath))
                {
                    foreach (var oneModel in tbls2)
                    {
                        //string oneTblName = oneModel.TableName.Replace("dbo.", "");
                        string oneTblName = oneModel;
                        ExcelWorksheet ws = pck.Workbook.Worksheets[oneTblName];
                        if (ws == null)
                            ws = pck.Workbook.Worksheets.Add(oneTblName);
                        string queryStr = $"SELECT * FROM [{oneTblName}]";
                        string fieldToFilter = "";
                        switch (oneTblName)
                        {
                            case "AssetTbl":
                                fieldToFilter = "AssetSubDepartment";
                                break;
                            case "FinancialItemTbl":
                                fieldToFilter = "FinancialItemSubDept";
                                break;
                            case "AssetMovementTbl":
                            case "AssetTransactionTbl":
                                fieldToFilter = "AssetID IN (SELECT ID FROM AssetTbl WHERE AssetSubDepartment";
                                break;
                            default:
                                break;
                        }
                        if (exportBySubDepartmentRadioButton.Checked)
                            queryStr += $" WHERE {fieldToFilter} = {exportBySubDepartmentSearchLookUpEdit.EditValue}";
                        if (exportByDepartmentRadioButton.Checked)
                            queryStr += $" WHERE {fieldToFilter} IN (SELECT ID FROM SubDepartmentTbl WHERE MainDepartment = {exportByDepartmentSearchLookUpEdit.EditValue})";
                        if (exportBySectionRadioButton.Checked)
                            queryStr += $" WHERE {fieldToFilter} IN (SELECT ID FROM SubDepartmentTbl WHERE MainDepartment IN (SELECT ID FROM SectionTbl WHERE ID = {exportBySectionLookUpEdit.EditValue}))";
                        if (oneTblName == "AssetMovementTbl" || oneTblName == "AssetTransactionTbl")
                        {
                            if (!unknownExportRadioButton.Checked)
                                queryStr += ")";
                        }
                        SqlDataAdapter dbAdpt = new SqlDataAdapter(queryStr, dbConn);
                        DataTable oneDt = new DataTable();
                        dbAdpt.Fill(oneDt);
                        if (oneDt.Rows.Count > 0)
                        {
                            using (var cells = ws.Cells[1, 1, oneDt.Rows.Count, oneDt.Columns.Count])
                            {
                                cells.Style.Numberformat.Format = "@";
                            }
                        }
                        ws.Cells["A1"].LoadFromDataTable(oneDt, true, OfficeOpenXml.Table.TableStyles.Light19);
                        pck.Save();
                    }
                }
                if (encryptExportedFileCheckBox.Checked)
                {
                    #region Aes encryption
                    if (!File.Exists(StaticCode.AesKeyAndIVPath))
                    {
                        if (MessageBox.Show("لا يوجد مفاتيح تشفير حالياً ونحتاج إلى توليد هذه المفاتيح، هل تريد المتابعة؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                            return;
                        StaticCode.GenerateNewAesKeyAndIV();
                    }
                    try
                    {
                        FileStream key_IVRdr = new FileStream(StaticCode.AesKeyAndIVPath, FileMode.Open);
                        byte[] keyArr = new byte[32];
                        byte[] IVArr = new byte[16];
                        key_IVRdr.Read(keyArr, 0, keyArr.Length);
                        key_IVRdr.Read(IVArr, 0, IVArr.Length);
                        key_IVRdr.Close();

                        if (StaticCode.AesEncryption(excelFilePath, encryptedFilePath, keyArr, IVArr))
                        {
                            File.Delete(excelFilePath);
                            mainAlertControl.Show(this, "تم تصدير قاعدة البيانات مشفرة بنجاح", StaticCode.ApplicationTitle, true);
                        }
                        else
                        {
                            if (File.Exists(excelFilePath))
                                File.Delete(excelFilePath);
                            if (File.Exists(encryptedFilePath))
                                File.Delete(encryptedFilePath);
                            mainAlertControl.Show(this, "لم يتم تصدير قاعدة البيانات المشفرة بسبب خطأ في مفتاح التشفير، يمكنك إعادة توليده مرة ثانية", StaticCode.ApplicationTitle, true);
                        }
                    }
                    catch
                    {
                        if (File.Exists(excelFilePath))
                            File.Delete(excelFilePath);
                        if (File.Exists(encryptedFilePath))
                            File.Delete(encryptedFilePath);
                        mainAlertControl.Show(this, "خطأ في تصدير ملف مشفر", StaticCode.ApplicationTitle, true);
                    }
                    #endregion
                }
                else
                {
                    mainAlertControl.Show(this, "تم تصدير قاعدة البيانات بنجاح", StaticCode.ApplicationTitle, true);
                }

                ImportExportTbl newExport = new ImportExportTbl()
                {
                    ActionDate = DateTime.Today.AddDays(StaticCode.appOptions.ShiftDays),
                    ImportOrExport = "تصدير",
                    TablesExported = tablesExported,
                    ActionByDepartment = (exportByDepartmentRadioButton.Checked) ? exportByDepartmentSearchLookUpEdit.Text : "",
                    ActionBySection = (exportBySectionRadioButton.Checked) ? exportBySectionLookUpEdit.Text : "",
                    ActionBySubDepartment = (exportBySubDepartmentRadioButton.Checked) ? exportBySubDepartmentSearchLookUpEdit.Text : "",
                    ActionNotes = notesTextBox.Text.Trim(),
                };
                StaticCode.mainDbContext.ImportExportTbls.InsertOnSubmit(newExport);
                StaticCode.mainDbContext.SubmitChanges();
            }
            catch
            {
                if (File.Exists(excelFilePath))
                    File.Delete(excelFilePath);
                if (File.Exists(encryptedFilePath))
                    File.Delete(encryptedFilePath);
                mainAlertControl.Show(this, "لم يتم تصدير قاعدة البيانات، حاولا لاحقاً", StaticCode.ApplicationTitle, true);
            }
        }

        private void exportData_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exportAssetsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}