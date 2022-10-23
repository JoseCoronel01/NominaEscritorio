using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using n = PCL_Nomina.Reportes;
using i = PCL_Inventario.Reportes;

namespace NominaUI
{
    public partial class frmReportes : Form
    {
        public frmReportes(string nombreDelReporte, DateTime? fecha = null, int? empleado = null)
        {
            InitializeComponent();

            if (nombreDelReporte == "NominaPorFecha")
            {
                n.rptNominaPorEmpleadoFecha cr = new n.rptNominaPorEmpleadoFecha();

                n.dsNominaPorFecha dsN = new n.dsNominaPorFecha();

                DataSet ds = new DataSet("NominaPorFecha");

                ds = dsN.PorFecha((DateTime)fecha, (int)empleado);

                n.CreaXML.GeneraXSD(ds, "NominaPorFecha");

                cr.SetDataSource(ds);

                crystalReportViewer1.ReportSource = cr;
            }
            else if (nombreDelReporte == "Inventario")
            {
                i.rptInventario cr = new i.rptInventario();

                DataSet ds = i.CreaXML.GeneraDataSet("select i.FechaEntrada, m.Nombre, m.Descripcion, " +
                    "i.FechaSalida from Material m " +
                    "inner join Inventario i on m.Id = i.IdMaterial " +
                    "order by i.FechaEntrada desc ", "Inventario");

                cr.SetDataSource(ds);

                crystalReportViewer1.ReportSource = cr;
            }
        }
    }
}
