namespace MathsGenius
{
    partial class frmAdminQuest
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
            this.components = new System.ComponentModel.Container();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnAdminUsers = new System.Windows.Forms.Button();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtOptionA = new System.Windows.Forms.TextBox();
            this.txtOptionB = new System.Windows.Forms.TextBox();
            this.txtOptionC = new System.Windows.Forms.TextBox();
            this.txtOptionD = new System.Windows.Forms.TextBox();
            this.txtCorrect = new System.Windows.Forms.TextBox();
            this.txtQuiz = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblOptionA = new System.Windows.Forms.Label();
            this.lblOptionB = new System.Windows.Forms.Label();
            this.lblOptionC = new System.Windows.Forms.Label();
            this.lblOptionD = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblQuiz = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qquestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qoptionADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qoptionBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qoptionCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qoptionDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qcorrectOptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quizidfkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mathsGeniusDataSet = new MathsGenius.MathsGeniusDataSet();
            this.questionsTableAdapter = new MathsGenius.MathsGeniusDataSetTableAdapters.questionsTableAdapter();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathsGeniusDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.lblHeading.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.lblHeading.Location = new System.Drawing.Point(-5, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(858, 85);
            this.lblHeading.TabIndex = 22;
            this.lblHeading.Text = "Maths Quiz Admin Controls";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.lblFooter.Location = new System.Drawing.Point(-2, 399);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(855, 52);
            this.lblFooter.TabIndex = 23;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlButtons.Controls.Add(this.btnExit);
            this.pnlButtons.Controls.Add(this.btnAdminUsers);
            this.pnlButtons.Controls.Add(this.btnAdminLogin);
            this.pnlButtons.Controls.Add(this.btnHome);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Location = new System.Drawing.Point(641, 110);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(185, 266);
            this.pnlButtons.TabIndex = 24;
            // 
            // btnAdminUsers
            // 
            this.btnAdminUsers.Location = new System.Drawing.Point(35, 155);
            this.btnAdminUsers.Name = "btnAdminUsers";
            this.btnAdminUsers.Size = new System.Drawing.Size(108, 23);
            this.btnAdminUsers.TabIndex = 27;
            this.btnAdminUsers.Text = "Manage Users";
            this.btnAdminUsers.UseVisualStyleBackColor = true;
            this.btnAdminUsers.Click += new System.EventHandler(this.btnAdminUsers_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(35, 110);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(108, 23);
            this.btnAdminLogin.TabIndex = 26;
            this.btnAdminLogin.Text = "Admin Login";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(35, 63);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(108, 23);
            this.btnHome.TabIndex = 25;
            this.btnHome.Text = "Home Page";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(35, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtOptionA
            // 
            this.txtOptionA.Location = new System.Drawing.Point(525, 154);
            this.txtOptionA.Name = "txtOptionA";
            this.txtOptionA.Size = new System.Drawing.Size(100, 20);
            this.txtOptionA.TabIndex = 32;
            // 
            // txtOptionB
            // 
            this.txtOptionB.Location = new System.Drawing.Point(525, 198);
            this.txtOptionB.Name = "txtOptionB";
            this.txtOptionB.Size = new System.Drawing.Size(100, 20);
            this.txtOptionB.TabIndex = 33;
            // 
            // txtOptionC
            // 
            this.txtOptionC.Location = new System.Drawing.Point(525, 238);
            this.txtOptionC.Name = "txtOptionC";
            this.txtOptionC.Size = new System.Drawing.Size(100, 20);
            this.txtOptionC.TabIndex = 34;
            // 
            // txtOptionD
            // 
            this.txtOptionD.Location = new System.Drawing.Point(525, 284);
            this.txtOptionD.Name = "txtOptionD";
            this.txtOptionD.Size = new System.Drawing.Size(100, 20);
            this.txtOptionD.TabIndex = 35;
            // 
            // txtCorrect
            // 
            this.txtCorrect.Location = new System.Drawing.Point(525, 324);
            this.txtCorrect.Name = "txtCorrect";
            this.txtCorrect.Size = new System.Drawing.Size(100, 20);
            this.txtCorrect.TabIndex = 36;
            // 
            // txtQuiz
            // 
            this.txtQuiz.Location = new System.Drawing.Point(525, 367);
            this.txtQuiz.Name = "txtQuiz";
            this.txtQuiz.Size = new System.Drawing.Size(100, 20);
            this.txtQuiz.TabIndex = 37;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(525, 114);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(100, 20);
            this.txtQuestion.TabIndex = 38;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(470, 117);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(49, 13);
            this.lblQuestion.TabIndex = 39;
            this.lblQuestion.Text = "Question";
            // 
            // lblOptionA
            // 
            this.lblOptionA.AutoSize = true;
            this.lblOptionA.Location = new System.Drawing.Point(471, 157);
            this.lblOptionA.Name = "lblOptionA";
            this.lblOptionA.Size = new System.Drawing.Size(48, 13);
            this.lblOptionA.TabIndex = 40;
            this.lblOptionA.Text = "Option A";
            // 
            // lblOptionB
            // 
            this.lblOptionB.AutoSize = true;
            this.lblOptionB.Location = new System.Drawing.Point(471, 201);
            this.lblOptionB.Name = "lblOptionB";
            this.lblOptionB.Size = new System.Drawing.Size(48, 13);
            this.lblOptionB.TabIndex = 41;
            this.lblOptionB.Text = "Option B";
            // 
            // lblOptionC
            // 
            this.lblOptionC.AutoSize = true;
            this.lblOptionC.Location = new System.Drawing.Point(471, 241);
            this.lblOptionC.Name = "lblOptionC";
            this.lblOptionC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOptionC.Size = new System.Drawing.Size(48, 13);
            this.lblOptionC.TabIndex = 42;
            this.lblOptionC.Text = "Option C";
            // 
            // lblOptionD
            // 
            this.lblOptionD.AutoSize = true;
            this.lblOptionD.Location = new System.Drawing.Point(471, 287);
            this.lblOptionD.Name = "lblOptionD";
            this.lblOptionD.Size = new System.Drawing.Size(49, 13);
            this.lblOptionD.TabIndex = 43;
            this.lblOptionD.Text = "Option D";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(445, 327);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(75, 13);
            this.lblCorrect.TabIndex = 44;
            this.lblCorrect.Text = "Correct Option";
            // 
            // lblQuiz
            // 
            this.lblQuiz.AutoSize = true;
            this.lblQuiz.Location = new System.Drawing.Point(479, 370);
            this.lblQuiz.Name = "lblQuiz";
            this.lblQuiz.Size = new System.Drawing.Size(40, 13);
            this.lblQuiz.TabIndex = 45;
            this.lblQuiz.Text = "Quiz Id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qidDataGridViewTextBoxColumn,
            this.qquestionDataGridViewTextBoxColumn,
            this.qoptionADataGridViewTextBoxColumn,
            this.qoptionBDataGridViewTextBoxColumn,
            this.qoptionCDataGridViewTextBoxColumn,
            this.qoptionDDataGridViewTextBoxColumn,
            this.qcorrectOptionDataGridViewTextBoxColumn,
            this.quizidfkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.questionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(415, 276);
            this.dataGridView1.TabIndex = 46;
            // 
            // qidDataGridViewTextBoxColumn
            // 
            this.qidDataGridViewTextBoxColumn.DataPropertyName = "q_id";
            this.qidDataGridViewTextBoxColumn.HeaderText = "q_id";
            this.qidDataGridViewTextBoxColumn.Name = "qidDataGridViewTextBoxColumn";
            this.qidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qquestionDataGridViewTextBoxColumn
            // 
            this.qquestionDataGridViewTextBoxColumn.DataPropertyName = "q_question";
            this.qquestionDataGridViewTextBoxColumn.HeaderText = "q_question";
            this.qquestionDataGridViewTextBoxColumn.Name = "qquestionDataGridViewTextBoxColumn";
            // 
            // qoptionADataGridViewTextBoxColumn
            // 
            this.qoptionADataGridViewTextBoxColumn.DataPropertyName = "q_optionA";
            this.qoptionADataGridViewTextBoxColumn.HeaderText = "q_optionA";
            this.qoptionADataGridViewTextBoxColumn.Name = "qoptionADataGridViewTextBoxColumn";
            // 
            // qoptionBDataGridViewTextBoxColumn
            // 
            this.qoptionBDataGridViewTextBoxColumn.DataPropertyName = "q_optionB";
            this.qoptionBDataGridViewTextBoxColumn.HeaderText = "q_optionB";
            this.qoptionBDataGridViewTextBoxColumn.Name = "qoptionBDataGridViewTextBoxColumn";
            // 
            // qoptionCDataGridViewTextBoxColumn
            // 
            this.qoptionCDataGridViewTextBoxColumn.DataPropertyName = "q_optionC";
            this.qoptionCDataGridViewTextBoxColumn.HeaderText = "q_optionC";
            this.qoptionCDataGridViewTextBoxColumn.Name = "qoptionCDataGridViewTextBoxColumn";
            // 
            // qoptionDDataGridViewTextBoxColumn
            // 
            this.qoptionDDataGridViewTextBoxColumn.DataPropertyName = "q_optionD";
            this.qoptionDDataGridViewTextBoxColumn.HeaderText = "q_optionD";
            this.qoptionDDataGridViewTextBoxColumn.Name = "qoptionDDataGridViewTextBoxColumn";
            // 
            // qcorrectOptionDataGridViewTextBoxColumn
            // 
            this.qcorrectOptionDataGridViewTextBoxColumn.DataPropertyName = "q_correctOption";
            this.qcorrectOptionDataGridViewTextBoxColumn.HeaderText = "q_correctOption";
            this.qcorrectOptionDataGridViewTextBoxColumn.Name = "qcorrectOptionDataGridViewTextBoxColumn";
            // 
            // quizidfkDataGridViewTextBoxColumn
            // 
            this.quizidfkDataGridViewTextBoxColumn.DataPropertyName = "quiz_id_fk";
            this.quizidfkDataGridViewTextBoxColumn.HeaderText = "quiz_id_fk";
            this.quizidfkDataGridViewTextBoxColumn.Name = "quizidfkDataGridViewTextBoxColumn";
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataMember = "questions";
            this.questionsBindingSource.DataSource = this.mathsGeniusDataSet;
            // 
            // mathsGeniusDataSet
            // 
            this.mathsGeniusDataSet.DataSetName = "MathsGeniusDataSet";
            this.mathsGeniusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questionsTableAdapter
            // 
            this.questionsTableAdapter.ClearBeforeFill = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(35, 209);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 23);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAdminQuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblQuiz);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblOptionD);
            this.Controls.Add(this.lblOptionC);
            this.Controls.Add(this.lblOptionB);
            this.Controls.Add(this.lblOptionA);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.txtQuiz);
            this.Controls.Add(this.txtCorrect);
            this.Controls.Add(this.txtOptionD);
            this.Controls.Add(this.txtOptionC);
            this.Controls.Add(this.txtOptionB);
            this.Controls.Add(this.txtOptionA);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.lblHeading);
            this.Name = "frmAdminQuest";
            this.Text = "AddQuestions";
            this.Load += new System.EventHandler(this.frmAddQuestions_Load);
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathsGeniusDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtOptionA;
        private System.Windows.Forms.TextBox txtOptionB;
        private System.Windows.Forms.TextBox txtOptionC;
        private System.Windows.Forms.TextBox txtOptionD;
        private System.Windows.Forms.TextBox txtCorrect;
        private System.Windows.Forms.TextBox txtQuiz;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblOptionA;
        private System.Windows.Forms.Label lblOptionB;
        private System.Windows.Forms.Label lblOptionC;
        private System.Windows.Forms.Label lblOptionD;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblQuiz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MathsGeniusDataSet mathsGeniusDataSet;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private MathsGeniusDataSetTableAdapters.questionsTableAdapter questionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn qidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qquestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qoptionADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qoptionBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qoptionCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qoptionDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qcorrectOptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quizidfkDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAdminUsers;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnExit;
    }
}