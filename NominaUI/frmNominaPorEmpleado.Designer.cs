
namespace NominaUI
{
    partial class frmNominaPorEmpleado
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.btnPreliminar = new System.Windows.Forms.Button();
            this.chboxEmpleado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Empleado:";
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.DisplayMember = "Nombre";
            this.cbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(120, 36);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(396, 21);
            this.cbEmpleado.TabIndex = 1;
            this.cbEmpleado.ValueMember = "Id";
            // 
            // btnPreliminar
            // 
            this.btnPreliminar.Location = new System.Drawing.Point(415, 167);
            this.btnPreliminar.Name = "btnPreliminar";
            this.btnPreliminar.Size = new System.Drawing.Size(101, 23);
            this.btnPreliminar.TabIndex = 3;
            this.btnPreliminar.Text = "Preliminar";
            this.btnPreliminar.UseVisualStyleBackColor = true;
            this.btnPreliminar.Click += new System.EventHandler(this.btnPreliminar_Click);
            // 
            // chboxEmpleado
            // 
            this.chboxEmpleado.AutoSize = true;
            this.chboxEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxEmpleado.ForeColor = System.Drawing.Color.Yellow;
            this.chboxEmpleado.Location = new System.Drawing.Point(120, 135);
            this.chboxEmpleado.Name = "chboxEmpleado";
            this.chboxEmpleado.Size = new System.Drawing.Size(268, 22);
            this.chboxEmpleado.TabIndex = 2;
            this.chboxEmpleado.Text = "Presentar Empleados dados de Baja";
            this.chboxEmpleado.UseVisualStyleBackColor = true;
            this.chboxEmpleado.CheckedChanged += new System.EventHandler(this.chboxEmpleado_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(120, 86);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(96, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // frmNominaPorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(528, 202);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chboxEmpleado);
            this.Controls.Add(this.btnPreliminar);
            this.Controls.Add(this.cbEmpleado);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNominaPorEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nomina Por Empleado";
            this.Load += new System.EventHandler(this.frmNominaPorEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.Button btnPreliminar;
        private System.Windows.Forms.CheckBox chboxEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}