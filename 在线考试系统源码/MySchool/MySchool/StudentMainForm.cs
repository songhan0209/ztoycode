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
    public partial class StudentMainForm : Form
    {
       
        public StudentMainForm()
        {
            InitializeComponent();
            
        }
        #region 构造方法
        //登录的账号
        private string loginID = null;
        
        //构造方法，从登录窗体获取登录的账号
        public StudentMainForm(string ID)
        {
            this.loginID = ID;
            InitializeComponent();
           

        }
        #endregion

        string LoginID()
        {
            return loginID;
        }
        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();

            // 托盘图标显示
            this.notifyIcon1.Text = "用户名：" + loginID + "\r\n" + "类型：学员";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            StudentForm informationForm = new StudentForm(loginID);
            informationForm.MdiParent = this;
            informationForm.Show();
        }

        #region 单击退出时，提示是否确认退出
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 弹出消息框向用户确认
            DialogResult result = MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // 如果选择了“是”，退出应用程序
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SelecteQuestionForm selecteQuestionForm = new SelecteQuestionForm();
            selecteQuestionForm.MdiParent = this;
            selecteQuestionForm.Show();
        }

        private void 在线答题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelecteQuestionForm selecteQuestionForm = new SelecteQuestionForm();
            selecteQuestionForm.MdiParent = this;
            selecteQuestionForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 打开主面板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolLabel_studentsName.Text = string.Format("学员{0}登录了！，系统当前时间：{1}",loginID, DateTime.Now.ToString());
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ScoreSelect  scoreselect = new ScoreSelect ();
            scoreselect .MdiParent = this;
            scoreselect .Show();
        }
    }
}
