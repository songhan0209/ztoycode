using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchool
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog()==DialogResult.OK)
            {
                string loginType = loginForm.loginType;  // 登录类型
                string loginID = loginForm.loginID;   // 登录名
                Form mainForm = null;
                if (loginType=="教员")
                {
                    mainForm = new TeacherForm(loginID);
                }
                else if (loginType=="管理员")
                {
                    mainForm = new AdminForm(loginID);
                }
                else
                {
                    mainForm = new StudentMainForm(loginID);
                }
                Application.Run(mainForm);
               
            }
        }
    }
}
