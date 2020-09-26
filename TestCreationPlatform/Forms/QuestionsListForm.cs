using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCreationPlatform.BLL.Models;
using TestCreationPlatform.BLL.Services.Implementations;

namespace TestCreationPlatform.Forms
{
    public partial class QuestionsListForm : Form
    {
        private List<QuestionModel> Questions { get; set; }
        public TestModel Test { get; set; }

        private readonly string mode;

        public QuestionsListForm(string clickedButton)
        {
            InitializeComponent();
            mode = clickedButton;
        }


        private void QuestionsListForm_Load(object sender, EventArgs e)
        {
            DisplayTestInfo();
            ShowQuestions();

            if (mode == "Start Test")
            {
                this.Text = mode;
                lstQuestions.Visible = false;
                label1.Text = $" Prepare for {Questions.Count } question(s).\n Good luck!";
                btnDeleteQuestion.Visible = false;
                btnEditQUestion.Visible = false;
                btnAdd.Visible = false;
                btnStart.Visible = true;
                lnkUpdateTestInfo.Visible = false;
            }
        }

        private void DisplayTestInfo()
        {
            lblTestName.Text = Test.TestName;
            lblDescription.Text = (Test.TestDescription == null) ? "No Description" : Test.TestDescription;
        }

        public void ShowQuestions()
        {
            QuestionService question = new QuestionService();
            Questions = question.GetTestQuestions(Test);

            lstQuestions.Items.Clear();
            lstQuestions.DisplayMember = "QuestionText";
            lstQuestions.ValueMember = "QuestionID";

            foreach (QuestionModel item in Questions)
            {
                lstQuestions.Items.Add(item);
            }
        }

        private void btnEditPass_Click(object sender, EventArgs e)
        {

        }

        private void DeleteQuestion(QuestionModel selectedQuestion)
        {
            QuestionService question = new QuestionService();
            question.Delete(selectedQuestion.QuestionID);
            MessageBox.Show($"'{selectedQuestion.QuestionText}' question has been deleted.");
            ShowQuestions();
        }

        private void btnDeleteEditQuestion_Click(object sender, EventArgs e)
        {
            string buttonText = (sender as Button).Text;
            QuestionModel selectedQuestion = (QuestionModel)lstQuestions.SelectedItem;

            if (buttonText != "Add" && selectedQuestion == null)
            {
                MessageBox.Show("Please select a question.");
            }
            else
            {
                switch (buttonText)
                {
                    case "Add":
                    case "Edit":
                    case "Start Test":
                        CreateQuestionForm editQuestion = new CreateQuestionForm();
                        editQuestion.Test = Test;
                        editQuestion.EditMode = buttonText;
                        if (selectedQuestion != null)
                        {
                            editQuestion.Question = selectedQuestion;
                        }
                        editQuestion.ShowDialog();
                        ShowQuestions();
                        break;
                    case "Delete":
                        DeleteQuestion(selectedQuestion);
                        break;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Questions.Count > 0)
            {
                QuestionForm questionForm = new QuestionForm(Questions);
                questionForm.Show();
                Close();
            }
            else
            {
                MessageBox.Show("There are no questions in this test. Please select another one!");
            }
        }

        private void lnkUpdateTestInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnkUpdateTestInfo.Text == "Save changes")
            {
                TestService test = new TestService();
                if (!string.IsNullOrEmpty(lblTestName.Text) && !string.IsNullOrEmpty(lblDescription.Text))
                {
                    test.Update(Test.TestID, new TestModel
                    {
                        TestID = Test.TestID,
                        TestName = lblTestName.Text,
                        TestDescription = lblDescription.Text,
                        TopicID = Test.TopicID
                    });
                    MessageBox.Show("Test information has been updated.");
                    Test = test.GetItem(Test.TestID);
                    DisplayTestInfo();
                }
                else
                {
                    MessageBox.Show("Please complete both Test Name and Description.");
                }
            }
            else
            {
                lblDescription.ReadOnly = false;
                lblTestName.ReadOnly = false;
                lnkUpdateTestInfo.Text = "Save changes";
            }
        }
    }
}
