using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Repositories
{
    public class RepositorieAluno
    {

        private RHEntities Db = new RHEntities();

        public Aluno LoginAluno(string email, string senha)
        {
            return Db.Aluno.Where(i => i.Alu_Email == email && i.Alu_Senha == senha).FirstOrDefault();
        }


        public List<Aluno> SelecionarTodosAlunos(int ano)
        {
            return Db.Aluno.Where(p => p.Alu_DataCadastro.Year == ano && p.Alu_Situation == true).ToList();
        }

        public Aluno SelecionarAluno(int IDAluno)
        {
            return Db.Aluno.Where(i => i.Alu_ID == IDAluno && i.Alu_Situation == true).FirstOrDefault();
        }

        public void CadastrarAluno(Aluno oAluno)
        {
            Db.Entry(oAluno).State = System.Data.Entity.EntityState.Added;
            Db.SaveChanges();
        }


        public void AlterarAluno(Aluno oAluno)
        {
            Db.Entry(oAluno).State = System.Data.Entity.EntityState.Modified;
        }


        public void DeletarAluno(Aluno oAluno)
        {
            Db.Entry(oAluno).State = System.Data.Entity.EntityState.Deleted;
        }
    }
}
