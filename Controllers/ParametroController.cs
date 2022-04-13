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

    [Route("api/Parametro")]
    public class ParametroController : ApiController
    {
        ParametroManagement parametroManagement;
        Parametro parametro;
        HttpResponseMessage response;
        /// <summary>
        /// Obtener todos los parametros.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/TodosLosParametros
        ///     {
        ///    "IdParametro": 0,
        ///    "ObjNombreParametro": {
        ///     "IdNombreParametro": 0,
        ///     "Medida": null,
        ///      "Fecha": "0001-01-01T00:00:00",
        ///      "Nombre": null
        ///    },
        ///    "Valor": 1,
        ///     "Editable": 1,
        ///     "Fecha": "2021-04-11T00:00:00"
        ///    }
        /// </remarks>
        /// <response code="200">Carga de todos los parametros, exitosa</response>  
        /// <response code="500">Hubo un error en la carga de todos los parametros</response>  
        [HttpGet]
        [Route("TodosLosParametros")]
        public HttpResponseMessage TodosLosParametros()
        {
            try
            {
                parametroManagement = new ParametroManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<Parametro>)parametroManagement.RetrieveAllParametro());
                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de todos los parametros");
            }

        }

        /// <summary>
        /// Insertar un parametro nuevo.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     POST api/InsertarParametro
        ///     {
        ///    "IdParametro": 0,
        ///    "ObjNombreParametro": {
        ///     "IdNombreParametro": 0,
        ///     "Medida": null,
        ///      "Fecha": "0001-01-01T00:00:00",
        ///      "Nombre": null
        ///    },
        ///    "Valor": 1,
        ///     "Editable": 1,
        ///     "Fecha": "2021-04-11T00:00:00"
        ///    }
        /// </remarks>
        /// <response code="201">El nuevo parametro se ingreso correctamente</response> 
        /// <response code="500">Hubo un error error al crear el nuevo parametro</response> 
        // POST api/values
        [HttpPost]
        [Route("InsertarParametro")]
        public HttpResponseMessage InsertarParametro([FromBody] Parametro parametro)
        {
            try
            {
                parametroManagement = new ParametroManagement();
                try
                {
                    parametroManagement.CreateParametro(parametro);
                    return Request.CreateResponse(HttpStatusCode.Created, "El nuevo parametro se ingreso correctamente");
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al crear el nuevo parametro");
                }

                // return response;
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al crear el nuevo parametro");
            }

        }


        /// <summary>
        /// Modificar un parametro.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     PUT api/ModificarParametro
        ///     {
        ///    "IdParametro": 0,
        ///    "ObjNombreParametro": {
        ///     "IdNombreParametro": 0,
        ///     "Medida": null,
        ///      "Fecha": "0001-01-01T00:00:00",
        ///      "Nombre": null
        ///    },
        ///    "Valor": 1,
        ///     "Editable": 1,
        ///     "Fecha": "2021-04-11T00:00:00"
        ///    }
        /// </remarks>
        /// <response code="200">El parametro se modifico correctamente</response> 
        /// <response code="500">Hubo un error error al modificar el parametro</response> 
        // POST api/values
        [HttpPut]
        [Route("ModificarParametro")]
        public HttpResponseMessage ModificarParametro([FromBody] Parametro parametro)
        {
            try
            {
                parametroManagement = new ParametroManagement();
                try
                {
                    parametroManagement.UpdateParametro(parametro);
                    return Request.CreateResponse(HttpStatusCode.OK, "El parametro se modifico correctamente");
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al modificar el parametro");
                }

                // return response;
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al modificar el parametro");
            }

        }


        /// <summary>
        /// Eliminar un parametro.
        /// </summary>
        /// <param name="id">Id Parametro</param>
        /// <response code="200">El parametro se elimino correctamente</response>  
        /// <response code="400">No se puede eliminar este parametro por tener proyectos asociados</response>  
        /// <response code="500">Hubo un error error al eliminar el parametro</response>  
        [HttpDelete()]
        [Route("EliminarParametro")]
        public HttpResponseMessage EliminarParametro(string id)
        {
            try
            {
                parametro = new Parametro
                {
                    IdParametro = Int32.Parse(id)
                };
                parametroManagement = new ParametroManagement();
                parametroManagement.DeleteParametro(parametro);
                return Request.CreateResponse(HttpStatusCode.OK, "El parametro se elimino correctamente");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FOREIGN KEY"))
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "No se puede eliminar este parametro por tener proyectos asociados");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al eliminar el parametro");
                }
                
            }

        }

        /// <summary>
        /// Obtener una Parametro  por Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/ObtenerParametro
        ///     {        
        ///     "IdCliente": 0,
        ///     "Nombre": "Prueba Cliente",
        ///     "Site": "site.com",
        ///     "Telefono": "88888888",
        ///     "Direccion": "San Jose",
        ///     "CorreoContacto": "test@gmail.com"      
        ///     }
        /// </remarks>
        /// <param name="idParametro">Parametro</param>
        /// <response code="200">Carga de Parametro, exitosa</response>  
        /// <response code="404">No se encontro la Parametro por id</response>  
        /// <response code="500">Hubo un error en la carga de la Parametro por id</response>  
        [HttpPut]
        [Route("ObtenerParametro/{id}")]
        public HttpResponseMessage ObtenerOcupacion(string idParametro)
        {
            try
            {
                parametro = new Parametro
                {
                    IdParametro = Int32.Parse(idParametro)
                };
                parametroManagement = new ParametroManagement();
                parametro = parametroManagement.RetrieveParamentro(parametro);
                if (parametro is null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound, parametro);
                }
                else
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, parametro);
                }

                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de Parametro por id");
            }

        }

    }
}
