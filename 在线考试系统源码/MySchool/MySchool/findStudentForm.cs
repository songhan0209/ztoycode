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
    public partial class findStudentForm : Form
    {
        public findStudentForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void findStudentForm_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = "server=.;database=MySchool;uid=sa;pwd=123;";
            SqlConnection conn = new SqlConnection(conString);
            //创建SqlDataAdapter对象s
            SqlDataAdapter s = new SqlDataAdapter(" select * from Student where StudentName   like '%" + textBox1.Text + "%' ", conn);
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
