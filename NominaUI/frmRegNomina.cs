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
    public partial class frmRegNomina : Form
    {
        private int idPrestamo = 0;
        private int idNominaDetalle = 0;

        public frmRegNomina()
        {
            InitializeComponent();
        }

        private void cbNomina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNomina.SelectedValue != null)
            {
                daoEmpleado dao = new daoEmpleado();
                var obj = dao.Empleado(int.Parse(cbNomina.Text));
                if (obj != null)
                {
                    txtEmpleado.Text = obj.Nombre;
                    CargarPrestamos(obj.Id);

                    int idn = int.Parse(cbNomina.SelectedValue.ToString());

                    CargarGridDatos(idn);
                }
                else
                {
                    txtEmpleado.Text = "";
                }
            }
        }

        private void CargarPrestamos(int idEmp)
        {
            daoPrestamos dao1 = new daoPrestamos();
            gvDatosPrestamos.DataSource = dao1.Prestamos("Empleado = " + idEmp + "");
        }

        private void CargarGridDatos(int idNomina)
        {
            daoNominaDetalle dao2 = new daoNominaDetalle();
            gvDatos.DataSource = dao2.Nominas("Nomina = " + idNomina + "");
            LimpiarDatos();
        }

        private void frmRegNomina_Load(object sender, EventArgs e)
        {
            daoNomina dao = new daoNomina();
            cbNomina.DataSource = dao.Nominas();
            LimpiarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            if (ValidarForma())
            {
                strNominaDetalle str = new strNominaDetalle();
                daoNominaDetalle dao = new daoNominaDetalle();
                str.Id = dao.NuevoId();
                str.Adelantado = double.Parse(txtAdelantado.Text);
                str.Aguinaldo = double.Parse(txtAguinaldo.Text);
                str.DiaExtra = double.Parse(txtDiaExtra.Text);
                str.Faltas = int.Parse(txtFaltas.Text);
                str.Fecha = dtpFecha.Value;
                str.Incentivo = double.Parse(txtIncentivo.Text);
                str.Nomina = int.Parse(cbNomina.SelectedValue.ToString());
                str.Prestamo = double.Parse(txtPrestamo.Text);
                str.Vacaciones = double.Parse(txtVacaciones.Text);
                int save = dao.Add(str);
                if (save > 0)
                {
                    daoPrestamos dao1 = new daoPrestamos();
                    var p = dao1.Prestamo(idPrestamo);
                    if (p != null)
                    {
                        double? saldo = p.Saldo - str.Prestamo;
                        dao1.UpdateSaldo(idPrestamo, (double)saldo);
                    }

                    MessageBox.Show("Registro de Nomina Satisfactoriamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPrestamos(int.Parse(cbNomina.Text));
                    CargarGridDatos(str.Nomina);
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

        private void LimpiarDatos()
        {
            txtAdelantado.Text = "0";
            txtAguinaldo.Text = "0";
            txtDiaExtra.Text = "0";
            txtFaltas.Text = "0";
            txtIncentivo.Text = "0";
            txtPrestamo.Text = "0";
            txtVacaciones.Text = "0";
            cbNomina.Focus();
            idPrestamo = 0;
            dtpFecha.Text = "";
        }

        private bool ValidarForma()
        {
            if (txtAdelantado.Text != "" && txtAguinaldo.Text != "" && txtDiaExtra.Text != "" &&
                txtFaltas.Text != "" && txtIncentivo.Text != "" && txtPrestamo.Text != "" &&
                txtVacaciones.Text != "" && dtpFecha.Text != "" && cbNomina.SelectedValue != null && 
                idPrestamo != 0)
            {
                return true;
            }
            else
            {
                if (gvDatosPrestamos.Rows.Count == 0)
                    return true;
                else
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
            LimpiarDatos();
        }

        private void btnLimpiar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.L)
            {
                LimpiarDatos();
            }
        }

        private void gvDatosPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(gvDatosPrestamos.Rows[e.RowIndex].Cells["Id"].Value.ToString());

            daoPrestamos dao = new daoPrestamos();

            txtPrestamo.Text = dao.Prestamo(id).Saldo.ToString();

            idPrestamo = id;

            MessageBox.Show("Ha Seleccionado el prestamo con Id " + idPrestamo, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnEliminar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                Eliminar();
            }
        }

        private void Eliminar()
        {
            if (MessageBox.Show("¿Esta Seguro de Eliminar este Registro con Id " + idNominaDetalle + "?",
                this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (idPrestamo != 0 && idNominaDetalle != 0)
                {
                    daoPrestamos dao_ = new daoPrestamos();

                    var obj = dao_.Prestamo(idPrestamo);

                    daoNominaDetalle dao = new daoNominaDetalle();

                    daoNomina dao1 = new daoNomina();

                    var nom = dao1.Nomina(obj.Empleado);

                    var nd = dao.ExisteNomina(nom.Id);

                    double? sal = obj.Saldo + nd.Prestamo;

                    int save1 = dao_.UpdateSaldo(obj.Id, (double)sal);

                    if (save1 > 0)
                    {
                        MessageBox.Show("Saldo Actualizado Correctamente.", this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        int save2 = dao.Delete(idNominaDetalle);

                        if (save2 > 0)
                        {
                            MessageBox.Show("Registro Eliminado Satisfactoriamente.", this.Text,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarPrestamos(int.Parse(cbNomina.Text));
                            CargarGridDatos(nom.Id);
                            idNominaDetalle = 0;
                            idPrestamo = 0;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Favor de Seleccionar el Prestamo y el registro de nomina ha eliminar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(gvDatos.Rows[e.RowIndex].Cells["Id"].Value.ToString());

            idNominaDetalle = id;

            MessageBox.Show("Ha Seleccionado el Id detalle: " + idNominaDetalle, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
