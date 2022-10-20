using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.Users
{
    public partial class LoginForm : Form
    {
        int attemptsCounter = 0;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.MaximumSize = this.Size;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string usernameTyped = usernameTextBox.Text;
            string passwordTyped = passwordTextBox.Text;
            var existedUser = StaticCode.mainDbContext.UserTbls.Where(usr => usr.Username == usernameTextBox.Text && usr.Password == passwordTextBox.Text);
            if (existedUser.Count() == 1)
            {
                StaticCode.activeUser = existedUser.First();
                StaticCode.activeUserRole = StaticCode.mainDbContext.UserRoleTbls.Single(usrrl => usrrl.ID == StaticCode.activeUser.UserRole);
                StaticCode.appOptions = StaticCode.mainDbContext.OptionsTbls.Single(opt => opt.ID == 1);
                StaticCode.appOptions.ActiveUser = StaticCode.activeUser.ID;
                StaticCode.mainDbContext.SubmitChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                attemptsCounter++;
                loginAlertControl.Show(this, $"محاولة فاشلة رقم ({attemptsCounter})!", StaticCode.ApplicationTitle);
                usernameTextBox.Text = passwordTextBox.Text = "";
                usernameTextBox.Focus();
                if (attemptsCounter == 3)
                {
                    MessageBox.Show("لقد وصلت إلى المحاولة الثالثة الخاطئة للدخول، حاول لاحقاً من فضلك", StaticCode.ApplicationTitle);
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}