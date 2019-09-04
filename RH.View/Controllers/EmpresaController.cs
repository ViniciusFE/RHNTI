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

            aProva = _Control.SelecionarProvaEntregue(oAluno.Alu_ID);
            if(aProva!=null && DateTime.Compare(aProva.Pro_DataTermino.Date,DateTime.Now.Date)<=0)
            {
                Nota aNota = _Control.SelecionarNotaProva(aProva.Pro_ID);
                if(aNota.Not_Nota<10)
                {
                    ViewBag.Nota = aNota.Not_Nota;
                    ViewBag.NomeAluno = oAluno.Alu_Nome;
                    ViewBag.DataEntrega = aNota.Not_DataCadastro;
                    ViewBag.IDProva = aProva.Pro_ID;                    
                }
               
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
            Aluno oAluno = (Aluno)Session["User"];

            Prova aProva = _Control.ProvaAluno(oAluno.Alu_ID);

            if (aProva != null)
            {
                ViewBag.DataTermino = aProva.Pro_DataTermino;
            }

            if (Avaliativa)
            {
                if (_Control.EmpresaAvaliativaAtiva(oAluno.Alu_ID))
                {
                    ModelState.AddModelError("EmpresaAvaliativa", "Você já possui uma empresa avaliativa, você não pode ter duas empresas avaliativas cadastradas ao mesmo tempo.");
                    return View();
                }
            }
            
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
                empresa.Emp_Logo = imagem;
            }

            empresa.Emp_Nome = aEmpresa.Emp_Nome;
            empresa.Emp_Estado = aEmpresa.Emp_Estado;
            empresa.Emp_Cidade = aEmpresa.Emp_Cidade;
            empresa.Emp_Endereco = aEmpresa.Emp_Endereco;
            empresa.Emp_CNPJ = aEmpresa.Emp_CNPJ;
            empresa.Emp_RegistroEstadual = aEmpresa.Emp_RegistroEstadual;

            _Control.AlterarEmpresa(empresa);
            return RedirectToAction("Index","Home",new { id=empresa.Emp_ID,nomeEmpresa=empresa.Emp_Nome});

        }

        public ActionResult GetImagem(int id)
        {
            Empresa aEmpresa = _Control.SelecionarEmpresa(id);
            return File(aEmpresa.Emp_Logo, aEmpresa.Emp_Logo.GetType().ToString());
        }
    }
}
