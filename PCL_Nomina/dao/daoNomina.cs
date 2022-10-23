using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using PCL_Nomina.str;

namespace PCL_Nomina.dao
{
    public class daoNomina
    {
        public int Add(strNomina nomina)
        {
            string query = "Insert into Nomina (Id,Empleado,Sueldo) values (@Id,@Empleado,@Sueldo)";

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            AddParameters(cmd, nomina);

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

        public int Update(strNomina nomina)
        {
            string query = "Update Nomina set Sueldo=@Sueldo where Id=@Id";

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@Id", nomina.Id);
            cmd.Parameters.AddWithValue("@Sueldo", nomina.Sueldo);

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

        public strNomina Nomina(int empleado)
        {
            string query = "Select * from Nomina where Empleado=@Empleado";

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@Empleado", empleado);

            strNomina str = CargaStr(cmd.ExecuteReader());

            dao.closeSql();

            return str;
        }

        public List<strNomina> Nominas()
        {
            string query = "Select * from Nomina order by Sueldo desc";

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            List<strNomina> lista = CargaLista(cmd.ExecuteReader());

            dao.closeSql();

            return lista;
        }

        public int NuevoId()
        {
            string query = "Select Id from Nomina order by Id desc";

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

        private List<strNomina> CargaLista(SqlDataReader lector)
        {
            List<strNomina> lista = null;
            while (lector != null && lector.Read())
            {
                if (lista == null) lista = new List<strNomina>();
                lista.Add(new strNomina()
                {
                    Id = int.Parse(lector["Id"].ToString()),
                    Empleado = int.Parse(lector["Empleado"].ToString()),
                    Sueldo = double.Parse(lector["Sueldo"].ToString())
                });
            }
            return lista;
        }

        private strNomina CargaStr(SqlDataReader lector)
        {
            strNomina str = null;
            if (lector != null && lector.Read())
            {
                str = new strNomina();
                str.Id = int.Parse(lector["Id"].ToString());
                str.Empleado = int.Parse(lector["Empleado"].ToString());
                str.Sueldo = double.Parse(lector["Sueldo"].ToString());
            }
            return str;
        }

        private void AddParameters(SqlCommand cmd, strNomina nomina)
        {
            cmd.Parameters.AddWithValue("@Id", nomina.Id);
            cmd.Parameters.AddWithValue("@Empleado", nomina.Empleado);
            cmd.Parameters.AddWithValue("@Sueldo", nomina.Sueldo);
        }
    }
}