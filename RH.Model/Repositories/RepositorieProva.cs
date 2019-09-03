using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Repositories
{
    public class RepositorieProva
    {
        private RHEntities odb;

        public RepositorieProva()
        {
            odb = Helper.Connection.GetConnection();
        }

        public RepositorieProva(RHEntities _odb)
        {
            odb = _odb;
        }

        public List<VW_Provas> SelecionarProvas()
        {
            return odb.VW_Provas.ToList();
        }

        public Prova SelecionarProvaAluno(int IDAluno)
        {
            return odb.Prova.Where(p => p.Pro_Aluno_Alu_ID.Equals(IDAluno) && p.Pro_Situation == true).FirstOrDefault();
        }


        public void ExcluirProva(int Codigo)
        {
            
        }

        public void CadastrarProva(Prova aProva)
        {
            odb.Entry(aProva).State = System.Data.Entity.EntityState.Added;
            odb.SaveChanges();
        }

        public int QuantidadeProvas()
        {
            return odb.Prova.ToList().Count();
        }

        public void AlterarProva(Prova aProva)
        {
            odb.Entry(aProva).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }

        public bool ProvaAtiva()
        {
            Prova aProva=odb.Prova.Where(p => p.Pro_Situation == true).FirstOrDefault();

            if(aProva!=null)
            {
                return true;
            }

            return false;
        }

       public List<Prova> SelecionarProvasCodigo(int CodigoProva)
        {
            return odb.Prova.Where(p => p.Pro_Codigo.Equals(CodigoProva) && p.Pro_Situation == true).ToList();
        }

        public List<Prova> SelecionarProvasPeloCodigo(int CodigoProva)
        {
            return odb.Prova.Where(p => p.Pro_Codigo.Equals(CodigoProva) && p.Pro_Situation == true).ToList();
        }

        public Prova SelecionarProvaPorID(int IDProva)
        {
            return odb.Prova.Where(p => p.Pro_ID.Equals(IDProva)).FirstOrDefault();
        }

        public Prova SelecionarProvaEntregue(int IDAluno)
        {
            return odb.Prova.Where(p => p.Pro_Aluno_Alu_ID.Equals(IDAluno) && p.Pro_Entregue == true).FirstOrDefault();
        }
       
    }
}
