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
        private RepositorieAluno _RepositorieAluno;
        private RepositorieCurso _RepositorieCurso;
        private RepositorieSetor _RepositorieSetor;
        private RepositorieCargo _RepositorieCargo;

        public CEmpresa()
        {
            _RepositorieEmpresa = new RepositorieEmpresa();
            _RepositorieProva = new RepositorieProva();
            _RepositorieAluno = new RepositorieAluno();
            _RepositorieCurso = new RepositorieCurso();
            _RepositorieSetor = new RepositorieSetor();
            _RepositorieCargo = new RepositorieCargo();
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

        public bool EmpresaAvaliativaAtiva(int IDUsuario)
        {
            return _RepositorieEmpresa.EmpresaAvaliativaAtiva(IDUsuario);
        }

        public Prova SelecionarProvaAluno(int IDAluno)
        {
            return _RepositorieProva.SelecionarProvaAluno(IDAluno);
        }

        public Aluno SelecionarAluno(int id)
        {
            return _RepositorieAluno.SelecionarAluno(id);
        }

        public Curso SelecionarCurso(int id)
        {
            return _RepositorieCurso.SelecionarCurso(id);
        }
    }
}
