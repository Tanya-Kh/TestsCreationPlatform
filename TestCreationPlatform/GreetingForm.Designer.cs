namespace TestCreationPlatform
{
    partial class GreetingForm
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
            this.imgQuiz = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateTest = new System.Windows.Forms.Button();
            this.btnPassTest = new System.Windows.Forms.Button();
            this.btnEditTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgQuiz)).BeginInit();
            this.SuspendLayout();
            // 
            // imgQuiz
            // 
            this.imgQuiz.Image = global::TestCreationPlatform.Properties.Resources.quiz;
            this.imgQuiz.Location = new System.Drawing.Point(275, 23);
            this.imgQuiz.Name = "imgQuiz";
            this.imgQuiz.Size = new System.Drawing.Size(233, 162);
            this.imgQuiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgQuiz.TabIndex = 1;
            this.imgQuiz.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 120);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello! \r\nWelcome to the Test Platform.\r\nYou can create, edit or pass tests here. " +
    "\r\nPlease select below:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCreateTest
            // 
            this.btnCreateTest.AutoSize = true;
            this.btnCreateTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTest.Location = new System.Drawing.Point(111, 363);
            this.btnCreateTest.Name = "btnCreateTest";
            this.btnCreateTest.Size = new System.Drawing.Size(159, 43);
            this.btnCreateTest.TabIndex = 3;
            this.btnCreateTest.Text = "Create Test";
            this.btnCreateTest.UseVisualStyleBackColor = true;
            // 
            // btnPassTest
            // 
            this.btnPassTest.AutoSize = true;
            this.btnPassTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassTest.Location = new System.Drawing.Point(531, 363);
            this.btnPassTest.Name = "btnPassTest";
            this.btnPassTest.Size = new System.Drawing.Size(128, 43);
            this.btnPassTest.TabIndex = 4;
            this.btnPassTest.Text = "Pass Test";
            this.btnPassTest.UseVisualStyleBackColor = true;
            // 
            // btnEditTest
            // 
            this.btnEditTest.AutoSize = true;
            this.btnEditTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTest.Location = new System.Drawing.Point(335, 363);
            this.btnEditTest.Name = "btnEditTest";
            this.btnEditTest.Size = new System.Drawing.Size(124, 43);
            this.btnEditTest.TabIndex = 5;
            this.btnEditTest.Text = "Edit Test";
            this.btnEditTest.UseVisualStyleBackColor = true;
            // 
            // GreetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditTest);
            this.Controls.Add(this.btnPassTest);
            this.Controls.Add(this.btnCreateTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgQuiz);
            this.Name = "GreetingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Greeting";
            ((System.ComponentModel.ISupportInitialize)(this.imgQuiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgQuiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateTest;
        private System.Windows.Forms.Button btnPassTest;
        private System.Windows.Forms.Button btnEditTest;
    }
}

