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
   public class TestService : ITestService
    {
        private IGenericRepository<Test> _testRepository;

        public TestService()
        {
            _testRepository = new GenericRepository<Test>();
        }

        public bool Create(TestModel item)
        {
            bool created = false;

            if (item != null)
            {
                _testRepository.Create(ConvertTestModelToTest(item));
                created = true;
            }

            return created;
        }

        public bool Delete(int id)
        {
            bool deleted = false;

            if (id > 0)
            {
                _testRepository.Delete(id);
                deleted = true;
            }

            return deleted;
        }

        public IEnumerable<TestModel> GetAll()
        {
            //return _testRepository.GetAll().Select(test => new TestModel { TestName = test.TestName,
            //    TestDescription = test.TestDescription,
            //    TopicID = test.TopicID,
            //    TestTime = test.TestTime,
            //    TestID = test.TestID
            //}).AsEnumerable();

            return _testRepository.GetAll().AsEnumerable().Select(test => ConvertTestToTestModel(test));
        }

        public TestModel GetItem(int id)
        {
            if (id > 0)
            {
                Test test = _testRepository.GetItem(id);
                return ConvertTestToTestModel(test);
            }
            else
            {
                return null;
            }
        }

        public bool Update(int id, TestModel item)
        {
            bool updated = false;

            if (id > 0)
            {
                _testRepository.Update(id, ConvertTestModelToTest(item));
                updated = true;
            }

            return updated;
        }

        private static Test ConvertTestModelToTest(TestModel testModel)
        {
            Test test = new Test()
            {
                TestName = testModel.TestName,
                TestDescription = testModel.TestDescription,
                TopicID = testModel.TopicID,
                TestTime = testModel.TestTime
            };

            return test;
        }

        private static TestModel ConvertTestToTestModel(Test test)
        {
            return new TestModel()
            {
                TestName = test.TestName,
                TestDescription = test.TestDescription,
                TopicID = test.TopicID,
                TestTime = test.TestTime,
                TestID = test.TestID
            };
        }
    }
}
