using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Catalogo
{
    internal class ClsEstadoAspirante
    {
        public int idEstado { get; set; }
        public string descripcion { get; set; }

        public ClsEstadoAspirante() { }

        public void setDatosEstadoAspirante(int _idEstado, string _descripcion)
        {
            idEstado = _idEstado;
            descripcion = _descripcion;
        }

        object[] datos = { };
        string[] parametros = { };

        public int insertDatoEstadoAspirante()
        {
            datos = new object[] { idEstado, descripcion };
            parametros = new string[] { "@idEstado", "@descripcion" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_ESTADOASPIRANTE]", datos, parametros);
            return result;
        }

        public int updateDatoEstadoAspirante()
        {
            datos = new object[] { idEstado, descripcion };
            parametros = new string[] { "@idEstado", "@descripcion" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_ESTADOASPIRANTE]", datos, parametros);
            return result;
        }
    }
}
