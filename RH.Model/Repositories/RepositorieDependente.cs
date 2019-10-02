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
            return odb.DadoDependente.Join(odb.Pessoa.Join(odb.Vaga.Join(odb.Cargo.Join(odb.Setor.Where(s => s.Set_Empresa_Emp_ID.Equals(IDEmpresa)), c => c.Car_Setor_Set_ID, s => s.Set_ID, (c, s) => c), v => v.Vag_Cargo_Car_ID, c => c.Car_ID, (v, c) => v), p => p.Pes_Vaga_Vag_ID, v => v.Vag_ID, (p, v) => p), a => a.DP_Pessoa_Pes_ID, p => p.Pes_ID, (a, p) => a).Where(a => a.DP_Situation == true && a.DP_DataCadastro.Equals(DataCadastro)).Last();
        }

        public bool LimiteDependentesEmpresaAvaliativa(int IDEmpresa)
        {
            int QuantidadeDependentes = odb.DadoDependente.Join(odb.Pessoa.Join(odb.Vaga.Join(odb.Cargo.Join(odb.Setor.Where(s => s.Set_Empresa_Emp_ID.Equals(IDEmpresa)), c => c.Car_Setor_Set_ID, s => s.Set_ID, (c, s) => c), v => v.Vag_Cargo_Car_ID, c => c.Car_ID, (v, c) => v), p => p.Pes_Vaga_Vag_ID, v => v.Vag_ID, (p, v) => p), a => a.DP_Pessoa_Pes_ID, p => p.Pes_ID, (a, p) => a).Where(a => a.DP_Situation == true).Count();

            if (QuantidadeDependentes==5)
            {
                return true;
            }

            return false;
        }
    }
}
