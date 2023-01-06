
namespace AssetManagement.Assets
{
    partial class CustomAssetsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomAssetsForm));
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.financialItemTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.financialItemCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subDepartmentTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.currencyTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.financialItemTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.FinancialItemTblTableAdapter();
            this.financialItemCategoryTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.FinancialItemCategoryTblTableAdapter();
            this.currencyTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.CurrencyTblTableAdapter();
            this.searchByDepartmentRadioButton = new System.Windows.Forms.RadioButton();
            this.searchAllRadioButton = new System.Windows.Forms.RadioButton();
            this.manageDepartmentTblBtn = new System.Windows.Forms.Button();
            this.departmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter();
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.sectionTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SectionTblTableAdapter();
            this.subDepartmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SubDepartmentTblTableAdapter();
            this.searchBySectionRadioButton = new System.Windows.Forms.RadioButton();
            this.searchBySubDepartmentRadioButton = new System.Windows.Forms.RadioButton();
            this.manageSectionTblBtn = new System.Windows.Forms.Button();
            this.searchBySectionLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.sectionTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manageSubDepartmentTblBtn = new System.Windows.Forms.Button();
            this.subDepartmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchAssetsBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.searchBySubDepartmentSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.subDepartmentVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchByDepartmentSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.departmentVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colمعرفالقسم = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colاسمالقسم = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالدائرةالتييتبعلهاالقسم = new DevExpress.XtraGrid.Columns.GridColumn();
            this.departmentVwTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.DepartmentVwTableAdapter();
            this.subDepartmentVwTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SubDepartmentVwTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBySectionLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBySubDepartmentSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByDepartmentSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
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
            this.mainAlertControl.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight;
            this.mainAlertControl.FormLoad += new DevExpress.XtraBars.Alerter.AlertFormLoadEventHandler(this.mainAlertControl_FormLoad);
            // 
            // financialItemTblBindingSource
            // 
            this.financialItemTblBindingSource.DataMember = "FinancialItemTbl";
            this.financialItemTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // financialItemCategoryTblBindingSource
            // 
            this.financialItemCategoryTblBindingSource.DataMember = "FinancialItemCategoryTbl";
            this.financialItemCategoryTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // subDepartmentTblBindingSource1
            // 
            this.subDepartmentTblBindingSource1.DataMember = "SubDepartmentTbl";
            this.subDepartmentTblBindingSource1.DataSource = this.assetMngDbDataSet;
            // 
            // currencyTblBindingSource
            // 
            this.currencyTblBindingSource.DataMember = "CurrencyTbl";
            this.currencyTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // departmentTblBindingSource1
            // 
            this.departmentTblBindingSource1.DataMember = "DepartmentTbl";
            this.departmentTblBindingSource1.DataSource = this.assetMngDbDataSet;
            // 
            // financialItemTblTableAdapter
            // 
            this.financialItemTblTableAdapter.ClearBeforeFill = true;
            // 
            // financialItemCategoryTblTableAdapter
            // 
            this.financialItemCategoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // currencyTblTableAdapter
            // 
            this.currencyTblTableAdapter.ClearBeforeFill = true;
            // 
            // searchByDepartmentRadioButton
            // 
            this.searchByDepartmentRadioButton.AutoSize = true;
            this.searchByDepartmentRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByDepartmentRadioButton.Location = new System.Drawing.Point(37, 150);
            this.searchByDepartmentRadioButton.Name = "searchByDepartmentRadioButton";
            this.searchByDepartmentRadioButton.Size = new System.Drawing.Size(124, 25);
            this.searchByDepartmentRadioButton.TabIndex = 30;
            this.searchByDepartmentRadioButton.Text = "ضمن قسم معين";
            this.searchByDepartmentRadioButton.UseVisualStyleBackColor = true;
            this.searchByDepartmentRadioButton.CheckedChanged += new System.EventHandler(this.searchInDeptRadioButton_CheckedChanged);
            // 
            // searchAllRadioButton
            // 
            this.searchAllRadioButton.AutoSize = true;
            this.searchAllRadioButton.Checked = true;
            this.searchAllRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchAllRadioButton.Location = new System.Drawing.Point(37, 30);
            this.searchAllRadioButton.Name = "searchAllRadioButton";
            this.searchAllRadioButton.Size = new System.Drawing.Size(92, 25);
            this.searchAllRadioButton.TabIndex = 15;
            this.searchAllRadioButton.TabStop = true;
            this.searchAllRadioButton.Text = "كل الأصول";
            this.searchAllRadioButton.UseVisualStyleBackColor = true;
            this.searchAllRadioButton.CheckedChanged += new System.EventHandler(this.searchInDeptRadioButton_CheckedChanged);
            // 
            // manageDepartmentTblBtn
            // 
            this.manageDepartmentTblBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageDepartmentTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageDepartmentTblBtn.Location = new System.Drawing.Point(451, 135);
            this.manageDepartmentTblBtn.Name = "manageDepartmentTblBtn";
            this.manageDepartmentTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageDepartmentTblBtn.TabIndex = 36;
            this.manageDepartmentTblBtn.UseVisualStyleBackColor = true;
            this.manageDepartmentTblBtn.Visible = false;
            this.manageDepartmentTblBtn.Click += new System.EventHandler(this.manageDepartmentTblBtn_Click);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssetMovementTblTableAdapter = null;
            this.tableAdapterManager.AssetTblTableAdapter = null;
            this.tableAdapterManager.AssetTransactionTblTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CurrencyTblTableAdapter = this.currencyTblTableAdapter;
            this.tableAdapterManager.DepartmentTblTableAdapter = this.departmentTblTableAdapter;
            this.tableAdapterManager.EstateAreaUnitTblTableAdapter = null;
            this.tableAdapterManager.FinancialItemCategoryTblTableAdapter = this.financialItemCategoryTblTableAdapter;
            this.tableAdapterManager.FinancialItemTblTableAdapter = this.financialItemTblTableAdapter;
            this.tableAdapterManager.ImportExportTblTableAdapter = null;
            this.tableAdapterManager.IncomingTypeTblTableAdapter = null;
            this.tableAdapterManager.MainCategoryTblTableAdapter = null;
            this.tableAdapterManager.MinorCategoryTblTableAdapter = null;
            this.tableAdapterManager.ModelTblTableAdapter = null;
            this.tableAdapterManager.NumberingTblTableAdapter = null;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.OutgoingTypeTblTableAdapter = null;
            this.tableAdapterManager.SectionTblTableAdapter = this.sectionTblTableAdapter;
            this.tableAdapterManager.SquareTblTableAdapter = null;
            this.tableAdapterManager.StatusTblTableAdapter = null;
            this.tableAdapterManager.SubDepartmentTblTableAdapter = this.subDepartmentTblTableAdapter;
            this.tableAdapterManager.TransactionTypeTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserLoginTblTableAdapter = null;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // sectionTblTableAdapter
            // 
            this.sectionTblTableAdapter.ClearBeforeFill = true;
            // 
            // subDepartmentTblTableAdapter
            // 
            this.subDepartmentTblTableAdapter.ClearBeforeFill = true;
            // 
            // searchBySectionRadioButton
            // 
            this.searchBySectionRadioButton.AutoSize = true;
            this.searchBySectionRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBySectionRadioButton.Location = new System.Drawing.Point(37, 90);
            this.searchBySectionRadioButton.Name = "searchBySectionRadioButton";
            this.searchBySectionRadioButton.Size = new System.Drawing.Size(128, 25);
            this.searchBySectionRadioButton.TabIndex = 20;
            this.searchBySectionRadioButton.Text = "ضمن دائرة معينة";
            this.searchBySectionRadioButton.UseVisualStyleBackColor = true;
            this.searchBySectionRadioButton.CheckedChanged += new System.EventHandler(this.searchInDeptRadioButton_CheckedChanged);
            // 
            // searchBySubDepartmentRadioButton
            // 
            this.searchBySubDepartmentRadioButton.AutoSize = true;
            this.searchBySubDepartmentRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBySubDepartmentRadioButton.Location = new System.Drawing.Point(37, 210);
            this.searchBySubDepartmentRadioButton.Name = "searchBySubDepartmentRadioButton";
            this.searchBySubDepartmentRadioButton.Size = new System.Drawing.Size(132, 25);
            this.searchBySubDepartmentRadioButton.TabIndex = 40;
            this.searchBySubDepartmentRadioButton.Text = "ضمن وحدة معينة";
            this.searchBySubDepartmentRadioButton.UseVisualStyleBackColor = true;
            this.searchBySubDepartmentRadioButton.CheckedChanged += new System.EventHandler(this.searchInDeptRadioButton_CheckedChanged);
            // 
            // manageSectionTblBtn
            // 
            this.manageSectionTblBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageSectionTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageSectionTblBtn.Location = new System.Drawing.Point(451, 75);
            this.manageSectionTblBtn.Name = "manageSectionTblBtn";
            this.manageSectionTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageSectionTblBtn.TabIndex = 26;
            this.manageSectionTblBtn.UseVisualStyleBackColor = true;
            this.manageSectionTblBtn.Visible = false;
            this.manageSectionTblBtn.Click += new System.EventHandler(this.manageSectionTblBtn_Click);
            // 
            // searchBySectionLookUpEdit
            // 
            this.searchBySectionLookUpEdit.Location = new System.Drawing.Point(191, 88);
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
            this.searchBySectionLookUpEdit.Properties.PopupWidth = 500;
            this.searchBySectionLookUpEdit.Properties.ValueMember = "ID";
            this.searchBySectionLookUpEdit.Size = new System.Drawing.Size(243, 28);
            this.searchBySectionLookUpEdit.TabIndex = 25;
            this.searchBySectionLookUpEdit.Visible = false;
            // 
            // sectionTblBindingSource
            // 
            this.sectionTblBindingSource.DataMember = "SectionTbl";
            this.sectionTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // manageSubDepartmentTblBtn
            // 
            this.manageSubDepartmentTblBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageSubDepartmentTblBtn.Image = global::AssetManagement.Properties.Resources._981382;
            this.manageSubDepartmentTblBtn.Location = new System.Drawing.Point(451, 195);
            this.manageSubDepartmentTblBtn.Name = "manageSubDepartmentTblBtn";
            this.manageSubDepartmentTblBtn.Size = new System.Drawing.Size(55, 55);
            this.manageSubDepartmentTblBtn.TabIndex = 46;
            this.manageSubDepartmentTblBtn.UseVisualStyleBackColor = true;
            this.manageSubDepartmentTblBtn.Visible = false;
            this.manageSubDepartmentTblBtn.Click += new System.EventHandler(this.manageSubDepartmentTblBtn_Click);
            // 
            // subDepartmentTblBindingSource
            // 
            this.subDepartmentTblBindingSource.DataMember = "SubDepartmentTbl";
            this.subDepartmentTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // searchAssetsBtn
            // 
            this.searchAssetsBtn.Image = global::AssetManagement.Properties.Resources._2719309;
            this.searchAssetsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchAssetsBtn.Location = new System.Drawing.Point(37, 266);
            this.searchAssetsBtn.Name = "searchAssetsBtn";
            this.searchAssetsBtn.Size = new System.Drawing.Size(166, 73);
            this.searchAssetsBtn.TabIndex = 200;
            this.searchAssetsBtn.Text = "بحث";
            this.searchAssetsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchAssetsBtn.UseVisualStyleBackColor = true;
            this.searchAssetsBtn.Click += new System.EventHandler(this.searchAssetsBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Image = global::AssetManagement.Properties.Resources._2137707;
            this.closeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeBtn.Location = new System.Drawing.Point(294, 266);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(166, 73);
            this.closeBtn.TabIndex = 205;
            this.closeBtn.Text = "إغلاق";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // searchBySubDepartmentSearchLookUpEdit
            // 
            this.searchBySubDepartmentSearchLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBySubDepartmentSearchLookUpEdit.Location = new System.Drawing.Point(191, 208);
            this.searchBySubDepartmentSearchLookUpEdit.Name = "searchBySubDepartmentSearchLookUpEdit";
            this.searchBySubDepartmentSearchLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBySubDepartmentSearchLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.searchBySubDepartmentSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchBySubDepartmentSearchLookUpEdit.Properties.DataSource = this.subDepartmentVwBindingSource;
            this.searchBySubDepartmentSearchLookUpEdit.Properties.DisplayMember = "اسم الوحدة";
            this.searchBySubDepartmentSearchLookUpEdit.Properties.ValueMember = "معرف الوحدة";
            this.searchBySubDepartmentSearchLookUpEdit.Size = new System.Drawing.Size(243, 28);
            this.searchBySubDepartmentSearchLookUpEdit.TabIndex = 45;
            this.searchBySubDepartmentSearchLookUpEdit.Visible = false;
            // 
            // subDepartmentVwBindingSource
            // 
            this.subDepartmentVwBindingSource.DataMember = "SubDepartmentVw";
            this.subDepartmentVwBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // searchByDepartmentSearchLookUpEdit
            // 
            this.searchByDepartmentSearchLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByDepartmentSearchLookUpEdit.Location = new System.Drawing.Point(191, 148);
            this.searchByDepartmentSearchLookUpEdit.Name = "searchByDepartmentSearchLookUpEdit";
            this.searchByDepartmentSearchLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByDepartmentSearchLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.searchByDepartmentSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchByDepartmentSearchLookUpEdit.Properties.DataSource = this.departmentVwBindingSource;
            this.searchByDepartmentSearchLookUpEdit.Properties.DisplayMember = "اسم القسم";
            this.searchByDepartmentSearchLookUpEdit.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchByDepartmentSearchLookUpEdit.Properties.ValueMember = "معرف القسم";
            this.searchByDepartmentSearchLookUpEdit.Size = new System.Drawing.Size(243, 28);
            this.searchByDepartmentSearchLookUpEdit.TabIndex = 35;
            this.searchByDepartmentSearchLookUpEdit.Visible = false;
            // 
            // departmentVwBindingSource
            // 
            this.departmentVwBindingSource.DataMember = "DepartmentVw";
            this.departmentVwBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colمعرفالقسم,
            this.colاسمالقسم,
            this.colالدائرةالتييتبعلهاالقسم});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colمعرفالقسم
            // 
            this.colمعرفالقسم.FieldName = "معرف القسم";
            this.colمعرفالقسم.MinWidth = 100;
            this.colمعرفالقسم.Name = "colمعرفالقسم";
            this.colمعرفالقسم.Width = 100;
            // 
            // colاسمالقسم
            // 
            this.colاسمالقسم.FieldName = "اسم القسم";
            this.colاسمالقسم.MinWidth = 150;
            this.colاسمالقسم.Name = "colاسمالقسم";
            this.colاسمالقسم.Visible = true;
            this.colاسمالقسم.VisibleIndex = 0;
            this.colاسمالقسم.Width = 150;
            // 
            // colالدائرةالتييتبعلهاالقسم
            // 
            this.colالدائرةالتييتبعلهاالقسم.FieldName = "الدائرة التي يتبع لها القسم";
            this.colالدائرةالتييتبعلهاالقسم.MinWidth = 150;
            this.colالدائرةالتييتبعلهاالقسم.Name = "colالدائرةالتييتبعلهاالقسم";
            this.colالدائرةالتييتبعلهاالقسم.Visible = true;
            this.colالدائرةالتييتبعلهاالقسم.VisibleIndex = 1;
            this.colالدائرةالتييتبعلهاالقسم.Width = 150;
            // 
            // departmentVwTableAdapter
            // 
            this.departmentVwTableAdapter.ClearBeforeFill = true;
            // 
            // subDepartmentVwTableAdapter
            // 
            this.subDepartmentVwTableAdapter.ClearBeforeFill = true;
            // 
            // CustomAssetsForm
            // 
            this.AcceptButton = this.searchAssetsBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(574, 364);
            this.Controls.Add(this.searchBySubDepartmentSearchLookUpEdit);
            this.Controls.Add(this.searchByDepartmentSearchLookUpEdit);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.searchAssetsBtn);
            this.Controls.Add(this.manageSubDepartmentTblBtn);
            this.Controls.Add(this.manageSectionTblBtn);
            this.Controls.Add(this.searchBySectionLookUpEdit);
            this.Controls.Add(this.searchBySubDepartmentRadioButton);
            this.Controls.Add(this.searchBySectionRadioButton);
            this.Controls.Add(this.manageDepartmentTblBtn);
            this.Controls.Add(this.searchAllRadioButton);
            this.Controls.Add(this.searchByDepartmentRadioButton);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CustomAssetsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بحث مخصص عن أصول";
            this.Load += new System.EventHandler(this.CustomAssetsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.financialItemTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBySectionLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBySubDepartmentSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchByDepartmentSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private AssetMngDbDataSet assetMngDbDataSet;
        private System.Windows.Forms.BindingSource financialItemTblBindingSource;
        private AssetMngDbDataSetTableAdapters.FinancialItemTblTableAdapter financialItemTblTableAdapter;
        private System.Windows.Forms.BindingSource financialItemCategoryTblBindingSource;
        private AssetMngDbDataSetTableAdapters.FinancialItemCategoryTblTableAdapter financialItemCategoryTblTableAdapter;
        private System.Windows.Forms.BindingSource currencyTblBindingSource;
        private AssetMngDbDataSetTableAdapters.CurrencyTblTableAdapter currencyTblTableAdapter;
        private System.Windows.Forms.RadioButton searchByDepartmentRadioButton;
        private System.Windows.Forms.RadioButton searchAllRadioButton;
        private System.Windows.Forms.Button manageDepartmentTblBtn;
        private System.Windows.Forms.BindingSource departmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter departmentTblTableAdapter;
        private System.Windows.Forms.BindingSource departmentTblBindingSource1;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.RadioButton searchBySectionRadioButton;
        private System.Windows.Forms.RadioButton searchBySubDepartmentRadioButton;
        private System.Windows.Forms.Button manageSectionTblBtn;
        private DevExpress.XtraEditors.LookUpEdit searchBySectionLookUpEdit;
        private System.Windows.Forms.Button manageSubDepartmentTblBtn;
        private System.Windows.Forms.BindingSource sectionTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SectionTblTableAdapter sectionTblTableAdapter;
        private System.Windows.Forms.BindingSource subDepartmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SubDepartmentTblTableAdapter subDepartmentTblTableAdapter;
        private System.Windows.Forms.BindingSource subDepartmentTblBindingSource1;
        private System.Windows.Forms.Button searchAssetsBtn;
        private System.Windows.Forms.Button closeBtn;
        private DevExpress.XtraEditors.SearchLookUpEdit searchBySubDepartmentSearchLookUpEdit;
        private DevExpress.XtraEditors.SearchLookUpEdit searchByDepartmentSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colمعرفالقسم;
        private DevExpress.XtraGrid.Columns.GridColumn colاسمالقسم;
        private DevExpress.XtraGrid.Columns.GridColumn colالدائرةالتييتبعلهاالقسم;
        private System.Windows.Forms.BindingSource departmentVwBindingSource;
        private AssetMngDbDataSetTableAdapters.DepartmentVwTableAdapter departmentVwTableAdapter;
        private System.Windows.Forms.BindingSource subDepartmentVwBindingSource;
        private AssetMngDbDataSetTableAdapters.SubDepartmentVwTableAdapter subDepartmentVwTableAdapter;
    }
}