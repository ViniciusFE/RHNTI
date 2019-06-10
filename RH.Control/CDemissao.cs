using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RH.Model;
using RH.Model.Repositories;

namespace RH.Control
{
    public class CDemissao
    {
        private RepositorieDemissao _RepositorieDemissao;

        public CDemissao()
        {
            _RepositorieDemissao = new RepositorieDemissao();
        }

        public void CadastrarDemissao(Demissao aDemissao)
        {
            _RepositorieDemissao.CadastrarDemissao(aDemissao);
        }
    }
}
