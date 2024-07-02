using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Catalogo
{
    internal class ClsPeriodos
    {
        public int idCicloEscolar { get; set; }
        public string cveMesInicio { get; set; }
        public int anioInicio { get; set; }
        public string cveMesFin { get; set; }
        public int anioFin { get; set; }

        public ClsPeriodos()
        {

        }

        public void setDatosPeriodos(int _idCicloEscolar, string _cveMesInicio, int _anioInicio, string _cveMesFin, int _anioFin)
        {
            idCicloEscolar = _idCicloEscolar;
            cveMesInicio = _cveMesInicio;
            anioInicio = _anioInicio;
            cveMesFin = _cveMesFin;
            anioFin = _anioFin;
        }
        object[] datos = { };
        string[] parametros = { };

        public int insertDatoPeriodos()
        {
            datos = new object[] { idCicloEscolar, cveMesInicio, anioInicio, cveMesFin, anioFin };
            parametros = new string[] { "@idCicloEscolar", "@cveMesInicio", "@anioInicio", "@cveMesFin", "@anioFin" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_PERIODOS]", datos, parametros);
            return result;

        }

        public int updateDescPeriodos()
        {
            datos = new object[] { idCicloEscolar, cveMesInicio, anioInicio, cveMesFin, anioFin };
            parametros = new string[] { "@idCicloEscolar", "@cveMesInicio", "@anioInicio", "@cveMesFin", "@anioFin" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_PERIODOS]", datos, parametros);
            return result;
        }
    }
}
