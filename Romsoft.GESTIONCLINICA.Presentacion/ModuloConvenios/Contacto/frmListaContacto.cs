using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Presentacion.ApiService;
using Romsoft.GESTIONCLINICA.Presentacion.Utilities;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.CON_CONTACTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Presentacion.Helpers;
using Romsoft.GESTIONCLINICA.Presentacion.Core;

namespace Romsoft.GESTIONCLINICA.Presentacion.ModuloConvenios.Contacto
{
    public partial class frmListaContacto : Form
    {
        public int intTipoConsulta = 0;

        public frmListaContacto()
        {
            InitializeComponent();
        }

        private void InitialLoad(int intTipoConsulta)
        {

            try
            {
                 

                //Muestra Todo
                if (intTipoConsulta == 0)
                {
                    ComunFilter.ValorRequest = "0";

                    var jsonResponse = new JsonResponse { Success = false };
                    //PaginationParameter paginationParameters = new PaginationParameter { AmountRows = 1000, CurrentPage = 0, OrderBy = "", Start = 0, WhereFilter = "WHERE U.estado IN ('Activo','Inactivo')" };
                    jsonResponse = InvokeHelper.MakeRequest(ConstantesWindows.WS_CON_CONTACTO_GetAllFilters, GetContacto(), ConstantesWindows.METHODPOST);

                    if (jsonResponse.Success && !jsonResponse.Warning)
                    {
                        var contactoListDTO = (List<CON_CONTACTODTO>)JsonConvert.DeserializeObject(jsonResponse.Data.ToString(), (new List<CON_CONTACTODTO>()).GetType());
                        this.ETContacto.DataSource = contactoListDTO;
                        //this.usuarioBindingNavigator.BindingSource = this.usuarioBindingSource;
                    }
                    else if (jsonResponse.Warning)
                    {
                        Mensaje.ShowMessageAlert(this.ParentForm, ConstantesWindows.TituloMensaje, jsonResponse.Message);
                    }
                }

                //Muestra Todo por filtro
                if (intTipoConsulta == 1)
                {


                    var jsonResponse = new JsonResponse { Success = false };

                    jsonResponse = InvokeHelper.MakeRequest(ConstantesWindows.WS_CVN_CATEGORIA_PAGO_GetAllFilters, GetContacto(), ConstantesWindows.METHODPOST);

                    if (jsonResponse.Success && !jsonResponse.Warning)
                    {
                        var catpagoListDTO = (List<CON_CONTACTODTO>)JsonConvert.DeserializeObject(jsonResponse.Data.ToString(), (new List<CON_CONTACTODTO>()).GetType());
                        this.ETContacto.DataSource = catpagoListDTO;
                        //this.usuarioBindingNavigator.BindingSource = this.usuarioBindingSource;
                    }
                    else if (jsonResponse.Warning)
                    {
                        Mensaje.ShowMessageAlert(this.ParentForm, ConstantesWindows.TituloMensaje, jsonResponse.Message);
                    }
                }

            }
            catch (Exception ex)
            {
                Mensaje.ShowMessageAlert(this.ParentForm, ConstantesWindows.TituloMensaje, ex.Message);
            }
        }


        //Asigna Datos para el Filtro
        private CON_CONTACTODTO GetContacto()
        {
            return new CON_CONTACTODTO
            {
                valor = ComunFilter.ValorRequest,
            };
        }

        private void frmListaContacto_Load(object sender, EventArgs e)
        {
            // 0 = Consulta todos
            InitialLoad(0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CategoriaPago.frmFiltroCategoriaPago frm = new CategoriaPago.frmFiltroCategoriaPago();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // 1 = Consulta por filtro
                InitialLoad(1);
            }
            else
            {
                // 0 = Consulta todos
                InitialLoad(0);
            }
        }

        private void dgvListaCatPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaCatPago.Rows.Count > 0)
            {

                // Editar
                if (dgvListaCatPago.CurrentCell.ColumnIndex == 6)
                {
                    ComunFilter.cp_id_categoria_pago = Convert.ToInt32(dgvListaCatPago.CurrentRow.Cells[0].Value.ToString()); //id_categoria_pago

                    CategoriaPago.frmNuevoCategoriaPago frm = new CategoriaPago.frmNuevoCategoriaPago();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        // 0 = Consulta Todos
                        InitialLoad(0);
                    }
                }


            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ComunFilter.cp_id_categoria_pago = 0;


            CategoriaPago.frmNuevoCategoriaPago frm = new CategoriaPago.frmNuevoCategoriaPago();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // 0 = Consulta Todos
                InitialLoad(0);
            }
        }

        //cambia color columna Estado
        private void dgvListaCatPago_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.Columns[e.ColumnIndex].Name == "estadoDataGridViewTextBoxColumn")  //columna Esatado a evaluar
            {
                if (e.Value.ToString().Contains("Inactivo"))
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                if (e.Value.ToString().Contains("Activo"))
                {
                    e.CellStyle.ForeColor = Color.CornflowerBlue;
                }
            }
        }
    }
}
