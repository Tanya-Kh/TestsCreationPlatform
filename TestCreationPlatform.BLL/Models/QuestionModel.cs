using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCreationPlatform.BLL.Services.Implementations;

namespace TestCreationPlatform.BLL.Models
{
    public class QuestionModel
    {
        public int QuestionID { get; set; }

        public int TestID { get; set; }

        public string QuestionText { get; set; }

        public int Type { get; set; }

        public AnswerModel CorrrectAnswer { get; set; }

        public AnswerModel IncorrectAnswerText { get; set; }

        public AnswerModel IncorrectAnswer2 { get; set; }

        public AnswerModel IncorrectAnswer3 { get; set; }

        public List<AnswerModel> GetAnswers()
        {
            AnswerModel[] answersArray = { CorrrectAnswer, IncorrectAnswerText, IncorrectAnswer2, IncorrectAnswer3 };
            List<AnswerModel> answers = new List<AnswerModel>(answersArray);

            return answers;
        }
    }
}
