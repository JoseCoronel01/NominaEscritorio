using System;
using dataSet = System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace PCL_Inventario.Reportes
{
    public class CreaXML
    {
        public static dataSet.DataSet GeneraDataSet(string query = null, string fileName = null)
        {
            SqlConnection cxn = new SqlConnection(ConfigurationManager.ConnectionStrings["db2"].ConnectionString);

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
            else
            {
                File.Delete(pathWithFile);
                ds.WriteXmlSchema(pathWithFile);
            }

            return ds;
        }
    }
}