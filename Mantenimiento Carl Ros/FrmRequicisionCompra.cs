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
    public partial class FrmRequicisionCompra : Form
    {        
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        OleDbCommandBuilder constructor;
        DataSet datos; 

        public FrmRequicisionCompra()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            conexion = new OleDbConnection(ConexionBase.conectar());
            conexion.Open();

            OleDbTransaction transaccion;
            OleDbCommand comando;

            transaccion = conexion.BeginTransaction();

            comando = new OleDbCommand("INSERT INTO REQUISICION(tipo, no) VALUES(@tipo, @no)", conexion);
            comando.Parameters.AddWithValue("@tipo", cboTipo.Text.ToString());
            comando.Parameters.AddWithValue("@no", txtNo.Text.ToString());
            comando.Transaction = transaccion;
            comando.ExecuteNonQuery();

            transaccion.Commit();
            conexion.Close(); 
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvRequisicion.Rows.Add(1);
        }
    }
}
