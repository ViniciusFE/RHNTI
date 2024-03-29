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

        public List<Cargo> SelecionarTodosCargosEmpresa(int id)
        {
            return odb.Cargo.Join(odb.Setor.Where(s=>s.Set_Empresa_Emp_ID.Equals(id)), c => c.Car_Setor_Set_ID, s => s.Set_ID, (c, s) => c).Where(c=>c.Car_Situation==true).ToList();
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
            odb.Entry(oCargo).State = System.Data.Entity.EntityState.Modified;
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

        public List<Cargo> CargosChefeEmpresa(int IDEmpresa)
        {
            return odb.Cargo.SqlQuery("select * from Cargo c inner join Setor s on c.Car_Setor_Set_ID = s.Set_ID and c.Car_Situation = 1 and s.Set_Empresa_Emp_ID = " + IDEmpresa + " and c.Car_Cargo_Car_ID is null").ToList();
        }

        public bool SelecionarChefeSetor(int IDSetor)
        {
            Cargo oCargo=odb.Cargo.Where(c => c.Car_Setor_Set_ID.Equals(IDSetor) && c.Car_Situation == true && c.Car_Chefe == true).FirstOrDefault();

            if(oCargo!=null)
            {
                return true;
            }

            return false;
        }

        public bool CargosComMesmoNome(string NomeCargo,int IDSetor)
        {
            Cargo oCargo = odb.Cargo.Where(p => p.Car_Nome.Equals(NomeCargo) && p.Car_Setor_Set_ID.Equals(IDSetor) && p.Car_Situation==true).FirstOrDefault();

            if(oCargo!=null)
            {
                return true;
            }

            return false;
        }


        public int QuantidadeCargosEmpresa(int IDEmpresa)
        {
            return odb.Cargo.SqlQuery("select * from Cargo c inner join Setor s on c.Car_Setor_Set_ID = s.Set_ID where s.Set_Empresa_Emp_ID = " + IDEmpresa+" and c.Car_Situation=1").Count();
        }

        public Cargo SelecionarCargoDiaCadastro(string DiaCadastro,int IDEmpresa)
        {
            return odb.Cargo.Join(odb.Setor.Where(s => s.Set_Empresa_Emp_ID.Equals(IDEmpresa)), c => c.Car_Setor_Set_ID, s => s.Set_ID, (c, s) => c).Where(c => c.Car_DataCadastro.Equals(DiaCadastro) && c.Car_Situation == true).FirstOrDefault();
        }

        public bool LimiteCargosEmpresaAvaliativa(int IDEmpresa)
        {
            int QuantidadeCargos = SelecionarTodosCargosEmpresa(IDEmpresa).Count();

            if(QuantidadeCargos==5)
            {
                return true;
            }

            return false;
        }

    }
}
