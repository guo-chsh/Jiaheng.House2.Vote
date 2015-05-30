using Jiaheng.House2.Vote.DTO.ViewModel;
using Jiaheng.House2.Vote.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jiaheng.House2.Vote.WebUi.Controllers
{
    public class HomeController : Controller
    {
        IUserOperationServices _iUserOperationServices;
        public HomeController(IUserOperationServices iUserOperationServices)
        {
            _iUserOperationServices = iUserOperationServices;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginSubmit(LoginViewModel model)
        {
            var result = _iUserOperationServices.Login(model);
            if (result)
                return RedirectToAction("Index");
            else
                return View("Login");
        }

        //public string UserStatus(int userid)
        //{
        //    return "当前登录信息";
        //}

    }
}