using System;
using dataSet = System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using PCL_Nomina.dao;

namespace PCL_Nomina.Reportes
{
    public class CreaXML
    {
        public static dataSet.DataSet GeneraDataSet(string query = null, string fileName = null)
        {
            daoConexion dao = new daoConexion();

            SqlConnection cxn = dao.openSql(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            SqlDataAdapter adaptador = new SqlDataAdapter(query, cxn);

            dataSet.DataSet ds = new dataSet.DataSet();

            adaptador.Fill(ds);

            if (!Directory.Exists(ConfigurationManager.AppSettings["Path"].ToString()))
            {
                Directory.CreateDirectory(ConfigurationManager.AppSettings["Path"].ToString());
            }

            string pathWithFile = string.Format(ConfigurationManager.AppSettings["Path"].ToString() + "{0}.xsd", fileName);

            if (!File.Exists(pathWithFile))
            {
                ds.WriteXmlSchema(pathWithFile);
            }

            return ds;
        }

        public static void GeneraXSD(dataSet.DataSet ds, string nombreReporte)
        {
            if (!Directory.Exists(ConfigurationManager.AppSettings["Path"].ToString()))
            {
                Directory.CreateDirectory(ConfigurationManager.AppSettings["Path"].ToString());
            }

            string pathWithFile = string.Format(ConfigurationManager.AppSettings["Path"].ToString() + "{0}.xsd", nombreReporte);

            if (!File.Exists(pathWithFile))
            {
                ds.WriteXmlSchema(pathWithFile);
            }
        }
    }
}