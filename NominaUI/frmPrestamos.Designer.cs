
namespace NominaUI
{
    partial class frmPrestamos
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpFechaI = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonto = new TextBoxEx.CtrlTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaldo = new TextBoxEx.CtrlTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEmpleados = new System.Windows.Forms.ComboBox();
            this.gvDatosPrestamos = new System.Windows.Forms.DataGridView();
            this.EntradaDeDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // EntradaDeDatos
            // 
            this.EntradaDeDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntradaDeDatos.Controls.Add(this.cbEmpleados);
            this.EntradaDeDatos.Controls.Add(this.btnLimpiar);
            this.EntradaDeDatos.Controls.Add(this.btnGuardar);
            this.EntradaDeDatos.Controls.Add(this.dtpFechaI);
            this.EntradaDeDatos.Controls.Add(this.label4);
            this.EntradaDeDatos.Controls.Add(this.txtMonto);
            this.EntradaDeDatos.Controls.Add(this.label3);
            this.EntradaDeDatos.Controls.Add(this.txtSaldo);
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
            // btnLimpiar
            // 
            this.btnLimpiar.ForeColor = System.Drawing.Color.Blue;
            this.btnLimpiar.Location = new System.Drawing.Point(447, 126);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            this.btnLimpiar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLimpiar_KeyDown);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.Color.Blue;
            this.btnGuardar.Location = new System.Drawing.Point(366, 126);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGuardar_KeyDown);
            // 
            // dtpFechaI
            // 
            this.dtpFechaI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaI.Location = new System.Drawing.Point(439, 64);
            this.dtpFechaI.Name = "dtpFechaI";
            this.dtpFechaI.Size = new System.Drawing.Size(98, 20);
            this.dtpFechaI.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Inicial:";
            // 
            // txtMonto
            // 
            this.txtMonto.AplicarColorFoco = true;
            this.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMonto.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtMonto.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtMonto.Location = new System.Drawing.Point(69, 64);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(279, 20);
            this.txtMonto.TabIndex = 3;
            this.txtMonto.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.AplicarColorFoco = true;
            this.txtSaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaldo.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtSaldo.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtSaldo.Location = new System.Drawing.Point(439, 18);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(170, 20);
            this.txtSaldo.TabIndex = 5;
            this.txtSaldo.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saldo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado:";
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.DisplayMember = "Nombre";
            this.cbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Location = new System.Drawing.Point(69, 19);
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(279, 21);
            this.cbEmpleados.TabIndex = 11;
            this.cbEmpleados.ValueMember = "Id";
            // 
            // gvDatosPrestamos
            // 
            this.gvDatosPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvDatosPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDatosPrestamos.Location = new System.Drawing.Point(12, 231);
            this.gvDatosPrestamos.MultiSelect = false;
            this.gvDatosPrestamos.Name = "gvDatosPrestamos";
            this.gvDatosPrestamos.ReadOnly = true;
            this.gvDatosPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDatosPrestamos.Size = new System.Drawing.Size(776, 207);
            this.gvDatosPrestamos.TabIndex = 4;
            this.gvDatosPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDatosPrestamos_CellContentClick);
            // 
            // frmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gvDatosPrestamos);
            this.Controls.Add(this.EntradaDeDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.frmPrestamos_Load);
            this.EntradaDeDatos.ResumeLayout(false);
            this.EntradaDeDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosPrestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EntradaDeDatos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtpFechaI;
        private System.Windows.Forms.Label label4;
        private TextBoxEx.CtrlTextBox txtMonto;
        private System.Windows.Forms.Label label3;
        private TextBoxEx.CtrlTextBox txtSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEmpleados;
        private System.Windows.Forms.DataGridView gvDatosPrestamos;
    }
}