using RH.Model;
using RH.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Control
{
    public class CAluno
    {
        private RepositorieAluno RepAluno = new RepositorieAluno();
        private RepositorieEmpresa _RepositorieEmpresa = new RepositorieEmpresa();
        private RepositorieSetor _RepositorieSetor = new RepositorieSetor();
        private RepositorieCargo _RepositorieCargo = new RepositorieCargo();
        private RepositoriePessoa _RepositoriePessoa = new RepositoriePessoa();
        private RepositorieBeneficio _RepositorieBeneficio = new RepositorieBeneficio();
        private RepositorieDependente _RepositorieDependentes = new RepositorieDependente();
        private RepositorieDadosBancarios _RepositorieDadosBancarios = new RepositorieDadosBancarios();
        private RepositoriePessoaBeneficio _RepositoriePessoaBeneficio = new RepositoriePessoaBeneficio();
        private RepositorieAvaliacao _RepositorieAvaliacao = new RepositorieAvaliacao();

        public Aluno FazerLogin(string email, string senha)
        {
            return RepAluno.LoginAluno(email, senha);
        }

        public List<Aluno> SelecionarTodosAlunos(int ano)
        {
            return RepAluno.SelecionarTodosAlunos(ano);
        }

        public Aluno SelecionarAluno(int IDAluno)
        {
            return RepAluno.SelecionarAluno(IDAluno);
        }

        public void CadastrarAluno(Aluno oAluno)
        {
            RepAluno.CadastrarAluno(oAluno);
        }

        public void AlterarAluno(Aluno oAluno)
        {
            RepAluno.AlterarAluno(oAluno);
        }

        public void DeletarAluno(Aluno oAluno)
        {
            RepAluno.DeletarAluno(oAluno);
        }

        public List<Empresa> SelecionarEmpresasAluno(int IDAluno)
        {
            return _RepositorieEmpresa.SelecionarEmpresasUsuario(IDAluno);
        }

        public Empresa SelecionarEmpresa(int id)
        {
            return _RepositorieEmpresa.SelecionarEmpresa(id);
        }

        public int QuantidadeSetor(int IDEmpresa)
        {
            return _RepositorieSetor.QuantidadeDeSetoresEmpresa(IDEmpresa);
        }

        public int QuantidadeCargo(int IDEmpresa)
        {
            return _RepositorieCargo.QuantidadeCargosEmpresa(IDEmpresa);
        }

        public int QuantidadeFuncioanarios(int IDEmpresa)
        {
            return _RepositoriePessoa.QuantidadeFuncionariosEmpresa(IDEmpresa);
        }

        public int QuantidadeBeneficiosEmpresa(int IDEmpresa)
        {
            return _RepositorieBeneficio.QuantidadeBeneficiosEmpresa(IDEmpresa);
        }

        public List<Setor> SelecionarSetorEmpresa(int IDEmpresa)
        {
            return _RepositorieSetor.SelecionarSetorEmpresa(IDEmpresa);
        }

        public List<Cargo> SelecionarTodosCargosEmpresa(int IDEmpresa)
        {
            return _RepositorieCargo.SelecionarTodosCargosEmpresa(IDEmpresa);
        }

        public List<Pessoa> SelecionarFuncionariosEmpresa(int IDEmpresa)
        {
            return _RepositoriePessoa.SelecionarTodosFuncionariosEmpresa(IDEmpresa);
        }

        public List<Beneficio> SelecionarBeneficiosEmpresa(int IDEmpresa)
        {
            return _RepositorieBeneficio.SelecionarBeneficioporEmpresa(IDEmpresa);
        }

        public Pessoa SelecionarFuncionario(int IDFuncionario)
        {
            return _RepositoriePessoa.SelecionarFuncionario(IDFuncionario);
        }

        public List<DadoDependente> SelecionarDependentesFuncionario(int IDFuncionario)
        {
            return _RepositorieDependentes.SelecionarDependentesFuncionario(IDFuncionario);
        }

        public List<DadoBancario> SelecionarDadosBancariosFuncionario(int IDFuncionario)
        {
            return _RepositorieDadosBancarios.DadosBancariosFuncionario(IDFuncionario);
        }

        public List<Beneficio> BeneficiosEmpresa(int IDEmpresa)
        {
            return _RepositorieBeneficio.BeneficiosEmpresa(IDEmpresa);
        }

        public bool PossuiBeneficio(int IDBeneficio,int IDFuncionario)
        {
            return _RepositoriePessoaBeneficio.PossuiBeneficio(IDBeneficio, IDFuncionario);
        }

        public List<Avaliacao> SelecionarAvaliacoesEmpresa(int IDEmpresa,string Pesquisado)
        {
            return _RepositorieAvaliacao.SelecionarAAvaliacoesEmpresa(IDEmpresa,Pesquisado);
        }

        public List<VW_Notas> SelecionarNotasProva(int CodigoProva)
        {
            return RepAluno.SelecionarNotasProva(CodigoProva);
        }
    }
}
