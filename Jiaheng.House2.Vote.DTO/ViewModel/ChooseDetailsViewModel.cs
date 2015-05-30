using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiaheng.House2.Vote.DTO.ViewModel
{
    /// <summary>
    /// 客户投票记录
    /// </summary>
    public class ChooseDetailsViewModel
    {
        public int ID { get; set; }
        public VoteItemViewModel VoteItem { get; set; }
        public LoginViewModel User { get; set; }
        public string UserIp { get; set; }
    }
}
