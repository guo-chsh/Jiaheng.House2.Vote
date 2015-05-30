
using System;
namespace Jiaheng.House2.Vote.Entities
{
    /// <summary>
    /// 投票主表
    /// </summary>
    [Serializable]
    public partial class Vote_main
    {
        public Vote_main()
        { }
        #region Model
        private int _id;
        private string _votename;
        private DateTime _begintime;
        private DateTime _endtime;
        private string _votedescription;
        private DateTime _createtime;
        private string _voteType;

        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 投票标题名称
        /// </summary>
        public string VoteName
        {
            set { _votename = value; }
            get { return _votename; }
        }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime Begintime
        {
            set { _begintime = value; }
            get { return _begintime; }
        }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime Endtime
        {
            set { _endtime = value; }
            get { return _endtime; }
        }
        /// <summary>
        /// 该投票描述
        /// </summary>
        public string VoteDescription
        {
            set { _votedescription = value; }
            get { return _votedescription; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Createtime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }

        /// <summary>
        /// 投票活动类型
        /// </summary>
        public string VoteType
        {
            get { return _voteType; }
            set { _voteType = value; }
        }

        #endregion Model

    }
}

