using DataEntities;
using DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BateriaDA
    {
        public BateriaDE ObtenerBateria(BusquedaDE model)
        {

            using (var conn = new PanasonicConexion())
            {
                var query = from master in conn.Master_Table
                            join bateria in conn.Bateria on master.ID_Bateria equals bateria.ID_Bateria
                            where
                            (master.ID_Anno == model.ID_Anno) &&
                            (master.ID_Cilindrada == model.ID_Cilindrada) &&
                            (master.ID_Inyeccion == model.ID_Inyeccion) &&
                            (master.ID_Marca == model.ID_Marca) &&
                            (master.ID_Modelo == model.ID_Modelo)
                            //join modelo in conn.Modelo on master.ID_Modelo equals model.ID_Modelo
                            //join anno in conn.Anno on master.ID_Anno equals model.ID_Anno
                            //join marca in conn.Marca on master.ID_Marca equals model.ID_Marca
                            //join inyeccion in conn.Inyeccion on master.ID_Inyeccion equals model.ID_Inyeccion
                            //join cilindrada in conn.Cilindrada on master.ID_Cilindrada equals model.ID_Cilindrada
                            select new BateriaDE()
                            {
                                ID_Bateria = bateria.ID_Bateria,
                                Detalles_Bateria = bateria.Detalle_Bateria,
                                Largo_Bateria = bateria.Largo,
                                Ancho_Bateria = bateria.Ancho,
                                Alto_Bateria = bateria.Alto,
                                Peso_Bateria = bateria.Peso
                            };

                return query.FirstOrDefault();

            }

        }

        public IList<BateriaDE> ObtenerBaterias()
        {

            using (var conn = new PanasonicConexion())
            {
                var query = from master in conn.Master_Table
                            join bateria in conn.Bateria on master.ID_Bateria equals bateria.ID_Bateria
                            //join modelo in conn.Modelo on master.ID_Modelo equals model.ID_Modelo
                            //join anno in conn.Anno on master.ID_Anno equals model.ID_Anno
                            //join marca in conn.Marca on master.ID_Marca equals model.ID_Marca
                            //join inyeccion in conn.Inyeccion on master.ID_Inyeccion equals model.ID_Inyeccion
                            //join cilindrada in conn.Cilindrada on master.ID_Cilindrada equals model.ID_Cilindrada
                            select new BateriaDE()
                            {
                                ID_Bateria = bateria.ID_Bateria,
                                Detalles_Bateria = bateria.Detalle_Bateria,
                                Largo_Bateria = bateria.Largo,
                                Ancho_Bateria = bateria.Ancho,
                                Alto_Bateria = bateria.Alto,
                                Peso_Bateria = bateria.Peso,
                                CCA_Bateria = bateria.CCA
                            };

                return query.ToList();

            }

        }

        public IList<MasterDE> ObtenerMaster() {
            using (var conn = new PanasonicConexion())
            {
                var query = from master in conn.Master_Table
                            select new MasterDE()
                            {
                                Master_IDAnno = master.ID_Anno,
                                Master_IDBateria = master.ID_Bateria,
                                Master_IDCilindrada = master.ID_Cilindrada,
                                Master_IDInyeccion = master.ID_Inyeccion,
                                Master_IDMarca = master.ID_Marca,
                                Master_IDModelo = master.ID_Modelo
                            };

                return query.ToList();

            }
        }

    }
}
