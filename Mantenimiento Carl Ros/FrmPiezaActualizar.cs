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
    public partial class FrmPiezaActualizar : Form
    {
        private OleDbConnection conexion;
        private OleDbDataAdapter adaptadorPieza;
        private OleDbDataAdapter adaptadorMarca;
        private OleDbDataAdapter adaptador;
        private OleDbCommandBuilder constructor;
        private DataSet datos;
        private OleDbCommand comando;

        public FrmPiezaActualizar()
        {
            InitializeComponent();
        }
        
        private void FrmPiezaActualizar_Load(object sender, EventArgs e)
        {
            conexion = new OleDbConnection(ConexionBase.conectar());
            adaptadorPieza = new OleDbDataAdapter("SELECT pieza FROM PIEZA GROUP BY pieza", conexion);
            adaptadorMarca = new OleDbDataAdapter("SELECT marca FROM PIEZA GROUP BY marca", conexion);
            datos = new DataSet();

            conexion.Open();
            adaptadorPieza.Fill(datos, "PIEZA");
            adaptadorMarca.Fill(datos, "MARCA");
            conexion.Close();


            cboMarca.DataSource = datos.Tables["MARCA"];
            cboMarca.DisplayMember = "marca";

            cboPieza.DataSource = datos.Tables["PIEZA"];
            cboPieza.DisplayMember = "pieza";

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cboPieza.Text == "")
            {
                MessageBox.Show("Faltan datos por llenar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                conexion = new OleDbConnection(ConexionBase.conectar());
                comando = new OleDbCommand();
                comando.Connection = conexion;

                comando.CommandText = "UPDATE PIEZA SET pieza=@pieza, marca=@marca, descripcion=@descripcion, serial=@serial, codigo_equipo=@codigo_equipo, activo=@activo WHERE id=@id";

                comando.Parameters.AddWithValue("@pieza", cboPieza.Text);
                comando.Parameters.AddWithValue("@marca", cboMarca.Text);
                comando.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                comando.Parameters.AddWithValue("@serial", txtSerial.Text);
                comando.Parameters.AddWithValue("@codigo_equipo", txtCodigoEquipo.Text);
                comando.Parameters.AddWithValue("@activo", chkActivo.Checked);
                comando.Parameters.AddWithValue("@id", txtId.Text);

                adaptador = new OleDbDataAdapter(comando);
                constructor = new OleDbCommandBuilder(adaptador);
                datos = new DataSet();

                conexion.Open();
                int i = comando.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show(i + " Datos actualizados");
            }
        }

    }
}
