using Microsoft.AspNetCore.Mvc;

namespace Mes.Pendant.Web.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 可恶的洋洋
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
