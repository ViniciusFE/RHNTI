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
    public class AlunoController : Controller
    {
        CAluno _Control;
        private RHEntities x = Model.Helper.Connection.GetConnection();

        public AlunoController()
        {
            _Control = new CAluno();
        }

        // GET: Aluno
        public ActionResult Index(int ano = 0)
        {
            List<Aluno> Alunos = new List<Aluno>();

            if (ano == 0)
            {
                Alunos = _Control.SelecionarTodosAlunos(DateTime.Now.Year);
            }

            else
            {
                Alunos = _Control.SelecionarTodosAlunos(ano);
            }

            return View(Alunos.OrderBy(p => p.Alu_Nome));
        }

        public ActionResult Empresas(int IDAluno)
        {
            Aluno oAluno = _Control.SelecionarAluno(IDAluno);
            ViewBag.NomeAluno = oAluno.Alu_Nome;
            List<Empresa> MinhasEmpresas = _Control.SelecionarEmpresasAluno(IDAluno);
            return View(MinhasEmpresas);
        }

        public ActionResult GetImagemEmpresa(int id)
        {
            Empresa aEmpresa = _Control.SelecionarEmpresa(id);
            return File(aEmpresa.Emp_Logo, aEmpresa.Emp_Logo.GetType().ToString());
        }

        public ActionResult Empresa(int IDEmpresa)
        {
            Empresa aEmpresa = _Control.SelecionarEmpresa(IDEmpresa);

            ViewBag.IDEmpresa = aEmpresa.Emp_ID;
            ViewBag.NomeEmpresa = aEmpresa.Emp_Nome;
            ViewBag.Setores = _Control.QuantidadeSetor(IDEmpresa);
            ViewBag.Cargos = _Control.QuantidadeCargo(IDEmpresa);
            ViewBag.Funcionarios = _Control.QuantidadeFuncioanarios(IDEmpresa);
            ViewBag.Beneficios = _Control.QuantidadeBeneficiosEmpresa(IDEmpresa);

            return View();
        }

        public ActionResult Setores(int IDEmpresa,int? pagina, string Pesquisa = "Pesquisar setores")
        {
            ViewBag.Pesquisa = null;
            ViewBag.Pesquisado = Pesquisa;
            ViewBag.Setores = _Control.SelecionarSetorEmpresa(IDEmpresa);
            ViewBag.IDEmpresa = IDEmpresa;
            Empresa aEmpresa = _Control.SelecionarEmpresa(IDEmpresa);
            ViewBag.NomeEmpresa = aEmpresa.Emp_Nome;

            List<Setor> _setores = _Control.SelecionarSetorEmpresa(IDEmpresa);

            if (Pesquisa != "Pesquisar setores")
            {
                _setores = _setores.Where(p => p.Set_Nome.Contains(Pesquisa)).ToList();
                if (_setores.Count() == 0)
                {
                    ViewBag.Pesquisa = "Não foi encontrado nenhum resultado referente a pesquisa '" + Pesquisa + "', verifique o que foi digitado e tente novamente.";
                }
            }

            int paginaTamanho = 4;
            int paginaNumero = (pagina ?? 1);

            return View(_setores.ToPagedList(paginaNumero, paginaTamanho));
        }
    }
}
