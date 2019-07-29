using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Repositories
{
    public class RepositoriePessoaBeneficio
    {
        private RHEntities odb;

        public RepositoriePessoaBeneficio()
        {
            odb = Helper.Connection.GetConnection();
        }

        public RepositoriePessoaBeneficio(RHEntities _odb)
        {
            odb = _odb;
        }

        public List<PessoaBeneficio> BeneficiosFuncionario(int id)
        {
            return odb.PessoaBeneficio.Where(p => p.PB_Pessoa_Pes_ID.Equals(id) && p.PB_Situation == true).ToList();
        }

        public PessoaBeneficio SelecionarBeneficio(int id)
        {
            return odb.PessoaBeneficio.Where(p => p.PB_ID.Equals(id) && p.PB_Situation == true).FirstOrDefault();
        }

        public void CadastrarBeneficioFuncionario(PessoaBeneficio Beneficio)
        {
            odb.Entry(Beneficio).State = System.Data.Entity.EntityState.Added;
            odb.SaveChanges();
        }

        public void AlterarBeneficioFuncionario(PessoaBeneficio Beneficio)
        {
            odb.Entry(Beneficio).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }

        public void DesabilitarBeneficiosFuncionario(int IDFuncionario)
        {
            odb.Database.ExecuteSqlCommand("update PessoaBeneficio set PB_Situation=0 where PB_Pessoa_Pes_ID= " + IDFuncionario);
            odb.SaveChanges();
        }
    }
}
