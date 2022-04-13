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
    /// ConcentracionParticula
    /// </summary>
    [Serializable]
    [DataContract]
    public class ConcentracionParticula :BaseEntity
    {
        public ConcentracionParticula() { }

        public ConcentracionParticula(int IdConcentracionParticula,ProyectoRoom ObjProyectoRoom, string Tiempo,double ConcenPartiIni,double ConcenPartiGen,double PartiIni,double PartiRetorna,double PartiFin,double ConcenPartiFin,double ConceIncome)
        {
            this.IdConcentracionParticula = IdConcentracionParticula;
            this.ObjProyectoRoom = ObjProyectoRoom;
            this.Tiempo = Tiempo;
            this.ConcenPartiIni = ConcenPartiIni;
            this.ConcenPartiGen = ConcenPartiGen;
            this.PartiIni = PartiIni;
            this.PartiRetorna = PartiRetorna;
            this.PartiFin = PartiFin;
            this.ConcenPartiFin = ConcenPartiFin;
            this.ConceIncome = ConceIncome;
        }
        /// <summary>
        /// Id ConcentracionParticula
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public int IdConcentracionParticula { get; set; }
        /// <summary>
        /// ObjProyectoRoom
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        //[DefaultValue(1)]
        public ProyectoRoom ObjProyectoRoom { get; set; }
        /// <summary>
        /// Tiempo
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        //[DefaultValue(1)]
        public string Tiempo { get; set; }
        /// <summary>
        /// ConcenPartiIni
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double ConcenPartiIni { get; set; }
        /// <summary>
        /// ConcenPartiGen
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double ConcenPartiGen { get; set; }
        /// <summary>
        /// PartiIni
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double PartiIni { get; set; }
        /// <summary>
        /// PartiRetorna
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double PartiRetorna { get; set; }
        /// <summary>
        /// PartiFin
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double PartiFin { get; set; }
        /// <summary>
        /// ConcenPartiFin
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double ConcenPartiFin { get; set; }
        /// <summary>
        /// ConceIncome
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double ConceIncome { get; set; }

        
    }
}
