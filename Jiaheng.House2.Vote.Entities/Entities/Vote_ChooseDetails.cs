
using System;
namespace Jiaheng.House2.Vote.Entities
{
    /// <summary>
    /// 客户投票明细表
    /// </summary>
    [Serializable]
    public partial class Vote_ChooseDetails
    {
        public Vote_ChooseDetails()
        { }
        #region Model
        private int _id;
        private int? _userid;
        private int? _voteitemid;
        private DateTime? _createtime;
        private string _userchooseip;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 客户ID
        /// </summary>
        public int? Userid
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 选项ID
        /// </summary>
        public int? VoteItemId
        {
            set { _voteitemid = value; }
            get { return _voteitemid; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? Createtime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 客户投票时候的IP
        /// </summary>
        public string UserChooseIp
        {
            set { _userchooseip = value; }
            get { return _userchooseip; }
        }
        #endregion Model

    }
}

