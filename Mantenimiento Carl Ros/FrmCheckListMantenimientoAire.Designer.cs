namespace Mantenimiento_Carl_Ros
{
    partial class FrmCheckListMantenimientoAire
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chkCheckList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 218);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // chkCheckList
            // 
            this.chkCheckList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCheckList.FormattingEnabled = true;
            this.chkCheckList.Items.AddRange(new object[] {
            "Lavado de maquinas",
            "Lavado de serpentín",
            "Limpieza de sistemas de soplado (aspas y/o browser)",
            "Limpieza de drenaje y bandejas",
            "Lavado  y/o cambio de filtros de aire",
            "Limpieza y ajustes de controles eléctricos",
            "Chequeo de nivel de aceite y temperatura  del cárter",
            "Revisión carga de refrigerante",
            "Verificación, ajustes y reposición de tornillería",
            "Limpieza del cuarto de maquinas"});
            this.chkCheckList.Location = new System.Drawing.Point(12, 12);
            this.chkCheckList.Name = "chkCheckList";
            this.chkCheckList.Size = new System.Drawing.Size(414, 191);
            this.chkCheckList.TabIndex = 2;
            // 
            // FrmCheckListMantenimientoAire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 256);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.chkCheckList);
            this.Name = "FrmCheckListMantenimientoAire";
            this.Text = "FrmCheckListMantenimientoAire";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckedListBox chkCheckList;
    }
}