using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Sistemas.Alumnos
{
    internal class clsAlumno
    {
        int idAlumno {  get; set; }
        string nombres { get; set; }
        string apellidoPaterno { get; set; }
        string apellidoMaterno { get; set; }
        int estadoAlumno { get; set; }
        string cvModalidad {  get; set; }
        string cveLicenciatura { get; set; }
        int idGeneracion { get; set; }
        int idSemestre { get; set; }
        string curp { get; set; }
        int edad {  get; set; }
        string noControl { get; set; }
        string email { get; set; }


        public clsAlumno()
        {

        }
        public void setDatos(int _idAlumno, string _nombres, string _apellidoPaterno, string _apellidoMaterno,
                            int _estadoAlumno, string _cvModalidad, string _cveLicenciatura, int _idGeneracion, int _idSemestre
                            , string _curp, int _edad, string _noControl, string _email)
        {
            idAlumno = _idAlumno;
            nombres = _nombres;
            apellidoPaterno = _apellidoPaterno;
            apellidoMaterno = _apellidoMaterno;
            estadoAlumno = _estadoAlumno;
            cvModalidad = _cvModalidad; 
            cveLicenciatura= _cveLicenciatura;
            idGeneracion = _idGeneracion;
            idSemestre = _idSemestre;
            curp = _curp;
            edad = _edad;
            noControl = _noControl;
            email = _email;
        }
        object[] datos = { };
        string[] parametros= { };

        public int insertAlumno()
        {
            datos = new object[] {nombres,apellidoPaterno,apellidoMaterno,estadoAlumno,cvModalidad,cveLicenciatura,idGeneracion,idSemestre,variables.varUser,email };
            parametros=new string[] { "@nombres", "@apellidoPaterno", "@apellidoMaterno", "@estadoAlumno", "@cveModalidad", "@cveLicenciatura", "@idGeneracion", "@idSemestre", "@usuActualizo", "@email" };
            int resultado = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_SISTEMAS_ALUMNOS]", datos, parametros);
            return resultado;
        }
        public int updateAlumno()
        {
            datos = new object[] { idAlumno,nombres, apellidoPaterno, apellidoMaterno, estadoAlumno, cvModalidad, cveLicenciatura, idGeneracion, idSemestre, variables.varUser, email };
            parametros = new string[] { "@idAlumno","@nombres", "@apellidoPaterno", "@apellidoMaterno", "@estadoAlumno", "@cveModalidad", "@cveLicenciatura", "@idGeneracion", "@idSemestre", "@usuActualizo", "@email" };
            int resultado = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_SISTEMAS_ALUMNOS]", datos, parametros);
            return resultado;
        }


    }
}
