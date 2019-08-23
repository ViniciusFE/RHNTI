using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Repositories
{
    public class RepositorieNota
    {
        private RHEntities odb;

        public RepositorieNota()
        {
            odb = Helper.Connection.GetConnection();
        }

        public RepositorieNota(RHEntities _odb)
        {
            odb = _odb;
        }

        public List<Nota> SelecionarTodasNotasProva(int Codigo)
        {
            return odb.Nota.Join(odb.Prova.Where(p => p.Pro_Codigo.Equals(Codigo)), n => n.Not_Prova_Pro_ID, p => p.Pro_ID, (n, p) => n).ToList();
        }

        public Nota SelecionarNota(int IDProva)
        {
            return odb.Nota.Where(p => p.Not_Prova_Pro_ID.Equals(IDProva)).FirstOrDefault();
        }

        public void CadastrarNota(Nota aNota)
        {
            odb.Entry(aNota).State = System.Data.Entity.EntityState.Added;
            odb.SaveChanges();
        }

        public void AlterarNota(Nota aNota)
        {
            odb.Entry(aNota).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }

        public List<Nota> SelecionarNotasProva(int CodigoProva)
        {
            return odb.Nota.Join(odb.Prova.Where(p => p.Pro_Situation == true && p.Pro_Codigo.Equals(CodigoProva)), n => n.Not_Prova_Pro_ID, p => p.Pro_ID, (n, p) => n).ToList();
        }
    }
}
