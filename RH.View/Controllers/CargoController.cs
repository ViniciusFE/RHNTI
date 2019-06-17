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
            List<Cargo> _cargos = _Control.SelecionarTodosCargos();
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
                if (oCargo.Car_Cargo_Car_ID == -42)
                {                    
                    oCargo.Car_Situation = true;
                    oCargo.Car_DataCadastro = DateTime.Now;
                    oCargo.Car_Cargo_Car_ID = null;
                    _Control.CadastrarCargo(oCargo);

                    oCargo.Car_Cargo_Car_ID = oCargo.Car_ID;
                    _Control.AlterarCargo(oCargo);
                    return RedirectToAction("Index");
                }

                oCargo.Car_Situation = true;
                oCargo.Car_DataCadastro = DateTime.Now;
                _Control.CadastrarCargo(oCargo);
                return RedirectToAction("Index");

            }
            return View();
        }

        public ActionResult AlterarCargo(int id)
        {
            Cargo oCargo = _Control.SelecionarCargo(id);
            int IDEmpresa = Convert.ToInt32(Session["IDEmpresa"]);
            ViewBag.Car_Setor_Set_ID = new SelectList(_Control.SelecionarSetoresEmpresa(IDEmpresa), "Set_ID", "Set_Nome",oCargo.Car_Setor_Set_ID);

            //Cargo x = new Cargo();
            //x.Car_ID = oCargo.Car_ID;
            //x.Car_Nome = "Selecione este cargo caso ele seja chefe dele mesmo.";
            List<Cargo> lc = _Control.SelecionarTodosCargos();
            //lc.Add(x);

            ViewBag.Car_Cargo_Car_ID = new SelectList(lc, "Car_ID", "Car_Nome",oCargo.Car_Cargo_Car_ID);

            return View(oCargo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AlterarCargo(Cargo oCargo)
        {
            if(ModelState.IsValid)
            {
                Cargo x = _Control.SelecionarCargo(oCargo.Car_ID);
                x.Car_Nome = oCargo.Car_Nome;
                x.Car_Setor_Set_ID = oCargo.Car_Setor_Set_ID;
                x.Car_Cargo_Car_ID = oCargo.Car_Cargo_Car_ID;
                _Control.AlterarCargo(x);                
            }
            return RedirectToAction("Index");

        }
    }
}
