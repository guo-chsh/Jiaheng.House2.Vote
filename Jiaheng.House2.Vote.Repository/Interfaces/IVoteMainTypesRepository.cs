using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jiaheng.House2.Vote.Entities;

namespace Jiaheng.House2.Vote.Repository.Interfaces
{
    public interface IVoteMainTypesRepository<T> : IVoteRepository<T> where T : class
    {
    }
}
