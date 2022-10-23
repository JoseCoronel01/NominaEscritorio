using System;
using System.Collections.Generic;
using System.Text;

namespace PCL_Inventario.Model
{
    public class Inventario
    {
        public int Id { get; set; }
        public int IdMaterial { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime? FechaSalida { get; set; }
    }
}
