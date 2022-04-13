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
    /// Parametro
    /// </summary>
    [Serializable]
    [DataContract]
    public class Parametro:BaseEntity
    {
        public Parametro() { }

        public Parametro(int IdParametro,NombreParametro ObjNombreParametro,double Valor,int Editable,DateTime Fecha)
        {
            this.IdParametro = IdParametro;
            this.ObjNombreParametro = ObjNombreParametro;
            this.Valor = Valor;
            this.Editable = Editable;
            this.Fecha = Fecha;
        }

        /// <summary>
        /// Id Parametro
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public int IdParametro { get; set; }
        /// <summary>
        /// ObjNombreParametro
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        //[DefaultValue(1)]
        public NombreParametro ObjNombreParametro { get; set; }
        /// <summary>
        /// Valor
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double Valor { get; set; }
        /// <summary>
        /// Editable
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        //[DefaultValue(1)]
        public int Editable { get; set; }
        /// <summary>
        /// Fecha
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        //[DefaultValue(1)]
        public DateTime Fecha { get; set; }
    }
}
