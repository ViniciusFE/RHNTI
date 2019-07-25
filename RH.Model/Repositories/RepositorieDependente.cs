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
    }
}
