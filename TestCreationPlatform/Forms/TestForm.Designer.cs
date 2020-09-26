namespace TestCreationPlatform
{
    partial class TestForm
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
            this.lstTests = new System.Windows.Forms.ListBox();
            this.btnEditPass = new System.Windows.Forms.Button();
            this.btnDeleteTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select a test:";
            // 
            // lstTests
            // 
            this.lstTests.FormattingEnabled = true;
            this.lstTests.ItemHeight = 16;
            this.lstTests.Location = new System.Drawing.Point(169, 99);
            this.lstTests.Name = "lstTests";
            this.lstTests.Size = new System.Drawing.Size(502, 212);
            this.lstTests.TabIndex = 1;
            // 
            // btnEditPass
            // 
            this.btnEditPass.Location = new System.Drawing.Point(322, 377);
            this.btnEditPass.Name = "btnEditPass";
            this.btnEditPass.Size = new System.Drawing.Size(188, 29);
            this.btnEditPass.TabIndex = 2;
            this.btnEditPass.UseVisualStyleBackColor = true;
            this.btnEditPass.Click += new System.EventHandler(this.btnPassDeleteEdit_Click);
            // 
            // btnDeleteTest
            // 
            this.btnDeleteTest.Location = new System.Drawing.Point(322, 332);
            this.btnDeleteTest.Name = "btnDeleteTest";
            this.btnDeleteTest.Size = new System.Drawing.Size(188, 29);
            this.btnDeleteTest.TabIndex = 3;
            this.btnDeleteTest.Text = "Delete Test";
            this.btnDeleteTest.UseVisualStyleBackColor = true;
            this.btnDeleteTest.Visible = false;
            this.btnDeleteTest.Click += new System.EventHandler(this.btnPassDeleteEdit_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.btnDeleteTest);
            this.Controls.Add(this.btnEditPass);
            this.Controls.Add(this.lstTests);
            this.Controls.Add(this.label1);
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tests";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstTests;
        private System.Windows.Forms.Button btnEditPass;
        private System.Windows.Forms.Button btnDeleteTest;
    }
}