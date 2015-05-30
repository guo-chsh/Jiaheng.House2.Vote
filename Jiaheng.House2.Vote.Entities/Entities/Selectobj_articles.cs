
using System;
namespace Jiaheng.House2.Vote.Entities
{
    /// <summary>
    /// 文章表
    /// </summary>
    [Serializable]
    public partial class Selectobj_articles
    {
        public Selectobj_articles()
        { }
        #region Model
        private int _id;
        private string _articletitle;
        private string _articlecontent;
        private DateTime? _createtime;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 文章标题
        /// </summary>
        public string ArticleTitle
        {
            set { _articletitle = value; }
            get { return _articletitle; }
        }
        /// <summary>
        /// 文章内容
        /// </summary>
        public string articleContent
        {
            set { _articlecontent = value; }
            get { return _articlecontent; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? Createtime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        #endregion Model

    }
}

