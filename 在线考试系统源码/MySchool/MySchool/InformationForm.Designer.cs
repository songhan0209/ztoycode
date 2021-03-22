namespace MySchool
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dmButtonClose1 = new DMSkin.Controls.DMButtonClose();
            this.dmButtonMin1 = new DMSkin.Controls.DMButtonMin();
            this.label1 = new System.Windows.Forms.Label();
            this.dmLabel1 = new DMSkin.Controls.DMLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_sex = new System.Windows.Forms.TextBox();
            this.textBox_StudentName = new System.Windows.Forms.TextBox();
            this.textBox_StudentNO = new System.Windows.Forms.TextBox();
            this.textBox_class = new System.Windows.Forms.TextBox();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_CityWanted = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Comment = new System.Windows.Forms.TextBox();
            this.textBox_addresss = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_JobWanted = new System.Windows.Forms.TextBox();
            this.textBox_PostalCode = new System.Windows.Forms.TextBox();
            this.textBox_SchoolBefore = new System.Windows.Forms.TextBox();
            this.textBox_Major = new System.Windows.Forms.TextBox();
            this.textBox_StudentIDNO = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(620, 27);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // dmButtonClose1
            // 
            this.dmButtonClose1.BackColor = System.Drawing.Color.Transparent;
            this.dmButtonClose1.Location = new System.Drawing.Point(590, 0);
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
            this.dmButtonMin1.Location = new System.Drawing.Point(559, 0);
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
            this.label1.Text = "个人信息";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_sex);
            this.groupBox1.Controls.Add(this.textBox_StudentName);
            this.groupBox1.Controls.Add(this.textBox_StudentNO);
            this.groupBox1.Controls.Add(this.textBox_class);
            this.groupBox1.Controls.Add(this.textBox_user);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(7, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox_sex
            // 
            this.textBox_sex.Location = new System.Drawing.Point(386, 67);
            this.textBox_sex.Name = "textBox_sex";
            this.textBox_sex.ReadOnly = true;
            this.textBox_sex.Size = new System.Drawing.Size(163, 21);
            this.textBox_sex.TabIndex = 11;
            // 
            // textBox_StudentName
            // 
            this.textBox_StudentName.Location = new System.Drawing.Point(386, 30);
            this.textBox_StudentName.Name = "textBox_StudentName";
            this.textBox_StudentName.ReadOnly = true;
            this.textBox_StudentName.Size = new System.Drawing.Size(163, 21);
            this.textBox_StudentName.TabIndex = 10;
            this.textBox_StudentName.TextChanged += new System.EventHandler(this.textBox_StudentName_TextChanged);
            // 
            // textBox_StudentNO
            // 
            this.textBox_StudentNO.Location = new System.Drawing.Point(103, 67);
            this.textBox_StudentNO.Name = "textBox_StudentNO";
            this.textBox_StudentNO.ReadOnly = true;
            this.textBox_StudentNO.Size = new System.Drawing.Size(163, 21);
            this.textBox_StudentNO.TabIndex = 9;
            // 
            // textBox_class
            // 
            this.textBox_class.Location = new System.Drawing.Point(103, 107);
            this.textBox_class.Name = "textBox_class";
            this.textBox_class.ReadOnly = true;
            this.textBox_class.Size = new System.Drawing.Size(163, 21);
            this.textBox_class.TabIndex = 8;
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(103, 30);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.ReadOnly = true;
            this.textBox_user.Size = new System.Drawing.Size(163, 21);
            this.textBox_user.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "性别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "姓名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "学号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "班级编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "用户名：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_CityWanted);
            this.groupBox2.Controls.Add(this.textBox_Email);
            this.groupBox2.Controls.Add(this.textBox_Comment);
            this.groupBox2.Controls.Add(this.textBox_addresss);
            this.groupBox2.Controls.Add(this.textBox_phone);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.textBox_JobWanted);
            this.groupBox2.Controls.Add(this.textBox_PostalCode);
            this.groupBox2.Controls.Add(this.textBox_SchoolBefore);
            this.groupBox2.Controls.Add(this.textBox_Major);
            this.groupBox2.Controls.Add(this.textBox_StudentIDNO);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(7, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 209);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "详细信息";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox_CityWanted
            // 
            this.textBox_CityWanted.Location = new System.Drawing.Point(386, 63);
            this.textBox_CityWanted.Name = "textBox_CityWanted";
            this.textBox_CityWanted.ReadOnly = true;
            this.textBox_CityWanted.Size = new System.Drawing.Size(163, 21);
            this.textBox_CityWanted.TabIndex = 20;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(386, 168);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.ReadOnly = true;
            this.textBox_Email.Size = new System.Drawing.Size(163, 21);
            this.textBox_Email.TabIndex = 19;
            // 
            // textBox_Comment
            // 
            this.textBox_Comment.Location = new System.Drawing.Point(386, 133);
            this.textBox_Comment.Name = "textBox_Comment";
            this.textBox_Comment.ReadOnly = true;
            this.textBox_Comment.Size = new System.Drawing.Size(163, 21);
            this.textBox_Comment.TabIndex = 18;
            // 
            // textBox_addresss
            // 
            this.textBox_addresss.Location = new System.Drawing.Point(103, 168);
            this.textBox_addresss.Name = "textBox_addresss";
            this.textBox_addresss.ReadOnly = true;
            this.textBox_addresss.Size = new System.Drawing.Size(163, 21);
            this.textBox_addresss.TabIndex = 17;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(103, 133);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.ReadOnly = true;
            this.textBox_phone.Size = new System.Drawing.Size(163, 21);
            this.textBox_phone.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(315, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 15;
            this.label14.Text = "电子邮箱：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(339, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 14;
            this.label15.Text = "备注：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(50, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 13;
            this.label16.Text = "住址：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 12;
            this.label17.Text = "联系电话：";
            // 
            // textBox_JobWanted
            // 
            this.textBox_JobWanted.Location = new System.Drawing.Point(386, 98);
            this.textBox_JobWanted.Name = "textBox_JobWanted";
            this.textBox_JobWanted.ReadOnly = true;
            this.textBox_JobWanted.Size = new System.Drawing.Size(163, 21);
            this.textBox_JobWanted.TabIndex = 11;
            // 
            // textBox_PostalCode
            // 
            this.textBox_PostalCode.Location = new System.Drawing.Point(386, 30);
            this.textBox_PostalCode.Name = "textBox_PostalCode";
            this.textBox_PostalCode.ReadOnly = true;
            this.textBox_PostalCode.Size = new System.Drawing.Size(163, 21);
            this.textBox_PostalCode.TabIndex = 9;
            // 
            // textBox_SchoolBefore
            // 
            this.textBox_SchoolBefore.Location = new System.Drawing.Point(103, 98);
            this.textBox_SchoolBefore.Name = "textBox_SchoolBefore";
            this.textBox_SchoolBefore.ReadOnly = true;
            this.textBox_SchoolBefore.Size = new System.Drawing.Size(163, 21);
            this.textBox_SchoolBefore.TabIndex = 8;
            // 
            // textBox_Major
            // 
            this.textBox_Major.Location = new System.Drawing.Point(103, 63);
            this.textBox_Major.Name = "textBox_Major";
            this.textBox_Major.ReadOnly = true;
            this.textBox_Major.Size = new System.Drawing.Size(163, 21);
            this.textBox_Major.TabIndex = 7;
            // 
            // textBox_StudentIDNO
            // 
            this.textBox_StudentIDNO.Location = new System.Drawing.Point(103, 30);
            this.textBox_StudentIDNO.Name = "textBox_StudentIDNO";
            this.textBox_StudentIDNO.ReadOnly = true;
            this.textBox_StudentIDNO.Size = new System.Drawing.Size(163, 21);
            this.textBox_StudentIDNO.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "工作职位：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(339, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "市区：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "邮政编码：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "学校地址：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "专业名称：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "身份证号：";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(515, 398);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(74, 30);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "确定";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(620, 440);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "个人信息";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DMSkin.Controls.DMLabel dmLabel1;
        private DMSkin.Controls.DMButtonClose dmButtonClose1;
        private DMSkin.Controls.DMButtonMin dmButtonMin1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_sex;
        private System.Windows.Forms.TextBox textBox_StudentName;
        private System.Windows.Forms.TextBox textBox_StudentNO;
        private System.Windows.Forms.TextBox textBox_class;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_JobWanted;
        private System.Windows.Forms.TextBox textBox_PostalCode;
        private System.Windows.Forms.TextBox textBox_SchoolBefore;
        private System.Windows.Forms.TextBox textBox_Major;
        private System.Windows.Forms.TextBox textBox_StudentIDNO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Comment;
        private System.Windows.Forms.TextBox textBox_addresss;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textBox_CityWanted;
    }
}