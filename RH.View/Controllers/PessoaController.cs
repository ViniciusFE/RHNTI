using PagedList;
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
        public ActionResult CadastrarFuncionario(Pessoa oFuncionario, HttpPostedFileBase Imagem,string Salario)
        {            
            Empresa aEmpresa = DbPessoa.SelecionarEmpresa(Convert.ToInt32(Session["IDEmpresa"]));
            oFuncionario.Pes_DataCadastro=aEmpresa.Emp_DataAtual;
            ViewBag.Pes_Cargo_Car_ID = new SelectList(DbPessoa.SelecionarCargosEmpresa(Convert.ToInt32(Session["IDEmpresa"])), "Car_ID", "Car_Nome", oFuncionario.Pes_Cargo_Car_ID);


            if (Convert.ToBoolean(Session["Avaliativa"]))
            {
                if (DbPessoa.LimiteFuncionariosEmpresaAvaliativa(Convert.ToInt32(Session["IDEmpresa"])))
                {
                    ModelState.AddModelError("Limite", "O limite de funcionários nessa Empresa Avaliativa foi atingido. (Limite de Funcionários = 5)");
                }
            }


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

            if(string.IsNullOrEmpty(Salario))
            {
                ModelState.AddModelError("Pes_Salario", "Digite o Salário do funcionário");
            }

            Cargo oCargo = DbPessoa.SelecionarCargo(oFuncionario.Pes_Cargo_Car_ID);
            if(oCargo.Car_Chefe)
            {
                if(DbPessoa.CargoOcupado(oCargo.Car_ID))
                {
                    ModelState.AddModelError("CargoChefe", "Este cargo selecionado é um cargo com uma posição de chefe do setor e já está ocupado por outro funcionário, o cargo de chefe do setor só pode existir um funcionário que o ocupe");
                }
            }

            if(ModelState.IsValid)
            {
                oFuncionario.Pes_Situation = true;
                oFuncionario.Pes_Salario = Convert.ToDouble(Salario);
                DbPessoa.CadastrarFuncionario(oFuncionario);
                return RedirectToAction("MeusFuncionarios");
            }

            return View();

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
        public ActionResult AlterarFuncionario(Pessoa oFuncionario, HttpPostedFileBase Imagem,string Salario="")
        {
            ViewBag.Pes_Cargo_Car_ID = new SelectList(DbPessoa.SelecionarCargosEmpresa(Convert.ToInt32(Session["IDEmpresa"])), "Car_ID", "Car_Nome", oFuncionario.Pes_Cargo_Car_ID);

            

            

            //Altera o funcionário e redireciona para tela de meus funcionários
            Pessoa aPessoa = DbPessoa.SelecionarFuncionario(oFuncionario.Pes_ID);

            if(aPessoa.Pes_Cargo_Car_ID!=oFuncionario.Pes_Cargo_Car_ID)
            {
                Cargo oCargo = DbPessoa.SelecionarCargo(oFuncionario.Pes_Cargo_Car_ID);
                if (oCargo.Car_Chefe)
                {
                    if (DbPessoa.CargoOcupado(oCargo.Car_ID))
                    {
                        ModelState.AddModelError("CargoChefe", "Este cargo selecionado é um cargo com uma posição de chefe do setor e já está ocupado por outro funcionário, o cargo de chefe do setor só pode existir um funcionário que o ocupe");
                    }
                }
            }

            //Retorna pra tela de alteração com todos os erros
            if (!ModelState.IsValid)
            {
                return View(oFuncionario);
            }

            if (Imagem != null)
            {
                byte[] NovaImagem = new byte[Imagem.ContentLength];
                Imagem.InputStream.Read(NovaImagem, 0, Imagem.ContentLength);
                aPessoa.Pes_Imagem = NovaImagem;
            }

            if(!string.IsNullOrEmpty(Salario))
            {
                aPessoa.Pes_Salario = Convert.ToDouble(Salario);
            }



            aPessoa.Pes_Nome = oFuncionario.Pes_Nome;
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
      
            
        public ActionResult MeusFuncionarios(int? pagina,string Pesquisa="")
        { 
            ViewBag.Pesquisado=null;

            int IDEmpresa = Convert.ToInt32(Session["IDEmpresa"]);
            List<Pessoa> Funcionarios = DbPessoa.SelecionarTodosFuncionariosEmpresa(IDEmpresa);
            List<Setor> Setores = DbPessoa.SelecionarTodosSetores(IDEmpresa);
            List<Cargo> Cargos = DbPessoa.SelecionarCargosEmpresa(IDEmpresa);
          
            List<Beneficio> beneficios = DbPessoa.BeneficiosEmpresa(IDEmpresa);
            ViewBag.Beneficios = beneficios;


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

            int paginaTamanho = 5;
            int paginaNumero = (pagina ?? 1);

            return View(Funcionarios.ToPagedList(paginaNumero, paginaTamanho));
        }
        
        public ActionResult SelecionarBeneficios(int id )
        {


            ViewBag.Resullt = "Beneficio Atribuido com Sucesso";

            return ViewBag.Result;
        }

        public ActionResult Demitir(int id,string Motivo)
        {
            if (Convert.ToBoolean(Session["Avaliativa"]))
            {
                if (DbPessoa.LimiteDemissoesEmpresaAvaliativa(Convert.ToInt32(Session["IDEmpresa"])))
                {
                    return Json("1");
                }
            }

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
            DbPessoa.DesabilitarAvaliacoes(id);

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
                        Status = status,
                        Descricao=x.Ben_Descricao,
                        Custo=x.Ben_Custo
                    }
                    );
            }

            return Json(Beneficios, JsonRequestBehavior.AllowGet);
        }

       public ActionResult AdicionarBeneficio(int beneficio,int funcionario)
        {
            if (Convert.ToBoolean(Session["Avaliativa"]))
            {
                if (DbPessoa.LimiteBeneficiosFuncionariosEmpresaAvaliativa(Convert.ToInt32(Session["IDEmpresa"])))
                {
                    return Json("1");
                }
            }

            Empresa aEmpresa = DbPessoa.SelecionarEmpresa(Convert.ToInt32(Session["IDEmpresa"]));

            PessoaBeneficio Beneficio = new PessoaBeneficio()
            {
                PB_Beneficio_Ben_ID=beneficio,
                PB_DataCadastro=aEmpresa.Emp_DataAtual,
                PB_Pessoa_Pes_ID=funcionario,
                PB_Situation=true
            };

            DbPessoa.CadastrarBeneficioFuncionario(Beneficio);
            return new EmptyResult();
        }

        public ActionResult RemoverBeneficio(int beneficio,int funcionario)
        {
            PessoaBeneficio Beneficio = DbPessoa.SelecionarBeneficioFuncionario(beneficio, funcionario);

            DbPessoa.ExcluirBeneficioFuncionario(Beneficio);

            return new EmptyResult();
        }

    }

}
