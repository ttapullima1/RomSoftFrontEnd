﻿using System.Configuration;

namespace Romsoft.GESTIONCLINICA.Presentacion.Utilities
{
    public class ConstantesWindows
    {

        #region Otros
        public static string ColorBodeFormularios = ConfigurationManager.AppSettings["ColorBodeFormularios"];
        public static string ColorBodeControles = ConfigurationManager.AppSettings["ColorBodeControles"];
        #endregion


        #region WebServices


        public static string BaseUrlApiService = ConfigurationManager.AppSettings["BaseUrlApiService"];
        public static string WS_Account_Login = ConfigurationManager.AppSettings["WS_Account_Login"];
        //Usuario
        public static string WS_Usuario_Add = ConfigurationManager.AppSettings["WS_Usuario_Add"];
        public static string WS_Usuario_Delete = ConfigurationManager.AppSettings["WS_Usuario_Delete"];
        public static string WS_Usuario_GetAllPaging = ConfigurationManager.AppSettings["WS_Usuario_GetAllPaging"];
        public static string WS_Usuario_GetAllFilters = ConfigurationManager.AppSettings["WS_Usuario_GetAllFilters"];
        public static string WS_Usuario_GetById = ConfigurationManager.AppSettings["WS_Usuario_GetById"];
        public static string WS_Usuario_Update = ConfigurationManager.AppSettings["WS_Usuario_Update"];
        //Estado
        public static string WS_Estado_GetAllFilters = ConfigurationManager.AppSettings["WS_Estado_GetAllFilters"];

        //Rol
        public static string WS_Rol_Add = ConfigurationManager.AppSettings["WS_Rol_Add"];
        public static string WS_Rol_Delete = ConfigurationManager.AppSettings["WS_Rol_Delete"];
        public static string WS_Rol_GetAllPaging = ConfigurationManager.AppSettings["WS_Rol_GetAllPaging"];
        public static string WS_Rol_GetAllActives = ConfigurationManager.AppSettings["WS_Rol_GetAllActives"];
        public static string WS_Rol_GetById = ConfigurationManager.AppSettings["WS_Rol_GetById"];
        public static string WS_Rol_Update = ConfigurationManager.AppSettings["WS_Rol_Update"];

        //Ocupacion
        public static string WS_Ocupacion_Add = ConfigurationManager.AppSettings["WS_Ocupacion_Add"];
        public static string WS_Ocupacion_Delete = ConfigurationManager.AppSettings["WS_Ocupacion_Delete"];
        public static string WS_Ocupacion_GetAllFilters = ConfigurationManager.AppSettings["WS_Ocupacion_GetAllFilters"];
        public static string WS_Ocupacion_GetById = ConfigurationManager.AppSettings["WS_Ocupacion_GetById"];
        public static string WS_Ocupacion_Update = ConfigurationManager.AppSettings["WS_Ocupacion_Update"];
        public static string WS_Ocupacion_GetAllActives = ConfigurationManager.AppSettings["WS_Ocupacion_GetAllActives"];

        //Tarifario
        public static string WS_CVN_TARIFARIO_SEGUS_Add = ConfigurationManager.AppSettings["WS_CVN_TARIFARIO_SEGUS_Add"];
        public static string WS_CVN_TARIFARIO_SEGUS_Delete = ConfigurationManager.AppSettings["WS_CVN_TARIFARIO_SEGUS_Delete"];
        public static string WS_CVN_TARIFARIO_SEGUS_GetAllFilters = ConfigurationManager.AppSettings["WS_CVN_TARIFARIO_SEGUS_GetAllFilters"];
        public static string WS_CVN_TARIFARIO_SEGUS_Update = ConfigurationManager.AppSettings["WS_CVN_TARIFARIO_SEGUS_Update"];
        public static string WS_CVN_TARIFARIO_SEGUS_GetAllActives = ConfigurationManager.AppSettings["WS_CVN_TARIFARIO_SEGUS_GetAllActives"];
        public static string WS_CVN_TARIFARIO_SEGUS_GetById = ConfigurationManager.AppSettings["WS_CVN_TARIFARIO_SEGUS_GetById"];


        //Clasificacion SEGUS
        public static string WS_CVN_CLASIFICACION_SEGUS_GetAllActives = ConfigurationManager.AppSettings["WS_CVN_CLASIFICACION_SEGUS_GetAllActives"];

