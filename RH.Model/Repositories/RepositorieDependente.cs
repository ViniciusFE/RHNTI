using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Repositories
{
    public class RepositorieDependente
    {
        private RHEntities odb;

        public RepositorieDependente()
        {
            odb = Helper.Connection.GetConnection();
        }

        public List<DadoDependente> SelecionarDependentesFuncionario(int id)
        {
            return odb.DadoDependente.Where(p => p.DP_Pessoa_Pes_ID.Equals(id) && p.DP_Situation == true).OrderBy(p=>p.DP_ID).ToList();
        }

        public DadoDependente SelecionarDadoDependente(int id)
        {
            return odb.DadoDependente.Where(p => p.DP_ID.Equals(id) && p.DP_Situation == true).FirstOrDefault();
        }

        public void CadastrarDependente(DadoDependente oDependente)
        {
            odb.Entry(oDependente).State = System.Data.Entity.EntityState.Added;
            odb.SaveChanges();
        }

        public void AlterarDependente(DadoDependente oDependente)
        {
            DadoDependente DP = odb.DadoDependente.Where(p => p.DP_ID.Equals(oDependente.DP_ID)).First();
            odb.Entry(DP).State = System.Data.Entity.EntityState.Detached;
            odb.Entry(oDependente).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }

        public bool VerificarParentesco(int IDFuncionario,string Parentesco)
        {
            DadoDependente DP = odb.DadoDependente.Where(p => p.DP_Pessoa_Pes_ID.Equals(IDFuncionario) && p.DP_Parentesco.Equals(Parentesco) && p.DP_Situation==true).FirstOrDefault();

            if(DP!=null)
            {
                return true;
            }

            return false;
        }

        public void DesabilitarDependentes(int IDFuncionario)
        {
            odb.Database.ExecuteSqlCommand("update DadoDependente set DP_Situation=0 where DP_Pessoa_Pes_ID=" + IDFuncionario);
            odb.SaveChanges();
        }

        public DadoDependente SelecionarDependenteDataCadastro(string DataCadastro,int IDEmpresa)
        {
            return odb.DadoDependente.Join(odb.Pessoa.Join(odb.Cargo.Join(odb.Setor.Where(s=>s.Set_Empresa_Emp_ID.Equals(IDEmpresa)),c=>c.Car_Setor_Set_ID,s=>s.Set_ID,(c,s)=>c),p=>p.Pes_Cargo_Car_ID,c=>c.Car_ID,(p,c)=>p), dd => dd.DP_Pessoa_Pes_ID, p => p.Pes_ID, (dd, p) => dd).Where(dd=>dd.DP_DataCadastro.Equals(DataCadastro)).OrderBy(dd => dd.DP_ID).ToList().Last();
        }

        public bool LimiteDependentesEmpresaAvaliativa(int IDEmpresa)
        {
            int QuantidadeDependentes = odb.DadoDependente.SqlQuery("select * from DadoDependente dp inner join Pessoa p on dp.DP_Pessoa_Pes_ID = p.Pes_ID inner join Cargo c on p.Pes_Cargo_Car_ID = C.Car_ID inner join Setor s on c.Car_Setor_Set_ID = s.Set_ID and s.Set_Empresa_Emp_ID = "+IDEmpresa+" where dp.DP_Situation = 1").Count();

            if(QuantidadeDependentes==5)
            {
                return true;
            }

            return false;
        }
    }
}
