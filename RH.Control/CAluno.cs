using RH.Model;
using RH.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Control
{
    public class CAluno
    {
        private RepositorieAluno RepAluno = new RepositorieAluno();
        private RepositorieEmpresa _RepositorieEmpresa = new RepositorieEmpresa();
        private RepositorieSetor _RepositorieSetor = new RepositorieSetor();
        private RepositorieCargo _RepositorieCargo = new RepositorieCargo();


        public Aluno FazerLogin(string email, string senha)
        {
            return RepAluno.LoginAluno(email, senha);
        }

        public List<Aluno> SelecionarTodosAlunos(int ano)
        {
            return RepAluno.SelecionarTodosAlunos(ano);
        }

        public Aluno SelecionarAluno(int IDAluno)
        {
            return RepAluno.SelecionarAluno(IDAluno);
        }

        public void CadastrarAluno(Aluno oAluno)
        {
            RepAluno.CadastrarAluno(oAluno);
        }

        public void AlterarAluno(Aluno oAluno)
        {
            RepAluno.AlterarAluno(oAluno);
        }

        public void DeletarAluno(Aluno oAluno)
        {
            RepAluno.DeletarAluno(oAluno);
        }

        public List<Empresa> SelecionarEmpresasAluno(int IDAluno)
        {
            return _RepositorieEmpresa.SelecionarEmpresasUsuario(IDAluno);
        }

        public Empresa SelecionarEmpresa(int id)
        {
            return _RepositorieEmpresa.SelecionarEmpresa(id);
        }

        public int QuantidadeSetor(int IDEmpresa)
        {
            return _RepositorieSetor.QuantidadeDeSetoresEmpresa(IDEmpresa);
        }

        public int QuantidadeCargo(int IDEmpresa)
        {
            return _RepositorieCargo.QuantidadeCargosEmpresa(IDEmpresa);
        }

    }
}
