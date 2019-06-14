using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Model;
using RH.Control;
namespace RH.View.Controllers
{
    public class SetorController : Controller
    {
        private CSetor _Control;
        private CEmpresa _EControl;
        private CCargo _CCargo;

        public SetorController()
        {
            _Control = new CSetor();
            _EControl = new CEmpresa();
            _CCargo = new CCargo();
        }

        // GET: Setor
        public ActionResult Index()
        {
            List<Setor> _setores = _Control.SelecionarTodosSetores();
            return View(_setores);
        }

        public ActionResult CadastrarSetor()
        {
            ViewBag.Set_Empresa_Emp_ID = new SelectList(_EControl.SelecionarTodasEmpresa(), "Emp_ID", "Emp_Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarSetor(Setor oSetor)
        {
            if (ModelState.IsValid)
            {
                oSetor.Set_DataCadastro = DateTime.Now;
                oSetor.Set_Situation = true;
                oSetor.Set_Empresa_Emp_ID = Convert.ToInt32("IDEmpresa");
                _Control.CadastrarSetor(oSetor);
                //Cargo t = _CCargo.SelecionarCargoPorNome("-");
                //if (t == null)
                //{
                //    Cargo chefe = new Cargo();
                //    chefe.Car_Setor_Set_ID = oSetor.Set_ID;
                //    chefe.Car_Nome = "-";
                //    chefe.Car_DataCadastro = DateTime.Now;
                //    chefe.Car_Situation = false;
                //    _CCargo.CadastrarCargo(chefe);
                //    chefe.Car_Cargo_Car_ID = chefe.Car_ID;
                //    _CCargo.AlterarCargo(chefe);
                //}
                return RedirectToAction("Index");
            }
            return View();
            
        }

        public ActionResult AlterarSetor(int id)
        {
            Setor oSetor = _Control.SelecionarSetor(id);
            ViewBag.Set_Empresa_Emp_ID = new SelectList(_EControl.SelecionarTodasEmpresa(), "Emp_ID", "Emp_Nome", oSetor.Set_Empresa_Emp_ID);
            return View(oSetor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AlterarSetor(Setor oSetor)
        {
            Setor nSetor = _Control.SelecionarSetor(oSetor.Set_ID);
            nSetor.Set_Nome = oSetor.Set_Nome;
            nSetor.Set_Empresa_Emp_ID = oSetor.Set_Empresa_Emp_ID;
            if (ModelState.IsValid)
            {
                _Control.AlterarSetor(nSetor);
            }

            return RedirectToAction("Index");
        }

    }
}
