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

    [RoutePrefix("api/Fuga")]
    public class FugaController : ApiController
    {
        FugaManagement fugaManagement;
        Fuga fuga;
        ProyectoRoom proyectoRoom;
        HttpResponseMessage response;
        /// <summary>
        /// Obtener todas las fugas.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/TodosLasFugas
        ///     {
        ///    "IdFuga": 1,
        ///    "ObjProyectoRoom": {
        ///     "IdProyectoRoom": 1,
        ///      "ObjRoom": null,
        ///      "ObjProyecto": null,
        ///      "ObjCartaPsicometrica": null,
        ///      "ObjProvedor": null,
        ///      "ObjProcesoCartaPsicometrica": null,
        ///      "ObjGraficoNivelActividad": null,
        ///      "ObjGraNivActCalorLatente": null,
        ///      "ObjConcentracionParticula": null
        ///    },
        ///    "ObjNombreParametro": {
        ///      "IdNombreParametro": 88,
        ///      "Medida": null,
        ///      "Fecha": "0001-01-01T00:00:00",
        ///      "Nombre": null
        ///    },
        ///    "Cantidad": 0,
        ///    "Area": 0,
        ///    "Factor": 1,
        ///    "Flow": 0
        ///  }
        /// </remarks>
        /// <response code="200">Carga de todas las fugas, exitosa</response>  
        /// <response code="500">Hubo un error en la carga de las fugas</response>  
        [HttpGet]
        [Route("TodosLasFugas")]
        public HttpResponseMessage TodosLasFugas()
        {
            try
            {
                fugaManagement = new FugaManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<Fuga>)fugaManagement.RetrieveAllFuga());
                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de las fugas");
            }

        }

        /// <summary>
        /// Obtener todas las fugas por pyecto room.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/TodosLasFugasXProyectoRoom
        ///     {
        ///    "IdFuga": 1,
        ///    "ObjProyectoRoom": {
        ///     "IdProyectoRoom": 1,
        ///      "ObjRoom": null,
        ///      "ObjProyecto": null,
        ///      "ObjCartaPsicometrica": null,
        ///      "ObjProvedor": null,
        ///      "ObjProcesoCartaPsicometrica": null,
        ///      "ObjGraficoNivelActividad": null,
        ///      "ObjGraNivActCalorLatente": null,
        ///      "ObjConcentracionParticula": null
        ///    },
        ///    "ObjNombreParametro": {
        ///      "IdNombreParametro": 88,
        ///      "Medida": null,
        ///      "Fecha": "0001-01-01T00:00:00",
        ///      "Nombre": null
        ///    },
        ///    "Cantidad": 0,
        ///    "Area": 0,
        ///    "Factor": 1,
        ///    "Flow": 0
        ///  }
        /// </remarks>
        /// <param name="id">Id Proeycto Room</param>
        /// <response code="200">Carga de todas las fugas por proyecto room, exitosa</response>  
        /// <response code="500">Hubo un error en la carga de todas las fugas por proyecto room</response>  
        [HttpGet]
        [Route("TodosLasFugasXProyecto")]
        public HttpResponseMessage TodosLasFugasXProyectoRoom(string id)
        {
            try
            {
                proyectoRoom = new ProyectoRoom
                {
                    IdProyectoRoom = Int32.Parse(id)
                };

                fuga = new Fuga
                {
                    ObjProyectoRoom = proyectoRoom
                };

                fugaManagement = new FugaManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<Fuga>)fugaManagement.RetrieveAllFugaByProyecto(fuga));
                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de todas las fugas por proyecto room");
            }

        }





        /// <summary>
        /// Insertar una fuga nueva.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     POST api/InsertarFuga
        ///     {
        ///    "IdFuga": 1,
        ///    "ObjProyectoRoom": {
        ///     "IdProyectoRoom": 1,
        ///      "ObjRoom": null,
        ///      "ObjProyecto": null,
        ///      "ObjCartaPsicometrica": null,
        ///      "ObjProvedor": null,
        ///      "ObjProcesoCartaPsicometrica": null,
        ///      "ObjGraficoNivelActividad": null,
        ///      "ObjGraNivActCalorLatente": null,
        ///      "ObjConcentracionParticula": null
        ///    },
        ///    "ObjNombreParametro": {
        ///      "IdNombreParametro": 88,
        ///      "Medida": null,
        ///      "Fecha": "0001-01-01T00:00:00",
        ///      "Nombre": null
        ///    },
        ///    "Cantidad": 0,
        ///    "Area": 0,
        ///    "Factor": 1,
        ///    "Flow": 0
        ///  }
        /// </remarks>
        /// <response code="201">La nueva fuga se ingreso correctamente</response> 
        /// <response code="500">Hubo un error al crear la nueva fuga</response> 
        // POST api/values
        [HttpPost]
        [Route("InsertarFuga")]
        public HttpResponseMessage InsertarFuga([FromBody] Fuga fuga)
        {
            try
            {
                fugaManagement = new FugaManagement();
                try
                {
                    fugaManagement.CreateFuga(fuga);
                    return Request.CreateResponse(HttpStatusCode.Created, "La nueva fuga se ingreso correctamente");
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al crear la nueva fuga");
                }

                // return response;
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al crear la nueva fuga");
            }

        }


        /// <summary>
        /// Modificar una fuga.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     POST api/ModificarFuga
        ///     {
        ///    "IdFuga": 1,
        ///    "ObjProyectoRoom": {
        ///     "IdProyectoRoom": 1,
        ///      "ObjRoom": null,
        ///      "ObjProyecto": null,
        ///      "ObjCartaPsicometrica": null,
        ///      "ObjProvedor": null,
        ///      "ObjProcesoCartaPsicometrica": null,
        ///      "ObjGraficoNivelActividad": null,
        ///      "ObjGraNivActCalorLatente": null,
        ///      "ObjConcentracionParticula": null
        ///    },
        ///    "ObjNombreParametro": {
        ///      "IdNombreParametro": 88,
        ///      "Medida": null,
        ///      "Fecha": "0001-01-01T00:00:00",
        ///      "Nombre": null
        ///    },
        ///    "Cantidad": 0,
        ///    "Area": 0,
        ///    "Factor": 1,
        ///    "Flow": 0
        ///  }
        /// </remarks>
        /// <response code="200">La fuga se modifico correctamente</response> 
        /// <response code="500">Hubo un error al modificar la fuga</response> 
        // POST api/values
        [HttpPut]
        [Route("ModificarFuga")]
        public HttpResponseMessage ModificarFuga([FromBody] Fuga fuga)
        {
            try
            {
                fugaManagement = new FugaManagement();
                try
                {
                    fugaManagement.UpdateFuga(fuga);
                    return Request.CreateResponse(HttpStatusCode.OK, "La fuga se modifico correctamente");
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al modificar la fuga");
                }

                // return response;
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al modificar la fuga");
            }

        }


        /// <summary>
        /// Eliminar una fuga.
        /// </summary>
        /// <param name="id">Id Fuga</param>
        /// <response code="200">La fuga se elimino correctamente</response>  
        /// <response code="400">No se puede eliminar esta fuga por tener proyectos asociados</response>  
        /// <response code="500">Hubo un error al eliminar esta fuga</response>  
        [HttpDelete()]
        [Route("EliminarFuga")]
        public HttpResponseMessage EliminarFuga(string id)
        {
            try
            {
                fuga = new Fuga
                {
                    IdFuga = Int32.Parse(id)
                };
                fugaManagement = new FugaManagement();
                fugaManagement.DeleteFuga(fuga);
                return Request.CreateResponse(HttpStatusCode.OK, "La fuga se elimino correctamente");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FOREIGN KEY"))
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "No se puede eliminar esta fuga por tener proyectos asociados");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al eliminar esta fuga");
                }
                
            }

        }


        /// <summary>
        /// Obtener una Fuga  por Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/ObtenerFuga
        ///     {        
        ///     "IdCliente": 0,
        ///     "Nombre": "Prueba Cliente",
        ///     "Site": "site.com",
        ///     "Telefono": "88888888",
        ///     "Direccion": "San Jose",
        ///     "CorreoContacto": "test@gmail.com"      
        ///     }
        /// </remarks>
        /// <param name="idFuga">Fuga</param>
        /// <response code="200">Carga de Fuga, exitosa</response>  
        /// <response code="404">No se encontro la Fuga por id</response>  
        /// <response code="500">Hubo un error en la carga de la Fuga por id</response>  
        [HttpPut]
        [Route("ObtenerFuga/{id}")]
        public HttpResponseMessage ObtenerFuga(string idFuga)
        {
            try
            {
                fuga = new Fuga
                {
                    IdFuga = Int32.Parse(idFuga)
                };
                fugaManagement = new FugaManagement();
                fuga = fugaManagement.RetrieveFuga(fuga);
                if (fuga is null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound, fuga);
                }
                else
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, fuga);
                }

                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de Fuga por id");
            }

        }

    }
}
