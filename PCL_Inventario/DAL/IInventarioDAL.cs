using System;
using System.Collections.Generic;
using System.Text;
using PCL_Inventario.Model;

namespace PCL_Inventario.DAL
{
    public interface IInventarioDAL
    {
        int Add(Inventario inventario);
        int Update(Inventario inventario);
        int Delete(int id);
        Inventario GetInventario(int id);
        List<Inventario> GetAll();
        List<Inventario> GetAll(DateTime delaFecha, DateTime alaFecha);
    }
}
