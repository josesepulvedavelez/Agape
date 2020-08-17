namespace Mantenimiento_Carl_Ros
{
    partial class FrmMantenimientoEquipoCorrectivo
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
            this.btbExportarExcel = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.btnAnt = new System.Windows.Forms.Button();
            this.btnPri = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSig = new System.Windows.Forms.Button();
            this.dgvMantenimiento = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // btbExportarExcel
            // 
            this.btbExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btbExportarExcel.Location = new System.Drawing.Point(803, 705);
            this.btbExportarExcel.Name = "btbExportarExcel";
            this.btbExportarExcel.Size = new System.Drawing.Size(75, 23);
            this.btbExportarExcel.TabIndex = 46;
            this.btbExportarExcel.Text = "Exportar";
            this.btbExportarExcel.UseVisualStyleBackColor = true;
            this.btbExportarExcel.Click += new System.EventHandler(this.btbExportarExcel_Click);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(20, 696);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(395, 32);
            this.tableLayoutPanel3.TabIndex = 45;
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
            // dgvMantenimiento
            // 
            this.dgvMantenimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMantenimiento.Location = new System.Drawing.Point(14, 12);
            this.dgvMantenimiento.Name = "dgvMantenimiento";
            this.dgvMantenimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMantenimiento.Size = new System.Drawing.Size(864, 669);
            this.dgvMantenimiento.TabIndex = 44;
            // 
            // FrmMantenimientoEquipoCorrectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 740);
            this.Controls.Add(this.btbExportarExcel);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.dgvMantenimiento);
            this.Name = "FrmMantenimientoEquipoCorrectivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANTENIMIENTOS EQUIPOS CORRECTIVO";
            this.Load += new System.EventHandler(this.FrmMantenimientoEquipoCorrectivo_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btbExportarExcel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Button btnPri;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSig;
        private System.Windows.Forms.DataGridView dgvMantenimiento;
    }
}