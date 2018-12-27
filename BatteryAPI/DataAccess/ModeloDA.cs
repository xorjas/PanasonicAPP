using DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DataAccess
{
    public class ModeloDA
    {
        public IList<ModeloDE> ObtenerModelos(int idMarca) {
            using (var conn = new PanasonicConexion())
            {
                var query = (from master in conn.Master_Table
                            join modelo in conn.Modelo on master.ID_Marca equals modelo.ID_Modelo
                            where
                            (master.ID_Marca == idMarca)
                            select new ModeloDE()
                            {
                                ID_Modelo = modelo.ID_Modelo,
                                Nombre_Modelo = modelo.Detalle_Modelo
                            }).Distinct();
                return query.ToList();
            }
        }

        public IList<ModeloDE> ObtenerModelos()
        {
            using (var conn = new PanasonicConexion())
            {
                var query = (from master in conn.Master_Table
                             join modelo in conn.Modelo on master.ID_Marca equals modelo.ID_Modelo
                             select new ModeloDE()
                             {
                                 ID_Modelo = modelo.ID_Modelo,
                                 Nombre_Modelo = modelo.Detalle_Modelo
                             }).Distinct();
                return query.ToList();
            }
        }
    }
}
