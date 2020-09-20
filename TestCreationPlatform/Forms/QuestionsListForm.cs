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
        public List<QuestionModel> Questions { get; set; }
        public TestModel Test { get; set; }

        public QuestionsListForm()
        {
            InitializeComponent();
        }

        private void QuestionsListForm_Load(object sender, EventArgs e)
        {
            DisplayTestInfo();
            ShowQuestions(this.Questions);
        }

        private void DisplayTestInfo()
        {
            lblTestName.Text = this.Test.TestName;
            lblDescription.Text = (this.Test.TestDescription == null) ? "No Description" : this.Test.TestDescription;
        }

        private void ShowQuestions(List<QuestionModel> questions)
        {
            //QuestionService question = new QuestionService();
            //var questions = question.GetAll().ToList();

            lstQuestions.Items.Clear();
            lstQuestions.DisplayMember = "Question1";
            lstQuestions.ValueMember = "QuestionID";

            foreach (QuestionModel item in questions)
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
            MessageBox.Show($"'{selectedQuestion.Question1}' question has been deleted.");
            ShowQuestions(this.Questions);
        }

        private void btnDeleteEditQuestion_Click(object sender, EventArgs e)
        {
            string buttonText = (sender as Button).Text;
            QuestionModel selectedQuestion = (QuestionModel)lstQuestions.SelectedItem;

            //Debug.WriteLine(buttonText);
            if (selectedQuestion == null)
            {
                MessageBox.Show("Please select a question.");
            }
            else
            {
                switch (buttonText)
                {
                    case "Edit":
                        //case "Pass Test":
                        Debug.WriteLine(buttonText);
                        break;
                    case "Delete":
                        DeleteQuestion(selectedQuestion);
                        break;
                }
            }
        }
    }
}
