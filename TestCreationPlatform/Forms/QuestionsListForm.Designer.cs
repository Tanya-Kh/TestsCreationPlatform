namespace TestCreationPlatform.Forms
{
    partial class QuestionsListForm
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
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.btnEditQUestion = new System.Windows.Forms.Button();
            this.lstQuestions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lable40 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTestName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.TextBox();
            this.lnkUpdateTestInfo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.Location = new System.Drawing.Point(28, 274);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(188, 29);
            this.btnDeleteQuestion.TabIndex = 7;
            this.btnDeleteQuestion.Text = "Delete";
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteEditQuestion_Click);
            // 
            // btnEditQUestion
            // 
            this.btnEditQUestion.Location = new System.Drawing.Point(304, 274);
            this.btnEditQUestion.Name = "btnEditQUestion";
            this.btnEditQUestion.Size = new System.Drawing.Size(188, 29);
            this.btnEditQUestion.TabIndex = 6;
            this.btnEditQUestion.Text = "Edit";
            this.btnEditQUestion.UseVisualStyleBackColor = true;
            this.btnEditQUestion.Click += new System.EventHandler(this.btnDeleteEditQuestion_Click);
            // 
            // lstQuestions
            // 
            this.lstQuestions.FormattingEnabled = true;
            this.lstQuestions.ItemHeight = 16;
            this.lstQuestions.Location = new System.Drawing.Point(28, 129);
            this.lstQuestions.Name = "lstQuestions";
            this.lstQuestions.Size = new System.Drawing.Size(744, 116);
            this.lstQuestions.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Questions:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Test Name:";
            // 
            // lable40
            // 
            this.lable40.AutoSize = true;
            this.lable40.Location = new System.Drawing.Point(25, 59);
            this.lable40.Name = "lable40";
            this.lable40.Size = new System.Drawing.Size(83, 17);
            this.lable40.TabIndex = 10;
            this.lable40.Text = "Description:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(349, 274);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(188, 29);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(584, 274);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 29);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnDeleteEditQuestion_Click);
            // 
            // lblTestName
            // 
            this.lblTestName.Location = new System.Drawing.Point(145, 20);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.ReadOnly = true;
            this.lblTestName.Size = new System.Drawing.Size(324, 22);
            this.lblTestName.TabIndex = 14;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(145, 59);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.ReadOnly = true;
            this.lblDescription.Size = new System.Drawing.Size(324, 22);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Description";
            // 
            // lnkUpdateTestInfo
            // 
            this.lnkUpdateTestInfo.AutoSize = true;
            this.lnkUpdateTestInfo.Location = new System.Drawing.Point(516, 40);
            this.lnkUpdateTestInfo.Name = "lnkUpdateTestInfo";
            this.lnkUpdateTestInfo.Size = new System.Drawing.Size(164, 17);
            this.lnkUpdateTestInfo.TabIndex = 16;
            this.lnkUpdateTestInfo.TabStop = true;
            this.lnkUpdateTestInfo.Text = "Change Test/Description";
            this.lnkUpdateTestInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUpdateTestInfo_LinkClicked);
            // 
            // QuestionsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 317);
            this.Controls.Add(this.lnkUpdateTestInfo);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTestName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lable40);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteQuestion);
            this.Controls.Add(this.btnEditQUestion);
            this.Controls.Add(this.lstQuestions);
            this.Controls.Add(this.label1);
            this.Name = "QuestionsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questions List";
            this.Load += new System.EventHandler(this.QuestionsListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.Button btnEditQUestion;
        private System.Windows.Forms.ListBox lstQuestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable40;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox lblTestName;
        private System.Windows.Forms.TextBox lblDescription;
        private System.Windows.Forms.LinkLabel lnkUpdateTestInfo;
    }
}