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

        public CSetor()
        {
            _RepositorieSetor = new RepositorieSetor();
        }

        public List<Setor> SelecionarTodosSetores()
        {
            return _RepositorieSetor.SelecionarTodosSetores();
        }

        public List<Setor> SelecionarSetorEmpresa(int idEmpresa)
        {
            return _RepositorieSetor.SelecionarSetorEmpresa(idEmpresa);
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

    }
}
