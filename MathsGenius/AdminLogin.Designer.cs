namespace MathsGenius
{
    partial class frmAdminLogin
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnQuestions = new System.Windows.Forms.Button();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.lblHeader.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.lblHeader.Location = new System.Drawing.Point(0, -2);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(450, 78);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Maths Genius";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.lblFooter.Location = new System.Drawing.Point(-3, 442);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(453, 50);
            this.lblFooter.TabIndex = 2;
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.Color.Transparent;
            this.grpLogin.Controls.Add(this.lblWelcome);
            this.grpLogin.Controls.Add(this.btnExit);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.txtUsername);
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Controls.Add(this.lblUsername);
            this.grpLogin.ForeColor = System.Drawing.Color.Black;
            this.grpLogin.Location = new System.Drawing.Point(12, 182);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(409, 226);
            this.grpLogin.TabIndex = 5;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "User Login";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Location = new System.Drawing.Point(-3, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(387, 124);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "The admin page is to manage the server through visual studio.\r\nOnly the admin use" +
    "rs have authorithy to access these roles.\r\n";
            this.lblWelcome.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Location = new System.Drawing.Point(177, 147);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogin.Location = new System.Drawing.Point(69, 147);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(152, 104);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(152, 70);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(83, 107);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(52, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(83, 73);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(53, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "username";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(16, 139);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(147, 32);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Admin Login";
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHome.FlatAppearance.BorderSize = 4;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(0, 76);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(107, 54);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnUser
            // 
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUser.FlatAppearance.BorderSize = 4;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnUser.ForeColor = System.Drawing.Color.Black;
            this.btnUser.Location = new System.Drawing.Point(106, 76);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(107, 54);
            this.btnUser.TabIndex = 9;
            this.btnUser.Text = "Manage \r\n   User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Visible = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnQuestions
            // 
            this.btnQuestions.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuestions.FlatAppearance.BorderSize = 4;
            this.btnQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuestions.ForeColor = System.Drawing.Color.Black;
            this.btnQuestions.Location = new System.Drawing.Point(210, 76);
            this.btnQuestions.Name = "btnQuestions";
            this.btnQuestions.Size = new System.Drawing.Size(107, 54);
            this.btnQuestions.TabIndex = 10;
            this.btnQuestions.Text = "Manage \r\nQuestions";
            this.btnQuestions.UseVisualStyleBackColor = true;
            this.btnQuestions.Visible = false;
            this.btnQuestions.Click += new System.EventHandler(this.btnQuestions_Click);
            // 
            // btnExit2
            // 
            this.btnExit2.Location = new System.Drawing.Point(340, 455);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(75, 23);
            this.btnExit2.TabIndex = 11;
            this.btnExit2.Text = "Exit";
            this.btnExit2.UseVisualStyleBackColor = true;
            this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
            // 
            // frmAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(449, 490);
            this.Controls.Add(this.btnExit2);
            this.Controls.Add(this.btnQuestions);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.lblHeader);
            this.Name = "frmAdminLogin";
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.frmAdminLogin_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnQuestions;
        private System.Windows.Forms.Button btnExit2;
    }
}