using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Repositories
{
    public class RepositorieVaga
    {
        private RHEntities odb = new RHEntities();

        public RepositorieVaga()
        {
            odb = Helper.Connection.GetConnection();
        }

        public Vaga SelecionarVaga(int id)
        {
            return odb.Vaga.Where(v => v.Vag_ID.Equals(id) && v.Vag_Situation == true).FirstOrDefault();
        }

        public List<Vaga> SelecionarVagas(int IDEmpresa)
        {
            return odb.Vaga.Join(odb.Cargo, v => v.Vag_Cargo_Car_ID, c => c.Car_ID, (v, c) => v).Where(v => v.Vag_Situation == true).ToList();
        }

        public void CadastrarVaga(Vaga aVaga)
        {
            odb.Entry(aVaga).State = System.Data.Entity.EntityState.Added;
            odb.SaveChanges();
        }

        public Vaga SelecionarVagaDiaCadastro(string DataCadastro,int IDEmpresa)
        {
            return odb.Vaga.Join(odb.Cargo.Join(odb.Setor.Where(s=>s.Set_Empresa_Emp_ID.Equals(IDEmpresa)),c=>c.Car_Setor_Set_ID,s=>s.Set_Setor_Set_ID,(c,s)=>c), v => v.Vag_Cargo_Car_ID, c => c.Car_ID, (v,c) => v).Where(v => v.Vag_DataCadastro.Equals(DataCadastro) && v.Vag_Situation == true).Last();
        }
    }
}
