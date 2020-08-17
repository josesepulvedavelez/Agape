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
    public partial class FrmMantenimientoInformeGeneral : Form
    {
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        DataSet datos;
        BindingManagerBase bmb; 

        public FrmMantenimientoInformeGeneral()
        {
            InitializeComponent();
        }

        private void FrmMantenimientoInformeGeneral_Load(object sender, EventArgs e)
        {
            //this.registro();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            conexion = new OleDbConnection(ConexionBase.conectar());
            
            if (cboMantenimiento.Text == "MANTENIMIENTO PREVENTIVO" && cboTipo.Text == "COMPUTO")
            {
                OleDbCommand comando = conexion.CreateCommand();
                comando.CommandText = "SELECT * FROM MANTENIMIENTO_COMPUTO WHERE mantenimiento = 'PREVENTIVO' AND fecha BETWEEN @desde AND @hasta ORDER BY fecha DESC, codigo_equipo";
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

            else if (cboMantenimiento.Text == "MANTENIMIENTO CORRECTIVO" && cboTipo.Text == "COMPUTO")
            {
                OleDbCommand comando = conexion.CreateCommand();
                comando.CommandText = "SELECT * FROM MANTENIMIENTO_COMPUTO WHERE mantenimiento = 'CORRECTIVO' AND fecha BETWEEN @desde AND @hasta ORDER BY fecha DESC, codigo_equipo";
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

            else if (cboMantenimiento.Text == "PREVENTIVO Y CORRECTIVO" && cboTipo.Text == "COMPUTO")
            {
                OleDbCommand comando = conexion.CreateCommand();
                comando.CommandText = "SELECT * FROM MANTENIMIENTO_COMPUTO WHERE fecha BETWEEN @desde AND @hasta ORDER BY fecha DESC, codigo_equipo";
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
                        
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarExcel exportarExcel = new ExportarExcel();
            exportarExcel.Exportar(dgvMantenimiento); 
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
               
    }
}
