namespace MySchool
{
    partial class AnswerQuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnswerQuestionForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dmButtonClose1 = new DMSkin.Controls.DMButtonClose();
            this.dmButtonMin1 = new DMSkin.Controls.DMButtonMin();
            this.label1 = new System.Windows.Forms.Label();
            this.dmLabel1 = new DMSkin.Controls.DMLabel();
            this.btnAnswerCard = new System.Windows.Forms.Button();
            this.rdoOptionD = new System.Windows.Forms.RadioButton();
            this.rdoOptionC = new System.Windows.Forms.RadioButton();
            this.rdoOptionB = new System.Windows.Forms.RadioButton();
            this.rdoOptionA = new System.Windows.Forms.RadioButton();
            this.lblQuestionDetails = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::MySchool.Properties.Resources.desktop2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dmButtonClose1);
            this.panel1.Controls.Add(this.dmButtonMin1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dmLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 27);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // dmButtonClose1
            // 
            this.dmButtonClose1.BackColor = System.Drawing.Color.Transparent;
            this.dmButtonClose1.Location = new System.Drawing.Point(562, 1);
            this.dmButtonClose1.MaximumSize = new System.Drawing.Size(30, 27);
            this.dmButtonClose1.MinimumSize = new System.Drawing.Size(30, 27);
            this.dmButtonClose1.Name = "dmButtonClose1";
            this.dmButtonClose1.Size = new System.Drawing.Size(30, 27);
            this.dmButtonClose1.TabIndex = 3;
            this.dmButtonClose1.Click += new System.EventHandler(this.dmButtonClose1_Click);
            // 
            // dmButtonMin1
            // 
            this.dmButtonMin1.BackColor = System.Drawing.Color.Transparent;
            this.dmButtonMin1.Location = new System.Drawing.Point(531, 1);
            this.dmButtonMin1.Name = "dmButtonMin1";
            this.dmButtonMin1.Size = new System.Drawing.Size(30, 27);
            this.dmButtonMin1.TabIndex = 4;
            this.dmButtonMin1.Click += new System.EventHandler(this.dmButtonMin1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "回答问题";
            // 
            // dmLabel1
            // 
            this.dmLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dmLabel1.DM_Color = System.Drawing.Color.White;
            this.dmLabel1.DM_Font_Size = 18F;
            this.dmLabel1.DM_Key = DMSkin.Controls.DMLabelKey.铅笔;
            this.dmLabel1.DM_Text = "";
            this.dmLabel1.Location = new System.Drawing.Point(3, 1);
            this.dmLabel1.Name = "dmLabel1";
            this.dmLabel1.Size = new System.Drawing.Size(25, 24);
            this.dmLabel1.TabIndex = 0;
            this.dmLabel1.Text = "dmLabel1";
            // 
            // btnAnswerCard
            // 
            this.btnAnswerCard.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAnswerCard.Location = new System.Drawing.Point(335, 38);
            this.btnAnswerCard.Name = "btnAnswerCard";
            this.btnAnswerCard.Size = new System.Drawing.Size(103, 23);
            this.btnAnswerCard.TabIndex = 22;
            this.btnAnswerCard.Text = "答题卡";
            this.btnAnswerCard.UseVisualStyleBackColor = true;
            this.btnAnswerCard.Click += new System.EventHandler(this.btnAnswerCard_Click);
            // 
            // rdoOptionD
            // 
            this.rdoOptionD.AutoSize = true;
            this.rdoOptionD.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoOptionD.Location = new System.Drawing.Point(87, 293);
            this.rdoOptionD.Name = "rdoOptionD";
            this.rdoOptionD.Size = new System.Drawing.Size(39, 18);
            this.rdoOptionD.TabIndex = 21;
            this.rdoOptionD.TabStop = true;
            this.rdoOptionD.Tag = "D";
            this.rdoOptionD.Text = "D.";
            this.rdoOptionD.UseVisualStyleBackColor = true;
            this.rdoOptionD.Click += new System.EventHandler(this.rdoOption_Click);
            // 
            // rdoOptionC
            // 
            this.rdoOptionC.AutoSize = true;
            this.rdoOptionC.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoOptionC.Location = new System.Drawing.Point(87, 269);
            this.rdoOptionC.Name = "rdoOptionC";
            this.rdoOptionC.Size = new System.Drawing.Size(39, 18);
            this.rdoOptionC.TabIndex = 20;
            this.rdoOptionC.TabStop = true;
            this.rdoOptionC.Tag = "C";
            this.rdoOptionC.Text = "C.";
            this.rdoOptionC.UseVisualStyleBackColor = true;
            this.rdoOptionC.Click += new System.EventHandler(this.rdoOption_Click);
            // 
            // rdoOptionB
            // 
            this.rdoOptionB.AutoSize = true;
            this.rdoOptionB.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoOptionB.Location = new System.Drawing.Point(87, 245);
            this.rdoOptionB.Name = "rdoOptionB";
            this.rdoOptionB.Size = new System.Drawing.Size(39, 18);
            this.rdoOptionB.TabIndex = 19;
            this.rdoOptionB.TabStop = true;
            this.rdoOptionB.Tag = "B";
            this.rdoOptionB.Text = "B.";
            this.rdoOptionB.UseVisualStyleBackColor = true;
            this.rdoOptionB.CheckedChanged += new System.EventHandler(this.rdoOptionB_CheckedChanged);
            this.rdoOptionB.Click += new System.EventHandler(this.rdoOption_Click);
            // 
            // rdoOptionA
            // 
            this.rdoOptionA.AutoSize = true;
            this.rdoOptionA.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoOptionA.Location = new System.Drawing.Point(87, 221);
            this.rdoOptionA.Name = "rdoOptionA";
            this.rdoOptionA.Size = new System.Drawing.Size(39, 18);
            this.rdoOptionA.TabIndex = 18;
            this.rdoOptionA.TabStop = true;
            this.rdoOptionA.Tag = "A";
            this.rdoOptionA.Text = "A.";
            this.rdoOptionA.UseVisualStyleBackColor = true;
            this.rdoOptionA.Click += new System.EventHandler(this.rdoOption_Click);
            // 
            // lblQuestionDetails
            // 
            this.lblQuestionDetails.BackColor = System.Drawing.Color.White;
            this.lblQuestionDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestionDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuestionDetails.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQuestionDetails.Location = new System.Drawing.Point(30, 78);
            this.lblQuestionDetails.Name = "lblQuestionDetails";
            this.lblQuestionDetails.Size = new System.Drawing.Size(536, 126);
            this.lblQuestionDetails.TabIndex = 17;
            // 
            // lblTimer
            // 
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimer.Location = new System.Drawing.Point(459, 38);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(107, 21);
            this.lblTimer.TabIndex = 16;
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.Location = new System.Drawing.Point(332, 328);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(234, 27);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "下一题";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAnswer.Location = new System.Drawing.Point(27, 223);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(49, 14);
            this.lblAnswer.TabIndex = 14;
            this.lblAnswer.Text = "答案：";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQuestion.Location = new System.Drawing.Point(27, 45);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(56, 14);
            this.lblQuestion.TabIndex = 13;
            this.lblQuestion.Text = "问题1：";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AnswerQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 369);
            this.Controls.Add(this.btnAnswerCard);
            this.Controls.Add(this.rdoOptionD);
            this.Controls.Add(this.rdoOptionC);
            this.Controls.Add(this.rdoOptionB);
            this.Controls.Add(this.rdoOptionA);
            this.Controls.Add(this.lblQuestionDetails);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnswerQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "回答问题";
            this.Load += new System.EventHandler(this.AnswerQuestionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DMSkin.Controls.DMButtonClose dmButtonClose1;
        private DMSkin.Controls.DMButtonMin dmButtonMin1;
        private System.Windows.Forms.Label label1;
        private DMSkin.Controls.DMLabel dmLabel1;
        private System.Windows.Forms.Button btnAnswerCard;
        private System.Windows.Forms.RadioButton rdoOptionD;
        private System.Windows.Forms.RadioButton rdoOptionC;
        private System.Windows.Forms.RadioButton rdoOptionB;
        private System.Windows.Forms.RadioButton rdoOptionA;
        private System.Windows.Forms.Label lblQuestionDetails;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblAnswer;
        public System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Timer timer1;
    }
}