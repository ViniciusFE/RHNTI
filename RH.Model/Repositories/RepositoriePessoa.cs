
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
            Db.SaveChanges();
        }

        public void DeletarFuncionario(Pessoa oFuncionario)
        {
            Db.Entry(oFuncionario).State = System.Data.Entity.EntityState.Deleted;
            Db.SaveChanges();
        }

        public bool AutenticaCargo(int cargo)
        {
            //var pes = Db.Pessoa.SqlQuery("select count(Pes_Cargo_Car_ID) from Pessoa where Pes_Cargo_Car_ID = " + cargo) ;
            //int pes= Db.Pessoa.Where(i => i.Pes_Cargo_Car_ID==cargo).Count();
            int pes = Db.Pessoa.SqlQuery("select * from Pessoa where Pes_Cargo_Car_ID =" + cargo).Count();
            var pes2 = Db.Pessoa.Where(i => i.Pes_Cargo_Car_ID == cargo).FirstOrDefault();
            if (pes == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Pessoa> SelcionarTodosMeusFuncionarios(int id)
        {
            return Db.Pessoa.SqlQuery("select * from Pessoa inner join Cargo on Pes_Cargo_Car_ID = Car_ID where Car_Cargo_Car_ID = " + id + " and Car_Situation = 1 and Pes_Situation = 1").ToList();
        }

        public List<Pessoa> SelecionarTodosChefes()
        {
            return Db.Pessoa.SqlQuery("select * from Pessoa inner join Cargo on Pessoa.Pes_Cargo_Car_ID = Car_ID where Car_Cargo_Car_ID is null and Car_Situation = 1 and Pes_Situation = 1").ToList();
        }

        public List<Pessoa> SelecionarTodosFuncionariosEmpresa(int IDEmpresa)
        {
            return Db.Pessoa.SqlQuery("select * from Pessoa p inner join Cargo c on p.Pes_Cargo_Car_ID = c.Car_ID inner join Setor s on c.Car_Setor_Set_ID = s.Set_ID and s.Set_Empresa_Emp_ID = 1 and p.Pes_Situation = "+IDEmpresa+" and c.Car_Situation=1 and s.Set_Situation=1").ToList();
        }

        public Pessoa SelecionarPessoaCargo(int IDCargo)
        {
            return Db.Pessoa.Where(p => p.Pes_Cargo_Car_ID.Equals(IDCargo) && p.Pes_Situation==true).FirstOrDefault();
        }
    }
}
