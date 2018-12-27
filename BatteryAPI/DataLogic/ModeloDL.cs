using DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace DataLogic
{
    public class ModeloDL
    {
        public IList<ModeloDE> ObtenerModelos(int idMarca) {

            ModeloDA dataAccess = new ModeloDA();
            return dataAccess.ObtenerModelos(idMarca);

        }

        public IList<ModeloDE> ObtenerModelos() {
            ModeloDA dataAccess = new ModeloDA();
            return dataAccess.ObtenerModelos();
        }

    }
}
