using System;
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

            try
            {

            }
            catch
            {
                assetCodePrefixTextBox.Text = StaticCode.appOptions.AssetCodePrefix;
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StaticCode.appOptions.AssetCodePrefix = assetCodePrefixTextBox.Text.Trim();
                StaticCode.mainDbContext.SubmitChanges();
                mainAlertControl.Show(this, "تم الحفظ", StaticCode.ApplicationTitle);
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
    }
}