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

        public Empresa SelecionarEmpresa(int id)
        {
            return odb.Empresa.Where(p => p.Emp_ID.Equals(id) && p.Emp_Situation == true).FirstOrDefault();
        }

        public void CadastrarEmpresa(Empresa aEmpresa)
        {
            odb.Entry(aEmpresa).State = System.Data.Entity.EntityState.Added;
            odb.SaveChanges();
        }

        public void AlterarEmpresa(Empresa aEmpresa)
        {
            var local = odb.Set<Empresa>()
                        .Local
                        .FirstOrDefault(f => f.Emp_ID == aEmpresa.Emp_ID);

            odb.Entry(local).State = System.Data.Entity.EntityState.Detached;
            odb.Entry(aEmpresa).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }

        public void ExcluirEmpresa(Empresa aEmpresa)
        {
            odb.Entry(aEmpresa).State = System.Data.Entity.EntityState.Deleted;
            odb.SaveChanges();
        }

        public Empresa SelecionarEmpresaAvaliativaAluno(int IDAluno)
        {
            return odb.Empresa.Where(p => p.Emp_Aluno_Alu_ID.Equals(IDAluno) && p.Emp_Avaliativa == true).FirstOrDefault();
        }
    }
}
