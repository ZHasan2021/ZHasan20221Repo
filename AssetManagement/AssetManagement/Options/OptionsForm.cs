﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.Options
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;

            assetLifeSpanThresholdToWarnNumericUpDown.Value = StaticCode.appOptions.AssetLifeSpanThresholdToWarn;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StaticCode.appOptions.AssetLifeSpanThresholdToWarn = Convert.ToInt32(assetLifeSpanThresholdToWarnNumericUpDown.Value);
                StaticCode.mainDbContext.SubmitChanges();
                mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
                StaticCode.activeUserLogin.SessionActions += $"تعديل إعدادات التطبيق - {DateTime.Now.AddDays(StaticCode.appOptions.ShiftDays).AddSeconds(StaticCode.appOptions.ShiftSeconds)}\r\n";
                this.Close();
            }
            catch
            {
                mainAlertControl.Show(this, "لم يتم الحفظ", StaticCode.ApplicationTitle);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainAlertControl_FormLoad(object sender, DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs e)
        {
            e.AlertForm.Size = new Size(350, 100);
            e.AlertForm.Location = new Point(500, 200);
        }
    }
}