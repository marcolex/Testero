using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Ingenya.Entities
{
    [Serializable]
    [DataContract]
    public class ProyectoParametro : BaseEntity
    {
        public ProyectoParametro() { }

        public ProyectoParametro(int IdProyectoParametro,ProyectoRoom ObjProyectoRoom, Parametro ObjParametro, double Valor)
        {
            this.IdProyectoParametro = IdProyectoParametro;
            this.ObjProyectoRoom = ObjProyectoRoom;
            this.ObjParametro = ObjParametro;
            this.Valor = Valor;
        }

        public int IdProyectoParametro { get; set; }
        public ProyectoRoom ObjProyectoRoom { get; set; }
        public Parametro ObjParametro { get; set; }
        public double Valor { get; set; }
    }
}
