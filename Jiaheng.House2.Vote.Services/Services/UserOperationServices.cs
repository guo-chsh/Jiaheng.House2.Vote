using Jiaheng.House2.Vote.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jiaheng.House2.Vote.DTO.ViewModel;
using Jiaheng.House2.Vote.Entities;
using Jiaheng.House2.Vote.Repository.Interfaces;
using Jiaheng.House2.Vote.Tools;

namespace Jiaheng.House2.Vote.Services.Services
{
    public class UserOperationServices : IUserOperationServices
    {
        IUserinfoRepository<User_info> _iUserinfoRepository;
        public UserOperationServices(IUserinfoRepository<User_info> iUserinfoRepository)
        {
            _iUserinfoRepository = iUserinfoRepository;
        }

        public object ConvertToViewModel(object entity)
        {
            var info = entity as User_info;
            if (info == null) return null;
            var vmodel = new LoginViewModel
            {
                ID = info.Id,
                LoginDatetime = DateTime.Now,
                Password = info.Password,
                Username = info.UserName
            };
            return vmodel;
        }

        public bool Login(LoginViewModel model)
        {
            var info = _iUserinfoRepository.First(u => u.UserName == model.Username);
            var md5pass = Md5Secret.Md5(model.Password);
            return md5pass.Equals(info.Password);
        }
    }
}
