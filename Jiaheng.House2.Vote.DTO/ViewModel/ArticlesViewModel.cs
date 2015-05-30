using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiaheng.House2.Vote.DTO.ViewModel
{
    /// <summary>
    /// 文章 继承自被投票接口
    /// </summary>
    public class ArticlesViewModel 
    {
        public int ID { get; set; }

        public string ArticleTitle { get; set; }

        public string ArticleContent { get; set; }
    }
}
