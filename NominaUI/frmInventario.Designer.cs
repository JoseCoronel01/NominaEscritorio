
namespace NominaUI
{
    partial class frmInventario
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
            this.gbEDatos = new System.Windows.Forms.GroupBox();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gvInventario = new System.Windows.Forms.DataGridView();
            this.btnPreliminar = new System.Windows.Forms.Button();
            this.gbEDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEDatos
            // 
            this.gbEDatos.Controls.Add(this.dtpFechaSalida);
            this.gbEDatos.Controls.Add(this.label3);
            this.gbEDatos.Controls.Add(this.dtpFechaEntrada);
            this.gbEDatos.Controls.Add(this.cbMaterial);
            this.gbEDatos.Controls.Add(this.btnLimpiar);
            this.gbEDatos.Controls.Add(this.btnGuardar);
            this.gbEDatos.Controls.Add(this.label2);
            this.gbEDatos.Controls.Add(this.label1);
            this.gbEDatos.ForeColor = System.Drawing.Color.Yellow;
            this.gbEDatos.Location = new System.Drawing.Point(12, 12);
            this.gbEDatos.Name = "gbEDatos";
            this.gbEDatos.Size = new System.Drawing.Size(618, 162);
            this.gbEDatos.TabIndex = 1;
            this.gbEDatos.TabStop = false;
            this.gbEDatos.Text = "Entrada de Datos";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSalida.Location = new System.Drawing.Point(450, 86);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaSalida.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha de Salida:";
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrada.Location = new System.Drawing.Point(181, 88);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaEntrada.TabIndex = 7;
            // 
            // cbMaterial
            // 
            this.cbMaterial.DisplayMember = "Nombre";
            this.cbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(181, 34);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(380, 21);
            this.cbMaterial.TabIndex = 6;
            this.cbMaterial.ValueMember = "Id";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(475, 133);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(86, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            this.btnLimpiar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLimpiar_KeyDown);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(383, 133);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGuardar_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Material:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de Entrada:";
            // 
            // gvInventario
            // 
            this.gvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvInventario.Location = new System.Drawing.Point(12, 212);
            this.gvInventario.MultiSelect = false;
            this.gvInventario.Name = "gvInventario";
            this.gvInventario.ReadOnly = true;
            this.gvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvInventario.Size = new System.Drawing.Size(618, 204);
            this.gvInventario.TabIndex = 2;
            this.gvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvInventario_CellContentClick);
            // 
            // btnPreliminar
            // 
            this.btnPreliminar.ForeColor = System.Drawing.Color.Black;
            this.btnPreliminar.Location = new System.Drawing.Point(544, 183);
            this.btnPreliminar.Name = "btnPreliminar";
            this.btnPreliminar.Size = new System.Drawing.Size(86, 23);
            this.btnPreliminar.TabIndex = 5;
            this.btnPreliminar.Text = "&Preliminar";
            this.btnPreliminar.UseVisualStyleBackColor = true;
            this.btnPreliminar.Click += new System.EventHandler(this.btnPreliminar_Click);
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(642, 428);
            this.Controls.Add(this.btnPreliminar);
            this.Controls.Add(this.gvInventario);
            this.Controls.Add(this.gbEDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            this.gbEDatos.ResumeLayout(false);
            this.gbEDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEDatos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.DataGridView gvInventario;
        private System.Windows.Forms.Button btnPreliminar;
    }
}