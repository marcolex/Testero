using System;

namespace Ingenya.Entities
{
    public class ImagenesCalculo: BaseEntity
    {
        public ImagenesCalculo() { }

        public ImagenesCalculo(int IdImagenesCalculo, ProyectoRoom ObjProyectoRoom, String Nombre, byte[]  Imagen)
        {
            this.IdImagenesCalculo = IdImagenesCalculo;
            this.ObjProyectoRoom = ObjProyectoRoom;
            this.Nombre = Nombre;
            this.Imagen = Imagen;
        }

        public int IdImagenesCalculo { get; set; }
        public ProyectoRoom ObjProyectoRoom { get; set; }
        public string Nombre { get; set; }
        public byte[] Imagen { get; set; }
    }
}
