namespace MySchool
{
    partial class SelecteQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecteQuestionForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dmButtonClose1 = new DMSkin.Controls.DMButtonClose();
            this.dmButtonMin1 = new DMSkin.Controls.DMButtonMin();
            this.label1 = new System.Windows.Forms.Label();
            this.dmLabel1 = new DMSkin.Controls.DMLabel();
            this.grpDescription = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picDescription = new System.Windows.Forms.PictureBox();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.btnBegin = new System.Windows.Forms.Button();
            this.lblSubjects = new System.Windows.Forms.Label();
            this.cboSubjects = new DMSkin.Metro.Controls.MetroComboBox();
            this.panel1.SuspendLayout();
            this.grpDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDescription)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(519, 27);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // dmButtonClose1
            // 
            this.dmButtonClose1.BackColor = System.Drawing.Color.Transparent;
            this.dmButtonClose1.Location = new System.Drawing.Point(489, 0);
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
            this.dmButtonMin1.Location = new System.Drawing.Point(458, 0);
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
            this.label1.Text = "试题选择";
            // 
            // dmLabel1
            // 
            this.dmLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dmLabel1.DM_Color = System.Drawing.Color.White;
            this.dmLabel1.DM_Font_Size = 18F;
            this.dmLabel1.DM_Key = DMSkin.Controls.DMLabelKey.用户;
            this.dmLabel1.DM_Text = "";
            this.dmLabel1.Location = new System.Drawing.Point(3, 1);
            this.dmLabel1.Name = "dmLabel1";
            this.dmLabel1.Size = new System.Drawing.Size(25, 24);
            this.dmLabel1.TabIndex = 0;
            this.dmLabel1.Text = "dmLabel1";
            // 
            // grpDescription
            // 
            this.grpDescription.Controls.Add(this.lblDescription);
            this.grpDescription.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpDescription.Location = new System.Drawing.Point(20, 169);
            this.grpDescription.Name = "grpDescription";
            this.grpDescription.Size = new System.Drawing.Size(479, 107);
            this.grpDescription.TabIndex = 18;
            this.grpDescription.TabStop = false;
            this.grpDescription.Text = "说明";
            this.grpDescription.Enter += new System.EventHandler(this.grpDescription_Enter);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDescription.Location = new System.Drawing.Point(40, 24);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(259, 75);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "1.所有题目均为单项选择题\r\n2.题量为20题\r\n3.答题时间为20分钟\r\n祝你好运！\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(188, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "考考自己，看学得怎么样！";
            // 
            // picDescription
            // 
            this.picDescription.Image = ((System.Drawing.Image)(resources.GetObject("picDescription.Image")));
            this.picDescription.Location = new System.Drawing.Point(150, 48);
            this.picDescription.Name = "picDescription";
            this.picDescription.Size = new System.Drawing.Size(32, 32);
            this.picDescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDescription.TabIndex = 16;
            this.picDescription.TabStop = false;
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGiveUp.Location = new System.Drawing.Point(424, 294);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(75, 23);
            this.btnGiveUp.TabIndex = 3;
            this.btnGiveUp.Text = "放弃";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBegin.Location = new System.Drawing.Point(342, 294);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 23);
            this.btnBegin.TabIndex = 2;
            this.btnBegin.Text = "开始答题";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // lblSubjects
            // 
            this.lblSubjects.AutoSize = true;
            this.lblSubjects.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSubjects.Location = new System.Drawing.Point(79, 121);
            this.lblSubjects.Name = "lblSubjects";
            this.lblSubjects.Size = new System.Drawing.Size(35, 14);
            this.lblSubjects.TabIndex = 12;
            this.lblSubjects.Text = "科目";
            // 
            // cboSubjects
            // 
            this.cboSubjects.DM_UseSelectable = true;
            this.cboSubjects.DropDownHeight = 90;
            this.cboSubjects.FormattingEnabled = true;
            this.cboSubjects.IntegralHeight = false;
            this.cboSubjects.ItemHeight = 24;
            this.cboSubjects.Items.AddRange(new object[] {
            "教员",
            "学员",
            "管理员"});
            this.cboSubjects.Location = new System.Drawing.Point(134, 114);
            this.cboSubjects.Name = "cboSubjects";
            this.cboSubjects.Size = new System.Drawing.Size(315, 30);
            this.cboSubjects.TabIndex = 1;
            // 
            // SelecteQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(519, 331);
            this.Controls.Add(this.cboSubjects);
            this.Controls.Add(this.grpDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picDescription);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.lblSubjects);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelecteQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "试题选择";
            this.Load += new System.EventHandler(this.SelecteQuestionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DMSkin.Controls.DMButtonClose dmButtonClose1;
        private DMSkin.Controls.DMButtonMin dmButtonMin1;
        private System.Windows.Forms.Label label1;
        private DMSkin.Controls.DMLabel dmLabel1;
        private System.Windows.Forms.GroupBox grpDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picDescription;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Label lblSubjects;
        private DMSkin.Metro.Controls.MetroComboBox cboSubjects;

    }
}