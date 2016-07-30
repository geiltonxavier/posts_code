using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltrosNoASP.NETMVC.Controllers
{
    [HandleError(View = "ViewErroController")]
    public class HomeController : Controller
    {        
        public ActionResult Index()
        {
            throw new Exception("Erro na Index");
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
    }
}