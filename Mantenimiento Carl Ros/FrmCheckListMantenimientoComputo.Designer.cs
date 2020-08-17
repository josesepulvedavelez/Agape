namespace Mantenimiento_Carl_Ros
{
    partial class FrmCheckListMantenimientoComputo
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
            this.chkCheckList = new System.Windows.Forms.CheckedListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkCheckList
            // 
            this.chkCheckList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCheckList.FormattingEnabled = true;
            this.chkCheckList.Items.AddRange(new object[] {
            "Limpieza interna y externa",
            "Revisión de conectores internos\t",
            "Limpieza de monitor",
            "Limpieza de teclado\t\t",
            "Limpieza del mouse\t\t",
            "Limpieza unidad de DVD/CD\t\t",
            "Limpieza de estabilizador\t\t",
            "Actualización de antivirus\t\t",
            "Desfragmentación de disco duro\t\t",
            "Eliminación de temporales\t\t",
            "Respaldo de datos\t\t",
            "Verificación de conexión de red \t\t",
            "Formato lógico y montaje de sistema operativo"});
            this.chkCheckList.Location = new System.Drawing.Point(12, 12);
            this.chkCheckList.Name = "chkCheckList";
            this.chkCheckList.Size = new System.Drawing.Size(414, 242);
            this.chkCheckList.TabIndex = 0;
            this.chkCheckList.SelectedIndexChanged += new System.EventHandler(this.chkCheckList_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 269);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmCheckListMantenimientoComputo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 306);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.chkCheckList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCheckListMantenimientoComputo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHECK LIST MANTENIMIENTO PREVENTIVO COMPUTO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkCheckList;
        private System.Windows.Forms.Button btnAceptar;
    }
}