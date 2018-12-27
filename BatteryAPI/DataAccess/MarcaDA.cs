using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntities;
using DataModel;

namespace DataAccess
{
    public class MarcaDA
    {
        public IList<MarcaDE> ObtenerMarcas() {

            using (var conn = new PanasonicConexion())
            {
                var query = from marca in conn.Marca
                            select new MarcaDE()
                            {
                                ID_Marca = marca.ID_Marca,
                                Nombre_Marca = marca.Detalle_Marca
                            };
                return query.ToList();
            }

            

        }
    }
}
