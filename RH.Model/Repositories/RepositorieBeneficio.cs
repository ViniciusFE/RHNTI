using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Repositories
{
    public class RepositorieBeneficio
    {
        private RHEntities odb;

        public RepositorieBeneficio()
        {
            odb = Helper.Connection.GetConnection();
        }

        public RepositorieBeneficio(RHEntities _odb)
        {
            odb = _odb;
        }

        public List<Beneficio> SelecionarTodosBeneficios()
        {
            return odb.Beneficio.Where(p => p.Ben_Situation == true).OrderBy(p => p.Ben_ID).ToList();
        }

        public Beneficio SelecionarBeneficio(int id)
        {
            return odb.Beneficio.Where(p => p.Ben_ID.Equals(id) && p.Ben_Situation == true).FirstOrDefault();
        }

        public void CadastrarBeneficio(Beneficio oBeneficio)
        {
            odb.Entry(oBeneficio).State = System.Data.Entity.EntityState.Added;
            odb.SaveChanges();
        }

        public void AlterarBeneficio(Beneficio oBeneficio)
        {
            odb.Entry(oBeneficio).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }
    }
}
