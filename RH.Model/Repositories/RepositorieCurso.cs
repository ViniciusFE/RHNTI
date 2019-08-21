using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Repositories
{
    public class RepositorieCurso
    {
        private RHEntities odb;

        public RepositorieCurso()
        {
            odb = Helper.Connection.GetConnection();
        }

        public RepositorieCurso(RHEntities _odb)
        {
            odb = _odb;
        }

        public Curso SelecionarCurso(int id)
        {
            return odb.Curso.Where(p => p.Cur_ID.Equals(id)).FirstOrDefault();
        }
    }
}
