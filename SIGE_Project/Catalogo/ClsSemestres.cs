using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Catalogo
{
    internal class ClsSemestres
    {
        public int idSemestre {  get; set; }    
        public string descSemestres {  get; set; }
        public int estadoSemestres { get; set; }

        public ClsSemestres() { }

        public void setDatosGenero(int _idSemestre, string _descSemestres, int _estadoSemestres)
        {
            idSemestre = _idSemestre;
            descSemestres = _descSemestres;
            estadoSemestres = _estadoSemestres;
        }

        object[] datos = { };
        string[] parametros = { };

        public int insertarDatosSemestres()
        {
            datos = new object[] { descSemestres, estadoSemestres };
            parametros = new string[] { "@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_SEMESTRES]", datos, parametros);
            return result;
        }


        public int updateDescSemestres()
        {
            datos = new object[] { idSemestre, descSemestres, estadoSemestres };
            parametros = new string[] { "@idSemestre", "@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_SEMESTRES]", datos, parametros);
            return result;
        }
    }
}
