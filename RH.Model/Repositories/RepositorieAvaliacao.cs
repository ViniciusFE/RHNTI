using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Repositories
{
    public class RepositorieAvaliacao
    {
        private RHEntities odb;

        public RepositorieAvaliacao()
        {
            odb = Helper.Connection.GetConnection();
        }

        public RepositorieAvaliacao(RHEntities _odb)
        {
            odb = _odb;
        }

        public List<Avaliacao> SelecionarTodasAvaliacoes()
        {
            return odb.Avaliacao.Where(p => p.Ava_Situation == true).ToList();
        }

        public Avaliacao SelecionarAvaliacao(int id)
        {
            return odb.Avaliacao.Where(p => p.Ava_ID.Equals(id) && p.Ava_Situation == true).FirstOrDefault();
        }

        public void CadastrarAvaliacao(Avaliacao aAvaliacao)
        {
            odb.Entry(aAvaliacao).State = System.Data.Entity.EntityState.Added;
            odb.SaveChanges();
        }

        public void AlterarAvaliacao(Avaliacao aAvaliacao)
        {
            odb.Entry(aAvaliacao).State = System.Data.Entity.EntityState.Added;
            odb.SaveChanges();
        }
    }
}
