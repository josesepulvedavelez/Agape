namespace Mantenimiento_Carl_Ros
{
    partial class FrmRequicisionCompra
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSede = new System.Windows.Forms.ComboBox();
            this.cboPor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtSoporte_justificacion = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvRequisicion = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSolicito = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisicion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "No";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(25, 55);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 20);
            this.txtNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sede";
            // 
            // cboSede
            // 
            this.cboSede.FormattingEnabled = true;
            this.cboSede.Location = new System.Drawing.Point(131, 55);
            this.cboSede.Name = "cboSede";
            this.cboSede.Size = new System.Drawing.Size(121, 21);
            this.cboSede.TabIndex = 6;
            // 
            // cboPor
            // 
            this.cboPor.FormattingEnabled = true;
            this.cboPor.Location = new System.Drawing.Point(63, 94);
            this.cboPor.Name = "cboPor";
            this.cboPor.Size = new System.Drawing.Size(449, 21);
            this.cboPor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Por";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(63, 147);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(130, 20);
            this.dtpFecha.TabIndex = 12;
            // 
            // txtSoporte_justificacion
            // 
            this.txtSoporte_justificacion.Location = new System.Drawing.Point(25, 207);
            this.txtSoporte_justificacion.Name = "txtSoporte_justificacion";
            this.txtSoporte_justificacion.Size = new System.Drawing.Size(487, 71);
            this.txtSoporte_justificacion.TabIndex = 13;
            this.txtSoporte_justificacion.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Soporte o justificacion";
            // 
            // dgvRequisicion
            // 
            this.dgvRequisicion.AllowUserToAddRows = false;
            this.dgvRequisicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisicion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantidad,
            this.nombre,
            this.descripcion});
            this.dgvRequisicion.Location = new System.Drawing.Point(25, 284);
            this.dgvRequisicion.Name = "dgvRequisicion";
            this.dgvRequisicion.Size = new System.Drawing.Size(487, 249);
            this.dgvRequisicion.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 580);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(25, 596);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(487, 71);
            this.txtObservaciones.TabIndex = 16;
            this.txtObservaciones.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 681);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Solicito";
            // 
            // cboSolicito
            // 
            this.cboSolicito.FormattingEnabled = true;
            this.cboSolicito.Location = new System.Drawing.Point(63, 673);
            this.cboSolicito.Name = "cboSolicito";
            this.cboSolicito.Size = new System.Drawing.Size(449, 21);
            this.cboSolicito.TabIndex = 18;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(25, 539);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 20;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(25, 715);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 21;
            this.btnInsertar.Text = "&Guardar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // cboCargo
            // 
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(63, 120);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(449, 21);
            this.cboCargo.TabIndex = 22;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Insumos y Papeleria",
            "Equipos y materiales para el servicio",
            "Servicios"});
            this.cboTipo.Location = new System.Drawing.Point(262, 54);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(250, 21);
            this.cboTipo.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tipo de Requisicion";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // FrmRequicisionCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 750);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboSolicito);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.dgvRequisicion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoporte_justificacion);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboPor);
            this.Controls.Add(this.cboSede);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.label1);
            this.Name = "FrmRequicisionCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REQUICISION DE COMPRA";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSede;
        private System.Windows.Forms.ComboBox cboPor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.RichTextBox txtSoporte_justificacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvRequisicion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtObservaciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboSolicito;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;

    }
}