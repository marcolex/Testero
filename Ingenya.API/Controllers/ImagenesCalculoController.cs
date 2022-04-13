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

    [Route("Clientes")]
    public class ImagenesCalculoController : ApiController
    {
        ImagenesCalculoManagement imagenesCalculoManagement;
        ImagenesCalculo imagenesCalculo;
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
        [Route("api/TodosLosImagenesCalculo")]
        public HttpResponseMessage TodosLosImagenesCalculo()
        {
            try
            {
                imagenesCalculoManagement = new ImagenesCalculoManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<ImagenesCalculo>)imagenesCalculoManagement.RetrieveAllImagenesCalculo());
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
        [Route("api/InsertarImagenesCalculo")]
        public HttpResponseMessage InsertarImagenesCalculo([FromBody] ImagenesCalculo imagenesCalculo)
        {
            try
            {
                imagenesCalculoManagement = new ImagenesCalculoManagement();
                try
                {
                    imagenesCalculoManagement.CreateImagenesCalculo(imagenesCalculo);
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
        [Route("api/ModificarImagenesCalculo")]
        public HttpResponseMessage ModificarImagenesCalculo([FromBody] ImagenesCalculo imagenesCalculo)
        {
            try
            {
                imagenesCalculoManagement = new ImagenesCalculoManagement();
                try
                {
                    imagenesCalculoManagement.UpdateImagenesCalculo(imagenesCalculo);
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
        [Route("api/EliminarImagenesCalculo")]
        public HttpResponseMessage EliminarImagenesCalculo(string id)
        {
            try
            {
                imagenesCalculo = new ImagenesCalculo
                {
                    IdImagenesCalculo = Int32.Parse(id)
                };
                imagenesCalculoManagement = new ImagenesCalculoManagement();
                imagenesCalculoManagement.DeleteImagenesCalculo(imagenesCalculo);
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

    }
}
