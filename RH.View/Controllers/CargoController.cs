using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Model;
using RH.Control;
using RH.View.Filtro;
using PagedList;

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
        public ActionResult Index(int? pagina,string Pesquisa="")
        {
            ViewBag.Pesquisado = null;
            List<Cargo> _cargos = _Control.SelecionarTodosCargosEmpresa(Convert.ToInt32(Session["IDEmpresa"]));

            if(!string.IsNullOrEmpty(Pesquisa))
            {
                _cargos = _cargos.Where(p => p.Car_Nome.Contains(Pesquisa)).ToList();
                ViewBag.Pesquisado = Pesquisa;
            }

            int paginaTamanho = 4;
            int paginaNumero = (pagina ?? 1);

            return View(_cargos.ToPagedList(paginaNumero,paginaTamanho));
        }


        public ActionResult CadastrarCargo()
        {
            List<Setor> Setores = _Control.SelecionarSetoresEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
            ViewBag.Car_Setor_Set_ID = new SelectList(Setores, "Set_ID", "Set_Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarCargo(Cargo oCargo,bool ChefeSetor)
        {
            List<Setor> Setores = _Control.SelecionarSetoresEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
            ViewBag.Car_Setor_Set_ID = new SelectList(Setores, "Set_ID", "Set_Nome");

            if(ChefeSetor)
            {
                bool StatusChefe = _Control.SelecionarChefeSetor(oCargo.Car_Setor_Set_ID);
                if (StatusChefe)
                {
                    ModelState.AddModelError("ChefeSetor", "Este setor já possui um chefe, troque o status de chefe do cargo ou selecione outro setor de atividade");
                    return View();
                }
            }

            bool CargosComMesmoNome = _Control.CargosComMesmoNome(oCargo.Car_Nome, oCargo.Car_Setor_Set_ID);
            if (CargosComMesmoNome)
            {
                ModelState.AddModelError("Car_Nome", "Este setor já possui um cargo com este nome");
                return View();
            }

            if (ModelState.IsValid)
            {
                Empresa aEmpresa = _Control.SelecionarEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
                oCargo.Car_DataCadastro = aEmpresa.Emp_DataAtual;
                oCargo.Car_Chefe = ChefeSetor;
                oCargo.Car_Situation = true;
                _Control.CadastrarCargo(oCargo);
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult AlterarCargo(int id)
        {
            List<Setor> Setores = _Control.SelecionarSetoresEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
            
            Cargo oCargo = _Control.SelecionarCargo(id);

            ViewBag.Car_Setor_Set_ID = new SelectList(Setores, "Set_ID", "Set_Nome", oCargo.Car_Setor_Set_ID);

            return View(oCargo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AlterarCargo(Cargo oCargo,bool ChefeSetor)
        {
            List<Setor> Setores = _Control.SelecionarSetoresEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
            ViewBag.Car_Setor_Set_ID = new SelectList(Setores, "Set_ID", "Set_Nome", oCargo.Car_Setor_Set_ID);

            if (ChefeSetor)
            {
                bool StatusChefe = _Control.SelecionarChefeSetor(oCargo.Car_Setor_Set_ID);
                if (StatusChefe)
                {
                    ModelState.AddModelError("ChefeSetor", "Este setor já possui um chefe, troque o status de chefe do cargo ou selecione outro setor de atividade");
                    return View();
                }
            }

            bool CargosComMesmoNome = _Control.CargosComMesmoNome(oCargo.Car_Nome, oCargo.Car_Setor_Set_ID);
            if (CargosComMesmoNome)
            {
                ModelState.AddModelError("Car_Nome", "Este setor já possui um cargo com este nome");
                return View();
            }


            if (ModelState.IsValid)
            {
                Cargo oCargo1 = _Control.SelecionarCargo(oCargo.Car_ID);
                oCargo1.Car_Nome = oCargo.Car_Nome;
                oCargo1.Car_Setor_Set_ID = oCargo.Car_Setor_Set_ID;
                oCargo1.Car_Chefe = ChefeSetor;
                _Control.AlterarCargo(oCargo1);

                return RedirectToAction("Index");
            }

            return View(oCargo);
        }

        public ActionResult ExcluirCargo(int id)
        {
            Cargo oCargo = _Control.SelecionarCargo(id);

            Pessoa aPessoa = _Control.SelecionarPessoaCargo(id);

            if (aPessoa != null)
            {
                return Json("Não é possivel escluir esse cargo, pois existem funcionários cadastrados nesse cargo, por favor antes de excluir esse cargo exclua os funcionários que estão cadastrados no mesmo");
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
