using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCreationPlatform
{
    public partial class CreateQuestion : Form
    {
        public CreateQuestion()
        {
            InitializeComponent();
        }

        private void rdoClosed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoOpen_CheckedChanged(object sender, EventArgs e)
        {
            grpIncorrectAnswers.Visible = false;
        }
    }
}
