using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Repositories
{
    public class RepositorieDemissao
    {
        private RHEntities odb;

        public RepositorieDemissao()
        {
            odb = Helper.Connection.GetConnection();
        }

        public RepositorieDemissao(RHEntities _odb)
        {
            odb = _odb;
        }

        public void CadastrarDemissao(Demissao aDemissao)
        {
            odb.Entry(aDemissao).State = System.Data.Entity.EntityState.Added;
            odb.SaveChanges();
        }

        public void AlterarDemissao(Demissao aDemissao)
        {
            odb.Entry(aDemissao).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }

        public Demissao SelecionarDemissao(int id)
        {
            return odb.Demissao.Where(p => p.Dem_ID.Equals(id)).FirstOrDefault();
        }

        public Demissao SelecionarDemissaoDataCadastro(string DataCadastro,int IDEmpresa)
        {
            return odb.Demissao.SqlQuery("select * from Demissao d inner join Pessoa p on d.Dem_Pessoa_Pes_ID = p.Pes_ID inner join Cargo c on p.Pes_Cargo_Car_ID = c.Car_ID inner join Setor s on c.Car_Setor_Set_ID = s.Set_ID and s.Set_Empresa_Emp_ID = "+IDEmpresa+ " where d.Dem_Situation = 1 and d.Dem_DataCadastro='"+DataCadastro+"'").FirstOrDefault();
        }

        public bool LimiteDemissoesEmpresaAvaliativa(int IDEmpresa)
        {
            int QuantidadeDemissoes = odb.Demissao.SqlQuery("select * from Demissao d inner join Pessoa p on d.Dem_Pessoa_Pes_ID = p.Pes_ID inner join Cargo c on p.Pes_Cargo_Car_ID = C.Car_ID inner join Setor s on c.Car_Setor_Set_ID = s.Set_ID and s.Set_Empresa_Emp_ID = "+IDEmpresa+" where d.Dem_Situation = 1").Count();

            if(QuantidadeDemissoes>=3)
            {
                return true;
            }

            return false;
        }

    }
}
