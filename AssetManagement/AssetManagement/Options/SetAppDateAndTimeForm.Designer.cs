
namespace AssetManagement.Options
{
    partial class SetAppDateAndTimeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetAppDateAndTimeForm));
            this.appDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.appTimeTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.appDateLabel = new System.Windows.Forms.Label();
            this.appTimeLabel = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appTimeTimeEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // appDateDateEdit
            // 
            this.appDateDateEdit.EditValue = null;
            this.appDateDateEdit.Location = new System.Drawing.Point(156, 28);
            this.appDateDateEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.appDateDateEdit.Name = "appDateDateEdit";
            this.appDateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appDateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.appDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.appDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.appDateDateEdit.Size = new System.Drawing.Size(236, 34);
            this.appDateDateEdit.TabIndex = 10;
            // 
            // appTimeTimeEdit
            // 
            this.appTimeTimeEdit.EditValue = new System.DateTime(2022, 7, 6, 0, 0, 0, 0);
            this.appTimeTimeEdit.Location = new System.Drawing.Point(156, 106);
            this.appTimeTimeEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.appTimeTimeEdit.Name = "appTimeTimeEdit";
            this.appTimeTimeEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTimeTimeEdit.Properties.Appearance.Options.UseFont = true;
            this.appTimeTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.appTimeTimeEdit.Size = new System.Drawing.Size(236, 34);
            this.appTimeTimeEdit.TabIndex = 20;
            // 
            // appDateLabel
            // 
            this.appDateLabel.AutoSize = true;
            this.appDateLabel.Location = new System.Drawing.Point(52, 31);
            this.appDateLabel.Name = "appDateLabel";
            this.appDateLabel.Size = new System.Drawing.Size(73, 29);
            this.appDateLabel.TabIndex = 5;
            this.appDateLabel.Text = "التاريخ:";
            // 
            // appTimeLabel
            // 
            this.appTimeLabel.AutoSize = true;
            this.appTimeLabel.Location = new System.Drawing.Point(52, 109);
            this.appTimeLabel.Name = "appTimeLabel";
            this.appTimeLabel.Size = new System.Drawing.Size(69, 29);
            this.appTimeLabel.TabIndex = 15;
            this.appTimeLabel.Text = "الوقت:";
            // 
            // okBtn
            // 
            this.okBtn.Image = global::AssetManagement.Properties.Resources._2137710;
            this.okBtn.Location = new System.Drawing.Point(541, 80);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(90, 90);
            this.okBtn.TabIndex = 100;
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Image = global::AssetManagement.Properties.Resources._2137707;
            this.cancelBtn.Location = new System.Drawing.Point(688, 80);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(90, 90);
            this.cancelBtn.TabIndex = 105;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // SetAppDateAndTimeForm
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(798, 249);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.appTimeLabel);
            this.Controls.Add(this.appDateLabel);
            this.Controls.Add(this.appDateDateEdit);
            this.Controls.Add(this.appTimeTimeEdit);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SetAppDateAndTimeForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ضبط الوقت والتاريخ";
            this.Load += new System.EventHandler(this.SetAppDateAndTimeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appTimeTimeEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TimeEdit appTimeTimeEdit;
        private DevExpress.XtraEditors.DateEdit appDateDateEdit;
        private System.Windows.Forms.Label appDateLabel;
        private System.Windows.Forms.Label appTimeLabel;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}