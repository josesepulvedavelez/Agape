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
    public partial class FrmmantenimientoEquipoActualizar : Form
    {
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        OleDbCommandBuilder constructor;
        OleDbCommand comando;
        DataSet datos;

        public FrmmantenimientoEquipoActualizar()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
