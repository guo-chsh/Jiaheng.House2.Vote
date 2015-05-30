using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jiaheng.House2.Vote.Entities;

namespace Jiaheng.House2.Vote.Repository
{
    public class VoteRepository<T> : IVoteRepository<T> where T : class
    {
        protected DbContext _context;

        private DbSet<T> _dbSet;

        public VoteRepository()
        {

            _context = Entityframework.Entities.Current;
            _dbSet = _context.Set<T>();
        }

        public IQueryable<T> Fetch()
        {
            return _dbSet.AsQueryable<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return Fetch().AsEnumerable<T>();
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return _dbSet.Where<T>(predicate);
        }

        public T Single(Func<T, bool> predicate)
        {
            return _dbSet.Single<T>(predicate);
        }

        public T SingleOrDefault(Func<T, bool> predicate)
        {
            return _dbSet.SingleOrDefault<T>(predicate);
        }

        public T First(Func<T, bool> predicate)
        {
            return _dbSet.First<T>(predicate);
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _dbSet.Remove(entity);
        }

        public void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _dbSet.Add(entity);
        }

        public void Attach(T entity)
        {
            _dbSet.Attach(entity);
        }

        public IEnumerable<T> AddRange(IEnumerable<T> entities)
        {
            return _dbSet.AddRange(entities);
        }
    }
}
