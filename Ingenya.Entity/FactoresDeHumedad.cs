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
    /// Factores De Humedad
    /// </summary>
    [Serializable]
    [DataContract]
    public class FactoresDeHumedad : BaseEntity
    {
        public FactoresDeHumedad() { }
        public FactoresDeHumedad(int IdFactoresDeHumedad, ProyectoRoom objProyectoRoom, Parametro objParametro)
        {
            this.IdFactoresDeHumedad = IdFactoresDeHumedad;
            ObjProyectoRoom = objProyectoRoom;
            ObjParametro = objParametro;
        }
        /// <summary>
        /// Id FactoresDeHumedad
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public int IdFactoresDeHumedad { get; set; }
        /// <summary>
        /// ObjProyectoRoom
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public ProyectoRoom ObjProyectoRoom { get; set; }
        /// <summary>
        /// ObjParametro
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public Parametro ObjParametro { get; set; }
    }
}
