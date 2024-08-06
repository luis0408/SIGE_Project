using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Catalogo
{
    internal class ClsDiscapacidad
    {

        public string descDiscapacidad {  get; set; }
        public int estadoDiscapacidad { get; set; }

        public ClsDiscapacidad() { }

        public void setDatosGenero(string _descDiscapacidad, int _estadoDiscapacidad)
        {
            descDiscapacidad = _descDiscapacidad;
            estadoDiscapacidad = _estadoDiscapacidad;
        }

        object[] datos = { };
        string[] parametros = { };

        public int insertarDatosDiscapacidad()
        {
            datos = new object[] { descDiscapacidad, estadoDiscapacidad };
            parametros = new string[] { "@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_DISCAPACIDAD]", datos, parametros);
            return result;
        }

        public int updateDescDiscapacidad()
        {
            datos = new object[] { descDiscapacidad, estadoDiscapacidad };
            parametros = new string[] { "@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_DISCAPACIDAD]", datos, parametros);
            return result;
        }

    }
}
