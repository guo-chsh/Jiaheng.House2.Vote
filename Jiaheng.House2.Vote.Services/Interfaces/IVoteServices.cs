using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiaheng.House2.Vote.Services.Interfaces
{
    /// <summary>
    /// DTO转换方法，本例中用的是比较简单的单项转换，此处可以试用DTOMapping框架替换
    /// </summary>
    public interface IVoteServices
    {
        object ConvertToViewModel(object entity);
    }
}
