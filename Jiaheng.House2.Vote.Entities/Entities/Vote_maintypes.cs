
using System;
namespace Jiaheng.House2.Vote.Entities
{
    /// <summary>
    /// 投票类型（1、文章，2、图片）
    /// </summary>
    [Serializable]
    public partial class Vote_maintypes
    {
        public Vote_maintypes()
        { }
        #region Model
        private int _id;
        private string _votetypechar;
        private string _votetype;
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
        /// 投票类型标识符
        /// </summary>
        public string VoteTypeChar
        {
            set { _votetypechar = value; }
            get { return _votetypechar; }
        }
        /// <summary>
        /// 类型名称
        /// </summary>
        public string VoteType
        {
            set { _votetype = value; }
            get { return _votetype; }
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

