using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Catalogo
{
    internal class ClsTipoSangre
    {
        public string cveTipoSangre { set; get; }
        public string descTipoSangre { set; get; }
        public int estadoTipoSangre { set; get; }

        public ClsTipoSangre() { }

        public void setDatosTipoSangre(string _cveTipoSangre, string _descTipoSangre, int _estadoTipoSangre)
        {
            cveTipoSangre = _cveTipoSangre;
            descTipoSangre = _descTipoSangre;
            estadoTipoSangre = _estadoTipoSangre;
        }

        object[] datos = { };
        string[] parametros = { };

        public int insertarDatosTipoSangre()
        {
            datos = new object[] {cveTipoSangre,descTipoSangre,estadoTipoSangre };
            parametros = new string[] {"@cveTipoSangre", "@descripcion","@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_TIPOSANGRE]", datos, parametros);
            return result;
        }

        public int updateDescTipoSangre()
        {
            datos = new object[] { cveTipoSangre, descTipoSangre, estadoTipoSangre };
            parametros = new string[] { "@cveTipoSangre", "@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_TIPOSANGRE]", datos, parametros);
            return result;
        }

    }
}
