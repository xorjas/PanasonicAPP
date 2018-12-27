using DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace DataLogic
{
    public class MarcaDL
    {
        public IList<MarcaDE> ObtenerMarcas() {

            MarcaDA dataAccess = new MarcaDA();
            return dataAccess.ObtenerMarcas();

        }
    }
}
