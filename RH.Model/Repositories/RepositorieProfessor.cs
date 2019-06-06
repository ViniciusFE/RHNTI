using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Repositories
{
    public class RepositorieProfessor
    {

        private RHEntities Db = new RHEntities();

        public Professor LoginProfessor(string email, string senha)
        {
            return Db.Professor.Where(i => i.Pro_Email == email && i.Pro_Senha == senha).FirstOrDefault();
        }

        public Professor SelecionarProfessor(int IDPro)
        {
            return Db.Professor.Where(i => i.Pro_ID == IDPro).FirstOrDefault();
        }

        public void AlterarProfessor(Professor oProfessor)
        {
            Db.Entry(oProfessor).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public void AdicionarProfessor(Professor oProfessor)
        {
            Db.Entry(oProfessor).State = System.Data.Entity.EntityState.Added;
            Db.SaveChanges();
        }

        public void DeletarProfessor(Professor oProfessor)
        {
            Db.Entry(oProfessor).State = System.Data.Entity.EntityState.Deleted;
            Db.SaveChanges();
        }
    }
}