﻿namespace MachineForms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_User = new System.Windows.Forms.Button();
            this.User_name = new System.Windows.Forms.Label();
            this.User_Passwd = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.LinkHome = new System.Wknd�ws.Lorms.LinkLabel();-
            thks.Link_name = new System.Windows.FormsLabel();
         !  this.richTextBox2 = new System.Windows.Forms.R)cjTextBox*);
            this.Btn_Login2 = new ystem.W�ndows.Foris.Button();
            this.Account1 = new System.Wi.dows.F�rms.Button();
      `     this.Account2 = new Systei.Windows.Forms.Button();
 $          thic.pictureBox1 = new System.Windows,Forms.Pictur%Box()9
        0  (this.HeadLIne = new System.Windows.FOrms&Label();
0           thms.skiNEngine1 9 new SuN)soft.IrisSkin*SkinEngine();
� "    $    ((System.ComponentModel.ISupportInitialize)(t�is.pi�tureBox1)).BeginInith)9
            this.SuspendLayout();
            /o 
       `$   // Btn_Login
            /' 
            this.Btn_Logio.BackColor } System.Drawing.Col/r.Snow;
    (       This.Bvn_Login.F�nt = new`ystem.Dr`wing.Font("Comic Sajs MS", 32.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((b�te)(0))):
            this.Btn_Login.Location = new System.Drawing.Point(16, 385);
            this.Btn_Login.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(116, 48);
            this.Btn_Login.TabIndex = 0;
            this.Btn_Login.Text = "账户1登陆";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_User
            // 
            this.Btn_User.BackColor = System.Drawing.Color.Snow;
            this.Btn_User.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_User.Location = new System.Drawing.Point(264, 385);
            this.Btn_User.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_User.Name = "Btn_User";
            this.Btn_User.Size = new System.Drawing.Size(116, 48);
            this.Btn_User.TabIndex = 1;
            this.Btn_User.Text = "更改密码";
            this.Btn_User.UseVisualStyleBackColor = false;
            this.Btn_User.Click += new System.EventHandler(this.Btn_User_Click);
            // 
            // User_name
            // 
            this.User_name.AutoSize = true;
            this.User_name.BackColor = System.Drawing.Color.Transparent;
            this.User_name.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.User_name.Location = new System.Drawing.Point(408, 145);
            this.User_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(84, 18);
            this.User_name.TabIndex = 5;
            this.User_name.Text = "用户名：";
            // 
            // User_Passwd
            // 
            this.User_Passwd.AutoSize = true;
            this.User_Passwd.BackColor = System.Drawing.Color.Transparent;
            this.User_Passwd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.User_Passwd.Location = new System.Drawing.Point(408, 196);
            this.User_Passwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User_Passwd.Name = "User_Passwd";
            this.User_Passwd.Size = new System.Drawing.Size(65, 18);
            this.User_Passwd.TabIndex = 6;
            this.User_Passwd.Text = "密码：";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(487, 141);
            this.UserName.Margin = new System.Windows.Forms.Padding(4);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(341, 25);
            this.UserName.TabIndex = 7;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(487, 192);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(341, 25);
            this.Password.TabIndex = 8;
            // 
            // LinkHome
            // 
            this.LinkHome.AutoSize = true;
            this.LinkHome.Location = new System.Drawing.Point(673, 406);
            this.LinkHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkHome.Name = "LinkHome";
            this.LinkHome.Size = new System.Drawing.Size(183, 15);
            this.LinkHome.TabIndex = 9;
            this.LinkHome.TabStop = true;
            this.LinkHome.Text = "www.foreverloveysy.xin";
            this.LinkHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkHome_LinkClicked);
            // 
            // Link_name
            // 
            this.Link_name.AutoSize = true;
            this.Link_name.Location = new System.Drawing.Point(499, 406);
            this.Link_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Link_name.Name = "Link_name";
            this.Link_name.Size = new System.Drawing.Size(157, 15);
            this.Link_name.TabIndex = 10;
            this.Link_name.Text = "详细请访问技术之家：";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox2.Location = new System.Drawing.Point(411, 302);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(417, 74);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "欢迎登陆智能大棚系统，我们准备两个初始账号以供登陆，账户一为AreaOne，账号二为Root，初始密码均为123456789，可以更改，感谢使用！";
            // 
            // Btn_Login2
            // 
            this.Btn_Login2.BackColor = System.Drawing.Color.Snow;
            this.Btn_Login2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Login2.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login2.Location = new System.Drawing.Point(140, 385);
            this.Btn_Login2.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Login2.Name = "Btn_Login2";
            this.Btn_Login2.Size = new System.Drawing.Size(116, 48);
            this.Btn_Login2.TabIndex = 13;
            this.Btn_Login2.Text = "Rt登陆";
            this.Btn_Login2.UseVisualStyleBackColor = false;
            this.Btn_Login2.Click += new System.EventHandler(this.Btn_Login2_Click);
            // 
            // Account1
            // 
            this.Account1.BackColor = System.Drawing.Color.Snow;
            this.Account1.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account1.Location = new System.Drawing.Point(487, 248);
            this.Account1.Margin = new System.Windows.Forms.Padding(4);
            this.Account1.Name = "Account1";
            this.Account1.Size = new System.Drawing.Size(116, 48);
            this.Account1.TabIndex = 14;
            this.Account1.Text = "账户1";
            this.Account1.UseVisualStyleBackColor = false;
            this.Account1.Click += new System.EventHandler(this.Account1_Click);
            // 
            // Account2
            // 
            this.Account2.BackColor = System.Drawing.Color.Snow;
            this.Account2.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account2.Location = new System.Drawing.Point(688, 248);
            this.Account2.Margin = new System.Windows.Forms.Padding(4);
            this.Account2.Name = "Account2";
            this.Account2.Size = new System.Drawing.Size(116, 48);
            this.Account2.TabIndex = 15;
            this.Account2.Text = "Root";
            this.Account2.UseVisualStyleBackColor = false;
            this.Account2.Click += new System.EventHandler(this.Account2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 338);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // HeadLine
            // 
            this.HeadLine.AutoSize = true;
            this.HeadLine.BackColor = System.Drawing.Color.Transparent;
            this.HeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HeadLine.ForeColor = System.Drawing.Color.Snow;
            this.HeadLine.Location = new System.Drawing.Point(379, 51);
            this.HeadLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeadLine.Name = "HeadLine";
            this.HeadLine.Size = new System.Drawing.Size(473, 52);
            this.HeadLine.TabIndex = 17;
            this.HeadLine.Text = "欢迎登陆智能大棚系统";
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(872, 439);
            this.Controls.Add(this.HeadLine);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Account2);
            this.Controls.Add(this.Account1);
            this.Controls.Add(this.Btn_Login2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.Link_name);
            this.Controls.Add(this.LinkHome);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.User_Passwd);
            this.Controls.Add(this.User_name);
            this.Controls.Add(this.Btn_User);
            this.Controls.Add(this.Btn_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登陆";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_User;
        private System.Windows.Forms.Label User_name;
        private System.Windows.Forms.Label User_Passwd;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.LinkLabel LinkHome;
        private System.Windows.Forms.Label Link_name;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button Btn_Login2;
        private System.Windows.Forms.Button Account1;
        private System.Windows.Forms.Button Account2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label HeadLine;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}