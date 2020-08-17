namespace Mantenimiento_Carl_Ros
{
    partial class FrmHojaVidaComputo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHojaVidaComputo));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEquipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboPeriocidad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboProceso = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboJefeInmediato = new System.Windows.Forms.ComboBox();
            this.cboUbicacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboResponsable = new System.Windows.Forms.ComboBox();
            this.dgvMantenimiento = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevoMantenimiento = new System.Windows.Forms.Button();
            this.btnActualizarMantenimiento = new System.Windows.Forms.Button();
            this.dgvPieza = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevoPieza = new System.Windows.Forms.Button();
            this.btnActualizarPieza = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvHojaVidaComputo = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.btnAnt = new System.Windows.Forms.Button();
            this.btnPri = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSig = new System.Windows.Forms.Button();
            this.picPc = new System.Windows.Forms.PictureBox();
            this.picImpresora = new System.Windows.Forms.PictureBox();
            this.picPortatil = new System.Windows.Forms.PictureBox();
            this.picScanner = new System.Windows.Forms.PictureBox();
            this.rbtTodos = new System.Windows.Forms.RadioButton();
            this.rbtActivos = new System.Windows.Forms.RadioButton();
            this.rbtInactivos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimiento)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieza)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHojaVidaComputo)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImpresora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPortatil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScanner)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de creacion";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(105, 3);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(476, 30);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(258, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Equipo";
            // 
            // cboEquipo
            // 
            this.cboEquipo.FormattingEnabled = true;
            this.cboEquipo.Location = new System.Drawing.Point(105, 30);
            this.cboEquipo.Name = "cboEquipo";
            this.cboEquipo.Size = new System.Drawing.Size(258, 21);
            this.cboEquipo.TabIndex = 5;
            this.cboEquipo.Click += new System.EventHandler(this.cboEquipo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Responsable";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(105, 57);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(258, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cargo";
            // 
            // cboCargo
            // 
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(476, 84);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(258, 21);
            this.cboCargo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Periocidad";
            // 
            // cboPeriocidad
            // 
            this.cboPeriocidad.FormattingEnabled = true;
            this.cboPeriocidad.Location = new System.Drawing.Point(105, 84);
            this.cboPeriocidad.Name = "cboPeriocidad";
            this.cboPeriocidad.Size = new System.Drawing.Size(258, 21);
            this.cboPeriocidad.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Proceso";
            // 
            // cboProceso
            // 
            this.cboProceso.FormattingEnabled = true;
            this.cboProceso.Location = new System.Drawing.Point(502, 158);
            this.cboProceso.Name = "cboProceso";
            this.cboProceso.Size = new System.Drawing.Size(258, 21);
            this.cboProceso.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ubicacion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(427, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Jefe inmediato";
            // 
            // cboJefeInmediato
            // 
            this.cboJefeInmediato.FormattingEnabled = true;
            this.cboJefeInmediato.Location = new System.Drawing.Point(502, 185);
            this.cboJefeInmediato.Name = "cboJefeInmediato";
            this.cboJefeInmediato.Size = new System.Drawing.Size(258, 21);
            this.cboJefeInmediato.TabIndex = 19;
            // 
            // cboUbicacion
            // 
            this.cboUbicacion.FormattingEnabled = true;
            this.cboUbicacion.Location = new System.Drawing.Point(476, 3);
            this.cboUbicacion.Name = "cboUbicacion";
            this.cboUbicacion.Size = new System.Drawing.Size(258, 21);
            this.cboUbicacion.TabIndex = 17;
            this.cboUbicacion.Click += new System.EventHandler(this.cboUbicacion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // cboResponsable
            // 
            this.cboResponsable.FormattingEnabled = true;
            this.cboResponsable.Location = new System.Drawing.Point(476, 57);
            this.cboResponsable.Name = "cboResponsable";
            this.cboResponsable.Size = new System.Drawing.Size(258, 21);
            this.cboResponsable.TabIndex = 7;
            // 
            // dgvMantenimiento
            // 
            this.dgvMantenimiento.AllowUserToAddRows = false;
            this.dgvMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMantenimiento.Location = new System.Drawing.Point(3, 3);
            this.dgvMantenimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMantenimiento.Name = "dgvMantenimiento";
            this.dgvMantenimiento.RowTemplate.Height = 24;
            this.dgvMantenimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMantenimiento.Size = new System.Drawing.Size(1030, 417);
            this.dgvMantenimiento.TabIndex = 25;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel5);
            this.tabPage2.Controls.Add(this.dgvMantenimiento);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1038, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MANTENIMIETO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.btnNuevoMantenimiento, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnActualizarMantenimiento, 2, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(5, 424);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(217, 32);
            this.tableLayoutPanel5.TabIndex = 33;
            // 
            // btnNuevoMantenimiento
            // 
            this.btnNuevoMantenimiento.Location = new System.Drawing.Point(2, 2);
            this.btnNuevoMantenimiento.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoMantenimiento.Name = "btnNuevoMantenimiento";
            this.btnNuevoMantenimiento.Size = new System.Drawing.Size(66, 28);
            this.btnNuevoMantenimiento.TabIndex = 0;
            this.btnNuevoMantenimiento.Text = "&Nuevo";
            this.btnNuevoMantenimiento.UseVisualStyleBackColor = true;
            this.btnNuevoMantenimiento.Click += new System.EventHandler(this.btnNuevoMantenimiento_Click);
            // 
            // btnActualizarMantenimiento
            // 
            this.btnActualizarMantenimiento.Location = new System.Drawing.Point(72, 2);
            this.btnActualizarMantenimiento.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarMantenimiento.Name = "btnActualizarMantenimiento";
            this.btnActualizarMantenimiento.Size = new System.Drawing.Size(66, 28);
            this.btnActualizarMantenimiento.TabIndex = 2;
            this.btnActualizarMantenimiento.Text = "&Actualizar";
            this.btnActualizarMantenimiento.UseVisualStyleBackColor = true;
            this.btnActualizarMantenimiento.Click += new System.EventHandler(this.btnActualizarMantenimiento_Click);
            // 
            // dgvPieza
            // 
            this.dgvPieza.AllowUserToAddRows = false;
            this.dgvPieza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPieza.Location = new System.Drawing.Point(3, 3);
            this.dgvPieza.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPieza.Name = "dgvPieza";
            this.dgvPieza.RowTemplate.Height = 24;
            this.dgvPieza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPieza.Size = new System.Drawing.Size(1030, 417);
            this.dgvPieza.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel4);
            this.tabPage1.Controls.Add(this.dgvPieza);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1038, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PIEZA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.btnNuevoPieza, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnActualizarPieza, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 424);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(146, 32);
            this.tableLayoutPanel4.TabIndex = 32;
            // 
            // btnNuevoPieza
            // 
            this.btnNuevoPieza.Location = new System.Drawing.Point(2, 2);
            this.btnNuevoPieza.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoPieza.Name = "btnNuevoPieza";
            this.btnNuevoPieza.Size = new System.Drawing.Size(66, 28);
            this.btnNuevoPieza.TabIndex = 0;
            this.btnNuevoPieza.Text = "&Nuevo";
            this.btnNuevoPieza.UseVisualStyleBackColor = true;
            this.btnNuevoPieza.Click += new System.EventHandler(this.btnNuevoPieza_Click);
            // 
            // btnActualizarPieza
            // 
            this.btnActualizarPieza.Location = new System.Drawing.Point(72, 2);
            this.btnActualizarPieza.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarPieza.Name = "btnActualizarPieza";
            this.btnActualizarPieza.Size = new System.Drawing.Size(66, 28);
            this.btnActualizarPieza.TabIndex = 2;
            this.btnActualizarPieza.Text = "&Actualizar";
            this.btnActualizarPieza.UseVisualStyleBackColor = true;
            this.btnActualizarPieza.Click += new System.EventHandler(this.btnActualizarPieza_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizar.Location = new System.Drawing.Point(142, 2);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(66, 28);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsertar.Enabled = false;
            this.btnInsertar.Location = new System.Drawing.Point(72, 2);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(66, 28);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "&Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Location = new System.Drawing.Point(2, 2);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(66, 28);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvHojaVidaComputo
            // 
            this.dgvHojaVidaComputo.AllowUserToAddRows = false;
            this.dgvHojaVidaComputo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHojaVidaComputo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHojaVidaComputo.Location = new System.Drawing.Point(2, 2);
            this.dgvHojaVidaComputo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHojaVidaComputo.Name = "dgvHojaVidaComputo";
            this.dgvHojaVidaComputo.RowTemplate.Height = 24;
            this.dgvHojaVidaComputo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHojaVidaComputo.Size = new System.Drawing.Size(1034, 457);
            this.dgvHojaVidaComputo.TabIndex = 26;
            this.dgvHojaVidaComputo.SelectionChanged += new System.EventHandler(this.dgvHojaVidaComputo_SelectionChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvHojaVidaComputo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1038, 461);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "HV COMPUTO";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnInsertar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnActualizar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNuevo, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(30, 723);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(295, 32);
            this.tableLayoutPanel2.TabIndex = 31;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 230);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1046, 487);
            this.tabControl1.TabIndex = 27;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(502, 215);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 28;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(32, 158);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(357, 51);
            this.txtObservaciones.TabIndex = 33;
            this.txtObservaciones.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpFecha, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboEquipo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCodigo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboPeriocidad, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboUbicacion, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboResponsable, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboCargo, 4, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 114);
            this.tableLayoutPanel1.TabIndex = 34;
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(332, 723);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(395, 32);
            this.tableLayoutPanel3.TabIndex = 35;
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
            // picPc
            // 
            this.picPc.Image = ((System.Drawing.Image)(resources.GetObject("picPc.Image")));
            this.picPc.Location = new System.Drawing.Point(817, 25);
            this.picPc.Name = "picPc";
            this.picPc.Size = new System.Drawing.Size(255, 199);
            this.picPc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPc.TabIndex = 52;
            this.picPc.TabStop = false;
            this.picPc.Visible = false;
            // 
            // picImpresora
            // 
            this.picImpresora.Image = ((System.Drawing.Image)(resources.GetObject("picImpresora.Image")));
            this.picImpresora.Location = new System.Drawing.Point(817, 25);
            this.picImpresora.Name = "picImpresora";
            this.picImpresora.Size = new System.Drawing.Size(255, 199);
            this.picImpresora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImpresora.TabIndex = 55;
            this.picImpresora.TabStop = false;
            this.picImpresora.Visible = false;
            // 
            // picPortatil
            // 
            this.picPortatil.Image = ((System.Drawing.Image)(resources.GetObject("picPortatil.Image")));
            this.picPortatil.Location = new System.Drawing.Point(817, 25);
            this.picPortatil.Name = "picPortatil";
            this.picPortatil.Size = new System.Drawing.Size(255, 199);
            this.picPortatil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPortatil.TabIndex = 53;
            this.picPortatil.TabStop = false;
            this.picPortatil.Visible = false;
            // 
            // picScanner
            // 
            this.picScanner.Image = ((System.Drawing.Image)(resources.GetObject("picScanner.Image")));
            this.picScanner.Location = new System.Drawing.Point(817, 25);
            this.picScanner.Name = "picScanner";
            this.picScanner.Size = new System.Drawing.Size(255, 199);
            this.picScanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScanner.TabIndex = 54;
            this.picScanner.TabStop = false;
            this.picScanner.Visible = false;
            // 
            // rbtTodos
            // 
            this.rbtTodos.AutoSize = true;
            this.rbtTodos.Checked = true;
            this.rbtTodos.Location = new System.Drawing.Point(753, 731);
            this.rbtTodos.Name = "rbtTodos";
            this.rbtTodos.Size = new System.Drawing.Size(70, 17);
            this.rbtTodos.TabIndex = 56;
            this.rbtTodos.TabStop = true;
            this.rbtTodos.Text = "Ver todos";
            this.rbtTodos.UseVisualStyleBackColor = true;
            this.rbtTodos.CheckedChanged += new System.EventHandler(this.rbtTodos_CheckedChanged);
            // 
            // rbtActivos
            // 
            this.rbtActivos.AutoSize = true;
            this.rbtActivos.Location = new System.Drawing.Point(829, 731);
            this.rbtActivos.Name = "rbtActivos";
            this.rbtActivos.Size = new System.Drawing.Size(78, 17);
            this.rbtActivos.TabIndex = 57;
            this.rbtActivos.Text = "Ver activos";
            this.rbtActivos.UseVisualStyleBackColor = true;
            this.rbtActivos.CheckedChanged += new System.EventHandler(this.rbtActivos_CheckedChanged);
            // 
            // rbtInactivos
            // 
            this.rbtInactivos.AutoSize = true;
            this.rbtInactivos.Location = new System.Drawing.Point(913, 731);
            this.rbtInactivos.Name = "rbtInactivos";
            this.rbtInactivos.Size = new System.Drawing.Size(85, 17);
            this.rbtInactivos.TabIndex = 58;
            this.rbtInactivos.Text = "ver inactivos";
            this.rbtInactivos.UseVisualStyleBackColor = true;
            this.rbtInactivos.CheckedChanged += new System.EventHandler(this.rbtInactivos_CheckedChanged);
            // 
            // FrmHojaVidaComputo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 766);
            this.Controls.Add(this.rbtInactivos);
            this.Controls.Add(this.rbtActivos);
            this.Controls.Add(this.rbtTodos);
            this.Controls.Add(this.picScanner);
            this.Controls.Add(this.picPc);
            this.Controls.Add(this.picPortatil);
            this.Controls.Add(this.picImpresora);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.cboJefeInmediato);
            this.Controls.Add(this.cboProceso);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.MaximizeBox = false;
            this.Name = "FrmHojaVidaComputo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOJA DE VIDA COMPUTO";
            this.Load += new System.EventHandler(this.FrmHojaVidaComputo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimiento)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieza)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHojaVidaComputo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImpresora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPortatil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboEquipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboPeriocidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboProceso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboJefeInmediato;
        private System.Windows.Forms.ComboBox cboUbicacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboResponsable;
        private System.Windows.Forms.DataGridView dgvMantenimiento;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPieza;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvHojaVidaComputo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txtObservaciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnPri;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSig;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnNuevoPieza;
        private System.Windows.Forms.Button btnActualizarPieza;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnNuevoMantenimiento;
        private System.Windows.Forms.Button btnActualizarMantenimiento;
        private System.Windows.Forms.PictureBox picPc;
        private System.Windows.Forms.PictureBox picImpresora;
        private System.Windows.Forms.PictureBox picPortatil;
        private System.Windows.Forms.PictureBox picScanner;
        private System.Windows.Forms.RadioButton rbtTodos;
        private System.Windows.Forms.RadioButton rbtActivos;
        private System.Windows.Forms.RadioButton rbtInactivos;
    }
}

