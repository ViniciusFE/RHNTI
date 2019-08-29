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

        // GET: Prova
        public ActionResult Index()
        {
            List<Aluno> Alunos = _Control.SelecionarTodosAlunos();
            ViewBag.QuantidadeAlunos = Alunos.Count();

            List<VW_Provas> Provas = _Control.SelecionarTodasProva();
            return View(Provas);
        }

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
                aProva.Pro_Setor1 = 18;
                aProva.Pro_Setor2 = 19;
                aProva.Pro_Setor3 = 20;
                aProva.Pro_Setor4 = 25;
                aProva.Pro_Setor5 = 27;
                aProva.Pro_Cargo1 = 10;
                aProva.Pro_Cargo2 = 11;
                aProva.Pro_Cargo3 = 12;
                aProva.Pro_Cargo4 = 14;
                aProva.Pro_Cargo5 = 15;

                Pessoa aPessoa = new Pessoa();

                //Cadastra funcionário do cargo de tesoureiro//
                aPessoa.Pes_Cargo_Car_ID = 11;
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
                aPessoa.Pes_Cargo_Car_ID = 15;
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
                aPessoa.Pes_Cargo_Car_ID = 10;
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
                aPessoa.Pes_Cargo_Car_ID = 14;
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
                aPessoa.Pes_Cargo_Car_ID = 12;
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
                aProva.Pro_Beneficio1 = 18; 
                aProva.Pro_Beneficio2 = 19; 
                aProva.Pro_Beneficio3 = 20; 
                aProva.Pro_Beneficio4 = 21; 
                aProva.Pro_Beneficio5 = 22; 


                //Cadastrar Benefícios dos Funcionários
                PessoaBeneficio BeneficioFuncionario = new PessoaBeneficio();

                //Cadastra Beneficios do Funcionario Programador
                BeneficioFuncionario.PB_Beneficio_Ben_ID = 19;
                BeneficioFuncionario.PB_Pessoa_Pes_ID = IDProgramador;
                BeneficioFuncionario.PB_DataCadastro = "25/06";
                BeneficioFuncionario.PB_Situation = true;
                _Control.CadastrarBeneficioFuncionario(BeneficioFuncionario);
                aProva.Pro_BeneficioFuncionario1 = BeneficioFuncionario.PB_ID;

                BeneficioFuncionario.PB_Beneficio_Ben_ID = 22;
                BeneficioFuncionario.PB_Pessoa_Pes_ID = IDProgramador;
                BeneficioFuncionario.PB_DataCadastro = "25/06";
                BeneficioFuncionario.PB_Situation = true;
                _Control.CadastrarBeneficioFuncionario(BeneficioFuncionario);
                aProva.Pro_BeneficioFuncionario2 = BeneficioFuncionario.PB_ID;

                //Cadastra Benefícios do CEO
                BeneficioFuncionario.PB_Beneficio_Ben_ID = 20;
                BeneficioFuncionario.PB_Pessoa_Pes_ID = IDCEO;
                BeneficioFuncionario.PB_DataCadastro = "01/01";
                BeneficioFuncionario.PB_Situation = true;
                _Control.CadastrarBeneficioFuncionario(BeneficioFuncionario);
                aProva.Pro_BeneficioFuncionario3 = BeneficioFuncionario.PB_ID;

                BeneficioFuncionario.PB_Beneficio_Ben_ID = 18;
                BeneficioFuncionario.PB_Pessoa_Pes_ID = IDCEO;
                BeneficioFuncionario.PB_DataCadastro = "01/01";
                BeneficioFuncionario.PB_Situation = true;
                _Control.CadastrarBeneficioFuncionario(BeneficioFuncionario);
                aProva.Pro_BeneficioFuncionario4 = BeneficioFuncionario.PB_ID;

                //Cadastrar Benefícios Profissional de Marketing
                BeneficioFuncionario.PB_Beneficio_Ben_ID = 21;
                BeneficioFuncionario.PB_Pessoa_Pes_ID = IDProfissionalMarketing;
                BeneficioFuncionario.PB_DataCadastro = "07/09";
                BeneficioFuncionario.PB_Situation = true;
                _Control.CadastrarBeneficioFuncionario(BeneficioFuncionario);
                aProva.Pro_BeneficioFuncionario5 = BeneficioFuncionario.PB_ID;

                BeneficioFuncionario.PB_Beneficio_Ben_ID = 20;
                BeneficioFuncionario.PB_Pessoa_Pes_ID = IDProfissionalMarketing;
                BeneficioFuncionario.PB_DataCadastro = "07/09";
                BeneficioFuncionario.PB_Situation = true;
                _Control.CadastrarBeneficioFuncionario(BeneficioFuncionario);
                aProva.Pro_BenefcioFuncionario6 = BeneficioFuncionario.PB_ID;

                //Cadastrar Beneficios do Tesoureiro
                BeneficioFuncionario.PB_Beneficio_Ben_ID = 22;
                BeneficioFuncionario.PB_Pessoa_Pes_ID = IDTesoureiro;
                BeneficioFuncionario.PB_DataCadastro = "10/03";
                BeneficioFuncionario.PB_Situation = true;
                _Control.CadastrarBeneficioFuncionario(BeneficioFuncionario);
                aProva.Pro_BeneficioFuncionario7 = BeneficioFuncionario.PB_ID;

                BeneficioFuncionario.PB_Beneficio_Ben_ID = 18;
                BeneficioFuncionario.PB_Pessoa_Pes_ID = IDTesoureiro;
                BeneficioFuncionario.PB_DataCadastro = "10/03";
                BeneficioFuncionario.PB_Situation = true;
                _Control.CadastrarBeneficioFuncionario(BeneficioFuncionario);
                aProva.Pro_BeneficioFuncionario8 = BeneficioFuncionario.PB_ID;

                //Cadastrar Benefícios do Gerente de Produção
                BeneficioFuncionario.PB_Beneficio_Ben_ID = 21;
                BeneficioFuncionario.PB_Pessoa_Pes_ID = IDGerenteDeProducao;
                BeneficioFuncionario.PB_DataCadastro = "30/08";
                BeneficioFuncionario.PB_Situation = true;
                _Control.CadastrarBeneficioFuncionario(BeneficioFuncionario);
                aProva.Pro_BeneficioFuncionario9 = BeneficioFuncionario.PB_ID;

                BeneficioFuncionario.PB_Beneficio_Ben_ID = 19;
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
                aAvaliacao.Ava_Pessoa_Pes_ID = IDProfissionalMarketing;
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
                aPessoa = _Control.SelecionarFuncionario(IDProfissionalMarketing);
                aDemissao.Dem_Salario = aPessoa.Pes_Salario;
                aDemissao.Dem_DataCadastro = "31/12";
                aDemissao.Dem_Situation = true;
                _Control.CadastrarDemissao(aDemissao);
                aProva.Pro_Demissao2 = aDemissao.Dem_ID;

                aDemissao.Dem_Pessoa_Pes_ID = IDProgramador;
                aDemissao.Dem_Motivo = "Foi demitido";
                aPessoa = _Control.SelecionarFuncionario(IDProfissionalMarketing);
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

        public ActionResult EntregarProva()
        {
            Aluno oAluno = (Aluno)Session["User"];
            Prova aProva = _Control.SelecionarProvaAluno(oAluno.Alu_ID);
            aProva.Pro_Entregue = true;
            _Control.AlterarProva(aProva);

            CalcularNota(oAluno.Alu_ID);

            Empresa aEmpresa = _Control.SelecionarEmpresaAvaliativaAluno(oAluno.Alu_ID);
            aEmpresa.Emp_Situation = false;
            _Control.AlterarEmpresa(aEmpresa);  


            return Json("Sua prova foi entregue e sua nota foi calculada, após o vencimento do dia prova a próxima vez que acessar a plataforma terá a acesso a sua nota.");
        }

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
                Setor oSetor = _Control.SelecionarSetor(SetorProva.Set_ID);
                string SetorRespondenteProva = oSetor.Set_Nome;
                oSetor = _Control.SelecionarSetor(SetorAluno.Set_ID);
                string SetorRespondenteAluno = oSetor.Set_Nome;

                if (SetorAluno.Set_Nome.Trim() == SetorProva.Set_Nome.Trim() && SetorRespondenteAluno==SetorRespondenteProva)
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
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Err_RespostaAluno = "Não foi encontrado um setor cadastrado no dia " + SetorProva.Set_DataCadastro;
                oErro.Err_RespostaCerta = oErro.Err_RespostaCerta = "Setor:</br>Nome do Setor: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + SetorProva.Set_DataCadastro + "</br>Setor Respondente: " + SetorRespondenteProva;
            }

            //Setor 2
            SetorProva = _Control.SelecionarSetor(aProva.Pro_Setor2);
            SetorAluno = _Control.SelecionarSetorDiaCadastro(SetorProva.Set_DataCadastro, aEmpresa.Emp_ID);
            if (SetorAluno != null)
            {
                Setor oSetor = _Control.SelecionarSetor(SetorProva.Set_ID);
                string SetorRespondenteProva = oSetor.Set_Nome;
                oSetor = _Control.SelecionarSetor(SetorAluno.Set_ID);
                string SetorRespondenteAluno = oSetor.Set_Nome;

                if (SetorAluno.Set_Nome.Trim() == SetorProva.Set_Nome.Trim() && SetorRespondenteAluno == SetorRespondenteProva)
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
                oErro.Err_RespostaAluno = "Não foi encontrado um setor cadastrado no dia " + SetorProva.Set_DataCadastro;
                oErro.Err_RespostaCerta = oErro.Err_RespostaCerta = "Setor:</br>Nome do Setor: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + SetorProva.Set_DataCadastro + "</br>Setor Respondente: " + SetorRespondenteProva;
            }

            //Setor 3
            SetorProva = _Control.SelecionarSetor(aProva.Pro_Setor3);
            SetorAluno = _Control.SelecionarSetorDiaCadastro(SetorProva.Set_DataCadastro, aEmpresa.Emp_ID);
            if (SetorAluno != null)
            {
                Setor oSetor = _Control.SelecionarSetor(SetorProva.Set_ID);
                string SetorRespondenteProva = oSetor.Set_Nome;
                oSetor = _Control.SelecionarSetor(SetorAluno.Set_ID);
                string SetorRespondenteAluno = oSetor.Set_Nome;

                if (SetorAluno.Set_Nome.Trim() == SetorProva.Set_Nome.Trim() && SetorRespondenteAluno == SetorRespondenteProva)
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
                oErro.Err_RespostaAluno = "Não foi encontrado um setor cadastrado no dia " + SetorProva.Set_DataCadastro;
                oErro.Err_RespostaCerta = oErro.Err_RespostaCerta = "Setor:</br>Nome do Setor: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + SetorProva.Set_DataCadastro + "</br>Setor Respondente: " + SetorRespondenteProva;
            }

            //Setor 4
            SetorProva = _Control.SelecionarSetor(aProva.Pro_Setor4);
            SetorAluno = _Control.SelecionarSetorDiaCadastro(SetorProva.Set_DataCadastro, aEmpresa.Emp_ID);
            if (SetorAluno != null)
            {
                Setor oSetor = _Control.SelecionarSetor(SetorProva.Set_ID);
                string SetorRespondenteProva = oSetor.Set_Nome;
                oSetor = _Control.SelecionarSetor(SetorAluno.Set_ID);
                string SetorRespondenteAluno = oSetor.Set_Nome;

                if (SetorAluno.Set_Nome.Trim() == SetorProva.Set_Nome.Trim() && SetorRespondenteAluno == SetorRespondenteProva)
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
                oErro.Err_RespostaAluno = "Não foi encontrado um setor cadastrado no dia " + SetorProva.Set_DataCadastro;
                oErro.Err_RespostaCerta = oErro.Err_RespostaCerta = "Setor:</br>Nome do Setor: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + SetorProva.Set_DataCadastro + "</br>Setor Respondente: " + SetorRespondenteProva;
            }

            //Setor 5
            SetorProva = _Control.SelecionarSetor(aProva.Pro_Setor5);
            SetorAluno = _Control.SelecionarSetorDiaCadastro(SetorProva.Set_DataCadastro, aEmpresa.Emp_ID);
            if (SetorAluno != null)
            {
                Setor oSetor = _Control.SelecionarSetor(SetorProva.Set_ID);
                string SetorRespondenteProva = oSetor.Set_Nome;
                oSetor = _Control.SelecionarSetor(SetorAluno.Set_ID);
                string SetorRespondenteAluno = oSetor.Set_Nome;

                if (SetorAluno.Set_Nome.Trim() == SetorProva.Set_Nome.Trim() && SetorRespondenteAluno == SetorRespondenteProva)
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
                oErro.Err_RespostaAluno = "Não foi encontrado um setor cadastrado no dia " + SetorProva.Set_DataCadastro;
                oErro.Err_RespostaCerta = oErro.Err_RespostaCerta = "Setor:</br>Nome do Setor: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + SetorProva.Set_DataCadastro + "</br>Setor Respondente: " + SetorRespondenteProva;
            }


            //Verifica Cargos

            //Cargo 1
            Cargo CargoProva = _Control.SelecionarCargo(aProva.Pro_Cargo1);
            Cargo CargoAluno = _Control.SelecionarCargoDiaCadastro(CargoProva.Car_DataCadastro, aEmpresa.Emp_ID);


            if (CargoAluno != null)
            {
                SetorProva = _Control.SelecionarSetor(CargoProva.Car_Setor_Set_ID);
                SetorAluno = _Control.SelecionarSetor(CargoAluno.Car_Setor_Set_ID);

                if (CargoAluno.Car_Nome.Trim() == CargoProva.Car_Nome.Trim() && CargoAluno.Car_Chefe == CargoProva.Car_Chefe && SetorProva.Set_Nome == SetorAluno.Set_Nome)
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
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum cargo cadastrado no dia " + CargoProva.Car_DataCadastro;
                oErro.Err_RespostaCerta = "Cargo:</br>Nome do Cargo: " + CargoProva.Car_Nome + "</br>Setor do Cargo: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro + "</br>Chefe do Setor: " + ChefeProva;
            }

            //Cargo 2
            CargoProva = _Control.SelecionarCargo(aProva.Pro_Cargo2);
            CargoAluno = _Control.SelecionarCargoDiaCadastro(CargoProva.Car_DataCadastro, aEmpresa.Emp_ID);


            if (CargoAluno != null)
            {
                SetorProva = _Control.SelecionarSetor(CargoProva.Car_Setor_Set_ID);
                SetorAluno = _Control.SelecionarSetor(CargoAluno.Car_Setor_Set_ID);

                if (CargoAluno.Car_Nome.Trim() == CargoProva.Car_Nome.Trim() && CargoAluno.Car_Chefe == CargoProva.Car_Chefe && SetorProva.Set_Nome == SetorAluno.Set_Nome)
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
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum cargo cadastrado no dia " + CargoProva.Car_DataCadastro;
                oErro.Err_RespostaCerta = "Cargo:</br>Nome do Cargo: " + CargoProva.Car_Nome + "</br>Setor do Cargo: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro + "</br>Chefe do Setor: " + ChefeProva;
            }

            //Cargo 3
            CargoProva = _Control.SelecionarCargo(aProva.Pro_Cargo3);
            CargoAluno = _Control.SelecionarCargoDiaCadastro(CargoProva.Car_DataCadastro, aEmpresa.Emp_ID);


            if (CargoAluno != null)
            {
                SetorProva = _Control.SelecionarSetor(CargoProva.Car_Setor_Set_ID);
                SetorAluno = _Control.SelecionarSetor(CargoAluno.Car_Setor_Set_ID);

                if (CargoAluno.Car_Nome.Trim() == CargoProva.Car_Nome.Trim() && CargoAluno.Car_Chefe == CargoProva.Car_Chefe && SetorProva.Set_Nome == SetorAluno.Set_Nome)
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
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum cargo cadastrado no dia " + CargoProva.Car_DataCadastro;
                oErro.Err_RespostaCerta = "Cargo:</br>Nome do Cargo: " + CargoProva.Car_Nome + "</br>Setor do Cargo: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro + "</br>Chefe do Setor: " + ChefeProva;
            }

            //Cargo 4
            CargoProva = _Control.SelecionarCargo(aProva.Pro_Cargo4);
            CargoAluno = _Control.SelecionarCargoDiaCadastro(CargoProva.Car_DataCadastro, aEmpresa.Emp_ID);


            if (CargoAluno != null)
            {
                SetorProva = _Control.SelecionarSetor(CargoProva.Car_Setor_Set_ID);
                SetorAluno = _Control.SelecionarSetor(CargoAluno.Car_Setor_Set_ID);

                if (CargoAluno.Car_Nome.Trim() == CargoProva.Car_Nome.Trim() && CargoAluno.Car_Chefe == CargoProva.Car_Chefe && SetorProva.Set_Nome == SetorAluno.Set_Nome)
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
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum cargo cadastrado no dia " + CargoProva.Car_DataCadastro;
                oErro.Err_RespostaCerta = "Cargo:</br>Nome do Cargo: " + CargoProva.Car_Nome + "</br>Setor do Cargo: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro + "</br>Chefe do Setor: " + ChefeProva;
            }

            //Cargo 5
            CargoProva = _Control.SelecionarCargo(aProva.Pro_Cargo5);
            CargoAluno = _Control.SelecionarCargoDiaCadastro(CargoProva.Car_DataCadastro, aEmpresa.Emp_ID);


            if (CargoAluno != null)
            {
                SetorProva = _Control.SelecionarSetor(CargoProva.Car_Setor_Set_ID);
                SetorAluno = _Control.SelecionarSetor(CargoAluno.Car_Setor_Set_ID);

                if (CargoAluno.Car_Nome.Trim() == CargoProva.Car_Nome.Trim() && CargoAluno.Car_Chefe == CargoProva.Car_Chefe && SetorProva.Set_Nome == SetorAluno.Set_Nome)
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
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum cargo cadastrado no dia " + CargoProva.Car_DataCadastro;
                oErro.Err_RespostaCerta = "Cargo:</br>Nome do Cargo: " + CargoProva.Car_Nome + "</br>Setor do Cargo: " + SetorProva.Set_Nome + "</br>Data de Cadastro: " + CargoProva.Car_DataCadastro + "</br>Chefe do Setor: " + ChefeProva;
            }

            //Verificar Funcionarios

            //Funcionario 1
            Pessoa PessoaProva = _Control.SelecionarFuncionario(aProva.Pro_Pessoa1);
            Pessoa PessoaAluno = _Control.SelecionarPessoaDiaCadastro(PessoaProva.Pes_DataCadastro, aEmpresa.Emp_ID);

            if (PessoaAluno != null)
            {
                CargoProva = _Control.SelecionarCargo(PessoaProva.Pes_Cargo_Car_ID);
                CargoAluno = _Control.SelecionarCargo(PessoaAluno.Pes_Cargo_Car_ID);

                if (PessoaAluno.Pes_Nome.Trim() == PessoaProva.Pes_Nome.Trim() && PessoaAluno.Pes_CPF.Trim() == PessoaProva.Pes_CPF.Trim() && PessoaAluno.Pes_Cidade.Trim() == PessoaProva.Pes_Cidade.Trim() && PessoaAluno.Pes_Endereco.Trim() == PessoaProva.Pes_Endereco.Trim() && PessoaAluno.Pes_Salario == PessoaProva.Pes_Salario && CargoProva.Car_Nome.Trim() == CargoAluno.Car_Nome.Trim())
                {
                    Nota = Nota + 0.2;
                }

                else
                {

                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Err_RespostaAluno = "Funcionário:</br>Nome do Funcionário: " + PessoaAluno.Pes_Nome + "</br>CPF: " + PessoaAluno.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaAluno.Pes_CTrabalho + "</br>Salário: " + PessoaAluno.Pes_Salario + "</br>Cidade: " + PessoaAluno.Pes_Cidade + "</br>Endereço: " + PessoaAluno.Pes_Endereco + "</br>Data de Cadastro: " + PessoaAluno.Pes_DataCadastro + "</br>Cargo do Funcionário: " + CargoAluno.Car_Nome;
                    oErro.Err_RespostaCerta= "Funcionário:</br>Nome do Funcionário: " + PessoaProva.Pes_Nome + "</br>CPF: " + PessoaProva.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaProva.Pes_CTrabalho + "</br>Salário: " + PessoaProva.Pes_Salario + "</br>Cidade: " + PessoaProva.Pes_Cidade + "</br>Endereço: " + PessoaProva.Pes_Endereco + "</br>Data de Cadastro: " + PessoaProva.Pes_DataCadastro + "</br>Cargo do Funcionário: " + CargoProva.Car_Nome;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                CargoProva = _Control.SelecionarCargo(PessoaProva.Pes_Cargo_Car_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum funcionário cadastrado no dia " + PessoaProva.Pes_DataCadastro;
                oErro.Err_RespostaCerta= "Funcionário:</br>Nome do Funcionário: " + PessoaProva.Pes_Nome + "</br>CPF: " + PessoaProva.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaProva.Pes_CTrabalho + "</br>Salário: " + PessoaProva.Pes_Salario + "</br>Cidade: " + PessoaProva.Pes_Cidade + "</br>Endereço: " + PessoaProva.Pes_Endereco + "</br>Data de Cadastro: " + PessoaProva.Pes_DataCadastro + "</br>Cargo do Funcionário: " + CargoProva.Car_Nome;
            }

            //Funcionario 2
            PessoaProva = _Control.SelecionarFuncionario(aProva.Pro_Pessoa2);
            PessoaAluno = _Control.SelecionarPessoaDiaCadastro(PessoaProva.Pes_DataCadastro, aEmpresa.Emp_ID);

            if (PessoaAluno != null)
            {
                CargoProva = _Control.SelecionarCargo(PessoaProva.Pes_Cargo_Car_ID);
                CargoAluno = _Control.SelecionarCargo(PessoaAluno.Pes_Cargo_Car_ID);

                if (PessoaAluno.Pes_Nome.Trim() == PessoaProva.Pes_Nome.Trim() && PessoaAluno.Pes_CPF.Trim() == PessoaProva.Pes_CPF.Trim() && PessoaAluno.Pes_Cidade.Trim() == PessoaProva.Pes_Cidade.Trim() && PessoaAluno.Pes_Endereco.Trim() == PessoaProva.Pes_Endereco.Trim() && PessoaAluno.Pes_Salario == PessoaProva.Pes_Salario && CargoProva.Car_Nome.Trim() == CargoAluno.Car_Nome.Trim())
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Err_RespostaAluno = "Funcionário:</br>Nome do Funcionário: " + PessoaAluno.Pes_Nome + "</br>CPF: " + PessoaAluno.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaAluno.Pes_CTrabalho + "</br>Salário: " + PessoaAluno.Pes_Salario + "</br>Cidade: " + PessoaAluno.Pes_Cidade + "</br>Endereço: " + PessoaAluno.Pes_Endereco + "</br>Data de Cadastro: " + PessoaAluno.Pes_DataCadastro + "</br>Cargo do Funcionário: " + CargoAluno.Car_Nome;
                    oErro.Err_RespostaCerta = "Funcionário:</br>Nome do Funcionário: " + PessoaProva.Pes_Nome + "</br>CPF: " + PessoaProva.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaProva.Pes_CTrabalho + "</br>Salário: " + PessoaProva.Pes_Salario + "</br>Cidade: " + PessoaProva.Pes_Cidade + "</br>Endereço: " + PessoaProva.Pes_Endereco + "</br>Data de Cadastro: " + PessoaProva.Pes_DataCadastro + "</br>Cargo do Funcionário: " + CargoProva.Car_Nome;
                    _Control.CadastrarErro(oErro);
                    
                }
            }

            else
            {
                CargoProva = _Control.SelecionarCargo(PessoaProva.Pes_Cargo_Car_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum funcionário cadastrado no dia " + PessoaProva.Pes_DataCadastro;
                oErro.Err_RespostaCerta = "Funcionário:</br>Nome do Funcionário: " + PessoaProva.Pes_Nome + "</br>CPF: " + PessoaProva.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaProva.Pes_CTrabalho + "</br>Salário: " + PessoaProva.Pes_Salario + "</br>Cidade: " + PessoaProva.Pes_Cidade + "</br>Endereço: " + PessoaProva.Pes_Endereco + "</br>Data de Cadastro: " + PessoaProva.Pes_DataCadastro + "</br>Cargo do Funcionário: " + CargoProva.Car_Nome;
            }

            //Funcionario 3
            PessoaProva = _Control.SelecionarFuncionario(aProva.Pro_Pessoa3);
            PessoaAluno = _Control.SelecionarPessoaDiaCadastro(PessoaProva.Pes_DataCadastro, aEmpresa.Emp_ID);

            if (PessoaAluno != null)
            {
                CargoProva = _Control.SelecionarCargo(PessoaProva.Pes_Cargo_Car_ID);
                CargoAluno = _Control.SelecionarCargo(PessoaAluno.Pes_Cargo_Car_ID);

                if (PessoaAluno.Pes_Nome.Trim() == PessoaProva.Pes_Nome.Trim() && PessoaAluno.Pes_CPF.Trim() == PessoaProva.Pes_CPF.Trim() && PessoaAluno.Pes_Cidade.Trim() == PessoaProva.Pes_Cidade.Trim() && PessoaAluno.Pes_Endereco.Trim() == PessoaProva.Pes_Endereco.Trim() && PessoaAluno.Pes_Salario == PessoaProva.Pes_Salario && CargoProva.Car_Nome.Trim() == CargoAluno.Car_Nome.Trim())
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Err_RespostaAluno = "Funcionário:</br>Nome do Funcionário: " + PessoaAluno.Pes_Nome + "</br>CPF: " + PessoaAluno.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaAluno.Pes_CTrabalho + "</br>Salário: " + PessoaAluno.Pes_Salario + "</br>Cidade: " + PessoaAluno.Pes_Cidade + "</br>Endereço: " + PessoaAluno.Pes_Endereco + "</br>Data de Cadastro: " + PessoaAluno.Pes_DataCadastro + "</br>Cargo do Funcionário: " + CargoAluno.Car_Nome;
                    oErro.Err_RespostaCerta = "Funcionário:</br>Nome do Funcionário: " + PessoaProva.Pes_Nome + "</br>CPF: " + PessoaProva.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaProva.Pes_CTrabalho + "</br>Salário: " + PessoaProva.Pes_Salario + "</br>Cidade: " + PessoaProva.Pes_Cidade + "</br>Endereço: " + PessoaProva.Pes_Endereco + "</br>Data de Cadastro: " + PessoaProva.Pes_DataCadastro + "</br>Cargo do Funcionário: " + CargoProva.Car_Nome;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                CargoProva = _Control.SelecionarCargo(PessoaProva.Pes_Cargo_Car_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum funcionário cadastrado no dia " + PessoaProva.Pes_DataCadastro;
                oErro.Err_RespostaCerta = "Funcionário:</br>Nome do Funcionário: " + PessoaProva.Pes_Nome + "</br>CPF: " + PessoaProva.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaProva.Pes_CTrabalho + "</br>Salário: " + PessoaProva.Pes_Salario + "</br>Cidade: " + PessoaProva.Pes_Cidade + "</br>Endereço: " + PessoaProva.Pes_Endereco + "</br>Data de Cadastro: " + PessoaProva.Pes_DataCadastro + "</br>Cargo do Funcionário: " + CargoProva.Car_Nome;
            }

            //Funcionário 4
            PessoaProva = _Control.SelecionarFuncionario(aProva.Pro_Pessoa4);
            PessoaAluno = _Control.SelecionarPessoaDiaCadastro(PessoaProva.Pes_DataCadastro, aEmpresa.Emp_ID);

            if (PessoaAluno != null)
            {
                CargoProva = _Control.SelecionarCargo(PessoaProva.Pes_Cargo_Car_ID);
                CargoAluno = _Control.SelecionarCargo(PessoaAluno.Pes_Cargo_Car_ID);

                if (PessoaAluno.Pes_Nome.Trim() == PessoaProva.Pes_Nome.Trim() && PessoaAluno.Pes_CPF.Trim() == PessoaProva.Pes_CPF.Trim() && PessoaAluno.Pes_Cidade.Trim() == PessoaProva.Pes_Cidade.Trim() && PessoaAluno.Pes_Endereco.Trim() == PessoaProva.Pes_Endereco.Trim() && PessoaAluno.Pes_Salario == PessoaProva.Pes_Salario && CargoProva.Car_Nome.Trim() == CargoAluno.Car_Nome.Trim())
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Err_RespostaAluno = "Funcionário:</br>Nome do Funcionário: " + PessoaAluno.Pes_Nome + "</br>CPF: " + PessoaAluno.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaAluno.Pes_CTrabalho + "</br>Salário: " + PessoaAluno.Pes_Salario + "</br>Cidade: " + PessoaAluno.Pes_Cidade + "</br>Endereço: " + PessoaAluno.Pes_Endereco + "</br>Data de Cadastro: " + PessoaAluno.Pes_DataCadastro + "</br>Cargo do Funcionário: " + CargoAluno.Car_Nome;
                    oErro.Err_RespostaCerta = "Funcionário:</br>Nome do Funcionário: " + PessoaProva.Pes_Nome + "</br>CPF: " + PessoaProva.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaProva.Pes_CTrabalho + "</br>Salário: " + PessoaProva.Pes_Salario + "</br>Cidade: " + PessoaProva.Pes_Cidade + "</br>Endereço: " + PessoaProva.Pes_Endereco + "</br>Data de Cadastro: " + PessoaProva.Pes_DataCadastro + "</br>Cargo do Funcionário: " + CargoProva.Car_Nome;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                CargoProva = _Control.SelecionarCargo(PessoaProva.Pes_Cargo_Car_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum funcionário cadastrado no dia " + PessoaProva.Pes_DataCadastro;
                oErro.Err_RespostaCerta = "Funcionário:</br>Nome do Funcionário: " + PessoaProva.Pes_Nome + "</br>CPF: " + PessoaProva.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaProva.Pes_CTrabalho + "</br>Salário: " + PessoaProva.Pes_Salario + "</br>Cidade: " + PessoaProva.Pes_Cidade + "</br>Endereço: " + PessoaProva.Pes_Endereco + "</br>Data de Cadastro: " + PessoaProva.Pes_DataCadastro + "</br>Cargo do Funcionário: " + CargoProva.Car_Nome;
            }

            //Funcionário 5
            PessoaProva = _Control.SelecionarFuncionario(aProva.Pro_Pessoa5);
            PessoaAluno = _Control.SelecionarPessoaDiaCadastro(PessoaProva.Pes_DataCadastro, aEmpresa.Emp_ID);

            if (PessoaAluno != null)
            {
                CargoProva = _Control.SelecionarCargo(PessoaProva.Pes_Cargo_Car_ID);
                CargoAluno = _Control.SelecionarCargo(PessoaAluno.Pes_Cargo_Car_ID);

                if (PessoaAluno.Pes_Nome.Trim() == PessoaProva.Pes_Nome.Trim() && PessoaAluno.Pes_CPF.Trim() == PessoaProva.Pes_CPF.Trim() && PessoaAluno.Pes_Cidade.Trim() == PessoaProva.Pes_Cidade.Trim() && PessoaAluno.Pes_Endereco.Trim() == PessoaProva.Pes_Endereco.Trim() && PessoaAluno.Pes_Salario == PessoaProva.Pes_Salario && CargoProva.Car_Nome.Trim() == CargoAluno.Car_Nome.Trim())
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Err_RespostaAluno = "Funcionário:</br>Nome do Funcionário: " + PessoaAluno.Pes_Nome + "</br>CPF: " + PessoaAluno.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaAluno.Pes_CTrabalho + "</br>Salário: " + PessoaAluno.Pes_Salario + "</br>Cidade: " + PessoaAluno.Pes_Cidade + "</br>Endereço: " + PessoaAluno.Pes_Endereco + "</br>Data de Cadastro: " + PessoaAluno.Pes_DataCadastro + "</br>Cargo do Funcionário: " + CargoAluno.Car_Nome;
                    oErro.Err_RespostaCerta = "Funcionário:</br>Nome do Funcionário: " + PessoaProva.Pes_Nome + "</br>CPF: " + PessoaProva.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaProva.Pes_CTrabalho + "</br>Salário: " + PessoaProva.Pes_Salario + "</br>Cidade: " + PessoaProva.Pes_Cidade + "</br>Endereço: " + PessoaProva.Pes_Endereco + "</br>Data de Cadastro: " + PessoaProva.Pes_DataCadastro + "</br>Cargo do Funcionário: " + CargoProva.Car_Nome;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {
                CargoProva = _Control.SelecionarCargo(PessoaProva.Pes_Cargo_Car_ID);

                Erro oErro = new Erro();
                oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum funcionário cadastrado no dia " + PessoaProva.Pes_DataCadastro;
                oErro.Err_RespostaCerta = "Funcionário:</br>Nome do Funcionário: " + PessoaProva.Pes_Nome + "</br>CPF: " + PessoaProva.Pes_CPF + "</br>Carteira de Trabalho: " + PessoaProva.Pes_CTrabalho + "</br>Salário: " + PessoaProva.Pes_Salario + "</br>Cidade: " + PessoaProva.Pes_Cidade + "</br>Endereço: " + PessoaProva.Pes_Endereco + "</br>Data de Cadastro: " + PessoaProva.Pes_DataCadastro + "</br>Cargo do Funcionário: " + CargoProva.Car_Nome;
            }

            //Verifica Dependentes

            //Dependente 1
            DadoDependente DependenteProva = _Control.SelecionarDependente(aProva.Pro_DadoDependente1);
            DadoDependente DependenteAluno = _Control.SelecionarDependenteDiaCadastro(DependenteProva.DP_DataCadastro, aEmpresa.Emp_ID);

            if (DependenteAluno != null)
            {
                PessoaProva = _Control.SelecionarFuncionario(DependenteProva.DP_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarFuncionario(DependenteAluno.DP_Pessoa_Pes_ID);

                if (DependenteAluno.DP_Nome.Trim() == DependenteProva.DP_Nome && DependenteAluno.DP_Parentesco.Trim() == DependenteProva.DP_Parentesco.Trim() && PessoaProva.Pes_Nome.Trim() == PessoaAluno.Pes_Nome.Trim())
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_Codigo;
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
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum dependente cadastrado no dia " + DependenteProva.DP_DataCadastro;
                oErro.Err_RespostaCerta= "Dependente</br>Parente do Funcionário: " + PessoaProva.Pes_Nome + "</br>Nome do Dependente: " + DependenteProva.DP_Nome + "</br>Parentesco com o funcionário: " + DependenteProva.DP_Parentesco + "</br>Data de Cadastro: " + DependenteProva.DP_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            //Dependente 2
            DependenteProva = _Control.SelecionarDependente(aProva.Pro_DadoDependente2);
            DependenteAluno = _Control.SelecionarDependenteDiaCadastro(DependenteProva.DP_DataCadastro, aEmpresa.Emp_ID);

            if (DependenteAluno != null)
            {
                PessoaProva = _Control.SelecionarFuncionario(DependenteProva.DP_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarFuncionario(DependenteAluno.DP_Pessoa_Pes_ID);

                if (DependenteAluno.DP_Nome.Trim() == DependenteProva.DP_Nome && DependenteAluno.DP_Parentesco.Trim() == DependenteProva.DP_Parentesco.Trim() && PessoaProva.Pes_Nome.Trim() == PessoaAluno.Pes_Nome.Trim())
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_Codigo;
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
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum dependente cadastrado no dia " + DependenteProva.DP_DataCadastro;
                oErro.Err_RespostaCerta = "Dependente</br>Parente do Funcionário: " + PessoaProva.Pes_Nome + "</br>Nome do Dependente: " + DependenteProva.DP_Nome + "</br>Parentesco com o funcionário: " + DependenteProva.DP_Parentesco + "</br>Data de Cadastro: " + DependenteProva.DP_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            //Dependente 3
            DependenteProva = _Control.SelecionarDependente(aProva.Pro_DadoDependente3);
            DependenteAluno = _Control.SelecionarDependenteDiaCadastro(DependenteProva.DP_DataCadastro, aEmpresa.Emp_ID);

            if (DependenteAluno != null)
            {
                PessoaProva = _Control.SelecionarFuncionario(DependenteProva.DP_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarFuncionario(DependenteAluno.DP_Pessoa_Pes_ID);

                if (DependenteAluno.DP_Nome.Trim() == DependenteProva.DP_Nome && DependenteAluno.DP_Parentesco.Trim() == DependenteProva.DP_Parentesco.Trim() && PessoaProva.Pes_Nome.Trim() == PessoaAluno.Pes_Nome.Trim())
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_Codigo;
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
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum dependente cadastrado no dia " + DependenteProva.DP_DataCadastro;
                oErro.Err_RespostaCerta = "Dependente</br>Parente do Funcionário: " + PessoaProva.Pes_Nome + "</br>Nome do Dependente: " + DependenteProva.DP_Nome + "</br>Parentesco com o funcionário: " + DependenteProva.DP_Parentesco + "</br>Data de Cadastro: " + DependenteProva.DP_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            //Dependente 4
            DependenteProva = _Control.SelecionarDependente(aProva.Pro_DadoDependete4);
            DependenteAluno = _Control.SelecionarDependenteDiaCadastro(DependenteProva.DP_DataCadastro, aEmpresa.Emp_ID);

            if (DependenteAluno != null)
            {
                PessoaProva = _Control.SelecionarFuncionario(DependenteProva.DP_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarFuncionario(DependenteAluno.DP_Pessoa_Pes_ID);

                if (DependenteAluno.DP_Nome.Trim() == DependenteProva.DP_Nome && DependenteAluno.DP_Parentesco.Trim() == DependenteProva.DP_Parentesco.Trim() && PessoaProva.Pes_Nome.Trim() == PessoaAluno.Pes_Nome.Trim())
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_Codigo;
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
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum dependente cadastrado no dia " + DependenteProva.DP_DataCadastro;
                oErro.Err_RespostaCerta = "Dependente</br>Parente do Funcionário: " + PessoaProva.Pes_Nome + "</br>Nome do Dependente: " + DependenteProva.DP_Nome + "</br>Parentesco com o funcionário: " + DependenteProva.DP_Parentesco + "</br>Data de Cadastro: " + DependenteProva.DP_DataCadastro;
                _Control.CadastrarErro(oErro);
            }

            //Dependente 5
            DependenteProva = _Control.SelecionarDependente(aProva.Pro_DadoDependete5);
            DependenteAluno = _Control.SelecionarDependenteDiaCadastro(DependenteProva.DP_DataCadastro, aEmpresa.Emp_ID);

            if (DependenteAluno != null)
            {
                PessoaProva = _Control.SelecionarFuncionario(DependenteProva.DP_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarFuncionario(DependenteAluno.DP_Pessoa_Pes_ID);

                if (DependenteAluno.DP_Nome.Trim() == DependenteProva.DP_Nome && DependenteAluno.DP_Parentesco.Trim() == DependenteProva.DP_Parentesco.Trim() && PessoaProva.Pes_Nome.Trim() == PessoaAluno.Pes_Nome.Trim())
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_Codigo;
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
                PessoaProva = _Control.SelecionarFuncionario(DadoBancarioProva.DB_ID);
                PessoaAluno = _Control.SelecionarFuncionario(DadoBancarioAluno.DB_ID);

                if (DadoBancarioAluno.DB_Numero == DadoBancarioProva.DB_Numero && DadoBancarioAluno.DB_Tipo.Trim() == DadoBancarioProva.DB_Tipo.Trim() && PessoaProva.Pes_Nome.Trim() == PessoaAluno.Pes_Nome.Trim())
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
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
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum Dado Bancário cadastrado no dia " + DadoBancarioProva.DB_DataCadastro;
                oErro.Err_RespostaCerta = "Dado Bancário:</br>Dado do Funcionário: " + PessoaProva.Pes_Nome + "</br>Tipo: " + DadoBancarioProva.DB_Tipo + "</br>Número: " + DadoBancarioProva.DB_Numero + "</br>Data de Cadastro: " + DadoBancarioProva.DB_DataCadastro;
            }

            //Dado Bancário 2
            DadoBancarioProva = _Control.SelecionarDadoBancario(aProva.Pro_DadoBancario2);
            DadoBancarioAluno = _Control.SelecionarDadoBancarioDataCadastro(DadoBancarioProva.DB_DataCadastro, aEmpresa.Emp_ID);

            if (DadoBancarioAluno != null)
            {
                PessoaProva = _Control.SelecionarFuncionario(DadoBancarioProva.DB_ID);
                PessoaAluno = _Control.SelecionarFuncionario(DadoBancarioAluno.DB_ID);

                if (DadoBancarioAluno.DB_Numero == DadoBancarioProva.DB_Numero && DadoBancarioAluno.DB_Tipo.Trim() == DadoBancarioProva.DB_Tipo.Trim() && PessoaProva.Pes_Nome.Trim() == PessoaAluno.Pes_Nome.Trim())
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
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
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum Dado Bancário cadastrado no dia " + DadoBancarioProva.DB_DataCadastro;
                oErro.Err_RespostaCerta = "Dado Bancário:</br>Dado do Funcionário: " + PessoaProva.Pes_Nome + "</br>Tipo: " + DadoBancarioProva.DB_Tipo + "</br>Número: " + DadoBancarioProva.DB_Numero + "</br>Data de Cadastro: " + DadoBancarioProva.DB_DataCadastro;
            }

            //Dado Bancário 3
            DadoBancarioProva = _Control.SelecionarDadoBancario(aProva.Pro_DadoBancario3);
            DadoBancarioAluno = _Control.SelecionarDadoBancarioDataCadastro(DadoBancarioProva.DB_DataCadastro, aEmpresa.Emp_ID);

            if (DadoBancarioAluno != null)
            {
                PessoaProva = _Control.SelecionarFuncionario(DadoBancarioProva.DB_ID);
                PessoaAluno = _Control.SelecionarFuncionario(DadoBancarioAluno.DB_ID);

                if (DadoBancarioAluno.DB_Numero == DadoBancarioProva.DB_Numero && DadoBancarioAluno.DB_Tipo.Trim() == DadoBancarioProva.DB_Tipo.Trim() && PessoaProva.Pes_Nome.Trim() == PessoaAluno.Pes_Nome.Trim())
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
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
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum Dado Bancário cadastrado no dia " + DadoBancarioProva.DB_DataCadastro;
                oErro.Err_RespostaCerta = "Dado Bancário:</br>Dado do Funcionário: " + PessoaProva.Pes_Nome + "</br>Tipo: " + DadoBancarioProva.DB_Tipo + "</br>Número: " + DadoBancarioProva.DB_Numero + "</br>Data de Cadastro: " + DadoBancarioProva.DB_DataCadastro;
            }

            //Dado Bancário 4
            DadoBancarioProva = _Control.SelecionarDadoBancario(aProva.Pro_DadoBancario4);
            DadoBancarioAluno = _Control.SelecionarDadoBancarioDataCadastro(DadoBancarioProva.DB_DataCadastro, aEmpresa.Emp_ID);

            if (DadoBancarioAluno != null)
            {
                PessoaProva = _Control.SelecionarFuncionario(DadoBancarioProva.DB_ID);
                PessoaAluno = _Control.SelecionarFuncionario(DadoBancarioAluno.DB_ID);

                if (DadoBancarioAluno.DB_Numero == DadoBancarioProva.DB_Numero && DadoBancarioAluno.DB_Tipo.Trim() == DadoBancarioProva.DB_Tipo.Trim() && PessoaProva.Pes_Nome.Trim() == PessoaAluno.Pes_Nome.Trim())
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
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
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum Dado Bancário cadastrado no dia " + DadoBancarioProva.DB_DataCadastro;
                oErro.Err_RespostaCerta = "Dado Bancário:</br>Dado do Funcionário: " + PessoaProva.Pes_Nome + "</br>Tipo: " + DadoBancarioProva.DB_Tipo + "</br>Número: " + DadoBancarioProva.DB_Numero + "</br>Data de Cadastro: " + DadoBancarioProva.DB_DataCadastro;
            }

            //Dado Bancário 5
            DadoBancarioProva = _Control.SelecionarDadoBancario(aProva.Pro_DadoBancario5);
            DadoBancarioAluno = _Control.SelecionarDadoBancarioDataCadastro(DadoBancarioProva.DB_DataCadastro, aEmpresa.Emp_ID);

            if (DadoBancarioAluno != null)
            {
                PessoaProva = _Control.SelecionarFuncionario(DadoBancarioProva.DB_ID);
                PessoaAluno = _Control.SelecionarFuncionario(DadoBancarioAluno.DB_ID);

                if (DadoBancarioAluno.DB_Numero == DadoBancarioProva.DB_Numero && DadoBancarioAluno.DB_Tipo.Trim() == DadoBancarioProva.DB_Tipo.Trim() && PessoaProva.Pes_Nome.Trim() == PessoaAluno.Pes_Nome.Trim())
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
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
                oErro.Err_RespostaAluno = "Não foi encontrado nenhum Dado Bancário cadastrado no dia " + DadoBancarioProva.DB_DataCadastro;
                oErro.Err_RespostaCerta = "Dado Bancário:</br>Dado do Funcionário: " + PessoaProva.Pes_Nome + "</br>Tipo: " + DadoBancarioProva.DB_Tipo + "</br>Número: " + DadoBancarioProva.DB_Numero + "</br>Data de Cadastro: " + DadoBancarioProva.DB_DataCadastro;
            }

            //Verifica Benefícios

            

            //Verifica Benefícios do Funcionário
            

            //Verifica Avaliações dos Funcionários

            //Avaliação 1
            Avaliacao AvaliacaoProva = _Control.SelecionarAvaliacao(aProva.Pro_AvaliacaoFuncionario1);
            Avaliacao AvaliacaoAluno = _Control.SelecionarAvaliacaoDiaCadastro(AvaliacaoProva.Ava_DataCadastro, aEmpresa.Emp_ID);

            if (AvaliacaoAluno != null)
            {
                PessoaProva = _Control.SelecionarFuncionario(AvaliacaoProva.Ava_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarFuncionario(AvaliacaoAluno.Ava_Pessoa_Pes_ID);

                if (AvaliacaoAluno.Ava_Avaliacao.Trim() == AvaliacaoProva.Ava_Avaliacao.Trim() && PessoaProva.Pes_Nome.Trim() == PessoaAluno.Pes_Nome.Trim())
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
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
                oErro.Err_RespostaAluno = "Não foi encontrado nenhuma Avaliação de Funcionário no dia " + AvaliacaoProva.Ava_DataCadastro;
                oErro.Err_RespostaCerta= "Avaliação:</br>Avaliação do Funcionário: " + PessoaProva.Pes_Nome + "</br>Data de Cadastro: " + AvaliacaoProva.Ava_DataCadastro + "</br>Avaliação: " + AvaliacaoProva.Ava_Avaliacao;
                _Control.CadastrarErro(oErro);
            }

            //Avaliação 2
            AvaliacaoProva = _Control.SelecionarAvaliacao(aProva.Pro_AvaliacaoFuncionario2);
            AvaliacaoAluno = _Control.SelecionarAvaliacaoDiaCadastro(AvaliacaoProva.Ava_DataCadastro, aEmpresa.Emp_ID);

            if (AvaliacaoAluno != null)
            {
                PessoaProva = _Control.SelecionarFuncionario(AvaliacaoProva.Ava_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarFuncionario(AvaliacaoAluno.Ava_Pessoa_Pes_ID);

                if (AvaliacaoAluno.Ava_Avaliacao.Trim() == AvaliacaoProva.Ava_Avaliacao.Trim() && PessoaProva.Pes_Nome.Trim() == PessoaAluno.Pes_Nome.Trim())
                {
                    Nota = Nota + 0.4;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
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
                oErro.Err_RespostaAluno = "Não foi encontrado nenhuma Avaliação de Funcionário no dia " + AvaliacaoProva.Ava_DataCadastro;
                oErro.Err_RespostaCerta = "Avaliação:</br>Avaliação do Funcionário: " + PessoaProva.Pes_Nome + "</br>Data de Cadastro: " + AvaliacaoProva.Ava_DataCadastro + "</br>Avaliação: " + AvaliacaoProva.Ava_Avaliacao;
                _Control.CadastrarErro(oErro);
            }

            //Avaliação 3
            AvaliacaoProva = _Control.SelecionarAvaliacao(aProva.Pro_AvaliacaoFuncionario3);
            AvaliacaoAluno = _Control.SelecionarAvaliacaoDiaCadastro(AvaliacaoProva.Ava_DataCadastro, aEmpresa.Emp_ID);

            if (AvaliacaoAluno != null)
            {
                PessoaProva = _Control.SelecionarFuncionario(AvaliacaoProva.Ava_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarFuncionario(AvaliacaoAluno.Ava_Pessoa_Pes_ID);

                if (AvaliacaoAluno.Ava_Avaliacao.Trim() == AvaliacaoProva.Ava_Avaliacao.Trim() && PessoaProva.Pes_Nome.Trim() == PessoaAluno.Pes_Nome.Trim())
                {
                    Nota = Nota + 0.4;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
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
                oErro.Err_RespostaAluno = "Não foi encontrado nenhuma Avaliação de Funcionário no dia " + AvaliacaoProva.Ava_DataCadastro;
                oErro.Err_RespostaCerta = "Avaliação:</br>Avaliação do Funcionário: " + PessoaProva.Pes_Nome + "</br>Data de Cadastro: " + AvaliacaoProva.Ava_DataCadastro + "</br>Avaliação: " + AvaliacaoProva.Ava_Avaliacao;
                _Control.CadastrarErro(oErro);
            }

            //Avaliação 4
            AvaliacaoProva = _Control.SelecionarAvaliacao(aProva.Pro_AvaliacaoFuncionario4);
            AvaliacaoAluno = _Control.SelecionarAvaliacaoDiaCadastro(AvaliacaoProva.Ava_DataCadastro, aEmpresa.Emp_ID);

            if (AvaliacaoAluno != null)
            {
                PessoaProva = _Control.SelecionarFuncionario(AvaliacaoProva.Ava_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarFuncionario(AvaliacaoAluno.Ava_Pessoa_Pes_ID);

                if (AvaliacaoAluno.Ava_Avaliacao.Trim() == AvaliacaoProva.Ava_Avaliacao.Trim() && PessoaProva.Pes_Nome.Trim() == PessoaAluno.Pes_Nome.Trim())
                {
                    Nota = Nota + 0.4;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
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
                PessoaProva = _Control.SelecionarFuncionario(DemissaoProva.Dem_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarFuncionario(DemissaoAluno.Dem_Pessoa_Pes_ID);

                if (DemissaoAluno.Dem_Motivo.Trim() == DemissaoProva.Dem_Motivo && DemissaoAluno.Dem_Salario == DemissaoProva.Dem_Salario && PessoaAluno.Pes_Nome.Trim() == PessoaProva.Pes_Nome.Trim())
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Err_RespostaAluno = "Demissao:</br>Demissão do Funcionário: " + PessoaAluno.Pes_Nome + "</br>Data da Demissão: " + DemissaoAluno.Dem_DataCadastro + "</br>Motivo da Demissao: " + DemissaoAluno.Dem_Motivo;
                    oErro.Err_RespostaCerta= "Demissao:</br>Demissão do Funcionário: " + PessoaProva.Pes_Nome + "</br>Data da Demissão: " + DemissaoProva.Dem_DataCadastro + "</br>Motivo da Demissao: " + DemissaoProva.Dem_Motivo;
                    _Control.CadastrarErro(oErro);
                }
            }

            else
            {

            }

            //Demissao 2
            DemissaoProva = _Control.SelecionarDemissao(aProva.Pro_Demissao2);
            DemissaoAluno = _Control.SelecionarDemissaoDataCadastro(DemissaoProva.Dem_DataCadastro, aEmpresa.Emp_ID);

            if (DemissaoAluno != null)
            {
                PessoaProva = _Control.SelecionarFuncionario(DemissaoProva.Dem_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarFuncionario(DemissaoAluno.Dem_Pessoa_Pes_ID);

                if (DemissaoAluno.Dem_Motivo.Trim() == DemissaoProva.Dem_Motivo && DemissaoAluno.Dem_Salario == DemissaoProva.Dem_Salario && PessoaAluno.Pes_Nome.Trim() == PessoaProva.Pes_Nome.Trim())
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Err_RespostaAluno = "Demissao:</br>Demissão do Funcionário: " + PessoaAluno.Pes_Nome + "</br>Data da Demissão: " + DemissaoAluno.Dem_DataCadastro + "</br>Motivo da Demissao: " + DemissaoAluno.Dem_Motivo;
                    oErro.Err_RespostaCerta = "Demissao:</br>Demissão do Funcionário: " + PessoaProva.Pes_Nome + "</br>Data da Demissão: " + DemissaoProva.Dem_DataCadastro + "</br>Motivo da Demissao: " + DemissaoProva.Dem_Motivo;
                    _Control.CadastrarErro(oErro);
                }
            }

            //Demissao 3
            DemissaoProva = _Control.SelecionarDemissao(aProva.Pro_Demissao3);
            DemissaoAluno = _Control.SelecionarDemissaoDataCadastro(DemissaoProva.Dem_DataCadastro, aEmpresa.Emp_ID);

            if (DemissaoAluno != null)
            {
                PessoaProva = _Control.SelecionarFuncionario(DemissaoProva.Dem_Pessoa_Pes_ID);
                PessoaAluno = _Control.SelecionarFuncionario(DemissaoAluno.Dem_Pessoa_Pes_ID);

                if (DemissaoAluno.Dem_Motivo.Trim() == DemissaoProva.Dem_Motivo && DemissaoAluno.Dem_Salario == DemissaoProva.Dem_Salario && PessoaAluno.Pes_Nome.Trim() == PessoaProva.Pes_Nome.Trim())
                {
                    Nota = Nota + 0.2;
                }

                else
                {
                    Erro oErro = new Erro();
                    oErro.Err_Prova_Pro_ID = aProva.Pro_ID;
                    oErro.Err_RespostaAluno = "Demissao:</br>Demissão do Funcionário: " + PessoaAluno.Pes_Nome + "</br>Data da Demissão: " + DemissaoAluno.Dem_DataCadastro + "</br>Motivo da Demissao: " + DemissaoAluno.Dem_Motivo;
                    oErro.Err_RespostaCerta = "Demissao:</br>Demissão do Funcionário: " + PessoaProva.Pes_Nome + "</br>Data da Demissão: " + DemissaoProva.Dem_DataCadastro + "</br>Motivo da Demissao: " + DemissaoProva.Dem_Motivo;
                    _Control.CadastrarErro(oErro);
                }
            }

            aNota.Not_Nota = Nota;
            _Control.CadastrarNota(aNota);
        }

        public ActionResult Notas(int CodigoProva)
        {
            List<VW_Notas> NotasProva = _Control.SelecionarNotasProva();

            List<VW_Notas> FiltroNotasProva = NotasProva.Where(p => p.CodigoProva.Equals(CodigoProva)).ToList();
            return View(FiltroNotasProva);
        }
    }
}


