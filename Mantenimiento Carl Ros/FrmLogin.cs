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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string usuario, contraseña, nivel;
            usuario = txtUser.Text;
            contraseña = txtPass.Text;
            nivel = cboCargo.Text;

            if (validar(usuario, contraseña, nivel) == true)
            {
                FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
                frmMenuPrincipal.Show();

                frmMenuPrincipal.toolStripStatusLabel1.Text = usuario.ToString();
            }
            else
            {
                MessageBox.Show("Datos errados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtUser.Clear();
                txtPass.Clear();

                txtUser.Focus();
            }            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de salir de la aplicacion", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }     
        }

        bool validar(string usuario, string contraseña, string nivel)
        {
            OleDbConnection conexion = new OleDbConnection(ConexionBase.conectar());
            OleDbCommand comando;

            conexion.Open();
            string sql = "SELECT COUNT(*) FROM USUARIO WHERE usuario='" + usuario + "' AND contraseña='" + contraseña + "' AND nivel='" + nivel + "'";

            comando = conexion.CreateCommand();
            comando.CommandText = sql;

            int i;
            i = Convert.ToInt16(comando.ExecuteScalar());
            conexion.Close();

            if (i == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
