using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RH.Model.Repositories;
using RH.Model;

namespace RH.Control
{
    public class CEmpresa
    {
        private RepositorieEmpresa _RepositorieEmpresa;
        private RepositorieProva _RepositorieProva;
        private RepositorieAluno _RepositorieAluno;
        private RepositorieCurso _RepositorieCurso;
        private RepositorieSetor _RepositorieSetor;
        private RepositorieCargo _RepositorieCargo;
        private RepositoriePessoa _RepositoriePessoa;
        private RepositorieDependente _RepositorieDependente;
        private RepositorieDadosBancarios _RepositorieDadoBancario;
        private RepositorieBeneficio _RepositorieBeneficio;
        private RepositoriePessoaBeneficio _RepositorieBeneficioFuncionario;
        private RepositorieAvaliacao _RepositorieAvaliacao;
        private RepositorieDemissao _RepositorieDemissao;

        public CEmpresa()
        {
            _RepositorieEmpresa = new RepositorieEmpresa();
            _RepositorieProva = new RepositorieProva();
            _RepositorieAluno = new RepositorieAluno();
            _RepositorieCurso = new RepositorieCurso();
            _RepositorieSetor = new RepositorieSetor();
            _RepositorieCargo = new RepositorieCargo();
            _RepositoriePessoa = new RepositoriePessoa();
            _RepositorieDependente = new RepositorieDependente();
            _RepositorieDadoBancario = new RepositorieDadosBancarios();
            _RepositorieBeneficio = new RepositorieBeneficio();
            _RepositorieBeneficioFuncionario = new RepositoriePessoaBeneficio();
            _RepositorieAvaliacao = new RepositorieAvaliacao();
            _RepositorieDemissao = new RepositorieDemissao();
        }

        public List<Empresa> SelecionarTodasEmpresa()
        {
            return _RepositorieEmpresa.SelecionarTodasEmpresas();
        }

        public List<Empresa> SelecionarTodasEmpresasAluno(int IDUsuario)
        {
            return _RepositorieEmpresa.SelecionarEmpresasUsuario(IDUsuario);
        }

        public void CadastrarEmpresa(Empresa aEmpresa)
        {
            _RepositorieEmpresa.CadastrarEmpresa(aEmpresa);
        }

        public void AlterarEmpresa(Empresa aEmpresa)
        {
            _RepositorieEmpresa.AlterarEmpresa(aEmpresa);
        }

        public Empresa SelecionarEmpresa(int id)
        {
            return _RepositorieEmpresa.SelecionarEmpresa(id);
        }

        public Prova ProvaAluno(int IDAluno)
        {
            return _RepositorieProva.SelecionarProvaAluno(IDAluno);
        }

        public bool EmpresaAvaliativaAtiva(int IDUsuario)
        {
            return _RepositorieEmpresa.EmpresaAvaliativaAtiva(IDUsuario);
        }

        public Prova SelecionarProvaAluno(int IDAluno)
        {
            return _RepositorieProva.SelecionarProvaAluno(IDAluno);
        }

        public Aluno SelecionarAluno(int id)
        {
            return _RepositorieAluno.SelecionarAluno(id);
        }

        public Curso SelecionarCurso(int id)
        {
            return _RepositorieCurso.SelecionarCurso(id);
        }

        public Setor SelecionarSetor(int IDSetor)
        {
            return _RepositorieSetor.SelecionarSetor(IDSetor);
        }

        public Cargo SelecionarCargo(int IDCargo)
        {
            return _RepositorieCargo.SelecionarCargo(IDCargo);
        }

        public Pessoa SelecionarFuncionario(int IDFuncionario)
        {
            return _RepositoriePessoa.SelecionarFuncionario(IDFuncionario);
        }

        public DadoDependente SelecionarDependente(int id)
        {
            return _RepositorieDependente.SelecionarDadoDependente(id);
        }

        public DadoBancario SelecionarDadoBancario(int id)
        {
            return _RepositorieDadoBancario.SelecionarDadoBancario(id);
        }
        
        public Beneficio SelecionarBeneficio(int id)
        {
            return _RepositorieBeneficio.SelecionarBeneficioporID(id);
        }

        public PessoaBeneficio SelecionarBeneficioFuncionario(int id)
        {
            return _RepositorieBeneficioFuncionario.SelecionarBeneficio(id);
        }

        public Avaliacao SelecionarAvaliacao(int id)
        {
            return _RepositorieAvaliacao.SelecionarAvaliacao(id);
        }

        public Demissao SelecionarDemissao(int id)
        {
            return _RepositorieDemissao.SelecionarDemissao(id);
        }
    }
}
