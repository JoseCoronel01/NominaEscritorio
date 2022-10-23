
namespace NominaUI
{
    partial class frmMaterial
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDescripcion = new TextBoxEx.CtrlTextBox();
            this.txtNombre = new TextBoxEx.CtrlTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gvMaterial = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.Button();
            this.gbEDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEDatos
            // 
            this.gbEDatos.Controls.Add(this.Eliminar);
            this.gbEDatos.Controls.Add(this.btnLimpiar);
            this.gbEDatos.Controls.Add(this.btnGuardar);
            this.gbEDatos.Controls.Add(this.txtDescripcion);
            this.gbEDatos.Controls.Add(this.txtNombre);
            this.gbEDatos.Controls.Add(this.label2);
            this.gbEDatos.Controls.Add(this.label1);
            this.gbEDatos.ForeColor = System.Drawing.Color.Yellow;
            this.gbEDatos.Location = new System.Drawing.Point(12, 12);
            this.gbEDatos.Name = "gbEDatos";
            this.gbEDatos.Size = new System.Drawing.Size(596, 151);
            this.gbEDatos.TabIndex = 0;
            this.gbEDatos.TabStop = false;
            this.gbEDatos.Text = "Entrada de Datos";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(394, 122);
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
            this.btnGuardar.Location = new System.Drawing.Point(302, 122);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGuardar_KeyDown);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AplicarColorFoco = true;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtDescripcion.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtDescripcion.Location = new System.Drawing.Point(149, 88);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(412, 20);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // txtNombre
            // 
            this.txtNombre.AplicarColorFoco = true;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtNombre.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtNombre.Location = new System.Drawing.Point(149, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(267, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción:";
            // 
            // gvMaterial
            // 
            this.gvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMaterial.Location = new System.Drawing.Point(12, 169);
            this.gvMaterial.MultiSelect = false;
            this.gvMaterial.Name = "gvMaterial";
            this.gvMaterial.ReadOnly = true;
            this.gvMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMaterial.Size = new System.Drawing.Size(596, 162);
            this.gvMaterial.TabIndex = 1;
            this.gvMaterial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMaterial_CellContentClick);
            // 
            // btnEliminar
            // 
            this.Eliminar.ForeColor = System.Drawing.Color.Black;
            this.Eliminar.Location = new System.Drawing.Point(486, 122);
            this.Eliminar.Name = "btnEliminar";
            this.Eliminar.Size = new System.Drawing.Size(86, 23);
            this.Eliminar.TabIndex = 6;
            this.Eliminar.Text = "&Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.Eliminar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnEliminar_KeyDown);
            // 
            // frmMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(620, 343);
            this.Controls.Add(this.gvMaterial);
            this.Controls.Add(this.gbEDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Material";
            this.Load += new System.EventHandler(this.frmMaterial_Load);
            this.gbEDatos.ResumeLayout(false);
            this.gbEDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TextBoxEx.CtrlTextBox txtDescripcion;
        private TextBoxEx.CtrlTextBox txtNombre;
        private System.Windows.Forms.DataGridView gvMaterial;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button Eliminar;
    }
}