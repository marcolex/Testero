using Ingenya.ApiCore;
using Ingenya.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApp.Controllers
{

    //[Route("FactoresDeHumedad")]
    [RoutePrefix("api/FactoresDeHumedad")]
    public class FactoresDeHumedadController : ApiController
    {
        FactoresDeHumedadManagement factoresDeHumedadManagement;
        FactoresDeHumedad factoresDeHumedad;
        HttpResponseMessage response;
        /// <summary>
        /// Obtener todos los factores de humedad.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/TodosLosFactoresDeHumedad
        ///     {        
        ///     "IdCliente": 0,
        ///     "Nombre": "Prueba Cliente",
        ///     "Site": "site.com",
        ///     "Telefono": "88888888",
        ///     "Direccion": "San Jose",
        ///     "CorreoContacto": "test@gmail.com"      
        ///     }
        /// </remarks>
        /// <response code="200">Carga de factores de humedad, exitosa</response>  
        /// <response code="500">Hubo un error en la carga de los factores de humedad</response>  
        [HttpGet]
        [Route("TodosLosFactoresDeHumedad")]
        public HttpResponseMessage TodosLosFactoresDeHumedad()
        {
            try
            {
                factoresDeHumedadManagement = new FactoresDeHumedadManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<FactoresDeHumedad>)factoresDeHumedadManagement.RetrieveAllFactoresDeHumedad());
                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de los factores de humedad");
            }

        }

        /// <summary>
        /// Insertar un factor de humedad.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/InsertarFactoresDeHumedad
        ///       {
        ///        "IdCliente": 0,
        ///        "Nombre": "string",
        ///        "Site": "string",
        ///        "Telefono": "string",
        ///        "Direccion": "string",
        ///        "CorreoContacto": "string"
        ///       }
        /// </remarks>
        /// <response code="201">El nuevo factor de humedad se ingreso correctamente</response> 
        /// <response code="500">Hubo un error error al crear el nuevo factor de humedad</response> 
        // POST api/values
        [HttpPost]
        [Route("InsertarFactoresDeHumedad")]
        public HttpResponseMessage InsertarFactoresDeHumedad([FromBody] FactoresDeHumedad factoresDeHumedad)
        {
            try
            {
                factoresDeHumedadManagement = new FactoresDeHumedadManagement();
                try
                {
                    factoresDeHumedadManagement.CreateFactoresDeHumedad(factoresDeHumedad);
                    return Request.CreateResponse(HttpStatusCode.Created, "El nuevo factor de humedad se ingreso correctamente");
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al crear el nuevo factor de humedad");
                }

                // return response;
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al crear el nuevo factor de humedad");
            }

        }


        /// <summary>
        /// Modificar un factor de humedad.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     POST api/ModificarFactoresDeHumedad
        ///       {
        ///        "IdCliente": 0,
        ///        "Nombre": "string",
        ///        "Site": "string",
        ///        "Telefono": "string",
        ///        "Direccion": "string",
        ///        "CorreoContacto": "string"
        /// }
        /// </remarks>
        /// <response code="200">El factor de humedad se modifico correctamente</response> 
        /// <response code="500">Hubo un error error al modificar el factor de humedad</response> 
        // POST api/values
        [HttpPut]
        [Route("ModificarFactoresDeHumedad")]
        public HttpResponseMessage ModificarFactoresDeHumedad([FromBody] FactoresDeHumedad factoresDeHumedad)
        {
            try
            {
                factoresDeHumedadManagement = new FactoresDeHumedadManagement();
                try
                {
                    factoresDeHumedadManagement.UpdateFactoresDeHumedad(factoresDeHumedad);
                    return Request.CreateResponse(HttpStatusCode.OK, "El factor de humedad se modifico correctamente");
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al modificar el factor de humedad");
                }

                // return response;
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al modificar el factor de humedad");
            }

        }


        /// <summary>
        /// Eliminar un factor humedad.
        /// </summary>
        /// <param name="id">Id Factor Humedad</param>
        /// <response code="200">El factor humedad se elimino correctamente</response>  
        /// <response code="400">No se puede eliminar este factor humedad por tener objetos asociados</response>  
        /// <response code="500">Hubo un error error al eliminar el factor humedad</response>  
        [HttpDelete()]
        [Route("EliminarFactoresDeHumedad")]
        public HttpResponseMessage EliminarFactoresDeHumedad(string id)
        {
            try
            {
                factoresDeHumedad = new FactoresDeHumedad
                {
                    IdFactoresDeHumedad = Int32.Parse(id)
                };
                factoresDeHumedadManagement = new FactoresDeHumedadManagement();
                factoresDeHumedadManagement.DeleteFactoresDeHumedad(factoresDeHumedad);
                return Request.CreateResponse(HttpStatusCode.OK, "El factor humedad se elimino correctamente");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FOREIGN KEY"))
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "No se puede eliminar este factor humedad por tener objetos asociados");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al eliminar el factor humedad");
                }
                
            }

        }

        /// <summary>
        /// Obtener una FactoresDeHumedad  por Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/ObtenerFactoresDeHumedad
        ///     {        
        ///     "IdCliente": 0,
        ///     "Nombre": "Prueba Cliente",
        ///     "Site": "site.com",
        ///     "Telefono": "88888888",
        ///     "Direccion": "San Jose",
        ///     "CorreoContacto": "test@gmail.com"      
        ///     }
        /// </remarks>
        /// <param name="idFactoresDeHumedad">FactoresDeHumedad</param>
        /// <response code="200">Carga de FactoresDeHumedad, exitosa</response>  
        /// <response code="404">No se encontro la FactoresDeHumedad por id</response>  
        /// <response code="500">Hubo un error en la carga de la FactoresDeHumedad por id</response>  
        [HttpPut]
        [Route("ObtenerFactoresDeHumedad/{id}")]
        public HttpResponseMessage ObtenerFactoresDeHumedad(string idFactoresDeHumedad)
        {
            try
            {
                factoresDeHumedad = new FactoresDeHumedad
                {
                    IdFactoresDeHumedad = Int32.Parse(idFactoresDeHumedad)
                };
                factoresDeHumedadManagement = new FactoresDeHumedadManagement();
                factoresDeHumedad = factoresDeHumedadManagement.RetrieveFactoresDeHumedad(factoresDeHumedad);
                if (factoresDeHumedad is null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound, factoresDeHumedad);
                }
                else
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, factoresDeHumedad);
                }

                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de FactoresDeHumedad por id");
            }

        }


    }
}
