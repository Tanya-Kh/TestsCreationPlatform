namespace TestCreationPlatform
{
    partial class CreateQuestionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.rdoOpen = new System.Windows.Forms.RadioButton();
            this.rdoClosed = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIncorrect1 = new System.Windows.Forms.TextBox();
            this.txtIncorrect2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorrectAnswer = new System.Windows.Forms.TextBox();
            this.txtIncorrect3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpIncorrectAnswers = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpIncorrectAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question:";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(212, 76);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(552, 21);
            this.txtQuestion.TabIndex = 1;
            // 
            // rdoOpen
            // 
            this.rdoOpen.AutoSize = true;
            this.rdoOpen.Location = new System.Drawing.Point(215, 149);
            this.rdoOpen.Name = "rdoOpen";
            this.rdoOpen.Size = new System.Drawing.Size(64, 21);
            this.rdoOpen.TabIndex = 2;
            this.rdoOpen.TabStop = true;
            this.rdoOpen.Text = "Open";
            this.rdoOpen.UseVisualStyleBackColor = true;
            this.rdoOpen.CheckedChanged += new System.EventHandler(this.rdoOpen_CheckedChanged);
            // 
            // rdoClosed
            // 
            this.rdoClosed.AutoSize = true;
            this.rdoClosed.Location = new System.Drawing.Point(305, 149);
            this.rdoClosed.Name = "rdoClosed";
            this.rdoClosed.Size = new System.Drawing.Size(72, 21);
            this.rdoClosed.TabIndex = 3;
            this.rdoClosed.TabStop = true;
            this.rdoClosed.Text = "Closed";
            this.rdoClosed.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Question type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Incorrect answer:";
            // 
            // txtIncorrect1
            // 
            this.txtIncorrect1.Location = new System.Drawing.Point(150, 15);
            this.txtIncorrect1.Name = "txtIncorrect1";
            this.txtIncorrect1.Size = new System.Drawing.Size(549, 22);
            this.txtIncorrect1.TabIndex = 8;
            // 
            // txtIncorrect2
            // 
            this.txtIncorrect2.Location = new System.Drawing.Point(150, 63);
            this.txtIncorrect2.Name = "txtIncorrect2";
            this.txtIncorrect2.Size = new System.Drawing.Size(549, 22);
            this.txtIncorrect2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Incorrect answer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Incorrect answer:";
            // 
            // txtCorrectAnswer
            // 
            this.txtCorrectAnswer.Location = new System.Drawing.Point(215, 207);
            this.txtCorrectAnswer.Name = "txtCorrectAnswer";
            this.txtCorrectAnswer.Size = new System.Drawing.Size(549, 22);
            this.txtCorrectAnswer.TabIndex = 6;
            // 
            // txtIncorrect3
            // 
            this.txtIncorrect3.Location = new System.Drawing.Point(150, 111);
            this.txtIncorrect3.Name = "txtIncorrect3";
            this.txtIncorrect3.Size = new System.Drawing.Size(549, 22);
            this.txtIncorrect3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Correct answer:";
            // 
            // grpIncorrectAnswers
            // 
            this.grpIncorrectAnswers.Controls.Add(this.label4);
            this.grpIncorrectAnswers.Controls.Add(this.txtIncorrect3);
            this.grpIncorrectAnswers.Controls.Add(this.txtIncorrect1);
            this.grpIncorrectAnswers.Controls.Add(this.label6);
            this.grpIncorrectAnswers.Controls.Add(this.label5);
            this.grpIncorrectAnswers.Controls.Add(this.txtIncorrect2);
            this.grpIncorrectAnswers.Location = new System.Drawing.Point(65, 235);
            this.grpIncorrectAnswers.Name = "grpIncorrectAnswers";
            this.grpIncorrectAnswers.Size = new System.Drawing.Size(716, 156);
            this.grpIncorrectAnswers.TabIndex = 13;
            this.grpIncorrectAnswers.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(245, 397);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(132, 41);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Save";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(447, 397);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(304, 41);
            this.btnFinish.TabIndex = 15;
            this.btnFinish.Text = "Finish Test Creation";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // txtTestName
            // 
            this.txtTestName.Location = new System.Drawing.Point(212, 35);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.ReadOnly = true;
            this.txtTestName.Size = new System.Drawing.Size(552, 22);
            this.txtTestName.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Test:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(65, 397);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 41);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CreateQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 464);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtTestName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grpIncorrectAnswers);
            this.Controls.Add(this.txtCorrectAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdoClosed);
            this.Controls.Add(this.rdoOpen);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label1);
            this.Name = "CreateQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateQuestion";
            this.Load += new System.EventHandler(this.CreateQuestionForm_Load);
            this.grpIncorrectAnswers.ResumeLayout(false);
            this.grpIncorrectAnswers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.RadioButton rdoOpen;
        private System.Windows.Forms.RadioButton rdoClosed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIncorrect1;
        private System.Windows.Forms.TextBox txtIncorrect2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorrectAnswer;
        private System.Windows.Forms.TextBox txtIncorrect3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpIncorrectAnswers;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
    }
}