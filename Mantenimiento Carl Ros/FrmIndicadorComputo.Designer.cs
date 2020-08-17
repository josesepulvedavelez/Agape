namespace Mantenimiento_Carl_Ros
{
    partial class FrmIndicadorComputo
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
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvIndicadorMantenimientosEquipo = new System.Windows.Forms.DataGridView();
            this.dgvIndicadorMantenimientosComputoTotal = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvIndicadorMantenimientosComputoAprobadas = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.btnAnt = new System.Windows.Forms.Button();
            this.btnPri = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndicadorMantenimientosEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndicadorMantenimientosComputoTotal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndicadorMantenimientosComputoAprobadas)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboAnio
            // 
            this.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Location = new System.Drawing.Point(55, 21);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(121, 21);
            this.cboAnio.TabIndex = 8;
            this.cboAnio.SelectedIndexChanged += new System.EventHandler(this.cboAnio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Año";
            // 
            // dgvIndicadorMantenimientosEquipo
            // 
            this.dgvIndicadorMantenimientosEquipo.AllowUserToAddRows = false;
            this.dgvIndicadorMantenimientosEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndicadorMantenimientosEquipo.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvIndicadorMantenimientosEquipo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvIndicadorMantenimientosEquipo.Location = new System.Drawing.Point(12, 61);
            this.dgvIndicadorMantenimientosEquipo.Name = "dgvIndicadorMantenimientosEquipo";
            this.dgvIndicadorMantenimientosEquipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIndicadorMantenimientosEquipo.Size = new System.Drawing.Size(945, 450);
            this.dgvIndicadorMantenimientosEquipo.TabIndex = 6;
            // 
            // dgvIndicadorMantenimientosComputoTotal
            // 
            this.dgvIndicadorMantenimientosComputoTotal.AllowUserToAddRows = false;
            this.dgvIndicadorMantenimientosComputoTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndicadorMantenimientosComputoTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvIndicadorMantenimientosComputoTotal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvIndicadorMantenimientosComputoTotal.Location = new System.Drawing.Point(14, 19);
            this.dgvIndicadorMantenimientosComputoTotal.Name = "dgvIndicadorMantenimientosComputoTotal";
            this.dgvIndicadorMantenimientosComputoTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIndicadorMantenimientosComputoTotal.Size = new System.Drawing.Size(919, 82);
            this.dgvIndicadorMantenimientosComputoTotal.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvIndicadorMantenimientosComputoTotal);
            this.groupBox1.Location = new System.Drawing.Point(12, 579);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 118);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total solicitudes presentadas al mes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvIndicadorMantenimientosComputoAprobadas);
            this.groupBox2.Location = new System.Drawing.Point(13, 703);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(944, 110);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sumatoria de las calificaciones obtenidas por solicitud";
            // 
            // dgvIndicadorMantenimientosComputoAprobadas
            // 
            this.dgvIndicadorMantenimientosComputoAprobadas.AllowUserToAddRows = false;
            this.dgvIndicadorMantenimientosComputoAprobadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndicadorMantenimientosComputoAprobadas.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvIndicadorMantenimientosComputoAprobadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvIndicadorMantenimientosComputoAprobadas.Location = new System.Drawing.Point(14, 19);
            this.dgvIndicadorMantenimientosComputoAprobadas.Name = "dgvIndicadorMantenimientosComputoAprobadas";
            this.dgvIndicadorMantenimientosComputoAprobadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIndicadorMantenimientosComputoAprobadas.Size = new System.Drawing.Size(918, 82);
            this.dgvIndicadorMantenimientosComputoAprobadas.TabIndex = 13;
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 517);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(395, 32);
            this.tableLayoutPanel3.TabIndex = 47;
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
            this.btnSig.Location = new System.Drawing.Point(308, 2);
            this.btnSig.Margin = new System.Windows.Forms.Padding(2);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(40, 28);
            this.btnSig.TabIndex = 4;
            this.btnSig.Text = ">>";
            this.btnSig.UseVisualStyleBackColor = true;
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // FrmIndicadorComputo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 832);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboAnio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIndicadorMantenimientosEquipo);
            this.Name = "FrmIndicadorComputo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INDICADOR DE GESTION - EQUIPO DE COMPUTO";
            this.Load += new System.EventHandler(this.FrmIndicadorComputo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndicadorMantenimientosEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndicadorMantenimientosComputoTotal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndicadorMantenimientosComputoAprobadas)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvIndicadorMantenimientosEquipo;
        private System.Windows.Forms.DataGridView dgvIndicadorMantenimientosComputoTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvIndicadorMantenimientosComputoAprobadas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Button btnPri;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSig;
    }
}