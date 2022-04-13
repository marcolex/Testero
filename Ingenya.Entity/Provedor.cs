using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Ingenya.Entities
{
    /// <summary>
    /// Provedor
    /// </summary>
    [Serializable]
    [DataContract]
    public class Provedor : BaseEntity
    {
        public Provedor() { }

        public Provedor(int IdProvedor, String NombreProyecto, String Site, String Telefono, String Direccion, String CorreoContacto)
        {
            this.IdProvedor = IdProvedor;
            this.NombreProyecto = NombreProyecto;
            this.Site = Site;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
            this.CorreoContacto = CorreoContacto;
        }

        /// <summary>
        /// Id Provedor
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public int IdProvedor { get; set; }
        /// <summary>
        /// NombreProyecto
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public string NombreProyecto { get; set; }
        /// <summary>
        /// Site
        /// </summary>
        /// <example>01</example>
        [DataMember]
        //[Required]
        //[DefaultValue(1)]
        public string Site { get; set; }
        /// <summary>
        /// Telefono
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public string Telefono { get; set; }
        /// <summary>
        /// Direccion
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public string Direccion { get; set; }
        /// <summary>
        /// Correo Contacto
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public string CorreoContacto { get; set; }
    }
}
