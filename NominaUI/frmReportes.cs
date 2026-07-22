using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;
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
                n.dsNominaPorFecha dsN = new n.dsNominaPorFecha();

                DataSet ds = new DataSet("NominaPorFecha");

                ds = dsN.PorFecha((DateTime)fecha, (int)empleado);
                ExportarDataSetAExcel(ds, nombreDelReporte);
            }
            else if (nombreDelReporte == "Inventario")
            {
                DataSet ds = i.CreaXML.GeneraDataSet("select i.FechaEntrada, m.Nombre, m.Descripcion, " +
                    "i.FechaSalida from Material m " +
                    "inner join Inventario i on m.Id = i.IdMaterial " +
                    "order by i.FechaEntrada desc ", "Inventario");
                ExportarDataSetAExcel(ds, nombreDelReporte);
            }
        }

        private static void ExportarDataSetAExcel(DataSet ds, string nombreDelReporte)
        {
            if (ds == null || ds.Tables.Count == 0)
            {
                return;
            }

            SaveFileDialog dialogoGuardar = new SaveFileDialog();
            dialogoGuardar.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
            dialogoGuardar.FileName = string.Format("{0}.xlsx", nombreDelReporte);
            dialogoGuardar.Title = "Guardar reporte en Excel";

            if (dialogoGuardar.ShowDialog() == DialogResult.OK)
            {
                FileInfo archivo = new FileInfo(dialogoGuardar.FileName);

                using (ExcelPackage package = new ExcelPackage(archivo))
                {
                    for (int i = 0; i < ds.Tables.Count; i++)
                    {
                        DataTable table = ds.Tables[i];
                        ExcelWorksheet hoja = package.Workbook.Worksheets.Add(table.TableName ?? string.Format("Hoja{0}", i + 1));

                        for (int col = 0; col < table.Columns.Count; col++)
                        {
                            hoja.Cell(1, col + 1).Value = table.Columns[col].ColumnName;
                        }

                        for (int row = 0; row < table.Rows.Count; row++)
                        {
                            for (int col = 0; col < table.Columns.Count; col++)
                            {
                                hoja.Cell(row + 2, col + 1).Value = Convert.ToString(table.Rows[row][col]);
                            }
                        }
                    }

                    package.Save();
                }

                MessageBox.Show("El reporte se exportó correctamente a Excel.", "Exportar reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
