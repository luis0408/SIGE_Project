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
        public char grupo { set; get; }
        public int cveLicenciatura { set; get; }
        public int idGeneracion { set; get; }
        public int estadoGrupo { set; get; }

        public ClsGrupos() { }

        public void setDatosGrupo(int _idGrupo, char _grupo, int _cveLicenciatura, int _idGeneracion, int _estadoGrupo)
        {
            idGrupo = _idGrupo;
            grupo = _grupo;
            cveLicenciatura = _cveLicenciatura;
            idGeneracion = _idGeneracion;
            estadoGrupo = _estadoGrupo;
        }

        object[] datos = { };
        string[] parametros = { };

        public int insertarDatosGrupo()
        {
            datos = new object[] { idGrupo, grupo, cveLicenciatura, idGeneracion, estadoGrupo };
            parametros = new string[] { "", "", "" };
            int result = Utilerias.ejecutarprocedimiento("[]", datos, parametros);
            return result;
        }

        public int updateDescGrupo()
        {
            datos = new object[] { idGrupo, grupo, cveLicenciatura, idGeneracion, estadoGrupo };
            parametros = new string[] { "", "", "" };
            int result = Utilerias.ejecutarprocedimiento("[]", datos, parametros);
            return result;
        }
    }
}
