
namespace Kindergarten
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.userRoleToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.activeUserToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.activeUserRoleToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.addNewStudentBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.encryptExportedFileBarCheckItem = new DevExpress.XtraBars.BarCheckItem();
            this.exportDataBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.appDateBarStaticItem = new DevExpress.XtraBars.BarStaticItem();
            this.appTimeBarStaticItem = new DevExpress.XtraBars.BarStaticItem();
            this.viewReportsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.manageEducationalLevelTblBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.manageFeePeriodTblBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.manageScholasticYearTblBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.manageUserTblBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.addNewUserBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.loginBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.manageUserRoleTblBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.backupDbBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.restoreDbBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.deleteStudentsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.optionsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.decryptImportedFileBarCheckItem = new DevExpress.XtraBars.BarCheckItem();
            this.importDataBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.viewStatsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.prepareFinancialReportsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.manageStudentTblBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.openAppFolderBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.openBackupFolderBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.assetsToDestructBarStaticItem = new DevExpress.XtraBars.BarStaticItem();
            this.openExportFolderBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonMiniToolbar = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.assetsRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.newAssetRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.existedAssetsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.assetsReportsAndStatsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.financeRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.FinancialRecordsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.manageAuxTablesRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.auxTablesRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.exportImportDataRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.exportDataRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.importDataRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.backupAndRestoreRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.optionsRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.usersAccountsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.additionalOptionsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.appFoldersRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mainRibbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonImageList = new System.Windows.Forms.ImageList(this.components);
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ApplicationButtonDropDownControl = this.mainStatusStrip;
            this.mainRibbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(78, 89, 78, 89);
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Font = new System.Drawing.Font("Mudir MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.mainRibbonControl.SearchEditItem,
            this.addNewStudentBarButtonItem,
            this.skinDropDownButtonItem1,
            this.encryptExportedFileBarCheckItem,
            this.exportDataBarButtonItem,
            this.appDateBarStaticItem,
            this.appTimeBarStaticItem,
            this.viewReportsBarButtonItem,
            this.manageEducationalLevelTblBarButtonItem,
            this.manageFeePeriodTblBarButtonItem,
            this.manageScholasticYearTblBarButtonItem,
            this.manageUserTblBarButtonItem,
            this.addNewUserBarButtonItem,
            this.loginBarButtonItem,
            this.manageUserRoleTblBarButtonItem,
            this.backupDbBarButtonItem,
            this.restoreDbBarButtonItem,
            this.deleteStudentsBarButtonItem,
            this.optionsBarButtonItem,
            this.decryptImportedFileBarCheckItem,
            this.importDataBarButtonItem,
            this.viewStatsBarButtonItem,
            this.prepareFinancialReportsBarButtonItem,
            this.manageStudentTblBarButtonItem,
            this.openAppFolderBarButtonItem,
            this.openBackupFolderBarButtonItem,
            this.assetsToDestructBarStaticItem,
            this.openExportFolderBarButtonItem});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.mainRibbonControl.MaxItemId = 61;
            this.mainRibbonControl.MiniToolbars.Add(this.mainRibbonMiniToolbar);
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.OptionsMenuMinWidth = 880;
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.assetsRibbonPage,
            this.financeRibbonPage,
            this.manageAuxTablesRibbonPage,
            this.exportImportDataRibbonPage,
            this.optionsRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.mainRibbonControl.Size = new System.Drawing.Size(1485, 283);
            this.mainRibbonControl.StatusBar = this.mainRibbonStatusBar;
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Font = new System.Drawing.Font("Sakkal Majalla", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userRoleToolStripStatusLabel,
            this.activeUserToolStripStatusLabel,
            this.activeUserRoleToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 929);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Padding = new System.Windows.Forms.Padding(12, 0, 1, 0);
            this.mainStatusStrip.Size = new System.Drawing.Size(1485, 22);
            this.mainStatusStrip.TabIndex = 2;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // userRoleToolStripStatusLabel
            // 
            this.userRoleToolStripStatusLabel.Name = "userRoleToolStripStatusLabel";
            this.userRoleToolStripStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // activeUserToolStripStatusLabel
            // 
            this.activeUserToolStripStatusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.activeUserToolStripStatusLabel.Name = "activeUserToolStripStatusLabel";
            this.activeUserToolStripStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // activeUserRoleToolStripStatusLabel
            // 
            this.activeUserRoleToolStripStatusLabel.BackColor = System.Drawing.Color.Aqua;
            this.activeUserRoleToolStripStatusLabel.Name = "activeUserRoleToolStripStatusLabel";
            this.activeUserRoleToolStripStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // addNewStudentBarButtonItem
            // 
            this.addNewStudentBarButtonItem.Caption = "تسجيل طالب جديد";
            this.addNewStudentBarButtonItem.Id = 1;
            this.addNewStudentBarButtonItem.ImageOptions.ImageIndex = 41;
            this.addNewStudentBarButtonItem.ImageOptions.LargeImage = global::Kindergarten.Properties.Resources._5359538;
            this.addNewStudentBarButtonItem.Name = "addNewStudentBarButtonItem";
            this.addNewStudentBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addNewStudentBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addNewAssetBarButtonItem_ItemClick);
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 7;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // encryptExportedFileBarCheckItem
            // 
            this.encryptExportedFileBarCheckItem.Caption = "تشفير ملف التصدير";
            this.encryptExportedFileBarCheckItem.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.encryptExportedFileBarCheckItem.Id = 9;
            this.encryptExportedFileBarCheckItem.ImageOptions.Image = global::Kindergarten.Properties.Resources._7976039;
            this.encryptExportedFileBarCheckItem.Name = "encryptExportedFileBarCheckItem";
            this.encryptExportedFileBarCheckItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // exportDataBarButtonItem
            // 
            this.exportDataBarButtonItem.Caption = "تصدير البيانات";
            this.exportDataBarButtonItem.Id = 10;
            this.exportDataBarButtonItem.ImageOptions.Image = global::Kindergarten.Properties.Resources._3643510;
            this.exportDataBarButtonItem.Name = "exportDataBarButtonItem";
            this.exportDataBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.exportDataBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.exportDataBarButtonItem_ItemClick);
            // 
            // appDateBarStaticItem
            // 
            this.appDateBarStaticItem.Id = 15;
            this.appDateBarStaticItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("appDateBarStaticItem.ImageOptions.Image")));
            this.appDateBarStaticItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("appDateBarStaticItem.ImageOptions.LargeImage")));
            this.appDateBarStaticItem.ItemAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.appDateBarStaticItem.ItemAppearance.Normal.Font = new System.Drawing.Font("Cascadia Code", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appDateBarStaticItem.ItemAppearance.Normal.Options.UseBackColor = true;
            this.appDateBarStaticItem.ItemAppearance.Normal.Options.UseFont = true;
            this.appDateBarStaticItem.Name = "appDateBarStaticItem";
            this.appDateBarStaticItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // appTimeBarStaticItem
            // 
            this.appTimeBarStaticItem.Id = 16;
            this.appTimeBarStaticItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("appTimeBarStaticItem.ImageOptions.Image")));
            this.appTimeBarStaticItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("appTimeBarStaticItem.ImageOptions.LargeImage")));
            this.appTimeBarStaticItem.ItemAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.appTimeBarStaticItem.ItemAppearance.Normal.Font = new System.Drawing.Font("Cascadia Code", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTimeBarStaticItem.ItemAppearance.Normal.Options.UseBackColor = true;
            this.appTimeBarStaticItem.ItemAppearance.Normal.Options.UseFont = true;
            this.appTimeBarStaticItem.Name = "appTimeBarStaticItem";
            this.appTimeBarStaticItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // viewReportsBarButtonItem
            // 
            this.viewReportsBarButtonItem.Caption = "استعراض التقارير";
            this.viewReportsBarButtonItem.Id = 17;
            this.viewReportsBarButtonItem.ImageOptions.Image = global::Kindergarten.Properties.Resources._3753098;
            this.viewReportsBarButtonItem.Name = "viewReportsBarButtonItem";
            this.viewReportsBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.viewReportsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.viewReportsBarButtonItem_ItemClick);
            // 
            // manageEducationalLevelTblBarButtonItem
            // 
            this.manageEducationalLevelTblBarButtonItem.Caption = "إدارة جدول المراحل الدراسية";
            this.manageEducationalLevelTblBarButtonItem.Id = 18;
            this.manageEducationalLevelTblBarButtonItem.ImageOptions.Image = global::Kindergarten.Properties.Resources._1570810;
            this.manageEducationalLevelTblBarButtonItem.Name = "manageEducationalLevelTblBarButtonItem";
            this.manageEducationalLevelTblBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.manageEducationalLevelTblBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.manageEducationalLevelTblBarButtonItem_ItemClick);
            // 
            // manageFeePeriodTblBarButtonItem
            // 
            this.manageFeePeriodTblBarButtonItem.Caption = "إدارة جدول فترات الرسوم الدراسية";
            this.manageFeePeriodTblBarButtonItem.Id = 19;
            this.manageFeePeriodTblBarButtonItem.ImageOptions.Image = global::Kindergarten.Properties.Resources._5596774;
            this.manageFeePeriodTblBarButtonItem.Name = "manageFeePeriodTblBarButtonItem";
            this.manageFeePeriodTblBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.manageFeePeriodTblBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.manageFeePeriodTblBarButtonItem_ItemClick);
            // 
            // manageScholasticYearTblBarButtonItem
            // 
            this.manageScholasticYearTblBarButtonItem.Caption = "إدارة جدول السنوات الدراسية";
            this.manageScholasticYearTblBarButtonItem.Id = 20;
            this.manageScholasticYearTblBarButtonItem.ImageOptions.Image = global::Kindergarten.Properties.Resources._8586322;
            this.manageScholasticYearTblBarButtonItem.Name = "manageScholasticYearTblBarButtonItem";
            this.manageScholasticYearTblBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.manageScholasticYearTblBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.manageScholasticYearTblBarButtonItem_ItemClick);
            // 
            // manageUserTblBarButtonItem
            // 
            this.manageUserTblBarButtonItem.Caption = "إدارة حسابات المستخدمين";
            this.manageUserTblBarButtonItem.Id = 29;
            this.manageUserTblBarButtonItem.ImageOptions.Image = global::Kindergarten.Properties.Resources._7065712;
            this.manageUserTblBarButtonItem.Name = "manageUserTblBarButtonItem";
            this.manageUserTblBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.manageUserTblBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.manageUserTblBarButtonItem_ItemClick);
            // 
            // addNewUserBarButtonItem
            // 
            this.addNewUserBarButtonItem.Caption = "إضافة حساب جديد";
            this.addNewUserBarButtonItem.Id = 30;
            this.addNewUserBarButtonItem.ImageOptions.Image = global::Kindergarten.Properties.Resources._3208660;
            this.addNewUserBarButtonItem.Name = "addNewUserBarButtonItem";
            this.addNewUserBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addNewUserBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addNewUserBarButtonItem_ItemClick);
            // 
            // loginBarButtonItem
            // 
            this.loginBarButtonItem.Caption = "الدخول بحساب مختلف";
            this.loginBarButtonItem.Id = 34;
            this.loginBarButtonItem.ImageOptions.Image = global::Kindergarten.Properties.Resources._5323293;
            this.loginBarButtonItem.Name = "loginBarButtonItem";
            this.loginBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.loginBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.loginBarButtonItem_ItemClick);
            // 
            // manageUserRoleTblBarButtonItem
            // 
            this.manageUserRoleTblBarButtonItem.Caption = "إدارة أنواع حسابات المستخدمين";
            this.manageUserRoleTblBarButtonItem.Id = 35;
            this.manageUserRoleTblBarButtonItem.ImageOptions.Image = global::Kindergarten.Properties.Resources._2529580;
            this.manageUserRoleTblBarButtonItem.Name = "manageUserRoleTblBarButtonItem";
            this.manageUserRoleTblBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.manageUserRoleTblBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.manageUserRoleTblBarButtonItem_ItemClick);
            // 
            // backupDbBarButtonItem
            // 
            this.backupDbBarButtonItem.Caption = "نسخ احتياطي لقاعدة البيانات";
            this.backupDbBarButtonItem.Id = 36;
            this.backupDbBarButtonItem.ImageOptions.Image = global::Kindergarten.Properties.Resources._3620142;
            this.backupDbBarButtonItem.Name = "backupDbBarButtonItem";
            this.backupDbBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.backupDbBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.backupDbBarButtonItem_ItemClick);
            // 
            // restoreDbBarButtonItem
            // 
            this.restoreDbBarButtonItem.Caption = "استعادة نسخة سابقة من قاعدة البيانات";
            this.restoreDbBarButtonItem.Id = 37;
            this.restoreDbBarButtonItem.ImageOptions.Image = global::Kindergarten.Properties.Resources._744804;
            this.restoreDbBarButtonItem.Name = "restoreDbBarButtonItem";
            this.restoreDbBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.restoreDbBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.restoreDbBarButtonItem_ItemClick);
            // 
            // deleteStudentsBarButtonItem
            // 
            this.deleteStudentsBarButtonItem.Caption = "حذف سجل طالب";
            this.deleteStudentsBarButtonItem.Id = 38;
            this.deleteStudentsBarButtonItem.ImageOptions.Image = global::Kindergarten.Properties.Resources._4110306;
            this.deleteStudentsBarButtonItem.Name = "deleteStudentsBarButtonItem";
            this.deleteStudentsBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // optionsBarButtonItem
            // 
            this.optionsBarButtonItem.Caption = "إعدادات التطبيق";
            this.optionsBarButtonItem.Id = 39;
            this.optionsBarButtonItem.ImageOptions.Image = global::Kindergarten.Properties.Resources._821619;
            this.optionsBarButtonItem.Name = "optionsBarButtonItem";
            this.optionsBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.optionsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.optionsBarButtonItem_ItemClick);
            // 
            // decryptImportedFileBarCheckItem
            // 
            this.decryptImportedFileBarCheckItem.Caption = "استيراد ملف مشفر";
            this.decryptImportedFileBarCheckItem.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.decryptImportedFileBarCheckItem.Id = 40;
            this.decryptImportedFileBarCheckItem.Name = "decryptImportedFileBarCheckItem";
            this.decryptImportedFileBarCheckItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // importDataBarButtonItem
            // 
            this.importDataBarButtonItem.Caption = "استيراد البيانات";
            this.importDataBarButtonItem.Id = 41;
            this.importDataBarButtonItem.ImageOptions.Image = global::Kindergarten.Properties.Resources._3643517;
            this.importDataBarButtonItem.Name = "importDataBarButtonItem";
            this.importDataBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.importDataBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.importDataBarButtonItem_ItemClick);
            // 
            // viewStatsBarButtonItem
            // 
            this.viewStatsBarButtonItem.Caption = "عرض الإحصائيات";
            this.viewStatsBarButtonItem.Id = 42;
            this.viewStatsBarButtonItem.ImageOptions.Image = global::Kindergarten.Properties.Resources._753930;
            this.viewStatsBarButtonItem.Name = "viewStatsBarButtonItem";
            this.viewStatsBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.viewStatsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.viewStatsBarButtonItem_ItemClick);
            // 
            // prepareFinancialReportsBarButtonItem
            // 
            this.prepareFinancialReportsBarButtonItem.Caption = "إصدار تقارير مالية";
            this.prepareFinancialReportsBarButtonItem.Id = 46;
            this.prepareFinancialReportsBarButtonItem.ImageOptions.Image = global::Kindergarten.Properties.Resources._3418116;
            this.prepareFinancialReportsBarButtonItem.Name = "prepareFinancialReportsBarButtonItem";
            this.prepareFinancialReportsBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.prepareFinancialReportsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.prepareFinancialReportsBarButtonItem_ItemClick);
            // 
            // manageStudentTblBarButtonItem
            // 
            this.manageStudentTblBarButtonItem.Caption = "إدارة سجلات الطلاب";
            this.manageStudentTblBarButtonItem.Id = 51;
            this.manageStudentTblBarButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("manageStudentTblBarButtonItem.ImageOptions.SvgImage")));
            this.manageStudentTblBarButtonItem.Name = "manageStudentTblBarButtonItem";
            this.manageStudentTblBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.manageStudentTblBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.manageAssetTblBarButtonItem_ItemClick);
            // 
            // openAppFolderBarButtonItem
            // 
            this.openAppFolderBarButtonItem.Caption = "فتح مجلد التطبيق";
            this.openAppFolderBarButtonItem.Id = 54;
            this.openAppFolderBarButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("openAppFolderBarButtonItem.ImageOptions.SvgImage")));
            this.openAppFolderBarButtonItem.Name = "openAppFolderBarButtonItem";
            this.openAppFolderBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.openAppFolderBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.openAppFolderBarButtonItem_ItemClick);
            // 
            // openBackupFolderBarButtonItem
            // 
            this.openBackupFolderBarButtonItem.Caption = "مجلد النسخ الاحتياطية";
            this.openBackupFolderBarButtonItem.Id = 55;
            this.openBackupFolderBarButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("openBackupFolderBarButtonItem.ImageOptions.SvgImage")));
            this.openBackupFolderBarButtonItem.Name = "openBackupFolderBarButtonItem";
            this.openBackupFolderBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.openBackupFolderBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.openBackupFolderBarButtonItem_ItemClick);
            // 
            // assetsToDestructBarStaticItem
            // 
            this.assetsToDestructBarStaticItem.Id = 56;
            this.assetsToDestructBarStaticItem.ItemAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.assetsToDestructBarStaticItem.ItemAppearance.Normal.Font = new System.Drawing.Font("Sakkal Majalla", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetsToDestructBarStaticItem.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            this.assetsToDestructBarStaticItem.ItemAppearance.Normal.Options.UseBackColor = true;
            this.assetsToDestructBarStaticItem.ItemAppearance.Normal.Options.UseFont = true;
            this.assetsToDestructBarStaticItem.ItemAppearance.Normal.Options.UseForeColor = true;
            this.assetsToDestructBarStaticItem.Name = "assetsToDestructBarStaticItem";
            // 
            // openExportFolderBarButtonItem
            // 
            this.openExportFolderBarButtonItem.Caption = "مجلد الملفات المصدرة";
            this.openExportFolderBarButtonItem.Id = 58;
            this.openExportFolderBarButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("openExportFolderBarButtonItem.ImageOptions.SvgImage")));
            this.openExportFolderBarButtonItem.Name = "openExportFolderBarButtonItem";
            this.openExportFolderBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.openExportFolderBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.openExportFolderBarButtonItem_ItemClick);
            // 
            // mainRibbonMiniToolbar
            // 
            this.mainRibbonMiniToolbar.ParentControl = this;
            // 
            // assetsRibbonPage
            // 
            this.assetsRibbonPage.Appearance.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetsRibbonPage.Appearance.Options.UseFont = true;
            this.assetsRibbonPage.Appearance.Options.UseTextOptions = true;
            this.assetsRibbonPage.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.assetsRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.newAssetRibbonPageGroup,
            this.existedAssetsRibbonPageGroup,
            this.assetsReportsAndStatsRibbonPageGroup});
            this.assetsRibbonPage.ImageOptions.Image = global::Kindergarten.Properties.Resources._41866361;
            this.assetsRibbonPage.ImageOptions.ImageIndex = 41;
            this.assetsRibbonPage.Name = "assetsRibbonPage";
            this.assetsRibbonPage.Text = "الأصول";
            // 
            // newAssetRibbonPageGroup
            // 
            this.newAssetRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.newAssetRibbonPageGroup.ItemLinks.Add(this.addNewStudentBarButtonItem);
            this.newAssetRibbonPageGroup.Name = "newAssetRibbonPageGroup";
            this.newAssetRibbonPageGroup.Text = "تسجيل طالب - New student";
            // 
            // existedAssetsRibbonPageGroup
            // 
            this.existedAssetsRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.existedAssetsRibbonPageGroup.ItemLinks.Add(this.deleteStudentsBarButtonItem);
            this.existedAssetsRibbonPageGroup.ItemLinks.Add(this.manageStudentTblBarButtonItem);
            this.existedAssetsRibbonPageGroup.Name = "existedAssetsRibbonPageGroup";
            this.existedAssetsRibbonPageGroup.Text = "جدول الطلاب - Students table";
            // 
            // assetsReportsAndStatsRibbonPageGroup
            // 
            this.assetsReportsAndStatsRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.assetsReportsAndStatsRibbonPageGroup.ItemLinks.Add(this.viewReportsBarButtonItem);
            this.assetsReportsAndStatsRibbonPageGroup.ItemLinks.Add(this.viewStatsBarButtonItem);
            this.assetsReportsAndStatsRibbonPageGroup.Name = "assetsReportsAndStatsRibbonPageGroup";
            this.assetsReportsAndStatsRibbonPageGroup.Text = "تقارير وإحصائيات الطلاب";
            // 
            // financeRibbonPage
            // 
            this.financeRibbonPage.Appearance.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financeRibbonPage.Appearance.Options.UseFont = true;
            this.financeRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.FinancialRecordsRibbonPageGroup});
            this.financeRibbonPage.ImageOptions.Image = global::Kindergarten.Properties.Resources._2407198;
            this.financeRibbonPage.Name = "financeRibbonPage";
            this.financeRibbonPage.Text = "المالية";
            // 
            // FinancialRecordsRibbonPageGroup
            // 
            this.FinancialRecordsRibbonPageGroup.ItemLinks.Add(this.prepareFinancialReportsBarButtonItem);
            this.FinancialRecordsRibbonPageGroup.Name = "FinancialRecordsRibbonPageGroup";
            this.FinancialRecordsRibbonPageGroup.Text = "السجلات المالية";
            // 
            // manageAuxTablesRibbonPage
            // 
            this.manageAuxTablesRibbonPage.Appearance.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageAuxTablesRibbonPage.Appearance.Options.UseFont = true;
            this.manageAuxTablesRibbonPage.Appearance.Options.UseTextOptions = true;
            this.manageAuxTablesRibbonPage.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.manageAuxTablesRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.auxTablesRibbonPageGroup});
            this.manageAuxTablesRibbonPage.ImageOptions.Image = global::Kindergarten.Properties.Resources._2762550;
            this.manageAuxTablesRibbonPage.Name = "manageAuxTablesRibbonPage";
            this.manageAuxTablesRibbonPage.Text = "الجداول المساعدة";
            // 
            // auxTablesRibbonPageGroup
            // 
            this.auxTablesRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.auxTablesRibbonPageGroup.ItemLinks.Add(this.manageEducationalLevelTblBarButtonItem);
            this.auxTablesRibbonPageGroup.ItemLinks.Add(this.manageFeePeriodTblBarButtonItem);
            this.auxTablesRibbonPageGroup.ItemLinks.Add(this.manageScholasticYearTblBarButtonItem);
            this.auxTablesRibbonPageGroup.Name = "auxTablesRibbonPageGroup";
            this.auxTablesRibbonPageGroup.Text = "الجداول المساعدة";
            // 
            // exportImportDataRibbonPage
            // 
            this.exportImportDataRibbonPage.Appearance.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportImportDataRibbonPage.Appearance.Options.UseFont = true;
            this.exportImportDataRibbonPage.Appearance.Options.UseTextOptions = true;
            this.exportImportDataRibbonPage.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.exportImportDataRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.exportDataRibbonPageGroup,
            this.importDataRibbonPageGroup,
            this.backupAndRestoreRibbonPageGroup});
            this.exportImportDataRibbonPage.ImageOptions.Image = global::Kindergarten.Properties.Resources._3034410;
            this.exportImportDataRibbonPage.Name = "exportImportDataRibbonPage";
            this.exportImportDataRibbonPage.Text = "تصدير / استيراد البيانات";
            // 
            // exportDataRibbonPageGroup
            // 
            this.exportDataRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.exportDataRibbonPageGroup.ItemLinks.Add(this.encryptExportedFileBarCheckItem);
            this.exportDataRibbonPageGroup.ItemLinks.Add(this.exportDataBarButtonItem);
            this.exportDataRibbonPageGroup.Name = "exportDataRibbonPageGroup";
            this.exportDataRibbonPageGroup.Text = "تصدير البيانات - Export data";
            // 
            // importDataRibbonPageGroup
            // 
            this.importDataRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.importDataRibbonPageGroup.ItemLinks.Add(this.decryptImportedFileBarCheckItem);
            this.importDataRibbonPageGroup.ItemLinks.Add(this.importDataBarButtonItem);
            this.importDataRibbonPageGroup.Name = "importDataRibbonPageGroup";
            this.importDataRibbonPageGroup.Text = "استيراد البيانات - Import data";
            // 
            // backupAndRestoreRibbonPageGroup
            // 
            this.backupAndRestoreRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.backupAndRestoreRibbonPageGroup.ItemLinks.Add(this.backupDbBarButtonItem);
            this.backupAndRestoreRibbonPageGroup.ItemLinks.Add(this.restoreDbBarButtonItem);
            this.backupAndRestoreRibbonPageGroup.Name = "backupAndRestoreRibbonPageGroup";
            this.backupAndRestoreRibbonPageGroup.Text = "نسخ احتياطي واستعادة لقاعدة البيانات";
            // 
            // optionsRibbonPage
            // 
            this.optionsRibbonPage.Appearance.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsRibbonPage.Appearance.Options.UseFont = true;
            this.optionsRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.usersAccountsRibbonPageGroup,
            this.additionalOptionsRibbonPageGroup,
            this.appFoldersRibbonPageGroup});
            this.optionsRibbonPage.ImageOptions.Image = global::Kindergarten.Properties.Resources._2771406;
            this.optionsRibbonPage.Name = "optionsRibbonPage";
            this.optionsRibbonPage.Text = "الإعدادات";
            // 
            // usersAccountsRibbonPageGroup
            // 
            this.usersAccountsRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.usersAccountsRibbonPageGroup.ItemLinks.Add(this.addNewUserBarButtonItem);
            this.usersAccountsRibbonPageGroup.ItemLinks.Add(this.manageUserTblBarButtonItem);
            this.usersAccountsRibbonPageGroup.ItemLinks.Add(this.manageUserRoleTblBarButtonItem);
            this.usersAccountsRibbonPageGroup.ItemLinks.Add(this.loginBarButtonItem);
            this.usersAccountsRibbonPageGroup.Name = "usersAccountsRibbonPageGroup";
            this.usersAccountsRibbonPageGroup.Text = "حسابات المستخدمين";
            // 
            // additionalOptionsRibbonPageGroup
            // 
            this.additionalOptionsRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.additionalOptionsRibbonPageGroup.ItemLinks.Add(this.optionsBarButtonItem);
            this.additionalOptionsRibbonPageGroup.Name = "additionalOptionsRibbonPageGroup";
            this.additionalOptionsRibbonPageGroup.Text = "إعدادات إضافية";
            // 
            // appFoldersRibbonPageGroup
            // 
            this.appFoldersRibbonPageGroup.ItemLinks.Add(this.openAppFolderBarButtonItem);
            this.appFoldersRibbonPageGroup.ItemLinks.Add(this.openBackupFolderBarButtonItem);
            this.appFoldersRibbonPageGroup.ItemLinks.Add(this.openExportFolderBarButtonItem);
            this.appFoldersRibbonPageGroup.Name = "appFoldersRibbonPageGroup";
            this.appFoldersRibbonPageGroup.Text = "مجلدات التطبيق";
            // 
            // mainRibbonStatusBar
            // 
            this.mainRibbonStatusBar.ItemLinks.Add(this.skinDropDownButtonItem1);
            this.mainRibbonStatusBar.ItemLinks.Add(this.appDateBarStaticItem);
            this.mainRibbonStatusBar.ItemLinks.Add(this.appTimeBarStaticItem);
            this.mainRibbonStatusBar.ItemLinks.Add(this.assetsToDestructBarStaticItem);
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 951);
            this.mainRibbonStatusBar.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Ribbon = this.mainRibbonControl;
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(1485, 30);
            // 
            // ribbonImageList
            // 
            this.ribbonImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ribbonImageList.ImageStream")));
            this.ribbonImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ribbonImageList.Images.SetKeyName(0, "73630.png");
            this.ribbonImageList.Images.SetKeyName(1, "117738.png");
            this.ribbonImageList.Images.SetKeyName(2, "143804.png");
            this.ribbonImageList.Images.SetKeyName(3, "477138.png");
            this.ribbonImageList.Images.SetKeyName(4, "690123.png");
            this.ribbonImageList.Images.SetKeyName(5, "695845.png");
            this.ribbonImageList.Images.SetKeyName(6, "753919.png");
            this.ribbonImageList.Images.SetKeyName(7, "753930.png");
            this.ribbonImageList.Images.SetKeyName(8, "849878.png");
            this.ribbonImageList.Images.SetKeyName(9, "1038363.png");
            this.ribbonImageList.Images.SetKeyName(10, "1088089.png");
            this.ribbonImageList.Images.SetKeyName(11, "1317601.png");
            this.ribbonImageList.Images.SetKeyName(12, "1864841.png");
            this.ribbonImageList.Images.SetKeyName(13, "2116156.png");
            this.ribbonImageList.Images.SetKeyName(14, "2205595.png");
            this.ribbonImageList.Images.SetKeyName(15, "2477112.png");
            this.ribbonImageList.Images.SetKeyName(16, "2486641.png");
            this.ribbonImageList.Images.SetKeyName(17, "2623813.png");
            this.ribbonImageList.Images.SetKeyName(18, "2623814.png");
            this.ribbonImageList.Images.SetKeyName(19, "3133120.png");
            this.ribbonImageList.Images.SetKeyName(20, "3418116.png");
            this.ribbonImageList.Images.SetKeyName(21, "3612822.png");
            this.ribbonImageList.Images.SetKeyName(22, "3813472.png");
            this.ribbonImageList.Images.SetKeyName(23, "4189994.png");
            this.ribbonImageList.Images.SetKeyName(24, "4195400.png");
            this.ribbonImageList.Images.SetKeyName(25, "4195401.png");
            this.ribbonImageList.Images.SetKeyName(26, "4195402.png");
            this.ribbonImageList.Images.SetKeyName(27, "4319057.png");
            this.ribbonImageList.Images.SetKeyName(28, "4343305.png");
            this.ribbonImageList.Images.SetKeyName(29, "4643270.png");
            this.ribbonImageList.Images.SetKeyName(30, "4888525.png");
            this.ribbonImageList.Images.SetKeyName(31, "4903940.png");
            this.ribbonImageList.Images.SetKeyName(32, "4959445.png");
            this.ribbonImageList.Images.SetKeyName(33, "5000312.png");
            this.ribbonImageList.Images.SetKeyName(34, "5022621.png");
            this.ribbonImageList.Images.SetKeyName(35, "5097155.png");
            this.ribbonImageList.Images.SetKeyName(36, "5323293.png");
            this.ribbonImageList.Images.SetKeyName(37, "6856024.png");
            this.ribbonImageList.Images.SetKeyName(38, "7030130.png");
            this.ribbonImageList.Images.SetKeyName(39, "7065740.png");
            this.ribbonImageList.Images.SetKeyName(40, "7065754.png");
            this.ribbonImageList.Images.SetKeyName(41, "7185722.png");
            this.ribbonImageList.Images.SetKeyName(42, "7381354.png");
            this.ribbonImageList.Images.SetKeyName(43, "7442791.png");
            this.ribbonImageList.Images.SetKeyName(44, "7945017.png");
            this.ribbonImageList.Images.SetKeyName(45, "7945038.png");
            this.ribbonImageList.Images.SetKeyName(46, "7945059.png");
            this.ribbonImageList.Images.SetKeyName(47, "7945064.png");
            this.ribbonImageList.Images.SetKeyName(48, "7945084.png");
            this.ribbonImageList.Images.SetKeyName(49, "7945097.png");
            this.ribbonImageList.Images.SetKeyName(50, "7976196.png");
            this.ribbonImageList.Images.SetKeyName(51, "7987360.png");
            this.ribbonImageList.Images.SetKeyName(52, "8249437.png");
            this.ribbonImageList.Images.SetKeyName(53, "8270950.png");
            this.ribbonImageList.Images.SetKeyName(54, "8689249.png");
            this.ribbonImageList.Images.SetKeyName(55, "8712876.png");
            // 
            // mainAlertControl
            // 
            this.mainAlertControl.AppearanceCaption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainAlertControl.AppearanceCaption.Options.UseFont = true;
            this.mainAlertControl.AppearanceCaption.Options.UseTextOptions = true;
            this.mainAlertControl.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.mainAlertControl.AppearanceText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainAlertControl.AppearanceText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mainAlertControl.AppearanceText.Options.UseFont = true;
            this.mainAlertControl.AppearanceText.Options.UseForeColor = true;
            this.mainAlertControl.AppearanceText.Options.UseTextOptions = true;
            this.mainAlertControl.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.mainAlertControl.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight;
            this.mainAlertControl.FormLoad += new DevExpress.XtraBars.Alerter.AlertFormLoadEventHandler(this.mainAlertControl_FormLoad);
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 981);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Controls.Add(this.mainRibbonControl);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainForm.IconOptions.Icon")));
            this.Name = "MainForm";
            this.Ribbon = this.mainRibbonControl;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.mainRibbonStatusBar;
            this.Text = "أكاديمية النشء الجديد - New generation academy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage assetsRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup newAssetRibbonPageGroup;
        private System.Windows.Forms.ImageList ribbonImageList;
        private DevExpress.XtraBars.BarButtonItem addNewStudentBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup existedAssetsRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar mainRibbonStatusBar;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel userRoleToolStripStatusLabel;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage exportImportDataRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup exportDataRibbonPageGroup;
        private DevExpress.XtraBars.BarCheckItem encryptExportedFileBarCheckItem;
        private DevExpress.XtraBars.BarButtonItem exportDataBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar mainRibbonMiniToolbar;
        private DevExpress.XtraBars.Ribbon.RibbonPage manageAuxTablesRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup auxTablesRibbonPageGroup;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage optionsRibbonPage;
        private DevExpress.XtraBars.BarStaticItem appDateBarStaticItem;
        private DevExpress.XtraBars.BarStaticItem appTimeBarStaticItem;
        private System.Windows.Forms.Timer mainTimer;
        private DevExpress.XtraBars.BarButtonItem viewReportsBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem manageEducationalLevelTblBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem manageFeePeriodTblBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem manageScholasticYearTblBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem manageUserTblBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup usersAccountsRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem addNewUserBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup additionalOptionsRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem loginBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem manageUserRoleTblBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem backupDbBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup backupAndRestoreRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem restoreDbBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem deleteStudentsBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem optionsBarButtonItem;
        private DevExpress.XtraBars.BarCheckItem decryptImportedFileBarCheckItem;
        private DevExpress.XtraBars.BarButtonItem importDataBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup importDataRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem viewStatsBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup assetsReportsAndStatsRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage financeRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup FinancialRecordsRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem prepareFinancialReportsBarButtonItem;
        private System.Windows.Forms.ToolStripStatusLabel activeUserToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel activeUserRoleToolStripStatusLabel;
        private DevExpress.XtraBars.BarButtonItem manageStudentTblBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup appFoldersRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem openAppFolderBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem openBackupFolderBarButtonItem;
        private DevExpress.XtraBars.BarStaticItem assetsToDestructBarStaticItem;
        private DevExpress.XtraBars.BarButtonItem openExportFolderBarButtonItem;
    }
}

