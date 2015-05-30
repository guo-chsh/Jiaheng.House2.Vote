using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jiaheng.House2.Vote.Entities;

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
        public int SelectObjID { get; set; }
        public string TypeChar { get; set; }

        public Vote_items ToDataModel()
        {
            return new Vote_items
            {
                id = ID,
                CreateTime = DateTime.Now,
                SelectobjID = SelectObjID,
                
                VoteCounts = VoteCounts,
                VoteInitialCounts = VoteInitialCounts,
                VoteItemName = VoteItemName,
                VotemainId = VotemainID
            };
        }
    }
}
