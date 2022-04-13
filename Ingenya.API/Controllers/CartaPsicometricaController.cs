using Ingenya.ApiCore;
using Ingenya.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Runtime.Serialization;

namespace WebApp.Controllers
{

    //[Route("CartaPsicometrica")]
    [RoutePrefix("api/CartaPsicometrica")]
    public class CartaPsicometricaController : ApiController
    {
        CartaPsicometricaManagement cartaPsicometricaManagement;
        CartaPsicometrica cartaPsicometrica;
        HttpResponseMessage response;
        /// <summary>
        /// Obtener todas las Cartas Psicometrica.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/CartaPsicometrica
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
        [Route("TodasLasCartasPsicometricas")]
        public HttpResponseMessage TodasLasCartasPsicometricas()
        {
            try
            {
                cartaPsicometricaManagement = new CartaPsicometricaManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<CartaPsicometrica>)cartaPsicometricaManagement.RetrieveAllCartaPsicometrica());
                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }

        }

        /// <summary>
        /// Insertar un Carta Psicometrica nueva.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     
        ///     POST api/CartaPsicometrica
        ///       {
        ///        "IdCliente": 0,
        ///        "Nombre": "string",
        ///        "Site": "string",
        ///        "Telefono": "string",
        ///        "Direccion": "string",
        ///        "CorreoContacto": "string"
        ///       }
        /// </remarks>
        /// <response code="201">El nuevo cliente se ingreso correctamente</response> 
        /// <response code="500">Hubo un error error al crear el nuevo cliente</response> 
        // POST api/values
        [HttpPost]
        [Route("InsertarCartaPsicometrica")]
        public HttpResponseMessage InsertarCartaPsicometrica([FromBody] CartaPsicometrica cartaPsicometrica)
        {
            try
            {
                cartaPsicometricaManagement = new CartaPsicometricaManagement();
                try
                {
                    cartaPsicometricaManagement.CreateCartaPsicometrica(cartaPsicometrica);
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
        /// Modificar una Carta Psicometrica.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT api/ModificarCartaPsicometrica
        ///       {
        ///        "IdCliente": 0,
        ///        "Nombre": "string",
        ///        "Site": "string",
        ///        "Telefono": "string",
        ///        "Direccion": "string",
        ///        "CorreoContacto": "string"
        ///       }
        /// </remarks>
        /// <response code="200">El cliente se modifico correctamente</response> 
        /// <response code="500">Hubo un error error al modificar el cliente</response> 
        // POST api/values
        [HttpPut]
        [Route("ModificarCartaPsicometrica")]
        public HttpResponseMessage ModificarCartaPsicometrica([FromBody] CartaPsicometrica cartaPsicometrica)
        {
            try
            {
                cartaPsicometricaManagement = new CartaPsicometricaManagement();
                try
                {
                    cartaPsicometricaManagement.UpdateCartaPsicometrica(cartaPsicometrica);
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
        /// <param name="idCartaPsicometrica">CartaPsicometrica</param>
        /// <response code="200">La CartaPsicometrica se elimino correctamente</response>  
        /// <response code="400">No se puede eliminar esta CartaPsicometrica por tener proyectos asociados</response>  
        /// <response code="500">Hubo un error error al eliminar la CartaPsicometrica</response>  
        [HttpDelete()]
        [Route("EliminarCartaPsicometrica/{id}")]
        public HttpResponseMessage EliminarCartaPsicometrica(string idCartaPsicometrica)
        {
            try
            {
                cartaPsicometrica = new CartaPsicometrica
                {
                    IdCartaPsicometrica = Int32.Parse(idCartaPsicometrica)
                };
                cartaPsicometricaManagement = new CartaPsicometricaManagement();
                cartaPsicometricaManagement.DeleteCartaPsicometrica(cartaPsicometrica);
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
        /// Obtener una CartaPsicometrica por Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/ObtenerCartaPsicometrica
        ///     {        
        ///     "IdCliente": 0,
        ///     "Nombre": "Prueba Cliente",
        ///     "Site": "site.com",
        ///     "Telefono": "88888888",
        ///     "Direccion": "San Jose",
        ///     "CorreoContacto": "test@gmail.com"      
        ///     }
        /// </remarks>
        /// <param name="idCartaPsicometrica">CartaPsicometrica</param>
        /// <response code="200">Carga de CartaPsicometrica, exitosa</response>  
        /// <response code="404">No se encontro la CartaPsicometrica por id</response>  
        /// <response code="500">Hubo un error en la carga de la CartaPsicometrica por id</response>  
        [HttpPut]
        [Route("ObtenerCartaPsicometrica/{id}")]
        public HttpResponseMessage ObtenerCartaPsicometrica(string idCartaPsicometrica)
        {
            try
            {
                cartaPsicometrica = new CartaPsicometrica
                {
                    IdCartaPsicometrica = Int32.Parse(idCartaPsicometrica)
                };
                cartaPsicometricaManagement = new CartaPsicometricaManagement();
                cartaPsicometrica= cartaPsicometricaManagement.RetrieveCartaPsicometrica(cartaPsicometrica);
                if (cartaPsicometrica is null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound, cartaPsicometrica);
                }
                else
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, cartaPsicometrica);
                }

                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de cartaPsicometrica por id");
            }

        }

    }
}
