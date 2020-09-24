using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCreationPlatform.DAL.Data;
using TestCreationPlatform.DAL.Repositories.Interfaces;

namespace TestCreationPlatform.DAL.Repositories.Implementation
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        TestsEntities _context;
        DbSet<TEntity> _dbSet;

        public GenericRepository()
        {
            _context = new TestsEntities();
            _dbSet = _context.Set<TEntity>();
        }
        public void Create(TEntity item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _dbSet.Remove(GetItem(id));
            _context.SaveChanges();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet.AsNoTracking();
        }

        public TEntity GetItem(int id)
        {
            return _dbSet.Find(id);
        }

        public void Update(int id, TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
