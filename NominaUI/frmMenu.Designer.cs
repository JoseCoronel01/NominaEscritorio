
namespace NominaUI
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nomina = new System.Windows.Forms.ToolStripMenuItem();
            this.empleados = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.regnomina = new System.Windows.Forms.ToolStripMenuItem();
            this.nominaPorEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.salir = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.material = new System.Windows.Forms.ToolStripMenuItem();
            this.inventario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomina,
            this.gestiónInventarioToolStripMenuItem,
            this.salir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nomina
            // 
            this.nomina.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleados,
            this.prestamos,
            this.regnomina,
            this.nominaPorEmpleado});
            this.nomina.Name = "nomina";
            this.nomina.Size = new System.Drawing.Size(62, 20);
            this.nomina.Text = "Nomina";
            // 
            // empleados
            // 
            this.empleados.Name = "empleados";
            this.empleados.Size = new System.Drawing.Size(194, 22);
            this.empleados.Text = "Empleados";
            this.empleados.Click += new System.EventHandler(this.empleados_Click);
            // 
            // prestamos
            // 
            this.prestamos.Name = "prestamos";
            this.prestamos.Size = new System.Drawing.Size(194, 22);
            this.prestamos.Text = "Prestamos";
            this.prestamos.Click += new System.EventHandler(this.prestamos_Click);
            // 
            // regnomina
            // 
            this.regnomina.Name = "regnomina";
            this.regnomina.Size = new System.Drawing.Size(194, 22);
            this.regnomina.Text = "Registrar Nomina";
            this.regnomina.Click += new System.EventHandler(this.regnomina_Click);
            // 
            // nominaPorEmpleado
            // 
            this.nominaPorEmpleado.Name = "nominaPorEmpleado";
            this.nominaPorEmpleado.Size = new System.Drawing.Size(194, 22);
            this.nominaPorEmpleado.Text = "Nomina Por Empleado";
            this.nominaPorEmpleado.Click += new System.EventHandler(this.nominaPorEmpleado_Click);
            // 
            // salir
            // 
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(41, 20);
            this.salir.Text = "&Salir";
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // gestiónInventarioToolStripMenuItem
            // 
            this.gestiónInventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.material,
            this.inventario});
            this.gestiónInventarioToolStripMenuItem.Name = "gestiónInventarioToolStripMenuItem";
            this.gestiónInventarioToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.gestiónInventarioToolStripMenuItem.Text = "Gestión Inventario";
            // 
            // material
            // 
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(180, 22);
            this.material.Text = "Material";
            this.material.Click += new System.EventHandler(this.material_Click);
            // 
            // inventario
            // 
            this.inventario.Name = "inventario";
            this.inventario.Size = new System.Drawing.Size(180, 22);
            this.inventario.Text = "Inventario";
            this.inventario.Click += new System.EventHandler(this.inventario_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Nomina";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nomina;
        private System.Windows.Forms.ToolStripMenuItem empleados;
        private System.Windows.Forms.ToolStripMenuItem prestamos;
        private System.Windows.Forms.ToolStripMenuItem regnomina;
        private System.Windows.Forms.ToolStripMenuItem salir;
        private System.Windows.Forms.ToolStripMenuItem nominaPorEmpleado;
        private System.Windows.Forms.ToolStripMenuItem gestiónInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem material;
        private System.Windows.Forms.ToolStripMenuItem inventario;
    }
}