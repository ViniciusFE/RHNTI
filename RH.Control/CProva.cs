using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RH.Model;
using RH.Model.Repositories;

namespace RH.Control
{
    public class CProva
    {
        RepositorieProva _RepositorieProva;
        RepositorieAluno _RepositorieAluno;
        RepositoriePessoa _RepositoriePessoa;
        RepositorieDependente _RepositorieDependente;
        RepositorieDadosBancarios _RepositorieDadoBancario;
        RepositoriePessoaBeneficio _RepositoriePessoaBeneficio;
        RepositorieAvaliacao _RepositorieAvaliacao;
        RepositorieDemissao _RepositorieDemissao;
        RepositorieEmpresa _RepositorieEmpresa;
        RepositorieSetor _RepositorieSetor;
        RepositorieCargo _RepositorieCargo;
        RepositorieBeneficio _RepositorieBeneficio;
        RepositorieNota _RepositorieNota;
        RepositorieErro _RepositorieErro;
        RepositorieCurso _RepositorieCurso;
        RepositorieVaga _RepositorieVaga;
        

        public CProva()
        {
            _RepositorieProva = new RepositorieProva();
            _RepositorieAluno = new RepositorieAluno();
            _RepositoriePessoa = new RepositoriePessoa();
            _RepositorieDependente = new RepositorieDependente();
            _RepositorieDadoBancario = new RepositorieDadosBancarios();
            _RepositoriePessoaBeneficio = new RepositoriePessoaBeneficio();
            _RepositorieAvaliacao = new RepositorieAvaliacao();
            _RepositorieDemissao = new RepositorieDemissao();
            _RepositorieEmpresa = new RepositorieEmpresa();
            _RepositorieSetor = new RepositorieSetor();
            _RepositorieCargo = new RepositorieCargo();
            _RepositorieBeneficio = new RepositorieBeneficio();
            _RepositorieNota = new RepositorieNota();
            _RepositorieErro = new RepositorieErro();
            _RepositorieCurso = new RepositorieCurso();
            _RepositorieVaga = new RepositorieVaga();
        }

        public void CadastrarProva(Prova aProva)
        {
            _RepositorieProva.CadastrarProva(aProva);
        }

        public List<Aluno> SelecionarTodosAlunos()
        {
            return _RepositorieAluno.SelecionarTodosAlunos(DateTime.Now.Year);
        }

        public void CadastrarFuncionario(Pessoa aPessoa)
        {
            _RepositoriePessoa.CadastrarFuncionario(aPessoa);
        }

        public void CadastrarDependente(DadoDependente Dependente)
        {
            _RepositorieDependente.CadastrarDependente(Dependente);
        }

        public void CadastrarDadoBancario(DadoBancario oDado)
        {
            _RepositorieDadoBancario.CadastrarDadoBancario(oDado);
        }

        public void CadastrarBeneficioFuncionario(PessoaBeneficio BeneficioFuncionario)
        {
            _RepositoriePessoaBeneficio.CadastrarBeneficioFuncionario(BeneficioFuncionario);
        }

        public void CadastrarAvaliacao(Avaliacao aAvaliacao)
        {
            _RepositorieAvaliacao.CadastrarAvaliacao(aAvaliacao);
        }

        public Pessoa SelecionarFuncionario(int id)
        {
            return _RepositoriePessoa.SelecionarFuncionario(id);
        }

        public void CadastrarDemissao(Demissao aDemissao)
        {
            _RepositorieDemissao.CadastrarDemissao(aDemissao);
        }

        public int QuantidadeProvas()
        {
            return _RepositorieProva.QuantidadeProvas();
        }

        public List<VW_Provas> SelecionarTodasProva()
        {
            return _RepositorieProva.SelecionarProvas();
        }

        public Prova SelecionarProvaAluno(int IDAluno)
        {
            return _RepositorieProva.SelecionarProvaAluno(IDAluno);
        }

