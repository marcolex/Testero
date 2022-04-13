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
    /// CartaPsicometrica
    /// </summary>
    [Serializable]
    [DataContract]
    public class CartaPsicometrica :BaseEntity
    {
        public CartaPsicometrica() { }
        public CartaPsicometrica(int IdCartaPsicometrica, ProyectoRoom ObjProyectoRoom, double Dbt, double CienPorCiento,double OchentaProCiento,double SesentaPorCiento,double CuarentaPorCiento,double VeintePorCiento,double TreintaYCientoTem,double CuarentaYCientoTem,double CincuentaYCincoTem,double SesentaYCincoTem,double SetentaYCincoTem,double OchentaYCincoTem,double NoventaYCincoTem,double CientoCincoTem,double CientoDiezTem,double CientoQuinceTem,double CientoVeinteTem,double CientoVeintiCincoTem,double CientoTreintaTem) {
            this.IdCartaPsicometrica = IdCartaPsicometrica;
            this.ObjProyectoRoom = ObjProyectoRoom;
            this.Dbt = Dbt;
            this.CienPorCiento = CienPorCiento;
            this.OchentaProCiento = OchentaProCiento;
            this.SesentaPorCiento = SesentaPorCiento;
            this.CuarentaPorCiento = CuarentaPorCiento;
            this.VeintePorCiento = VeintePorCiento;
            this.TreintaYCientoTem = TreintaYCientoTem;
            this.CuarentaYCientoTem = CuarentaYCientoTem;
            this.CincuentaYCincoTem = CincuentaYCincoTem;
            this.SesentaYCincoTem = SesentaYCincoTem;
            this.SetentaYCincoTem = SetentaYCincoTem;
            this.OchentaYCincoTem = OchentaYCincoTem;
            this.NoventaYCincoTem = NoventaYCincoTem;
            this.CientoCincoTem = CientoCincoTem;
            this.CientoDiezTem = CientoDiezTem;
            this.CientoQuinceTem = CientoQuinceTem;
            this.CientoVeinteTem = CientoVeinteTem;
            this.CientoVeintiCincoTem = CientoVeintiCincoTem;
            this.CientoTreintaTem = CientoTreintaTem;
        }

        /// <summary>
        /// Id CartaPsicometrica
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public int IdCartaPsicometrica { get; set; }
        /// <summary>
        /// ObjProyectoRoom
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        //[DefaultValue(1)]
        public ProyectoRoom ObjProyectoRoom { get; set; }
        /// <summary>
        /// Dbt
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double Dbt { get; set; }
        /// <summary>
        /// CienPorCiento
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double CienPorCiento { get; set; }
        /// <summary>
        /// OchentaProCiento
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double OchentaProCiento { get; set; }
        /// <summary>
        /// SesentaPorCiento
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double SesentaPorCiento { get; set; }
        /// <summary>
        /// CuarentaPorCiento
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double CuarentaPorCiento { get; set; }
        /// <summary>
        /// VeintePorCiento
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double VeintePorCiento { get; set; }
        /// <summary>
        /// TreintaYCientoTem
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double TreintaYCientoTem { get; set; }
        /// <summary>
        /// CuarentaYCientoTem
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double CuarentaYCientoTem { get; set; }
        /// <summary>
        /// CincuentaYCincoTem
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double CincuentaYCincoTem { get; set; }
        /// <summary>
        /// SesentaYCincoTem
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double SesentaYCincoTem { get; set; }
        /// <summary>
        /// SetentaYCincoTem
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double SetentaYCincoTem { get; set; }
        /// <summary>
        /// OchentaYCincoTem
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double OchentaYCincoTem { get; set; }
        /// <summary>
        /// NoventaYCincoTem
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double NoventaYCincoTem { get; set; }
        /// <summary>
        /// CientoCincoTem
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double CientoCincoTem { get; set; }
        /// <summary>
        /// CientoDiezTem
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double CientoDiezTem { get; set; }
        /// <summary>
        /// CientoQuinceTem
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double CientoQuinceTem { get; set; }
        /// <summary>
        /// CientoVeinteTem
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double CientoVeinteTem { get; set; }
        /// <summary>
        /// CientoVeintiCincoTem
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double CientoVeintiCincoTem { get; set; }
        /// <summary>
        /// CientoTreintaTem
        /// </summary>
        /// <example>01</example>
        [DataMember]
        [Required]
        [DefaultValue(1)]
        public double CientoTreintaTem { get; set; }
    }
}
