namespace MathsGenius
{
    partial class frmInteraction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInteraction));
            this.lblWellDone = new System.Windows.Forms.Label();
            this.lblGoBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWellDone
            // 
            this.lblWellDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblWellDone.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWellDone.Location = new System.Drawing.Point(129, 321);
            this.lblWellDone.Name = "lblWellDone";
            this.lblWellDone.Size = new System.Drawing.Size(273, 41);
            this.lblWellDone.TabIndex = 0;
            this.lblWellDone.Text = "label1";
            this.lblWellDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGoBack
            // 
            this.lblGoBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoBack.ForeColor = System.Drawing.Color.White;
            this.lblGoBack.Location = new System.Drawing.Point(73, 402);
            this.lblGoBack.Name = "lblGoBack";
            this.lblGoBack.Size = new System.Drawing.Size(349, 23);
            this.lblGoBack.TabIndex = 1;
            this.lblGoBack.Text = "Click me to GO BACK!";
            this.lblGoBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGoBack.Click += new System.EventHandler(this.lblGoBack_Click);
            // 
            // frmInteraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.lblGoBack);
            this.Controls.Add(this.lblWellDone);
            this.DoubleBuffered = true;
            this.Name = "frmInteraction";
            this.Text = "interaction";
            this.Load += new System.EventHandler(this.frmInteraction_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWellDone;
        private System.Windows.Forms.Label lblGoBack;
    }
}