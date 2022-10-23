using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace PCL_Nomina.dao
{
    public class daoConexion
    {
        private SqlConnection sql = null;

        public SqlConnection openSql(string stringCxn)
        {
            try
            {
                sql = new SqlConnection(stringCxn);

                sql.Open();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexion a la base de datos. " + ex.Message);
            }
            finally
            {
            }
            return sql;
        }

        public void closeSql()
        {
            if (sql != null)
            {
                sql.Close();
                sql.Dispose();
            }
        }
    }
}