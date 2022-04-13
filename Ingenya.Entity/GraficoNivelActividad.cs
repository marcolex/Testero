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
    /// GraficoNivelActividad
    /// </summary>
    [Serializable]
    [DataContract]
    public class GraficoNivelActividad :BaseEntity
    {
        public GraficoNivelActividad() { }

        public GraficoNivelActividad(int IdGraficoNivelActividad,NombreParametro ObjNombreParametro, ProyectoRoom ObjProyectoRoom, double Porcentaje,double CalorSensible)
        {
            this.IdGraficoNivelActividad = IdGraficoNivelActividad;
            this.ObjNombreParametro = ObjNombreParametro;
            this.ObjProyectoRoom = ObjProyectoRoom;
            this.Porcentaje = Porcentaje;
            this.CalorSensible = CalorSensible;
        }
        /// <summary>
        /// Id GraficoNivelActividad
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public int IdGraficoNivelActividad { get; set; }
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
        /// CalorSensible
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double CalorSensible { get; set; }
    }
}
