﻿
namespace AssetManagement.Finance
{
    partial class FinancialReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialReportsForm));
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.toDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.fromDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.fromDateLabel = new System.Windows.Forms.Label();
            this.toDateLabel = new System.Windows.Forms.Label();
            this.financialItemGridControl = new DevExpress.XtraGrid.GridControl();
            this.financialItemTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetMngDbDataSet = new AssetManagement.AssetMngDbDataSet();
            this.financialItemGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinancialItemCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinancialItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinancialItemInsertionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncomingOrOutgoing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncomingAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutgoingAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinancialItemCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdditionalNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.financialItemTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.FinancialItemTblTableAdapter();
            this.searchFinancialItemDropDownButton = new DevExpress.XtraEditors.DropDownButton();
            this.exportFinancialReportToExcelDropDownButton = new DevExpress.XtraEditors.DropDownButton();
            this.financialItemCategoryRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.financialItemCategoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialItemCategoryTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.FinancialItemCategoryTblTableAdapter();
            this.currencyRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.currencyTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currencyTblTableAdapter = new AssetManagement.AssetMngDbDataSetTableAdapters.CurrencyTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.toDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).BeginInit();
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
            // toDateDateEdit
            // 
            this.toDateDateEdit.EditValue = null;
            this.toDateDateEdit.Location = new System.Drawing.Point(162, 131);
            this.toDateDateEdit.Name = "toDateDateEdit";
            this.toDateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.toDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDateDateEdit.Size = new System.Drawing.Size(243, 30);
            this.toDateDateEdit.TabIndex = 0;
            // 
            // fromDateDateEdit
            // 
            this.fromDateDateEdit.EditValue = null;
            this.fromDateDateEdit.Location = new System.Drawing.Point(162, 46);
            this.fromDateDateEdit.Name = "fromDateDateEdit";
            this.fromDateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.fromDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDateDateEdit.Size = new System.Drawing.Size(243, 30);
            this.fromDateDateEdit.TabIndex = 1;
            // 
            // fromDateLabel
            // 
            this.fromDateLabel.AutoSize = true;
            this.fromDateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateLabel.Location = new System.Drawing.Point(39, 49);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.Size = new System.Drawing.Size(75, 24);
            this.fromDateLabel.TabIndex = 2;
            this.fromDateLabel.Text = "من تاريخ:";
            // 
            // toDateLabel
            // 
            this.toDateLabel.AutoSize = true;
            this.toDateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateLabel.Location = new System.Drawing.Point(39, 134);
            this.toDateLabel.Name = "toDateLabel";
            this.toDateLabel.Size = new System.Drawing.Size(89, 24);
            this.toDateLabel.TabIndex = 3;
            this.toDateLabel.Text = "لغاية تاريخ:";
            // 
            // financialItemGridControl
            // 
            this.financialItemGridControl.DataSource = this.financialItemTblBindingSource;
            this.financialItemGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.financialItemGridControl.Location = new System.Drawing.Point(469, 0);
            this.financialItemGridControl.MainView = this.financialItemGridView;
            this.financialItemGridControl.Name = "financialItemGridControl";
            this.financialItemGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.financialItemCategoryRepositoryItemLookUpEdit,
            this.currencyRepositoryItemLookUpEdit});
            this.financialItemGridControl.Size = new System.Drawing.Size(733, 591);
            this.financialItemGridControl.TabIndex = 4;
            this.financialItemGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.financialItemGridView});
            this.financialItemGridControl.Visible = false;
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
            // financialItemGridView
            // 
            this.financialItemGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFinancialItemCategory,
            this.colFinancialItemDescription,
            this.colFinancialItemInsertionDate,
            this.colIncomingOrOutgoing,
            this.colIncomingAmount,
            this.colOutgoingAmount,
            this.colFinancialItemCurrency,
            this.colAdditionalNotes});
            this.financialItemGridView.GridControl = this.financialItemGridControl;
            this.financialItemGridView.Name = "financialItemGridView";
            // 
            // colID
            // 
            this.colID.Caption = "معرف السجل المالي";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 80;
            this.colID.Name = "colID";
            this.colID.Width = 94;
            // 
            // colFinancialItemCategory
            // 
            this.colFinancialItemCategory.Caption = "البند المالي";
            this.colFinancialItemCategory.ColumnEdit = this.financialItemCategoryRepositoryItemLookUpEdit;
            this.colFinancialItemCategory.FieldName = "FinancialItemCategory";
            this.colFinancialItemCategory.MinWidth = 150;
            this.colFinancialItemCategory.Name = "colFinancialItemCategory";
            this.colFinancialItemCategory.Visible = true;
            this.colFinancialItemCategory.VisibleIndex = 0;
            this.colFinancialItemCategory.Width = 150;
            // 
            // colFinancialItemDescription
            // 
            this.colFinancialItemDescription.Caption = "بيان السجل المالي";
            this.colFinancialItemDescription.FieldName = "FinancialItemDescription";
            this.colFinancialItemDescription.MinWidth = 150;
            this.colFinancialItemDescription.Name = "colFinancialItemDescription";
            this.colFinancialItemDescription.Visible = true;
            this.colFinancialItemDescription.VisibleIndex = 1;
            this.colFinancialItemDescription.Width = 150;
            // 
            // colFinancialItemInsertionDate
            // 
            this.colFinancialItemInsertionDate.Caption = "تاريخ السجل المالي";
            this.colFinancialItemInsertionDate.FieldName = "FinancialItemInsertionDate";
            this.colFinancialItemInsertionDate.MinWidth = 80;
            this.colFinancialItemInsertionDate.Name = "colFinancialItemInsertionDate";
            this.colFinancialItemInsertionDate.Visible = true;
            this.colFinancialItemInsertionDate.VisibleIndex = 2;
            this.colFinancialItemInsertionDate.Width = 1000;
            // 
            // colIncomingOrOutgoing
            // 
            this.colIncomingOrOutgoing.Caption = "صادر أو وارد";
            this.colIncomingOrOutgoing.FieldName = "IncomingOrOutgoing";
            this.colIncomingOrOutgoing.MinWidth = 50;
            this.colIncomingOrOutgoing.Name = "colIncomingOrOutgoing";
            this.colIncomingOrOutgoing.Visible = true;
            this.colIncomingOrOutgoing.VisibleIndex = 3;
            this.colIncomingOrOutgoing.Width = 94;
            // 
            // colIncomingAmount
            // 
            this.colIncomingAmount.Caption = "المبلغ الوارد";
            this.colIncomingAmount.FieldName = "IncomingAmount";
            this.colIncomingAmount.MinWidth = 80;
            this.colIncomingAmount.Name = "colIncomingAmount";
            this.colIncomingAmount.Visible = true;
            this.colIncomingAmount.VisibleIndex = 4;
            this.colIncomingAmount.Width = 100;
            // 
            // colOutgoingAmount
            // 
            this.colOutgoingAmount.Caption = "المبلغ الصادر";
            this.colOutgoingAmount.FieldName = "OutgoingAmount";
            this.colOutgoingAmount.MinWidth = 80;
            this.colOutgoingAmount.Name = "colOutgoingAmount";
            this.colOutgoingAmount.Visible = true;
            this.colOutgoingAmount.VisibleIndex = 5;
            this.colOutgoingAmount.Width = 94;
            // 
            // colFinancialItemCurrency
            // 
            this.colFinancialItemCurrency.Caption = "العملة";
            this.colFinancialItemCurrency.ColumnEdit = this.currencyRepositoryItemLookUpEdit;
            this.colFinancialItemCurrency.FieldName = "FinancialItemCurrency";
            this.colFinancialItemCurrency.MinWidth = 100;
            this.colFinancialItemCurrency.Name = "colFinancialItemCurrency";
            this.colFinancialItemCurrency.Visible = true;
            this.colFinancialItemCurrency.VisibleIndex = 6;
            this.colFinancialItemCurrency.Width = 100;
            // 
            // colAdditionalNotes
            // 
            this.colAdditionalNotes.Caption = "ملاحظات إضافية";
            this.colAdditionalNotes.FieldName = "AdditionalNotes";
            this.colAdditionalNotes.MinWidth = 150;
            this.colAdditionalNotes.Name = "colAdditionalNotes";
            this.colAdditionalNotes.Visible = true;
            this.colAdditionalNotes.VisibleIndex = 7;
            this.colAdditionalNotes.Width = 150;
            // 
            // financialItemTblTableAdapter
            // 
            this.financialItemTblTableAdapter.ClearBeforeFill = true;
            // 
            // searchFinancialItemDropDownButton
            // 
            this.searchFinancialItemDropDownButton.ImageOptions.Image = global::AssetManagement.Properties.Resources._2719309;
            this.searchFinancialItemDropDownButton.Location = new System.Drawing.Point(43, 229);
            this.searchFinancialItemDropDownButton.Name = "searchFinancialItemDropDownButton";
            this.searchFinancialItemDropDownButton.Size = new System.Drawing.Size(163, 73);
            this.searchFinancialItemDropDownButton.TabIndex = 509;
            this.searchFinancialItemDropDownButton.Text = "بحث";
            this.searchFinancialItemDropDownButton.Click += new System.EventHandler(this.searchFinancialItemDropDownButton_Click);
            // 
            // exportFinancialReportToExcelDropDownButton
            // 
            this.exportFinancialReportToExcelDropDownButton.Enabled = false;
            this.exportFinancialReportToExcelDropDownButton.ImageOptions.Image = global::AssetManagement.Properties.Resources._3643510;
            this.exportFinancialReportToExcelDropDownButton.Location = new System.Drawing.Point(43, 370);
            this.exportFinancialReportToExcelDropDownButton.Name = "exportFinancialReportToExcelDropDownButton";
            this.exportFinancialReportToExcelDropDownButton.Size = new System.Drawing.Size(163, 73);
            this.exportFinancialReportToExcelDropDownButton.TabIndex = 508;
            this.exportFinancialReportToExcelDropDownButton.Text = "تصدير الجرد";
            this.exportFinancialReportToExcelDropDownButton.Click += new System.EventHandler(this.exportFinancialReportToExcelDropDownButton_Click);
            // 
            // financialItemCategoryRepositoryItemLookUpEdit
            // 
            this.financialItemCategoryRepositoryItemLookUpEdit.AutoHeight = false;
            this.financialItemCategoryRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.financialItemCategoryRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف البند المالي", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FinancialItemCategoryName", "اسم البند المالي", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FinancialItemCategoryDetails", "وصف البند المالي", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.financialItemCategoryRepositoryItemLookUpEdit.DataSource = this.financialItemCategoryTblBindingSource;
            this.financialItemCategoryRepositoryItemLookUpEdit.DisplayMember = "FinancialItemCategoryName";
            this.financialItemCategoryRepositoryItemLookUpEdit.Name = "financialItemCategoryRepositoryItemLookUpEdit";
            this.financialItemCategoryRepositoryItemLookUpEdit.ValueMember = "ID";
            // 
            // financialItemCategoryTblBindingSource
            // 
            this.financialItemCategoryTblBindingSource.DataMember = "FinancialItemCategoryTbl";
            this.financialItemCategoryTblBindingSource.DataSource = this.assetMngDbDataSet;
            // 
            // financialItemCategoryTblTableAdapter
            // 
            this.financialItemCategoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // currencyRepositoryItemLookUpEdit
            // 
            this.currencyRepositoryItemLookUpEdit.AutoHeight = false;
            this.currencyRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.currencyRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "معرف العملة", 80, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyName", "اسم العملة", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.currencyRepositoryItemLookUpEdit.DataSource = this.currencyTblBindingSource;
            this.currencyRepositoryItemLookUpEdit.DisplayMember = "CurrencyName";
            this.currencyRepositoryItemLookUpEdit.Name = "currencyRepositoryItemLookUpEdit";
            this.currencyRepositoryItemLookUpEdit.ValueMember = "ID";
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
            // FinancialReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 591);
            this.Controls.Add(this.searchFinancialItemDropDownButton);
            this.Controls.Add(this.exportFinancialReportToExcelDropDownButton);
            this.Controls.Add(this.financialItemGridControl);
            this.Controls.Add(this.toDateLabel);
            this.Controls.Add(this.fromDateLabel);
            this.Controls.Add(this.fromDateDateEdit);
            this.Controls.Add(this.toDateDateEdit);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FinancialReportsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التقارير المالية";
            this.Load += new System.EventHandler(this.FinancialReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetMngDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialItemCategoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private DevExpress.XtraEditors.DateEdit toDateDateEdit;
        private DevExpress.XtraEditors.DateEdit fromDateDateEdit;
        private System.Windows.Forms.Label fromDateLabel;
        private System.Windows.Forms.Label toDateLabel;
        private DevExpress.XtraGrid.GridControl financialItemGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView financialItemGridView;
        private AssetMngDbDataSet assetMngDbDataSet;
        private System.Windows.Forms.BindingSource financialItemTblBindingSource;
        private AssetMngDbDataSetTableAdapters.FinancialItemTblTableAdapter financialItemTblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFinancialItemCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colFinancialItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colFinancialItemInsertionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIncomingOrOutgoing;
        private DevExpress.XtraGrid.Columns.GridColumn colIncomingAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colOutgoingAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colFinancialItemCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colAdditionalNotes;
        private DevExpress.XtraEditors.DropDownButton searchFinancialItemDropDownButton;
        private DevExpress.XtraEditors.DropDownButton exportFinancialReportToExcelDropDownButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit financialItemCategoryRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource financialItemCategoryTblBindingSource;
        private AssetMngDbDataSetTableAdapters.FinancialItemCategoryTblTableAdapter financialItemCategoryTblTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit currencyRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource currencyTblBindingSource;
        private AssetMngDbDataSetTableAdapters.CurrencyTblTableAdapter currencyTblTableAdapter;
    }
}