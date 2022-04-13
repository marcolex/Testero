using Ingenya.API.Models;
using Ingenya.ApiCore;
using Ingenya.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace WebApp.Controllers
{

    // [RoutePrefix("api/Cliente")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly IConfiguration configuration;

        ClienteManagement clienteManagement;
        Cliente cliente;
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
        [Route("TodosLosClientes")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Cliente> TodosLosClientes()
        {
            try
            {
                clienteManagement = new ClienteManagement();
                return (IEnumerable<Cliente>)clienteManagement.RetrieveAllCliente();
            }
            catch (Exception)
            {
                return null ;
            }

        }

        /// <summary>
        /// Insertar un cliente nuevo.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/InsertarCliente
        ///       {
        ///        "IdCliente": 0,
        ///        "Nombre": "string",
        ///        "Site": "string",
        ///        "Telefono": "string",
        ///        "Direccion": "string",
        ///        "CorreoContacto": "string"
        ///       }
        /// 
        /// </remarks>
        /// <response code="201">El nuevo cliente se ingreso correctamente</response> 
        /// <response code="500">Hubo un error error al crear el nuevo cliente</response> 
        // POST api/values
        [HttpPost]
        [Route("InsertarCliente")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void InsertarCliente([Required][FromBody] Cliente cliente)
        {
            try
            {
                clienteManagement = new ClienteManagement();
                try
                {
                    clienteManagement.CreateCliente(cliente);
                    //return Request.CreateResponse(HttpStatusCode.Created, "El cliente se inserto correctamente");
                }
                catch (Exception)
                {
                     
                   // return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al crear el nuevo cliente");
                }

                // return response;
            }
            catch (Exception)
            {

               // return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error error al crear el nuevo cliente");
            }

        }


        /// <summary>
        /// Modificar un cliente.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT api/ModificarCliente
        ///       {
        ///        "IdCliente": 0,
        ///        "Nombre": "string",
        ///        "Site": "string",
        ///        "Telefono": "string",
        ///        "Direccion": "string",
        ///        "CorreoContacto": "string"
        ///     }
        /// </remarks>
        /// <response code="200">El cliente se modifico correctamente</response> 
        /// <response code="500">Hubo un error error al modificar el cliente</response> 
        [HttpPut]
        [Route("ModificarCliente")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void ModificarCliente([Required][FromBody] Cliente cliente)
        {
            try
            {
                clienteManagement = new ClienteManagement();
                try
                {
                    clienteManagement.UpdateCliente(cliente);
                    //return StatusCodes.Status200OK;
                }
                catch (Exception)
                {
                    //return StatusCodes.Status500InternalServerError;
                }

                // return response;
            }
            catch (Exception)
            {

               // return StatusCodes.Status500InternalServerError;
            }

        }


        /// <summary>
        /// Eliminar un cliente.
        /// </summary>
        /// <param name="id">Id Cliente</param>
        /// <response code="200">El cliente se modifico correctamente</response> 
        /// <response code="409">No se puede eliminar este cliente por tener proyectos asociados</response> 
        /// <response code="500">Hubo un error error al modificar el cliente</response> 
        [HttpDelete()]
        [Route("EliminarCliente/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //[HttpDelete("EliminarCliente/{id}")]
        public void EliminarCliente([Required] string id)
        {
            try
            {
                cliente = new Cliente
                {
                    IdCliente = Int32.Parse(id)
                };
                clienteManagement = new ClienteManagement();
                clienteManagement.DeleteCliente(cliente);
                //return Request.CreateResponse(HttpStatusCode.OK, "El cliente se elimino correctamente");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FOREIGN KEY"))
                {
                   // return Request.CreateResponse(HttpStatusCode.Conflict, "No se puede eliminar este cliente por tener proyectos asociados");
                }
                else
                {
                   // return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error al eliminar el cliente");
                }

            }

        }

        /// <summary>
        /// Obtener un cliente por Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT ObtenerCliente/{id}
        ///     {        
        ///     "IdCliente": 0,
        ///     "Nombre": "Prueba Cliente",
        ///     "Site": "site.com",
        ///     "Telefono": "88888888",
        ///     "Direccion": "San Jose",
        ///     "CorreoContacto": "test@gmail.com"      
        ///     }
        /// </remarks>
        /// <param name="id">Cliente</param>
        /// <response code="200">El cliente se obtuvo correctamente</response> 
        /// <response code="404">No se encontro el cliente por id</response> 
        /// <response code="500">Hubo un error en la carga del cliente por id</response> 
        [HttpPut]
        [Route("ObtenerCliente/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
       // [HttpPut("ObtenerCliente/{id}")]
        public Cliente ObtenerCliente([Required] string id)
        {
            try
            {
                cliente = new Cliente
                {
                    IdCliente = Int32.Parse(id)
                };
                clienteManagement = new ClienteManagement();
                cliente = clienteManagement.RetrieveClientebyId(cliente);
                if (cliente is null)
                {
                    //response = Request.CreateResponse(HttpStatusCode.NotFound, cliente);
                }
                else
                {
                    //response = Request.CreateResponse(HttpStatusCode.OK, cliente);
                }

                return cliente;
            }
            catch (Exception)
            {
                //return Request.CreateResponse(HttpStatusCode.InternalServerError, "Hubo un error en la carga del cliente por id");
                return null;
            }

        }

    }
}
