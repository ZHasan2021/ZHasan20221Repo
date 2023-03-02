
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
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.minorCategoryTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.minorCategoryTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryTblBindingNavigator)).BeginInit();
            this.minorCategoryTblBindingNavigator.SuspendLayout();
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
            this.minorCategoryGridControl.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.minorCategoryGridControl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.minorCategoryGridControl_EmbeddedNavigator_ButtonClick);
            gridLevelNode1.LevelTemplate = this.minorCategoryGridView;
            gridLevelNode1.RelationName = "minorCategoryLevel";
            this.minorCategoryGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.minorCategoryGridControl.Location = new System.Drawing.Point(0, 290);
            this.minorCategoryGridControl.MainView = this.mainCategoryGridView;
            this.minorCategoryGridControl.Name = "minorCategoryGridControl";
            this.minorCategoryGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.mainCategoryRepositoryItemLookUpEdit});
            this.minorCategoryGridControl.Size = new System.Drawing.Size(1284, 424);
            this.minorCategoryGridControl.TabIndex = 6;
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
            this.colMainCategory.VisibleIndex = 2;
            this.colMainCategory.Width = 94;
            // 
            // mainCategoryRepositoryItemLookUpEdit
            // 
            this.mainCategoryRepositoryItemLookUpEdit.AutoHeight = false;
            this.mainCategoryRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mainCategoryRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الفئة الرئيسية", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainCategoryName", "اسم الفئة الرئيسية", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainCategoryDescription", "وصف الفئة الرئيسية", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
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
            this.colProductiveAgeInYears.VisibleIndex = 3;
            this.colProductiveAgeInYears.Width = 100;
            // 
            // colDestructionRate
            // 
            this.colDestructionRate.Caption = "معدل الإهلاك (%)";
            this.colDestructionRate.FieldName = "DestructionRate";
            this.colDestructionRate.MinWidth = 100;
            this.colDestructionRate.Name = "colDestructionRate";
            this.colDestructionRate.OptionsColumn.AllowEdit = false;
            this.colDestructionRate.Visible = true;
            this.colDestructionRate.VisibleIndex = 4;
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
            this.findAllMinorCategoriestBtn.Location = new System.Drawing.Point(71, 31);
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
            this.addNewMainCategoryBtn_Cancel.Location = new System.Drawing.Point(19, 35);
            this.addNewMainCategoryBtn_Cancel.Name = "addNewMainCategoryBtn_Cancel";
            this.addNewMainCategoryBtn_Cancel.Size = new System.Drawing.Size(78, 78);
            this.addNewMainCategoryBtn_Cancel.TabIndex = 155;
            this.addNewMainCategoryBtn_Cancel.UseVisualStyleBackColor = true;
            this.addNewMainCategoryBtn_Cancel.Click += new System.EventHandler(this.addNewMainCategoryBtn_Cancel_Click);
            // 
            // addNewMainCategoryBtn_OK
            // 
            this.addNewMainCategoryBtn_OK.Image = global::AssetManagement.Properties.Resources._2137710;
            this.addNewMainCategoryBtn_OK.Location = new System.Drawing.Point(117, 35);
            this.addNewMainCategoryBtn_OK.Name = "addNewMainCategoryBtn_OK";
            this.addNewMainCategoryBtn_OK.Size = new System.Drawing.Size(78, 78);
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
            this.addNewMainCategoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addNewMainCategoryBtn.Image = global::AssetManagement.Properties.Resources._223645;
            this.addNewMainCategoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewMainCategoryBtn.Location = new System.Drawing.Point(964, 104);
            this.addNewMainCategoryBtn.Name = "addNewMainCategoryBtn";
            this.addNewMainCategoryBtn.Size = new System.Drawing.Size(275, 63);
            this.addNewMainCategoryBtn.TabIndex = 60;
            this.addNewMainCategoryBtn.Text = "إضافة فئة رئيسية جديدة";
            this.addNewMainCategoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewMainCategoryBtn.UseVisualStyleBackColor = true;
            this.addNewMainCategoryBtn.Click += new System.EventHandler(this.addNewMainCategoryBtn_Click);
            // 
            // findMinorCategoriesByLookupEditBtn
            // 
            this.findMinorCategoriesByLookupEditBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.findMinorCategoriesByLookupEditBtn.Image = global::AssetManagement.Properties.Resources._5928140;
            this.findMinorCategoriesByLookupEditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.findMinorCategoriesByLookupEditBtn.Location = new System.Drawing.Point(332, 31);
            this.findMinorCategoriesByLookupEditBtn.Name = "findMinorCategoriesByLookupEditBtn";
            this.findMinorCategoriesByLookupEditBtn.Size = new System.Drawing.Size(412, 54);
            this.findMinorCategoriesByLookupEditBtn.TabIndex = 50;
            this.findMinorCategoriesByLookupEditBtn.Text = "استعراض الفئات الفرعية للاختيار الحالي";
            this.findMinorCategoriesByLookupEditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findMinorCategoriesByLookupEditBtn.UseVisualStyleBackColor = true;
            this.findMinorCategoriesByLookupEditBtn.Click += new System.EventHandler(this.findMinorCategoriesBtn_Click);
            // 
            // assetMinorCategoryLabel
            // 
            this.assetMinorCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.mainCategoryLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.mainCategoryLookUpEdit.Properties.PopupWidth = 500;
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
            this.mainAlertControl.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight;
            this.mainAlertControl.FormLoad += new DevExpress.XtraBars.Alerter.AlertFormLoadEventHandler(this.mainAlertControl_FormLoad);
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
            this.tableAdapterManager.FinancialItemCategoryTblTableAdapter = null;
            this.tableAdapterManager.FinancialItemTblTableAdapter = null;
            this.tableAdapterManager.ImportExportTblTableAdapter = null;
            this.tableAdapterManager.IncomingTypeTblTableAdapter = null;
            this.tableAdapterManager.MainCategoryTblTableAdapter = this.mainCategoryTblTableAdapter;
            this.tableAdapterManager.MinorCategoryTblTableAdapter = this.minorCategoryTblTableAdapter;
            this.tableAdapterManager.ModelTblTableAdapter = null;
            this.tableAdapterManager.NumberingTblTableAdapter = null;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.OutgoingTypeTblTableAdapter = null;
            this.tableAdapterManager.SectionTblTableAdapter = null;
            this.tableAdapterManager.SquareTblTableAdapter = null;
            this.tableAdapterManager.StatusTblTableAdapter = null;
            this.tableAdapterManager.SubDepartmentTblTableAdapter = null;
            this.tableAdapterManager.TransactionTypeTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserLoginTblTableAdapter = null;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // minorCategoryTblBindingNavigator
            // 
            this.minorCategoryTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.minorCategoryTblBindingNavigator.BindingSource = this.minorCategoryTblBindingSource;
            this.minorCategoryTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.minorCategoryTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.minorCategoryTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.minorCategoryTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.minorCategoryTblBindingNavigatorSaveItem});
            this.minorCategoryTblBindingNavigator.Location = new System.Drawing.Point(0, 263);
            this.minorCategoryTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.minorCategoryTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.minorCategoryTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.minorCategoryTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.minorCategoryTblBindingNavigator.Name = "minorCategoryTblBindingNavigator";
            this.minorCategoryTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.minorCategoryTblBindingNavigator.Size = new System.Drawing.Size(1284, 27);
            this.minorCategoryTblBindingNavigator.TabIndex = 5;
            this.minorCategoryTblBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // minorCategoryTblBindingNavigatorSaveItem
            // 
            this.minorCategoryTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.minorCategoryTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("minorCategoryTblBindingNavigatorSaveItem.Image")));
            this.minorCategoryTblBindingNavigatorSaveItem.Name = "minorCategoryTblBindingNavigatorSaveItem";
            this.minorCategoryTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.minorCategoryTblBindingNavigatorSaveItem.Text = "Save Data";
            this.minorCategoryTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.minorCategoryTblBindingNavigatorSaveItem_Click);
            // 
            // ManageCategoriesTblsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 714);
            this.Controls.Add(this.minorCategoryGridControl);
            this.Controls.Add(this.minorCategoryTblBindingNavigator);
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
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryTblBindingNavigator)).EndInit();
            this.minorCategoryTblBindingNavigator.ResumeLayout(false);
            this.minorCategoryTblBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource mainCategoryTblBindingSource1;
        private System.Windows.Forms.Button findAllMinorCategoriestBtn;
        private System.Windows.Forms.BindingNavigator minorCategoryTblBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton minorCategoryTblBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl minorCategoryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView minorCategoryGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView mainCategoryGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMinorCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colMinorCategoryDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colMainCategory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit mainCategoryRepositoryItemLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colProductiveAgeInYears;
        private DevExpress.XtraGrid.Columns.GridColumn colDestructionRate;
    }
}