using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltrosNoASP.NETMVC.Controllers
{
    [HandleError(View = "ViewErroController")]
    public class TesteErroPorTipoDeExcecaoController : Controller
    {
        [HandleError(View = "ViewErroActionPorTipo",ExceptionType = typeof(InvalidOperationException))]
        public ActionResult Index()
        {
            throw new InvalidOperationException("Erro operação Invalida");
            return View();
        }
    }
}