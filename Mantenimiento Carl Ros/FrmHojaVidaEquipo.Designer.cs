namespace Mantenimiento_Carl_Ros
{
    partial class FrmHojaVidaEquipo
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEquipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboPeriocidad = new System.Windows.Forms.ComboBox();
            this.cboUbicacion = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.btnAnt = new System.Windows.Forms.Button();
            this.btnPri = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSig = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvHojaVidaEquipo = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnACtuaizarMantenimiento = new System.Windows.Forms.Button();
            this.btnNuevoMantenimiento = new System.Windows.Forms.Button();
            this.dgvMantenimiento = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cboCapacidad = new System.Windows.Forms.ComboBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rbtInactivos = new System.Windows.Forms.RadioButton();
            this.rbtActivos = new System.Windows.Forms.RadioButton();
            this.rbtTodos = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHojaVidaEquipo)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimiento)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
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
            // btnInsertar
            // 
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtSerie, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboMarca, 4, 1);
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
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboModelo, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 114);
            this.tableLayoutPanel1.TabIndex = 45;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(462, 84);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(258, 20);
            this.txtSerie.TabIndex = 47;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(462, 30);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(258, 21);
            this.cboMarca.TabIndex = 47;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(105, 3);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha.TabIndex = 1;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Codigo inventario";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(105, 57);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(258, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "periocidad mto";
            // 
            // cboPeriocidad
            // 
            this.cboPeriocidad.FormattingEnabled = true;
            this.cboPeriocidad.Location = new System.Drawing.Point(105, 84);
            this.cboPeriocidad.Name = "cboPeriocidad";
            this.cboPeriocidad.Size = new System.Drawing.Size(258, 21);
            this.cboPeriocidad.TabIndex = 13;
            // 
            // cboUbicacion
            // 
            this.cboUbicacion.FormattingEnabled = true;
            this.cboUbicacion.Location = new System.Drawing.Point(462, 3);
            this.cboUbicacion.Name = "cboUbicacion";
            this.cboUbicacion.Size = new System.Drawing.Size(258, 21);
            this.cboUbicacion.TabIndex = 17;
            this.cboUbicacion.Click += new System.EventHandler(this.cboUbicacion_Click_1);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Modelo";
            // 
            // cboModelo
            // 
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Location = new System.Drawing.Point(462, 57);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(258, 21);
            this.cboModelo.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Serie";
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(331, 723);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(395, 32);
            this.tableLayoutPanel3.TabIndex = 46;
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
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(142, 2);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(66, 28);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(31, 156);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(357, 51);
            this.txtDescripcion.TabIndex = 44;
            this.txtDescripcion.Text = "";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(2, 2);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(66, 28);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvHojaVidaEquipo
            // 
            this.dgvHojaVidaEquipo.AllowUserToAddRows = false;
            this.dgvHojaVidaEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHojaVidaEquipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHojaVidaEquipo.Location = new System.Drawing.Point(2, 2);
            this.dgvHojaVidaEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHojaVidaEquipo.Name = "dgvHojaVidaEquipo";
            this.dgvHojaVidaEquipo.RowTemplate.Height = 24;
            this.dgvHojaVidaEquipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHojaVidaEquipo.Size = new System.Drawing.Size(1036, 459);
            this.dgvHojaVidaEquipo.TabIndex = 26;
            this.dgvHojaVidaEquipo.SelectionChanged += new System.EventHandler(this.dgvHojaVidaEquipo_SelectionChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvHojaVidaEquipo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1040, 463);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "HV EQUIPO";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(487, 210);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 41;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(25, 228);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1048, 489);
            this.tabControl1.TabIndex = 40;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel5);
            this.tabPage2.Controls.Add(this.dgvMantenimiento);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1040, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MANTENIMIETO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.btnACtuaizarMantenimiento, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnNuevoMantenimiento, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(5, 426);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(146, 32);
            this.tableLayoutPanel5.TabIndex = 33;
            // 
            // btnACtuaizarMantenimiento
            // 
            this.btnACtuaizarMantenimiento.Location = new System.Drawing.Point(72, 2);
            this.btnACtuaizarMantenimiento.Margin = new System.Windows.Forms.Padding(2);
            this.btnACtuaizarMantenimiento.Name = "btnACtuaizarMantenimiento";
            this.btnACtuaizarMantenimiento.Size = new System.Drawing.Size(66, 28);
            this.btnACtuaizarMantenimiento.TabIndex = 3;
            this.btnACtuaizarMantenimiento.Text = "&Actualizar";
            this.btnACtuaizarMantenimiento.UseVisualStyleBackColor = true;
            this.btnACtuaizarMantenimiento.Click += new System.EventHandler(this.btnACtuaizarMantenimiento_Click);
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
            // dgvMantenimiento
            // 
            this.dgvMantenimiento.AllowUserToAddRows = false;
            this.dgvMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMantenimiento.Location = new System.Drawing.Point(3, 5);
            this.dgvMantenimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMantenimiento.Name = "dgvMantenimiento";
            this.dgvMantenimiento.RowTemplate.Height = 24;
            this.dgvMantenimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMantenimiento.Size = new System.Drawing.Size(1032, 417);
            this.dgvMantenimiento.TabIndex = 25;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnNuevo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnInsertar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnActualizar, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(29, 723);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(295, 32);
            this.tableLayoutPanel2.TabIndex = 42;
            // 
            // cboCapacidad
            // 
            this.cboCapacidad.FormattingEnabled = true;
            this.cboCapacidad.Location = new System.Drawing.Point(487, 156);
            this.cboCapacidad.Name = "cboCapacidad";
            this.cboCapacidad.Size = new System.Drawing.Size(258, 21);
            this.cboCapacidad.TabIndex = 37;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(487, 183);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(258, 21);
            this.cboTipo.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(426, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Capacidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(426, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Tipo";
            // 
            // rbtInactivos
            // 
            this.rbtInactivos.AutoSize = true;
            this.rbtInactivos.Location = new System.Drawing.Point(921, 731);
            this.rbtInactivos.Name = "rbtInactivos";
            this.rbtInactivos.Size = new System.Drawing.Size(85, 17);
            this.rbtInactivos.TabIndex = 61;
            this.rbtInactivos.TabStop = true;
            this.rbtInactivos.Text = "ver inactivos";
            this.rbtInactivos.UseVisualStyleBackColor = true;
            this.rbtInactivos.CheckedChanged += new System.EventHandler(this.rbtInactivos_CheckedChanged);
            // 
            // rbtActivos
            // 
            this.rbtActivos.AutoSize = true;
            this.rbtActivos.Location = new System.Drawing.Point(837, 731);
            this.rbtActivos.Name = "rbtActivos";
            this.rbtActivos.Size = new System.Drawing.Size(78, 17);
            this.rbtActivos.TabIndex = 60;
            this.rbtActivos.TabStop = true;
            this.rbtActivos.Text = "Ver activos";
            this.rbtActivos.UseVisualStyleBackColor = true;
            this.rbtActivos.CheckedChanged += new System.EventHandler(this.rbtActivos_CheckedChanged);
            // 
            // rbtTodos
            // 
            this.rbtTodos.AutoSize = true;
            this.rbtTodos.Location = new System.Drawing.Point(761, 731);
            this.rbtTodos.Name = "rbtTodos";
            this.rbtTodos.Size = new System.Drawing.Size(70, 17);
            this.rbtTodos.TabIndex = 59;
            this.rbtTodos.TabStop = true;
            this.rbtTodos.Text = "Ver todos";
            this.rbtTodos.UseVisualStyleBackColor = true;
            this.rbtTodos.CheckedChanged += new System.EventHandler(this.rbtTodos_CheckedChanged);
            // 
            // FrmHojaVidaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 766);
            this.Controls.Add(this.rbtInactivos);
            this.Controls.Add(this.rbtActivos);
            this.Controls.Add(this.rbtTodos);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.cboCapacidad);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.MaximizeBox = false;
            this.Name = "FrmHojaVidaEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOJA DE VIDA EQUIPO";
            this.Load += new System.EventHandler(this.FrmHojaVidaEquipo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHojaVidaEquipo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimiento)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboEquipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboPeriocidad;
        private System.Windows.Forms.ComboBox cboUbicacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Button btnPri;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSig;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvHojaVidaEquipo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnNuevoMantenimiento;
        private System.Windows.Forms.DataGridView dgvMantenimiento;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cboCapacidad;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Button btnACtuaizarMantenimiento;
        private System.Windows.Forms.RadioButton rbtInactivos;
        private System.Windows.Forms.RadioButton rbtActivos;
        private System.Windows.Forms.RadioButton rbtTodos;

    }
}