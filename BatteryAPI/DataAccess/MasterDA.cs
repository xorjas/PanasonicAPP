using DataEntities;
using DataEntities.UIModels;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MasterDA
    {
        public void IngresarBateriaVehiculo(MasterDE master)
        {

            using (var conn = new PanasonicConexion())
            {

                Master_Table masterAdd = new Master_Table()
                {
                    ID_Bateria = master.Master_IDBateria,
                    ID_Anno = master.Master_IDAnno,
                    ID_Inyeccion = master.Master_IDInyeccion,
                    ID_Cilindrada = master.Master_IDCilindrada,
                    ID_Marca = master.Master_IDMarca,
                    ID_Modelo = master.Master_IDModelo
                };

                conn.Master_Table.Add(masterAdd);

                conn.SaveChanges();
            }
        }

        public void ActualizarBateriaVehiculo(MasterUpdateDE masterNew)
        {

            var split = masterNew.Master_OldIDs.Split(',');

            using (var conn = new PanasonicConexion())
            {
                var query = conn.Master_Table.SingleOrDefault(
                    x => x.ID_Bateria == Convert.ToInt32(split[0]) &&
                    x.ID_Marca == Convert.ToInt32(split[0]) &&
                    x.ID_Modelo == Convert.ToInt32(split[0]) &&
                    x.ID_Anno == Convert.ToInt32(split[0]) &&
                    x.ID_Cilindrada == Convert.ToInt32(split[0]) &&
                    x.ID_Inyeccion == Convert.ToInt32(split[0])
                    );

                query.ID_Bateria = masterNew.Master_IDBateria;
                query.ID_Marca = masterNew.Master_IDMarca;
                query.ID_Modelo = masterNew.Master_IDModelo;
                query.ID_Anno = masterNew.Master_IDAnno;
                query.ID_Cilindrada = masterNew.Master_IDCilindrada;
                query.ID_Inyeccion = masterNew.Master_IDInyeccion;
                conn.SaveChanges();

            }
        }

        public void EliminarBateriaVehiculo(MasterDE master)
        {
            using (var conn = new PanasonicConexion())
            {
                var query = conn.Master_Table.SingleOrDefault(
                    x => x.ID_Bateria == master.Master_IDBateria &&
                    x.ID_Marca == master.Master_IDMarca &&
                    x.ID_Modelo == master.Master_IDModelo &&
                    x.ID_Anno == master.Master_IDAnno &&
                    x.ID_Cilindrada == master.Master_IDCilindrada &&
                    x.ID_Inyeccion == master.Master_IDInyeccion
                    );
                conn.Master_Table.Remove(query);
                conn.SaveChanges();
            }
        }
    }
}
