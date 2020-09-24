using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCreationPlatform.BLL.Models
{
    public class AnswerModel
    {
        public int AnswerID { get; set; }

        public int QuestionID { get; set; }

        public string AnswerText { get; set; }

        public bool IsCorrect { get; set; }

    }
}
