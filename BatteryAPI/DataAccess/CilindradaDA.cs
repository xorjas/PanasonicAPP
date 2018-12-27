using DataEntities;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CilindradaDA
    {
        public IList<CilindradaDE> ObtenerCilindradas() {

            using (var conn = new PanasonicConexion())
            {
                var query = from cilindrada in conn.Cilindrada
                            select new CilindradaDE()
                            {
                                ID_Cilindrada = cilindrada.ID_Cilindrada,
                                Nombre_Cilindrada = cilindrada.Detalle_Cilindrada
                            };
                return query.ToList();
            }

        }
    }
}
