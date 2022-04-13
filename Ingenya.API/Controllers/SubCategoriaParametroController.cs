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

    [Route("SubCategoriaParametro")]
    public class SubCategoriaParametroController : ApiController
    {
        SubCategoriaParametroManagement subCategoriaParametroManagement;
        SubCategoriaParametro subCategoriaParametro;
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
        [Route("api/TodosLosSubCategoriaParametros")]
        public HttpResponseMessage TodosLosSubCategoriaParametros()
        {
            try
            {
                subCategoriaParametroManagement = new SubCategoriaParametroManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<SubCategoriaParametro>)subCategoriaParametroManagement.RetrieveAllSubCategoriaParametro());
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
        [Route("api/InsertarSubCategoriaParametro")]
        public HttpResponseMessage InsertarSubCategoriaParametro([FromBody] SubCategoriaParametro SubCategoriaParametro)
        {
            try
            {
                subCategoriaParametroManagement = new SubCategoriaParametroManagement();
                try
                {
                    subCategoriaParametroManagement.CreateSubCategoriaParametro(subCategoriaParametro);
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
        [Route("api/ModificarSubCategoriaParametro")]
        public HttpResponseMessage ModificarSubCategoriaParametro([FromBody] SubCategoriaParametro subCategoriaParametro)
        {
            try
            {
                subCategoriaParametroManagement = new SubCategoriaParametroManagement();
                try
                {
                    subCategoriaParametroManagement.UpdateSubCategoriaParametro(subCategoriaParametro);
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
        [Route("api/EliminarSubCategoriaParametro")]
        public HttpResponseMessage EliminarSubCategoriaParametro(string id)
        {
            try
            {
                subCategoriaParametro = new SubCategoriaParametro
                {
                    IdSubCategoriaParametro = Int32.Parse(id)
                };
                subCategoriaParametroManagement = new SubCategoriaParametroManagement();
                subCategoriaParametroManagement.DeleteSubCategoriaParametro(subCategoriaParametro);
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
