using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RH.View.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id,string nomeEmpresa)
        {
            Session["IDEmpresa"] = id;
            Session["NomeEmpresa"] = nomeEmpresa;
            return View();
        }

        public ActionResult Professor()
        {
            return View();
        }
    }
}
