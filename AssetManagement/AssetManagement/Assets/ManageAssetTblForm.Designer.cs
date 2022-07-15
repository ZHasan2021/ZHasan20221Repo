
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
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAssetTblForm));
            this.mainCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.minorCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetTblTableAdapter();
            this.minorCategoryTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.MinorCategoryTblTableAdapter();
            this.mainCategoryTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.MainCategoryTblTableAdapter();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.assetGridControl = new DevExpress.XtraGrid.GridControl();
            this.assetVwGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.assetVwTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetVwTableAdapter();
            this.minorCategoryTileNavPane = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mainMenuNavButton = new DevExpress.XtraBars.Navigation.NavButton();
            this.minorCategoryTileNavCategory = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.savingChangesTileNavItem = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.saveChangesTileNavSubItem = new DevExpress.XtraBars.Navigation.TileNavSubItem();
            this.discardChangesTileNavSubItem = new DevExpress.XtraBars.Navigation.TileNavSubItem();
            this.exportDataTileNavItem = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.exportToXlsxTileNavSubItem = new DevExpress.XtraBars.Navigation.TileNavSubItem();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetSection = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetDept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetSquare = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetMinorCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetSpecifications = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchasePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchasePriceCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlaceOfPresence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentStatus = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colCarPanelNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCarManufacturingYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCarChassisNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCarEngineNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentDestructionRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLifeSpanInMonths = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSold = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsOutOfWork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsertedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModifiedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsertedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTblBindingSource)).BeginInit();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryTileNavPane)).BeginInit();
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
            // assetTblBindingSource
            // 
            this.assetTblBindingSource.DataMember = "AssetTbl";
            this.assetTblBindingSource.DataSource = this.assetMngDbDataSet;
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
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 760);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1316, 20);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.assetGridControl);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 39);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1316, 741);
            this.fluentDesignFormContainer1.TabIndex = 5;
            // 
            // assetGridControl
            // 
            this.assetGridControl.DataSource = this.assetTblBindingSource;
            this.assetGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.assetGridControl.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetGridControl.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.assetGridControl.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.assetGridControl.Location = new System.Drawing.Point(0, 96);
            this.assetGridControl.MainView = this.assetVwGridView;
            this.assetGridControl.Name = "assetGridControl";
            this.assetGridControl.Size = new System.Drawing.Size(1316, 645);
            this.assetGridControl.TabIndex = 5;
            this.assetGridControl.UseEmbeddedNavigator = true;
            this.assetGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.assetVwGridView});
            // 
            // assetVwGridView
            // 
            this.assetVwGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colAssetCode,
            this.colAssetSection,
            this.colAssetDept,
            this.colAssetSquare,
            this.colAssetMinorCategory,
            this.colAssetSpecifications,
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
            this.colCurrentDestructionRate,
            this.colLifeSpanInMonths,
            this.colIsSold,
            this.colIsOutOfWork,
            this.colInsertedOn,
            this.colLastModifiedOn,
            this.colInsertedBy,
            this.colLastModifiedBy});
            this.assetVwGridView.GridControl = this.assetGridControl;
            this.assetVwGridView.Name = "assetVwGridView";
            this.assetVwGridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1316, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 780);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1316, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 741);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1316, 39);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 741);
            // 
            // toolbarFormControl1
            // 
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.toolbarFormManager2;
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(1316, 39);
            this.toolbarFormControl1.TabIndex = 11;
            this.toolbarFormControl1.TabStop = false;
            this.toolbarFormControl1.ToolbarForm = this;
            // 
            // toolbarFormManager2
            // 
            this.toolbarFormManager2.DockControls.Add(this.barDockControl1);
            this.toolbarFormManager2.DockControls.Add(this.barDockControl2);
            this.toolbarFormManager2.DockControls.Add(this.barDockControl3);
            this.toolbarFormManager2.DockControls.Add(this.barDockControl4);
            this.toolbarFormManager2.Form = this;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 39);
            this.barDockControl1.Manager = this.toolbarFormManager2;
            this.barDockControl1.Size = new System.Drawing.Size(1316, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 780);
            this.barDockControl2.Manager = this.toolbarFormManager2;
            this.barDockControl2.Size = new System.Drawing.Size(1316, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 39);
            this.barDockControl3.Manager = this.toolbarFormManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 741);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1316, 39);
            this.barDockControl4.Manager = this.toolbarFormManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 741);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // assetVwTableAdapter
            // 
            this.assetVwTableAdapter.ClearBeforeFill = true;
            // 
            // minorCategoryTileNavPane
            // 
            this.minorCategoryTileNavPane.Buttons.Add(this.mainMenuNavButton);
            this.minorCategoryTileNavPane.Categories.AddRange(new DevExpress.XtraBars.Navigation.TileNavCategory[] {
            this.minorCategoryTileNavCategory});
            // 
            // tileNavCategory1
            // 
            this.minorCategoryTileNavPane.DefaultCategory.Name = "tileNavCategory1";
            // 
            // 
            // 
            this.minorCategoryTileNavPane.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.minorCategoryTileNavPane.Dock = System.Windows.Forms.DockStyle.Top;
            this.minorCategoryTileNavPane.Location = new System.Drawing.Point(0, 39);
            this.minorCategoryTileNavPane.Name = "minorCategoryTileNavPane";
            this.minorCategoryTileNavPane.Size = new System.Drawing.Size(1316, 90);
            this.minorCategoryTileNavPane.TabIndex = 14;
            this.minorCategoryTileNavPane.Text = "tileNavPane1";
            // 
            // mainMenuNavButton
            // 
            this.mainMenuNavButton.Caption = "القائمة الرئيسية";
            this.mainMenuNavButton.IsMain = true;
            this.mainMenuNavButton.Name = "mainMenuNavButton";
            // 
            // minorCategoryTileNavCategory
            // 
            this.minorCategoryTileNavCategory.Caption = "جدول الفئات الفرعية";
            this.minorCategoryTileNavCategory.Items.AddRange(new DevExpress.XtraBars.Navigation.TileNavItem[] {
            this.savingChangesTileNavItem,
            this.exportDataTileNavItem});
            this.minorCategoryTileNavCategory.Name = "minorCategoryTileNavCategory";
            // 
            // 
            // 
            this.minorCategoryTileNavCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.Text = "جدول الفئات الفرعية";
            this.minorCategoryTileNavCategory.Tile.Elements.Add(tileItemElement6);
            this.minorCategoryTileNavCategory.Tile.Name = "tileBarItem2";
            // 
            // savingChangesTileNavItem
            // 
            this.savingChangesTileNavItem.Caption = "حفظ التعديلات";
            this.savingChangesTileNavItem.Name = "savingChangesTileNavItem";
            this.savingChangesTileNavItem.SubItems.AddRange(new DevExpress.XtraBars.Navigation.TileNavSubItem[] {
            this.saveChangesTileNavSubItem,
            this.discardChangesTileNavSubItem});
            // 
            // 
            // 
            this.savingChangesTileNavItem.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Text = "حفظ التعديلات";
            this.savingChangesTileNavItem.Tile.Elements.Add(tileItemElement3);
            this.savingChangesTileNavItem.Tile.Name = "tileBarItem1";
            // 
            // saveChangesTileNavSubItem
            // 
            this.saveChangesTileNavSubItem.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveChangesTileNavSubItem.Appearance.Options.UseBackColor = true;
            this.saveChangesTileNavSubItem.Caption = "حفظ التفييرات";
            this.saveChangesTileNavSubItem.ImageOptions.Image = global::AssetManagement.Properties.Resources._21377251;
            this.saveChangesTileNavSubItem.Name = "saveChangesTileNavSubItem";
            // 
            // 
            // 
            this.saveChangesTileNavSubItem.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Text = "حفظ التفييرات";
            this.saveChangesTileNavSubItem.Tile.Elements.Add(tileItemElement1);
            this.saveChangesTileNavSubItem.Tile.Name = "tileBarItem1";
            // 
            // discardChangesTileNavSubItem
            // 
            this.discardChangesTileNavSubItem.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.discardChangesTileNavSubItem.Appearance.Options.UseBackColor = true;
            this.discardChangesTileNavSubItem.Caption = "تجاهل التفييرات";
            this.discardChangesTileNavSubItem.ImageOptions.Image = global::AssetManagement.Properties.Resources._21377241;
            this.discardChangesTileNavSubItem.Name = "discardChangesTileNavSubItem";
            // 
            // 
            // 
            this.discardChangesTileNavSubItem.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Text = "تجاهل التفييرات";
            this.discardChangesTileNavSubItem.Tile.Elements.Add(tileItemElement2);
            this.discardChangesTileNavSubItem.Tile.Name = "tileBarItem2";
            // 
            // exportDataTileNavItem
            // 
            this.exportDataTileNavItem.Caption = "تصدير";
            this.exportDataTileNavItem.Name = "exportDataTileNavItem";
            this.exportDataTileNavItem.SubItems.AddRange(new DevExpress.XtraBars.Navigation.TileNavSubItem[] {
            this.exportToXlsxTileNavSubItem});
            // 
            // 
            // 
            this.exportDataTileNavItem.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Text = "تصدير";
            this.exportDataTileNavItem.Tile.Elements.Add(tileItemElement5);
            this.exportDataTileNavItem.Tile.Name = "tileBarItem1";
            // 
            // exportToXlsxTileNavSubItem
            // 
            this.exportToXlsxTileNavSubItem.Caption = "Excel (2007-2022) (*.xlsx)";
            this.exportToXlsxTileNavSubItem.Name = "exportToXlsxTileNavSubItem";
            // 
            // 
            // 
            this.exportToXlsxTileNavSubItem.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Text = "Excel (2007-2022) (*.xlsx)";
            this.exportToXlsxTileNavSubItem.Tile.Elements.Add(tileItemElement4);
            this.exportToXlsxTileNavSubItem.Tile.Name = "tileBarItem2";
            this.exportToXlsxTileNavSubItem.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.exportToXlsxTileNavSubItem_ElementClick);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 94;
            // 
            // colAssetCode
            // 
            this.colAssetCode.FieldName = "AssetCode";
            this.colAssetCode.MinWidth = 25;
            this.colAssetCode.Name = "colAssetCode";
            this.colAssetCode.Visible = true;
            this.colAssetCode.VisibleIndex = 1;
            this.colAssetCode.Width = 94;
            // 
            // colAssetSection
            // 
            this.colAssetSection.FieldName = "AssetSection";
            this.colAssetSection.MinWidth = 25;
            this.colAssetSection.Name = "colAssetSection";
            this.colAssetSection.Visible = true;
            this.colAssetSection.VisibleIndex = 2;
            this.colAssetSection.Width = 94;
            // 
            // colAssetDept
            // 
            this.colAssetDept.FieldName = "AssetDept";
            this.colAssetDept.MinWidth = 25;
            this.colAssetDept.Name = "colAssetDept";
            this.colAssetDept.Visible = true;
            this.colAssetDept.VisibleIndex = 3;
            this.colAssetDept.Width = 94;
            // 
            // colAssetSquare
            // 
            this.colAssetSquare.FieldName = "AssetSquare";
            this.colAssetSquare.MinWidth = 25;
            this.colAssetSquare.Name = "colAssetSquare";
            this.colAssetSquare.Visible = true;
            this.colAssetSquare.VisibleIndex = 4;
            this.colAssetSquare.Width = 94;
            // 
            // colAssetMinorCategory
            // 
            this.colAssetMinorCategory.FieldName = "AssetMinorCategory";
            this.colAssetMinorCategory.MinWidth = 25;
            this.colAssetMinorCategory.Name = "colAssetMinorCategory";
            this.colAssetMinorCategory.Visible = true;
            this.colAssetMinorCategory.VisibleIndex = 5;
            this.colAssetMinorCategory.Width = 94;
            // 
            // colAssetSpecifications
            // 
            this.colAssetSpecifications.FieldName = "AssetSpecifications";
            this.colAssetSpecifications.MinWidth = 25;
            this.colAssetSpecifications.Name = "colAssetSpecifications";
            this.colAssetSpecifications.Visible = true;
            this.colAssetSpecifications.VisibleIndex = 6;
            this.colAssetSpecifications.Width = 94;
            // 
            // colModel
            // 
            this.colModel.FieldName = "Model";
            this.colModel.MinWidth = 25;
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 7;
            this.colModel.Width = 94;
            // 
            // colColor
            // 
            this.colColor.FieldName = "Color";
            this.colColor.MinWidth = 25;
            this.colColor.Name = "colColor";
            this.colColor.Visible = true;
            this.colColor.VisibleIndex = 8;
            this.colColor.Width = 94;
            // 
            // colVolume
            // 
            this.colVolume.FieldName = "Volume";
            this.colVolume.MinWidth = 25;
            this.colVolume.Name = "colVolume";
            this.colVolume.Visible = true;
            this.colVolume.VisibleIndex = 9;
            this.colVolume.Width = 94;
            // 
            // colPurchaseDate
            // 
            this.colPurchaseDate.FieldName = "PurchaseDate";
            this.colPurchaseDate.MinWidth = 25;
            this.colPurchaseDate.Name = "colPurchaseDate";
            this.colPurchaseDate.Visible = true;
            this.colPurchaseDate.VisibleIndex = 10;
            this.colPurchaseDate.Width = 94;
            // 
            // colPurchasePrice
            // 
            this.colPurchasePrice.FieldName = "PurchasePrice";
            this.colPurchasePrice.MinWidth = 25;
            this.colPurchasePrice.Name = "colPurchasePrice";
            this.colPurchasePrice.Visible = true;
            this.colPurchasePrice.VisibleIndex = 11;
            this.colPurchasePrice.Width = 94;
            // 
            // colPurchasePriceCurrency
            // 
            this.colPurchasePriceCurrency.FieldName = "PurchasePriceCurrency";
            this.colPurchasePriceCurrency.MinWidth = 25;
            this.colPurchasePriceCurrency.Name = "colPurchasePriceCurrency";
            this.colPurchasePriceCurrency.Visible = true;
            this.colPurchasePriceCurrency.VisibleIndex = 12;
            this.colPurchasePriceCurrency.Width = 94;
            // 
            // colPlaceOfPresence
            // 
            this.colPlaceOfPresence.FieldName = "PlaceOfPresence";
            this.colPlaceOfPresence.MinWidth = 25;
            this.colPlaceOfPresence.Name = "colPlaceOfPresence";
            this.colPlaceOfPresence.Visible = true;
            this.colPlaceOfPresence.VisibleIndex = 13;
            this.colPlaceOfPresence.Width = 94;
            // 
            // colCurrentStatus
            // 
            this.colCurrentStatus.FieldName = "CurrentStatus";
            this.colCurrentStatus.MinWidth = 25;
            this.colCurrentStatus.Name = "colCurrentStatus";
            this.colCurrentStatus.Visible = true;
            this.colCurrentStatus.VisibleIndex = 14;
            this.colCurrentStatus.Width = 94;
            // 
            // colBenefitPercentage
            // 
            this.colBenefitPercentage.FieldName = "BenefitPercentage";
            this.colBenefitPercentage.MinWidth = 25;
            this.colBenefitPercentage.Name = "colBenefitPercentage";
            this.colBenefitPercentage.Visible = true;
            this.colBenefitPercentage.VisibleIndex = 15;
            this.colBenefitPercentage.Width = 94;
            // 
            // colActualCurrentPrice
            // 
            this.colActualCurrentPrice.FieldName = "ActualCurrentPrice";
            this.colActualCurrentPrice.MinWidth = 25;
            this.colActualCurrentPrice.Name = "colActualCurrentPrice";
            this.colActualCurrentPrice.Visible = true;
            this.colActualCurrentPrice.VisibleIndex = 16;
            this.colActualCurrentPrice.Width = 94;
            // 
            // colActualCurrentPriceCurrency
            // 
            this.colActualCurrentPriceCurrency.FieldName = "ActualCurrentPriceCurrency";
            this.colActualCurrentPriceCurrency.MinWidth = 25;
            this.colActualCurrentPriceCurrency.Name = "colActualCurrentPriceCurrency";
            this.colActualCurrentPriceCurrency.Visible = true;
            this.colActualCurrentPriceCurrency.VisibleIndex = 17;
            this.colActualCurrentPriceCurrency.Width = 94;
            // 
            // colCustodianName
            // 
            this.colCustodianName.FieldName = "CustodianName";
            this.colCustodianName.MinWidth = 25;
            this.colCustodianName.Name = "colCustodianName";
            this.colCustodianName.Visible = true;
            this.colCustodianName.VisibleIndex = 18;
            this.colCustodianName.Width = 94;
            // 
            // colMoreDetails
            // 
            this.colMoreDetails.FieldName = "MoreDetails";
            this.colMoreDetails.MinWidth = 25;
            this.colMoreDetails.Name = "colMoreDetails";
            this.colMoreDetails.Visible = true;
            this.colMoreDetails.VisibleIndex = 19;
            this.colMoreDetails.Width = 94;
            // 
            // colAssetNotes
            // 
            this.colAssetNotes.FieldName = "AssetNotes";
            this.colAssetNotes.MinWidth = 25;
            this.colAssetNotes.Name = "colAssetNotes";
            this.colAssetNotes.Visible = true;
            this.colAssetNotes.VisibleIndex = 20;
            this.colAssetNotes.Width = 94;
            // 
            // colEstateAddress
            // 
            this.colEstateAddress.FieldName = "EstateAddress";
            this.colEstateAddress.MinWidth = 25;
            this.colEstateAddress.Name = "colEstateAddress";
            this.colEstateAddress.Visible = true;
            this.colEstateAddress.VisibleIndex = 21;
            this.colEstateAddress.Width = 94;
            // 
            // colOwnerName
            // 
            this.colOwnerName.FieldName = "OwnerName";
            this.colOwnerName.MinWidth = 25;
            this.colOwnerName.Name = "colOwnerName";
            this.colOwnerName.Visible = true;
            this.colOwnerName.VisibleIndex = 22;
            this.colOwnerName.Width = 94;
            // 
            // colOfUsed
            // 
            this.colOfUsed.FieldName = "OfUsed";
            this.colOfUsed.MinWidth = 25;
            this.colOfUsed.Name = "colOfUsed";
            this.colOfUsed.Visible = true;
            this.colOfUsed.VisibleIndex = 23;
            this.colOfUsed.Width = 94;
            // 
            // colEstateOwnershipDocumentWith
            // 
            this.colEstateOwnershipDocumentWith.FieldName = "EstateOwnershipDocumentWith";
            this.colEstateOwnershipDocumentWith.MinWidth = 25;
            this.colEstateOwnershipDocumentWith.Name = "colEstateOwnershipDocumentWith";
            this.colEstateOwnershipDocumentWith.Visible = true;
            this.colEstateOwnershipDocumentWith.VisibleIndex = 24;
            this.colEstateOwnershipDocumentWith.Width = 94;
            // 
            // colEstateArea
            // 
            this.colEstateArea.FieldName = "EstateArea";
            this.colEstateArea.MinWidth = 25;
            this.colEstateArea.Name = "colEstateArea";
            this.colEstateArea.Visible = true;
            this.colEstateArea.VisibleIndex = 25;
            this.colEstateArea.Width = 94;
            // 
            // colEstateAreaUnit
            // 
            this.colEstateAreaUnit.FieldName = "EstateAreaUnit";
            this.colEstateAreaUnit.MinWidth = 25;
            this.colEstateAreaUnit.Name = "colEstateAreaUnit";
            this.colEstateAreaUnit.Visible = true;
            this.colEstateAreaUnit.VisibleIndex = 26;
            this.colEstateAreaUnit.Width = 94;
            // 
            // colCarPanelNumber
            // 
            this.colCarPanelNumber.FieldName = "CarPanelNumber";
            this.colCarPanelNumber.MinWidth = 25;
            this.colCarPanelNumber.Name = "colCarPanelNumber";
            this.colCarPanelNumber.Visible = true;
            this.colCarPanelNumber.VisibleIndex = 27;
            this.colCarPanelNumber.Width = 94;
            // 
            // colCarManufacturingYear
            // 
            this.colCarManufacturingYear.FieldName = "CarManufacturingYear";
            this.colCarManufacturingYear.MinWidth = 25;
            this.colCarManufacturingYear.Name = "colCarManufacturingYear";
            this.colCarManufacturingYear.Visible = true;
            this.colCarManufacturingYear.VisibleIndex = 28;
            this.colCarManufacturingYear.Width = 94;
            // 
            // colCarChassisNumber
            // 
            this.colCarChassisNumber.FieldName = "CarChassisNumber";
            this.colCarChassisNumber.MinWidth = 25;
            this.colCarChassisNumber.Name = "colCarChassisNumber";
            this.colCarChassisNumber.Visible = true;
            this.colCarChassisNumber.VisibleIndex = 29;
            this.colCarChassisNumber.Width = 94;
            // 
            // colCarEngineNumber
            // 
            this.colCarEngineNumber.FieldName = "CarEngineNumber";
            this.colCarEngineNumber.MinWidth = 25;
            this.colCarEngineNumber.Name = "colCarEngineNumber";
            this.colCarEngineNumber.Visible = true;
            this.colCarEngineNumber.VisibleIndex = 30;
            this.colCarEngineNumber.Width = 94;
            // 
            // colCurrentDestructionRate
            // 
            this.colCurrentDestructionRate.FieldName = "CurrentDestructionRate";
            this.colCurrentDestructionRate.MinWidth = 25;
            this.colCurrentDestructionRate.Name = "colCurrentDestructionRate";
            this.colCurrentDestructionRate.Visible = true;
            this.colCurrentDestructionRate.VisibleIndex = 31;
            this.colCurrentDestructionRate.Width = 94;
            // 
            // colLifeSpanInMonths
            // 
            this.colLifeSpanInMonths.FieldName = "LifeSpanInMonths";
            this.colLifeSpanInMonths.MinWidth = 25;
            this.colLifeSpanInMonths.Name = "colLifeSpanInMonths";
            this.colLifeSpanInMonths.Visible = true;
            this.colLifeSpanInMonths.VisibleIndex = 32;
            this.colLifeSpanInMonths.Width = 94;
            // 
            // colIsSold
            // 
            this.colIsSold.FieldName = "IsSold";
            this.colIsSold.MinWidth = 25;
            this.colIsSold.Name = "colIsSold";
            this.colIsSold.Visible = true;
            this.colIsSold.VisibleIndex = 33;
            this.colIsSold.Width = 94;
            // 
            // colIsOutOfWork
            // 
            this.colIsOutOfWork.FieldName = "IsOutOfWork";
            this.colIsOutOfWork.MinWidth = 25;
            this.colIsOutOfWork.Name = "colIsOutOfWork";
            this.colIsOutOfWork.Visible = true;
            this.colIsOutOfWork.VisibleIndex = 34;
            this.colIsOutOfWork.Width = 94;
            // 
            // colInsertedOn
            // 
            this.colInsertedOn.FieldName = "InsertedOn";
            this.colInsertedOn.MinWidth = 25;
            this.colInsertedOn.Name = "colInsertedOn";
            this.colInsertedOn.Visible = true;
            this.colInsertedOn.VisibleIndex = 35;
            this.colInsertedOn.Width = 94;
            // 
            // colLastModifiedOn
            // 
            this.colLastModifiedOn.FieldName = "LastModifiedOn";
            this.colLastModifiedOn.MinWidth = 25;
            this.colLastModifiedOn.Name = "colLastModifiedOn";
            this.colLastModifiedOn.Visible = true;
            this.colLastModifiedOn.VisibleIndex = 36;
            this.colLastModifiedOn.Width = 94;
            // 
            // colInsertedBy
            // 
            this.colInsertedBy.FieldName = "InsertedBy";
            this.colInsertedBy.MinWidth = 25;
            this.colInsertedBy.Name = "colInsertedBy";
            this.colInsertedBy.Visible = true;
            this.colInsertedBy.VisibleIndex = 37;
            this.colInsertedBy.Width = 94;
            // 
            // colLastModifiedBy
            // 
            this.colLastModifiedBy.FieldName = "LastModifiedBy";
            this.colLastModifiedBy.MinWidth = 25;
            this.colLastModifiedBy.Name = "colLastModifiedBy";
            this.colLastModifiedBy.Visible = true;
            this.colLastModifiedBy.VisibleIndex = 38;
            this.colLastModifiedBy.Width = 94;
            // 
            // ManageAssetTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 780);
            this.Controls.Add(this.minorCategoryTileNavPane);
            this.Controls.Add(this.ribbonStatusBar1);
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
            ((System.ComponentModel.ISupportInitialize)(this.assetTblBindingSource)).EndInit();
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assetGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryTileNavPane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AssetMngDbDataSet assetMngDbDataSet;
        private System.Windows.Forms.BindingSource assetTblBindingSource;
        private AssetMngDbDataSetTableAdapters.AssetTblTableAdapter assetTblTableAdapter;
        private System.Windows.Forms.BindingSource minorCategoryTblBindingSource;
        private AssetMngDbDataSetTableAdapters.MinorCategoryTblTableAdapter minorCategoryTblTableAdapter;
        private System.Windows.Forms.BindingSource mainCategoryTblBindingSource;
        private AssetMngDbDataSetTableAdapters.MainCategoryTblTableAdapter mainCategoryTblTableAdapter;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
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
        private DevExpress.XtraBars.Navigation.TileNavPane minorCategoryTileNavPane;
        private DevExpress.XtraBars.Navigation.NavButton mainMenuNavButton;
        private DevExpress.XtraBars.Navigation.TileNavCategory minorCategoryTileNavCategory;
        private DevExpress.XtraBars.Navigation.TileNavItem savingChangesTileNavItem;
        private DevExpress.XtraBars.Navigation.TileNavSubItem saveChangesTileNavSubItem;
        private DevExpress.XtraBars.Navigation.TileNavSubItem discardChangesTileNavSubItem;
        private DevExpress.XtraGrid.GridControl assetGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView assetVwGridView;
        private DevExpress.XtraBars.Navigation.TileNavItem exportDataTileNavItem;
        private DevExpress.XtraBars.Navigation.TileNavSubItem exportToXlsxTileNavSubItem;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetSection;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetDept;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetSquare;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetMinorCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetSpecifications;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraGrid.Columns.GridColumn colVolume;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchasePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchasePriceCurrency;
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
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentDestructionRate;
        private DevExpress.XtraGrid.Columns.GridColumn colLifeSpanInMonths;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSold;
        private DevExpress.XtraGrid.Columns.GridColumn colIsOutOfWork;
        private DevExpress.XtraGrid.Columns.GridColumn colInsertedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModifiedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colInsertedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModifiedBy;
    }
}