using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RH.Model;
using RH.Model.Repositories;

namespace RH.Control
{
    public class CVaga
    {
        private RepositorieVaga _RepositorieVaga;
        private RepositorieCargo _RepositorieCargo;
        private RepositorieEmpresa _RepositorieEmpresa;

        public CVaga()
        {
            _RepositorieVaga = new RepositorieVaga();
            _RepositorieCargo = new RepositorieCargo();
            _RepositorieEmpresa = new RepositorieEmpresa();
        }

        public List<Vaga> SelecionarVagasEmpresa(int IDEmpresa)
        {
            return _RepositorieVaga.SelecionarVagas(IDEmpresa);
        }

        public void CadastrarVaga(Vaga aVaga)
        {
            _RepositorieVaga.CadastrarVaga(aVaga);
        }

        public List<Cargo> SelecionarCargosEmpresa(int IDEmpresa)
        {
            return _RepositorieCargo.SelecionarTodosCargosEmpresa(IDEmpresa);
        }

        public Empresa SelecionarEmpresa(int id)
        {
            return _RepositorieEmpresa.SelecionarEmpresa(id);
        }

        public Vaga SelecionarVaga(int id)
        {
            return _RepositorieVaga.SelecionarVaga(id);
        }

        public void AlterarVaga(Vaga aVaga)
        {
            _RepositorieVaga.AlterarVaga(aVaga);
        }
    }
}
