﻿using System;
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

        //private List<QuestionModel> GetTestQuestions(TestModel selected)
        //{
        //    QuestionService question = new QuestionService();
        //    List<QuestionModel> allQuestions = question.GetAll().ToList();
        //    List<QuestionModel> testQuestions = allQuestions.Where(item => item.TestID == selected.TestID).ToList();
           
        //    return testQuestions;
        //}

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
                btnStart.Visible = true;
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

            if (selectedQuestion == null)
            {
                MessageBox.Show("Please select a question.");
            }
            else
            {
                switch (buttonText)
                {
                    case "Edit":
                    case "Start Test":
                        CreateQuestionForm editQuestion = new CreateQuestionForm();
                        editQuestion.Test = Test;
                        editQuestion.EditMode = true;
                        editQuestion.Question = selectedQuestion;
                        editQuestion.ShowDialog();
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
            }
            else
            {
                MessageBox.Show("There are no questions in this test. Please select another one!");
            }
        }
    }
}
