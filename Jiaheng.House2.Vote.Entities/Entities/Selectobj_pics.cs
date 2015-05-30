
using System;
namespace Jiaheng.House2.Vote.Entities
{
    /// <summary>
    /// 被投票对象，图片表
    /// </summary>
    [Serializable]
    public partial class Selectobj_pics
    {
        public Selectobj_pics()
        { }
        #region Model
        private int _id;
        private string _picname;
        private string _picurl;
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
        /// 图片名称
        /// </summary>
        public string PicName
        {
            set { _picname = value; }
            get { return _picname; }
        }
        /// <summary>
        /// 图片地址
        /// </summary>
        public string PicUrl
        {
            set { _picurl = value; }
            get { return _picurl; }
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

