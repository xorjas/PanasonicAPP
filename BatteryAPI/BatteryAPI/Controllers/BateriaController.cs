using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataLogic;
using DataEntities;
using System.Threading.Tasks;

namespace BatteryAPI.Controllers
{
    public class BateriaController : ApiController
    {
        // GET: api/Bateria
        [HttpGet]
        public BateriaDE ObtenerBateria([FromUri] BusquedaDE model)
        {

            try
            {
                BateriaDL dataLogic = new BateriaDL();
                var bateria = dataLogic.ObtenerBateria(model);
                return bateria;
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message));
            }
        }

        [HttpGet]
        public IList<BateriaDE> ObtenerBaterias()
        {

            try
            {
                BateriaDL dataLogic = new BateriaDL();
                var bateria = dataLogic.ObtenerBaterias();
                return bateria;
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message));
            }
        }

        [HttpGet]
        public IList<MasterDE> ObtenerMaster()
        {

            try
            {
                BateriaDL dataLogic = new BateriaDL();
                var master = dataLogic.ObtenerMaster();
                return master;
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message));
            }
        }

        [HttpGet]
        public IEnumerable<MarcaDE> ObtenerMarcas() {

            try
            {
                MarcaDL dataLogic = new MarcaDL();
                return dataLogic.ObtenerMarcas();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message));
            }
        }

        [HttpGet]
        public IEnumerable<ModeloDE> ObtenerModelo([FromUri] int idMarca) {
            try
            {
                ModeloDL dataLogic = new ModeloDL();
                var result = dataLogic.ObtenerModelos(idMarca);
                return result;
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message));
            }
        }

        [HttpGet]
        public IEnumerable<ModeloDE> ObtenerModelos()
        {
            try
            {
                ModeloDL dataLogic = new ModeloDL();
                var result = dataLogic.ObtenerModelos();
                return result;
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message));
            }
        }

        [HttpGet]
        public IEnumerable<CilindradaDE> ObtenerCilindrada()
        {
            try
            {
                CilindradaDL dataLogic = new CilindradaDL();
                return dataLogic.ObtenerCilindrada();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message));
            }
        }

        [HttpGet]
        public IEnumerable<AnnoDE> ObtenerAnnos()
        {
            try
            {
                AnnoDL dataLogic = new AnnoDL();
                return dataLogic.ObtenerAnnnos();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message));
            }
        }
    }
}
