using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RH.Model;
using RH.Control;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using RH.View.Filtro;

namespace RH.View.Controllers
{
    
    public class ProvaController : Controller
    {
        CProva _Control;

        public ProvaController()
        {
            _Control = new CProva();
        }

        public string SelecionarNome()
        {
            string[] Nomes = new string[100] { "Abílio Carneiro",
            "Adalberto Fernández",
            "Adelaide Junqueira",
            "Adelaide Vilanova",
            "Adelina Angelim",
            "Aida Cortês",
            "Américo Mariz",
            "Amílcar Belén",
            "Angelino Cayubi",
            "Anna Taperebá",
            "António Muniz",
            "Aníbal Leal",
            "Berengária Brandão",
            "Bernardina Godoi",
            "Boaventura Castella",
            "Brenda Conceição",
            "Bukake Canhão",
            "Bukake Maranhão",
            "Burtira Pinheiro",
            "Caetano Ferreyra",
            "Carolina Borges",
            "Casimiro Rangel",
            "Caubi Covilhã",
            "Cauã Suaçuna",
            "Cândida Barreto",
            "Davide Valentín",
            "Deise Baranda",
            "Delfina Bacelar",
            "Délia Durão",
            "Ema Uchoa",
            "Emiliana Teves",
            "Estefânia Carreiro",
            "Eugénia Sanches",
            "Evangelista Maciel",
            "Evaristo Dourado",
            "Filipa Giménez",
            "Flávio Vilarim",
            "Frederico Mirandela",
            "Fábia Torcato",
            "Godofredo Athayde",
            "Graça Guará",
            "Gregório Xavier",
            "Guido Freitas",
            "Guilhermina Carromeu",
            "Guiomar Guimaraens",
            "Gávio Lagos",
            "Helena Barroqueiro",
            "Herberto Diniz",
            "Hermígio Beltrão",
            "Hernâni Moreira",
            "Ifigénia Vides",
            "Jacira Silveira dos Açores",
            "Jandira Beltrão",
            "Jerónimo, Jerônimo Junquera",
            "Jerónimo, Jerônimo Sant'Anna",
            "Joaquim Bencatel",
            "Joaquim Gentil",
            "Jónatas Sousa de Arronches",
            "Júlio Salazar",
            "Luciano Montero",
            "Lucinda Siebra",
            "Luísa Lage",
            "Lília Carrasqueira",
            "Mafalda Perdigón",
            "Mafalda Tabosa",
            "Mamede Maciel",
            "Mbicy Maciel",
            "Morgana Candeias",
            "Natividade Rivas",
            "Odilia Jorge",
            "Palmira Cardozo",
            "Pandora Díaz",
            "Quirino Briones",
            "Raquel Goes",
            "Raquel Ríos",
            "Romano Lamego",
            "Roque Jucá",
            "Rui Villaverde",
            "Rúben Roriz",
            "Salomão Marroquim",
            "Salvina Fialho",
            "Sebastião Gutiérrez",
            "Severino Tupinambá",
            "Sofia Marinho",
            "Solano Inês",
            "Suniário Liberato",
            "Tadeu Padilha",
            "Taíssa Viegas",
            "Ubirajara Camilo",
            "Ubiratã Ribas",
            "Udo Varella",
            "Vanessa Piratininga",
            "Viriato Cachão",
            "Vitória Ornellas",
            "Vânia Talhão",
            "Xênia Parracho",
            "Zeferino Açores",
            "Zélia Domínguez",
            "Átila Ávila",
            "Énia Viveros"
            };

            int posicao;

            Random random = new Random();
            posicao = random.Next(0, 99);

            return Nomes[posicao];
        }

        public string SelecionarEndereco()
        {
            string[] Enderecos = new string[80]
            {
                    "Vila Verde",
                    "Novo Surubi",
                    "Surubi",
                    "Jardim Esperança",
                    "Morada da Barra",
                    "Jardim do Sol",
                    "Parque Embaixador",
                    "Fazenda da Barra 1",
                    "Fazenda da Barra 2",
                    "Fazenda da Barra 3",
                    "Nossa Senhora de Fátima",
                    "Campo Belo",
                    "Maria Cândida",
                    "Isaac Politi",
                    "Morro do Batista",
                    "Morro do Machado",
                    "Vila Moderna",
                    "Jardim Brasília 1",
                    "Jardim Brasília 2",
                    "Parque Ipiranga 1",
                    "Parque Ipiranga 2",
                    "Morada das Garças",
                    "Vicentina",
                    "Santo Amaro",
                    "Eucaliptal",
                    "Terras Alpha",
                    "Vila Julieta",
                    "Santa Cecília",
                    "Jardim Jalisco",
                    "Liberdade",
                    "Nova Liberdade",
                    "Manejo",
                    "Vila Santa Isabel",
                    "Elite",
                    "Morada da Felicidade",
                    "Baixada da Olaria",
                    "Itapuca",
                    "Residencial Limeira",
                    "Morada da Colina 1",
                    "Morada da Colina 2",
                    "Morada da Colina 3",
                    "Mirante das Agulhas",
                    "Residencial Morada das Agulhas",
                    "Morada do Bosque",
                    "Casa da Lua",
                    "Loteamento Cícero",
                    "Alegria 1",
                    "Alegria 2",
                    "Nova Alegria",
                    "Jardim Alegria",
                    "Cidade Alegria",
                    "Nova Resende",
                    "Boa Vista 1",
                    "Boa Vista 2",
                    "Mirante da Serra",
                    "Morada da Montanha",
                    "Morada do Contorno",
                    "Jardim Beira Rio",
                    "Vila Isabel",
                    "Primavera 1",
                    "Primavera 2",
                    "Primavera 3",
                    "Jardim Aliança",
                    "Jardim do Oeste",
                    "Morada do Castelo",
                    "Montese",
                    "Bairro Comercial",
                    "Monte Castelo",
                    "Guararapes",
                    "Independência",
                    "Cabral",
                    "Alambari",
                    "Paraíso",
                    "Castelo Branco",
                    "Morro do Cruzeiro",
                    "Vila Araújo",
                    "Comercial",
                    "Jardim Tropical",
                    "São Caetano",
                    "Monet"
            };

            int posicao;

            Random random = new Random();
            posicao = random.Next(0, 79);

            return Enderecos[posicao];
        }

        [AutorizacaoProfessor]
        // GET: Prova
        public ActionResult Index()
        {
            List<Aluno> Alunos = _Control.SelecionarTodosAlunos();
            ViewBag.QuantidadeAlunos = Alunos.Count();

            List<VW_Provas> Provas = _Control.SelecionarTodasProva();
            return View(Provas);
        }

        [AutorizacaoProfessor]
        public ActionResult CadastrarProva(string DataTermino)
        {
            bool ProvaAtiva = _Control.ProvaAtiva();
            if(ProvaAtiva)
            {
                return Json("3");
            }

            DateTime Data = Convert.ToDateTime(DataTermino);

            if (DateTime.Compare(DateTime.Now.Date, Data) == 0)
            {
                return Json("0");
            }

            else if (DateTime.Compare(Data, DateTime.Now.Date) < 0)
            {
                return Json("1");
            }

            byte[] data;
            
            var caminho = Server.MapPath("~/Imagem/sem-imagem-avatar.png");
            Bitmap bmp = new Bitmap(caminho);

            MemoryStream memory = new MemoryStream();
            bmp.Save(memory, ImageFormat.Bmp);

            data = memory.ToArray();

            List<Aluno> Alunos = _Control.SelecionarTodosAlunos();


            int CodigoProva = _Control.QuantidadeProvas()+1;

            foreach(var x in Alunos)
            {

                Prova aProva = new Prova();
                Professor oProfessor = (Professor)Session["User"];
                aProva.Pro_Professor_Pro_ID = oProfessor.Pro_ID;
                aProva.Pro_Aluno_Alu_ID = x.Alu_ID;
                aProva.Pro_DataInicio = DateTime.Now;
                aProva.Pro_DataTermino = Convert.ToDateTime(DataTermino);

                int IDAlunoProva = 0;
                Aluno oAluno = _Control.AlunoProva();
                if(oAluno==null)
                {
                    Aluno AlunoProva = new Aluno();
                    AlunoProva.Alu_Curso_Cur_ID = 1;
                    AlunoProva.Alu_DataCadastro = DateTime.Now;
                    AlunoProva.Alu_Email = "ALUNO PROVA";
                    AlunoProva.Alu_Matricula = 1;
                    AlunoProva.Alu_Nome = "ALUNO PROVA";
                    AlunoProva.Alu_Senha = "ALUNO PROVA";
                    AlunoProva.Alu_Serie = 1;
                    AlunoProva.Alu_Situation = false;
                    _Control.CadastrarAluno(AlunoProva);
                    IDAlunoProva = AlunoProva.Alu_ID;
                }

                else
                {
                    IDAlunoProva = oAluno.Alu_ID;
                }

                Empresa aEmpresa = _Control.EmpresaAlunoProva();
                int IDEmpresaProva;

                if(aEmpresa==null)
                {
                    Empresa EmpresaAlunoProva = new Empresa();
                    EmpresaAlunoProva.Emp_Nome = "EMPRESA";
                    EmpresaAlunoProva.Emp_Aluno_Alu_ID = IDAlunoProva;
                    EmpresaAlunoProva.Emp_Avaliativa = true;
                    EmpresaAlunoProva.Emp_Cidade = "EMPRESA";
                    EmpresaAlunoProva.Emp_CNPJ = "EMPRESA";
                    EmpresaAlunoProva.Emp_DataAtual = "01/01";
                    EmpresaAlunoProva.Emp_DataCadastro = DateTime.Now;
                    EmpresaAlunoProva.Emp_Endereco = "EMPRESA";
                    EmpresaAlunoProva.Emp_Estado = "EMPRESA";
                    EmpresaAlunoProva.Emp_Logo = data;
                    EmpresaAlunoProva.Emp_RegistroEstadual = "EMPRESA";
                    EmpresaAlunoProva.Emp_Situation = false;
                    _Control.CadastrarEmpresa(EmpresaAlunoProva);
                    IDEmpresaProva = EmpresaAlunoProva.Emp_ID;
                }

                else
                {
                    IDEmpresaProva = aEmpresa.Emp_ID;
                }
                               

                Setor oSetor = new Setor();

                //Cadastra Setores da Prova

                //Setor 1
                oSetor.Set_Nome = "Administrativo";
                oSetor.Set_Empresa_Emp_ID = IDEmpresaProva;
                oSetor.Set_Setor_Set_ID = oSetor.Set_ID;
                oSetor.Set_DataCadastro = "01/01";
                oSetor.Set_Situation = true;
                _Control.CadastrarSetor(oSetor);
                int IDSetorAdiministrativo = oSetor.Set_ID;
                aProva.Pro_Setor1 = oSetor.Set_ID;
                oSetor.Set_Setor_Set_ID = oSetor.Set_ID;
                _Control.AlterarSetor(oSetor);


                //Setor 2
                oSetor.Set_Nome = "Tesouraria";
                oSetor.Set_Empresa_Emp_ID = IDEmpresaProva;
                oSetor.Set_Setor_Set_ID = IDSetorAdiministrativo;
                oSetor.Set_DataCadastro = "10/03";
                oSetor.Set_Situation = true;
                _Control.CadastrarSetor(oSetor);
                aProva.Pro_Setor2 = oSetor.Set_ID;
                int IDSetorTesouararia = oSetor.Set_ID;

                //Setor 3
                oSetor.Set_Nome = "Tecnologia da Informação";
                oSetor.Set_Empresa_Emp_ID = IDEmpresaProva;
                oSetor.Set_Setor_Set_ID = IDSetorAdiministrativo;
                oSetor.Set_DataCadastro = "25/06";
                oSetor.Set_Situation = true;
                _Control.CadastrarSetor(oSetor);
                aProva.Pro_Setor3 = oSetor.Set_ID;
                int IDSetorTI = oSetor.Set_ID;

                //Setor 4
                oSetor.Set_Nome = "Produção";
                oSetor.Set_Empresa_Emp_ID = IDEmpresaProva;
                oSetor.Set_Setor_Set_ID = IDSetorAdiministrativo;
                oSetor.Set_DataCadastro = "30/08";
                oSetor.Set_Situation = true;
                _Control.CadastrarSetor(oSetor);
                aProva.Pro_Setor4 = oSetor.Set_ID;
                int IDSetorProducao = oSetor.Set_ID;

                //Setor 5
                oSetor.Set_Nome = "Marketing";
                oSetor.Set_Empresa_Emp_ID = IDEmpresaProva;
                oSetor.Set_Setor_Set_ID = IDSetorAdiministrativo;
                oSetor.Set_DataCadastro = "07/09";
                oSetor.Set_Situation = true;
                _Control.CadastrarSetor(oSetor);
                aProva.Pro_Setor5 = oSetor.Set_ID;
                int IDSetorMarketing = oSetor.Set_ID;

                //Cadastrar Cargos

                //Cargo 1
                Cargo oCargo = new Cargo();
                oCargo.Car_Chefe = true;
                oCargo.Car_DataCadastro = "01/01";
                oCargo.Car_Nome = "C.E.O";
                oCargo.Car_Setor_Set_ID = IDSetorAdiministrativo;
                oCargo.Car_Situation = true;
                _Control.CadastrarCargo(oCargo);
                aProva.Pro_Cargo1 = oCargo.Car_ID;
                int IDCargoCEO = oCargo.Car_ID;

                //Cargo 2
                oCargo.Car_Chefe = false;
                oCargo.Car_DataCadastro = "10/03";
                oCargo.Car_Nome = "Tesoureiro";
                oCargo.Car_Setor_Set_ID = IDSetorTesouararia;
                oCargo.Car_Situation = true;
                _Control.CadastrarCargo(oCargo);
                aProva.Pro_Cargo2 = oCargo.Car_ID;
                int IDCargoTesoureiro = oCargo.Car_ID;

                //Cargo 3
                oCargo.Car_Chefe = false;
                oCargo.Car_DataCadastro = "25/06";
                oCargo.Car_Nome = "Programador";
                oCargo.Car_Setor_Set_ID = IDSetorTI;
                oCargo.Car_Situation = true;
                _Control.CadastrarCargo(oCargo);
                aProva.Pro_Cargo3 = oCargo.Car_ID;
                int IDCargoProgramador = oCargo.Car_ID;

                //Cargo 4
                oCargo.Car_Chefe = true;
                oCargo.Car_DataCadastro = "30/08";
                oCargo.Car_Nome = "Gerente de Produção";
                oCargo.Car_Setor_Set_ID = IDSetorProducao;
                oCargo.Car_Situation = true;
                _Control.CadastrarCargo(oCargo);
                aProva.Pro_Cargo4 = oCargo.Car_ID;
                int IDCargoGerenteProducao = oCargo.Car_ID;

                //Cargo 5
                oCargo.Car_Chefe = false;
                oCargo.Car_DataCadastro = "07/09";
                oCargo.Car_Nome = "Profissional de Marketing";
                oCargo.Car_Setor_Set_ID = IDSetorMarketing;
                oCargo.Car_Situation = true;
                _Control.CadastrarCargo(oCargo);
                aProva.Pro_Cargo5 = oCargo.Car_ID;
                int IDCargoProfissionalMarketing = oCargo.Car_ID;


                //Cadastrar Vagas Empresa
                Vaga aVaga = new Vaga();

                //Vaga 1
                aVaga.Vag_Cargo_Car_ID = IDCargoTesoureiro;
                aVaga.Vag_DataCadastro = "10/03";
                aVaga.Vag_Descricao = "O profissional será responsável por planejar, organizar, dirigir e controlar os serviços da tesouraria se relaciona com toda área financeira, contábil e administrativa.";
                aVaga.Vag_Situation = true;
                aVaga.Vag_Titulo = "Vaga de Tesoureiro";
                aVaga.Vag_Preenchida = false;
                _Control.CadastrarVaga(aVaga);
                aProva.Pro_Vaga1 = aVaga.Vag_ID;
                int IDVagaTesoureiro = aVaga.Vag_ID;

                //Vaga 2
                aVaga.Vag_Cargo_Car_ID = IDCargoProfissionalMarketing;
                aVaga.Vag_DataCadastro = "07/09";
                aVaga.Vag_Descricao = "Auxiliar no desenvolvimento e implementação de ações de Marketing, incluindo pesquisas de mercado, campanhas publicitárias e promocionais, visando projetar a imagem da empresa e elevar as vendas.";
                aVaga.Vag_Situation = true;
                aVaga.Vag_Titulo = "Vaga de Profissional de Marketing";
                aVaga.Vag_Preenchida = false;
                _Control.CadastrarVaga(aVaga);
                aProva.Pro_Vaga1 = aVaga.Vag_ID;
                int IDVagaProfissionalMarketing = aVaga.Vag_ID;

                //Vaga 3
                aVaga.Vag_Cargo_Car_ID = IDCargoProgramador;
                aVaga.Vag_DataCadastro = "25/06";
                aVaga.Vag_Descricao = "Será responsável pela implementação e/ou correção dos erros e defeitos no sistema.";
                aVaga.Vag_Situation = true;
                aVaga.Vag_Titulo = "Vaga de Programador";
                aVaga.Vag_Preenchida = false;
                _Control.CadastrarVaga(aVaga);
                aProva.Pro_Vaga1 = aVaga.Vag_ID;
                int IDVagaProgramador = aVaga.Vag_ID;

                //Vaga 4
                aVaga.Vag_Cargo_Car_ID = IDCargoGerenteProducao;
                aVaga.Vag_DataCadastro = "30/08";
                aVaga.Vag_Descricao = "Será responsável por assegurar o cumprimento das metas de produção, dentro dos padrões de qualidade, quantidade, custos e prazo estabelecidos pela empresa.";
                aVaga.Vag_Situation = true;
                aVaga.Vag_Titulo = "Vaga de Gerente de Produção";
                aVaga.Vag_Preenchida = false;
                _Control.CadastrarVaga(aVaga);
                aProva.Pro_Vaga1 = aVaga.Vag_ID;
                int IDVagaGerente = aVaga.Vag_ID;

                //Vaga 5
                aVaga.Vag_Cargo_Car_ID = IDCargoCEO;
                aVaga.Vag_DataCadastro = "01/01";
                aVaga.Vag_Descricao = "Será É o responsável pelas estratégias e pela visão da empresa. Não são todas as empresas que possuem uma pessoa no cargo de CEO.";
                aVaga.Vag_Situation = true;
                aVaga.Vag_Titulo = "Vaga de C.E.O";
                aVaga.Vag_Preenchida = false;
                _Control.CadastrarVaga(aVaga);
                aProva.Pro_Vaga1 = aVaga.Vag_ID;
                int IDVagaCEO = aVaga.Vag_ID;

                Pessoa aPessoa = new Pessoa();

                //Cadastra funcionário do cargo de tesoureiro//
                aPessoa.Pes_Vaga_Vag_ID = IDVagaTesoureiro;
                aPessoa.Pes_Nome = SelecionarNome();
                aPessoa.Pes_Endereco = SelecionarEndereco();
                aPessoa.Pes_DataCadastro = "10/03";
                aPessoa.Pes_CPF = "126.373.510-04";
                aPessoa.Pes_CTrabalho = "120.23362.99-9";
                aPessoa.Pes_Salario = 2626.04;
                aPessoa.Pes_Situation = true;
                aPessoa.Pes_Imagem = data;
                aPessoa.Pes_Cidade = "Resende";
                _Control.CadastrarFuncionario(aPessoa);
                int IDTesoureiro = aPessoa.Pes_ID;
                aProva.Pro_Pessoa1 = IDTesoureiro;

                //Cadastra funcionário do cargo de programador//
                aPessoa.Pes_Vaga_Vag_ID = IDVagaProgramador;
                aPessoa.Pes_Nome = SelecionarNome();
                aPessoa.Pes_Endereco = SelecionarEndereco();
                aPessoa.Pes_DataCadastro = "25/06";
                aPessoa.Pes_CPF = "869.628.180-25";
                aPessoa.Pes_CTrabalho = "133.76185.77-7";
                aPessoa.Pes_Salario = 1500.00;
                aPessoa.Pes_Situation = true;
                aPessoa.Pes_Imagem = data;
                aPessoa.Pes_Cidade = "Volta Redonda";
                _Control.CadastrarFuncionario(aPessoa);
                int IDProgramador = aPessoa.Pes_ID;
                aProva.Pro_Pessoa2 = IDProgramador;

                //Cadastra funcionário do cargo de CEO
                aPessoa.Pes_Vaga_Vag_ID = IDVagaCEO;
                aPessoa.Pes_Nome = SelecionarNome();
                aPessoa.Pes_Endereco = SelecionarEndereco();
                aPessoa.Pes_DataCadastro = "01/01";
                aPessoa.Pes_CPF = "455.003.530-71";
                aPessoa.Pes_CTrabalho = "718.37915.49-9";
                aPessoa.Pes_Salario = 20000.00;
                aPessoa.Pes_Situation = true;
                aPessoa.Pes_Imagem = data;
                aPessoa.Pes_Cidade = "Rio de Janeiro";
                _Control.CadastrarFuncionario(aPessoa);
                int IDCEO = aPessoa.Pes_ID;
                aProva.Pro_Pessoa3 = IDCEO;

                //Cadastra funcionário do cargo Gerente de Produção
                aPessoa.Pes_Vaga_Vag_ID = IDVagaGerente;
                aPessoa.Pes_Nome = SelecionarNome();
                aPessoa.Pes_Endereco = SelecionarEndereco();
                aPessoa.Pes_DataCadastro = "30/08";
                aPessoa.Pes_CPF = "835.013.410-08";
                aPessoa.Pes_CTrabalho = "789.82791.72-2";
                aPessoa.Pes_Salario = 2000.00;
                aPessoa.Pes_Situation = true;
                aPessoa.Pes_Imagem = data;
                aPessoa.Pes_Cidade = "Porto Real";
                _Control.CadastrarFuncionario(aPessoa);
                int IDGerenteDeProducao = aPessoa.Pes_ID;
                aProva.Pro_Pessoa4 = IDGerenteDeProducao;

                //Cadastra funcionário do cargo Profissional de Marketing
                aPessoa.Pes_Vaga_Vag_ID = IDVagaProfissionalMarketing;
                aPessoa.Pes_Nome = SelecionarNome();
                aPessoa.Pes_Endereco = SelecionarEndereco();
                aPessoa.Pes_DataCadastro = "07/09";
                aPessoa.Pes_CPF = "578.589.100-00";
                aPessoa.Pes_CTrabalho = "456.13745.46-6";
                aPessoa.Pes_Salario = 1000.00;
                aPessoa.Pes_Situation = true;
                aPessoa.Pes_Imagem = data;
                aPessoa.Pes_Cidade = "Resende";
                _Control.CadastrarFuncionario(aPessoa);
                int IDProfissionalMarketing = aPessoa.Pes_ID;
                aProva.Pro_Pessoa5 = IDProfissionalMarketing;


                DadoDependente Dependente = new DadoDependente();

                //Cadastra Dependente do Funcionário Gerente de Produção
                Dependente.DP_Nome = SelecionarNome();
                Dependente.DP_Parentesco = "Filho/a";
                Dependente.DP_Pessoa_Pes_ID = IDGerenteDeProducao;
                Dependente.DP_Situation = true;
                Dependente.DP_Nome = SelecionarNome();
                Dependente.DP_DataCadastro = "30/08";
                _Control.CadastrarDependente(Dependente);
                aProva.Pro_DadoDependente1 = Dependente.DP_ID;

                //Cadastra Dependente do Funcionário Programador
                Dependente.DP_Nome = SelecionarNome();
                Dependente.DP_Parentesco = "Pai";
                Dependente.DP_Pessoa_Pes_ID = IDProgramador;
                Dependente.DP_Situation = true;
                Dependente.DP_Nome = "Gaspar da Silva Eugênio";
                Dependente.DP_DataCadastro = "25/06";
                _Control.CadastrarDependente(Dependente);
                aProva.Pro_DadoDependente2 = Dependente.DP_ID;

                //Cadastra Dependente do Funcionário Profissional de Marketing
                Dependente.DP_Nome = SelecionarNome();
                Dependente.DP_Parentesco = "Filho/a";
                Dependente.DP_Pessoa_Pes_ID = IDProfissionalMarketing;
                Dependente.DP_Situation = true;
                Dependente.DP_Nome = SelecionarNome();
                Dependente.DP_DataCadastro = "07/09";
                _Control.CadastrarDependente(Dependente);
                aProva.Pro_DadoDependente3 = Dependente.DP_ID;

                //Cadastrar Dependente do Funcionário Tesoureiro
                Dependente.DP_Nome = SelecionarNome();
                Dependente.DP_Parentesco = "Filho/a";
                Dependente.DP_Pessoa_Pes_ID = IDTesoureiro;
                Dependente.DP_Situation = true;
                Dependente.DP_Nome = SelecionarNome();
                Dependente.DP_DataCadastro = "10/03";
                _Control.CadastrarDependente(Dependente);
                aProva.Pro_DadoDependete4 = Dependente.DP_ID;

                //Cadastra Dependente CEO
                Dependente.DP_Nome = SelecionarNome();
                Dependente.DP_Parentesco = "Mãe";
                Dependente.DP_Pessoa_Pes_ID = IDCEO;
                Dependente.DP_Situation = true;
                Dependente.DP_Nome = "Cristhina Fonseca";
                Dependente.DP_DataCadastro = "01/01";
                _Control.CadastrarDependente(Dependente);
                aProva.Pro_DadoDependete5 = Dependente.DP_ID;

                DadoBancario oDado = new DadoBancario();

                //Cadastrar Dado Bancário Programador
                oDado.DB_Numero = "4012001037141112";
                oDado.DB_Pessoa_Pes_ID = IDProgramador;
                oDado.DB_Situation = true;
                oDado.DB_Tipo = "Cartão de Crédito";
                oDado.DB_DataCadastro = "25/06";
                _Control.CadastrarDadoBancario(oDado);
                aProva.Pro_DadoBancario1 = oDado.DB_ID;


                //Cadastrar Dado Bancário Profissional de Marketing
                oDado.DB_Numero = "36490102462661";
                oDado.DB_Pessoa_Pes_ID = IDProfissionalMarketing;
                oDado.DB_Situation = true;
                oDado.DB_Tipo = "Cartão de Crédito";
                oDado.DB_DataCadastro = "07/09";
                _Control.CadastrarDadoBancario(oDado);
                aProva.Pro_DadoBancario2 = oDado.DB_ID;

                //Cadastrar Dado Bancario CEO
                oDado.DB_Numero = "5555666677778884";
                oDado.DB_Pessoa_Pes_ID = IDCEO;
                oDado.DB_Situation = true;
                oDado.DB_Tipo = "Cartão de Crédito";
                oDado.DB_DataCadastro = "01/01";
                _Control.CadastrarDadoBancario(oDado);
                aProva.Pro_DadoBancario3 = oDado.DB_ID;

                //Cadastrar Dado Bancario Gerente de Produção
                oDado.DB_Numero = "	6362970000457013";
                oDado.DB_Pessoa_Pes_ID = IDGerenteDeProducao;
                oDado.DB_Situation = true;
                oDado.DB_Tipo = "Cartão de Crédito";
                oDado.DB_DataCadastro = "30/08";
                _Control.CadastrarDadoBancario(oDado);
                aProva.Pro_DadoBancario4 = oDado.DB_ID;

                //Cadastrar Dado Bancario Tesoureiro
                oDado.DB_Numero = "5506186782166925";
                oDado.DB_Pessoa_Pes_ID = IDTesoureiro;
                oDado.DB_Situation = true;
                oDado.DB_Tipo = "Cartão de Crédito";
                oDado.DB_DataCadastro = "10/03";
                _Control.CadastrarDadoBancario(oDado);
                aProva.Pro_DadoBancario5 = oDado.DB_ID;

                //Cadastrar Benefícos

                //Benefício 1
                Beneficio oBeneficio = new Beneficio();
                oBeneficio.Ben_Custo=300.00;
                oBeneficio.Ben_DataCadastro = "01/01";
                oBeneficio.Ben_Descricao = "É um benefício que impede que qualquer trabalhador gaste mais do que 6% do seu salário com despesas de transporte de sua casa até o trabalho e do trabalho até sua casa. O valor da despesa que superar os 6% deve ser custeado pela empresa";
                oBeneficio.Ben_Empresa_Emp_ID = IDEmpresaProva;
                oBeneficio.Ben_Nome = "Vale Transporte";
                oBeneficio.Ben_Situation = true;
                _Control.CadastrarBeneficio(oBeneficio);
                int IDValeTransporte = oBeneficio.Ben_ID;
                aProva.Pro_Beneficio1 = oBeneficio.Ben_ID;

                //Benefício 2
                oBeneficio = new Beneficio();
                oBeneficio.Ben_Custo = 250.00;
                oBeneficio.Ben_DataCadastro = "01/01";
                oBeneficio.Ben_Descricao = "Para organizações com mais de 300 colaboradores é previsto que haja um ambiente para que os funcionários possam realizar suas refeições ,a instituição pode disponibilizar a refeição ou o profissional para trazer de casa.";
                oBeneficio.Ben_Empresa_Emp_ID = IDEmpresaProva;
                oBeneficio.Ben_Nome = "Vale Alimentação";
                oBeneficio.Ben_Situation = true;
                _Control.CadastrarBeneficio(oBeneficio);
                int IDValeAlimentacao = oBeneficio.Ben_ID;
                aProva.Pro_Beneficio2 = oBeneficio.Ben_ID;

                //Benefício 3
                oBeneficio = new Beneficio();
                oBeneficio.Ben_Custo = 500.00;
                oBeneficio.Ben_DataCadastro = "01/01";
                oBeneficio.Ben_Descricao = "Quando a empresa oferece plano de saúde, o custo pode ser deduzido na folha de pagamento do funcionário. Entretanto, o colaborador pagaria abaixo do que se ele contratasse um plano particular, visto que a companhia paga boa parte do custo. Além do mais, planos corporativos habituam ser mais acessíveis do que individuais.";
                oBeneficio.Ben_Empresa_Emp_ID = IDEmpresaProva;
                oBeneficio.Ben_Nome = "Assistência Médica";
                oBeneficio.Ben_Situation = true;
                _Control.CadastrarBeneficio(oBeneficio);
                int IDAssistenciaMedica = oBeneficio.Ben_ID;
                aProva.Pro_Beneficio3 = oBeneficio.Ben_ID;

                //Benefício 4
                oBeneficio = new Beneficio();
                oBeneficio.Ben_Custo = 150.00;
                oBeneficio.Ben_DataCadastro = "01/01";
                oBeneficio.Ben_Descricao = "O Vale-cultura, na prática, é um pagamento adicional ao trabalhador, em forma de benefício, entregue em um cartão magnético. Todo mês, este saldo é acrescentado no cartão para que o funcionário possa aplicar em livros, eventos, ingressos, filmes etc.";
                oBeneficio.Ben_Empresa_Emp_ID = IDEmpresaProva;
                oBeneficio.Ben_Nome = "Vale Alimentação";
                oBeneficio.Ben_Situation = true;
                _Control.CadastrarBeneficio(oBeneficio);
                int IDValeCultura = oBeneficio.Ben_ID;
                aProva.Pro_Beneficio4 = oBeneficio.Ben_ID;

                //Benefício 5
                oBeneficio = new Beneficio();
                oBeneficio.Ben_Custo = 350.00;
                oBeneficio.Ben_DataCadastro = "01/01";
                oBeneficio.Ben_Descricao = "Oferece ao funcionário a possibilidade de realizar tratamentos dentários e funciona de forma semelhante à assistência médica.";
                oBeneficio.Ben_Empresa_Emp_ID = IDEmpresaProva;
                oBeneficio.Ben_Nome = "Plano Odontológico";
                oBeneficio.Ben_Situation = true;
                _Control.CadastrarBeneficio(oBeneficio);
                int IDPlanoOdontologico = oBeneficio.Ben_ID;
                aProva.Pro_Beneficio5 = oBeneficio.Ben_ID;


                //Cadastrar Benefícios dos Funcionários
                PessoaBeneficio BeneficioFuncionario = new PessoaBeneficio();

                //Cadastra Beneficios do Funcionario Programador
                BeneficioFuncionario.PB_Beneficio_Ben_ID = IDValeTransporte;
                BeneficioFuncionario.PB_Pessoa_Pes_ID = IDProgramador;
                BeneficioFuncionario.PB_DataCadastro = "25/06";
                BeneficioFuncionario.PB_Situation = true;
                _Control.CadastrarBeneficioFuncionario(BeneficioFuncionario);
                aProva.Pro_BeneficioFuncionario1 = BeneficioFuncionario.PB_ID;

                BeneficioFuncionario.PB_Beneficio_Ben_ID = IDValeAlimentacao;
                BeneficioFuncionario.PB_Pessoa_Pes_ID = IDProgramador;
                BeneficioFuncionario.PB_DataCadastro = "25/06";
                BeneficioFuncionario.PB_Situation = true;
                _Control.CadastrarBeneficioFuncionario(BeneficioFuncionario);
                aProva.Pro_BeneficioFuncionario2 = BeneficioFuncionario.PB_ID;

                //Cadastra Benefícios do CEO
                BeneficioFuncionario.PB_Beneficio_Ben_ID = IDValeCultura;
                BeneficioFuncionario.PB_Pessoa_Pes_ID = IDCEO;
                BeneficioFuncionario.PB_DataCadastro = "01/01";
                BeneficioFuncionario.PB_Situation = true;
                _Control.CadastrarBeneficioFuncionario(BeneficioFuncionario);
                aProva.Pro_BeneficioFuncionario3 = BeneficioFuncionario.PB_ID;

                BeneficioFuncionario.PB_Beneficio_Ben_ID =  IDPlanoOdontologico;
                BeneficioFuncionario.PB_Pessoa_Pes_ID = IDCEO;
                BeneficioFuncionario.PB_DataCadastro = "01/01";
                BeneficioFuncionario.PB_Situation = true;
                _Control.CadastrarBeneficioFuncionario(BeneficioFuncionario);
                aProva.Pro_BeneficioFuncionario4 = BeneficioFuncionario.PB_ID;

                //Cadastrar Benefícios Profissional de Marketing
                BeneficioFuncionario.PB_Beneficio_Ben_ID = IDAssistenciaMedica;
                BeneficioFuncionario.PB_Pessoa_Pes_ID = IDProfissionalMarketing;
                BeneficioFuncionario.PB_DataCadastro = "07/09";
                BeneficioFuncionario.PB_Situation = true;
                _Control.CadastrarBeneficioFuncionario(BeneficioFuncionario);
                aProva.Pro_BeneficioFuncionario5 = BeneficioFuncionario.PB_ID;

                BeneficioFuncionario.PB_Beneficio_Ben_ID = IDValeCultura;
                BeneficioFuncionario.PB_Pessoa_Pes_ID = IDProfissionalMarketing;
                BeneficioFuncionario.PB_DataCadastro = "07/09";
                BeneficioFuncionario.PB_Situation = true;
                _Control.CadastrarBeneficioFuncionario(BeneficioFuncionario);
                aProva.Pro_BenefcioFuncionario6 = BeneficioFuncionario.PB_ID;

                //Cadastrar Beneficios do Tesoureiro
                BeneficioFuncionario.PB_Beneficio_Ben_ID = IDValeAlimentacao;
                BeneficioFuncionario.PB_Pessoa_Pes_ID = IDTesoureiro;
                BeneficioFuncionario.PB_DataCadastro = "10/03";
                BeneficioFuncionario.PB_Situation = true;
                _Control.CadastrarBeneficioFuncionario(BeneficioFuncionario);
                aProva.Pro_BeneficioFuncionario7 = BeneficioFuncionario.PB_ID;

                BeneficioFuncionario.PB_Beneficio_Ben_ID = IDPlanoOdontologico;
                BeneficioFuncionario.PB_Pessoa_Pes_ID = IDTesoureiro;
                BeneficioFuncionario.PB_DataCadastro = "10/03";
                BeneficioFuncionario.PB_Situation = true;
                _Control.CadastrarBeneficioFuncionario(BeneficioFuncionario);
                aProva.Pro_BeneficioFuncionario8 = BeneficioFuncionario.PB_ID;

                //Cadastrar Benefícios do Gerente de Produção
                BeneficioFuncionario.PB_Beneficio_Ben_ID = IDAssistenciaMedica;
                BeneficioFuncionario.PB_Pessoa_Pes_ID = IDGerenteDeProducao;
                BeneficioFuncionario.PB_DataCadastro = "30/08";
                BeneficioFuncionario.PB_Situation = true;
                _Control.CadastrarBeneficioFuncionario(BeneficioFuncionario);
                aProva.Pro_BeneficioFuncionario9 = BeneficioFuncionario.PB_ID;

                BeneficioFuncionario.PB_Beneficio_Ben_ID = IDValeTransporte;
                BeneficioFuncionario.PB_Pessoa_Pes_ID = IDGerenteDeProducao;
                BeneficioFuncionario.PB_DataCadastro = "30/08";
                BeneficioFuncionario.PB_Situation = true;
                _Control.CadastrarBeneficioFuncionario(BeneficioFuncionario);
                aProva.Pro_BeneficioFuncionario10 = BeneficioFuncionario.PB_ID;

                //Cadastrar Avaliações dos Funcionários

                //Avaliação do Gerente de Produção
                Avaliacao aAvaliacao = new Avaliacao();
                aAvaliacao.Ava_Pessoa_Pes_ID = IDGerenteDeProducao;
                aAvaliacao.Ava_DataCadastro = "03/11";
                aAvaliacao.Ava_Situation = true;
                aAvaliacao.Ava_Avaliacao = "Ótimo funcionário, alcançou níveis ótimos de desempenho e performance além de melhorar a produção em 10% através de sua liderança e espirito de equipe.";
                _Control.CadastrarAvaliacao(aAvaliacao);
                aProva.Pro_AvaliacaoFuncionario1 = aAvaliacao.Ava_ID;

                //Avaliação do Tesoureiro
                aAvaliacao.Ava_Pessoa_Pes_ID = IDTesoureiro;
                aAvaliacao.Ava_DataCadastro = "23/06";
                aAvaliacao.Ava_Situation = true;
                aAvaliacao.Ava_Avaliacao = "É hábil e criativo para encontrar soluções para obstáculos e reconhece as necessidades dos outros e auxilia a encontrar uma solução.";
                _Control.CadastrarAvaliacao(aAvaliacao);
                aProva.Pro_AvaliacaoFuncionario2 = aAvaliacao.Ava_ID;

                //Avaliação do Profissional de Marketing
                aAvaliacao.Ava_Pessoa_Pes_ID = IDProfissionalMarketing;
                aAvaliacao.Ava_DataCadastro = "08/12";
                aAvaliacao.Ava_Situation = true;
                aAvaliacao.Ava_Avaliacao = "Busca alternativas criativas para as atividades onde está trabalhando com os quais trouxeram ótimos resultados, constrói bons relacionamentos através de suas ações.";
                _Control.CadastrarAvaliacao(aAvaliacao);
                aProva.Pro_AvaliacaoFuncionario3 = aAvaliacao.Ava_ID;

                //Avaliação do Programador
                aAvaliacao.Ava_Pessoa_Pes_ID = IDProgramador;
                aAvaliacao.Ava_DataCadastro = "10/09";
                aAvaliacao.Ava_Situation = true;
                aAvaliacao.Ava_Avaliacao = "Está sempre chegando atrasado no trabalho, além não trabalhar bem em equipe.";
                _Control.CadastrarAvaliacao(aAvaliacao);
                aProva.Pro_AvaliacaoFuncionario4 = aAvaliacao.Ava_ID;

                //Cadastrar Demissões

                //Demissao do Profissional de Marketing
                Demissao aDemissao = new Demissao();
                aDemissao.Dem_Pessoa_Pes_ID = IDProfissionalMarketing;
                aDemissao.Dem_Motivo = "Pediu demissão";
                aPessoa = _Control.SelecionarFuncionario(IDProfissionalMarketing);
                aDemissao.Dem_Salario = aPessoa.Pes_Salario;
                aDemissao.Dem_DataCadastro = "31/12";
                aDemissao.Dem_Situation = true;
                _Control.CadastrarDemissao(aDemissao);
                aProva.Pro_Demissao1 = aDemissao.Dem_ID;

                aDemissao.Dem_Pessoa_Pes_ID = IDTesoureiro;
                aDemissao.Dem_Motivo = "Pediu demissão";
                aPessoa = _Control.SelecionarFuncionario(IDTesoureiro);
                aDemissao.Dem_Salario = aPessoa.Pes_Salario;
                aDemissao.Dem_DataCadastro = "30/12";
                aDemissao.Dem_Situation = true;
                _Control.CadastrarDemissao(aDemissao);
                aProva.Pro_Demissao2 = aDemissao.Dem_ID;

                aDemissao.Dem_Pessoa_Pes_ID = IDProgramador;
                aDemissao.Dem_Motivo = "Foi demitido";
                aPessoa = _Control.SelecionarFuncionario(IDProgramador);
                aDemissao.Dem_Salario = aPessoa.Pes_Salario;
                aDemissao.Dem_DataCadastro = "12/12";
                aDemissao.Dem_Situation = true;
                _Control.CadastrarDemissao(aDemissao);
                aProva.Pro_Demissao3 = aDemissao.Dem_ID;

                aProva.Pro_Codigo = CodigoProva;
                aProva.Pro_Entregue = false;
                aProva.Pro_Situation = true;
                _Control.CadastrarProva(aProva);
            }

            return Json("2");
        }

