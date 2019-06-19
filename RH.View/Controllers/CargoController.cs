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

            //Remove o cargo dele da lista, pois um cargo não pode ter como chefe o próprio cargo.
            List<Cargo> lc = _Control.SelecionarTodosCargosEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
            Cargo cargo = _Control.SelecionarCargo(id);
            lc.Remove(cargo);

            //Adiciona a opção de chefe na lista
            Cargo x = new Cargo();
            x.Car_ID = -42;
            x.Car_Nome = "Este cargo é o chefe do setor";
            lc.Add(x);

            //Ordena por ordem de ID
            lc.OrderBy(p => p.Car_ID);

            //Se o cargo não possuir um chefe ele coloca a opção de chefe se não a quem esse cargo responde
            if(oCargo.Car_Cargo_Car_ID==null)
            {
                ViewBag.Car_Cargo_Car_ID = new SelectList(lc, "Car_ID", "Car_Nome", -42);
            }

            else
            {
                ViewBag.Car_Cargo_Car_ID = new SelectList(lc, "Car_ID", "Car_Nome", oCargo.Car_Cargo_Car_ID);
            }
            

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

                //Se  o cargo vier com o valor -42 ele será o chefe do setor
                if(oCargo.Car_ID==-42)
                {
                    x.Car_Cargo_Car_ID = null;
                }

                else
                {
                    x.Car_Cargo_Car_ID = oCargo.Car_Cargo_Car_ID;
                }
                
                _Control.AlterarCargo(x);                
            }
            return RedirectToAction("Index");

        }

        public ActionResult ExcluirCargo(int id,int IDPessoa=0)
        {
            Cargo oCargo = _Control.SelecionarCargo(id);
            if (IDPessoa==0)
            {
                Pessoa aPessoa = _Control.SelecionarPessoaCargo(id);

                if (aPessoa != null)
                {
                    return Json("Este cargo não pode ser excluído, pois está atualmente ocupado pelo funcionário " + aPessoa.Pes_Nome + " tem certeza que deseja continuar? isso fará com o que o funcionário que o ocupa o cargo seja demitido.", aPessoa.Pes_ID.ToString());
                }

                else
                {
                    oCargo.Car_Situation = false;
                    _Control.ExcluirCargo(oCargo);
                }
            }

            else
            {
                Pessoa aPessoa = _Control.SelecionarFuncionario(IDPessoa);
                aPessoa.Pes_Situation = false;
                _Control.AlterarFuncionario(aPessoa);

                oCargo.Car_Situation = false;
                _Control.AlterarCargo(oCargo);
            }

            return Json("O cargo foi excluído com sucesso!");
        }

    }
}
