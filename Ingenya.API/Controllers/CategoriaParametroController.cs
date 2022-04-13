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

    //[Route("CategoriaParametro")]
    [RoutePrefix("api/CategoriaParametro")]
    public class CategoriaParametroController : ApiController
    {
        CategoriaParametroManagement categoriaParametroManagement;
        CategoriaParametro categoriaParametro;
        HttpResponseMessage response;
        /// <summary>
        /// Obtener Todas Las Categorias Parametro.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/TodosLasCategoriasParametro
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
        [Route("TodasLasCategoriasParametro")]
        public HttpResponseMessage TodasLasCategoriasParametro()
        {
            try
            {
                categoriaParametroManagement = new CategoriaParametroManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<CategoriaParametro>)categoriaParametroManagement.RetrieveAllCategoriaParametro());
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
        [Route("InsertarCategoriaParametro")]
        public HttpResponseMessage InsertarCategoriaParametro([FromBody] CategoriaParametro categoriaParametro)
        {
            try
            {
                categoriaParametroManagement = new CategoriaParametroManagement();
                try
                {
                    categoriaParametroManagement.CreateCategoriaParametro(categoriaParametro);
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
        [Route("ModificarCategoriaParametro")]
        public HttpResponseMessage ModificarCategoriaParametro([FromBody] CategoriaParametro categoriaParametro)
        {
            try
            {
                categoriaParametroManagement = new CategoriaParametroManagement();
                try
                {
                    categoriaParametroManagement.UpdateCategoriaParametro(categoriaParametro);
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
        [Route("EliminarCategoriaParametro")]
        public HttpResponseMessage EliminarCategoriaParametro(string id)
        {
            try
            {
                categoriaParametro = new CategoriaParametro
                {
                    IdCategoriaParametro = Int32.Parse(id)
                };
                categoriaParametroManagement = new CategoriaParametroManagement();
                categoriaParametroManagement.DeleteCategoriaParametro(categoriaParametro);
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
        /// Obtener una CategoriaParametro  por Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/ObtenerCategoriaParametro
        ///     {        
        ///     "IdCliente": 0,
        ///     "Nombre": "Prueba Cliente",
        ///     "Site": "site.com",
        ///     "Telefono": "88888888",
        ///     "Direccion": "San Jose",
        ///     "CorreoContacto": "test@gmail.com"      
        ///     }
        /// </remarks>
        /// <param name="idCategoriaParametro">CategoriaParametro</param>
        /// <response code="200">Carga de CategoriaParametro, exitosa</response>  
        /// <response code="404">No se encontro la CategoriaParametro por id</response>  
        /// <response code="500">Hubo un error en la carga de la CategoriaParametro por id</response>  
        [HttpPut]
        [Route("ObtenerCategoriaParametro/{id}")]
        public HttpResponseMessage ObtenerCategoriaParametro(string idCategoriaParametro)
        {
            try
            {
                categoriaParametro = new CategoriaParametro
                {
                    IdCategoriaParametro = Int32.Parse(idCategoriaParametro)
                };
                categoriaParametroManagement = new CategoriaParametroManagement();
                categoriaParametro = categoriaParametroManagement.RetrieveCategoriaParametro(categoriaParametro);
                if (categoriaParametro is null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound, categoriaParametro);
                }
                else
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, categoriaParametro);
                }

                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de CategoriaParametro por id");
            }

        }

    }
}
