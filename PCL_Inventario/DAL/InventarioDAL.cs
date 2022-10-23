using PCL_Inventario.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace PCL_Inventario.DAL
{
    public class InventarioDAL : IInventarioDAL
    {
        private string CadenaConexion;

        public InventarioDAL()
        {
            this.CadenaConexion = ConfigurationManager.ConnectionStrings["db2"].ConnectionString;
        }

        public int Add(Inventario inventario)
        {
            int save = 0;

            using (var db = new SqlConnection(this.CadenaConexion))
            {
                string nuevoId = "Select Id From Inventario order by Id desc";
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

                string query = "Insert into Inventario (Id,IdMaterial,FechaEntrada) values (@Id,@IdMaterial,@FechaEntrada)";
                var cmd2 = new SqlCommand(query, db);
                inventario.Id = id;
                cmd2.Parameters.AddWithValue("@Id", inventario.Id);
                cmd2.Parameters.AddWithValue("@IdMaterial", inventario.IdMaterial);
                cmd2.Parameters.AddWithValue("@FechaEntrada", inventario.FechaEntrada);
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
                string query = "Delete from Inventario where Id=@Id ";
                db.Open();
                var cmd2 = new SqlCommand(query, db);
                cmd2.Parameters.AddWithValue("@Id", id);
                save = cmd2.ExecuteNonQuery();
                cmd2.Dispose();
                db.Close();
            }

            return save;
        }

        public List<Inventario> GetAll()
        {
            List<Inventario> lista = new List<Inventario>();

            using (var db = new SqlConnection(this.CadenaConexion))
            {
                string query = "Select * From Inventario order by FechaEntrada desc ";
                db.Open();
                var cmd = new SqlCommand(query, db);
                var lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new Inventario()
                    {
                        Id = int.Parse(lector["Id"].ToString()),
                        IdMaterial = int.Parse(lector["IdMaterial"].ToString()),
                        FechaEntrada = DateTime.Parse(lector["FechaEntrada"].ToString()),
                        FechaSalida = (lector["FechaSalida"] != DBNull.Value) ? DateTime.Parse(lector["FechaSalida"].ToString()) : DateTime.MinValue,
                    });
                }
                if (lector != null)
                    lector.Close();
                cmd.Dispose();
                db.Close();
            }

            return lista;
        }

        public List<Inventario> GetAll(DateTime delaFecha, DateTime alaFecha)
        {
            List<Inventario> lista = null;

            using (var db = new SqlConnection(this.CadenaConexion))
            {
                string query = "Select * From Inventario where " +
                    "(FechaEntrada >= CONVERT(date, '" + delaFecha.ToString("yyyy/MM/dd") + "') " +
                    "and FechaSalida <= CONVERT(date, '" + alaFecha.ToString("yyyy/MM/dd") + "')) or FechaSalida Is Null " +
                    "order by FechaEntrada desc ";
                db.Open();
                var cmd = new SqlCommand(query, db);
                var lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    if (lista == null) lista = new List<Inventario>();
                    lista.Add(new Inventario()
                    {
                        Id = int.Parse(lector["Id"].ToString()),
                        IdMaterial = int.Parse(lector["IdMaterial"].ToString()),
                        FechaEntrada = DateTime.Parse(lector["FechaEntrada"].ToString()),
                        FechaSalida = (lector["FechaSalida"] != DBNull.Value) ? DateTime.Parse(lector["FechaSalida"].ToString()) : DateTime.MinValue,
                    });
                }
                if (lector != null)
                    lector.Close();
                cmd.Dispose();
                db.Close();
            }

            return lista;
        }

        public Inventario GetInventario(int id)
        {
            Inventario inventario = new Inventario();

            using (var db = new SqlConnection(this.CadenaConexion))
            {
                string query = "Select * From Inventario where Id=@Id ";
                db.Open();
                var cmd = new SqlCommand(query, db);
                cmd.Parameters.AddWithValue("@Id", id);
                var lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    inventario.Id = int.Parse(lector["Id"].ToString());
                    inventario.IdMaterial = int.Parse(lector["IdMaterial"].ToString());
                    inventario.FechaEntrada = DateTime.Parse(lector["FechaEntrada"].ToString());
                    inventario.FechaSalida = (lector["FechaSalida"] != DBNull.Value) ? DateTime.Parse(lector["FechaSalida"].ToString()) : DateTime.MinValue;
                }
                if (lector != null)
                    lector.Close();
                cmd.Dispose();
                db.Close();
            }

            return inventario;
        }

        public int Update(Inventario inventario)
        {
            int save = 0;

            using (var db = new SqlConnection(this.CadenaConexion))
            {
                string query = "Update Inventario set FechaSalida=@FechaSalida where Id=@Id ";
                db.Open();
                var cmd2 = new SqlCommand(query, db);
                cmd2.Parameters.AddWithValue("@Id", inventario.Id);
                //cmd2.Parameters.AddWithValue("@IdMaterial", inventario.IdMaterial);
                //cmd2.Parameters.AddWithValue("@FechaEntrada", inventario.FechaEntrada);
                if (inventario.FechaSalida != null)
                    cmd2.Parameters.AddWithValue("@FechaSalida", inventario.FechaSalida);
                save = cmd2.ExecuteNonQuery();
                cmd2.Dispose();
                db.Close();
            }

            return save;
        }
    }
}
