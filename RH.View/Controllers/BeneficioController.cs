using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Control;
using RH.Model;

namespace RH.View.Controllers
{
    public class BeneficioController : Controller
    {
        private CBeneficio _Control;

        public BeneficioController()
        {
            _Control = new CBeneficio();
        }

        // GET: Beneficio
        public ActionResult Index()
        {
            List<Beneficio> b = _Control.SelecionarBeneficiosEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
            Empresa aEmpresa = _Control.SelecionarEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
            ViewBag.NomeEmpresa = aEmpresa.Emp_Nome;
            return View(b);
        }

        public ActionResult CadastrarBeneficio()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarBeneficio(Beneficio oBeneficio,string Preco="")
        {
            if(Convert.ToBoolean(Session["Avaliativa"]))
            {
                if(_Control.LimiteBeneficiosEmpresaAvaliativa(Convert.ToInt32(Session["IDEmpresa"])))
                {
                    ModelState.AddModelError("Limite", "O limite de benefícios nessa Empresa Avaliativa foi atingido. (Limite de Benefícios = 5)");
                }
            }

            if (Preco == "")
            {
                ModelState.AddModelError("Ben_Custo", "Digite o custo desse benefício");
            }

            if (ModelState.IsValid)
            {
                
                Empresa aEmpresa = _Control.SelecionarEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
                oBeneficio.Ben_Empresa_Emp_ID = aEmpresa.Emp_ID;
                oBeneficio.Ben_DataCadastro = aEmpresa.Emp_DataAtual;
                oBeneficio.Ben_Situation = true;
                oBeneficio.Ben_Custo = Math.Round(Convert.ToDouble(Preco), 2);
                _Control.Incluir(oBeneficio);
                return RedirectToAction("Index");
            }

            

            return View();
        }

        public ActionResult AlterarBeneficio(int id)
        {
            Beneficio b =  _Control.SelecionarBeneficioID(id);
            return View(b);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AlterarBeneficio(Beneficio oBeneficio,string Preco="")
        {
            if (Preco == "")
            {
                ModelState.AddModelError("Ben_Custo", "Digite o custo desse benefício");
            }

            if (ModelState.IsValid)
            {
                Beneficio AlterarBeneficio = _Control.SelecionarBeneficioID(oBeneficio.Ben_ID);
                AlterarBeneficio.Ben_Nome = oBeneficio.Ben_Nome;
                AlterarBeneficio.Ben_Descricao = oBeneficio.Ben_Descricao;
                AlterarBeneficio.Ben_Custo = Math.Round(Convert.ToDouble(Preco),2);
                _Control.Alterar(AlterarBeneficio);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult ExcluirBeneficio(int id)
        {
            Beneficio b = _Control.SelecionarBeneficioID(id);
            b.Ben_Situation = false;
            _Control.Alterar(b);
            return Json ("Benefício excluído com sucesso!");
        }

    }
}
