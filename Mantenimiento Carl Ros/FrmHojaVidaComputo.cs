using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mantenimiento_Carl_Ros
{
    public partial class FrmHojaVidaComputo : Form
    {
        OleDbConnection conexion;
        OleDbDataAdapter adaptador, adaptador2, adaptador3;
        OleDbCommandBuilder constructor, constructor2, constructor3;
        DataSet datos;
        BindingManagerBase bmb;
        BindingManagerBase bmbPieza;
        OleDbCommand comando; 

        public FrmHojaVidaComputo()
        {
            InitializeComponent();
        }

        #region carga
        private void FrmHojaVidaComputo_Load(object sender, EventArgs e)
        {
            conexion = new OleDbConnection(ConexionBase.conectar());
            adaptador = new OleDbDataAdapter("SELECT * FROM HOJA_VIDA_COMPUTO ORDER BY codigo", conexion);
            constructor = new OleDbCommandBuilder(adaptador);
            constructor2 = new OleDbCommandBuilder(adaptador2);
            datos = new DataSet();

            conexion.Open();
            adaptador.Fill(datos);
            conexion.Close();

            dgvHojaVidaComputo.DataSource = datos.Tables[0]; 

            bmb = BindingContext[datos.Tables[0]];

            this.combos();
            registro();
        }

        public void combos()
        {
            cboPeriocidad.Items.Add("TRIMESTRAL");
            cboResponsable.Items.Add("JOSE SEPULVEDA");
            cboCargo.Items.Add("COORDINADOR DE MANTENIMIENTO");
            cboProceso.Items.Add("SERVICIOS GENERALES");
            cboJefeInmediato.Items.Add("SERGIO BARRIOS");
        }

        private void cboEquipo_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adaptadorEquipo = new OleDbDataAdapter("SELECT equipo FROM HOJA_VIDA_COMPUTO GROUP BY equipo ORDER BY equipo;", conexion);
            DataTable dt = new DataTable();

            adaptadorEquipo.Fill(dt);

            cboEquipo.DataSource = dt;
            cboEquipo.DisplayMember = "equipo";
        }


        private void cboUbicacion_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adaptadorUbicacion = new OleDbDataAdapter("SELECT codigo FROM PROCESO ORDER BY SEDE, codigo", conexion);
            DataTable dt = new DataTable();

            adaptadorUbicacion.Fill(dt);

            cboUbicacion.DataSource = dt;
            cboUbicacion.DisplayMember = "codigo";
        }

        private void dgvHojaVidaComputo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dtpFecha.Text = dgvHojaVidaComputo.CurrentRow.Cells["fecha_creacion"].Value.ToString();
                cboEquipo.Text = dgvHojaVidaComputo.CurrentRow.Cells["equipo"].Value.ToString();
                txtCodigo.Text = dgvHojaVidaComputo.CurrentRow.Cells["codigo"].Value.ToString();
                cboPeriocidad.Text = dgvHojaVidaComputo.CurrentRow.Cells["periocidad"].Value.ToString();
                txtDescripcion.Text = dgvHojaVidaComputo.CurrentRow.Cells["descripcion_equipo"].Value.ToString();
                cboUbicacion.Text = dgvHojaVidaComputo.CurrentRow.Cells["ubicacion"].Value.ToString();
                cboResponsable.Text = dgvHojaVidaComputo.CurrentRow.Cells["responsable"].Value.ToString();
                cboCargo.Text = dgvHojaVidaComputo.CurrentRow.Cells["cargo"].Value.ToString();
                cboProceso.Text = dgvHojaVidaComputo.CurrentRow.Cells["proceso"].Value.ToString();
                cboJefeInmediato.Text = dgvHojaVidaComputo.CurrentRow.Cells["jefe_inmediato"].Value.ToString();
                txtObservaciones.Text = dgvHojaVidaComputo.CurrentRow.Cells["observaciones"].Value.ToString();
                chkActivo.Checked = Convert.ToBoolean(dgvHojaVidaComputo.CurrentRow.Cells["activo"].Value);

                registro(); 
            }
            catch (Exception ex)
            {
                
            }
        }
        #endregion

        #region edicion
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dtpFecha.Text = DateTime.Now.Date.ToString();
            txtCodigo.Clear();
            txtDescripcion.Text = "COMPUTO";
            txtObservaciones.Text = "NINGUNA";

            btnInsertar.Enabled = true;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                 MessageBox.Show("Faltan datos por llenar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 txtCodigo.Focus(); 
            }
            else
            {
                DataRow row;
                row = datos.Tables[0].NewRow();

                row["fecha_creacion"] = dtpFecha.Text;
                row["equipo"] = cboEquipo.Text;
                row["codigo"] = txtCodigo.Text;
                row["periocidad"] = cboPeriocidad.Text;
                row["ubicacion"] = cboUbicacion.Text;
                row["descripcion_equipo"] = txtDescripcion.Text;
                row["responsable"] = cboResponsable.Text;
                row["cargo"] = cboCargo.Text;
                row["proceso"] = cboProceso.Text;
                row["jefe_inmediato"] = cboJefeInmediato.Text;
                row["observaciones"] = txtObservaciones.Text;
                row["activo"] = chkActivo.Checked;

                datos.Tables[0].Rows.Add(row);
                btnInsertar.Enabled = false;
                btnNuevo.Enabled = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            adaptador.Update(datos.Tables[0]);
            dgvHojaVidaComputo.Refresh();
            
        }
           
        #endregion

        #region navegacion pestañas
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                for (int i = dgvPieza.Rows.Count - 1; i >= 0; i--)
                {
                    dgvPieza.Rows.RemoveAt(i);
                }
                for (int i = dgvMantenimiento.Rows.Count - 1; i >= 0; i--)
                {
                    dgvMantenimiento.Rows.RemoveAt(i);
                }

                
            }

            else if (tabControl1.SelectedIndex == 1)
            {
                for (int i = dgvMantenimiento.Rows.Count - 1; i >= 0; i--)
                {
                    dgvMantenimiento.Rows.RemoveAt(i);
                }

                string codigo = txtCodigo.Text;
                adaptador2 = new OleDbDataAdapter("SELECT * FROM PIEZA WHERE codigo_equipo = '" + codigo + "' ", conexion);
                constructor2 = new OleDbCommandBuilder(adaptador2);

                conexion.Open();
                adaptador2.Fill(datos, "PIEZA");
                conexion.Close();

                dgvPieza.DataSource = datos;
                dgvPieza.DataMember = "PIEZA";
                dgvPieza.Columns["id"].Visible = false; 
                dgvPieza.Refresh();
                                 
            }

            else if (tabControl1.SelectedIndex == 2)
            {
                for (int i = dgvPieza.Rows.Count - 1; i >= 0; i--)
                {
                    dgvPieza.Rows.RemoveAt(i);
                }

                string codigo = txtCodigo.Text;

                adaptador3 = new OleDbDataAdapter("SELECT * FROM MANTENIMIENTO_COMPUTO WHERE codigo_equipo = '" + codigo + "' ORDER BY fecha DESC", conexion);
                constructor3 = new OleDbCommandBuilder(adaptador3);

                conexion.Open();
                adaptador3.Fill(datos, "MANTENIMIENTO_COMPUTO");
                conexion.Close();

                dgvMantenimiento.DataSource = datos;
                dgvMantenimiento.DataMember = "MANTENIMIENTO_COMPUTO";
                dgvMantenimiento.Columns["id"].Visible = false;
                dgvMantenimiento.Refresh();

            }
        }
        #endregion 

        #region navegacion registros
        private void registro() 
        {
            txtRegistro.Text = "Equipo de computo " + (bmb.Position + 1) + " de " + datos.Tables[0].Rows.Count;
        }

        private void btnPri_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            registro();
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            bmb.Position--;
            registro();
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            bmb.Position++;
            registro();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bmb.Position = datos.Tables[0].Rows.Count;
            registro();
        }
        #endregion
        
        private void btnNuevoPieza_Click(object sender, EventArgs e)
        {
            FrmPiezaInsertar frmPiezaInsertar = new FrmPiezaInsertar();
            frmPiezaInsertar.Show();
            frmPiezaInsertar.txtCodigoEquipo.Text = txtCodigo.Text; 
        }

        private void btnActualizarPieza_Click(object sender, EventArgs e)
        {
            if (dgvPieza.Rows.Count == 0)
            {
                MessageBox.Show("No hay piezas", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FrmPiezaActualizar frmPiezaActualizar = new FrmPiezaActualizar();
                frmPiezaActualizar.Show(); 
                
                frmPiezaActualizar.cboPieza.Text = dgvPieza.CurrentRow.Cells[0].Value.ToString();
                frmPiezaActualizar.cboMarca.Text = dgvPieza.CurrentRow.Cells[1].Value.ToString();
                frmPiezaActualizar.txtDescripcion.Text = dgvPieza.CurrentRow.Cells[2].Value.ToString();
                frmPiezaActualizar.txtSerial.Text = dgvPieza.CurrentRow.Cells[3].Value.ToString();
                frmPiezaActualizar.txtCodigoEquipo.Text = dgvPieza.CurrentRow.Cells[4].Value.ToString();
                frmPiezaActualizar.chkActivo.Checked = Convert.ToBoolean(dgvPieza.CurrentRow.Cells[5].Value.ToString());
                frmPiezaActualizar.txtId.Text = dgvPieza.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void btnNuevoMantenimiento_Click(object sender, EventArgs e)
        {
            FrmMantenimientoComputoInsertar frmMantenimientoComputoInsertar = new FrmMantenimientoComputoInsertar();
            frmMantenimientoComputoInsertar.Show();
            frmMantenimientoComputoInsertar.txtCodigoEquipo.Text = this.txtCodigo.Text; 
        }

        private void btnActualizarMantenimiento_Click(object sender, EventArgs e)
        {
            if (dgvMantenimiento.Rows.Count == 0)
            {
                MessageBox.Show("No hay mantenimientos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FrmMantenimientoComputoActualizar frmmantenimientoComputoActualizar = new FrmMantenimientoComputoActualizar();
                frmmantenimientoComputoActualizar.Show();

                frmmantenimientoComputoActualizar.txtCons.Text = dgvMantenimiento.CurrentRow.Cells["cons"].Value.ToString();
                frmmantenimientoComputoActualizar.dtpFecha.Text = dgvMantenimiento.CurrentRow.Cells["fecha"].Value.ToString();
                frmmantenimientoComputoActualizar.cboMantenimiento.Text = dgvMantenimiento.CurrentRow.Cells["mantenimiento"].Value.ToString();
                frmmantenimientoComputoActualizar.cboProveedor.Text = dgvMantenimiento.CurrentRow.Cells["proveedor"].Value.ToString();
                frmmantenimientoComputoActualizar.txtDescripcionActividadesRealizadas.Text = dgvMantenimiento.CurrentRow.Cells["descripcion_actividades_realizadas"].Value.ToString();
                frmmantenimientoComputoActualizar.dtpfechaProximoMantenimiento.Text = dgvMantenimiento.CurrentRow.Cells["fecha_proximo_mto"].Value.ToString();
                frmmantenimientoComputoActualizar.txtObservaciones.Text = dgvMantenimiento.CurrentRow.Cells["observaciones"].Value.ToString();
                frmmantenimientoComputoActualizar.txtCodigoEquipo.Text = dgvMantenimiento.CurrentRow.Cells["codigo_equipo"].Value.ToString();
                frmmantenimientoComputoActualizar.cboNota.Text = dgvMantenimiento.CurrentRow.Cells["nota"].Value.ToString();
                frmmantenimientoComputoActualizar.txtId.Text = dgvMantenimiento.CurrentRow.Cells["id"].Value.ToString();
                
            }
        }

        private void rbtInactivos_CheckedChanged(object sender, EventArgs e)
        {
            mostrar(); 
        }

        private void rbtActivos_CheckedChanged(object sender, EventArgs e)
        {
            mostrar();
        }

        private void rbtTodos_CheckedChanged(object sender, EventArgs e)
        {
            mostrar();
        }

        void mostrar() {

            if (rbtInactivos.Checked == true)
            {
                adaptador = new OleDbDataAdapter("SELECT * FROM HOJA_VIDA_COMPUTO WHERE activo=false ORDER BY codigo", conexion);
                constructor = new OleDbCommandBuilder(adaptador);
                constructor2 = new OleDbCommandBuilder(adaptador2);
                datos = new DataSet();

                conexion.Open();
                adaptador.Fill(datos);
                conexion.Close();

                dgvHojaVidaComputo.DataSource = datos.Tables[0];

                bmb = BindingContext[datos.Tables[0]];

                this.combos();
                registro();
            }
            else if (rbtActivos.Checked == true)
            {
                adaptador = new OleDbDataAdapter("SELECT * FROM HOJA_VIDA_COMPUTO WHERE activo=true ORDER BY codigo", conexion);
                constructor = new OleDbCommandBuilder(adaptador);
                constructor2 = new OleDbCommandBuilder(adaptador2);
                datos = new DataSet();

                conexion.Open();
                adaptador.Fill(datos);
                conexion.Close();

                dgvHojaVidaComputo.DataSource = datos.Tables[0];

                bmb = BindingContext[datos.Tables[0]];

                this.combos();
                registro();
            }
            else
            {                
                adaptador = new OleDbDataAdapter("SELECT * FROM HOJA_VIDA_COMPUTO ORDER BY codigo", conexion);
                constructor = new OleDbCommandBuilder(adaptador);
                constructor2 = new OleDbCommandBuilder(adaptador2);
                datos = new DataSet();

                conexion.Open();
                adaptador.Fill(datos);
                conexion.Close();

                dgvHojaVidaComputo.DataSource = datos.Tables[0];

                bmb = BindingContext[datos.Tables[0]];

                this.combos();
                registro();
            }
        }
                                             
    }//end class
}//end namespace