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

    [Route("GraNivActCalorLatente")]
    public class GraNivActCalorLatenteController : ApiController
    {
        GraNivActCalorLatenteManagement graNivActCalorLatenteManagement;
        GraNivActCalorLatente graNivActCalorLatente;
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
        [Route("api/TodosLosGraNivActCalorLatente")]
        public HttpResponseMessage TodosLosGraNivActCalorLatente()
        {
            try
            {
                graNivActCalorLatenteManagement = new GraNivActCalorLatenteManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<GraNivActCalorLatente>)graNivActCalorLatenteManagement.RetrieveAllGraNivActCalorLatente());
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
        [Route("api/InsertarGraNivActCalorLatente")]
        public HttpResponseMessage InsertarGraNivActCalorLatente([FromBody] GraNivActCalorLatente graNivActCalorLatente)
        {
            try
            {
                graNivActCalorLatenteManagement = new GraNivActCalorLatenteManagement();
                try
                {
                    graNivActCalorLatenteManagement.CreateGraNivActCalorLatente(graNivActCalorLatente);
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
        [Route("api/ModificarGraNivActCalorLatente")]
        public HttpResponseMessage ModificarGraNivActCalorLatente([FromBody] GraNivActCalorLatente graNivActCalorLatente)
        {
            try
            {
                graNivActCalorLatenteManagement = new GraNivActCalorLatenteManagement();
                try
                {
                    graNivActCalorLatenteManagement.UpdateGraNivActCalorLatente(graNivActCalorLatente);
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
        [Route("api/EliminarGraNivActCalorLatente")]
        public HttpResponseMessage EliminarGraNivActCalorLatente(string id)
        {
            try
            {
                graNivActCalorLatente = new GraNivActCalorLatente
                {
                    IdGravNivActCalorLatente = Int32.Parse(id)
                };
                graNivActCalorLatenteManagement = new GraNivActCalorLatenteManagement();
                graNivActCalorLatenteManagement.DeleteGraNivActCalorLatente(graNivActCalorLatente);
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
        /// Obtener una GraNivActCalorLatente  por Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/ObtenerGraNivActCalorLatente
        ///     {        
        ///     "IdCliente": 0,
        ///     "Nombre": "Prueba Cliente",
        ///     "Site": "site.com",
        ///     "Telefono": "88888888",
        ///     "Direccion": "San Jose",
        ///     "CorreoContacto": "test@gmail.com"      
        ///     }
        /// </remarks>
        /// <param name="idGraNivActCalorLatente">GraNivActCalorLatente</param>
        /// <response code="200">Carga de GraNivActCalorLatente, exitosa</response>  
        /// <response code="404">No se encontro la GraNivActCalorLatente por id</response>  
        /// <response code="500">Hubo un error en la carga de la GraNivActCalorLatente por id</response>  
        [HttpPut]
        [Route("ObtenerGraNivActCalorLatente/{id}")]
        public HttpResponseMessage ObtenerGraNivActCalorLatente(string idGraNivActCalorLatente)
        {
            try
            {
                graNivActCalorLatente = new GraNivActCalorLatente
                {
                    IdGravNivActCalorLatente = Int32.Parse(idGraNivActCalorLatente)
                };
                graNivActCalorLatenteManagement = new GraNivActCalorLatenteManagement();
                graNivActCalorLatente = graNivActCalorLatenteManagement.RetrieveGraNivActCalorLatente(graNivActCalorLatente);
                if (graNivActCalorLatente is null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound, graNivActCalorLatente);
                }
                else
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, graNivActCalorLatente);
                }

                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de GraNivActCalorLatente por id");
            }

        }

    }
}
