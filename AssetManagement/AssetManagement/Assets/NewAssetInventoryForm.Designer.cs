
namespace AssetManagement.Assets
{
    partial class NewAssetInventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAssetInventoryForm));
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.exportToExcelBtn = new System.Windows.Forms.Button();
            this.searchAssetBtn = new System.Windows.Forms.Button();
            this.customSearchRadioButton = new System.Windows.Forms.RadioButton();
            this.searchAllRadioButton = new System.Windows.Forms.RadioButton();
            this.customSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchByInsertionDatePanel = new System.Windows.Forms.Panel();
            this.searchByInsertionDateLabel_To = new System.Windows.Forms.Label();
            this.searchByInsertionDateDateEdit_To = new DevExpress.XtraEditors.DateEdit();
            this.searchByInsertionDateLabel_From = new System.Windows.Forms.Label();
            this.searchByInsertionDateDateEdit_From = new DevExpress.XtraEditors.DateEdit();
            this.searchByInsertionDateCheckBox = new System.Windows.Forms.CheckBox();
            this.searchByStatusLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.statusTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.searchByStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.searchByPurchaseDatePanel = new System.Windows.Forms.Panel();
            this.searchByPurchaseDateLabel_To = new System.Windows.Forms.Label();
            this.searchByPurchaseDateDateEdit_To = new DevExpress.XtraEditors.DateEdit();
            this.searchByPurchaseDateLabel_From = new System.Windows.Forms.Label();
            this.searchByPurchaseDateDateEdit_From = new DevExpress.XtraEditors.DateEdit();
            this.searchByPurchaseDateCheckBox = new System.Windows.Forms.CheckBox();
            this.searchByAssetDescriptionCheckBox = new System.Windows.Forms.CheckBox();
            this.searchByAssetDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.searchByCustodianNameCheckBox = new System.Windows.Forms.CheckBox();
            this.searchByCustodianNameTextBox = new System.Windows.Forms.TextBox();
            this.searchByAssetCodeCheckBox = new System.Windows.Forms.CheckBox();
            this.searchByAssetCodeTextBox = new System.Windows.Forms.TextBox();
            this.searchByMinorCategoryCheckBox = new System.Windows.Forms.CheckBox();
            this.searchByMainCategoryCheckBox = new System.Windows.Forms.CheckBox();
            this.searchBySquareCheckBox = new System.Windows.Forms.CheckBox();
            this.searchBySectionCheckBox = new System.Windows.Forms.CheckBox();
            this.searchBySquareLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.squareTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchBySectionLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.sectionTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchByDepartmentLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.departmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchByMinorCategoryLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.minorCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchByMainCategoryLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.mainCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchByDepartmentCheckBox = new System.Windows.Forms.CheckBox();
            this.departmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter();
            this.sectionTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SectionTblTableAdapter();
            this.squareTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SquareTblTableAdapter();
            this.mainCategoryTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.MainCategoryTblTableAdapter();
            this.minorCategoryTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.MinorCategoryTblTableAdapter();
            this.assetGridControl = new DevExpress.XtraGrid.GridControl();
            this.assetTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.statusTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.StatusTblTableAdapter();
            this.assetTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetTblTableAdapter();
            this.panel1.SuspendLayout();
            this.customSearchGroupBox.SuspendLayout();
            this.searchByInsertionDatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchByInsertionDateDateEdit_To.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByInsertionDateDateEdit_To.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByInsertionDateDateEdit_From.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByInsertionDateDateEdit_From.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByStatusLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            this.searchByPurchaseDatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchByPurchaseDateDateEdit_To.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByPurchaseDateDateEdit_To.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByPurchaseDateDateEdit_From.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByPurchaseDateDateEdit_From.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBySquareLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBySectionLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByDepartmentLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByMinorCategoryLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByMainCategoryLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetGridView)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.exportToExcelBtn);
            this.panel1.Controls.Add(this.searchAssetBtn);
            this.panel1.Controls.Add(this.customSearchRadioButton);
            this.panel1.Controls.Add(this.searchAllRadioButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1441, 101);
            this.panel1.TabIndex = 0;
            // 
            // exportToExcelBtn
            // 
            this.exportToExcelBtn.Enabled = false;
            this.exportToExcelBtn.Image = global::AssetManagement.Properties.Resources._3643510;
            this.exportToExcelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportToExcelBtn.Location = new System.Drawing.Point(36, 12);
            this.exportToExcelBtn.Name = "exportToExcelBtn";
            this.exportToExcelBtn.Size = new System.Drawing.Size(163, 74);
            this.exportToExcelBtn.TabIndex = 505;
            this.exportToExcelBtn.Text = "تصدير";
            this.exportToExcelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportToExcelBtn.UseVisualStyleBackColor = true;
            this.exportToExcelBtn.Click += new System.EventHandler(this.exportToExcelBtn_Click);
            // 
            // searchAssetBtn
            // 
            this.searchAssetBtn.Image = global::AssetManagement.Properties.Resources._2719309;
            this.searchAssetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchAssetBtn.Location = new System.Drawing.Point(228, 12);
            this.searchAssetBtn.Name = "searchAssetBtn";
            this.searchAssetBtn.Size = new System.Drawing.Size(163, 74);
            this.searchAssetBtn.TabIndex = 500;
            this.searchAssetBtn.Text = "بحث";
            this.searchAssetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchAssetBtn.UseVisualStyleBackColor = true;
            this.searchAssetBtn.Click += new System.EventHandler(this.searchAssetBtn_Click);
            // 
            // customSearchRadioButton
            // 
            this.customSearchRadioButton.AutoSize = true;
            this.customSearchRadioButton.Location = new System.Drawing.Point(977, 24);
            this.customSearchRadioButton.Name = "customSearchRadioButton";
            this.customSearchRadioButton.Size = new System.Drawing.Size(129, 28);
            this.customSearchRadioButton.TabIndex = 10;
            this.customSearchRadioButton.Text = "بحث مخصص";
            this.customSearchRadioButton.UseVisualStyleBackColor = true;
            this.customSearchRadioButton.CheckedChanged += new System.EventHandler(this.searchAllRadioButton_CheckedChanged);
            // 
            // searchAllRadioButton
            // 
            this.searchAllRadioButton.AutoSize = true;
            this.searchAllRadioButton.Checked = true;
            this.searchAllRadioButton.Location = new System.Drawing.Point(1141, 24);
            this.searchAllRadioButton.Name = "searchAllRadioButton";
            this.searchAllRadioButton.Size = new System.Drawing.Size(125, 28);
            this.searchAllRadioButton.TabIndex = 5;
            this.searchAllRadioButton.TabStop = true;
            this.searchAllRadioButton.Text = "بحث عن الكل";
            this.searchAllRadioButton.UseVisualStyleBackColor = true;
            this.searchAllRadioButton.CheckedChanged += new System.EventHandler(this.searchAllRadioButton_CheckedChanged);
            // 
            // customSearchGroupBox
            // 
            this.customSearchGroupBox.BackColor = System.Drawing.Color.Gainsboro;
            this.customSearchGroupBox.Controls.Add(this.searchByInsertionDatePanel);
            this.customSearchGroupBox.Controls.Add(this.searchByInsertionDateCheckBox);
            this.customSearchGroupBox.Controls.Add(this.searchByStatusLookUpEdit);
            this.customSearchGroupBox.Controls.Add(this.searchByStatusCheckBox);
            this.customSearchGroupBox.Controls.Add(this.searchByPurchaseDatePanel);
            this.customSearchGroupBox.Controls.Add(this.searchByPurchaseDateCheckBox);
            this.customSearchGroupBox.Controls.Add(this.searchByAssetDescriptionCheckBox);
            this.customSearchGroupBox.Controls.Add(this.searchByAssetDescriptionTextBox);
            this.customSearchGroupBox.Controls.Add(this.searchByCustodianNameCheckBox);
            this.customSearchGroupBox.Controls.Add(this.searchByCustodianNameTextBox);
            this.customSearchGroupBox.Controls.Add(this.searchByAssetCodeCheckBox);
            this.customSearchGroupBox.Controls.Add(this.searchByAssetCodeTextBox);
            this.customSearchGroupBox.Controls.Add(this.searchByMinorCategoryCheckBox);
            this.customSearchGroupBox.Controls.Add(this.searchByMainCategoryCheckBox);
            this.customSearchGroupBox.Controls.Add(this.searchBySquareCheckBox);
            this.customSearchGroupBox.Controls.Add(this.searchBySectionCheckBox);
            this.customSearchGroupBox.Controls.Add(this.searchBySquareLookUpEdit);
            this.customSearchGroupBox.Controls.Add(this.searchBySectionLookUpEdit);
            this.customSearchGroupBox.Controls.Add(this.searchByDepartmentLookUpEdit);
            this.customSearchGroupBox.Controls.Add(this.searchByMinorCategoryLookUpEdit);
            this.customSearchGroupBox.Controls.Add(this.searchByMainCategoryLookUpEdit);
            this.customSearchGroupBox.Controls.Add(this.searchByDepartmentCheckBox);
            this.customSearchGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.customSearchGroupBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customSearchGroupBox.Location = new System.Drawing.Point(0, 101);
            this.customSearchGroupBox.Name = "customSearchGroupBox";
            this.customSearchGroupBox.Size = new System.Drawing.Size(1441, 387);
            this.customSearchGroupBox.TabIndex = 100;
            this.customSearchGroupBox.TabStop = false;
            this.customSearchGroupBox.Text = "بحث مخصص";
            this.customSearchGroupBox.Visible = false;
            // 
            // searchByInsertionDatePanel
            // 
            this.searchByInsertionDatePanel.Controls.Add(this.searchByInsertionDateLabel_To);
            this.searchByInsertionDatePanel.Controls.Add(this.searchByInsertionDateDateEdit_To);
            this.searchByInsertionDatePanel.Controls.Add(this.searchByInsertionDateLabel_From);
            this.searchByInsertionDatePanel.Controls.Add(this.searchByInsertionDateDateEdit_From);
            this.searchByInsertionDatePanel.Location = new System.Drawing.Point(60, 179);
            this.searchByInsertionDatePanel.Name = "searchByInsertionDatePanel";
            this.searchByInsertionDatePanel.Size = new System.Drawing.Size(234, 101);
            this.searchByInsertionDatePanel.TabIndex = 335;
            this.searchByInsertionDatePanel.Visible = false;
            // 
            // searchByInsertionDateLabel_To
            // 
            this.searchByInsertionDateLabel_To.AutoSize = true;
            this.searchByInsertionDateLabel_To.Location = new System.Drawing.Point(189, 61);
            this.searchByInsertionDateLabel_To.Name = "searchByInsertionDateLabel_To";
            this.searchByInsertionDateLabel_To.Size = new System.Drawing.Size(29, 21);
            this.searchByInsertionDateLabel_To.TabIndex = 350;
            this.searchByInsertionDateLabel_To.Text = "إلى:";
            // 
            // searchByInsertionDateDateEdit_To
            // 
            this.searchByInsertionDateDateEdit_To.EditValue = null;
            this.searchByInsertionDateDateEdit_To.Location = new System.Drawing.Point(18, 57);
            this.searchByInsertionDateDateEdit_To.Name = "searchByInsertionDateDateEdit_To";
            this.searchByInsertionDateDateEdit_To.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByInsertionDateDateEdit_To.Properties.Appearance.Options.UseFont = true;
            this.searchByInsertionDateDateEdit_To.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchByInsertionDateDateEdit_To.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchByInsertionDateDateEdit_To.Size = new System.Drawing.Size(156, 28);
            this.searchByInsertionDateDateEdit_To.TabIndex = 355;
            // 
            // searchByInsertionDateLabel_From
            // 
            this.searchByInsertionDateLabel_From.AutoSize = true;
            this.searchByInsertionDateLabel_From.Location = new System.Drawing.Point(189, 16);
            this.searchByInsertionDateLabel_From.Name = "searchByInsertionDateLabel_From";
            this.searchByInsertionDateLabel_From.Size = new System.Drawing.Size(32, 21);
            this.searchByInsertionDateLabel_From.TabIndex = 340;
            this.searchByInsertionDateLabel_From.Text = "من:";
            // 
            // searchByInsertionDateDateEdit_From
            // 
            this.searchByInsertionDateDateEdit_From.EditValue = null;
            this.searchByInsertionDateDateEdit_From.Location = new System.Drawing.Point(18, 12);
            this.searchByInsertionDateDateEdit_From.Name = "searchByInsertionDateDateEdit_From";
            this.searchByInsertionDateDateEdit_From.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByInsertionDateDateEdit_From.Properties.Appearance.Options.UseFont = true;
            this.searchByInsertionDateDateEdit_From.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchByInsertionDateDateEdit_From.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchByInsertionDateDateEdit_From.Size = new System.Drawing.Size(156, 28);
            this.searchByInsertionDateDateEdit_From.TabIndex = 345;
            // 
            // searchByInsertionDateCheckBox
            // 
            this.searchByInsertionDateCheckBox.AutoSize = true;
            this.searchByInsertionDateCheckBox.Location = new System.Drawing.Point(312, 185);
            this.searchByInsertionDateCheckBox.Name = "searchByInsertionDateCheckBox";
            this.searchByInsertionDateCheckBox.Size = new System.Drawing.Size(153, 25);
            this.searchByInsertionDateCheckBox.TabIndex = 330;
            this.searchByInsertionDateCheckBox.Text = "حسب تاريخ الإدخال:";
            this.searchByInsertionDateCheckBox.UseVisualStyleBackColor = true;
            this.searchByInsertionDateCheckBox.CheckedChanged += new System.EventHandler(this.searchByInsertionDateCheckBox_CheckedChanged);
            // 
            // searchByStatusLookUpEdit
            // 
            this.searchByStatusLookUpEdit.Location = new System.Drawing.Point(60, 33);
            this.searchByStatusLookUpEdit.Name = "searchByStatusLookUpEdit";
            this.searchByStatusLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByStatusLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.searchByStatusLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchByStatusLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الحالة", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StatusName", "اسم الحالة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.searchByStatusLookUpEdit.Properties.DataSource = this.statusTblBindingSource;
            this.searchByStatusLookUpEdit.Properties.DisplayMember = "StatusName";
            this.searchByStatusLookUpEdit.Properties.ValueMember = "ID";
            this.searchByStatusLookUpEdit.Size = new System.Drawing.Size(234, 28);
            this.searchByStatusLookUpEdit.TabIndex = 305;
            this.searchByStatusLookUpEdit.Visible = false;
            // 
            // statusTblBindingSource
            // 
            this.statusTblBindingSource.DataMember = "StatusTbl";
            this.statusTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchByStatusCheckBox
            // 
            this.searchByStatusCheckBox.AutoSize = true;
            this.searchByStatusCheckBox.Location = new System.Drawing.Point(355, 35);
            this.searchByStatusCheckBox.Name = "searchByStatusCheckBox";
            this.searchByStatusCheckBox.Size = new System.Drawing.Size(110, 25);
            this.searchByStatusCheckBox.TabIndex = 300;
            this.searchByStatusCheckBox.Text = "حسب الحالة:";
            this.searchByStatusCheckBox.UseVisualStyleBackColor = true;
            this.searchByStatusCheckBox.CheckedChanged += new System.EventHandler(this.searchByStatusCheckBox_CheckedChanged);
            // 
            // searchByPurchaseDatePanel
            // 
            this.searchByPurchaseDatePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchByPurchaseDatePanel.Controls.Add(this.searchByPurchaseDateLabel_To);
            this.searchByPurchaseDatePanel.Controls.Add(this.searchByPurchaseDateDateEdit_To);
            this.searchByPurchaseDatePanel.Controls.Add(this.searchByPurchaseDateLabel_From);
            this.searchByPurchaseDatePanel.Controls.Add(this.searchByPurchaseDateDateEdit_From);
            this.searchByPurchaseDatePanel.Location = new System.Drawing.Point(526, 179);
            this.searchByPurchaseDatePanel.Name = "searchByPurchaseDatePanel";
            this.searchByPurchaseDatePanel.Size = new System.Drawing.Size(234, 101);
            this.searchByPurchaseDatePanel.TabIndex = 235;
            this.searchByPurchaseDatePanel.Visible = false;
            // 
            // searchByPurchaseDateLabel_To
            // 
            this.searchByPurchaseDateLabel_To.AutoSize = true;
            this.searchByPurchaseDateLabel_To.Location = new System.Drawing.Point(189, 61);
            this.searchByPurchaseDateLabel_To.Name = "searchByPurchaseDateLabel_To";
            this.searchByPurchaseDateLabel_To.Size = new System.Drawing.Size(29, 21);
            this.searchByPurchaseDateLabel_To.TabIndex = 250;
            this.searchByPurchaseDateLabel_To.Text = "إلى:";
            // 
            // searchByPurchaseDateDateEdit_To
            // 
            this.searchByPurchaseDateDateEdit_To.EditValue = null;
            this.searchByPurchaseDateDateEdit_To.Location = new System.Drawing.Point(18, 57);
            this.searchByPurchaseDateDateEdit_To.Name = "searchByPurchaseDateDateEdit_To";
            this.searchByPurchaseDateDateEdit_To.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByPurchaseDateDateEdit_To.Properties.Appearance.Options.UseFont = true;
            this.searchByPurchaseDateDateEdit_To.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchByPurchaseDateDateEdit_To.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchByPurchaseDateDateEdit_To.Size = new System.Drawing.Size(156, 28);
            this.searchByPurchaseDateDateEdit_To.TabIndex = 255;
            // 
            // searchByPurchaseDateLabel_From
            // 
            this.searchByPurchaseDateLabel_From.AutoSize = true;
            this.searchByPurchaseDateLabel_From.Location = new System.Drawing.Point(189, 16);
            this.searchByPurchaseDateLabel_From.Name = "searchByPurchaseDateLabel_From";
            this.searchByPurchaseDateLabel_From.Size = new System.Drawing.Size(32, 21);
            this.searchByPurchaseDateLabel_From.TabIndex = 240;
            this.searchByPurchaseDateLabel_From.Text = "من:";
            // 
            // searchByPurchaseDateDateEdit_From
            // 
            this.searchByPurchaseDateDateEdit_From.EditValue = null;
            this.searchByPurchaseDateDateEdit_From.Location = new System.Drawing.Point(18, 12);
            this.searchByPurchaseDateDateEdit_From.Name = "searchByPurchaseDateDateEdit_From";
            this.searchByPurchaseDateDateEdit_From.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByPurchaseDateDateEdit_From.Properties.Appearance.Options.UseFont = true;
            this.searchByPurchaseDateDateEdit_From.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchByPurchaseDateDateEdit_From.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchByPurchaseDateDateEdit_From.Size = new System.Drawing.Size(156, 28);
            this.searchByPurchaseDateDateEdit_From.TabIndex = 245;
            // 
            // searchByPurchaseDateCheckBox
            // 
            this.searchByPurchaseDateCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchByPurchaseDateCheckBox.AutoSize = true;
            this.searchByPurchaseDateCheckBox.Location = new System.Drawing.Point(788, 186);
            this.searchByPurchaseDateCheckBox.Name = "searchByPurchaseDateCheckBox";
            this.searchByPurchaseDateCheckBox.Size = new System.Drawing.Size(143, 25);
            this.searchByPurchaseDateCheckBox.TabIndex = 230;
            this.searchByPurchaseDateCheckBox.Text = "حسب تاريخ الشراء:";
            this.searchByPurchaseDateCheckBox.UseVisualStyleBackColor = true;
            this.searchByPurchaseDateCheckBox.CheckedChanged += new System.EventHandler(this.searchByPurchaseDateCheckBox_CheckedChanged);
            // 
            // searchByAssetDescriptionCheckBox
            // 
            this.searchByAssetDescriptionCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchByAssetDescriptionCheckBox.AutoSize = true;
            this.searchByAssetDescriptionCheckBox.Location = new System.Drawing.Point(781, 135);
            this.searchByAssetDescriptionCheckBox.Name = "searchByAssetDescriptionCheckBox";
            this.searchByAssetDescriptionCheckBox.Size = new System.Drawing.Size(150, 25);
            this.searchByAssetDescriptionCheckBox.TabIndex = 220;
            this.searchByAssetDescriptionCheckBox.Text = "حسب وصف الأصل:";
            this.searchByAssetDescriptionCheckBox.UseVisualStyleBackColor = true;
            this.searchByAssetDescriptionCheckBox.CheckedChanged += new System.EventHandler(this.searchByAssetDescriptionCheckBox_CheckedChanged);
            // 
            // searchByAssetDescriptionTextBox
            // 
            this.searchByAssetDescriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchByAssetDescriptionTextBox.Location = new System.Drawing.Point(526, 133);
            this.searchByAssetDescriptionTextBox.Name = "searchByAssetDescriptionTextBox";
            this.searchByAssetDescriptionTextBox.Size = new System.Drawing.Size(234, 28);
            this.searchByAssetDescriptionTextBox.TabIndex = 225;
            this.searchByAssetDescriptionTextBox.Visible = false;
            // 
            // searchByCustodianNameCheckBox
            // 
            this.searchByCustodianNameCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchByCustodianNameCheckBox.AutoSize = true;
            this.searchByCustodianNameCheckBox.Location = new System.Drawing.Point(772, 85);
            this.searchByCustodianNameCheckBox.Name = "searchByCustodianNameCheckBox";
            this.searchByCustodianNameCheckBox.Size = new System.Drawing.Size(159, 25);
            this.searchByCustodianNameCheckBox.TabIndex = 210;
            this.searchByCustodianNameCheckBox.Text = "حسب صاحب العهدة:";
            this.searchByCustodianNameCheckBox.UseVisualStyleBackColor = true;
            this.searchByCustodianNameCheckBox.CheckedChanged += new System.EventHandler(this.searchByCustodianNameCheckBox_CheckedChanged);
            // 
            // searchByCustodianNameTextBox
            // 
            this.searchByCustodianNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchByCustodianNameTextBox.Location = new System.Drawing.Point(526, 83);
            this.searchByCustodianNameTextBox.Name = "searchByCustodianNameTextBox";
            this.searchByCustodianNameTextBox.Size = new System.Drawing.Size(234, 28);
            this.searchByCustodianNameTextBox.TabIndex = 215;
            this.searchByCustodianNameTextBox.Visible = false;
            // 
            // searchByAssetCodeCheckBox
            // 
            this.searchByAssetCodeCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchByAssetCodeCheckBox.AutoSize = true;
            this.searchByAssetCodeCheckBox.Location = new System.Drawing.Point(795, 35);
            this.searchByAssetCodeCheckBox.Name = "searchByAssetCodeCheckBox";
            this.searchByAssetCodeCheckBox.Size = new System.Drawing.Size(136, 25);
            this.searchByAssetCodeCheckBox.TabIndex = 200;
            this.searchByAssetCodeCheckBox.Text = "حسب كود الأصل:";
            this.searchByAssetCodeCheckBox.UseVisualStyleBackColor = true;
            this.searchByAssetCodeCheckBox.CheckedChanged += new System.EventHandler(this.searchByAssetCodeCheckBox_CheckedChanged);
            // 
            // searchByAssetCodeTextBox
            // 
            this.searchByAssetCodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchByAssetCodeTextBox.Location = new System.Drawing.Point(526, 33);
            this.searchByAssetCodeTextBox.Name = "searchByAssetCodeTextBox";
            this.searchByAssetCodeTextBox.Size = new System.Drawing.Size(234, 28);
            this.searchByAssetCodeTextBox.TabIndex = 205;
            this.searchByAssetCodeTextBox.Visible = false;
            // 
            // searchByMinorCategoryCheckBox
            // 
            this.searchByMinorCategoryCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByMinorCategoryCheckBox.AutoSize = true;
            this.searchByMinorCategoryCheckBox.Location = new System.Drawing.Point(1277, 235);
            this.searchByMinorCategoryCheckBox.Name = "searchByMinorCategoryCheckBox";
            this.searchByMinorCategoryCheckBox.Size = new System.Drawing.Size(147, 25);
            this.searchByMinorCategoryCheckBox.TabIndex = 145;
            this.searchByMinorCategoryCheckBox.Text = "حسب الفئة الفرعية:";
            this.searchByMinorCategoryCheckBox.UseVisualStyleBackColor = true;
            this.searchByMinorCategoryCheckBox.CheckedChanged += new System.EventHandler(this.searchByMinorCategoryCheckBox_CheckedChanged);
            // 
            // searchByMainCategoryCheckBox
            // 
            this.searchByMainCategoryCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByMainCategoryCheckBox.AutoSize = true;
            this.searchByMainCategoryCheckBox.Location = new System.Drawing.Point(1272, 185);
            this.searchByMainCategoryCheckBox.Name = "searchByMainCategoryCheckBox";
            this.searchByMainCategoryCheckBox.Size = new System.Drawing.Size(152, 25);
            this.searchByMainCategoryCheckBox.TabIndex = 135;
            this.searchByMainCategoryCheckBox.Text = "حسب الفئة الرئيسية:";
            this.searchByMainCategoryCheckBox.UseVisualStyleBackColor = true;
            this.searchByMainCategoryCheckBox.CheckedChanged += new System.EventHandler(this.searchByMainCategoryCheckBox_CheckedChanged);
            // 
            // searchBySquareCheckBox
            // 
            this.searchBySquareCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBySquareCheckBox.AutoSize = true;
            this.searchBySquareCheckBox.Location = new System.Drawing.Point(1308, 135);
            this.searchBySquareCheckBox.Name = "searchBySquareCheckBox";
            this.searchBySquareCheckBox.Size = new System.Drawing.Size(116, 25);
            this.searchBySquareCheckBox.TabIndex = 125;
            this.searchBySquareCheckBox.Text = "حسب الساحة:";
            this.searchBySquareCheckBox.UseVisualStyleBackColor = true;
            this.searchBySquareCheckBox.CheckedChanged += new System.EventHandler(this.searchBySquareCheckBox_CheckedChanged);
            // 
            // searchBySectionCheckBox
            // 
            this.searchBySectionCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBySectionCheckBox.AutoSize = true;
            this.searchBySectionCheckBox.Location = new System.Drawing.Point(1313, 85);
            this.searchBySectionCheckBox.Name = "searchBySectionCheckBox";
            this.searchBySectionCheckBox.Size = new System.Drawing.Size(111, 25);
            this.searchBySectionCheckBox.TabIndex = 115;
            this.searchBySectionCheckBox.Text = "حسب الدائرة:";
            this.searchBySectionCheckBox.UseVisualStyleBackColor = true;
            this.searchBySectionCheckBox.CheckedChanged += new System.EventHandler(this.searchBySectionCheckBox_CheckedChanged);
            // 
            // searchBySquareLookUpEdit
            // 
            this.searchBySquareLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBySquareLookUpEdit.Location = new System.Drawing.Point(1019, 133);
            this.searchBySquareLookUpEdit.Name = "searchBySquareLookUpEdit";
            this.searchBySquareLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBySquareLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.searchBySquareLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchBySquareLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الساحة", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SquareName", "اسم الساحة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SquareLocation", "موقع الساحة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.searchBySquareLookUpEdit.Properties.DataSource = this.squareTblBindingSource;
            this.searchBySquareLookUpEdit.Properties.DisplayMember = "SquareName";
            this.searchBySquareLookUpEdit.Properties.ValueMember = "ID";
            this.searchBySquareLookUpEdit.Size = new System.Drawing.Size(234, 28);
            this.searchBySquareLookUpEdit.TabIndex = 130;
            this.searchBySquareLookUpEdit.Visible = false;
            // 
            // squareTblBindingSource
            // 
            this.squareTblBindingSource.DataMember = "SquareTbl";
            this.squareTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // searchBySectionLookUpEdit
            // 
            this.searchBySectionLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBySectionLookUpEdit.Location = new System.Drawing.Point(1019, 83);
            this.searchBySectionLookUpEdit.Name = "searchBySectionLookUpEdit";
            this.searchBySectionLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBySectionLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.searchBySectionLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchBySectionLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الدائرة", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SectionName", "اسم الدائرة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.searchBySectionLookUpEdit.Properties.DataSource = this.sectionTblBindingSource;
            this.searchBySectionLookUpEdit.Properties.DisplayMember = "SectionName";
            this.searchBySectionLookUpEdit.Properties.ValueMember = "ID";
            this.searchBySectionLookUpEdit.Size = new System.Drawing.Size(234, 28);
            this.searchBySectionLookUpEdit.TabIndex = 120;
            this.searchBySectionLookUpEdit.Visible = false;
            // 
            // sectionTblBindingSource
            // 
            this.sectionTblBindingSource.DataMember = "SectionTbl";
            this.sectionTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // searchByDepartmentLookUpEdit
            // 
            this.searchByDepartmentLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByDepartmentLookUpEdit.Location = new System.Drawing.Point(1019, 33);
            this.searchByDepartmentLookUpEdit.Name = "searchByDepartmentLookUpEdit";
            this.searchByDepartmentLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByDepartmentLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.searchByDepartmentLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchByDepartmentLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف القسم", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "اسم القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentHQ", "مقر القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.searchByDepartmentLookUpEdit.Properties.DataSource = this.departmentTblBindingSource;
            this.searchByDepartmentLookUpEdit.Properties.DisplayMember = "DepartmentName";
            this.searchByDepartmentLookUpEdit.Properties.ValueMember = "ID";
            this.searchByDepartmentLookUpEdit.Size = new System.Drawing.Size(234, 28);
            this.searchByDepartmentLookUpEdit.TabIndex = 110;
            this.searchByDepartmentLookUpEdit.Visible = false;
            // 
            // departmentTblBindingSource
            // 
            this.departmentTblBindingSource.DataMember = "DepartmentTbl";
            this.departmentTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // searchByMinorCategoryLookUpEdit
            // 
            this.searchByMinorCategoryLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByMinorCategoryLookUpEdit.Location = new System.Drawing.Point(1019, 233);
            this.searchByMinorCategoryLookUpEdit.Name = "searchByMinorCategoryLookUpEdit";
            this.searchByMinorCategoryLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByMinorCategoryLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.searchByMinorCategoryLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchByMinorCategoryLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الفئة الفرعية", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MinorCategoryName", "اسم الفئة الفرعية", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MinorCategoryDescription", "وصف الفئة الفرعية", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainCategory", "معرف الفئة الرئيسية", 100, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductiveAgeInYears", "العمر الإنتاجي بالسنوات", 150, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DestructionRate", "معدل الإهلاك", 120, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.searchByMinorCategoryLookUpEdit.Properties.DataSource = this.minorCategoryTblBindingSource;
            this.searchByMinorCategoryLookUpEdit.Properties.DisplayMember = "MinorCategoryName";
            this.searchByMinorCategoryLookUpEdit.Properties.ValueMember = "ID";
            this.searchByMinorCategoryLookUpEdit.Size = new System.Drawing.Size(234, 28);
            this.searchByMinorCategoryLookUpEdit.TabIndex = 150;
            this.searchByMinorCategoryLookUpEdit.Visible = false;
            // 
            // minorCategoryTblBindingSource
            // 
            this.minorCategoryTblBindingSource.DataMember = "MinorCategoryTbl";
            this.minorCategoryTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // searchByMainCategoryLookUpEdit
            // 
            this.searchByMainCategoryLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByMainCategoryLookUpEdit.Location = new System.Drawing.Point(1019, 183);
            this.searchByMainCategoryLookUpEdit.Name = "searchByMainCategoryLookUpEdit";
            this.searchByMainCategoryLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByMainCategoryLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.searchByMainCategoryLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchByMainCategoryLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الفئة الرئيسية", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainCategoryName", "اسم الفئة الرئيسية", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainCategoryDescription", "وصف الفئة الرئيسية", 250, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.searchByMainCategoryLookUpEdit.Properties.DataSource = this.mainCategoryTblBindingSource;
            this.searchByMainCategoryLookUpEdit.Properties.DisplayMember = "MainCategoryName";
            this.searchByMainCategoryLookUpEdit.Properties.ValueMember = "ID";
            this.searchByMainCategoryLookUpEdit.Size = new System.Drawing.Size(234, 28);
            this.searchByMainCategoryLookUpEdit.TabIndex = 140;
            this.searchByMainCategoryLookUpEdit.Visible = false;
            // 
            // mainCategoryTblBindingSource
            // 
            this.mainCategoryTblBindingSource.DataMember = "MainCategoryTbl";
            this.mainCategoryTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // searchByDepartmentCheckBox
            // 
            this.searchByDepartmentCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByDepartmentCheckBox.AutoSize = true;
            this.searchByDepartmentCheckBox.Location = new System.Drawing.Point(1313, 35);
            this.searchByDepartmentCheckBox.Name = "searchByDepartmentCheckBox";
            this.searchByDepartmentCheckBox.Size = new System.Drawing.Size(111, 25);
            this.searchByDepartmentCheckBox.TabIndex = 105;
            this.searchByDepartmentCheckBox.Text = "حسب القسم:";
            this.searchByDepartmentCheckBox.UseVisualStyleBackColor = true;
            this.searchByDepartmentCheckBox.CheckedChanged += new System.EventHandler(this.searchByDepartmentCheckBox_CheckedChanged);
            // 
            // departmentTblTableAdapter
            // 
            this.departmentTblTableAdapter.ClearBeforeFill = true;
            // 
            // sectionTblTableAdapter
            // 
            this.sectionTblTableAdapter.ClearBeforeFill = true;
            // 
            // squareTblTableAdapter
            // 
            this.squareTblTableAdapter.ClearBeforeFill = true;
            // 
            // mainCategoryTblTableAdapter
            // 
            this.mainCategoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // minorCategoryTblTableAdapter
            // 
            this.minorCategoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // assetGridControl
            // 
            this.assetGridControl.DataSource = this.assetTblBindingSource;
            this.assetGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetGridControl.Location = new System.Drawing.Point(0, 488);
            this.assetGridControl.MainView = this.assetGridView;
            this.assetGridControl.Name = "assetGridControl";
            this.assetGridControl.Size = new System.Drawing.Size(1441, 343);
            this.assetGridControl.TabIndex = 600;
            this.assetGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.assetGridView});
            this.assetGridControl.Visible = false;
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
            this.assetGridView.GridControl = this.assetGridControl;
            this.assetGridView.Name = "assetGridView";
            // 
            // colID
            // 
            this.colID.Caption = "معرف الأصل";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 80;
            this.colID.Name = "colID";
            this.colID.Width = 94;
            // 
            // colAssetCode
            // 
            this.colAssetCode.Caption = "كود الأصل";
            this.colAssetCode.FieldName = "AssetCode";
            this.colAssetCode.MinWidth = 80;
            this.colAssetCode.Name = "colAssetCode";
            this.colAssetCode.Visible = true;
            this.colAssetCode.VisibleIndex = 0;
            this.colAssetCode.Width = 108;
            // 
            // colAssetSection
            // 
            this.colAssetSection.Caption = "الدائرة";
            this.colAssetSection.FieldName = "AssetSection";
            this.colAssetSection.MinWidth = 120;
            this.colAssetSection.Name = "colAssetSection";
            this.colAssetSection.Visible = true;
            this.colAssetSection.VisibleIndex = 1;
            this.colAssetSection.Width = 120;
            // 
            // colAssetDept
            // 
            this.colAssetDept.Caption = "القسم";
            this.colAssetDept.FieldName = "AssetDept";
            this.colAssetDept.MinWidth = 120;
            this.colAssetDept.Name = "colAssetDept";
            this.colAssetDept.Visible = true;
            this.colAssetDept.VisibleIndex = 2;
            this.colAssetDept.Width = 120;
            // 
            // colAssetSquare
            // 
            this.colAssetSquare.Caption = "الساحة";
            this.colAssetSquare.FieldName = "AssetSquare";
            this.colAssetSquare.MinWidth = 120;
            this.colAssetSquare.Name = "colAssetSquare";
            this.colAssetSquare.Visible = true;
            this.colAssetSquare.VisibleIndex = 3;
            this.colAssetSquare.Width = 120;
            // 
            // colAssetMinorCategory
            // 
            this.colAssetMinorCategory.Caption = "الفئة الفرعية";
            this.colAssetMinorCategory.FieldName = "AssetMinorCategory";
            this.colAssetMinorCategory.MinWidth = 120;
            this.colAssetMinorCategory.Name = "colAssetMinorCategory";
            this.colAssetMinorCategory.Visible = true;
            this.colAssetMinorCategory.VisibleIndex = 4;
            this.colAssetMinorCategory.Width = 120;
            // 
            // colAssetSpecifications
            // 
            this.colAssetSpecifications.Caption = "مواصفات الأصل";
            this.colAssetSpecifications.FieldName = "AssetSpecifications";
            this.colAssetSpecifications.MinWidth = 150;
            this.colAssetSpecifications.Name = "colAssetSpecifications";
            this.colAssetSpecifications.Visible = true;
            this.colAssetSpecifications.VisibleIndex = 5;
            this.colAssetSpecifications.Width = 150;
            // 
            // colModel
            // 
            this.colModel.Caption = "الموديل";
            this.colModel.FieldName = "Model";
            this.colModel.MinWidth = 100;
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 6;
            this.colModel.Width = 100;
            // 
            // colColor
            // 
            this.colColor.Caption = "اللون";
            this.colColor.FieldName = "Color";
            this.colColor.MinWidth = 80;
            this.colColor.Name = "colColor";
            this.colColor.Visible = true;
            this.colColor.VisibleIndex = 7;
            this.colColor.Width = 94;
            // 
            // colVolume
            // 
            this.colVolume.Caption = "السعة أو الحجم";
            this.colVolume.FieldName = "Volume";
            this.colVolume.MinWidth = 100;
            this.colVolume.Name = "colVolume";
            this.colVolume.Visible = true;
            this.colVolume.VisibleIndex = 8;
            this.colVolume.Width = 100;
            // 
            // colPurchaseDate
            // 
            this.colPurchaseDate.Caption = "تاريخ الشراء";
            this.colPurchaseDate.FieldName = "PurchaseDate";
            this.colPurchaseDate.MinWidth = 80;
            this.colPurchaseDate.Name = "colPurchaseDate";
            this.colPurchaseDate.Visible = true;
            this.colPurchaseDate.VisibleIndex = 9;
            this.colPurchaseDate.Width = 94;
            // 
            // colPurchasePrice
            // 
            this.colPurchasePrice.Caption = "سعر الشراء";
            this.colPurchasePrice.FieldName = "PurchasePrice";
            this.colPurchasePrice.MinWidth = 80;
            this.colPurchasePrice.Name = "colPurchasePrice";
            this.colPurchasePrice.Visible = true;
            this.colPurchasePrice.VisibleIndex = 10;
            this.colPurchasePrice.Width = 94;
            // 
            // colPurchasePriceCurrency
            // 
            this.colPurchasePriceCurrency.Caption = "عملة سعر الشراء";
            this.colPurchasePriceCurrency.FieldName = "PurchasePriceCurrency";
            this.colPurchasePriceCurrency.MinWidth = 80;
            this.colPurchasePriceCurrency.Name = "colPurchasePriceCurrency";
            this.colPurchasePriceCurrency.Visible = true;
            this.colPurchasePriceCurrency.VisibleIndex = 11;
            this.colPurchasePriceCurrency.Width = 94;
            // 
            // colPlaceOfPresence
            // 
            this.colPlaceOfPresence.Caption = "مكان التواجد";
            this.colPlaceOfPresence.FieldName = "PlaceOfPresence";
            this.colPlaceOfPresence.MinWidth = 120;
            this.colPlaceOfPresence.Name = "colPlaceOfPresence";
            this.colPlaceOfPresence.Visible = true;
            this.colPlaceOfPresence.VisibleIndex = 12;
            this.colPlaceOfPresence.Width = 120;
            // 
            // colCurrentStatus
            // 
            this.colCurrentStatus.Caption = "الحالة الآنية";
            this.colCurrentStatus.FieldName = "CurrentStatus";
            this.colCurrentStatus.MinWidth = 80;
            this.colCurrentStatus.Name = "colCurrentStatus";
            this.colCurrentStatus.Visible = true;
            this.colCurrentStatus.VisibleIndex = 13;
            this.colCurrentStatus.Width = 94;
            // 
            // colBenefitPercentage
            // 
            this.colBenefitPercentage.Caption = "نسبة الاستفادة منه";
            this.colBenefitPercentage.FieldName = "BenefitPercentage";
            this.colBenefitPercentage.MinWidth = 120;
            this.colBenefitPercentage.Name = "colBenefitPercentage";
            this.colBenefitPercentage.Visible = true;
            this.colBenefitPercentage.VisibleIndex = 14;
            this.colBenefitPercentage.Width = 120;
            // 
            // colActualCurrentPrice
            // 
            this.colActualCurrentPrice.Caption = "السعر الفعلي الحالي";
            this.colActualCurrentPrice.FieldName = "ActualCurrentPrice";
            this.colActualCurrentPrice.MinWidth = 80;
            this.colActualCurrentPrice.Name = "colActualCurrentPrice";
            this.colActualCurrentPrice.Visible = true;
            this.colActualCurrentPrice.VisibleIndex = 15;
            this.colActualCurrentPrice.Width = 94;
            // 
            // colActualCurrentPriceCurrency
            // 
            this.colActualCurrentPriceCurrency.Caption = "عملة السعر الفعلي الحالي";
            this.colActualCurrentPriceCurrency.FieldName = "ActualCurrentPriceCurrency";
            this.colActualCurrentPriceCurrency.MinWidth = 80;
            this.colActualCurrentPriceCurrency.Name = "colActualCurrentPriceCurrency";
            this.colActualCurrentPriceCurrency.Visible = true;
            this.colActualCurrentPriceCurrency.VisibleIndex = 16;
            this.colActualCurrentPriceCurrency.Width = 94;
            // 
            // colCustodianName
            // 
            this.colCustodianName.Caption = "صاحب العهدة";
            this.colCustodianName.FieldName = "CustodianName";
            this.colCustodianName.MinWidth = 120;
            this.colCustodianName.Name = "colCustodianName";
            this.colCustodianName.Visible = true;
            this.colCustodianName.VisibleIndex = 17;
            this.colCustodianName.Width = 120;
            // 
            // colMoreDetails
            // 
            this.colMoreDetails.Caption = "تفاصيل إضافية";
            this.colMoreDetails.FieldName = "MoreDetails";
            this.colMoreDetails.MinWidth = 150;
            this.colMoreDetails.Name = "colMoreDetails";
            this.colMoreDetails.Visible = true;
            this.colMoreDetails.VisibleIndex = 18;
            this.colMoreDetails.Width = 150;
            // 
            // colAssetNotes
            // 
            this.colAssetNotes.Caption = "ملاحظات أخرى";
            this.colAssetNotes.FieldName = "AssetNotes";
            this.colAssetNotes.MinWidth = 150;
            this.colAssetNotes.Name = "colAssetNotes";
            this.colAssetNotes.Visible = true;
            this.colAssetNotes.VisibleIndex = 19;
            this.colAssetNotes.Width = 251;
            // 
            // colEstateAddress
            // 
            this.colEstateAddress.Caption = "العنوان الحالي";
            this.colEstateAddress.FieldName = "EstateAddress";
            this.colEstateAddress.MinWidth = 150;
            this.colEstateAddress.Name = "colEstateAddress";
            this.colEstateAddress.Visible = true;
            this.colEstateAddress.VisibleIndex = 20;
            this.colEstateAddress.Width = 150;
            // 
            // colOwnerName
            // 
            this.colOwnerName.Caption = "اسم المالك";
            this.colOwnerName.FieldName = "OwnerName";
            this.colOwnerName.MinWidth = 120;
            this.colOwnerName.Name = "colOwnerName";
            this.colOwnerName.Visible = true;
            this.colOwnerName.VisibleIndex = 21;
            this.colOwnerName.Width = 120;
            // 
            // colOfUsed
            // 
            this.colOfUsed.Caption = "المستغل منه";
            this.colOfUsed.FieldName = "OfUsed";
            this.colOfUsed.MinWidth = 120;
            this.colOfUsed.Name = "colOfUsed";
            this.colOfUsed.Visible = true;
            this.colOfUsed.VisibleIndex = 22;
            this.colOfUsed.Width = 120;
            // 
            // colEstateOwnershipDocumentWith
            // 
            this.colEstateOwnershipDocumentWith.Caption = "مع من ورقة الملكية";
            this.colEstateOwnershipDocumentWith.FieldName = "EstateOwnershipDocumentWith";
            this.colEstateOwnershipDocumentWith.MinWidth = 120;
            this.colEstateOwnershipDocumentWith.Name = "colEstateOwnershipDocumentWith";
            this.colEstateOwnershipDocumentWith.Visible = true;
            this.colEstateOwnershipDocumentWith.VisibleIndex = 23;
            this.colEstateOwnershipDocumentWith.Width = 1000;
            // 
            // colEstateArea
            // 
            this.colEstateArea.Caption = "مساحة العقار";
            this.colEstateArea.FieldName = "EstateArea";
            this.colEstateArea.MinWidth = 80;
            this.colEstateArea.Name = "colEstateArea";
            this.colEstateArea.Visible = true;
            this.colEstateArea.VisibleIndex = 24;
            this.colEstateArea.Width = 94;
            // 
            // colEstateAreaUnit
            // 
            this.colEstateAreaUnit.Caption = "واحدة مساحة العقار";
            this.colEstateAreaUnit.FieldName = "EstateAreaUnit";
            this.colEstateAreaUnit.MinWidth = 80;
            this.colEstateAreaUnit.Name = "colEstateAreaUnit";
            this.colEstateAreaUnit.Visible = true;
            this.colEstateAreaUnit.VisibleIndex = 25;
            this.colEstateAreaUnit.Width = 1000;
            // 
            // colCarPanelNumber
            // 
            this.colCarPanelNumber.Caption = "رقم لوحة المركبة";
            this.colCarPanelNumber.FieldName = "CarPanelNumber";
            this.colCarPanelNumber.MinWidth = 100;
            this.colCarPanelNumber.Name = "colCarPanelNumber";
            this.colCarPanelNumber.Visible = true;
            this.colCarPanelNumber.VisibleIndex = 26;
            this.colCarPanelNumber.Width = 100;
            // 
            // colCarManufacturingYear
            // 
            this.colCarManufacturingYear.Caption = "سنة صنع المركبة";
            this.colCarManufacturingYear.FieldName = "CarManufacturingYear";
            this.colCarManufacturingYear.MinWidth = 80;
            this.colCarManufacturingYear.Name = "colCarManufacturingYear";
            this.colCarManufacturingYear.Visible = true;
            this.colCarManufacturingYear.VisibleIndex = 27;
            this.colCarManufacturingYear.Width = 94;
            // 
            // colCarChassisNumber
            // 
            this.colCarChassisNumber.Caption = "رقم هيكل (شاصيه) المركبة";
            this.colCarChassisNumber.FieldName = "CarChassisNumber";
            this.colCarChassisNumber.MinWidth = 100;
            this.colCarChassisNumber.Name = "colCarChassisNumber";
            this.colCarChassisNumber.Visible = true;
            this.colCarChassisNumber.VisibleIndex = 28;
            this.colCarChassisNumber.Width = 100;
            // 
            // colCarEngineNumber
            // 
            this.colCarEngineNumber.Caption = "رقم محرك المركبة";
            this.colCarEngineNumber.FieldName = "CarEngineNumber";
            this.colCarEngineNumber.MinWidth = 100;
            this.colCarEngineNumber.Name = "colCarEngineNumber";
            this.colCarEngineNumber.Visible = true;
            this.colCarEngineNumber.VisibleIndex = 29;
            this.colCarEngineNumber.Width = 100;
            // 
            // colCurrentDestructionRate
            // 
            this.colCurrentDestructionRate.Caption = "معدل الإهلاك";
            this.colCurrentDestructionRate.FieldName = "CurrentDestructionRate";
            this.colCurrentDestructionRate.MinWidth = 80;
            this.colCurrentDestructionRate.Name = "colCurrentDestructionRate";
            this.colCurrentDestructionRate.Visible = true;
            this.colCurrentDestructionRate.VisibleIndex = 30;
            this.colCurrentDestructionRate.Width = 94;
            // 
            // colLifeSpanInMonths
            // 
            this.colLifeSpanInMonths.Caption = "العمر الافتراضي المتبقي";
            this.colLifeSpanInMonths.FieldName = "LifeSpanInMonths";
            this.colLifeSpanInMonths.MinWidth = 80;
            this.colLifeSpanInMonths.Name = "colLifeSpanInMonths";
            this.colLifeSpanInMonths.Visible = true;
            this.colLifeSpanInMonths.VisibleIndex = 31;
            this.colLifeSpanInMonths.Width = 94;
            // 
            // colIsSold
            // 
            this.colIsSold.Caption = "مباع";
            this.colIsSold.FieldName = "IsSold";
            this.colIsSold.MinWidth = 50;
            this.colIsSold.Name = "colIsSold";
            this.colIsSold.Visible = true;
            this.colIsSold.VisibleIndex = 32;
            this.colIsSold.Width = 94;
            // 
            // colIsOutOfWork
            // 
            this.colIsOutOfWork.Caption = "خارج الحدمة";
            this.colIsOutOfWork.FieldName = "IsOutOfWork";
            this.colIsOutOfWork.MinWidth = 50;
            this.colIsOutOfWork.Name = "colIsOutOfWork";
            this.colIsOutOfWork.Visible = true;
            this.colIsOutOfWork.VisibleIndex = 33;
            this.colIsOutOfWork.Width = 94;
            // 
            // colInsertedOn
            // 
            this.colInsertedOn.Caption = "تاريخ الإضافة";
            this.colInsertedOn.FieldName = "InsertedOn";
            this.colInsertedOn.MinWidth = 80;
            this.colInsertedOn.Name = "colInsertedOn";
            this.colInsertedOn.Width = 94;
            // 
            // colLastModifiedOn
            // 
            this.colLastModifiedOn.Caption = "تاريخ آخر تعديل";
            this.colLastModifiedOn.FieldName = "LastModifiedOn";
            this.colLastModifiedOn.MinWidth = 80;
            this.colLastModifiedOn.Name = "colLastModifiedOn";
            this.colLastModifiedOn.Width = 94;
            // 
            // colInsertedBy
            // 
            this.colInsertedBy.Caption = "الحساب الذي قام بالإضافة";
            this.colInsertedBy.FieldName = "InsertedBy";
            this.colInsertedBy.MinWidth = 80;
            this.colInsertedBy.Name = "colInsertedBy";
            this.colInsertedBy.Width = 94;
            // 
            // colLastModifiedBy
            // 
            this.colLastModifiedBy.Caption = "الحساب الذي قام بآخر تعديل";
            this.colLastModifiedBy.FieldName = "LastModifiedBy";
            this.colLastModifiedBy.MinWidth = 80;
            this.colLastModifiedBy.Name = "colLastModifiedBy";
            this.colLastModifiedBy.Width = 94;
            // 
            // statusTblTableAdapter
            // 
            this.statusTblTableAdapter.ClearBeforeFill = true;
            // 
            // assetTblTableAdapter
            // 
            this.assetTblTableAdapter.ClearBeforeFill = true;
            // 
            // NewAssetInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 831);
            this.Controls.Add(this.assetGridControl);
            this.Controls.Add(this.customSearchGroupBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewAssetInventoryForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إجراء جرد للأصول";
            this.Load += new System.EventHandler(this.NewAssetInventoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.customSearchGroupBox.ResumeLayout(false);
            this.customSearchGroupBox.PerformLayout();
            this.searchByInsertionDatePanel.ResumeLayout(false);
            this.searchByInsertionDatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchByInsertionDateDateEdit_To.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByInsertionDateDateEdit_To.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByInsertionDateDateEdit_From.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByInsertionDateDateEdit_From.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByStatusLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            this.searchByPurchaseDatePanel.ResumeLayout(false);
            this.searchByPurchaseDatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchByPurchaseDateDateEdit_To.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByPurchaseDateDateEdit_To.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByPurchaseDateDateEdit_From.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByPurchaseDateDateEdit_From.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBySquareLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBySectionLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByDepartmentLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByMinorCategoryLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorCategoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByMainCategoryLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton customSearchRadioButton;
        private System.Windows.Forms.RadioButton searchAllRadioButton;
        private System.Windows.Forms.GroupBox customSearchGroupBox;
        private System.Windows.Forms.CheckBox searchByDepartmentCheckBox;
        private System.Windows.Forms.CheckBox searchByMinorCategoryCheckBox;
        private System.Windows.Forms.CheckBox searchByMainCategoryCheckBox;
        private System.Windows.Forms.CheckBox searchBySquareCheckBox;
        private System.Windows.Forms.CheckBox searchBySectionCheckBox;
        private DevExpress.XtraEditors.LookUpEdit searchBySquareLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit searchBySectionLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit searchByDepartmentLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit searchByMinorCategoryLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit searchByMainCategoryLookUpEdit;
        private AssetMngDbDataSet assetMngDbDataSet;
        private System.Windows.Forms.BindingSource departmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter departmentTblTableAdapter;
        private System.Windows.Forms.BindingSource sectionTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SectionTblTableAdapter sectionTblTableAdapter;
        private System.Windows.Forms.BindingSource squareTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SquareTblTableAdapter squareTblTableAdapter;
        private System.Windows.Forms.BindingSource mainCategoryTblBindingSource;
        private AssetMngDbDataSetTableAdapters.MainCategoryTblTableAdapter mainCategoryTblTableAdapter;
        private System.Windows.Forms.BindingSource minorCategoryTblBindingSource;
        private AssetMngDbDataSetTableAdapters.MinorCategoryTblTableAdapter minorCategoryTblTableAdapter;
        private DevExpress.XtraGrid.GridControl assetGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView assetGridView;
        private System.Windows.Forms.CheckBox searchByAssetCodeCheckBox;
        private System.Windows.Forms.TextBox searchByAssetCodeTextBox;
        private System.Windows.Forms.CheckBox searchByAssetDescriptionCheckBox;
        private System.Windows.Forms.TextBox searchByAssetDescriptionTextBox;
        private System.Windows.Forms.CheckBox searchByCustodianNameCheckBox;
        private System.Windows.Forms.TextBox searchByCustodianNameTextBox;
        private System.Windows.Forms.Panel searchByPurchaseDatePanel;
        private System.Windows.Forms.Label searchByPurchaseDateLabel_To;
        private DevExpress.XtraEditors.DateEdit searchByPurchaseDateDateEdit_To;
        private System.Windows.Forms.Label searchByPurchaseDateLabel_From;
        private DevExpress.XtraEditors.DateEdit searchByPurchaseDateDateEdit_From;
        private System.Windows.Forms.CheckBox searchByPurchaseDateCheckBox;
        private System.Windows.Forms.Panel searchByInsertionDatePanel;
        private System.Windows.Forms.Label searchByInsertionDateLabel_To;
        private DevExpress.XtraEditors.DateEdit searchByInsertionDateDateEdit_To;
        private System.Windows.Forms.Label searchByInsertionDateLabel_From;
        private DevExpress.XtraEditors.DateEdit searchByInsertionDateDateEdit_From;
        private System.Windows.Forms.CheckBox searchByInsertionDateCheckBox;
        private System.Windows.Forms.CheckBox searchByStatusCheckBox;
        private DevExpress.XtraEditors.LookUpEdit searchByStatusLookUpEdit;
        private System.Windows.Forms.BindingSource statusTblBindingSource;
        private AssetMngDbDataSetTableAdapters.StatusTblTableAdapter statusTblTableAdapter;
        private System.Windows.Forms.Button searchAssetBtn;
        private System.Windows.Forms.BindingSource assetTblBindingSource;
        private AssetMngDbDataSetTableAdapters.AssetTblTableAdapter assetTblTableAdapter;
        private System.Windows.Forms.Button exportToExcelBtn;
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