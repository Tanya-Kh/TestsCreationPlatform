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
                _questionTypeRepository.Create(ConvertQuestionTypeModelToQuestionType(item));
                created = true;
            }

            return created;
        }

        public bool Update(int id, QuestionTypeModel item)
        {
            bool updated = false;

            if (id > 0)
            {
                _questionTypeRepository.Update(id, ConvertQuestionTypeModelToQuestionType(item));
                updated = true;
            }

            return updated;
        }

        QuestionTypeModel IService<QuestionTypeModel>.GetItem(int id)
        {
            if (id > 0)
            {
                QuestionType questionType = _questionTypeRepository.GetItem(id);
                return ConvertQuestionTypeToQuestionTypeModel(questionType);
            }
            else
            {
                return null;
            }
        }

        IEnumerable<QuestionTypeModel> IService<QuestionTypeModel>.GetAll()
        {
            return _questionTypeRepository.GetAll().Select(questionType => ConvertQuestionTypeToQuestionTypeModel(questionType)).AsEnumerable();
        }

        private static QuestionType ConvertQuestionTypeModelToQuestionType(QuestionTypeModel questionTypeModel)
        {
            QuestionType questionType = new QuestionType()
            {
                TypeName = questionTypeModel.TypeName
            };

            return questionType;
        }

        private static QuestionTypeModel ConvertQuestionTypeToQuestionTypeModel(QuestionType questionType)
        {
            QuestionTypeModel questionTypeModel = new QuestionTypeModel()
            {
                TypeName = questionType.TypeName
            };

            return questionTypeModel;
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
