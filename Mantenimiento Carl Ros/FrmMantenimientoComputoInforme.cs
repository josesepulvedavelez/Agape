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
    public partial class FrmMantenimientoComputoInforme : Form
    {
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        DataSet datos;
        BindingManagerBase bmb; 

        public FrmMantenimientoComputoInforme()
        {
            InitializeComponent();
        }

        private void FrmMantenimientoComputoInforme_Load(object sender, EventArgs e)
        {
           
        }
        
        private void cboProceso_Click(object sender, EventArgs e)
        {
            conexion = new OleDbConnection(ConexionBase.conectar());
            adaptador = new OleDbDataAdapter("SELECT * FROM PROCESO", conexion);
            datos = new DataSet();

            conexion.Open();
            adaptador.Fill(datos);
            conexion.Close();

            cboProceso.DataSource = datos.Tables[0];
            
            cboProceso.DisplayMember = "proceso";
            cboProceso.ValueMember = "codigo";
        }

       private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            conexion = new OleDbConnection(ConexionBase.conectar());
           
            if (cboMantenimiento.Text == "MANTENIMIENTO PREVENTIVO" && cboProceso.Text == "")
            {
                OleDbCommand comando = conexion.CreateCommand();
                comando.CommandText = "SELECT ubicacion, fecha, mantenimiento, proveedor, descripcion_actividades_realizadas, fecha_proximo_mto, MC.observaciones, codigo_equipo FROM HOJA_VIDA_COMPUTO AS HVE, MANTENIMIENTO_COMPUTO AS MC WHERE codigo = codigo_equipo AND mantenimiento = 'PREVENTIVO' AND fecha BETWEEN @desde AND @hasta ORDER BY fecha DESC";
                comando.Parameters.AddWithValue("@desde", dtpDesde.Value.Date);
                comando.Parameters.AddWithValue("@hasta", dtpHasta.Value.Date);
                
                adaptador = new OleDbDataAdapter(comando);
                datos = new DataSet();

                conexion.Open();
                adaptador.Fill(datos);
                conexion.Close();

                dgvMantenimiento.DataSource = datos.Tables[0];
                bmb = BindingContext[datos.Tables[0]];

                this.registro();
            }

            else if (cboMantenimiento.Text == "MANTENIMIENTO PREVENTIVO")
            {
                OleDbCommand comando = conexion.CreateCommand();
                comando.CommandText = "SELECT ubicacion, fecha, mantenimiento, proveedor, descripcion_actividades_realizadas, fecha_proximo_mto, MC.observaciones, codigo_equipo FROM HOJA_VIDA_COMPUTO AS HVE, MANTENIMIENTO_COMPUTO AS MC WHERE codigo = codigo_equipo AND mantenimiento = 'PREVENTIVO' AND fecha BETWEEN @desde AND @hasta AND ubicacion = @ubicacion ORDER BY fecha DESC";
                comando.Parameters.AddWithValue("@desde", dtpDesde.Value.Date);
                comando.Parameters.AddWithValue("@hasta", dtpHasta.Value.Date);
                comando.Parameters.AddWithValue("@ubicacion", cboProceso.Text);

                adaptador = new OleDbDataAdapter(comando);
                datos = new DataSet();

                conexion.Open();
                adaptador.Fill(datos);
                conexion.Close();

                dgvMantenimiento.DataSource = datos.Tables[0];
                bmb = BindingContext[datos.Tables[0]];

                this.registro();
            }

            else if (cboMantenimiento.Text == "MANTENIMIENTO CORRECTIVO" && cboProceso.Text == "")
            {
                OleDbCommand comando = conexion.CreateCommand();
                comando.CommandText = "SELECT ubicacion, fecha, mantenimiento, proveedor, descripcion_actividades_realizadas, fecha_proximo_mto, MC.observaciones, codigo_equipo FROM HOJA_VIDA_COMPUTO AS HVE, MANTENIMIENTO_COMPUTO AS MC WHERE codigo = codigo_equipo AND mantenimiento = 'CORRECTIVO' AND fecha BETWEEN @desde AND @hasta ORDER BY fecha DESC";
                comando.Parameters.AddWithValue("@desde", dtpDesde.Value.Date);
                comando.Parameters.AddWithValue("@hasta", dtpHasta.Value.Date);

                adaptador = new OleDbDataAdapter(comando);
                datos = new DataSet();

                conexion.Open();
                adaptador.Fill(datos);
                conexion.Close();

                dgvMantenimiento.DataSource = datos.Tables[0];
                bmb = BindingContext[datos.Tables[0]];

                this.registro();
            }

            else if (cboMantenimiento.Text == "MANTENIMIENTO CORRECTIVO")
            {
                OleDbCommand comando = conexion.CreateCommand();
                comando.CommandText = "SELECT ubicacion, fecha, mantenimiento, proveedor, descripcion_actividades_realizadas, fecha_proximo_mto, MC.observaciones, codigo_equipo FROM HOJA_VIDA_COMPUTO AS HVE, MANTENIMIENTO_COMPUTO AS MC WHERE codigo = codigo_equipo AND mantenimiento = 'CORRECTIVO' AND fecha BETWEEN @desde AND @hasta AND ubicacion = @ubicacion ORDER BY fecha DESC";
                comando.Parameters.AddWithValue("@desde", dtpDesde.Value.Date);
                comando.Parameters.AddWithValue("@hasta", dtpHasta.Value.Date);
                comando.Parameters.AddWithValue("@ubicacion", cboProceso.Text);

                adaptador = new OleDbDataAdapter(comando);
                datos = new DataSet();

                conexion.Open();
                adaptador.Fill(datos);
                conexion.Close();

                dgvMantenimiento.DataSource = datos.Tables[0];
                bmb = BindingContext[datos.Tables[0]];

                this.registro();
            }

            else if (cboMantenimiento.Text == "PREVENTIVO Y CORRECTIVO" && cboProceso.Text == "")
            {
                OleDbCommand comando = conexion.CreateCommand();
                comando.CommandText = "SELECT ubicacion, fecha, mantenimiento, proveedor, descripcion_actividades_realizadas, fecha_proximo_mto, MC.observaciones, codigo_equipo FROM HOJA_VIDA_COMPUTO AS HVE, MANTENIMIENTO_COMPUTO AS MC WHERE codigo = codigo_equipo AND fecha BETWEEN @desde AND @hasta ORDER BY fecha DESC";
                comando.Parameters.AddWithValue("@desde", dtpDesde.Value.Date);
                comando.Parameters.AddWithValue("@hasta", dtpHasta.Value.Date);

                adaptador = new OleDbDataAdapter(comando);
                datos = new DataSet();

                conexion.Open();
                adaptador.Fill(datos);
                conexion.Close();

                dgvMantenimiento.DataSource = datos.Tables[0];
                bmb = BindingContext[datos.Tables[0]];

                this.registro();
            }

            else if (cboMantenimiento.Text == "PREVENTIVO Y CORRECTIVO")
            {
                OleDbCommand comando = conexion.CreateCommand();
                comando.CommandText = "SELECT ubicacion, fecha, mantenimiento, proveedor, descripcion_actividades_realizadas, fecha_proximo_mto, MC.observaciones, codigo_equipo FROM HOJA_VIDA_COMPUTO AS HVE, MANTENIMIENTO_COMPUTO AS MC WHERE codigo = codigo_equipo AND fecha BETWEEN @desde AND @hasta AND ubicacion=@ubicacion ORDER BY fecha DESC";
                comando.Parameters.AddWithValue("@desde", dtpDesde.Value.Date);
                comando.Parameters.AddWithValue("@hasta", dtpHasta.Value.Date);
                comando.Parameters.AddWithValue("@ubicacion", cboProceso.Text);

                adaptador = new OleDbDataAdapter(comando);
                datos = new DataSet();

                conexion.Open();
                adaptador.Fill(datos);
                conexion.Close();

                dgvMantenimiento.DataSource = datos.Tables[0];
                bmb = BindingContext[datos.Tables[0]];

                this.registro();
            }
        }     
                    
        public void registro()
        {
            txtRegistro.Text = "Mantenimiento " + (bmb.Position + 1) + " de " + datos.Tables[0].Rows.Count;
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
            bmb.Position = datos.Tables[0].Rows.Count - 1;
            this.registro();
        }
        
        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarExcel exportarExcel = new ExportarExcel();
            exportarExcel.Exportar(dgvMantenimiento); 
        }
               
    }
}
