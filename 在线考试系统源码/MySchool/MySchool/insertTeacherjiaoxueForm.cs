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
    public partial class insertTeacherjiaoxueForm : Form
    {
        public insertTeacherjiaoxueForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pp = insertTeacherForm.sttr;
            SqlConnection sqlcon = new SqlConnection("Data Source=localhost;Initial Catalog=MySchool;Integrated Security=True");
           // string   ear = string.Format("select TeacherId from Teacher where TeacherName='{0}'",pp );
            //int tt = Convert.ToInt16(ear);
            //SqlConnection sql = new SqlConnection("Data Source=localhost;Initial Catalog=MySchool;Integrated Security=True");
            sqlcon.Open();
            string st = "insert into  Teacherjiaoxuebiao(ClassId,GradeId,SubjectId,TeacherId) values (" + textBox8.Text + "," + textBox9.Text + "," + textBox11.Text + ",(select TeacherId from Teacher where TeacherName='"+pp+"'))";
            SqlCommand sqlco = new SqlCommand(st, sqlcon);
            int t = sqlco.ExecuteNonQuery();
            if (t > 0)
            {

                MessageBox.Show("添加成功");

                textBox8.Clear();//用户名
                textBox9.Clear(); //密码

                
                textBox11.Clear();//姓名

            }
            sqlcon.Close();



        }

        private void insertTeacherjiaoxueForm_Load(object sender, EventArgs e)
        {

        }
    }
}
