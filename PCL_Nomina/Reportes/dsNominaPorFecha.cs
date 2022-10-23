using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace PCL_Nomina.Reportes
{
    public class dsNominaPorFecha
    {
        public DataSet PorFecha(DateTime fecha)
        {
            string query = "select e.Nombre, nd.Fecha, " +
                "((n.Sueldo + ((nd.DiaExtra + nd.Incentivo) - (nd.Adelantado + nd.Prestamo))) - " +
                "((n.Sueldo / 6) * (nd.Faltas)) + nd.Vacaciones + nd.Aguinaldo) as Total " +
                           "from Nomina n " +
                           "inner " +
                           "join NominaDetalle nd on nd.Nomina = n.Id " +
                           "left " +
                           "join Empleado e on e.Id = n.Empleado " +
                           "where nd.Fecha = '" + fecha.ToString("yyyy/MM/dd") + "'";

            SqlConnection cxn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            SqlDataAdapter ad = new SqlDataAdapter(query, cxn);
            DataSet ds = new DataSet("NominaPorFecha");
            ad.Fill(ds);
            return ds;
        }

        public DataSet PorFecha(DateTime fecha, int IdEmp)
        {
            string query = "select e.Nombre, nd.Fecha, n.Sueldo, nd.DiaExtra, nd.Incentivo, nd.Adelantado, nd.Prestamo, SUM(p.Saldo) as SaldoPrestamo, " +
                            "nd.Faltas, nd.Vacaciones, nd.Aguinaldo, " +
                            "((n.Sueldo + ((nd.DiaExtra + nd.Incentivo) - (nd.Adelantado + nd.Prestamo))) - " +
                            "((n.Sueldo / 6) * (nd.Faltas)) + nd.Vacaciones + nd.Aguinaldo) as Total " +
                            "from Nomina n " +
                            "inner " +
                            "join NominaDetalle nd on nd.Nomina = n.Id " +
                            "left " +
                            "join Empleado e on e.Id = n.Empleado " +
                            "inner " +
                            "join Prestamos p on p.Empleado = e.Id " +
                            "where nd.Fecha >= CONVERT(datetime, '" +
                            fecha.ToString("yyyy/MM/dd") + " 00:00:00.000') AND " +
                            "nd.Fecha <= CONVERT(datetime, '" + fecha.ToString("yyyy/MM/dd") + " 23:59:59.999') " +
                            "AND n.Empleado = " + IdEmp + " " +
                            "Group by e.Nombre, nd.Fecha, n.Sueldo, nd.DiaExtra, nd.Incentivo, nd.Adelantado, nd.Prestamo, p.Saldo, nd.Faltas, nd.Vacaciones, nd.Aguinaldo " +
                            "; ";

            SqlConnection cxn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            SqlDataAdapter ad = new SqlDataAdapter(query, cxn);
            DataSet ds = new DataSet("NominaPorFecha");
            ad.Fill(ds);
            return ds;
        }
    }
}