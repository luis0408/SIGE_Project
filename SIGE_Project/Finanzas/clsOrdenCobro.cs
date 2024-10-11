﻿using DevExpress.DataAccess.Native.Sql.ConnectionProviders;
using DevExpress.Map.Native;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Finanzas
{
    internal class clsOrdenCobro
    {
        int idOrdenCobro{ set; get; }///EN LA TABLA APARECE COMO IDREGISTRO
        #region Datos del solicitante
        string curpSolicitante { set; get; }
        int semestre { set; get; }
        string cveLicenciatura { set; get; }
        #endregion
        int estadoSolicitud { set; get; }
        DateTime fechaRegistro{ set; get; }
        DateTime fechaEnvio{ set; get; }
        DateTime fechaExpira{ set; get; }
        DateTime fechaCancelacion{ set; get; }
    string dirSolicitudPago, dirComprobante;
        string usuEnvio, usuRegistro;
        object[] datos;
        string[] parametros;
        public clsOrdenCobro(string _curpSolcitante)
        {
            curpSolicitante = _curpSolcitante;  

        }
        
        public bool validarSolicitudesOrdenCobroPendiente()
        {
            /////SE RETORNA VERDADERO SI EXISTE UNA SOLICITUD PENDIENTE
            ////SE RETORNA FALSO CUANDO NO EXISTE UNA SOLCITUD PENDIENTE
            datos = new object[] {curpSolicitante };
            parametros = new string[] { "@CURP" };
            DataSet ds = Utilerias.consultarProcedimiento("SIGE_CONSULTAR_DATOSORDENESCOBROXCURP", datos, parametros);
            if (ds.Tables[0].Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
        public void setValoresOrdenCobroInsert(int _semestre, string _cveLicenciatura, int _estadoSolicitud, string _usuRegistro)
        {
            ////METODO PARA SETEAR VALORES EN LAS VARIABLES PARA INSERCION
            semestre = _semestre;
            cveLicenciatura = _cveLicenciatura;
            estadoSolicitud = _estadoSolicitud;
            usuRegistro = _usuRegistro;
        }
        public int insertSolicitudOrdenCobro()
        {

            /////SE RETORNARA EL NUMERO DE SOLICITUD QUE SE GENERO
            datos = new object[] { curpSolicitante,semestre,cveLicenciatura,estadoSolicitud,usuRegistro };
            parametros = new string[] { "@curpSolicitante", "@semestre", "@cveLicenciatura", "@estadoSolicitud", "@usuRegistro" };
            int resultInsert = Utilerias.ejecutarprocedimientoReturnIdentity("SIGE_INSERTAR_SOLCITUDORDENCOBRO", datos,parametros);
            setIdOrdenCobro(resultInsert);
            return resultInsert;
        }
        private void setIdOrdenCobro(int _idOrdenCobro)
        {
            idOrdenCobro = _idOrdenCobro;
        }
        public void getDatosOrdenCobro()
        {
            datos = new object[] { idOrdenCobro };
            parametros = new string[] { "@idOrdenCobro"};
            DataSet dsResult= Utilerias.consultarProcedimiento("SIGE_CONSULTAR_DATOSORDENESCOBROXIDORDEN", datos,parametros);
            if (dsResult.Tables[0].Rows.Count>0)
            {
                DataTable dt = dsResult.Tables[0];
                curpSolicitante = dt.Rows[0]["curpSolicitante"].ToString();
                semestre = Convert.ToInt32(dt.Rows[0]["semestre"].ToString());
                cveLicenciatura = dt.Rows[0]["cveLicenciatura"].ToString();
                estadoSolicitud = Convert.ToInt32(dt.Rows[0]["estadoSolicitud"].ToString());
                fechaRegistro = Convert.ToDateTime(dt.Rows[0]["fechaRegistro"].ToString());
                fechaEnvio = Convert.ToDateTime(dt.Rows[0]["fechaEnvio"].ToString());
                fechaExpira = Convert.ToDateTime(dt.Rows[0]["fechaExpira"].ToString());
                fechaCancelacion = Convert.ToDateTime(dt.Rows[0]["fechaCancelacion"].ToString());
                dirSolicitudPago = dt.Rows[0]["dirSolicitudPago"].ToString();
                dirComprobante = dt.Rows[0]["dirComprobante"].ToString();
                usuEnvio = dt.Rows[0]["usuEnvio"].ToString();
                usuRegistro = dt.Rows[0]["usuRegistro"].ToString();
            }
        }
    }
}