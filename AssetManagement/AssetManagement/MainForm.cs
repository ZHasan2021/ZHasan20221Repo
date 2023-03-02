using AssetManagement.Assets;
using AssetManagement.AuxTables;
using AssetManagement.Finance;
using AssetManagement.Options;
using AssetManagement.Properties;
using AssetManagement.Users;
using DevExpress.XtraReports.UI;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        IQueryable<AssetTbl> assetsToDestructList = null;
        IQueryable<AssetTbl> destructedAssetsList = null;
        IQueryable<AssetTbl> assetsWithoutPurchaseDateList = null;
        IQueryable<AssetTbl> missingDataAssetsList = null;
        int timer3 = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Form
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;

            ApplyUserRolesOnInterface();
            //CheckAssetsNotifications();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StaticCode.activeUser.UserNotes = mainMemoEdit.EditValue?.ToString();
            StaticCode.mainDbContext.SubmitChanges();
            if (MessageBox.Show("هل تريد بالتاكيد إغلاق البرنامج؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            appDateBarStaticItem.Caption = DateTime.Today.AddDays(StaticCode.appOptions.ShiftDays).ToString("dddd, MMMM dd, yyyy");
            appTimeBarStaticItem.Caption = DateTime.Now.AddSeconds(StaticCode.appOptions.ShiftSeconds).ToLongTimeString();
            timer3++;
            if (timer3 == 3)
            {
                CheckAssetsNotifications();
            }
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 200);
            e.AlertForm.BackColor = Color.DarkGreen;
            e.AlertForm.ForeColor = Color.Black;
            e.AlertForm.StartPosition = FormStartPosition.Manual;
            e.AlertForm.Location = new Point(200, 200);
        }
        #endregion

        #region Import/Export
        private void manageImportExportTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageImportExportTblForm ieFrm = new ManageImportExportTblForm();
            ieFrm.ShowDialog();
        }

        private void exportDataBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportForm expFrm = new ExportForm();
            expFrm.ShowDialog();
        }

        private void importDataBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ImportForm impFrm = new ImportForm();
            impFrm.ShowDialog();
            timer3 = 0;
        }
        #endregion

        #region Assets
        private void CheckAssetsNotifications()
        {
            assetsToDestructList = StaticCode.GetAssetsToDestruct();
            destructedAssetsList = StaticCode.GetDestructedWithoutTransactionAssets();
            assetsWithoutPurchaseDateList = StaticCode.GetAssetsWithoutPurchaseDate();
            missingDataAssetsList = StaticCode.GetMissingDataAssets();

            if (assetsToDestructList.Any() || destructedAssetsList.Any() || assetsWithoutPurchaseDateList.Any() || missingDataAssetsList.Any())
            {
                breakingAlertControl.Show(this, StaticCode.ApplicationTitle, $"لديك بعض الإشعارات بخصوص بيانات الأصول وفق التفاصيل التالية:\r\nعدد الأصول التي أوشكت على انتهاء عمرها الإنتاجي ({assetsToDestructList.Count()})\r\nعدد الأصول التي انتهى عمرها الإنتاجي ولم يتم تصريفها ({destructedAssetsList.Count()})\r\nعدد الأصول التي لا تملك تواريخ شراء ({assetsWithoutPurchaseDateList.Count()})\r\nعدد الأصول ذات البيانات الناقصة ({missingDataAssetsList.Count()})");

                if (destructedAssetsList.Any())
                {
                    if (StaticCode.activeUserRole.ManageAssetTbl == true)
                    {
                        ManageAssetTblForm desFrm1 = new ManageAssetTblForm(destructedAssetsList, "الأصول التي انتهى عمرها الإنتاجي ولم يتم تصريفها");
                        desFrm1.ShowDialog();
                    }
                }
                if (missingDataAssetsList.Any())
                {
                    if (StaticCode.activeUserRole.ManageAssetTbl == true)
                    {
                        ManageAssetTblForm desFrm2 = new ManageAssetTblForm(missingDataAssetsList, "الأصول ذات البيانات الناقصة");
                        desFrm2.ShowDialog();
                    }
                }
            }
            else
            {
                breakingAlertControl.Show(this, StaticCode.ApplicationTitle, "لا يوجد إشعارات");
            }
        }

        private void addNewAssetBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddNewAssetForm newAsstFrm = new AddNewAssetForm();
            DialogResult frmRes = newAsstFrm.ShowDialog();
            if (frmRes == DialogResult.OK)
                mainAlertControl.Show(this, "تم إضافة الأصل بنجاح", StaticCode.ApplicationTitle);
        }

        private void manageAssetTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CustomAssetsForm cuFrm = new CustomAssetsForm();
            cuFrm.ShowDialog();
        }

        private void addNewAssetMovementBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MoveAssetForm mvFrm = new MoveAssetForm();
            mvFrm.ShowDialog();
        }

        private void addNewAssetTransactionBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TransacteAssetForm trsFrm = new TransacteAssetForm();
            trsFrm.ShowDialog();
        }

        private void manageAssetMovementTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageAssetMovementTblForm astmvFrm = new ManageAssetMovementTblForm();
            astmvFrm.ShowDialog();
        }

        private void manageAssetTransactionTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageAssetTransactionTblForm asttsFrm = new ManageAssetTransactionTblForm();
            asttsFrm.ShowDialog();
        }

        private void addNewAssetInventoryBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewAssetInventoryForm invFrm = new NewAssetInventoryForm();
            invFrm.ShowDialog();
        }

        private void manageAssetInventoryTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void deleteAssetsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteAssetForm dFrm = new DeleteAssetForm();
            dFrm.ShowDialog();
        }

        private void viewReportsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AssetsXtraReport2 repFrm = new AssetsXtraReport2();
            repFrm.ShowPreviewDialog();
        }

        private void updateExistedAssetBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateExistedAssetForm updFrm = new UpdateExistedAssetForm();
            updFrm.ShowDialog();
        }

        private void viewStatsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AssetsStatsForm3 statFrm = new AssetsStatsForm3();
            statFrm.ShowDialog();
        }

        private void destructedAssetsBarStaticItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageAssetTblForm desFrm = new ManageAssetTblForm(destructedAssetsList, "الأصول التي انتهى عمرها الإنتاجي ولم يتم تصريفها");
            desFrm.ShowDialog();
        }

        private void fromGeneralFormBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ImportAssetsFromExcel(sender, e, 1);
        }

        private void fromEstatesFormBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ImportAssetsFromExcel(sender, e, 2);
        }

        private void fromVehiclesFormBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ImportAssetsFromExcel(sender, e, 3);
        }

        private void fromAssetsMovementsFormBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            actionsStatusBarStaticItem.Caption = "";
            OpenFileDialog assetsFileOFD = new OpenFileDialog() { Filter = "Excel worbook 2007-2022 (*.xlsx)|*.xlsx", Title = "فتح ملف بيانات نقل أصول" };
            if (assetsFileOFD.ShowDialog() != DialogResult.OK)
            {
                mainAlertControl.Show(this, "تم الإلغاء", StaticCode.ApplicationTitle);
                return;
            }
            actionsStatusMemoEdit.Text = "";

            mainProgressPanel.Visible = true;
            ExcelPackage astEp = new ExcelPackage(new FileInfo(assetsFileOFD.FileName));
            ExcelWorkbook astWb = astEp.Workbook;
            ExcelWorksheet astWs = astWb.Worksheets.First();
            List<string> nonExistedAssets = new List<string>();
            List<string> mvColumnsHeaders = astWs.Cells.Where(cl1 => cl1.Start.Row == 1 && cl1.End.Row == 1).Select(cl2 => cl2.Value?.ToString()).ToList();
            int assetCodeCol = mvColumnsHeaders.IndexOf("معلومات الأصل") + 1;
            if (assetCodeCol == 0)
            {
                mainAlertControl.Show(this, "عمود (كود الأصل) مفقود، لا يمكن المتابعة في الاستيراد", StaticCode.ApplicationTitle);
                mainProgressPanel.Visible = false;
                return;
            }
            int movedFieldCol = mvColumnsHeaders.IndexOf("الحقل المحدث بعملية النقل") + 1;
            if (movedFieldCol == 0)
            {
                mainAlertControl.Show(this, "عمود (الحقل المحدث بعملية النقل) مفقود، لا يمكن المتابعة في الاستيراد", StaticCode.ApplicationTitle);
                mainProgressPanel.Visible = false;
                return;
            }
            int mvFromCol = mvColumnsHeaders.IndexOf("من") + 1;
            if (mvFromCol == 0)
            {
                mainAlertControl.Show(this, "عمود (القيمة الحالية) مفقود، لا يمكن المتابعة في الاستيراد", StaticCode.ApplicationTitle);
                mainProgressPanel.Visible = false;
                return;
            }
            int mvToCol = mvColumnsHeaders.IndexOf("إلى") + 1;
            if (mvToCol == 0)
            {
                mainAlertControl.Show(this, "عمود (القيمة الجديدة) مفقود، لا يمكن المتابعة في الاستيراد", StaticCode.ApplicationTitle);
                mainProgressPanel.Visible = false;
                return;
            }
            int mvDateCol = mvColumnsHeaders.IndexOf("تاريخ النقل") + 1;
            if (mvDateCol == 0)
            {
                mainAlertControl.Show(this, "عمود (تاريخ النقل) مفقود، لا يمكن المتابعة في الاستيراد", StaticCode.ApplicationTitle);
                mainProgressPanel.Visible = false;
                return;
            }

            int addedRecordsCount = 0;
            int existedRecordsCount = 0;
            int notAddedRecordsCount = 0;

            for (int iRow = 2; iRow <= astWs.Dimension.End.Row; iRow++)
            {
                Application.DoEvents();
                try
                {
                    string assetCodeVal = astWs.Cells[iRow, assetCodeCol].Value?.ToString();
                    string movedFieldVal = astWs.Cells[iRow, movedFieldCol].Value?.ToString();
                    string mvFromVal = astWs.Cells[iRow, mvFromCol].Value?.ToString();
                    string mvToVal = astWs.Cells[iRow, mvToCol].Value?.ToString();
                    DateTime mvDateVal = new DateTime(1899, 12, 30).AddDays(Convert.ToInt32(astWs.Cells[iRow, mvDateCol].Value?.ToString()));

                    var existedAsset = StaticCode.mainDbContext.AssetTbls.Where(ast1 => ast1.AssetCode == assetCodeVal);
                    if (existedAsset == null || existedAsset.Count() == 0)
                    {
                        nonExistedAssets.Add(assetCodeVal);
                        continue;
                    }
                    AssetTbl assetToAddMovement = existedAsset.First();
                    var existedRecords = StaticCode.mainDbContext.AssetMovementTbls.Where(asmv1 => asmv1.AssetID == assetToAddMovement.ID && asmv1.MovementDate == mvDateVal && asmv1.FieldChanged == movedFieldVal && asmv1.OldValue == mvFromVal && asmv1.NewValue == mvToVal);
                    if (existedRecords.Count() > 0)
                    {
                        existedRecordsCount++;
                        continue;
                    }
                    StaticCode.mainDbContext.AssetMovementTbls.InsertOnSubmit(new AssetMovementTbl()
                    {
                        AssetID = assetToAddMovement.ID,
                        MovementDate = mvDateVal,
                        FieldChanged = movedFieldVal,
                        OldValue = mvFromVal,
                        NewValue = mvToVal,
                    });
                    addedRecordsCount++;
                }
                catch
                {
                    notAddedRecordsCount++;
                    continue;
                }
            }

            StaticCode.mainDbContext.SubmitChanges();
            string importNotes = $"1- عدد السجلات الموجودة مسبقاً والتي لم يتم تحديثها ({existedRecordsCount})\r\n2- عدد الأصول المضمنة في الملف وغير موجودة في سجلات الأصول ({nonExistedAssets.Count()})\r\n3- عدد سجلات النقل المضافة ({addedRecordsCount})\r\n4- عدد سجلات النقل غير المضافة نتيجة خطأ في إحدى القيم ({notAddedRecordsCount})";
            ImportExportTbl newImport = new ImportExportTbl()
            {
                ActionDate = DateTime.Today.AddDays(StaticCode.appOptions.ShiftDays),
                ImportOrExport = "استيراد",
                ActionBySection = (StaticCode.activeUser.UserSection == null) ? "" : StaticCode.mainDbContext.SectionTbls.Single(sct1 => sct1.ID == Convert.ToInt32(StaticCode.activeUser.UserSection)).SectionName,
                ActionByDepartment = (StaticCode.activeUser.UserDept == null) ? "" : StaticCode.mainDbContext.DepartmentTbls.Single(dpt1 => dpt1.ID == Convert.ToInt32(StaticCode.activeUser.UserDept)).DepartmentName,
                ActionBySubDepartment = "",
                TablesExported = "سجلات نقل أصول",
                ActionNotes = importNotes,
            };
            StaticCode.mainDbContext.ImportExportTbls.InsertOnSubmit(newImport);
            StaticCode.mainDbContext.SubmitChanges();
            actionsStatusMemoEdit.Text = $"تم استيراد سجلات نقل الأصول بنجاح:\r\n {importNotes}\r\n----------------\r\n راجع إدارة سجلات نقل الأصول للتأكد من ذلك";
            mainProgressPanel.Visible = false;
        }

        private void fromAssetsTransactionsFormBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            actionsStatusBarStaticItem.Caption = "";
            OpenFileDialog assetsFileOFD = new OpenFileDialog() { Filter = "Excel worbook 2007-2022 (*.xlsx)|*.xlsx", Title = "فتح ملف بيانات تصريف أصول" };
            if (assetsFileOFD.ShowDialog() != DialogResult.OK)
            {
                mainAlertControl.Show(this, "تم الإلغاء", StaticCode.ApplicationTitle);
                return;
            }
            actionsStatusMemoEdit.Text = "";

            mainProgressPanel.Visible = true;
            ExcelPackage astEp = new ExcelPackage(new FileInfo(assetsFileOFD.FileName));
            ExcelWorkbook astWb = astEp.Workbook;
            ExcelWorksheet astWs = astWb.Worksheets.First();
            List<string> nonExistedAssets = new List<string>();
            List<string> mvColumnsHeaders = astWs.Cells.Where(cl1 => cl1.Start.Row == 1 && cl1.End.Row == 1).Select(cl2 => cl2.Value?.ToString()).ToList();
            int assetCodeCol = mvColumnsHeaders.IndexOf("معلومات الأصل") + 1;
            if (assetCodeCol == 0)
            {
                mainAlertControl.Show(this, "عمود (كود الأصل) مفقود، لا يمكن المتابعة في الاستيراد", StaticCode.ApplicationTitle);
                mainProgressPanel.Visible = false;
                return;
            }
            int trCategoryCol = mvColumnsHeaders.IndexOf("نوع التصريف") + 1;
            if (trCategoryCol == 0)
            {
                mainAlertControl.Show(this, "عمود (نوع التصريف) مفقود، لا يمكن المتابعة في الاستيراد", StaticCode.ApplicationTitle);
                mainProgressPanel.Visible = false;
                return;
            }
            int trQuantityCol = mvColumnsHeaders.IndexOf("العدد") + 1;
            if (trQuantityCol == 0)
            {
                mainAlertControl.Show(this, "عمود (العدد) مفقود، لا يمكن المتابعة في الاستيراد", StaticCode.ApplicationTitle);
                mainProgressPanel.Visible = false;
                return;
            }
            int trSellPriceCol = mvColumnsHeaders.IndexOf("مبلغ البيع") + 1;
            if (trSellPriceCol == 0)
            {
                mainAlertControl.Show(this, "عمود (مبلغ البيع) مفقود، لا يمكن المتابعة في الاستيراد", StaticCode.ApplicationTitle);
                mainProgressPanel.Visible = false;
                return;
            }
            int trSellPriceCurrCol = mvColumnsHeaders.IndexOf("عملة مبلغ البيع") + 1;
            if (trSellPriceCurrCol == 0)
            {
                mainAlertControl.Show(this, "عمود (عملة مبلغ البيع) مفقود، لا يمكن المتابعة في الاستيراد", StaticCode.ApplicationTitle);
                mainProgressPanel.Visible = false;
                return;
            }
            int trGetOutOfWorkCol = mvColumnsHeaders.IndexOf("إخراج الأصل من الخدمة") + 1;
            if (trGetOutOfWorkCol == 0)
            {
                mainAlertControl.Show(this, "عمود (إخراج الأصل من الخدمة) مفقود، لا يمكن المتابعة في الاستيراد", StaticCode.ApplicationTitle);
                mainProgressPanel.Visible = false;
                return;
            }
            int trCurrPriceCol = mvColumnsHeaders.IndexOf("السعر الحالي مع الإهلاك") + 1;
            if (trCurrPriceCol == 0)
            {
                mainAlertControl.Show(this, "عمود (السعر الحالي مع الإهلاك) مفقود، لا يمكن المتابعة في الاستيراد", StaticCode.ApplicationTitle);
                mainProgressPanel.Visible = false;
                return;
            }
            int trNotesCol = mvColumnsHeaders.IndexOf("ملاحظات") + 1;
            if (trNotesCol == 0)
            {
                mainAlertControl.Show(this, "عمود (ملاحظات) مفقود، لا يمكن المتابعة في الاستيراد", StaticCode.ApplicationTitle);
                mainProgressPanel.Visible = false;
                return;
            }
            int trDateCol = mvColumnsHeaders.IndexOf("تاريخ التصريف") + 1;
            if (trDateCol == 0)
            {
                mainAlertControl.Show(this, "عمود (تاريخ التصريف) مفقود، لا يمكن المتابعة في الاستيراد", StaticCode.ApplicationTitle);
                mainProgressPanel.Visible = false;
                return;
            }

            int addedRecordsCount = 0;
            int existedRecordsCount = 0;
            int notAddedRecordsCount = 0;
            List<AssetTransactionTbl> importedRecords = new List<AssetTransactionTbl>();

            for (int iRow = 2; iRow <= astWs.Dimension.End.Row; iRow++)
            {
                Application.DoEvents();
                try
                {
                    string assetCodeVal = astWs.Cells[iRow, assetCodeCol].Value?.ToString();
                    string tmpVal = astWs.Cells[iRow, trCategoryCol].Value?.ToString();
                    int trCategoryVal = StaticCode.mainDbContext.TransactionTypeTbls.Single(tt1 => tt1.TransactionTypeName == tmpVal).ID;
                    double trQuantityVal = (astWs.Cells[iRow, trQuantityCol].Value?.ToString() == "") ? 0 : Convert.ToInt32(astWs.Cells[iRow, trQuantityCol].Value?.ToString());
                    if (trQuantityVal <= 0)
                    {
                        mainAlertControl.Show(this, $"العدد في السطر رقم {iRow} صفر أو سالب، لا يمكن المتابعة في الاستيراد", StaticCode.ApplicationTitle);
                        mainProgressPanel.Visible = false;
                        return;
                    }
                    double trSellPriceVal = (astWs.Cells[iRow, trSellPriceCol].Value?.ToString() == "") ? 0 : Convert.ToDouble(astWs.Cells[iRow, trSellPriceCol].Value?.ToString());
                    if (trSellPriceVal <= 0)
                    {
                        mainAlertControl.Show(this, $"السعر في السطر رقم {iRow} صفر أو سالب، لا يمكن المتابعة في الاستيراد", StaticCode.ApplicationTitle);
                        mainProgressPanel.Visible = false;
                        return;
                    }
                    tmpVal = astWs.Cells[iRow, trSellPriceCurrCol].Value?.ToString().Trim();
                    if (!StaticCode.mainDbContext.CurrencyTbls.Any(cu2 => cu2.CurrencyName == tmpVal))
                    {
                        mainAlertControl.Show(this, $"العملة في السطر رقم {iRow} غير موجودة في جدول العملات، لا يمكن المتابعة في الاستيراد", StaticCode.ApplicationTitle);
                        mainProgressPanel.Visible = false;
                        return;
                    }
                    int trSellPriceCurrVal = StaticCode.mainDbContext.CurrencyTbls.Single(cur1 => cur1.CurrencyName == tmpVal).ID;
                    bool trGetOutOfWorkVal = (astWs.Cells[iRow, trGetOutOfWorkCol].Value?.ToString() == "") ? false : Convert.ToBoolean(astWs.Cells[iRow, trGetOutOfWorkCol].Value?.ToString());
                    double trCurrPriceVal = Convert.ToDouble(astWs.Cells[iRow, trCurrPriceCol].Value?.ToString());
                    string trNotesVal = astWs.Cells[iRow, trNotesCol].Value?.ToString();
                    DateTime mvDateVal = new DateTime(1899, 12, 30).AddDays(Convert.ToInt32(astWs.Cells[iRow, trDateCol].Value?.ToString()));

                    var existedAsset = StaticCode.mainDbContext.AssetTbls.Where(ast1 => ast1.AssetCode == assetCodeVal);
                    if (existedAsset == null || existedAsset.Count() == 0)
                    {
                        nonExistedAssets.Add(assetCodeVal);
                        continue;
                    }
                    AssetTbl assetToAddMovement = existedAsset.First();
                    var existedRecords = StaticCode.mainDbContext.AssetTransactionTbls.Where(astr1 => astr1.AssetID == assetToAddMovement.ID && astr1.TransactionDate == mvDateVal && astr1.TransactionType == trCategoryVal && astr1.MoneyAmount == trSellPriceVal && astr1.GetAssetOutOfWork == trGetOutOfWorkVal);
                    if (existedRecords.Count() > 0)
                    {
                        existedRecordsCount++;
                        continue;
                    }
                    importedRecords.Add(new AssetTransactionTbl()
                    {
                        AssetID = assetToAddMovement.ID,
                        TransactionDate = mvDateVal,
                        TransactionType = trCategoryVal,
                        GetAssetOutOfWork = trGetOutOfWorkVal,
                        TransactionNotes = trNotesVal,
                        CurrentPriceWithDestroying = trCurrPriceVal,
                        MoneyAmount = trSellPriceVal,
                        MoneyAmountCurrency = trSellPriceCurrVal,
                    });
                    addedRecordsCount++;
                }
                catch
                {
                    notAddedRecordsCount++;
                    continue;
                }
            }

            StaticCode.mainDbContext.AssetTransactionTbls.InsertAllOnSubmit(importedRecords);
            string importNotes = $"1- عدد السجلات الموجودة مسبقاً والتي لم يتم تحديثها ({existedRecordsCount})\r\n2- عدد الأصول المضمنة في الملف وغير موجودة في سجلات الأصول ({nonExistedAssets.Count()})\r\n3- عدد سجلات التصريف المضافة ({addedRecordsCount})\r\n4- عدد سجلات التصريف غير المضافة نتيجة خطأ في إحدى القيم ({notAddedRecordsCount})";
            ImportExportTbl newImport = new ImportExportTbl()
            {
                ActionDate = DateTime.Today.AddDays(StaticCode.appOptions.ShiftDays),
                ImportOrExport = "استيراد",
                ActionBySection = (StaticCode.activeUser.UserSection == null) ? "" : StaticCode.mainDbContext.SectionTbls.Single(sct1 => sct1.ID == Convert.ToInt32(StaticCode.activeUser.UserSection)).SectionName,
                ActionByDepartment = (StaticCode.activeUser.UserDept == null) ? "" : StaticCode.mainDbContext.DepartmentTbls.Single(dpt1 => dpt1.ID == Convert.ToInt32(StaticCode.activeUser.UserDept)).DepartmentName,
                ActionBySubDepartment = "",
                TablesExported = "سجلات تصريف أصول",
                ActionNotes = importNotes,
            };
            StaticCode.mainDbContext.ImportExportTbls.InsertOnSubmit(newImport);
            StaticCode.mainDbContext.SubmitChanges();
            actionsStatusMemoEdit.Text = $"تم استيراد سجلات تصريف الأصول بنجاح:\r\n {importNotes}\r\n----------------\r\n راجع إدارة سجلات تصريف الأصول للتأكد من ذلك";
            mainProgressPanel.Visible = false;
        }

        private void ImportAssetsFromExcel(object sender, DevExpress.XtraBars.ItemClickEventArgs e, int formNo)
        {
            actionsStatusMemoEdit.Text = "";
            OpenFileDialog assetsFileOFD = new OpenFileDialog() { Filter = "Excel worbook 2007-2022 (*.xlsx)|*.xlsx" };
            if (assetsFileOFD.ShowDialog() != DialogResult.OK)
            {
                mainAlertControl.Show(this, "تم الإلغاء", StaticCode.ApplicationTitle);
                return;
            }

            mainProgressPanel.Visible = true;
            ExcelPackage astEp = new ExcelPackage(new FileInfo(assetsFileOFD.FileName));
            ExcelWorkbook astWb = astEp.Workbook;
            ExcelWorksheet astWs = astWb.Worksheets.First();
            List<string> assetsCodes = astWs.Cells.Where(cl1 => cl1.Start.Column == 3 && cl1.End.Column == 3 && cl1.Start.Row >= 8 && !cl1.Offset(0, -1).Value.ToString().Contains("ملاحظة:")).Select(cl2 => cl2.Value?.ToString()).ToList();
            List<string> existedCodes = StaticCode.mainDbContext.AssetTbls.Where(ast1 => assetsCodes.Contains(ast1.AssetCode)).Select(ast2 => ast2.AssetCode).ToList();
            List<string> existedCodes_ImportExcel = StaticCode.mainDbContext.AssetTbls.Where(ast1 => assetsCodes.Contains(ast1.AssetCode) && ast1.AddingMethod == "Import/Excel").Select(ast2 => ast2.AssetCode).ToList();
            List<string> existedCodes_UserForm = StaticCode.mainDbContext.AssetTbls.Where(ast1 => assetsCodes.Contains(ast1.AssetCode) && ast1.AddingMethod == "UserForm").Select(ast2 => ast2.AssetCode).ToList();
            bool updateExistedAssets = false;
            int existedAssetsCount = existedCodes.Count();
            int existedAssetsCount_ImportExcel = existedCodes_ImportExcel.Count();
            int existedAssetsCount_UserForm = existedCodes_UserForm.Count();
            int newAssetsCount = assetsCodes.Count() - existedAssetsCount;
            if (existedAssetsCount_UserForm > 0)
            {
                updateExistedAssets = MessageBox.Show("هناك بعض الأصول موجودة مسبقاً في سجلات الأصول، هل تريد تحديث معلوماتها؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            }

            string errorMsgOut = "";
            string importingReport = StaticCode.ImportAssetsFromExcel(assetsFileOFD.FileName, formNo, updateExistedAssets, out errorMsgOut);
            if (importingReport == null)
            {
                actionsStatusMemoEdit.Text = errorMsgOut;
                mainProgressPanel.Visible = false;
                mainAlertControl.Show(this, errorMsgOut, StaticCode.ApplicationTitle);
            }
            else
            {
                actionsStatusMemoEdit.Text = $"تمت العملية بنجاح وفق التفاصيل التالية:\r\n1- عدد الأصول المضافة ({newAssetsCount})\r\n2- عدد الأصول المحدثة ({((updateExistedAssets) ? existedAssetsCount_UserForm : 0)})\r\n3- عدد الأصول الموجودة ولم يتم تحديثها لأنها مضافة أساساً عن طريق استيراد ملف إكسل ({existedAssetsCount_ImportExcel})\r\n---------------";
                mainProgressPanel.Visible = false;
                mainAlertControl.Show(this, "تم استيراد الأصول بنجاح وإضافة سجل استيراد يضم التفاصيل المتعلقة، راجع إدارة سجلات الأصول وسجلات عمليات الاستيراد للتأكد من ذلك", StaticCode.ApplicationTitle);
                timer3 = 0;
            }
        }

        private void breakingAlertControl_ButtonClick(object sender, DevExpress.XtraBars.Alerter.AlertButtonClickEventArgs e)
        {
            switch (e.Button.Name)
            {
                case "destructedAssetsAlertButton":
                    if (StaticCode.activeUserRole.ManageAssetTbl != true)
                    {
                        mainAlertControl.Show(this, StaticCode.ApplicationTitle, "لا تملك الصلاحيات للدخول إلى سجلات الأصول!");
                        return;
                    }
                    ManageAssetTblForm desFrm1 = new ManageAssetTblForm(destructedAssetsList, "الأصول التي انتهى عمرها الإنتاجي ولم يتم تصريفها");
                    desFrm1.ShowDialog();
                    break;
                case "assetsToDestructAlertButton":
                    if (StaticCode.activeUserRole.ManageAssetTbl != true)
                    {
                        mainAlertControl.Show(this, StaticCode.ApplicationTitle, "لا تملك الصلاحيات للدخول إلى سجلات الأصول!");
                        return;
                    }
                    ManageAssetTblForm desFrm2 = new ManageAssetTblForm(assetsToDestructList, "الأصول التي سينتهي عمرها الإنتاجي");
                    desFrm2.ShowDialog();
                    break;
                case "assetsWithoutPurchaseDate":
                    if (StaticCode.activeUserRole.ManageAssetTbl != true)
                    {
                        mainAlertControl.Show(this, StaticCode.ApplicationTitle, "لا تملك الصلاحيات للدخول إلى سجلات الأصول!");
                        return;
                    }
                    ManageAssetTblForm desFrm3 = new ManageAssetTblForm(assetsWithoutPurchaseDateList, "الأصول التي ليس لديها تواريخ شراء");
                    desFrm3.ShowDialog();
                    break;
                case "missingDataAssets":
                    if (StaticCode.activeUserRole.ManageAssetTbl != true)
                    {
                        mainAlertControl.Show(this, StaticCode.ApplicationTitle, "لا تملك الصلاحيات للدخول إلى سجلات الأصول!");
                        return;
                    }
                    ManageAssetTblForm desFrm4 = new ManageAssetTblForm(missingDataAssetsList, "الأصول ذات البيانات الناقصة");
                    desFrm4.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void breakingAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            //e.AlertForm.Size = new Size(400, 250);
            e.AlertForm.BackColor = Color.DarkGreen;
            e.AlertForm.ForeColor = Color.Red;
            e.AlertForm.StartPosition = FormStartPosition.Manual;
            e.AlertForm.Location = new Point(900, 400);
            //e.Buttons.PinButton.SetDown(true);
        }

        private void viewAssetsNotificationsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CheckAssetsNotifications();
        }
        #endregion

        #region Options
        private void setAppDateAndTimeBarStaticItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (StaticCode.activeUserRole.SetDateAndTime == true)
            {
                SetAppDateAndTimeForm setdtFrm = new SetAppDateAndTimeForm();
                setdtFrm.ShowDialog();
            }
        }

        private void setAppDateAndTimeBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetAppDateAndTimeForm appDtFrm = new SetAppDateAndTimeForm();
            appDtFrm.ShowDialog();
        }

        private void optionsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OptionsForm optFrm = new OptionsForm();
            optFrm.ShowDialog();
            timer3 = 0;
        }
        #endregion

        #region Aux tables
        private void manageMainCategoryTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageMainCategoryTblForm macaFrm = new ManageMainCategoryTblForm();
            macaFrm.ShowDialog();
        }

        private void manageMinorCategoryTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageMinorCategoryTblForm micaFrm = new ManageMinorCategoryTblForm();
            micaFrm.ShowDialog();
        }

        private void importAssetsCategoriesFromExcelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            actionsStatusMemoEdit.Text = "";
            OpenFileDialog assetsFileOFD = new OpenFileDialog() { Filter = "Excel worbook 2007-2022 (*.xlsx)|*.xlsx" };
            if (assetsFileOFD.ShowDialog() != DialogResult.OK)
            {
                mainAlertControl.Show(this, "تم الإلغاء", StaticCode.ApplicationTitle);
                return;
            }

            mainProgressPanel.Visible = true;
            ExcelPackage catsEp = new ExcelPackage(new FileInfo(assetsFileOFD.FileName));
            ExcelWorkbook catsWb = catsEp.Workbook;
            ExcelWorksheet catsWs = catsWb.Worksheets.First();
            List<string> columnsHeaders = catsWs.Cells.Where(cl1 => cl1.Start.Row == 1 && cl1.End.Row == 1).Select(cl2 => cl2.Value?.ToString()).ToList();
            int macaNameCol = columnsHeaders.IndexOf("الفئة الرئيسية") + 1;
            int micaNameCol = columnsHeaders.IndexOf("اسم الفئة الفرعية") + 1;
            int micaDescCol = columnsHeaders.IndexOf("وصف الفئة الفرعية") + 1;
            int micaProdAgeCol = columnsHeaders.IndexOf("العمر الإنتاجي بالسنوات") + 1;
            int micaDestRateCol = columnsHeaders.IndexOf("معدل الإهلاك") + 1;
            if (macaNameCol == 0)
            {
                actionsStatusMemoEdit.Text = "عمود اسم الفئة الرئيسية غير موجود";
                return;
            }
            if (micaNameCol == 0)
            {
                actionsStatusMemoEdit.Text = "عمود اسم الفئة الفرعية غير موجود";
                return;
            }
            if (micaProdAgeCol == 0)
            {
                actionsStatusMemoEdit.Text = "عمود العمر الإنتاجي بالسنوات غير موجود";
                return;
            }

            for (int iRow = 2; iRow <= catsWs.Dimension.End.Row; iRow++)
            {
                Application.DoEvents();

                int oneMiCaProdAgeVal = 0;
                if (!Int32.TryParse(catsWs.Cells[iRow, micaProdAgeCol].Value?.ToString(), out oneMiCaProdAgeVal))
                {
                    actionsStatusMemoEdit.Text = $"العمر الإنتاجي في السطر {iRow} ليس رقماً صحيحاً";
                    return;
                }
                string oneMaCaVal = catsWs.Cells[iRow, macaNameCol].Value?.ToString();
                if (oneMaCaVal == "")
                {
                    actionsStatusMemoEdit.Text = $"اسم الفئة الرئيسية في السطر {iRow} فارغ";
                    return;
                }
                string oneMiCaVal = catsWs.Cells[iRow, micaNameCol].Value?.ToString();
                if (oneMiCaVal == "")
                {
                    actionsStatusMemoEdit.Text = $"اسم الفئة الفرعية في السطر {iRow} فارغ";
                    return;
                }
            }

            AssetMngDbDataContext tmpDataContext = new AssetMngDbDataContext();
            int newMiCasCount = 0;
            int existedMiCasCount = 0;
            for (int iRow = 2; iRow <= catsWs.Dimension.End.Row; iRow++)
            {
                Application.DoEvents();

                int oneMiCaProdAgeVal = Convert.ToInt32(catsWs.Cells[iRow, micaProdAgeCol].Value);
                string oneMaCaVal = catsWs.Cells[iRow, macaNameCol].Value?.ToString();
                string oneMiCaVal = catsWs.Cells[iRow, micaNameCol].Value?.ToString();
                string oneMiCaDescVal = "";
                if (micaDescCol > 0)
                    oneMiCaDescVal = catsWs.Cells[iRow, micaDescCol].Value?.ToString();
                int oneMaCaID = 0;
                if (!tmpDataContext.MainCategoryTbls.Any(maca1 => maca1.MainCategoryName == oneMaCaVal))
                {
                    MainCategoryTbl newMaCaRec = new MainCategoryTbl() { MainCategoryName = oneMaCaVal, MainCategoryDescription = "" };
                    tmpDataContext.MainCategoryTbls.InsertOnSubmit(newMaCaRec);
                    tmpDataContext.SubmitChanges();
                    oneMaCaID = newMaCaRec.ID;
                    MinorCategoryTbl newMiCaRec = new MinorCategoryTbl() { MinorCategoryName = oneMiCaVal, MainCategory = oneMaCaID, MinorCategoryDescription = oneMiCaDescVal, ProductiveAgeInYears = oneMiCaProdAgeVal };
                    tmpDataContext.MinorCategoryTbls.InsertOnSubmit(newMiCaRec);
                    newMiCasCount++;
                }
                else
                {
                    oneMaCaID = tmpDataContext.MainCategoryTbls.Where(maca1 => maca1.MainCategoryName == oneMaCaVal).First().ID;
                    if (!tmpDataContext.MinorCategoryTbls.Any(mica1 => mica1.MinorCategoryName == oneMiCaVal && mica1.MainCategory == oneMaCaID))
                    {
                        MinorCategoryTbl newMiCaRec = new MinorCategoryTbl() { MinorCategoryName = oneMiCaVal, MainCategory = oneMaCaID, MinorCategoryDescription = oneMiCaDescVal, ProductiveAgeInYears = oneMiCaProdAgeVal, DestructionRate = 1.0 / (double)oneMiCaProdAgeVal };
                        tmpDataContext.MinorCategoryTbls.InsertOnSubmit(newMiCaRec);
                        newMiCasCount++;
                    }
                    else
                    {
                        MinorCategoryTbl existedMiCaRec = tmpDataContext.MinorCategoryTbls.Where(mica1 => mica1.MinorCategoryName == oneMiCaVal && mica1.MainCategory == oneMaCaID).First();
                        existedMiCaRec.MinorCategoryDescription = oneMiCaDescVal;
                        existedMiCaRec.ProductiveAgeInYears = oneMiCaProdAgeVal;
                        existedMiCaRec.DestructionRate = 1.0 / (double)oneMiCaProdAgeVal;
                        existedMiCasCount++;
                    }
                }
            }

            tmpDataContext.SubmitChanges();
            StaticCode.mainDbContext.Dispose();
            StaticCode.mainDbContext = new AssetMngDbDataContext();

            actionsStatusMemoEdit.Text = $"تمت العملية بنجاح وفق التفاصيل التالية:\r\n1- عدد الفئات الفرعية المضافة ({newMiCasCount})\r\n2- عدد الفئات الفرعية المحدثة ({existedMiCasCount})\r\n---------------";
            mainProgressPanel.Visible = false;
            mainAlertControl.Show(this, "تم استيراد الفئات الفرعية بنجاح", StaticCode.ApplicationTitle);
            return;
        }

        private void addNewMainCategoryBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageCategoriesTblsForm catFrm = new ManageCategoriesTblsForm();
            catFrm.ShowDialog();
        }

        private void addNewMinorCategoryBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddNewMinorCategoryForm addFrm = new AddNewMinorCategoryForm();
            addFrm.ShowDialog();
        }

        private void manageFinancialItemCategoryTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageFinancialItemCategoryTblForm ficFrm = new ManageFinancialItemCategoryTblForm();
            ficFrm.ShowDialog();
        }

        private void importFinancialItemsCategoriesFromExcelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            actionsStatusMemoEdit.Text = "";
            OpenFileDialog assetsFileOFD = new OpenFileDialog() { Filter = "Excel worbook 2007-2022 (*.xlsx)|*.xlsx" };
            if (assetsFileOFD.ShowDialog() != DialogResult.OK)
            {
                mainAlertControl.Show(this, "تم الإلغاء", StaticCode.ApplicationTitle);
                return;
            }

            mainProgressPanel.Visible = true;
            ExcelPackage ficaEp = new ExcelPackage(new FileInfo(assetsFileOFD.FileName));
            ExcelWorkbook ficaWb = ficaEp.Workbook;
            ExcelWorksheet ficaWs = ficaWb.Worksheets.First();
            List<string> columnsHeaders = ficaWs.Cells.Where(cl1 => cl1.Start.Row == 1 && cl1.End.Row == 1).Select(cl2 => cl2.Value?.ToString()).ToList();
            int ficaNameCol = columnsHeaders.IndexOf("اسم البند المالي") + 1;
            int ficaDetCol = columnsHeaders.IndexOf("وصف البند المالي") + 1;
            int ficaInOutCol = columnsHeaders.IndexOf("صادر أم وارد") + 1;
            if (ficaNameCol == 0)
            {
                actionsStatusMemoEdit.Text = "عمود اسم البند المالي غير موجود";
                return;
            }
            if (ficaDetCol == 0)
            {
                actionsStatusMemoEdit.Text = "عمود وصف البند المالي غير موجود";
                return;
            }
            if (ficaInOutCol == 0)
            {
                actionsStatusMemoEdit.Text = "عمود صادر أم وارد غير موجود";
                return;
            }

            for (int iRow = 2; iRow <= ficaWs.Dimension.End.Row; iRow++)
            {
                Application.DoEvents();

                string oneFiCaVal = ficaWs.Cells[iRow, ficaNameCol].Value?.ToString();
                if (oneFiCaVal == "")
                {
                    actionsStatusMemoEdit.Text = $"اسم البند المالي  في السطر {iRow} فارغ";
                    return;
                }
                string oneFiCaDetVal = ficaWs.Cells[iRow, ficaDetCol].Value?.ToString();
                if (oneFiCaDetVal == "")
                {
                    actionsStatusMemoEdit.Text = $"وصف البند المالي  في السطر {iRow} فارغ";
                    return;
                }
                string oneFiCaInOutVal = ficaWs.Cells[iRow, ficaInOutCol].Value?.ToString();
                if (oneFiCaInOutVal == "")
                {
                    actionsStatusMemoEdit.Text = $"قيمة (صادر أم وارد)  في السطر {iRow} فارغ";
                    return;
                }
            }

            AssetMngDbDataContext tmpDataContext = new AssetMngDbDataContext();
            int newFiCasCount = 0;
            int existedFiCasCount = 0;
            for (int iRow = 2; iRow <= ficaWs.Dimension.End.Row; iRow++)
            {
                Application.DoEvents();

                string oneFiCaVal = ficaWs.Cells[iRow, ficaNameCol].Value?.ToString();
                string oneFiCaDetVal = ficaWs.Cells[iRow, ficaDetCol].Value?.ToString();
                string oneFiCaInOutVal = ficaWs.Cells[iRow, ficaInOutCol].Value?.ToString();
                if (!tmpDataContext.FinancialItemCategoryTbls.Any(fica1 => fica1.FinancialItemCategoryName == oneFiCaVal))
                {
                    FinancialItemCategoryTbl newFiCaRec = new FinancialItemCategoryTbl() { FinancialItemCategoryName = oneFiCaVal, FinancialItemCategoryDetails = oneFiCaDetVal, IsIncomingOrOutgiung = oneFiCaInOutVal };
                    tmpDataContext.FinancialItemCategoryTbls.InsertOnSubmit(newFiCaRec);
                    newFiCasCount++;
                }
                else
                {
                    FinancialItemCategoryTbl existedFiCaRec = tmpDataContext.FinancialItemCategoryTbls.Where(fica1 => fica1.FinancialItemCategoryName == oneFiCaVal).First();
                    existedFiCaRec.FinancialItemCategoryDetails = oneFiCaDetVal;
                    existedFiCaRec.IsIncomingOrOutgiung = oneFiCaInOutVal;
                    existedFiCasCount++;
                }
            }

            tmpDataContext.SubmitChanges();
            StaticCode.mainDbContext.Dispose();
            StaticCode.mainDbContext = new AssetMngDbDataContext();

            actionsStatusMemoEdit.Text = $"تمت العملية بنجاح وفق التفاصيل التالية:\r\n1- عدد البنود المالية المضافة ({newFiCasCount})\r\n2- عدد البنود المالية المحدثة ({existedFiCasCount})\r\n---------------";
            mainProgressPanel.Visible = false;
            mainAlertControl.Show(this, "تم استيراد البنود المالية بنجاح", StaticCode.ApplicationTitle);
            return;
        }

        private void manageCurrencyTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageCurrencyTblForm curFrm = new ManageCurrencyTblForm();
            curFrm.ShowDialog();
        }

        private void manageDepartmentTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageDepartmentTblForm dptFrm = new ManageDepartmentTblForm();
            dptFrm.ShowDialog();
        }

        private void manageSectionTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageSectionTblForm secFrm = new ManageSectionTblForm();
            secFrm.ShowDialog();
        }

        private void manageSquareTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageSquareTblForm squFrm = new ManageSquareTblForm();
            squFrm.ShowDialog();
        }

        private void manageEstateAreaUnitTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageEstateAreaUnitTblForm eauFrm = new ManageEstateAreaUnitTblForm();
            eauFrm.ShowDialog();
        }

        private void manageTransactionTypeTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageTransactionTypeTblForm ttyFrm = new ManageTransactionTypeTblForm();
            ttyFrm.ShowDialog();
        }

        private void manageIncomingTypeTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageIncomingTypeTblForm inTyFrm = new ManageIncomingTypeTblForm();
            inTyFrm.ShowDialog();
        }

        private void manageOutgoingTypeTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageOutgoingTypeTblForm ouTyFrm = new ManageOutgoingTypeTblForm();
            ouTyFrm.ShowDialog();
        }

        private void manageModelTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageModelTblForm mdlFrm = new ManageModelTblForm();
            mdlFrm.ShowDialog();
        }

        private void manageSubDepartmentTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageSubDepartmentTblForm sdptFrm = new ManageSubDepartmentTblForm();
            sdptFrm.ShowDialog();
        }
        #endregion

        #region Backup and Restore
        private void backupDbBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Directory.Exists(StaticCode.BackupFolder))
                Directory.CreateDirectory(StaticCode.BackupFolder);
            string backupDbFileName = $"{StaticCode.BackupFolder}AssetMngDb{DateTime.Now.Ticks}.bak";
            bool dbBackedup = StaticCode.BackupDb(backupDbFileName);
            if (dbBackedup)
                mainAlertControl.Show(this, "تم النسخ الاحتياطي بنجاح", StaticCode.ApplicationTitle);
            else
                mainAlertControl.Show(this, "لم يتم النسخ الاحتياطي، حاول لاحقاً", StaticCode.ApplicationTitle);
        }

        private void restoreDbBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("هل تريد بالتاكيد استعادة نسخة سابقة من قاعدة البيانات؟", StaticCode.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            OpenFileDialog bakOFD = new OpenFileDialog() { Filter = "Backup file (*.bak)|*.bak" };
            if (bakOFD.ShowDialog() != DialogResult.OK)
            {
                mainAlertControl.Show(this, "تم الإلغاء", StaticCode.ApplicationTitle);
                return;
            }
            bool dbRestored = StaticCode.RestoreDb(bakOFD.FileName);
            if (dbRestored)
            {
                mainAlertControl.Show(this, "تم استعادة قاعدة البيانات لكن تحتاج لإعادة تشغيل البرنامج ليتم تطبيق التغييرات", StaticCode.ApplicationTitle);
            }
            else
            {
                mainAlertControl.Show(this, "لم يتم استعادة قاعدة البيانات، حاول لاحقاُ", StaticCode.ApplicationTitle);
            }
        }
        #endregion

        #region Finance
        private void addNewFinancialItemBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddNewFinancialItemForm newFinFrm = new AddNewFinancialItemForm();
            newFinFrm.ShowDialog();

            StaticCode.mainDbContext = new AssetMngDbDataContext();
            GC.Collect();
        }

        private void manageFinancialItemsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageFinancialItemTblForm fiItFrm = new ManageFinancialItemTblForm();
            fiItFrm.Show();
        }

        private void prepareFinancialReportsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FinancialReportsForm fiRpFrm = new FinancialReportsForm();
            fiRpFrm.ShowDialog();
        }

        private void importFinancialItemsFromExcelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            actionsStatusMemoEdit.Text = "";
            OpenFileDialog assetsFileOFD = new OpenFileDialog() { Filter = "Excel worbook 2007-2022 (*.xlsx)|*.xlsx" };
            if (assetsFileOFD.ShowDialog() != DialogResult.OK)
            {
                mainAlertControl.Show(this, "تم الإلغاء", StaticCode.ApplicationTitle);
                return;
            }

            int newAssetsAdded = 0;
            string errorMsg = StaticCode.ImportFinancialItemsFromExcel(assetsFileOFD.FileName, out newAssetsAdded);
            if (errorMsg != "Done!")
            {
                actionsStatusMemoEdit.Text = errorMsg;
                mainAlertControl.Show(this, errorMsg, StaticCode.ApplicationTitle);
                return;
            }
            else
            {
                StaticCode.mainDbContext = new AssetMngDbDataContext();
                GC.Collect();
                string actionMsg = $"تم استيراد السجلات المالية بنجاح، وتم إضافة ({newAssetsAdded}) أصول إلى سجلات الأصول كذلك، راجع إدارة سجلات الأصول والسجلات المالية للتأكد من ذلك";
                mainAlertControl.Show(this, actionMsg, StaticCode.ApplicationTitle);
                timer3 = 0;
                return;
            }
        }

        private void financialItemsStatsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mainAlertControl.Show(this, StaticCode.ApplicationTitle, "هذه الميزة قيد الإنجاز حالياً");
            //FinancialStatsForm fistFrm = new FinancialStatsForm();
            //fistFrm.ShowDialog();
        }
        #endregion

        #region App folders
        private void openAppFolderBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start(Application.StartupPath);
        }

        private void openEencryptionKeysFolderRarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start(StaticCode.AesKeyAndIVFolder);
        }

        private void openBackupFolderBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start(StaticCode.BackupFolder);
        }

        private void openExportFolderBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start(StaticCode.ExportFolder);
        }
        #endregion

        #region Help
        private void helpBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start($"{Application.StartupPath}//Help//مساعد إدارة الأصول.docx");
        }
        #endregion

        #region Users
        private void ApplyUserRolesOnInterface()
        {
            StaticCode.AssignDbParams();

            activeUserBarStaticItem.Caption = $"المستخدم النشط: ({StaticCode.activeUser.Username})";
            activeUserRoleBarStaticItem.Caption = $"({StaticCode.activeUserRole.RoleName})";
            if (StaticCode.activeUser.UserSection != null)
            {
                activeUserSectionBarStaticItem.Caption = $"دائرة: ({StaticCode.mainDbContext.SectionTbls.Single(sct1 => sct1.ID == StaticCode.activeUser.UserSection).SectionName})";
                activeUserSectionBarStaticItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                activeUserSectionBarStaticItem.Caption = "الحساب لا يتبع لدائرة محددة";
                activeUserSectionBarStaticItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (StaticCode.activeUser.UserDept != null)
            {
                activeUserDeptBarStaticItem.Caption = $"قسم: ({StaticCode.mainDbContext.DepartmentTbls.Single(dpt1 => dpt1.ID == StaticCode.activeUser.UserDept).DepartmentName})";
                activeUserDeptBarStaticItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                activeUserDeptBarStaticItem.Caption = "الحساب لا يتبع لقسم محدد";
                activeUserDeptBarStaticItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            mainMemoEdit.EditValue = StaticCode.activeUser.UserNotes;
            StaticCode.mainDbContext.SubmitChanges();

            addNewAssetBarButtonItem.Visibility = importAssetsFromExcelBarSubItem.Visibility = (StaticCode.activeUserRole.AddNewAsset == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            addNewMainCategoryBarButtonItem.Visibility = (StaticCode.activeUserRole.AddNewMainCategory == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            addNewMinorCategoryBarButtonItem.Visibility = (StaticCode.activeUserRole.AddNewMinorCategory == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            updateExistedAssetBarButtonItem.Visibility = (StaticCode.activeUserRole.UpdateExistedAsset == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageAssetTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageAssetTbl == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            addNewAssetMovementBarButtonItem.Visibility = (StaticCode.activeUserRole.AddNewAssetMovement == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            addNewAssetTransactionBarButtonItem.Visibility = (StaticCode.activeUserRole.AddNewAssetTransaction == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageAssetMovementTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageAssetMovements == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageAssetTransactionTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageAssetTransactions == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageCategoriesBarSubItem.Visibility = (StaticCode.activeUserRole.ManageMainCategories == true || StaticCode.activeUserRole.ManageMinorCategories == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageMainCategoryTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageMainCategories == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageMinorCategoryTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageMinorCategories == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            importAssetsCategoriesFromExcelBarButtonItem.Visibility = (StaticCode.activeUserRole.AddNewMainCategory == true && StaticCode.activeUserRole.AddNewMinorCategory == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageCurrencyTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageCurrencies == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageDepartmentTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageDepartments == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageSubDepartmentTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageSubDepartments == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageSectionTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageSections == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageSquareTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageSquares == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageModelTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageModels == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageEstateAreaUnitTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageEstateAreaUnits == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageTransactionTypeTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageTransactionTypes == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            addNewAssetInventoryBarButtonItem.Visibility = (StaticCode.activeUserRole.CreateInventoryReport == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            setAppDateAndTimeBarButtonItem.Visibility = (StaticCode.activeUserRole.SetDateAndTime == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            addNewUserBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageUsers == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageUserTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageUsers == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageUserRoleTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageUsers == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            backupDbBarButtonItem.Visibility = (StaticCode.activeUserRole.BackupDb == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            restoreDbBarButtonItem.Visibility = (StaticCode.activeUserRole.RestoreDb == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            deleteAssetsBarButtonItem.Visibility = (StaticCode.activeUserRole.DeleteAssetRecord == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            exportDataBarButtonItem.Visibility = (StaticCode.activeUserRole.ExportAllData == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            importDataBarButtonItem.Visibility = (StaticCode.activeUserRole.ImportAllData == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageImportExportTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageImportExportTbl == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            viewReportsBarButtonItem.Visibility = (StaticCode.activeUserRole.ViewAssetsReports == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            viewStatsBarButtonItem.Visibility = (StaticCode.activeUserRole.ViewAssetsStats == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            financialItemsStatsBarButtonItem.Visibility = (StaticCode.activeUserRole.ViewFinancialItemsStats == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            addNewFinancialItemBarButtonItem.Visibility =
importFinancialItemsFromExcelBarButtonItem.Visibility = (StaticCode.activeUserRole.AddNewFinancialItem == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageFinancialItemsBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageFinancialItems == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            importFinancialItemsCategoriesFromExcelBarButtonItem.Visibility = (StaticCode.activeUserRole.AddNewFinancialItemCategory == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageFinancialItemCategoryTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageFinancialItemCategories == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            prepareFinancialReportsBarButtonItem.Visibility = (StaticCode.activeUserRole.ViewFinancialReports == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageIncomingTypeTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageIncomingTypes == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            manageOutgoingTypeTblBarButtonItem.Visibility = (StaticCode.activeUserRole.ManageOutgoingTypes == true) ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void addNewUserBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddNewUserForm usrFrm = new AddNewUserForm();
            usrFrm.ShowDialog();
        }

        private void manageUserTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageUserTblForm mngusrFrm = new ManageUserTblForm();
            mngusrFrm.ShowDialog();

            ApplyUserRolesOnInterface();
        }

        private void loginBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            StaticCode.activeUser.UserNotes = mainMemoEdit.EditValue?.ToString();
            StaticCode.mainDbContext.SubmitChanges();
            LoginForm logFrm = new LoginForm();
            DialogResult logResult = logFrm.ShowDialog();
            if (logResult == DialogResult.OK)
            {
                ApplyUserRolesOnInterface();
                timer3 = 0;
            }
        }

        private void manageUserRoleTblBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManageUserRoleTblForm mngusrrlFrm = new ManageUserRoleTblForm();
            mngusrrlFrm.ShowDialog();

            ApplyUserRolesOnInterface();
        }
        #endregion
    }
}