using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RH.Model.Repositories
{
    public class RepositorieBeneficio
    {
        private RHEntities Db = new RHEntities();

        public RepositorieBeneficio()
        {
            Db = new RHEntities();
        }

        public List<Beneficio> SelecionarTodosBeneficions()
        {
            return Db.Beneficio.Where(i => i.Ben_Situation == true).ToList();
        }

        public Beneficio SelecionarBeneficioporID(int id)
        {
            return Db.Beneficio.Find(id);
        }

        public void Incluir(Beneficio oBeneficio)
        {
            Db.Entry(oBeneficio).State = EntityState.Added;
            Db.SaveChanges();
        }

        public void Alterar(Beneficio oBeneficio)
        {
            Db.Entry(oBeneficio).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Excluir(Beneficio oBeneficio)
        {
            Db.Entry(oBeneficio).State = EntityState.Deleted;
            Db.SaveChanges();
        }

        public List<Beneficio> BeneficiosEmpresa(int IDEmpresa)
        {
            return Db.Beneficio.Where(p => p.Ben_Empresa_Emp_ID.Equals(IDEmpresa) && p.Ben_Situation == true).ToList();
        }

    }
}
