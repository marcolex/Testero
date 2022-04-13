using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.Entities
{
    /// <summary>
    /// CLiente
    /// </summary>
    public class Cliente :BaseEntity
    {
        public Cliente() { }

        public Cliente(int IdCliente,String Nombre, String  Site, String Telefono, String Direccion, String CorreoContacto)
        {
            this.IdCliente = IdCliente;
            this.Nombre = Nombre;
            this.Site = Site;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
            this.CorreoContacto = CorreoContacto;
        }

        /// <summary>
        /// Id Cliente
        /// </summary>
        /// <example>6073ca0bd932aa3291eb524f</example>
        [Required]
        [DefaultValue(1)]
        public int IdCliente { get; set; }

        /// <summary>
        /// Nombre del cliente
        /// </summary>
        /// <example>Ingenya</example>

        [Required]
        [DefaultValue("Ingenya")]
        public string Nombre { get; set; }

        /// <summary>
        /// The user's first name.
        /// </summary>
        /// <example>Jane</example>

        public string Site { get; set; }

        /// <summary>
        /// The user's first name.
        /// </summary>
        /// <example>Jane</example>

        public string Telefono { get; set; }

        /// <summary>
        /// The user's first name.
        /// </summary>
        /// <example>Jane</example>

        public string Direccion { get; set; }

        /// <summary>
        /// The user's first name.
        /// </summary>
        /// <example>Jane</example>
        [Required]
        public string CorreoContacto { get; set; }
    }
}
