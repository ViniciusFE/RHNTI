using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Repositories
{
    public class RepositorieAvaliacao
    {
        private RHEntities odb;

        public RepositorieAvaliacao()
        {
            odb = Helper.Connection.GetConnection();
        }

        public RepositorieAvaliacao(RHEntities _odb)
        {
            odb = _odb;
        }

        public List<Avaliacao> SelecionarTodasAvaliacoes()
        {
            return odb.Avaliacao.Where(p => p.Ava_Situation == true).ToList();
        }

        public Avaliacao SelecionarAvaliacao(int id)
        {
            return odb.Avaliacao.Where(p => p.Ava_ID.Equals(id) && p.Ava_Situation == true).FirstOrDefault();
        }

        public void CadastrarAvaliacao(Avaliacao aAvaliacao)
        {
            odb.Entry(aAvaliacao).State = System.Data.Entity.EntityState.Added;
            odb.SaveChanges();
        }

        public void AlterarAvaliacao(Avaliacao aAvaliacao)
        {
            odb.Entry(aAvaliacao).State = System.Data.Entity.EntityState.Added;
            odb.SaveChanges();
        }

        public List<Avaliacao> SelecionarAAvaliacoesEmpresa(int IDEmpresa, string Pesquisado)
        {
            return odb.Avaliacao.SqlQuery("select * from Avaliacao a inner join Pessoa p on a.Ava_Pessoa_Pes_ID = p.Pes_ID and p.Pes_Situation = 1 and p.Pes_Nome like '" + Pesquisado + "%' inner join Cargo c on p.Pes_Cargo_Car_ID = c.Car_ID inner join Setor s on c.Car_Setor_Set_ID = s.Set_ID and s.Set_Empresa_Emp_ID =" + IDEmpresa).ToList();
        }

        public Avaliacao SelecionarAvaliacaoDiaCadastro(string DataCadastro, int IDEmpresa)
        {
            return odb.Avaliacao.SqlQuery("select * from Avaliacao a inner join Pessoa p on a.Ava_Pessoa_Pes_ID = p.Pes_ID and p.Pes_Situation = 1 inner join Cargo c on p.Pes_Cargo_Car_ID = c.Car_ID inner join Setor s on c.Car_Setor_Set_ID = s.Set_ID and s.Set_Empresa_Emp_ID = " + IDEmpresa + " where a.Ava_Situation = 1 and a.Ava_DataCadastro='" + DataCadastro + "'").FirstOrDefault();
        }

        public bool LimiteAvaliacoesEmpresaAvaliativa(int IDEmpresa)
        {
            int QuantidadeAvaliacoes = odb.Avaliacao.SqlQuery("select * from Avaliacao a inner join Pessoa p on a.Ava_Pessoa_Pes_ID = p.Pes_ID inner join Cargo c on p.Pes_Cargo_Car_ID = c.Car_ID inner join Setor s on c.Car_Setor_Set_ID = s.Set_ID and s.Set_Empresa_Emp_ID = " + IDEmpresa + " where a.Ava_Situation = 1").Count();

            if (QuantidadeAvaliacoes == 4)
            {
                return true;
            }

            return false;
        }

        public void DesabilitarAvaliacoes(int IDPessoa)
        {
            odb.Database.ExecuteSqlCommand("update Avaliacao set Ava_Situation=0 where Ava_Pessoa_Pes_ID=" + IDPessoa);
            odb.SaveChanges();
        }

    }
}
