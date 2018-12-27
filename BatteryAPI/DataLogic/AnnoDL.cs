using DataAccess;
using DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic
{
    public class AnnoDL
    {
        public IList<AnnoDE> ObtenerAnnnos()
        {
            AnnoDA dataAccess = new AnnoDA();
            return dataAccess.ObtenerAnnos();
        }
    }
}
