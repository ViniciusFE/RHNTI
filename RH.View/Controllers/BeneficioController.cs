using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Control;
using RH.Model;

namespace RH.View.Controllers
{
    public class BeneficioController : Controller
    {
        private CBeneficio _Control;

        public BeneficioController()
        {
            _Control = new CBeneficio();
        }

        // GET: Beneficio
        public ActionResult Index()
        {
            List<Beneficio> b = _Control.SelecionarTodosBeneficios();
            return View(b);
        }

        public ActionResult CadastrarBenificio()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarBenificio(Beneficio oBeneficio)
        {
            if(ModelState.IsValid)
            {
                _Control.Incluir(oBeneficio);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult AlterarBeneficio(int id)
        {
            Beneficio b =  _Control.SelecionarBeneficioID(id);
            return View(b);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AlterarBeneficio(Beneficio oBeneficio)
        {
            if (ModelState.IsValid)
            {
                _Control.Alterar(oBeneficio);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult ExcluirBeneficio(int id)
        {
            Beneficio b = _Control.SelecionarBeneficioID(id);
            _Control.Excluir(b);
            return RedirectToAction("Index");
        }

    }
}