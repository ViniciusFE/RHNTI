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
        private RepositoriePessoa _RepositoriePessoa;
        private RepositorieEmpresa _RepositorieEmpresa;

        public CDependente()
        {
            _RepositorieDependente = new RepositorieDependente();
            _RepositoriePessoa = new RepositoriePessoa();
            _RepositorieEmpresa = new RepositorieEmpresa();
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

        public Pessoa SelecionarFuncionario(int id)
        {
            return _RepositoriePessoa.SelecionarFuncionario(id);
        }

        public Empresa SelecionarEmpresa(int id)
        {
            return _RepositorieEmpresa.SelecionarEmpresa(id);
        }

        public bool VerificarParentesco(int IDFuncionario,string Parentesco)
        {
            return _RepositorieDependente.VerificarParentesco(IDFuncionario,Parentesco);
        }
    }
}
