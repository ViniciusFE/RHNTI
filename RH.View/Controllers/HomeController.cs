using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Model;
using RH.Control;
using SelectPdf;
using RH.View.CriptoHelper;
using RH.View.Filtro;

namespace RH.View.Controllers
{
    [Autorizacao]
    public class HomeController : Controller
    {
        private CEmpresa _Control;

        public HomeController()
        {
            _Control = new CEmpresa();
        }

        public ActionResult Index(string id,string nomeEmpresa)
        {
            int IDDescriptografado = Convert.ToInt32(Criptografia.DecriptQueryString(id));
            Session["IDEmpresa"] = IDDescriptografado;
            Session["NomeEmpresa"] = Criptografia.DecriptQueryString(nomeEmpresa);

            Empresa aEmpresa = _Control.SelecionarEmpresa(IDDescriptografado);

            if (aEmpresa.Emp_Avaliativa)
            {
                Session["Avaliativa"] = true;
            }

            else
            {
                Session["Avaliativa"] = false;
            }

            Session["DataAtual"] = aEmpresa.Emp_DataAtual;
            return View();
        }

        public ActionResult Professor()
        {
            return View();
        }

        public ActionResult MudarDataEmpresa(string Data)
        {
            Empresa aEmpresa = _Control.SelecionarEmpresa(Convert.ToInt32(Session["IDEmpresa"]));

            string ComparaData = aEmpresa.Emp_DataAtual + "/2019";

            if(DateTime.Compare(Convert.ToDateTime(Data),Convert.ToDateTime(ComparaData))<0)
            {
                return Json("A data selecionada para alteração da data de sua empresa foi um dia que já passou!\nLembre-se que você só pode selecionar uma data futura.");
            }

            else if(DateTime.Compare(Convert.ToDateTime(Data), Convert.ToDateTime(ComparaData)) == 0)
            {
                return Json("Sua empresa já se encontra na data selecionada");
            }

            string Dia="";
            string Mes="";

            if(Convert.ToDateTime(Data).Day.ToString().Count()==1)
            {
                Dia = 0 + Convert.ToDateTime(Data).Day.ToString();
            }

            else
            {
                Dia= Convert.ToDateTime(Data).Day.ToString();
            }

            if (Convert.ToDateTime(Data).Month.ToString().Count()==1)
            {
                Mes = 0 + Convert.ToDateTime(Data).Month.ToString();
            }

            else
            {
                Mes = Convert.ToDateTime(Data).Month.ToString();
            }

            aEmpresa.Emp_DataAtual =  Dia+ "/" +Mes;
            _Control.AlterarEmpresa(aEmpresa);
            Session["DataAtual"] = aEmpresa.Emp_DataAtual;
            return Json("1");
        }

