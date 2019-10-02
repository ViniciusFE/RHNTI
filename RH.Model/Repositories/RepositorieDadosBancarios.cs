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

        public void DesabilitarDadosBancarios(int IDFuncionario)
        {
            odb.Database.ExecuteSqlCommand("update DadoBancario set DB_Situation=0 where DB_Pessoa_Pes_ID= " + IDFuncionario);
            odb.SaveChanges();
        }

        public DadoBancario SelecionarDadoBancarioDataCadastro(string DataCadastro, int IDEmpresa)
        {
            return odb.DadoBancario.Join(odb.Pessoa.Join(odb.Vaga.Join(odb.Cargo.Join(odb.Setor.Where(s => s.Set_Empresa_Emp_ID.Equals(IDEmpresa)), c => c.Car_Setor_Set_ID, s => s.Set_ID, (c, s) => c), v => v.Vag_Cargo_Car_ID, c => c.Car_ID, (v, c) => v), p => p.Pes_Vaga_Vag_ID, v => v.Vag_ID, (p, v) => p), a => a.DB_Pessoa_Pes_ID, p => p.Pes_ID, (a, p) => a).Where(a => a.DB_Situation == true && a.DB_DataCadastro.Equals(DataCadastro)).Last();
        }

        public bool LimiteDadosBancariosEmpresaAvaliativa(int IDEmpresa)
        {
            int QuantidadeDados = odb.DadoBancario.Join(odb.Pessoa.Join(odb.Vaga.Join(odb.Cargo.Join(odb.Setor.Where(s => s.Set_Empresa_Emp_ID.Equals(IDEmpresa)), c => c.Car_Setor_Set_ID, s => s.Set_ID, (c, s) => c), v => v.Vag_Cargo_Car_ID, c => c.Car_ID, (v, c) => v), p => p.Pes_Vaga_Vag_ID, v => v.Vag_ID, (p, v) => p), a => a.DB_Pessoa_Pes_ID, p => p.Pes_ID, (a, p) => a).Where(a => a.DB_Situation == true).Count();

            if (QuantidadeDados==5)
            {
                return true;
            }

            return false;
        }
    }
}
