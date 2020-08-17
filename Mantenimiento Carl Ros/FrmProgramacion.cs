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
    public partial class FrmProgramacion : Form
    {
        private OleDbConnection conexion;
        private OleDbDataAdapter adaptador;
        private DataSet datos;

        public FrmProgramacion()
        {
            InitializeComponent();
        }

        private void FrmProgramacion_Load(object sender, EventArgs e)
        {
            conexion = new OleDbConnection(ConexionBase.conectar());
            adaptador = new OleDbDataAdapter("SELECT * FROM SEDE", conexion);
            datos = new DataSet();

            conexion.Open();
            adaptador.Fill(datos);
            conexion.Close();

            cboSede.DataSource = datos.Tables[0];
            cboSede.DisplayMember = "sede";
            cboSede.ValueMember = "codigo";
        }

        private void cboSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            sql = datos.Tables[0].Rows[cboSede.SelectedIndex][1].ToString();

            OleDbDataAdapter adaptador2 = new OleDbDataAdapter("SELECT * FROM PROCESO WHERE sede = '" + sql + "' ", conexion);
            DataSet datos2 = new DataSet();

            conexion.Open();
            adaptador2.Fill(datos2);
            conexion.Close();

            cboProceso.DataSource = datos2.Tables[0];

            cboProceso.DisplayMember = datos2.Tables[0].Columns[1].ToString();
        }

        private void btnProgramar_Click(object sender, EventArgs e)
        {
            if (cboActividad.Text == "MANTENIMIENTO PREVENTIVO COMPUTO")
            {
                conexion.Open();
                OleDbTransaction transaccion;
                OleDbCommand comando;
                transaccion = conexion.BeginTransaction();

                try
                {
                    comando = new OleDbCommand("UPDATE HOJA_VIDA_COMPUTO SET mant1=@mant1, mant2=@mant2, mant3=@mant3, mant4=@mant4 WHERE ubicacion='" + cboProceso.Text.ToString() + "' ", conexion);
                    comando.Parameters.AddWithValue("@mant1", Convert.ToDateTime(dtpMant1.Text));
                    comando.Parameters.AddWithValue("@mant2", Convert.ToDateTime(dtpMant2.Text));
                    comando.Parameters.AddWithValue("@mant3", Convert.ToDateTime(dtpMant3.Text));
                    comando.Parameters.AddWithValue("@mant4", Convert.ToDateTime(dtpMant4.Text));
                    comando.Transaction = transaccion;
                    comando.ExecuteNonQuery();

                    comando = new OleDbCommand("INSERT INTO PROGRAMACION(fecha, sede, proceso, actividad, objetivo, mant1, mant2, mant3, mant4, responsable, recursos, observaciones) VALUES(@fecha, @sede, @proceso, @actividad, @objetivo, @mant1, @mant2, @mant3, @mant4, @responsable, @recursos, @observaciones)", conexion);
                    comando.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dtpFecha.Text));
                    comando.Parameters.AddWithValue("@sede", cboSede.Text);
                    comando.Parameters.AddWithValue("@proceso", cboProceso.Text);
                    comando.Parameters.AddWithValue("@actividad", cboActividad.Text);
                    comando.Parameters.AddWithValue("@objetivo", cboObjetivo.Text);
                    comando.Parameters.AddWithValue("@mant1", Convert.ToDateTime(dtpMant1.Text));
                    comando.Parameters.AddWithValue("@mant2", Convert.ToDateTime(dtpMant2.Text));
                    comando.Parameters.AddWithValue("@mant3", Convert.ToDateTime(dtpMant3.Text));
                    comando.Parameters.AddWithValue("@mant4", Convert.ToDateTime(dtpMant4.Text));
                    comando.Parameters.AddWithValue("@responsable", txtResponsable.Text);
                    comando.Parameters.AddWithValue("@recursos", txtRecursos.Text);
                    comando.Parameters.AddWithValue("@observaciones", rtbObservaciones.Text);
                    comando.Transaction = transaccion;
                    comando.ExecuteNonQuery();

                    transaccion.Commit();
                    MessageBox.Show("Datos insertados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show(ex.Message);
                }
                conexion.Close();
            }
            else if (cboActividad.Text == "MANTENIMIENTO PREVENTIVO AUDIOVISUAL")
            {
                conexion.Open();
                OleDbTransaction transaccion;
                OleDbCommand comando;
                transaccion = conexion.BeginTransaction();

                try
                {
                    comando = new OleDbCommand("UPDATE HOJA_VIDA_EQUIPO SET mant1=@mant1, mant2=@mant2 WHERE ubicacion='" + cboProceso.Text.ToString() + "' AND descripcion_general='AUDIOVISUAL' ", conexion);
                    comando.Parameters.AddWithValue("@mant1", Convert.ToDateTime(dtpMant1.Text));
                    comando.Parameters.AddWithValue("@mant2", Convert.ToDateTime(dtpMant2.Text));
                    comando.Transaction = transaccion;
                    comando.ExecuteNonQuery();

                    comando = new OleDbCommand("INSERT INTO PROGRAMACION(fecha, sede, proceso, actividad, objetivo, mant1, mant2, responsable, recursos, observaciones) VALUES(@fecha, @sede, @proceso, @actividad, @objetivo, @mant1, @mant2, @responsable, @recursos, @observaciones)", conexion);
                    comando.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dtpFecha.Text));
                    comando.Parameters.AddWithValue("@sede", cboSede.Text);
                    comando.Parameters.AddWithValue("@proceso", cboProceso.Text);
                    comando.Parameters.AddWithValue("@actividad", cboActividad.Text);
                    comando.Parameters.AddWithValue("@objetivo", cboObjetivo.Text);
                    comando.Parameters.AddWithValue("@mant1", Convert.ToDateTime(dtpMant1.Text));
                    comando.Parameters.AddWithValue("@mant2", Convert.ToDateTime(dtpMant2.Text));
                    comando.Parameters.AddWithValue("@responsable", txtResponsable.Text);
                    comando.Parameters.AddWithValue("@recursos", txtRecursos.Text);
                    comando.Parameters.AddWithValue("@observaciones", rtbObservaciones.Text);
                    comando.Transaction = transaccion;
                    comando.ExecuteNonQuery();

                    transaccion.Commit();
                    MessageBox.Show("Datos insertados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show(ex.Message);
                }
                conexion.Close();
            }
            else if (cboActividad.Text == "MANTENIMIENTO PREVENTIVO AIRES")
            {
                conexion.Open();
                OleDbTransaction transaccion;
                OleDbCommand comando;
                transaccion = conexion.BeginTransaction();

                try
                {
                    comando = new OleDbCommand("UPDATE HOJA_VIDA_EQUIPO SET mant1=@mant1, mant2=@mant2, mant3=@mant3, mant4=@mant4 WHERE  ubicacion='" + cboProceso.Text.ToString() + "' AND equipo='AIRE ACONDICIONADO' ", conexion);
                    comando.Parameters.AddWithValue("@mant1", Convert.ToDateTime(dtpMant1.Text));
                    comando.Parameters.AddWithValue("@mant2", Convert.ToDateTime(dtpMant2.Text));
                    comando.Parameters.AddWithValue("@mant3", Convert.ToDateTime(dtpMant3.Text));
                    comando.Parameters.AddWithValue("@mant4", Convert.ToDateTime(dtpMant4.Text));
                    comando.Transaction = transaccion;
                    comando.ExecuteNonQuery();

                    comando = new OleDbCommand("INSERT INTO PROGRAMACION(fecha, sede, proceso, actividad, objetivo, mant1, mant2, mant3, mant4, responsable, recursos, observaciones) VALUES(@fecha, @sede, @proceso, @actividad, @objetivo, @mant1, @mant2, @mant3, @mant4, @responsable, @recursos, @observaciones)", conexion);
                    comando.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dtpFecha.Text));
                    comando.Parameters.AddWithValue("@sede", cboSede.Text);
                    comando.Parameters.AddWithValue("@proceso", cboProceso.Text);
                    comando.Parameters.AddWithValue("@actividad", cboActividad.Text);
                    comando.Parameters.AddWithValue("@objetivo", cboObjetivo.Text);
                    comando.Parameters.AddWithValue("@mant1", Convert.ToDateTime(dtpMant1.Text));
                    comando.Parameters.AddWithValue("@mant2", Convert.ToDateTime(dtpMant2.Text));
                    comando.Parameters.AddWithValue("@mant3", Convert.ToDateTime(dtpMant3.Text));
                    comando.Parameters.AddWithValue("@mant4", Convert.ToDateTime(dtpMant4.Text));
                    comando.Parameters.AddWithValue("@responsable", txtResponsable.Text);
                    comando.Parameters.AddWithValue("@recursos", txtRecursos.Text);
                    comando.Parameters.AddWithValue("@observaciones", rtbObservaciones.Text);
                    comando.Transaction = transaccion;
                    comando.ExecuteNonQuery();

                    transaccion.Commit();
                    MessageBox.Show("Datos insertados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show(ex.Message);
                }
                conexion.Close();
            }
            else if (cboActividad.Text == "MANTENIMIENTO PREVENTIVO COSMETOLOGIA")
            {
                conexion.Open();
                OleDbTransaction transaccion;
                OleDbCommand comando;
                transaccion = conexion.BeginTransaction();

                try
                {
                    comando = new OleDbCommand("UPDATE HOJA_VIDA_EQUIPO SET mant1=@mant1, mant2=@mant2 WHERE codigo_inventario LIKE 'E3CO%' ", conexion);
                    comando.Parameters.AddWithValue("@mant1", Convert.ToDateTime(dtpMant1.Text));
                    comando.Parameters.AddWithValue("@mant2", Convert.ToDateTime(dtpMant2.Text));

                    comando.Transaction = transaccion;
                    comando.ExecuteNonQuery();

                    comando = new OleDbCommand("INSERT INTO PROGRAMACION(fecha, sede, proceso, actividad, objetivo, mant1, mant2, responsable, recursos, observaciones) VALUES(@fecha, @sede, @proceso, @actividad, @objetivo, @mant1, @mant2, @responsable, @recursos, @observaciones)", conexion);
                    comando.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dtpFecha.Text));
                    comando.Parameters.AddWithValue("@sede", cboSede.Text);
                    comando.Parameters.AddWithValue("@proceso", cboProceso.Text);
                    comando.Parameters.AddWithValue("@actividad", cboActividad.Text);
                    comando.Parameters.AddWithValue("@objetivo", cboObjetivo.Text);
                    comando.Parameters.AddWithValue("@mant1", Convert.ToDateTime(dtpMant1.Text));
                    comando.Parameters.AddWithValue("@mant2", Convert.ToDateTime(dtpMant2.Text));
                    comando.Parameters.AddWithValue("@responsable", txtResponsable.Text);
                    comando.Parameters.AddWithValue("@recursos", txtRecursos.Text);
                    comando.Parameters.AddWithValue("@observaciones", rtbObservaciones.Text);
                    comando.Transaction = transaccion;
                    comando.ExecuteNonQuery();

                    transaccion.Commit();
                    MessageBox.Show("Datos insertados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show(ex.Message);
                }
                conexion.Close();
            }
            
            else if (cboActividad.Text == "MANTENIMIENTO PREVENTIVO MECANICA")
            {
                conexion.Open();
                OleDbTransaction transaccion;
                OleDbCommand comando;
                transaccion = conexion.BeginTransaction();

                try
                {
                    comando = new OleDbCommand("UPDATE HOJA_VIDA_EQUIPO SET mant1=@mant1, mant2=@mant2, mant3=@mant3, mant4=@mant4, mant5=@mant5, mant6=@mant6 WHERE descripcion_general = 'INFRAESTRUCTURA MECANICA' ", conexion);
                    comando.Parameters.AddWithValue("@mant1", Convert.ToDateTime(dtpMant1.Text));
                    comando.Parameters.AddWithValue("@mant2", Convert.ToDateTime(dtpMant2.Text));
                    comando.Parameters.AddWithValue("@mant3", Convert.ToDateTime(dtpMant3.Text));
                    comando.Parameters.AddWithValue("@mant4", Convert.ToDateTime(dtpMant4.Text));
                    comando.Parameters.AddWithValue("@mant5", Convert.ToDateTime(dtpMant5.Text));
                    comando.Parameters.AddWithValue("@mant6", Convert.ToDateTime(dtpMant6.Text));
                    comando.Transaction = transaccion;
                    comando.ExecuteNonQuery();

                    comando = new OleDbCommand("INSERT INTO PROGRAMACION(fecha, sede, proceso, actividad, objetivo, mant1, mant2, mant3, mant4, mant5, mant6, responsable, recursos, observaciones) VALUES(@fecha, @sede, @proceso, @actividad, @objetivo, @mant1, @mant2, @mant3, @mant4, @mant5, @mant6, @responsable, @recursos, @observaciones)", conexion);
                    comando.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dtpFecha.Text));
                    comando.Parameters.AddWithValue("@sede", cboSede.Text);
                    comando.Parameters.AddWithValue("@proceso", cboProceso.Text);
                    comando.Parameters.AddWithValue("@actividad", cboActividad.Text);
                    comando.Parameters.AddWithValue("@objetivo", cboObjetivo.Text);
                    comando.Parameters.AddWithValue("@mant1", Convert.ToDateTime(dtpMant1.Text));
                    comando.Parameters.AddWithValue("@mant2", Convert.ToDateTime(dtpMant2.Text));
                    comando.Parameters.AddWithValue("@mant3", Convert.ToDateTime(dtpMant3.Text));
                    comando.Parameters.AddWithValue("@mant4", Convert.ToDateTime(dtpMant4.Text));
                    comando.Parameters.AddWithValue("@mant5", Convert.ToDateTime(dtpMant5.Text));
                    comando.Parameters.AddWithValue("@mant6", Convert.ToDateTime(dtpMant6.Text));
                    comando.Parameters.AddWithValue("@responsable", txtResponsable.Text);
                    comando.Parameters.AddWithValue("@recursos", txtRecursos.Text);
                    comando.Parameters.AddWithValue("@observaciones", rtbObservaciones.Text);
                    comando.Transaction = transaccion;
                    comando.ExecuteNonQuery();

                    transaccion.Commit();
                    MessageBox.Show("Datos insertados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show(ex.Message);
                }
                conexion.Close();
            }
            else if (cboActividad.Text == "MANTENIMIENTO PREVENTIVO ENFERMERIA")
            {
                conexion.Open();
                OleDbTransaction transaccion;
                OleDbCommand comando;
                transaccion = conexion.BeginTransaction();

                try
                {
                    comando = new OleDbCommand("UPDATE HOJA_VIDA_EQUIPO SET mant1=@mant1, mant2=@mant2 WHERE ubicacion = 'LABORATORIO DE ENFERMERIA' AND equipo <> 'AIRE ACONDICIONADO' ", conexion);
                    comando.Parameters.AddWithValue("@mant1", Convert.ToDateTime(dtpMant1.Text));
                    comando.Parameters.AddWithValue("@mant2", Convert.ToDateTime(dtpMant2.Text));

                    comando.Transaction = transaccion;
                    comando.ExecuteNonQuery();

                    comando = new OleDbCommand("INSERT INTO PROGRAMACION(fecha, sede, proceso, actividad, objetivo, mant1, mant2, responsable, recursos, observaciones) VALUES(@fecha, @sede, @proceso, @actividad, @objetivo, @mant1, @mant2, @responsable, @recursos, @observaciones)", conexion);
                    comando.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dtpFecha.Text));
                    comando.Parameters.AddWithValue("@sede", cboSede.Text);
                    comando.Parameters.AddWithValue("@proceso", cboProceso.Text);
                    comando.Parameters.AddWithValue("@actividad", cboActividad.Text);
                    comando.Parameters.AddWithValue("@objetivo", cboObjetivo.Text);
                    comando.Parameters.AddWithValue("@mant1", Convert.ToDateTime(dtpMant1.Text));
                    comando.Parameters.AddWithValue("@mant2", Convert.ToDateTime(dtpMant2.Text));
                    comando.Parameters.AddWithValue("@responsable", txtResponsable.Text);
                    comando.Parameters.AddWithValue("@recursos", txtRecursos.Text);
                    comando.Parameters.AddWithValue("@observaciones", rtbObservaciones.Text);
                    comando.Transaction = transaccion;
                    comando.ExecuteNonQuery();

                    transaccion.Commit();
                    MessageBox.Show("Datos insertados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show(ex.Message);
                }
                conexion.Close();
            }

            else if (cboActividad.Text == "RECARGA EXTINTOR")
            {
                conexion.Open();
                OleDbTransaction transaccion;
                OleDbCommand comando;
                transaccion = conexion.BeginTransaction();

                try
                {
                    comando = new OleDbCommand("UPDATE HOJA_VIDA_EQUIPO SET mant1=@mant1, mant2=@mant2, mant3=@mant3, mant4=@mant4 WHERE ubicacion='" + cboProceso.Text.ToString() + "' AND equipo = 'EXTINTOR' ", conexion);
                    comando.Parameters.AddWithValue("@mant1", Convert.ToDateTime(dtpMant1.Text));
                    comando.Parameters.AddWithValue("@mant2", Convert.ToDateTime(dtpMant2.Text));
                    comando.Parameters.AddWithValue("@mant3", Convert.ToDateTime(dtpMant3.Text));
                    comando.Parameters.AddWithValue("@mant4", Convert.ToDateTime(dtpMant4.Text));
                    comando.Transaction = transaccion;
                    comando.ExecuteNonQuery();

                    comando = new OleDbCommand("INSERT INTO PROGRAMACION(fecha, sede, proceso, actividad, objetivo, mant1, mant2, mant3, mant4, responsable, recursos, observaciones) VALUES(@fecha, @sede, @proceso, @actividad, @objetivo, @mant1, @mant2, @mant3, @mant4, @responsable, @recursos, @observaciones)", conexion);
                    comando.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dtpFecha.Text));
                    comando.Parameters.AddWithValue("@sede", cboSede.Text);
                    comando.Parameters.AddWithValue("@proceso", cboProceso.Text);
                    comando.Parameters.AddWithValue("@actividad", cboActividad.Text);
                    comando.Parameters.AddWithValue("@objetivo", cboObjetivo.Text);
                    comando.Parameters.AddWithValue("@mant1", Convert.ToDateTime(dtpMant1.Text));
                    comando.Parameters.AddWithValue("@mant2", Convert.ToDateTime(dtpMant2.Text));
                    comando.Parameters.AddWithValue("@mant3", Convert.ToDateTime(dtpMant3.Text));
                    comando.Parameters.AddWithValue("@mant4", Convert.ToDateTime(dtpMant4.Text));
                    comando.Parameters.AddWithValue("@responsable", txtResponsable.Text);
                    comando.Parameters.AddWithValue("@recursos", txtRecursos.Text);
                    comando.Parameters.AddWithValue("@observaciones", rtbObservaciones.Text);
                    comando.Transaction = transaccion;
                    comando.ExecuteNonQuery();

                    transaccion.Commit();
                    MessageBox.Show("Datos insertados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show(ex.Message);
                }
                conexion.Close();
            }
                        
        }

        private void dtpMant1_ValueChanged(object sender, EventArgs e)
        {
            if (cboActividad.Text == "MANTENIMIENTO PREVENTIVO COMPUTO" || cboActividad.Text == "MANTENIMIENTO PREVENTIVO AUDIOVISUAL" || cboActividad.Text == "MANTENIMIENTO PREVENTIVO AIRES")
            {
                dtpMant2.Value = dtpMant1.Value.AddMonths(3);
                dtpMant3.Value = dtpMant1.Value.AddMonths(6);
                dtpMant4.Value = dtpMant1.Value.AddMonths(9);
            }
            else if (cboActividad.Text == "MANTENIMIENTO PREVENTIVO COSMETOLOGIA")
            {
                dtpMant2.Value = dtpMant1.Value.AddMonths(6);
                
            }
            else if (cboActividad.Text == "MANTENIMIENTO PREVENTIVO MECANICA")
            {
                dtpMant2.Value = dtpMant1.Value.AddMonths(2);
                dtpMant3.Value = dtpMant1.Value.AddMonths(4);
                dtpMant4.Value = dtpMant1.Value.AddMonths(6);
                dtpMant5.Value = dtpMant1.Value.AddMonths(8);
                dtpMant6.Value = dtpMant1.Value.AddMonths(10);
            }
            else if (cboActividad.Text == "MANTENIMIENTO PREVENTIVO ENFERMERIA")
            {
                dtpMant2.Value = dtpMant1.Value.AddMonths(6);
            }
            else if (cboActividad.Text == "RECARGA EXTINTOR")
            {
                dtpMant2.Value = dtpMant1.Value.AddYears(1);
                dtpMant3.Value = dtpMant1.Value.AddYears(2);
                dtpMant4.Value = dtpMant1.Value.AddYears(3);
            }
        }

        private void cboActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboActividad.Text == "MANTENIMIENTO PREVENTIVO COMPUTO")
            {
                cboObjetivo.Text = "REALIZAR MANTENIMIENTO PREVENTIVO COMPUTO";
            }
            else if (cboActividad.Text == "MANTENIMIENTO PREVENTIVO AUDIOVISUAL")
            {
                cboObjetivo.Text = "REALIZAR MANTENIMIENTO PREVENTIVO AUDIOVISUAL";
            }
            else if (cboActividad.Text == "MANTENIMIENTO PREVENTIVO AIRES")
            {
                cboObjetivo.Text = "REALIZAR MANTENIMIENTO PREVENTIVO AIRES";
            }
            else if (cboActividad.Text == "MANTENIMIENTO PREVENTIVO COSMETOLOGIA")
            {
                cboObjetivo.Text = "REALIZAR MANTENIMIENTO PREVENTIVO COSMETOLOGIA";
            }
            else if (cboActividad.Text == "MANTENIMIENTO PREVENTIVO MECANICA")
            {
                cboObjetivo.Text = "REALIZAR MANTENIMIENTO PREVENTIVO MECANICA";
            }
            else if (cboActividad.Text == "MANTENIMIENTO PREVENTIVO ENFERMERIA")
            {
                cboObjetivo.Text = "REALIZAR MANTENIMIENTO PREVENTIVO ENFERMERIA";
            }
            else if (cboActividad.Text == "RECARGA EXTINTOR")
            {
                cboObjetivo.Text = "REALIZAR RECARGA EXTINTOR"; 
            }
        }

        private void btnProgramacionHecha_Click(object sender, EventArgs e)
        {
            FrmProgramacionHecha frmProgramacionHecha = new FrmProgramacionHecha();
            //frmProgramacionHecha.MdiParent = this;
            frmProgramacionHecha.Show();
        }

        private void cboProceso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
