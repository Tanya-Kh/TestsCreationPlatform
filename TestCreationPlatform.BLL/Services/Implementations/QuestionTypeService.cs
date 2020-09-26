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
    public class QuestionTypeService : IQuestionTypeService
    {
        private IGenericRepository<QuestionType> _questionTypeRepository;

        public QuestionTypeService()
        {
            _questionTypeRepository = new GenericRepository<QuestionType>();
        }

        public bool Create(QuestionTypeModel item)
        {
            bool created = false;

            if (item != null)
            {
                _questionTypeRepository.Create(new QuestionType
                {
                    TypeName = item.TypeName
                });

                created = true;
            }

            return created;
        }

        public bool Update(int id, QuestionTypeModel item)
        {
            bool updated = false;

            if (id > 0)
            {
                _questionTypeRepository.Update(id, new QuestionType
                {
                    TypeName = item.TypeName,
                    TypeID = item.TypeID
                });

                updated = true;
            }

            return updated;
        }

        QuestionTypeModel IService<QuestionTypeModel>.GetItem(int id)
        {
            if (id > 0)
            {
                QuestionType questionType = _questionTypeRepository.GetItem(id);

                return new QuestionTypeModel()
                {
                    TypeName = questionType.TypeName,
                    TypeID = questionType.TypeID
                };
            }
            else
            {
                return null;
            }
        }

        IEnumerable<QuestionTypeModel> IService<QuestionTypeModel>.GetAll()
        {
            return _questionTypeRepository.GetAll().Select(questionType => new QuestionTypeModel()
            {
                TypeName = questionType.TypeName,
                TypeID = questionType.TypeID
            }).AsEnumerable();
        }

        public bool Delete(int id)
        {
            bool deleted = false;

            if (id > 0)
            {
                _questionTypeRepository.Delete(id);
                deleted = true;
            }

            return deleted;
        }
    }
}
