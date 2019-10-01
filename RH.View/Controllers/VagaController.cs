using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Model;
using RH.Control;

namespace RH.View.Controllers
{
    public class VagaController : Controller
    {
        private CVaga _Control;

        public VagaController()
        {
            _Control = new CVaga();
        }

        // GET: Vaga
        public ActionResult Index()
        {
            List<Vaga> Vagas = _Control.SelecionarVagasEmpresa(Convert.ToInt32(Session["IDEmpresa"])); 
            return View(Vagas);
        }

        public ActionResult CadastrarVaga()
        {
            List<Cargo> Cargos = _Control.SelecionarCargosEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
            ViewBag.Vag_Cargo_Car_ID = new SelectList(Cargos, "Car_ID", "Car_Nome");
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult CadastrarVaga(Vaga aVaga)
        {
            if(ModelState.IsValid)
            {
                Empresa aEmpresa = _Control.SelecionarEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
                aVaga.Vag_DataCadastro = aEmpresa.Emp_DataAtual;
                aVaga.Vag_Preenchida = false;
                aVaga.Vag_Situation = true;
                _Control.CadastrarVaga(aVaga);
                return RedirectToAction("Index");
            }

            List<Cargo> Cargos = _Control.SelecionarCargosEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
            ViewBag.Vag_Cargo_Car_ID = new SelectList(Cargos, "Car_ID", "Car_Nome");
            return View(aVaga);
        }

        public ActionResult ExcluirVaga(int id)
        {
            Vaga aVaga = _Control.SelecionarVaga(id);
            aVaga.Vag_Situation = false;
            _Control.AlterarVaga(aVaga);
        }
    }
}
