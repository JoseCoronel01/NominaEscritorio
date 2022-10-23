
namespace NominaUI
{
    partial class frmEmpleados
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
            this.EntradaDeDatos = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpFechaI = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new TextBoxEx.CtrlTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIMSS = new TextBoxEx.CtrlTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new TextBoxEx.CtrlTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvDatosEmpleados = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscar = new TextBoxEx.CtrlTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSueldo = new TextBoxEx.CtrlTextBox();
            this.EntradaDeDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // EntradaDeDatos
            // 
            this.EntradaDeDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntradaDeDatos.Controls.Add(this.txtSueldo);
            this.EntradaDeDatos.Controls.Add(this.label6);
            this.EntradaDeDatos.Controls.Add(this.btnLimpiar);
            this.EntradaDeDatos.Controls.Add(this.btnBaja);
            this.EntradaDeDatos.Controls.Add(this.btnGuardar);
            this.EntradaDeDatos.Controls.Add(this.dtpFechaI);
            this.EntradaDeDatos.Controls.Add(this.label4);
            this.EntradaDeDatos.Controls.Add(this.txtDireccion);
            this.EntradaDeDatos.Controls.Add(this.label3);
            this.EntradaDeDatos.Controls.Add(this.txtIMSS);
            this.EntradaDeDatos.Controls.Add(this.label2);
            this.EntradaDeDatos.Controls.Add(this.txtNombre);
            this.EntradaDeDatos.Controls.Add(this.label1);
            this.EntradaDeDatos.ForeColor = System.Drawing.Color.Yellow;
            this.EntradaDeDatos.Location = new System.Drawing.Point(12, 12);
            this.EntradaDeDatos.Name = "EntradaDeDatos";
            this.EntradaDeDatos.Size = new System.Drawing.Size(776, 164);
            this.EntradaDeDatos.TabIndex = 0;
            this.EntradaDeDatos.TabStop = false;
            this.EntradaDeDatos.Text = "Entrada de Datos";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ForeColor = System.Drawing.Color.Blue;
            this.btnLimpiar.Location = new System.Drawing.Point(528, 126);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            this.btnLimpiar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLimpiar_KeyDown);
            // 
            // btnBaja
            // 
            this.btnBaja.ForeColor = System.Drawing.Color.Blue;
            this.btnBaja.Location = new System.Drawing.Point(447, 126);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 11;
            this.btnBaja.Text = "&Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            this.btnBaja.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnBaja_KeyDown);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.Color.Blue;
            this.btnGuardar.Location = new System.Drawing.Point(366, 126);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGuardar_KeyDown);
            // 
            // dtpFechaI
            // 
            this.dtpFechaI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaI.Location = new System.Drawing.Point(462, 64);
            this.dtpFechaI.Name = "dtpFechaI";
            this.dtpFechaI.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaI.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de Ingreso:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.AplicarColorFoco = true;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtDireccion.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtDireccion.Location = new System.Drawing.Point(59, 64);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(289, 20);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección:";
            // 
            // txtIMSS
            // 
            this.txtIMSS.AplicarColorFoco = true;
            this.txtIMSS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIMSS.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtIMSS.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtIMSS.Location = new System.Drawing.Point(416, 18);
            this.txtIMSS.Name = "txtIMSS";
            this.txtIMSS.Size = new System.Drawing.Size(193, 20);
            this.txtIMSS.TabIndex = 7;
            this.txtIMSS.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "IMSS:";
            // 
            // txtNombre
            // 
            this.txtNombre.AplicarColorFoco = true;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtNombre.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtNombre.Location = new System.Drawing.Point(59, 18);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(289, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // gvDatosEmpleados
            // 
            this.gvDatosEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvDatosEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDatosEmpleados.Location = new System.Drawing.Point(12, 231);
            this.gvDatosEmpleados.MultiSelect = false;
            this.gvDatosEmpleados.Name = "gvDatosEmpleados";
            this.gvDatosEmpleados.ReadOnly = true;
            this.gvDatosEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDatosEmpleados.Size = new System.Drawing.Size(776, 207);
            this.gvDatosEmpleados.TabIndex = 3;
            this.gvDatosEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDatosEmpleados_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(528, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Buscar Empleado:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.AplicarColorFoco = true;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtBuscar.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtBuscar.Location = new System.Drawing.Point(627, 208);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(161, 20);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sueldo:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.AplicarColorFoco = true;
            this.txtSueldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSueldo.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtSueldo.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtSueldo.Location = new System.Drawing.Point(59, 101);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(110, 20);
            this.txtSueldo.TabIndex = 5;
            this.txtSueldo.Tecleado = TextBoxEx.CtrlTextBox.Validar.Numeros;
            this.txtSueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gvDatosEmpleados);
            this.Controls.Add(this.EntradaDeDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.EntradaDeDatos.ResumeLayout(false);
            this.EntradaDeDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox EntradaDeDatos;
        private System.Windows.Forms.DataGridView gvDatosEmpleados;
        private System.Windows.Forms.Label label1;
        private TextBoxEx.CtrlTextBox txtNombre;
        private TextBoxEx.CtrlTextBox txtIMSS;
        private System.Windows.Forms.Label label2;
        private TextBoxEx.CtrlTextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaI;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Label label5;
        private TextBoxEx.CtrlTextBox txtBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private TextBoxEx.CtrlTextBox txtSueldo;
        private System.Windows.Forms.Label label6;
    }
}