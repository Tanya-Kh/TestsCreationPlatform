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
using TestCreationPlatform.Forms;

namespace TestCreationPlatform
{
    public partial class TestForm : Form
    {
        TestService test = new TestService();

        public TestForm(string btn)
        {
            InitializeComponent();
            btnEditPass.Text = btn;

            if (btn != "Pass Test")
            {
                btnEditPass.Text = "Edit Test";
                btnDeleteTest.Visible = true;
            }
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            ShowTests();
        }

        private void ShowTests()
        {
            var tests = test.GetAll().ToList();

            lstTests.Items.Clear();
            lstTests.DisplayMember = "TestName";
            lstTests.ValueMember = "TestID";

            foreach (TestModel item in tests)
            {
                lstTests.Items.Add(item);
            }
        }

        private void btnPassDeleteEdit_Click(object sender, EventArgs e)
        {
            string buttonText = (sender as Button).Text;
            TestModel selected = (TestModel)lstTests.SelectedItem;

            //Debug.WriteLine(buttonText);
            if (selected == null)
            {
                MessageBox.Show("Please select a test.");
            }
            else
            {
                switch (buttonText)
                {
                    case "Edit Test":
                        //case "Pass Test":
                        GetTestQuestions(selected);
                        Debug.WriteLine(buttonText);
                        break;
                    case "Delete Test":
                        DeleteTest(selected);
                        break;
                }
            }
        }

        private void DeleteTest(TestModel selected)
        {
            test.Delete(selected.TestID);
            MessageBox.Show($"{selected.TestName} test has been deleted.");
            ShowTests();
        }
        private void GetTestQuestions(TestModel selected)
        {
            QuestionService question = new QuestionService();
            List<QuestionModel> allQuestions = question.GetAll().ToList();
            List<QuestionModel> testQuestions = allQuestions.Where(item => item.TestID == selected.TestID).ToList();
            QuestionsListForm questionList = new QuestionsListForm();
            questionList.Questions = testQuestions;
            questionList.Test = selected;
            questionList.ShowDialog();

        }

    }
}
