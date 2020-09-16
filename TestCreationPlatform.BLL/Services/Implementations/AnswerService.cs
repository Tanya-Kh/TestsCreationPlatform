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
            return _answerRepository.GetAll().Select(answer => ConvertAnswerToAnswerModel(answer)).AsEnumerable();
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
                Answer1 = answerModel.Answer1,
                QuestionID = answerModel.QuestionID,
                IsCorrect = answerModel.IsCorrect
            };

            return answer;
        }

        private static AnswerModel ConvertAnswerToAnswerModel(Answer answer)
        {
            AnswerModel answerModel = new AnswerModel()
            {
                Answer1 = answer.Answer1,
                QuestionID = answer.QuestionID,
                IsCorrect = answer.IsCorrect
            };

            return answerModel;
        }
    }
}
