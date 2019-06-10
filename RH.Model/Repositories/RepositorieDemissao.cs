using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Repositories
{
    public class RepositorieDemissao
    {
        private RHEntities odb;

        public RepositorieDemissao()
        {
            odb = Helper.Connection.GetConnection();
        }

        public RepositorieDemissao(RHEntities _odb)
        {
            odb = _odb;
        }

        public void CadastrarDemissao(Demissao aDemissao)
        {
            odb.Entry(aDemissao).State = System.Data.Entity.EntityState.Added;
            odb.SaveChanges();
        }
    }
}
