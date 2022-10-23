
namespace NominaUI
{
    partial class frmRegNomina
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
            this.txtAguinaldo = new TextBoxEx.CtrlTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVacaciones = new TextBoxEx.CtrlTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFaltas = new TextBoxEx.CtrlTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIncentivo = new TextBoxEx.CtrlTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdelantado = new TextBoxEx.CtrlTextBox();
            this.txtDiaExtra = new TextBoxEx.CtrlTextBox();
            this.txtEmpleado = new TextBoxEx.CtrlTextBox();
            this.cbNomina = new System.Windows.Forms.ComboBox();
            this.txtPrestamo = new TextBoxEx.CtrlTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gvDatos = new System.Windows.Forms.DataGridView();
            this.gvDatosPrestamos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.EntradaDeDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // EntradaDeDatos
            // 
            this.EntradaDeDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntradaDeDatos.Controls.Add(this.txtAguinaldo);
            this.EntradaDeDatos.Controls.Add(this.label9);
            this.EntradaDeDatos.Controls.Add(this.txtVacaciones);
            this.EntradaDeDatos.Controls.Add(this.label8);
            this.EntradaDeDatos.Controls.Add(this.txtFaltas);
            this.EntradaDeDatos.Controls.Add(this.label7);
            this.EntradaDeDatos.Controls.Add(this.txtIncentivo);
            this.EntradaDeDatos.Controls.Add(this.label5);
            this.EntradaDeDatos.Controls.Add(this.txtAdelantado);
            this.EntradaDeDatos.Controls.Add(this.txtDiaExtra);
            this.EntradaDeDatos.Controls.Add(this.txtEmpleado);
            this.EntradaDeDatos.Controls.Add(this.cbNomina);
            this.EntradaDeDatos.Controls.Add(this.txtPrestamo);
            this.EntradaDeDatos.Controls.Add(this.label6);
            this.EntradaDeDatos.Controls.Add(this.btnLimpiar);
            this.EntradaDeDatos.Controls.Add(this.btnGuardar);
            this.EntradaDeDatos.Controls.Add(this.dtpFecha);
            this.EntradaDeDatos.Controls.Add(this.label4);
            this.EntradaDeDatos.Controls.Add(this.label3);
            this.EntradaDeDatos.Controls.Add(this.label2);
            this.EntradaDeDatos.Controls.Add(this.label1);
            this.EntradaDeDatos.ForeColor = System.Drawing.Color.Yellow;
            this.EntradaDeDatos.Location = new System.Drawing.Point(12, 12);
            this.EntradaDeDatos.Name = "EntradaDeDatos";
            this.EntradaDeDatos.Size = new System.Drawing.Size(776, 164);
            this.EntradaDeDatos.TabIndex = 1;
            this.EntradaDeDatos.TabStop = false;
            this.EntradaDeDatos.Text = "Entrada de Datos";
            // 
            // txtAguinaldo
            // 
            this.txtAguinaldo.AplicarColorFoco = true;
            this.txtAguinaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAguinaldo.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtAguinaldo.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtAguinaldo.Location = new System.Drawing.Point(638, 68);
            this.txtAguinaldo.Name = "txtAguinaldo";
            this.txtAguinaldo.Size = new System.Drawing.Size(110, 20);
            this.txtAguinaldo.TabIndex = 24;
            this.txtAguinaldo.Tecleado = TextBoxEx.CtrlTextBox.Validar.Numeros;
            this.txtAguinaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(575, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Aguinaldo:";
            // 
            // txtVacaciones
            // 
            this.txtVacaciones.AplicarColorFoco = true;
            this.txtVacaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVacaciones.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtVacaciones.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtVacaciones.Location = new System.Drawing.Point(447, 68);
            this.txtVacaciones.Name = "txtVacaciones";
            this.txtVacaciones.Size = new System.Drawing.Size(110, 20);
            this.txtVacaciones.TabIndex = 22;
            this.txtVacaciones.Tecleado = TextBoxEx.CtrlTextBox.Validar.Numeros;
            this.txtVacaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Vacaciones:";
            // 
            // txtFaltas
            // 
            this.txtFaltas.AplicarColorFoco = true;
            this.txtFaltas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFaltas.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtFaltas.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtFaltas.Location = new System.Drawing.Point(250, 68);
            this.txtFaltas.Name = "txtFaltas";
            this.txtFaltas.Size = new System.Drawing.Size(110, 20);
            this.txtFaltas.TabIndex = 20;
            this.txtFaltas.Tecleado = TextBoxEx.CtrlTextBox.Validar.Numeros;
            this.txtFaltas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Faltas:";
            // 
            // txtIncentivo
            // 
            this.txtIncentivo.AplicarColorFoco = true;
            this.txtIncentivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIncentivo.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtIncentivo.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtIncentivo.Location = new System.Drawing.Point(66, 104);
            this.txtIncentivo.Name = "txtIncentivo";
            this.txtIncentivo.Size = new System.Drawing.Size(110, 20);
            this.txtIncentivo.TabIndex = 18;
            this.txtIncentivo.Tecleado = TextBoxEx.CtrlTextBox.Validar.Numeros;
            this.txtIncentivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Incentivo:";
            // 
            // txtAdelantado
            // 
            this.txtAdelantado.AplicarColorFoco = true;
            this.txtAdelantado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdelantado.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtAdelantado.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtAdelantado.Location = new System.Drawing.Point(628, 22);
            this.txtAdelantado.Name = "txtAdelantado";
            this.txtAdelantado.Size = new System.Drawing.Size(110, 20);
            this.txtAdelantado.TabIndex = 16;
            this.txtAdelantado.Tecleado = TextBoxEx.CtrlTextBox.Validar.Numeros;
            this.txtAdelantado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiaExtra
            // 
            this.txtDiaExtra.AplicarColorFoco = true;
            this.txtDiaExtra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDiaExtra.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtDiaExtra.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtDiaExtra.Location = new System.Drawing.Point(424, 22);
            this.txtDiaExtra.Name = "txtDiaExtra";
            this.txtDiaExtra.Size = new System.Drawing.Size(110, 20);
            this.txtDiaExtra.TabIndex = 15;
            this.txtDiaExtra.Tecleado = TextBoxEx.CtrlTextBox.Validar.Numeros;
            this.txtDiaExtra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.AplicarColorFoco = true;
            this.txtEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpleado.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtEmpleado.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtEmpleado.Location = new System.Drawing.Point(118, 23);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.ReadOnly = true;
            this.txtEmpleado.Size = new System.Drawing.Size(230, 20);
            this.txtEmpleado.TabIndex = 14;
            this.txtEmpleado.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // cbNomina
            // 
            this.cbNomina.DisplayMember = "Empleado";
            this.cbNomina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNomina.FormattingEnabled = true;
            this.cbNomina.Location = new System.Drawing.Point(59, 22);
            this.cbNomina.Name = "cbNomina";
            this.cbNomina.Size = new System.Drawing.Size(53, 21);
            this.cbNomina.TabIndex = 13;
            this.cbNomina.ValueMember = "Id";
            this.cbNomina.SelectedIndexChanged += new System.EventHandler(this.cbNomina_SelectedIndexChanged);
            // 
            // txtPrestamo
            // 
            this.txtPrestamo.AplicarColorFoco = true;
            this.txtPrestamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrestamo.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtPrestamo.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtPrestamo.Location = new System.Drawing.Point(66, 68);
            this.txtPrestamo.Name = "txtPrestamo";
            this.txtPrestamo.Size = new System.Drawing.Size(110, 20);
            this.txtPrestamo.TabIndex = 5;
            this.txtPrestamo.Tecleado = TextBoxEx.CtrlTextBox.Validar.Numeros;
            this.txtPrestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Prestamo:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ForeColor = System.Drawing.Color.Blue;
            this.btnLimpiar.Location = new System.Drawing.Point(673, 126);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            this.btnLimpiar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLimpiar_KeyDown);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.Color.Blue;
            this.btnGuardar.Location = new System.Drawing.Point(592, 126);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGuardar_KeyDown);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(251, 104);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(97, 20);
            this.dtpFecha.TabIndex = 9;
            this.dtpFecha.Value = new System.DateTime(2021, 3, 25, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adelantado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Día Extra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nomina:";
            // 
            // gvDatos
            // 
            this.gvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDatos.Location = new System.Drawing.Point(12, 271);
            this.gvDatos.MultiSelect = false;
            this.gvDatos.Name = "gvDatos";
            this.gvDatos.ReadOnly = true;
            this.gvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDatos.Size = new System.Drawing.Size(776, 167);
            this.gvDatos.TabIndex = 4;
            this.gvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDatos_CellContentClick);
            // 
            // gvDatosPrestamos
            // 
            this.gvDatosPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvDatosPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDatosPrestamos.Location = new System.Drawing.Point(12, 182);
            this.gvDatosPrestamos.MultiSelect = false;
            this.gvDatosPrestamos.Name = "gvDatosPrestamos";
            this.gvDatosPrestamos.ReadOnly = true;
            this.gvDatosPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDatosPrestamos.Size = new System.Drawing.Size(479, 83);
            this.gvDatosPrestamos.TabIndex = 5;
            this.gvDatosPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDatosPrestamos_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Blue;
            this.btnEliminar.Location = new System.Drawing.Point(713, 242);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnEliminar_KeyDown);
            // 
            // frmRegNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gvDatosPrestamos);
            this.Controls.Add(this.gvDatos);
            this.Controls.Add(this.EntradaDeDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Nomina";
            this.Load += new System.EventHandler(this.frmRegNomina_Load);
            this.EntradaDeDatos.ResumeLayout(false);
            this.EntradaDeDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosPrestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EntradaDeDatos;
        private TextBoxEx.CtrlTextBox txtPrestamo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNomina;
        private TextBoxEx.CtrlTextBox txtEmpleado;
        private TextBoxEx.CtrlTextBox txtDiaExtra;
        private TextBoxEx.CtrlTextBox txtAdelantado;
        private System.Windows.Forms.Label label5;
        private TextBoxEx.CtrlTextBox txtIncentivo;
        private TextBoxEx.CtrlTextBox txtFaltas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private TextBoxEx.CtrlTextBox txtVacaciones;
        private System.Windows.Forms.Label label9;
        private TextBoxEx.CtrlTextBox txtAguinaldo;
        private System.Windows.Forms.DataGridView gvDatos;
        private System.Windows.Forms.DataGridView gvDatosPrestamos;
        private System.Windows.Forms.Button btnEliminar;
    }
}