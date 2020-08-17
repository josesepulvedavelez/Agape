namespace Mantenimiento_Carl_Ros
{
    partial class FrmMantenimientoEquipoInforme
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.btnAnt = new System.Windows.Forms.Button();
            this.btnPri = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSig = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.dgvMantenimiento = new System.Windows.Forms.DataGridView();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.cboMantenimiento = new System.Windows.Forms.ComboBox();
            this.cboProceso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimiento)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.txtRegistro, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAnt, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnPri, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button4, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSig, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(26, 681);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(395, 32);
            this.tableLayoutPanel3.TabIndex = 53;
            // 
            // txtRegistro
            // 
            this.txtRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistro.Location = new System.Drawing.Point(91, 3);
            this.txtRegistro.Multiline = true;
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(212, 26);
            this.txtRegistro.TabIndex = 10;
            this.txtRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAnt
            // 
            this.btnAnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnt.Location = new System.Drawing.Point(46, 2);
            this.btnAnt.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(40, 28);
            this.btnAnt.TabIndex = 2;
            this.btnAnt.Text = "<<";
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // btnPri
            // 
            this.btnPri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPri.Location = new System.Drawing.Point(2, 2);
            this.btnPri.Margin = new System.Windows.Forms.Padding(2);
            this.btnPri.Name = "btnPri";
            this.btnPri.Size = new System.Drawing.Size(40, 28);
            this.btnPri.TabIndex = 1;
            this.btnPri.Text = "|<";
            this.btnPri.UseVisualStyleBackColor = true;
            this.btnPri.Click += new System.EventHandler(this.btnPri_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Location = new System.Drawing.Point(352, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = ">|";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSig
            // 
            this.btnSig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSig.Location = new System.Drawing.Point(308, 2);
            this.btnSig.Margin = new System.Windows.Forms.Padding(2);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(40, 28);
            this.btnSig.TabIndex = 4;
            this.btnSig.Text = ">>";
            this.btnSig.UseVisualStyleBackColor = true;
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(702, 16);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 52;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Mantenimiento";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(877, 688);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 48;
            this.btnExportar.Text = "&Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dgvMantenimiento
            // 
            this.dgvMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMantenimiento.Location = new System.Drawing.Point(26, 74);
            this.dgvMantenimiento.Name = "dgvMantenimiento";
            this.dgvMantenimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMantenimiento.Size = new System.Drawing.Size(926, 591);
            this.dgvMantenimiento.TabIndex = 47;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(337, 16);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(123, 20);
            this.dtpHasta.TabIndex = 46;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(208, 16);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(123, 20);
            this.dtpDesde.TabIndex = 45;
            // 
            // cboMantenimiento
            // 
            this.cboMantenimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMantenimiento.FormattingEnabled = true;
            this.cboMantenimiento.Items.AddRange(new object[] {
            "MANTENIMIENTO PREVENTIVO",
            "MANTENIMIENTO CORRECTIVO",
            "PREVENTIVO Y CORRECTIVO"});
            this.cboMantenimiento.Location = new System.Drawing.Point(3, 16);
            this.cboMantenimiento.Name = "cboMantenimiento";
            this.cboMantenimiento.Size = new System.Drawing.Size(199, 21);
            this.cboMantenimiento.TabIndex = 44;
            // 
            // cboProceso
            // 
            this.cboProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProceso.FormattingEnabled = true;
            this.cboProceso.Location = new System.Drawing.Point(466, 16);
            this.cboProceso.Name = "cboProceso";
            this.cboProceso.Size = new System.Drawing.Size(230, 21);
            this.cboProceso.TabIndex = 54;
            this.cboProceso.Click += new System.EventHandler(this.cboProceso_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Proceso";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGenerar, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboMantenimiento, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboProceso, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpDesde, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpHasta, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(811, 46);
            this.tableLayoutPanel1.TabIndex = 56;
            // 
            // FrmMantenimientoEquipoInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 725);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvMantenimiento);
            this.MaximizeBox = false;
            this.Name = "FrmMantenimientoEquipoInforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANTENIMIENTO EQUIPOS INFORME";
            this.Load += new System.EventHandler(this.FrmMantenimientoEquipoInforme_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimiento)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Button btnPri;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSig;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridView dgvMantenimiento;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.ComboBox cboMantenimiento;
        private System.Windows.Forms.ComboBox cboProceso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}