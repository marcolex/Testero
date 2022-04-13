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

    [Route("api/NombreParametro")]
    public class NombreParametroController : ApiController
    {
        NombreParametroManagement nombreParametroManagement;
        NombreParametro nombreParametro;
        HttpResponseMessage response;
        /// <summary>
        /// Obtener todos los nombre parametro.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/TodosLosNombreParametro
        ///     {
        ///  "IdNombreParametro": 0,
        ///  "Medida": "°F",
        ///  "Fecha": "2021-04-11T00:00:00",
        ///  "Nombre": "txt_DryBulbA"
        ///     }
        /// </remarks>
        /// <response code="200">Carga de todos los nombre parametro, exitosa</response>  
        /// <response code="500">Hubo un error en la carga de todos los nombre parametro</response>  
        [HttpGet]
        [Route("TodosLosNombreParametro")]
        public HttpResponseMessage TodosLosNombreParametro()
        {
            try
            {
                nombreParametroManagement = new NombreParametroManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<NombreParametro>)nombreParametroManagement.RetrieveAllNombreParametro());
                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de todos los nombre parametro");
            }

        }

        /// <summary>
        /// Insertar un nombre parametro.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     POST api/InsertarNombreParametro
        ///     {
        ///  "IdNombreParametro": 0,
        ///  "Medida": "°F",
        ///  "Fecha": "2021-04-11T00:00:00",
        ///  "Nombre": "txt_DryBulbA"
        ///     }
        /// </remarks>
        /// <response code="201">El nuevo nombre parametro se ingreso correctamente</response> 
        /// <response code="500">Hubo un error al crear el nuevo nombre parametro</response> 
        // POST api/values
        [HttpPost]
        [Route("InsertarNombreParametro")]
        public HttpResponseMessage InsertarNombreParametro([FromBody] NombreParametro nombreParametro)
        {
            try
            {
                nombreParametroManagement = new NombreParametroManagement();
                try
                {
                    nombreParametroManagement.CreateNombreParametro(nombreParametro);
                    return Request.CreateResponse(HttpStatusCode.Created, "El nuevo nombre parametro se ingreso correctamente");
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al crear el nuevo nombre parametro");
                }

                // return response;
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al crear el nuevo nombre parametro");
            }

        }


        /// <summary>
        /// Modificar un nombre parametro.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     PUT api/ModificarNombreParametro
        ///     {
        ///  "IdNombreParametro": 0,
        ///  "Medida": "°F",
        ///  "Fecha": "2021-04-11T00:00:00",
        ///  "Nombre": "txt_DryBulbA"
        ///     }
        /// </remarks>
        /// <response code="200">El nombre parametro se modifico correctamente</response> 
        /// <response code="500">Hubo un error al modificar el nombre parametro</response> 
        // POST api/values
        [HttpPut]
        [Route("ModificarNombreParametro")]
        public HttpResponseMessage ModificarNombreParametro([FromBody] NombreParametro nombreParametro)
        {
            try
            {
                nombreParametroManagement = new NombreParametroManagement();
                try
                {
                    nombreParametroManagement.UpdateNombreParametro(nombreParametro);
                    return Request.CreateResponse(HttpStatusCode.OK, "El nombre parametro se modifico correctamente");
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al modificar el nombre parametro");
                }

                // return response;
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al modificar el nombre parametro");
            }

        }


        /// <summary>
        /// Eliminar un nombre parametro.
        /// </summary>
        /// <param name="id">Id NombreParametro</param>
        /// <response code="200">El nombre parametro se elimino correctamente</response>  
        /// <response code="400">No se puede eliminar este nombre parametro por tener proyectos asociados</response>  
        /// <response code="500">Hubo un error al eliminar el nombre parametro</response>  
        [HttpDelete()]
        [Route("EliminarNombreParametro")]
        public HttpResponseMessage EliminarNombreParametro(string id)
        {
            try
            {
                nombreParametro = new NombreParametro
                {
                    IdNombreParametro = Int32.Parse(id)
                };
                nombreParametroManagement = new NombreParametroManagement();
                nombreParametroManagement.DeleteNombreParametro(nombreParametro);
                return Request.CreateResponse(HttpStatusCode.OK, "El nombre parametro se elimino correctamente");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FOREIGN KEY"))
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "No se puede eliminar este nombre parametro por tener proyectos asociados");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al eliminar el nombre parametro");
                }
                
            }

        }


        /// <summary>
        /// Obtener una NombreParametro  por Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/ObtenerNombreParametro
        ///     {        
        ///     "IdCliente": 0,
        ///     "Nombre": "Prueba Cliente",
        ///     "Site": "site.com",
        ///     "Telefono": "88888888",
        ///     "Direccion": "San Jose",
        ///     "CorreoContacto": "test@gmail.com"      
        ///     }
        /// </remarks>
        /// <param name="idNombreParametro">NombreParametro</param>
        /// <response code="200">Carga de NombreParametro, exitosa</response>  
        /// <response code="404">No se encontro la NombreParametro por id</response>  
        /// <response code="500">Hubo un error en la carga de la NombreParametro por id</response>  
        [HttpPut]
        [Route("ObtenerNombreParametro/{id}")]
        public HttpResponseMessage ObtenerNombreParametro(string idNombreParametro)
        {
            try
            {
                nombreParametro = new NombreParametro
                {
                    IdNombreParametro = Int32.Parse(idNombreParametro)
                };
                nombreParametroManagement = new NombreParametroManagement();
                nombreParametro = nombreParametroManagement.RetrieveNombreParametro(nombreParametro);
                if (nombreParametro is null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound, nombreParametro);
                }
                else
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, nombreParametro);
                }

                return response;
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga de NombreParametro por id");
            }

        }

    }
}
