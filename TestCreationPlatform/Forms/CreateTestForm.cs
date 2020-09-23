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
            linkTopicDelete.Visible = true;
            Helpers.ClearTextBoxes(this.Controls);
            Helpers.ClearComboBoxes(this.Controls);
            TopicModel selectedTopic = (TopicModel)cboTopics.SelectedItem;
            Topic = selectedTopic;
            linkAddSubTopic.Visible = true;
            ShowTopics(cboSubTopics, Topic);
            cboSubTopics.Enabled = true;
        }

        private void cboSubTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            TopicModel selectedSubTopic = (TopicModel)cboSubTopics.SelectedItem;
            SubTopic = selectedSubTopic;
            ShowTopics(cboSubSubTopics, SubTopic);
            linkDeleteSubTopic.Visible = true;
            linkAddSubSubTopic.Visible = true;
            cboSubSubTopics.Enabled = true;
        }

        private void cboSubSubTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            TopicModel selectedSubSubTopic = (TopicModel)cboSubSubTopics.SelectedItem;
            SubSubTopic = selectedSubSubTopic;
            linkDeleteSubSubTopic.Visible = true;
        }

        //private int GetTopicId()
        //{
        //    int topicID = 0;
        //    if (cboTopics.SelectedItem != null)
        //    {
        //        topicID = ((TopicModel)cboTopics.SelectedItem).TopicID;
        //    }
        //    TopicModel selectedSubTopic = ((TopicModel)cboSubTopics.SelectedItem);
        //    int subTopicID = selectedSubTopic == null ? 0 : ((TopicModel)cboSubTopics.SelectedItem).TopicID;
        //    //int? subTopicID = ((TopicModel)cboSubTopics.SelectedItem).TopicID;

        //    if (subTopicID != 0)
        //    {
        //        TopicModel selectedSubSubTopic = ((TopicModel)cboSubSubTopics.SelectedItem);
        //        int subSubTopicID = selectedSubSubTopic == null ? 0 : ((TopicModel)cboSubSubTopics.SelectedItem).TopicID;

        //        //int? subSubTopicID = ((TopicModel)cboSubSubTopics.SelectedItem).TopicID;

        //        topicID = subSubTopicID == 0 ? (int)subTopicID : (int)subSubTopicID;
        //    }
        //    return topicID;
        //    //Debug.WriteLine(topicID);
        //}

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
                    //TO DO - ADD TIME
                });
                message = "New test was created.";
            }

            MessageBox.Show(message);
        }

        private void linkTopicAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddTopic();
            //ShowTopics(cboTopics);
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
            cboSubTopics.Items.Clear();
            cboSubSubTopics.Items.Clear();
        }

        private void DeleteTopic(TopicModel selectedTopic)
        {
            //var childTopics = topic.GetAll().Where(item => item.ParentTopicID == selectedTopic.TopicID).ToList();
            //var childChildTopics = topic.GetAll().Where(item => item.ParentTopicID == selectedTopic.TopicID).ToList();
            var subTopics = topic.GetAll().Where(item => item.ParentTopicID == selectedTopic.TopicID).ToList();
            //List<TopicModel> subSubTopics;
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
            MessageBox.Show($"'{selectedTopic.TopicName}' topic has been deleted.");
            //ShowTopics();
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
