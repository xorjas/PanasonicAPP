using DataEntities;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AnnoDA
    {
        public IList<AnnoDE> ObtenerAnnos()
        {

            using (var conn = new PanasonicConexion())
            {
                var query = from anno in conn.Anno
                            select new AnnoDE()
                            {
                                ID_Anno = anno.ID_ANNO,
                                Nombre_Anno = anno.Detalle_Anno
                            };
                return query.ToList();
            }
        }
    }
}
