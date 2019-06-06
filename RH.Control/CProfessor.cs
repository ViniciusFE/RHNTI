using RH.Model;
using RH.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Control
{
    public class CProfessor
    {
        private RepositorieProfessor RepProfessor = new RepositorieProfessor();


        public Professor LoginProfessor(string email, string senha)
        {
            return RepProfessor.LoginProfessor(email, senha);
        }

        public Professor SelecionarProfessor(int IDPro)
        {
            return RepProfessor.SelecionarProfessor(IDPro);
        }

        public void AlterarProfessor(Professor oProfessor)
        {
            RepProfessor.AlterarProfessor(oProfessor);
        }

        public void AdicionarProfessor(Professor oProfessor)
        {
            RepProfessor.AdicionarProfessor(oProfessor);
        }

        public void DeletarProfessor(Professor oProfessor)
        {
            RepProfessor.DeletarProfessor(oProfessor);
        }
    }
}