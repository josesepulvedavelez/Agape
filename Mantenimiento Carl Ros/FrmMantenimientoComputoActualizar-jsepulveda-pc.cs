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
    public partial class FrmMantenimientoComputoActualizar : Form
    {
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        OleDbCommandBuilder constructor;
        OleDbCommand comando;
        DataSet datos;

        public FrmMantenimientoComputoActualizar()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cboMantenimiento.Text == "" || cboProveedor.Text == "" || txtObservaciones.Text == "")
            {
                MessageBox.Show("Faltan datos por llenar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                conexion = new OleDbConnection(ConexionBase.conectar());
                comando = new OleDbCommand();
                comando.Connection = conexion;

                comando.CommandText = "UPDATE MANTENIMIENTO_COMPUTO SET No=@No, fecha=@fecha, mantenimiento=@mantenimiento, proveedor=@proveedor, descripcion_actividades_realizadas=@descripcion_actividades_realizadas, fecha_proximo_mto=@fecha_proximo_mto, observaciones=@observaciones, codigo_equipo=@codigo_equipo WHERE id=@id";

                comando.Parameters.AddWithValue("@No", txtNo.Text.ToString());
                comando.Parameters.AddWithValue("@fecha", dtpFecha.Text.ToString());
                comando.Parameters.AddWithValue("@mantenimiento", cboMantenimiento.Text);
                comando.Parameters.AddWithValue("@proveedor", cboProveedor.Text);
                comando.Parameters.AddWithValue("@descripcion_actividades_realizadas", txtDescripcionActividadesRealizadas.Text);
                comando.Parameters.AddWithValue("@fecha_proximo_mto", dtpfechaProximoMantenimiento.Text.ToString());
                comando.Parameters.AddWithValue("@observaciones", txtObservaciones.Text);
                comando.Parameters.AddWithValue("@codigo_equipo", txtCodigoEquipo.Text);
                //comando.Parameters.AddWithValue("@nota", cboNota.Text.ToString());
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
