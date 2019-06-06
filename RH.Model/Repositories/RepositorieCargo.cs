using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Repositories
{
    public class RepositorieCargo
    {
        RHEntities odb;

        public RepositorieCargo()
        {
            odb = Helper.Connection.GetConnection();
        }
        public RepositorieCargo(RHEntities _odb)
        {
            odb = _odb;
        }

        public List<Cargo> SelecionarTodosCargos()
        {
            return odb.Cargo.Where(p => p.Car_Situation == true).ToList();
        }

        public List<Cargo> SelecionarCargoPorSetor(int IDSetor)
        {
            return odb.Cargo.Where(p => p.Car_Setor_Set_ID.Equals(IDSetor) && p.Car_Situation == true).ToList();
        }

        public Cargo SelecionarCargoPorNome(string n)
        {
            return odb.Cargo.Where(p => p.Car_Nome.Equals(n)).FirstOrDefault();
        }

        public void CadastrarCargo(Cargo oCargo)
        {
            odb.Entry(oCargo).State = System.Data.Entity.EntityState.Added;
            odb.SaveChanges();
        }

        public void AlterarCargo(Cargo oCargo)
        {
            odb.Entry(oCargo).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }

        public void ExcluirCargo(Cargo oCargo)
        {
            odb.Entry(oCargo).State = System.Data.Entity.EntityState.Deleted;
            odb.SaveChanges();
        }

        public List<Cargo> SelecionarTodosCargosFuncionarios(int id)
        {
            return odb.Cargo.SqlQuery("select * from Cargo inner join Pessoa on Car_ID = Pes_Cargo_Car_ID where Car_Cargo_Car_ID = " + id + " and Car_Situation = 1 and Pes_Situation = 1").ToList();
        }

        public List<Cargo> CargosNaoPreenchidos()
        {
            return odb.Cargo.SqlQuery("select * from Cargo where Car_ID not in (select Pes_Cargo_Car_ID from Pessoa)").ToList();
        }

        public Cargo SelecionarCargo(int id)
        {
            return odb.Cargo.Where(c => c.Car_ID.Equals(id)).FirstOrDefault();
        }

    }
}
