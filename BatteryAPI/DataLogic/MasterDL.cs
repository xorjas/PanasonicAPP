using DataAccess;
using DataEntities;
using DataEntities.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic
{
    public class MasterDL
    {
        public HttpStatusCode IngresarBateriaVehiculo(MasterDE master) {

            try
            {
                MasterDA datalogic = new MasterDA();
                datalogic.IngresarBateriaVehiculo(master);
                return HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                return HttpStatusCode.InternalServerError;
            }
            
        }

        public HttpStatusCode ActualizarBateriaVehiculo(MasterUpdateDE master)
        {

            try
            {
                MasterDA datalogic = new MasterDA();
                datalogic.ActualizarBateriaVehiculo(master);
                return HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                return HttpStatusCode.InternalServerError;
            }
        }

        public HttpStatusCode EliminarBateriaVehiculo(MasterDE master)
        {

            try
            {
                MasterDA datalogic = new MasterDA();
                datalogic.EliminarBateriaVehiculo(master);
                return HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                return HttpStatusCode.InternalServerError;
            }
        }
    }
}
