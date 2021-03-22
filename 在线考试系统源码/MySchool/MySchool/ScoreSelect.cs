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
    public partial class ScoreSelect : Form
    {
        public ScoreSelect()
        {
            InitializeComponent();
        }


        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ScoreSelect_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“mySchoolDataSet.StudeScore”中。您可以根据需要移动或删除它。
            //this.studeScoreTableAdapter.Fill(this.mySchoolDataSet.StudeScore);
            

            string str = LoginForm.str;
            int subid = SelecteQuestionForm.subjectId;
            int score = QuizResultForm.scoreture;
            string conString = "server=.;database=MySchool;uid=sa;pwd=123;";
            SqlConnection conn = new SqlConnection(conString);
            //创建SqlDataAdapter对象s
            SqlDataAdapter s = new SqlDataAdapter("select * from StudeScore where StudentId=(select StudentId from Student where  LoginId='"+str+"')", conn);
            //DataTable data = DBHelper.getTable(s, conn);
            //创建DataSet对象d
            DataSet d = new DataSet();
            //使用fill方法填充DataSet
            s.Fill(d, "t");
            //在DataGridView1控件中显示表t
            this.dataGridView1.DataSource = d.Tables["t"];



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
}
