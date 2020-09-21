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

        public string Question1 { get; set; }

        public int Type { get; set; }

        public AnswerModel CorrrectAnswer { get; set; }

        public AnswerModel IncorrectAnswer1 { get; set; }

        public AnswerModel IncorrectAnswer2 { get; set; }

        public AnswerModel IncorrectAnswer3 { get; set; }

        //public List<AnswerModel> QuestionAnswers { get; set; }

        //private List<AnswerModel> questionAnswers;

        //public List<AnswerModel> QuestionAnswers
        //{
        //    get
        //    {
        //        return questionAnswers;
        //    }
        //    set
        //    {
        //        questionAnswers = GetAnswers();
        //    }
        //}

        public List<AnswerModel> GetAnswers()
        {
            AnswerModel[] answersArray = { CorrrectAnswer, IncorrectAnswer1, IncorrectAnswer2, IncorrectAnswer3 };
            List<AnswerModel> answers = new List<AnswerModel>(answersArray);

            return answers;

        }
        //private List<AnswerModel> GetAnswers()
        //{
        //    AnswerService answer = new AnswerService();
        //    List<AnswerModel> allAnswers = answer.GetAll().ToList();
        //    List<AnswerModel> questionAnswers = allAnswers.Where(item => item.QuestionID == this.QuestionID).ToList();

        //    return questionAnswers;
        //}

    }


}
