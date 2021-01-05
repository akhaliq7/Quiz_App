namespace MathsGenius
{
    partial class frmAdminUser
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
            this.lstEmail = new System.Windows.Forms.ListBox();
            this.lstUsername = new System.Windows.Forms.ListBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblEmail2 = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblUsername2 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnManageQuest = new System.Windows.Forms.Button();
            this.pnlBox1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.pnlBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEmail
            // 
            this.lstEmail.FormattingEnabled = true;
            this.lstEmail.Location = new System.Drawing.Point(333, 127);
            this.lstEmail.Name = "lstEmail";
            this.lstEmail.Size = new System.Drawing.Size(109, 225);
            this.lstEmail.TabIndex = 33;
            // 
            // lstUsername
            // 
            this.lstUsername.FormattingEnabled = true;
            this.lstUsername.Location = new System.Drawing.Point(226, 127);
            this.lstUsername.Name = "lstUsername";
            this.lstUsername.Size = new System.Drawing.Size(73, 225);
            this.lstUsername.TabIndex = 32;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(91, 193);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 31;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(91, 160);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 30;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(91, 127);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 29;
            // 
            // lblEmail2
            // 
            this.lblEmail2.AutoSize = true;
            this.lblEmail2.Location = new System.Drawing.Point(352, 103);
            this.lblEmail2.Name = "lblEmail2";
            this.lblEmail2.Size = new System.Drawing.Size(32, 13);
            this.lblEmail2.TabIndex = 28;
            this.lblEmail2.Text = "Email";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(464, 103);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(37, 13);
            this.lblActive.TabIndex = 27;
            this.lblActive.Text = "Active";
            // 
            // lblUsername2
            // 
            this.lblUsername2.AutoSize = true;
            this.lblUsername2.Location = new System.Drawing.Point(239, 103);
            this.lblUsername2.Name = "lblUsername2";
            this.lblUsername2.Size = new System.Drawing.Size(55, 13);
            this.lblUsername2.TabIndex = 26;
            this.lblUsername2.Text = "Username";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(50, 193);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(29, 163);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 24;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(27, 130);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 23;
            this.lblUsername.Text = "Username:";
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.lblFooter.Location = new System.Drawing.Point(-1, 400);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(804, 52);
            this.lblFooter.TabIndex = 22;
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.lblHeading.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.lblHeading.Location = new System.Drawing.Point(-2, -2);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(805, 85);
            this.lblHeading.TabIndex = 21;
            this.lblHeading.Text = "Maths Quiz Admin Controls";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(21, 182);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(137, 23);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnManageQuest
            // 
            this.btnManageQuest.Location = new System.Drawing.Point(21, 143);
            this.btnManageQuest.Name = "btnManageQuest";
            this.btnManageQuest.Size = new System.Drawing.Size(137, 23);
            this.btnManageQuest.TabIndex = 3;
            this.btnManageQuest.Text = "Manage Questions";
            this.btnManageQuest.UseVisualStyleBackColor = true;
            this.btnManageQuest.Click += new System.EventHandler(this.btnManageQuest_Click);
            // 
            // pnlBox1
            // 
            this.pnlBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBox1.Controls.Add(this.btnAdminLogin);
            this.pnlBox1.Controls.Add(this.btnHome);
            this.pnlBox1.Controls.Add(this.btnManageQuest);
            this.pnlBox1.Controls.Add(this.btnSave);
            this.pnlBox1.Controls.Add(this.btnView);
            this.pnlBox1.Location = new System.Drawing.Point(521, 130);
            this.pnlBox1.Name = "pnlBox1";
            this.pnlBox1.Size = new System.Drawing.Size(224, 225);
            this.pnlBox1.TabIndex = 36;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(665, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(21, 61);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(137, 23);
            this.btnView.TabIndex = 21;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(21, 102);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(137, 23);
            this.btnAdminLogin.TabIndex = 37;
            this.btnAdminLogin.Text = "Admin Login";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // frmAdminUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBox1);
            this.Controls.Add(this.lstEmail);
            this.Controls.Add(this.lstUsername);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblEmail2);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.lblUsername2);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.lblHeading);
            this.Name = "frmAdminUser";
            this.Text = "admin";
            this.pnlBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstEmail;
        private System.Windows.Forms.ListBox lstUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblEmail2;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblUsername2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnManageQuest;
        private System.Windows.Forms.Button btnAdminLogin;
    }
}