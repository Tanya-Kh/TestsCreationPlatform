namespace TestCreationPlatform
{
    partial class CreateTestForm
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTopics = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSubTopics = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSubSubTopics = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.linkTopicAdd = new System.Windows.Forms.LinkLabel();
            this.linkTopicDelete = new System.Windows.Forms.LinkLabel();
            this.linkDeleteSubTopic = new System.Windows.Forms.LinkLabel();
            this.linkAddSubTopic = new System.Windows.Forms.LinkLabel();
            this.linkDeleteSubSubTopic = new System.Windows.Forms.LinkLabel();
            this.linkAddSubSubTopic = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(397, 403);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Topic";
            // 
            // cboTopics
            // 
            this.cboTopics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTopics.FormattingEnabled = true;
            this.cboTopics.Location = new System.Drawing.Point(239, 51);
            this.cboTopics.Name = "cboTopics";
            this.cboTopics.Size = new System.Drawing.Size(411, 24);
            this.cboTopics.TabIndex = 6;
            this.cboTopics.DropDown += new System.EventHandler(this.cboTopics_DropDown);
            this.cboTopics.SelectedIndexChanged += new System.EventHandler(this.cboTopics_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Test description*";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(239, 259);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(411, 22);
            this.txtDescription.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 314);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 22);
            this.textBox1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Time to pass a test (minutes)*";
            // 
            // cboSubTopics
            // 
            this.cboSubTopics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubTopics.Enabled = false;
            this.cboSubTopics.FormattingEnabled = true;
            this.cboSubTopics.Location = new System.Drawing.Point(239, 103);
            this.cboSubTopics.Name = "cboSubTopics";
            this.cboSubTopics.Size = new System.Drawing.Size(411, 24);
            this.cboSubTopics.TabIndex = 14;
            this.cboSubTopics.DropDown += new System.EventHandler(this.cboTopics_DropDown);
            this.cboSubTopics.SelectedIndexChanged += new System.EventHandler(this.cboSubTopics_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Subtopic*";
            // 
            // cboSubSubTopics
            // 
            this.cboSubSubTopics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubSubTopics.Enabled = false;
            this.cboSubSubTopics.FormattingEnabled = true;
            this.cboSubSubTopics.Location = new System.Drawing.Point(239, 153);
            this.cboSubSubTopics.Name = "cboSubSubTopics";
            this.cboSubSubTopics.Size = new System.Drawing.Size(411, 24);
            this.cboSubSubTopics.TabIndex = 16;
            this.cboSubSubTopics.DropDown += new System.EventHandler(this.cboTopics_DropDown);
            this.cboSubSubTopics.SelectedIndexChanged += new System.EventHandler(this.cboSubSubTopics_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "SubSubTopic*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "* - Optional ";
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(239, 203);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(411, 22);
            this.txtTest.TabIndex = 18;
            // 
            // linkTopicAdd
            // 
            this.linkTopicAdd.AutoSize = true;
            this.linkTopicAdd.Location = new System.Drawing.Point(680, 58);
            this.linkTopicAdd.Name = "linkTopicAdd";
            this.linkTopicAdd.Size = new System.Drawing.Size(33, 17);
            this.linkTopicAdd.TabIndex = 19;
            this.linkTopicAdd.TabStop = true;
            this.linkTopicAdd.Text = "Add";
            this.linkTopicAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTopicAdd_LinkClicked);
            // 
            // linkTopicDelete
            // 
            this.linkTopicDelete.AutoSize = true;
            this.linkTopicDelete.Location = new System.Drawing.Point(737, 58);
            this.linkTopicDelete.Name = "linkTopicDelete";
            this.linkTopicDelete.Size = new System.Drawing.Size(49, 17);
            this.linkTopicDelete.TabIndex = 20;
            this.linkTopicDelete.TabStop = true;
            this.linkTopicDelete.Text = "Delete";
            this.linkTopicDelete.Visible = false;
            this.linkTopicDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTopicDelete_LinkClicked);
            // 
            // linkDeleteSubTopic
            // 
            this.linkDeleteSubTopic.AutoSize = true;
            this.linkDeleteSubTopic.Location = new System.Drawing.Point(737, 106);
            this.linkDeleteSubTopic.Name = "linkDeleteSubTopic";
            this.linkDeleteSubTopic.Size = new System.Drawing.Size(49, 17);
            this.linkDeleteSubTopic.TabIndex = 23;
            this.linkDeleteSubTopic.TabStop = true;
            this.linkDeleteSubTopic.Text = "Delete";
            this.linkDeleteSubTopic.Visible = false;
            this.linkDeleteSubTopic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDeleteSubTopic_LinkClicked);
            // 
            // linkAddSubTopic
            // 
            this.linkAddSubTopic.AutoSize = true;
            this.linkAddSubTopic.Location = new System.Drawing.Point(680, 106);
            this.linkAddSubTopic.Name = "linkAddSubTopic";
            this.linkAddSubTopic.Size = new System.Drawing.Size(33, 17);
            this.linkAddSubTopic.TabIndex = 22;
            this.linkAddSubTopic.TabStop = true;
            this.linkAddSubTopic.Text = "Add";
            this.linkAddSubTopic.Visible = false;
            this.linkAddSubTopic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAddSubTopic_LinkClicked);
            // 
            // linkDeleteSubSubTopic
            // 
            this.linkDeleteSubSubTopic.AutoSize = true;
            this.linkDeleteSubSubTopic.Location = new System.Drawing.Point(737, 156);
            this.linkDeleteSubSubTopic.Name = "linkDeleteSubSubTopic";
            this.linkDeleteSubSubTopic.Size = new System.Drawing.Size(49, 17);
            this.linkDeleteSubSubTopic.TabIndex = 25;
            this.linkDeleteSubSubTopic.TabStop = true;
            this.linkDeleteSubSubTopic.Text = "Delete";
            this.linkDeleteSubSubTopic.Visible = false;
            this.linkDeleteSubSubTopic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDeleteSubSubTopic_LinkClicked);
            // 
            // linkAddSubSubTopic
            // 
            this.linkAddSubSubTopic.AutoSize = true;
            this.linkAddSubSubTopic.Location = new System.Drawing.Point(680, 156);
            this.linkAddSubSubTopic.Name = "linkAddSubSubTopic";
            this.linkAddSubSubTopic.Size = new System.Drawing.Size(33, 17);
            this.linkAddSubSubTopic.TabIndex = 24;
            this.linkAddSubSubTopic.TabStop = true;
            this.linkAddSubSubTopic.Text = "Add";
            this.linkAddSubSubTopic.Visible = false;
            this.linkAddSubSubTopic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAddSubSubTopic_LinkClicked);
            // 
            // CreateTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 463);
            this.Controls.Add(this.linkDeleteSubSubTopic);
            this.Controls.Add(this.linkAddSubSubTopic);
            this.Controls.Add(this.linkDeleteSubTopic);
            this.Controls.Add(this.linkAddSubTopic);
            this.Controls.Add(this.linkTopicDelete);
            this.Controls.Add(this.linkTopicAdd);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboSubSubTopics);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboSubTopics);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTopics);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Name = "CreateTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Test";
            this.Load += new System.EventHandler(this.CreateTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTopics;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSubTopics;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSubSubTopics;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.LinkLabel linkTopicAdd;
        private System.Windows.Forms.LinkLabel linkTopicDelete;
        private System.Windows.Forms.LinkLabel linkDeleteSubTopic;
        private System.Windows.Forms.LinkLabel linkAddSubTopic;
        private System.Windows.Forms.LinkLabel linkDeleteSubSubTopic;
        private System.Windows.Forms.LinkLabel linkAddSubSubTopic;
    }
}