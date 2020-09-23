using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCreationPlatform.BLL.Models;
using TestCreationPlatform.BLL.Services.Implementations;

namespace TestCreationPlatform.Forms
{
    public partial class TopicForm : Form
    {
        private TopicModel ParentTopic { get; set; }
        public TopicForm(TopicModel parentTopic)
        {
            InitializeComponent();
            ParentTopic = parentTopic;
        }

        TopicService topic = new TopicService();

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "ERROR! Please provide topic name.";
            if (!String.IsNullOrWhiteSpace(txtTopicName.Text))
            {
                message = "New topic was created.";
                topic.Create(new TopicModel { TopicName = txtTopicName.Text, ParentTopicID = ParentTopic?.TopicID });
            }
            MessageBox.Show(message);
            Close();
        }     
    }
}