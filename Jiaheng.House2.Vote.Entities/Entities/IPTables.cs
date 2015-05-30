using System;
namespace Jiaheng.House2.Vote.Entities
{
    /// <summary>
    /// ip列表将已知部分IP暂时缓存到本地数据库，正式生产应该选用缓存服务器或是其他缓存机制
    /// </summary>
    [Serializable]
    public partial class IPTables
    {
        public IPTables()
        { }
        #region Model
        private int _id;
        private string _ipadress;
        private string _province;
        private string _city;
        private string _other;
        private DateTime? _updatetime;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// ip4地址
        /// </summary>
        public string Ipadress
        {
            set { _ipadress = value; }
            get { return _ipadress; }
        }
        /// <summary>
        /// 省
        /// </summary>
        public string Province
        {
            set { _province = value; }
            get { return _province; }
        }
        /// <summary>
        /// 城市
        /// </summary>
        public string City
        {
            set { _city = value; }
            get { return _city; }
        }
        /// <summary>
        /// 其他
        /// </summary>
        public string Other
        {
            set { _other = value; }
            get { return _other; }
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

