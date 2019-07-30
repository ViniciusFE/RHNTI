using RH.Control;
using RH.Model;
using RH.View.Filtro;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RH.View.Controllers
{
    [Autorizacao]
    public class PessoaController : Controller
    {
        private CPessoa DbPessoa = new CPessoa();
        private CBeneficio DbBeneficos = new CBeneficio();


        // GET: Funcionario
        public ActionResult Index()
        {
            return View();
        }
        //cadastro de Funcionario
        public ActionResult CadastrarFuncionario()
        {
            List<Cargo> Cargos = DbPessoa.SelecionarCargosEmpresa(Convert.ToInt32(Session["IDEmpresa"]));

            if(Cargos.Count==0)
            {
                ViewBag.Cargos = "Você ainda não pode cadastrar funcionários, pois ainda não existem cargos cadastrados na sua empresa, por favor cadastre um cargo e a funcionalidade de cadastrar funcionários estará habilitada.";
            }

            ViewBag.Pes_Cargo_Car_ID = new SelectList(DbPessoa.SelecionarCargosEmpresa(Convert.ToInt32(Session["IDEmpresa"])), "Car_ID", "Car_Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AutorizacaoEmpresa]
        public ActionResult CadastrarFuncionario(Pessoa oFuncionario, HttpPostedFileBase Imagem)
        {
            oFuncionario.Pes_Situation = true;

            Empresa aEmpresa = DbPessoa.SelecionarEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
            oFuncionario.Pes_DataCadastro=aEmpresa.Emp_DataAtual;

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
      
            
        public ActionResult MeusFuncionarios(string Pesquisa="")
        { 
            ViewBag.Pesquisado=null;

            int IDEmpresa = Convert.ToInt32(Session["IDEmpresa"]);
            List<Pessoa> Funcionarios = DbPessoa.SelecionarTodosFuncionariosEmpresa(IDEmpresa);
            List<Setor> Setores = DbPessoa.SelecionarTodosSetores(IDEmpresa);
            List<Cargo> Cargos = DbPessoa.SelecionarCargosEmpresa(IDEmpresa);


<<<<<<< HEAD
            int qtd =DbPessoa.BeneficiosEmpresa(IDEmpresa).Count();
            List<Beneficio> beneficios = DbPessoa.BeneficiosEmpresa(IDEmpresa);
            ViewBag.Beneficios = beneficios;
            ViewBag.qtdB = qtd;
            ViewBag.IDE = IDEmpresa;
=======
>>>>>>> c5854128676d49fadb3663b05a306f16c19367be

            ViewBag.Setores = Setores;
            ViewBag.Cargos = Cargos;

            List<PessoaBeneficio> BeneficiosFuncionarios = DbPessoa.BeneficiosFuncionariosEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
            ViewBag.BeneficiosFuncionarios = BeneficiosFuncionarios;

            ViewBag.IDFuncionarioBeneficio = 0;

            if(Pesquisa!="")
            {
                Funcionarios = Funcionarios.Where(p => p.Pes_Nome.Contains(Pesquisa)).ToList();
                ViewBag.Pesquisado = Pesquisa;
            }

            return View(Funcionarios);
        }
        
        public ActionResult SelecionarBeneficios(int id )
        {


            ViewBag.Resullt = "Beneficio Atribuido com Sucesso";

            return ViewBag.Result;
        }

        public ActionResult Demitir(int id,string Motivo)
        {
            Pessoa aPessoa = DbPessoa.SelecionarFuncionario(id);
            aPessoa.Pes_Situation = false;
            DbPessoa.AlterarFuncionario(aPessoa);
            Empresa aEmpresa = DbPessoa.SelecionarEmpresa(Convert.ToInt32(Session["IDEmpresa"]));

            Demissao aDemissao = new Demissao()
            {
                Dem_DataCadastro = aEmpresa.Emp_DataAtual,
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
            DbPessoa.DesabilitarDadosBancarios(id);
            DbPessoa.DesabilitarBeneficiosFuncionario(id);
            DbPessoa.DesabilitarDependentesFuncionario(id);

            return Json("O funcionário foi demitido com sucesso!");
        }

        public ActionResult PopularBeneficiosFuncionario(int id)
        {
            List<Beneficio> BeneficiosEmpresa = DbPessoa.BeneficiosEmpresa(Convert.ToInt32(Session["IDEmpresa"]));

            List<object> Beneficios = new List<object>();

            foreach (var x in BeneficiosEmpresa)
            {
                string status;
                if (DbPessoa.PossuiBeneficio(x.Ben_ID, id))
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
                        Status = status
                    }
                    );
            }

            return Json(Beneficios, JsonRequestBehavior.AllowGet);
        }

       

    }

}
