using AssetManagement.Users;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (Mutex mutex = new Mutex(false, "Global\\" + StaticCode.appGuid))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("يوجد نسخة فعالة من التطبيق ولا يسمح بتشغيل أكثر من نسخة معاً", StaticCode.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LoginForm logFrm = new LoginForm();
                DialogResult logResult = logFrm.ShowDialog();
                if (logResult != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }

                Application.Run(new MainForm());
            }
        }
    }
}