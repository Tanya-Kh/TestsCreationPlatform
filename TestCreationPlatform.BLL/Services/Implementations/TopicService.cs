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
    public class TopicService : ITopicService
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
                _topicRepository.Create(new Topic()
                {
                    ParentTopicID = item.ParentTopicID,
                    TopicName = item.TopicName
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
                _topicRepository.Delete(id);
                deleted = true;
            }

            return deleted;
        }

        public IEnumerable<TopicModel> GetAll()
        {
            return _topicRepository.GetAll().Select(topic => new TopicModel()
            {
                ParentTopicID = topic.ParentTopicID,
                TopicName = topic.TopicName,
                TopicID = topic.TopicID
            }).AsEnumerable();
        }

        public List<TopicModel> GetSubTopics(int id)
        {
            var topics =  GetAll();
            return topics.Where(item => item.ParentTopicID == id).ToList();
        }

        public TopicModel GetItem(int id)
        {
            if (id > 0)
            {
                Topic topic = _topicRepository.GetItem(id);

                return new TopicModel()
                {
                    ParentTopicID = topic.ParentTopicID,
                    TopicName = topic.TopicName,
                    TopicID = topic.TopicID
                };
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
                _topicRepository.Update(id, new Topic()
                {
                    ParentTopicID = item.ParentTopicID,
                    TopicName = item.TopicName,
                    TopicID = item.TopicID
                });

                updated = true;
            }

            return updated;
        }
    }
}
