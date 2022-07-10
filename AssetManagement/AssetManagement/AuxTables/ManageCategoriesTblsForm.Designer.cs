
namespace AssetManagement.AuxTables
{
    partial class ManageCategoriesTblsForm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCategoriesTblsForm));
            this.minorCategoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.minorCategoryGridControl = new DevExpress.XtraGrid.GridControl();
            this.minorCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.mainCategoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinorCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinorCategoryDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMainCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainCategoryRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.mainCategoryTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colProductiveAgeInYears = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDestructionRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainCategoryTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.MainCategoryTblTableAdapter();
            this.minorCategoryTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.MinorCategoryTblTableAdapter();
            this.mainCategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.findAllMinorCategoriestBtn = new System.Windows.Forms.Button();
            this.addNewMainCategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.newMainCategoryDescriptionLabel = new System.Windows.Forms.Label();
            this.newMainCategoryDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.newMainCategoryNameLabel = new System.Windows.Forms.Label();
            this.addNewMainCategoryBtn_Cancel = new System.Windows.Forms.Button();
            this.addNewMainCategoryBtn_OK = new System.Windows.Forms.Button();
            this.newMainCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.addNewMainCategoryBtn = new System.Windows.Forms.Button();
            this.findMinorCategoriesByLookupEditBtn = new System.Windows.Forms.Button();
            this.assetMinorCategoryLabel = new System.Windows.Forms.Label();
            this.mainCategoryLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.minorCategoryTileNavPane = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mainMenuNavButton = new DevExpress.XtraBars.Navigation.NavButton();
            this.minorCategoryTileNavCategory = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.savingChangesTileNavItem = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.saveChangesTileNavSubItem = new DevExpress.XtraBars.Navigation.TileNavSubItem();
            this.discardChangesTileNavSubItem = new DevExpress.XtraBars.Navigation.TileNavSubItem();
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryTblBindingSource)).BeginInit();
            this.mainCategoryGroupBox.SuspendLayout();
            this.addNewMainCategoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryTileNavPane)).BeginInit();
            this.SuspendLayout();
            // 
            // minorCategoryGridView
            // 
            this.minorCategoryGridView.GridControl = this.minorCategoryGridControl;
            this.minorCategoryGridView.Name = "minorCategoryGridView";
            // 
            // minorCategoryGridControl
            // 
            this.minorCategoryGridControl.DataSource = this.minorCategoryTblBindingSource;
            this.minorCategoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minorCategoryGridControl.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minorCategoryGridControl.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.minorCategoryGridControl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.minorCategoryGridControl_EmbeddedNavigator_ButtonClick);
            gridLevelNode1.LevelTemplate = this.minorCategoryGridView;
            gridLevelNode1.RelationName = "minorCategoryLevel";
            this.minorCategoryGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.minorCategoryGridControl.Location = new System.Drawing.Point(0, 263);
            this.minorCategoryGridControl.MainView = this.mainCategoryGridView;
            this.minorCategoryGridControl.Name = "minorCategoryGridControl";
            this.minorCategoryGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.mainCategoryRepositoryItemLookUpEdit});
            this.minorCategoryGridControl.Size = new System.Drawing.Size(1284, 451);
            this.minorCategoryGridControl.TabIndex = 3;
            this.minorCategoryGridControl.UseEmbeddedNavigator = true;
            this.minorCategoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mainCategoryGridView,
            this.minorCategoryGridView});
            // 
            // minorCategoryTblBindingSource
            // 
            this.minorCategoryTblBindingSource.DataMember = "MinorCategoryTbl";
            this.minorCategoryTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainCategoryGridView
            // 
            this.mainCategoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMinorCategoryName,
            this.colMinorCategoryDescription,
            this.colMainCategory,
            this.colProductiveAgeInYears,
            this.colDestructionRate});
            this.mainCategoryGridView.GridControl = this.minorCategoryGridControl;
            this.mainCategoryGridView.Name = "mainCategoryGridView";
            // 
            // colID
            // 
            this.colID.Caption = "معرف الفئة الفرعية";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 70;
            this.colID.Name = "colID";
            this.colID.Width = 98;
            // 
            // colMinorCategoryName
            // 
            this.colMinorCategoryName.Caption = "اسم الفئة الفرعية";
            this.colMinorCategoryName.FieldName = "MinorCategoryName";
            this.colMinorCategoryName.MinWidth = 150;
            this.colMinorCategoryName.Name = "colMinorCategoryName";
            this.colMinorCategoryName.Visible = true;
            this.colMinorCategoryName.VisibleIndex = 0;
            this.colMinorCategoryName.Width = 178;
            // 
            // colMinorCategoryDescription
            // 
            this.colMinorCategoryDescription.Caption = "وصف الفئة الفرعية";
            this.colMinorCategoryDescription.FieldName = "MinorCategoryDescription";
            this.colMinorCategoryDescription.MinWidth = 200;
            this.colMinorCategoryDescription.Name = "colMinorCategoryDescription";
            this.colMinorCategoryDescription.Visible = true;
            this.colMinorCategoryDescription.VisibleIndex = 1;
            this.colMinorCategoryDescription.Width = 200;
            // 
            // colMainCategory
            // 
            this.colMainCategory.Caption = "الفئة الرئيسية";
            this.colMainCategory.ColumnEdit = this.mainCategoryRepositoryItemLookUpEdit;
            this.colMainCategory.FieldName = "MainCategory";
            this.colMainCategory.MinWidth = 70;
            this.colMainCategory.Name = "colMainCategory";
            this.colMainCategory.Visible = true;
            this.colMainCategory.VisibleIndex = 4;
            this.colMainCategory.Width = 94;
            // 
            // mainCategoryRepositoryItemLookUpEdit
            // 
            this.mainCategoryRepositoryItemLookUpEdit.AutoHeight = false;
            this.mainCategoryRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mainCategoryRepositoryItemLookUpEdit.DataSource = this.mainCategoryTblBindingSource1;
            this.mainCategoryRepositoryItemLookUpEdit.DisplayMember = "MainCategoryName";
            this.mainCategoryRepositoryItemLookUpEdit.Name = "mainCategoryRepositoryItemLookUpEdit";
            this.mainCategoryRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // mainCategoryTblBindingSource1
            // 
            this.mainCategoryTblBindingSource1.DataMember = "MainCategoryTbl";
            this.mainCategoryTblBindingSource1.DataSource = this.assetMngDbDataSet;
            // 
            // colProductiveAgeInYears
            // 
            this.colProductiveAgeInYears.Caption = "العمر الإنتاجي بالسنوات";
            this.colProductiveAgeInYears.FieldName = "ProductiveAgeInYears";
            this.colProductiveAgeInYears.MinWidth = 100;
            this.colProductiveAgeInYears.Name = "colProductiveAgeInYears";
            this.colProductiveAgeInYears.Visible = true;
            this.colProductiveAgeInYears.VisibleIndex = 2;
            this.colProductiveAgeInYears.Width = 100;
            // 
            // colDestructionRate
            // 
            this.colDestructionRate.Caption = "معدل الإهلاك";
            this.colDestructionRate.FieldName = "DestructionRate";
            this.colDestructionRate.MinWidth = 100;
            this.colDestructionRate.Name = "colDestructionRate";
            this.colDestructionRate.OptionsColumn.AllowEdit = false;
            this.colDestructionRate.Visible = true;
            this.colDestructionRate.VisibleIndex = 3;
            this.colDestructionRate.Width = 100;
            // 
            // mainCategoryTblBindingSource
            // 
            this.mainCategoryTblBindingSource.DataMember = "MainCategoryTbl";
            this.mainCategoryTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // mainCategoryTblTableAdapter
            // 
            this.mainCategoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // minorCategoryTblTableAdapter
            // 
            this.minorCategoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // mainCategoryGroupBox
            // 
            this.mainCategoryGroupBox.Controls.Add(this.findAllMinorCategoriestBtn);
            this.mainCategoryGroupBox.Controls.Add(this.addNewMainCategoryGroupBox);
            this.mainCategoryGroupBox.Controls.Add(this.addNewMainCategoryBtn);
            this.mainCategoryGroupBox.Controls.Add(this.findMinorCategoriesByLookupEditBtn);
            this.mainCategoryGroupBox.Controls.Add(this.assetMinorCategoryLabel);
            this.mainCategoryGroupBox.Controls.Add(this.mainCategoryLookUpEdit);
            this.mainCategoryGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainCategoryGroupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCategoryGroupBox.Location = new System.Drawing.Point(0, 0);
            this.mainCategoryGroupBox.Name = "mainCategoryGroupBox";
            this.mainCategoryGroupBox.Size = new System.Drawing.Size(1284, 263);
            this.mainCategoryGroupBox.TabIndex = 2;
            this.mainCategoryGroupBox.TabStop = false;
            this.mainCategoryGroupBox.Text = "الفئات الرئيسية";
            // 
            // findAllMinorCategoriestBtn
            // 
            this.findAllMinorCategoriestBtn.Image = global::AssetManagement.Properties.Resources._5928140;
            this.findAllMinorCategoriestBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.findAllMinorCategoriestBtn.Location = new System.Drawing.Point(201, 31);
            this.findAllMinorCategoriestBtn.Name = "findAllMinorCategoriestBtn";
            this.findAllMinorCategoriestBtn.Size = new System.Drawing.Size(175, 54);
            this.findAllMinorCategoriestBtn.TabIndex = 55;
            this.findAllMinorCategoriestBtn.Text = "عرض الكل";
            this.findAllMinorCategoriestBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findAllMinorCategoriestBtn.UseVisualStyleBackColor = true;
            this.findAllMinorCategoriestBtn.Click += new System.EventHandler(this.findAllMinorCategoriestBtn_Click);
            // 
            // addNewMainCategoryGroupBox
            // 
            this.addNewMainCategoryGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addNewMainCategoryGroupBox.Controls.Add(this.newMainCategoryDescriptionLabel);
            this.addNewMainCategoryGroupBox.Controls.Add(this.newMainCategoryDescriptionTextBox);
            this.addNewMainCategoryGroupBox.Controls.Add(this.newMainCategoryNameLabel);
            this.addNewMainCategoryGroupBox.Controls.Add(this.addNewMainCategoryBtn_Cancel);
            this.addNewMainCategoryGroupBox.Controls.Add(this.addNewMainCategoryBtn_OK);
            this.addNewMainCategoryGroupBox.Controls.Add(this.newMainCategoryNameTextBox);
            this.addNewMainCategoryGroupBox.Location = new System.Drawing.Point(52, 104);
            this.addNewMainCategoryGroupBox.Name = "addNewMainCategoryGroupBox";
            this.addNewMainCategoryGroupBox.Size = new System.Drawing.Size(874, 142);
            this.addNewMainCategoryGroupBox.TabIndex = 100;
            this.addNewMainCategoryGroupBox.TabStop = false;
            this.addNewMainCategoryGroupBox.Text = "إضافة فئة رئيسية جديدة";
            this.addNewMainCategoryGroupBox.Visible = false;
            // 
            // newMainCategoryDescriptionLabel
            // 
            this.newMainCategoryDescriptionLabel.AutoSize = true;
            this.newMainCategoryDescriptionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMainCategoryDescriptionLabel.Location = new System.Drawing.Point(699, 89);
            this.newMainCategoryDescriptionLabel.Name = "newMainCategoryDescriptionLabel";
            this.newMainCategoryDescriptionLabel.Size = new System.Drawing.Size(153, 24);
            this.newMainCategoryDescriptionLabel.TabIndex = 115;
            this.newMainCategoryDescriptionLabel.Text = "وصف الفئة الرئيسية:";
            // 
            // newMainCategoryDescriptionTextBox
            // 
            this.newMainCategoryDescriptionTextBox.Location = new System.Drawing.Point(297, 85);
            this.newMainCategoryDescriptionTextBox.Name = "newMainCategoryDescriptionTextBox";
            this.newMainCategoryDescriptionTextBox.Size = new System.Drawing.Size(376, 32);
            this.newMainCategoryDescriptionTextBox.TabIndex = 120;
            // 
            // newMainCategoryNameLabel
            // 
            this.newMainCategoryNameLabel.AutoSize = true;
            this.newMainCategoryNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMainCategoryNameLabel.Location = new System.Drawing.Point(713, 35);
            this.newMainCategoryNameLabel.Name = "newMainCategoryNameLabel";
            this.newMainCategoryNameLabel.Size = new System.Drawing.Size(139, 24);
            this.newMainCategoryNameLabel.TabIndex = 105;
            this.newMainCategoryNameLabel.Text = "اسم الفئة الرئيسية:";
            // 
            // addNewMainCategoryBtn_Cancel
            // 
            this.addNewMainCategoryBtn_Cancel.Image = global::AssetManagement.Properties.Resources._2137707;
            this.addNewMainCategoryBtn_Cancel.Location = new System.Drawing.Point(19, 48);
            this.addNewMainCategoryBtn_Cancel.Name = "addNewMainCategoryBtn_Cancel";
            this.addNewMainCategoryBtn_Cancel.Size = new System.Drawing.Size(69, 65);
            this.addNewMainCategoryBtn_Cancel.TabIndex = 155;
            this.addNewMainCategoryBtn_Cancel.UseVisualStyleBackColor = true;
            this.addNewMainCategoryBtn_Cancel.Click += new System.EventHandler(this.addNewMainCategoryBtn_Cancel_Click);
            // 
            // addNewMainCategoryBtn_OK
            // 
            this.addNewMainCategoryBtn_OK.Image = global::AssetManagement.Properties.Resources._2137710;
            this.addNewMainCategoryBtn_OK.Location = new System.Drawing.Point(117, 48);
            this.addNewMainCategoryBtn_OK.Name = "addNewMainCategoryBtn_OK";
            this.addNewMainCategoryBtn_OK.Size = new System.Drawing.Size(69, 65);
            this.addNewMainCategoryBtn_OK.TabIndex = 150;
            this.addNewMainCategoryBtn_OK.UseVisualStyleBackColor = true;
            this.addNewMainCategoryBtn_OK.Click += new System.EventHandler(this.addNewMainCategoryBtn_OK_Click);
            // 
            // newMainCategoryNameTextBox
            // 
            this.newMainCategoryNameTextBox.Location = new System.Drawing.Point(453, 31);
            this.newMainCategoryNameTextBox.Name = "newMainCategoryNameTextBox";
            this.newMainCategoryNameTextBox.Size = new System.Drawing.Size(220, 32);
            this.newMainCategoryNameTextBox.TabIndex = 110;
            // 
            // addNewMainCategoryBtn
            // 
            this.addNewMainCategoryBtn.Image = global::AssetManagement.Properties.Resources._223645;
            this.addNewMainCategoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewMainCategoryBtn.Location = new System.Drawing.Point(1027, 122);
            this.addNewMainCategoryBtn.Name = "addNewMainCategoryBtn";
            this.addNewMainCategoryBtn.Size = new System.Drawing.Size(172, 102);
            this.addNewMainCategoryBtn.TabIndex = 60;
            this.addNewMainCategoryBtn.Text = "إضافة فئة رئيسية جديدة";
            this.addNewMainCategoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewMainCategoryBtn.UseVisualStyleBackColor = true;
            this.addNewMainCategoryBtn.Click += new System.EventHandler(this.addNewMainCategoryBtn_Click);
            // 
            // findMinorCategoriesByLookupEditBtn
            // 
            this.findMinorCategoriesByLookupEditBtn.Image = global::AssetManagement.Properties.Resources._5928140;
            this.findMinorCategoriesByLookupEditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.findMinorCategoriesByLookupEditBtn.Location = new System.Drawing.Point(407, 31);
            this.findMinorCategoriesByLookupEditBtn.Name = "findMinorCategoriesByLookupEditBtn";
            this.findMinorCategoriesByLookupEditBtn.Size = new System.Drawing.Size(337, 54);
            this.findMinorCategoriesByLookupEditBtn.TabIndex = 50;
            this.findMinorCategoriesByLookupEditBtn.Text = "استعراض الفئات الفرعية للاختيار الحالي";
            this.findMinorCategoriesByLookupEditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findMinorCategoriesByLookupEditBtn.UseVisualStyleBackColor = true;
            this.findMinorCategoriesByLookupEditBtn.Click += new System.EventHandler(this.findMinorCategoriesBtn_Click);
            // 
            // assetMinorCategoryLabel
            // 
            this.assetMinorCategoryLabel.AutoSize = true;
            this.assetMinorCategoryLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetMinorCategoryLabel.Location = new System.Drawing.Point(1096, 46);
            this.assetMinorCategoryLabel.Name = "assetMinorCategoryLabel";
            this.assetMinorCategoryLabel.Size = new System.Drawing.Size(107, 24);
            this.assetMinorCategoryLabel.TabIndex = 5;
            this.assetMinorCategoryLabel.Text = "الفئة الرئيسية:";
            // 
            // mainCategoryLookUpEdit
            // 
            this.mainCategoryLookUpEdit.Location = new System.Drawing.Point(775, 43);
            this.mainCategoryLookUpEdit.Name = "mainCategoryLookUpEdit";
            this.mainCategoryLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCategoryLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.mainCategoryLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mainCategoryLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الفئة الرئيسية", 23, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainCategoryName", "اسم الفئة الرئيسية", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainCategoryDescription", "وصف الفئة الرئيسية", 250, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.mainCategoryLookUpEdit.Properties.DataSource = this.mainCategoryTblBindingSource;
            this.mainCategoryLookUpEdit.Properties.DisplayMember = "MainCategoryName";
            this.mainCategoryLookUpEdit.Properties.ValueMember = "ID";
            this.mainCategoryLookUpEdit.Size = new System.Drawing.Size(298, 30);
            this.mainCategoryLookUpEdit.TabIndex = 10;
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
            this.mainAlertControl.AutoHeight = true;
            this.mainAlertControl.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight;
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
            this.minorCategoryTileNavPane.Location = new System.Drawing.Point(0, 263);
            this.minorCategoryTileNavPane.Name = "minorCategoryTileNavPane";
            this.minorCategoryTileNavPane.Size = new System.Drawing.Size(1284, 40);
            this.minorCategoryTileNavPane.TabIndex = 4;
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
            this.savingChangesTileNavItem});
            this.minorCategoryTileNavCategory.Name = "minorCategoryTileNavCategory";
            // 
            // 
            // 
            this.minorCategoryTileNavCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Text = "جدول الفئات الفرعية";
            this.minorCategoryTileNavCategory.Tile.Elements.Add(tileItemElement4);
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
            this.savingChangesTileNavItem.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.saveChangesTileNavItem_ElementClick);
            // 
            // saveChangesTileNavSubItem
            // 
            this.saveChangesTileNavSubItem.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
            this.saveChangesTileNavSubItem.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.saveChangesTileNavSubItem_ElementClick);
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
            this.discardChangesTileNavSubItem.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.discardChangesTileNavSubItem_ElementClick);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssetMovementTblTableAdapter = null;
            this.tableAdapterManager.AssetTblTableAdapter = null;
            this.tableAdapterManager.AssetTransactionTblTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CurrencyTblTableAdapter = null;
            this.tableAdapterManager.DepartmentTblTableAdapter = null;
            this.tableAdapterManager.EstateAreaUnitTblTableAdapter = null;
            this.tableAdapterManager.MainCategoryTblTableAdapter = this.mainCategoryTblTableAdapter;
            this.tableAdapterManager.MinorCategoryTblTableAdapter = this.minorCategoryTblTableAdapter;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.SectionTblTableAdapter = null;
            this.tableAdapterManager.SquareTblTableAdapter = null;
            this.tableAdapterManager.StatusTblTableAdapter = null;
            this.tableAdapterManager.TransactionTypeTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // ManageCategoriesTblsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 714);
            this.Controls.Add(this.minorCategoryTileNavPane);
            this.Controls.Add(this.minorCategoryGridControl);
            this.Controls.Add(this.mainCategoryGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageCategoriesTblsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة جداول فئات الأصول";
            this.Load += new System.EventHandler(this.ManageCategoriesTblsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryTblBindingSource)).EndInit();
            this.mainCategoryGroupBox.ResumeLayout(false);
            this.mainCategoryGroupBox.PerformLayout();
            this.addNewMainCategoryGroupBox.ResumeLayout(false);
            this.addNewMainCategoryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryTileNavPane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AssetMngDbDataSet assetMngDbDataSet;
        private System.Windows.Forms.BindingSource mainCategoryTblBindingSource;
        private AssetMngDbDataSetTableAdapters.MainCategoryTblTableAdapter mainCategoryTblTableAdapter;
        private System.Windows.Forms.BindingSource minorCategoryTblBindingSource;
        private AssetMngDbDataSetTableAdapters.MinorCategoryTblTableAdapter minorCategoryTblTableAdapter;
        private System.Windows.Forms.GroupBox mainCategoryGroupBox;
        private System.Windows.Forms.Label assetMinorCategoryLabel;
        private DevExpress.XtraEditors.LookUpEdit mainCategoryLookUpEdit;
        private DevExpress.XtraGrid.GridControl minorCategoryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView minorCategoryGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView mainCategoryGridView;
        private System.Windows.Forms.Button addNewMainCategoryBtn;
        private System.Windows.Forms.Button findMinorCategoriesByLookupEditBtn;
        private System.Windows.Forms.GroupBox addNewMainCategoryGroupBox;
        private System.Windows.Forms.Button addNewMainCategoryBtn_Cancel;
        private System.Windows.Forms.Button addNewMainCategoryBtn_OK;
        private System.Windows.Forms.TextBox newMainCategoryNameTextBox;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private System.Windows.Forms.Label newMainCategoryDescriptionLabel;
        private System.Windows.Forms.TextBox newMainCategoryDescriptionTextBox;
        private System.Windows.Forms.Label newMainCategoryNameLabel;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMinorCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colMinorCategoryDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colMainCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colProductiveAgeInYears;
        private DevExpress.XtraGrid.Columns.GridColumn colDestructionRate;
        private DevExpress.XtraBars.Navigation.TileNavPane minorCategoryTileNavPane;
        private DevExpress.XtraBars.Navigation.NavButton mainMenuNavButton;
        private DevExpress.XtraBars.Navigation.TileNavCategory minorCategoryTileNavCategory;
        private DevExpress.XtraBars.Navigation.TileNavItem savingChangesTileNavItem;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.Navigation.TileNavSubItem saveChangesTileNavSubItem;
        private DevExpress.XtraBars.Navigation.TileNavSubItem discardChangesTileNavSubItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit mainCategoryRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource mainCategoryTblBindingSource1;
        private System.Windows.Forms.Button findAllMinorCategoriestBtn;
    }
}