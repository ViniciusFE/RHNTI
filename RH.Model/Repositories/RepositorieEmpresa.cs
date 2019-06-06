using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Repositories
{
    public class RepositorieEmpresa
    {
        private RHEntities odb;

        public RepositorieEmpresa()
        {
            odb = Helper.Connection.GetConnection();
        }

        public RepositorieEmpresa(RHEntities _odb)
        {
            odb = _odb;
        }

        public List<Empresa> SelecionarTodasEmpresas()
        {
            return odb.Empresa.Where(p => p.Emp_Situation == true).ToList();
        }

        public List<Empresa> SelecionarEmpresasUsuario(int IDUsuario)
        {
            return odb.Empresa.Where(p => p.Emp_Aluno_Alu_ID.Equals(IDUsuario) && p.Emp_Situation == true).ToList();
        }

        public void CadastrarEmpresa(Empresa aEmpresa)
        {
            odb.Entry(aEmpresa).State = System.Data.Entity.EntityState.Added;
            odb.SaveChanges();
        }

        public void AlterarEmpresa(Empresa aEmpresa)
        {
            odb.Entry(aEmpresa).State = System.Data.Entity.EntityState.Modified;
        }

        public void ExcluirEmpresa(Empresa aEmpresa)
        {
            odb.Entry(aEmpresa).State = System.Data.Entity.EntityState.Deleted;
            odb.SaveChanges();
        }
    }
}
