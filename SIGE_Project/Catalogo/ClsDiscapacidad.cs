using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Catalogo
{
    internal class ClsDiscapacidad
    {
        public int idDIscapacidad { get; set; } 
        public string descripcion { get; set; }
        public int estado { get; set; }

        public ClsDiscapacidad()
        {
        }

        public void setDatosDiscapacidad(int _idDIscapacidad, string _descripcion, int _estado)
        {
            idDIscapacidad = _idDIscapacidad;
            descripcion = _descripcion;
            estado = _estado;
        }

        object[] datos = new object[0];
        string[] parametros = new string[0];

        public int insertDatoDiscapacidad()
        {
            datos = new object[] { descripcion, estado };
            parametros = new string[] { "@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_DISCAPACIDAD]", datos, parametros);
            return result;
        }

        public int updateDescDiscapacidad()
        {
            datos = new object[] { idDIscapacidad, descripcion, estado };
            parametros = new string[] { "@idDIscapacidad", "@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_DISCAPACIDAD]", datos, parametros);
            return result;
        }
    }
}