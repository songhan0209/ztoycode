using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchool
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        string loginID;
        public AdminForm(string id)
        {
            this.loginID = id;
            InitializeComponent();
        }
        private void dmButtonMin1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//最小化窗体
        }

        private void dmButtonClose1_Click(object sender, EventArgs e)
        {
            this.Hide();//隐藏窗体
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

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“mySchoolDataSet1.Student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.mySchoolDataSet1.Student);
            // 显示登录用户的信息
            this.toolLabel_teacherName.Text = string.Format("管理员{1}登录了！，系统当前时间：{0}  {2}",
                DateTime.Now.ToLongTimeString(), loginID, DateTime.Now.ToString("yyyy-MM-dd"));

            // 托盘图标显示
            this.notifyIcon1.Text = "用户名：" + loginID + "\r\n" + "类型：管理员";
            this.SelectTable();
            
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private  void SelectTable()
        {
            string str = LoginForm.str;

            string conString = "server=.;database=MySchool;uid=sa;pwd=123;";
            SqlConnection conn = new SqlConnection(conString);
            //创建SqlDataAdapter对象s
            SqlDataAdapter s = new SqlDataAdapter(" select * from Teacher,Teacherjiaoxuebiao where Teacher.TeacherId=Teacherjiaoxuebiao.TeacherId ", conn);
            //DataTable data = DBHelper.getTable(s, conn);
            //创建DataSet对象d
            DataSet d = new DataSet();
            //使用fill方法填充DataSet
            s.Fill(d, "t");
            //在DataGridView1控件中显示表t
            this.dataGridView3.DataSource = d.Tables["t"];
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void 打开主面板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // 获取当前选中单元格所在行的学生编号
            if (MessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string indexID = this.dataGridView2.CurrentRow.Cells["StudentId"].Value.ToString();
                string sql = string.Format("delete from Student where StudentId='{0}'", indexID);
                bool result = DBHelper.ExecuteNonQuery(sql);
                if (result)
                {
                    MessageBox.Show("删除成功！");
                    this.SelectTable();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }

        private void 新增ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            insertStudentForm insertStuForm = new insertStudentForm();
            insertStuForm.Show();
        }


        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findStudentForm findStudent = new findStudentForm();
            findStudent.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 新增ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            insertTeacherForm insertTeacherForm = new insertTeacherForm();
            insertTeacherForm .Show();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 获取当前选中单元格所在行的学生编号
            if (MessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string indexID = this.dataGridView3.CurrentRow.Cells["TeacherId"].Value.ToString();
                string sql = string.Format("delete from Teacher where TeacherId='{0}'", indexID);
                bool result = DBHelper.ExecuteNonQuery(sql);
                if (result)
                {
                    MessageBox.Show("删除成功！");
                    
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }

                string sq = string.Format("delete from Teacherjiaoxuebiao where TeacherId='{0}'", indexID);
                bool re = DBHelper.ExecuteNonQuery(sq );
                if (re)
                {
                    MessageBox.Show("删除成功！");
                    this.SelectTable();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }

            }
        }

        private void 查找ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            findTeacherForm findTeacherForm = new findTeacherForm();
            findTeacherForm.Show();

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView3 .DataSource =null;


            string conString = "server=.;database=MySchool;uid=sa;pwd=123;";
            SqlConnection conn = new SqlConnection(conString);
            //创建SqlDataAdapter对象s
            SqlDataAdapter s = new SqlDataAdapter(" select * from Teacher,Teacherjiaoxuebiao where Teacher.TeacherId=Teacherjiaoxuebiao.TeacherId ", conn);
            //DataTable data = DBHelper.getTable(s, conn);
            //创建DataSet对象d
            DataSet d = new DataSet();
            //使用fill方法填充DataSet
            s.Fill(d, "t");
            //在DataGridView1控件中显示表t
            this  .dataGridView3.DataSource = d.Tables["t"];

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
