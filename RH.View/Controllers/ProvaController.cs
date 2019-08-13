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

            List<Prova> Provas = _Control.SelecionarTodasProva();
            return View(Provas);
        }

        public ActionResult CadastrarProva(string DataTermino)
        {
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

            Empresa aEmpresa = _Control.SelecionarEmpresaAvaliativaAluno(oAluno.Alu_ID);
            aEmpresa.Emp_Situation = false;
            _Control.AlterarEmpresa(aEmpresa);  


            return Json("Sua prova foi entregada, a próxima vez que acessar a plataforma você terá acesso a sua nota");
        }

        public ActionResult CalcularNotas()
        {
            List<Aluno> Alunos = _Control.SelecionarTodosAlunos();

            foreach(var x in Alunos)
            {
                Prova aProva = _Control.SelecionarProvaAluno(x.Alu_ID);
                Empresa aEmpresa = _Control.SelecionarEmpresaAvaliativaAluno(x.Alu_ID);

                double Nota = 0;

                Nota aNota = new Nota();
                aNota.Not_DataCadastro = DateTime.Now;
                aNota.Not_Prova_Pro_ID = aProva.Pro_ID;

                //Verifica os Setores

                //Setor 1
                Setor SetorProva = _Control.SelecionarSetor(aProva.Pro_Setor1);
                Setor SetorAluno = _Control.SelecionarSetorDiaCadastro(SetorProva.Set_DataCadastro, aEmpresa.Emp_ID);

                if(SetorAluno!=null)
                {
                    if(SetorAluno.Set_Nome.Trim()==SetorProva.Set_Nome.Trim())
                    {
                        Nota = Nota + 0.2;
                    }
                }

                //Setor 2
                SetorProva = _Control.SelecionarSetor(aProva.Pro_Setor2);
                SetorAluno = _Control.SelecionarSetorDiaCadastro(SetorProva.Set_DataCadastro, aEmpresa.Emp_ID);
                if (SetorAluno != null)
                {
                    if (SetorAluno.Set_Nome.Trim() == SetorProva.Set_Nome.Trim())
                    {
                        Nota = Nota + 0.2;
                    }
                }

                //Setor 3
                SetorProva = _Control.SelecionarSetor(aProva.Pro_Setor3);
                SetorAluno = _Control.SelecionarSetorDiaCadastro(SetorProva.Set_DataCadastro, aEmpresa.Emp_ID);
                if (SetorAluno != null)
                {
                    if (SetorAluno.Set_Nome.Trim() == SetorProva.Set_Nome.Trim())
                    {
                        Nota = Nota + 0.2;
                    }
                }

                //Setor 4
                SetorProva = _Control.SelecionarSetor(aProva.Pro_Setor4);
                SetorAluno = _Control.SelecionarSetorDiaCadastro(SetorProva.Set_DataCadastro, aEmpresa.Emp_ID);
                if (SetorAluno != null)
                {
                    if (SetorAluno.Set_Nome.Trim() == SetorProva.Set_Nome.Trim())
                    {
                        Nota = Nota + 0.2;
                    }
                }

                //Setor 5
                SetorProva = _Control.SelecionarSetor(aProva.Pro_Setor5);
                SetorAluno = _Control.SelecionarSetorDiaCadastro(SetorProva.Set_DataCadastro, aEmpresa.Emp_ID);
                if (SetorAluno != null)
                {
                    if (SetorAluno.Set_Nome.Trim() == SetorProva.Set_Nome.Trim())
                    {
                        Nota = Nota + 0.2;
                    }
                }


                //Verifica Cargos

                //Cargo 1
                Cargo CargoProva = _Control.SelecionarCargo(aProva.Pro_Cargo1);
                Cargo CargoAluno = _Control.SelecionarCargoDiaCadastro(CargoProva.Car_DataCadastro, aEmpresa.Emp_ID);
               
               
                if(CargoAluno!=null)
                {
                    SetorProva = _Control.SelecionarSetor(CargoProva.Car_Setor_Set_ID);
                    SetorAluno = _Control.SelecionarSetor(CargoAluno.Car_Setor_Set_ID);

                    if(CargoAluno.Car_Nome.Trim()==CargoProva.Car_Nome.Trim() && CargoAluno.Car_Chefe==CargoProva.Car_Chefe && SetorProva.Set_Nome==SetorAluno.Set_Nome)
                    {
                        Nota = Nota + 0.2;
                    }
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
                }

                //Verificar Funcionarios

                //Funcionario 1
                Pessoa PessoaProva = _Control.SelecionarFuncionario(aProva.Pro_Pessoa1);
                Pessoa PessoaAluno = _Control.SelecionarPessoaDiaCadastro(PessoaProva.Pes_DataCadastro, aEmpresa.Emp_ID);

                if(PessoaAluno!=null)
                {
                    CargoProva = _Control.SelecionarCargo(PessoaProva.Pes_Cargo_Car_ID);
                    CargoAluno = _Control.SelecionarCargo(PessoaAluno.Pes_Cargo_Car_ID);

                    if(PessoaAluno.Pes_Nome.Trim()==PessoaProva.Pes_Nome.Trim() && PessoaAluno.Pes_CPF.Trim()==PessoaProva.Pes_CPF.Trim() && PessoaAluno.Pes_Cidade.Trim()==PessoaProva.Pes_Cidade.Trim() && PessoaAluno.Pes_Endereco.Trim()==PessoaProva.Pes_Endereco.Trim() && PessoaAluno.Pes_Salario==PessoaProva.Pes_Salario && CargoProva.Car_Nome.Trim()==CargoAluno.Car_Nome.Trim())
                    {
                        Nota = Nota + 0.2;
                    }
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
                }

                //Verifica Dependentes


            }

            return Json("Todas as notas foram calculadas com sucesso!");
        }
    }
}
