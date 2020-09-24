using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCreationPlatform.BLL.Services.Interfaces
{
    public interface IService<T>
    {
        bool Create(T item);

        bool Delete(int id);

        bool Update(int id, T item);

        T GetItem(int id);

        IEnumerable<T> GetAll();
    }
}
