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

    [Route("Ocupacion")]
    public class OcupacionController : ApiController
    {
        OcupacionManagement ocupacionManagement;
        Ocupacion ocupacion;
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
        [Route("api/TodosLasOcupaciones")]
        public HttpResponseMessage TodosLasOcupaciones()
        {
            try
            {
                ocupacionManagement = new OcupacionManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<Ocupacion>)ocupacionManagement.RetrieveAllOcupacion());
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
        [Route("api/InsertarOcupacion")]
        public HttpResponseMessage InsertarOcupacion([FromBody] Ocupacion ocupacion)
        {
            try
            {
                ocupacionManagement = new OcupacionManagement();
                try
                {
                    ocupacionManagement.CreateOcupacion(ocupacion);
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
        ///     PUT api/ModificarCliente
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
        [HttpPut]
        [Route("api/ModificarOcupacion")]
        public HttpResponseMessage ModificarOcupacion([FromBody] Ocupacion ocupacion)
        {
            try
            {
                ocupacionManagement = new OcupacionManagement();
                try
                {
                    ocupacionManagement.UpdateOcupacion(ocupacion);
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
        [Route("api/EliminarOcupacion")]
        public HttpResponseMessage EliminarOcupacion(string id)
        {
            try
            {
                ocupacion = new Ocupacion
                {
                    IdOcupacion = Int32.Parse(id)
                };
                ocupacionManagement = new OcupacionManagement();
                ocupacionManagement.DeleteOcupacion (ocupacion);
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
        /// Obtener una Ocupacion  por Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/ObtenerOcupacion
        ///     {        
        ///     "IdCliente": 0,
        ///     "Nombre": "Prueba Cliente",
        ///     "Site": "site.com",
        ///     "Telefono": "88888888",
        ///     "Direccion": "San Jose",
        ///     "CorreoContacto": "test@gmail.com"      
        ///     }
        /// </remarks>
        /// <param name="idOcupacion">Ocupacion</param>
        /// <response code="200">Carga de Ocupacion, exitosa</response>  
        /// <response code="404">No se encontro la Ocupacion por id</response>  
        /// <response code="500">Hubo un error en la carga de la Ocupacion por id</response>  
        [HttpPut]
        [Route("ObtenerOcupacion/{id}")]
        public HttpResponseMessage ObtenerOcupacion(string idOcupacion)
        {
            try
            {
                ocupacion = new Ocupacion
                {
                    IdOcupacion = Int32.Parse(idOcupacion)
                };
                ocupacionManagement = new OcupacionManagement();
                ocupacion = ocupacionManagement.RetrieveOcupacion(ocupacion);
                if (ocupacion is null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound, ocupacion);
                }
                else
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, ocupacion);
                }

                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de Ocupacion por id");
            }

        }

    }
}
