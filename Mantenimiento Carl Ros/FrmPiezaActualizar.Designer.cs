namespace Mantenimiento_Carl_Ros
{
    partial class FrmPiezaActualizar
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoEquipo = new System.Windows.Forms.TextBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboPieza = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Serial";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(93, 75);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(202, 99);
            this.txtDescripcion.TabIndex = 23;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(19, 254);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 22;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(239, 258);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 21;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Codigo Equipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Serial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Pieza";
            // 
            // txtCodigoEquipo
            // 
            this.txtCodigoEquipo.Enabled = false;
            this.txtCodigoEquipo.Location = new System.Drawing.Point(93, 206);
            this.txtCodigoEquipo.Name = "txtCodigoEquipo";
            this.txtCodigoEquipo.Size = new System.Drawing.Size(202, 20);
            this.txtCodigoEquipo.TabIndex = 16;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(93, 180);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(202, 20);
            this.txtSerial.TabIndex = 15;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(93, 48);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(202, 21);
            this.cboMarca.TabIndex = 14;
            // 
            // cboPieza
            // 
            this.cboPieza.FormattingEnabled = true;
            this.cboPieza.Location = new System.Drawing.Point(93, 21);
            this.cboPieza.Name = "cboPieza";
            this.cboPieza.Size = new System.Drawing.Size(202, 21);
            this.cboPieza.TabIndex = 13;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(93, 232);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(202, 20);
            this.txtId.TabIndex = 25;
            this.txtId.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Id";
            this.label6.Visible = false;
            // 
            // FrmPiezaActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 297);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoEquipo);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.cboPieza);
            this.MaximizeBox = false;
            this.Name = "FrmPiezaActualizar";
            this.Text = "PIEZA ACTUALIZAR";
            this.Load += new System.EventHandler(this.FrmPiezaActualizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtDescripcion;
        internal System.Windows.Forms.CheckBox chkActivo;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtCodigoEquipo;
        internal System.Windows.Forms.TextBox txtSerial;
        internal System.Windows.Forms.ComboBox cboMarca;
        internal System.Windows.Forms.ComboBox cboPieza;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label label6;
    }
}