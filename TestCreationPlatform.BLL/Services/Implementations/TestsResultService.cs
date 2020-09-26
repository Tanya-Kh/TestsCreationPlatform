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
    public class TestsResultService : ITestsResultService
    {
        private IGenericRepository<TestsResult> _testsResultRepository;

        public TestsResultService()
        {
            _testsResultRepository = new GenericRepository<TestsResult>();
        }

        public bool Create(TestsResultModel item)
        {
            bool created = false;

            if (item != null)
            {
                _testsResultRepository.Create(new TestsResult()
                {
                    TestID = item.TestID,
                    CorrectAnswersTotal = item.CorrectAnswersTotal,
                    QuestionsTotal = item.QuestionsTotal,
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
                _testsResultRepository.Delete(id);
                deleted = true;
            }

            return deleted;
        }

        public IEnumerable<TestsResultModel> GetAll()
        {
            return _testsResultRepository.GetAll().Select(testsResult => new TestsResultModel()
            {
                TestID = testsResult.TestID,
                CorrectAnswersTotal = testsResult.CorrectAnswersTotal,
                QuestionsTotal = testsResult.QuestionsTotal,
                ResultID = testsResult.ResultID
            }).AsEnumerable();
        }

        public TestsResultModel GetItem(int id)
        {
            if (id > 0)
            {
                TestsResult testsResult = _testsResultRepository.GetItem(id);

                return new TestsResultModel()
                {
                    TestID = testsResult.TestID,
                    CorrectAnswersTotal = testsResult.CorrectAnswersTotal,
                    QuestionsTotal = testsResult.QuestionsTotal,
                    ResultID = testsResult.ResultID
                };
            }
            return null;
        }

        public bool Update(int id, TestsResultModel item)
        {
            bool updated = false;

            if (id > 0)
            {
                _testsResultRepository.Update(id, new TestsResult()
                {
                    TestID = item.TestID,
                    CorrectAnswersTotal = item.CorrectAnswersTotal,
                    QuestionsTotal = item.QuestionsTotal,
                    ResultID = item.ResultID
                });
                updated = true;
            }

            return updated;
        }
    }
}
