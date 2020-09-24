using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCreationPlatform.BLL;
using TestCreationPlatform.BLL.Models;
using TestCreationPlatform.BLL.Services.Implementations;

namespace TestCreationPlatform
{
    public partial class QuestionForm : Form
    {
        private List<QuestionModel> questions = null;
        private QuestionModel currentQuestion = null;
        List<string> correctAnswers = new List<string>();
        List<string> inCorrectAnswers = new List<string>();
        int questionNumber = 0;

        public QuestionForm(List<QuestionModel> list)
        {
            InitializeComponent();
            questions = list;
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            DisplayQuestion(questions[questionNumber]);
        }

        private void DisplayQuestion(QuestionModel question)
        {
            lblQuestion.Text = question.QuestionText;
            currentQuestion = question;

            if (question.Type == 1)
            {
                groupBoxAnswers.Visible = false;
                txtOpenAnswer.Clear();
                txtOpenAnswer.Visible = true;
                btnNextQuestion.Visible = true;
            }
            else
            {
                ShowAnswers(question);
            }
            questionNumber += 1;
        }

        private void ShowAnswers(QuestionModel question)
        {
            groupBoxAnswers.Visible = true;
            txtOpenAnswer.Visible = false;
            btnNextQuestion.Visible = false;
            AnswerService answer = new AnswerService();
            var ans = answer.GetQuestionAnswers(question);
            var answers = Helpers.Shuffle(ans);
            var buttons = groupBoxAnswers.Controls;

            for (int i = 0; i < answers.Count; i++)
            {
                buttons[i].Text = answers[i].AnswerText;
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }

        private void NextQuestion()
        {
            if (txtOpenAnswer.Visible)
            {
                CheckOpenAnswer();

            }
            if (questionNumber < questions.Count)
            {
                
                DisplayQuestion(questions[questionNumber]);
            }
            else
            {
                ResultsForm results = new ResultsForm(correctAnswers, inCorrectAnswers, currentQuestion.TestID, questions.Count);
                btnNextQuestion.Visible = false;
                results.Show();
            }
        }

        private void CheckOpenAnswer()
        {
            AnswerService answer = new AnswerService();
            IsCorrectAnswer(txtOpenAnswer.Text, answer.GetCorrectAnswer(currentQuestion).AnswerText);
        }

        private void CheckClosedAnswer(object sender, MouseEventArgs e)
        {
            AnswerService answer = new AnswerService();
            string selectedAnswer = ((Button)sender).Text;
            IsCorrectAnswer(selectedAnswer, answer.GetCorrectAnswer(currentQuestion).AnswerText);
            NextQuestion();
        }

        private void IsCorrectAnswer(string userAnswer, string correctAnswer)
        {
            if (userAnswer == correctAnswer)
            {
                correctAnswers.Add(currentQuestion.QuestionText);
            }
            else
            {
                inCorrectAnswers.Add(currentQuestion.QuestionText);
            }
        }
    }
}
