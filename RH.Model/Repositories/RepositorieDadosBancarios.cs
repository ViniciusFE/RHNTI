using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Repositories
{
    public class RepositorieDadosBancarios
    {
        private RHEntities odb;

        public RepositorieDadosBancarios()
        {
            odb = Helper.Connection.GetConnection();
        }

        public RepositorieDadosBancarios(RHEntities _odb)
        {
            odb = _odb;
        }

        public List<DadoBancario> DadosBancariosFuncionario(int IDFuncionario)
        {
            return odb.DadoBancario.Where(p => p.DB_Pessoa_Pes_ID.Equals(IDFuncionario) && p.DB_Situation == true).ToList();
        }

        public DadoBancario SelecionarDadoBancario(int id)
        {
            return odb.DadoBancario.Where(p => p.DB_ID.Equals(id) && p.DB_Situation == true).FirstOrDefault();
        }

        public void CadastrarDadoBancario(DadoBancario oDado)
        {
            odb.Entry(oDado).State = System.Data.Entity.EntityState.Added;
            odb.SaveChanges();
        }

        public void AlterarDadoBancario(DadoBancario oDado)
        {
            odb.Entry(oDado).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }
    }
}
