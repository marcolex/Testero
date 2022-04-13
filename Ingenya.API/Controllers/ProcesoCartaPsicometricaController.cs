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

    [Route("ProcesoCartaPsicometrica")]
    public class ProcesoCartaPsicometricaController : ApiController
    {
        ProcesoCartaPsicometricaManagement procesoCartaPsicometricaManagement;
        ProcesoCartaPsicometrica procesoCartaPsicometrica;
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
        [Route("api/TodosLosProcesoCartaPsicometricas")]
        public HttpResponseMessage TodosLosProcesoCartaPsicometricas()
        {
            try
            {
                procesoCartaPsicometricaManagement = new ProcesoCartaPsicometricaManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<ProcesoCartaPsicometrica>)procesoCartaPsicometricaManagement.RetrieveAllProcesoCartaPsicometrica());
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
        [Route("api/InsertarProcesoCartaPsicometrica")]
        public HttpResponseMessage InsertarProcesoCartaPsicometrica([FromBody] ProcesoCartaPsicometrica procesoCartaPsicometrica)
        {
            try
            {
                procesoCartaPsicometricaManagement = new ProcesoCartaPsicometricaManagement();
                try
                {
                    procesoCartaPsicometricaManagement.CreateProcesoCartaPsicometrica(procesoCartaPsicometrica);
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
        [Route("api/ModificarProcesoCartaPsicometrica")]
        public HttpResponseMessage ModificarProcesoCartaPsicometrica([FromBody] ProcesoCartaPsicometrica procesoCartaPsicometrica)
        {
            try
            {
                procesoCartaPsicometricaManagement = new ProcesoCartaPsicometricaManagement();
                try
                {
                    procesoCartaPsicometricaManagement.UpdateProcesoCartaPsicometrica(procesoCartaPsicometrica);
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
        [Route("api/EliminarProcesoCartaPsicometrica")]
        public HttpResponseMessage EliminarProcesoCartaPsicometrica(string id)
        {
            try
            {
                procesoCartaPsicometrica = new ProcesoCartaPsicometrica
                {
                    IdProcesoCartaPsicometrica = Int32.Parse(id)
                };
                procesoCartaPsicometricaManagement = new ProcesoCartaPsicometricaManagement();
                procesoCartaPsicometricaManagement.DeleteProcesoCartaPsicometrica(procesoCartaPsicometrica);
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
        /// Obtener una ProcesoCartaPsicometrica  por Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/ObtenerProcesoCartaPsicometrica
        ///     {        
        ///     "IdCliente": 0,
        ///     "Nombre": "Prueba Cliente",
        ///     "Site": "site.com",
        ///     "Telefono": "88888888",
        ///     "Direccion": "San Jose",
        ///     "CorreoContacto": "test@gmail.com"      
        ///     }
        /// </remarks>
        /// <param name="idProcesoCartaPsicometrica">ProcesoCartaPsicometrica</param>
        /// <response code="200">Carga de ProcesoCartaPsicometrica, exitosa</response>  
        /// <response code="404">No se encontro la ProcesoCartaPsicometrica por id</response>  
        /// <response code="500">Hubo un error en la carga de la ProcesoCartaPsicometrica por id</response>  
        [HttpPut]
        [Route("ObtenerProcesoCartaPsicometrica/{id}")]
        public HttpResponseMessage ObtenerProcesoCartaPsicometrica(string idProcesoCartaPsicometrica)
        {
            try
            {
                procesoCartaPsicometrica = new ProcesoCartaPsicometrica
                {
                    IdProcesoCartaPsicometrica = Int32.Parse(idProcesoCartaPsicometrica)
                };
                procesoCartaPsicometricaManagement = new ProcesoCartaPsicometricaManagement();
                procesoCartaPsicometrica = procesoCartaPsicometricaManagement.RetrieveProcesoCartaPsicometrica(procesoCartaPsicometrica);
                if (procesoCartaPsicometrica is null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound, procesoCartaPsicometrica);
                }
                else
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, procesoCartaPsicometrica);
                }

                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de ProcesoCartaPsicometrica por id");
            }

        }

    }
}
