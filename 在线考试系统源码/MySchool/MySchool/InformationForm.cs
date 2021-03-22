using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MySchool
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        #region 构造方法
        //登录的账号
        private string loginID = null;
        //构造方法，从登录窗体获取登录的账号
        public StudentForm(string ID)
        {
            this.loginID = ID;
            InitializeComponent();
        }
        #endregion

        private void dmButtonMin1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//最小化窗体
        }

        private void dmButtonClose1_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
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

        #region 窗体加载，在相对应的文本框中显示信息
        private void StudentForm_Load(object sender, EventArgs e)
        {
            string user = null;//用户名
            string studentNO = null;//学号
            string studentName = null;//姓名
            string classNum = null;//班级编号
            string sex = null;//性别
            string studentIDNO = null;//身份证号
            string major = null;//专业
            string schoolBefore = null;//学校地址
            string phone = null;//电话
            string address = null;//住址
            string postalCode = null;//邮政编码
            string cityWanted = null;//市区
            string jobWanted = null;//职位
            string comment = null;//备注
            string email = null;//邮箱
            string conString = "server=.;database=MySchool;uid=sa;pwd=123;";
            SqlConnection conn = new SqlConnection(conString);
            conn.Open(); 
            string sql = string.Format("select LoginId,StudentNO,StudentName,ClassId,Sex,StudentIDNO,Major,SchoolBefore,Phone,Address,PostalCode,CityWanted,JobWanted,Comment,Email from Student where LoginId='{0}'", loginID);
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    user = dr["LoginId"].ToString();
                    studentNO = dr["StudentNO"].ToString();
                    studentName = dr["StudentName"].ToString();
                    classNum = dr["ClassId"].ToString();
                    sex = dr["Sex"].ToString();
                    studentIDNO = dr["StudentIDNO"].ToString();
                    major = dr["Major"].ToString();
                    schoolBefore = dr["SchoolBefore"].ToString();
                    phone = dr["Phone"].ToString();
                    address = dr["Address"].ToString();
                    postalCode = dr["PostalCode"].ToString();
                    cityWanted = dr["CityWanted"].ToString();
                    jobWanted = dr["JobWanted"].ToString();
                    comment = dr["Comment"].ToString();
                    email = dr["Email"].ToString();
                }
                this.textBox_user.Text = user;
                this.textBox_StudentNO.Text = studentNO;
                this.textBox_StudentName.Text = studentName;
                this.textBox_class.Text = classNum;
                this.textBox_sex.Text = sex;
                this.textBox_StudentIDNO.Text = studentIDNO;
                this.textBox_Major.Text = major;
                this.textBox_SchoolBefore.Text = schoolBefore;
                this.textBox_phone.Text = phone;
                this.textBox_addresss.Text = address;
                this.textBox_PostalCode.Text = postalCode;
                this.textBox_CityWanted.Text = cityWanted;
                this.textBox_JobWanted.Text = jobWanted;
                this.textBox_Comment.Text = comment;
                this.textBox_Email.Text = email;
            }
            catch
            {

                MessageBox.Show("加载课程个人信息失败!", "BF-TECH在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
            conn.Close();
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_StudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
