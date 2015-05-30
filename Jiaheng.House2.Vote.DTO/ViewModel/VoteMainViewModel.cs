using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiaheng.House2.Vote.DTO.ViewModel
{
    /// <summary>
    /// 投票活动
    /// </summary>
    public class VoteMainViewModel
    {
        public int ID { get; set; }
        public string VoteTile { get; set; }
        public DateTime Begintime { get; set; }
        public DateTime Endtime { get; set; }
        public string Description { get; set; }
        public string Votemaintype { get; set; }
        public IList<VoteItemViewModel> VoteItems { get; set; }

      
    }
}
