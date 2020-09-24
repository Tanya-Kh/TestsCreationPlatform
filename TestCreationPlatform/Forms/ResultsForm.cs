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
    public partial class ResultsForm : Form
    {
        List<string> correctList;
        List<string> inCorrectList;
        int testID;
        int questionsTotal;

        public ResultsForm(List<string> correct, List<string> incorrect, int id, int questions)
        {
            InitializeComponent();
            correctList = correct;
            inCorrectList = incorrect;
            testID = id;
            questionsTotal = questions;
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            TestsResultService result = new TestsResultService();

            lstCorrect.DataSource = correctList;
            lstIncorrect.DataSource = inCorrectList;
            double percent = Helpers.GetPercent((double)correctList.Count, (double)inCorrectList.Count);
            txtResults.Text = $"{correctList.Count} correct answer(s)," +
                $" {inCorrectList.Count} incorrect answer(s). Result - " +
                $"{percent} %";

            result.Create(new TestsResultModel
            {
                TestID = testID,
                CorrectAnswersTotal = correctList.Count,
                QuestionsTotal = questionsTotal
            });
        }
    }
}
