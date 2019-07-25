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

        public CBeneficio()
        {
            _C = new RepositorieBeneficio();
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
            return _C.SelecionarTodosBeneficions();
        }

        public List<Beneficio> SelecionarBebeficioEmpresa(int id)
        {
            return _C.SelecionarBeneficioporEmpresa(id);
        }
    }
}
