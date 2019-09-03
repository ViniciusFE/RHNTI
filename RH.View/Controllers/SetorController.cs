using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Model;
using RH.Control;
using RH.View.Filtro;
using PagedList;
using RH.View.CriptoHelper;

namespace RH.View.Controllers
{
    [AutorizacaoEmpresa]
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
        public ActionResult Index(int? pagina,string Pesquisa= "Pesquisar setores")
        {
            ViewBag.Pesquisa = null;
            ViewBag.Pesquisado = Pesquisa;
            ViewBag.Setores = _Control.SelecionarSetorEmpresa(Convert.ToInt32(Session["IDEmpresa"]));

            List<Setor> _setores = _Control.SelecionarSetorEmpresa(Convert.ToInt32(Session["IDEmpresa"]));

            if(Pesquisa!="Pesquisar setores")
            {
                _setores = _setores.Where(p => p.Set_Nome.Contains(Pesquisa)).ToList();
                if(_setores.Count()==0)
                {
                    ViewBag.Pesquisa="Não foi encontrado nenhum resultado referente a pesquisa '"+Pesquisa+"', verifique o que foi digitado e tente novamente.";
                }
            }

            int paginaTamanho = 4;
            int paginaNumero = (pagina ?? 1);

            return View(_setores.ToPagedList(paginaNumero,paginaTamanho));
        }

        public ActionResult CadastrarSetor()
        {
            ViewBag.Setores = _Control.SelecionarSetorEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarSetor(Setor oSetor,int SetorRespondente)
        {
            ViewBag.Setores = _Control.SelecionarSetorEmpresa(Convert.ToInt32(Session["IDEmpresa"]));

            bool EmpresaAvaliativa = Convert.ToBoolean(Session["Avaliativa"]);

            if(EmpresaAvaliativa)
            {
                if(_Control.LimiteSetoresEmpresaAvaliativa(Convert.ToInt32(Session["IDEmpresa"])))
                {
                    ModelState.AddModelError("Limite", "O limite de setores nessa Empresa Avaliativa foi atingido. (Limite de Setores = 5)");
                    return View();
                }
            }
                
            

            if (ModelState.IsValid)
            {
                Empresa aEmpresa = _Control.SelecionarEmpresa(Convert.ToInt32(Session["IDEmpresa"]));

                oSetor.Set_DataCadastro = aEmpresa.Emp_DataAtual;
                oSetor.Set_Situation = true;
                oSetor.Set_Empresa_Emp_ID = Convert.ToInt32(Session["IDEmpresa"]);

                if(SetorRespondente==0)
                {
                    oSetor.Set_Setor_Set_ID = oSetor.Set_ID;
                }

                else
                {
                    oSetor.Set_Setor_Set_ID = SetorRespondente;
                }

                _Control.CadastrarSetor(oSetor);

                if(SetorRespondente==0)
                {
                    Setor oSetor2 = _Control.SelecionarSetorPeloNome(oSetor.Set_Nome);
                    oSetor2.Set_Setor_Set_ID = oSetor2.Set_ID;
                    _Control.AlterarSetor(oSetor2);
                }

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

        public ActionResult AlterarSetor(string id)
        {
            int IDDescriptografado = Convert.ToInt32(Criptografia.DecryptQueryString(id));
            Setor oSetor = _Control.SelecionarSetor(IDDescriptografado);
            ViewBag.Setores = _Control.SelecionarSetorEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
            return View(oSetor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AlterarSetor(Setor oSetor,int SetorRespondente)
        {
            ViewBag.Setores = _Control.SelecionarSetorEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
            
            if (ModelState.IsValid)
            {
                Setor nSetor = _Control.SelecionarSetor(oSetor.Set_ID);
                oSetor.Set_Empresa_Emp_ID = nSetor.Set_Empresa_Emp_ID;
                oSetor.Set_Situation = nSetor.Set_Situation;
                oSetor.Set_DataCadastro = nSetor.Set_DataCadastro;
                if(SetorRespondente==0)
                {
                    oSetor.Set_Setor_Set_ID = nSetor.Set_ID;
                }

                else
                {
                    oSetor.Set_Setor_Set_ID = SetorRespondente;
                }

                _Control.AlterarSetor(oSetor);
                return RedirectToAction("Index");
            }
            return View(oSetor);
            
        }

        public ActionResult ExcluirSetor(int id)
        {
            string[] retorno = new string[2];

            if(!_Control.PossuiSetores(id))
            {
                Setor oSetor = _Control.SelecionarSetor(id);
                oSetor.Set_Situation = false;
                _Control.AlterarSetor(oSetor);

                retorno[0] = "O setor foi excluído com sucesso!";
                retorno[1] = "Excluido";

                return Json(retorno);
            }

            retorno[0] = "O setor não pode ser excluído, poís existem outros setores que respondem ao mesmo. Para excluir esse setor primeiro apague ou altere os setores que respondem a este.";
            retorno[1] = "Erro";

            return Json(retorno);
        }

    }
}
