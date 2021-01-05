namespace MathsGenius
{
    partial class frmRegister
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpRegister = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtReEnterPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblReEnterPassword = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.grpRegister.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.lblHeader.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
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
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTitle.Location = new System.Drawing.Point(23, 141);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(131, 32);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Register";
            // 
            // grpRegister
            // 
            this.grpRegister.BackColor = System.Drawing.Color.DarkOrange;
            this.grpRegister.Controls.Add(this.txtEmail);
            this.grpRegister.Controls.Add(this.txtReEnterPassword);
            this.grpRegister.Controls.Add(this.lblEmail);
            this.grpRegister.Controls.Add(this.lblReEnterPassword);
            this.grpRegister.Controls.Add(this.btnExit);
            this.grpRegister.Controls.Add(this.btnSubmit);
            this.grpRegister.Controls.Add(this.txtPassword);
            this.grpRegister.Controls.Add(this.txtUsername);
            this.grpRegister.Controls.Add(this.lblPassword);
            this.grpRegister.Controls.Add(this.lblUsername);
            this.grpRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(248)))));
            this.grpRegister.Location = new System.Drawing.Point(12, 176);
            this.grpRegister.Name = "grpRegister";
            this.grpRegister.Size = new System.Drawing.Size(409, 226);
            this.grpRegister.TabIndex = 5;
            this.grpRegister.TabStop = false;
            this.grpRegister.Text = "Registration Form";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(152, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtReEnterPassword
            // 
            this.txtReEnterPassword.Location = new System.Drawing.Point(152, 107);
            this.txtReEnterPassword.Name = "txtReEnterPassword";
            this.txtReEnterPassword.Size = new System.Drawing.Size(100, 20);
            this.txtReEnterPassword.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(83, 140);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // lblReEnterPassword
            // 
            this.lblReEnterPassword.AutoSize = true;
            this.lblReEnterPassword.Location = new System.Drawing.Point(38, 110);
            this.lblReEnterPassword.Name = "lblReEnterPassword";
            this.lblReEnterPassword.Size = new System.Drawing.Size(97, 13);
            this.lblReEnterPassword.TabIndex = 7;
            this.lblReEnterPassword.Text = "Re-enter Password";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Location = new System.Drawing.Point(177, 170);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSubmit.Location = new System.Drawing.Point(67, 170);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(152, 76);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(152, 46);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(83, 79);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(52, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(82, 49);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(53, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "username";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 49);
            this.panel1.TabIndex = 6;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnMenu.FlatAppearance.BorderSize = 4;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnMenu.Location = new System.Drawing.Point(206, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(107, 49);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnProfile.FlatAppearance.BorderSize = 4;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnProfile.Location = new System.Drawing.Point(103, 0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(107, 49);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnHome.FlatAppearance.BorderSize = 4;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(107, 49);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(449, 490);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpRegister);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.lblHeader);
            this.Name = "frmRegister";
            this.Text = "Register";
            this.grpRegister.ResumeLayout(false);
            this.grpRegister.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpRegister;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtReEnterPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblReEnterPassword;
    }
}