using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Repositories
{
    public class RepositorieSetor
    {
        RHEntities odb;

        public RepositorieSetor()
        {
            odb = Helper.Connection.GetConnection();
        }

        public RepositorieSetor(RHEntities _odb)
        {
            odb = _odb;
        }

        public List<Setor> SelecionarTodosSetores()
        {
            return odb.Setor.Where(p => p.Set_Situation == true).ToList();
        }

        public List<Setor> SelecionarSetorEmpresa(int IDEmpresa)
        {
            return odb.Setor.Where(p => p.Set_Empresa_Emp_ID.Equals(IDEmpresa) && p.Set_Situation == true).ToList();
        }

        public Setor SelecionarSetor(int id)
        {
            return (from p in odb.Setor where p.Set_ID == id select p).FirstOrDefault();
        }

        public void CadastrarSetor(Setor oSetor)
        {
            odb.Entry(oSetor).State = System.Data.Entity.EntityState.Added;
            odb.SaveChanges();
        }


        public void AlterarSetor(Setor oSetor)
        {
            odb.Entry(oSetor).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }

        public void ExcluirSetor(Setor oSetor)
        {
            odb.Entry(oSetor).State = System.Data.Entity.EntityState.Deleted;
            odb.SaveChanges();
        }
    }
}
