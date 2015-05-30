
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
        private int? _votemainid;
        private string _voteitemname;
        private int? _voteinitialcounts;
        private int? _votecounts;
        private int _selectobjid;
        private int? _votetypeid;
        private DateTime? _createtime;
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
        public int? VotemainId
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
        public int? VoteInitialCounts
        {
            set { _voteinitialcounts = value; }
            get { return _voteinitialcounts; }
        }
        /// <summary>
        /// 当前真实投票数量
        /// </summary>
        public int? VoteCounts
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
        /// 投票类型与主表中一致
        /// </summary>
        public int? VoteTypeID
        {
            set { _votetypeid = value; }
            get { return _votetypeid; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        #endregion Model

    }
}

