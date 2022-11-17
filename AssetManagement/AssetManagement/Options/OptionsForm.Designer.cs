
namespace AssetManagement.Options
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.mainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.assetLifeSpanThresholdToWarnNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.assetLifeSpanThresholdToWarnLabel = new System.Windows.Forms.Label();
            this.monthsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.assetLifeSpanThresholdToWarnNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Image = global::AssetManagement.Properties.Resources._2137707;
            this.cancelBtn.Location = new System.Drawing.Point(686, 177);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(90, 90);
            this.cancelBtn.TabIndex = 205;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Image = global::AssetManagement.Properties.Resources._2137710;
            this.okBtn.Location = new System.Drawing.Point(539, 177);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(90, 90);
            this.okBtn.TabIndex = 200;
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
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
            // assetLifeSpanThresholdToWarnNumericUpDown
            // 
            this.assetLifeSpanThresholdToWarnNumericUpDown.Location = new System.Drawing.Point(509, 62);
            this.assetLifeSpanThresholdToWarnNumericUpDown.Name = "assetLifeSpanThresholdToWarnNumericUpDown";
            this.assetLifeSpanThresholdToWarnNumericUpDown.Size = new System.Drawing.Size(120, 32);
            this.assetLifeSpanThresholdToWarnNumericUpDown.TabIndex = 15;
            // 
            // assetLifeSpanThresholdToWarnLabel
            // 
            this.assetLifeSpanThresholdToWarnLabel.AutoSize = true;
            this.assetLifeSpanThresholdToWarnLabel.Location = new System.Drawing.Point(46, 66);
            this.assetLifeSpanThresholdToWarnLabel.Name = "assetLifeSpanThresholdToWarnLabel";
            this.assetLifeSpanThresholdToWarnLabel.Size = new System.Drawing.Size(440, 24);
            this.assetLifeSpanThresholdToWarnLabel.TabIndex = 10;
            this.assetLifeSpanThresholdToWarnLabel.Text = "إشعار عن الأصول ذات العمر الافتراضي المتبقي أقل من أو يساوي:";
            // 
            // monthsLabel
            // 
            this.monthsLabel.AutoSize = true;
            this.monthsLabel.Location = new System.Drawing.Point(664, 66);
            this.monthsLabel.Name = "monthsLabel";
            this.monthsLabel.Size = new System.Drawing.Size(44, 24);
            this.monthsLabel.TabIndex = 20;
            this.monthsLabel.Text = "أشهر";
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(825, 295);
            this.Controls.Add(this.monthsLabel);
            this.Controls.Add(this.assetLifeSpanThresholdToWarnLabel);
            this.Controls.Add(this.assetLifeSpanThresholdToWarnNumericUpDown);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "OptionsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إعدادات التطبيق";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assetLifeSpanThresholdToWarnNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private DevExpress.XtraBars.Alerter.AlertControl mainAlertControl;
        private System.Windows.Forms.NumericUpDown assetLifeSpanThresholdToWarnNumericUpDown;
        private System.Windows.Forms.Label assetLifeSpanThresholdToWarnLabel;
        private System.Windows.Forms.Label monthsLabel;
    }
}