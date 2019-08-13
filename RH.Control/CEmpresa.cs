using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RH.Model.Repositories;
using RH.Model;

namespace RH.Control
{
    public class CEmpresa
    {
        private RepositorieEmpresa _RepositorieEmpresa;
        private RepositorieProva _RepositorieProva;

        public CEmpresa()
        {
            _RepositorieEmpresa = new RepositorieEmpresa();
            _RepositorieProva = new RepositorieProva();
        }

        public List<Empresa> SelecionarTodasEmpresa()
        {
            return _RepositorieEmpresa.SelecionarTodasEmpresas();
        }

        public List<Empresa> SelecionarTodasEmpresasAluno(int IDUsuario)
        {
            return _RepositorieEmpresa.SelecionarEmpresasUsuario(IDUsuario);
        }

        public void CadastrarEmpresa(Empresa aEmpresa)
        {
            _RepositorieEmpresa.CadastrarEmpresa(aEmpresa);
        }

        public void AlterarEmpresa(Empresa aEmpresa)
        {
            _RepositorieEmpresa.AlterarEmpresa(aEmpresa);
        }

        public Empresa SelecionarEmpresa(int id)
        {
            return _RepositorieEmpresa.SelecionarEmpresa(id);
        }

        public Prova ProvaAluno(int IDAluno)
        {
            return _RepositorieProva.SelecionarProvaAluno(IDAluno);
        }
    }
}
