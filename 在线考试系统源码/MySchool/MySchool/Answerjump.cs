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
    public partial class Answerjump : Form
    {
        public Answerjump()
        {
            InitializeComponent();
        }
        public int qi;
        private void Answerjump_Load(object sender, EventArgs e)
        {
           
            this.timer1.Start();

            qi = AnswerCardForm.Helper.questionIndex;

            label1.Text = string.Format("问题{0}",qi+1  );
            string sql = "select Question,OptionA,OptionB,OptionC,OptionD from Question where questionId=" + QuizHelper.selectedQuestionIds[qi];
            SqlDataReader dr = DBHelper.getReader(sql); ;
            if (dr.Read())
            {
                label2 .Text = dr["Question"].ToString();
                radioButton1 .Text = string.Format("A.{0}", dr["OptionA"].ToString());
                radioButton2 .Text = string.Format("B.{0}", dr["OptionB"].ToString());
                radioButton3 .Text = string.Format("C:{0}", dr["OptionC"].ToString());
                radioButton4.Text = string.Format("D:{0}", dr["OptionD"].ToString());
            }
            dr.Close();
            CheckOption();
        }

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
                IbITimer.Text = string.Format("{0:00}:{1:00}", minute, second);
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


        #region 如果已经答了题目，选中相应的选项
        private void CheckOption()
        {
            switch (QuizHelper.studentAnswers[qi])
            {
                case "A":
                    radioButton1 .Checked = true;
                    break;
                case "B":
                    radioButton2 .Checked = true;
                    break;
                case "C":
                    radioButton3 .Checked = true;
                    break;
                case "D":
                    radioButton4 .Checked = true;
                    break;
                default:
                    radioButton1 .Checked = false;
                    radioButton2 .Checked = false;
                    radioButton3 .Checked = false;
                    radioButton4 .Checked = false;
                    break;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            AnswerCardForm  answerCardForm = new AnswerCardForm();
            answerCardForm.MdiParent = this.MdiParent;
            answerCardForm.Show();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            QuizHelper.studentAnswers[qi ] = radioButton1 .Tag.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            QuizHelper.studentAnswers[qi ] = radioButton2 .Tag.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            QuizHelper.studentAnswers[qi ] = radioButton3 .Tag.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            QuizHelper.studentAnswers[qi] = radioButton4.Tag.ToString();
        }

        private void IbITimer_Click(object sender, EventArgs e)
        {

        }
    }
}
