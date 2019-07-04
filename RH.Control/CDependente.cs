using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RH.Model.Repositories;
using RH.Model;

namespace RH.Control
{
    public class CDependente
    {
        private RepositorieDependente _RepositorieDependente;

        public CDependente()
        {
            _RepositorieDependente = new RepositorieDependente();
        }

        public List<DadoDependente> SelecionarDependetesFuncionario(int IDFuncionario)
        {
            return _RepositorieDependente.SelecionarDependentesFuncionario(IDFuncionario);
        }

        public DadoDependente SelecionarDependente(int id)
        {
            return _RepositorieDependente.SelecionarDadoDependente(id);
        }

        public void CadastrarDependente(DadoDependente oDependente)
        {
            _RepositorieDependente.CadastrarDependente(oDependente);
        }

        public void AlterarDependente(DadoDependente oDependente)
        {
            _RepositorieDependente.AlterarDependente(oDependente);
        }
    }
}
