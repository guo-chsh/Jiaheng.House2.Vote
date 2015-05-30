using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jiaheng.House2.Vote.Entities;
using Jiaheng.House2.Vote.Repository.Interfaces;

namespace Jiaheng.House2.Vote.Repository.Dao
{
    public class VoteMainRepository : VoteRepository<Vote_main>, IVoteMainRepository<Vote_main>
    {
    }
}
