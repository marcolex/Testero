using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ingenya.Entities
{
    /// <summary>
    /// Prepara Mezcla
    /// </summary>
    [Serializable]
    [DataContract]
    public class PreparaMezcla: BaseEntity
    {
        public PreparaMezcla() { }

        public PreparaMezcla(int IdPreparaMezcla,ProyectoRoom ObjProyectoRoom,NombreParametro ObjNombreParametro,double MakeUpAir,double Retorno)
        {
            this.IdPreparaMezcla = IdPreparaMezcla;
            this.ObjProyectoRoom = ObjProyectoRoom;
            this.ObjNombreParametro = ObjNombreParametro;
            this.MakeUpAir = MakeUpAir;
            this.Retorno = Retorno;
        }

        /// <summary>
        /// Id PreparaMezcla
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public int IdPreparaMezcla { get; set; }
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
        //[DefaultValue(1)]
        public NombreParametro ObjNombreParametro { get; set; }
        /// <summary>
        /// MakeUpAir
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double MakeUpAir { get; set; }
        /// <summary>
        /// Retorno
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double Retorno { get; set; }
    }
}
