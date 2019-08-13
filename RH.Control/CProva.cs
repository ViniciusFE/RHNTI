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

        public List<Prova> SelecionarTodasProva()
        {
            return _RepositorieProva.SelecionarProvas();
        }
    }
}
