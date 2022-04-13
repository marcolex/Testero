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
    /// Fuga
    /// </summary>
    [Serializable]
    [DataContract]
    public class Fuga:BaseEntity
    {
        public Fuga() { }

        public Fuga(int IdFuga,ProyectoRoom ObjProyectoRoom, NombreParametro ObjNombreParametro, double Cantidad,double Area,double Factor,double Flow)
        {
            this.IdFuga = IdFuga;
            this.ObjProyectoRoom = ObjProyectoRoom;
            this.ObjNombreParametro = ObjNombreParametro;
            this.Cantidad = Cantidad;
            this.Area = Area;
            this.Factor = Factor;
            this.Flow = Flow;
        }
        /// <summary>
        /// Id Fuga
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public int IdFuga { get; set; }
        /// <summary>
        /// ObjProyectoRoom
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        //[DefaultValue(1)]
        public ProyectoRoom ObjProyectoRoom { get; set; }
        /// <summary>
        /// ObjNombreParametro
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public NombreParametro ObjNombreParametro { get; set; }
        /// <summary>
        /// Cantidad
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double Cantidad { get; set; }
        /// <summary>
        /// Area
        /// </summary>
        /// <example>01</example>
        [DataMember]
        //[Required]
        //[DefaultValue(1)]
        public double Area { get; set; }
        /// <summary>
        /// Factor
        /// </summary>
        /// <example>01</example>
        [DataMember]
        //[Required]
        [DefaultValue(1)]
        public double Factor { get; set; }
        /// <summary>
        /// Flow
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double Flow { get; set; }
    }
}