        //Susalud
        public static string WS_CVN_CLASIFICACION_SUSALUD_GetAllActives = ConfigurationManager.AppSettings["WS_CVN_CLASIFICACION_SUSALUD_GetAllActives"];
        //Susalud OD
        public static string WS_CVN_CLASIFICACION_SUSALUD_OD_GetAllActives = ConfigurationManager.AppSettings["WS_CVN_CLASIFICACION_SUSALUD_OD_GetAllActives"];
        //Tipo Precio
        public static string WS_CVN_TIPO_PRECIO_GetAllActives = ConfigurationManager.AppSettings["WS_CVN_TIPO_PRECIO_GetAllActives"];
        //Centro Costo
        public static string WS_CON_CENTRO_COSTO_GetAllActives = ConfigurationManager.AppSettings["WS_CON_CENTRO_COSTO_GetAllActives"];
        //Cta Contable
        public static string WS_CON_CUENTA_CONTABLE_GetAllActives = ConfigurationManager.AppSettings["WS_CON_CUENTA_CONTABLE_GetAllActives"];

        //Participantes
        public static string WS_CVN_TARIFARIO_SEGUS_PARTICIPANTE_Add = ConfigurationManager.AppSettings["WS_CVN_TARIFARIO_SEGUS_PARTICIPANTE_Add"];
        public static string WS_CVN_TARIFARIO_SEGUS_PARTICIPANTE_Delete = ConfigurationManager.AppSettings["WS_CVN_TARIFARIO_SEGUS_PARTICIPANTE_Delete"];
        public static string WS_CVN_TARIFARIO_SEGUS_PARTICIPANTE_GetAllActivesFilters = ConfigurationManager.AppSettings["WS_CVN_TARIFARIO_SEGUS_PARTICIPANTE_GetAllActivesFilters"];

        //Categoria Pagos
        public static string WS_CVN_CATEGORIA_PAGO_GetAllActives = ConfigurationManager.AppSettings["WS_CVN_CATEGORIA_PAGO_GetAllActives"];
        public static string WS_CVN_CATEGORIA_PAGO_GetAllFilters = ConfigurationManager.AppSettings["WS_CVN_CATEGORIA_PAGO_GetAllFilters"];
        public static string WS_CVN_CATEGORIA_PAGO_Add = ConfigurationManager.AppSettings["WS_CVN_CATEGORIA_PAGO_Add"];
        public static string WS_CVN_CATEGORIA_PAGO_Delete = ConfigurationManager.AppSettings["WS_CVN_CATEGORIA_PAGO_Delete"];
        public static string WS_CVN_CATEGORIA_PAGO_GetById = ConfigurationManager.AppSettings["WS_CVN_CATEGORIA_PAGO_GetById"];
        public static string WS_CVN_CATEGORIA_PAGO_Update = ConfigurationManager.AppSettings["WS_CVN_CATEGORIA_PAGO_Update"];


        //Categoria Precios
        public static string WS_CVN_CATEGORIA_PAGO_PRECIO_Add = ConfigurationManager.AppSettings["WS_CVN_CATEGORIA_PAGO_PRECIO_Add"];
        public static string WS_CVN_CATEGORIA_PAGO_PRECIO_Delete = ConfigurationManager.AppSettings["WS_CVN_CATEGORIA_PAGO_PRECIO_Delete"];
        public static string WS_CVN_CATEGORIA_PAGO_PRECIO_GetAllActivesFilters = ConfigurationManager.AppSettings["WS_CVN_CATEGORIA_PAGO_PRECIO_GetAllActivesFilters"];

        //Contacto
        public static string WS_CON_CONTACTO_Add = ConfigurationManager.AppSettings["WS_CON_CONTACTO_Add"];
        public static string WS_CON_CONTACTO_Delete = ConfigurationManager.AppSettings["WS_CON_CONTACTO_Delete"];
        public static string WS_CON_CONTACTO_GetAllFilters = ConfigurationManager.AppSettings["WS_CON_CONTACTO_GetAllFilters"];
        public static string WS_CON_CONTACTO_GetById = ConfigurationManager.AppSettings["WS_CON_CONTACTO_GetById"];
        public static string WS_CON_CONTACTO_GetAllActives = ConfigurationManager.AppSettings["WS_CON_CONTACTO_GetAllActives"];
        public static string WS_CON_CONTACTO_Update = ConfigurationManager.AppSettings["WS_CON_CONTACTO_Update"];

