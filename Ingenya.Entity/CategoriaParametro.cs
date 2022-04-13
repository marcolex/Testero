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
    public class CategoriaParametro : BaseEntity
    {
        public CategoriaParametro() { }

        public CategoriaParametro(int IdCategoriaParametro, SubCategoriaParametro ObjSubCategoriaParametro,String Nombre)
        {
            this.IdCategoriaParametro = IdCategoriaParametro;
            this.ObjSubCategoriaParametro = ObjSubCategoriaParametro;
            this.Nombre = Nombre;
        }

        /// <summary>
        /// Id Categoria Parametro
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public int IdCategoriaParametro { get; set; }
        /// <summary>
        /// ObjSubCategoriaParametro
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        //[DefaultValue(1)]
        public SubCategoriaParametro ObjSubCategoriaParametro { get; set; }
        /// <summary>
        /// Nombre
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        //[DefaultValue(1)]
        public string Nombre { get; set; }
    }
}
