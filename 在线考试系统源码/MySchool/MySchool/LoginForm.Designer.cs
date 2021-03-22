namespace MySchool
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dmLabel1 = new DMSkin.Controls.DMLabel();
            this.dmButtonClose1 = new DMSkin.Controls.DMButtonClose();
            this.dmButtonMin1 = new DMSkin.Controls.DMButtonMin();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginType = new DMSkin.Metro.Controls.MetroComboBox();
            this.txtLoginId = new DMSkin.Controls.DMTextBox();
            this.txtLoginPwd = new DMSkin.Controls.DMTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dmLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 27);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(35, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户登录";
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
            // dmButtonClose1
            // 
            this.dmButtonClose1.BackColor = System.Drawing.Color.Transparent;
            this.dmButtonClose1.Location = new System.Drawing.Point(416, 0);
            this.dmButtonClose1.MaximumSize = new System.Drawing.Size(30, 27);
            this.dmButtonClose1.MinimumSize = new System.Drawing.Size(30, 27);
            this.dmButtonClose1.Name = "dmButtonClose1";
            this.dmButtonClose1.Size = new System.Drawing.Size(30, 27);
            this.dmButtonClose1.TabIndex = 1;
            this.dmButtonClose1.Click += new System.EventHandler(this.dmButtonClose1_Click);
            // 
            // dmButtonMin1
            // 
            this.dmButtonMin1.BackColor = System.Drawing.Color.Transparent;
            this.dmButtonMin1.Location = new System.Drawing.Point(385, 0);
            this.dmButtonMin1.Name = "dmButtonMin1";
            this.dmButtonMin1.Size = new System.Drawing.Size(30, 27);
            this.dmButtonMin1.TabIndex = 2;
            this.dmButtonMin1.Click += new System.EventHandler(this.dmButtonMin1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::MySchool.Properties.Resources.desktop2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dmButtonClose1);
            this.panel2.Controls.Add(this.dmButtonMin1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 130);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "BF-TECH在线考试系统V1.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "类型";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MySchool.Properties.Resources.CQDJ;
            this.pictureBox1.Location = new System.Drawing.Point(33, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "密码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "帐号";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(243, 290);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(157, 290);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(74, 30);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginType
            // 
            this.txtLoginType.DM_UseSelectable = true;
            this.txtLoginType.DropDownHeight = 90;
            this.txtLoginType.FormattingEnabled = true;
            this.txtLoginType.IntegralHeight = false;
            this.txtLoginType.ItemHeight = 24;
            this.txtLoginType.Items.AddRange(new object[] {
            "教员",
            "学员",
            "管理员"});
            this.txtLoginType.Location = new System.Drawing.Point(157, 242);
            this.txtLoginType.Name = "txtLoginType";
            this.txtLoginType.Size = new System.Drawing.Size(157, 30);
            this.txtLoginType.TabIndex = 3;
            // 
            // txtLoginId
            // 
            this.txtLoginId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginId.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtLoginId.Location = new System.Drawing.Point(157, 161);
            this.txtLoginId.Multiline = true;
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(157, 30);
            this.txtLoginId.TabIndex = 1;
            this.txtLoginId.WaterText = "账号";
            this.txtLoginId.TextChanged += new System.EventHandler(this.txtLoginId_TextChanged);
            this.txtLoginId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dmTextBox1_KeyDown);
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginPwd.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtLoginPwd.Location = new System.Drawing.Point(157, 202);
            this.txtLoginPwd.Multiline = true;
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.PasswordChar = '✲';
            this.txtLoginPwd.Size = new System.Drawing.Size(157, 30);
            this.txtLoginPwd.TabIndex = 2;
            this.txtLoginPwd.WaterText = "密码";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(446, 353);
            this.Controls.Add(this.txtLoginPwd);
            this.Controls.Add(this.txtLoginId);
            this.Controls.Add(this.txtLoginType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录窗体";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DMSkin.Controls.DMLabel dmLabel1;
        private DMSkin.Controls.DMButtonClose dmButtonClose1;
        private DMSkin.Controls.DMButtonMin dmButtonMin1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private DMSkin.Metro.Controls.MetroComboBox txtLoginType;
        private DMSkin.Controls.DMTextBox txtLoginId;
        private DMSkin.Controls.DMTextBox txtLoginPwd;
    }
}