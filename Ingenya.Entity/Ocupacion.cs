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
    /// Ocupacion
    /// </summary>
    [Serializable]
    [DataContract]
    public class Ocupacion: BaseEntity
    {
        public Ocupacion() { }

        public Ocupacion(int IdOcupacion,NombreParametro ObjNombreParametro,ProyectoRoom ObjProyectoRoom,double Porcentaje,int GeneracionXPersona)
        {
            this.IdOcupacion = IdOcupacion;
            this.ObjNombreParametro = ObjNombreParametro;
            this.ObjProyectoRoom = ObjProyectoRoom;
            this.Porcentaje = Porcentaje;
            this.GeneracionXPersona = GeneracionXPersona;
        }
        /// <summary>
        /// Id Ocupacion
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public int IdOcupacion { get; set; }
        /// <summary>
        /// ObjNombreParametro
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        //[DefaultValue(1)]
        public NombreParametro ObjNombreParametro { get; set; }
        /// <summary>
        /// ObjProyectoRoom
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        //[DefaultValue(1)]
        public ProyectoRoom ObjProyectoRoom { get; set; }
        /// <summary>
        /// Porcentaje
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double Porcentaje { get; set; }
        /// <summary>
        /// GeneracionXPersona
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public int GeneracionXPersona { get; set; }
    }
}
