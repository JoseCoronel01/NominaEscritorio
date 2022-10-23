using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCL_Nomina.dao;
using PCL_Nomina.Reportes;

namespace NominaUI
{
    public partial class frmNominaPorEmpleado : Form
    {
        public frmNominaPorEmpleado()
        {
            InitializeComponent();
        }

        private void btnPreliminar_Click(object sender, EventArgs e)
        {
            frmReportes frm = new frmReportes("NominaPorFecha", dtpFecha.Value, 
                int.Parse(cbEmpleado.SelectedValue.ToString()));
            frm.Show();
        }

        private void frmNominaPorEmpleado_Load(object sender, EventArgs e)
        {
            daoEmpleado dao = new daoEmpleado();
            cbEmpleado.DataSource = dao.Empleados("Baja=0");
        }

        private void chboxEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxEmpleado.Checked)
            {
                daoEmpleado dao = new daoEmpleado();
                cbEmpleado.DataSource = dao.Empleados();
            }
            else
            {
                daoEmpleado dao = new daoEmpleado();
                cbEmpleado.DataSource = dao.Empleados("Baja=0");
            }
        }
    }
}
