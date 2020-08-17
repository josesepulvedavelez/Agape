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
    public partial class FrmSede : Form
    {
        private OleDbConnection conexion;
        private OleDbDataAdapter adaptador1;
        private OleDbDataAdapter adaptador2;
        private OleDbCommandBuilder cmdB1;
        private OleDbCommandBuilder cmdB2;
        private DataSet datos;
        private DataRelation relacion; 

        public FrmSede()
        {
            InitializeComponent();
        }

        private void FrmSede_Load(object sender, EventArgs e)
        {
            conexion = new OleDbConnection(ConexionBase.conectar());
            adaptador1 = new OleDbDataAdapter("SELECT * FROM SEDE", conexion);
            adaptador2 = new OleDbDataAdapter("SELECT * FROM PROCESO", conexion);
            cmdB1 = new OleDbCommandBuilder(adaptador1);
            cmdB2 = new OleDbCommandBuilder(adaptador2);

            datos = new DataSet();

            conexion.Open();
            adaptador1.Fill(datos, "SEDE");
            adaptador2.Fill(datos, "PROCESO");
            conexion.Close();

            relacion = new DataRelation("llave", datos.Tables["SEDE"].Columns["codigo"], datos.Tables["PROCESO"].Columns["sede"]);
            datos.Relations.Add(relacion);

            dgvSede.DataSource = datos;
            dgvSede.DataMember = "SEDE";
            dgvSede.AutoResizeColumns();

            dgvProceso.DataSource = datos;
            dgvProceso.DataMember = "SEDE.llave";
            dgvProceso.AutoResizeColumns();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //adaptador1.Update(datos, "SEDE");
            adaptador2.Update(datos, "PROCESO");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvProceso.AllowUserToAddRows = true;
        }
    }
}
