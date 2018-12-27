using DataEntities.UIModels;
using DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BatteryAPI.Controllers
{
    public class MasterController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage IngresarBateriaVehiculo([FromBody] DataEntities.MasterDE model) {

            MasterDL dataLogic = new MasterDL();

            HttpResponseMessage message = new HttpResponseMessage();
            message.StatusCode = dataLogic.IngresarBateriaVehiculo(model);

            return message;
        }

        [HttpPut]
        public HttpResponseMessage ActualizarBateriaVehiculo([FromBody] MasterUpdateDE model)
        {

            MasterDL dataLogic = new MasterDL();

            HttpResponseMessage message = new HttpResponseMessage();
            message.StatusCode = dataLogic.ActualizarBateriaVehiculo(model);

            return message;
        }

        [HttpDelete]
        public HttpResponseMessage EliminarBateriaVehiculo([FromBody] DataEntities.MasterDE model)
        {

            MasterDL dataLogic = new MasterDL();

            HttpResponseMessage message = new HttpResponseMessage();
            message.StatusCode = dataLogic.EliminarBateriaVehiculo(model);

            return message;
        }
    }
}