        [Autorizacao]
        public ActionResult EntregarProva()
        {
            Aluno oAluno = (Aluno)Session["User"];
           
            
            CalcularNota(oAluno.Alu_ID);

            Prova aProva = _Control.SelecionarProvaAluno(oAluno.Alu_ID);
            aProva.Pro_Entregue = true;
            aProva.Pro_Situation = false;
            _Control.AlterarProva(aProva);

            Empresa aEmpresa = _Control.SelecionarEmpresaAvaliativaAluno(oAluno.Alu_ID);
            aEmpresa.Emp_Situation = false;
            _Control.AlterarEmpresa(aEmpresa);  


            return Json("Sua nota foi calculada com sucesso, após o vencimento do dia da prova que será no dia "+aProva.Pro_DataTermino+", a próxima vez que você logar na plataforma você terá acesso a sua nota e poderá visualizar seus erros.");
        }

        [Autorizacao]
        public void CalcularNota(int IDAluno)
        {
            List<Aluno> Alunos = _Control.SelecionarTodosAlunos();

            Prova aProva = _Control.SelecionarProvaAluno(IDAluno);
            Empresa aEmpresa = _Control.SelecionarEmpresaAvaliativaAluno(IDAluno);

            double Nota = 0;

            Nota aNota = new Nota();
            aNota.Not_DataCadastro = DateTime.Now;
            aNota.Not_Prova_Pro_ID = aProva.Pro_ID;

            //Verifica os Setores

            //Setor 1
            Setor SetorProva = _Control.SelecionarSetor(aProva.Pro_Setor1);
            Setor SetorAluno = _Control.SelecionarSetorDiaCadastro(SetorProva.Set_DataCadastro, aEmpresa.Emp_ID);

            if (SetorAluno != null)
            {
                Setor oSetor = _Control.SelecionarSetor(SetorProva.Set_Setor_Set_ID);
                string SetorRespondenteProva = oSetor.Set_Nome;
                oSetor = _Control.SelecionarSetor(SetorAluno.Set_Setor_Set_ID);
                string SetorRespondenteAluno = oSetor.Set_Nome;

                SetorAluno.Set_Nome = SetorAluno.Set_Nome.Replace("\t", "");
                SetorAluno.Set_Nome = SetorProva.Set_Nome.Replace("\n", "");
                SetorAluno.Set_Nome = SetorProva.Set_Nome.Replace("\r", "");

                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\t", "");
                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\n", "");
                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\r", "");

                SetorRespondenteAluno.Replace("\t", "");
                SetorRespondenteAluno.Replace("\n", "");
                SetorRespondenteAluno.Replace("\r", "");

                SetorRespondenteProva.Replace("\t", "");
                SetorRespondenteProva.Replace("\n", "");
                SetorRespondenteProva.Replace("\r", "");

                if (SetorAluno.Set_Nome.Replace(" ","") == SetorProva.Set_Nome.Replace(" ","") && SetorRespondenteAluno.Replace(" ","")==SetorRespondenteProva.Replace(" ",""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {                    
                    if(SetorAluno.Set_Setor_Set_ID==SetorAluno.Set_ID)
                    {
                        SetorRespondenteAluno = "Este setor responde a si mesmo";
                    }

                    else
                    {
                        oSetor = _Control.SelecionarSetor(SetorAluno.Set_Setor_Set_ID);
                        SetorRespondenteAluno = oSetor.Set_Nome;
                    }

                    if(SetorProva.Set_Setor_Set_ID==SetorProva.Set_ID)
                    {
                        SetorRespondenteProva = "Este setor responde a si mesmo";
                    }

                    else
                    {
                        oSetor = _Control.SelecionarSetor(SetorProva.Set_Setor_Set_ID);
                        SetorRespondenteProva = oSetor.Set_Nome;
                    }

                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Setor:</br>Nome do Setor: "+SetorAluno.Set_Nome+"</br>Data de Cadastro: "+SetorAluno.Set_DataCadastro+"</br>Setor Respondente: "+SetorRespondenteAluno;
                    oErro.Err_RespostaCerta= "Setor:</br>Nome do Setor: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + SetorProva.Set_DataCadastro + "</br>Setor Respondente: " + SetorRespondenteProva;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                string SetorRespondenteProva;
                if (SetorProva.Set_Setor_Set_ID == SetorProva.Set_ID)
                {
                    SetorRespondenteProva = "Este setor responde a si mesmo";
                }

                else
                {
                    Setor oSetor = _Control.SelecionarSetor(SetorProva.Set_Setor_Set_ID);
                    SetorRespondenteProva = oSetor.Set_Nome;
                }

                Erro oErro = new Erro();
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";  
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Err_RespostaAluno = "Não foi encontrado um setor cadastrado no dia " + SetorProva.Set_DataCadastro;
                oErro.Err_RespostaCerta = oErro.Err_RespostaCerta = "Setor:</br>Nome do Setor: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + SetorProva.Set_DataCadastro + "</br>Setor Respondente: " + SetorRespondenteProva;
                _Control.CadastrarErro(oErro);
            }

            //Setor 2
            SetorProva = _Control.SelecionarSetor(aProva.Pro_Setor2);
            SetorAluno = _Control.SelecionarSetorDiaCadastro(SetorProva.Set_DataCadastro, aEmpresa.Emp_ID);
            if (SetorAluno != null)
            {
                Setor oSetor = _Control.SelecionarSetor(SetorProva.Set_Setor_Set_ID);
                string SetorRespondenteProva = oSetor.Set_Nome;
                oSetor = _Control.SelecionarSetor(SetorAluno.Set_Setor_Set_ID);
                string SetorRespondenteAluno = oSetor.Set_Nome;

                SetorAluno.Set_Nome = SetorAluno.Set_Nome.Replace("\t", "");
                SetorAluno.Set_Nome = SetorProva.Set_Nome.Replace("\n", "");
                SetorAluno.Set_Nome = SetorProva.Set_Nome.Replace("\r", "");

                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\t", "");
                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\n", "");
                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\r", "");

                SetorRespondenteAluno.Replace("\t", "");
                SetorRespondenteAluno.Replace("\n", "");
                SetorRespondenteAluno.Replace("\r", "");

                SetorRespondenteProva.Replace("\t", "");
                SetorRespondenteProva.Replace("\n", "");
                SetorRespondenteProva.Replace("\r", "");

                if (SetorAluno.Set_Nome.Replace(" ", "") == SetorProva.Set_Nome.Replace(" ", "") && SetorRespondenteAluno.Replace(" ", "") == SetorRespondenteProva.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    if (SetorAluno.Set_Setor_Set_ID == SetorAluno.Set_ID)
                    {
                        SetorRespondenteAluno = "Este setor responde a si mesmo";
                    }

                    else
                    {
                        oSetor = _Control.SelecionarSetor(SetorAluno.Set_Setor_Set_ID);
                        SetorRespondenteAluno = oSetor.Set_Nome;
                    }

                    if (SetorProva.Set_Setor_Set_ID == SetorProva.Set_ID)
                    {
                        SetorRespondenteProva = "Este setor responde a si mesmo";
                    }

                    else
                    {
                        oSetor = _Control.SelecionarSetor(SetorProva.Set_Setor_Set_ID);
                        SetorRespondenteProva = oSetor.Set_Nome;
                    }

                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Setor:</br>Nome do Setor: " + SetorAluno.Set_Nome + "</br>Data de Cadastro: " + SetorAluno.Set_DataCadastro + "</br>Setor Respondente: " + SetorRespondenteAluno;
                    oErro.Err_RespostaCerta = "Setor:</br>Nome do Setor: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + SetorProva.Set_DataCadastro + "</br>Setor Respondente: " + SetorRespondenteProva;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                string SetorRespondenteProva;
                if (SetorProva.Set_Setor_Set_ID == SetorProva.Set_ID)
                {
                    SetorRespondenteProva = "Este setor responde a si mesmo";
                }

                else
                {
                    Setor oSetor = _Control.SelecionarSetor(SetorProva.Set_Setor_Set_ID);
                    SetorRespondenteProva = oSetor.Set_Nome;
                }

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado um setor cadastrado no dia " + SetorProva.Set_DataCadastro;
                oErro.Err_RespostaCerta = oErro.Err_RespostaCerta = "Setor:</br>Nome do Setor: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + SetorProva.Set_DataCadastro + "</br>Setor Respondente: " + SetorRespondenteProva;
                _Control.CadastrarErro(oErro);
            }

            //Setor 3
            SetorProva = _Control.SelecionarSetor(aProva.Pro_Setor3);
            SetorAluno = _Control.SelecionarSetorDiaCadastro(SetorProva.Set_DataCadastro, aEmpresa.Emp_ID);
            if (SetorAluno != null)
            {
                Setor oSetor = _Control.SelecionarSetor(SetorProva.Set_Setor_Set_ID);
                string SetorRespondenteProva = oSetor.Set_Nome;
                oSetor = _Control.SelecionarSetor(SetorAluno.Set_Setor_Set_ID);
                string SetorRespondenteAluno = oSetor.Set_Nome;

                SetorAluno.Set_Nome = SetorAluno.Set_Nome.Replace("\t", "");
                SetorAluno.Set_Nome = SetorProva.Set_Nome.Replace("\n", "");
                SetorAluno.Set_Nome = SetorProva.Set_Nome.Replace("\r", "");

                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\t", "");
                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\n", "");
                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\r", "");

                SetorRespondenteAluno.Replace("\t", "");
                SetorRespondenteAluno.Replace("\n", "");
                SetorRespondenteAluno.Replace("\r", "");

                SetorRespondenteProva.Replace("\t", "");
                SetorRespondenteProva.Replace("\n", "");
                SetorRespondenteProva.Replace("\r", "");

                if (SetorAluno.Set_Nome.Replace(" ", "") == SetorProva.Set_Nome.Replace(" ", "") && SetorRespondenteAluno.Replace(" ", "") == SetorRespondenteProva.Replace(" ", ""))
                {                    
                    Nota = Nota + 0.2;
                }

                else
                {
                    if (SetorAluno.Set_Setor_Set_ID == SetorAluno.Set_ID)
                    {
                        SetorRespondenteAluno = "Este setor responde a si mesmo";
                    }

                    else
                    {
                        oSetor = _Control.SelecionarSetor(SetorAluno.Set_Setor_Set_ID);
                        SetorRespondenteAluno = oSetor.Set_Nome;
                    }

                    if (SetorProva.Set_Setor_Set_ID == SetorProva.Set_ID)
                    {
                        SetorRespondenteProva = "Este setor responde a si mesmo";
                    }

                    else
                    {
                        oSetor = _Control.SelecionarSetor(SetorProva.Set_Setor_Set_ID);
                        SetorRespondenteProva = oSetor.Set_Nome;
                    }

                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Setor:</br>Nome do Setor: " + SetorAluno.Set_Nome + "</br>Data de Cadastro: " + SetorAluno.Set_DataCadastro + "</br>Setor Respondente: " + SetorRespondenteAluno;
                    oErro.Err_RespostaCerta = "Setor:</br>Nome do Setor: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + SetorProva.Set_DataCadastro + "</br>Setor Respondente: " + SetorRespondenteProva;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                string SetorRespondenteProva;
                if (SetorProva.Set_Setor_Set_ID == SetorProva.Set_ID)
                {
                    SetorRespondenteProva = "Este setor responde a si mesmo";
                }

                else
                {
                    Setor oSetor = _Control.SelecionarSetor(SetorProva.Set_Setor_Set_ID);
                    SetorRespondenteProva = oSetor.Set_Nome;
                }

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado um setor cadastrado no dia " + SetorProva.Set_DataCadastro;
                oErro.Err_RespostaCerta = oErro.Err_RespostaCerta = "Setor:</br>Nome do Setor: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + SetorProva.Set_DataCadastro + "</br>Setor Respondente: " + SetorRespondenteProva;
                _Control.CadastrarErro(oErro);
            }

            //Setor 4
            SetorProva = _Control.SelecionarSetor(aProva.Pro_Setor4);
            SetorAluno = _Control.SelecionarSetorDiaCadastro(SetorProva.Set_DataCadastro, aEmpresa.Emp_ID);
            if (SetorAluno != null)
            {
                Setor oSetor = _Control.SelecionarSetor(SetorProva.Set_Setor_Set_ID);
                string SetorRespondenteProva = oSetor.Set_Nome;
                oSetor = _Control.SelecionarSetor(SetorAluno.Set_Setor_Set_ID);
                string SetorRespondenteAluno = oSetor.Set_Nome;

                SetorAluno.Set_Nome = SetorAluno.Set_Nome.Replace("\t", "");
                SetorAluno.Set_Nome = SetorProva.Set_Nome.Replace("\n", "");
                SetorAluno.Set_Nome = SetorProva.Set_Nome.Replace("\r", "");

                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\t", "");
                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\n", "");
                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\r", "");

                SetorRespondenteAluno.Replace("\t", "");
                SetorRespondenteAluno.Replace("\n", "");
                SetorRespondenteAluno.Replace("\r", "");

                SetorRespondenteProva.Replace("\t", "");
                SetorRespondenteProva.Replace("\n", "");
                SetorRespondenteProva.Replace("\r", "");

                if (SetorAluno.Set_Nome.Replace(" ", "") == SetorProva.Set_Nome.Replace(" ", "") && SetorRespondenteAluno.Replace(" ", "") == SetorRespondenteProva.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    if (SetorAluno.Set_Setor_Set_ID == SetorAluno.Set_ID)
                    {
                        SetorRespondenteAluno = "Este setor responde a si mesmo";
                    }

                    else
                    {
                        oSetor = _Control.SelecionarSetor(SetorAluno.Set_Setor_Set_ID);
                        SetorRespondenteAluno = oSetor.Set_Nome;
                    }

                    if (SetorProva.Set_Setor_Set_ID == SetorProva.Set_ID)
                    {
                        SetorRespondenteProva = "Este setor responde a si mesmo";
                    }

                    else
                    {
                        oSetor = _Control.SelecionarSetor(SetorProva.Set_Setor_Set_ID);
                        SetorRespondenteAluno = oSetor.Set_Nome;
                    }

                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Setor:</br>Nome do Setor: " + SetorAluno.Set_Nome + "</br>Data de Cadastro: " + SetorAluno.Set_DataCadastro + "</br>Setor Respondente: " + SetorRespondenteAluno;
                    oErro.Err_RespostaCerta = "Setor:</br>Nome do Setor: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + SetorProva.Set_DataCadastro + "</br>Setor Respondente: " + SetorRespondenteProva;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                string SetorRespondenteProva;
                if (SetorProva.Set_Setor_Set_ID == SetorProva.Set_ID)
                {
                    SetorRespondenteProva = "Este setor responde a si mesmo";
                }

                else
                {
                    Setor oSetor = _Control.SelecionarSetor(SetorProva.Set_Setor_Set_ID);
                    SetorRespondenteProva = oSetor.Set_Nome;
                }

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado um setor cadastrado no dia " + SetorProva.Set_DataCadastro;
                oErro.Err_RespostaCerta = oErro.Err_RespostaCerta = "Setor:</br>Nome do Setor: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + SetorProva.Set_DataCadastro + "</br>Setor Respondente: " + SetorRespondenteProva;
                _Control.CadastrarErro(oErro);
            }

            //Setor 5
            SetorProva = _Control.SelecionarSetor(aProva.Pro_Setor5);
            SetorAluno = _Control.SelecionarSetorDiaCadastro(SetorProva.Set_DataCadastro, aEmpresa.Emp_ID);
            if (SetorAluno != null)
            {
                Setor oSetor = _Control.SelecionarSetor(SetorProva.Set_Setor_Set_ID);
                string SetorRespondenteProva = oSetor.Set_Nome;
                oSetor = _Control.SelecionarSetor(SetorAluno.Set_Setor_Set_ID);
                string SetorRespondenteAluno = oSetor.Set_Nome;

                SetorAluno.Set_Nome = SetorAluno.Set_Nome.Replace("\t", "");
                SetorAluno.Set_Nome = SetorProva.Set_Nome.Replace("\n", "");
                SetorAluno.Set_Nome = SetorProva.Set_Nome.Replace("\r", "");

                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\t", "");
                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\n", "");
                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\r", "");

                SetorRespondenteAluno.Replace("\t", "");
                SetorRespondenteAluno.Replace("\n", "");
                SetorRespondenteAluno.Replace("\r", "");

                SetorRespondenteProva.Replace("\t", "");
                SetorRespondenteProva.Replace("\n", "");
                SetorRespondenteProva.Replace("\r", "");

                if (SetorAluno.Set_Nome.Replace(" ", "") == SetorProva.Set_Nome.Replace(" ", "") && SetorRespondenteAluno.Replace(" ", "") == SetorRespondenteProva.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    if (SetorAluno.Set_Setor_Set_ID == SetorAluno.Set_ID)
                    {
                        SetorRespondenteAluno = "Este setor responde a si mesmo";
                    }

                    else
                    {
                        oSetor = _Control.SelecionarSetor(SetorAluno.Set_Setor_Set_ID);
                        SetorRespondenteAluno = oSetor.Set_Nome;
                    }

                    if (SetorProva.Set_Setor_Set_ID == SetorProva.Set_ID)
                    {
                        SetorRespondenteProva = "Este setor responde a si mesmo";
                    }

                    else
                    {
                        oSetor = _Control.SelecionarSetor(SetorProva.Set_Setor_Set_ID);
                        SetorRespondenteAluno = oSetor.Set_Nome;
                    }

                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Setor:</br>Nome do Setor: " + SetorAluno.Set_Nome + "</br>Data de Cadastro: " + SetorAluno.Set_DataCadastro + "</br>Setor Respondente: " + SetorRespondenteAluno;
                    oErro.Err_RespostaCerta = "Setor:</br>Nome do Setor: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + SetorProva.Set_DataCadastro + "</br>Setor Respondente: " + SetorRespondenteProva;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                string SetorRespondenteProva;
                if (SetorProva.Set_Setor_Set_ID == SetorProva.Set_ID)
                {
                    SetorRespondenteProva = "Este setor responde a si mesmo";
                }

                else
                {
                    Setor oSetor = _Control.SelecionarSetor(SetorProva.Set_Setor_Set_ID);
                    SetorRespondenteProva = oSetor.Set_Nome;
                }

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado um setor cadastrado no dia " + SetorProva.Set_DataCadastro;
                oErro.Err_RespostaCerta = oErro.Err_RespostaCerta = "Setor:</br>Nome do Setor: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + SetorProva.Set_DataCadastro + "</br>Setor Respondente: " + SetorRespondenteProva;
                _Control.CadastrarErro(oErro);
            }


            //Verifica Cargos

            //Cargo 1
            Cargo CargoProva = _Control.SelecionarCargo(aProva.Pro_Cargo1);
            Cargo CargoAluno = _Control.SelecionarCargoDiaCadastro(CargoProva.Car_DataCadastro, aEmpresa.Emp_ID);


            if (CargoAluno != null)
            {
                SetorProva = _Control.SelecionarSetor(CargoProva.Car_Setor_Set_ID);
                SetorAluno = _Control.SelecionarSetor(CargoAluno.Car_Setor_Set_ID);

                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\t", "");
                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\n", "");
                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\r", "");

                CargoProva.Car_Nome = CargoAluno.Car_Nome.Replace("\t", "");
                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\n", "");
                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\r", "");

                SetorAluno.Set_Nome = SetorAluno.Set_Nome.Replace("\t", "");
                SetorAluno.Set_Nome = SetorAluno.Set_Nome.Replace("\n", "");
                SetorAluno.Set_Nome = SetorAluno.Set_Nome.Replace("\r", "");

                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\t", "");
                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\n", "");
                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\r", "");

                if (CargoAluno.Car_Nome.Replace(" ","") == CargoProva.Car_Nome.Replace(" ","") && CargoAluno.Car_Chefe == CargoProva.Car_Chefe && SetorProva.Set_Nome.Replace(" ", "") == SetorAluno.Set_Nome.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    string ChefeAluno;

                    if(CargoAluno.Car_Chefe)
                    {
                        ChefeAluno = "Chefe do Setor";
                    }

                    else
                    {
                        ChefeAluno = "Este cargo não é chefe do Setor";
                    }

                    string ChefeProva;

                    if (CargoProva.Car_Chefe)
                    {
                        ChefeProva = "Chefe do Setor";
                    }

                    else
                    {
                        ChefeProva = "Este cargo não é chefe do Setor";
                    }

                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Cargo:</br>Nome do Cargo: " + CargoAluno.Car_Nome + "</br>Setor do Cargo: " + SetorAluno.Set_Nome + "</br>Data de Cadastro: " + CargoAluno.Car_DataCadastro + "</br>Chefe do Setor: " + ChefeAluno;
                    oErro.Err_RespostaCerta = "Cargo:</br>Nome do Cargo: " + CargoProva.Car_Nome + "</br>Setor do Cargo: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro + "</br>Chefe do Setor: " + ChefeProva;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                string ChefeProva;

                if (CargoProva.Car_Chefe)
                {
                    ChefeProva = "Chefe do Setor";
                }

                else
                {
                    ChefeProva = "Este cargo não é chefe do Setor";
                }

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum cargo cadastrado no dia " + CargoProva.Car_DataCadastro;
                oErro.Err_RespostaCerta = "Cargo:</br>Nome do Cargo: " + CargoProva.Car_Nome + "</br>Setor do Cargo: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro + "</br>Chefe do Setor: " + ChefeProva;
                _Control.CadastrarErro(oErro);
            }

            //Cargo 2
            CargoProva = _Control.SelecionarCargo(aProva.Pro_Cargo2);
            CargoAluno = _Control.SelecionarCargoDiaCadastro(CargoProva.Car_DataCadastro, aEmpresa.Emp_ID);


            if (CargoAluno != null)
            {
                SetorProva = _Control.SelecionarSetor(CargoProva.Car_Setor_Set_ID);
                SetorAluno = _Control.SelecionarSetor(CargoAluno.Car_Setor_Set_ID);

                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\t", "");
                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\n", "");
                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\r", "");

                CargoProva.Car_Nome = CargoAluno.Car_Nome.Replace("\t", "");
                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\n", "");
                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\r", "");

                SetorAluno.Set_Nome = SetorAluno.Set_Nome.Replace("\t", "");
                SetorAluno.Set_Nome = SetorAluno.Set_Nome.Replace("\n", "");
                SetorAluno.Set_Nome = SetorAluno.Set_Nome.Replace("\r", "");

                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\t", "");
                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\n", "");
                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\r", "");

                if (CargoAluno.Car_Nome.Replace(" ", "") == CargoProva.Car_Nome.Replace(" ", "") && CargoAluno.Car_Chefe == CargoProva.Car_Chefe && SetorProva.Set_Nome.Replace(" ", "") == SetorAluno.Set_Nome.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    string ChefeAluno;

                    if (CargoAluno.Car_Chefe)
                    {
                        ChefeAluno = "Chefe do Setor";
                    }

                    else
                    {
                        ChefeAluno = "Este cargo não é chefe do Setor";
                    }

                    string ChefeProva;

                    if (CargoProva.Car_Chefe)
                    {
                        ChefeProva = "Chefe do Setor";
                    }

                    else
                    {
                        ChefeProva = "Este cargo não é chefe do Setor";
                    }

                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Cargo:</br>Nome do Cargo: " + CargoAluno.Car_Nome + "</br>Setor do Cargo: " + SetorAluno.Set_Nome + "</br>Data de Cadastro: " + CargoAluno.Car_DataCadastro + "</br>Chefe do Setor: " + ChefeAluno;
                    oErro.Err_RespostaCerta = "Cargo:</br>Nome do Cargo: " + CargoProva.Car_Nome + "</br>Setor do Cargo: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro + "</br>Chefe do Setor: " + ChefeProva;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                string ChefeProva;

                if (CargoProva.Car_Chefe)
                {
                    ChefeProva = "Chefe do Setor";
                }

                else
                {
                    ChefeProva = "Este cargo não é chefe do Setor";
                }

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum cargo cadastrado no dia " + CargoProva.Car_DataCadastro;
                oErro.Err_RespostaCerta = "Cargo:</br>Nome do Cargo: " + CargoProva.Car_Nome + "</br>Setor do Cargo: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro + "</br>Chefe do Setor: " + ChefeProva;
                _Control.CadastrarErro(oErro);
            }

            //Cargo 3
            CargoProva = _Control.SelecionarCargo(aProva.Pro_Cargo3);
            CargoAluno = _Control.SelecionarCargoDiaCadastro(CargoProva.Car_DataCadastro, aEmpresa.Emp_ID);




            if (CargoAluno != null)
            {
                SetorProva = _Control.SelecionarSetor(CargoProva.Car_Setor_Set_ID);
                SetorAluno = _Control.SelecionarSetor(CargoAluno.Car_Setor_Set_ID);

                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\t", "");
                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\n", "");
                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\r", "");

                CargoProva.Car_Nome = CargoAluno.Car_Nome.Replace("\t", "");
                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\n", "");
                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\r", "");

                SetorAluno.Set_Nome = SetorAluno.Set_Nome.Replace("\t", "");
                SetorAluno.Set_Nome = SetorAluno.Set_Nome.Replace("\n", "");
                SetorAluno.Set_Nome = SetorAluno.Set_Nome.Replace("\r", "");

                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\t", "");
                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\n", "");
                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\r", "");

                if (CargoAluno.Car_Nome.Replace(" ", "") == CargoProva.Car_Nome.Replace(" ", "") && CargoAluno.Car_Chefe == CargoProva.Car_Chefe && SetorProva.Set_Nome.Replace(" ", "") == SetorAluno.Set_Nome.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    string ChefeAluno;

                    if (CargoAluno.Car_Chefe)
                    {
                        ChefeAluno = "Chefe do Setor";
                    }

                    else
                    {
                        ChefeAluno = "Este cargo não é chefe do Setor";
                    }

                    string ChefeProva;

                    if (CargoProva.Car_Chefe)
                    {
                        ChefeProva = "Chefe do Setor";
                    }

                    else
                    {
                        ChefeProva = "Este cargo não é chefe do Setor";
                    }

                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Cargo:</br>Nome do Cargo: " + CargoAluno.Car_Nome + "</br>Setor do Cargo: " + SetorAluno.Set_Nome + "</br>Data de Cadastro: " + CargoAluno.Car_DataCadastro + "</br>Chefe do Setor: " + ChefeAluno;
                    oErro.Err_RespostaCerta = "Cargo:</br>Nome do Cargo: " + CargoProva.Car_Nome + "</br>Setor do Cargo: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro + "</br>Chefe do Setor: " + ChefeProva;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                string ChefeProva;

                if (CargoProva.Car_Chefe)
                {
                    ChefeProva = "Chefe do Setor";
                }

                else
                {
                    ChefeProva = "Este cargo não é chefe do Setor";
                }

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum cargo cadastrado no dia " + CargoProva.Car_DataCadastro;
                oErro.Err_RespostaCerta = "Cargo:</br>Nome do Cargo: " + CargoProva.Car_Nome + "</br>Setor do Cargo: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro + "</br>Chefe do Setor: " + ChefeProva;
                _Control.CadastrarErro(oErro);
            }

            //Cargo 4
            CargoProva = _Control.SelecionarCargo(aProva.Pro_Cargo4);
            CargoAluno = _Control.SelecionarCargoDiaCadastro(CargoProva.Car_DataCadastro, aEmpresa.Emp_ID);


            if (CargoAluno != null)
            {
                SetorProva = _Control.SelecionarSetor(CargoProva.Car_Setor_Set_ID);
                SetorAluno = _Control.SelecionarSetor(CargoAluno.Car_Setor_Set_ID);

                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\t", "");
                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\n", "");
                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\r", "");

                CargoProva.Car_Nome = CargoAluno.Car_Nome.Replace("\t", "");
                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\n", "");
                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\r", "");

                SetorAluno.Set_Nome = SetorAluno.Set_Nome.Replace("\t", "");
                SetorAluno.Set_Nome = SetorAluno.Set_Nome.Replace("\n", "");
                SetorAluno.Set_Nome = SetorAluno.Set_Nome.Replace("\r", "");

                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\t", "");
                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\n", "");
                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\r", "");

                if (CargoAluno.Car_Nome.Replace(" ", "") == CargoProva.Car_Nome.Replace(" ", "") && CargoAluno.Car_Chefe == CargoProva.Car_Chefe && SetorProva.Set_Nome.Replace(" ", "") == SetorAluno.Set_Nome.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    string ChefeAluno;

                    if (CargoAluno.Car_Chefe)
                    {
                        ChefeAluno = "Chefe do Setor";
                    }

                    else
                    {
                        ChefeAluno = "Este cargo não é chefe do Setor";
                    }

                    string ChefeProva;

                    if (CargoProva.Car_Chefe)
                    {
                        ChefeProva = "Chefe do Setor";
                    }

                    else
                    {
                        ChefeProva = "Este cargo não é chefe do Setor";
                    }

                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Cargo:</br>Nome do Cargo: " + CargoAluno.Car_Nome + "</br>Setor do Cargo: " + SetorAluno.Set_Nome + "</br>Data de Cadastro: " + CargoAluno.Car_DataCadastro + "</br>Chefe do Setor: " + ChefeAluno;
                    oErro.Err_RespostaCerta = "Cargo:</br>Nome do Cargo: " + CargoProva.Car_Nome + "</br>Setor do Cargo: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro + "</br>Chefe do Setor: " + ChefeProva;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                string ChefeProva;

                if (CargoProva.Car_Chefe)
                {
                    ChefeProva = "Chefe do Setor";
                }

                else
                {
                    ChefeProva = "Este cargo não é chefe do Setor";
                }

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum cargo cadastrado no dia " + CargoProva.Car_DataCadastro;
                oErro.Err_RespostaCerta = "Cargo:</br>Nome do Cargo: " + CargoProva.Car_Nome + "</br>Setor do Cargo: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro + "</br>Chefe do Setor: " + ChefeProva;
                _Control.CadastrarErro(oErro);
            }

            //Cargo 5
            CargoProva = _Control.SelecionarCargo(aProva.Pro_Cargo5);
            CargoAluno = _Control.SelecionarCargoDiaCadastro(CargoProva.Car_DataCadastro, aEmpresa.Emp_ID);


            if (CargoAluno != null)
            {
                SetorProva = _Control.SelecionarSetor(CargoProva.Car_Setor_Set_ID);
                SetorAluno = _Control.SelecionarSetor(CargoAluno.Car_Setor_Set_ID);

                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\t", "");
                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\n", "");
                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\r", "");

                CargoProva.Car_Nome = CargoAluno.Car_Nome.Replace("\t", "");
                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\n", "");
                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\r", "");

                SetorAluno.Set_Nome = SetorAluno.Set_Nome.Replace("\t", "");
                SetorAluno.Set_Nome = SetorAluno.Set_Nome.Replace("\n", "");
                SetorAluno.Set_Nome = SetorAluno.Set_Nome.Replace("\r", "");

                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\t", "");
                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\n", "");
                SetorProva.Set_Nome = SetorProva.Set_Nome.Replace("\r", "");

                if (CargoAluno.Car_Nome.Replace(" ", "") == CargoProva.Car_Nome.Replace(" ", "") && CargoAluno.Car_Chefe == CargoProva.Car_Chefe && SetorProva.Set_Nome.Replace(" ", "") == SetorAluno.Set_Nome.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    string ChefeAluno;

                    if (CargoAluno.Car_Chefe)
                    {
                        ChefeAluno = "Chefe do Setor";
                    }

                    else
                    {
                        ChefeAluno = "Este cargo não é chefe do Setor";
                    }

                    string ChefeProva;

                    if (CargoProva.Car_Chefe)
                    {
                        ChefeProva = "Chefe do Setor";
                    }

                    else
                    {
                        ChefeProva = "Este cargo não é chefe do Setor";
                    }

                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Cargo:</br>Nome do Cargo: " + CargoAluno.Car_Nome + "</br>Setor do Cargo: " + SetorAluno.Set_Nome + "</br>Data de Cadastro: " + CargoAluno.Car_DataCadastro + "</br>Chefe do Setor: " + ChefeAluno;
                    oErro.Err_RespostaCerta = "Cargo:</br>Nome do Cargo: " + CargoProva.Car_Nome + "</br>Setor do Cargo: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro + "</br>Chefe do Setor: " + ChefeProva;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                string ChefeProva;

                if (CargoProva.Car_Chefe)
                {
                    ChefeProva = "Chefe do Setor";
                }

                else
                {
                    ChefeProva = "Este cargo não é chefe do Setor";
                }

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum cargo cadastrado no dia " + CargoProva.Car_DataCadastro;
                oErro.Err_RespostaCerta = "Cargo:</br>Nome do Cargo: " + CargoProva.Car_Nome + "</br>Setor do Cargo: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro + "</br>Chefe do Setor: " + ChefeProva;
                _Control.CadastrarErro(oErro);
            }

            //Verifica Vagas

            //Vaga 1
            Vaga VagaProva = _Control.SelecionarVaga(aProva.Pro_Vaga1);
            Vaga VagaAluno = _Control.SelecionarVagaDataCadastro(VagaProva.Vag_DataCadastro, aEmpresa.Emp_ID);

            if(VagaAluno!=null)
            {
                CargoProva = _Control.SelecionarCargo(VagaProva.Vag_Cargo_Car_ID);
                CargoAluno = _Control.SelecionarCargo(VagaAluno.Vag_Cargo_Car_ID);

                VagaProva.Vag_Descricao=VagaProva.Vag_Descricao.Replace("\t", "");
                VagaProva.Vag_Descricao = VagaProva.Vag_Descricao.Replace("\n", "");
                VagaProva.Vag_Descricao = VagaProva.Vag_Descricao.Replace("\r", "");

                VagaAluno.Vag_Descricao = VagaAluno.Vag_Descricao.Replace("\t", "");
                VagaAluno.Vag_Descricao = VagaAluno.Vag_Descricao.Replace("\n", "");
                VagaAluno.Vag_Descricao = VagaAluno.Vag_Descricao.Replace("\r", "");

                VagaProva.Vag_Titulo = VagaProva.Vag_Titulo.Replace("\t", "");
                VagaProva.Vag_Titulo = VagaProva.Vag_Titulo.Replace("\n", "");
                VagaProva.Vag_Titulo = VagaProva.Vag_Titulo.Replace("\r", "");

                VagaAluno.Vag_Titulo = VagaAluno.Vag_Titulo.Replace("\t", "");
                VagaAluno.Vag_Titulo = VagaAluno.Vag_Titulo.Replace("\n", "");
                VagaAluno.Vag_Titulo = VagaAluno.Vag_Titulo.Replace("\r", "");

                if(VagaProva.Vag_Descricao==VagaAluno.Vag_Descricao && VagaProva.Vag_Titulo==VagaAluno.Vag_Titulo && CargoProva.Car_Nome==CargoAluno.Car_Nome)
                {
                    Nota = Nota + 0.1;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Vaga:</br>Título da Vaga: " + VagaProva.Vag_Titulo + "</br>Descrição da Vaga: " + VagaProva.Vag_Descricao + "</br>Cargo da Vaga: " + CargoProva.Car_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro;
                    oErro.Err_RespostaCerta = "Vaga:</br>Título da Vaga: " + VagaAluno.Vag_Titulo + "</br>Descrição da Vaga: " + VagaAluno.Vag_Descricao + "</br>Cargo da Vaga: " + CargoAluno.Car_Nome + "</br>Data de Cadastro: " + CargoAluno.Car_DataCadastro;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                CargoProva = _Control.SelecionarCargo(VagaProva.Vag_Cargo_Car_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum funcionário cadastrado no dia " + VagaProva.Vag_DataCadastro;
                oErro.Err_RespostaCerta = "Vaga:</br>Título da Vaga: " + VagaProva.Vag_Titulo + "</br>Descrição da Vaga: " + VagaProva.Vag_Descricao + "</br>Cargo da Vaga: " + CargoProva.Car_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            //Vaga 2
            VagaProva = _Control.SelecionarVaga(aProva.Pro_Vaga2);
            VagaAluno = _Control.SelecionarVagaDataCadastro(VagaProva.Vag_DataCadastro, aEmpresa.Emp_ID);

            if (VagaAluno != null)
            {
                CargoProva = _Control.SelecionarCargo(VagaProva.Vag_Cargo_Car_ID);
                CargoAluno = _Control.SelecionarCargo(VagaAluno.Vag_Cargo_Car_ID);

                VagaProva.Vag_Descricao = VagaProva.Vag_Descricao.Replace("\t", "");
                VagaProva.Vag_Descricao = VagaProva.Vag_Descricao.Replace("\n", "");
                VagaProva.Vag_Descricao = VagaProva.Vag_Descricao.Replace("\r", "");

                VagaAluno.Vag_Descricao = VagaAluno.Vag_Descricao.Replace("\t", "");
                VagaAluno.Vag_Descricao = VagaAluno.Vag_Descricao.Replace("\n", "");
                VagaAluno.Vag_Descricao = VagaAluno.Vag_Descricao.Replace("\r", "");

                VagaProva.Vag_Titulo = VagaProva.Vag_Titulo.Replace("\t", "");
                VagaProva.Vag_Titulo = VagaProva.Vag_Titulo.Replace("\n", "");
                VagaProva.Vag_Titulo = VagaProva.Vag_Titulo.Replace("\r", "");

                VagaAluno.Vag_Titulo = VagaAluno.Vag_Titulo.Replace("\t", "");
                VagaAluno.Vag_Titulo = VagaAluno.Vag_Titulo.Replace("\n", "");
                VagaAluno.Vag_Titulo = VagaAluno.Vag_Titulo.Replace("\r", "");

                if (VagaProva.Vag_Descricao == VagaAluno.Vag_Descricao && VagaProva.Vag_Titulo == VagaAluno.Vag_Titulo && CargoProva.Car_Nome == CargoAluno.Car_Nome)
                {
                    Nota = Nota + 0.1;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Vaga:</br>Título da Vaga: " + VagaProva.Vag_Titulo + "</br>Descrição da Vaga: " + VagaProva.Vag_Descricao + "</br>Cargo da Vaga: " + CargoProva.Car_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro;
                    oErro.Err_RespostaCerta = "Vaga:</br>Título da Vaga: " + VagaAluno.Vag_Titulo + "</br>Descrição da Vaga: " + VagaAluno.Vag_Descricao + "</br>Cargo da Vaga: " + CargoAluno.Car_Nome + "</br>Data de Cadastro: " + CargoAluno.Car_DataCadastro;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                CargoProva = _Control.SelecionarCargo(VagaProva.Vag_Cargo_Car_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum funcionário cadastrado no dia " + VagaProva.Vag_DataCadastro;
                oErro.Err_RespostaCerta = "Vaga:</br>Título da Vaga: " + VagaProva.Vag_Titulo + "</br>Descrição da Vaga: " + VagaProva.Vag_Descricao + "</br>Cargo da Vaga: " + CargoProva.Car_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            //Vaga 3
            VagaProva = _Control.SelecionarVaga(aProva.Pro_Vaga3);
            VagaAluno = _Control.SelecionarVagaDataCadastro(VagaProva.Vag_DataCadastro, aEmpresa.Emp_ID);

            if (VagaAluno != null)
            {
                CargoProva = _Control.SelecionarCargo(VagaProva.Vag_Cargo_Car_ID);
                CargoAluno = _Control.SelecionarCargo(VagaAluno.Vag_Cargo_Car_ID);

                VagaProva.Vag_Descricao = VagaProva.Vag_Descricao.Replace("\t", "");
                VagaProva.Vag_Descricao = VagaProva.Vag_Descricao.Replace("\n", "");
                VagaProva.Vag_Descricao = VagaProva.Vag_Descricao.Replace("\r", "");

                VagaAluno.Vag_Descricao = VagaAluno.Vag_Descricao.Replace("\t", "");
                VagaAluno.Vag_Descricao = VagaAluno.Vag_Descricao.Replace("\n", "");
                VagaAluno.Vag_Descricao = VagaAluno.Vag_Descricao.Replace("\r", "");

                VagaProva.Vag_Titulo = VagaProva.Vag_Titulo.Replace("\t", "");
                VagaProva.Vag_Titulo = VagaProva.Vag_Titulo.Replace("\n", "");
                VagaProva.Vag_Titulo = VagaProva.Vag_Titulo.Replace("\r", "");

                VagaAluno.Vag_Titulo = VagaAluno.Vag_Titulo.Replace("\t", "");
                VagaAluno.Vag_Titulo = VagaAluno.Vag_Titulo.Replace("\n", "");
                VagaAluno.Vag_Titulo = VagaAluno.Vag_Titulo.Replace("\r", "");

                if (VagaProva.Vag_Descricao == VagaAluno.Vag_Descricao && VagaProva.Vag_Titulo == VagaAluno.Vag_Titulo && CargoProva.Car_Nome == CargoAluno.Car_Nome)
                {
                    Nota = Nota + 0.1;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Vaga:</br>Título da Vaga: " + VagaProva.Vag_Titulo + "</br>Descrição da Vaga: " + VagaProva.Vag_Descricao + "</br>Cargo da Vaga: " + CargoProva.Car_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro;
                    oErro.Err_RespostaCerta = "Vaga:</br>Título da Vaga: " + VagaAluno.Vag_Titulo + "</br>Descrição da Vaga: " + VagaAluno.Vag_Descricao + "</br>Cargo da Vaga: " + CargoAluno.Car_Nome + "</br>Data de Cadastro: " + CargoAluno.Car_DataCadastro;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                CargoProva = _Control.SelecionarCargo(VagaProva.Vag_Cargo_Car_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum funcionário cadastrado no dia " + VagaProva.Vag_DataCadastro;
                oErro.Err_RespostaCerta = "Vaga:</br>Título da Vaga: " + VagaProva.Vag_Titulo + "</br>Descrição da Vaga: " + VagaProva.Vag_Descricao + "</br>Cargo da Vaga: " + CargoProva.Car_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            //Vaga 4
            VagaProva = _Control.SelecionarVaga(aProva.Pro_Vaga4);
            VagaAluno = _Control.SelecionarVagaDataCadastro(VagaProva.Vag_DataCadastro, aEmpresa.Emp_ID);

            if (VagaAluno != null)
            {
                CargoProva = _Control.SelecionarCargo(VagaProva.Vag_Cargo_Car_ID);
                CargoAluno = _Control.SelecionarCargo(VagaAluno.Vag_Cargo_Car_ID);

                VagaProva.Vag_Descricao = VagaProva.Vag_Descricao.Replace("\t", "");
                VagaProva.Vag_Descricao = VagaProva.Vag_Descricao.Replace("\n", "");
                VagaProva.Vag_Descricao = VagaProva.Vag_Descricao.Replace("\r", "");

                VagaAluno.Vag_Descricao = VagaAluno.Vag_Descricao.Replace("\t", "");
                VagaAluno.Vag_Descricao = VagaAluno.Vag_Descricao.Replace("\n", "");
                VagaAluno.Vag_Descricao = VagaAluno.Vag_Descricao.Replace("\r", "");

                VagaProva.Vag_Titulo = VagaProva.Vag_Titulo.Replace("\t", "");
                VagaProva.Vag_Titulo = VagaProva.Vag_Titulo.Replace("\n", "");
                VagaProva.Vag_Titulo = VagaProva.Vag_Titulo.Replace("\r", "");

                VagaAluno.Vag_Titulo = VagaAluno.Vag_Titulo.Replace("\t", "");
                VagaAluno.Vag_Titulo = VagaAluno.Vag_Titulo.Replace("\n", "");
                VagaAluno.Vag_Titulo = VagaAluno.Vag_Titulo.Replace("\r", "");

                if (VagaProva.Vag_Descricao == VagaAluno.Vag_Descricao && VagaProva.Vag_Titulo == VagaAluno.Vag_Titulo && CargoProva.Car_Nome == CargoAluno.Car_Nome)
                {
                    Nota = Nota + 0.1;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Vaga:</br>Título da Vaga: " + VagaProva.Vag_Titulo + "</br>Descrição da Vaga: " + VagaProva.Vag_Descricao + "</br>Cargo da Vaga: " + CargoProva.Car_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro;
                    oErro.Err_RespostaCerta = "Vaga:</br>Título da Vaga: " + VagaAluno.Vag_Titulo + "</br>Descrição da Vaga: " + VagaAluno.Vag_Descricao + "</br>Cargo da Vaga: " + CargoAluno.Car_Nome + "</br>Data de Cadastro: " + CargoAluno.Car_DataCadastro;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                CargoProva = _Control.SelecionarCargo(VagaProva.Vag_Cargo_Car_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum funcionário cadastrado no dia " + VagaProva.Vag_DataCadastro;
                oErro.Err_RespostaCerta = "Vaga:</br>Título da Vaga: " + VagaProva.Vag_Titulo + "</br>Descrição da Vaga: " + VagaProva.Vag_Descricao + "</br>Cargo da Vaga: " + CargoProva.Car_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            //Vaga 5
            VagaProva = _Control.SelecionarVaga(aProva.Pro_Vaga5);
            VagaAluno = _Control.SelecionarVagaDataCadastro(VagaProva.Vag_DataCadastro, aEmpresa.Emp_ID);

            if (VagaAluno != null)
            {
                CargoProva = _Control.SelecionarCargo(VagaProva.Vag_Cargo_Car_ID);
                CargoAluno = _Control.SelecionarCargo(VagaAluno.Vag_Cargo_Car_ID);

                VagaProva.Vag_Descricao = VagaProva.Vag_Descricao.Replace("\t", "");
                VagaProva.Vag_Descricao = VagaProva.Vag_Descricao.Replace("\n", "");
                VagaProva.Vag_Descricao = VagaProva.Vag_Descricao.Replace("\r", "");

                VagaAluno.Vag_Descricao = VagaAluno.Vag_Descricao.Replace("\t", "");
                VagaAluno.Vag_Descricao = VagaAluno.Vag_Descricao.Replace("\n", "");
                VagaAluno.Vag_Descricao = VagaAluno.Vag_Descricao.Replace("\r", "");

                VagaProva.Vag_Titulo = VagaProva.Vag_Titulo.Replace("\t", "");
                VagaProva.Vag_Titulo = VagaProva.Vag_Titulo.Replace("\n", "");
                VagaProva.Vag_Titulo = VagaProva.Vag_Titulo.Replace("\r", "");

                VagaAluno.Vag_Titulo = VagaAluno.Vag_Titulo.Replace("\t", "");
                VagaAluno.Vag_Titulo = VagaAluno.Vag_Titulo.Replace("\n", "");
                VagaAluno.Vag_Titulo = VagaAluno.Vag_Titulo.Replace("\r", "");

                if (VagaProva.Vag_Descricao == VagaAluno.Vag_Descricao && VagaProva.Vag_Titulo == VagaAluno.Vag_Titulo && CargoProva.Car_Nome == CargoAluno.Car_Nome)
                {
                    Nota = Nota + 0.1;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Vaga:</br>Título da Vaga: " + VagaProva.Vag_Titulo + "</br>Descrição da Vaga: " + VagaProva.Vag_Descricao + "</br>Cargo da Vaga: " + CargoProva.Car_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro;
                    oErro.Err_RespostaCerta = "Vaga:</br>Título da Vaga: " + VagaAluno.Vag_Titulo + "</br>Descrição da Vaga: " + VagaAluno.Vag_Descricao + "</br>Cargo da Vaga: " + CargoAluno.Car_Nome + "</br>Data de Cadastro: " + CargoAluno.Car_DataCadastro;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                CargoProva = _Control.SelecionarCargo(VagaProva.Vag_Cargo_Car_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum funcionário cadastrado no dia " + VagaProva.Vag_DataCadastro;
                oErro.Err_RespostaCerta = "Vaga:</br>Título da Vaga: " + VagaProva.Vag_Titulo + "</br>Descrição da Vaga: " + VagaProva.Vag_Descricao + "</br>Cargo da Vaga: " + CargoProva.Car_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            //Verificar Funcionarios

            //Funcionario 1
            Pessoa PessoaProva = _Control.SelecionarFuncionario(aProva.Pro_Pessoa1);
            Pessoa PessoaAluno = _Control.SelecionarPessoaDiaCadastro(PessoaProva.Pes_DataCadastro, aEmpresa.Emp_ID);

            if (PessoaAluno != null)
            {
                VagaProva = _Control.SelecionarVaga(PessoaProva.Pes_Vaga_Vag_ID);
                VagaAluno = _Control.SelecionarVaga(PessoaAluno.Pes_Vaga_Vag_ID);

                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                PessoaAluno.Pes_CPF = PessoaAluno.Pes_CPF.Replace("\t", "");
                PessoaAluno.Pes_CPF = PessoaAluno.Pes_CPF.Replace("\n", "");
                PessoaAluno.Pes_CPF = PessoaAluno.Pes_CPF.Replace("\r", "");

                PessoaProva.Pes_CPF = PessoaProva.Pes_CPF.Replace("\t", "");
                PessoaProva.Pes_CPF = PessoaProva.Pes_CPF.Replace("\n", "");
                PessoaProva.Pes_CPF = PessoaProva.Pes_CPF.Replace("\r", "");

                PessoaAluno.Pes_Cidade = PessoaAluno.Pes_Cidade.Replace("\t", "");
                PessoaAluno.Pes_Cidade = PessoaAluno.Pes_Cidade.Replace("\n", "");
                PessoaAluno.Pes_Cidade = PessoaAluno.Pes_Cidade.Replace("\r", "");

                PessoaProva.Pes_Cidade = PessoaProva.Pes_Cidade.Replace("\t", "");
                PessoaProva.Pes_Cidade = PessoaProva.Pes_Cidade.Replace("\n", "");
                PessoaProva.Pes_Cidade = PessoaProva.Pes_Cidade.Replace("\r", "");

                PessoaAluno.Pes_Endereco = PessoaAluno.Pes_Endereco.Replace("\t", "");
                PessoaAluno.Pes_Endereco = PessoaAluno.Pes_Endereco.Replace("\n", "");
                PessoaAluno.Pes_Endereco = PessoaAluno.Pes_Endereco.Replace("\r", "");

                PessoaProva.Pes_Endereco = PessoaProva.Pes_Endereco.Replace("\t", "");
                PessoaProva.Pes_Endereco = PessoaProva.Pes_Endereco.Replace("\n", "");
                PessoaProva.Pes_Endereco = PessoaProva.Pes_Endereco.Replace("\r", "");

                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\t", "");
                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\n", "");
                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\r", "");

                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\t", "");
                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\n", "");
                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\r", "");

                if (PessoaAluno.Pes_Nome.Replace(" ","") == PessoaProva.Pes_Nome.Replace(" ","") && PessoaAluno.Pes_CPF.Replace(" ", "") == PessoaProva.Pes_CPF.Replace(" ", "") && PessoaAluno.Pes_Cidade.Replace(" ", "") == PessoaProva.Pes_Cidade.Replace(" ", "") && PessoaAluno.Pes_Endereco.Replace(" ", "") == PessoaProva.Pes_Endereco.Replace(" ", "") && PessoaAluno.Pes_Salario == PessoaProva.Pes_Salario && VagaProva.Vag_Titulo.Replace(" ", "") == VagaAluno.Vag_Titulo.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {

                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Funcionário:</br>Nome do Funcionário: " + PessoaAluno.Pes_Nome + "</br>CPF: " + PessoaAluno.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaAluno.Pes_CTrabalho + "</br>Salário: " + PessoaAluno.Pes_Salario + "</br>Cidade: " + PessoaAluno.Pes_Cidade + "</br>Endereço: " + PessoaAluno.Pes_Endereco + "</br>Data de Cadastro: " + PessoaAluno.Pes_DataCadastro + "</br>Vaga do Funcionário: " + VagaAluno.Vag_Titulo;
                    oErro.Err_RespostaCerta= "Funcionário:</br>Nome do Funcionário: " + PessoaProva.Pes_Nome + "</br>CPF: " + PessoaProva.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaProva.Pes_CTrabalho + "</br>Salário: " + PessoaProva.Pes_Salario + "</br>Cidade: " + PessoaProva.Pes_Cidade + "</br>Endereço: " + PessoaProva.Pes_Endereco + "</br>Data de Cadastro: " + PessoaProva.Pes_DataCadastro + "</br>Vaga do Funcionário: " + VagaProva.Vag_Titulo;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                VagaProva = _Control.SelecionarVaga(PessoaProva.Pes_Vaga_Vag_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum funcionário cadastrado no dia " + PessoaProva.Pes_DataCadastro;
                oErro.Err_RespostaCerta= "Funcionário:</br>Nome do Funcionário: " + PessoaProva.Pes_Nome + "</br>CPF: " + PessoaProva.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaProva.Pes_CTrabalho + "</br>Salário: " + PessoaProva.Pes_Salario + "</br>Cidade: " + PessoaProva.Pes_Cidade + "</br>Endereço: " + PessoaProva.Pes_Endereco + "</br>Data de Cadastro: " + PessoaProva.Pes_DataCadastro + "</br>Vaga do Funcionário: " + VagaProva.Vag_Titulo;
                _Control.CadastrarErro(oErro);
            }

            //Funcionario 2
            PessoaProva = _Control.SelecionarFuncionario(aProva.Pro_Pessoa2);
            PessoaAluno = _Control.SelecionarPessoaDiaCadastro(PessoaProva.Pes_DataCadastro, aEmpresa.Emp_ID);

            if (PessoaAluno != null)
            {
                VagaProva = _Control.SelecionarVaga(PessoaProva.Pes_Vaga_Vag_ID);
                VagaAluno = _Control.SelecionarVaga(PessoaAluno.Pes_Vaga_Vag_ID);

                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                PessoaAluno.Pes_CPF = PessoaAluno.Pes_CPF.Replace("\t", "");
                PessoaAluno.Pes_CPF = PessoaAluno.Pes_CPF.Replace("\n", "");
                PessoaAluno.Pes_CPF = PessoaAluno.Pes_CPF.Replace("\r", "");

                PessoaProva.Pes_CPF = PessoaProva.Pes_CPF.Replace("\t", "");
                PessoaProva.Pes_CPF = PessoaProva.Pes_CPF.Replace("\n", "");
                PessoaProva.Pes_CPF = PessoaProva.Pes_CPF.Replace("\r", "");

                PessoaAluno.Pes_Cidade = PessoaAluno.Pes_Cidade.Replace("\t", "");
                PessoaAluno.Pes_Cidade = PessoaAluno.Pes_Cidade.Replace("\n", "");
                PessoaAluno.Pes_Cidade = PessoaAluno.Pes_Cidade.Replace("\r", "");

                PessoaProva.Pes_Cidade = PessoaProva.Pes_Cidade.Replace("\t", "");
                PessoaProva.Pes_Cidade = PessoaProva.Pes_Cidade.Replace("\n", "");
                PessoaProva.Pes_Cidade = PessoaProva.Pes_Cidade.Replace("\r", "");

                PessoaAluno.Pes_Endereco = PessoaAluno.Pes_Endereco.Replace("\t", "");
                PessoaAluno.Pes_Endereco = PessoaAluno.Pes_Endereco.Replace("\n", "");
                PessoaAluno.Pes_Endereco = PessoaAluno.Pes_Endereco.Replace("\r", "");

                PessoaProva.Pes_Endereco = PessoaProva.Pes_Endereco.Replace("\t", "");
                PessoaProva.Pes_Endereco = PessoaProva.Pes_Endereco.Replace("\n", "");
                PessoaProva.Pes_Endereco = PessoaProva.Pes_Endereco.Replace("\r", "");

                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\t", "");
                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\n", "");
                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\r", "");

                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\t", "");
                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\n", "");
                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\r", "");

                if (PessoaAluno.Pes_Nome.Replace(" ", "") == PessoaProva.Pes_Nome.Replace(" ", "") && PessoaAluno.Pes_CPF.Replace(" ", "") == PessoaProva.Pes_CPF.Replace(" ", "") && PessoaAluno.Pes_Cidade.Replace(" ", "") == PessoaProva.Pes_Cidade.Replace(" ", "") && PessoaAluno.Pes_Endereco.Replace(" ", "") == PessoaProva.Pes_Endereco.Replace(" ", "") && PessoaAluno.Pes_Salario == PessoaProva.Pes_Salario && VagaProva.Vag_Titulo.Replace(" ", "") == VagaAluno.Vag_Titulo.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Funcionário:</br>Nome do Funcionário: " + PessoaAluno.Pes_Nome + "</br>CPF: " + PessoaAluno.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaAluno.Pes_CTrabalho + "</br>Salário: " + PessoaAluno.Pes_Salario + "</br>Cidade: " + PessoaAluno.Pes_Cidade + "</br>Endereço: " + PessoaAluno.Pes_Endereco + "</br>Data de Cadastro: " + PessoaAluno.Pes_DataCadastro + "</br>Vaga do Funcionário: " + VagaAluno.Vag_Titulo;
                    oErro.Err_RespostaCerta = "Funcionário:</br>Nome do Funcionário: " + PessoaProva.Pes_Nome + "</br>CPF: " + PessoaProva.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaProva.Pes_CTrabalho + "</br>Salário: " + PessoaProva.Pes_Salario + "</br>Cidade: " + PessoaProva.Pes_Cidade + "</br>Endereço: " + PessoaProva.Pes_Endereco + "</br>Data de Cadastro: " + PessoaProva.Pes_DataCadastro + "</br>Vaga do Funcionário: " + VagaProva.Vag_Titulo;
                    _Control.CadastrarErro(oErro);
                    
                }
            }

            else
            {
                VagaProva = _Control.SelecionarVaga(PessoaProva.Pes_Vaga_Vag_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum funcionário cadastrado no dia " + PessoaProva.Pes_DataCadastro;
                oErro.Err_RespostaCerta = "Funcionário:</br>Nome do Funcionário: " + PessoaProva.Pes_Nome + "</br>CPF: " + PessoaProva.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaProva.Pes_CTrabalho + "</br>Salário: " + PessoaProva.Pes_Salario + "</br>Cidade: " + PessoaProva.Pes_Cidade + "</br>Endereço: " + PessoaProva.Pes_Endereco + "</br>Data de Cadastro: " + PessoaProva.Pes_DataCadastro + "</br>Vaga do Funcionário: " + VagaProva.Vag_Titulo;
                _Control.CadastrarErro(oErro);
            }

            //Funcionario 3
            PessoaProva = _Control.SelecionarFuncionario(aProva.Pro_Pessoa3);
            PessoaAluno = _Control.SelecionarPessoaDiaCadastro(PessoaProva.Pes_DataCadastro, aEmpresa.Emp_ID);

            if (PessoaAluno != null)
            {
                VagaProva = _Control.SelecionarVaga(PessoaProva.Pes_Vaga_Vag_ID);
                VagaAluno = _Control.SelecionarVaga(PessoaAluno.Pes_Vaga_Vag_ID);

                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                PessoaAluno.Pes_CPF = PessoaAluno.Pes_CPF.Replace("\t", "");
                PessoaAluno.Pes_CPF = PessoaAluno.Pes_CPF.Replace("\n", "");
                PessoaAluno.Pes_CPF = PessoaAluno.Pes_CPF.Replace("\r", "");

                PessoaProva.Pes_CPF = PessoaProva.Pes_CPF.Replace("\t", "");
                PessoaProva.Pes_CPF = PessoaProva.Pes_CPF.Replace("\n", "");
                PessoaProva.Pes_CPF = PessoaProva.Pes_CPF.Replace("\r", "");

                PessoaAluno.Pes_Cidade = PessoaAluno.Pes_Cidade.Replace("\t", "");
                PessoaAluno.Pes_Cidade = PessoaAluno.Pes_Cidade.Replace("\n", "");
                PessoaAluno.Pes_Cidade = PessoaAluno.Pes_Cidade.Replace("\r", "");

                PessoaProva.Pes_Cidade = PessoaProva.Pes_Cidade.Replace("\t", "");
                PessoaProva.Pes_Cidade = PessoaProva.Pes_Cidade.Replace("\n", "");
                PessoaProva.Pes_Cidade = PessoaProva.Pes_Cidade.Replace("\r", "");

                PessoaAluno.Pes_Endereco = PessoaAluno.Pes_Endereco.Replace("\t", "");
                PessoaAluno.Pes_Endereco = PessoaAluno.Pes_Endereco.Replace("\n", "");
                PessoaAluno.Pes_Endereco = PessoaAluno.Pes_Endereco.Replace("\r", "");

                PessoaProva.Pes_Endereco = PessoaProva.Pes_Endereco.Replace("\t", "");
                PessoaProva.Pes_Endereco = PessoaProva.Pes_Endereco.Replace("\n", "");
                PessoaProva.Pes_Endereco = PessoaProva.Pes_Endereco.Replace("\r", "");

                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\t", "");
                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\n", "");
                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\r", "");

                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\t", "");
                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\n", "");
                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\r", "");
                if (PessoaAluno.Pes_Nome.Replace(" ", "") == PessoaProva.Pes_Nome.Replace(" ", "") && PessoaAluno.Pes_CPF.Replace(" ", "") == PessoaProva.Pes_CPF.Replace(" ", "") && PessoaAluno.Pes_Cidade.Replace(" ", "") == PessoaProva.Pes_Cidade.Replace(" ", "") && PessoaAluno.Pes_Endereco.Replace(" ", "") == PessoaProva.Pes_Endereco.Replace(" ", "") && PessoaAluno.Pes_Salario == PessoaProva.Pes_Salario && VagaProva.Vag_Titulo.Replace(" ", "") == VagaAluno.Vag_Titulo.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Funcionário:</br>Nome do Funcionário: " + PessoaAluno.Pes_Nome + "</br>CPF: " + PessoaAluno.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaAluno.Pes_CTrabalho + "</br>Salário: " + PessoaAluno.Pes_Salario + "</br>Cidade: " + PessoaAluno.Pes_Cidade + "</br>Endereço: " + PessoaAluno.Pes_Endereco + "</br>Data de Cadastro: " + PessoaAluno.Pes_DataCadastro + "</br>Vaga do Funcionário: " + VagaAluno.Vag_Titulo;
                    oErro.Err_RespostaCerta = "Funcionário:</br>Nome do Funcionário: " + PessoaProva.Pes_Nome + "</br>CPF: " + PessoaProva.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaProva.Pes_CTrabalho + "</br>Salário: " + PessoaProva.Pes_Salario + "</br>Cidade: " + PessoaProva.Pes_Cidade + "</br>Endereço: " + PessoaProva.Pes_Endereco + "</br>Data de Cadastro: " + PessoaProva.Pes_DataCadastro + "</br>Vaga do Funcionário: " + VagaProva.Vag_Titulo;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                VagaProva = _Control.SelecionarVaga(PessoaProva.Pes_Vaga_Vag_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum funcionário cadastrado no dia " + PessoaProva.Pes_DataCadastro;
                oErro.Err_RespostaCerta = "Funcionário:</br>Nome do Funcionário: " + PessoaProva.Pes_Nome + "</br>CPF: " + PessoaProva.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaProva.Pes_CTrabalho + "</br>Salário: " + PessoaProva.Pes_Salario + "</br>Cidade: " + PessoaProva.Pes_Cidade + "</br>Endereço: " + PessoaProva.Pes_Endereco + "</br>Data de Cadastro: " + PessoaProva.Pes_DataCadastro + "</br>Vaga do Funcionário: " + VagaProva.Vag_Titulo;
                _Control.CadastrarErro(oErro);
            }

            //Funcionário 4
            PessoaProva = _Control.SelecionarFuncionario(aProva.Pro_Pessoa4);
            PessoaAluno = _Control.SelecionarPessoaDiaCadastro(PessoaProva.Pes_DataCadastro, aEmpresa.Emp_ID);

            if (PessoaAluno != null)
            {
                VagaProva = _Control.SelecionarVaga(PessoaProva.Pes_Vaga_Vag_ID);
                VagaAluno = _Control.SelecionarVaga(PessoaAluno.Pes_Vaga_Vag_ID);

                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                PessoaAluno.Pes_CPF = PessoaAluno.Pes_CPF.Replace("\t", "");
                PessoaAluno.Pes_CPF = PessoaAluno.Pes_CPF.Replace("\n", "");
                PessoaAluno.Pes_CPF = PessoaAluno.Pes_CPF.Replace("\r", "");

                PessoaProva.Pes_CPF = PessoaProva.Pes_CPF.Replace("\t", "");
                PessoaProva.Pes_CPF = PessoaProva.Pes_CPF.Replace("\n", "");
                PessoaProva.Pes_CPF = PessoaProva.Pes_CPF.Replace("\r", "");

                PessoaAluno.Pes_Cidade = PessoaAluno.Pes_Cidade.Replace("\t", "");
                PessoaAluno.Pes_Cidade = PessoaAluno.Pes_Cidade.Replace("\n", "");
                PessoaAluno.Pes_Cidade = PessoaAluno.Pes_Cidade.Replace("\r", "");

                PessoaProva.Pes_Cidade = PessoaProva.Pes_Cidade.Replace("\t", "");
                PessoaProva.Pes_Cidade = PessoaProva.Pes_Cidade.Replace("\n", "");
                PessoaProva.Pes_Cidade = PessoaProva.Pes_Cidade.Replace("\r", "");

                PessoaAluno.Pes_Endereco = PessoaAluno.Pes_Endereco.Replace("\t", "");
                PessoaAluno.Pes_Endereco = PessoaAluno.Pes_Endereco.Replace("\n", "");
                PessoaAluno.Pes_Endereco = PessoaAluno.Pes_Endereco.Replace("\r", "");

                PessoaProva.Pes_Endereco = PessoaProva.Pes_Endereco.Replace("\t", "");
                PessoaProva.Pes_Endereco = PessoaProva.Pes_Endereco.Replace("\n", "");
                PessoaProva.Pes_Endereco = PessoaProva.Pes_Endereco.Replace("\r", "");

                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\t", "");
                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\n", "");
                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\r", "");

                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\t", "");
                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\n", "");
                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\r", "");

                if (PessoaAluno.Pes_Nome.Replace(" ", "") == PessoaProva.Pes_Nome.Replace(" ", "") && PessoaAluno.Pes_CPF.Replace(" ", "") == PessoaProva.Pes_CPF.Replace(" ", "") && PessoaAluno.Pes_Cidade.Replace(" ", "") == PessoaProva.Pes_Cidade.Replace(" ", "") && PessoaAluno.Pes_Endereco.Replace(" ", "") == PessoaProva.Pes_Endereco.Replace(" ", "") && PessoaAluno.Pes_Salario == PessoaProva.Pes_Salario && VagaProva.Vag_Titulo.Replace(" ", "") == VagaAluno.Vag_Titulo.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Funcionário:</br>Nome do Funcionário: " + PessoaAluno.Pes_Nome + "</br>CPF: " + PessoaAluno.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaAluno.Pes_CTrabalho + "</br>Salário: " + PessoaAluno.Pes_Salario + "</br>Cidade: " + PessoaAluno.Pes_Cidade + "</br>Endereço: " + PessoaAluno.Pes_Endereco + "</br>Data de Cadastro: " + PessoaAluno.Pes_DataCadastro + "</br>Vaga do Funcionário: " + VagaAluno.Vag_Titulo;
                    oErro.Err_RespostaCerta = "Funcionário:</br>Nome do Funcionário: " + PessoaProva.Pes_Nome + "</br>CPF: " + PessoaProva.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaProva.Pes_CTrabalho + "</br>Salário: " + PessoaProva.Pes_Salario + "</br>Cidade: " + PessoaProva.Pes_Cidade + "</br>Endereço: " + PessoaProva.Pes_Endereco + "</br>Data de Cadastro: " + PessoaProva.Pes_DataCadastro + "</br>Vaga do Funcionário: " + VagaProva.Vag_Titulo;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                VagaProva = _Control.SelecionarVaga(PessoaProva.Pes_Vaga_Vag_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum funcionário cadastrado no dia " + PessoaProva.Pes_DataCadastro;
                oErro.Err_RespostaCerta = "Funcionário:</br>Nome do Funcionário: " + PessoaProva.Pes_Nome + "</br>CPF: " + PessoaProva.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaProva.Pes_CTrabalho + "</br>Salário: " + PessoaProva.Pes_Salario + "</br>Cidade: " + PessoaProva.Pes_Cidade + "</br>Endereço: " + PessoaProva.Pes_Endereco + "</br>Data de Cadastro: " + PessoaProva.Pes_DataCadastro + "</br>Vaga do Funcionário: " + VagaProva.Vag_Titulo;
                _Control.CadastrarErro(oErro);
            }

            //Funcionário 5
            PessoaProva = _Control.SelecionarFuncionario(aProva.Pro_Pessoa5);
            PessoaAluno = _Control.SelecionarPessoaDiaCadastro(PessoaProva.Pes_DataCadastro, aEmpresa.Emp_ID);

            if (PessoaAluno != null)
            {
                VagaProva = _Control.SelecionarVaga(PessoaProva.Pes_Vaga_Vag_ID);
                VagaAluno = _Control.SelecionarVaga(PessoaAluno.Pes_Vaga_Vag_ID);

                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                PessoaAluno.Pes_CPF = PessoaAluno.Pes_CPF.Replace("\t", "");
                PessoaAluno.Pes_CPF = PessoaAluno.Pes_CPF.Replace("\n", "");
                PessoaAluno.Pes_CPF = PessoaAluno.Pes_CPF.Replace("\r", "");

                PessoaProva.Pes_CPF = PessoaProva.Pes_CPF.Replace("\t", "");
                PessoaProva.Pes_CPF = PessoaProva.Pes_CPF.Replace("\n", "");
                PessoaProva.Pes_CPF = PessoaProva.Pes_CPF.Replace("\r", "");

                PessoaAluno.Pes_Cidade = PessoaAluno.Pes_Cidade.Replace("\t", "");
                PessoaAluno.Pes_Cidade = PessoaAluno.Pes_Cidade.Replace("\n", "");
                PessoaAluno.Pes_Cidade = PessoaAluno.Pes_Cidade.Replace("\r", "");

                PessoaProva.Pes_Cidade = PessoaProva.Pes_Cidade.Replace("\t", "");
                PessoaProva.Pes_Cidade = PessoaProva.Pes_Cidade.Replace("\n", "");
                PessoaProva.Pes_Cidade = PessoaProva.Pes_Cidade.Replace("\r", "");

                PessoaAluno.Pes_Endereco = PessoaAluno.Pes_Endereco.Replace("\t", "");
                PessoaAluno.Pes_Endereco = PessoaAluno.Pes_Endereco.Replace("\n", "");
                PessoaAluno.Pes_Endereco = PessoaAluno.Pes_Endereco.Replace("\r", "");

                PessoaProva.Pes_Endereco = PessoaProva.Pes_Endereco.Replace("\t", "");
                PessoaProva.Pes_Endereco = PessoaProva.Pes_Endereco.Replace("\n", "");
                PessoaProva.Pes_Endereco = PessoaProva.Pes_Endereco.Replace("\r", "");

                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\t", "");
                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\n", "");
                CargoAluno.Car_Nome = CargoAluno.Car_Nome.Replace("\r", "");

                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\t", "");
                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\n", "");
                CargoProva.Car_Nome = CargoProva.Car_Nome.Replace("\r", "");

                if (PessoaAluno.Pes_Nome.Replace(" ", "") == PessoaProva.Pes_Nome.Replace(" ", "") && PessoaAluno.Pes_CPF.Replace(" ", "") == PessoaProva.Pes_CPF.Replace(" ", "") && PessoaAluno.Pes_Cidade.Replace(" ", "") == PessoaProva.Pes_Cidade.Replace(" ", "") && PessoaAluno.Pes_Endereco.Replace(" ", "") == PessoaProva.Pes_Endereco.Replace(" ", "") && PessoaAluno.Pes_Salario == PessoaProva.Pes_Salario && VagaProva.Vag_Titulo.Replace(" ", "") == VagaAluno.Vag_Titulo.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Funcionário:</br>Nome do Funcionário: " + PessoaAluno.Pes_Nome + "</br>CPF: " + PessoaAluno.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaAluno.Pes_CTrabalho + "</br>Salário: " + PessoaAluno.Pes_Salario + "</br>Cidade: " + PessoaAluno.Pes_Cidade + "</br>Endereço: " + PessoaAluno.Pes_Endereco + "</br>Data de Cadastro: " + PessoaAluno.Pes_DataCadastro + "</br>Vaga do Funcionário: " + VagaAluno.Vag_Titulo;
                    oErro.Err_RespostaCerta = "Funcionário:</br>Nome do Funcionário: " + PessoaProva.Pes_Nome + "</br>CPF: " + PessoaProva.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaProva.Pes_CTrabalho + "</br>Salário: " + PessoaProva.Pes_Salario + "</br>Cidade: " + PessoaProva.Pes_Cidade + "</br>Endereço: " + PessoaProva.Pes_Endereco + "</br>Data de Cadastro: " + PessoaProva.Pes_DataCadastro + "</br>Vaga do Funcionário: " + VagaProva.Vag_Titulo;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                VagaProva = _Control.SelecionarVaga(PessoaProva.Pes_Vaga_Vag_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum funcionário cadastrado no dia " + PessoaProva.Pes_DataCadastro;
                oErro.Err_RespostaCerta = "Funcionário:</br>Nome do Funcionário: " + PessoaProva.Pes_Nome + "</br>CPF: " + PessoaProva.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaProva.Pes_CTrabalho + "</br>Salário: " + PessoaProva.Pes_Salario + "</br>Cidade: " + PessoaProva.Pes_Cidade + "</br>Endereço: " + PessoaProva.Pes_Endereco + "</br>Data de Cadastro: " + PessoaProva.Pes_DataCadastro + "</br>Vaga do Funcionário: " + VagaProva.Vag_Titulo;
                _Control.CadastrarErro(oErro);
            }

            //Verifica Dependentes

            //Dependente 1
            DadoDependente DependenteProva = _Control.SelecionarDependente(aProva.Pro_DadoDependente1);
            DadoDependente DependenteAluno = _Control.SelecionarDependenteDiaCadastro(DependenteProva.DP_DataCadastro, aEmpresa.Emp_ID);

            if (DependenteAluno != null)
            {
                PessoaProva = _Control.SelecionarPessoa(DependenteProva.DP_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarPessoa(DependenteAluno.DP_Pessoa_Pes_ID);

                DependenteAluno.DP_Nome = DependenteAluno.DP_Nome.Replace("\t", "");
                DependenteAluno.DP_Nome = DependenteAluno.DP_Nome.Replace("\n", "");
                DependenteAluno.DP_Nome = DependenteAluno.DP_Nome.Replace("\r", "");

                DependenteProva.DP_Nome = DependenteProva.DP_Nome.Replace("\t", "");
                DependenteProva.DP_Nome = DependenteProva.DP_Nome.Replace("\n", "");
                DependenteProva.DP_Nome = DependenteProva.DP_Nome.Replace("\r", "");

                DependenteAluno.DP_Parentesco = DependenteAluno.DP_Parentesco.Replace("\t", "");
                DependenteAluno.DP_Parentesco = DependenteAluno.DP_Parentesco.Replace("\n", "");
                DependenteAluno.DP_Parentesco = DependenteAluno.DP_Parentesco.Replace("\r", "");

                DependenteProva.DP_Parentesco = DependenteProva.DP_Parentesco.Replace("\t", "");
                DependenteProva.DP_Parentesco = DependenteProva.DP_Parentesco.Replace("\n", "");
                DependenteProva.DP_Parentesco = DependenteProva.DP_Parentesco.Replace("\r", "");

                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n","");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                if (DependenteAluno.DP_Nome.Replace(" ","") == DependenteProva.DP_Nome.Replace(" ","") && DependenteAluno.DP_Parentesco.Replace(" ", "") == DependenteProva.DP_Parentesco.Replace(" ","") && PessoaProva.Pes_Nome.Replace(" ", "") == PessoaAluno.Pes_Nome.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Dependente</br>Parente do Funcionário: " + PessoaAluno.Pes_Nome + "</br>Nome do Dependente: " + DependenteAluno.DP_Nome + "</br>Parentesco com o funcionário: " + DependenteAluno.DP_Parentesco + "</br>Data de Cadastro: " + DependenteAluno.DP_DataCadastro;
                    oErro.Err_RespostaCerta = "Dependente</br>Parente do Funcionário: " + PessoaProva.Pes_Nome + "</br>Nome do Dependente: " + DependenteProva.DP_Nome + "</br>Parentesco com o funcionário: " + DependenteProva.DP_Parentesco + "</br>Data de Cadastro: " + DependenteProva.DP_DataCadastro;
                    _Control.CadastrarErro(oErro);
                }

            }

            else
            {
                PessoaProva = _Control.SelecionarFuncionario(DependenteProva.DP_Pessoa_Pes_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum dependente cadastrado no dia " + DependenteProva.DP_DataCadastro;
                oErro.Err_RespostaCerta= "Dependente</br>Parente do Funcionário: " + PessoaProva.Pes_Nome + "</br>Nome do Dependente: " + DependenteProva.DP_Nome + "</br>Parentesco com o funcionário: " + DependenteProva.DP_Parentesco + "</br>Data de Cadastro: " + DependenteProva.DP_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            //Dependente 2
            DependenteProva = _Control.SelecionarDependente(aProva.Pro_DadoDependente2);
            DependenteAluno = _Control.SelecionarDependenteDiaCadastro(DependenteProva.DP_DataCadastro, aEmpresa.Emp_ID);

            if (DependenteAluno != null)
            {
                PessoaProva = _Control.SelecionarPessoa(DependenteProva.DP_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarPessoa(DependenteAluno.DP_Pessoa_Pes_ID);

                DependenteAluno.DP_Nome = DependenteAluno.DP_Nome.Replace("\t", "");
                DependenteAluno.DP_Nome = DependenteAluno.DP_Nome.Replace("\n", "");
                DependenteAluno.DP_Nome = DependenteAluno.DP_Nome.Replace("\r", "");

                DependenteProva.DP_Nome = DependenteProva.DP_Nome.Replace("\t", "");
                DependenteProva.DP_Nome = DependenteProva.DP_Nome.Replace("\n", "");
                DependenteProva.DP_Nome = DependenteProva.DP_Nome.Replace("\r", "");

                DependenteAluno.DP_Parentesco = DependenteAluno.DP_Parentesco.Replace("\t", "");
                DependenteAluno.DP_Parentesco = DependenteAluno.DP_Parentesco.Replace("\n", "");
                DependenteAluno.DP_Parentesco = DependenteAluno.DP_Parentesco.Replace("\r", "");

                DependenteProva.DP_Parentesco = DependenteProva.DP_Parentesco.Replace("\t", "");
                DependenteProva.DP_Parentesco = DependenteProva.DP_Parentesco.Replace("\n", "");
                DependenteProva.DP_Parentesco = DependenteProva.DP_Parentesco.Replace("\r", "");

                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                if (DependenteAluno.DP_Nome.Replace(" ", "") == DependenteProva.DP_Nome.Replace(" ", "") && DependenteAluno.DP_Parentesco.Replace(" ", "") == DependenteProva.DP_Parentesco.Replace(" ", "") && PessoaProva.Pes_Nome.Replace(" ", "") == PessoaAluno.Pes_Nome.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Dependente</br>Parente do Funcionário: " + PessoaAluno.Pes_Nome + "</br>Nome do Dependente: " + DependenteAluno.DP_Nome + "</br>Parentesco com o funcionário: " + DependenteAluno.DP_Parentesco + "</br>Data de Cadastro: " + DependenteAluno.DP_DataCadastro;
                    oErro.Err_RespostaCerta = "Dependente</br>Parente do Funcionário: " + PessoaProva.Pes_Nome + "</br>Nome do Dependente: " + DependenteProva.DP_Nome + "</br>Parentesco com o funcionário: " + DependenteProva.DP_Parentesco + "</br>Data de Cadastro: " + DependenteProva.DP_DataCadastro;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                PessoaProva = _Control.SelecionarFuncionario(DependenteProva.DP_Pessoa_Pes_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum dependente cadastrado no dia " + DependenteProva.DP_DataCadastro;
                oErro.Err_RespostaCerta = "Dependente</br>Parente do Funcionário: " + PessoaProva.Pes_Nome + "</br>Nome do Dependente: " + DependenteProva.DP_Nome + "</br>Parentesco com o funcionário: " + DependenteProva.DP_Parentesco + "</br>Data de Cadastro: " + DependenteProva.DP_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            //Dependente 3
            DependenteProva = _Control.SelecionarDependente(aProva.Pro_DadoDependente3);
            DependenteAluno = _Control.SelecionarDependenteDiaCadastro(DependenteProva.DP_DataCadastro, aEmpresa.Emp_ID);

            if (DependenteAluno != null)
            {
                PessoaProva = _Control.SelecionarPessoa(DependenteProva.DP_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarPessoa(DependenteAluno.DP_Pessoa_Pes_ID);

                DependenteAluno.DP_Nome = DependenteAluno.DP_Nome.Replace("\t", "");
                DependenteAluno.DP_Nome = DependenteAluno.DP_Nome.Replace("\n", "");
                DependenteAluno.DP_Nome = DependenteAluno.DP_Nome.Replace("\r", "");

                DependenteProva.DP_Nome = DependenteProva.DP_Nome.Replace("\t", "");
                DependenteProva.DP_Nome = DependenteProva.DP_Nome.Replace("\n", "");
                DependenteProva.DP_Nome = DependenteProva.DP_Nome.Replace("\r", "");

                DependenteAluno.DP_Parentesco = DependenteAluno.DP_Parentesco.Replace("\t", "");
                DependenteAluno.DP_Parentesco = DependenteAluno.DP_Parentesco.Replace("\n", "");
                DependenteAluno.DP_Parentesco = DependenteAluno.DP_Parentesco.Replace("\r", "");

                DependenteProva.DP_Parentesco = DependenteProva.DP_Parentesco.Replace("\t", "");
                DependenteProva.DP_Parentesco = DependenteProva.DP_Parentesco.Replace("\n", "");
                DependenteProva.DP_Parentesco = DependenteProva.DP_Parentesco.Replace("\r", "");

                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                if (DependenteAluno.DP_Nome.Replace(" ", "") == DependenteProva.DP_Nome.Replace(" ", "") && DependenteAluno.DP_Parentesco.Replace(" ", "") == DependenteProva.DP_Parentesco.Replace(" ", "") && PessoaProva.Pes_Nome.Replace(" ", "") == PessoaAluno.Pes_Nome.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Dependente</br>Parente do Funcionário: " + PessoaAluno.Pes_Nome + "</br>Nome do Dependente: " + DependenteAluno.DP_Nome + "</br>Parentesco com o funcionário: " + DependenteAluno.DP_Parentesco + "</br>Data de Cadastro: " + DependenteAluno.DP_DataCadastro;
                    oErro.Err_RespostaCerta = "Dependente</br>Parente do Funcionário: " + PessoaProva.Pes_Nome + "</br>Nome do Dependente: " + DependenteProva.DP_Nome + "</br>Parentesco com o funcionário: " + DependenteProva.DP_Parentesco + "</br>Data de Cadastro: " + DependenteProva.DP_DataCadastro;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                PessoaProva = _Control.SelecionarFuncionario(DependenteProva.DP_Pessoa_Pes_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum dependente cadastrado no dia " + DependenteProva.DP_DataCadastro;
                oErro.Err_RespostaCerta = "Dependente</br>Parente do Funcionário: " + PessoaProva.Pes_Nome + "</br>Nome do Dependente: " + DependenteProva.DP_Nome + "</br>Parentesco com o funcionário: " + DependenteProva.DP_Parentesco + "</br>Data de Cadastro: " + DependenteProva.DP_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            //Dependente 4
            DependenteProva = _Control.SelecionarDependente(aProva.Pro_DadoDependete4);
            DependenteAluno = _Control.SelecionarDependenteDiaCadastro(DependenteProva.DP_DataCadastro, aEmpresa.Emp_ID);

            if (DependenteAluno != null)
            {
                PessoaProva = _Control.SelecionarPessoa(DependenteProva.DP_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarPessoa(DependenteAluno.DP_Pessoa_Pes_ID);

                DependenteAluno.DP_Nome = DependenteAluno.DP_Nome.Replace("\t", "");
                DependenteAluno.DP_Nome = DependenteAluno.DP_Nome.Replace("\n", "");
                DependenteAluno.DP_Nome = DependenteAluno.DP_Nome.Replace("\r", "");

                DependenteProva.DP_Nome = DependenteProva.DP_Nome.Replace("\t", "");
                DependenteProva.DP_Nome = DependenteProva.DP_Nome.Replace("\n", "");
                DependenteProva.DP_Nome = DependenteProva.DP_Nome.Replace("\r", "");

                DependenteAluno.DP_Parentesco = DependenteAluno.DP_Parentesco.Replace("\t", "");
                DependenteAluno.DP_Parentesco = DependenteAluno.DP_Parentesco.Replace("\n", "");
                DependenteAluno.DP_Parentesco = DependenteAluno.DP_Parentesco.Replace("\r", "");

                DependenteProva.DP_Parentesco = DependenteProva.DP_Parentesco.Replace("\t", "");
                DependenteProva.DP_Parentesco = DependenteProva.DP_Parentesco.Replace("\n", "");
                DependenteProva.DP_Parentesco = DependenteProva.DP_Parentesco.Replace("\r", "");

                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                if (DependenteAluno.DP_Nome.Replace(" ", "") == DependenteProva.DP_Nome.Replace(" ", "") && DependenteAluno.DP_Parentesco.Replace(" ", "") == DependenteProva.DP_Parentesco.Replace(" ", "") && PessoaProva.Pes_Nome.Replace(" ", "") == PessoaAluno.Pes_Nome.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Dependente</br>Parente do Funcionário: " + PessoaAluno.Pes_Nome + "</br>Nome do Dependente: " + DependenteAluno.DP_Nome + "</br>Parentesco com o funcionário: " + DependenteAluno.DP_Parentesco + "</br>Data de Cadastro: " + DependenteAluno.DP_DataCadastro;
                    oErro.Err_RespostaCerta = "Dependente</br>Parente do Funcionário: " + PessoaProva.Pes_Nome + "</br>Nome do Dependente: " + DependenteProva.DP_Nome + "</br>Parentesco com o funcionário: " + DependenteProva.DP_Parentesco + "</br>Data de Cadastro: " + DependenteProva.DP_DataCadastro;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                PessoaProva = _Control.SelecionarFuncionario(DependenteProva.DP_Pessoa_Pes_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum dependente cadastrado no dia " + DependenteProva.DP_DataCadastro;
                oErro.Err_RespostaCerta = "Dependente</br>Parente do Funcionário: " + PessoaProva.Pes_Nome + "</br>Nome do Dependente: " + DependenteProva.DP_Nome + "</br>Parentesco com o funcionário: " + DependenteProva.DP_Parentesco + "</br>Data de Cadastro: " + DependenteProva.DP_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            //Dependente 5
            DependenteProva = _Control.SelecionarDependente(aProva.Pro_DadoDependete5);
            DependenteAluno = _Control.SelecionarDependenteDiaCadastro(DependenteProva.DP_DataCadastro, aEmpresa.Emp_ID);

            if (DependenteAluno != null)
            {
                PessoaProva = _Control.SelecionarPessoa(DependenteProva.DP_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarPessoa(DependenteAluno.DP_Pessoa_Pes_ID);

                DependenteAluno.DP_Nome = DependenteAluno.DP_Nome.Replace("\t", "");
                DependenteAluno.DP_Nome = DependenteAluno.DP_Nome.Replace("\n", "");
                DependenteAluno.DP_Nome = DependenteAluno.DP_Nome.Replace("\r", "");

                DependenteProva.DP_Nome = DependenteProva.DP_Nome.Replace("\t", "");
                DependenteProva.DP_Nome = DependenteProva.DP_Nome.Replace("\n", "");
                DependenteProva.DP_Nome = DependenteProva.DP_Nome.Replace("\r", "");

                DependenteAluno.DP_Parentesco = DependenteAluno.DP_Parentesco.Replace("\t", "");
                DependenteAluno.DP_Parentesco = DependenteAluno.DP_Parentesco.Replace("\n", "");
                DependenteAluno.DP_Parentesco = DependenteAluno.DP_Parentesco.Replace("\r", "");

                DependenteProva.DP_Parentesco = DependenteProva.DP_Parentesco.Replace("\t", "");
                DependenteProva.DP_Parentesco = DependenteProva.DP_Parentesco.Replace("\n", "");
                DependenteProva.DP_Parentesco = DependenteProva.DP_Parentesco.Replace("\r", "");

                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                if (DependenteAluno.DP_Nome.Replace(" ", "") == DependenteProva.DP_Nome.Replace(" ", "") && DependenteAluno.DP_Parentesco.Replace(" ", "") == DependenteProva.DP_Parentesco.Replace(" ", "") && PessoaProva.Pes_Nome.Replace(" ", "") == PessoaAluno.Pes_Nome.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Dependente</br>Parente do Funcionário: " + PessoaAluno.Pes_Nome + "</br>Nome do Dependente: " + DependenteAluno.DP_Nome + "</br>Parentesco com o funcionário: " + DependenteAluno.DP_Parentesco + "</br>Data de Cadastro: " + DependenteAluno.DP_DataCadastro;
                    oErro.Err_RespostaCerta = "Dependente</br>Parente do Funcionário: " + PessoaProva.Pes_Nome + "</br>Nome do Dependente: " + DependenteProva.DP_Nome + "</br>Parentesco com o funcionário: " + DependenteProva.DP_Parentesco + "</br>Data de Cadastro: " + DependenteProva.DP_DataCadastro;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                PessoaProva = _Control.SelecionarFuncionario(DependenteProva.DP_Pessoa_Pes_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum dependente cadastrado no dia " + DependenteProva.DP_DataCadastro;
                oErro.Err_RespostaCerta = "Dependente</br>Parente do Funcionário: " + PessoaProva.Pes_Nome + "</br>Nome do Dependente: " + DependenteProva.DP_Nome + "</br>Parentesco com o funcionário: " + DependenteProva.DP_Parentesco + "</br>Data de Cadastro: " + DependenteProva.DP_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            //Verifica Dados Bancários

            //Dado Bancário 1
            DadoBancario DadoBancarioProva = _Control.SelecionarDadoBancario(aProva.Pro_DadoBancario1);
            DadoBancario DadoBancarioAluno = _Control.SelecionarDadoBancarioDataCadastro(DadoBancarioProva.DB_DataCadastro, aEmpresa.Emp_ID);

            if (DadoBancarioAluno != null)
            {
                PessoaProva = _Control.SelecionarPessoa(DadoBancarioProva.DB_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarPessoa(DadoBancarioAluno.DB_Pessoa_Pes_ID);

                DadoBancarioProva.DB_Numero = DadoBancarioProva.DB_Numero.Replace("\t", "");
                DadoBancarioProva.DB_Numero = DadoBancarioProva.DB_Numero.Replace("\n", "");
                DadoBancarioProva.DB_Numero = DadoBancarioProva.DB_Numero.Replace("\r", "");

                DadoBancarioAluno.DB_Numero = DadoBancarioAluno.DB_Numero.Replace("\t", "");
                DadoBancarioAluno.DB_Numero = DadoBancarioAluno.DB_Numero.Replace("\n", "");
                DadoBancarioAluno.DB_Numero = DadoBancarioAluno.DB_Numero.Replace("\r", "");

                DadoBancarioProva.DB_Tipo = DadoBancarioProva.DB_Tipo.Replace("\t", "");
                DadoBancarioProva.DB_Tipo = DadoBancarioProva.DB_Tipo.Replace("\n", "");
                DadoBancarioProva.DB_Tipo = DadoBancarioProva.DB_Tipo.Replace("\r", "");

                DadoBancarioAluno.DB_Tipo = DadoBancarioAluno.DB_Tipo.Replace("\t", "");
                DadoBancarioAluno.DB_Tipo = DadoBancarioAluno.DB_Tipo.Replace("\n", "");
                DadoBancarioAluno.DB_Tipo = DadoBancarioAluno.DB_Tipo.Replace("\r", "");

                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");



                if (DadoBancarioAluno.DB_Numero.Replace(" ","")== DadoBancarioProva.DB_Numero.Replace(" ","") && DadoBancarioAluno.DB_Tipo.Replace(" ","") == DadoBancarioProva.DB_Tipo.Replace(" ", "") && PessoaProva.Pes_Nome.Replace(" ", "") == PessoaAluno.Pes_Nome.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Dado Bancário:</br>Dado do Funcionário: " + PessoaAluno.Pes_Nome + "</br>Tipo: " + DadoBancarioAluno.DB_Tipo + "</br>Número: " + DadoBancarioAluno.DB_Numero + "</br>Data de Cadastro: " + DadoBancarioAluno.DB_DataCadastro;
                    oErro.Err_RespostaCerta = "Dado Bancário:</br>Dado do Funcionário: " + PessoaProva.Pes_Nome + "</br>Tipo: " + DadoBancarioProva.DB_Tipo + "</br>Número: " + DadoBancarioProva.DB_Numero + "</br>Data de Cadastro: " + DadoBancarioProva.DB_DataCadastro;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                PessoaProva = _Control.SelecionarFuncionario(DadoBancarioProva.DB_ID);
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum Dado Bancário cadastrado no dia " + DadoBancarioProva.DB_DataCadastro;
                oErro.Err_RespostaCerta = "Dado Bancário:</br>Dado do Funcionário: " + PessoaProva.Pes_Nome + "</br>Tipo: " + DadoBancarioProva.DB_Tipo + "</br>Número: " + DadoBancarioProva.DB_Numero + "</br>Data de Cadastro: " + DadoBancarioProva.DB_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            //Dado Bancário 2
            DadoBancarioProva = _Control.SelecionarDadoBancario(aProva.Pro_DadoBancario2);
            DadoBancarioAluno = _Control.SelecionarDadoBancarioDataCadastro(DadoBancarioProva.DB_DataCadastro, aEmpresa.Emp_ID);

            if (DadoBancarioAluno != null)
            {
                PessoaProva = _Control.SelecionarPessoa(DadoBancarioProva.DB_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarPessoa(DadoBancarioAluno.DB_Pessoa_Pes_ID);

                DadoBancarioProva.DB_Numero = DadoBancarioProva.DB_Numero.Replace("\t", "");
                DadoBancarioProva.DB_Numero = DadoBancarioProva.DB_Numero.Replace("\n", "");
                DadoBancarioProva.DB_Numero = DadoBancarioProva.DB_Numero.Replace("\r", "");

                DadoBancarioAluno.DB_Numero = DadoBancarioAluno.DB_Numero.Replace("\t", "");
                DadoBancarioAluno.DB_Numero = DadoBancarioAluno.DB_Numero.Replace("\n", "");
                DadoBancarioAluno.DB_Numero = DadoBancarioAluno.DB_Numero.Replace("\r", "");

                DadoBancarioProva.DB_Tipo = DadoBancarioProva.DB_Tipo.Replace("\t", "");
                DadoBancarioProva.DB_Tipo = DadoBancarioProva.DB_Tipo.Replace("\n", "");
                DadoBancarioProva.DB_Tipo = DadoBancarioProva.DB_Tipo.Replace("\r", "");

                DadoBancarioAluno.DB_Tipo = DadoBancarioAluno.DB_Tipo.Replace("\t", "");
                DadoBancarioAluno.DB_Tipo = DadoBancarioAluno.DB_Tipo.Replace("\n", "");
                DadoBancarioAluno.DB_Tipo = DadoBancarioAluno.DB_Tipo.Replace("\r", "");

                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                if (DadoBancarioAluno.DB_Numero.Replace(" ", "") == DadoBancarioProva.DB_Numero.Replace(" ", "") && DadoBancarioAluno.DB_Tipo.Replace(" ", "") == DadoBancarioProva.DB_Tipo.Replace(" ", "") && PessoaProva.Pes_Nome.Replace(" ", "") == PessoaAluno.Pes_Nome.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Errro no Cadastro";
                    oErro.Err_RespostaAluno = "Dado Bancário:</br>Dado do Funcionário: " + PessoaAluno.Pes_Nome + "</br>Tipo: " + DadoBancarioAluno.DB_Tipo + "</br>Número: " + DadoBancarioAluno.DB_Numero + "</br>Data de Cadastro: " + DadoBancarioAluno.DB_DataCadastro;
                    oErro.Err_RespostaCerta = "Dado Bancário:</br>Dado do Funcionário: " + PessoaProva.Pes_Nome + "</br>Tipo: " + DadoBancarioProva.DB_Tipo + "</br>Número: " + DadoBancarioProva.DB_Numero + "</br>Data de Cadastro: " + DadoBancarioProva.DB_DataCadastro;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                PessoaProva = _Control.SelecionarFuncionario(DadoBancarioProva.DB_ID);
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum Dado Bancário cadastrado no dia " + DadoBancarioProva.DB_DataCadastro;
                oErro.Err_RespostaCerta = "Dado Bancário:</br>Dado do Funcionário: " + PessoaProva.Pes_Nome + "</br>Tipo: " + DadoBancarioProva.DB_Tipo + "</br>Número: " + DadoBancarioProva.DB_Numero + "</br>Data de Cadastro: " + DadoBancarioProva.DB_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            //Dado Bancário 3
            DadoBancarioProva = _Control.SelecionarDadoBancario(aProva.Pro_DadoBancario3);
            DadoBancarioAluno = _Control.SelecionarDadoBancarioDataCadastro(DadoBancarioProva.DB_DataCadastro, aEmpresa.Emp_ID);

            if (DadoBancarioAluno != null)
            {
                PessoaProva = _Control.SelecionarPessoa(DadoBancarioProva.DB_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarPessoa(DadoBancarioAluno.DB_Pessoa_Pes_ID);

                DadoBancarioProva.DB_Numero = DadoBancarioProva.DB_Numero.Replace("\t", "");
                DadoBancarioProva.DB_Numero = DadoBancarioProva.DB_Numero.Replace("\n", "");
                DadoBancarioProva.DB_Numero = DadoBancarioProva.DB_Numero.Replace("\r", "");

                DadoBancarioAluno.DB_Numero = DadoBancarioAluno.DB_Numero.Replace("\t", "");
                DadoBancarioAluno.DB_Numero = DadoBancarioAluno.DB_Numero.Replace("\n", "");
                DadoBancarioAluno.DB_Numero = DadoBancarioAluno.DB_Numero.Replace("\r", "");

                DadoBancarioProva.DB_Tipo = DadoBancarioProva.DB_Tipo.Replace("\t", "");
                DadoBancarioProva.DB_Tipo = DadoBancarioProva.DB_Tipo.Replace("\n", "");
                DadoBancarioProva.DB_Tipo = DadoBancarioProva.DB_Tipo.Replace("\r", "");

                DadoBancarioAluno.DB_Tipo = DadoBancarioAluno.DB_Tipo.Replace("\t", "");
                DadoBancarioAluno.DB_Tipo = DadoBancarioAluno.DB_Tipo.Replace("\n", "");
                DadoBancarioAluno.DB_Tipo = DadoBancarioAluno.DB_Tipo.Replace("\r", "");

                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                if (DadoBancarioAluno.DB_Numero.Replace(" ", "") == DadoBancarioProva.DB_Numero.Replace(" ", "") && DadoBancarioAluno.DB_Tipo.Replace(" ", "") == DadoBancarioProva.DB_Tipo.Replace(" ", "") && PessoaProva.Pes_Nome.Replace(" ", "") == PessoaAluno.Pes_Nome.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Dado Bancário:</br>Dado do Funcionário: " + PessoaAluno.Pes_Nome + "</br>Tipo: " + DadoBancarioAluno.DB_Tipo + "</br>Número: " + DadoBancarioAluno.DB_Numero + "</br>Data de Cadastro: " + DadoBancarioAluno.DB_DataCadastro;
                    oErro.Err_RespostaCerta = "Dado Bancário:</br>Dado do Funcionário: " + PessoaProva.Pes_Nome + "</br>Tipo: " + DadoBancarioProva.DB_Tipo + "</br>Número: " + DadoBancarioProva.DB_Numero + "</br>Data de Cadastro: " + DadoBancarioProva.DB_DataCadastro;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                PessoaProva = _Control.SelecionarFuncionario(DadoBancarioProva.DB_ID);
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum Dado Bancário cadastrado no dia " + DadoBancarioProva.DB_DataCadastro;
                oErro.Err_RespostaCerta = "Dado Bancário:</br>Dado do Funcionário: " + PessoaProva.Pes_Nome + "</br>Tipo: " + DadoBancarioProva.DB_Tipo + "</br>Número: " + DadoBancarioProva.DB_Numero + "</br>Data de Cadastro: " + DadoBancarioProva.DB_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            //Dado Bancário 4
            DadoBancarioProva = _Control.SelecionarDadoBancario(aProva.Pro_DadoBancario4);
            DadoBancarioAluno = _Control.SelecionarDadoBancarioDataCadastro(DadoBancarioProva.DB_DataCadastro, aEmpresa.Emp_ID);

            if (DadoBancarioAluno != null)
            {
                PessoaProva = _Control.SelecionarPessoa(DadoBancarioProva.DB_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarPessoa(DadoBancarioAluno.DB_Pessoa_Pes_ID);

                DadoBancarioProva.DB_Numero = DadoBancarioProva.DB_Numero.Replace("\t", "");
                DadoBancarioProva.DB_Numero = DadoBancarioProva.DB_Numero.Replace("\n", "");
                DadoBancarioProva.DB_Numero = DadoBancarioProva.DB_Numero.Replace("\r", "");

                DadoBancarioAluno.DB_Numero = DadoBancarioAluno.DB_Numero.Replace("\t", "");
                DadoBancarioAluno.DB_Numero = DadoBancarioAluno.DB_Numero.Replace("\n", "");
                DadoBancarioAluno.DB_Numero = DadoBancarioAluno.DB_Numero.Replace("\r", "");

                DadoBancarioProva.DB_Tipo = DadoBancarioProva.DB_Tipo.Replace("\t", "");
                DadoBancarioProva.DB_Tipo = DadoBancarioProva.DB_Tipo.Replace("\n", "");
                DadoBancarioProva.DB_Tipo = DadoBancarioProva.DB_Tipo.Replace("\r", "");

                DadoBancarioAluno.DB_Tipo = DadoBancarioAluno.DB_Tipo.Replace("\t", "");
                DadoBancarioAluno.DB_Tipo = DadoBancarioAluno.DB_Tipo.Replace("\n", "");
                DadoBancarioAluno.DB_Tipo = DadoBancarioAluno.DB_Tipo.Replace("\r", "");

                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                if (DadoBancarioAluno.DB_Numero.Replace(" ", "") == DadoBancarioProva.DB_Numero.Replace(" ", "") && DadoBancarioAluno.DB_Tipo.Replace(" ", "") == DadoBancarioProva.DB_Tipo.Replace(" ", "") && PessoaProva.Pes_Nome.Replace(" ", "") == PessoaAluno.Pes_Nome.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Dado Bancário:</br>Dado do Funcionário: " + PessoaAluno.Pes_Nome + "</br>Tipo: " + DadoBancarioAluno.DB_Tipo + "</br>Número: " + DadoBancarioAluno.DB_Numero + "</br>Data de Cadastro: " + DadoBancarioAluno.DB_DataCadastro;
                    oErro.Err_RespostaCerta = "Dado Bancário:</br>Dado do Funcionário: " + PessoaProva.Pes_Nome + "</br>Tipo: " + DadoBancarioProva.DB_Tipo + "</br>Número: " + DadoBancarioProva.DB_Numero + "</br>Data de Cadastro: " + DadoBancarioProva.DB_DataCadastro;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                PessoaProva = _Control.SelecionarFuncionario(DadoBancarioProva.DB_ID);
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum Dado Bancário cadastrado no dia " + DadoBancarioProva.DB_DataCadastro;
                oErro.Err_RespostaCerta = "Dado Bancário:</br>Dado do Funcionário: " + PessoaProva.Pes_Nome + "</br>Tipo: " + DadoBancarioProva.DB_Tipo + "</br>Número: " + DadoBancarioProva.DB_Numero + "</br>Data de Cadastro: " + DadoBancarioProva.DB_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            //Dado Bancário 5
            DadoBancarioProva = _Control.SelecionarDadoBancario(aProva.Pro_DadoBancario5);
            DadoBancarioAluno = _Control.SelecionarDadoBancarioDataCadastro(DadoBancarioProva.DB_DataCadastro, aEmpresa.Emp_ID);

            if (DadoBancarioAluno != null)
            {
                PessoaProva = _Control.SelecionarPessoa(DadoBancarioProva.DB_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarPessoa(DadoBancarioAluno.DB_Pessoa_Pes_ID);

                DadoBancarioProva.DB_Numero = DadoBancarioProva.DB_Numero.Replace("\t", "");
                DadoBancarioProva.DB_Numero = DadoBancarioProva.DB_Numero.Replace("\n", "");
                DadoBancarioProva.DB_Numero = DadoBancarioProva.DB_Numero.Replace("\r", "");

                DadoBancarioAluno.DB_Numero = DadoBancarioAluno.DB_Numero.Replace("\t", "");
                DadoBancarioAluno.DB_Numero = DadoBancarioAluno.DB_Numero.Replace("\n", "");
                DadoBancarioAluno.DB_Numero = DadoBancarioAluno.DB_Numero.Replace("\r", "");

                DadoBancarioProva.DB_Tipo = DadoBancarioProva.DB_Tipo.Replace("\t", "");
                DadoBancarioProva.DB_Tipo = DadoBancarioProva.DB_Tipo.Replace("\n", "");
                DadoBancarioProva.DB_Tipo = DadoBancarioProva.DB_Tipo.Replace("\r", "");

                DadoBancarioAluno.DB_Tipo = DadoBancarioAluno.DB_Tipo.Replace("\t", "");
                DadoBancarioAluno.DB_Tipo = DadoBancarioAluno.DB_Tipo.Replace("\n", "");
                DadoBancarioAluno.DB_Tipo = DadoBancarioAluno.DB_Tipo.Replace("\r", "");

                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                if (DadoBancarioAluno.DB_Numero.Replace(" ", "") == DadoBancarioProva.DB_Numero.Replace(" ", "") && DadoBancarioAluno.DB_Tipo.Replace(" ", "") == DadoBancarioProva.DB_Tipo.Replace(" ", "") && PessoaProva.Pes_Nome.Replace(" ", "") == PessoaAluno.Pes_Nome.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Dado Bancário:</br>Dado do Funcionário: " + PessoaAluno.Pes_Nome + "</br>Tipo: " + DadoBancarioAluno.DB_Tipo + "</br>Número: " + DadoBancarioAluno.DB_Numero + "</br>Data de Cadastro: " + DadoBancarioAluno.DB_DataCadastro;
                    oErro.Err_RespostaCerta = "Dado Bancário:</br>Dado do Funcionário: " + PessoaProva.Pes_Nome + "</br>Tipo: " + DadoBancarioProva.DB_Tipo + "</br>Número: " + DadoBancarioProva.DB_Numero + "</br>Data de Cadastro: " + DadoBancarioProva.DB_DataCadastro;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                PessoaProva = _Control.SelecionarFuncionario(DadoBancarioProva.DB_ID);
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum Dado Bancário cadastrado no dia " + DadoBancarioProva.DB_DataCadastro;
                oErro.Err_RespostaCerta = "Dado Bancário:</br>Dado do Funcionário: " + PessoaProva.Pes_Nome + "</br>Tipo: " + DadoBancarioProva.DB_Tipo + "</br>Número: " + DadoBancarioProva.DB_Numero + "</br>Data de Cadastro: " + DadoBancarioProva.DB_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            //Verifica Benefícios
            List<Beneficio> BeneficiosAluno = _Control.SelecionarBeneficiosAluno(aEmpresa.Emp_ID);
            bool Acertou = false;

            //Benefício 1
            Beneficio oBeneficio = _Control.SelecionarBeneficio(aProva.Pro_Beneficio1);

            oBeneficio.Ben_Nome = oBeneficio.Ben_Nome.Replace("\t", "");
            oBeneficio.Ben_Nome = oBeneficio.Ben_Nome.Replace("\n", "");
            oBeneficio.Ben_Nome = oBeneficio.Ben_Nome.Replace("\r", "");

            oBeneficio.Ben_Descricao = oBeneficio.Ben_Descricao.Replace("\t", "");
            oBeneficio.Ben_Descricao = oBeneficio.Ben_Descricao.Replace("\n", "");
            oBeneficio.Ben_Descricao = oBeneficio.Ben_Descricao.Replace("\r", "");

            foreach (var x in BeneficiosAluno)
            {
                x.Ben_Nome = x.Ben_Nome.Replace("\t", "");
                x.Ben_Nome = x.Ben_Nome.Replace("\n", "");
                x.Ben_Nome = x.Ben_Nome.Replace("\r", "");

                x.Ben_Descricao = x.Ben_Descricao.Replace("\t", "");
                x.Ben_Descricao = x.Ben_Descricao.Replace("\n", "");
                x.Ben_Descricao = x.Ben_Descricao.Replace("\r", "");

                if (oBeneficio.Ben_Nome.Replace(" ","")==x.Ben_Nome.Replace(" ","") && oBeneficio.Ben_Descricao.Replace(" ","").Replace("\n","").Replace("\r","")==x.Ben_Descricao.Replace(" ", "").Replace("\n", "").Replace("\r", "") && oBeneficio.Ben_Custo==x.Ben_Custo && oBeneficio.Ben_DataCadastro==x.Ben_DataCadastro)
                {
                    Nota = Nota + 0.2;
                    Acertou = true;
                    break;
                }
            }

            if(!Acertou)
            {
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Erro no Cadastro";
                oErro.Err_RespostaAluno = "Nenhum dos seus benefícios cadastrados se compara ao benefício da prova.";
                oErro.Err_RespostaCerta = "Benefício:</br>Nome do Benefício: " + oBeneficio.Ben_Nome + "</br>Descrição: " + oBeneficio.Ben_Descricao + "</br>Custo: " + oBeneficio.Ben_Custo + "R$</br>Data de Cadastro: " + oBeneficio.Ben_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            Acertou = false;

            //Benefício 2
            oBeneficio = _Control.SelecionarBeneficio(aProva.Pro_Beneficio2);

            oBeneficio.Ben_Nome = oBeneficio.Ben_Nome.Replace("\t", "");
            oBeneficio.Ben_Nome = oBeneficio.Ben_Nome.Replace("\n", "");
            oBeneficio.Ben_Nome = oBeneficio.Ben_Nome.Replace("\r", "");

            oBeneficio.Ben_Descricao = oBeneficio.Ben_Descricao.Replace("\t", "");
            oBeneficio.Ben_Descricao = oBeneficio.Ben_Descricao.Replace("\n", "");
            oBeneficio.Ben_Descricao = oBeneficio.Ben_Descricao.Replace("\r", "");

            foreach (var x in BeneficiosAluno)
            {
                x.Ben_Nome = x.Ben_Nome.Replace("\t", "");
                x.Ben_Nome = x.Ben_Nome.Replace("\n", "");
                x.Ben_Nome = x.Ben_Nome.Replace("\r", "");

                x.Ben_Descricao = x.Ben_Descricao.Replace("\t", "");
                x.Ben_Descricao = x.Ben_Descricao.Replace("\n", "");
                x.Ben_Descricao = x.Ben_Descricao.Replace("\r", "");

                if (oBeneficio.Ben_Nome.Replace(" ", "") == x.Ben_Nome.Replace(" ", "") && oBeneficio.Ben_Descricao.Replace(" ", "").Replace("\n", "").Replace("\r", "") == x.Ben_Descricao.Replace(" ", "").Replace("\n", "").Replace("\r", "") && oBeneficio.Ben_Custo == x.Ben_Custo && oBeneficio.Ben_DataCadastro == x.Ben_DataCadastro)
                {
                    Nota = Nota + 0.2;
                    Acertou = true;
                    break;
                }
            }

            if (!Acertou)
            {
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Erro no Cadastro";
                oErro.Err_RespostaAluno = "Nenhum dos seus benefícios cadastrados se compara ao benefício da prova.";
                oErro.Err_RespostaCerta = "Benefício:</br>Nome do Benefício: " + oBeneficio.Ben_Nome + "</br>Descrição: " + oBeneficio.Ben_Descricao + "</br>Custo: " + oBeneficio.Ben_Custo + "R$</br>Data de Cadastro: " + oBeneficio.Ben_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            Acertou = false;

            //Benefício 3
            oBeneficio = _Control.SelecionarBeneficio(aProva.Pro_Beneficio3);

            oBeneficio.Ben_Nome = oBeneficio.Ben_Nome.Replace("\t", "");
            oBeneficio.Ben_Nome = oBeneficio.Ben_Nome.Replace("\n", "");
            oBeneficio.Ben_Nome = oBeneficio.Ben_Nome.Replace("\r", "");

            oBeneficio.Ben_Descricao = oBeneficio.Ben_Descricao.Replace("\t", "");
            oBeneficio.Ben_Descricao = oBeneficio.Ben_Descricao.Replace("\n", "");
            oBeneficio.Ben_Descricao = oBeneficio.Ben_Descricao.Replace("\r", "");

            foreach (var x in BeneficiosAluno)
            {
                x.Ben_Nome = x.Ben_Nome.Replace("\t", "");
                x.Ben_Nome = x.Ben_Nome.Replace("\n", "");
                x.Ben_Nome = x.Ben_Nome.Replace("\r", "");

                x.Ben_Descricao = x.Ben_Descricao.Replace("\t", "");
                x.Ben_Descricao = x.Ben_Descricao.Replace("\n", "");
                x.Ben_Descricao = x.Ben_Descricao.Replace("\r", "");

                if (oBeneficio.Ben_Nome.Replace(" ", "") == x.Ben_Nome.Replace(" ", "") && oBeneficio.Ben_Descricao.Replace(" ", "").Replace("\n", "").Replace("\r", "") == x.Ben_Descricao.Replace(" ", "").Replace("\n", "").Replace("\r", "") && oBeneficio.Ben_Custo == x.Ben_Custo && oBeneficio.Ben_DataCadastro == x.Ben_DataCadastro)
                {
                    Nota = Nota + 0.2;
                    Acertou = true;
                    break;
                }
            }

            if (!Acertou)
            {
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Erro no Cadastro";
                oErro.Err_RespostaAluno = "Nenhum dos seus benefícios cadastrados se compara ao benefício da prova.";
                oErro.Err_RespostaCerta = "Benefício:</br>Nome do Benefício: " + oBeneficio.Ben_Nome + "</br>Descrição: " + oBeneficio.Ben_Descricao + "</br>Custo: " + oBeneficio.Ben_Custo + "R$</br>Data de Cadastro: " + oBeneficio.Ben_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            Acertou = false;

            //Benefício 4
            oBeneficio = _Control.SelecionarBeneficio(aProva.Pro_Beneficio4);

            oBeneficio.Ben_Nome = oBeneficio.Ben_Nome.Replace("\t", "");
            oBeneficio.Ben_Nome = oBeneficio.Ben_Nome.Replace("\n", "");
            oBeneficio.Ben_Nome = oBeneficio.Ben_Nome.Replace("\r", "");

            oBeneficio.Ben_Descricao = oBeneficio.Ben_Descricao.Replace("\t", "");
            oBeneficio.Ben_Descricao = oBeneficio.Ben_Descricao.Replace("\n", "");
            oBeneficio.Ben_Descricao = oBeneficio.Ben_Descricao.Replace("\r", "");

            foreach (var x in BeneficiosAluno)
            {
                x.Ben_Nome = x.Ben_Nome.Replace("\t", "");
                x.Ben_Nome = x.Ben_Nome.Replace("\n", "");
                x.Ben_Nome = x.Ben_Nome.Replace("\r", "");

                x.Ben_Descricao = x.Ben_Descricao.Replace("\t", "");
                x.Ben_Descricao = x.Ben_Descricao.Replace("\n", "");
                x.Ben_Descricao = x.Ben_Descricao.Replace("\r", "");

                if (oBeneficio.Ben_Nome.Replace(" ", "") == x.Ben_Nome.Replace(" ", "") && oBeneficio.Ben_Descricao.Replace(" ", "").Replace("\n", "").Replace("\r", "") == x.Ben_Descricao.Replace(" ", "").Replace("\n", "").Replace("\r", "") && oBeneficio.Ben_Custo == x.Ben_Custo && oBeneficio.Ben_DataCadastro == x.Ben_DataCadastro)
                {
                    Nota = Nota + 0.2;
                    Acertou = true;
                    break;
                }
            }

            if (!Acertou)
            {
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Erro no Cadastro";
                oErro.Err_RespostaAluno = "Nenhum dos seus benefícios cadastrados se compara ao benefício da prova.";
                oErro.Err_RespostaCerta = "Benefício:</br>Nome do Benefício: " + oBeneficio.Ben_Nome + "</br>Descrição: " + oBeneficio.Ben_Descricao + "</br>Custo: " + oBeneficio.Ben_Custo + "R$</br>Data de Cadastro: " + oBeneficio.Ben_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            Acertou = false;

            //Benefício 5
            oBeneficio = _Control.SelecionarBeneficio(aProva.Pro_Beneficio5);

            oBeneficio.Ben_Nome = oBeneficio.Ben_Nome.Replace("\t", "");
            oBeneficio.Ben_Nome = oBeneficio.Ben_Nome.Replace("\n", "");
            oBeneficio.Ben_Nome = oBeneficio.Ben_Nome.Replace("\r", "");

            oBeneficio.Ben_Descricao = oBeneficio.Ben_Descricao.Replace("\t", "");
            oBeneficio.Ben_Descricao = oBeneficio.Ben_Descricao.Replace("\n", "");
            oBeneficio.Ben_Descricao = oBeneficio.Ben_Descricao.Replace("\r", "");

            foreach (var x in BeneficiosAluno)
            {
                x.Ben_Nome = x.Ben_Nome.Replace("\t", "");
                x.Ben_Nome = x.Ben_Nome.Replace("\n", "");
                x.Ben_Nome = x.Ben_Nome.Replace("\r", "");

                x.Ben_Descricao = x.Ben_Descricao.Replace("\t", "");
                x.Ben_Descricao = x.Ben_Descricao.Replace("\n", "");
                x.Ben_Descricao = x.Ben_Descricao.Replace("\r", "");

                if (oBeneficio.Ben_Nome.Replace(" ", "") == x.Ben_Nome.Replace(" ", "") && oBeneficio.Ben_Descricao.Replace(" ", "").Replace("\n", "").Replace("\r", "") == x.Ben_Descricao.Replace(" ", "").Replace("\n", "").Replace("\r", "") && oBeneficio.Ben_Custo == x.Ben_Custo && oBeneficio.Ben_DataCadastro == x.Ben_DataCadastro)
                {
                    Nota = Nota + 0.2;
                    Acertou = true;
                    break;
                }
            }

            if (!Acertou)
            {
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Erro no Cadastro";
                oErro.Err_RespostaAluno = "Nenhum dos seus benefícios cadastrados se compara ao benefício da prova.";
                oErro.Err_RespostaCerta = "Benefício:</br>Nome do Benefício: " + oBeneficio.Ben_Nome + "</br>Descrição: " + oBeneficio.Ben_Descricao + "</br>Custo: " + oBeneficio.Ben_Custo + "R$</br>Data de Cadastro: " + oBeneficio.Ben_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            Acertou = false;

            //Verifica Benefícios do Funcionário

            //Verifica Benefícios 1

            PessoaBeneficio BeneficioProva = _Control.SelecionarBeneficioFuncionario(aProva.Pro_BeneficioFuncionario1);
            List<PessoaBeneficio> BeneficiosFuncionarioAluno = _Control.SelecionarBeneficiosFuncionarioDiaCadastro(BeneficioProva.PB_DataCadastro, aEmpresa.Emp_ID);
            Beneficio BeneficioAluno = new Beneficio();
            Beneficio oBeneficioProva = new Beneficio();

            if (BeneficiosFuncionarioAluno != null)
            {
                foreach (var x in BeneficiosFuncionarioAluno)
                {
                    PessoaAluno = _Control.SelecionarPessoa(x.PB_Pessoa_Pes_ID);
                    PessoaProva = _Control.SelecionarPessoa(BeneficioProva.PB_Pessoa_Pes_ID);
                    BeneficioAluno = _Control.SelecionarBeneficio(x.PB_Beneficio_Ben_ID);
                    oBeneficioProva = _Control.SelecionarBeneficio(BeneficioProva.PB_Beneficio_Ben_ID);

                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\t", "");
                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\n", "");
                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\r", "");

                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\t", "");
                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\n", "");
                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\r", "");

                    if (PessoaAluno.Pes_Nome.Replace(" ", "") == PessoaProva.Pes_Nome.Replace(" ", "") && BeneficioAluno.Ben_Nome.Replace(" ", "") == oBeneficioProva.Ben_Nome.Replace(" ", ""))
                    {
                        Nota = Nota + 0.2;
                        Acertou = true;
                        break;
                    }
                }

                if (!Acertou)
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Err_RespostaAluno = "Nenhum dos seus benefícios de funcionários cadastrados se compara ao benefício de funcionário da prova.";
                    oErro.Err_RespostaCerta = "Benefíco Funcionário</br>Funcionário: " + PessoaProva.Pes_Nome + "</br>Benefício: " + oBeneficioProva.Ben_Nome + "</br>Data de Cadastro: " + BeneficioProva.PB_DataCadastro;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum cadastro de benefíco de funcionário no dia " + BeneficioProva.PB_DataCadastro;
                oErro.Err_RespostaCerta = "Benefíco Funcionário</br>Funcionário: " + PessoaProva.Pes_Nome + "</br>Benefício: " + oBeneficioProva.Ben_Nome + "</br>Data de Cadastro: " + BeneficioProva.PB_DataCadastro;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                _Control.CadastrarErro(oErro);
            }

            Acertou = false;

            //Verifica Benefíco 2

            BeneficioProva = _Control.SelecionarBeneficioFuncionario(aProva.Pro_BeneficioFuncionario2);
            BeneficiosFuncionarioAluno = _Control.SelecionarBeneficiosFuncionarioDiaCadastro(BeneficioProva.PB_DataCadastro, aEmpresa.Emp_ID);

            if (BeneficiosFuncionarioAluno != null)
            {
                foreach (var x in BeneficiosFuncionarioAluno)
                {
                    PessoaAluno = _Control.SelecionarPessoa(x.PB_Pessoa_Pes_ID);
                    PessoaProva = _Control.SelecionarPessoa(BeneficioProva.PB_Pessoa_Pes_ID);
                    BeneficioAluno = _Control.SelecionarBeneficio(x.PB_Beneficio_Ben_ID);
                    oBeneficioProva = _Control.SelecionarBeneficio(BeneficioProva.PB_Beneficio_Ben_ID);

                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\t", "");
                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\n", "");
                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\r", "");

                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\t", "");
                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\n", "");
                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\r", "");

                    if (PessoaAluno.Pes_Nome.Replace(" ", "") == PessoaProva.Pes_Nome.Replace(" ", "") && BeneficioAluno.Ben_Nome.Replace(" ", "") == oBeneficioProva.Ben_Nome.Replace(" ", ""))
                    {
                        Nota = Nota + 0.2;
                        Acertou = true;
                        break;
                    }
                }

                if (!Acertou)
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Err_RespostaAluno = "Nenhum dos seus benefícios de funcionários cadastrados se compara ao benefício de funcionário da prova.";
                    oErro.Err_RespostaCerta = "Benefíco Funcionário</br>Funcionário: " + PessoaProva.Pes_Nome + "</br>Benefício: " + oBeneficioProva.Ben_Nome + "</br>Data de Cadastro: " + BeneficioProva.PB_DataCadastro;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum cadastro de benefíco de funcionário no dia " + BeneficioProva.PB_DataCadastro;
                oErro.Err_RespostaCerta = "Benefíco Funcionário</br>Funcionário: " + PessoaProva.Pes_Nome + "</br>Benefício: " + oBeneficioProva.Ben_Nome + "</br>Data de Cadastro: " + BeneficioProva.PB_DataCadastro;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                _Control.CadastrarErro(oErro);
            }

            Acertou = false;

            //Verifica Benefíco 3

            BeneficioProva = _Control.SelecionarBeneficioFuncionario(aProva.Pro_BeneficioFuncionario3);
            BeneficiosFuncionarioAluno = _Control.SelecionarBeneficiosFuncionarioDiaCadastro(BeneficioProva.PB_DataCadastro, aEmpresa.Emp_ID);

            if (BeneficiosFuncionarioAluno != null)
            {
                foreach (var x in BeneficiosFuncionarioAluno)
                {
                    PessoaAluno = _Control.SelecionarPessoa(x.PB_Pessoa_Pes_ID);
                    PessoaProva = _Control.SelecionarPessoa(BeneficioProva.PB_Pessoa_Pes_ID);
                    BeneficioAluno = _Control.SelecionarBeneficio(x.PB_Beneficio_Ben_ID);
                    oBeneficioProva = _Control.SelecionarBeneficio(BeneficioProva.PB_Beneficio_Ben_ID);

                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\t", "");
                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\n", "");
                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\r", "");

                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\t", "");
                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\n", "");
                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\r", "");

                    if (PessoaAluno.Pes_Nome.Replace(" ", "") == PessoaProva.Pes_Nome.Replace(" ", "") && BeneficioAluno.Ben_Nome.Replace(" ", "") == oBeneficioProva.Ben_Nome.Replace(" ", ""))
                    {
                        Nota = Nota + 0.2;
                        Acertou = true;
                        break;
                    }
                }

                if (!Acertou)
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Err_RespostaAluno = "Nenhum dos seus benefícios de funcionários cadastrados se compara ao benefício de funcionário da prova.";
                    oErro.Err_RespostaCerta = "Benefíco Funcionário</br>Funcionário: " + PessoaProva.Pes_Nome + "</br>Benefício: " + oBeneficioProva.Ben_Nome + "</br>Data de Cadastro: " + BeneficioProva.PB_DataCadastro;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum cadastro de benefíco de funcionário no dia " + BeneficioProva.PB_DataCadastro;
                oErro.Err_RespostaCerta = "Benefíco Funcionário</br>Funcionário: " + PessoaProva.Pes_Nome + "</br>Benefício: " + oBeneficioProva.Ben_Nome + "</br>Data de Cadastro: " + BeneficioProva.PB_DataCadastro;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                _Control.CadastrarErro(oErro);
            }

            Acertou = false;

            //Verifica Benefíco 4

            BeneficioProva = _Control.SelecionarBeneficioFuncionario(aProva.Pro_BeneficioFuncionario4);
            BeneficiosFuncionarioAluno = _Control.SelecionarBeneficiosFuncionarioDiaCadastro(BeneficioProva.PB_DataCadastro, aEmpresa.Emp_ID);

            if (BeneficiosFuncionarioAluno != null)
            {
                foreach (var x in BeneficiosFuncionarioAluno)
                {
                    PessoaAluno = _Control.SelecionarPessoa(x.PB_Pessoa_Pes_ID);
                    PessoaProva = _Control.SelecionarPessoa(BeneficioProva.PB_Pessoa_Pes_ID);
                    BeneficioAluno = _Control.SelecionarBeneficio(x.PB_Beneficio_Ben_ID);
                    oBeneficioProva = _Control.SelecionarBeneficio(BeneficioProva.PB_Beneficio_Ben_ID);

                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\t", "");
                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\n", "");
                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\r", "");

                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\t", "");
                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\n", "");
                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\r", "");

                    if (PessoaAluno.Pes_Nome.Replace(" ", "") == PessoaProva.Pes_Nome.Replace(" ", "") && BeneficioAluno.Ben_Nome.Replace(" ", "") == oBeneficioProva.Ben_Nome.Replace(" ", ""))
                    {
                        Nota = Nota + 0.2;
                        Acertou = true;
                        break;
                    }
                }

                if (!Acertou)
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Err_RespostaAluno = "Nenhum dos seus benefícios de funcionários cadastrados se compara ao benefício de funcionário da prova.";
                    oErro.Err_RespostaCerta = "Benefíco Funcionário</br>Funcionário: " + PessoaProva.Pes_Nome + "</br>Benefício: " + oBeneficioProva.Ben_Nome + "</br>Data de Cadastro: " + BeneficioProva.PB_DataCadastro;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum cadastro de benefíco de funcionário no dia " + BeneficioProva.PB_DataCadastro;
                oErro.Err_RespostaCerta = "Benefíco Funcionário</br>Funcionário: " + PessoaProva.Pes_Nome + "</br>Benefício: " + oBeneficioProva.Ben_Nome + "</br>Data de Cadastro: " + BeneficioProva.PB_DataCadastro;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                _Control.CadastrarErro(oErro);
            }

            Acertou = false;

            //Verifica Benefíco 5

            BeneficioProva = _Control.SelecionarBeneficioFuncionario(aProva.Pro_BeneficioFuncionario5);
            BeneficiosFuncionarioAluno = _Control.SelecionarBeneficiosFuncionarioDiaCadastro(BeneficioProva.PB_DataCadastro, aEmpresa.Emp_ID);

            if (BeneficiosFuncionarioAluno != null)
            {
                foreach (var x in BeneficiosFuncionarioAluno)
                {
                    PessoaAluno = _Control.SelecionarPessoa(x.PB_Pessoa_Pes_ID);
                    PessoaProva = _Control.SelecionarPessoa(BeneficioProva.PB_Pessoa_Pes_ID);
                    BeneficioAluno = _Control.SelecionarBeneficio(x.PB_Beneficio_Ben_ID);
                    oBeneficioProva = _Control.SelecionarBeneficio(BeneficioProva.PB_Beneficio_Ben_ID);

                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\t", "");
                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\n", "");
                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\r", "");

                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\t", "");
                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\n", "");
                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\r", "");

                    if (PessoaAluno.Pes_Nome.Replace(" ", "") == PessoaProva.Pes_Nome.Replace(" ", "") && BeneficioAluno.Ben_Nome.Replace(" ", "") == oBeneficioProva.Ben_Nome.Replace(" ", ""))
                    {
                        Nota = Nota + 0.2;
                        Acertou = true;
                        break;
                    }
                }

                if (!Acertou)
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Err_RespostaAluno = "Nenhum dos seus benefícios de funcionários cadastrados se compara ao benefício de funcionário da prova.";
                    oErro.Err_RespostaCerta = "Benefíco Funcionário</br>Funcionário: " + PessoaProva.Pes_Nome + "</br>Benefício: " + oBeneficioProva.Ben_Nome + "</br>Data de Cadastro: " + BeneficioProva.PB_DataCadastro;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum cadastro de benefíco de funcionário no dia " + BeneficioProva.PB_DataCadastro;
                oErro.Err_RespostaCerta = "Benefíco Funcionário</br>Funcionário: " + PessoaProva.Pes_Nome + "</br>Benefício: " + oBeneficioProva.Ben_Nome + "</br>Data de Cadastro: " + BeneficioProva.PB_DataCadastro;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                _Control.CadastrarErro(oErro);
            }

            Acertou = false;

            //Verifica Benefíco 6

            BeneficioProva = _Control.SelecionarBeneficioFuncionario(aProva.Pro_BenefcioFuncionario6);
            BeneficiosFuncionarioAluno = _Control.SelecionarBeneficiosFuncionarioDiaCadastro(BeneficioProva.PB_DataCadastro, aEmpresa.Emp_ID);

            if (BeneficiosFuncionarioAluno != null)
            {
                foreach (var x in BeneficiosFuncionarioAluno)
                {
                    PessoaAluno = _Control.SelecionarPessoa(x.PB_Pessoa_Pes_ID);
                    PessoaProva = _Control.SelecionarPessoa(BeneficioProva.PB_Pessoa_Pes_ID);
                    BeneficioAluno = _Control.SelecionarBeneficio(x.PB_Beneficio_Ben_ID);
                    oBeneficioProva = _Control.SelecionarBeneficio(BeneficioProva.PB_Beneficio_Ben_ID);

                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\t", "");
                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\n", "");
                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\r", "");

                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\t", "");
                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\n", "");
                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\r", "");

                    if (PessoaAluno.Pes_Nome.Replace(" ", "") == PessoaProva.Pes_Nome.Replace(" ", "") && BeneficioAluno.Ben_Nome.Replace(" ", "") == oBeneficioProva.Ben_Nome.Replace(" ", ""))
                    {
                        Nota = Nota + 0.2;
                        Acertou = true;
                        break;
                    }
                }

                if (!Acertou)
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Err_RespostaAluno = "Nenhum dos seus benefícios de funcionários cadastrados se compara ao benefício de funcionário da prova.";
                    oErro.Err_RespostaCerta = "Benefíco Funcionário</br>Funcionário: " + PessoaProva.Pes_Nome + "</br>Benefício: " + oBeneficioProva.Ben_Nome + "</br>Data de Cadastro: " + BeneficioProva.PB_DataCadastro;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum cadastro de benefíco de funcionário no dia " + BeneficioProva.PB_DataCadastro;
                oErro.Err_RespostaCerta = "Benefíco Funcionário</br>Funcionário: " + PessoaProva.Pes_Nome + "</br>Benefício: " + oBeneficioProva.Ben_Nome + "</br>Data de Cadastro: " + BeneficioProva.PB_DataCadastro;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                _Control.CadastrarErro(oErro);
            }

            Acertou = false;

            //Verifica Benefíco 7

            BeneficioProva = _Control.SelecionarBeneficioFuncionario(aProva.Pro_BeneficioFuncionario7);
            BeneficiosFuncionarioAluno = _Control.SelecionarBeneficiosFuncionarioDiaCadastro(BeneficioProva.PB_DataCadastro, aEmpresa.Emp_ID);

            if (BeneficiosFuncionarioAluno != null)
            {
                foreach (var x in BeneficiosFuncionarioAluno)
                {
                    PessoaAluno = _Control.SelecionarPessoa(x.PB_Pessoa_Pes_ID);
                    PessoaProva = _Control.SelecionarPessoa(BeneficioProva.PB_Pessoa_Pes_ID);
                    BeneficioAluno = _Control.SelecionarBeneficio(x.PB_Beneficio_Ben_ID);
                    oBeneficioProva = _Control.SelecionarBeneficio(BeneficioProva.PB_Beneficio_Ben_ID);

                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\t", "");
                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\n", "");
                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\r", "");

                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\t", "");
                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\n", "");
                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\r", "");

                    if (PessoaAluno.Pes_Nome.Replace(" ", "") == PessoaProva.Pes_Nome.Replace(" ", "") && BeneficioAluno.Ben_Nome.Replace(" ", "") == oBeneficioProva.Ben_Nome.Replace(" ", ""))
                    {
                        Nota = Nota + 0.2;
                        Acertou = true;
                        break;
                    }
                }

                if (!Acertou)
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Err_RespostaAluno = "Nenhum dos seus benefícios de funcionários cadastrados se compara ao benefício de funcionário da prova.";
                    oErro.Err_RespostaCerta = "Benefíco Funcionário</br>Funcionário: " + PessoaProva.Pes_Nome + "</br>Benefício: " + oBeneficioProva.Ben_Nome + "</br>Data de Cadastro: " + BeneficioProva.PB_DataCadastro;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum cadastro de benefíco de funcionário no dia " + BeneficioProva.PB_DataCadastro;
                oErro.Err_RespostaCerta = "Benefíco Funcionário</br>Funcionário: " + PessoaProva.Pes_Nome + "</br>Benefício: " + oBeneficioProva.Ben_Nome + "</br>Data de Cadastro: " + BeneficioProva.PB_DataCadastro;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                _Control.CadastrarErro(oErro);
            }

            Acertou = false;

            //Verifica Benefíco 8

            BeneficioProva = _Control.SelecionarBeneficioFuncionario(aProva.Pro_BeneficioFuncionario8);
            BeneficiosFuncionarioAluno = _Control.SelecionarBeneficiosFuncionarioDiaCadastro(BeneficioProva.PB_DataCadastro, aEmpresa.Emp_ID);

            if (BeneficiosFuncionarioAluno != null)
            {
                foreach (var x in BeneficiosFuncionarioAluno)
                {
                    PessoaAluno = _Control.SelecionarPessoa(x.PB_Pessoa_Pes_ID);
                    PessoaProva = _Control.SelecionarPessoa(BeneficioProva.PB_Pessoa_Pes_ID);
                    BeneficioAluno = _Control.SelecionarBeneficio(x.PB_Beneficio_Ben_ID);
                    oBeneficioProva = _Control.SelecionarBeneficio(BeneficioProva.PB_Beneficio_Ben_ID);

                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\t", "");
                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\n", "");
                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\r", "");

                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\t", "");
                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\n", "");
                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\r", "");

                    if (PessoaAluno.Pes_Nome.Replace(" ", "") == PessoaProva.Pes_Nome.Replace(" ", "") && BeneficioAluno.Ben_Nome.Replace(" ", "") == oBeneficioProva.Ben_Nome.Replace(" ", ""))
                    {
                        Nota = Nota + 0.2;
                        Acertou = true;
                        break;
                    }
                }

                if (!Acertou)
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Err_RespostaAluno = "Nenhum dos seus benefícios de funcionários cadastrados se compara ao benefício de funcionário da prova.";
                    oErro.Err_RespostaCerta = "Benefíco Funcionário</br>Funcionário: " + PessoaProva.Pes_Nome + "</br>Benefício: " + oBeneficioProva.Ben_Nome + "</br>Data de Cadastro: " + BeneficioProva.PB_DataCadastro;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum cadastro de benefíco de funcionário no dia " + BeneficioProva.PB_DataCadastro;
                oErro.Err_RespostaCerta = "Benefíco Funcionário</br>Funcionário: " + PessoaProva.Pes_Nome + "</br>Benefício: " + oBeneficioProva.Ben_Nome + "</br>Data de Cadastro: " + BeneficioProva.PB_DataCadastro;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                _Control.CadastrarErro(oErro);
            }

            Acertou = false;

            //Verifica Benefíco 9

            BeneficioProva = _Control.SelecionarBeneficioFuncionario(aProva.Pro_BeneficioFuncionario9);
            BeneficiosFuncionarioAluno = _Control.SelecionarBeneficiosFuncionarioDiaCadastro(BeneficioProva.PB_DataCadastro, aEmpresa.Emp_ID);

            if (BeneficiosFuncionarioAluno != null)
            {
                foreach (var x in BeneficiosFuncionarioAluno)
                {
                    PessoaAluno = _Control.SelecionarPessoa(x.PB_Pessoa_Pes_ID);
                    PessoaProva = _Control.SelecionarPessoa(BeneficioProva.PB_Pessoa_Pes_ID);
                    BeneficioAluno = _Control.SelecionarBeneficio(x.PB_Beneficio_Ben_ID);
                    oBeneficioProva = _Control.SelecionarBeneficio(BeneficioProva.PB_Beneficio_Ben_ID);

                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\t", "");
                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\n", "");
                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\r", "");

                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\t", "");
                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\n", "");
                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\r", "");

                    if (PessoaAluno.Pes_Nome.Replace(" ", "") == PessoaProva.Pes_Nome.Replace(" ", "") && BeneficioAluno.Ben_Nome.Replace(" ", "") == oBeneficioProva.Ben_Nome.Replace(" ", ""))
                    {
                        Nota = Nota + 0.2;
                        Acertou = true;
                        break;
                    }
                }

                if (!Acertou)
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Err_RespostaAluno = "Nenhum dos seus benefícios de funcionários cadastrados se compara ao benefício de funcionário da prova.";
                    oErro.Err_RespostaCerta = "Benefíco Funcionário</br>Funcionário: " + PessoaProva.Pes_Nome + "</br>Benefício: " + oBeneficioProva.Ben_Nome + "</br>Data de Cadastro: " + BeneficioProva.PB_DataCadastro;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum cadastro de benefíco de funcionário no dia " + BeneficioProva.PB_DataCadastro;
                oErro.Err_RespostaCerta = "Benefíco Funcionário</br>Funcionário: " + PessoaProva.Pes_Nome + "</br>Benefício: " + oBeneficioProva.Ben_Nome + "</br>Data de Cadastro: " + BeneficioProva.PB_DataCadastro;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                _Control.CadastrarErro(oErro);
            }

            Acertou = false;

            //Verifica Benefíco 10

            BeneficioProva = _Control.SelecionarBeneficioFuncionario(aProva.Pro_BeneficioFuncionario10);
            BeneficiosFuncionarioAluno = _Control.SelecionarBeneficiosFuncionarioDiaCadastro(BeneficioProva.PB_DataCadastro, aEmpresa.Emp_ID);

            if (BeneficiosFuncionarioAluno != null)
            {
                foreach (var x in BeneficiosFuncionarioAluno)
                {
                    PessoaAluno = _Control.SelecionarPessoa(x.PB_Pessoa_Pes_ID);
                    PessoaProva = _Control.SelecionarPessoa(BeneficioProva.PB_Pessoa_Pes_ID);
                    BeneficioAluno = _Control.SelecionarBeneficio(x.PB_Beneficio_Ben_ID);
                    oBeneficioProva = _Control.SelecionarBeneficio(BeneficioProva.PB_Beneficio_Ben_ID);

                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                    PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                    PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\t", "");
                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\n", "");
                    oBeneficioProva.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\r", "");

                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\t", "");
                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\n", "");
                    BeneficioAluno.Ben_Nome = oBeneficioProva.Ben_Nome.Replace("\r", "");

                    if (PessoaAluno.Pes_Nome.Replace(" ", "") == PessoaProva.Pes_Nome.Replace(" ", "") && BeneficioAluno.Ben_Nome.Replace(" ", "") == oBeneficioProva.Ben_Nome.Replace(" ", ""))
                    {
                        Nota = Nota + 0.2;
                        Acertou = true;
                        break;
                    }
                }

                if (!Acertou)
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Err_RespostaAluno = "Nenhum dos seus benefícios de funcionários cadastrados se compara ao benefício de funcionário da prova.";
                    oErro.Err_RespostaCerta = "Benefíco Funcionário</br>Funcionário: " + PessoaProva.Pes_Nome + "</br>Benefício: " + oBeneficioProva.Ben_Nome + "</br>Data de Cadastro: " + BeneficioProva.PB_DataCadastro;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum cadastro de benefíco de funcionário no dia " + BeneficioProva.PB_DataCadastro;
                oErro.Err_RespostaCerta = "Benefíco Funcionário</br>Funcionário: " + PessoaProva.Pes_Nome + "</br>Benefício: " + oBeneficioProva.Ben_Nome + "</br>Data de Cadastro: " + BeneficioProva.PB_DataCadastro;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                _Control.CadastrarErro(oErro);
            }

            Acertou = false;

            //Verifica Avaliações dos Funcionários

            //Avaliação 1
            Avaliacao AvaliacaoProva = _Control.SelecionarAvaliacao(aProva.Pro_AvaliacaoFuncionario1);
            Avaliacao AvaliacaoAluno = _Control.SelecionarAvaliacaoDiaCadastro(AvaliacaoProva.Ava_DataCadastro, aEmpresa.Emp_ID);

            if (AvaliacaoAluno != null)
            {
                PessoaProva = _Control.SelecionarPessoa(AvaliacaoProva.Ava_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarPessoa(AvaliacaoAluno.Ava_Pessoa_Pes_ID);

                AvaliacaoAluno.Ava_Avaliacao = AvaliacaoAluno.Ava_Avaliacao.Replace("\n", "");
                AvaliacaoAluno.Ava_Avaliacao = AvaliacaoAluno.Ava_Avaliacao.Replace("\t", "");
                AvaliacaoAluno.Ava_Avaliacao = AvaliacaoAluno.Ava_Avaliacao.Replace("\r", "");

                AvaliacaoProva.Ava_Avaliacao = AvaliacaoProva.Ava_Avaliacao.Replace("\n", "");
                AvaliacaoProva.Ava_Avaliacao = AvaliacaoProva.Ava_Avaliacao.Replace("\t", "");
                AvaliacaoProva.Ava_Avaliacao = AvaliacaoProva.Ava_Avaliacao.Replace("\r", "");

                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                if (AvaliacaoAluno.Ava_Avaliacao.Replace(" ","") == AvaliacaoProva.Ava_Avaliacao.Replace(" ","") && PessoaProva.Pes_Nome.Replace(" ","") == PessoaAluno.Pes_Nome.Replace(" ",""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Avaliação:</br>Avaliação do Funcionário: " + PessoaAluno.Pes_Nome + "</br>Data de Cadastro: " + AvaliacaoAluno.Ava_DataCadastro + "</br>Avaliação: " + AvaliacaoAluno.Ava_Avaliacao;
                    oErro.Err_RespostaCerta = "Avaliação:</br>Avaliação do Funcionário: " + PessoaProva.Pes_Nome + "</br>Data de Cadastro: " + AvaliacaoProva.Ava_DataCadastro + "</br>Avaliação: " + AvaliacaoProva.Ava_Avaliacao;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                PessoaProva = _Control.SelecionarFuncionario(AvaliacaoProva.Ava_Pessoa_Pes_ID);
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhuma Avaliação de Funcionário no dia " + AvaliacaoProva.Ava_DataCadastro;
                oErro.Err_RespostaCerta= "Avaliação:</br>Avaliação do Funcionário: " + PessoaProva.Pes_Nome + "</br>Data de Cadastro: " + AvaliacaoProva.Ava_DataCadastro + "</br>Avaliação: " + AvaliacaoProva.Ava_Avaliacao;
                _Control.CadastrarErro(oErro);
            }

            //Avaliação 2
            AvaliacaoProva = _Control.SelecionarAvaliacao(aProva.Pro_AvaliacaoFuncionario2);
            AvaliacaoAluno = _Control.SelecionarAvaliacaoDiaCadastro(AvaliacaoProva.Ava_DataCadastro, aEmpresa.Emp_ID);

            if (AvaliacaoAluno != null)
            {
                PessoaProva = _Control.SelecionarPessoa(AvaliacaoProva.Ava_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarPessoa(AvaliacaoAluno.Ava_Pessoa_Pes_ID);

                AvaliacaoAluno.Ava_Avaliacao = AvaliacaoAluno.Ava_Avaliacao.Replace("\n", "");
                AvaliacaoAluno.Ava_Avaliacao = AvaliacaoAluno.Ava_Avaliacao.Replace("\t", "");
                AvaliacaoAluno.Ava_Avaliacao = AvaliacaoAluno.Ava_Avaliacao.Replace("\r", "");

                AvaliacaoProva.Ava_Avaliacao = AvaliacaoProva.Ava_Avaliacao.Replace("\n", "");
                AvaliacaoProva.Ava_Avaliacao = AvaliacaoProva.Ava_Avaliacao.Replace("\t", "");
                AvaliacaoProva.Ava_Avaliacao = AvaliacaoProva.Ava_Avaliacao.Replace("\r", "");

                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                if (AvaliacaoAluno.Ava_Avaliacao.Replace(" ", "") == AvaliacaoProva.Ava_Avaliacao.Replace(" ", "") && PessoaProva.Pes_Nome.Replace(" ", "") == PessoaAluno.Pes_Nome.Replace(" ", ""))
                {
                    Nota = Nota + 0.4;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Avaliação:</br>Avaliação do Funcionário: " + PessoaAluno.Pes_Nome + "</br>Data de Cadastro: " + AvaliacaoAluno.Ava_DataCadastro + "</br>Avaliação: " + AvaliacaoAluno.Ava_Avaliacao;
                    oErro.Err_RespostaCerta = "Avaliação:</br>Avaliação do Funcionário: " + PessoaProva.Pes_Nome + "</br>Data de Cadastro: " + AvaliacaoProva.Ava_DataCadastro + "</br>Avaliação: " + AvaliacaoProva.Ava_Avaliacao;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                PessoaProva = _Control.SelecionarFuncionario(AvaliacaoProva.Ava_Pessoa_Pes_ID);
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhuma Avaliação de Funcionário no dia " + AvaliacaoProva.Ava_DataCadastro;
                oErro.Err_RespostaCerta = "Avaliação:</br>Avaliação do Funcionário: " + PessoaProva.Pes_Nome + "</br>Data de Cadastro: " + AvaliacaoProva.Ava_DataCadastro + "</br>Avaliação: " + AvaliacaoProva.Ava_Avaliacao;
                _Control.CadastrarErro(oErro);
            }

            //Avaliação 3
            AvaliacaoProva = _Control.SelecionarAvaliacao(aProva.Pro_AvaliacaoFuncionario3);
            AvaliacaoAluno = _Control.SelecionarAvaliacaoDiaCadastro(AvaliacaoProva.Ava_DataCadastro, aEmpresa.Emp_ID);

            if (AvaliacaoAluno != null)
            {
                PessoaProva = _Control.SelecionarPessoa(AvaliacaoProva.Ava_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarPessoa(AvaliacaoAluno.Ava_Pessoa_Pes_ID);

                AvaliacaoAluno.Ava_Avaliacao = AvaliacaoAluno.Ava_Avaliacao.Replace("\n", "");
                AvaliacaoAluno.Ava_Avaliacao = AvaliacaoAluno.Ava_Avaliacao.Replace("\t", "");
                AvaliacaoAluno.Ava_Avaliacao = AvaliacaoAluno.Ava_Avaliacao.Replace("\r", "");

                AvaliacaoProva.Ava_Avaliacao = AvaliacaoProva.Ava_Avaliacao.Replace("\n", "");
                AvaliacaoProva.Ava_Avaliacao = AvaliacaoProva.Ava_Avaliacao.Replace("\t", "");
                AvaliacaoProva.Ava_Avaliacao = AvaliacaoProva.Ava_Avaliacao.Replace("\r", "");

                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                if (AvaliacaoAluno.Ava_Avaliacao.Replace(" ", "") == AvaliacaoProva.Ava_Avaliacao.Replace(" ", "") && PessoaProva.Pes_Nome.Replace(" ", "") == PessoaAluno.Pes_Nome.Replace(" ", ""))
                {
                    Nota = Nota + 0.4;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Avaliação:</br>Avaliação do Funcionário: " + PessoaAluno.Pes_Nome + "</br>Data de Cadastro: " + AvaliacaoAluno.Ava_DataCadastro + "</br>Avaliação: " + AvaliacaoAluno.Ava_Avaliacao;
                    oErro.Err_RespostaCerta = "Avaliação:</br>Avaliação do Funcionário: " + PessoaProva.Pes_Nome + "</br>Data de Cadastro: " + AvaliacaoProva.Ava_DataCadastro + "</br>Avaliação: " + AvaliacaoProva.Ava_Avaliacao;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                PessoaProva = _Control.SelecionarFuncionario(AvaliacaoProva.Ava_Pessoa_Pes_ID);
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhuma Avaliação de Funcionário no dia " + AvaliacaoProva.Ava_DataCadastro;
                oErro.Err_RespostaCerta = "Avaliação:</br>Avaliação do Funcionário: " + PessoaProva.Pes_Nome + "</br>Data de Cadastro: " + AvaliacaoProva.Ava_DataCadastro + "</br>Avaliação: " + AvaliacaoProva.Ava_Avaliacao;
                _Control.CadastrarErro(oErro);
            }

            //Avaliação 4
            AvaliacaoProva = _Control.SelecionarAvaliacao(aProva.Pro_AvaliacaoFuncionario4);
            AvaliacaoAluno = _Control.SelecionarAvaliacaoDiaCadastro(AvaliacaoProva.Ava_DataCadastro, aEmpresa.Emp_ID);

            if (AvaliacaoAluno != null)
            {
                PessoaProva = _Control.SelecionarPessoa(AvaliacaoProva.Ava_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarPessoa(AvaliacaoAluno.Ava_Pessoa_Pes_ID);

                if (AvaliacaoAluno.Ava_Avaliacao.Replace(" ", "") == AvaliacaoProva.Ava_Avaliacao.Replace(" ", "") && PessoaProva.Pes_Nome.Replace(" ", "") == PessoaAluno.Pes_Nome.Replace(" ", ""))
                {
                    Nota = Nota + 0.4;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Avaliação:</br>Avaliação do Funcionário: " + PessoaAluno.Pes_Nome + "</br>Data de Cadastro: " + AvaliacaoAluno.Ava_DataCadastro + "</br>Avaliação: " + AvaliacaoAluno.Ava_Avaliacao;
                    oErro.Err_RespostaCerta = "Avaliação:</br>Avaliação do Funcionário: " + PessoaProva.Pes_Nome + "</br>Data de Cadastro: " + AvaliacaoProva.Ava_DataCadastro + "</br>Avaliação: " + AvaliacaoProva.Ava_Avaliacao;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                PessoaProva = _Control.SelecionarFuncionario(AvaliacaoProva.Ava_Pessoa_Pes_ID);
                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhuma Avaliação de Funcionário no dia " + AvaliacaoProva.Ava_DataCadastro;
                oErro.Err_RespostaCerta = "Avaliação:</br>Avaliação do Funcionário: " + PessoaProva.Pes_Nome + "</br>Data de Cadastro: " + AvaliacaoProva.Ava_DataCadastro + "</br>Avaliação: " + AvaliacaoProva.Ava_Avaliacao;
                _Control.CadastrarErro(oErro);
            }

            //Verifica Demissão

            //Demissao 1
            Demissao DemissaoProva = _Control.SelecionarDemissao(aProva.Pro_Demissao1);
            Demissao DemissaoAluno = _Control.SelecionarDemissaoDataCadastro(DemissaoProva.Dem_DataCadastro, aEmpresa.Emp_ID);

            if (DemissaoAluno != null)
            {
                PessoaProva = _Control.SelecionarPessoa(DemissaoProva.Dem_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarPessoa(DemissaoAluno.Dem_Pessoa_Pes_ID);

                DemissaoAluno.Dem_Motivo = DemissaoAluno.Dem_Motivo.Replace("\t", "");
                DemissaoAluno.Dem_Motivo = DemissaoAluno.Dem_Motivo.Replace("\n", "");
                DemissaoAluno.Dem_Motivo = DemissaoAluno.Dem_Motivo.Replace("\r", "");

                DemissaoProva.Dem_Motivo = DemissaoProva.Dem_Motivo.Replace("\t", "");
                DemissaoProva.Dem_Motivo = DemissaoProva.Dem_Motivo.Replace("\n", "");
                DemissaoProva.Dem_Motivo = DemissaoProva.Dem_Motivo.Replace("\r", "");

                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");


                if (DemissaoAluno.Dem_Motivo.Replace(" ","") == DemissaoProva.Dem_Motivo.Replace(" ","") && PessoaAluno.Pes_Nome.Replace(" ","") == PessoaProva.Pes_Nome.Replace(" ",""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Demissao:</br>Demissão do Funcionário: " + PessoaAluno.Pes_Nome + "</br>Data da Demissão: " + DemissaoAluno.Dem_DataCadastro + "</br>Motivo da Demissao: " + DemissaoAluno.Dem_Motivo;
                    oErro.Err_RespostaCerta= "Demissao:</br>Demissão do Funcionário: " + PessoaProva.Pes_Nome + "</br>Data da Demissão: " + DemissaoProva.Dem_DataCadastro + "</br>Motivo da Demissao: " + DemissaoProva.Dem_Motivo;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                PessoaProva = _Control.SelecionarFuncionario(DemissaoProva.Dem_Pessoa_Pes_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhuma Demissão de Funcionário no dia " + DemissaoProva.Dem_DataCadastro;
                oErro.Err_RespostaCerta= "Demissao:</br>Demissão do Funcionário: " + PessoaProva.Pes_Nome + "</br>Data da Demissão: " + DemissaoProva.Dem_DataCadastro + "</br>Motivo da Demissao: " + DemissaoProva.Dem_Motivo;
                _Control.CadastrarErro(oErro);
            }

            //Demissao 2
            DemissaoProva = _Control.SelecionarDemissao(aProva.Pro_Demissao2);
            DemissaoAluno = _Control.SelecionarDemissaoDataCadastro(DemissaoProva.Dem_DataCadastro, aEmpresa.Emp_ID);

            if (DemissaoAluno != null)
            {
                PessoaProva = _Control.SelecionarPessoa(DemissaoProva.Dem_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarPessoa(DemissaoAluno.Dem_Pessoa_Pes_ID);

                DemissaoAluno.Dem_Motivo = DemissaoAluno.Dem_Motivo.Replace("\t", "");
                DemissaoAluno.Dem_Motivo = DemissaoAluno.Dem_Motivo.Replace("\n", "");
                DemissaoAluno.Dem_Motivo = DemissaoAluno.Dem_Motivo.Replace("\r", "");

                DemissaoProva.Dem_Motivo = DemissaoProva.Dem_Motivo.Replace("\t", "");
                DemissaoProva.Dem_Motivo = DemissaoProva.Dem_Motivo.Replace("\n", "");
                DemissaoProva.Dem_Motivo = DemissaoProva.Dem_Motivo.Replace("\r", "");

                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                if (DemissaoAluno.Dem_Motivo.Replace(" ", "") == DemissaoProva.Dem_Motivo.Replace(" ", "") && PessoaAluno.Pes_Nome.Replace(" ", "") == PessoaProva.Pes_Nome.Replace(" ", ""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Demissao:</br>Demissão do Funcionário: " + PessoaAluno.Pes_Nome + "</br>Data da Demissão: " + DemissaoAluno.Dem_DataCadastro + "</br>Motivo da Demissao: " + DemissaoAluno.Dem_Motivo;
                    oErro.Err_RespostaCerta = "Demissao:</br>Demissão do Funcionário: " + PessoaProva.Pes_Nome + "</br>Data da Demissão: " + DemissaoProva.Dem_DataCadastro + "</br>Motivo da Demissao: " + DemissaoProva.Dem_Motivo;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                PessoaProva = _Control.SelecionarFuncionario(DemissaoProva.Dem_Pessoa_Pes_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhuma Demissão de Funcionário no dia " + DemissaoProva.Dem_DataCadastro;
                oErro.Err_RespostaCerta = "Demissao:</br>Demissão do Funcionário: " + PessoaProva.Pes_Nome + "</br>Data da Demissão: " + DemissaoProva.Dem_DataCadastro + "</br>Motivo da Demissao: " + DemissaoProva.Dem_Motivo;
                _Control.CadastrarErro(oErro);
            }

            //Demissao 3
            DemissaoProva = _Control.SelecionarDemissao(aProva.Pro_Demissao3);
            DemissaoAluno = _Control.SelecionarDemissaoDataCadastro(DemissaoProva.Dem_DataCadastro, aEmpresa.Emp_ID);

            

            if (DemissaoAluno != null)
            {
                PessoaProva = _Control.SelecionarPessoa(DemissaoProva.Dem_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarPessoa(DemissaoAluno.Dem_Pessoa_Pes_ID);

                DemissaoAluno.Dem_Motivo = DemissaoAluno.Dem_Motivo.Replace("\t", "");
                DemissaoAluno.Dem_Motivo = DemissaoAluno.Dem_Motivo.Replace("\n", "");
                DemissaoAluno.Dem_Motivo = DemissaoAluno.Dem_Motivo.Replace("\r", "");

                DemissaoProva.Dem_Motivo = DemissaoProva.Dem_Motivo.Replace("\t", "");
                DemissaoProva.Dem_Motivo = DemissaoProva.Dem_Motivo.Replace("\n", "");
                DemissaoProva.Dem_Motivo = DemissaoProva.Dem_Motivo.Replace("\r", "");

                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\t", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\n", "");
                PessoaAluno.Pes_Nome = PessoaAluno.Pes_Nome.Replace("\r", "");

                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\t", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\n", "");
                PessoaProva.Pes_Nome = PessoaProva.Pes_Nome.Replace("\r", "");

                if (DemissaoAluno.Dem_Motivo.Replace(" ","") == DemissaoProva.Dem_Motivo.Replace(" ","") && PessoaAluno.Pes_Nome.Replace(" ","") == PessoaProva.Pes_Nome.Replace(" ",""))
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Erro_Tipo = "Erro no Cadastro";
                    oErro.Err_RespostaAluno = "Demissao:</br>Demissão do Funcionário: " + PessoaAluno.Pes_Nome + "</br>Data da Demissão: " + DemissaoAluno.Dem_DataCadastro + "</br>Motivo da Demissao: " + DemissaoAluno.Dem_Motivo;
                    oErro.Err_RespostaCerta = "Demissao:</br>Demissão do Funcionário: " + PessoaProva.Pes_Nome + "</br>Data da Demissão: " + DemissaoProva.Dem_DataCadastro + "</br>Motivo da Demissao: " + DemissaoProva.Dem_Motivo;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                PessoaProva = _Control.SelecionarFuncionario(DemissaoProva.Dem_Pessoa_Pes_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Erro_Tipo = "Cadastro realizado no dia errado";
                oErro.Err_RespostaAluno = "Não foi encontrado nenhuma Demissão de Funcionário no dia " + DemissaoProva.Dem_DataCadastro;
                oErro.Err_RespostaCerta = "Demissao:</br>Demissão do Funcionário: " + PessoaProva.Pes_Nome + "</br>Data da Demissão: " + DemissaoProva.Dem_DataCadastro + "</br>Motivo da Demissao: " + DemissaoProva.Dem_Motivo;
                _Control.CadastrarErro(oErro);
            }

            aNota.Not_Situation = true;
            aNota.Not_Nota = Nota;
            _Control.CadastrarNota(aNota);
        }

        [AutorizacaoProfessor]
        public ActionResult Notas(int CodigoProva)
        {
            List<VW_Notas> NotasProva = _Control.SelecionarNotasProva();

            List<VW_Notas> FiltroNotasProva = NotasProva.Where(p => p.CodigoProva.Equals(CodigoProva)).ToList();
            return View(FiltroNotasProva);
        }

        [Autorizacao]
        public ActionResult Erros(int IDProva)
        {
            List<Erro> Erros = _Control.SelecionarErrosProva(IDProva);
            Prova aProva = _Control.SelecionarProvaPorID(IDProva);
            Aluno oAluno = _Control.SelecionarAluno(aProva.Pro_Aluno_Alu_ID);
            ViewBag.NomeAluno = oAluno.Alu_Nome;
            ViewBag.MatriculaAluno = oAluno.Alu_Matricula;
            ViewBag.Serie = oAluno.Alu_Serie+"º Ano";
            Curso oCurso = _Control.SelecionarCurso(oAluno.Alu_Curso_Cur_ID);
            ViewBag.Curso = oCurso.Cur_Nome;
            Nota aNota = _Control.SelecionarNotaProva(IDProva);
            ViewBag.Nota = aNota.Not_Nota;
            Empresa aEmpresa = _Control.SelecionarEmpresaAvaliativaAluno(aProva.Pro_Aluno_Alu_ID);

            ViewBag.MeusBeneficios = _Control.SelecionarBeneficiosEmpresa(aEmpresa.Emp_ID);

            return View(Erros);
        }
    }
}


