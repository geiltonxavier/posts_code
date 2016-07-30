using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltrosNoASP.NETMVC.Controllers
{
    [HandleError(View="ViewErroController")]
    public class TesteController : Controller
    {
        [HandleError(View = "ViewErroAction")]
        public ActionResult Index()
        {
            throw new Exception("Erro ao executar operação");
            return View();
        }
    }
}