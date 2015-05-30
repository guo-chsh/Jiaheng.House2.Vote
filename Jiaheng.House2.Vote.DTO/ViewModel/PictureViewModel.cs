using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiaheng.House2.Vote.DTO.ViewModel
{
    /// <summary>
    /// 被投票对象之图片
    /// </summary>
    public class PictureViewModel : ISelectobj
    {
        public int ID { get; set; }
        public string Typechar { get; set; }

        public string Picurl { get; set; }

    }
}
