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
    /// GraNivActCalorLatente
    /// </summary>
    [Serializable]
    [DataContract]
    public class GraNivActCalorLatente :BaseEntity
    {
        public GraNivActCalorLatente() { }

        public GraNivActCalorLatente(int IdGravNivActCalorLatente,ProyectoRoom ObjProyectoRoom,String TipoAplicacion, double Porcentaje,double CalorSensible) {
            this.IdGravNivActCalorLatente = IdGravNivActCalorLatente;
            this.ObjProyectoRoom = ObjProyectoRoom;
            this.TipoAplicacion = TipoAplicacion;
            this.Porcentaje = Porcentaje;
            this.CalorSensible = CalorSensible;
        }
        /// <summary>
        /// Id GravNivActCalorLatente
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public int IdGravNivActCalorLatente { get; set; }
        /// <summary>
        /// ObjProyectoRoom
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        //[DefaultValue(1)]
        public ProyectoRoom ObjProyectoRoom { get; set; }
        /// <summary>
        /// Tipo Aplicacion
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public string TipoAplicacion { get; set; }
        /// <summary>
        /// Porcentaje
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double Porcentaje { get; set; }
        /// <summary>
        /// Calor Sensible
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double CalorSensible { get; set; }
    }
}
