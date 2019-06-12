using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Model;
using RH.Control;

namespace RH.View.Controllers
{
    public class AlunoController : Controller
    {
        CAluno _Control;
        private RHEntities x = Model.Helper.Connection.GetConnection();

        public AlunoController()
        {
            _Control = new CAluno();
        }

        // GET: Aluno
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CadasrarAluno()
        {

            List<Curso> cursos = (from p in x.Curso where p.Cur_Situation == true select p).ToList();
            ViewBag.Alu_Curso_Cur_ID = new SelectList(cursos, "Cur_ID", "Cur_Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadasrarAluno(Aluno oAluno)
        {
            if (ModelState.IsValid)
            {
                oAluno.Alu_Situation = true;
                oAluno.Alu_DataCadastro = DateTime.Now;
                _Control.CadastrarAluno(oAluno);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}