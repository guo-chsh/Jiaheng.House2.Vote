using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Jiaheng.House2.Vote.DTO.ViewModel
{
    /// <summary>
    /// 登录用户信息
    /// </summary>
    public class LoginViewModel
    {
        public int ID { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [Required(ErrorMessage = "不能为空")]
        [Display(Name = "用户名")]
        public string Username { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required(ErrorMessage = "6-20位，支持数字、字母、符号")]
        [Display(Name = "登录密码")]
        public string Password { get; set; }
        public DateTime LoginDatetime { get; set; }

    }
}
