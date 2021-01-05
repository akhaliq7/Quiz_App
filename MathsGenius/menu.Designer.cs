namespace MathsGenius
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.picMinus = new System.Windows.Forms.PictureBox();
            this.picMultiply = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.picDivide = new System.Windows.Forms.PictureBox();
            this.rdoAdd = new System.Windows.Forms.RadioButton();
            this.rdoMinus = new System.Windows.Forms.RadioButton();
            this.rdoMultiply = new System.Windows.Forms.RadioButton();
            this.rdoDivide = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMultiply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDivide)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.lblHeader.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.lblHeader.Location = new System.Drawing.Point(1, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(450, 78);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Maths Genius";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.lblFooter.Location = new System.Drawing.Point(-2, 441);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(453, 50);
            this.lblFooter.TabIndex = 2;
            // 
            // picUser
            // 
            this.picUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUser.BackgroundImage")));
            this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUser.Location = new System.Drawing.Point(245, 147);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(100, 60);
            this.picUser.TabIndex = 10;
            this.picUser.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(351, 159);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(51, 20);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "label1";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTitle.Location = new System.Drawing.Point(22, 147);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(131, 32);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Main Menu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(1, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 49);
            this.panel1.TabIndex = 13;
            // 
            // btnProfile
            // 
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnProfile.FlatAppearance.BorderSize = 4;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnProfile.Location = new System.Drawing.Point(104, 0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(107, 49);
            this.btnProfile.TabIndex = 2;
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
            // picMinus
            // 
            this.picMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMinus.BackgroundImage")));
            this.picMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMinus.Location = new System.Drawing.Point(245, 247);
            this.picMinus.Name = "picMinus";
            this.picMinus.Size = new System.Drawing.Size(100, 50);
            this.picMinus.TabIndex = 14;
            this.picMinus.TabStop = false;
            // 
            // picMultiply
            // 
            this.picMultiply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMultiply.BackgroundImage")));
            this.picMultiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMultiply.Location = new System.Drawing.Point(53, 334);
            this.picMultiply.Name = "picMultiply";
            this.picMultiply.Size = new System.Drawing.Size(100, 50);
            this.picMultiply.TabIndex = 15;
            this.picMultiply.TabStop = false;
            // 
            // picAdd
            // 
            this.picAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAdd.BackgroundImage")));
            this.picAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAdd.Location = new System.Drawing.Point(53, 247);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(100, 50);
            this.picAdd.TabIndex = 16;
            this.picAdd.TabStop = false;
            // 
            // picDivide
            // 
            this.picDivide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDivide.BackgroundImage")));
            this.picDivide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDivide.Location = new System.Drawing.Point(245, 334);
            this.picDivide.Name = "picDivide";
            this.picDivide.Size = new System.Drawing.Size(100, 50);
            this.picDivide.TabIndex = 17;
            this.picDivide.TabStop = false;
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Location = new System.Drawing.Point(94, 308);
            this.rdoAdd.Name = "rdoAdd";
            this.rdoAdd.Size = new System.Drawing.Size(14, 13);
            this.rdoAdd.TabIndex = 18;
            this.rdoAdd.TabStop = true;
            this.rdoAdd.UseVisualStyleBackColor = true;
            // 
            // rdoMinus
            // 
            this.rdoMinus.AutoSize = true;
            this.rdoMinus.Location = new System.Drawing.Point(285, 308);
            this.rdoMinus.Name = "rdoMinus";
            this.rdoMinus.Size = new System.Drawing.Size(14, 13);
            this.rdoMinus.TabIndex = 19;
            this.rdoMinus.TabStop = true;
            this.rdoMinus.UseVisualStyleBackColor = true;
            // 
            // rdoMultiply
            // 
            this.rdoMultiply.AutoSize = true;
            this.rdoMultiply.Location = new System.Drawing.Point(94, 399);
            this.rdoMultiply.Name = "rdoMultiply";
            this.rdoMultiply.Size = new System.Drawing.Size(14, 13);
            this.rdoMultiply.TabIndex = 20;
            this.rdoMultiply.TabStop = true;
            this.rdoMultiply.UseVisualStyleBackColor = true;
            // 
            // rdoDivide
            // 
            this.rdoDivide.AutoSize = true;
            this.rdoDivide.Location = new System.Drawing.Point(285, 399);
            this.rdoDivide.Name = "rdoDivide";
            this.rdoDivide.Size = new System.Drawing.Size(14, 13);
            this.rdoDivide.TabIndex = 21;
            this.rdoDivide.TabStop = true;
            this.rdoDivide.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(355, 399);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 22;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(362, 455);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(449, 490);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rdoDivide);
            this.Controls.Add(this.rdoMultiply);
            this.Controls.Add(this.rdoMinus);
            this.Controls.Add(this.rdoAdd);
            this.Controls.Add(this.picDivide);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.picMultiply);
            this.Controls.Add(this.picMinus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.lblHeader);
            this.Name = "frmMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMultiply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDivide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox picMinus;
        private System.Windows.Forms.PictureBox picMultiply;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.PictureBox picDivide;
        private System.Windows.Forms.RadioButton rdoAdd;
        private System.Windows.Forms.RadioButton rdoMinus;
        private System.Windows.Forms.RadioButton rdoMultiply;
        private System.Windows.Forms.RadioButton rdoDivide;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
    }
}