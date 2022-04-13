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
    public class Proyecto : BaseEntity
    {
        public Proyecto() { }
        public Proyecto(int IdProyecto, Cliente ObjClient, string NombreProyecto, string Zona, DateTime Fecha) {
            this.IdProyecto = IdProyecto;
            this.ObjClient = ObjClient;
            this.NombreProyecto = NombreProyecto;
            this.Zona = Zona;
            this.Fecha = Fecha;
        }

        public int IdProyecto { get; set; }
        public Cliente ObjClient { get; set; }
        public string NombreProyecto { get; set; }
        public string Zona { get; set; }
        public DateTime Fecha { get; set; }

    }
}
