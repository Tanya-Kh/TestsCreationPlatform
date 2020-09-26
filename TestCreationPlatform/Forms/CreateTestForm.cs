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
using TestCreationPlatform.BLL;
using TestCreationPlatform.Forms;

namespace TestCreationPlatform
{
    public partial class CreateTestForm : Form
    {
        TopicService topic = new TopicService();

        public TopicModel Topic { get; set; }

        public TopicModel SubTopic { get; set; }

        public TopicModel SubSubTopic { get; set; }

        public CreateTestForm()
        {
            InitializeComponent();
        }

        private void ShowTopics(ComboBox cbo, TopicModel top = null)
        {
            var topics = topic.GetAll().Where(item => item.ParentTopicID == null).ToList();

            if (top != null)
            {
                //get subTopics of top
                topics = topic.GetSubTopics(top.TopicID);
            }

            PopulateComboBox(cbo, topics);
        }

        private void CreateTestForm_Load(object sender, EventArgs e)
        {
            ShowTopics(cboTopics);
        }

        private void cboTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            Helpers.ClearTextBoxes(this.Controls);
            TopicModel selectedTopic = (TopicModel)cboTopics.SelectedItem;
            Topic = selectedTopic;
            ShowTopics(cboSubTopics, Topic);

            if (cboTopics.SelectedIndex != -1)
            {
                linkTopicDelete.Visible = true;
                cboSubTopics.Enabled = true;
                linkAddSubTopic.Visible = true;
            }
            else
            {
                linkTopicDelete.Visible = false;
                linkAddSubTopic.Visible = false;
                cboSubTopics.Enabled = false;
                cboSubTopics_SelectedIndexChanged(sender, e);
            }
        }

        private void cboSubTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
             TopicModel selectedSubTopic = (TopicModel)cboSubTopics.SelectedItem;
            SubTopic = selectedSubTopic;
            ShowTopics(cboSubSubTopics, SubTopic);

            if (cboSubTopics.SelectedIndex != -1)
            {
                linkDeleteSubTopic.Visible = true;
                linkAddSubSubTopic.Visible = true;
                cboSubSubTopics.Enabled = true;
            }
            else
            {
                linkDeleteSubTopic.Visible = false;
                linkDeleteSubSubTopic.Visible = false;
                linkAddSubSubTopic.Visible = false;
                cboSubSubTopics.Enabled = false;
            }
        }

        private void cboSubSubTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            TopicModel selectedSubSubTopic = (TopicModel)cboSubSubTopics.SelectedItem;
            SubSubTopic = selectedSubSubTopic;

            if (cboSubSubTopics.SelectedItem != null)
            {
                linkDeleteSubSubTopic.Visible = true;
            }
            else
            {
                linkDeleteSubSubTopic.Visible = false;
            }
        }

        //TO DO refactor next method!
        private int GetTopicId()
        {
            int topicID = Topic.TopicID;

            if (SubTopic != null)
            {
                topicID = SubTopic.TopicID;

                if (SubSubTopic != null)
                {
                    topicID = SubSubTopic.TopicID;
                }
            }

            return topicID;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            TestService test = new TestService();
            string message = "ERROR! Please check if all required fields were completed and try again.";

            if (!String.IsNullOrWhiteSpace(txtTest.Text) && (cboTopics.SelectedIndex > -1))
            {
                test.Create(new TestModel()
                {
                    TestName = txtTest.Text,
                    TestDescription = txtDescription.Text,
                    TopicID = GetTopicId(),
                });
                message = "New test was created.";
            }

            MessageBox.Show(message);
        }

        private void linkTopicAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddTopic();
        }

        private void AddTopic(TopicModel parentTopic = null)
        {
            TopicForm topicForm = new TopicForm(parentTopic);
            topicForm.Show();
        }

        private void linkTopicDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteTopic(Topic);
            ShowTopics(cboTopics);
            linkAddSubTopic.Visible = false;
            cboTopics_SelectedIndexChanged(sender, e);
            Helpers.ClearComboBoxes(this.Controls);
        }

        private void DeleteTopic(TopicModel selectedTopic)
        {
            var subTopics = topic.GetAll().Where(item => item.ParentTopicID == selectedTopic.TopicID).ToList();

            foreach (var subTopic in subTopics)
            {
                var subSubTopics = topic.GetAll().Where(item => item.ParentTopicID == subTopic.TopicID).ToList();

                foreach (var item in subSubTopics)
                {
                    topic.Delete(item.TopicID);
                }
                topic.Delete(subTopic.TopicID);
            }
            topic.Delete(selectedTopic.TopicID);
            //MessageBox.Show($"'{selectedTopic.TopicName}' topic has been deleted.");
        }

        private void linkDeleteSubTopic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var subSubTopics = topic.GetAll().Where(item => item.ParentTopicID == SubTopic.TopicID).ToList();

            foreach (var item in subSubTopics)
            {
                DeleteTopic(item);
            }

            DeleteTopic(SubTopic);
            ShowTopics(cboSubTopics, Topic);
            cboSubTopics_SelectedIndexChanged(sender, e);
            cboSubSubTopics_SelectedIndexChanged(sender, e);
            cboSubSubTopics.Items.Clear();
        }

        private void linkAddSubTopic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddTopic(Topic);
        }

        private void linkAddSubSubTopic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddTopic(SubTopic);
        }

        private void linkDeleteSubSubTopic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteTopic(SubSubTopic);
            ShowTopics(cboSubSubTopics, SubTopic);
            linkDeleteSubSubTopic.Visible = false;
        }

        private void cboTopics_DropDown(object sender, EventArgs e)
        {
            TopicModel topicModel = null;

            if ((ComboBox)sender == cboSubTopics)
            {
                topicModel = Topic;
            }
            else if ((ComboBox)sender == cboSubSubTopics)
            {
                topicModel = SubTopic;
            }

            ShowTopics((ComboBox)sender, topicModel);
        }

        private void PopulateComboBox(ComboBox cbo, List<TopicModel> topics)
        {
            cbo.Items.Clear();

            if (topics.Count != 0)
            {
                cbo.Items.Clear();
                cbo.DisplayMember = "TopicName";
                cbo.ValueMember = "TopicID";

                foreach (TopicModel item in topics)
                {
                    cbo.Items.Add(item);
                }
            }
        }
    }
}
