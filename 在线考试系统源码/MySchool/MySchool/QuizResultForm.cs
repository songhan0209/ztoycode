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
    public partial class QuizResultForm : Form
    {
        public static int scoreture;
        public QuizResultForm()
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//退出窗体
        }

        #region 显示得分
        private void QuizResultForm_Load(object sender, EventArgs e)
        {
            int correctNum = 0;
            for (int i = 0; i < QuizHelper.questionNum; i++)
            {
                if (QuizHelper.studentAnswers[i] == QuizHelper.correctAnswers[i])
                {
                    correctNum++;
                }
            }

            int score = correctNum * 100 / QuizHelper.questionNum;
            lblMark.Text = score.ToString() + "分";

            lblStudentScoreStrip.Width = lblFullMarkStrip.Width * score / 100;
            scoreture = score;
            if (score < 60)
            {
                lblComment.Text = "该好好复习了!";
                lblStudentScoreStrip.BackColor = Color.Red;
                picFace.Image = ilFaces.Images[0];
            }
            else if (score >= 60 && score < 85)
            {
                lblComment.Text = "还不错，继续努力!";
                lblStudentScoreStrip.BackColor = Color.Blue;
                picFace.Image = ilFaces.Images[1];
            }
            else if (score >= 85 && score < 100)
            {
                lblComment.Text = "真厉害，得优秀了!";
                lblStudentScoreStrip.BackColor = Color.CornflowerBlue;
                picFace.Image = ilFaces.Images[2];
            }
            else if (score == 100)
            {

                lblComment.Text = "哇赛，太厉害了，得满分了!";
                lblStudentScoreStrip.BackColor = Color.Green;
     
            }
            //public string loginID = LoginForm .txtLogin
            //StudentForm informationForm = new StudentForm(LoginForm .); ;


            string str = LoginForm.str;
            int subid = SelecteQuestionForm.subjectId;
  
            string conString = "server=.;database=MySchool;uid=sa;pwd=123;";
            SqlConnection conn = new SqlConnection(conString);
            //创建SqlDataAdapter对象s
            SqlDataAdapter s = new SqlDataAdapter("insert into StudentScore(LoginId,SubjectId,Score) values('" + str + "'," + subid + "," + score + ")", conn);
            //DataTable data = DBHelper.getTable(s, conn);
            //创建DataSet对象d
            DataSet d = new DataSet();
            //使用fill方法填充DataSet
            s.Fill(d, "t");
            
            

        }
        #endregion
       // string mt=StudentMainForm .m_fort .login 
        // Formzhu fu;
        // fu = (Formzhu) this.Owner;
       // LoginForm  f = (LoginForm )Owner;
        //这样就可以获得f 窗体textBox1的值
        //string path = f.txtLoginId.Text.Trim();

       // LoginForm st =new LoginForm()  ;
        //public string s = st.loginID;
        //SelecteQuestionForm m = new SelecteQuestionForm();
       // public int q=m.subjectId;



        private void picFace_Click(object sender, EventArgs e)
        {

        }

        
        

    }
}
