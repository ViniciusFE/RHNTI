using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Control;
using RH.Model;

namespace RH.View.Controllers
{
    public class AvaliacaoController : Controller
    {
        private CAvaliacao _Control;

        public AvaliacaoController()
        {
            _Control = new CAvaliacao();
        }
        // GET: Avaliacao
        public ActionResult Index()
        {
            List<Pessoa> Chefes = _Control.SelecionarTodosChefes();
            ViewBag.Pes_Nome = new SelectList(Chefes, "Pes_ID", "Pes_Nome");
            return View(Chefes);
        }

        public ActionResult MeusFuncionarios(int IDChefe)
        {
            Pessoa ChefeSetor = _Control.SelecionarPessoa(IDChefe);
            Cargo CargoChefe = _Control.SelecionarCargo(ChefeSetor.Pes_Cargo_Car_ID);
            List<Pessoa> MeusFuncionarios = _Control.SelecionarTodosMeusFuncionarios(CargoChefe.Car_Setor_Set_ID, ChefeSetor.Pes_ID);

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
            Avaliacao aAvaliacao = new Avaliacao()
            {
                Ava_Pessoa_Pes_ID = id,
                Ava_DataCadastro = DateTime.Now,
                Ava_Situation = true,
            };
            _Control.CadastrarAvaliacao(aAvaliacao);
            return Json("A avaliação do funcionário foi efetuada com sucesso, obrigado!");
        }
    }
}
