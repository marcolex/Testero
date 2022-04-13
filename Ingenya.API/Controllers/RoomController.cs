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

    [Route("api/Room")]
    public class RoomController : ApiController
    {
        RoomManagement roomManagement;
        Room room;
        HttpResponseMessage response;
        /// <summary>
        /// Obtener todos los rooms.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/TodosLosRooms
        ///     {
        ///  "IdRoom": 1,
        ///  "Nombre": "Room Prueba"
        ///     }
        /// </remarks>
        /// <response code="200">Carga de rooms, exitosa</response>  
        /// <response code="500">Hubo un error en la carga de los rooms</response>  
        [HttpGet]
        [Route("TodosLosRooms")]
        public HttpResponseMessage TodosLosRooms()
        {
            try
            {
                roomManagement = new RoomManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<Room>)roomManagement.RetrieveAllRoom());
                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de los rooms");
            }

        }

        /// <summary>
        /// Insertar un room nuevo.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     POST api/InsertarRoom
        ///     {
        ///  "IdRoom": 1,
        ///  "Nombre": "Room Prueba"
        ///     }
        /// </remarks>
        /// <response code="201">El nuevo room se ingreso correctamente</response> 
        /// <response code="500">Hubo un error error al crear el nuevo room</response> 
        // POST api/values
        [HttpPost]
        [Route("InsertarRoom")]
        public HttpResponseMessage InsertarRoom([FromBody] Room room)
        {
            try
            {
                roomManagement = new RoomManagement();
                try
                {
                    roomManagement.CreateRoom(room);
                    return Request.CreateResponse(HttpStatusCode.Created, "El nuevo room se ingreso correctamente");
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al crear el nuevo room");
                }

                // return response;
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al crear el nuevo room");
            }

        }


        /// <summary>
        /// Modificar un room.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     POST api/ModificarRoom
        ///     {
        ///  "IdRoom": 1,
        ///  "Nombre": "Room Prueba"
        ///     }
        /// </remarks>
        /// <response code="200">El room se modifico correctamente</response> 
        /// <response code="500">Hubo un error al modificar el room</response> 
        // POST api/values
        [HttpPut]
        [Route("ModificarRoom")]
        public HttpResponseMessage ModificarRoom([FromBody] Room room)
        {
            try
            {
                roomManagement = new RoomManagement();
                try
                {
                    roomManagement.UpdateRoom(room);
                    return Request.CreateResponse(HttpStatusCode.OK, "El room se modifico correctamente");
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al modificar el room");
                }

                // return response;
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al modificar el room");
            }

        }


        /// <summary>
        /// Eliminar un room.
        /// </summary>
        /// <param name="id">Id Room</param>
        /// <response code="200">El room se elimino correctamente</response>  
        /// <response code="400">No se puede eliminar este room por tener proyectos asociados</response>  
        /// <response code="500">Hubo un error al eliminar el room</response>  
        [HttpDelete()]
        [Route("EliminarRoom")]
        public HttpResponseMessage EliminarRoom(string id)
        {
            try
            {
                room = new Room
                {
                    IdRoom = Int32.Parse(id)
                };
                roomManagement = new RoomManagement();
                roomManagement.DeleteRoom(room);
                return Request.CreateResponse(HttpStatusCode.OK, "El room se elimino correctamente");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FOREIGN KEY"))
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "No se puede eliminar este room por tener proyectos asociados");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al eliminar el room");
                }
                
            }

        }

    }
}
