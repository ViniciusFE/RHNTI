using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Model;
using RH.Control;
using PagedList;
using RH.View.Filtro;

namespace RH.View.Controllers
{
    [Autorizacao]
    public class EmpresaController : Controller
    {
        private CEmpresa _Control;

        public EmpresaController()
        {
            _Control = new CEmpresa();
        }

        // GET: Empresa
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MinhasEmpresas(int? pagina)
        {
            Session["IDEmpresa"] = null;

            int paginaTamanho = 4;
            int paginaNumero = (pagina ?? 1);
            Aluno oAluno = (Aluno)Session["User"];
            List<Empresa> MinhasEmpresas = _Control.SelecionarTodasEmpresasAluno(oAluno.Alu_ID);

            Prova aProva = _Control.ProvaAluno(oAluno.Alu_ID);

            if(aProva!=null)
            {
                ViewBag.DataTermino = aProva.Pro_DataTermino;
            }

            return View(MinhasEmpresas.ToPagedList(paginaNumero, paginaTamanho));
        }

        public ActionResult CadastrarEmpresa()
        {
            Aluno oAluno = (Aluno)Session["User"];
            Prova aProva = _Control.ProvaAluno(oAluno.Alu_ID);

            if (aProva != null)
            {
                ViewBag.DataTermino = aProva.Pro_DataTermino;
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarEmpresa(Empresa aEmpresa, HttpPostedFileBase Imagem,bool Avaliativa=false)
        {
            if (Imagem != null)
            {
                byte[] Arquivo = new byte[Imagem.ContentLength];
                Imagem.InputStream.Read(Arquivo, 0, Imagem.ContentLength);
                aEmpresa.Emp_Logo = Arquivo;
            }

            else
            {
                ModelState.AddModelError("Imagem", "Por favor selecione uma logo para sua empresa");
                return View();
            }

            if (ModelState.IsValid)
            {
                aEmpresa.Emp_DataCadastro = DateTime.Now;
                aEmpresa.Emp_DataAtual = "01/01";
                aEmpresa.Emp_Situation = true;
                Aluno oAluno = (Aluno)Session["User"];
                aEmpresa.Emp_Aluno_Alu_ID = Convert.ToInt32(oAluno.Alu_ID);
                aEmpresa.Emp_Avaliativa = Avaliativa;
                _Control.CadastrarEmpresa(aEmpresa);
                return RedirectToAction("MinhasEmpresas");
            }
            return View();
        }

        [AutorizacaoEmpresa]        
        public ActionResult EditarEmpresa(int id)
        {
            Empresa aEmpresa = _Control.SelecionarEmpresa(id);
            return View(aEmpresa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarEmpresa(Empresa aEmpresa,HttpPostedFileBase Imagem)
        {
            Empresa empresa = _Control.SelecionarEmpresa(aEmpresa.Emp_ID);

            if (!ModelState.IsValid)
            {
                return View(aEmpresa);
            }

            if (Imagem != null)
            {
                byte[] imagem = new byte[Imagem.ContentLength];
                Imagem.InputStream.Read(imagem, 0, Imagem.ContentLength);
                aEmpresa.Emp_Logo = imagem;
            }

            else
            {
                aEmpresa.Emp_Logo = empresa.Emp_Logo;
            }

            aEmpresa.Emp_DataAtual = empresa.Emp_DataAtual;
            aEmpresa.Emp_DataCadastro = empresa.Emp_DataCadastro;
            aEmpresa.Emp_Aluno_Alu_ID = empresa.Emp_Aluno_Alu_ID;
            aEmpresa.Emp_Situation = empresa.Emp_Situation;

            _Control.AlterarEmpresa(aEmpresa);
            return RedirectToAction("MinhasEmpresas");

        }

        public ActionResult GetImagem(int id)
        {
            Empresa aEmpresa = _Control.SelecionarEmpresa(id);
            return File(aEmpresa.Emp_Logo, aEmpresa.Emp_Logo.GetType().ToString());
        }
    }
}
