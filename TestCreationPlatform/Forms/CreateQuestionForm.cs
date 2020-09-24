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

        public bool EditMode { get; set; }

        public CreateQuestionForm()
        {
            InitializeComponent();
        }

        private void CreateQuestionForm_Load(object sender, EventArgs e)
        {
            DisplayQuestionInfo();
            if (EditMode)
            {
                this.Text = "Edit Question";
                btnNext.Text = "Save";
                btnFinish.Visible = false;
            }
        }

        private void DisplayAnswers()
        {
            AnswerService answer = new AnswerService();
            List<AnswerModel> answers = answer.GetQuestionAnswers(Question);
            AnswerModel correctAnswer = answers.Where(item => item.IsCorrect == true).FirstOrDefault();
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

        private void rdoOpen_CheckedChanged(object sender, EventArgs e)
        {
            grpIncorrectAnswers.Visible = (rdoOpen.Checked) ? false : true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisplayQuestionInfo();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (btnNext.Text)
            {
                case "Save":
                    UpdateQuestion();
                    UpdateAnswers();
                    break;
                default:
                    break;
            }
        }

        private void UpdateQuestion()
        {
            QuestionService question = new QuestionService();

            Question.QuestionText = txtQuestion.Text;
            Question.Type = (rdoOpen.Checked) ? 1 : 2;
//FIX: DELETE INCORRECT ANSWERS IF OPEN QUESTION

            question.Update(Question.QuestionID, Question);
            MessageBox.Show($"Question has been updated.");
            
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
    }
}
