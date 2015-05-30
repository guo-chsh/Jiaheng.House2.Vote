using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jiaheng.House2.Vote.DTO.ViewModel;

namespace Jiaheng.House2.Vote.Services.Interfaces
{
    /// <summary>
    /// 用户操作主业务方法
    /// </summary>
    public interface IUserOperationServices : IVoteServices
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Login(LoginViewModel model);
    }
}
