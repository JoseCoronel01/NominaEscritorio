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
    public partial class frmEmpleados : Form
    {
        private bool insertando = true;
        private strEmpleado empleado = new strEmpleado();

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            CargarGrid();            
        }

        private void CargarGrid()
        {
            daoEmpleado dao = new daoEmpleado();
            gvDatosEmpleados.DataSource = dao.Empleados();
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            if (ValidarForm())
            {
                if (this.insertando)
                {
                    strEmpleado str = new strEmpleado();
                    daoEmpleado dao = new daoEmpleado();
                    str.Id = dao.NuevoId();
                    str.Nombre = txtNombre.Text;
                    str.Direccion = txtDireccion.Text;
                    str.IMSS = txtIMSS.Text;
                    str.Baja = 0;
                    str.FechaIngreso = dtpFechaI.Value;
                    int save = dao.Add(str);
                    if (save > 0)
                    {
                        strNomina nomina = new strNomina();
                        daoNomina dao1 = new daoNomina();
                        nomina.Id = dao1.NuevoId();
                        nomina.Empleado = str.Id;
                        nomina.Sueldo = double.Parse(txtSueldo.Text);
                        dao1.Add(nomina);

                        MessageBox.Show("Registro Insertado Satisfactoriamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Error", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //editar registro
                    strEmpleado str = new strEmpleado();
                    daoEmpleado dao = new daoEmpleado();
                    str = dao.Empleado(empleado.Id);
                    if (str != null)
                    {
                        str.Nombre = txtNombre.Text;
                        str.Direccion = txtDireccion.Text;
                        str.IMSS = txtIMSS.Text;
                        str.FechaIngreso = dtpFechaI.Value;
                        int save = dao.Update(str);
                        if (save > 0)
                        {
                            strNomina nomina = new strNomina();
                            daoNomina dao1 = new daoNomina();
                            nomina.Id = dao1.Nomina(str.Id).Id;
                            nomina.Empleado = str.Id;
                            nomina.Sueldo = double.Parse(txtSueldo.Text);
                            dao1.Update(nomina);

                            MessageBox.Show("Registro Actualizado Satisfactoriamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarGrid();
                        }
                        else
                        {
                            MessageBox.Show("Error", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error, Empleado no existe. Favor de seleccionar el Registro que se desee modificar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por llenar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarForm()
        {
            if (txtNombre.Text != "" && txtDireccion.Text != "" && txtIMSS.Text != "" && dtpFechaI.Text != "" && txtSueldo.Text != "")
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

        private void gvDatosEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            empleado.Baja = byte.Parse(gvDatosEmpleados.Rows[e.RowIndex].Cells["Baja"].Value.ToString());
            empleado.Direccion = gvDatosEmpleados.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
            empleado.FechaIngreso = DateTime.Parse(gvDatosEmpleados.Rows[e.RowIndex].Cells["FechaIngreso"].Value.ToString());
            empleado.Id = int.Parse(gvDatosEmpleados.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            empleado.IMSS = gvDatosEmpleados.Rows[e.RowIndex].Cells["IMSS"].Value.ToString();
            empleado.Nombre = gvDatosEmpleados.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

            MostrarDatos(empleado);

            this.insertando = false;
        }

        private void MostrarDatos(strEmpleado empleado)
        {
            txtNombre.Text = empleado.Nombre;
            txtIMSS.Text = empleado.IMSS;
            txtDireccion.Text = empleado.Direccion;
            dtpFechaI.Value = empleado.FechaIngreso;
            daoNomina dao = new daoNomina();
            txtSueldo.Text = dao.Nomina(empleado.Id).Sueldo.ToString();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Baja();
        }

        private void Baja()
        {
            strEmpleado str = new strEmpleado();
            daoEmpleado dao = new daoEmpleado();
            str = dao.Empleado(empleado.Id);
            if (str != null)
            {
                if (str.Baja == 0)
                {
                    str.Baja = 1;
                    int save = dao.Baja(str);
                    if (save > 0)
                    {
                        MessageBox.Show("Empleado Dado de Baja Satisfactoriamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Error", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (MessageBox.Show("¿Desea Revocar la Baja al Empleado "+str.Nombre+"?", this.Text, 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        str.Baja = 0;
                        int save = dao.Baja(str);
                        if (save > 0)
                        {
                            MessageBox.Show("Se Revoco la Baja de "+str.Nombre+" Satisfactoriamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarGrid();
                        }
                        else
                        {
                            MessageBox.Show("Error", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Error, Empleado no existe. Favor de seleccionar el Registro que se desee modificar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBaja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B)
            {
                Baja();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            this.insertando = true;
            txtNombre.Text = "";
            txtIMSS.Text = "";
            txtDireccion.Text = "";
            txtBuscar.Text = "";
            dtpFechaI.Text = "";
            txtSueldo.Text = "";
            txtNombre.Focus();
        }

        private void btnLimpiar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.L)
            {
                Limpiar();
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            daoEmpleado dao = new daoEmpleado();
            List<strEmpleado> lista = dao.Empleados("Nombre like '%" + txtBuscar.Text + "%' or Nombre like '%" + txtBuscar.Text + "' or Nombre like '" + txtBuscar.Text + "%'");
            gvDatosEmpleados.DataSource = lista;
        }
    }
}
