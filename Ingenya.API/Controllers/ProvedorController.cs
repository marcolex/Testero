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
    /// <summary>
    /// Proyecto CRUD
    /// </summary>
    [Route("Provedor")]
    public class ProvedorController : ApiController
    {
        ProvedorManagement provedorManagement;
        Provedor provedor;
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
        [Route("api/TodosLosProvedores")]
        public HttpResponseMessage TodosLosProvedores()
        {
            try
            {
                provedorManagement = new ProvedorManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<Provedor>)provedorManagement.RetrieveAllProvedor());
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
        [Route("api/InsertarProvedor")]
        public HttpResponseMessage InsertarProvedor([FromBody] Provedor provedor)
        {
            try
            {
                provedorManagement = new ProvedorManagement();
                try
                {
                    provedorManagement.CreateProvedor(provedor);
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
        [Route("api/ModificarProvedor")]
        public HttpResponseMessage ModificarProvedor([FromBody] Provedor provedor)
        {
            try
            {
                provedorManagement = new ProvedorManagement();
                try
                {
                    provedorManagement.UpdateProvedor(provedor);
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
        [Route("api/EliminarProvedor/{id}")]
        public HttpResponseMessage EliminarProvedor(string id)
        {
            try
            {
                provedor = new Provedor
                {
                    IdProvedor = Int32.Parse(id)
                };
                provedorManagement = new ProvedorManagement();
                provedorManagement.DeleteProvedor(provedor);
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
        /// Obtener una Provedor  por Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/ObtenerProvedor
        ///     {        
        ///     "IdCliente": 0,
        ///     "Nombre": "Prueba Cliente",
        ///     "Site": "site.com",
        ///     "Telefono": "88888888",
        ///     "Direccion": "San Jose",
        ///     "CorreoContacto": "test@gmail.com"      
        ///     }
        /// </remarks>
        /// <param name="idProvedor">Provedor</param>
        /// <response code="200">Carga de Provedor, exitosa</response>  
        /// <response code="404">No se encontro la Provedor por id</response>  
        /// <response code="500">Hubo un error en la carga de la Provedor por id</response>  
        [HttpPut]
        [Route("ObtenerProvedor/{id}")]
        public HttpResponseMessage ObtenerProvedor(string idProvedor)
        {
            try
            {
                provedor = new Provedor
                {
                    IdProvedor = Int32.Parse(idProvedor)
                };
                provedorManagement = new ProvedorManagement();
                provedor = provedorManagement.RetrieveProvedor(provedor);
                if (provedor is null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound, provedor);
                }
                else
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, provedor);
                }

                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de Provedor por id");
            }

        }

    }
}
