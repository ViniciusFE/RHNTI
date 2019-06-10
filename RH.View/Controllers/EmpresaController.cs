using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Model;
using RH.Control;
using PagedList;

namespace RH.View.Controllers
{
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
            int paginaTamanho = 4;
            int paginaNumero = (pagina ?? 1);
            List<Empresa> MinhasEmpresas = _Control.SelecionarTodasEmpresasAluno(1);
            return View(MinhasEmpresas.ToPagedList(paginaNumero, paginaTamanho));
        }

        public ActionResult CadastrarEmpresa()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarEmpresa(Empresa aEmpresa, HttpPostedFileBase Imagem)
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
                aEmpresa.Emp_DataAtual = Convert.ToDateTime("01/01/2019");
                aEmpresa.Emp_Situation = true;
                aEmpresa.Emp_Aluno_Alu_ID = Convert.ToInt32(1);
                _Control.CadastrarEmpresa(aEmpresa);
                return RedirectToAction("MinhasEmpresas");
            }
            return View();
        }
    }
}