        public Aluno SelecionarAluno(int id)
        {
            return _RepositorieAluno.SelecionarAluno(id);
        }

        public Empresa SelecionarEmpresaAvaliativaAluno(int IDAluno)
        {
            return _RepositorieEmpresa.SelecionarEmpresaAvaliativaAluno(IDAluno);
        }

        public void AlterarProva(Prova aProva)
        {
            _RepositorieProva.AlterarProva(aProva);
        }

        public void AlterarEmpresa(Empresa aEmpresa)
        {
            _RepositorieEmpresa.AlterarEmpresa(aEmpresa);
        }

        public Setor SelecionarSetor(int id)
        {
            return _RepositorieSetor.SelecionarSetor(id);
        }

        public Setor SelecionarSetorDiaCadastro(string DataCadastro,int IDEmpresa)
        {
            return _RepositorieSetor.SelecionarSetorDiaCadastro(DataCadastro, IDEmpresa);
        }

        public Cargo SelecionarCargo(int id)
        {
            return _RepositorieCargo.SelecionarCargo(id);
        }

        public Cargo SelecionarCargoDiaCadastro(string DiaCadastro,int IDEmpresa)
        {
            return _RepositorieCargo.SelecionarCargoDiaCadastro(DiaCadastro, IDEmpresa);
        }

        public Pessoa SelecionarPessoaDiaCadastro(string DiaCadastro,int IDEmpresa)
        {
            return _RepositoriePessoa.SelecionarPessoaDiaCadastro(DiaCadastro, IDEmpresa);
        }

        public DadoDependente SelecionarDependente(int id)
        {
            return _RepositorieDependente.SelecionarDadoDependente(id);
        }

        public DadoDependente SelecionarDependenteDiaCadastro(string DataCadastro,int IDEmpresa)
        {
            return _RepositorieDependente.SelecionarDependenteDataCadastro(DataCadastro, IDEmpresa);
        }

        public DadoBancario SelecionarDadoBancario(int id)
        {
            return _RepositorieDadoBancario.SelecionarDadoBancario(id);
        }

        public DadoBancario SelecionarDadoBancarioDataCadastro(string DataCadastro, int IDEmpresa)
        {
            return _RepositorieDadoBancario.SelecionarDadoBancarioDataCadastro(DataCadastro, IDEmpresa);
        }

        public Beneficio SelecionarBeneficio(int id)
        {
            return _RepositorieBeneficio.SelecionarBeneficioporID(id);
        }

        public List<Beneficio> SelecionarBeneficiosAluno(int IDEmpresa)
        {
            return _RepositorieBeneficio.SelecionarBeneficioporEmpresa(IDEmpresa);
        }

        public PessoaBeneficio SelecionarBeneficioFuncionario(int IDBeneficio)
        {
            return _RepositoriePessoaBeneficio.SelecionarBeneficio(IDBeneficio);
        }

        public List<PessoaBeneficio> SelecionarBeneficiosFuncionariosEmpresa(int IDEmpresa)
        {
            return _RepositoriePessoaBeneficio.SelecionarBeneficiosFuncionariosEmpresa(IDEmpresa);
        }

        public Avaliacao SelecionarAvaliacao(int id)
        {
            return _RepositorieAvaliacao.SelecionarAvaliacao(id);
        }

        public Avaliacao SelecionarAvaliacaoDiaCadastro(string DataCadastro,int IDEmpresa)
        {
            return _RepositorieAvaliacao.SelecionarAvaliacaoDiaCadastro(DataCadastro, IDEmpresa);
        }

        public Demissao SelecionarDemissao(int id)
        {
            return _RepositorieDemissao.SelecionarDemissao(id);
        }

        public Demissao SelecionarDemissaoDataCadastro(string DataCadastro,int IDEmpresa)
        {
            return _RepositorieDemissao.SelecionarDemissaoDataCadastro(DataCadastro, IDEmpresa);
        }

