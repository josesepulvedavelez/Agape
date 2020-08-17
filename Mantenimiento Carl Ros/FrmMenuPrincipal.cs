using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mantenimiento_Carl_Ros
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de salir de la aplicacion", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void hojaDeVidaComputoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHojaVidaComputo frmHojaVidaComputo = new FrmHojaVidaComputo();
            frmHojaVidaComputo.MdiParent = this;
            frmHojaVidaComputo.Show();
        }

        private void sedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSede frmSede = new FrmSede();
            frmSede.MdiParent = this;
            frmSede.Show();
        }

        private void programacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProgramacion frmProgramacion = new FrmProgramacion();
            frmProgramacion.MdiParent = this;
            frmProgramacion.Show(); 
        }

        private void hojaDeVidaEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHojaVidaEquipo frmHojaVidaEquipo = new FrmHojaVidaEquipo();
            frmHojaVidaEquipo.MdiParent = this;
            frmHojaVidaEquipo.Show(); 
        }

        private void reporteDeDañoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmServicioTecnico frmServicioTecnico = new FrmServicioTecnico();
            frmServicioTecnico.MdiParent = this;
            frmServicioTecnico.Show(); 
        }

        private void computoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenimientoComputoPreventivo frmMantenimientoComputoPreventivo = new FrmMantenimientoComputoPreventivo();
            frmMantenimientoComputoPreventivo.MdiParent = this;
            frmMantenimientoComputoPreventivo.Show(); 
        }

        private void computoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMantenimientoComputoCorrectivo frmMantenimientoComputoCorrectivo = new FrmMantenimientoComputoCorrectivo();
            frmMantenimientoComputoCorrectivo.MdiParent = this;
            frmMantenimientoComputoCorrectivo.Show(); 
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenimientoEquipoPreventivo frmMantenimientoEquipoPreventivo = new FrmMantenimientoEquipoPreventivo();
            frmMantenimientoEquipoPreventivo.MdiParent = this;
            frmMantenimientoEquipoPreventivo.Show(); 
        }

        private void equiposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMantenimientoEquipoCorrectivo frmMantenimientoEquipoCorrectivo = new FrmMantenimientoEquipoCorrectivo();
            frmMantenimientoEquipoCorrectivo.MdiParent = this;
            frmMantenimientoEquipoCorrectivo.Show(); 
        }

        private void computoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmMantenimientoComputoInforme frmMantenimientoComputoInforme = new FrmMantenimientoComputoInforme();
            frmMantenimientoComputoInforme.MdiParent = this;
            frmMantenimientoComputoInforme.Show(); 
        }

        private void equipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenimientoEquipoInforme frmMantenimientoEquipoInforme = new FrmMantenimientoEquipoInforme();
            frmMantenimientoEquipoInforme.MdiParent = this;
            frmMantenimientoEquipoInforme.Show();
        }

        private void servicioTecnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmServiciosTecnicosCorrectivos frmServiciosTecnicos = new FrmServiciosTecnicosCorrectivos();
            frmServiciosTecnicos.MdiParent = this;
            frmServiciosTecnicos.Show(); 
        }

        private void hojaDeVidaGenericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHojaVidaGenerica frmHojaVidaGenerica = new FrmHojaVidaGenerica();
            frmHojaVidaGenerica.MdiParent = this;
            frmHojaVidaGenerica.Show();
        }

        private void servicioTecnicoPreventivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmServiciosTecnicosPreventivos frmServiciosTecnicosPreventivos = new FrmServiciosTecnicosPreventivos();
            frmServiciosTecnicosPreventivos.MdiParent = this;
            frmServiciosTecnicosPreventivos.Show(); 
        }

        private void computoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmMantenimientoEquipoCorrectivo frmMantenimientoEquipoCorrectivo = new FrmMantenimientoEquipoCorrectivo();
            frmMantenimientoEquipoCorrectivo.MdiParent = this;
            frmMantenimientoEquipoCorrectivo.Show(); 
        }

        private void equipoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMantenimientoEquipoCorrectivo frmMantenimientoEquipoCorrectivo = new FrmMantenimientoEquipoCorrectivo();
            frmMantenimientoEquipoCorrectivo.MdiParent = this;
            frmMantenimientoEquipoCorrectivo.Show(); 
        }

        private void computoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmMantenimientoComputoPreventivo frmMantenimientoComputoPreventivo = new FrmMantenimientoComputoPreventivo();
            frmMantenimientoComputoPreventivo.MdiParent = this;
            frmMantenimientoComputoPreventivo.Show(); 
        }

        private void equipoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmMantenimientoEquipoPreventivo frmMantenimientoEquipoPreventivo = new FrmMantenimientoEquipoPreventivo();
            frmMantenimientoEquipoPreventivo.MdiParent = this;
            frmMantenimientoEquipoPreventivo.Show(); 
        }

        private void computoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmIndicadorComputo frmIndicadorComputo = new FrmIndicadorComputo();
            frmIndicadorComputo.MdiParent = this;
            frmIndicadorComputo.Show(); 
        }

        private void infraestructuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIndicadorInfraestructura frmIndicadorInfraestructura = new FrmIndicadorInfraestructura();
            frmIndicadorInfraestructura.MdiParent = this;
            frmIndicadorInfraestructura.Show(); 
        }

        private void requsicionDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRequicisionCompra frmRequicisionCompra = new FrmRequicisionCompra();
            frmRequicisionCompra.MdiParent = this;
            frmRequicisionCompra.Show(); 
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

    }
}
