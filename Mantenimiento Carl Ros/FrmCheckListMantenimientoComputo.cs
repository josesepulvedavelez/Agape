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
    public partial class FrmCheckListMantenimientoComputo : Form
    {
        public FrmCheckListMantenimientoComputo()
        {
            InitializeComponent();
        }

        private void chkCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int i;
            string s = "";

            for (i = 0; i <= (chkCheckList.Items.Count - 1); i++)
            {
                if (chkCheckList.GetItemChecked(i))
                {
                    s = s + chkCheckList.Items[i].ToString();
                    s = s + "\n";
                }
            }

            FrmMantenimientoComputoInsertar.mci.txtDescripcionActividadesRealizadas.Text = s; 
        }

    }
}