        // Plan Seguro
        public static string WS_CVN_PLAN_SEGURO_Add = ConfigurationManager.AppSettings["WS_CVN_PLAN_SEGURO_Add"];
        public static string WS_CVN_PLAN_SEGURO_GetAllFilters = ConfigurationManager.AppSettings["WS_CVN_PLAN_SEGURO_GetAllFilters"];
        public static string WS_CVN_PLAN_SEGURO_GetById = ConfigurationManager.AppSettings["WS_CVN_PLAN_SEGURO_GetById"];
        public static string WS_CVN_PLAN_SEGURO_GetAllActives = ConfigurationManager.AppSettings["WS_CVN_PLAN_SEGURO_GetAllActives"];
        public static string WS_CVN_PLAN_SEGURO_Update = ConfigurationManager.AppSettings["WS_CVN_PLAN_SEGURO_Update"];

        //CVN_PRODUCTO_PLAN/GetAllActivesFilters
        public static string WS_CVN_PRODUCTO_PLAN_GetAllActivesFilters = ConfigurationManager.AppSettings["WS_CVN_PRODUCTO_PLAN_GetAllActivesFilters"];

        //Beneficio
        public static string WS_CVN_BENEFICIO_GetAllActives = ConfigurationManager.AppSettings["WS_CVN_BENEFICIO_GetAllActives"];

        //Moneda
        public static string WS_CVN_MONEDA_GetAllActives = ConfigurationManager.AppSettings["WS_CVN_MONEDA_GetAllActives"];

        //
        public static string WS_CVN_PLAN_SEGURO_DETALLE_GetAllActivesFilters = ConfigurationManager.AppSettings["WS_CVN_PLAN_SEGURO_DETALLE_GetAllActivesFilters"];
        public static string WS_CVN_PLAN_SEGURO_DETALLE_Add = ConfigurationManager.AppSettings["WS_CVN_PLAN_SEGURO_DETALLE_Add"];
        public static string WS_CVN_PLAN_SEGURO_DETALLE_Delete = ConfigurationManager.AppSettings["WS_CVN_PLAN_SEGURO_DETALLE_Delete"];

        //TipoContacto
        public static string WS_TipoContacto_GetAllActives = ConfigurationManager.AppSettings["WS_TipoContacto_GetAllActives"];


        #endregion

        #region KeyString

        public const string UsuarioSesion = "UsuarioSesion";
        public const string NoUsuario = "NoUsuario";
        public const string FormulariosSesion = "FormulariosSesion";
        public const string FormularioActualSesion = "FormularioActualSesion";
        public const string TimeOutSession = "TimeOutSession";
        public const string EmailPattern = "EmailPattern";

        public const string LoginController = "Account";
        public const string LoginAction = "Login";

        public const string HomeController = "Home";
        public const string HomeAction = "Index";

        public const string FormatoFechaPorDefecto = "dd/MM/yyyy";
        public const string FormatoFechaHoraPorDefecto = "dd/MM/yyyy hh:mm";
        public const string FormatoHoraPorDefecto = "HH:mm:ss";
        public const string FormatoMonedaPorDefecto = "N2";
        public const string FormatoDecimalesPorDefecto = "{0:N2}";

        public const int Unauthorized = 1;

        public const int Error2146233087 = -2146233087;

        #endregion

        #region MethodType

        public const string METHODPOST = "POST";
        public const string METHODGET = "GET";

        #endregion

        #region Mensajes

        public static string IntenteloMasTarde = "Hubo un error, inténtelo más tarde";
        public static string CredencialesDominioIncorrectas = "Las credenciales de Dominio son Incorrectas";

        #endregion

        #region Roles

        public const int RolAdministrador = 1;
        public const int RolOperador = 2;

        #endregion


        public const string Mensaje = "MENSAJE";
        public const string MensajeError = @" Por favor ingrese de nuevo los datos y intente grabar o para mas seguridad informe a Soporte.";
        public const string TituloMensaje = ".:: Mensaje del sistema.";
        public const byte CargosStandar = 251;
        public const byte NumeroMesas = 10;
        public const int alturaMinima = 25;
        public const decimal IGV = (decimal)0.19;
        public const string Error = "Error";
        public static string ArchivoCargar = "";
        public static string FechaActual = "";
        public static string UrlGuardarExcel = ConfigurationManager.AppSettings["UrlGuardarExcel"];
        public static string Excel07ConString = ConfigurationManager.AppSettings["Excel07ConString"];
        public static string PaqueteDTS = ConfigurationManager.AppSettings["PaqueteDTS"];


    }
}
