using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RH.Model.Repositories;
using RH.Model;

namespace RH.Control
{
    public class CCargo
    {
        private RepositorieCargo _RepositorieCargo;
        private RepositorieSetor _RepositorieSetor;
        private RepositoriePessoa _RepositoriePessoa;

        public CCargo()
        {
            _RepositorieCargo = new RepositorieCargo();
            _RepositorieSetor = new RepositorieSetor();
            _RepositoriePessoa = new RepositoriePessoa();
        }

        public List<Cargo> SelecionarTodosCargos()
        {
            return _RepositorieCargo.SelecionarTodosCargos();
        }

        public List<Cargo> SelecionarCargoPorSetor(int IDSetor)
        {
            return _RepositorieCargo.SelecionarCargoPorSetor(IDSetor);
        }

        public Cargo SelecionarCargoPorNome(string n)
        {
            return _RepositorieCargo.SelecionarCargoPorNome(n);
        }

        public Cargo SelecionarCargo(int id)
        {
            return _RepositorieCargo.SelecionarCargo(id);
        }

        public void CadastrarCargo(Cargo oCargo)
        {
            _RepositorieCargo.CadastrarCargo(oCargo);
        }

        public void AlterarCargo(Cargo oCargo)
        {
            _RepositorieCargo.AlterarCargo(oCargo);
        }

        public void ExcluirCargo(Cargo oCargo)
        {
            _RepositorieCargo.ExcluirCargo(oCargo);
        }

        public List<Cargo> SelecionarTodosCargosEmpresa(int id)
        {
            return _RepositorieCargo.SelecionarTodosCargosEmpresa(id);
        }

        public List<Setor> SelecionarTodosSetores()
        {
            return _RepositorieSetor.SelecionarTodosSetores();
        }

        public List<Setor> SelecionarSetoresEmpresa(int id)
        {
            return _RepositorieSetor.SelecionarSetorEmpresa(id);
        }

        public List<Cargo> CargosChefeEmpresa(int IDEmpresa)
        {
            return _RepositorieCargo.CargosChefeEmpresa(IDEmpresa);
        }

        public Pessoa SelecionarPessoaCargo(int IDCargo)
        {
            return _RepositoriePessoa.SelecionarPessoaCargo(IDCargo);
        }

        public void AlterarFuncionario(Pessoa aPessoa)
        {
            _RepositoriePessoa.AlterarFuncionario(aPessoa);
        }

        public Pessoa SelecionarFuncionario(int id)
        {
            return _RepositoriePessoa.SelecionarFuncionario(id);
        }
    }
}
