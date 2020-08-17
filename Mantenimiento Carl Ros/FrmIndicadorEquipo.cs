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
    public partial class FrmIndicadorInfraestructura : Form
    {
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        OleDbDataAdapter adaptador2;
        OleDbDataAdapter adaptador3;
        OleDbCommandBuilder constructor;
        DataSet datos;
        BindingManagerBase bmb; 

        public FrmIndicadorInfraestructura()
        {
            InitializeComponent();
        }

        private void FrmIndicadorInfraestructura_Load(object sender, EventArgs e)
        {
            for (int i = 2014; i <= 2020; i++)
            {
                cboAnio.Items.Add("" + i);
            }
            cboAnio.Text = DateTime.Now.Date.Year.ToString();

            this.registro(); 
        }

        private void cboAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion = new OleDbConnection(ConexionBase.conectar());
            adaptador = new OleDbDataAdapter("SELECT * FROM INDICADOR_MANTENIMIENTOS_EQUIPO WHERE YEAR(fecha)='" + cboAnio.Text.ToString() + "' ", conexion);
            adaptador2 = new OleDbDataAdapter("TRANSFORM Count(INDICADOR_MANTENIMIENTOS_EQUIPO.ubicacion) AS CuentaDeubicacion SELECT INDICADOR_MANTENIMIENTOS_EQUIPO.descripcion_general AS equipo FROM INDICADOR_MANTENIMIENTOS_EQUIPO WHERE YEAR(fecha) = '"+cboAnio.Text+"' GROUP BY INDICADOR_MANTENIMIENTOS_EQUIPO.descripcion_general PIVOT Format([fecha],'mmm') In ('ene','feb','mar','abr','may','jun','jul','ago','sep','oct','nov','dic') ", conexion);
            adaptador3 = new OleDbDataAdapter("TRANSFORM Sum(nota) AS SumaDenota SELECT descripcion_general AS equipo FROM INDICADOR_MANTENIMIENTOS_EQUIPO WHERE nota>=3 AND YEAR(fecha) = '"+cboAnio.Text+"' GROUP BY descripcion_general PIVOT Format([fecha],'mmm') In ('ene','feb','mar','abr','may','jun','jul','ago','sep','oct','nov','dic')", conexion);

            constructor = new OleDbCommandBuilder(adaptador);

            datos = new DataSet();

            conexion.Open();
            adaptador.Fill(datos);
            adaptador2.Fill(datos, "INDICADOR_MANTENIMIENTOS_EQUIPO_TOTAL");
            adaptador3.Fill(datos, "INDICADOR_MANTENIMIENTOS_EQUIPO_APROBADAS");
            conexion.Close();

            dgvIndicadorMantenimientosComputo.DataSource = datos.Tables[0];
            dgvIndicadorMantenimientosEquipoTotal.DataSource = datos.Tables["INDICADOR_MANTENIMIENTOS_EQUIPO_TOTAL"];
            dgvIndicadorMantenimientosComputoAprobadas.DataSource = datos.Tables["INDICADOR_MANTENIMIENTOS_EQUIPO_APROBADAS"];
            dgvIndicadorMantenimientosComputo.Columns[0].Visible = false;

            bmb = BindingContext[datos.Tables[0]];
            this.registro();
        }

        private void registro()
        {
            txtRegistro.Text = "Equipo de computo " + (bmb.Position + 1) + " de " + datos.Tables[0].Rows.Count;
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
