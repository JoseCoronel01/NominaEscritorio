using System;
using System.Collections.Generic;
using System.Text;
using PCL_Inventario.DAL;
using PCL_Inventario.Model;

namespace PCL_Inventario.BL
{
    public class MaterialBL
    {
        public IMaterialDAL materialDAL;

        public MaterialBL(IMaterialDAL material)
        {
            this.materialDAL = material;
        }

        public int Add(Material material)
        {
            return this.materialDAL.Add(material);
        }

        public int Update(Material material)
        {
            return this.materialDAL.Update(material);
        }

        public int Delete(int id)
        {
            return this.materialDAL.Delete(id);
        }

        public Material GetMaterial(int id)
        {
            return this.materialDAL.GetMaterial(id);
        }

        public List<Material> GetAll()
        {
            return this.materialDAL.GetAll();
        }
    }
}
