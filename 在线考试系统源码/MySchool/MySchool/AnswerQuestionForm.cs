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
    public partial class AnswerQuestionForm : Form
    {
        public AnswerQuestionForm()
        {
            InitializeComponent();
        }
        public int subjectId;
        public AnswerQuestionForm(int id)
        {
            this.subjectId = id;
            InitializeComponent();
        }
        public int questionIndex = 0;  // 当前的问题对应的数组索引
        public static SqlConnection connection = new SqlConnection(DBHelper.conString);

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

        #region 计时器Tick事件
        private void timer1_Tick(object sender, EventArgs e)
        {
            int minute;   // 当前的分钟
            int second;   // 秒

            // 如果还有剩余时间，就显示剩余的分钟和秒数
            if (QuizHelper.remainSeconds > 0)
            {
                QuizHelper.remainSeconds--;
                minute = QuizHelper.remainSeconds / 60;
                second = QuizHelper.remainSeconds % 60;
                lblTimer.Text = string.Format("{0:00}:{1:00}", minute, second);
            }
            // 否则，就提示交卷
            else
            {
                timer1.Stop();
                MessageBox.Show("时间到了，该交卷了！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                QuizResultForm quizResultForm = new QuizResultForm();
                quizResultForm.MdiParent = this.MdiParent;
                quizResultForm.Show();
                this.Close();
            }
        }
        #endregion

        #region 获取题目和答案
        private void AnswerQuestionForm_Load(object sender, EventArgs e)
        {
            //启动计时器，开始倒计时
            timer1.Start();

            // 该科目问题总数
            int allQuestionCount = GetQuestionCount(subjectId);

            // 指定所有问题数组的长度                
            QuizHelper.allQuestionIds = new int[allQuestionCount];

            // 指定记录问题是否选中的数组的长度
            QuizHelper.selectedStates = new bool[allQuestionCount];

            // 为所有问题数组元素赋值
            SetAllQuestionIds(subjectId);

            // 抽题
            SetSelectedQuestionIds();

            // 取出标准答案
            SetRightAnswers();

            // 剩余时间为20分钟
            QuizHelper.remainSeconds = 1200;

            // 将学生答案数组初始化
            for (int i = 0; i < QuizHelper.studentAnswers.Length; i++)
            {
                QuizHelper.studentAnswers[i] = "未回答";
            }
            GetQuestionDetails();
        }

        // 获得对应科目的题目的总数
        private static int GetQuestionCount(int subjectId)
        {
            //TODO:获得对应科目的题目的总数,尚未实现
            // return -1;
            string strsql = "select count(*) from Question where SubjectId=" + subjectId;
            SqlCommand comm = new SqlCommand(strsql, connection);
            try
            {
                connection.Open();
                return (int)comm.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                connection.Close();
            }
        }


        // 获得某科目所有问题的Id
        private void SetAllQuestionIds(int subjectId)
        {
            //TODO:获得某科目所有问题的Id,尚未实现
            string sql = "select QuestionId from Question where subjectId=" + subjectId;
            SqlDataReader dr = DBHelper.getReader(sql); ;
            try
            {
                int i = 0;
                while (dr.Read())
                {
                    QuizHelper.allQuestionIds[i] = (int)dr[0];
                    QuizHelper.selectedStates[i] = false;
                    i++;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dr.Close();
            }
        }

        // 抽取试题
        private void SetSelectedQuestionIds()
        {
            Random random = new Random();
            int questionIndex = 0; //随机产生问题的索引值
            int i = 0;
            while (i < QuizHelper.questionNum)
            {
                questionIndex = random.Next(QuizHelper.allQuestionIds.Length);
                if (QuizHelper.selectedStates[questionIndex] == false)
                {
                    QuizHelper.selectedQuestionIds[i] = QuizHelper.allQuestionIds[questionIndex];
                    QuizHelper.selectedStates[questionIndex] = true;
                    i++;
                }
            }

        }

        // 取出试题的标准答案
        private void SetRightAnswers()
        {
            //取出该科目下试题的答案，并存入数组
            for (int i = 0; i < QuizHelper.selectedQuestionIds.Length; i++)
            {
                int questionId = QuizHelper.selectedQuestionIds[i];
                QuizHelper.correctAnswers[i] = this.GetAnswerByQuestionId(questionId);

            }
        }
        /// <summary>
        /// 根据题目编号得题目答案
        /// </summary>
        /// <param name="questionId"></param>
        /// <returns></returns>
        private string GetAnswerByQuestionId(int questionId)
        {
            string ID = null;
            string sql = string.Format("select Answer from Question where questionId={0}", questionId);
            SqlDataReader dr = DBHelper.getReader(sql);
            if (dr.Read())
            {
                ID = dr["Answer"].ToString();
            }
            dr.Close();
            return ID;
        }
        #endregion

        #region 显示题目并进行答题

        #region 单击“下一题”按钮时，为答案数组赋值，并显示下一题的信息
        private void btnNext_Click(object sender, EventArgs e)
        {
            // 如果没有到最后一题，就继续显示新题目信息
            if (questionIndex < QuizHelper.selectedQuestionIds.Length - 1)
            {
                questionIndex++;

                GetQuestionDetails();  // 显示试题信息
                CheckOption();         // 如果题目已经答过，让相应的选项选中    
                // 如果达到20题，就让“下一题”按钮的文字显示为“检查答案”
                if (questionIndex >= QuizHelper.selectedQuestionIds.Length - 1)
                {
                    btnNext.Text = "检查答案";
                }
            }
            else  // 否则，打开答题卡窗体
            {
                OpenAnswerCard();
            }
        }
        #endregion

        // 打开答题卡窗体
        private void OpenAnswerCard()
        {
            AnswerCardForm answerCardForm = new AnswerCardForm();
            answerCardForm.MdiParent = this.MdiParent;
            answerCardForm.Show();
            this.Close();
        }
        private void btnAnswerCard_Click(object sender, EventArgs e)
        {
            OpenAnswerCard();
        }

        #region 根据问题的Id，显示题目的详细信息
        public void GetQuestionDetails()
        {
            lblQuestion.Text = string.Format("问题{0}", questionIndex + 1);
            string sql = "select Question,OptionA,OptionB,OptionC,OptionD from Question where questionId=" + QuizHelper.selectedQuestionIds[questionIndex];
            SqlDataReader dr = DBHelper.getReader(sql); ;
            if (dr.Read())
            {
                lblQuestionDetails.Text = dr["Question"].ToString();
                rdoOptionA.Text = string.Format("A.{0}", dr["OptionA"].ToString());
                rdoOptionB.Text = string.Format("B.{0}", dr["OptionB"].ToString());
                rdoOptionC.Text = string.Format("C:{0}", dr["OptionC"].ToString());
                rdoOptionD.Text = string.Format("D:{0}", dr["OptionD"].ToString());
            }
            dr.Close();
        }
        #endregion

        // 选项单选按钮的单击事件处理，选择答案时，记录答案
        private void rdoOption_Click(object sender, EventArgs e)
        {
            QuizHelper.studentAnswers[questionIndex] = ((RadioButton)sender).Tag.ToString();
        }
        #region 如果已经答了题目，选中相应的选项
        private void CheckOption()
        {
            switch (QuizHelper.studentAnswers[questionIndex])
            {
                case "A":
                    rdoOptionA.Checked = true;
                    break;
                case "B":
                    rdoOptionB.Checked = true;
                    break;
                case "C":
                    rdoOptionC.Checked = true;
                    break;
                case "D":
                    rdoOptionD.Checked = true;
                    break;
                default:
                    rdoOptionA.Checked = false;
                    rdoOptionB.Checked = false;
                    rdoOptionC.Checked = false;
                    rdoOptionD.Checked = false;
                    break;
            }
        }
        #endregion

        #endregion

        private void rdoOptionB_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
