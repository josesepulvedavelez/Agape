namespace Mantenimiento_Carl_Ros
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label2 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(139, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "&Usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OK.Location = new System.Drawing.Point(142, 163);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(94, 23);
            this.OK.TabIndex = 29;
            this.OK.Text = "&Aceptar";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(142, 96);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(163, 23);
            this.Label1.TabIndex = 33;
            this.Label1.Text = "&Cargo";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboCargo
            // 
            this.cboCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "ADMINISTRADOR"});
            this.cboCargo.Location = new System.Drawing.Point(142, 119);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(163, 21);
            this.cboCargo.TabIndex = 28;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(252, 163);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(94, 23);
            this.Cancel.TabIndex = 30;
            this.Cancel.Text = "&Cancelar";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(142, 74);
            this.txtPass.MaxLength = 15;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(163, 20);
            this.txtPass.TabIndex = 27;
            this.txtPass.Text = "admin";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(142, 33);
            this.txtUser.MaxLength = 20;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(163, 20);
            this.txtUser.TabIndex = 26;
            this.txtUser.Text = "admin";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Location = new System.Drawing.Point(139, 54);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(165, 23);
            this.PasswordLabel.TabIndex = 32;
            this.PasswordLabel.Text = "&Contraseña";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(122, 179);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 31;
            this.LogoPictureBox.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 200);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button OK;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cboCargo;
        internal System.Windows.Forms.Button Cancel;
        internal System.Windows.Forms.TextBox txtPass;
        internal System.Windows.Forms.TextBox txtUser;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.PictureBox LogoPictureBox;
    }
}