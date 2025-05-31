using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Catalogo
{
    internal class ClsGrupos
    {
        public int idGrupo { set; get; }
        public int alumnos { set; get; }
        public string cveLicenciatura { set; get; }
        public int idGeneracion { set; get; }
        public int estadoGrupo { set; get; }
        public int idSemestre {  set; get; }  
        public string grupo { set; get; }   
        public string cveModalidad { get; set; }

        public ClsGrupos() { }

        public void setDatosGrupo(int _idGrupo, int _alumnos, string _cveLicenciatura, int _idGeneracion, int _estadoGrupo,int _semestre, string _grupo, string _cveModalidad)
        {
            idGrupo = _idGrupo;
            alumnos = _alumnos;
            cveLicenciatura = _cveLicenciatura;
            idGeneracion = _idGeneracion;
            estadoGrupo = _estadoGrupo;
            idSemestre = _semestre;   
            grupo = _grupo; 
            cveLicenciatura= _cveLicenciatura;
            cveModalidad = _cveModalidad;
        }

        object[] datos = { };
        string[] parametros = { };

        public int insertarDatosGrupo()
        {
            datos = new object[] {  grupo, cveLicenciatura, idGeneracion, idSemestre, estadoGrupo,alumnos,cveModalidad };
            parametros = new string[] { "@grupo", "@cveLicenciatura", "@idGeneracion", "@idSemestre", "@estado", "@numAlumnos", "@cveModalidad" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_GRUPO]", datos, parametros);
            return result;
        }

        public int updateDescGrupo()
        {
            datos = new object[] {idGrupo, grupo, cveLicenciatura, idGeneracion, idSemestre, estadoGrupo, alumnos,cveModalidad };
            parametros = new string[] { "@idGrupo", "@grupo", "@cveLicenciatura", "@idGeneracion", "@idSemestre", "@estado", "@numAlumnos", "@cveModalidad" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_GRUPO]", datos, parametros);
            return result;
        }
    }
}
