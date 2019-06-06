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

        public Aluno FazerLogin(string email, string senha)
        {
            return RepAluno.LoginAluno(email, senha);
        }

        public List<Aluno> SelecionarTodosAlunos()
        {
            return RepAluno.SelecionarTodosAlunos();
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

    }
}