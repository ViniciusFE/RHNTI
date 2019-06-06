using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Repositories
{
    public class RepositoriePessoa
    {
        private RHEntities Db = new RHEntities();


        public void CadastrarFuncionario(Pessoa oFuncionario)
        {
            Db.Entry(oFuncionario).State = System.Data.Entity.EntityState.Added;

            Db.SaveChanges();
        }

        public List<Pessoa> SelecionarTodosFuncionarios()
        {
            return Db.Pessoa.Where(i => i.Pes_Situation == true).ToList();
        }

        public Pessoa SelecionarFuncionario(int IDFuncionario)
        {
            return Db.Pessoa.Where(i => i.Pes_ID == IDFuncionario && i.Pes_Situation == true).FirstOrDefault();
        }

        public void AlterarFuncionario(Pessoa oFuncionario)
        {
            Db.Entry(oFuncionario).State = System.Data.Entity.EntityState.Modified;
        }

        public void DeletarFuncionario(Pessoa oFuncionario)
        {
            Db.Entry(oFuncionario).State = System.Data.Entity.EntityState.Deleted;
        }

        public List<Pessoa> SelcionarTodosMeusFuncionarios(int id)
        {
            return Db.Pessoa.SqlQuery("select * from Pessoa inner join Cargo on Pes_Cargo_Car_ID = Car_ID where Car_Cargo_Car_ID = " + id + " and Car_Situation = 1 and Pes_Situation = 1").ToList();
        }

        public List<Pessoa> SelecionarTodosChefes()
        {
            return Db.Pessoa.SqlQuery("select * from Pessoa inner join Cargo on Pessoa.Pes_Cargo_Car_ID = Car_ID where Car_Cargo_Car_ID is null and Car_Situation = 1 and Pes_Situation = 1").ToList();
        }
    }
}
