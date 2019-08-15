using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RH.Model;
using RH.Model.Repositories;

namespace RH.Control
{
    public class CBeneficio
    {
        RepositorieBeneficio _C;
        RepositoriePessoa _RepositoriePessoa;
        RepositorieEmpresa _RepositorieEmpresa;

        public CBeneficio()
        {
            _C = new RepositorieBeneficio();
            _RepositoriePessoa = new RepositoriePessoa();
            _RepositorieEmpresa = new RepositorieEmpresa();
        }

        public void Incluir(Beneficio oBeneficio)
        {
            _C.Incluir(oBeneficio);
        }

        public void Alterar(Beneficio oBeneficio)
        {
            _C.Alterar(oBeneficio);
        }

        public void Excluir(Beneficio oBeneficio)
        {
            _C.Excluir(oBeneficio);
        }

        public Beneficio SelecionarBeneficioID(int id)
        {
            return _C.SelecionarBeneficioporID(id);
        }

        public List<Beneficio> SelecionarTodosBeneficios()
        {
            return _C.SelecionarTodosBeneficions().ToList();
        }

        public Pessoa SelecionarFuncionario(int IDFuncionario)
        {
            return _RepositoriePessoa.SelecionarFuncionario(IDFuncionario);
        }

        public List<Beneficio> SelecionarBeneficiosEmpresa(int IDEmpresa)
        {
            return _C.SelecionarBeneficioporEmpresa(IDEmpresa);
        }

        public Empresa SelecionarEmpresa(int IDEmpresa)
        {
            return _RepositorieEmpresa.SelecionarEmpresa(IDEmpresa);
        }

        public bool LimiteBeneficiosEmpresaAvaliativa(int IDEmpresa)
        {
            return _C.LimiteBeneficiosEmpresa(IDEmpresa);
        }
    }
}
