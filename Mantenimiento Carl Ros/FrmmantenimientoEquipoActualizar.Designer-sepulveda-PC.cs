namespace Mantenimiento_Carl_Ros
{
    partial class FrmmantenimientoEquipoActualizar
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtCodigoInventario = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.RichTextBox();
            this.dtpfechaProximoMantenimiento = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcionActividadesRealizadas = new System.Windows.Forms.RichTextBox();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.cboMantenimiento = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Observaciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Codigo Inventario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Fecha Proximo Mant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Descripcion de actividades realizadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mantenimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fecha";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(19, 359);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 23;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtCodigoInventario
            // 
            this.txtCodigoInventario.Location = new System.Drawing.Point(422, 53);
            this.txtCodigoInventario.Name = "txtCodigoInventario";
            this.txtCodigoInventario.Size = new System.Drawing.Size(200, 20);
            this.txtCodigoInventario.TabIndex = 22;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(19, 145);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(636, 69);
            this.txtObservaciones.TabIndex = 21;
            this.txtObservaciones.Text = "";
            // 
            // dtpfechaProximoMantenimiento
            // 
            this.dtpfechaProximoMantenimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaProximoMantenimiento.Location = new System.Drawing.Point(422, 27);
            this.dtpfechaProximoMantenimiento.Name = "dtpfechaProximoMantenimiento";
            this.dtpfechaProximoMantenimiento.Size = new System.Drawing.Size(121, 20);
            this.dtpfechaProximoMantenimiento.TabIndex = 20;
            // 
            // txtDescripcionActividadesRealizadas
            // 
            this.txtDescripcionActividadesRealizadas.Location = new System.Drawing.Point(21, 248);
            this.txtDescripcionActividadesRealizadas.Name = "txtDescripcionActividadesRealizadas";
            this.txtDescripcionActividadesRealizadas.Size = new System.Drawing.Size(636, 96);
            this.txtDescripcionActividadesRealizadas.TabIndex = 19;
            this.txtDescripcionActividadesRealizadas.Text = "";
            // 
            // cboProveedor
            // 
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Items.AddRange(new object[] {
            "INTERNO",
            "IRM",
            "RAFAEL SOLANO"});
            this.cboProveedor.Location = new System.Drawing.Point(91, 80);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(200, 21);
            this.cboProveedor.TabIndex = 18;
            // 
            // cboMantenimiento
            // 
            this.cboMantenimiento.FormattingEnabled = true;
            this.cboMantenimiento.Items.AddRange(new object[] {
            "PREVENTIVO",
            "CORRECTIVO"});
            this.cboMantenimiento.Location = new System.Drawing.Point(91, 53);
            this.cboMantenimiento.Name = "cboMantenimiento";
            this.cboMantenimiento.Size = new System.Drawing.Size(200, 21);
            this.cboMantenimiento.TabIndex = 17;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(91, 27);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha.TabIndex = 16;
            // 
            // FrmmantenimientoEquipoActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 397);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtCodigoInventario);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.dtpfechaProximoMantenimiento);
            this.Controls.Add(this.txtDescripcionActividadesRealizadas);
            this.Controls.Add(this.cboProveedor);
            this.Controls.Add(this.cboMantenimiento);
            this.Controls.Add(this.dtpFecha);
            this.Name = "FrmmantenimientoEquipoActualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANTENIMIENTO EQUIPO ACTUALIZAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizar;
        internal System.Windows.Forms.TextBox txtCodigoInventario;
        private System.Windows.Forms.RichTextBox txtObservaciones;
        private System.Windows.Forms.DateTimePicker dtpfechaProximoMantenimiento;
        private System.Windows.Forms.RichTextBox txtDescripcionActividadesRealizadas;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.ComboBox cboMantenimiento;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}