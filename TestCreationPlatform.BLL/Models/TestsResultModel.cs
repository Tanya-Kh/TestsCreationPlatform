using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCreationPlatform.BLL.Models
{
    public class TestsResultModel
    {
        public int ResultID { get; set; }

        public int TestID { get; set; }

        public int CorrectAnswersTotal { get; set; }

        public int QuestionsTotal { get; set; }

    }
}
