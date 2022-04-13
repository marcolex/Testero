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
    public class ProyectoRoom : BaseEntity
    {
        public ProyectoRoom() { }
        public ProyectoRoom(int IdProyectoRoom, Room objRoom, Proyecto objProyecto, CartaPsicometrica objCartaPsicometrica, Provedor objProvedor, ProcesoCartaPsicometrica objProcesoCartaPsicometrica, GraficoNivelActividad objGraficoNivelActividad, GraNivActCalorLatente objGraNivActCalorLatente, ConcentracionParticula objConcentracionParticula)
        {
            this.IdProyectoRoom = IdProyectoRoom;
            ObjRoom = objRoom;
            ObjProyecto = objProyecto;
            ObjCartaPsicometrica = objCartaPsicometrica;
            ObjProvedor = objProvedor;
            ObjProcesoCartaPsicometrica = objProcesoCartaPsicometrica;
            ObjGraficoNivelActividad = objGraficoNivelActividad;
            ObjGraNivActCalorLatente = objGraNivActCalorLatente;
            ObjConcentracionParticula = objConcentracionParticula;
        }

        public int IdProyectoRoom { get; set; }
        public Room ObjRoom { get; set; }
        public Proyecto ObjProyecto { get; set; }
        public CartaPsicometrica ObjCartaPsicometrica { get; set; }
        public Provedor ObjProvedor { get; set; }
        public ProcesoCartaPsicometrica ObjProcesoCartaPsicometrica { get; set; }
        public GraficoNivelActividad ObjGraficoNivelActividad { get; set; }
        public GraNivActCalorLatente ObjGraNivActCalorLatente { get; set; }
        public ConcentracionParticula ObjConcentracionParticula { get; set; }
    }
}
