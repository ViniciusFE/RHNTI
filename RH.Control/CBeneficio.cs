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
        private RepositorieBeneficio _RepositorieBeneficio;

        public CBeneficio()
        {
            _RepositorieBeneficio = new RepositorieBeneficio();
        }

        public List<Beneficio> SelecionarTodosBeneficios()
        {
            return _RepositorieBeneficio.SelecionarTodosBeneficios();
        }

        public Beneficio SelecionarBeneficio(int id)
        {
            return _RepositorieBeneficio.SelecionarBeneficio(id);
        }

        public void CadastrarBeneficio(Beneficio oBeneficio)
        {
            _RepositorieBeneficio.CadastrarBeneficio(oBeneficio);
        }

        public void AlterarBeneficio(Beneficio oBeneficio)
        {
            _RepositorieBeneficio.AlterarBeneficio(oBeneficio);
        }
    }
}
