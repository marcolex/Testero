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
    /// Nombre Parametro
    /// </summary>
    [Serializable]
    [DataContract]
    public class NombreParametro: BaseEntity
    {
        private readonly int idNombreParametro;

        public NombreParametro() { }

        public NombreParametro(int IdNombreParametro,String Medida,DateTime Fecha,String Nombre)
        {
            idNombreParametro = IdNombreParametro;
            this.Medida = Medida;
            this.Fecha = Fecha;
            this.Nombre = Nombre;
        }

        /// <summary>
        /// Id NombreParametro
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public int IdNombreParametro { get; set; }
        /// <summary>
        /// Medida
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public string Medida { get; set; }
        /// <summary>
        /// Fecha
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        //[DefaultValue(1)]
        public DateTime Fecha { get; set; }
        /// <summary>
        /// Nombre
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public string Nombre { get; set; }
    }
}
