using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Catalogo
{
    internal class ClsCicloEscolar
    {
        public int anioInicio { get; set; }
        public int anioFin { get; set; }
        public int estado { get; set; }

        public ClsCicloEscolar()
        { }
        public void setCicloEscolar(int _anioInicio, int _anioFin, int _estado)
        {
            anioInicio = _anioInicio;
            anioFin = _anioFin;
            estado = _estado;
        }
        object[] datos = { };
        string[] parametros = { };
        public int insertDatoCicloEscolar()
        {
            datos = new object[] { anioInicio, anioFin, estado };
            parametros = new string[] { "@anioInicio", "@anioFin", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_CICLOESCOLAR]", datos, parametros);
            return result;
        }
        public int updateDatoCicloEscolar()
        {
            datos = new object[] { anioInicio, anioFin, estado };
            parametros = new string[] { "@anioInicio", "@anioFin", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_CICLOESCOLAR]", datos, parametros);
            return result;
        }
    }
}
