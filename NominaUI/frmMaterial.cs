using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCL_Inventario.BL;
using PCL_Inventario.DAL;
using PCL_Inventario.Model;

namespace NominaUI
{
    public partial class frmMaterial : Form
    {
        private bool insertando = true;
        private int idMaterial = 0;

        public frmMaterial()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            if (ValidarForma())
            {
                if (this.insertando)
                {
                    MaterialBL material = new MaterialBL(new MaterialDAL());
                    Material material1 = new Material();
                    material1.Nombre = txtNombre.Text;
                    material1.Descripcion = txtDescripcion.Text;
                    int save = material.Add(material1);
                    if (save > 0)
                    {
                        MessageBox.Show("Material Insertado Correctamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Error", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //editar material
                    MaterialBL materialBL = new MaterialBL(new MaterialDAL());
                    Material mat = materialBL.GetMaterial(this.idMaterial);
                    mat.Nombre = txtNombre.Text;
                    mat.Descripcion = txtDescripcion.Text;
                    int save = materialBL.Update(mat);
                    if (save > 0)
                    {
                        MessageBox.Show("Material Actualizado Correctamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Error", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hay Campos Vacíos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarForma()
        {
            if (txtNombre.Text != "" && txtDescripcion.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Focus();
            this.insertando = true;
            this.idMaterial = 0;
        }

        private void frmMaterial_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CargarGrid()
        {
            MaterialBL materialBL = new MaterialBL(new MaterialDAL());
            gvMaterial.DataSource = materialBL.GetAll();
            Limpiar();
        }

        private void gvMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(gvMaterial.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            string nombre = gvMaterial.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            string desc = gvMaterial.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();

            this.idMaterial = id;
            txtNombre.Text = nombre;
            txtDescripcion.Text = desc;
            txtNombre.Focus();
            this.insertando = false;
        }

        private void btnGuardar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.G)
            {
                Guardar();
            }
        }

        private void btnLimpiar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.L)
            {
                Limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar1();
        }

        private void Eliminar1()
        {
            if (MessageBox.Show("¿Esta Seguro de Eliminar este Registro? "+
                "Nota: Se Perderán los Datos Asociados a este.", this.Text, 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.idMaterial != 0)
                {
                    MaterialBL materialBL = new MaterialBL(new MaterialDAL());
                    int delete = materialBL.Delete(this.idMaterial);
                    if (delete > 0)
                    {
                        MessageBox.Show("Material Eliminado Correctamente.",
                            this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error",
                            this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Favor de Eeleccionar un Registro para Poder Eliminar.", 
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                Eliminar1();
            }
        }
    }
}
