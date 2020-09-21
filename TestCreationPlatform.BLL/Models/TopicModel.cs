using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCreationPlatform.BLL.Models
{
    public class TopicModel
    {
        public int TopicID { get; set; }

        public int? ParentTopicID { get; set; }

        public string TopicName { get; set; }
    }
}
