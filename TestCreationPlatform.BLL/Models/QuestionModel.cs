using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCreationPlatform.BLL.Models
{
    public class QuestionModel
    {
        public int QuestionID { get; set; }
        public int TestID { get; set; }
        public string Question1 { get; set; }
        public int Type { get; set; }
    }
}
