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
    public partial class FrmServiciosTecnicosCorrectivos : Form
    {
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        DataSet datos;
        BindingManagerBase bmb; 

        public FrmServiciosTecnicosCorrectivos()
        {
            InitializeComponent();
        }
        
        private void FrmServiciosTecnicos_Load(object sender, EventArgs e)
        {
            conexion = new OleDbConnection(ConexionBase.conectar());
            adaptador = new OleDbDataAdapter("SELECT * FROM MANTENIMIENTOS_ WHERE mantenimiento = 'CORRECTIVO' ", conexion);
            
            datos = new DataSet();

            conexion.Open();
            adaptador.Fill(datos);
            conexion.Close();

            dgvMantenimiento.DataSource = datos.Tables[0];
            dgvMantenimiento.Columns[9].Visible = false; 
            bmb = BindingContext[datos.Tables[0]];

            this.registro(); 
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarExcel ex = new ExportarExcel();
            ex.Exportar(dgvMantenimiento);
        }

        public void registro() {
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
