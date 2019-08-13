using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Model;
using RH.Control;

namespace RH.View.Controllers
{
    public class HomeController : Controller
    {
        private CEmpresa _Control;

        public HomeController()
        {
            _Control = new CEmpresa();
        }


        public ActionResult Index(int id,string nomeEmpresa)
        {
            Session["IDEmpresa"] = id;
            Session["NomeEmpresa"] = nomeEmpresa;

            Empresa aEmpresa = _Control.SelecionarEmpresa(id);
            if(aEmpresa.Emp_Avaliativa)
            {
                Session["Avaliativa"] = true;
            }

            else
            {
                Session["Avaliativa"] = false;
            }
            
            return View();
        }

        public ActionResult Professor()
        {
            return View();
        }
    }
}
