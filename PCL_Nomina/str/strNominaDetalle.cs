using System;
using System.Collections.Generic;
using System.Text;

namespace PCL_Nomina.str
{
    public class strNominaDetalle
    {
        public int Id { get; set; }
        public int Nomina { get; set; }
        public DateTime Fecha { get; set; }
        public double? DiaExtra { get; set; }
        public double? Adelantado { get; set; }
        public double? Prestamo { get; set; }
        public double? Incentivo { get; set; }
        public int? Faltas { get; set; }
        public double? Vacaciones { get; set; }
        public double? Aguinaldo { get; set; }
    }
}