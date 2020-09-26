using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCreationPlatform.BLL.Models;
using TestCreationPlatform.BLL.Services.Implementations;
using TestCreationPlatform.Forms;
using TestCreationPlatform.BLL;

namespace TestCreationPlatform
{
    public partial class CreateQuestionForm : Form
    {
        public TestModel Test { get; set; }

        public QuestionModel Question { get; set; }

        public string EditMode { get; set; }

        public CreateQuestionForm()
        {
            InitializeComponent();
        }

        private void CreateQuestionForm_Load(object sender, EventArgs e)
        {
            if (EditMode == "Edit")
            {
                this.Text = "Edit Question";
                btnNext.Text = "Update";
                btnFinish.Visible = false;

            }

            DisplayQuestionInfo();
        }

        private void DisplayAnswers()
        {
            AnswerService answer = new AnswerService();
            List<AnswerModel> answers = answer.GetQuestionAnswers(Question);
            AnswerModel correctAnswer = answers.FirstOrDefault(item => item.IsCorrect == true);
            Question.CorrrectAnswer = correctAnswer;
            txtCorrectAnswer.Text = String.Empty;

            Helpers.ClearTextBoxes(grpIncorrectAnswers.Controls);
            txtCorrectAnswer.Text = correctAnswer.AnswerText;

            if (answers.Count > 1)
            {
                List<AnswerModel> incorrectAnswers = answers.Where(item => item.IsCorrect == false).ToList();
                txtIncorrect1.Text = incorrectAnswers[0].AnswerText;
                txtIncorrect2.Text = incorrectAnswers[1].AnswerText;
                txtIncorrect3.Text = incorrectAnswers[2].AnswerText;
                Question.IncorrectAnswerText = incorrectAnswers[0];
                Question.IncorrectAnswer2 = incorrectAnswers[1];
                Question.IncorrectAnswer3 = incorrectAnswers[2];
            }
        }

        private void DisplayQuestionInfo()
        {
            txtTestName.Text = Test.TestName;

            if (EditMode == "Edit")
            {
                txtQuestion.Text = Question.QuestionText;

                if (Question.Type == 1)
                {
                    rdoOpen.Checked = true;
                }
                else
                {
                    rdoClosed.Checked = true;
                }
                DisplayAnswers();
            }
        }

        private void rdoOpen_CheckedChanged(object sender, EventArgs e)
        {
            grpIncorrectAnswers.Visible = (rdoOpen.Checked) ? false : true;
            Helpers.ClearTextBoxes(grpIncorrectAnswers.Controls);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisplayQuestionInfo();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (btnNext.Text)
            {
                case "Update":
                    UpdateQuestion();
                    UpdateAnswers();
                    break;
                default:
                    SaveQuestion();
                    break;
            }
        }
        private bool IsValid()
        {
            bool isValid = false;

            List<string> textBoxes = new List<string>() { txtTestName.Text, txtCorrectAnswer.Text };
            
            if (rdoClosed.Checked)
            {
                textBoxes.Add(txtIncorrect1.Text);
                textBoxes.Add(txtIncorrect2.Text);
                textBoxes.Add(txtIncorrect3.Text);
            }
            else if (!rdoOpen.Checked)
            {
                return isValid;
            }

            foreach (var item in textBoxes)
            {
                isValid = !string.IsNullOrEmpty(item) && textBoxes.Distinct().Count() == textBoxes.Count();
            }

            return isValid;
        }

        private void SaveQuestion()
        {
            if (IsValid())
            {
                QuestionService question = new QuestionService();

                question.Create(new QuestionModel
                {
                    TestID = Test.TestID,
                    QuestionText = txtQuestion.Text,
                    Type = (rdoClosed.Checked) ? 2 : 1
                });

                int createdQuestionID = question.GetTestQuestions(Test).OrderByDescending(item => item.QuestionID).First().QuestionID;
                SaveAnswers(createdQuestionID);
            }
            else
            {
                MessageBox.Show("ERROR!Please check that all fields are completed and answers are different.");
            }
        }

        private void SaveAnswers(int questionID)
        {
            AnswerService answer = new AnswerService();
            answer.Create(new AnswerModel
            {
                QuestionID = questionID,
                AnswerText = txtCorrectAnswer.Text,
                IsCorrect = true
            });

            if (rdoClosed.Checked)
            {
                SaveIncorrectAnswers(questionID);
            }
            MessageBox.Show("The question has been saved!");
            Helpers.ClearTextBoxes(this.Controls);
            Helpers.ClearTextBoxes(grpIncorrectAnswers.Controls);
            DisplayQuestionInfo();
        }

        private void SaveIncorrectAnswers(int questionID)
        {
            AnswerService answer = new AnswerService();
            foreach (var item in grpIncorrectAnswers.Controls)
            {
                if (item is TextBox)
                {
                    answer.Create(new AnswerModel
                    {
                        QuestionID = questionID,
                        AnswerText = ((TextBox)item).Text,
                        IsCorrect = false
                    });
                }
            }
        }

        private void UpdateQuestion()
        {
            QuestionService question = new QuestionService();

            Question.QuestionText = txtQuestion.Text;
            Question.Type = (rdoOpen.Checked) ? 1 : 2;
            
            if (IsValid())
            {
                question.Update(Question.QuestionID, Question);
                MessageBox.Show($"Question has been updated.");
            }
            else
            {
                MessageBox.Show("ERROR!Please check that all fields are completed and answers are different.");
            }
            //FIX: UPDATE Questions List on QuestionListForm
            //QuestionsListForm questionList = new QuestionsListForm();
            //questionList.ShowQuestions();
        }

        private void UpdateAnswers()
        {
            Question.CorrrectAnswer.AnswerText = txtCorrectAnswer.Text;
            Question.IncorrectAnswerText.AnswerText = txtIncorrect1.Text;
            Question.IncorrectAnswer2.AnswerText = txtIncorrect2.Text;
            Question.IncorrectAnswer3.AnswerText = txtIncorrect3.Text;
            AnswerService answer = new AnswerService();
            List<AnswerModel> answers = Question.GetAnswers();

            foreach (var item in answers)
            {
                answer.Update(item.AnswerID, item);
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
