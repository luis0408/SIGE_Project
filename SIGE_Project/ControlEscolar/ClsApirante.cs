using SIGE_Project.Catalogo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.ControlEscolar
{
    internal class ClsApirante:ClsPersona
    {
        
        public string cveLicenciatura { get; set; }
        public string cveModalidad { get; set; }
        public int? idCicloEscolar { get; set; }
        public int? idPeriodo { get; set; }
        public string CCT_Bachillerato { get; set; }
        public decimal? promedio { get; set; }
        public string cveMedio { get; set; }
        public string usuarioRegistro { get; set; }
        public int? idGeneracion { get; set; }
        DataTable tablaDocumentos;
        DataTable tablaDocsAspirante;
        public ClsApirante()
        {
            getDocuments();
            
            //fillTableDocsAspirante();
        }
        public void setDatosAspirante(string _cveLicenciatura , string _cveModalidad, int? _idCicloEscolar, int? _idPeriodo, string _CCT_Bachillerato, decimal? _promedio, string _cveMedio, string _usuarioRegistro, int? _idGeneracion)
        {
            cveLicenciatura= _cveLicenciatura;
            cveModalidad= _cveModalidad;
            idCicloEscolar= _idCicloEscolar;
            idPeriodo= _idPeriodo;
            CCT_Bachillerato= _CCT_Bachillerato;
            promedio= _promedio;
            cveMedio= _cveMedio;    
            usuarioRegistro= _usuarioRegistro;
            idGeneracion = _idGeneracion;
        }
        object[] datos = { };
        string[] parametros = { };
        public int insertarAspirante()
        {
            datos = new object[] { CURP, cveLicenciatura, cveModalidad, idCicloEscolar, idPeriodo, CCT_Bachillerato, promedio, cveMedio, usuarioRegistro, idGeneracion };
            parametros = new string[] { "@CURP","@cveLicenciatura","@cveModalidad","@idCicloEscolar","@idPeriodo","@CCT_Bachillerato","@promedio","@cveMedio","@usuarioRegistro", "@idGeneracion" };
            int resultadoInsert = Utilerias.ejecutarprocedimiento("SIGE_INSERTAR_ASPIRANTE", datos, parametros);
            return resultadoInsert;
        }
        public int updateAspirante()
        {
            datos = new object[] { CURP,cveLicenciatura, cveModalidad, idCicloEscolar, idPeriodo, CCT_Bachillerato, promedio, cveMedio, usuarioRegistro,idGeneracion };
            parametros = new string[] { "@CURP","@cveLicenciatura", "@cveModalidad", "@idCicloEscolar", "@idPeriodo", "@CCT_Bachillerato", "@promedio", "@cveMedio", "@usuarioRegistro", "@idGeneracion" };
            int resultadoUpdate = Utilerias.ejecutarprocedimiento("SIGE_ACTUALIZAR_ASPIRANTE", datos, parametros);
            return resultadoUpdate;
        }
        private void getDocuments()
        {
            /////SE LLENA TABLA CON LA LISTA DE DOCUMENTO DISPONIBLES
            try
            {
                datos = new object[]{ };
                parametros = new string[] { };
                DataSet ds = new DataSet();
                ds = Utilerias.consultarProcedimiento("[SIGE_CONSULTAR_LISTADOCUMENTOS]", datos, parametros);
                tablaDocumentos = new DataTable();
                tablaDocumentos = ds.Tables[0];
            }
            catch (Exception e)
            {
                tablaDocumentos = null;
            }
            
        }
        private void createTableDocsAspirante()
        {
            tablaDocsAspirante = new DataTable();
            tablaDocsAspirante.Columns.Add("CURP");
            tablaDocsAspirante.Columns.Add("idDocumento", typeof(int));
            tablaDocsAspirante.Columns.Add("original", typeof(int));
            tablaDocsAspirante.Columns.Add("copia", typeof(int));
            tablaDocsAspirante.Columns.Add("observaciones");
            tablaDocsAspirante.Columns.Add("rutaArchivo");
        }
        public void fillTableDocsAspirante()
        {
            /////SE CREA TABLA DE DOCUMENTACION DEL ASPIRANTE
            createTableDocsAspirante();
            /////SE RECORRE TABLA DE DOCS PARA LLENAR LA TABLA DE DOCUMENTOS DEL ASPIRANTE
            for (int i = 0; i < tablaDocumentos.Rows.Count; i++)
            {
                int idDocumento = Convert.ToInt32(tablaDocumentos.Rows[i]["idDocumento"].ToString());
                tablaDocsAspirante.Rows.Add(CURP,idDocumento,0,0,null,null);
            }
        }

        public int insertarTablaDocumentacion()
        {
            datos = new object[] {tablaDocsAspirante };
            parametros = new string[] { "@tableishon" };
            int resultadoInsertDocumentacion = Utilerias.ejecutarprocedimiento("SIGE_INSERTAR_ASPIRANTE_TABLADOCUMENTACION", datos, parametros);
            return resultadoInsertDocumentacion;
        }
    }
}
