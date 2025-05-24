using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Catalogo
{
    internal class ClsGeneracion
    {
        public int anioInicio { get; set; }
        public int anioFin { get; set; }
        public int estado { get; set; }
        public int idGeneracion { get; set; }

        public ClsGeneracion()
        { }

        public void setDatosGeneracion(int _anioInicio, int _anioFin, int _estado)
        {
            anioInicio = _anioInicio;
            anioFin = _anioFin;
            estado = _estado;
        }
        object[] datos = { };
        string[] parametros = { };
        public int insertDatoGeneracion()
        {
            datos = new object[] { anioInicio, anioFin, estado };
            parametros = new string[] { "@anioInicio", "@anioFin", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_GENERACION]", datos, parametros);
            return result;
        }
        public int updateDatoGeneracion()
        {
            
            datos = new object[] { anioInicio, anioFin, estado,idGeneracion };
            parametros = new string[] { "@anioInicio", "@anioFin", "@estado","@idGeneracion" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_GENERACION]", datos, parametros);
            return result;
        }
    }
}
