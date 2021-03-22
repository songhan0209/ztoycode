using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchool
{
    public partial class AnswerCardForm : Form
    {

        
            public AnswerCardForm()
        {
            InitializeComponent();
        }
        public class Helper { public static int questionIndex; }

        private void dmButtonMin1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//最小化窗体
        }

        private void dmButtonClose1_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }

        private void AnswerCardForm_Load(object sender, EventArgs e)
        {
            this.timer1.Start();//启动计时器

            // 显示答案
            int index = 0;
            foreach (Control item in this.Controls)
            {
                if (item is Label)
                {
                    index = Convert.ToInt32(item.Tag);
                    if (index != -1)
                    {
                        item.Text = QuizHelper.studentAnswers[index];
                    }
                }
            }
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

        #region 交卷
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // 创建答题结果窗体并显示，关闭当前窗体
            QuizResultForm quizResultForm = new QuizResultForm();
            quizResultForm.MdiParent = this.MdiParent;
            quizResultForm.Show();
            this.Close();
        }
        #endregion
        
        #region 转到相应的题目
        private void btnQuestion_Click(object sender, EventArgs e)
        {
            Helper .questionIndex  = Convert.ToInt32(((Button)sender).Tag);



            Answerjump aj = new Answerjump();
           // answerQuestionForm.questionIndex = questionIndex;

            aj .MdiParent = this.MdiParent;
           aj.Show();
            this.Hide ();



        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }






        //answerQuestionForm.GetQuestionDetails();

        // answerQuestionForm.Hide ();
        //AnswerCardForm an = new AnswerCardForm();
        // an.Show();



        // this.Close();

    }
        #endregion

       
 }

