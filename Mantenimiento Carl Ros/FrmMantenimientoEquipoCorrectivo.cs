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
    public partial class FrmMantenimientoEquipoCorrectivo : Form
    {
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        DataSet datos;
        BindingManagerBase bmb; 

        public FrmMantenimientoEquipoCorrectivo()
        {
            InitializeComponent();
        }

        private void FrmMantenimientoEquipoCorrectivo_Load(object sender, EventArgs e)
        {
            conexion = new OleDbConnection(ConexionBase.conectar());
            adaptador = new OleDbDataAdapter("SELECT fecha, mantenimiento, proveedor, descripcion_actividades_realizadas, fecha_proximo_mto, observaciones, codigo_inventario, nota FROM MANTENIMIENTO_EQUIPO WHERE mantenimiento = 'CORRECTIVO' ORDER BY fecha DESC", conexion);
            datos = new DataSet();

            conexion.Open();
            adaptador.Fill(datos);
            conexion.Close();

            dgvMantenimiento.DataSource = datos.Tables[0];
            bmb = BindingContext[datos.Tables[0]];

            this.registro(); 
        }

        public void registro()
        {
            txtRegistro.Text = "Mantenimiento " + (bmb.Position + 1) + " de " + datos.Tables[0].Rows.Count;
        }

        private void btbExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel exportarExcel = new ExportarExcel();
            exportarExcel.Exportar(dgvMantenimiento);
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
