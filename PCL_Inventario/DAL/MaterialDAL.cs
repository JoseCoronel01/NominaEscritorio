using PCL_Inventario.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace PCL_Inventario.DAL
{
    public class MaterialDAL : IMaterialDAL
    {
        private string CadenaConexion;

        public MaterialDAL()
        {
            this.CadenaConexion = ConfigurationManager.ConnectionStrings["db2"].ConnectionString;
        }

        public int Add(Material material)
        {
            int save = 0;

            using (var db = new SqlConnection(this.CadenaConexion))
            {
                string nuevoId = "Select Id From Material order by Id desc";
                db.Open();
                var cmd = new SqlCommand(nuevoId, db);
                var lector = cmd.ExecuteReader();
                int id = -1;
                if (lector.Read())
                {
                    id = lector.GetInt32(0);
                    id = id + 1;
                }
                else
                    id = 1;
                if (lector != null)
                    lector.Close();
                cmd.Dispose();

                string query = "Insert into Material (Id,Nombre,Descripcion) values (@Id,@Nombre,@Descripcion)";
                var cmd2 = new SqlCommand(query, db);
                material.Id = id;
                cmd2.Parameters.AddWithValue("@Id", material.Id);
                cmd2.Parameters.AddWithValue("@Nombre", material.Nombre);
                cmd2.Parameters.AddWithValue("@Descripcion", material.Descripcion);
                save = cmd2.ExecuteNonQuery();
                cmd2.Dispose();
                db.Close();
            }

            return save;
        }

        public int Delete(int id)
        {
            int save = 0;

            using (var db = new SqlConnection(this.CadenaConexion))
            {
                string query = "Delete from Material where Id=@Id ";
                db.Open();
                var cmd2 = new SqlCommand(query, db);
                cmd2.Parameters.AddWithValue("@Id", id);
                save = cmd2.ExecuteNonQuery();
                cmd2.Dispose();
                db.Close();
            }

            return save;
        }

        public List<Material> GetAll()
        {
            List<Material> lista = new List<Material>();

            using (var db = new SqlConnection(this.CadenaConexion))
            {
                string query = "Select * From Material order by Nombre asc ";
                db.Open();
                var cmd = new SqlCommand(query, db);
                var lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new Material()
                    {
                        Id = int.Parse(lector["Id"].ToString()),
                        Nombre = lector["Nombre"].ToString(),
                        Descripcion = lector["Descripcion"].ToString()
                    });
                }
                if (lector != null)
                    lector.Close();
                cmd.Dispose();
                db.Close();
            }

            return lista;
        }

        public Material GetMaterial(int id)
        {
            Material material = new Material();

            using (var db = new SqlConnection(this.CadenaConexion))
            {
                string query = "Select * From Material where Id=@Id ";
                db.Open();
                var cmd = new SqlCommand(query, db);
                cmd.Parameters.AddWithValue("@Id", id);
                var lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    material.Id = int.Parse(lector["Id"].ToString());
                    material.Nombre = lector["Nombre"].ToString();
                    material.Descripcion = lector["Descripcion"].ToString();
                }
                if (lector != null)
                    lector.Close();
                cmd.Dispose();
                db.Close();
            }

            return material;
        }

        public int Update(Material material)
        {
            int save = 0;

            using (var db = new SqlConnection(this.CadenaConexion))
            {
                string query = "Update Material set Nombre=@Nombre,Descripcion=@Descripcion where Id=@Id ";
                db.Open();
                var cmd2 = new SqlCommand(query, db);
                cmd2.Parameters.AddWithValue("@Id", material.Id);
                cmd2.Parameters.AddWithValue("@Nombre", material.Nombre);
                cmd2.Parameters.AddWithValue("@Descripcion", material.Descripcion);
                save = cmd2.ExecuteNonQuery();
                cmd2.Dispose();
                db.Close();
            }

            return save;
        }
    }
}
