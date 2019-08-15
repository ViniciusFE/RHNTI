using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RH.Model.Repositories;
using RH.Model;

namespace RH.Control
{
    public class CSetor
    {
        private RepositorieSetor _RepositorieSetor;
        private RepositorieEmpresa _RepositorieEmpresa;

        public CSetor()
        {
            _RepositorieSetor = new RepositorieSetor();
            _RepositorieEmpresa = new RepositorieEmpresa();
        }

        public List<Setor> SelecionarTodosSetores()
        {
            return _RepositorieSetor.SelecionarTodosSetores();
        }

        public List<Setor> SelecionarSetorEmpresa(int idEmpresa)
        {
            return _RepositorieSetor.SelecionarSetorEmpresa(idEmpresa);
        }

        public Setor SelecionarSetor(int id)
        {
            return _RepositorieSetor.SelecionarSetor(id);
        }

        public void CadastrarSetor(Setor Osetor)
        {
             _RepositorieSetor.CadastrarSetor(Osetor);
        }

        public void AlterarSetor(Setor oSetor)
        {
            _RepositorieSetor.AlterarSetor(oSetor);
        }

        public void ExcluirSetor(Setor oSetor)
        {
            _RepositorieSetor.ExcluirSetor(oSetor);
        }

        public Empresa SelecionarEmpresa(int id)
        {
            return _RepositorieEmpresa.SelecionarEmpresa(id);
        }

        public Setor SelecionarSetorPeloNome(string NomeSetor)
        {
            return _RepositorieSetor.SelecionarSetorPeloNome(NomeSetor);
        }

        public bool PossuiSetores(int IDSetor)
        {
            return _RepositorieSetor.PossuiSetores(IDSetor);
        }

        public bool LimiteSetoresEmpresaAvaliativa(int IDEmpresa)
        {
            return _RepositorieSetor.LimiteSetoresEmpresaAvaliativa(IDEmpresa);
        }
    }
}
