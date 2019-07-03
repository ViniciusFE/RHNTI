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
            List<Cargo> CargosChefe = _Control.CargosChefeEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
            ViewBag.CargosChefe = CargosChefe;
            return View(_cargos);
        }


        public ActionResult CadastrarCargo()
        {
            Cargo x = new Cargo();
            x.Car_ID = -42;
            x.Car_Nome = "Este cargo é o chefe do setor";
            int IDEmpresa = Convert.ToInt32(Session["IDEmpresa"]);
            List<Cargo> lc = _Control.SelecionarTodosCargosEmpresa(IDEmpresa);
            lc.Add(x);
            
            ViewBag.Car_Cargo_Car_ID = new SelectList(lc, "Car_ID", "Car_Nome");
            ViewBag.Car_Setor_Set_ID = new SelectList(_Control.SelecionarSetoresEmpresa(IDEmpresa), "Set_ID", "Set_Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarCargo(Cargo oCargo)
        {
            if (ModelState.IsValid)
            {
                oCargo.Car_Situation = true;
                oCargo.Car_DataCadastro = DateTime.Now;
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
