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
    public partial class FrmMantenimientoGenericoActualizar : Form
    {
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        OleDbCommandBuilder constructor;
        OleDbCommand comando;
        DataSet datos;

        public FrmMantenimientoGenericoActualizar()
        {
            InitializeComponent();
        }

        private void FrmMantenimientoGenericoActualizar_Load(object sender, EventArgs e)
        {
            for (double i = 0.0; i < 5; i += 0.1)
            {
                cboNota.Items.Add(Math.Round(i, 3));
            }
        }

        private void cboNota_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cboMantenimiento.Text == "" || cboProveedor.Text == "" || txtObservaciones.Text == "" || cboNota.Text == "")
            {
                MessageBox.Show("Faltan datos por llenar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                conexion = new OleDbConnection(ConexionBase.conectar());
                comando = new OleDbCommand();
                comando.Connection = conexion;

                comando.CommandText = "UPDATE MANTENIMIENTO_GENERICO SET cons=@cons, fecha=@fecha, mantenimiento=@mantenimiento, proveedor=@proveedor, descripcion_actividades_realizadas=@descripcion_actividades_realizadas, fecha_proximo_mto=@fecha_proximo_mto, observaciones=@observaciones, codigo_inventario=@codigo_inventario, nota=@nota WHERE id=@id";

                comando.Parameters.AddWithValue("@cons", txtCons.Text.ToString());
                comando.Parameters.AddWithValue("@fecha", dtpFecha.Text.ToString());
                comando.Parameters.AddWithValue("@mantenimiento", cboMantenimiento.Text);
                comando.Parameters.AddWithValue("@proveedor", cboProveedor.Text);
                comando.Parameters.AddWithValue("@descripcion_actividades_realizadas", txtDescripcionActividadesRealizadas.Text);
                comando.Parameters.AddWithValue("@fecha_proximo_mto", dtpfechaProximoMantenimiento.Text.ToString());
                comando.Parameters.AddWithValue("@observaciones", txtObservaciones.Text);
                comando.Parameters.AddWithValue("@codigo_inventario", txtCodigoInventario.Text);
                comando.Parameters.AddWithValue("@nota", cboNota.Text.ToString());
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

        private void cboMantenimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMantenimiento.Text == "PREVENTIVO")
            {
                txtObservaciones.Text = "NINGUNA";
                txtDescripcionActividadesRealizadas.Text = "MANTENIMIENTO PREVENTIVO";
            }
            else if (cboMantenimiento.Text == "CORRECTIVO")
            {
                txtObservaciones.Clear();
                txtDescripcionActividadesRealizadas.Clear();
            }
        }
    }
}
