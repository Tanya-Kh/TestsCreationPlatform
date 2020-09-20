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
    public class QuestionService : IQuestionService
    {
        private IGenericRepository<Question> _questionRepository;

        public QuestionService()
        {
            _questionRepository = new GenericRepository<Question>();
        }
        public bool Create(QuestionModel item)
        {
            bool created = false;

            if (item != null)
            {
                _questionRepository.Create(ConvertQuestionModelToQuestion(item));
                created = true;
            }

            return created;
        }

        public bool Delete(int id)
        {
            bool deleted = false;

            if (id > 0)
            {
                _questionRepository.Delete(id);
                deleted = true;
            }

            return deleted;
        }

        public IEnumerable<QuestionModel> GetAll()
        {
            return _questionRepository.GetAll().AsEnumerable().Select(answer => ConvertQuestionToQuestionModel(answer));
        }

        public QuestionModel GetItem(int id)
        {
            if (id > 0)
            {
                Question question = _questionRepository.GetItem(id);
                return ConvertQuestionToQuestionModel(question);
            }
            else
            {
                return null;
            }
        }

        public bool Update(int id, QuestionModel item)
        {
            bool updated = false;

            if (id > 0)
            {
                _questionRepository.Update(id, ConvertQuestionModelToQuestion(item));
                updated = true;
            }

            return updated;
        }

        private static Question ConvertQuestionModelToQuestion(QuestionModel questionModel)
        {
            Question question = new Question()
            {
                TestID = questionModel.TestID,
                Question1 = questionModel.Question1,
                Type = questionModel.Type
            };

            return question;
        }

        private static QuestionModel ConvertQuestionToQuestionModel(Question question)
        {
            QuestionModel questionModel = new QuestionModel()
            {
                TestID = question.TestID,
                Question1 = question.Question1,
                Type = question.Type,
                QuestionID = question.QuestionID
            };

            return questionModel;
        }
    }
}
