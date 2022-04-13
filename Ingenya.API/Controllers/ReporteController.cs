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


    [Route("api/Reporte")]
    public class ReporteController : ApiController
    {
        ReporteManagement reporteManagement;

        ReporteManagement reporteManagementGrafico;


        Reporte reporte;
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
        [Route("TodosLosReportes")]
        public HttpResponseMessage TodosLosReportes()
        {
            try
            {
                reporteManagement = new ReporteManagement();
                response = Request.CreateResponse(HttpStatusCode.OK, (IEnumerable<Reporte>)reporteManagement.RetrieveAllReporte());
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
        [Route("api/InsertarReporte")]
        public HttpResponseMessage InsertarReporte([FromBody] Reporte reporte)
        {
            try
            {
                reporteManagement = new ReporteManagement();
                try
                {
                    reporteManagement.CreateReporte(reporte);
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
        [Route("api/ModificarReporte")]
        public HttpResponseMessage ModificarReporte([FromBody] Reporte reporte)
        {
            try
            {
                reporteManagement = new ReporteManagement();
                try
                {
                    reporteManagement.UpdateReporte(reporte);
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
        [Route("api/EliminarReporte")]
        public HttpResponseMessage EliminarReporte(string id)
        {
            try
            {
                reporte = new Reporte
                {
                    IdReporte = Int32.Parse(id)
                };
                reporteManagement = new ReporteManagement();
                reporteManagement.DeleteReporte(reporte);
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
        /// Eliminar un cliente.
        /// </summary>
        /// <param name="MUPDB_T1">MUPDB T1</param>
        /// <param name="MUPDB_T2">MUPDB T2</param>
        /// <param name="MUP_W1">MUP W1</param>
        /// <param name="MUP_W2">MUP W2</param>
        /// <param name="Elevation">Elevacion</param>
        /// <response code="200">El cliente se elimino correctamente</response>  
        /// <response code="400">No se puede eliminar este cliente por tener proyectos asociados</response>  
        /// <response code="500">Hubo un error error al eliminar el cliente</response>  
        [HttpGet()]
        [Route("api/GenerarReporteMUP")]
        public HttpResponseMessage GenerarReporteMUP(string MUPDB_T1, string MUPDB_T2, string MUP_W1, string MUP_W2,string Elevation)
        {
            //try
            //{

            //    reporteManagement = new ReporteManagement(4, MUPDB_T1, MUPDB_T2, MUP_W1, MUP_W2, double.Parse(Elevation));

            //    reporteManagement.Reportes();
            //    return Request.CreateResponse(HttpStatusCode.OK, "El cliente se elimino correctamente");
            //    // new frm_Grafico(4, CargarMUP(MUPDB_T1,MUPDB_T2,MUP_W1,MUP_W2), Elevation);


            //}
            //catch (Exception ex)
            //{
            //    if (ex.Message.Contains("FOREIGN KEY"))
            //    {
            //        return Request.CreateResponse(HttpStatusCode.BadRequest, "No se puede eliminar este cliente por tener proyectos asociados");
            //    }
            //    else
            //    {
            //        return Request.CreateResponse(HttpStatusCode.InternalServerError);
            //    }

            //}

            return Request.CreateResponse(HttpStatusCode.OK, "El cliente se elimino correctamente");

        }


        //

    }
}
