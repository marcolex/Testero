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

    [Route("api/ProyectoRoom")]
    public class ProyectoRoomController : ApiController
    {
        ProyectoRoomManagement proyectoRoomManagement;
        ProyectoRoom proyectoRoom;
        HttpResponseMessage response;
        /// <summary>
        /// Obtener todos los proyecto rooms.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/TodosLosProyectoRooms
        ///     {
        ///     "IdProyectoRoom": 1,
        ///     "ObjRoom": {
        ///       "IdRoom": 1,
        ///       "Nombre": null
        ///     },
        ///     "ObjProyecto": null,
        ///     "ObjCartaPsicometrica": {
        ///       "IdCartaPsicometrica": 0,
        ///       "ObjProyectoRoom": null,
        ///       "Dbt": 0,
        ///       "CienPorCiento": 0,
        ///       "OchentaProCiento": 0,
        ///       "SesentaPorCiento": 0,
        ///       "CuarentaPorCiento": 0,
        ///       "VeintePorCiento": 0,
        ///       "TreintaYCientoTem": 0,
        ///      "CuarentaYCientoTem": 0,
        ///      "CincuentaYCincoTem": 0,
        ///      "SesentaYCincoTem": 0,
        ///      "SetentaYCincoTem": 0,
        ///       "OchentaYCincoTem": 0,
        ///       "NoventaYCincoTem": 0,
        ///       "CientoCincoTem": 0,
        ///       "CientoDiezTem": 0,
        ///       "CientoQuinceTem": 0,
        ///       "CientoVeinteTem": 0,
        ///       "CientoVeintiCincoTem": 0,
        ///       "CientoTreintaTem": 0
        ///     },
        ///     "ObjProvedor": {
        ///       "IdProvedor": 0,
        ///       "NombreProyecto": null,
        ///       "Site": null,
        ///       "Telefono": null,
        ///       "Direccion": null,
        ///        "CorreoContacto": null
        ///     },
        ///     "ObjProcesoCartaPsicometrica": {
        ///       "IdProcesoCartaPsicometrica": 0,
        ///       "ObjProyectoRoom": null,
        ///       "Punto": 0,
        ///       "Dbt": 0,
        ///       "W": 0,
        ///        "Description": null,
        ///       "Tipo": null
        ///     },
        ///     "ObjGraficoNivelActividad": {
        ///      "IdGraficoNivelActividad": 0,
        ///      "ObjNombreParametro": null,
        ///      "ObjProyectoRoom": null,
        ///      "Porcentaje": 0,
        ///      "CalorSensible": 0
        ///    },
        ///    "ObjGraNivActCalorLatente": {
        ///       "IdGravNivActCalorLatente": 0,
        ///      "ObjProyectoRoom": null,
        ///      "TipoAplicacion": null,
        ///      "Porcentaje": 0,
        ///      "CalorSensible": 0
        ///     },
        ///     "ObjConcentracionParticula": {
        ///       "IdConcentracionParticula": 0,
        ///      "ObjProyectoRoom": null,
        ///       "Tiempo": null,
        ///       "ConcenPartiIni": 0,
        ///       "ConcenPartiGen": 0,
        ///       "PartiIni": 0,
        ///       "PartiRetorna": 0,
        ///       "PartiFin": 0,
        ///       "ConcenPartiFin": 0,
        ///       "ConceIncome": 0
        ///     }
        ///     }
        /// </remarks>
        /// <response code="200">Carga de proyecto rooms, exitosa</response>  
        /// <response code="500">Hubo un error en la carga de los proyecto rooms</response>  
        [HttpGet]
        [Route("TodosLosProyectoRooms")]
        public HttpResponseMessage TodosLosProyectoRooms()
        {
            try
            {
                proyectoRoomManagement = new ProyectoRoomManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<ProyectoRoom>)proyectoRoomManagement.RetrieveAllProyectoRoom());
                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de los proyecto rooms");
            }

        }

        /// <summary>
        /// Insertar un proyecto room nuevo.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     POST api/InsertarProyectoRoom
        ///     {
        ///     "IdProyectoRoom": 1,
        ///     "ObjRoom": {
        ///       "IdRoom": 1,
        ///       "Nombre": null
        ///     },
        ///     "ObjProyecto": null,
        ///     "ObjCartaPsicometrica": {
        ///       "IdCartaPsicometrica": 0,
        ///       "ObjProyectoRoom": null,
        ///       "Dbt": 0,
        ///       "CienPorCiento": 0,
        ///       "OchentaProCiento": 0,
        ///       "SesentaPorCiento": 0,
        ///       "CuarentaPorCiento": 0,
        ///       "VeintePorCiento": 0,
        ///       "TreintaYCientoTem": 0,
        ///      "CuarentaYCientoTem": 0,
        ///      "CincuentaYCincoTem": 0,
        ///      "SesentaYCincoTem": 0,
        ///      "SetentaYCincoTem": 0,
        ///       "OchentaYCincoTem": 0,
        ///       "NoventaYCincoTem": 0,
        ///       "CientoCincoTem": 0,
        ///       "CientoDiezTem": 0,
        ///       "CientoQuinceTem": 0,
        ///       "CientoVeinteTem": 0,
        ///       "CientoVeintiCincoTem": 0,
        ///       "CientoTreintaTem": 0
        ///     },
        ///     "ObjProvedor": {
        ///       "IdProvedor": 0,
        ///       "NombreProyecto": null,
        ///       "Site": null,
        ///       "Telefono": null,
        ///       "Direccion": null,
        ///        "CorreoContacto": null
        ///     },
        ///     "ObjProcesoCartaPsicometrica": {
        ///       "IdProcesoCartaPsicometrica": 0,
        ///       "ObjProyectoRoom": null,
        ///       "Punto": 0,
        ///       "Dbt": 0,
        ///       "W": 0,
        ///        "Description": null,
        ///       "Tipo": null
        ///     },
        ///     "ObjGraficoNivelActividad": {
        ///      "IdGraficoNivelActividad": 0,
        ///      "ObjNombreParametro": null,
        ///      "ObjProyectoRoom": null,
        ///      "Porcentaje": 0,
        ///      "CalorSensible": 0
        ///    },
        ///    "ObjGraNivActCalorLatente": {
        ///       "IdGravNivActCalorLatente": 0,
        ///      "ObjProyectoRoom": null,
        ///      "TipoAplicacion": null,
        ///      "Porcentaje": 0,
        ///      "CalorSensible": 0
        ///     },
        ///     "ObjConcentracionParticula": {
        ///       "IdConcentracionParticula": 0,
        ///      "ObjProyectoRoom": null,
        ///       "Tiempo": null,
        ///       "ConcenPartiIni": 0,
        ///       "ConcenPartiGen": 0,
        ///       "PartiIni": 0,
        ///       "PartiRetorna": 0,
        ///       "PartiFin": 0,
        ///       "ConcenPartiFin": 0,
        ///       "ConceIncome": 0
        ///     }
        ///     }
        /// </remarks>
        /// <response code="201">El nuevo proyecto room se ingreso correctamente</response> 
        /// <response code="500">Hubo un error al crear el nuevo proyecto room</response> 
        // POST api/values
        [HttpPost]
        [Route("InsertarProyectoRoom")]
        public HttpResponseMessage InsertarProyectoRoom([FromBody] ProyectoRoom proyectoRoom)
        {
            try
            {
                proyectoRoomManagement = new ProyectoRoomManagement();
                try
                {
                    proyectoRoomManagement.CreateProyectoRoom(proyectoRoom);
                    return Request.CreateResponse(HttpStatusCode.Created, "El nuevo proyecto room se ingreso correctamente");
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al crear el nuevo proyecto room");
                }

                // return response;
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al crear el nuevo proyecto room");
            }

        }


        /// <summary>
        /// Modificar un proyecto room.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     POST api/ModificarProyectoRoom
        ///     {
        ///     "IdProyectoRoom": 1,
        ///     "ObjRoom": {
        ///       "IdRoom": 1,
        ///       "Nombre": null
        ///     },
        ///     "ObjProyecto": null,
        ///     "ObjCartaPsicometrica": {
        ///       "IdCartaPsicometrica": 0,
        ///       "ObjProyectoRoom": null,
        ///       "Dbt": 0,
        ///       "CienPorCiento": 0,
        ///       "OchentaProCiento": 0,
        ///       "SesentaPorCiento": 0,
        ///       "CuarentaPorCiento": 0,
        ///       "VeintePorCiento": 0,
        ///       "TreintaYCientoTem": 0,
        ///      "CuarentaYCientoTem": 0,
        ///      "CincuentaYCincoTem": 0,
        ///      "SesentaYCincoTem": 0,
        ///      "SetentaYCincoTem": 0,
        ///       "OchentaYCincoTem": 0,
        ///       "NoventaYCincoTem": 0,
        ///       "CientoCincoTem": 0,
        ///       "CientoDiezTem": 0,
        ///       "CientoQuinceTem": 0,
        ///       "CientoVeinteTem": 0,
        ///       "CientoVeintiCincoTem": 0,
        ///       "CientoTreintaTem": 0
        ///     },
        ///     "ObjProvedor": {
        ///       "IdProvedor": 0,
        ///       "NombreProyecto": null,
        ///       "Site": null,
        ///       "Telefono": null,
        ///       "Direccion": null,
        ///        "CorreoContacto": null
        ///     },
        ///     "ObjProcesoCartaPsicometrica": {
        ///       "IdProcesoCartaPsicometrica": 0,
        ///       "ObjProyectoRoom": null,
        ///       "Punto": 0,
        ///       "Dbt": 0,
        ///       "W": 0,
        ///        "Description": null,
        ///       "Tipo": null
        ///     },
        ///     "ObjGraficoNivelActividad": {
        ///      "IdGraficoNivelActividad": 0,
        ///      "ObjNombreParametro": null,
        ///      "ObjProyectoRoom": null,
        ///      "Porcentaje": 0,
        ///      "CalorSensible": 0
        ///    },
        ///    "ObjGraNivActCalorLatente": {
        ///       "IdGravNivActCalorLatente": 0,
        ///      "ObjProyectoRoom": null,
        ///      "TipoAplicacion": null,
        ///      "Porcentaje": 0,
        ///      "CalorSensible": 0
        ///     },
        ///     "ObjConcentracionParticula": {
        ///       "IdConcentracionParticula": 0,
        ///      "ObjProyectoRoom": null,
        ///       "Tiempo": null,
        ///       "ConcenPartiIni": 0,
        ///       "ConcenPartiGen": 0,
        ///       "PartiIni": 0,
        ///       "PartiRetorna": 0,
        ///       "PartiFin": 0,
        ///       "ConcenPartiFin": 0,
        ///       "ConceIncome": 0
        ///     }
        ///     }
        /// </remarks>
        /// <response code="200">El proyecto room se modifico correctamente</response> 
        /// <response code="500">Hubo un error al modificar el proyecto room</response> 
        // POST api/values
        [HttpPut]
        [Route("ModificarProyectoRoom")]
        public HttpResponseMessage ModificarProyectoRoom([FromBody] ProyectoRoom proyectoRoom)
        {
            try
            {
                proyectoRoomManagement = new ProyectoRoomManagement();
                try
                {
                    proyectoRoomManagement.UpdateProyectoRoom(proyectoRoom);
                    return Request.CreateResponse(HttpStatusCode.OK, "El proyecto room se modifico correctamente");
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al modificar el proyecto room");
                }

                // return response;
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al modificar el proyecto room");
            }

        }


        /// <summary>
        /// Eliminar un proyecto room.
        /// </summary>
        /// <param name="id">Id ProyectoRoom</param>
        /// <response code="200">El  proyecto room se elimino correctamente</response>  
        /// <response code="400">No se puede eliminar este  proyecto room por tener proyectos asociados</response>  
        /// <response code="500">Hubo un error al eliminar el  proyecto room</response>  
        [HttpDelete()]
        [Route("EliminarProyectoRoom")]
        public HttpResponseMessage EliminarProyectoRoom(string id)
        {
            try
            {
                proyectoRoom = new ProyectoRoom
                {
                    IdProyectoRoom = Int32.Parse(id)
                };
                proyectoRoomManagement = new ProyectoRoomManagement();
                proyectoRoomManagement.DeleteProyectoRoom(proyectoRoom);
                return Request.CreateResponse(HttpStatusCode.OK, "El  proyecto room se elimino correctamente");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FOREIGN KEY"))
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "No se puede eliminar este  proyecto room por tener proyectos asociados");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al eliminar el  proyecto room");
                }
                
            }

        }

    }
}
