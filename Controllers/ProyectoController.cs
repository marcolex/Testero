using Ingenya.ApiCore;
using Ingenya.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Controllers
{

    //[Route("api/Proyecto")]
    [RoutePrefix("api/Proyecto")]
    
    public class ProyectoController : ApiController
    {
        ProyectoManagement proyectoManagement;
        Proyecto proyecto;
        HttpResponseMessage response;
        /// <summary>
        /// Obtener todos los proyectos.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/TodosLosProyectos
        ///     {
        ///         "IdProyecto": 1,
        ///         "ObjClient": {
        ///         "IdCliente": 1,
        ///         "Nombre": null,
        ///         "Site": null,
        ///         "Telefono": null,
        ///         "Direccion": null,
        ///         "CorreoContacto": null
        ///     },
        ///     "NombreProyecto": "Prueba Proeycto",
        ///     "Zona": "",
        ///     "Fecha": "2021-04-11T18:01:58"
        ///    }
        /// </remarks>
        /// <response code="200">Carga de proyectos, exitosa</response>  
        /// <response code="500">Hubo un error en la carga de los proyectos</response>  
        [HttpGet]
        [Route("TodosLosProyectos")]
        [SwaggerOperation("TodosLosProyectos")]
        [SwaggerResponse(HttpStatusCode.OK, "Proyecto", typeof(Proyecto))]
        public HttpResponseMessage TodosLosProyectos()
        {
            try
            {
                proyectoManagement = new ProyectoManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<Proyecto>)proyectoManagement.RetrieveAllProyecto());
                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de los proyectos");
            }

        }

        /// <summary>
        /// Insertar un proyecto nuevo.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/InsertarProyectos
        ///     {
        ///     "IdProyecto": 1,
        ///     "ObjClient": {
        ///     "IdCliente": 1,
        ///     "Nombre": null,
        ///     "Site": null,
        ///     "Telefono": null,
        ///     "Direccion": null,
        ///     "CorreoContacto": null
        ///     },
        ///     "NombreProyecto": "Prueba Proeycto",
        ///     "Zona": "",
        ///     "Fecha": "2021-04-11T18:01:58"
        ///      }
        /// </remarks>
        /// <response code="201">El nuevo proyecto se ingreso correctamente</response> 
        /// <response code="500">Hubo un error error al crear el nuevo proyecto</response> 
        // POST api/values
        [HttpPost]
        [Route("InsertarProyecto")]
        [SwaggerOperation("InsertarProyecto")]
        [SwaggerResponse(HttpStatusCode.Created, "El nuevo proyecto se ingreso correctamente")]
        public HttpResponseMessage InsertarProyecto([FromBody] Proyecto proyecto)
        {
            try
            {
                proyectoManagement = new ProyectoManagement();
                try
                {
                    proyectoManagement.CreateProyecto(proyecto);
                    return Request.CreateResponse(HttpStatusCode.Created, "El nuevo proyecto se ingreso correctamente");
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al crear el nuevo proyecto");
                }

                // return response;
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al crear el nuevo proyecto");
            }

        }


        /// <summary>
        /// Modificar un proyecto.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     PUT api/ModificarProyecto
        ///     {
        ///    "IdProyecto": 1,
        ///   "ObjClient": {
        ///     "IdCliente": 1,
        ///     "Nombre": null,
        ///     "Site": null,
        ///     "Telefono": null,
        ///     "Direccion": null,
        ///     "CorreoContacto": null
        ///   },
        ///   "NombreProyecto": "Prueba Proeycto",
        ///   "Zona": "",
        ///   "Fecha": "2021-04-11T18:01:58"
        ///    }
        /// </remarks>
        /// <response code="200">El proyecto se modifico correctamente</response> 
        /// <response code="500">Hubo un error al modificar el proyecto</response> 
        // POST api/values
        [HttpPut]
        [Route("ModificarProyecto")]
        [SwaggerOperation("ModificarProyecto")]
        [SwaggerResponse(HttpStatusCode.OK, "El proyecto se modifico correctamente")]
        public HttpResponseMessage ModificarProyecto([FromBody] Proyecto proyecto)
        {
            try
            {
                proyectoManagement = new ProyectoManagement();
                try
                {
                    proyectoManagement.UpdateProyecto(proyecto);
                    return Request.CreateResponse(HttpStatusCode.OK, "El proyecto se modifico correctamente");
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al modificar el proyecto");
                }

                // return response;
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al modificar el proyecto");
            }

        }


        /// <summary>
        /// Eliminar un proyecto.
        /// </summary>
        /// <param name="id">Id Proyecto</param>
        /// <response code="200">El proyecto se elimino correctamente</response>  
        /// <response code="400">No se puede eliminar este proyecto por tener proyectos asociados</response>  
        /// <response code="500">Hubo un error al eliminar el proyecto</response>  
        [HttpDelete()]
        [Route("EliminarProyecto/{id}")]
        [SwaggerOperation("EliminarProyecto")]
        [SwaggerResponse(HttpStatusCode.OK, "El proyecto se elimino correctamente")]
        public HttpResponseMessage EliminarProyecto(string id)
        {
            try
            {
                proyecto = new Proyecto
                {
                    IdProyecto = Int32.Parse(id)
                };
                proyectoManagement = new ProyectoManagement();
                proyectoManagement.DeleteProyecto(proyecto);
                return Request.CreateResponse(HttpStatusCode.OK, "El proyecto se elimino correctamente");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FOREIGN KEY"))
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "No se puede eliminar este proyecto por tener proyectos asociados");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al eliminar el proyecto");
                }

            }

        }

        /// <summary>
        /// Obtener una Proyecto  por Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT api/ObtenerProyecto
        ///     {
        ///    "IdProyecto": 1,
        ///   "ObjClient": {
        ///     "IdCliente": 1,
        ///     "Nombre": null,
        ///     "Site": null,
        ///     "Telefono": null,
        ///     "Direccion": null,
        ///     "CorreoContacto": null
        ///   },
        ///   "NombreProyecto": "Prueba Proeycto",
        ///   "Zona": "",
        ///   "Fecha": "2021-04-11T18:01:58"
        ///    }
        /// </remarks>
        /// <param name="idProyecto" required="true">Proyecto</param>
        /// <response code="200">Carga de Proyecto, exitosa</response>  
        /// <response code="404">No se encontro la Proyecto por id</response>  
        /// <response code="500">Hubo un error en la carga de la Proyecto por id</response>  
        [HttpPut]
        [Route("ObtenerProyecto/{idProyecto}")]
        [SwaggerOperation("ObtenerProyecto")]
        [SwaggerResponse(HttpStatusCode.OK, "Proyecto", typeof(Proyecto))]
        public HttpResponseMessage ObtenerProyecto([Required] string idProyecto)
        {
            try
            {
                proyecto = new Proyecto
                {
                    IdProyecto = Int32.Parse(idProyecto)
                };
                proyectoManagement = new ProyectoManagement();
                proyecto = proyectoManagement.RetrieveProyecto(proyecto);
                if (proyecto is null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound, proyecto);
                }
                else
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, proyecto);
                }

                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de Proyecto por id");
            }

        }

    }
}
