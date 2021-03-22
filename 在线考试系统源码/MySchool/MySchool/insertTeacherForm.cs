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
    
    public partial class insertTeacherForm : Form
    {
        public insertTeacherForm()
        {
            InitializeComponent();
        }
        public static string sttr;
        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection sqlcon = new SqlConnection("Data Source=localhost;Initial Catalog=MySchool;Integrated Security=True");
            sqlcon.Open();
            string str = "insert into  Teacher(LoginId,LoginPwd,UserStateId,TeacherName,Sex,Birthday,SubjectId) values ('" + textBox1 .Text  + "','" + textBox2 .Text  + "'," + textBox3 .Text  + ",'" + textBox4 .Text + "','" + textBox5 .Text  + "','" + textBox6 .Text  + "'," + textBox7 .Text  + ")";
            sttr = textBox4.Text.ToString();
            SqlCommand sqlcom = new SqlCommand(str, sqlcon);
            int s = sqlcom.ExecuteNonQuery();
            if (s > 0)
            {

                MessageBox.Show("添加成功");

                textBox1.Clear();//用户名
                textBox2.Clear(); //密码

                textBox3.Clear();//学号
                textBox4.Clear();//姓名
                textBox5.Clear();//班级编号
                textBox6.Clear();//性别
                textBox7.Clear();//身份证号
             }
            sqlcon.Close();


           






            

        }

        private void insertTeacherForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            insertTeacherjiaoxueForm insertTeacherjiaoxueForm = new insertTeacherjiaoxueForm();
            insertTeacherjiaoxueForm.Show();
            this.Close();
        }
    }
}
