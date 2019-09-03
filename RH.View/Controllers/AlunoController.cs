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
    [AutorizacaoProfessor]
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
            ViewBag.Avaliacoes = _Control.SelecionarAvaliacoesEmpresa(IDEmpresa, "").Count();

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

        public ActionResult Cargos(int IDEmpresa,int? pagina, string Pesquisa = "")
        {
            ViewBag.Pesquisado = null;
            List<Cargo> _cargos = _Control.SelecionarTodosCargosEmpresa(IDEmpresa);

            if (!string.IsNullOrEmpty(Pesquisa))
            {
                _cargos = _cargos.Where(p => p.Car_Nome.Contains(Pesquisa)).ToList();
                ViewBag.Pesquisado = Pesquisa;
            }

            int paginaTamanho = 4;
            int paginaNumero = (pagina ?? 1);

            Empresa aEmpresa = _Control.SelecionarEmpresa(IDEmpresa);
            ViewBag.NomeEmpresa = aEmpresa.Emp_Nome;
            ViewBag.IDEmpresa = aEmpresa.Emp_ID;

            return View(_cargos.ToPagedList(paginaNumero, paginaTamanho));
        }

        public ActionResult Funcionarios(int? pagina,int IDEmpresa,string Pesquisa = "")
        {
            ViewBag.Pesquisado = null;

            Empresa aEmpresa = _Control.SelecionarEmpresa(IDEmpresa);
            ViewBag.IDEmpresa = aEmpresa.Emp_ID;
            ViewBag.NomeEmpresa = aEmpresa.Emp_Nome;

            List<Beneficio> Beneficios = _Control.SelecionarBeneficiosEmpresa(IDEmpresa);
            ViewBag.Beneficios = Beneficios;


            List<Pessoa> Funcionarios = _Control.SelecionarFuncionariosEmpresa(IDEmpresa);
            List<Setor> Setores = _Control.SelecionarSetorEmpresa(IDEmpresa);
            List<Cargo> Cargos = _Control.SelecionarTodosCargosEmpresa(IDEmpresa);



            ViewBag.Setores = Setores;
            ViewBag.Cargos = Cargos;



            ViewBag.IDFuncionarioBeneficio = 0;

            if (Pesquisa != "")
            {
                Funcionarios = Funcionarios.Where(p => p.Pes_Nome.Contains(Pesquisa)).ToList();
                ViewBag.Pesquisado = Pesquisa;
            }

            int paginaTamanho = 5;
            int paginaNumero = (pagina ?? 1);

            return View(Funcionarios.ToPagedList(paginaNumero, paginaTamanho));

        }

        public ActionResult GetImagemFuncionario(int IDFuncionario)
        {
            Pessoa aPessoa = _Control.SelecionarFuncionario(IDFuncionario);
            return File(aPessoa.Pes_Imagem, aPessoa.Pes_Imagem.GetType().ToString());
        }

        public ActionResult Dependentes(int IDFuncionario,int IDEmpresa)
        {
            Pessoa aPessoa = _Control.SelecionarFuncionario(IDFuncionario);
            ViewBag.IDFuncionario = IDFuncionario;
            ViewBag.NomeFuncionario = aPessoa.Pes_Nome;

            ViewBag.IDEmpresa = IDEmpresa;

            return View(_Control.SelecionarDependentesFuncionario(IDFuncionario));
        }

        public ActionResult DadosBancarios(int IDFuncionario,int IDEmpresa)
        {
            List<DadoBancario> Dados = _Control.SelecionarDadosBancariosFuncionario(IDFuncionario);
            Pessoa aPessoa = _Control.SelecionarFuncionario(IDFuncionario);
            ViewBag.IDFuncionario = IDFuncionario;
            ViewBag.NomeFuncionario = aPessoa.Pes_Nome;
            ViewBag.IDEmpresa = IDEmpresa;
            return View(Dados);
        }

        public ActionResult PopularBeneficiosFuncionario(int id,int IDEmpresa)
        {
            List<Beneficio> BeneficiosEmpresa = _Control.BeneficiosEmpresa(IDEmpresa);

            List<object> Beneficios = new List<object>();

            foreach (var x in BeneficiosEmpresa)
            {
                string status;
                if (_Control.PossuiBeneficio(x.Ben_ID, id))
                {
                    status = "Possui";
                }

                else
                {
                    status = "Não possui";
                }

                Beneficios.Add(
                    new
                    {
                        ID = x.Ben_ID,
                        Nome = x.Ben_Nome,
                        Status = status,
                        Descricao = x.Ben_Descricao,
                        Custo = x.Ben_Custo
                    }
                    );
            }

            return Json(Beneficios, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AvaliacaoFuncionarios(int IDEmpresa,string Pesquisado="")
        {
            List<Avaliacao> Avaliacoes = _Control.SelecionarAvaliacoesEmpresa(IDEmpresa,Pesquisado);
            ViewBag.IDEmpresa = IDEmpresa;

            if(!string.IsNullOrEmpty(Pesquisado))
            {
                ViewBag.Pesquisado = Pesquisado;
            }

            Empresa aEmpresa = _Control.SelecionarEmpresa(IDEmpresa);
            ViewBag.NomeEmpresa = aEmpresa.Emp_Nome;

            return View(Avaliacoes);
        }

        public ActionResult Beneficios(int IDEmpresa)
        {
            List<Beneficio> b = _Control.SelecionarBeneficiosEmpresa(IDEmpresa);
            Empresa aEmpresa = _Control.SelecionarEmpresa(IDEmpresa);
            ViewBag.NomeEmpresa = aEmpresa.Emp_Nome;
            return View(b);
        }

        public ActionResult Notas(int CodigoProva)
        {
            return View(_Control.SelecionarNotasProva(CodigoProva).OrderBy(p=>p.MatriculaAluno));
        }
    }
}
