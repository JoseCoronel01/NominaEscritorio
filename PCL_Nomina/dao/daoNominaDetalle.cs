using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using PCL_Nomina.str;

namespace PCL_Nomina.dao
{
    public class daoNominaDetalle
    {
        public int Add(strNominaDetalle nominaDetalle)
        {
            string query = "Insert into NominaDetalle (Id,Nomina,Fecha,DiaExtra,Adelantado,Prestamo,Incentivo,Faltas,Vacaciones,Aguinaldo) values (@Id,@Nomina,@Fecha,@DiaExtra,@Adelantado,@Prestamo,@Incentivo,@Faltas,@Vacaciones,@Aguinaldo)";

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            AddParameters(cmd, nominaDetalle);

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

        public int Update(strNominaDetalle nominaDetalle)
        {
            string query = "Update NominaDetalle set Nomina=@Nomina,Fecha=@Fecha,DiaExtra=@DiaExtra,Adelantado=@Adelantado,Prestamo=@Prestamo,Incentivo=@Incentivo,Faltas=@Faltas,Vacaciones=@Vacaciones,Aguinaldo=@Aguinaldo where Id=@Id";

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            AddParameters(cmd, nominaDetalle);

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

        public int Delete(int id)
        {
            string query = "Delete from NominaDetalle where Id=@Id";

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

        public strNominaDetalle ExisteNomina(int idNomina)
        {
            string query = "Select * from NominaDetalle where Nomina=@Nomina";

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            cmd.Parameters.AddWithValue("@Nomina", idNomina);

            strNominaDetalle str = CargaStr(cmd.ExecuteReader());

            dao.closeSql();

            return str;
        }

        public List<strNominaDetalle> Nominas(string condicion = null)
        {
            string query = "Select * from NominaDetalle " + ((String.IsNullOrEmpty(condicion) == false) ?
                "where " + condicion + " order by Fecha desc" : " order by Fecha desc ");

            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlCommand cmd = new SqlCommand(query, cxn);

            List<strNominaDetalle> lista = CargaLista(cmd.ExecuteReader());

            dao.closeSql();

            return lista;
        }

        public int NuevoId()
        {
            string query = "Select Id from NominaDetalle order by Id desc";

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

        private List<strNominaDetalle> CargaLista(SqlDataReader lector)
        {
            List<strNominaDetalle> lista = null;
            while (lector != null && lector.Read())
            {
                if (lista == null) lista = new List<strNominaDetalle>();
                lista.Add(new strNominaDetalle()
                {
                    Id = int.Parse(lector["Id"].ToString()),
                    Nomina = int.Parse(lector["Nomina"].ToString()),
                    Fecha = DateTime.Parse(lector["Fecha"].ToString()),
                    DiaExtra = (lector["DiaExtra"] != DBNull.Value) ? double.Parse(lector["DiaExtra"].ToString()) : 0,
                    Adelantado = (lector["Adelantado"] != DBNull.Value) ? double.Parse(lector["Adelantado"].ToString()) : 0,
                    Prestamo = (lector["Prestamo"] != DBNull.Value) ? double.Parse(lector["Prestamo"].ToString()) : 0,
                    Incentivo = (lector["Incentivo"] != DBNull.Value) ? double.Parse(lector["Incentivo"].ToString()) : 0,
                    Faltas = (lector["Faltas"] != DBNull.Value) ? int.Parse(lector["Faltas"].ToString()) : 0,
                    Vacaciones = (lector["Vacaciones"] != DBNull.Value) ? double.Parse(lector["Vacaciones"].ToString()) : 0,
                    Aguinaldo = (lector["Aguinaldo"] != DBNull.Value) ? double.Parse(lector["Aguinaldo"].ToString()) : 0
                });
            }
            return lista;
        }

        private strNominaDetalle CargaStr(SqlDataReader lector)
        {
            strNominaDetalle str = null;
            if (lector != null && lector.Read())
            {
                str = new strNominaDetalle();
                str.Id = int.Parse(lector["Id"].ToString());
                str.Nomina = int.Parse(lector["Nomina"].ToString());
                str.Fecha = DateTime.Parse(lector["Fecha"].ToString());
                str.DiaExtra = (lector["DiaExtra"] != DBNull.Value) ? double.Parse(lector["DiaExtra"].ToString()) : 0;
                str.Adelantado = (lector["Adelantado"] != DBNull.Value) ? double.Parse(lector["Adelantado"].ToString()) : 0;
                str.Prestamo = (lector["Prestamo"] != DBNull.Value) ? double.Parse(lector["Prestamo"].ToString()) : 0;
                str.Incentivo = (lector["Incentivo"] != DBNull.Value) ? double.Parse(lector["Incentivo"].ToString()) : 0;
                str.Faltas = (lector["Faltas"] != DBNull.Value) ? int.Parse(lector["Faltas"].ToString()) : 0;
                str.Vacaciones = (lector["Vacaciones"] != DBNull.Value) ? double.Parse(lector["Vacaciones"].ToString()) : 0;
                str.Aguinaldo = (lector["Aguinaldo"] != DBNull.Value) ? double.Parse(lector["Aguinaldo"].ToString()) : 0;
            }
            return str;
        }

        private void AddParameters(SqlCommand cmd, strNominaDetalle nominaDetalle)
        {
            cmd.Parameters.AddWithValue("@Id", nominaDetalle.Id);
            cmd.Parameters.AddWithValue("@Nomina", nominaDetalle.Nomina);
            cmd.Parameters.AddWithValue("@Fecha", nominaDetalle.Fecha);
            cmd.Parameters.AddWithValue("@DiaExtra", nominaDetalle.DiaExtra);
            cmd.Parameters.AddWithValue("@Adelantado", nominaDetalle.Adelantado);
            cmd.Parameters.AddWithValue("@Prestamo", nominaDetalle.Prestamo);
            cmd.Parameters.AddWithValue("@Incentivo", nominaDetalle.Incentivo);
            cmd.Parameters.AddWithValue("@Faltas", nominaDetalle.Faltas);
            cmd.Parameters.AddWithValue("@Vacaciones", nominaDetalle.Vacaciones);
            cmd.Parameters.AddWithValue("@Aguinaldo", nominaDetalle.Aguinaldo);            
        }
    }
}