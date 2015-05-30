
using System;
namespace Jiaheng.House2.Vote.Entities
{
    /// <summary>
    /// 客户表
    /// </summary>
    [Serializable]
    public partial class User_info
    {
        public User_info()
        { }
        #region Model
        private int _id;
        private string _username;
        private string _password;
        private DateTime? _updatetime;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        {
            set { _password = value; }
            get { return _password; }
        }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? Updatetime
        {
            set { _updatetime = value; }
            get { return _updatetime; }
        }
        #endregion Model

    }
}

