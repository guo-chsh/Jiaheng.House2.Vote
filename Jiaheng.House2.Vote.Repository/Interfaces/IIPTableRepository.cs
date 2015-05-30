using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiaheng.House2.Vote.Repository.Interfaces
{
    /// <summary>
    /// 接口内部可以定义单个实体特殊业务扩展方法
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IIPTableRepository<T> : IVoteRepository<T> where T : class
    {
       
    }
}
