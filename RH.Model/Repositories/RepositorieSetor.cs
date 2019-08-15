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
            var local = odb.Set<Setor>()
                       .Local
                       .FirstOrDefault(f => f.Set_ID == oSetor.Set_ID);

            odb.Entry(local).State = System.Data.Entity.EntityState.Detached;
            odb.Entry(oSetor).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }

        public void ExcluirSetor(Setor oSetor)
        {
            odb.Entry(oSetor).State = System.Data.Entity.EntityState.Deleted;
            odb.SaveChanges();
        }

        public Setor SelecionarSetorPeloNome(string NomeSetor)
        {
            return odb.Setor.Where(p => p.Set_Nome.Equals(NomeSetor) && p.Set_Situation == true).FirstOrDefault();
        }

        public bool PossuiSetores(int IDSetor)
        {
            List<Setor> Setores = odb.Setor.Where(p => p.Set_Setor_Set_ID == IDSetor && p.Set_ID != IDSetor).ToList();

            if(Setores.Count()>0)
            {
                return true;
            }

            return false;
        }

        public int QuantidadeDeSetoresEmpresa(int IDEmpresa)
        {
            return odb.Setor.Where(p => p.Set_Empresa_Emp_ID.Equals(IDEmpresa) && p.Set_Situation==true).Count();
        }

        public Setor SelecionarSetorDiaCadastro(string DataCadastro,int IDEmpresa)
        {
            return odb.Setor.Where(p => p.Set_DataCadastro.Equals(DataCadastro) && p.Set_Empresa_Emp_ID.Equals(IDEmpresa) && p.Set_Situation==true).FirstOrDefault();
        }

        public bool LimiteSetoresEmpresaAvaliativa(int IDEmpresa)
        {
            int QuantidadeSetores = SelecionarSetorEmpresa(IDEmpresa).Count();

            if(QuantidadeSetores==5)
            {
                return true;
            }

            return false;
        }
    }
}
