using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Romsoft.GESTIONCLINICA.Presentacion.ModuloFacturacion.Prefacturacion;

namespace Romsoft.GESTIONCLINICA.Presentacion.ModuloAdmision.HistoriaClinica
{
    public partial class frmAtencion : Form
    {
        public frmAtencion()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnIntegracionSiteds_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

             
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnCama_Click(object sender, EventArgs e)
        {
            HistoriaClinica.frmFiltroCama frm = new HistoriaClinica.frmFiltroCama();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // 0 = Consulta Todos
                //    InitialLoad(0);
            }
        }

        private void btnSiteds_Click(object sender, EventArgs e)
        {
            HistoriaClinica.frmFiltroSiteds frm = new HistoriaClinica.frmFiltroSiteds();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // 0 = Consulta Todos
                //    InitialLoad(0);
            }
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            HistoriaClinica.frmAutorizacion frm = new HistoriaClinica.frmAutorizacion();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // 0 = Consulta Todos
                //    InitialLoad(0);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            frmPrefacturacion frm = new frmPrefacturacion();
           
             if (frm.ShowDialog() == DialogResult.OK)
            {
                // 0 = Consulta Todos
                //    InitialLoad(0);
            }
        }
    }
}
