using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Repositories
{
    public class RepositoriePessoaBeneficio
    {
        private RHEntities odb;

        public RepositoriePessoaBeneficio()
        {
            odb = Helper.Connection.GetConnection();
        }

        public RepositoriePessoaBeneficio(RHEntities _odb)
        {
            odb = _odb;
        }

        

        public PessoaBeneficio SelecionarBeneficio(int id)
        {
            return odb.PessoaBeneficio.Where(p => p.PB_ID.Equals(id) && p.PB_Situation == true).FirstOrDefault();
        }

        public void CadastrarBeneficioFuncionario(PessoaBeneficio Beneficio)
        {
            odb.Entry(Beneficio).State = System.Data.Entity.EntityState.Added;
            odb.SaveChanges();
        }

        public void AlterarBeneficioFuncionario(PessoaBeneficio Beneficio)
        {
            odb.Entry(Beneficio).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }

        public void DesabilitarBeneficiosFuncionario(int IDFuncionario)
        {
            odb.Database.ExecuteSqlCommand("update PessoaBeneficio set PB_Situation=0 where PB_Pessoa_Pes_ID= " + IDFuncionario);
            odb.SaveChanges();
        }

        public List<PessoaBeneficio> BeneficiosFuncionariosEmpresa(int IDEmpresa)
        {
            return odb.PessoaBeneficio.Join(odb.Beneficio.Where(b => b.Ben_Empresa_Emp_ID.Equals(IDEmpresa)), p => p.PB_Beneficio_Ben_ID, b => b.Ben_ID, (p, b) => p).ToList();
        }

        public bool PossuiBeneficio(int IDBeneficio,int IDFuncionario)
        {
            PessoaBeneficio Beneficio = odb.PessoaBeneficio.Where(p => p.PB_Pessoa_Pes_ID.Equals(IDFuncionario) && p.PB_Beneficio_Ben_ID.Equals(IDBeneficio) && p.PB_Situation == true).FirstOrDefault();
            if(Beneficio!=null)
            {
                return true;
            }

            return false;
        }

        public PessoaBeneficio SelecionarBeneficioFuncionario(int IDBeneficio,int IDFuncionario)
        {
            return odb.PessoaBeneficio.Where(p => p.PB_Beneficio_Ben_ID.Equals(IDBeneficio) && p.PB_Pessoa_Pes_ID.Equals(IDFuncionario)).FirstOrDefault();
        }

        public void ExcluirBeneficioFuncionario(PessoaBeneficio oBeneficio)
        {
            odb.Entry(oBeneficio).State = System.Data.Entity.EntityState.Deleted;
            odb.SaveChanges();
        }

    }
}
