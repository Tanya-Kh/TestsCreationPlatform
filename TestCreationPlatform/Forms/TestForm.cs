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

namespace TestCreationPlatform
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            TestService test = new TestService();
            var tests = test.GetAll().ToList();
            ShowTests(tests);
        }

        private void ShowTests(List<TestModel> list)
        {
            foreach (TestModel item in list)
            {
                lstTests.Items.Add(item.TestName);
            }
        }
    }
}
