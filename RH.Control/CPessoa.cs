using RH.Model;
using RH.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Control
{
    public class CPessoa
    {
        private RepositoriePessoa RepFuncionario = new RepositoriePessoa();

        public void CadastrarFuncionario(Pessoa oFuncionario)
        {
            RepFuncionario.CadastrarFuncionario(oFuncionario);
        }

        public List<Pessoa> SelecionarTodosFuncionario()
        {
            return RepFuncionario.SelecionarTodosFuncionarios();
        }

        public Pessoa SelecionarFuncionario(int IDFuncionario)
        {
            return RepFuncionario.SelecionarFuncionario(IDFuncionario);
        }

        public void AlterarFuncionario(Pessoa oFuncionario)
        {
            RepFuncionario.CadastrarFuncionario(oFuncionario);
        }

        public void DeletarFuncionario(Pessoa oFuncionario)
        {
            RepFuncionario.DeletarFuncionario(oFuncionario);
        }
    }
}