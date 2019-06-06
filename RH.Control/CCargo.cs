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

        public CCargo()
        {
            _RepositorieCargo = new RepositorieCargo();
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
    }
}
