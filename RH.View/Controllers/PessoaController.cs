using RH.Control;
using RH.Model;
using RH.View.Filtro;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Web;
using System.Web.Mvc;

namespace RH.View.Controllers
{
    [Autorizacao]
    public class PessoaController : Controller
    {
        private CPessoa DbPessoa = new CPessoa();

        // GET: Funcionario
        public ActionResult Index()
        {
            return View();
        }
        //cadastro de Funcionario
        public ActionResult CadastrarFuncionario()
        {
            ViewBag.Pes_Cargo_Car_ID = new SelectList(DbPessoa.SelecionarCargosEmpresa(Convert.ToInt32(Session["IDEmpresa"])), "Car_ID", "Car_Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AutorizacaoEmpresa]
        public ActionResult CadastrarFuncionario(Pessoa oFuncionario, HttpPostedFileBase Imagem)
        {
            oFuncionario.Pes_Situation = true;
            oFuncionario.Pes_DataAdmissao = DateTime.Now;

            ViewBag.Pes_Cargo_Car_ID = new SelectList(DbPessoa.SelecionarCargosEmpresa(Convert.ToInt32(Session["IDEmpresa"])), "Car_ID", "Car_Nome", oFuncionario.Pes_Cargo_Car_ID);

            if (Imagem == null)
            {
                ModelState.AddModelError("Imagem", "Por favor selecione a imagem do funcionário");
                return View();
            }

            else
            {
                byte[] ImagemFuncionario = new byte[Imagem.ContentLength];
                Imagem.InputStream.Read(ImagemFuncionario, 0, Imagem.ContentLength);
                oFuncionario.Pes_Imagem = ImagemFuncionario;
            }

            if (oFuncionario.Pes_Cargo_Car_ID==0)
            {
                return View();
            }

            

            DbPessoa.CadastrarFuncionario(oFuncionario);
            return RedirectToAction("MeusFuncionarios");

        }

        //edição dados do Funcionario

        [AutorizacaoEmpresa]
        public ActionResult AlterarFuncionario(int id)
        {
            var aPessoa = DbPessoa.SelecionarFuncionario(id);
            ViewBag.Pes_Cargo_Car_ID = new SelectList(DbPessoa.SelecionarCargosEmpresa(Convert.ToInt32(Session["IDEmpresa"])), "Car_ID", "Car_Nome",aPessoa.Pes_Cargo_Car_ID);
            return View(aPessoa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AutorizacaoEmpresa]
        public ActionResult AlterarFuncionario(Pessoa oFuncionario, HttpPostedFileBase Imagem)
        {
            ViewBag.Pes_Cargo_Car_ID = new SelectList(DbPessoa.SelecionarCargosEmpresa(Convert.ToInt32(Session["IDEmpresa"])), "Car_ID", "Car_Nome", oFuncionario.Pes_Cargo_Car_ID);

            //Retorna pra tela de alteração com todos os erros
            if(!ModelState.IsValid)
            {
                return View();
            }

            //Altera o funcionário e redireciona para tela de meus funcionários
            Pessoa aPessoa = DbPessoa.SelecionarFuncionario(oFuncionario.Pes_ID);

            if (Imagem != null)
            {
                byte[] NovaImagem = new byte[Imagem.ContentLength];
                Imagem.InputStream.Read(NovaImagem, 0, Imagem.ContentLength);
                aPessoa.Pes_Imagem = NovaImagem;
            }

            aPessoa.Pes_Nome = oFuncionario.Pes_Nome;
            aPessoa.Pes_Salario = oFuncionario.Pes_Salario;
            aPessoa.Pes_Endereco = oFuncionario.Pes_Endereco;
            aPessoa.Pes_CTrabalho = oFuncionario.Pes_CTrabalho;
            aPessoa.Pes_CPF = oFuncionario.Pes_CPF;
            aPessoa.Pes_Cidade = oFuncionario.Pes_Cidade;
            aPessoa.Pes_Cargo_Car_ID = oFuncionario.Pes_Cargo_Car_ID;
            DbPessoa.AlterarFuncionario(aPessoa);

            return RedirectToAction("MeusFuncionarios");
        }


        public FileContentResult GetImagemFuncionario(int id)
        {
            var aPessoa = DbPessoa.SelecionarFuncionario(id);
            return File(aPessoa.Pes_Imagem, aPessoa.Pes_Imagem.GetType().ToString());
        }

        [AutorizacaoEmpresa]
        public ActionResult MeusFuncionarios()
        {
            int IDEmpresa = Convert.ToInt32(Session["IDEmpresa"]);
            List<Pessoa> Funcionarios = DbPessoa.SelecionarTodosFuncionariosEmpresa(IDEmpresa);
            List<Setor> Setores = DbPessoa.SelecionarTodosSetores(IDEmpresa);
            List<Cargo> Cargos = DbPessoa.SelecionarCargosEmpresa(IDEmpresa);
            ViewBag.Setores = Setores;
            ViewBag.Cargos = Cargos;
            return View(Funcionarios);
        }

        public ActionResult Demitir(int id,string Motivo)
        {
            Pessoa aPessoa = DbPessoa.SelecionarFuncionario(id);
            aPessoa.Pes_Situation = false;
            DbPessoa.AlterarFuncionario(aPessoa);

            Demissao aDemissao = new Demissao()
            {
                Dem_Data = DateTime.Now,
                Dem_Motivo = Motivo,
                Dem_Pessoa_Pes_ID = id,
                Dem_Situation = true
            };

            if(Motivo=="Pediu demissão")
            {
                aDemissao.Dem_Salario = aPessoa.Pes_Salario * 2;
            }

            else
            {
                aDemissao.Dem_Salario = aPessoa.Pes_Salario - (aPessoa.Pes_Salario / 2);
            }

            DbPessoa.CadastrarDemissao(aDemissao);

            return Json("O funcionário foi demitido com sucesso!");
        }

    }

}
