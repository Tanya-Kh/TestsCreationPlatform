using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCreationPlatform.BLL.Models
{
    public class TestModel
    {
        public int TestID { get; set; }
        public string TestName { get; set; }
        public string TestDescription { get; set; }
        public int TopicID { get; set; }
        public DateTime? TestTime { get; set; }
    }
}
