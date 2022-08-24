
namespace AssetManagement.Assets
{
    partial class ManageAssetTblForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAssetTblForm));
            this.mainCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.minorCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetTblTableAdapter();
            this.minorCategoryTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.MinorCategoryTblTableAdapter();
            this.mainCategoryTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.MainCategoryTblTableAdapter();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.assetVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.toolbarFormManager2 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.saveChangesBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.exportToExcelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.showAssetCardBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.assetVwTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetVwTableAdapter();
            this.sectionTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SectionTblTableAdapter();
            this.departmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter();
            this.squareTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.squareTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SquareTblTableAdapter();
            this.minorCategoryTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.currencyTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currencyTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.CurrencyTblTableAdapter();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.assetGridControl = new DevExpress.XtraGrid.GridControl();
            this.assetTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsOldOrNewAsset = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetSection = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colAssetDept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colAssetSquare = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colAssetMinorCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colAssetSpecifications = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemsQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colPurchasePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colPurchasePriceCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPlaceOfPresence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.statusTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colBenefitPercentage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActualCurrentPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActualCurrentPriceCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustodianName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoreDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstateAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwnerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOfUsed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstateOwnershipDocumentWith = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstateArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstateAreaUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.estateAreaUnitTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCarPanelNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCarManufacturingYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCarChassisNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCarEngineNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDestructionRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLifeSpanInMonths = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSold = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsOutOfWork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsertedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModifiedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsertedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.estateAreaUnitTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.EstateAreaUnitTblTableAdapter();
            this.statusTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.StatusTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estateAreaUnitTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainCategoryTblBindingSource
            // 
            this.mainCategoryTblBindingSource.DataMember = "MainCategoryTbl";
            this.mainCategoryTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // minorCategoryTblBindingSource
            // 
            this.minorCategoryTblBindingSource.DataMember = "MinorCategoryTbl";
            this.minorCategoryTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetTblTableAdapter
            // 
            this.assetTblTableAdapter.ClearBeforeFill = true;
            // 
            // minorCategoryTblTableAdapter
            // 
            this.minorCategoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // mainCategoryTblTableAdapter
            // 
            this.mainCategoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // assetVwBindingSource
            // 
            this.assetVwBindingSource.DataMember = "AssetVw";
            this.assetVwBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // toolbarFormManager1
            // 
            this.toolbarFormManager1.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 39);
            this.barDockControlTop.Manager = this.toolbarFormManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1470, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 995);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1470, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 956);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1470, 39);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 956);
            // 
            // toolbarFormControl1
            // 
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.toolbarFormManager2;
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(1470, 39);
            this.toolbarFormControl1.TabIndex = 11;
            this.toolbarFormControl1.TabStop = false;
            this.toolbarFormControl1.TitleItemLinks.Add(this.saveChangesBarButtonItem);
            this.toolbarFormControl1.TitleItemLinks.Add(this.exportToExcelBarButtonItem);
            this.toolbarFormControl1.TitleItemLinks.Add(this.showAssetCardBarButtonItem);
            this.toolbarFormControl1.ToolbarForm = this;
            // 
            // toolbarFormManager2
            // 
            this.toolbarFormManager2.DockControls.Add(this.barDockControl1);
            this.toolbarFormManager2.DockControls.Add(this.barDockControl2);
            this.toolbarFormManager2.DockControls.Add(this.barDockControl3);
            this.toolbarFormManager2.DockControls.Add(this.barDockControl4);
            this.toolbarFormManager2.Form = this;
            this.toolbarFormManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.saveChangesBarButtonItem,
            this.exportToExcelBarButtonItem,
            this.showAssetCardBarButtonItem});
            this.toolbarFormManager2.MaxItemId = 3;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 39);
            this.barDockControl1.Manager = this.toolbarFormManager2;
            this.barDockControl1.Size = new System.Drawing.Size(1470, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 995);
            this.barDockControl2.Manager = this.toolbarFormManager2;
            this.barDockControl2.Size = new System.Drawing.Size(1470, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 39);
            this.barDockControl3.Manager = this.toolbarFormManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 956);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1470, 39);
            this.barDockControl4.Manager = this.toolbarFormManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 956);
            // 
            // saveChangesBarButtonItem
            // 
            this.saveChangesBarButtonItem.Caption = "حفظ";
            this.saveChangesBarButtonItem.Id = 0;
            this.saveChangesBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveChangesBarButtonItem.ImageOptions.Image")));
            this.saveChangesBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("saveChangesBarButtonItem.ImageOptions.LargeImage")));
            this.saveChangesBarButtonItem.Name = "saveChangesBarButtonItem";
            this.saveChangesBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveChangesBarButtonItem_ItemClick);
            // 
            // exportToExcelBarButtonItem
            // 
            this.exportToExcelBarButtonItem.Caption = "تصدير إلى اكسل";
            this.exportToExcelBarButtonItem.Id = 1;
            this.exportToExcelBarButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("exportToExcelBarButtonItem.ImageOptions.SvgImage")));
            this.exportToExcelBarButtonItem.Name = "exportToExcelBarButtonItem";
            this.exportToExcelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.exportToExcelBarButtonItem_ItemClick);
            // 
            // showAssetCardBarButtonItem
            // 
            this.showAssetCardBarButtonItem.Caption = "إظهار كرت أصل";
            this.showAssetCardBarButtonItem.Id = 2;
            this.showAssetCardBarButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("showAssetCardBarButtonItem.ImageOptions.SvgImage")));
            this.showAssetCardBarButtonItem.Name = "showAssetCardBarButtonItem";
            this.showAssetCardBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showAssetCardBarButtonItem_ItemClick);
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // assetVwTableAdapter
            // 
            this.assetVwTableAdapter.ClearBeforeFill = true;
            // 
            // sectionTblBindingSource
            // 
            this.sectionTblBindingSource.DataMember = "SectionTbl";
            this.sectionTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // sectionTblTableAdapter
            // 
            this.sectionTblTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTblBindingSource
            // 
            this.departmentTblBindingSource.DataMember = "DepartmentTbl";
            this.departmentTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // departmentTblTableAdapter
            // 
            this.departmentTblTableAdapter.ClearBeforeFill = true;
            // 
            // squareTblBindingSource
            // 
            this.squareTblBindingSource.DataMember = "SquareTbl";
            this.squareTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // squareTblTableAdapter
            // 
            this.squareTblTableAdapter.ClearBeforeFill = true;
            // 
            // minorCategoryTblBindingSource1
            // 
            this.minorCategoryTblBindingSource1.DataMember = "MinorCategoryTbl";
            this.minorCategoryTblBindingSource1.DataSource = this.assetMngDbDataSet;
            // 
            // currencyTblBindingSource
            // 
            this.currencyTblBindingSource.DataMember = "CurrencyTbl";
            this.currencyTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // currencyTblTableAdapter
            // 
            this.currencyTblTableAdapter.ClearBeforeFill = true;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.assetGridControl);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 39);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1470, 956);
            this.fluentDesignFormContainer1.TabIndex = 5;
            // 
            // assetGridControl
            // 
            this.assetGridControl.DataSource = this.assetTblBindingSource;
            this.assetGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetGridControl.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetGridControl.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.assetGridControl.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.assetGridControl.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.assetGridControl.Location = new System.Drawing.Point(0, 0);
            this.assetGridControl.MainView = this.assetGridView;
            this.assetGridControl.Name = "assetGridControl";
            this.assetGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3,
            this.repositoryItemLookUpEdit4,
            this.repositoryItemLookUpEdit5,
            this.repositoryItemDateEdit1,
            this.repositoryItemLookUpEdit6,
            this.repositoryItemCalcEdit1,
            this.repositoryItemLookUpEdit7});
            this.assetGridControl.Size = new System.Drawing.Size(1470, 956);
            this.assetGridControl.TabIndex = 6;
            this.assetGridControl.UseEmbeddedNavigator = true;
            this.assetGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.assetGridView});
            // 
            // assetTblBindingSource
            // 
            this.assetTblBindingSource.DataMember = "AssetTbl";
            this.assetTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetGridView
            // 
            this.assetGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colAssetCode,
            this.colIsOldOrNewAsset,
            this.colAssetDept,
            this.colAssetSection,
            this.colAssetSquare,
            this.colAssetMinorCategory,
            this.colAssetSpecifications,
            this.colItemsQuantity,
            this.colModel,
            this.colColor,
            this.colVolume,
            this.colPurchaseDate,
            this.colPurchasePrice,
            this.colPurchasePriceCurrency,
            this.colPlaceOfPresence,
            this.colCurrentStatus,
            this.colBenefitPercentage,
            this.colActualCurrentPrice,
            this.colActualCurrentPriceCurrency,
            this.colCustodianName,
            this.colMoreDetails,
            this.colAssetNotes,
            this.colEstateAddress,
            this.colOwnerName,
            this.colOfUsed,
            this.colEstateOwnershipDocumentWith,
            this.colEstateArea,
            this.colEstateAreaUnit,
            this.colCarPanelNumber,
            this.colCarManufacturingYear,
            this.colCarChassisNumber,
            this.colCarEngineNumber,
            this.colDestructionRate,
            this.colLifeSpanInMonths,
            this.colIsSold,
            this.colIsOutOfWork,
            this.colInsertedOn,
            this.colLastModifiedOn,
            this.colInsertedBy,
            this.colLastModifiedBy});
            this.assetGridView.GridControl = this.assetGridControl;
            this.assetGridView.Name = "assetGridView";
            this.assetGridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.assetGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.assetTblGridView_RowClick);
            this.assetGridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.assetTblGridView_RowCellClick);
            this.assetGridView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.assetTblGridView_SelectionChanged);
            // 
            // colID
            // 
            this.colID.Caption = "معرف الأصل";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 120;
            this.colID.Name = "colID";
            this.colID.Width = 94;
            // 
            // colAssetCode
            // 
            this.colAssetCode.Caption = "كود الأصل";
            this.colAssetCode.FieldName = "AssetCode";
            this.colAssetCode.MinWidth = 150;
            this.colAssetCode.Name = "colAssetCode";
            this.colAssetCode.Visible = true;
            this.colAssetCode.VisibleIndex = 0;
            this.colAssetCode.Width = 178;
            // 
            // colIsOldOrNewAsset
            // 
            this.colIsOldOrNewAsset.Caption = "أصل قديم أم جديد";
            this.colIsOldOrNewAsset.FieldName = "IsOldOrNewAsset";
            this.colIsOldOrNewAsset.MinWidth = 100;
            this.colIsOldOrNewAsset.Name = "colIsOldOrNewAsset";
            this.colIsOldOrNewAsset.Visible = true;
            this.colIsOldOrNewAsset.VisibleIndex = 1;
            this.colIsOldOrNewAsset.Width = 100;
            // 
            // colAssetSection
            // 
            this.colAssetSection.Caption = "الدائرة";
            this.colAssetSection.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colAssetSection.FieldName = "AssetSection";
            this.colAssetSection.MinWidth = 150;
            this.colAssetSection.Name = "colAssetSection";
            this.colAssetSection.Visible = true;
            this.colAssetSection.VisibleIndex = 3;
            this.colAssetSection.Width = 150;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الدائرة", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SectionName", "اسم الدائرة", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEdit1.DataSource = this.sectionTblBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "SectionName";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.PopupWidth = 500;
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // colAssetDept
            // 
            this.colAssetDept.Caption = "القسم";
            this.colAssetDept.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colAssetDept.FieldName = "AssetDept";
            this.colAssetDept.MinWidth = 150;
            this.colAssetDept.Name = "colAssetDept";
            this.colAssetDept.Visible = true;
            this.colAssetDept.VisibleIndex = 2;
            this.colAssetDept.Width = 150;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف القسم", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "اسم القسم", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentHQ", "مقر الثسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEdit2.DataSource = this.departmentTblBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "DepartmentName";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.PopupWidth = 500;
            this.repositoryItemLookUpEdit2.ValueMember = "ID";
            // 
            // colAssetSquare
            // 
            this.colAssetSquare.Caption = "الساحة";
            this.colAssetSquare.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colAssetSquare.FieldName = "AssetSquare";
            this.colAssetSquare.MinWidth = 150;
            this.colAssetSquare.Name = "colAssetSquare";
            this.colAssetSquare.Visible = true;
            this.colAssetSquare.VisibleIndex = 4;
            this.colAssetSquare.Width = 150;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الساحة", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SquareName", "اسم الساحة", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SquareLocation", "مقر الساحة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEdit3.DataSource = this.squareTblBindingSource;
            this.repositoryItemLookUpEdit3.DisplayMember = "SquareName";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.PopupWidth = 500;
            this.repositoryItemLookUpEdit3.ValueMember = "ID";
            // 
            // colAssetMinorCategory
            // 
            this.colAssetMinorCategory.Caption = "نوع الأصل (الغئة الفرعية)";
            this.colAssetMinorCategory.ColumnEdit = this.repositoryItemLookUpEdit4;
            this.colAssetMinorCategory.FieldName = "AssetMinorCategory";
            this.colAssetMinorCategory.MinWidth = 150;
            this.colAssetMinorCategory.Name = "colAssetMinorCategory";
            this.colAssetMinorCategory.Visible = true;
            this.colAssetMinorCategory.VisibleIndex = 5;
            this.colAssetMinorCategory.Width = 150;
            // 
            // repositoryItemLookUpEdit4
            // 
            this.repositoryItemLookUpEdit4.AutoHeight = false;
            this.repositoryItemLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit4.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الفئة الفرعية", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MinorCategoryName", "اسم الفئة الفرعية", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MinorCategoryDescription", "وصف الفئة الفرعية", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainCategory", "معرف الفئة الرئسية", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductiveAgeInYears", "العمر الإنتاجي بالسنوات", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DestructionRate", "معدل الإهلاك", 80, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEdit4.DataSource = this.minorCategoryTblBindingSource1;
            this.repositoryItemLookUpEdit4.DisplayMember = "MinorCategoryName";
            this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
            this.repositoryItemLookUpEdit4.PopupWidth = 500;
            this.repositoryItemLookUpEdit4.ValueMember = "ID";
            // 
            // colAssetSpecifications
            // 
            this.colAssetSpecifications.Caption = "وصف الأصل";
            this.colAssetSpecifications.FieldName = "AssetSpecifications";
            this.colAssetSpecifications.MinWidth = 150;
            this.colAssetSpecifications.Name = "colAssetSpecifications";
            this.colAssetSpecifications.Visible = true;
            this.colAssetSpecifications.VisibleIndex = 6;
            this.colAssetSpecifications.Width = 150;
            // 
            // colItemsQuantity
            // 
            this.colItemsQuantity.Caption = "العدد";
            this.colItemsQuantity.FieldName = "ItemsQuantity";
            this.colItemsQuantity.MinWidth = 80;
            this.colItemsQuantity.Name = "colItemsQuantity";
            this.colItemsQuantity.Visible = true;
            this.colItemsQuantity.VisibleIndex = 7;
            this.colItemsQuantity.Width = 94;
            // 
            // colModel
            // 
            this.colModel.Caption = "الموديل";
            this.colModel.FieldName = "Model";
            this.colModel.MinWidth = 100;
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 8;
            this.colModel.Width = 100;
            // 
            // colColor
            // 
            this.colColor.Caption = "اللون";
            this.colColor.FieldName = "Color";
            this.colColor.MinWidth = 100;
            this.colColor.Name = "colColor";
            this.colColor.Visible = true;
            this.colColor.VisibleIndex = 9;
            this.colColor.Width = 100;
            // 
            // colVolume
            // 
            this.colVolume.Caption = "السعة أو الحجم";
            this.colVolume.FieldName = "Volume";
            this.colVolume.MinWidth = 120;
            this.colVolume.Name = "colVolume";
            this.colVolume.Visible = true;
            this.colVolume.VisibleIndex = 10;
            this.colVolume.Width = 120;
            // 
            // colPurchaseDate
            // 
            this.colPurchaseDate.Caption = "تاريخ الشراء";
            this.colPurchaseDate.ColumnEdit = this.repositoryItemDateEdit1;
            this.colPurchaseDate.FieldName = "PurchaseDate";
            this.colPurchaseDate.MinWidth = 100;
            this.colPurchaseDate.Name = "colPurchaseDate";
            this.colPurchaseDate.Visible = true;
            this.colPurchaseDate.VisibleIndex = 11;
            this.colPurchaseDate.Width = 100;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // colPurchasePrice
            // 
            this.colPurchasePrice.Caption = "سعر الشراء";
            this.colPurchasePrice.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colPurchasePrice.DisplayFormat.FormatString = "c0";
            this.colPurchasePrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPurchasePrice.FieldName = "PurchasePrice";
            this.colPurchasePrice.MinWidth = 120;
            this.colPurchasePrice.Name = "colPurchasePrice";
            this.colPurchasePrice.Visible = true;
            this.colPurchasePrice.VisibleIndex = 12;
            this.colPurchasePrice.Width = 120;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // colPurchasePriceCurrency
            // 
            this.colPurchasePriceCurrency.Caption = "عملة سعر الشراء";
            this.colPurchasePriceCurrency.ColumnEdit = this.repositoryItemLookUpEdit5;
            this.colPurchasePriceCurrency.FieldName = "PurchasePriceCurrency";
            this.colPurchasePriceCurrency.MinWidth = 120;
            this.colPurchasePriceCurrency.Name = "colPurchasePriceCurrency";
            this.colPurchasePriceCurrency.Visible = true;
            this.colPurchasePriceCurrency.VisibleIndex = 13;
            this.colPurchasePriceCurrency.Width = 120;
            // 
            // repositoryItemLookUpEdit5
            // 
            this.repositoryItemLookUpEdit5.AutoHeight = false;
            this.repositoryItemLookUpEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit5.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف العملة", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyName", "اسم العملة", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEdit5.DataSource = this.currencyTblBindingSource;
            this.repositoryItemLookUpEdit5.DisplayMember = "CurrencyName";
            this.repositoryItemLookUpEdit5.Name = "repositoryItemLookUpEdit5";
            this.repositoryItemLookUpEdit5.PopupWidth = 500;
            this.repositoryItemLookUpEdit5.ValueMember = "ID";
            // 
            // colPlaceOfPresence
            // 
            this.colPlaceOfPresence.Caption = "مكان التواجد";
            this.colPlaceOfPresence.FieldName = "PlaceOfPresence";
            this.colPlaceOfPresence.MinWidth = 150;
            this.colPlaceOfPresence.Name = "colPlaceOfPresence";
            this.colPlaceOfPresence.Visible = true;
            this.colPlaceOfPresence.VisibleIndex = 14;
            this.colPlaceOfPresence.Width = 150;
            // 
            // colCurrentStatus
            // 
            this.colCurrentStatus.Caption = "الحالة الآنية";
            this.colCurrentStatus.ColumnEdit = this.repositoryItemLookUpEdit6;
            this.colCurrentStatus.FieldName = "CurrentStatus";
            this.colCurrentStatus.MinWidth = 100;
            this.colCurrentStatus.Name = "colCurrentStatus";
            this.colCurrentStatus.Visible = true;
            this.colCurrentStatus.VisibleIndex = 15;
            this.colCurrentStatus.Width = 100;
            // 
            // repositoryItemLookUpEdit6
            // 
            this.repositoryItemLookUpEdit6.AutoHeight = false;
            this.repositoryItemLookUpEdit6.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit6.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الحالة", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StatusName", "اسم الحالة", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEdit6.DataSource = this.statusTblBindingSource;
            this.repositoryItemLookUpEdit6.DisplayMember = "StatusName";
            this.repositoryItemLookUpEdit6.Name = "repositoryItemLookUpEdit6";
            this.repositoryItemLookUpEdit6.PopupWidth = 500;
            this.repositoryItemLookUpEdit6.ValueMember = "ID";
            // 
            // statusTblBindingSource
            // 
            this.statusTblBindingSource.DataMember = "StatusTbl";
            this.statusTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // colBenefitPercentage
            // 
            this.colBenefitPercentage.Caption = "المستخدم منه";
            this.colBenefitPercentage.FieldName = "BenefitPercentage";
            this.colBenefitPercentage.MinWidth = 150;
            this.colBenefitPercentage.Name = "colBenefitPercentage";
            this.colBenefitPercentage.Visible = true;
            this.colBenefitPercentage.VisibleIndex = 16;
            this.colBenefitPercentage.Width = 150;
            // 
            // colActualCurrentPrice
            // 
            this.colActualCurrentPrice.Caption = "السعر الفعلي الحالي";
            this.colActualCurrentPrice.DisplayFormat.FormatString = "c0";
            this.colActualCurrentPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colActualCurrentPrice.FieldName = "ActualCurrentPrice";
            this.colActualCurrentPrice.MinWidth = 120;
            this.colActualCurrentPrice.Name = "colActualCurrentPrice";
            this.colActualCurrentPrice.Visible = true;
            this.colActualCurrentPrice.VisibleIndex = 17;
            this.colActualCurrentPrice.Width = 120;
            // 
            // colActualCurrentPriceCurrency
            // 
            this.colActualCurrentPriceCurrency.Caption = "عملة السعر الفعلي الحالي";
            this.colActualCurrentPriceCurrency.ColumnEdit = this.repositoryItemLookUpEdit5;
            this.colActualCurrentPriceCurrency.FieldName = "ActualCurrentPriceCurrency";
            this.colActualCurrentPriceCurrency.MinWidth = 120;
            this.colActualCurrentPriceCurrency.Name = "colActualCurrentPriceCurrency";
            this.colActualCurrentPriceCurrency.Visible = true;
            this.colActualCurrentPriceCurrency.VisibleIndex = 18;
            this.colActualCurrentPriceCurrency.Width = 120;
            // 
            // colCustodianName
            // 
            this.colCustodianName.Caption = "اسم صاحب العهدة";
            this.colCustodianName.FieldName = "CustodianName";
            this.colCustodianName.MinWidth = 150;
            this.colCustodianName.Name = "colCustodianName";
            this.colCustodianName.Visible = true;
            this.colCustodianName.VisibleIndex = 19;
            this.colCustodianName.Width = 150;
            // 
            // colMoreDetails
            // 
            this.colMoreDetails.Caption = "تفاصيل إضافية";
            this.colMoreDetails.FieldName = "MoreDetails";
            this.colMoreDetails.MinWidth = 200;
            this.colMoreDetails.Name = "colMoreDetails";
            this.colMoreDetails.Visible = true;
            this.colMoreDetails.VisibleIndex = 20;
            this.colMoreDetails.Width = 200;
            // 
            // colAssetNotes
            // 
            this.colAssetNotes.Caption = "ملاحظات الأصل";
            this.colAssetNotes.FieldName = "AssetNotes";
            this.colAssetNotes.MinWidth = 200;
            this.colAssetNotes.Name = "colAssetNotes";
            this.colAssetNotes.Visible = true;
            this.colAssetNotes.VisibleIndex = 21;
            this.colAssetNotes.Width = 200;
            // 
            // colEstateAddress
            // 
            this.colEstateAddress.Caption = "العنوان الحالي / عقار";
            this.colEstateAddress.FieldName = "EstateAddress";
            this.colEstateAddress.MinWidth = 200;
            this.colEstateAddress.Name = "colEstateAddress";
            this.colEstateAddress.Visible = true;
            this.colEstateAddress.VisibleIndex = 22;
            this.colEstateAddress.Width = 200;
            // 
            // colOwnerName
            // 
            this.colOwnerName.Caption = "اسم المالك / عقار";
            this.colOwnerName.FieldName = "OwnerName";
            this.colOwnerName.MinWidth = 150;
            this.colOwnerName.Name = "colOwnerName";
            this.colOwnerName.Visible = true;
            this.colOwnerName.VisibleIndex = 23;
            this.colOwnerName.Width = 150;
            // 
            // colOfUsed
            // 
            this.colOfUsed.Caption = "المستغل منه / عقار";
            this.colOfUsed.FieldName = "OfUsed";
            this.colOfUsed.MinWidth = 150;
            this.colOfUsed.Name = "colOfUsed";
            this.colOfUsed.Visible = true;
            this.colOfUsed.VisibleIndex = 24;
            this.colOfUsed.Width = 150;
            // 
            // colEstateOwnershipDocumentWith
            // 
            this.colEstateOwnershipDocumentWith.Caption = "مع من ورقة الملكية / عقار";
            this.colEstateOwnershipDocumentWith.FieldName = "EstateOwnershipDocumentWith";
            this.colEstateOwnershipDocumentWith.MinWidth = 150;
            this.colEstateOwnershipDocumentWith.Name = "colEstateOwnershipDocumentWith";
            this.colEstateOwnershipDocumentWith.Visible = true;
            this.colEstateOwnershipDocumentWith.VisibleIndex = 25;
            this.colEstateOwnershipDocumentWith.Width = 150;
            // 
            // colEstateArea
            // 
            this.colEstateArea.Caption = "المساحة / عقار";
            this.colEstateArea.FieldName = "EstateArea";
            this.colEstateArea.MinWidth = 100;
            this.colEstateArea.Name = "colEstateArea";
            this.colEstateArea.Visible = true;
            this.colEstateArea.VisibleIndex = 26;
            this.colEstateArea.Width = 100;
            // 
            // colEstateAreaUnit
            // 
            this.colEstateAreaUnit.Caption = "وحدة المساحة / عقار";
            this.colEstateAreaUnit.ColumnEdit = this.repositoryItemLookUpEdit7;
            this.colEstateAreaUnit.FieldName = "EstateAreaUnit";
            this.colEstateAreaUnit.MinWidth = 100;
            this.colEstateAreaUnit.Name = "colEstateAreaUnit";
            this.colEstateAreaUnit.Visible = true;
            this.colEstateAreaUnit.VisibleIndex = 27;
            this.colEstateAreaUnit.Width = 100;
            // 
            // repositoryItemLookUpEdit7
            // 
            this.repositoryItemLookUpEdit7.AutoHeight = false;
            this.repositoryItemLookUpEdit7.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit7.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف واحدة المساحة", 80, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstateAreaUnitName", "اسم واحدة المساحة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEdit7.DataSource = this.estateAreaUnitTblBindingSource;
            this.repositoryItemLookUpEdit7.DisplayMember = "EstateAreaUnitName";
            this.repositoryItemLookUpEdit7.Name = "repositoryItemLookUpEdit7";
            this.repositoryItemLookUpEdit7.PopupWidth = 500;
            this.repositoryItemLookUpEdit7.ValueMember = "ID";
            // 
            // estateAreaUnitTblBindingSource
            // 
            this.estateAreaUnitTblBindingSource.DataMember = "EstateAreaUnitTbl";
            this.estateAreaUnitTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // colCarPanelNumber
            // 
            this.colCarPanelNumber.Caption = "رقم اللوحة / مركبات";
            this.colCarPanelNumber.FieldName = "CarPanelNumber";
            this.colCarPanelNumber.MinWidth = 120;
            this.colCarPanelNumber.Name = "colCarPanelNumber";
            this.colCarPanelNumber.Visible = true;
            this.colCarPanelNumber.VisibleIndex = 28;
            this.colCarPanelNumber.Width = 120;
            // 
            // colCarManufacturingYear
            // 
            this.colCarManufacturingYear.Caption = "سنة الصنع / مركبات";
            this.colCarManufacturingYear.FieldName = "CarManufacturingYear";
            this.colCarManufacturingYear.MinWidth = 80;
            this.colCarManufacturingYear.Name = "colCarManufacturingYear";
            this.colCarManufacturingYear.Visible = true;
            this.colCarManufacturingYear.VisibleIndex = 29;
            this.colCarManufacturingYear.Width = 100;
            // 
            // colCarChassisNumber
            // 
            this.colCarChassisNumber.Caption = "رقم الهيكل (الشاصيه) / مركبات";
            this.colCarChassisNumber.FieldName = "CarChassisNumber";
            this.colCarChassisNumber.MinWidth = 120;
            this.colCarChassisNumber.Name = "colCarChassisNumber";
            this.colCarChassisNumber.Visible = true;
            this.colCarChassisNumber.VisibleIndex = 30;
            this.colCarChassisNumber.Width = 120;
            // 
            // colCarEngineNumber
            // 
            this.colCarEngineNumber.Caption = "رقم المحرك / مركبات";
            this.colCarEngineNumber.FieldName = "CarEngineNumber";
            this.colCarEngineNumber.MinWidth = 120;
            this.colCarEngineNumber.Name = "colCarEngineNumber";
            this.colCarEngineNumber.Visible = true;
            this.colCarEngineNumber.VisibleIndex = 31;
            this.colCarEngineNumber.Width = 1000;
            // 
            // colDestructionRate
            // 
            this.colDestructionRate.Caption = "معدل الإهلاك";
            this.colDestructionRate.DisplayFormat.FormatString = "P";
            this.colDestructionRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDestructionRate.FieldName = "DestructionRate";
            this.colDestructionRate.MinWidth = 100;
            this.colDestructionRate.Name = "colDestructionRate";
            this.colDestructionRate.OptionsColumn.AllowEdit = false;
            this.colDestructionRate.Visible = true;
            this.colDestructionRate.VisibleIndex = 32;
            this.colDestructionRate.Width = 100;
            // 
            // colLifeSpanInMonths
            // 
            this.colLifeSpanInMonths.Caption = "العمر الافتراضي المتبقي بالأشهر";
            this.colLifeSpanInMonths.FieldName = "LifeSpanInMonths";
            this.colLifeSpanInMonths.MinWidth = 80;
            this.colLifeSpanInMonths.Name = "colLifeSpanInMonths";
            this.colLifeSpanInMonths.OptionsColumn.AllowEdit = false;
            this.colLifeSpanInMonths.Visible = true;
            this.colLifeSpanInMonths.VisibleIndex = 33;
            this.colLifeSpanInMonths.Width = 94;
            // 
            // colIsSold
            // 
            this.colIsSold.Caption = "مباع";
            this.colIsSold.FieldName = "IsSold";
            this.colIsSold.MinWidth = 50;
            this.colIsSold.Name = "colIsSold";
            this.colIsSold.Visible = true;
            this.colIsSold.VisibleIndex = 34;
            this.colIsSold.Width = 94;
            // 
            // colIsOutOfWork
            // 
            this.colIsOutOfWork.Caption = "خارج الخدمة";
            this.colIsOutOfWork.FieldName = "IsOutOfWork";
            this.colIsOutOfWork.MinWidth = 50;
            this.colIsOutOfWork.Name = "colIsOutOfWork";
            this.colIsOutOfWork.Visible = true;
            this.colIsOutOfWork.VisibleIndex = 35;
            this.colIsOutOfWork.Width = 94;
            // 
            // colInsertedOn
            // 
            this.colInsertedOn.Caption = "تاريخ إضافة السجل";
            this.colInsertedOn.FieldName = "InsertedOn";
            this.colInsertedOn.MinWidth = 100;
            this.colInsertedOn.Name = "colInsertedOn";
            this.colInsertedOn.Width = 94;
            // 
            // colLastModifiedOn
            // 
            this.colLastModifiedOn.Caption = "تاريخ آخر تعديل على السجل";
            this.colLastModifiedOn.FieldName = "LastModifiedOn";
            this.colLastModifiedOn.MinWidth = 100;
            this.colLastModifiedOn.Name = "colLastModifiedOn";
            this.colLastModifiedOn.Width = 94;
            // 
            // colInsertedBy
            // 
            this.colInsertedBy.Caption = "المستخدم الذي قام بالإضافة";
            this.colInsertedBy.FieldName = "InsertedBy";
            this.colInsertedBy.MinWidth = 60;
            this.colInsertedBy.Name = "colInsertedBy";
            this.colInsertedBy.Width = 94;
            // 
            // colLastModifiedBy
            // 
            this.colLastModifiedBy.Caption = "المستخدم الذي قام بآخر تعديل";
            this.colLastModifiedBy.FieldName = "LastModifiedBy";
            this.colLastModifiedBy.MinWidth = 60;
            this.colLastModifiedBy.Name = "colLastModifiedBy";
            this.colLastModifiedBy.Width = 94;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssetMovementTblTableAdapter = null;
            this.tableAdapterManager.AssetTblTableAdapter = this.assetTblTableAdapter;
            this.tableAdapterManager.AssetTransactionTblTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CurrencyTblTableAdapter = this.currencyTblTableAdapter;
            this.tableAdapterManager.DepartmentTblTableAdapter = this.departmentTblTableAdapter;
            this.tableAdapterManager.EstateAreaUnitTblTableAdapter = this.estateAreaUnitTblTableAdapter;
            this.tableAdapterManager.FinancialItemCategoryTblTableAdapter = null;
            this.tableAdapterManager.FinancialItemTblTableAdapter = null;
            this.tableAdapterManager.MainCategoryTblTableAdapter = this.mainCategoryTblTableAdapter;
            this.tableAdapterManager.MinorCategoryTblTableAdapter = this.minorCategoryTblTableAdapter;
            this.tableAdapterManager.ModelTblTableAdapter = null;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.SectionTblTableAdapter = this.sectionTblTableAdapter;
            this.tableAdapterManager.SquareTblTableAdapter = this.squareTblTableAdapter;
            this.tableAdapterManager.StatusTblTableAdapter = this.statusTblTableAdapter;
            this.tableAdapterManager.TransactionTypeTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // estateAreaUnitTblTableAdapter
            // 
            this.estateAreaUnitTblTableAdapter.ClearBeforeFill = true;
            // 
            // statusTblTableAdapter
            // 
            this.statusTblTableAdapter.ClearBeforeFill = true;
            // 
            // ManageAssetTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 995);
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.toolbarFormControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ManageAssetTblForm.IconOptions.Icon")));
            this.Name = "ManageAssetTblForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة جدول الأصول";
            this.ToolbarFormControl = this.toolbarFormControl1;
            this.Load += new System.EventHandler(this.ManageAssetTblForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assetGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estateAreaUnitTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AssetMngDbDataSet assetMngDbDataSet;
        private AssetMngDbDataSetTableAdapters.AssetTblTableAdapter assetTblTableAdapter;
        private System.Windows.Forms.BindingSource minorCategoryTblBindingSource;
        private AssetMngDbDataSetTableAdapters.MinorCategoryTblTableAdapter minorCategoryTblTableAdapter;
        private System.Windows.Forms.BindingSource mainCategoryTblBindingSource;
        private AssetMngDbDataSetTableAdapters.MainCategoryTblTableAdapter mainCategoryTblTableAdapter;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private System.Windows.Forms.Timer mainTimer;
        private AssetMngDbDataSetTableAdapters.AssetVwTableAdapter assetVwTableAdapter;
        private System.Windows.Forms.BindingSource assetVwBindingSource;
        private DevExpress.XtraBars.BarButtonItem saveChangesBarButtonItem;
        private System.Windows.Forms.BindingSource sectionTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SectionTblTableAdapter sectionTblTableAdapter;
        private System.Windows.Forms.BindingSource departmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter departmentTblTableAdapter;
        private System.Windows.Forms.BindingSource squareTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SquareTblTableAdapter squareTblTableAdapter;
        private System.Windows.Forms.BindingSource minorCategoryTblBindingSource1;
        private System.Windows.Forms.BindingSource currencyTblBindingSource;
        private AssetMngDbDataSetTableAdapters.CurrencyTblTableAdapter currencyTblTableAdapter;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem exportToExcelBarButtonItem;
        private DevExpress.XtraGrid.GridControl assetGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView assetGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetSection;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetDept;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetSquare;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetMinorCategory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetSpecifications;
        private DevExpress.XtraGrid.Columns.GridColumn colItemsQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraGrid.Columns.GridColumn colVolume;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchasePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchasePriceCurrency;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit5;
        private DevExpress.XtraGrid.Columns.GridColumn colPlaceOfPresence;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colBenefitPercentage;
        private DevExpress.XtraGrid.Columns.GridColumn colActualCurrentPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colActualCurrentPriceCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colCustodianName;
        private DevExpress.XtraGrid.Columns.GridColumn colMoreDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colEstateAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colOwnerName;
        private DevExpress.XtraGrid.Columns.GridColumn colOfUsed;
        private DevExpress.XtraGrid.Columns.GridColumn colEstateOwnershipDocumentWith;
        private DevExpress.XtraGrid.Columns.GridColumn colEstateArea;
        private DevExpress.XtraGrid.Columns.GridColumn colEstateAreaUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colCarPanelNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCarManufacturingYear;
        private DevExpress.XtraGrid.Columns.GridColumn colCarChassisNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCarEngineNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDestructionRate;
        private DevExpress.XtraGrid.Columns.GridColumn colLifeSpanInMonths;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSold;
        private DevExpress.XtraGrid.Columns.GridColumn colIsOutOfWork;
        private DevExpress.XtraGrid.Columns.GridColumn colInsertedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModifiedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colInsertedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModifiedBy;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarButtonItem showAssetCardBarButtonItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit6;
        private AssetMngDbDataSetTableAdapters.StatusTblTableAdapter statusTblTableAdapter;
        private System.Windows.Forms.BindingSource statusTblBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit7;
        private System.Windows.Forms.BindingSource estateAreaUnitTblBindingSource;
        private AssetMngDbDataSetTableAdapters.EstateAreaUnitTblTableAdapter estateAreaUnitTblTableAdapter;
        private System.Windows.Forms.BindingSource assetTblBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIsOldOrNewAsset;
    }
}