using System;
using System.Collections.Generic;
using System.Text;
using PCL_Inventario.Model;
using PCL_Inventario.DAL;

namespace PCL_Inventario.BL
{
    public class InventarioBL
    {
        public IInventarioDAL inventarioDAL;

        public InventarioBL(IInventarioDAL inventario)
        {
            this.inventarioDAL = inventario;
        }

        public int Add(Inventario inventario)
        {
            return this.inventarioDAL.Add(inventario);
        }

        public int Update(Inventario inventario)
        {
            return this.inventarioDAL.Update(inventario);
        }

        public int Delete(int id)
        {
            return this.inventarioDAL.Delete(id);
        }

        public Inventario GetInventario(int id)
        {
            return this.inventarioDAL.GetInventario(id);
        }

        public List<Inventario> GetAll()
        {
            return this.inventarioDAL.GetAll();
        }

        public List<Inventario> GetAll(DateTime delaFecha, DateTime alaFecha)
        {
            return this.inventarioDAL.GetAll(delaFecha, alaFecha);
        }
    }
}
