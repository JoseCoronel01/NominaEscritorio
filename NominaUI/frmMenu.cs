using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominaUI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void empleados_Click(object sender, EventArgs e)
        {
            frmEmpleados frm = new frmEmpleados();
            frm.ShowDialog();
        }

        private void prestamos_Click(object sender, EventArgs e)
        {
            frmPrestamos frm = new frmPrestamos();
            frm.ShowDialog();
        }

        private void regnomina_Click(object sender, EventArgs e)
        {
            frmRegNomina frm = new frmRegNomina();
            frm.ShowDialog();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nominaPorEmpleado_Click(object sender, EventArgs e)
        {
            frmNominaPorEmpleado frm = new frmNominaPorEmpleado();
            frm.ShowDialog();
        }

        private void material_Click(object sender, EventArgs e)
        {
            frmMaterial frm = new frmMaterial();
            frm.ShowDialog();
        }

        private void inventario_Click(object sender, EventArgs e)
        {
            frmInventario frm = new frmInventario();
            frm.ShowDialog();
        }
    }
}
