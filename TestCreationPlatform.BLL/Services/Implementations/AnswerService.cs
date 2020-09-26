using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCreationPlatform.BLL.Models;
using TestCreationPlatform.BLL.Services.Interfaces;
using TestCreationPlatform.DAL.Data;
using TestCreationPlatform.DAL.Repositories.Implementation;
using TestCreationPlatform.DAL.Repositories.Interfaces;

namespace TestCreationPlatform.BLL.Services.Implementations
{
    public class AnswerService : IAnswerService
    {
        private IGenericRepository<Answer> _answerRepository;

        public AnswerService()
        {
            _answerRepository = new GenericRepository<Answer>();
        }
        public bool Create(AnswerModel item)
        {
            bool created = false;

            if (item != null)
            {
                _answerRepository.Create(new Answer
                {
                    AnswerText = item.AnswerText,
                    QuestionID = item.QuestionID,
                    IsCorrect = item.IsCorrect,
                });
                created = true;
            }

            return created;
        }

        public bool Delete(int id)
        {
            bool deleted = false;

            if (id > 0)
            {
                _answerRepository.Delete(id);
                deleted = true;
            }

            return deleted;
        }

        public IEnumerable<AnswerModel> GetAll()
        {
            return _answerRepository.GetAll().Select(answer => new AnswerModel()
            {
                AnswerText = answer.AnswerText,
                QuestionID = answer.QuestionID,
                IsCorrect = answer.IsCorrect,
                AnswerID = answer.AnswerID
            }).AsEnumerable();
        }

        public List<AnswerModel> GetQuestionAnswers(QuestionModel questionModel)
        {
            var questionAnswers = GetAll().Where(item => item.QuestionID == questionModel.QuestionID).ToList();

            return questionAnswers;
        }

        public AnswerModel GetCorrectAnswer(QuestionModel questionModel)
        {
            var correct = GetQuestionAnswers(questionModel).FirstOrDefault(item => item.IsCorrect == true);
            return correct;
        }

        public AnswerModel GetItem(int id)
        {
            if (id > 0)
            {
                Answer answer = _answerRepository.GetItem(id);

                return new AnswerModel()
                {
                    AnswerText = answer.AnswerText,
                    QuestionID = answer.QuestionID,
                    IsCorrect = answer.IsCorrect,
                    AnswerID = answer.AnswerID
                };
            }

            return null;
        }

        public bool Update(int id, AnswerModel item)
        {
            bool updated = false;

            if (id > 0)
            {
                _answerRepository.Update(id, new Answer()
                {
                    AnswerText = item.AnswerText,
                    QuestionID = item.QuestionID,
                    IsCorrect = item.IsCorrect,
                    AnswerID = item.AnswerID
                });
                updated = true;
            }

            return updated;
        }
    }
}
