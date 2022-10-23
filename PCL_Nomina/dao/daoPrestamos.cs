using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using PCL_Nomina.str;

namespace PCL_Nomina.dao
{
    public class daoPrestamos
    {
        public int Add(strPrestamos prestamos)
        {
            string query = "Insert into Prestamos (Id,FechaI,Monto,Saldo,Empleado) values (@Id,@FechaI,@Monto,@Saldo,@Empleado)";

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            AddParameters(cmd, prestamos);

            int save = cmd.ExecuteNonQuery();

            if (save > 0)
            {
                cmd.Dispose();
                dao.closeSql();
                return save;
            }
            else
                return save;
        }

        public int UpdateSaldo(int Id, double Saldo)
        {
            string query = "Update Prestamos set Saldo=@Saldo where Id=@Id";

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Saldo", Saldo);

            int save = cmd.ExecuteNonQuery();

            if (save > 0)
            {
                cmd.Dispose();
                dao.closeSql();
                return save;
            }
            else
                return save;
        }

        public int Update(strPrestamos str)
        {
            string query = "Update Prestamos set Monto=@Monto, Saldo=@Saldo where Id=@Id";

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@Id", str.Id);
            cmd.Parameters.AddWithValue("@Monto", str.Monto);
            cmd.Parameters.AddWithValue("@Saldo", str.Saldo);

            int save = cmd.ExecuteNonQuery();

            if (save > 0)
            {
                cmd.Dispose();
                dao.closeSql();
                return save;
            }
            else
                return save;
        }

        public strPrestamos ExistePrestamo(int idEmpleado)
        {
            string query = "Select * from Prestamos where Empleado=@Empleado";

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@Empleado", idEmpleado);

            strPrestamos str = CargaStr(cmd.ExecuteReader());

            dao.closeSql();

            return str;
        }

        public strPrestamos Prestamo(int id)
        {
            string query = "Select * from Prestamos where Id=@Id";

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@Id", id);

            strPrestamos str = CargaStr(cmd.ExecuteReader());

            dao.closeSql();

            return str;
        }

        public strPrestamos PrestamoActivo(int Empleado)
        {
            string query = "Select * from Prestamos where Empleado=@Empleado AND Saldo > 0 ";

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@Empleado", Empleado);

            strPrestamos str = CargaStr(cmd.ExecuteReader());

            dao.closeSql();

            return str;
        }

        public List<strPrestamos> Prestamos(string condicion = null)
        {
            string query = "Select * from Prestamos " +
                ((String.IsNullOrEmpty(condicion) == false) ? "where " + condicion + " order by FechaI desc" :
                " order by FechaI desc");

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            List<strPrestamos> lista = CargaLista(cmd.ExecuteReader());

            dao.closeSql();

            return lista;
        }

        private List<strPrestamos> CargaLista(SqlDataReader lector)
        {
            List<strPrestamos> lista = null;
            while (lector != null && lector.Read())
            {
                if (lista == null) lista = new List<strPrestamos>();
                lista.Add(new strPrestamos()
                {
                    Id = int.Parse(lector["Id"].ToString()),
                    FechaI = DateTime.Parse(lector["FechaI"].ToString()),
                    Monto = double.Parse(lector["Monto"].ToString()),
                    Saldo = double.Parse(lector["Saldo"].ToString()),
                    Empleado = int.Parse(lector["Empleado"].ToString())
                });
            }
            return lista;
        }

        private strPrestamos CargaStr(SqlDataReader lector)
        {
            strPrestamos str = null;
            if (lector != null && lector.Read())
            {
                str = new strPrestamos();
                str.Id = int.Parse(lector["Id"].ToString());
                str.FechaI = DateTime.Parse(lector["FechaI"].ToString());
                str.Monto = double.Parse(lector["Monto"].ToString());
                str.Saldo = double.Parse(lector["Saldo"].ToString());
                str.Empleado = int.Parse(lector["Empleado"].ToString());
            }
            return str;
        }

        private void AddParameters(SqlCommand cmd, strPrestamos prestamos)
        {
            cmd.Parameters.AddWithValue("@Id", prestamos.Id);
            cmd.Parameters.AddWithValue("@FechaI", prestamos.FechaI);
            cmd.Parameters.AddWithValue("@Monto", prestamos.Monto);
            cmd.Parameters.AddWithValue("@Saldo", prestamos.Saldo);
            cmd.Parameters.AddWithValue("@Empleado", prestamos.Empleado);
        }

        public int NuevoId()
        {
            string query = "Select Id from Prestamos order by Id desc";

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            int id = 0;

            SqlDataReader lector = cmd.ExecuteReader();

            if (lector != null && lector.Read())
            {
                id = int.Parse(lector["Id"].ToString());

                id = id + 1;
            }
            else
                id = 1;

            dao.closeSql();

            return id;
        }
    }
}