        public ActionResult GerarProva(int id)
        {
            Aluno oAluno = _Control.SelecionarAluno(id);
            Prova aProva = _Control.SelecionarProvaAluno(oAluno.Alu_ID);
            Curso oCurso = _Control.SelecionarCurso(oAluno.Alu_Curso_Cur_ID);

            //Identificação do Aluno
            ViewBag.CodigoProva = aProva.Pro_ID;
            ViewBag.DataTermino = aProva.Pro_DataTermino;
            ViewBag.NomeAluno = oAluno.Alu_Nome;
            ViewBag.Curso = oCurso.Cur_Nome + " - " + oAluno.Alu_Serie+"º ano";

            //Setores
            Setor oSetor = _Control.SelecionarSetor(aProva.Pro_Setor1);
            ViewBag.Setor1 = oSetor;
            Setor oSetorRespondente1 = _Control.SelecionarSetor(oSetor.Set_Setor_Set_ID);
            ViewBag.SetorRespondente1 = oSetorRespondente1.Set_Nome;

            oSetor = _Control.SelecionarSetor(aProva.Pro_Setor2);
            ViewBag.Setor2 = oSetor;
            Setor oSetorRespondente2 = _Control.SelecionarSetor(oSetor.Set_Setor_Set_ID);
            ViewBag.SetorRespondente2 = oSetorRespondente2.Set_Nome;

            oSetor = _Control.SelecionarSetor(aProva.Pro_Setor3);
            ViewBag.Setor3 = oSetor;
            Setor oSetorRespondente3 = _Control.SelecionarSetor(oSetor.Set_Setor_Set_ID);
            ViewBag.SetorRespondente3 = oSetorRespondente3.Set_Nome;

            oSetor = _Control.SelecionarSetor(aProva.Pro_Setor4);
            ViewBag.Setor4 = oSetor;
            Setor oSetorRespondente4 = _Control.SelecionarSetor(oSetor.Set_Setor_Set_ID);
            ViewBag.SetorRespondente4 = oSetorRespondente4.Set_Nome;

            oSetor = _Control.SelecionarSetor(aProva.Pro_Setor5);
            ViewBag.Setor5 = oSetor;
            Setor oSetorRespondente5 = _Control.SelecionarSetor(oSetor.Set_Setor_Set_ID);
            ViewBag.SetorRespondente5 = oSetorRespondente5.Set_Nome;

            //Cargos
            Cargo oCargo = _Control.SelecionarCargo(aProva.Pro_Cargo1);
            ViewBag.Cargo1 = oCargo;
            oSetorRespondente1 = _Control.SelecionarSetor(oCargo.Car_Setor_Set_ID);
            ViewBag.CargoSetor1 = oSetorRespondente1.Set_Nome;

            oCargo = _Control.SelecionarCargo(aProva.Pro_Cargo2);
            ViewBag.Cargo2 = oCargo;
            oSetorRespondente2 = _Control.SelecionarSetor(oCargo.Car_Setor_Set_ID);
            ViewBag.CargoSetor2 = oSetorRespondente2.Set_Nome;

            oCargo = _Control.SelecionarCargo(aProva.Pro_Cargo3);
            ViewBag.Cargo3 = oCargo;
            oSetorRespondente3 = _Control.SelecionarSetor(oCargo.Car_Setor_Set_ID);
            ViewBag.CargoSetor3 = oSetorRespondente3.Set_Nome;

            oCargo = _Control.SelecionarCargo(aProva.Pro_Cargo4);
            ViewBag.Cargo4 = oCargo;
            oSetorRespondente4 = _Control.SelecionarSetor(oCargo.Car_Setor_Set_ID);
            ViewBag.CargoSetor4 = oSetorRespondente4.Set_Nome;

            oCargo = _Control.SelecionarCargo(aProva.Pro_Cargo5);
            ViewBag.Cargo5 = oCargo;
            oSetorRespondente5 = _Control.SelecionarSetor(oCargo.Car_Setor_Set_ID);
            ViewBag.CargoSetor5 = oSetorRespondente5.Set_Nome;

            //Funcionários
            Pessoa oFuncionario = _Control.SelecionarFuncionario(aProva.Pro_Pessoa1);
            ViewBag.Funcionario1 = oFuncionario;
            oCargo = _Control.SelecionarCargo(oFuncionario.Pes_Cargo_Car_ID);
            ViewBag.CargoFuncionario1 = oCargo.Car_Nome;


            oFuncionario = _Control.SelecionarFuncionario(aProva.Pro_Pessoa2);
            ViewBag.Funcionario2 = oFuncionario;
            oCargo = _Control.SelecionarCargo(oFuncionario.Pes_Cargo_Car_ID);
            ViewBag.CargoFuncionario2 = oCargo.Car_Nome;

            oFuncionario = _Control.SelecionarFuncionario(aProva.Pro_Pessoa3);
            ViewBag.Funcionario3 = oFuncionario;
            oCargo = _Control.SelecionarCargo(oFuncionario.Pes_Cargo_Car_ID);
            ViewBag.CargoFuncionario3 = oCargo.Car_Nome;

            oFuncionario = _Control.SelecionarFuncionario(aProva.Pro_Pessoa4);
            ViewBag.Funcionario4 = oFuncionario;
            oCargo = _Control.SelecionarCargo(oFuncionario.Pes_Cargo_Car_ID);
            ViewBag.CargoFuncionario4 = oCargo.Car_Nome;

            oFuncionario = _Control.SelecionarFuncionario(aProva.Pro_Pessoa5);
            ViewBag.Funcionario5 = oFuncionario;
            oCargo = _Control.SelecionarCargo(oFuncionario.Pes_Cargo_Car_ID);
            ViewBag.CargoFuncionario5 = oCargo.Car_Nome;

            //Dependentes
            DadoDependente Dependente = _Control.SelecionarDependente(aProva.Pro_DadoDependente1);
            ViewBag.Dependente1 = Dependente;
            oFuncionario = _Control.SelecionarFuncionario(Dependente.DP_Pessoa_Pes_ID);
            ViewBag.FuncionarioDependente1 = oFuncionario.Pes_Nome;

            Dependente = _Control.SelecionarDependente(aProva.Pro_DadoDependente2);
            ViewBag.Dependente2 = Dependente;
            oFuncionario = _Control.SelecionarFuncionario(Dependente.DP_Pessoa_Pes_ID);
            ViewBag.FuncionarioDependente2 = oFuncionario.Pes_Nome;

            Dependente = _Control.SelecionarDependente(aProva.Pro_DadoDependente3);
            ViewBag.Dependente3 = Dependente;
            oFuncionario = _Control.SelecionarFuncionario(Dependente.DP_Pessoa_Pes_ID);
            ViewBag.FuncionarioDependente3 = oFuncionario.Pes_Nome;

            Dependente = _Control.SelecionarDependente(aProva.Pro_DadoDependete4);
            ViewBag.Dependente4 = Dependente;
            oFuncionario = _Control.SelecionarFuncionario(Dependente.DP_Pessoa_Pes_ID);
            ViewBag.FuncionarioDependente4 = oFuncionario.Pes_Nome;

            Dependente = _Control.SelecionarDependente(aProva.Pro_DadoDependete5);
            ViewBag.Dependente5 = Dependente;
            oFuncionario = _Control.SelecionarFuncionario(Dependente.DP_Pessoa_Pes_ID);
            ViewBag.FuncionarioDependente5 = oFuncionario.Pes_Nome;

            //Dados Bancários
            DadoBancario Dado = _Control.SelecionarDadoBancario(aProva.Pro_DadoBancario1);
            ViewBag.DadoBancario1 = Dado;
            oFuncionario = _Control.SelecionarFuncionario(Dado.DB_Pessoa_Pes_ID);
            ViewBag.DadoFuncionario1 = oFuncionario.Pes_Nome;

            Dado = _Control.SelecionarDadoBancario(aProva.Pro_DadoBancario2);
            ViewBag.DadoBancario2 = Dado;
            oFuncionario = _Control.SelecionarFuncionario(Dado.DB_Pessoa_Pes_ID);
            ViewBag.DadoFuncionario2 = oFuncionario.Pes_Nome;

            Dado = _Control.SelecionarDadoBancario(aProva.Pro_DadoBancario3);
            ViewBag.DadoBancario3 = Dado;
            oFuncionario = _Control.SelecionarFuncionario(Dado.DB_Pessoa_Pes_ID);
            ViewBag.DadoFuncionario3 = oFuncionario.Pes_Nome;

            Dado = _Control.SelecionarDadoBancario(aProva.Pro_DadoBancario4);
            ViewBag.DadoBancario4 = Dado;
            oFuncionario = _Control.SelecionarFuncionario(Dado.DB_Pessoa_Pes_ID);
            ViewBag.DadoFuncionario4 = oFuncionario.Pes_Nome;

            Dado = _Control.SelecionarDadoBancario(aProva.Pro_DadoBancario5);
            ViewBag.DadoBancario5 = Dado;
            oFuncionario = _Control.SelecionarFuncionario(Dado.DB_Pessoa_Pes_ID);
            ViewBag.DadoFuncionario5 = oFuncionario.Pes_Nome;

            //Benefícios
            Beneficio oBeneficio = _Control.SelecionarBeneficio(aProva.Pro_Beneficio1);
            ViewBag.Beneficio1 = oBeneficio;

            oBeneficio = _Control.SelecionarBeneficio(aProva.Pro_Beneficio2);
            ViewBag.Beneficio2 = oBeneficio;

            oBeneficio = _Control.SelecionarBeneficio(aProva.Pro_Beneficio3);
            ViewBag.Beneficio3 = oBeneficio;

            oBeneficio = _Control.SelecionarBeneficio(aProva.Pro_Beneficio4);
            ViewBag.Beneficio4 = oBeneficio;

            oBeneficio = _Control.SelecionarBeneficio(aProva.Pro_Beneficio5);
            ViewBag.Beneficio5 = oBeneficio;

            //Benefícios dos Funcionários
            PessoaBeneficio BeneficioFuncionario = _Control.SelecionarBeneficioFuncionario(aProva.Pro_BeneficioFuncionario1);
            oBeneficio = _Control.SelecionarBeneficio(BeneficioFuncionario.PB_Beneficio_Ben_ID);
            ViewBag.NomeBeneficio1 = oBeneficio.Ben_Nome;
            oFuncionario = _Control.SelecionarFuncionario(BeneficioFuncionario.PB_Pessoa_Pes_ID);
            ViewBag.NomeFuncionarioBenefio1 = oFuncionario.Pes_Nome;
            ViewBag.DataCadastro1 = BeneficioFuncionario.PB_DataCadastro;

            BeneficioFuncionario = _Control.SelecionarBeneficioFuncionario(aProva.Pro_BeneficioFuncionario2);
            oBeneficio = _Control.SelecionarBeneficio(BeneficioFuncionario.PB_Beneficio_Ben_ID);
            ViewBag.NomeBeneficio2 = oBeneficio.Ben_Nome;
            oFuncionario = _Control.SelecionarFuncionario(BeneficioFuncionario.PB_Pessoa_Pes_ID);
            ViewBag.NomeFuncionarioBenefio2 = oFuncionario.Pes_Nome;
            ViewBag.DataCadastro2 = BeneficioFuncionario.PB_DataCadastro;

            BeneficioFuncionario = _Control.SelecionarBeneficioFuncionario(aProva.Pro_BeneficioFuncionario3);
            oBeneficio = _Control.SelecionarBeneficio(BeneficioFuncionario.PB_Beneficio_Ben_ID);
            ViewBag.NomeBeneficio3 = oBeneficio.Ben_Nome;
            oFuncionario = _Control.SelecionarFuncionario(BeneficioFuncionario.PB_Pessoa_Pes_ID);
            ViewBag.NomeFuncionarioBenefio3 = oFuncionario.Pes_Nome;
            ViewBag.DataCadastro3 = BeneficioFuncionario.PB_DataCadastro;

            BeneficioFuncionario = _Control.SelecionarBeneficioFuncionario(aProva.Pro_BeneficioFuncionario4);
            oBeneficio = _Control.SelecionarBeneficio(BeneficioFuncionario.PB_Beneficio_Ben_ID);
            ViewBag.NomeBeneficio4 = oBeneficio.Ben_Nome;
            oFuncionario = _Control.SelecionarFuncionario(BeneficioFuncionario.PB_Pessoa_Pes_ID);
            ViewBag.NomeFuncionarioBenefio4 = oFuncionario.Pes_Nome;
            ViewBag.DataCadastro4 = BeneficioFuncionario.PB_DataCadastro;

            BeneficioFuncionario = _Control.SelecionarBeneficioFuncionario(aProva.Pro_BeneficioFuncionario5);
            oBeneficio = _Control.SelecionarBeneficio(BeneficioFuncionario.PB_Beneficio_Ben_ID);
            ViewBag.NomeBeneficio5 = oBeneficio.Ben_Nome;
            oFuncionario = _Control.SelecionarFuncionario(BeneficioFuncionario.PB_Pessoa_Pes_ID);
            ViewBag.NomeFuncionarioBenefio5 = oFuncionario.Pes_Nome;
            ViewBag.DataCadastro5 = BeneficioFuncionario.PB_DataCadastro;

            BeneficioFuncionario = _Control.SelecionarBeneficioFuncionario(aProva.Pro_BenefcioFuncionario6);
            oBeneficio = _Control.SelecionarBeneficio(BeneficioFuncionario.PB_Beneficio_Ben_ID);
            ViewBag.NomeBeneficio6 = oBeneficio.Ben_Nome;
            oFuncionario = _Control.SelecionarFuncionario(BeneficioFuncionario.PB_Pessoa_Pes_ID);
            ViewBag.NomeFuncionarioBenefio6 = oFuncionario.Pes_Nome;
            ViewBag.DataCadastro6 = BeneficioFuncionario.PB_DataCadastro;

            BeneficioFuncionario = _Control.SelecionarBeneficioFuncionario(aProva.Pro_BeneficioFuncionario7);
            oBeneficio = _Control.SelecionarBeneficio(BeneficioFuncionario.PB_Beneficio_Ben_ID);
            ViewBag.NomeBeneficio7 = oBeneficio.Ben_Nome;
            oFuncionario = _Control.SelecionarFuncionario(BeneficioFuncionario.PB_Pessoa_Pes_ID);
            ViewBag.NomeFuncionarioBenefio7 = oFuncionario.Pes_Nome;
            ViewBag.DataCadastro7 = BeneficioFuncionario.PB_DataCadastro;

            BeneficioFuncionario = _Control.SelecionarBeneficioFuncionario(aProva.Pro_BeneficioFuncionario8);
            oBeneficio = _Control.SelecionarBeneficio(BeneficioFuncionario.PB_Beneficio_Ben_ID);
            ViewBag.NomeBeneficio8 = oBeneficio.Ben_Nome;
            oFuncionario = _Control.SelecionarFuncionario(BeneficioFuncionario.PB_Pessoa_Pes_ID);
            ViewBag.NomeFuncionarioBenefio8 = oFuncionario.Pes_Nome;
            ViewBag.DataCadastro8 = BeneficioFuncionario.PB_DataCadastro;

            BeneficioFuncionario = _Control.SelecionarBeneficioFuncionario(aProva.Pro_BeneficioFuncionario9);
            oBeneficio = _Control.SelecionarBeneficio(BeneficioFuncionario.PB_Beneficio_Ben_ID);
            ViewBag.NomeBeneficio9 = oBeneficio.Ben_Nome;
            oFuncionario = _Control.SelecionarFuncionario(BeneficioFuncionario.PB_Pessoa_Pes_ID);
            ViewBag.NomeFuncionarioBenefio9 = oFuncionario.Pes_Nome;
            ViewBag.DataCadastro9 = BeneficioFuncionario.PB_DataCadastro;

            BeneficioFuncionario = _Control.SelecionarBeneficioFuncionario(aProva.Pro_BeneficioFuncionario10);
            oBeneficio = _Control.SelecionarBeneficio(BeneficioFuncionario.PB_Beneficio_Ben_ID);
            ViewBag.NomeBeneficio10 = oBeneficio.Ben_Nome;
            oFuncionario = _Control.SelecionarFuncionario(BeneficioFuncionario.PB_Pessoa_Pes_ID);
            ViewBag.NomeFuncionarioBenefio10 = oFuncionario.Pes_Nome;
            ViewBag.DataCadastro10 = BeneficioFuncionario.PB_DataCadastro;


            //Avaliações dos Funcionários
            Avaliacao AF = _Control.SelecionarAvaliacao(aProva.Pro_AvaliacaoFuncionario1);
            ViewBag.Avaliacao1 = AF;
            oFuncionario = _Control.SelecionarFuncionario(AF.Ava_Pessoa_Pes_ID);
            ViewBag.FuncionarioAvaliacao1 = oFuncionario.Pes_Nome;

            AF = _Control.SelecionarAvaliacao(aProva.Pro_AvaliacaoFuncionario2);
            ViewBag.Avaliacao2 = AF;
            oFuncionario = _Control.SelecionarFuncionario(AF.Ava_Pessoa_Pes_ID);
            ViewBag.FuncionarioAvaliacao2 = oFuncionario.Pes_Nome;

            AF = _Control.SelecionarAvaliacao(aProva.Pro_AvaliacaoFuncionario3);
            ViewBag.Avaliacao3 = AF;
            oFuncionario = _Control.SelecionarFuncionario(AF.Ava_Pessoa_Pes_ID);
            ViewBag.FuncionarioAvaliacao3 = oFuncionario.Pes_Nome;

            AF = _Control.SelecionarAvaliacao(aProva.Pro_AvaliacaoFuncionario4);
            ViewBag.Avaliacao4 = AF;
            oFuncionario = _Control.SelecionarFuncionario(AF.Ava_Pessoa_Pes_ID);
            ViewBag.FuncionarioAvaliacao4 = oFuncionario.Pes_Nome;

            //Demissões
            Demissao aDemissao = _Control.SelecionarDemissao(aProva.Pro_Demissao1);
            ViewBag.Demissao1 = aDemissao;
            oFuncionario = _Control.SelecionarFuncionario(aDemissao.Dem_Pessoa_Pes_ID);
            ViewBag.FuncionarioDemitido1 = oFuncionario.Pes_Nome;

            aDemissao = _Control.SelecionarDemissao(aProva.Pro_Demissao2);
            ViewBag.Demissao2 = aDemissao;
            oFuncionario = _Control.SelecionarFuncionario(aDemissao.Dem_Pessoa_Pes_ID);
            ViewBag.FuncionarioDemitido2 = oFuncionario.Pes_Nome;

            aDemissao = _Control.SelecionarDemissao(aProva.Pro_Demissao3);
            ViewBag.Demissao3 = aDemissao;
            oFuncionario = _Control.SelecionarFuncionario(aDemissao.Dem_Pessoa_Pes_ID);
            ViewBag.FuncionarioDemitido3 = oFuncionario.Pes_Nome;


            return View();
        }

        public ActionResult VisualizarProva()
        {
            Aluno oAluno = (Aluno)Session["User"];

            // instantiate a html to pdf converter object 
            HtmlToPdf converter = new HtmlToPdf();
            // create a new pdf document converting an url 
            PdfDocument doc = converter.ConvertUrl("http://localhost:52257/Home/GerarProva/"+oAluno.Alu_ID);

            // save pdf document 
            byte[] pdf = doc.Save();

            // close pdf document 
            doc.Close();

            // return resulted pdf document 
            FileResult fileResult = new FileContentResult(pdf, "application/pdf");
            fileResult.FileDownloadName = "PROVA - "+oAluno.Alu_Nome+".pdf";
            return fileResult;
        }

        public ActionResult NotFound()
        {
            return new HttpNotFoundResult();
        }

    }
}
