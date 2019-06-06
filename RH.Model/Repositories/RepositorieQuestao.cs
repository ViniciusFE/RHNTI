using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Repositories
{
    public class RepositorieQuestao
    {
        private RHEntities odb;

        public RepositorieQuestao()
        {
            odb = Helper.Connection.GetConnection();
        }

        public RepositorieQuestao(RHEntities _odb)
        {
            odb = _odb;
        }

        public List<Questao> SelecionarTodasQuestoes()
        {
            return odb.Questao.Where(p => p.Que_Situation == true).ToList();
        }

        public Questao SelecionarQuestao(int id)
        {
            return odb.Questao.Where(p => p.Que_ID.Equals(id)).FirstOrDefault();
        }

        public void CadastrarQuestao(Questao aQuestao)
        {
            odb.Entry(aQuestao).State = System.Data.Entity.EntityState.Added;
            odb.SaveChanges();
        }

        public void AlterarQuestao(Questao aQuestao)
        {
            odb.Entry(aQuestao).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }

        public void ExcluirQuestao(Questao aQuestao)
        {
            odb.Entry(aQuestao).State = System.Data.Entity.EntityState.Deleted;
            odb.SaveChanges();
        }
    }
}
