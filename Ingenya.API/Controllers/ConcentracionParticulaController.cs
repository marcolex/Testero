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

    [Route("ConcentracionParticula")]
    [RoutePrefix("api/ConcentracionParticula")]
    public class ConcentracionParticulaController : ApiController
    {
        ConcentracionParticulaManagement concentracionParticulaManagement;
        ConcentracionParticula concentracionParticula;
        ProyectoRoom proyectoRoom;
        HttpResponseMessage response;
        /// <summary>
        /// Obtener Todos Las Concentracion Particula.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/TodosLasConcentracionParticula
        ///     {
        ///     "IdConcentracionParticula": 1,
        ///     "ObjProyectoRoom": {
        ///         "IdProyectoRoom": 1,
        ///         "ObjRoom": null,
        ///         "ObjProyecto": null,
        ///         "ObjCartaPsicometrica": null,
        ///         "ObjProvedor": null,
        ///         "ObjProcesoCartaPsicometrica": null,
        ///         "ObjGraficoNivelActividad": null,
        ///         "ObjGraNivActCalorLatente": null,
        ///         "ObjConcentracionParticula": null
        ///                     },
        ///     "Tiempo": "00:00",
        ///     "ConcenPartiIni": 1,
        ///     "ConcenPartiGen": 1,
        ///     "PartiIni": 1,
        ///     "PartiRetorna": 1,
        ///     "PartiFin": 1,
        ///     "ConcenPartiFin": 1,
        ///     "ConceIncome": 1
        ///     }
        /// </remarks>
        /// <response code="200">Carga de Concentracion Particula, exitosa</response>  
        /// <response code="500">Hubo un error en la carga de las Concentracion Particula</response>  
        [HttpGet]
        [Route("TodosLasConcentracionParticula")]
        public HttpResponseMessage TodosLasConcentracionParticula()
        {
            try
            {
                concentracionParticulaManagement = new ConcentracionParticulaManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<ConcentracionParticula>)concentracionParticulaManagement.RetrieveAllConcentracionParticula());
                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }

        }

        /// <summary>
        /// Obtener todos los CPXProyectoRoom.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/TodosLosCPXProyectoRoom
        ///     {
        ///     "IdConcentracionParticula": 1,
        ///     "ObjProyectoRoom": {
        ///         "IdProyectoRoom": 1,
        ///         "ObjRoom": null,
        ///         "ObjProyecto": null,
        ///         "ObjCartaPsicometrica": null,
        ///         "ObjProvedor": null,
        ///         "ObjProcesoCartaPsicometrica": null,
        ///         "ObjGraficoNivelActividad": null,
        ///         "ObjGraNivActCalorLatente": null,
        ///         "ObjConcentracionParticula": null
        ///                     },
        ///     "Tiempo": "00:00",
        ///     "ConcenPartiIni": 1,
        ///     "ConcenPartiGen": 1,
        ///     "PartiIni": 1,
        ///     "PartiRetorna": 1,
        ///     "PartiFin": 1,
        ///     "ConcenPartiFin": 1,
        ///     "ConceIncome": 1
        ///     }
        /// </remarks>
        /// <param name="id">Id Proyecto Room</param>
        /// <response code="200">Carga de TodosLasCPXProyectoRoom, exitosa</response>  
        /// <response code="500">Hubo un error en la carga de TodosLasCPXProyectoRoom</response>  
        [HttpGet]
        [Route("TodosLasCPXProyectoRoom/{id}")]
        public HttpResponseMessage TodosLasCPXProyectoRoom(String id)
        {
            try
            {
                proyectoRoom = new ProyectoRoom
                {
                    IdProyectoRoom = Int32.Parse(id)
                };

                concentracionParticula = new ConcentracionParticula
                {
                    ObjProyectoRoom = proyectoRoom
                };
                concentracionParticulaManagement = new ConcentracionParticulaManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<ConcentracionParticula>)concentracionParticulaManagement.RetriveByProRoomStatement(concentracionParticula));
                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de TodosLasCPXProyectoRoom");
            }

        }



        /// <summary>
        /// Insertar una nueva concantracion particula.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/InsertarConcentracionParticula
        ///     {
        ///     "IdConcentracionParticula": 1,
        ///     "ObjProyectoRoom": {
        ///         "IdProyectoRoom": 1,
        ///         "ObjRoom": null,
        ///         "ObjProyecto": null,
        ///         "ObjCartaPsicometrica": null,
        ///         "ObjProvedor": null,
        ///         "ObjProcesoCartaPsicometrica": null,
        ///         "ObjGraficoNivelActividad": null,
        ///         "ObjGraNivActCalorLatente": null,
        ///         "ObjConcentracionParticula": null
        ///                     },
        ///     "Tiempo": "00:00",
        ///     "ConcenPartiIni": 1,
        ///     "ConcenPartiGen": 1,
        ///     "PartiIni": 1,
        ///     "PartiRetorna": 1,
        ///     "PartiFin": 1,
        ///     "ConcenPartiFin": 1,
        ///     "ConceIncome": 1
        ///     }
        /// </remarks>
        /// <response code="201">La nueva concantracion particula se ingreso correctamente</response> 
        /// <response code="500">Hubo un error error al crear la nueva concantracion particula</response> 
        // POST api/values
        [HttpPost]
        [Route("InsertarConcentracionParticula")]
        public HttpResponseMessage InsertarConcentracionParticula([FromBody] ConcentracionParticula concentracionParticula)
        {
            try
            {
                concentracionParticulaManagement = new ConcentracionParticulaManagement();
                try
                {
                    concentracionParticulaManagement.CreateConcentracionParticula(concentracionParticula);
                    return Request.CreateResponse(HttpStatusCode.Created);
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al crear la nueva concantracion particula");
                }

                // return response;
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al crear la nueva concantracion particula");
            }

        }


        /// <summary>
        /// Modificar una Concentracion Particula.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT api/ModificarConcentracionParticula
        ///     {
        ///     "IdConcentracionParticula": 1,
        ///     "ObjProyectoRoom": {
        ///         "IdProyectoRoom": 1,
        ///         "ObjRoom": null,
        ///         "ObjProyecto": null,
        ///         "ObjCartaPsicometrica": null,
        ///         "ObjProvedor": null,
        ///         "ObjProcesoCartaPsicometrica": null,
        ///         "ObjGraficoNivelActividad": null,
        ///         "ObjGraNivActCalorLatente": null,
        ///         "ObjConcentracionParticula": null
        ///                     },
        ///     "Tiempo": "00:00",
        ///     "ConcenPartiIni": 1,
        ///     "ConcenPartiGen": 1,
        ///     "PartiIni": 1,
        ///     "PartiRetorna": 1,
        ///     "PartiFin": 1,
        ///     "ConcenPartiFin": 1,
        ///     "ConceIncome": 1
        ///     }
        /// </remarks>
        /// <response code="200">La Concentracion Particula se modifico correctamente</response> 
        /// <response code="500">Hubo un error error al modificar la Concentracion Particula</response> 
        // POST api/values
        [HttpPut]
        [Route("ModificarConcentracionParticula")]
        public HttpResponseMessage ModificarConcentracionParticula([FromBody] ConcentracionParticula concentracionParticula)
        {
            try
            {
                concentracionParticulaManagement = new ConcentracionParticulaManagement();
                try
                {
                    concentracionParticulaManagement.UpdateConcentracionParticula(concentracionParticula);
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                catch (Exception)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al modificar la Concentracion Particula");
                }

                // return response;
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al modificar la Concentracion Particula");
            }

        }


        /// <summary>
        /// Eliminar una Concentracion Particula.
        /// </summary>
        /// <param name="id">Id ConcentracionParticula</param>
        /// <response code="200">La Concentracion Particula se elimino correctamente</response>  
        /// <response code="400">No se puede eliminar esta Concentracion Particula por tener objetos asociados</response>  
        /// <response code="500">Hubo un error error al eliminar la Concentracion Particula</response>  
        [HttpDelete()]
        [Route("EliminarConcentracionParticula")]
        public HttpResponseMessage EliminarConcentracionParticula(string id)
        {
            try
            {
                concentracionParticula = new ConcentracionParticula
                {
                    IdConcentracionParticula = Int32.Parse(id)
                };
                concentracionParticulaManagement = new ConcentracionParticulaManagement();
                concentracionParticulaManagement.DeleteConcentracionParticula(concentracionParticula);
                return Request.CreateResponse(HttpStatusCode.OK, "La Concentracion Particula se elimino correctamente");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FOREIGN KEY"))
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "No se puede eliminar esta Concentracion Particula por tener objetos asociados");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al eliminar la Concentracion Particula");
                }
                
            }

        }

        /// <summary>
        /// Obtener una ConcentracionParticula  por Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/ObtenerConcentracionParticula
        ///     {        
        ///     "IdCliente": 0,
        ///     "Nombre": "Prueba Cliente",
        ///     "Site": "site.com",
        ///     "Telefono": "88888888",
        ///     "Direccion": "San Jose",
        ///     "CorreoContacto": "test@gmail.com"      
        ///     }
        /// </remarks>
        /// <param name="idConcentracionParticula">ConcentracionParticula</param>
        /// <response code="200">Carga de ConcentracionParticula, exitosa</response>  
        /// <response code="404">No se encontro la ConcentracionParticula por id</response>  
        /// <response code="500">Hubo un error en la carga de la ConcentracionParticula por id</response>  
        [HttpPut]
        [Route("ObtenerConcentracionParticula/{id}")]
        public HttpResponseMessage ObtenerConcentracionParticula(string idConcentracionParticula)
        {
            try
            {
                concentracionParticula = new ConcentracionParticula
                {
                    IdConcentracionParticula = Int32.Parse(idConcentracionParticula)
                };
                concentracionParticulaManagement = new ConcentracionParticulaManagement();
                concentracionParticula = concentracionParticulaManagement.RetrieveConcentracionParticula(concentracionParticula);
                if (concentracionParticula is null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound, concentracionParticula);
                }
                else
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, concentracionParticula);
                }

                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de ConcentracionParticula por id");
            }

        }

    }
}
