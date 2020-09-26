using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCreationPlatform.Forms;

namespace TestCreationPlatform
{
    public partial class GreetingForm : Form
    {
        public GreetingForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string clickedBtn = (sender as Button).Text;
            //this.Hide();
            TestForm testForm = new TestForm(clickedBtn);
            testForm.Show();
        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            CreateTestForm createTest = new CreateTestForm();
            createTest.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StatisticsForm statistics = new StatisticsForm();
            statistics.Show();
        }
    }
}
