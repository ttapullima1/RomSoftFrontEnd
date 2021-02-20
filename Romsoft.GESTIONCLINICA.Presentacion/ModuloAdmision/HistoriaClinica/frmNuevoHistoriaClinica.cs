using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Presentacion.ApiService;
using Romsoft.GESTIONCLINICA.Presentacion.Utilities;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_PROFESIONAL;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.TIPO_ESTADO;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_GENERO;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_DOCUMENTO_IDENTIDAD;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_ESPECIALIDAD;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_TIPO_PROFESIONAL;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_CONDICION_PROFESIONAL;
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

namespace Romsoft.GESTIONCLINICA.Presentacion.ModuloAdmision.HistoriaClinica
{
    public partial class frmNuevoHistoriaClinica : Form
    {
        public frmNuevoHistoriaClinica()
        {
            InitializeComponent();
        }


        private void CargarComboSexo()
        {
            try
            {
                var jsonResponse = new JsonResponse { Success = false };
                jsonResponse = InvokeHelper.MakeRequest(ConstantesWindows.WS_ADM_GENEROL_GetAllActives, new ADM_GENERODTO { }, ConstantesWindows.METHODPOST);

                if (jsonResponse.Success && !jsonResponse.Warning)
                {
                    var generoListDTO = (List<ADM_GENERODTO>)JsonConvert.DeserializeObject(jsonResponse.Data.ToString(), (new List<ADM_GENERODTO>()).GetType());
                    cboSexo.ValueMember = "id_genero";
                    cboSexo.DisplayMember = "t_descripcion";
                    cboSexo.DataSource = generoListDTO;
                }
                else if (jsonResponse.Warning)
                {
                    Mensaje.ShowMessageAlert(this.ParentForm, ConstantesWindows.TituloMensaje, jsonResponse.Message);
                }
            }
            catch (Exception ex)
            {
                Mensaje.ShowMessageAlert(this.ParentForm, ConstantesWindows.TituloMensaje, ex.Message);
            }
        }

        private void CargarComboDocumento()
        {
            try
            {
                var jsonResponse = new JsonResponse { Success = false };
                jsonResponse = InvokeHelper.MakeRequest(ConstantesWindows.WS_ADM_DOCUMENTO_IDENTIDAD_GetAllActives, new ADM_DOCUMENTO_IDENTIDADDTO { }, ConstantesWindows.METHODPOST);

                if (jsonResponse.Success && !jsonResponse.Warning)
                {
                    var documentoListDTO = (List<ADM_DOCUMENTO_IDENTIDADDTO>)JsonConvert.DeserializeObject(jsonResponse.Data.ToString(), (new List<ADM_DOCUMENTO_IDENTIDADDTO>()).GetType());
                    cboTDocumento.ValueMember = "id_documento_identidad";
                    cboTDocumento.DisplayMember = "t_descripcion";
                    cboTDocumento.DataSource = documentoListDTO;
                }
                else if (jsonResponse.Warning)
                {
                    Mensaje.ShowMessageAlert(this.ParentForm, ConstantesWindows.TituloMensaje, jsonResponse.Message);
                }
            }
            catch (Exception ex)
            {
                Mensaje.ShowMessageAlert(this.ParentForm, ConstantesWindows.TituloMensaje, ex.Message);
            }
        }


        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            HistoriaClinica.frmAtencion frm = new HistoriaClinica.frmAtencion();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // 0 = Consulta Todos
                //    InitialLoad(0);
            }
        }

        private void frmHistoriaClinica_Load(object sender, EventArgs e)
        {
            CargarComboSexo();
            CargarComboDocumento();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUbigeoNacimiento_Click(object sender, EventArgs e)
        {
            HistoriaClinica.frmFiltroUbigeo frm = new HistoriaClinica.frmFiltroUbigeo();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // 0 = Consulta Todos
                //    InitialLoad(0);
            }
        }

        private void btnUbigeoDomicilio_Click(object sender, EventArgs e)
        {
            HistoriaClinica.frmFiltroUbigeo frm = new HistoriaClinica.frmFiltroUbigeo();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // 0 = Consulta Todos
                //    InitialLoad(0);
            }
        }

        private void btnIntegracionSiteds_Click(object sender, EventArgs e)
        {
            HistoriaClinica.frmFiltroSiteds frm = new HistoriaClinica.frmFiltroSiteds();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // 0 = Consulta Todos
                //    InitialLoad(0);
            }
        }

        private void btnGuardarAtencion_Click(object sender, EventArgs e)
        {
            this.Close();

            HistoriaClinica.frmAtencion frm = new HistoriaClinica.frmAtencion();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // 0 = Consulta Todos
                //    InitialLoad(0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes|*.jpg; *.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccionar Imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                pctFoto.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
