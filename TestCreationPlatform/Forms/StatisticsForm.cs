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
using TestCreationPlatform.BLL.Services.Implementations;

namespace TestCreationPlatform.Forms
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            DisplayStatistic();
        }

        private void DisplayStatistic()
        {
            TestsResultService testsResult = new TestsResultService();
            var results = testsResult.GetAll().ToList();
            foreach (var item in results)
            {
                string[] row = { testsResult.GetTestName(item.TestID), ((double)item.CorrectAnswersTotal / (double)item.QuestionsTotal * 100).ToString("0.00") };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
        }
    }
}
