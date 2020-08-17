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
    public partial class FrmIndicadorComputo : Form
    {
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        OleDbDataAdapter adaptador2;
        OleDbDataAdapter adaptador3;
        OleDbCommandBuilder constructor;
        DataSet datos;
        BindingManagerBase bmb; 

        public FrmIndicadorComputo()
        {
            InitializeComponent();
        }

        private void FrmIndicadorComputo_Load(object sender, EventArgs e)
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
            adaptador = new OleDbDataAdapter("SELECT * FROM INDICADOR_MANTENIMIENTOS_COMPUTO WHERE YEAR(fecha)='" + cboAnio.Text.ToString() + "' ", conexion);
            adaptador2 = new OleDbDataAdapter("TRANSFORM Count(INDICADOR_MANTENIMIENTOS_COMPUTO.ubicacion) AS CuentaDeubicacion SELECT INDICADOR_MANTENIMIENTOS_COMPUTO.descripcion_equipo AS equipo FROM INDICADOR_MANTENIMIENTOS_COMPUTO WHERE YEAR(fecha) = '" + cboAnio.Text + "' GROUP BY INDICADOR_MANTENIMIENTOS_COMPUTO.descripcion_equipo PIVOT Format([fecha],'mmm') In ('ene','feb','mar','abr','may','jun','jul','ago','sep','oct','nov','dic')", conexion);
            adaptador3 = new OleDbDataAdapter("TRANSFORM sum(nota) SELECT descripcion_equipo AS equipo FROM INDICADOR_MANTENIMIENTOS_COMPUTO WHERE nota>=3 AND YEAR(fecha) = '" + cboAnio.Text + "' GROUP BY descripcion_equipo PIVOT Format([fecha],'mmm') In ('ene','feb','mar','abr','may','jun','jul','ago','sep','oct','nov','dic')", conexion);

            constructor = new OleDbCommandBuilder(adaptador);

            datos = new DataSet();

            conexion.Open();
            adaptador.Fill(datos);
            adaptador2.Fill(datos, "INDICADOR_MANTENIMIENTOS_COMPUTO_TOTAL");
            adaptador3.Fill(datos, "INDICADOR_MANTENIMIENTOS_COMPUTO_APROBADAS");
            conexion.Close();

            dgvIndicadorMantenimientosEquipo.DataSource = datos.Tables[0];
            dgvIndicadorMantenimientosComputoTotal.DataSource = datos.Tables["INDICADOR_MANTENIMIENTOS_COMPUTO_TOTAL"];
            dgvIndicadorMantenimientosComputoAprobadas.DataSource = datos.Tables["INDICADOR_MANTENIMIENTOS_COMPUTO_APROBADAS"]; 
            dgvIndicadorMantenimientosEquipo.Columns[0].Visible = false;

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
