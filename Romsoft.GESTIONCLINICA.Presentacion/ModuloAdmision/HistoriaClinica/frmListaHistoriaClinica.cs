using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Romsoft.GESTIONCLINICA.Presentacion.ModuloAdmision.HistoriaClinica
{
    public partial class frmListaHistoriaClinica : Form
    {
        public frmListaHistoriaClinica()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HistoriaClinica.frmNuevoHistoriaClinica frm = new HistoriaClinica.frmNuevoHistoriaClinica();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // 0 = Consulta Todos
                //    InitialLoad(0);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
