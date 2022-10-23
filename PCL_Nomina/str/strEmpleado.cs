using System;
using System.Collections.Generic;
using System.Text;

namespace PCL_Nomina.str
{
    public class strEmpleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public byte Baja { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string IMSS { get; set; }
        public string Direccion { get; set; }

        public override string ToString()
        {
            return this.Id + ": " + this.Nombre + " " + ((this.Baja == 0) ? "[Alta]" : "[Baja]");
        }
    }
}