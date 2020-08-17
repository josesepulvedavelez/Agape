namespace Mantenimiento_Carl_Ros
{
    partial class FrmMantenimientoEquipoInsertar
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboMantenimiento = new System.Windows.Forms.ComboBox();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.txtDescripcionActividadesRealizadas = new System.Windows.Forms.RichTextBox();
            this.dtpfechaProximoMantenimiento = new System.Windows.Forms.DateTimePicker();
            this.txtObservaciones = new System.Windows.Forms.RichTextBox();
            this.txtCodigoInventario = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboNota = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCons = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(91, 28);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // cboMantenimiento
            // 
            this.cboMantenimiento.FormattingEnabled = true;
            this.cboMantenimiento.Items.AddRange(new object[] {
            "PREVENTIVO",
            "CORRECTIVO",
            "CALIBRACION",
            "RECARGA"});
            this.cboMantenimiento.Location = new System.Drawing.Point(91, 54);
            this.cboMantenimiento.Name = "cboMantenimiento";
            this.cboMantenimiento.Size = new System.Drawing.Size(200, 21);
            this.cboMantenimiento.TabIndex = 1;
            this.cboMantenimiento.SelectedIndexChanged += new System.EventHandler(this.cboMantenimiento_SelectedIndexChanged);
            // 
            // cboProveedor
            // 
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Items.AddRange(new object[] {
            "INTERNO",
            "IRM",
            "RAFAEL SOLANO",
            "METROCARIBE",
            "INSEGRAL"});
            this.cboProveedor.Location = new System.Drawing.Point(91, 81);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(200, 21);
            this.cboProveedor.TabIndex = 2;
            // 
            // txtDescripcionActividadesRealizadas
            // 
            this.txtDescripcionActividadesRealizadas.Location = new System.Drawing.Point(21, 249);
            this.txtDescripcionActividadesRealizadas.Name = "txtDescripcionActividadesRealizadas";
            this.txtDescripcionActividadesRealizadas.Size = new System.Drawing.Size(636, 96);
            this.txtDescripcionActividadesRealizadas.TabIndex = 3;
            this.txtDescripcionActividadesRealizadas.Text = "";
            // 
            // dtpfechaProximoMantenimiento
            // 
            this.dtpfechaProximoMantenimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaProximoMantenimiento.Location = new System.Drawing.Point(422, 28);
            this.dtpfechaProximoMantenimiento.Name = "dtpfechaProximoMantenimiento";
            this.dtpfechaProximoMantenimiento.Size = new System.Drawing.Size(121, 20);
            this.dtpfechaProximoMantenimiento.TabIndex = 4;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(19, 146);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(636, 69);
            this.txtObservaciones.TabIndex = 5;
            this.txtObservaciones.Text = "";
            // 
            // txtCodigoInventario
            // 
            this.txtCodigoInventario.Enabled = false;
            this.txtCodigoInventario.Location = new System.Drawing.Point(422, 54);
            this.txtCodigoInventario.Name = "txtCodigoInventario";
            this.txtCodigoInventario.Size = new System.Drawing.Size(200, 20);
            this.txtCodigoInventario.TabIndex = 6;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(19, 360);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 7;
            this.btnInsertar.Text = "&Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mantenimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descripcion de actividades realizadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha Proximo Mant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Codigo Inventario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Observaciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(519, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Nota";
            // 
            // cboNota
            // 
            this.cboNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNota.FormattingEnabled = true;
            this.cboNota.Location = new System.Drawing.Point(555, 81);
            this.cboNota.Name = "cboNota";
            this.cboNota.Size = new System.Drawing.Size(67, 21);
            this.cboNota.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "No";
            // 
            // txtCons
            // 
            this.txtCons.Location = new System.Drawing.Point(422, 81);
            this.txtCons.Name = "txtCons";
            this.txtCons.Size = new System.Drawing.Size(67, 20);
            this.txtCons.TabIndex = 39;
            // 
            // FrmMantenimientoEquipoInsertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 397);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboNota);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCons);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtCodigoInventario);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.dtpfechaProximoMantenimiento);
            this.Controls.Add(this.txtDescripcionActividadesRealizadas);
            this.Controls.Add(this.cboProveedor);
            this.Controls.Add(this.cboMantenimiento);
            this.Controls.Add(this.dtpFecha);
            this.MaximizeBox = false;
            this.Name = "FrmMantenimientoEquipoInsertar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANTENIMIENTO EQUIPO INSERTAR";
            this.Load += new System.EventHandler(this.FrmMantenimientoEquipoInsertar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboMantenimiento;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.RichTextBox txtDescripcionActividadesRealizadas;
        private System.Windows.Forms.DateTimePicker dtpfechaProximoMantenimiento;
        private System.Windows.Forms.RichTextBox txtObservaciones;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtCodigoInventario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboNota;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtCons;
    }
}