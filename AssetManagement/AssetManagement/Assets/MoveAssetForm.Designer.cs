
namespace AssetManagement.Assets
{
    partial class MoveAssetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveAssetForm));
            this.assetCodeTextBox = new System.Windows.Forms.TextBox();
            this.assetCodeLabel = new System.Windows.Forms.Label();
            this.moveAssetGroupBox = new System.Windows.Forms.GroupBox();
            this.assetMovementTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.assetMovementTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.assetMoveVwGridControl = new DevExpress.XtraGrid.GridControl();
            this.assetMovementTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.assetMoveVwGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFieldChanged = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOldValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMovementDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetMovedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetMovedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.assetInfoLabel = new System.Windows.Forms.Label();
            this.toCustodianNameCheckBox = new System.Windows.Forms.CheckBox();
            this.toSquareCheckBox = new System.Windows.Forms.CheckBox();
            this.toSectionCheckBox = new System.Windows.Forms.CheckBox();
            this.toDepartmentCheckBox = new System.Windows.Forms.CheckBox();
            this.assetMovementDateLabel = new System.Windows.Forms.Label();
            this.assetMovementDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.assetMoveBtn = new System.Windows.Forms.Button();
            this.fromSquareTextBox = new System.Windows.Forms.TextBox();
            this.fromSectionTextBox = new System.Windows.Forms.TextBox();
            this.fromDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.toCustodianNameTextBox = new System.Windows.Forms.TextBox();
            this.fromCustodianNameTextBox = new System.Windows.Forms.TextBox();
            this.fromCustodianNameLabel = new System.Windows.Forms.Label();
            this.toSquareLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.squareTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toSectionLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.sectionTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toDepartmentLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.departmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fromSquareLabel = new System.Windows.Forms.Label();
            this.fromSectionLabel = new System.Windows.Forms.Label();
            this.fromDepartmentLabel = new System.Windows.Forms.Label();
            this.searchAssetBtn = new System.Windows.Forms.Button();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.departmentTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.DepartmentTblTableAdapter();
            this.squareTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SquareTblTableAdapter();
            this.sectionTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.SectionTblTableAdapter();
            this.tableAdapterManager = new AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager();
            this.assetMoveVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMoveVwTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetMoveVwTableAdapter();
            this.assetMovementTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.AssetMovementTblTableAdapter();
            this.moveAssetGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementTblBindingNavigator)).BeginInit();
            this.assetMovementTblBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetMoveVwGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMoveVwGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toSquareLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toSectionLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDepartmentLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMoveVwBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // assetCodeTextBox
            // 
            this.assetCodeTextBox.Location = new System.Drawing.Point(200, 54);
            this.assetCodeTextBox.Name = "assetCodeTextBox";
            this.assetCodeTextBox.Size = new System.Drawing.Size(288, 32);
            this.assetCodeTextBox.TabIndex = 5;
            // 
            // assetCodeLabel
            // 
            this.assetCodeLabel.AutoSize = true;
            this.assetCodeLabel.Location = new System.Drawing.Point(72, 58);
            this.assetCodeLabel.Name = "assetCodeLabel";
            this.assetCodeLabel.Size = new System.Drawing.Size(86, 24);
            this.assetCodeLabel.TabIndex = 0;
            this.assetCodeLabel.Text = "كود الأصل:";
            // 
            // moveAssetGroupBox
            // 
            this.moveAssetGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.moveAssetGroupBox.Controls.Add(this.assetMovementTblBindingNavigator);
            this.moveAssetGroupBox.Controls.Add(this.assetMoveVwGridControl);
            this.moveAssetGroupBox.Controls.Add(this.assetInfoLabel);
            this.moveAssetGroupBox.Controls.Add(this.toCustodianNameCheckBox);
            this.moveAssetGroupBox.Controls.Add(this.toSquareCheckBox);
            this.moveAssetGroupBox.Controls.Add(this.toSectionCheckBox);
            this.moveAssetGroupBox.Controls.Add(this.toDepartmentCheckBox);
            this.moveAssetGroupBox.Controls.Add(this.assetMovementDateLabel);
            this.moveAssetGroupBox.Controls.Add(this.assetMovementDateDateEdit);
            this.moveAssetGroupBox.Controls.Add(this.assetMoveBtn);
            this.moveAssetGroupBox.Controls.Add(this.fromSquareTextBox);
            this.moveAssetGroupBox.Controls.Add(this.fromSectionTextBox);
            this.moveAssetGroupBox.Controls.Add(this.fromDepartmentTextBox);
            this.moveAssetGroupBox.Controls.Add(this.toCustodianNameTextBox);
            this.moveAssetGroupBox.Controls.Add(this.fromCustodianNameTextBox);
            this.moveAssetGroupBox.Controls.Add(this.fromCustodianNameLabel);
            this.moveAssetGroupBox.Controls.Add(this.toSquareLookUpEdit);
            this.moveAssetGroupBox.Controls.Add(this.toSectionLookUpEdit);
            this.moveAssetGroupBox.Controls.Add(this.toDepartmentLookUpEdit);
            this.moveAssetGroupBox.Controls.Add(this.fromSquareLabel);
            this.moveAssetGroupBox.Controls.Add(this.fromSectionLabel);
            this.moveAssetGroupBox.Controls.Add(this.fromDepartmentLabel);
            this.moveAssetGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.moveAssetGroupBox.Location = new System.Drawing.Point(0, 141);
            this.moveAssetGroupBox.Name = "moveAssetGroupBox";
            this.moveAssetGroupBox.Size = new System.Drawing.Size(1311, 617);
            this.moveAssetGroupBox.TabIndex = 100;
            this.moveAssetGroupBox.TabStop = false;
            this.moveAssetGroupBox.Text = "معلومات الأصل الحالية والجديدة";
            this.moveAssetGroupBox.Visible = false;
            // 
            // assetMovementTblBindingNavigator
            // 
            this.assetMovementTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.assetMovementTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.assetMovementTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.assetMovementTblBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.assetMovementTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.assetMovementTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.assetMovementTblBindingNavigatorSaveItem});
            this.assetMovementTblBindingNavigator.Location = new System.Drawing.Point(3, 359);
            this.assetMovementTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.assetMovementTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.assetMovementTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.assetMovementTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.assetMovementTblBindingNavigator.Name = "assetMovementTblBindingNavigator";
            this.assetMovementTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.assetMovementTblBindingNavigator.Size = new System.Drawing.Size(1305, 27);
            this.assetMovementTblBindingNavigator.TabIndex = 303;
            this.assetMovementTblBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // assetMovementTblBindingNavigatorSaveItem
            // 
            this.assetMovementTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.assetMovementTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("assetMovementTblBindingNavigatorSaveItem.Image")));
            this.assetMovementTblBindingNavigatorSaveItem.Name = "assetMovementTblBindingNavigatorSaveItem";
            this.assetMovementTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.assetMovementTblBindingNavigatorSaveItem.Text = "Save Data";
            this.assetMovementTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.assetMovementTblBindingNavigatorSaveItem_Click);
            // 
            // assetMoveVwGridControl
            // 
            this.assetMoveVwGridControl.DataSource = this.assetMovementTblBindingSource;
            this.assetMoveVwGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.assetMoveVwGridControl.Location = new System.Drawing.Point(3, 386);
            this.assetMoveVwGridControl.MainView = this.assetMoveVwGridView;
            this.assetMoveVwGridControl.Name = "assetMoveVwGridControl";
            this.assetMoveVwGridControl.Size = new System.Drawing.Size(1305, 228);
            this.assetMoveVwGridControl.TabIndex = 302;
            this.assetMoveVwGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.assetMoveVwGridView});
            // 
            // assetMovementTblBindingSource
            // 
            this.assetMovementTblBindingSource.DataMember = "AssetMovementTbl";
            this.assetMovementTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // assetMngDbDataSet
            // 
            this.assetMngDbDataSet.DataSetName = "AssetMngDbDataSet";
            this.assetMngDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetMoveVwGridView
            // 
            this.assetMoveVwGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colAssetID,
            this.colFieldChanged,
            this.colOldValue,
            this.colNewValue,
            this.colMovementDate,
            this.colAssetMovedOn,
            this.colAssetMovedBy});
            this.assetMoveVwGridView.GridControl = this.assetMoveVwGridControl;
            this.assetMoveVwGridView.Name = "assetMoveVwGridView";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Width = 80;
            // 
            // colAssetID
            // 
            this.colAssetID.FieldName = "AssetID";
            this.colAssetID.MinWidth = 25;
            this.colAssetID.Name = "colAssetID";
            this.colAssetID.Width = 80;
            // 
            // colFieldChanged
            // 
            this.colFieldChanged.Caption = "الحقل الذي تم تغييره";
            this.colFieldChanged.FieldName = "FieldChanged";
            this.colFieldChanged.MinWidth = 25;
            this.colFieldChanged.Name = "colFieldChanged";
            this.colFieldChanged.Visible = true;
            this.colFieldChanged.VisibleIndex = 0;
            this.colFieldChanged.Width = 184;
            // 
            // colOldValue
            // 
            this.colOldValue.Caption = "نقل من";
            this.colOldValue.FieldName = "OldValue";
            this.colOldValue.MinWidth = 25;
            this.colOldValue.Name = "colOldValue";
            this.colOldValue.Visible = true;
            this.colOldValue.VisibleIndex = 1;
            this.colOldValue.Width = 184;
            // 
            // colNewValue
            // 
            this.colNewValue.Caption = "نقل إلى";
            this.colNewValue.FieldName = "NewValue";
            this.colNewValue.MinWidth = 25;
            this.colNewValue.Name = "colNewValue";
            this.colNewValue.Visible = true;
            this.colNewValue.VisibleIndex = 2;
            this.colNewValue.Width = 184;
            // 
            // colMovementDate
            // 
            this.colMovementDate.Caption = "تاريخ النقل";
            this.colMovementDate.FieldName = "MovementDate";
            this.colMovementDate.MinWidth = 25;
            this.colMovementDate.Name = "colMovementDate";
            this.colMovementDate.Visible = true;
            this.colMovementDate.VisibleIndex = 3;
            this.colMovementDate.Width = 184;
            // 
            // colAssetMovedOn
            // 
            this.colAssetMovedOn.Caption = "سجل النقل بتاريخ";
            this.colAssetMovedOn.FieldName = "AssetMovedOn";
            this.colAssetMovedOn.MinWidth = 25;
            this.colAssetMovedOn.Name = "colAssetMovedOn";
            this.colAssetMovedOn.Width = 184;
            // 
            // colAssetMovedBy
            // 
            this.colAssetMovedBy.Caption = "من قام بتسجيل النقل";
            this.colAssetMovedBy.FieldName = "AssetMovedBy";
            this.colAssetMovedBy.MinWidth = 25;
            this.colAssetMovedBy.Name = "colAssetMovedBy";
            this.colAssetMovedBy.Width = 192;
            // 
            // assetInfoLabel
            // 
            this.assetInfoLabel.AutoSize = true;
            this.assetInfoLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.assetInfoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.assetInfoLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetInfoLabel.Location = new System.Drawing.Point(3, 28);
            this.assetInfoLabel.Name = "assetInfoLabel";
            this.assetInfoLabel.Size = new System.Drawing.Size(0, 29);
            this.assetInfoLabel.TabIndex = 301;
            // 
            // toCustodianNameCheckBox
            // 
            this.toCustodianNameCheckBox.AutoSize = true;
            this.toCustodianNameCheckBox.Location = new System.Drawing.Point(612, 234);
            this.toCustodianNameCheckBox.Name = "toCustodianNameCheckBox";
            this.toCustodianNameCheckBox.Size = new System.Drawing.Size(102, 28);
            this.toCustodianNameCheckBox.TabIndex = 175;
            this.toCustodianNameCheckBox.Text = "إلى العهدة:";
            this.toCustodianNameCheckBox.UseVisualStyleBackColor = true;
            this.toCustodianNameCheckBox.CheckedChanged += new System.EventHandler(this.toCustodianNameCheckBox_CheckedChanged);
            // 
            // toSquareCheckBox
            // 
            this.toSquareCheckBox.AutoSize = true;
            this.toSquareCheckBox.Location = new System.Drawing.Point(606, 187);
            this.toSquareCheckBox.Name = "toSquareCheckBox";
            this.toSquareCheckBox.Size = new System.Drawing.Size(108, 28);
            this.toSquareCheckBox.TabIndex = 155;
            this.toSquareCheckBox.Text = "إلى الساحة:";
            this.toSquareCheckBox.UseVisualStyleBackColor = true;
            this.toSquareCheckBox.CheckedChanged += new System.EventHandler(this.toSquareCheckBox_CheckedChanged);
            // 
            // toSectionCheckBox
            // 
            this.toSectionCheckBox.AutoSize = true;
            this.toSectionCheckBox.Location = new System.Drawing.Point(614, 140);
            this.toSectionCheckBox.Name = "toSectionCheckBox";
            this.toSectionCheckBox.Size = new System.Drawing.Size(100, 28);
            this.toSectionCheckBox.TabIndex = 135;
            this.toSectionCheckBox.Text = "إلى الدائرة:";
            this.toSectionCheckBox.UseVisualStyleBackColor = true;
            this.toSectionCheckBox.CheckedChanged += new System.EventHandler(this.toSectionCheckBox_CheckedChanged);
            // 
            // toDepartmentCheckBox
            // 
            this.toDepartmentCheckBox.AutoSize = true;
            this.toDepartmentCheckBox.Location = new System.Drawing.Point(619, 93);
            this.toDepartmentCheckBox.Name = "toDepartmentCheckBox";
            this.toDepartmentCheckBox.Size = new System.Drawing.Size(95, 28);
            this.toDepartmentCheckBox.TabIndex = 115;
            this.toDepartmentCheckBox.Text = "إلى القسم";
            this.toDepartmentCheckBox.UseVisualStyleBackColor = true;
            this.toDepartmentCheckBox.CheckedChanged += new System.EventHandler(this.toDepartmentCheckBox_CheckedChanged);
            // 
            // assetMovementDateLabel
            // 
            this.assetMovementDateLabel.AutoSize = true;
            this.assetMovementDateLabel.Location = new System.Drawing.Point(1184, 283);
            this.assetMovementDateLabel.Name = "assetMovementDateLabel";
            this.assetMovementDateLabel.Size = new System.Drawing.Size(91, 24);
            this.assetMovementDateLabel.TabIndex = 185;
            this.assetMovementDateLabel.Text = "تاريخ النقل:";
            // 
            // assetMovementDateDateEdit
            // 
            this.assetMovementDateDateEdit.EditValue = null;
            this.assetMovementDateDateEdit.Location = new System.Drawing.Point(907, 280);
            this.assetMovementDateDateEdit.Name = "assetMovementDateDateEdit";
            this.assetMovementDateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetMovementDateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.assetMovementDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.assetMovementDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.assetMovementDateDateEdit.Size = new System.Drawing.Size(259, 30);
            this.assetMovementDateDateEdit.TabIndex = 190;
            // 
            // assetMoveBtn
            // 
            this.assetMoveBtn.Image = global::AssetManagement.Properties.Resources._1592276;
            this.assetMoveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.assetMoveBtn.Location = new System.Drawing.Point(45, 259);
            this.assetMoveBtn.Name = "assetMoveBtn";
            this.assetMoveBtn.Size = new System.Drawing.Size(163, 74);
            this.assetMoveBtn.TabIndex = 300;
            this.assetMoveBtn.Text = "نقل";
            this.assetMoveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.assetMoveBtn.UseVisualStyleBackColor = true;
            this.assetMoveBtn.Click += new System.EventHandler(this.assetMoveBtn_Click);
            // 
            // fromSquareTextBox
            // 
            this.fromSquareTextBox.Location = new System.Drawing.Point(905, 185);
            this.fromSquareTextBox.Name = "fromSquareTextBox";
            this.fromSquareTextBox.ReadOnly = true;
            this.fromSquareTextBox.Size = new System.Drawing.Size(261, 32);
            this.fromSquareTextBox.TabIndex = 150;
            // 
            // fromSectionTextBox
            // 
            this.fromSectionTextBox.Location = new System.Drawing.Point(905, 138);
            this.fromSectionTextBox.Name = "fromSectionTextBox";
            this.fromSectionTextBox.ReadOnly = true;
            this.fromSectionTextBox.Size = new System.Drawing.Size(261, 32);
            this.fromSectionTextBox.TabIndex = 130;
            // 
            // fromDepartmentTextBox
            // 
            this.fromDepartmentTextBox.Location = new System.Drawing.Point(905, 91);
            this.fromDepartmentTextBox.Name = "fromDepartmentTextBox";
            this.fromDepartmentTextBox.ReadOnly = true;
            this.fromDepartmentTextBox.Size = new System.Drawing.Size(261, 32);
            this.fromDepartmentTextBox.TabIndex = 110;
            // 
            // toCustodianNameTextBox
            // 
            this.toCustodianNameTextBox.Location = new System.Drawing.Point(279, 232);
            this.toCustodianNameTextBox.Name = "toCustodianNameTextBox";
            this.toCustodianNameTextBox.Size = new System.Drawing.Size(261, 32);
            this.toCustodianNameTextBox.TabIndex = 180;
            this.toCustodianNameTextBox.Visible = false;
            // 
            // fromCustodianNameTextBox
            // 
            this.fromCustodianNameTextBox.Location = new System.Drawing.Point(905, 232);
            this.fromCustodianNameTextBox.Name = "fromCustodianNameTextBox";
            this.fromCustodianNameTextBox.ReadOnly = true;
            this.fromCustodianNameTextBox.Size = new System.Drawing.Size(261, 32);
            this.fromCustodianNameTextBox.TabIndex = 170;
            // 
            // fromCustodianNameLabel
            // 
            this.fromCustodianNameLabel.AutoSize = true;
            this.fromCustodianNameLabel.Location = new System.Drawing.Point(1201, 236);
            this.fromCustodianNameLabel.Name = "fromCustodianNameLabel";
            this.fromCustodianNameLabel.Size = new System.Drawing.Size(74, 24);
            this.fromCustodianNameLabel.TabIndex = 165;
            this.fromCustodianNameLabel.Text = "من عهدة:";
            // 
            // toSquareLookUpEdit
            // 
            this.toSquareLookUpEdit.Location = new System.Drawing.Point(279, 186);
            this.toSquareLookUpEdit.Name = "toSquareLookUpEdit";
            this.toSquareLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toSquareLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.toSquareLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toSquareLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الساحة", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SquareName", "اسم الساحة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SquareLocation", "موقع الساحة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.toSquareLookUpEdit.Properties.DataSource = this.squareTblBindingSource;
            this.toSquareLookUpEdit.Properties.DisplayMember = "SquareName";
            this.toSquareLookUpEdit.Properties.ValueMember = "ID";
            this.toSquareLookUpEdit.Size = new System.Drawing.Size(261, 30);
            this.toSquareLookUpEdit.TabIndex = 160;
            this.toSquareLookUpEdit.Visible = false;
            // 
            // squareTblBindingSource
            // 
            this.squareTblBindingSource.DataMember = "SquareTbl";
            this.squareTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // toSectionLookUpEdit
            // 
            this.toSectionLookUpEdit.Location = new System.Drawing.Point(279, 139);
            this.toSectionLookUpEdit.Name = "toSectionLookUpEdit";
            this.toSectionLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toSectionLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.toSectionLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toSectionLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف الدائرة", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SectionName", "اسم الدائرة", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.toSectionLookUpEdit.Properties.DataSource = this.sectionTblBindingSource;
            this.toSectionLookUpEdit.Properties.DisplayMember = "SectionName";
            this.toSectionLookUpEdit.Properties.ValueMember = "ID";
            this.toSectionLookUpEdit.Size = new System.Drawing.Size(261, 30);
            this.toSectionLookUpEdit.TabIndex = 140;
            this.toSectionLookUpEdit.Visible = false;
            // 
            // sectionTblBindingSource
            // 
            this.sectionTblBindingSource.DataMember = "SectionTbl";
            this.sectionTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // toDepartmentLookUpEdit
            // 
            this.toDepartmentLookUpEdit.Location = new System.Drawing.Point(279, 92);
            this.toDepartmentLookUpEdit.Name = "toDepartmentLookUpEdit";
            this.toDepartmentLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDepartmentLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.toDepartmentLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDepartmentLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف القسم", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "اسم القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentHQ", "مقر القسم", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.toDepartmentLookUpEdit.Properties.DataSource = this.departmentTblBindingSource;
            this.toDepartmentLookUpEdit.Properties.DisplayMember = "DepartmentName";
            this.toDepartmentLookUpEdit.Properties.ValueMember = "ID";
            this.toDepartmentLookUpEdit.Size = new System.Drawing.Size(261, 30);
            this.toDepartmentLookUpEdit.TabIndex = 120;
            this.toDepartmentLookUpEdit.Visible = false;
            // 
            // departmentTblBindingSource
            // 
            this.departmentTblBindingSource.DataMember = "DepartmentTbl";
            this.departmentTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // fromSquareLabel
            // 
            this.fromSquareLabel.AutoSize = true;
            this.fromSquareLabel.Location = new System.Drawing.Point(1187, 189);
            this.fromSquareLabel.Name = "fromSquareLabel";
            this.fromSquareLabel.Size = new System.Drawing.Size(88, 24);
            this.fromSquareLabel.TabIndex = 145;
            this.fromSquareLabel.Text = "من الساحة:";
            // 
            // fromSectionLabel
            // 
            this.fromSectionLabel.AutoSize = true;
            this.fromSectionLabel.Location = new System.Drawing.Point(1195, 142);
            this.fromSectionLabel.Name = "fromSectionLabel";
            this.fromSectionLabel.Size = new System.Drawing.Size(80, 24);
            this.fromSectionLabel.TabIndex = 125;
            this.fromSectionLabel.Text = "من الدائرة:";
            // 
            // fromDepartmentLabel
            // 
            this.fromDepartmentLabel.AutoSize = true;
            this.fromDepartmentLabel.Location = new System.Drawing.Point(1195, 95);
            this.fromDepartmentLabel.Name = "fromDepartmentLabel";
            this.fromDepartmentLabel.Size = new System.Drawing.Size(80, 24);
            this.fromDepartmentLabel.TabIndex = 105;
            this.fromDepartmentLabel.Text = "من القسم:";
            // 
            // searchAssetBtn
            // 
            this.searchAssetBtn.Image = global::AssetManagement.Properties.Resources._2719309;
            this.searchAssetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchAssetBtn.Location = new System.Drawing.Point(552, 33);
            this.searchAssetBtn.Name = "searchAssetBtn";
            this.searchAssetBtn.Size = new System.Drawing.Size(163, 74);
            this.searchAssetBtn.TabIndex = 50;
            this.searchAssetBtn.Text = "بحث";
            this.searchAssetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchAssetBtn.UseVisualStyleBackColor = true;
            this.searchAssetBtn.Click += new System.EventHandler(this.searchAssetBtn_Click);
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
            this.tableAdapterManager.MainCategoryTblTableAdapter = null;
            this.tableAdapterManager.MinorCategoryTblTableAdapter = null;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.SectionTblTableAdapter = this.sectionTblTableAdapter;
            this.tableAdapterManager.SquareTblTableAdapter = this.squareTblTableAdapter;
            this.tableAdapterManager.StatusTblTableAdapter = null;
            this.tableAdapterManager.TransactionTypeTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AssetManagement.AssetMngDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
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
            // MoveAssetForm
            // 
            this.AcceptButton = this.searchAssetBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 758);
            this.Controls.Add(this.moveAssetGroupBox);
            this.Controls.Add(this.searchAssetBtn);
            this.Controls.Add(this.assetCodeLabel);
            this.Controls.Add(this.assetCodeTextBox);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MoveAssetForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نقل أصل";
            this.Load += new System.EventHandler(this.MoveAssetForm_Load);
            this.moveAssetGroupBox.ResumeLayout(false);
            this.moveAssetGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementTblBindingNavigator)).EndInit();
            this.assetMovementTblBindingNavigator.ResumeLayout(false);
            this.assetMovementTblBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetMoveVwGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMoveVwGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMovementDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toSquareLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toSectionLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDepartmentLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMoveVwBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox assetCodeTextBox;
        private System.Windows.Forms.Label assetCodeLabel;
        private System.Windows.Forms.Button searchAssetBtn;
        private System.Windows.Forms.GroupBox moveAssetGroupBox;
        private System.Windows.Forms.Label fromCustodianNameLabel;
        private DevExpress.XtraEditors.LookUpEdit toSquareLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit toSectionLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit toDepartmentLookUpEdit;
        private System.Windows.Forms.Label fromSquareLabel;
        private System.Windows.Forms.Label fromSectionLabel;
        private System.Windows.Forms.Label fromDepartmentLabel;
        private System.Windows.Forms.TextBox fromCustodianNameTextBox;
        private System.Windows.Forms.TextBox toCustodianNameTextBox;
        private System.Windows.Forms.TextBox fromSquareTextBox;
        private System.Windows.Forms.TextBox fromSectionTextBox;
        private System.Windows.Forms.TextBox fromDepartmentTextBox;
        private System.Windows.Forms.Label assetMovementDateLabel;
        private DevExpress.XtraEditors.DateEdit assetMovementDateDateEdit;
        private System.Windows.Forms.Button assetMoveBtn;
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
        private System.Windows.Forms.CheckBox toSectionCheckBox;
        private System.Windows.Forms.CheckBox toDepartmentCheckBox;
        private System.Windows.Forms.Label assetInfoLabel;
        private DevExpress.XtraGrid.GridControl assetMoveVwGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView assetMoveVwGridView;
        private System.Windows.Forms.BindingSource assetMoveVwBindingSource;
        private AssetMngDbDataSetTableAdapters.AssetMoveVwTableAdapter assetMoveVwTableAdapter;
        private System.Windows.Forms.BindingSource assetMovementTblBindingSource;
        private AssetMngDbDataSetTableAdapters.AssetMovementTblTableAdapter assetMovementTblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetID;
        private DevExpress.XtraGrid.Columns.GridColumn colFieldChanged;
        private DevExpress.XtraGrid.Columns.GridColumn colOldValue;
        private DevExpress.XtraGrid.Columns.GridColumn colNewValue;
        private DevExpress.XtraGrid.Columns.GridColumn colMovementDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetMovedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetMovedBy;
        private System.Windows.Forms.BindingNavigator assetMovementTblBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton assetMovementTblBindingNavigatorSaveItem;
    }
}