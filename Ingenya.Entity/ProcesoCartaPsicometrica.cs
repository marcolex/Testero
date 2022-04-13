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
    [Serializable]
    [DataContract]
    public class ProcesoCartaPsicometrica:BaseEntity
    {
        public ProcesoCartaPsicometrica() { }

        public ProcesoCartaPsicometrica(int IdProcesoCartaPsicometrica,ProyectoRoom ObjProyectoRoom,double Punto,double Dbt,double W,String Description,String Tipo)
        {
            this.IdProcesoCartaPsicometrica = IdProcesoCartaPsicometrica;
            this.ObjProyectoRoom = ObjProyectoRoom;
            this.Punto = Punto;
            this.Dbt = Dbt;
            this.W = W;
            this.Description = Description;
            this.Tipo = Tipo;
        }

        /// <summary>
        /// Id PreparaMezcla
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public int IdProcesoCartaPsicometrica { get; set; }
        /// <summary>
        /// Id PreparaMezcla
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public ProyectoRoom ObjProyectoRoom { get; set; }
        /// <summary>
        /// Id PreparaMezcla
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double Punto { get; set; }
        /// <summary>
        /// Id PreparaMezcla
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double Dbt { get; set; }
        /// <summary>
        /// Id PreparaMezcla
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double W { get; set; }
        /// <summary>
        /// Id PreparaMezcla
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public string Description { get; set; }
        /// <summary>
        /// Id PreparaMezcla
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public string Tipo { get; set; }
    }
}
