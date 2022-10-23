using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCL_Inventario.Model;
using PCL_Inventario.BL;
using PCL_Inventario.DAL;

namespace NominaUI
{
    public partial class frmInventario : Form
    {
        private bool insertando = true;
        private int idInventario = 0;

        public frmInventario()
        {
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            MaterialBL materialBL = new MaterialBL(new MaterialDAL());
            cbMaterial.DataSource = materialBL.GetAll();

            dtpFechaSalida.Value = DateTime.Now.AddYears(200);

            CargarGrid();
        }

        private void CargarGrid()
        {
            InventarioBL inventarioBL = new InventarioBL(new InventarioDAL());
            gvInventario.DataSource = inventarioBL.GetAll();
            Limpiar();
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
                    InventarioBL inventarioBL = new InventarioBL(new InventarioDAL());
                    int save = inventarioBL.Add(new Inventario()
                    {
                        IdMaterial = int.Parse(cbMaterial.SelectedValue.ToString()),
                        FechaEntrada = dtpFechaEntrada.Value,
                        FechaSalida = dtpFechaSalida.Value
                    });
                    if (save > 0)
                    {
                        MessageBox.Show("Inventario Insertado Correctamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Error", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //editar inventario
                    InventarioBL inventarioBL = new InventarioBL(new InventarioDAL());
                    int save = inventarioBL.Update(new Inventario()
                    {
                        Id = this.idInventario,
                        IdMaterial = int.Parse(cbMaterial.SelectedValue.ToString()),
                        FechaEntrada = dtpFechaEntrada.Value,
                        FechaSalida = dtpFechaSalida.Value
                    });
                    if (save > 0)
                    {
                        MessageBox.Show("Inventario Actualizado Correctamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Datos Inválidos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarForma()
        {
            if (cbMaterial.SelectedValue != null && dtpFechaEntrada.Value < dtpFechaSalida.Value && dtpFechaEntrada.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnGuardar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.G)
            {
                Guardar();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            cbMaterial.SelectedIndex = -1;
            dtpFechaEntrada.Value = DateTime.Now;
            dtpFechaSalida.Value = DateTime.Now.AddYears(200);
            cbMaterial.Focus();
            this.insertando = true;
            this.idInventario = 0;
        }

        private void btnLimpiar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.L)
            {
                Limpiar();
            }
        }

        private void gvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idInventario = int.Parse(gvInventario.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            int idM = int.Parse(gvInventario.Rows[e.RowIndex].Cells["IdMaterial"].Value.ToString());
            DateTime FE = DateTime.Parse(gvInventario.Rows[e.RowIndex].Cells["FechaEntrada"].Value.ToString());
            DateTime FS = DateTime.Parse(gvInventario.Rows[e.RowIndex].Cells["FechaSalida"].Value.ToString());
            this.insertando = false;
            cbMaterial.SelectedValue = idM;
            dtpFechaEntrada.Value = FE;
            try
            {
                dtpFechaSalida.Value = FS;
            }
            catch 
            {
                dtpFechaSalida.Value = DateTime.Now.AddYears(200);
            }
            finally { }
        }

        private void btnPreliminar_Click(object sender, EventArgs e)
        {
            frmReportes frm = new frmReportes("Inventario");
            frm.Show();
        }
    }
}
