using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Catalogo
{
    internal class ClsTipoUsuarios
    {
        public string cveTipoUsuario { get; set; }
        public string descTipoUsuario { get; set; }
        public int estadoTipoUsuario { get; set; }

        public ClsTipoUsuarios()
        {

        }
        public void setDatosTipoUsuarios(string _cveTipoUsuario, string _descripcion, int _estado)
        {
            cveTipoUsuario = _cveTipoUsuario;
            descTipoUsuario = _descripcion;
            estadoTipoUsuario = _estado;
        }

        object[] datos = { };
        string[] parametros = { };
        public int insertTipoUsuarios()
        {
            datos = new object[] { cveTipoUsuario,descTipoUsuario, estadoTipoUsuario };
            parametros = new string[] { "@cveTipoUsuario", "@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_TIPOUSUARIOS]", datos, parametros);
            return result;

        }

        public int updateDescTipoUsuarios()
        {
            datos = new object[] { cveTipoUsuario, descTipoUsuario, estadoTipoUsuario };
            parametros = new string[] { "@cveTipoUsuario", "@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_TIPOUSUARIOS]", datos, parametros);
            return result;
        }
    }
}
