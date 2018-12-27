using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntities;
using DataAccess;

namespace DataLogic
{
    public class BateriaDL
    {
        public BateriaDE ObtenerBateria(BusquedaDE model)
        {
            BateriaDA dataAccess = new BateriaDA();
            return dataAccess.ObtenerBateria(model);
        }

        public IList<BateriaDE> ObtenerBaterias()
        {
            BateriaDA dataAccess = new BateriaDA();
            return dataAccess.ObtenerBaterias();
        }

        public IList<MasterDE> ObtenerMaster()
        {
            BateriaDA dataAccess = new BateriaDA();
            return dataAccess.ObtenerMaster();
        }
    }
}
