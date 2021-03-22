namespace MySchool
{
    partial class QuizResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizResultForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dmButtonClose1 = new DMSkin.Controls.DMButtonClose();
            this.dmButtonMin1 = new DMSkin.Controls.DMButtonMin();
            this.label1 = new System.Windows.Forms.Label();
            this.dmLabel1 = new DMSkin.Controls.DMLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.lblMark = new System.Windows.Forms.Label();
            this.lbl100 = new System.Windows.Forms.Label();
            this.lblFullMarkStrip = new System.Windows.Forms.Label();
            this.lblFullMark = new System.Windows.Forms.Label();
            this.lblStudentScoreStrip = new System.Windows.Forms.Label();
            this.lblStudentScore = new System.Windows.Forms.Label();
            this.ilFaces = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(548, 27);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // dmButtonClose1
            // 
            this.dmButtonClose1.BackColor = System.Drawing.Color.Transparent;
            this.dmButtonClose1.Location = new System.Drawing.Point(518, 0);
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
            this.dmButtonMin1.Location = new System.Drawing.Point(487, 0);
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
            this.label1.Text = "答题结果";
            // 
            // dmLabel1
            // 
            this.dmLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dmLabel1.DM_Color = System.Drawing.Color.White;
            this.dmLabel1.DM_Font_Size = 18F;
            this.dmLabel1.DM_Key = DMSkin.Controls.DMLabelKey.书签_A;
            this.dmLabel1.DM_Text = "";
            this.dmLabel1.Location = new System.Drawing.Point(3, 1);
            this.dmLabel1.Name = "dmLabel1";
            this.dmLabel1.Size = new System.Drawing.Size(25, 24);
            this.dmLabel1.TabIndex = 0;
            this.dmLabel1.Text = "dmLabel1";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(444, 331);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblComment.Location = new System.Drawing.Point(250, 105);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(0, 24);
            this.lblComment.TabIndex = 16;
            this.lblComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picFace
            // 
            this.picFace.Location = new System.Drawing.Point(98, 47);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(128, 128);
            this.picFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFace.TabIndex = 15;
            this.picFace.TabStop = false;
            this.picFace.Click += new System.EventHandler(this.picFace_Click);
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMark.Location = new System.Drawing.Point(417, 230);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(0, 14);
            this.lblMark.TabIndex = 14;
            this.lblMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl100.Location = new System.Drawing.Point(417, 265);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(42, 14);
            this.lbl100.TabIndex = 13;
            this.lbl100.Text = "100分";
            // 
            // lblFullMarkStrip
            // 
            this.lblFullMarkStrip.BackColor = System.Drawing.Color.Green;
            this.lblFullMarkStrip.Location = new System.Drawing.Point(101, 260);
            this.lblFullMarkStrip.Name = "lblFullMarkStrip";
            this.lblFullMarkStrip.Size = new System.Drawing.Size(300, 23);
            this.lblFullMarkStrip.TabIndex = 12;
            // 
            // lblFullMark
            // 
            this.lblFullMark.AutoSize = true;
            this.lblFullMark.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFullMark.Location = new System.Drawing.Point(53, 265);
            this.lblFullMark.Name = "lblFullMark";
            this.lblFullMark.Size = new System.Drawing.Size(49, 14);
            this.lblFullMark.TabIndex = 11;
            this.lblFullMark.Text = "满分：";
            // 
            // lblStudentScoreStrip
            // 
            this.lblStudentScoreStrip.BackColor = System.Drawing.Color.Red;
            this.lblStudentScoreStrip.Location = new System.Drawing.Point(101, 222);
            this.lblStudentScoreStrip.Name = "lblStudentScoreStrip";
            this.lblStudentScoreStrip.Size = new System.Drawing.Size(100, 23);
            this.lblStudentScoreStrip.TabIndex = 10;
            // 
            // lblStudentScore
            // 
            this.lblStudentScore.AutoSize = true;
            this.lblStudentScore.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStudentScore.Location = new System.Drawing.Point(29, 227);
            this.lblStudentScore.Name = "lblStudentScore";
            this.lblStudentScore.Size = new System.Drawing.Size(77, 14);
            this.lblStudentScore.TabIndex = 9;
            this.lblStudentScore.Text = "你的得分：";
            // 
            // ilFaces
            // 
            this.ilFaces.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilFaces.ImageStream")));
            this.ilFaces.TransparentColor = System.Drawing.Color.Transparent;
            this.ilFaces.Images.SetKeyName(0, "face1.png");
            this.ilFaces.Images.SetKeyName(1, "face2.png");
            this.ilFaces.Images.SetKeyName(2, "face3.png");
            this.ilFaces.Images.SetKeyName(3, "face4.png");
            // 
            // QuizResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 369);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.picFace);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.lbl100);
            this.Controls.Add(this.lblFullMarkStrip);
            this.Controls.Add(this.lblFullMark);
            this.Controls.Add(this.lblStudentScoreStrip);
            this.Controls.Add(this.lblStudentScore);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuizResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "答题结果";
            this.Load += new System.EventHandler(this.QuizResultForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DMSkin.Controls.DMButtonClose dmButtonClose1;
        private DMSkin.Controls.DMButtonMin dmButtonMin1;
        private System.Windows.Forms.Label label1;
        private DMSkin.Controls.DMLabel dmLabel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.Label lblFullMarkStrip;
        private System.Windows.Forms.Label lblFullMark;
        private System.Windows.Forms.Label lblStudentScoreStrip;
        private System.Windows.Forms.Label lblStudentScore;
        private System.Windows.Forms.ImageList ilFaces;
    }
}