using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiaheng.House2.Vote.DTO.ViewModel
{
    /// <summary>
    /// 投票活动中的选项
    /// </summary>
    public class VoteItemViewModel
    {
        public int ID { get; set; }
        public int VotemainID { get; set; }
        public string VoteItemName { get; set; }
        public int VoteInitialCounts { get; set; }
        public int VoteCounts { get; set; }
        public VoteMaintypeViewModel MainType { get; set; }
        public ISelectobj Selectobj { get; set; }
    }
}
