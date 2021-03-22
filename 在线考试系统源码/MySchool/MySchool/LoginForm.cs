using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MySchool
{
    public partial class LoginForm : Form
    {
        public static string str;
        public LoginForm()
        {
            InitializeComponent();
        }
        public  string loginType;//接收选择的登录类型
        public string loginID;

        private void dmButtonClose1_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }

        private void dmButtonMin1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//最小化窗体
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();//点击取消，关闭窗体
        }

        private void dmTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            txtLoginId.AutoSize = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        #region 拖动无边框窗体
        //定义一个坐标
        private Point p = new Point();

        //鼠标按下后获取坐标
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            p.X = e.X;
            p.Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-p.X, -p.Y);
                Location = myPosittion;
            }
        }
        #endregion

        #region“登录”按钮的单击事件
       
        DataTable data = null;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!chkInput()) return; //检查输入
            string sql = null;
            loginID = txtLoginId.Text.Trim();
            str = loginID;
            string loginPwd = txtLoginPwd.Text.Trim();
            loginType = txtLoginType.Text.Trim();
            if (loginType=="管理员")
            {
                sql = string.Format("select LoginId,LoginPwd from Admin where LoginId='{0}' and LoginPwd='{1}'", txtLoginId.Text, txtLoginPwd.Text);
                this.informationValidate(sql);
            }
            else if (loginType=="学员")
            {
                sql = string.Format("select LoginId,LoginPwd from Student where LoginId='{0}' and LoginPwd='{1}'", txtLoginId.Text, txtLoginPwd.Text);
                this.informationValidate(sql);
            }
            else if (loginType=="教员")
            {
                sql = string.Format("select LoginId,LoginPwd from Teacher where LoginId='{0}' and LoginPwd='{1}'", txtLoginId.Text, txtLoginPwd.Text);
                this.informationValidate(sql);
            }

            
        }

        
        #region 验证信息
        private void informationValidate(string sql)
        {
            data = DBHelper.getTable(sql);
            if (data.Rows.Count == 1)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (data.Rows.Count != 1)
            {
                MessageBox.Show("用户名或密码错误！请重新输入！");
                //输入密码错误，密码清空
                this.txtLoginPwd.Text = string.Empty;
                this.txtLoginPwd.Focus();
            }
        }
        #endregion

        #endregion

        #region 校验客户端的输入的合法性
        /// <summary>
        /// 校验客户端的输入的合法性
        /// </summary>
        /// <returns>true:合法，false:不合法</returns>
        private bool chkInput()
        {
            string accountId = txtLoginId.Text.Trim();//账号
            string pwd = txtLoginPwd.Text.Trim(); //密码

            if (accountId == "")
            {
                MessageBox.Show("帐号不允许为空!", "BF-TECH在线考试系统(V1.0)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (pwd == "")
            {
                MessageBox.Show("密码不允许为空!", "BF-TECH在线考试系统(V1.0)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string loginType = this.txtLoginType.Text.Trim(); //类型

            if (loginType == "")
            {
                MessageBox.Show("请选择登录类型!", "BF-TECH在线考试系统(V1.0)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        #endregion

        

        private void txtLoginId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
