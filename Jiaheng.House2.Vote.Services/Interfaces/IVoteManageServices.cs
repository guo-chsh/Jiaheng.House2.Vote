using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jiaheng.House2.Vote.DTO.ViewModel;

namespace Jiaheng.House2.Vote.Services.Interfaces
{
    /// <summary>
    /// 投票所有操作
    /// </summary>
    public interface IVoteManageServices : IVoteServices
    {
        bool DoVote(LoginViewModel userinfo, int voteitemid, string ip);
        bool CreateVoteMain(VoteMainViewModel model);
        bool UpdateVoteItemChooseCounts(VoteItemViewModel model);
        IEnumerable<VoteMainViewModel> GetAllVotes();
        VoteMainViewModel GetVoteByid(int id);
        IEnumerable<VoteMaintypeViewModel> GetAllTypes();
    }
}
