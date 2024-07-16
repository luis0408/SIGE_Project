using SIGE_Project.Catalogo;
using System;
using System.Collections.Generic;
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
        public ClsApirante()
        {
        }
        public void setDatosAspirante(string _cveLicenciatura , string _cveModalidad, int? _idCicloEscolar, int? _idPeriodo, string _CCT_Bachillerato,
                                       decimal? _promedio, string _cveMedio, string _usuarioRegistro, int? _idGeneracion)
        {
            cveLicenciatura= _cveLicenciatura;
            cveModalidad= _cveModalidad;
            idCicloEscolar= _idCicloEscolar;
            idPeriodo= _idPeriodo;
            CCT_Bachillerato= _CCT_Bachillerato;
            promedio= _promedio;
            cveMedio= _cveMedio;    
            usuarioRegistro= _usuarioRegistro;  
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
    }
}
