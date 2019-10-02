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
            odb.Entry(aAvaliacao).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }

        public List<Avaliacao> SelecionarAAvaliacoesEmpresa(int IDEmpresa, string Pesquisado)
        {
            return odb.Avaliacao.Join(odb.Pessoa.Where(p=>p.Pes_Nome.Contains(Pesquisado)).Join(odb.Vaga.Join(odb.Cargo.Join(odb.Setor.Where(s => s.Set_Empresa_Emp_ID.Equals(IDEmpresa)), c => c.Car_Setor_Set_ID, s => s.Set_ID, (c, s) => c), v => v.Vag_Cargo_Car_ID, c => c.Car_ID, (v, c) => v), p => p.Pes_Vaga_Vag_ID, v => v.Vag_ID, (p, v) => p), a => a.Ava_Pessoa_Pes_ID, p => p.Pes_ID, (a, p) => a).Where(a => a.Ava_Situation == true).ToList();
        }

        public Avaliacao SelecionarAvaliacaoDiaCadastro(string DataCadastro, int IDEmpresa)
        {
            return odb.Avaliacao.Join(odb.Pessoa.Join(odb.Vaga.Join(odb.Cargo.Join(odb.Setor.Where(s => s.Set_Empresa_Emp_ID.Equals(IDEmpresa)), c => c.Car_Setor_Set_ID, s => s.Set_ID, (c, s) => c), v => v.Vag_Cargo_Car_ID, c => c.Car_ID, (v, c) => v), p => p.Pes_Vaga_Vag_ID, v => v.Vag_ID, (p, v) => p), a => a.Ava_Pessoa_Pes_ID, p => p.Pes_ID, (a, p) => a).Where(a => a.Ava_Situation == true && a.Ava_DataCadastro.Equals(DataCadastro)).Last();
        }

        public bool LimiteAvaliacoesEmpresaAvaliativa(int IDEmpresa)
        {
            int QuantidadeAvaliacoes=odb.Avaliacao.Join(odb.Pessoa.Join(odb.Vaga.Join(odb.Cargo.Join(odb.Setor.Where(s => s.Set_Empresa_Emp_ID.Equals(IDEmpresa)), c => c.Car_Setor_Set_ID, s => s.Set_ID, (c, s) => c), v => v.Vag_Cargo_Car_ID, c => c.Car_ID, (v, c) => v), p => p.Pes_Vaga_Vag_ID, v => v.Vag_ID, (p, v) => p), a => a.Ava_Pessoa_Pes_ID, p => p.Pes_ID, (a, p) => a).Where(a => a.Ava_Situation == true).ToList().Count();
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

        public bool Cadastrar(Avaliacao aAvaliacao)
        {
            return true;
        }

    }
}
