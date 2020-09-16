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
    class TopicService : ITopicService
    {
        private IGenericRepository<Topic> _topicRepository;

        public TopicService()
        {
            _topicRepository = new GenericRepository<Topic>();
        }

        public bool Create(TopicModel item)
        {
            bool created = false;

            if (item != null)
            {
                _topicRepository.Create(ConvertTopicModelToTopic(item));
                created = true;
            }

            return created;
        }

        public bool Delete(int id)
        {
            bool deleted = false;

            if (id > 0)
            {
                _topicRepository.Delete(id);
                deleted = true;
            }

            return deleted;
        }

        public IEnumerable<TopicModel> GetAll()
        {
            return _topicRepository.GetAll().Select(topic => ConvertTopicToTopicModel(topic)).AsEnumerable();
        }

        public TopicModel GetItem(int id)
        {
            if (id > 0)
            {
                Topic topic = _topicRepository.GetItem(id);
                return ConvertTopicToTopicModel(topic);
            }
            else
            {
                return null;
            }
        }

        public bool Update(int id, TopicModel item)
        {
            bool updated = false;

            if (id > 0)
            {
                _topicRepository.Update(id, ConvertTopicModelToTopic(item));
                updated = true;
            }

            return updated;
        }

        private static Topic ConvertTopicModelToTopic(TopicModel topicModel)
        {
            Topic topic = new Topic()
            {
                ParentTopicID = topicModel.ParentTopicID,
                TopicName = topicModel.TopicName
            };

            return topic;
        }

        private static TopicModel ConvertTopicToTopicModel(Topic topic)
        {
            TopicModel topicModel = new TopicModel()
            {
                ParentTopicID = topic.ParentTopicID,
                TopicName = topic.TopicName
            };

            return topicModel;
        }
    }
}