        public void CadastrarNota(Nota aNota)
        {
            _RepositorieNota.CadastrarNota(aNota);
        }

        public bool ProvaAtiva()
        {
            return _RepositorieProva.ProvaAtiva();
        }

        public bool EmpresaAvaliativaAtiva(int IDUsuario)
        {
            return _RepositorieEmpresa.EmpresaAvaliativaAtiva(IDUsuario);
        }

        public List<Nota> SelecionarNotas(int CodigoProva)
        {
            return _RepositorieNota.SelecionarTodasNotasProva(CodigoProva);
        }

        public List<VW_Notas> SelecionarNotasProva()
        {
            return _RepositorieNota.SelecionarNotasProva();
        }

        public List<Aluno> SelecionarAlunosProva(int CodigoProva)
        {
            return _RepositorieAluno.SelecionarAlunosProva(CodigoProva);
        }

        public List<Prova> SelecionarProvaPeloCodigo(int CodigoProva)
        {
            return _RepositorieProva.SelecionarProvasPeloCodigo(CodigoProva);
        }

        public void CadastrarErro(Erro oErro)
        {
            _RepositorieErro.CadastrarErro(oErro);
        }

        public List<PessoaBeneficio> SelecionarBeneficiosFuncionarioDiaCadastro(string DataCadastro,int IDEmpresa)
        {
            return _RepositoriePessoaBeneficio.SelecionarBeneficiosFuncionarioDiaCadastro(DataCadastro, IDEmpresa);
        }

        public List<Erro> SelecionarErrosProva(int IDProva)
        {
            return _RepositorieErro.SelecionarErroProva(IDProva);
        }

        public Prova SelecionarProvaPorID(int IDProva)
        {
            return _RepositorieProva.SelecionarProvaPorID(IDProva);
        }

        public Nota SelecionarNotaProva(int IDProva)
        {
            return _RepositorieNota.SelecionarNota(IDProva);
        }

        public Curso SelecionarCurso(int id)
        {
            return _RepositorieCurso.SelecionarCurso(id);
        }

        public List<Beneficio> SelecionarBeneficiosEmpresa(int IDEmpresa)
        {
            return _RepositorieBeneficio.SelecionarBeneficioporEmpresa(IDEmpresa);
        }

        public Aluno AlunoProva()
        {
            return _RepositorieAluno.AlunoProva();
        }

        public void CadastrarAluno(Aluno oAluno)
        {
            _RepositorieAluno.CadastrarAluno(oAluno);
        }

        public Empresa EmpresaAlunoProva()
        {
            return _RepositorieEmpresa.EmpresaAlunoProva();
        }

        public void CadastrarEmpresa(Empresa aEmpresa)
        {
            _RepositorieEmpresa.CadastrarEmpresa(aEmpresa);
        }

        public void CadastrarSetor(Setor oSetor)
        {
            _RepositorieSetor.CadastrarSetor(oSetor);
        }

        public void CadastrarCargo(Cargo oCargo)
        {
            _RepositorieCargo.CadastrarCargo(oCargo);
        }

        public void CadastrarBeneficio(Beneficio oBeneficio)
        {
            _RepositorieBeneficio.Incluir(oBeneficio);
        }

        public void AlterarSetor(Setor oSetor)
        {
            _RepositorieSetor.AlterarSetor(oSetor);
        }

        public Pessoa SelecionarPessoa(int IDFuncionario)
        {
            return _RepositoriePessoa.SelecionarPessoa(IDFuncionario);
        }

        public void CadastrarVaga(Vaga aVaga)
        {
            _RepositorieVaga.CadastrarVaga(aVaga);
        }

        public Vaga SelecionarVaga(int id)
        {
            return _RepositorieVaga.SelecionarVaga(id);
        }

        public Vaga SelecionarVagaDataCadastro(string DataCadastro,int IDEmpresa)
        {
            return _RepositorieVaga.SelecionarVagaDiaCadastro(DataCadastro, IDEmpresa);
        }
    }
}
