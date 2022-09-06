
namespace Kindergarten.AuxTables
{
    partial class ManageFinancialItemTblForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageFinancialItemTblForm));
            this.financialItemGridControl = new DevExpress.XtraGrid.GridControl();
            this.financialItemTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindergartenDbDataSet = new Kindergarten.KindergartenDbDataSet();
            this.financialItemGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinancialItemCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fiCaRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.financialItemCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colFinancialItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncomingOrOutgoing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncomingAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutgoingAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinancialItemCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cuRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.currencyTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colFinancialItemDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRelativePerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdditionalNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsertedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModifiedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsertedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.financialItemTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.financialItemTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tableAdapterManager = new Kindergarten.KindergartenDbDataSetTableAdapters.TableAdapterManager();
            this.currencyTblTableAdapter = new Kindergarten.KindergartenDbDataSetTableAdapters.CurrencyTblTableAdapter();
            this.financialItemCategoryTblTableAdapter = new Kindergarten.KindergartenDbDataSetTableAdapters.FinancialItemCategoryTblTableAdapter();
            this.financialItemTblTableAdapter = new Kindergarten.KindergartenDbDataSetTableAdapters.FinancialItemTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiCaRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemTblBindingNavigator)).BeginInit();
            this.financialItemTblBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // financialItemGridControl
            // 
            this.financialItemGridControl.DataSource = this.financialItemTblBindingSource;
            this.financialItemGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "financialItemLevel";
            this.financialItemGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.financialItemGridControl.Location = new System.Drawing.Point(0, 27);
            this.financialItemGridControl.MainView = this.financialItemGridView;
            this.financialItemGridControl.Name = "financialItemGridControl";
            this.financialItemGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.fiCaRepositoryItemLookUpEdit,
            this.cuRepositoryItemLookUpEdit});
            this.financialItemGridControl.Size = new System.Drawing.Size(1313, 719);
            this.financialItemGridControl.TabIndex = 5;
            this.financialItemGridControl.UseEmbeddedNavigator = true;
            this.financialItemGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.financialItemGridView});
            // 
            // financialItemTblBindingSource
            // 
            this.financialItemTblBindingSource.DataMember = "FinancialItemTbl";
            this.financialItemTblBindingSource.DataSource = this.kindergartenDbDataSet;
            // 
            // kindergartenDbDataSet
            // 
            this.kindergartenDbDataSet.DataSetName = "KindergartenDbDataSet";
            this.kindergartenDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // financialItemGridView
            // 
            this.financialItemGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFinancialItemCategory,
            this.colFinancialItemDescription,
            this.colIncomingOrOutgoing,
            this.colIncomingAmount,
            this.colOutgoingAmount,
            this.colFinancialItemCurrency,
            this.colFinancialItemDate,
            this.colRelativePerson,
            this.colAdditionalNotes,
            this.colInsertedOn,
            this.colLastModifiedOn,
            this.colInsertedBy,
            this.colLastModifiedBy});
            this.financialItemGridView.GridControl = this.financialItemGridControl;
            this.financialItemGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IncomingAmount", this.colIncomingAmount, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OutgoingAmount", this.colOutgoingAmount, "")});
            this.financialItemGridView.Name = "financialItemGridView";
            this.financialItemGridView.OptionsView.ShowFooter = true;
            // 
            // colID
            // 
            this.colID.Caption = "معرف السجل";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 80;
            this.colID.Name = "colID";
            this.colID.Width = 94;
            // 
            // colFinancialItemCategory
            // 
            this.colFinancialItemCategory.Caption = "البند المالي";
            this.colFinancialItemCategory.ColumnEdit = this.fiCaRepositoryItemLookUpEdit;
            this.colFinancialItemCategory.FieldName = "FinancialItemCategory";
            this.colFinancialItemCategory.MinWidth = 150;
            this.colFinancialItemCategory.Name = "colFinancialItemCategory";
            this.colFinancialItemCategory.Visible = true;
            this.colFinancialItemCategory.VisibleIndex = 0;
            this.colFinancialItemCategory.Width = 150;
            // 
            // fiCaRepositoryItemLookUpEdit
            // 
            this.fiCaRepositoryItemLookUpEdit.AutoHeight = false;
            this.fiCaRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fiCaRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف البند المالي", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FinancialItemCategoryName", "اسم البند المالي", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.fiCaRepositoryItemLookUpEdit.DataSource = this.financialItemCategoryTblBindingSource;
            this.fiCaRepositoryItemLookUpEdit.DisplayMember = "FinancialItemCategoryName";
            this.fiCaRepositoryItemLookUpEdit.Name = "fiCaRepositoryItemLookUpEdit";
            this.fiCaRepositoryItemLookUpEdit.PopupWidth = 500;
            this.fiCaRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // financialItemCategoryTblBindingSource
            // 
            this.financialItemCategoryTblBindingSource.DataMember = "FinancialItemCategoryTbl";
            this.financialItemCategoryTblBindingSource.DataSource = this.kindergartenDbDataSet;
            // 
            // colFinancialItemDescription
            // 
            this.colFinancialItemDescription.Caption = "وصف السجل المالي";
            this.colFinancialItemDescription.FieldName = "FinancialItemDescription";
            this.colFinancialItemDescription.MinWidth = 200;
            this.colFinancialItemDescription.Name = "colFinancialItemDescription";
            this.colFinancialItemDescription.Visible = true;
            this.colFinancialItemDescription.VisibleIndex = 1;
            this.colFinancialItemDescription.Width = 200;
            // 
            // colIncomingOrOutgoing
            // 
            this.colIncomingOrOutgoing.Caption = "وارد أم صادر";
            this.colIncomingOrOutgoing.FieldName = "IncomingOrOutgoing";
            this.colIncomingOrOutgoing.MinWidth = 100;
            this.colIncomingOrOutgoing.Name = "colIncomingOrOutgoing";
            this.colIncomingOrOutgoing.Visible = true;
            this.colIncomingOrOutgoing.VisibleIndex = 2;
            this.colIncomingOrOutgoing.Width = 100;
            // 
            // colIncomingAmount
            // 
            this.colIncomingAmount.Caption = "المبلغ الوارد";
            this.colIncomingAmount.FieldName = "IncomingAmount";
            this.colIncomingAmount.MinWidth = 200;
            this.colIncomingAmount.Name = "colIncomingAmount";
            this.colIncomingAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IncomingAmount", "مجموع الوارد={0:0.##}")});
            this.colIncomingAmount.Visible = true;
            this.colIncomingAmount.VisibleIndex = 3;
            this.colIncomingAmount.Width = 200;
            // 
            // colOutgoingAmount
            // 
            this.colOutgoingAmount.Caption = "المبلغ الصادر";
            this.colOutgoingAmount.FieldName = "OutgoingAmount";
            this.colOutgoingAmount.MinWidth = 200;
            this.colOutgoingAmount.Name = "colOutgoingAmount";
            this.colOutgoingAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OutgoingAmount", "مجموع الضادر={0:0.##}")});
            this.colOutgoingAmount.Visible = true;
            this.colOutgoingAmount.VisibleIndex = 4;
            this.colOutgoingAmount.Width = 200;
            // 
            // colFinancialItemCurrency
            // 
            this.colFinancialItemCurrency.Caption = "عملة المبلغ";
            this.colFinancialItemCurrency.ColumnEdit = this.cuRepositoryItemLookUpEdit;
            this.colFinancialItemCurrency.FieldName = "FinancialItemCurrency";
            this.colFinancialItemCurrency.MinWidth = 100;
            this.colFinancialItemCurrency.Name = "colFinancialItemCurrency";
            this.colFinancialItemCurrency.Visible = true;
            this.colFinancialItemCurrency.VisibleIndex = 5;
            this.colFinancialItemCurrency.Width = 100;
            // 
            // cuRepositoryItemLookUpEdit
            // 
            this.cuRepositoryItemLookUpEdit.AutoHeight = false;
            this.cuRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cuRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف العملة", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyName", "اسم العملة", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cuRepositoryItemLookUpEdit.DataSource = this.currencyTblBindingSource;
            this.cuRepositoryItemLookUpEdit.DisplayMember = "CurrencyName";
            this.cuRepositoryItemLookUpEdit.Name = "cuRepositoryItemLookUpEdit";
            this.cuRepositoryItemLookUpEdit.PopupWidth = 500;
            this.cuRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // currencyTblBindingSource
            // 
            this.currencyTblBindingSource.DataMember = "CurrencyTbl";
            this.currencyTblBindingSource.DataSource = this.kindergartenDbDataSet;
            // 
            // colFinancialItemDate
            // 
            this.colFinancialItemDate.Caption = "تاريخ السجل المالي";
            this.colFinancialItemDate.FieldName = "FinancialItemDate";
            this.colFinancialItemDate.MinWidth = 80;
            this.colFinancialItemDate.Name = "colFinancialItemDate";
            this.colFinancialItemDate.Visible = true;
            this.colFinancialItemDate.VisibleIndex = 6;
            this.colFinancialItemDate.Width = 94;
            // 
            // colRelativePerson
            // 
            this.colRelativePerson.Caption = "الشخص المعني بالسجل";
            this.colRelativePerson.FieldName = "RelativePerson";
            this.colRelativePerson.MinWidth = 200;
            this.colRelativePerson.Name = "colRelativePerson";
            this.colRelativePerson.Visible = true;
            this.colRelativePerson.VisibleIndex = 7;
            this.colRelativePerson.Width = 200;
            // 
            // colAdditionalNotes
            // 
            this.colAdditionalNotes.Caption = "ملاحظات";
            this.colAdditionalNotes.FieldName = "AdditionalNotes";
            this.colAdditionalNotes.MinWidth = 200;
            this.colAdditionalNotes.Name = "colAdditionalNotes";
            this.colAdditionalNotes.Visible = true;
            this.colAdditionalNotes.VisibleIndex = 8;
            this.colAdditionalNotes.Width = 200;
            // 
            // colInsertedOn
            // 
            this.colInsertedOn.Caption = "تاريخ إضافة السجل";
            this.colInsertedOn.FieldName = "InsertedOn";
            this.colInsertedOn.MinWidth = 80;
            this.colInsertedOn.Name = "colInsertedOn";
            this.colInsertedOn.Width = 94;
            // 
            // colLastModifiedOn
            // 
            this.colLastModifiedOn.Caption = "تاريخ أخر تعديل";
            this.colLastModifiedOn.FieldName = "LastModifiedOn";
            this.colLastModifiedOn.MinWidth = 80;
            this.colLastModifiedOn.Name = "colLastModifiedOn";
            this.colLastModifiedOn.Width = 94;
            // 
            // colInsertedBy
            // 
            this.colInsertedBy.Caption = "المستخدم الذي قام بالإضافة";
            this.colInsertedBy.FieldName = "InsertedBy";
            this.colInsertedBy.MinWidth = 80;
            this.colInsertedBy.Name = "colInsertedBy";
            this.colInsertedBy.Width = 94;
            // 
            // colLastModifiedBy
            // 
            this.colLastModifiedBy.Caption = "المستخدم الذي قام بالتعديل";
            this.colLastModifiedBy.FieldName = "LastModifiedBy";
            this.colLastModifiedBy.MinWidth = 80;
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
            // financialItemTblBindingNavigator
            // 
            this.financialItemTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.financialItemTblBindingNavigator.BindingSource = this.financialItemTblBindingSource;
            this.financialItemTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.financialItemTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.financialItemTblBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.financialItemTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.financialItemTblBindingNavigatorSaveItem});
            this.financialItemTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.financialItemTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.financialItemTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.financialItemTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.financialItemTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.financialItemTblBindingNavigator.Name = "financialItemTblBindingNavigator";
            this.financialItemTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.financialItemTblBindingNavigator.Size = new System.Drawing.Size(1313, 27);
            this.financialItemTblBindingNavigator.TabIndex = 4;
            this.financialItemTblBindingNavigator.Text = "bindingNavigator1";
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
            // financialItemTblBindingNavigatorSaveItem
            // 
            this.financialItemTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.financialItemTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("financialItemTblBindingNavigatorSaveItem.Image")));
            this.financialItemTblBindingNavigatorSaveItem.Name = "financialItemTblBindingNavigatorSaveItem";
            this.financialItemTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.financialItemTblBindingNavigatorSaveItem.Text = "Save Data";
            this.financialItemTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.currencyTblBindingNavigatorSaveItem_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CurrencyTblTableAdapter = this.currencyTblTableAdapter;
            this.tableAdapterManager.EducationalLevelTblTableAdapter = null;
            this.tableAdapterManager.FeePeriodTblTableAdapter = null;
            this.tableAdapterManager.FinancialItemCategoryTblTableAdapter = this.financialItemCategoryTblTableAdapter;
            this.tableAdapterManager.FinancialItemTblTableAdapter = this.financialItemTblTableAdapter;
            this.tableAdapterManager.OptionsTblTableAdapter = null;
            this.tableAdapterManager.ScholasticYearTblTableAdapter = null;
            this.tableAdapterManager.StudentFeeTblTableAdapter = null;
            this.tableAdapterManager.StudentTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kindergarten.KindergartenDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTblTableAdapter = null;
            this.tableAdapterManager.UserTblTableAdapter = null;
            // 
            // currencyTblTableAdapter
            // 
            this.currencyTblTableAdapter.ClearBeforeFill = true;
            // 
            // financialItemCategoryTblTableAdapter
            // 
            this.financialItemCategoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // financialItemTblTableAdapter
            // 
            this.financialItemTblTableAdapter.ClearBeforeFill = true;
            // 
            // ManageFinancialItemTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 746);
            this.Controls.Add(this.financialItemGridControl);
            this.Controls.Add(this.financialItemTblBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageFinancialItemTblForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة سجلات الحركة المالية";
            this.Load += new System.EventHandler(this.ManageFinancialItemTblForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.financialItemGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiCaRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemTblBindingNavigator)).EndInit();
            this.financialItemTblBindingNavigator.ResumeLayout(false);
            this.financialItemTblBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private System.Windows.Forms.BindingNavigator financialItemTblBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton financialItemTblBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl financialItemGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView financialItemGridView;
        private KindergartenDbDataSet kindergartenDbDataSet;
        private KindergartenDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource financialItemTblBindingSource;
        private KindergartenDbDataSetTableAdapters.FinancialItemTblTableAdapter financialItemTblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFinancialItemCategory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit fiCaRepositoryItemLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colFinancialItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colIncomingOrOutgoing;
        private DevExpress.XtraGrid.Columns.GridColumn colIncomingAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colOutgoingAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colFinancialItemCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colFinancialItemDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRelativePerson;
        private DevExpress.XtraGrid.Columns.GridColumn colAdditionalNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colInsertedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModifiedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colInsertedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModifiedBy;
        private System.Windows.Forms.BindingSource financialItemCategoryTblBindingSource;
        private KindergartenDbDataSetTableAdapters.FinancialItemCategoryTblTableAdapter financialItemCategoryTblTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cuRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource currencyTblBindingSource;
        private KindergartenDbDataSetTableAdapters.CurrencyTblTableAdapter currencyTblTableAdapter;
    }
}