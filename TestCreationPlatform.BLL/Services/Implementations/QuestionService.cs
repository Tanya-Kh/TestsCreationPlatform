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

                _questionRepository.Create(new Question()
                {
                    TestID = item.TestID,
                    QuestionText = item.QuestionText,
                    Type = item.Type
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
                _questionRepository.Delete(id);
                deleted = true;
            }

            return deleted;
        }

        public IEnumerable<QuestionModel> GetAll()
        {

            return _questionRepository.GetAll().Select(question => new QuestionModel()
            {
                QuestionID = question.QuestionID,
                TestID = question.TestID,
                QuestionText = question.QuestionText,
                Type = question.Type
            }).AsEnumerable();

        }

        public List<QuestionModel> GetTestQuestions(TestModel selected)
        {
            var allQuestions = GetAll().ToList();
            var testQuestions = allQuestions.Where(item => item.TestID == selected.TestID).ToList();

            return testQuestions;
        }

        public QuestionModel GetItem(int id)
        {
            if (id > 0)
            {
                Question question = _questionRepository.GetItem(id);

                return new QuestionModel()
                {
                    QuestionID = question.QuestionID,
                    TestID = question.TestID,
                    QuestionText = question.QuestionText,
                    Type = question.Type
                };
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
                _questionRepository.Update(id, new Question()
                {
                    TestID = item.TestID,
                    QuestionText = item.QuestionText,
                    Type = item.Type,
                    QuestionID = item.QuestionID
                });
                updated = true;
            }

            return updated;
        }
    }
}
