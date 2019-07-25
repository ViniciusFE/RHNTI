using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RH.Model;
using RH.Model.Repositories;

namespace RH.Control
{
    public class CDadoBancario
    {
        private RepositorieDadosBancarios _RepositorieDadoBancario;
        private RepositoriePessoa _RepositorieFuncionario;
        private RepositorieEmpresa _RepositorieEmpresa;

        public CDadoBancario()
        {
            _RepositorieDadoBancario = new RepositorieDadosBancarios();
            _RepositorieFuncionario = new RepositoriePessoa();
            _RepositorieEmpresa = new RepositorieEmpresa();
        }

        public List<DadoBancario> DadosBanacarioFuncionario(int IDFuncionario)
        {
            return _RepositorieDadoBancario.DadosBancariosFuncionario(IDFuncionario);
        }

        public DadoBancario SelecionarDadoBancario(int IDFuncionario)
        {
            return _RepositorieDadoBancario.SelecionarDadoBancario(IDFuncionario);
        }

        public void CadastrarDadoBancario(DadoBancario oDado)
        {
            _RepositorieDadoBancario.CadastrarDadoBancario(oDado);
        }

        public void AlterarDadoBancario(DadoBancario oDado)
        {
            _RepositorieDadoBancario.AlterarDadoBancario(oDado);
        }

        public Pessoa SelecionarFuncionario(int IDFuncionario)
        {
            return _RepositorieFuncionario.SelecionarFuncionario(IDFuncionario);
        }

        public Empresa SelecionarEmpresa(int IDEmpresa)
        {
            return _RepositorieEmpresa.SelecionarEmpresa(IDEmpresa);
        }
    }
}
