using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCL_Nomina.str;
using PCL_Nomina.dao;

namespace NominaUI
{
    public partial class frmPrestamos : Form
    {
        private bool insertando = true;
        private strPrestamos prestamo = new strPrestamos();

        public frmPrestamos()
        {
            InitializeComponent();
        }

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            daoEmpleado dao = new daoEmpleado();
            cbEmpleados.DataSource = dao.Empleados("Baja=0");

            CargarGrid();
        }

        private void CargarGrid()
        {
            daoPrestamos dao = new daoPrestamos();
            gvDatosPrestamos.DataSource = dao.Prestamos();
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            if (ValidarForm() && this.insertando)
            {
                strPrestamos str = new strPrestamos();
                daoPrestamos dao = new daoPrestamos();
                str.Id = dao.NuevoId();
                str.Empleado = int.Parse(cbEmpleados.SelectedValue.ToString());
                str.FechaI = dtpFechaI.Value;
                str.Monto = double.Parse(txtMonto.Text);
                str.Saldo = str.Monto;
                int save = dao.Add(str);
                if (save > 0)
                {
                    MessageBox.Show("Prestamo registrado con éxito.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("Error.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Datos Inválidos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarForm()
        {
            if (cbEmpleados.SelectedValue != null && txtMonto.Text != "" && dtpFechaI.Text != "")
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
            txtMonto.Text = "";
            txtSaldo.Text = "";
            dtpFechaI.Text = "";
            cbEmpleados.SelectedIndex = -1;
            cbEmpleados.Focus();
            this.insertando = true;
        }

        private void btnLimpiar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.L)
            {
                Limpiar();
            }
        }

        private void gvDatosPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prestamo.Empleado = int.Parse(gvDatosPrestamos.Rows[e.RowIndex].Cells["Empleado"].Value.ToString());
            prestamo.FechaI = DateTime.Parse(gvDatosPrestamos.Rows[e.RowIndex].Cells["FechaI"].Value.ToString());
            prestamo.Monto = double.Parse(gvDatosPrestamos.Rows[e.RowIndex].Cells["Monto"].Value.ToString());
            prestamo.Saldo = double.Parse(gvDatosPrestamos.Rows[e.RowIndex].Cells["Saldo"].Value.ToString());
            prestamo.Id = int.Parse(gvDatosPrestamos.Rows[e.RowIndex].Cells["Id"].Value.ToString());

            MostrarDatos(prestamo);

            this.insertando = false;
        }

        private void MostrarDatos(strPrestamos prestamo)
        {
            txtMonto.Text = prestamo.Monto.ToString();
            txtSaldo.Text = prestamo.Saldo.ToString();
            dtpFechaI.Value = prestamo.FechaI;
            cbEmpleados.SelectedValue = prestamo.Empleado;
        }
    }
}
