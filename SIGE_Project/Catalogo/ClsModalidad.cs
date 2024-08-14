using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Catalogo
{
    internal class ClsModalidad
    {
        public string cveModalidad { get; set; }
        public string descripcion { get; set; }
        public int estado { get; set; }

        public ClsModalidad()
        {

        }

        public void setDatosModalidad(string _cveModalidad, string _descripcion, int _estado)
        {
            cveModalidad = _cveModalidad;
            descripcion = _descripcion;
            estado = _estado;
        }
        object[] datos = { };
        string[] parametros = { };

        public int insertDatoModalidad()
        {
            datos = new object[] { cveModalidad, descripcion, estado };
            parametros = new string[] { "@cveModalidad", "@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_MODALIDAD]", datos, parametros);
            return result;

        }

        public int updateDescModalidad()
        {
            datos = new object[] { cveModalidad, descripcion, estado };
            parametros = new string[] { "@cveModalidad", "@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_MODALIDAD]", datos, parametros);
            return result;
        }
    }
}
