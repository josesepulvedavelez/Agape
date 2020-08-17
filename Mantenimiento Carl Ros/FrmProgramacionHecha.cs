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
    public partial class FrmProgramacionHecha : Form
    {
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        OleDbCommandBuilder constructor;
        DataSet datos;
        BindingManagerBase bmb; 

        public FrmProgramacionHecha()
        {
            InitializeComponent();
        }

        private void FrmProgramacionHecha_Load(object sender, EventArgs e)
        {
            for (int i = 2014; i <= 2020; i++)
            {
                cboAnio.Items.Add("" + i);
            }
            cboAnio.Text = DateTime.Now.Date.Year.ToString(); 
        }

        private void cargar() {
            //this.Text = DateTime.Now.Date.Year.ToString(); 
            conexion = new OleDbConnection(ConexionBase.conectar());
            adaptador = new OleDbDataAdapter("SELECT * FROM PROGRAMACION ORDER BY sede, proceso", conexion);
            constructor = new OleDbCommandBuilder(adaptador);

            datos = new DataSet();

            conexion.Open();
            adaptador.Fill(datos);
            conexion.Close();

            dgvProgramacion.DataSource = datos.Tables[0];

            bmb = BindingContext[datos.Tables[0]];
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel exportarExcel = new ExportarExcel();
            exportarExcel.Exportar(dgvProgramacion);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //adaptador.Update(datos.Tables[0]);
        }

        private void cboAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion = new OleDbConnection(ConexionBase.conectar());
            adaptador = new OleDbDataAdapter("SELECT * FROM PROGRAMACION WHERE YEAR(fecha)='" + cboAnio.Text.ToString() + "' ORDER BY sede, proceso", conexion);
            constructor = new OleDbCommandBuilder(adaptador);

            datos = new DataSet();

            conexion.Open();
            adaptador.Fill(datos);
            conexion.Close();

            dgvProgramacion.DataSource = datos.Tables[0];

            bmb = BindingContext[datos.Tables[0]];
        }
    }
}
