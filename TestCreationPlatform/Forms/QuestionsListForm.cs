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

        public QuestionsListForm()
        {
            InitializeComponent();
        }

        private List<QuestionModel> GetTestQuestions(TestModel selected)
        {
            QuestionService question = new QuestionService();
            List<QuestionModel> allQuestions = question.GetAll().ToList();
            List<QuestionModel> testQuestions = allQuestions.Where(item => item.TestID == selected.TestID).ToList();
           
            return testQuestions;
        }

        private void QuestionsListForm_Load(object sender, EventArgs e)
        {
            DisplayTestInfo();
            ShowQuestions();
        }

        private void DisplayTestInfo()
        {
            lblTestName.Text = Test.TestName;
            lblDescription.Text = (Test.TestDescription == null) ? "No Description" : Test.TestDescription;
        }

        private void ShowQuestions()
        {
            Questions = GetTestQuestions(Test);

            lstQuestions.Items.Clear();
            lstQuestions.DisplayMember = "Question1";
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
            MessageBox.Show($"'{selectedQuestion.Question1}' question has been deleted.");
            ShowQuestions();
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
