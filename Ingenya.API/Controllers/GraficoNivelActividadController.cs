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

    [Route("GraficoNivelActividad")]
    public class GraficoNivelActividadController : ApiController
    {
        GraficoNivelActividadManagement graficoNivelActividadManagement;
        GraficoNivelActividad graficoNivelActividad;
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
        [Route("api/TodosLosGraficoNivelActividad")]
        public HttpResponseMessage TodosLosGraficoNivelActividad()
        {
            try
            {
                graficoNivelActividadManagement = new GraficoNivelActividadManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<GraficoNivelActividad>)graficoNivelActividadManagement.RetrieveAllGraficoNivelActividad());
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
        [Route("api/InsertarGraficoNivelActividad")]
        public HttpResponseMessage InsertarGraficoNivelActividad([FromBody] GraficoNivelActividad graficoNivelActividad)
        {
            try
            {
                graficoNivelActividadManagement = new GraficoNivelActividadManagement();
                try
                {
                    graficoNivelActividadManagement.CreateGraficoNivelActividad(graficoNivelActividad);
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
        [Route("api/ModificarGraficoNivelActividad")]
        public HttpResponseMessage ModificarGraficoNivelActividad([FromBody] GraficoNivelActividad graficoNivelActividad)
        {
            try
            {
                graficoNivelActividadManagement = new GraficoNivelActividadManagement();
                try
                {
                    graficoNivelActividadManagement.UpdateGraficoNivelActividad(graficoNivelActividad);
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
        [Route("api/EliminarGraficoNivelActividad")]
        public HttpResponseMessage EliminarGraficoNivelActividad(string id)
        {
            try
            {
                graficoNivelActividad = new GraficoNivelActividad
                {
                    IdGraficoNivelActividad = Int32.Parse(id)
                };
                graficoNivelActividadManagement = new GraficoNivelActividadManagement();
                graficoNivelActividadManagement.DeleteGraficoNivelActividad(graficoNivelActividad);
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
        /// Obtener una GraficoNivelActividad  por Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/ObtenerGraficoNivelActividad
        ///     {        
        ///     "IdCliente": 0,
        ///     "Nombre": "Prueba Cliente",
        ///     "Site": "site.com",
        ///     "Telefono": "88888888",
        ///     "Direccion": "San Jose",
        ///     "CorreoContacto": "test@gmail.com"      
        ///     }
        /// </remarks>
        /// <param name="idGraficoNivelActividad">GraficoNivelActividad</param>
        /// <response code="200">Carga de GraficoNivelActividad, exitosa</response>  
        /// <response code="404">No se encontro la GraficoNivelActividad por id</response>  
        /// <response code="500">Hubo un error en la carga de la GraficoNivelActividad por id</response>  
        [HttpPut]
        [Route("ObtenerGraficoNivelActividad/{id}")]
        public HttpResponseMessage ObtenerGraficoNivelActividad(string idGraficoNivelActividad)
        {
            try
            {
                graficoNivelActividad = new GraficoNivelActividad
                {
                    IdGraficoNivelActividad = Int32.Parse(idGraficoNivelActividad)
                };
                graficoNivelActividadManagement = new GraficoNivelActividadManagement();
                graficoNivelActividad = graficoNivelActividadManagement.RetrieveGraficoNivelActividad(graficoNivelActividad);
                if (graficoNivelActividad is null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound, graficoNivelActividad);
                }
                else
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, graficoNivelActividad);
                }

                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de GraficoNivelActividad por id");
            }

        }

    }
}
