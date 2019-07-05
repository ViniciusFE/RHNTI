using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Model;
using RH.Control;
using RH.View.Filtro;

namespace RH.View.Controllers
{
    [AutorizacaoEmpresa]
    public class CargoController : Controller
    {
        private CCargo _Control;

        public CargoController()
        {
            _Control = new CCargo();
        }

        // GET: Cargo
        public ActionResult Index()
        {
            List<Cargo> _cargos = _Control.SelecionarTodosCargosEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
            return View(_cargos);
        }


        public ActionResult CadastrarCargo()
        {
            List<Setor> Setores = _Control.SelecionarSetoresEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
            ViewBag.Car_Setor_Set_ID = new SelectList(Setores, "Set_ID", "Set_Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarCargo(Cargo oCargo)
        {
            List<Setor> Setores = _Control.SelecionarSetoresEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
            ViewBag.Car_Setor_Set_ID = new SelectList(Setores, "Set_ID", "Set_Nome");

            if (ModelState.IsValid)
            {
                string dia = DateTime.Now.Day.ToString();
                string mes = DateTime.Now.Month.ToString();
                oCargo.Car_DataCadastro = dia + "/" + mes;
                oCargo.Car_Situation = true;
                _Control.CadastrarCargo(oCargo);
                return RedirectToAction("Index");
            }
            
            return View();
        }

        public ActionResult AlterarCargo(int id)
        {
         
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AlterarCargo(Cargo oCargo)
        {
            return RedirectToAction("Index");

        }

        public ActionResult ExcluirCargo(int id)
        {
            Cargo oCargo = _Control.SelecionarCargo(id);

            Pessoa aPessoa = _Control.SelecionarPessoaCargo(id);

            if (aPessoa != null)
            {
                return Json("Este cargo não pode ser excluído, pois está atualmente ocupado pelo funcionário " + aPessoa.Pes_Nome+", para excluir esse cargo primeiramente demita o funcionário que o ocupa.");
            }

            else
            {
                oCargo.Car_Situation = false;
                _Control.ExcluirCargo(oCargo);
                return Json("O cargo foi excluído com sucesso!");
            }

            
        }

    }
}
