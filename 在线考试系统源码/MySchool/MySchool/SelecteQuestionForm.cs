using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MySchool
{

    public partial class SelecteQuestionForm : Form
    {
        public static int subjectId;
        public SelecteQuestionForm()
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

        #region 放弃答题，退出应用程序
        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要放弃此次答题测试吗？", "BF-TECH在线考试系统", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

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

        private void SelecteQuestionForm_Load(object sender, EventArgs e)
        {
            string str = LoginForm.str;
            string sql = string.Format("select Subject.SubjectId,Subject.SubjectName,Subject.Hours,Subject.GradeId from Student,Class,Subject,Grade where Student.LoginId='"+str+"' and Student.ClassId=Class.ClassId and Class.GradeId=Grade.GradeId  and  Grade.GradeId=Subject.GradeId ");
            SqlDataReader dr = null;
            try
            {
                dr = DBHelper.getReader(sql);
                cboSubjects.Items.Clear();
                while (dr.Read())
                {
                    Subject subject = new Subject();
                    subject.SubjectId = (int)dr[0];
                    subject.SubjectName = dr[1].ToString();
                    this.cboSubjects.Items.Add(subject);
                }
            }
            catch
            {
                MessageBox.Show("加载课程科目信息失败!", "BF-TECH在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();

            }
        }
        

        #region 点击开始答题，进入答题窗体
        private void btnBegin_Click(object sender, EventArgs e)
        {
            //如果没有选择科目点击开始答题，系统会提示“请选择科目”，才能答题
            if (cboSubjects.SelectedIndex == -1)
            {
                MessageBox.Show("请选择科目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSubjects.Focus();
            }
            else
            {
                // 获得选中科目的Id
                 subjectId = GetSubjectId();
                string str = LoginForm.str;
                string sql = string.Format("select * from StudentScore where LoginId='"+str +"' and SubjectId="+subjectId +" ");
                SqlDataReader dr = null;
               
                    dr = DBHelper.getReader(sql);
                    if  (!dr.Read() )
                        
                { // 剩余时间为20分钟
                    QuizHelper.remainSeconds = 1200;
                    AnswerQuestionForm answerQuestion = new AnswerQuestionForm(subjectId);
                    answerQuestion.MdiParent = this.MdiParent;
                    answerQuestion.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("不能重复选择已答完科目，请重新选择！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboSubjects  .Focus();
                }

            }
        }
        #endregion

        #region 获得选中科目的Id
        private int  GetSubjectId()
        {

            string srr = cboSubjects.Text;
            string conString = "server=.;database=MySchool;uid=sa;pwd=123;";
            int a;
            string    num =null;
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            string sql = string.Format("select SubjectId from Subject where SubjectName='{0}'", srr );
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read ()) { num = dr["LoginId"].ToString();  }
            a = int.Parse(num);
            return a;
        }

        #endregion

        private void grpDescription_Enter(object sender, EventArgs e)
        {

        }
    }
}
