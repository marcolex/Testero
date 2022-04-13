using Ingenya.ApiCore;
using Ingenya.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{

    [Route("Bitacora")]
    [Serializable]
    [DataContract]
    public class BitacoraController : ControllerBase
    {
        BitacoraManagement bitacoraManagement;
        Bitacora bitacora;
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
        [Route("api/TodasLasBitacoras")]
        public HttpResponseMessage TodasLasBitacoras()
        {
            try
            {
                bitacoraManagement = new BitacoraManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<Bitacora>)bitacoraManagement.RetrieveAllBitacora());
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
        [Route("api/InsertarBitacora")]
        public HttpResponseMessage InsertarBitacora([FromBody] Bitacora bitacora)
        {
            try
            {
                bitacoraManagement = new BitacoraManagement();
                try
                {
                    bitacoraManagement.CreateBitacora(bitacora);
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
        [Route("api/ModificarBitacora")]
        public HttpResponseMessage ModificarBitacora([FromBody] Bitacora bitacora)
        {
            try
            {
                bitacoraManagement = new BitacoraManagement();
                try
                {
                    bitacoraManagement.UpdateBitacora(bitacora);
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
        [Route("api/EliminarBitacora")]
        public HttpResponseMessage EliminarBitacora(string id)
        {
            try
            {
                bitacora = new Bitacora
                {
                    IdBitacora = Int32.Parse(id)
                };
                bitacoraManagement = new BitacoraManagement();
                bitacoraManagement.DeleteBitacora(bitacora);
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
        /// Obtener todos los clientes.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/ObtenerBitacora
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
        [Route("api/ObtenerBitacora")]
        public HttpResponseMessage ObtenerBitacora([FromBody] Bitacora bitacora)
        {
            try
            {
                bitacoraManagement = new BitacoraManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<Bitacora>)bitacoraManagement.RetrieveAllBitacora());
                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }

        }

    }
}
