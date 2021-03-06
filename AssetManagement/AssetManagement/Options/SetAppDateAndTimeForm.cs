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
    public partial class SetAppDateAndTimeForm : Form
    {
        public SetAppDateAndTimeForm()
        {
            InitializeComponent();
        }

        private void SetAppDateAndTimeForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;

            appDateDateEdit.EditValue = DateTime.Today.AddDays(StaticCode.ShiftDays);
            appTimeTimeEdit.EditValue = DateTime.Now.AddSeconds(StaticCode.ShiftSeconds);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime appDate1 = Convert.ToDateTime(appDateDateEdit.EditValue);
                DateTime appTime1 = Convert.ToDateTime(appTimeTimeEdit.EditValue);
                StaticCode.ShiftDays = appDate1.Subtract(DateTime.Today).Days;
                StaticCode.ShiftSeconds = appTime1.Subtract(DateTime.Now).Hours * 3600 + appTime1.Subtract(DateTime.Now).Minutes * 60;
                this.Close();
            }
            catch
            {

            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
