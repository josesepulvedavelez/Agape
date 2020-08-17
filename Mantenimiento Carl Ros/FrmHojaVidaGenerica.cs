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
    public partial class FrmHojaVidaGenerica : Form
    {
        static FrmHojaVidaGenerica fix;

        OleDbConnection conexion;
        OleDbDataAdapter adaptador, adaptador2;
        OleDbCommandBuilder constructor, constructor2;
        DataSet datos;
        BindingManagerBase bmb, bmbMant; 

        public FrmHojaVidaGenerica()
        {
            InitializeComponent();
        }

        #region carga
        private void FrmHojaVidaGenerica_Load(object sender, EventArgs e)
        {
            FrmHojaVidaGenerica.fix = this;

            conexion = new OleDbConnection(ConexionBase.conectar());
            adaptador = new OleDbDataAdapter("SELECT * FROM HOJA_VIDA_GENERICO ORDER BY codigo_inventario", conexion);
            constructor = new OleDbCommandBuilder(adaptador);

            datos = new DataSet();

            conexion.Open();
            adaptador.Fill(datos);
            conexion.Close();

            dgvHojaVidaEquipo.DataSource = datos.Tables[0];
            bmb = BindingContext[datos.Tables[0]];

            this.combos();
            this.registro();
        }

        public void combos()
        {
            cboPeriocidad.Items.Add("TRIMESTRAL");
            cboPeriocidad.Items.Add("BIMENSUAL");
        }

        private void cboEquipo_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adaptadorEquipo = new OleDbDataAdapter("SELECT equipo FROM HOJA_VIDA_GENERICO GROUP BY equipo ORDER BY equipo;", conexion);
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

        private void dgvHojaVidaEquipo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dtpFecha.Text = dgvHojaVidaEquipo.CurrentRow.Cells["fecha_creacion"].Value.ToString();
                cboEquipo.Text = dgvHojaVidaEquipo.CurrentRow.Cells["equipo"].Value.ToString();
                txtCodigo.Text = dgvHojaVidaEquipo.CurrentRow.Cells["codigo_inventario"].Value.ToString();
                cboPeriocidad.Text = dgvHojaVidaEquipo.CurrentRow.Cells["periocidad_mto"].Value.ToString();
                cboUbicacion.Text = dgvHojaVidaEquipo.CurrentRow.Cells["ubicacion"].Value.ToString();
                cboMarca.Text = dgvHojaVidaEquipo.CurrentRow.Cells["marca"].Value.ToString();
                cboModelo.Text = dgvHojaVidaEquipo.CurrentRow.Cells["modelo"].Value.ToString();
                txtSerie.Text = dgvHojaVidaEquipo.CurrentRow.Cells["serie"].Value.ToString();
                cboCapacidad.Text = dgvHojaVidaEquipo.CurrentRow.Cells["capacidad"].Value.ToString();
                cboTipo.Text = dgvHojaVidaEquipo.CurrentRow.Cells["tipo"].Value.ToString();
                txtDescripcion.Text = dgvHojaVidaEquipo.CurrentRow.Cells["descripcion_general"].Value.ToString();
                chkActivo.Checked = Convert.ToBoolean(dgvHojaVidaEquipo.CurrentRow.Cells["activo"].Value);

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
            dtpFecha.Text = DateTime.Now.ToString();
            txtCodigo.Clear();
            txtDescripcion.Text = "INFRAESTRUCTURA";

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
                row["codigo_inventario"] = txtCodigo.Text;
                row["periocidad_mto"] = cboPeriocidad.Text;
                row["ubicacion"] = cboUbicacion.Text;
                row["marca"] = cboMarca.Text;
                row["modelo"] = cboModelo.Text;
                row["serie"] = txtSerie.Text;
                row["capacidad"] = cboCapacidad.Text;
                row["tipo"] = cboTipo.Text;
                row["descripcion_general"] = txtDescripcion.Text;
                row["activo"] = chkActivo.Checked;

                datos.Tables[0].Rows.Add(row);
                btnInsertar.Enabled = false;
                btnNuevo.Enabled = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            adaptador.Update(datos.Tables[0]);
            dgvHojaVidaEquipo.Refresh();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                dgvHojaVidaEquipo.Rows.RemoveAt(dgvHojaVidaEquipo.CurrentRow.Index);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                dgvMantenimiento.Rows.RemoveAt(dgvMantenimiento.CurrentRow.Index);
            }
        }
        #endregion    
 
        #region navegacion_pestañas 
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                for (int i = dgvMantenimiento.Rows.Count - 1; i >= 0; i--)
                {
                    dgvMantenimiento.Rows.RemoveAt(i);
                }
                                 
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                string codigo = txtCodigo.Text;

                adaptador2 = new OleDbDataAdapter("SELECT * FROM MANTENIMIENTO_GENERICO WHERE codigo_inventario = '" + codigo + "' ORDER BY fecha DESC ", conexion);
                constructor2 = new OleDbCommandBuilder(adaptador2);

                conexion.Open();
                adaptador2.Fill(datos, "MANTENIMIENTO_GENERICO");
                conexion.Close();

                dgvMantenimiento.DataSource = datos;
                dgvMantenimiento.DataMember = "MANTENIMIENTO_GENERICO";
                dgvMantenimiento.Columns["id"].Visible = false;
                dgvMantenimiento.Refresh();
                               
            }
        }
        #endregion 

        #region navegacion_registros
        private void registro()
        {
            txtRegistro.Text = "Equipo de generico " + (bmb.Position + 1) + " de " + datos.Tables[0].Rows.Count;
        }

        private void btnPri_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            this.registro();
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            bmb.Position--;
            this.registro();
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            bmb.Position++;
            this.registro(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bmb.Position = datos.Tables[0].Rows.Count;
            this.registro();
        }
        #endregion 

        private void btnNuevoMantenimiento_Click(object sender, EventArgs e)
        {
            FrmMantenimientoGenericoInsertar frmMantenimientoGenericoInsertar = new FrmMantenimientoGenericoInsertar();
            frmMantenimientoGenericoInsertar.Show();
            frmMantenimientoGenericoInsertar.txtCodigoInventario.Text = fix.txtCodigo.Text;
        }

        private void btnACtuaizarMantenimiento_Click(object sender, EventArgs e)
        {
            if (dgvMantenimiento.Rows.Count == 0)
            {
                MessageBox.Show("No hay mantenimientos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FrmMantenimientoGenericoActualizar frmMantenimientoGenericoActualizar = new FrmMantenimientoGenericoActualizar();
                frmMantenimientoGenericoActualizar.Show();

                frmMantenimientoGenericoActualizar.txtCons.Text = dgvMantenimiento.CurrentRow.Cells["cons"].Value.ToString();
                frmMantenimientoGenericoActualizar.dtpFecha.Text = dgvMantenimiento.CurrentRow.Cells["fecha"].Value.ToString();
                frmMantenimientoGenericoActualizar.cboMantenimiento.Text = dgvMantenimiento.CurrentRow.Cells["mantenimiento"].Value.ToString();
                frmMantenimientoGenericoActualizar.cboProveedor.Text = dgvMantenimiento.CurrentRow.Cells["proveedor"].Value.ToString();
                frmMantenimientoGenericoActualizar.txtDescripcionActividadesRealizadas.Text = dgvMantenimiento.CurrentRow.Cells["descripcion_actividades_realizadas"].Value.ToString();
                frmMantenimientoGenericoActualizar.dtpfechaProximoMantenimiento.Text = dgvMantenimiento.CurrentRow.Cells["fecha_proximo_mto"].Value.ToString();
                frmMantenimientoGenericoActualizar.txtObservaciones.Text = dgvMantenimiento.CurrentRow.Cells["observaciones"].Value.ToString();
                frmMantenimientoGenericoActualizar.txtCodigoInventario.Text = dgvMantenimiento.CurrentRow.Cells["codigo_inventario"].Value.ToString();
                frmMantenimientoGenericoActualizar.cboNota.Text = dgvMantenimiento.CurrentRow.Cells["nota"].Value.ToString();
                frmMantenimientoGenericoActualizar.txtId.Text = dgvMantenimiento.CurrentRow.Cells["id"].Value.ToString();

            }
        }
        
    }
}
