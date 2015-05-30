using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiaheng.House2.Vote.DTO.ViewModel
{
    /// <summary>
    /// 被投票对象可以是很多种，文章，图片，人物，其他
    /// </summary>
    public interface ISelectobj
    {
        int ID { get; set; }
        string Typechar { get; set; }
    }
}
