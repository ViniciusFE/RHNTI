using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Model;
using RH.Control;

namespace RH.View.Controllers
{
    public class ProfessorController : Controller
    {
        private CProfessor _Control;

        public ProfessorController()
        {
            _Control = new CProfessor();
        }

        // GET: Professor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CadastrarProfessor()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarProfessor(Professor oProfessor,string Senha)
        {
            return View();
        }
    }
}
