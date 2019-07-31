using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RH.Model;
using RH.Model.Repositories;

namespace RH.Control
{
    public class CAvaliacao
    {
        private RepositorieAvaliacao _RepositorieAvaliacao;
        private RepositoriePessoa _RepositoriePessoa;
        private RepositorieCargo _RepositorieCargo;
        private RepositorieSetor _RepositorieSetor;

        public CAvaliacao()
        {
            _RepositorieAvaliacao = new RepositorieAvaliacao();
            _RepositoriePessoa = new RepositoriePessoa();
            _RepositorieCargo = new RepositorieCargo();
            _RepositorieSetor = new RepositorieSetor();
        }

        public void CadastrarAvaliacao(Avaliacao aAvaliacao)
        {
            _RepositorieAvaliacao.CadastrarAvaliacao(aAvaliacao);
        }

        public List<Pessoa> SelecionarTodosChefes()
        {
            return _RepositoriePessoa.SelecionarTodosChefes();
        }

        public List<Pessoa> SelecionarTodosMeusFuncionarios(int IDSetor,int IDFuncionario)
        {
            return _RepositoriePessoa.SelcionarTodosMeusFuncionarios(IDSetor,IDFuncionario);
        }

        public List<Cargo> SelecionarTodosCargosFuncionarios(int id)
        {
            return _RepositorieCargo.SelecionarTodosCargosFuncionarios(id);
        }

        public Pessoa SelecionarPessoa(int id)
        {
            return _RepositoriePessoa.SelecionarFuncionario(id);
        }

        public Cargo SelecionarCargo(int id)
        {
            return _RepositorieCargo.SelecionarCargo(id);
        }

        public Setor SelecionarSetor(int IDSetor)
        {
            return _RepositorieSetor.SelecionarSetor(IDSetor);
        }
    }
}
