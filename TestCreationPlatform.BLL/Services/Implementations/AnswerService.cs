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
                _answerRepository.Create(ConvertAnswerModelToAnswer(item));
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
            return _answerRepository.GetAll().AsEnumerable().Select(answer => ConvertAnswerToAnswerModel(answer));
        }

        public List<AnswerModel> GetQuestionAnswers(QuestionModel questionModel)
        {
            var questionAnswers = GetAll().Where(item => item.QuestionID == questionModel.QuestionID).ToList();

            return questionAnswers;
        }

        public AnswerModel GetCorrectAnswer(QuestionModel questionModel)
        {
            var correct = GetQuestionAnswers(questionModel).Where(item => item.IsCorrect == true).FirstOrDefault();
            return correct;
        }

        public AnswerModel GetItem(int id)
        {
            if (id > 0)
            {
                Answer answer = _answerRepository.GetItem(id);
                return ConvertAnswerToAnswerModel(answer);
            }
            else
            {
                return null;
            }
        }

        public bool Update(int id, AnswerModel item)
        {
            bool updated = false;

            if (id > 0)
            {
                _answerRepository.Update(id, ConvertAnswerModelToAnswer(item));
                updated = true;
            }

            return updated;
        }

        private static Answer ConvertAnswerModelToAnswer(AnswerModel answerModel)
        {
            Answer answer = new Answer()
            {
                AnswerText = answerModel.AnswerText,
                QuestionID = answerModel.QuestionID,
                IsCorrect = answerModel.IsCorrect,
                AnswerID = answerModel.AnswerID
            };

            return answer;
        }

        private static AnswerModel ConvertAnswerToAnswerModel(Answer answer)
        {
            AnswerModel answerModel = new AnswerModel()
            {
                AnswerText = answer.AnswerText,
                QuestionID = answer.QuestionID,
                IsCorrect = answer.IsCorrect,
                AnswerID = answer.AnswerID
            };

            return answerModel;
        }
    }
}
