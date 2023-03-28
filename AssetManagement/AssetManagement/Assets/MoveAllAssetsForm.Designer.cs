
namespace AssetManagement.Assets
{
    partial class MoveAllAssetsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveAllAssetsForm));
            this.toPlaceOfPresenceCheckBox = new System.Windows.Forms.CheckBox();
            this.toPlaceOfPresenceTextBox = new System.Windows.Forms.TextBox();
            this.toSubDepartmentLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.subDepartmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.assetMovementTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toCustodianNameCheckBox = new System.Windows.Forms.CheckBox();
            this.toSquareCheckBox = new System.Windows.Forms.CheckBox();
            this.toSectionDepartmentSubDepartmentCheckBox = new System.Windows.Forms.CheckBox();
            this.assetMovementDateLabel = new System.Windows.Forms.Label();
            this.assetMovementDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.assetsAllMoveBtn = new System.Windows.Forms.Button();
            this.toSquareLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.squareTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toSectionLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.sectionTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toDepartmentLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.departmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.departmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter();
            this.squareTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SquareTblTableAdapter();
            this.sectionTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SectionTblTableAdapter();
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.subDepartmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SubDepartmentTblTableAdapter();
            this.assetMoveVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMoveVwTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetMoveVwTableAdapter();
            this.assetMovementTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetMovementTblTableAdapter();
            this.assetVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMoveVwBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.assetTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetTblTableAdapter();
            this.assetTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.assetVwTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetVwTableAdapter();
            this.toCustodianNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.toSubDepartmentLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toSquareLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toSectionLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDepartmentLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMoveVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMoveVwBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTblBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // toPlaceOfPresenceCheckBox
            // 
            this.toPlaceOfPresenceCheckBox.AutoSize = true;
            this.toPlaceOfPresenceCheckBox.Location = new System.Drawing.Point(50, 270);
            this.toPlaceOfPresenceCheckBox.Name = "toPlaceOfPresenceCheckBox";
            this.toPlaceOfPresenceCheckBox.Size = new System.Drawing.Size(125, 25);
            this.toPlaceOfPresenceCheckBox.TabIndex = 40;
            this.toPlaceOfPresenceCheckBox.Text = "إلى مكان التواجد:";
            this.toPlaceOfPresenceCheckBox.UseVisualStyleBackColor = true;
            this.toPlaceOfPresenceCheckBox.CheckedChanged += new System.EventHandler(this.toPlaceOfPresenceCheckBox_CheckedChanged);
            // 
            // toPlaceOfPresenceTextBox
            // 
            this.toPlaceOfPresenceTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toPlaceOfPresenceTextBox.Location = new System.Drawing.Point(286, 268);
            this.toPlaceOfPresenceTextBox.Name = "toPlaceOfPresenceTextBox";
            this.toPlaceOfPresenceTextBox.Size = new System.Drawing.Size(308, 28);
            this.toPlaceOfPresenceTextBox.TabIndex = 45;
            this.toPlaceOfPresenceTextBox.Visible = false;
            // 
            // toSubDepartmentLookUpEdit
            // 
            this.toSubDepartmentLookUpEdit.Location = new System.Drawing.Point(286, 118);
            this.toSubDepartmentLookUpEdit.Name = "toSubDepartmentLookUpEdit";
            this.toSubDepartmentLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toSubDepartmentLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.toSubDepartmentLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toSubDepartmentLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الوحدة", 72, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubDepartmentName", "اسم الوحدة", 135, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainDepartment", "معرف القسم", 72, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.toSubDepartmentLookUpEdit.Properties.DataSource = this.subDepartmentTblBindingSource;
            this.toSubDepartmentLookUpEdit.Properties.DisplayMember = "SubDepartmentName";
            this.toSubDepartmentLookUpEdit.Properties.PopupWidth = 450;
            this.toSubDepartmentLookUpEdit.Properties.ValueMember = "ID";
            this.toSubDepartmentLookUpEdit.Size = new System.Drawing.Size(308, 28);
            this.toSubDepartmentLookUpEdit.TabIndex = 15;
            this.toSubDepartmentLookUpEdit.Visible = false;
            // 
            // subDepartmentTblBindingSource
            // 
            this.subDepartmentTblBindingSource.DataMember = "SubDepartmentTbl";
            this.subDepartmentTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetMovementTblBindingSource
            // 
            this.assetMovementTblBindingSource.DataMember = "AssetMovementTbl";
            this.assetMovementTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // toCustodianNameCheckBox
            // 
            this.toCustodianNameCheckBox.AutoSize = true;
            this.toCustodianNameCheckBox.Location = new System.Drawing.Point(50, 220);
            this.toCustodianNameCheckBox.Name = "toCustodianNameCheckBox";
            this.toCustodianNameCheckBox.Size = new System.Drawing.Size(91, 25);
            this.toCustodianNameCheckBox.TabIndex = 30;
            this.toCustodianNameCheckBox.Text = "إلى العهدة:";
            this.toCustodianNameCheckBox.UseVisualStyleBackColor = true;
            this.toCustodianNameCheckBox.CheckedChanged += new System.EventHandler(this.toCustodianNameCheckBox_CheckedChanged);
            // 
            // toSquareCheckBox
            // 
            this.toSquareCheckBox.AutoSize = true;
            this.toSquareCheckBox.Location = new System.Drawing.Point(50, 170);
            this.toSquareCheckBox.Name = "toSquareCheckBox";
            this.toSquareCheckBox.Size = new System.Drawing.Size(94, 25);
            this.toSquareCheckBox.TabIndex = 20;
            this.toSquareCheckBox.Text = "إلى الساحة:";
            this.toSquareCheckBox.UseVisualStyleBackColor = true;
            this.toSquareCheckBox.CheckedChanged += new System.EventHandler(this.toSquareCheckBox_CheckedChanged);
            // 
            // toSectionDepartmentSubDepartmentCheckBox
            // 
            this.toSectionDepartmentSubDepartmentCheckBox.AutoSize = true;
            this.toSectionDepartmentSubDepartmentCheckBox.Location = new System.Drawing.Point(50, 20);
            this.toSectionDepartmentSubDepartmentCheckBox.Name = "toSectionDepartmentSubDepartmentCheckBox";
            this.toSectionDepartmentSubDepartmentCheckBox.Size = new System.Drawing.Size(176, 25);
            this.toSectionDepartmentSubDepartmentCheckBox.TabIndex = 0;
            this.toSectionDepartmentSubDepartmentCheckBox.Text = "إلى الدائرة والقسم والوحدة";
            this.toSectionDepartmentSubDepartmentCheckBox.UseVisualStyleBackColor = true;
            this.toSectionDepartmentSubDepartmentCheckBox.CheckedChanged += new System.EventHandler(this.toDepartmentCheckBox_CheckedChanged);
            // 
            // assetMovementDateLabel
            // 
            this.assetMovementDateLabel.AutoSize = true;
            this.assetMovementDateLabel.Location = new System.Drawing.Point(50, 320);
            this.assetMovementDateLabel.Name = "assetMovementDateLabel";
            this.assetMovementDateLabel.Size = new System.Drawing.Size(79, 21);
            this.assetMovementDateLabel.TabIndex = 50;
            this.assetMovementDateLabel.Text = "تاريخ النقل:";
            // 
            // assetMovementDateDateEdit
            // 
            this.assetMovementDateDateEdit.EditValue = null;
            this.assetMovementDateDateEdit.Location = new System.Drawing.Point(286, 316);
            this.assetMovementDateDateEdit.Name = "assetMovementDateDateEdit";
            this.assetMovementDateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetMovementDateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.assetMovementDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.assetMovementDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.assetMovementDateDateEdit.Size = new System.Drawing.Size(306, 28);
            this.assetMovementDateDateEdit.TabIndex = 55;
            // 
            // assetsAllMoveBtn
            // 
            this.assetsAllMoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.assetsAllMoveBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetsAllMoveBtn.Image = global::AssetManagement.Properties.Resources._1592276;
            this.assetsAllMoveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.assetsAllMoveBtn.Location = new System.Drawing.Point(640, 299);
            this.assetsAllMoveBtn.Name = "assetsAllMoveBtn";
            this.assetsAllMoveBtn.Size = new System.Drawing.Size(188, 99);
            this.assetsAllMoveBtn.TabIndex = 200;
            this.assetsAllMoveBtn.Text = "نقل الكل";
            this.assetsAllMoveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.assetsAllMoveBtn.UseVisualStyleBackColor = false;
            this.assetsAllMoveBtn.Click += new System.EventHandler(this.assetsMoveAllBtn_Click);
            // 
            // toSquareLookUpEdit
            // 
            this.toSquareLookUpEdit.Location = new System.Drawing.Point(286, 168);
            this.toSquareLookUpEdit.Name = "toSquareLookUpEdit";
            this.toSquareLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toSquareLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.toSquareLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toSquareLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الساحة", 63, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SquareName", "اسم الساحة", 135, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SquareLocation", "موقع الساحة", 135, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.toSquareLookUpEdit.Properties.DataSource = this.squareTblBindingSource;
            this.toSquareLookUpEdit.Properties.DisplayMember = "SquareName";
            this.toSquareLookUpEdit.Properties.PopupWidth = 450;
            this.toSquareLookUpEdit.Properties.ValueMember = "ID";
            this.toSquareLookUpEdit.Size = new System.Drawing.Size(308, 28);
            this.toSquareLookUpEdit.TabIndex = 25;
            this.toSquareLookUpEdit.Visible = false;
            // 
            // squareTblBindingSource
            // 
            this.squareTblBindingSource.DataMember = "SquareTbl";
            this.squareTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // toSectionLookUpEdit
            // 
            this.toSectionLookUpEdit.Location = new System.Drawing.Point(286, 18);
            this.toSectionLookUpEdit.Name = "toSectionLookUpEdit";
            this.toSectionLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toSectionLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.toSectionLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toSectionLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الدائرة", 72, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SectionName", "اسم الدائرة", 135, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.toSectionLookUpEdit.Properties.DataSource = this.sectionTblBindingSource;
            this.toSectionLookUpEdit.Properties.DisplayMember = "SectionName";
            this.toSectionLookUpEdit.Properties.PopupWidth = 450;
            this.toSectionLookUpEdit.Properties.ValueMember = "ID";
            this.toSectionLookUpEdit.Size = new System.Drawing.Size(308, 28);
            this.toSectionLookUpEdit.TabIndex = 5;
            this.toSectionLookUpEdit.Visible = false;
            this.toSectionLookUpEdit.EditValueChanged += new System.EventHandler(this.toSectionLookUpEdit_EditValueChanged);
            // 
            // sectionTblBindingSource
            // 
            this.sectionTblBindingSource.DataMember = "SectionTbl";
            this.sectionTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // toDepartmentLookUpEdit
            // 
            this.toDepartmentLookUpEdit.Location = new System.Drawing.Point(286, 68);
            this.toDepartmentLookUpEdit.Name = "toDepartmentLookUpEdit";
            this.toDepartmentLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDepartmentLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.toDepartmentLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDepartmentLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف القسم", 72, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "اسم القسم", 135, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SectionOfDepartment", "معرف الدائرة", 72, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.toDepartmentLookUpEdit.Properties.DataSource = this.departmentTblBindingSource;
            this.toDepartmentLookUpEdit.Properties.DisplayMember = "DepartmentName";
            this.toDepartmentLookUpEdit.Properties.PopupWidth = 450;
            this.toDepartmentLookUpEdit.Properties.ValueMember = "ID";
            this.toDepartmentLookUpEdit.Size = new System.Drawing.Size(308, 28);
            this.toDepartmentLookUpEdit.TabIndex = 10;
            this.toDepartmentLookUpEdit.Visible = false;
            this.toDepartmentLookUpEdit.EditValueChanged += new System.EventHandler(this.toDepartmentLookUpEdit_EditValueChanged);
            // 
            // departmentTblBindingSource
            // 
            this.departmentTblBindingSource.DataMember = "DepartmentTbl";
            this.departmentTblBindingSource.DataSource = this.assetMngDbDataSet;
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
            // departmentTblTableAdapter
            // 
            this.departmentTblTableAdapter.ClearBeforeFill = true;
            // 
            // squareTblTableAdapter
            // 
            this.squareTblTableAdapter.ClearBeforeFill = true;
            // 
            // sectionTblTableAdapter
            // 
            this.sectionTblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssetMovementTblTableAdapter = null;
            this.tableAdapterManager.AssetTblTableAdapter = null;
            this.tableAdapterManager.AssetTransactionTblTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CurrencyTblTableAdapter = null;
            this.tableAdapterManager.DepartmentTblTableAdapter = this.departmentTblTableAdapter;
            this.tableAdapterManager.EstateAreaUnitTblTableAdapter = null;
            this.tableAdapterManager.FinancialItemCategoryTblTableAdapter = null;
            this.tableAdapterManager.FinancialItemTblTableAdapter = null;
            this.tableAdapterManager.ImportExportTblTableAdapter = null;
            this.tableAdapterManager.IncomingTypeTblTableAdapter = null;
            this.tableAdapterManager.MainCategoryTblTableAdapter = null;
            this.tableAdapterManager.MinorCategoryTblTableAdapter = null;
            this.tableAdapterManager.ModelTblTableAdapter = null;
            this.tableAdapterManager.NumberingTblTableAdapter = null;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.OutgoingTypeTblTableAdapter = null;
            this.tableAdapterManager.SectionTblTableAdapter = this.sectionTblTableAdapter;
            this.tableAdapterManager.SquareTblTableAdapter = this.squareTblTableAdapter;
            this.tableAdapterManager.StatusTblTableAdapter = null;
            this.tableAdapterManager.SubDepartmentTblTableAdapter = this.subDepartmentTblTableAdapter;
            this.tableAdapterManager.TransactionTypeTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserLoginTblTableAdapter = null;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // subDepartmentTblTableAdapter
            // 
            this.subDepartmentTblTableAdapter.ClearBeforeFill = true;
            // 
            // assetMoveVwBindingSource
            // 
            this.assetMoveVwBindingSource.DataMember = "AssetMoveVw";
            this.assetMoveVwBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMoveVwTableAdapter
            // 
            this.assetMoveVwTableAdapter.ClearBeforeFill = true;
            // 
            // assetMovementTblTableAdapter
            // 
            this.assetMovementTblTableAdapter.ClearBeforeFill = true;
            // 
            // assetVwBindingSource
            // 
            this.assetVwBindingSource.DataMember = "AssetVw";
            this.assetVwBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMoveVwBindingSource1
            // 
            this.assetMoveVwBindingSource1.DataMember = "AssetMoveVw";
            this.assetMoveVwBindingSource1.DataSource = this.assetMngDbDataSet;
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
            // assetTblBindingSource1
            // 
            this.assetTblBindingSource1.DataMember = "AssetTbl";
            this.assetTblBindingSource1.DataSource = this.assetMngDbDataSet;
            // 
            // assetVwTableAdapter
            // 
            this.assetVwTableAdapter.ClearBeforeFill = true;
            // 
            // toCustodianNameTextBox
            // 
            this.toCustodianNameTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toCustodianNameTextBox.Location = new System.Drawing.Point(286, 218);
            this.toCustodianNameTextBox.Name = "toCustodianNameTextBox";
            this.toCustodianNameTextBox.Size = new System.Drawing.Size(308, 28);
            this.toCustodianNameTextBox.TabIndex = 201;
            this.toCustodianNameTextBox.Visible = false;
            // 
            // MoveAllAssetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 422);
            this.Controls.Add(this.toCustodianNameTextBox);
            this.Controls.Add(this.assetsAllMoveBtn);
            this.Controls.Add(this.assetMovementDateLabel);
            this.Controls.Add(this.toPlaceOfPresenceTextBox);
            this.Controls.Add(this.assetMovementDateDateEdit);
            this.Controls.Add(this.toPlaceOfPresenceCheckBox);
            this.Controls.Add(this.toSubDepartmentLookUpEdit);
            this.Controls.Add(this.toSectionDepartmentSubDepartmentCheckBox);
            this.Controls.Add(this.toSquareCheckBox);
            this.Controls.Add(this.toCustodianNameCheckBox);
            this.Controls.Add(this.toSectionLookUpEdit);
            this.Controls.Add(this.toSquareLookUpEdit);
            this.Controls.Add(this.toDepartmentLookUpEdit);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "MoveAllAssetsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نقل مجموعة من الأصول";
            this.Load += new System.EventHandler(this.MoveAllAssetsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toSubDepartmentLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDepartmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toSquareLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toSectionLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDepartmentLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMoveVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMoveVwBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTblBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LookUpEdit toSquareLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit toSectionLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit toDepartmentLookUpEdit;
        private System.Windows.Forms.Label assetMovementDateLabel;
        private DevExpress.XtraEditors.DateEdit assetMovementDateDateEdit;
        private System.Windows.Forms.Button assetsAllMoveBtn;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private AssetMngDbDataSet assetMngDbDataSet;
        private System.Windows.Forms.BindingSource departmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter departmentTblTableAdapter;
        private System.Windows.Forms.BindingSource squareTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SquareTblTableAdapter squareTblTableAdapter;
        private System.Windows.Forms.BindingSource sectionTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SectionTblTableAdapter sectionTblTableAdapter;
        private AssetMngDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox toCustodianNameCheckBox;
        private System.Windows.Forms.CheckBox toSquareCheckBox;
        private System.Windows.Forms.CheckBox toSectionDepartmentSubDepartmentCheckBox;
        private System.Windows.Forms.BindingSource assetMoveVwBindingSource;
        private AssetMngDbDataSetTableAdapters.AssetMoveVwTableAdapter assetMoveVwTableAdapter;
        private System.Windows.Forms.BindingSource assetMovementTblBindingSource;
        private AssetMngDbDataSetTableAdapters.AssetMovementTblTableAdapter assetMovementTblTableAdapter;
        private System.Windows.Forms.BindingSource assetTblBindingSource;
        private AssetMngDbDataSetTableAdapters.AssetTblTableAdapter assetTblTableAdapter;
        private System.Windows.Forms.BindingSource assetMoveVwBindingSource1;
        private System.Windows.Forms.BindingSource assetTblBindingSource1;
        private DevExpress.XtraEditors.LookUpEdit toSubDepartmentLookUpEdit;
        private System.Windows.Forms.BindingSource subDepartmentTblBindingSource;
        private AssetMngDbDataSetTableAdapters.SubDepartmentTblTableAdapter subDepartmentTblTableAdapter;
        private System.Windows.Forms.BindingSource assetVwBindingSource;
        private AssetMngDbDataSetTableAdapters.AssetVwTableAdapter assetVwTableAdapter;
        private System.Windows.Forms.CheckBox toPlaceOfPresenceCheckBox;
        private System.Windows.Forms.TextBox toPlaceOfPresenceTextBox;
        private System.Windows.Forms.TextBox toCustodianNameTextBox;
    }
}