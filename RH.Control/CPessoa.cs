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
        private RepositorieSetor _RepositorieSetor = new RepositorieSetor();
        private RepositorieCargo _RepositorieCargo = new RepositorieCargo();
        private RepositorieDemissao _RepositorieDemissao = new RepositorieDemissao();
        private RepositorieBeneficio _RepositorieBeneficio = new RepositorieBeneficio();
        private RepositorieDadosBancarios _RepositorieDadoBancario = new RepositorieDadosBancarios();
        private RepositoriePessoaBeneficio _RepositoriePessoaBeneficio = new RepositoriePessoaBeneficio();
        private RepositorieDependente _RepositorieDependente = new RepositorieDependente();
        private RepositorieEmpresa _RepositorieEmpresa = new RepositorieEmpresa();
        private RepositorieAvaliacao _RepositorieAvaliacao = new RepositorieAvaliacao();

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
            RepFuncionario.AlterarFuncionario(oFuncionario);
        }

        public void DeletarFuncionario(Pessoa oFuncionario)
        {
            RepFuncionario.DeletarFuncionario(oFuncionario);
        }

        public bool AutenticaCargo(int cargo)
        {
            return RepFuncionario.AutenticaCargo(cargo);
        }

        public List<Pessoa> SelecionarTodosFuncionariosEmpresa(int IDEmpresa)
        {
            return RepFuncionario.SelecionarTodosFuncionariosEmpresa(IDEmpresa);
        }

        public List<Setor> SelecionarTodosSetores(int IDEmpresa)
        {
            return _RepositorieSetor.SelecionarSetorEmpresa(IDEmpresa);
        }

        public List<Cargo> SelecionarCargosEmpresa(int IDEmpresa)
        {
            return _RepositorieCargo.SelecionarTodosCargosEmpresa(IDEmpresa);
        }

        public void CadastrarDemissao(Demissao aDemissao)
        {
            _RepositorieDemissao.CadastrarDemissao(aDemissao);
        }

        public List<Beneficio> BeneficiosEmpresa(int IDEmpresa)
        {
            return _RepositorieBeneficio.BeneficiosEmpresa(IDEmpresa);
        }

        public void DesabilitarDadosBancarios(int IDFuncionario)
        {
            _RepositorieDadoBancario.DesabilitarDadosBancarios(IDFuncionario);
        }

        

        public PessoaBeneficio SelecionarBeneficioFuncionario(int IDFuncionario)
        {
            return _RepositoriePessoaBeneficio.SelecionarBeneficio(IDFuncionario);
        }

        public void CadastrarBeneficioFuncionario(PessoaBeneficio Beneficio)
        {
            _RepositoriePessoaBeneficio.CadastrarBeneficioFuncionario(Beneficio);
        }

        public void AlterarBeneficioFuncionario(PessoaBeneficio Beneficio)
        {
            _RepositoriePessoaBeneficio.AlterarBeneficioFuncionario(Beneficio);
        }

        public void DesabilitarBeneficiosFuncionario(int IDFuncionario)
        {
            _RepositoriePessoaBeneficio.DesabilitarBeneficiosFuncionario(IDFuncionario);
        }

        public void DesabilitarDependentesFuncionario(int IDFuncionario)
        {
            _RepositorieDependente.DesabilitarDependentes(IDFuncionario);
        }

        public Empresa SelecionarEmpresa(int IDEmpresa)
        {
            return _RepositorieEmpresa.SelecionarEmpresa(IDEmpresa);
        }

        public List<PessoaBeneficio> BeneficiosFuncionariosEmpresa(int IDEmpresa)
        {
            return _RepositoriePessoaBeneficio.BeneficiosFuncionariosEmpresa(IDEmpresa);
        }

        public bool PossuiBeneficio(int IDBeneficio,int IDFuncionario)
        {
            return _RepositoriePessoaBeneficio.PossuiBeneficio(IDBeneficio, IDFuncionario);
        }

        public PessoaBeneficio SelecionarBeneficioFuncionario(int IDBeneficio,int IDFuncionario)
        {
            return _RepositoriePessoaBeneficio.SelecionarBeneficioFuncionario(IDBeneficio, IDFuncionario);
        }

        public void ExcluirBeneficioFuncionario(PessoaBeneficio oBeneficio)
        {
            _RepositoriePessoaBeneficio.ExcluirBeneficioFuncionario(oBeneficio);
        }

        public bool LimiteFuncionariosEmpresaAvaliativa(int IDEmpresa)
        {
            return RepFuncionario.LimiteFuncionariosEmpresaAvaliativa(IDEmpresa);
        }

        public Cargo SelecionarCargo(int IDCargo)
        {
            return _RepositorieCargo.SelecionarCargo(IDCargo);
        }

        public bool CargoOcupado(int IDCargo)
        {
            return RepFuncionario.CargoOcupado(IDCargo);
        }

        public bool LimiteDemissoesEmpresaAvaliativa(int IDEmpresa)
        {
            return _RepositorieDemissao.LimiteDemissoesEmpresaAvaliativa(IDEmpresa);
        }

        public void DesabilitarAvaliacoes(int IDPessoa)
        {
            _RepositorieAvaliacao.DesabilitarAvaliacoes(IDPessoa);
        }

        public bool LimiteBeneficiosFuncionariosEmpresaAvaliativa(int IDEmpresa)
        {
            return _RepositoriePessoaBeneficio.LimiteBeneficiosFuncionariosEmpresaAvaliativa(IDEmpresa);
        }
    }
}
