
using System;

namespace Jiaheng.House2.Vote.Entities
{
    /// <summary>
    /// 投票选项表
    /// </summary>
    [Serializable]
    public partial class Vote_items
    {
        public Vote_items()
        { }
        #region Model
        private int _id;
        private int _votemainid;
        private string _voteitemname;
        private int _voteinitialcounts;
        private int _votecounts;
        private int _selectobjid;
        public string _voteType;
        private DateTime _createtime;

        /// <summary>
        /// 投票活动类型
        /// </summary>
        public string VoteType
        {
            get { return _voteType; }
            set { _voteType = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 投票主表ID
        /// </summary>
        public int VotemainId
        {
            set { _votemainid = value; }
            get { return _votemainid; }
        }
        /// <summary>
        /// 投票选项名字
        /// </summary>
        public string VoteItemName
        {
            set { _voteitemname = value; }
            get { return _voteitemname; }
        }
        /// <summary>
        /// 初始化的数量
        /// </summary>
        public int VoteInitialCounts
        {
            set { _voteinitialcounts = value; }
            get { return _voteinitialcounts; }
        }
        /// <summary>
        /// 当前真实投票数量
        /// </summary>
        public int VoteCounts
        {
            set { _votecounts = value; }
            get { return _votecounts; }
        }
        /// <summary>
        /// 被投票对象ID
        /// </summary>
        public int SelectobjID
        {
            set { _selectobjid = value; }
            get { return _selectobjid; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        #endregion Model

    }
}

