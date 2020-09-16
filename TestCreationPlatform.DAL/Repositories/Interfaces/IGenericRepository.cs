using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestCreationPlatform.DAL.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Create(TEntity item);

        void Delete(int id);

        void Update(int id, TEntity item);

        TEntity GetItem(int id);

        IQueryable<TEntity> GetAll();

    }
}
