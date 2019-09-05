using System.Web.Mvc;
using RH.Model;
using RH.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using RH.View.CriptoHelper;

namespace RH.View.Controllers
{
    public class DependenteController : Controller
    {
        CDependente _Control;

        public List<object> Parentescos()
        {
            List<object> Parentesco = new List<object>();

            Parentesco.Add(
                    new
                    {
                        Valor = "Pai",
                        Nome = "Pai"
                    }
                );

            Parentesco.Add(
                    new
                    {
                        Valor = "Mãe",
                        Nome = "Mãe"
                    }
                );

            Parentesco.Add(
                    new
                    {
                        Valor = "Tio/a",
                        Nome = "Tio/a"
                    }
                );

            Parentesco.Add(
                    new
                    {
                        Valor = "Vô/ó",
                        Nome = "Vô/ó"
                    }
                );

            Parentesco.Add(
                    new
                    {
                        Valor = "Primo/a",
                        Nome = "Primo/a"
                    }
                );

            Parentesco.Add(
                    new
                    {
                        Valor = "Filho/a",
                        Nome = "Filho/a"
                    }
                );

            Parentesco.Add(
                    new
                    {
                        Valor = "Neto/a",
                        Nome = "Neto/a"
                    }
                );

            return Parentesco;
        }

        public DependenteController()
        {
            _Control = new CDependente();
        }

        public ActionResult Index(string IDFuncionario)
        {
            int IDDescriptografado = Convert.ToInt32(Criptografia.DecriptQueryString(IDFuncionario));

            Pessoa aPessoa = _Control.SelecionarFuncionario(IDDescriptografado);
            ViewBag.IDFuncionario = IDFuncionario;
            ViewBag.NomeFuncionario = aPessoa.Pes_Nome;
            return View(_Control.SelecionarDependetesFuncionario(IDDescriptografado));
        }

        public ActionResult CadastrarDependente(string IDFuncionario)
        {
            int IDDescriptografado = Convert.ToInt32(Criptografia.DecriptQueryString(IDFuncionario));
            Pessoa aPessoa = _Control.SelecionarFuncionario(IDDescriptografado);

            ViewBag.NomeFuncionario = aPessoa.Pes_Nome;
            ViewBag.IDFuncionario = IDFuncionario;

            ViewBag.DP_Parentesco = new SelectList(Parentescos(), "Valor", "Nome");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarDependente(DadoDependente oDependente,string IDFuncionario)
        {
            ViewBag.DP_Parentesco = new SelectList(Parentescos(), "Valor", "Nome");
            ViewBag.IDFuncionario = IDFuncionario;

            int IDDescriptografado = Convert.ToInt32(Criptografia.DecriptQueryString(IDFuncionario));


            if (Convert.ToBoolean(Session["Avaliativa"]))
            {
                if (_Control.LimiteDependentesEmpresaAvaliativa(Convert.ToInt32(Session["IDEmpresa"])))
                {
                    ModelState.AddModelError("Limite", "O limite de dependentes nessa Empresa Avaliativa foi atingido. (Limite de Dependentes = 5)");
                }
            }

            if (oDependente.DP_Parentesco=="Pai" || oDependente.DP_Parentesco=="Mãe")
            {
                if (_Control.VerificarParentesco(IDDescriptografado,oDependente.DP_Parentesco))
                {
                    ModelState.AddModelError("DP_Parentesco", "Este usuário já possui um dependente o grau de parentesco '" + oDependente.DP_Parentesco + "'");
                    return View();
                }
            }

            if (ModelState.IsValid)
            {
                Empresa aEmpresa = _Control.SelecionarEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
                oDependente.DP_Pessoa_Pes_ID = IDDescriptografado;
                oDependente.DP_DataCadastro = aEmpresa.Emp_DataAtual;
                oDependente.DP_Situation = true;
                _Control.CadastrarDependente(oDependente);
                return RedirectToAction("Index",new { IDFuncionario=IDFuncionario});
            }

            return View();
        }

        public ActionResult AlterarDependente(string id)
        {
            int IDDescriptografado = Convert.ToInt32(Criptografia.DecriptQueryString(id));
            DadoDependente Dependente = _Control.SelecionarDependente(IDDescriptografado);
            ViewBag.DP_Parentesco = new SelectList(Parentescos(), "Valor", "Nome");
            return View(Dependente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AlterarDependente(DadoDependente oDependente)
        {
            ViewBag.DP_Parentesco = new SelectList(Parentescos(), "Valor", "Nome");
            DadoDependente DP = _Control.SelecionarDependente(oDependente.DP_ID);

            if (oDependente.DP_Parentesco == "Pai" || oDependente.DP_Parentesco == "Mãe")
            {
                if(DP.DP_Parentesco!=oDependente.DP_Parentesco)
                {
                    if (_Control.VerificarParentesco(DP.DP_Pessoa_Pes_ID, oDependente.DP_Parentesco))
                    {
                        ModelState.AddModelError("DP_Parentesco", "Este usuário já possui um dependente o grau de parentesco '" + oDependente.DP_Parentesco + "'");
                        return View(oDependente);
                    }
                }               
            }

            if (ModelState.IsValid)
            {
               
                DP.DP_Nome = oDependente.DP_Nome;
                DP.DP_Parentesco = oDependente.DP_Parentesco;
                _Control.AlterarDependente(DP);
                return RedirectToAction("Index",new { IDFuncionario=Criptografia.EncryptQueryString(DP.DP_Pessoa_Pes_ID.ToString())});
            }

            return View(oDependente);
        }

        public ActionResult ExcluirDependente(int id)
        {
            DadoDependente oDependente = _Control.SelecionarDependente(id);
            oDependente.DP_Situation = false;
            _Control.AlterarDependente(oDependente);
            return Json("O dependente foi excluído com sucesso!");
        }
    }
}
