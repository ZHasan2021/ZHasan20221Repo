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

namespace AssetManagement.Finance
{
    public partial class ExportForm : Form
    {
        public ExportForm()
        {
            InitializeComponent();
        }

        private void ExportForm_Load(object sender, EventArgs e)
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
        }

        private void importBySectionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            exportBySectionLookUpEdit.Visible = exportBySectionRadioButton.Checked;
            exportByDepartmentLookUpEdit.Visible = exportByDepartmentRadioButton.Checked;
            exportBySubDepartmentLookUpEdit.Visible = exportBySubDepartmentRadioButton.Checked;
            manageSectionTblBtn.Visible = exportBySectionRadioButton.Checked && StaticCode.activeUserRole.ManageSections == true;
            manageDepartmentTblBtn.Visible = exportByDepartmentRadioButton.Checked && StaticCode.activeUserRole.ManageDepartments == true;
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

        private void importData_OK_Click(object sender, EventArgs e)
        {
            if (exportBySectionRadioButton.Checked && exportBySectionLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر الدائرة أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (exportByDepartmentRadioButton.Checked && exportByDepartmentLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر القسم أولاً", StaticCode.ApplicationTitle);
                return;
            }
            if (exportBySubDepartmentRadioButton.Checked && exportBySubDepartmentLookUpEdit.EditValue == null)
            {
                mainAlertControl.Show(this, "اختر الوحدة أولاً", StaticCode.ApplicationTitle);
                return;
            }
            var dataModel = new AttributeMappingSource().GetModel(typeof(AssetMngDbDataContext));
            var tbls = dataModel.GetTables();
            if (!Directory.Exists(StaticCode.ExportFolder))
                Directory.CreateDirectory(StaticCode.ExportFolder);
            string outFile1 = $"{StaticCode.ExportFolder}AssetMngDb{DateTime.Now.Ticks}.xlsx";
            SqlConnection dbConn = new SqlConnection(new Properties.Settings().AssetMngDbConnectionString);
            if (dbConn.State != ConnectionState.Open)
                dbConn.Open();
            try
            {
                using (ExcelPackage pck = new ExcelPackage(outFile1))
                {
                    foreach (var oneModel in tbls)
                    {
                        string oneTblName = oneModel.TableName.Replace("dbo.", "");
                        ExcelWorksheet ws = pck.Workbook.Worksheets[oneTblName];
                        if (ws == null)
                            ws = pck.Workbook.Worksheets.Add(oneTblName);
                        SqlDataAdapter dbAdpt = new SqlDataAdapter($"SELECT * FROM [{oneTblName}]", dbConn);
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

                        string outFile_Enc = outFile1.Replace("xlsx", "assf");
                        if (StaticCode.AesEncryption(outFile1, outFile_Enc, keyArr, IVArr))
                        {
                            File.Delete(outFile1);
                            mainAlertControl.Show(this, "تم تصدير قاعدة البيانات مشفرة بنجاح", StaticCode.ApplicationTitle, true);
                        }
                        else
                        {
                            mainAlertControl.Show(this, "لم يتم تصدير قاعدة البيانات المشفرة بسبب خطأ في مفتاح التشفير، يمكنك إعادة توليده مرة ثانية", StaticCode.ApplicationTitle, true);
                        }
                    }
                    catch
                    {
                        mainAlertControl.Show(this, "خطأ في تصدير ملف مشفر", StaticCode.ApplicationTitle, true);
                    }
                    #endregion
                }
                else
                {
                    mainAlertControl.Show(this, "تم تصدير قاعدة البيانات بنجاح", StaticCode.ApplicationTitle, true);
                }
            }
            catch
            {
                mainAlertControl.Show(this, "لم يتم تصدير قاعدة البيانات، حاولا لاحقاً", StaticCode.ApplicationTitle, true);
            }
        }

        private void importData_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}