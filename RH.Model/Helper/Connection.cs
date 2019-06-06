using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Model.Helper
{
    public class Connection
    {
        public static RHEntities GetConnection()
        {
            RHEntities odb = new RHEntities();
            return odb;
        }
    }
}
