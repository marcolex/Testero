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

    [Route("api/ProyectoParametro")]
    public class ProyectoParametroController : ApiController
    {
        ProyectoParametroManagement proyectoParametroManagement;
        ProyectoParametro proyectoParametro;
        HttpResponseMessage response;
        /// <summary>
        /// Obtener todos los proyecto parametros.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/TodosLosProyectoParametros
        ///     {
        ///   "IdProyectoParametro": 1,
        ///   "ObjProyectoRoom": {
        ///     "IdProyectoRoom": 1,
        ///     "ObjRoom": null,
        ///     "ObjProyecto": null,
        ///     "ObjCartaPsicometrica": null,
        ///     "ObjProvedor": null,
        ///     "ObjProcesoCartaPsicometrica": null,
        ///     "ObjGraficoNivelActividad": null,
        ///     "ObjGraNivActCalorLatente": null,
        ///     "ObjConcentracionParticula": null
        ///   },
        ///   "ObjParametro": {
        ///     "IdParametro": 0,
        ///     "ObjNombreParametro": null,
        ///     "Valor": 0,
        ///     "Editable": 0,
        ///     "Fecha": "0001-01-01T00:00:00"
        ///   },
        ///   "Valor": -1
        ///   }
        /// </remarks>
        /// <response code="200">Carga de proyecto parametros, exitosa</response>  
        /// <response code="500">Hubo un error en la carga de los proyecto parametros</response>  
        [HttpGet]
        [Route("TodosLosProyectoParametros")]
        public HttpResponseMessage TodosLosProyectoParametros()
        {
            try
            {
                proyectoParametroManagement = new ProyectoParametroManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<ProyectoParametro>)proyectoParametroManagement.RetrieveAllProyectoParametro());
                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de los proyecto parametros");
            }

        }

        /// <summary>
        /// Obtener todos los proyecto parametros.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/TodosLosProyectoParametros
        ///     {
        ///   "IdProyectoParametro": 1,
        ///   "ObjProyectoRoom": {
        ///     "IdProyectoRoom": 1,
        ///     "ObjRoom": null,
        ///     "ObjProyecto": null,
        ///     "ObjCartaPsicometrica": null,
        ///     "ObjProvedor": null,
        ///     "ObjProcesoCartaPsicometrica": null,
        ///     "ObjGraficoNivelActividad": null,
        ///     "ObjGraNivActCalorLatente": null,
        ///     "ObjConcentracionParticula": null
        ///   },
        ///   "ObjParametro": {
        ///     "IdParametro": 0,
        ///     "ObjNombreParametro": null,
        ///     "Valor": 0,
        ///     "Editable": 0,
        ///     "Fecha": "0001-01-01T00:00:00"
        ///   },
        ///   "Valor": -1
        ///   }
        /// </remarks>
        /// <response code="200">Carga de proyecto parametros, exitosa</response>  
        /// <response code="500">Hubo un error en la carga de los proyecto parametros</response>  
        [HttpGet]
        [Route("TodosLosProyectoParametrosByProyectoRoom")]
        public HttpResponseMessage TodosLosProyectoParametrosByProyectoRoom()
        {
            try
            {
                proyectoParametroManagement = new ProyectoParametroManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<ProyectoParametro>)proyectoParametroManagement.RetrieveAllProyectoParametro());
                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de los proyecto parametros");
            }

        }

        /// <summary>
        /// Insertar un proyecto parametro nuevo.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     POST api/InsertarProyectoParametro
        ///     {
        ///   "IdProyectoParametro": 1,
        ///   "ObjProyectoRoom": {
        ///     "IdProyectoRoom": 1,
        ///     "ObjRoom": null,
        ///     "ObjProyecto": null,
        ///     "ObjCartaPsicometrica": null,
        ///     "ObjProvedor": null,
        ///     "ObjProcesoCartaPsicometrica": null,
        ///     "ObjGraficoNivelActividad": null,
        ///     "ObjGraNivActCalorLatente": null,
        ///     "ObjConcentracionParticula": null
        ///   },
        ///   "ObjParametro": {
        ///     "IdParametro": 0,
        ///     "ObjNombreParametro": null,
        ///     "Valor": 0,
        ///     "Editable": 0,
        ///     "Fecha": "0001-01-01T00:00:00"
        ///   },
        ///   "Valor": -1
        ///   }
        /// </remarks>
        /// <response code="201">El nuevo proyecto parametro se ingreso correctamente</response> 
        /// <response code="500">Hubo un error al crear el nuevo proyecto parametro</response> 
        // POST api/values
        [HttpPost]
        [Route("InsertarProyectoParametro")]
        public HttpResponseMessage InsertarProyectoParametro([FromBody] ProyectoParametro proyectoParametro)
        {
            try
            {
                proyectoParametroManagement = new ProyectoParametroManagement();
                try
                {
                    proyectoParametroManagement.CreateProyectoParametro(proyectoParametro);
                    return Request.CreateResponse(HttpStatusCode.Created, "El nuevo proyecto parametro se ingreso correctamente");
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al crear el nuevo proyecto parametro");
                }

                // return response;
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al crear el nuevo proyecto parametro");
            }

        }


        /// <summary>
        /// Modificar un proyecto parametro.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     POST api/ModificarProyectoParametro
        ///     {
        ///   "IdProyectoParametro": 1,
        ///   "ObjProyectoRoom": {
        ///     "IdProyectoRoom": 1,
        ///     "ObjRoom": null,
        ///     "ObjProyecto": null,
        ///     "ObjCartaPsicometrica": null,
        ///     "ObjProvedor": null,
        ///     "ObjProcesoCartaPsicometrica": null,
        ///     "ObjGraficoNivelActividad": null,
        ///     "ObjGraNivActCalorLatente": null,
        ///     "ObjConcentracionParticula": null
        ///   },
        ///   "ObjParametro": {
        ///     "IdParametro": 0,
        ///     "ObjNombreParametro": null,
        ///     "Valor": 0,
        ///     "Editable": 0,
        ///     "Fecha": "0001-01-01T00:00:00"
        ///   },
        ///   "Valor": -1
        ///   }
        /// </remarks>
        /// <response code="200">El proyecto parametro se modifico correctamente</response> 
        /// <response code="500">Hubo un error al modificar el proyecto parametro</response> 
        // POST api/values
        [HttpPut]
        [Route("ModificarProyectoParametro")]
        public HttpResponseMessage ModificarProyectoParametro([FromBody] ProyectoParametro proyectoParametro)
        {
            try
            {
                proyectoParametroManagement = new ProyectoParametroManagement();
                try
                {
                    proyectoParametroManagement.UpdateProyectoParametro(proyectoParametro);
                    return Request.CreateResponse(HttpStatusCode.OK, "El proyecto parametro se modifico correctamente");
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al modificar el proyecto parametro");
                }

                // return response;
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al modificar el proyecto parametro");
            }

        }


        /// <summary>
        /// Eliminar un proyecto parametro.
        /// </summary>
        /// <param name="id">Id ProyectoParametro</param>
        /// <response code="200">El proyecto parametro se elimino correctamente</response>  
        /// <response code="400">No se puede eliminar este proyecto parametro por tener proyectos asociados</response>  
        /// <response code="500">Hubo un error al eliminar el proyecto parametro</response>  
        [HttpDelete()]
        [Route("EliminarProyectoParametro")]
        public HttpResponseMessage EliminarProyectoParametro(string id)
        {
            try
            {
                proyectoParametro = new ProyectoParametro
                {
                    IdProyectoParametro = Int32.Parse(id)
                };
                proyectoParametroManagement = new ProyectoParametroManagement();
                proyectoParametroManagement.DeleteProyectoParametro(proyectoParametro);
                return Request.CreateResponse(HttpStatusCode.OK, "El proyecto parametro se elimino correctamente");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FOREIGN KEY"))
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "No se puede eliminar este proyecto parametro por tener proyectos asociados");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al eliminar el proyecto parametro");
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
        /// <param name="idProyecto">Proyecto</param>
        /// <response code="200">Carga de Proyecto, exitosa</response>  
        /// <response code="404">No se encontro la Proyecto por id</response>  
        /// <response code="500">Hubo un error en la carga de la Proyecto por id</response>  
        [HttpPut]
        [Route("ObtenerProyecto/{id}")]
        public HttpResponseMessage ObtenerProyecto(string idProyecto)
        {
            try
            {
                proyectoParametro = new ProyectoParametro
                {
                    IdProyectoParametro = Int32.Parse(idProyecto)
                };
                proyectoParametroManagement = new ProyectoParametroManagement();
                proyectoParametro = proyectoParametroManagement.RetrieveProyectoParametro(proyectoParametro);
                if (proyectoParametro is null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound, proyectoParametro);
                }
                else
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, proyectoParametro);
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
