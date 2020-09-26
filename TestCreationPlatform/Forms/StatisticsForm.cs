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
            //TestsResultService resultService = new TestsResultService();
            //var allResults = resultService.GetAll();

            //var testAverage =
            //    from result in allResults
            //    group result by result.TestID into resultGroup
            //    select new
            //    {
            //        TestID = resultGroup.Key,
            //        AveragePercent = resultGroup.Average(x => Helpers.GetPercent((double)x.CorrectAnswersTotal, (double)x.QuestionsTotal))
            //    };
            //var distinctTests = result.GetAll().Select(item => item.TestID).Distinct().ToList();
            //var distinctTests = result.GetAll().GroupBy(elem => elem.TestID).Select(group => group.FirstOrDefault());

            //foreach (var item in distinctTests)
            //{
            //        string[] row = { result.GetTestName(item.TestID), (Helpers.GetPercent((double)item.CorrectAnswersTotal, (double)item.QuestionsTotal)).ToString("0.00") };
            //        var listViewItem = new ListViewItem(row);
            //        listView1.Items.Add(listViewItem);
            //}
            DisplayStatistic();
        }

        private void DisplayStatistic()
        {
            TestsResultService testsResult = new TestsResultService();
            var results = testsResult.GetAll().ToList();
            foreach (var item in results)
            {
                string[] row = { testsResult.GetTestName(item.TestID), ((double)item.CorrectAnswersTotal/(double)item.QuestionsTotal*100).ToString("0.00") };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }

            //var distinct =
            //    from result in results
            //    group result by result.TestID into resultGroup
            //    select new
            //    {
            //        TestID = resultGroup.Key,
            //        AveragePercent = resultGroup.Average(x => Helpers.GetPercent((double)x.CorrectAnswersTotal, (double)x.QuestionsTotal))
            //    };


        }

        //        var players = new List<Player> {
        //    new Player { Name = "Alex", Team = "A", Score = 10 },
        //    new Player { Name = "Anna", Team = "A", Score = 20 },
        //    new Player { Name = "Luke", Team = "L", Score = 60 },
        //    new Player { Name = "Lucy", Team = "L", Score = 40 },
        //};

        //        var teamAverageScores =
        //            from player in players
        //            group player by player.Team into playerGroup
        //            select new
        //            {
        //                Team = playerGroup.Key,
        //                AverageScore = playerGroup.Average(x => x.Score),
        //            };
    }
}
