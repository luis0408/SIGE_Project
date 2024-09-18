using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.ControlEscolar
{
    internal class ClsTutor
    {
        public string noControl { get; set; }////EL NUMERO DE CONTROL PUEDE SER LA CURP, YA QUE SE PUEDEN DATOS EN EL PROCESO DE INSCRIPCION
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string numeroTelefono { get; set; }
        public string email { get; set; }
        public int? idParentesco { get; set; }

        public ClsTutor()
        {

        }
        object[] datos = { };
        string[] parametros = { };
        public void setDatosTutor(string _noControl, string _nombre, string _apellidoPaterno, string _apellidoMaterno, string _numeroTelefono, string _email, int? _idParentesco)
        {
            noControl= _noControl;
            nombre= _nombre;   
            apellidoPaterno= _apellidoPaterno;
            apellidoMaterno= _apellidoMaterno;
            numeroTelefono= _numeroTelefono;
            email= _email;  
            idParentesco= _idParentesco;
        }
        public int insertarTutor()
        {
            datos = new object[] { noControl, nombre,apellidoPaterno,apellidoMaterno,numeroTelefono,email,idParentesco };
            parametros = new string[] { "@CURP", "@nombre", "@apellidoPaterno", "@apellidoMaterno", "@numeroTelefono", "@email", "@idParentesco" };
            int resultadoInsert = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_TUTOR]", datos, parametros);
            return resultadoInsert;
        }
        public int updateTutor()
        {
            datos = new object[] { noControl, nombre, apellidoPaterno, apellidoMaterno, numeroTelefono, email, idParentesco };
            parametros = new string[] { "@CURPaspirante", "@nombre", "@apellidoPaterno", "@apellidoMaterno", "@numeroTelefono", "@email", "@idParentesco" };
            int resultadoUpdate = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_TUTOR]", datos, parametros);
            return resultadoUpdate;
        }
    }
}
