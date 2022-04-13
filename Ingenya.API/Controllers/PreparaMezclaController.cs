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

    [Route("api/PreparaMezcla")]
    public class PreparaMezclaController : ApiController
    {
        PreparaMezclaManagement preparaMezclaManagement;
        PreparaMezcla preparaMezcla;
        HttpResponseMessage response;
        /// <summary>
        /// Obtener todos los clientes.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/TodosLosClientes
        ///     {        
        ///     "IdCliente": 0,
        ///     "Nombre": "Prueba Cliente",
        ///     "Site": "site.com",
        ///     "Telefono": "88888888",
        ///     "Direccion": "San Jose",
        ///     "CorreoContacto": "test@gmail.com"      
        ///     }
        /// </remarks>
        /// <response code="200">Carga de clientes, exitosa</response>  
        /// <response code="500">Hubo un error en la carga de los clientes</response>  
        [HttpGet]
        [Route("TodosLosPreparaMezcla")]
        public HttpResponseMessage TodosLosPreparaMezcla()
        {
            try
            {
                preparaMezclaManagement = new PreparaMezclaManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<PreparaMezcla>)preparaMezclaManagement.RetrieveAllPreparaMezcla());
                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }

        }

        /// <summary>
        /// Insertar un cliente nuevo.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     POST api/InsertarCliente
        ///       {
        ///        "IdCliente": 0,
        ///        "Nombre": "string",
        ///        "Site": "string",
        ///        "Telefono": "string",
        ///        "Direccion": "string",
        ///        "CorreoContacto": "string"
        /// }
        /// </remarks>
        /// <response code="201">El nuevo cliente se ingreso correctamente</response> 
        /// <response code="500">Hubo un error error al crear el nuevo cliente</response> 
        // POST api/values
        [HttpPost]
        [Route("api/InsertarPreparaMezcla")]
        public HttpResponseMessage InsertarPreparaMezcla([FromBody] PreparaMezcla preparaMezcla)
        {
            try
            {
                preparaMezclaManagement = new PreparaMezclaManagement();
                try
                {
                    preparaMezclaManagement.CreatePreparaMezcla(preparaMezcla);
                    return Request.CreateResponse(HttpStatusCode.Created);
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError);
                }

                // return response;
            }
            catch (Exception)
            {

                throw;
            }

        }


        /// <summary>
        /// Modificar un cliente.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     POST api/ModificarCliente
        ///       {
        ///        "IdCliente": 0,
        ///        "Nombre": "string",
        ///        "Site": "string",
        ///        "Telefono": "string",
        ///        "Direccion": "string",
        ///        "CorreoContacto": "string"
        /// }
        /// </remarks>
        /// <response code="200">El cliente se modifico correctamente</response> 
        /// <response code="500">Hubo un error error al modificar el cliente</response> 
        // POST api/values
        [HttpPost]
        [Route("api/ModificarPreparaMezcla")]
        public HttpResponseMessage ModificarPreparaMezcla([FromBody] PreparaMezcla preparaMezcla)
        {
            try
            {
                preparaMezclaManagement = new PreparaMezclaManagement();
                try
                {
                    preparaMezclaManagement.UpdatePreparaMezcla(preparaMezcla);
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError);
                }

                // return response;
            }
            catch (Exception)
            {

                throw;
            }

        }


        /// <summary>
        /// Eliminar un cliente.
        /// </summary>
        /// <param name="id">Id Cliente</param>
        /// <response code="200">El cliente se elimino correctamente</response>  
        /// <response code="400">No se puede eliminar este cliente por tener proyectos asociados</response>  
        /// <response code="500">Hubo un error error al eliminar el cliente</response>  
        [HttpDelete()]
        [Route("api/EliminarPreparaMezcla")]
        public HttpResponseMessage EliminarPreparaMezcla(string id)
        {
            try
            {
                preparaMezcla = new PreparaMezcla
                {
                    IdPreparaMezcla = Int32.Parse(id)
                };
                preparaMezclaManagement = new PreparaMezclaManagement();
                preparaMezclaManagement.DeletePreparaMezcla(preparaMezcla);
                return Request.CreateResponse(HttpStatusCode.OK, "El cliente se elimino correctamente");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FOREIGN KEY"))
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "No se puede eliminar este cliente por tener proyectos asociados");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError);
                }
                
            }

        }


        /// <summary>
        /// Obtener una PreparaMezcla  por Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/ObtenerPreparaMezcla
        ///     {        
        ///     "IdCliente": 0,
        ///     "Nombre": "Prueba Cliente",
        ///     "Site": "site.com",
        ///     "Telefono": "88888888",
        ///     "Direccion": "San Jose",
        ///     "CorreoContacto": "test@gmail.com"      
        ///     }
        /// </remarks>
        /// <param name="idPreparaMezcla">PreparaMezcla</param>
        /// <response code="200">Carga de PreparaMezcla, exitosa</response>  
        /// <response code="404">No se encontro la PreparaMezcla por id</response>  
        /// <response code="500">Hubo un error en la carga de la PreparaMezcla por id</response>  
        [HttpPut]
        [Route("ObtenerPreparaMezcla/{id}")]
        public HttpResponseMessage ObtenerPreparaMezcla(string idPreparaMezcla)
        {
            try
            {
                preparaMezcla = new PreparaMezcla
                {
                    IdPreparaMezcla = Int32.Parse(idPreparaMezcla)
                };
                preparaMezclaManagement = new PreparaMezclaManagement();
                preparaMezcla = preparaMezclaManagement.RetrievePreparaMezcla(preparaMezcla);
                if (preparaMezcla is null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound, preparaMezcla);
                }
                else
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, preparaMezcla);
                }

                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de PreparaMezcla por id");
            }

        }

    }
}
