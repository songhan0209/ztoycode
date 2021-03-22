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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }
        string loginID;
        public static   int classId;
        public TeacherForm(string id)
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

        private void TeacherForm_Load(object sender, EventArgs e)
        {

            // 显示登录用户的信息
            this.toolLabel_teacherName.Text = string.Format("教员{1}登录了！，系统当前时间：{0}  {2}",
                DateTime.Now.ToLongTimeString(), loginID, DateTime.Now.ToString("yyyy-MM-dd"));

            // 托盘图标显示
            this.notifyIcon1.Text = "用户名："+loginID+"\r\n"+"类型：教员";

            string str = LoginForm.str;
            string sql = string.Format("select ClassId,ClassName from Class  ");
            SqlDataReader dr = null;
            try
            {
                dr = DBHelper.getReader(sql);
                comboBox1.Items.Clear();
                while (dr.Read())
                {
                    Class lass = new Class();
                    lass.ClassId = (int)dr[0];
                    lass.ClassName = dr[1].ToString();
                    this.comboBox1.Items.Add(lass);
                }
            }
            catch
            {
                MessageBox.Show("加载班级信息失败!", "BF-TECH在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close(); 

            }

           
           

        }

       


        
        #region 刷新列表
        private void SelecteTable()
            {
            string str = LoginForm.str;
            int cl = classId;
            string conString = "server=.;database=MySchool;uid=sa;pwd=123;";
            SqlConnection conn = new SqlConnection(conString);
            //创建SqlDataAdapter对象s
            SqlDataAdapter s = new SqlDataAdapter(" select * from StudeScore  where  TeacherName in (select distinct TeacherName  from Teacher,Teacherjiaoxuebiao where Teacher.TeacherId=Teacherjiaoxuebiao.TeacherId and Teacher.LoginId ='" + str + "'  and  Teacherjiaoxuebiao.ClassId=" + cl + " ) ", conn);
            //DataTable data = DBHelper.getTable(s, conn);
            //创建DataSet对象d
            DataSet d = new DataSet();
            //使用fill方法填充DataSet
            s.Fill(d, "t");
            //在DataGridView1控件中显示表t
            this.dataGridView1.DataSource = d.Tables["t"];

        }
        #endregion

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

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 获取当前选中单元格所在行的学生编号
            if (MessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string indexID = this.dataGridView1.CurrentRow.Cells["StudentId"].Value.ToString();
                string sql = string.Format("delete from Student where StudentId='{0}'", indexID);
                bool result = DBHelper.ExecuteNonQuery(sql);
                if (result)
                {
                    MessageBox.Show("删除成功！");
                    this.SelecteTable();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertStudentForm insertStuForm = new insertStudentForm();
            insertStuForm.Show();
        }

        private void 打开主面板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        // 双击托盘图标，显示主界面
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 讨论交流ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1 .SelectedIndex == -1)
            {
                MessageBox.Show("请选择班级科目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1 .Focus();
            }
            else
            {
                classId = GetClassId();
                // 刷新列表
                this.SelecteTable();

                // 修改列名
                this.dataGridView1.Columns["StudentId"].HeaderText = "学生编号";
                this.dataGridView1.Columns["UserStateId"].HeaderText = "活动类型";
                this.dataGridView1.Columns["ClassName"].HeaderText = "班级名称";
                this.dataGridView1.Columns["GradeName"].HeaderText = "年级名称";
                this.dataGridView1.Columns["SubjectName"].HeaderText = "科目名称";
                this.dataGridView1.Columns["Score"].HeaderText = "成绩";
                this.dataGridView1.Columns["StudentNO"].HeaderText = "学号";
                this.dataGridView1.Columns["StudentName"].HeaderText = "姓名";
                this.dataGridView1.Columns["Sex"].HeaderText = "性别";
                this.dataGridView1.Columns["Major"].HeaderText = "系别";
                this.dataGridView1.Columns["TeacherName"].HeaderText = "任课教师";

            }
            
        }
        #region 获得选中班级的Id
        private int GetClassId()
        {

            object item = comboBox1.SelectedItem;
            if (item != null)
            {
                Class lass = item as Class;
                return lass.ClassId;
            }
            else
                return -1;

        }

        #endregion
    }
}
