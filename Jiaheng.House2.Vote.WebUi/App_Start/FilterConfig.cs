using System.Web;
using System.Web.Mvc;

namespace Jiaheng.House2.Vote.WebUi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
