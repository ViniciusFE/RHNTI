using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Model;
using RH.Control;

namespace RH.View.Controllers
{
    public class DadosBancariosController : Controller
    {

        private CDadoBancario _Control;

        public DadosBancariosController()
        {
            _Control = new CDadoBancario();
        }

        // GET: DadosBancarios
        public ActionResult Index(int IDFuncionario)
        {
            List<DadoBancario> Dados = _Control.DadosBanacarioFuncionario(IDFuncionario);
            Pessoa aPessoa = _Control.SelecionarFuncionario(IDFuncionario);
            ViewBag.IDFuncionario = IDFuncionario;
            ViewBag.NomeFuncionario = aPessoa.Pes_Nome;
            return View(Dados);
        }

        public ActionResult CadastrarDadoBancario(int IDFuncionario)
        {
            ViewBag.IDFuncionario = IDFuncionario;
            Pessoa oFuncionario = _Control.SelecionarFuncionario(IDFuncionario);
            ViewBag.NomeFuncionario = oFuncionario.Pes_Nome;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarDadoBancario(DadoBancario oDado,int IDFuncionario)
        {
            Pessoa aPessoa = _Control.SelecionarFuncionario(IDFuncionario);
            ViewBag.IDFuncionario = IDFuncionario;
            ViewBag.NomeFuncionario = aPessoa.Pes_Nome;

            if(ModelState.IsValid)
            {
                Empresa aEmpresa = _Control.SelecionarEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
                oDado.DB_DataCadastro = aEmpresa.Emp_DataAtual;
                oDado.DB_Pessoa_Pes_ID = IDFuncionario;
                oDado.DB_Situation = true;
                _Control.CadastrarDadoBancario(oDado);
                return RedirectToAction("Index",new { IDFuncionario=IDFuncionario});
            }

            return View();
        }

        public ActionResult AlterarDadoBancario(int IDDadoBancario,int IDFuncionario)
        {
            Pessoa aPessoa = _Control.SelecionarFuncionario(IDFuncionario);
            ViewBag.IDFuncionario = IDFuncionario;
            ViewBag.NomeFuncionario = aPessoa.Pes_Nome;

            DadoBancario oDado = _Control.SelecionarDadoBancario(IDDadoBancario);
            return View(oDado);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AlterarDadoBancario(DadoBancario oDado,int IDFuncionario)
        {
            Pessoa aPessoa = _Control.SelecionarFuncionario(IDFuncionario);
            ViewBag.IDFuncionario = IDFuncionario;
            ViewBag.NomeFuncionario = aPessoa.Pes_Nome;

            if(ModelState.IsValid)
            {
                DadoBancario DadoBancarioAlterar = _Control.SelecionarDadoBancario(oDado.DB_ID);
                DadoBancarioAlterar.DB_Numero = oDado.DB_Numero;
                DadoBancarioAlterar.DB_Tipo = oDado.DB_Tipo;
                _Control.AlterarDadoBancario(DadoBancarioAlterar);
                return View("Index",new { IDFuncionario=IDFuncionario});
            }

            return View(oDado);
        }

        public ActionResult ExcluirDadoBancario(int id)
        {
            DadoBancario oDado=_Control.SelecionarDadoBancario(id);
            oDado.DB_Situation = false;
            _Control.AlterarDadoBancario(oDado);
            return Json("Dado bancário excluído com sucesso!");
        }
    }
}
