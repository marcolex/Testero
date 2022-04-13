using Ingenya.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.Entities
{
    [Serializable]
    [DataContract]
    public class Bitacora : BaseEntity
    {
        public Bitacora() { }

        public Bitacora(int IdBitacora, DateTime Fecha, byte[] Entrada, byte[] Salida)
        {
            this.IdBitacora = IdBitacora;
            this.Fecha = Fecha;
            this.Entrada = Entrada;
            this.Salida = Salida;
        }

        public int IdBitacora { get; set; }

        public DateTime Fecha { get; set; }
        public byte[] Entrada { get; set; }
        public byte[] Salida { get; set; }
    }
}
