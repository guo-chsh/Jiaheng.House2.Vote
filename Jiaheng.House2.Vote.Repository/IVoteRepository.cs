using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiaheng.House2.Vote.Repository
{
    public interface IVoteRepository<T> where T : class
    {
        IQueryable<T> Fetch();
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Func<T, bool> predicate);
        T Single(Func<T, bool> predicate);
        T SingleOrDefault(Func<T, bool> predicate);
        T First(Func<T, bool> predicate);
        void Create(T entity);
        void Delete(T entity);
        void Attach(T entity);
        IEnumerable<T> AddRange(IEnumerable<T> entities);
    }
}
