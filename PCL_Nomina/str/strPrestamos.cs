using System;
using System.Collections.Generic;
using System.Text;

namespace PCL_Nomina.str
{
    public class strPrestamos
    {
        public int Id { get; set; }
        public DateTime FechaI { get; set; }
        public double Monto { get; set; }
        public double Saldo { get; set; }
        public int Empleado { get; set; }
    }
}