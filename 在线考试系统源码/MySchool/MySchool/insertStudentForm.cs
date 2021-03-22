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
    public partial class insertStudentForm : Form
    {
        public insertStudentForm()
        {
            InitializeComponent();
        }

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = this.textBox_user.Text;//用户名
            string pwd = this.textBox2.Text; //密码

            string studentNO = this.textBox_StudentNO.Text;//学号
            string studentName = this.textBox_StudentName.Text;//姓名
                                                               //int classNum = int.Parse (textBox_class.Text) ;//班级编号
            string sex = this.textBox_sex.Text;//性别
            string studentIDNO = this.textBox_StudentIDNO.Text;//身份证号
            string major = this.textBox_Major.Text;//专业
            string schoolBefore = this.textBox_SchoolBefore.Text;//学校地址
            string phone = this.textBox_phone.Text;//电话
            string address = this.textBox_addresss.Text;//住址
            string postalCode = this.textBox_PostalCode.Text;//邮政编码
            string cityWanted = this.textBox_JobWanted.Text;//市区
            string jobWanted = this.textBox_JobWanted.Text;//职位
            string comment = this.textBox_Comment.Text;//备注
            string email = this.textBox_Email.Text;//邮箱



            SqlConnection sqlcon = new SqlConnection("Data Source=localhost;Initial Catalog=MySchool;Integrated Security=True");
            sqlcon.Open();
            string str = "insert into  Student(LoginId,LoginPwd,UserStateId,ClassId,StudentNO,StudentName,Sex,StudentIDNO,Major,SchoolBefore,Phone,Address,PostalCode,CityWanted,JobWanted,Comment,Email ) values ('" + user + "','" + pwd + "'," + t + "," + textBox_class.Text + ",'" + studentNO + "','" + studentName + "','" + sex + "','" + studentIDNO + "','" + major + "','" + schoolBefore + "','" + phone + "','" + address + "','" + postalCode + "','" + cityWanted + "','" + jobWanted + "','" + comment + "','" + email + "')";
            SqlCommand sqlcom = new SqlCommand(str, sqlcon);
            int s = sqlcom.ExecuteNonQuery();
            if (s > 0)
            {

                MessageBox.Show("添加成功");

                textBox_user.Clear();//用户名
                textBox2.Clear(); //密码

                textBox_StudentNO.Clear();//学号
                textBox_StudentName.Clear();//姓名
                textBox_class.Clear();//班级编号
                textBox_sex.Clear();//性别
                textBox_StudentIDNO.Clear();//身份证号
                textBox_Major.Clear();//专业
                textBox_SchoolBefore.Clear();//学校地址
                textBox_phone.Clear();//电话
                textBox_addresss.Clear();//住址
                textBox_PostalCode.Clear();//邮政编码
                textBox_JobWanted.Clear();//市区
                textBox_JobWanted.Clear();//职位
                textBox_Comment.Clear();//备注
                textBox_Email.Clear();//邮箱

                findStudentForm studentForm = new findStudentForm();
                studentForm.Show();
                this.Close();


            }
            sqlcon.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
       
        int t;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { t = 1; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) { t=0; }
        }
        private void insertStudentForm_Load(object sender, EventArgs e)
        {
            


            



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
