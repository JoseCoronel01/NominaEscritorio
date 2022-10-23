using System;
using System.Collections.Generic;
using System.Text;
using PCL_Inventario.Model;

namespace PCL_Inventario.DAL
{
    public interface IMaterialDAL
    {
        int Add(Material material);
        int Update(Material material);
        int Delete(int id);
        Material GetMaterial(int id);
        List<Material> GetAll();
    }
}
