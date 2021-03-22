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
    public partial class findTeacherForm : Form
    {
        public findTeacherForm()
        {
            InitializeComponent();
        }

        private void findTeacherForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = "server=.;database=MySchool;uid=sa;pwd=123;";
            SqlConnection conn = new SqlConnection(conString);
            //创建SqlDataAdapter对象s
            SqlDataAdapter s = new SqlDataAdapter(" select * from Teacher,Teacherjiaoxuebiao where   Teacher.TeacherId=Teacherjiaoxuebiao.TeacherId  and TeacherName   like '%" + textBox1.Text + "%' ", conn);
            //DataTable data = DBHelper.getTable(s, conn);
            //创建DataSet对象d
            DataSet d = new DataSet();
            //使用fill方法填充DataSet
            s.Fill(d, "t");
            //在DataGridView1控件中显示表t
            this.dataGridView1.DataSource = d.Tables["t"];
        }
    }
}
