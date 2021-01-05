namespace MathsGenius
{
    partial class frmProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfile));
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblFooter = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstScoreId = new System.Windows.Forms.ListBox();
            this.lstUsername = new System.Windows.Forms.ListBox();
            this.lstQuiz = new System.Windows.Forms.ListBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lstScore = new System.Windows.Forms.ListBox();
            this.lstDate = new System.Windows.Forms.ListBox();
            this.lstTime = new System.Windows.Forms.ListBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblQuiz = new System.Windows.Forms.Label();
            this.lstHighScore = new System.Windows.Forms.ListBox();
            this.lblHighScores = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.Controls.Add(this.btnMenu);
            this.pnlNavBar.Controls.Add(this.btnHome);
            this.pnlNavBar.Location = new System.Drawing.Point(-2, 76);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(335, 49);
            this.pnlNavBar.TabIndex = 17;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnMenu.FlatAppearance.BorderSize = 4;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnMenu.Location = new System.Drawing.Point(167, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(167, 49);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
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
            this.btnHome.Size = new System.Drawing.Size(170, 49);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.lblFooter.Location = new System.Drawing.Point(0, 432);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(683, 50);
            this.lblFooter.TabIndex = 16;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.lblHeader.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.lblHeader.Location = new System.Drawing.Point(-2, -2);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(680, 78);
            this.lblHeader.TabIndex = 15;
            this.lblHeader.Text = "Maths Genius";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.Location = new System.Drawing.Point(550, 129);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(85, 23);
            this.btnDeleteProfile.TabIndex = 21;
            this.btnDeleteProfile.Text = "Delete Profile";
            this.btnDeleteProfile.UseVisualStyleBackColor = true;
            this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(555, 90);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(51, 20);
            this.lblUsername.TabIndex = 20;
            this.lblUsername.Text = "label1";
            // 
            // picUser
            // 
            this.picUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUser.BackgroundImage")));
            this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUser.Location = new System.Drawing.Point(439, 92);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(100, 60);
            this.picUser.TabIndex = 19;
            this.picUser.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTitle.Location = new System.Drawing.Point(60, 147);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(131, 32);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Profile";
            // 
            // lstScoreId
            // 
            this.lstScoreId.FormattingEnabled = true;
            this.lstScoreId.Location = new System.Drawing.Point(21, 201);
            this.lstScoreId.Name = "lstScoreId";
            this.lstScoreId.Size = new System.Drawing.Size(33, 225);
            this.lstScoreId.TabIndex = 23;
            // 
            // lstUsername
            // 
            this.lstUsername.FormattingEnabled = true;
            this.lstUsername.Location = new System.Drawing.Point(338, 201);
            this.lstUsername.Name = "lstUsername";
            this.lstUsername.Size = new System.Drawing.Size(79, 225);
            this.lstUsername.TabIndex = 24;
            // 
            // lstQuiz
            // 
            this.lstQuiz.FormattingEnabled = true;
            this.lstQuiz.Location = new System.Drawing.Point(439, 201);
            this.lstQuiz.Name = "lstQuiz";
            this.lstQuiz.Size = new System.Drawing.Size(93, 225);
            this.lstQuiz.TabIndex = 25;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(19, 179);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(18, 13);
            this.lblScore.TabIndex = 26;
            this.lblScore.Text = "ID";
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Location = new System.Drawing.Point(70, 179);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(35, 13);
            this.lblScores.TabIndex = 27;
            this.lblScores.Text = "Score";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(197, 179);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "Date";
            // 
            // lstScore
            // 
            this.lstScore.FormattingEnabled = true;
            this.lstScore.Location = new System.Drawing.Point(62, 201);
            this.lstScore.Name = "lstScore";
            this.lstScore.Size = new System.Drawing.Size(43, 225);
            this.lstScore.TabIndex = 29;
            // 
            // lstDate
            // 
            this.lstDate.FormattingEnabled = true;
            this.lstDate.Location = new System.Drawing.Point(180, 201);
            this.lstDate.Name = "lstDate";
            this.lstDate.Size = new System.Drawing.Size(78, 225);
            this.lstDate.TabIndex = 30;
            // 
            // lstTime
            // 
            this.lstTime.FormattingEnabled = true;
            this.lstTime.Location = new System.Drawing.Point(267, 201);
            this.lstTime.Name = "lstTime";
            this.lstTime.Size = new System.Drawing.Size(51, 225);
            this.lstTime.TabIndex = 31;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(274, 179);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 32;
            this.lblTime.Text = "Time";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(348, 179);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(55, 13);
            this.lblUser.TabIndex = 33;
            this.lblUser.Text = "Username";
            // 
            // lblQuiz
            // 
            this.lblQuiz.AutoSize = true;
            this.lblQuiz.Location = new System.Drawing.Point(456, 179);
            this.lblQuiz.Name = "lblQuiz";
            this.lblQuiz.Size = new System.Drawing.Size(59, 13);
            this.lblQuiz.TabIndex = 34;
            this.lblQuiz.Text = "Quiz Name";
            // 
            // lstHighScore
            // 
            this.lstHighScore.FormattingEnabled = true;
            this.lstHighScore.Location = new System.Drawing.Point(118, 201);
            this.lstHighScore.Name = "lstHighScore";
            this.lstHighScore.Size = new System.Drawing.Size(44, 225);
            this.lstHighScore.TabIndex = 35;
            // 
            // lblHighScores
            // 
            this.lblHighScores.AutoSize = true;
            this.lblHighScores.Location = new System.Drawing.Point(114, 179);
            this.lblHighScores.Name = "lblHighScores";
            this.lblHighScores.Size = new System.Drawing.Size(60, 13);
            this.lblHighScores.TabIndex = 36;
            this.lblHighScores.Text = "High Score";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(592, 447);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 482);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblHighScores);
            this.Controls.Add(this.lstHighScore);
            this.Controls.Add(this.lblQuiz);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lstTime);
            this.Controls.Add(this.lstDate);
            this.Controls.Add(this.lstScore);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lstQuiz);
            this.Controls.Add(this.lstUsername);
            this.Controls.Add(this.lstScoreId);
            this.Controls.Add(this.pnlNavBar);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnDeleteProfile);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmProfile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.profile2_Load);
            this.pnlNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstScoreId;
        private System.Windows.Forms.ListBox lstUsername;
        private System.Windows.Forms.ListBox lstQuiz;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ListBox lstScore;
        private System.Windows.Forms.ListBox lstDate;
        private System.Windows.Forms.ListBox lstTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblQuiz;
        private System.Windows.Forms.ListBox lstHighScore;
        private System.Windows.Forms.Label lblHighScores;
        private System.Windows.Forms.Button btnExit;
    }
}