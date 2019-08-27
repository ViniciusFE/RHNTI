using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Repositories
{
    public class RepositorieErro
    {
        private RHEntities odb;

        public RepositorieErro()
        {
            odb = Helper.Connection.GetConnection();
        }

        public RepositorieErro(RHEntities _odb)
        {
            odb = _odb;
        }

       public List<Erro> SelecionarErroProva(int IDProva)
        {
            return odb.Erro.Where(p => p.Err_Prova_Pro_ID.Equals(IDProva)).ToList();
        }

        public void CadastrarErro(Erro oErro)
        {
            odb.Erro.Add(oErro);
            odb.SaveChanges();
        }


    }
}
