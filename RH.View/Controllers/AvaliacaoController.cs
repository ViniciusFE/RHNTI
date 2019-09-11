using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Control;
using RH.Model;
using RH.View.Filtro;

namespace RH.View.Controllers
{
    [AutorizacaoEmpresa]
    public class AvaliacaoController : Controller
    {
        private CAvaliacao _Control;

        public AvaliacaoController()
        {
            _Control = new CAvaliacao();
        }

        public ActionResult Index(string Pesquisado="")
        {
            List<Avaliacao> Avaliacoes = _Control.SelecionarAvaliacoesEmpresa(Convert.ToInt32(Session["IDEmpresa"]), Pesquisado);
            ViewBag.IDEmpresa = Convert.ToInt32(Session["IDEmpresa"]);

            if (!string.IsNullOrEmpty(Pesquisado))
            {
                ViewBag.Pesquisado = Pesquisado;
            }

            Empresa aEmpresa = _Control.SelecionarEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
            ViewBag.NomeEmpresa = aEmpresa.Emp_Nome;

            return View(Avaliacoes);
        }

        public ActionResult Avaliacao()
        {
            List<Pessoa> Chefes = _Control.SelecionarTodosChefes(Convert.ToInt32(Session["IDEmpresa"]));
            ViewBag.Pes_Nome = new SelectList(Chefes, "Pes_ID", "Pes_Nome");
            return View(Chefes);
        }

        public ActionResult MeusFuncionarios(int IDChefe)
        {
            Pessoa ChefeSetor = _Control.SelecionarPessoa(IDChefe);
            Cargo CargoChefe = _Control.SelecionarCargo(ChefeSetor.Pes_Cargo_Car_ID);
            Setor oSetorChefe = _Control.SelecionarSetor(CargoChefe.Car_Setor_Set_ID);
            List<Pessoa> MeusFuncionarios = _Control.SelecionarTodosMeusFuncionarios(CargoChefe.Car_Setor_Set_ID, oSetorChefe.Set_Empresa_Emp_ID);

            List<object> DadosFuncionarios = new List<object>();

            foreach(var x in MeusFuncionarios)
            {
                Cargo oCargo = _Control.SelecionarCargo(x.Pes_Cargo_Car_ID);
                Setor oSetor = _Control.SelecionarSetor(oCargo.Car_Setor_Set_ID);
                DadosFuncionarios.Add(
                    new
                    {
                        ID=x.Pes_ID,
                        Nome=x.Pes_Nome,
                        CargoOcupacao=oCargo.Car_Nome,
                        Salario=x.Pes_Salario,
                        Setor=oSetor.Set_Nome,
                        CPF=x.Pes_CPF,
                        CarteiraTrabalho=x.Pes_CTrabalho,
                        DataAdmissao=x.Pes_DataCadastro,
                        Cidade=x.Pes_Cidade,
                        Endereco=x.Pes_Endereco
                    }
                );
            }

            return Json(DadosFuncionarios,JsonRequestBehavior.AllowGet);
        }

        public FileContentResult GetImagemUsuario(int id)
        {
            Pessoa aPessoa = _Control.SelecionarPessoa(id);
            return File(aPessoa.Pes_Imagem, aPessoa.Pes_Imagem.GetType().ToString());
        }

        public ActionResult AvaliacaoFuncionario(int id,string Avaliacao)
        {
            if (Convert.ToBoolean(Session["Avaliativa"]))
            {
                if (_Control.LimiteAvaliacoesEmpresaAvaliativa(Convert.ToInt32(Session["IDEmpresa"])))
                {
                    return Json("O limite de avaliações nessa Empresa Avaliativa foi atingido. (Limite de Avaliações = 4)");
                }
            }

            Empresa aEmpresa = _Control.SelecionarEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
            Avaliacao aAvaliacao = new Avaliacao()
            {
                Ava_Pessoa_Pes_ID = id,
                Ava_DataCadastro =aEmpresa.Emp_DataAtual,
                Ava_Situation = true,
                Ava_Avaliacao=Avaliacao
            };
            _Control.CadastrarAvaliacao(aAvaliacao);
            return Json("A avaliação do funcionário foi efetuada com sucesso!");
        }

        public ActionResult ExcluirAvaliacao(int id)
        {
            Avaliacao aAvaliacao = _Control.SelecionarAvaliacao(id);
            aAvaliacao.Ava_Situation = false;
            _Control.AlterarAvaliacao(aAvaliacao);
            return Json("A avaliação foi excluída com sucesso!");
        }
    }
}
