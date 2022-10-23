using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using PCL_Nomina.str;

namespace PCL_Nomina.dao
{
    public class daoEmpleado
    {
        public int Add(strEmpleado empleado)
        {
            string query = "Insert into Empleado (Id,Nombre,Periodicidad,Baja,FechaIngreso,IMSS,Direccion) values (@Id,@Nombre,1,0,@FechaIngreso,@IMSS,@Direccion)";

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            AddParameters(cmd, empleado);

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

        public int Update(strEmpleado empleado)
        {
            string query = "Update Empleado set Nombre=@Nombre,FechaIngreso=@FechaIngreso,IMSS=@IMSS,Direccion=@Direccion where Id=@Id";

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            AddParameters(cmd, empleado);

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

        public int Eliminar(int id)
        {
            string query = "Delete from Empleado where Id=@Id";

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@Id", id);

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

        public int Baja(strEmpleado empleado)
        {
            string query = "Update Empleado set Baja=@Baja where Id=@Id";

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@Id", empleado.Id);
            cmd.Parameters.AddWithValue("@Baja", empleado.Baja);

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

        public strEmpleado Empleado(int id)
        {
            string query = "Select Id,Nombre,Baja,FechaIngreso,IMSS,Direccion from Empleado where Id=@Id";

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@Id", id);

            strEmpleado str = CargaStr(cmd.ExecuteReader());

            dao.closeSql();

            return str;
        }

        public List<strEmpleado> Empleados(string condicion = null)
        {
            string query = "Select Id,Nombre,Baja,FechaIngreso,IMSS,Direccion from Empleado " +
                ((String.IsNullOrEmpty(condicion) == false) ? "where " + condicion + " order by Id asc" :
                " order by Id asc");

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            List<strEmpleado> lista = CargaLista(cmd.ExecuteReader());

            dao.closeSql();

            return lista;
        }

        private List<strEmpleado> CargaLista(SqlDataReader lector)
        {
            List<strEmpleado> lista = null;
            while (lector != null && lector.Read())
            {
                if (lista == null) lista = new List<strEmpleado>();
                lista.Add(new strEmpleado()
                {
                    Id = int.Parse(lector["Id"].ToString()),
                    Nombre = lector["Nombre"].ToString(),
                    Baja = byte.Parse(lector["Baja"].ToString()),
                    FechaIngreso = (lector["FechaIngreso"] != DBNull.Value) ? DateTime.Parse(lector["FechaIngreso"].ToString()) : DateTime.MinValue,
                    IMSS = lector["IMSS"].ToString(),
                    Direccion = lector["Direccion"].ToString()
                });
            }
            return lista;
        }

        private strEmpleado CargaStr(SqlDataReader lector)
        {
            strEmpleado str = null;
            if (lector != null && lector.Read())
            {
                str = new strEmpleado();
                str.Id = int.Parse(lector["Id"].ToString());
                str.Nombre = lector["Nombre"].ToString();
                str.Baja = byte.Parse(lector["Baja"].ToString());
                str.FechaIngreso = (lector["FechaIngreso"] != DBNull.Value) ? DateTime.Parse(lector["FechaIngreso"].ToString()) : DateTime.MinValue;
                str.IMSS = lector["IMSS"].ToString();
                str.Direccion = lector["Direccion"].ToString();
            }
            return str;
        }

        private void AddParameters(SqlCommand cmd, strEmpleado empleado)
        {
            cmd.Parameters.AddWithValue("@Id", empleado.Id);
            cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
            cmd.Parameters.AddWithValue("@FechaIngreso", empleado.FechaIngreso);
            cmd.Parameters.AddWithValue("@IMSS", empleado.IMSS);
            cmd.Parameters.AddWithValue("@Direccion", empleado.Direccion);
        }

        public int NuevoId()
        {
            string query = "Select Id from Empleado order by Id desc";

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