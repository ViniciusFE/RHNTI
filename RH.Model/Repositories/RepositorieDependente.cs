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
            odb.Entry(oDependente).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }
    }
}
