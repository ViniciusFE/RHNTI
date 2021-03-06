
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

        

        public List<Pessoa> SelcionarTodosMeusFuncionarios(int IDSetor,int IDEmpresa,int IDChefe)
        {
            return Db.Pessoa.SqlQuery("select * from Pessoa p inner join Cargo c on p.Pes_Cargo_Car_ID = c.Car_ID inner join Setor s on c.Car_Setor_Set_ID = s.Set_ID and s.Set_Empresa_Emp_ID = "+IDEmpresa+" and s.Set_Setor_Set_ID = "+IDSetor+" where p.Pes_Situation = 1 and p.Pes_ID <> "+IDChefe).ToList();
        }

        public List<Pessoa> SelecionarTodosChefes(int IDEmpresa)
        {
            return Db.Pessoa.SqlQuery("select * from Pessoa p inner join Cargo c on p.Pes_Cargo_Car_ID = c.Car_ID and c.Car_Chefe = 1 inner join Setor s on c.Car_Setor_Set_ID=s.Set_ID and s.Set_Empresa_Emp_ID="+IDEmpresa+" where p.Pes_Situation=1").ToList();
        }

        public List<Pessoa> SelecionarTodosFuncionariosEmpresa(int IDEmpresa)
        {
            return Db.Pessoa.SqlQuery("select * from Pessoa p inner join Cargo c on p.Pes_Cargo_Car_ID = c.Car_ID inner join Setor s on c.Car_Setor_Set_ID = s.Set_ID and s.Set_Empresa_Emp_ID = "+IDEmpresa+" and p.Pes_Situation = 1 and c.Car_Situation=1 and s.Set_Situation=1").ToList();
        }

        public Pessoa SelecionarPessoaCargo(int IDCargo)
        {
            return Db.Pessoa.Join(Db.Vaga.Where(p=>p.Vag_Cargo_Car_ID.Equals(IDCargo)), p => p.Pes_Vaga_Vag_ID, v => v.Vag_ID, (p, v) => p).Where(p => p.Pes_Situation == true).FirstOrDefault();
        }

        public int QuantidadeFuncionariosEmpresa(int IDEmpresa)
        {
            return Db.Pessoa.SqlQuery("select *  from Pessoa p inner join Cargo c on p.Pes_Cargo_Car_ID=c.Car_ID inner join Setor s on c.Car_Setor_Set_ID=s.Set_ID and s.Set_Empresa_Emp_ID="+IDEmpresa+" and p.Pes_Situation=1").Count();
        }

        public Pessoa SelecionarPessoaDiaCadastro(string DataCadastro, int IDEmpresa)
        {
            return Db.Pessoa.Join(Db.Vaga.Join(Db.Cargo.Join(Db.Setor.Where(s=>s.Set_Empresa_Emp_ID.Equals(IDEmpresa)),c=>c.Car_Setor_Set_ID,s=>s.Set_ID,(c,s)=>c),v=>v.Vag_Cargo_Car_ID,c=>c.Car_ID,(v,c)=>v), p => p.Pes_Vaga_Vag_ID, v => v.Vag_ID, (p, v) => p).Where(p => p.Pes_DataCadastro.Equals(DataCadastro) && p.Pes_Situation == true).Last();
        }

        public bool LimiteFuncionariosEmpresaAvaliativa(int IDEmpresa)
        {
            int QuantidadeFuncionarios = Db.Pessoa.Join(Db.Vaga.Join(Db.Cargo.Join(Db.Setor.Where(s => s.Set_Empresa_Emp_ID.Equals(IDEmpresa)), c => c.Car_Setor_Set_ID, s => s.Set_ID, (c, s) => c), v => v.Vag_Cargo_Car_ID, c => c.Car_ID, (v, c) => v), p => p.Pes_Vaga_Vag_ID, v => v.Vag_ID, (p, v) => p).Where(p=>p.Pes_Situation == true).Count();
        
            if(QuantidadeFuncionarios==5)
            {
                return true;
            }

            return false;
        }

        public bool CargoOcupado(int IDCargo)
        {
            Pessoa aPessoa = Db.Pessoa.Join(Db.Vaga.Join(Db.Cargo.Where(c=>c.Car_ID.Equals(IDCargo)), v => v.Vag_Cargo_Car_ID, c => c.Car_ID, (v, c) => v), p => p.Pes_Vaga_Vag_ID, v => v.Vag_ID, (p, v) => p).Where(p => p.Pes_Situation == true).FirstOrDefault();

            if (aPessoa!=null)
            {
                return true;
            }

            return false;
        }

        public Pessoa SelecionarPessoa(int IDFuncionario)
        {
            return Db.Pessoa.Where(p => p.Pes_ID.Equals(IDFuncionario)).FirstOrDefault();
        }
    }
}
