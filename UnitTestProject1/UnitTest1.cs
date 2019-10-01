using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RH.Model;
using RH.Model.Repositories;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        RepositorieBeneficio _Repositorie = new RepositorieBeneficio();
        RepositorieAvaliacao _RepositorieAvaliacao = new RepositorieAvaliacao();

        [TestMethod]
        public void CadastrarBeneficio()
        {
            Beneficio oBeneficio = new Beneficio();
            oBeneficio.Ben_Custo = 100;
            oBeneficio.Ben_DataCadastro = "01/01";
            oBeneficio.Ben_Descricao = "Teste";
            oBeneficio.Ben_Empresa_Emp_ID = 1;
            oBeneficio.Ben_Nome = "Teste";
            oBeneficio.Ben_Situation = true;
            bool retorno = _Repositorie.Cadastrar(oBeneficio);
            Assert.AreEqual(true, retorno);
        }

        [TestMethod]
        public void AlterarBeneficio()
        {
          
        }

        [TestMethod]
        public void SelecionarBeneficio()
        {
     
        }

        [TestMethod]
        public void CadastrarAvaliacao()
        {
            Avaliacao aAvaliacao = new Avaliacao();
            aAvaliacao.Ava_Avaliacao = "Teste";
            aAvaliacao.Ava_DataCadastro = "01/01";
            aAvaliacao.Ava_Pessoa_Pes_ID = 1;
            aAvaliacao.Ava_Situation = true;
            bool retorno=_RepositorieAvaliacao.Cadastrar(aAvaliacao);
            Assert.AreEqual(true, retorno);
        }

        [TestMethod]
        public void SelecionarAvalicao()
        {
            
        }
    }
}
