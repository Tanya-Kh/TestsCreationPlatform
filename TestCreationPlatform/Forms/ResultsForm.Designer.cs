namespace TestCreationPlatform
{
    partial class ResultsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.lstCorrect = new System.Windows.Forms.ListBox();
            this.lstIncorrect = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correct";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Incorrect";
            // 
            // lstCorrect
            // 
            this.lstCorrect.FormattingEnabled = true;
            this.lstCorrect.ItemHeight = 16;
            this.lstCorrect.Location = new System.Drawing.Point(64, 79);
            this.lstCorrect.Name = "lstCorrect";
            this.lstCorrect.Size = new System.Drawing.Size(915, 132);
            this.lstCorrect.TabIndex = 2;
            // 
            // lstIncorrect
            // 
            this.lstIncorrect.FormattingEnabled = true;
            this.lstIncorrect.ItemHeight = 16;
            this.lstIncorrect.Location = new System.Drawing.Point(59, 290);
            this.lstIncorrect.Name = "lstIncorrect";
            this.lstIncorrect.Size = new System.Drawing.Size(915, 164);
            this.lstIncorrect.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Results:";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(59, 512);
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(915, 22);
            this.txtResults.TabIndex = 5;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 575);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstIncorrect);
            this.Controls.Add(this.lstCorrect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultsForm";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCorrect;
        private System.Windows.Forms.ListBox lstIncorrect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResults;
    }
}