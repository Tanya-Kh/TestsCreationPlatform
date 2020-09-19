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
            this.btnPassDelete = new System.Windows.Forms.Button();
            this.btnEditTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
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
            // btnPassDelete
            // 
            this.btnPassDelete.Location = new System.Drawing.Point(322, 377);
            this.btnPassDelete.Name = "btnPassDelete";
            this.btnPassDelete.Size = new System.Drawing.Size(188, 29);
            this.btnPassDelete.TabIndex = 2;
            this.btnPassDelete.UseVisualStyleBackColor = true;
            this.btnPassDelete.Click += new System.EventHandler(this.btnPassDelete_Click);
            // 
            // btnEditTest
            // 
            this.btnEditTest.Location = new System.Drawing.Point(322, 332);
            this.btnEditTest.Name = "btnEditTest";
            this.btnEditTest.Size = new System.Drawing.Size(188, 29);
            this.btnEditTest.TabIndex = 3;
            this.btnEditTest.Text = "Edit Test";
            this.btnEditTest.UseVisualStyleBackColor = true;
            this.btnEditTest.Visible = false;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.btnEditTest);
            this.Controls.Add(this.btnPassDelete);
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
        private System.Windows.Forms.Button btnPassDelete;
        private System.Windows.Forms.Button btnEditTest;
    }
}