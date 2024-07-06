using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Catalogo
{
    internal class ClsGenero
    {
        public string cveGenero {  get; set; }
        public string descGenero { get; set; }
        public int estadoGenero {  get; set; }
        
        public ClsGenero() { }

        public void setDatosGenero (string _cveGenero, string _descGenero, int _estadoGenero)
        {
            cveGenero = _cveGenero;
            descGenero = _descGenero;
            estadoGenero = _estadoGenero;
        }

        object[] datos = { };
        string[] parametros = { };

<<<<<<< HEAD
        //public int insertarDatosGenero()
        //{
        //    datos = new object[] { cveGenero, descGenero, estadoCivil };
        //    parametros = new string[] { };
        //    retu
        //}
=======
        public int insertarDatosGenero()
        {
            datos = new object[] { cveGenero, descGenero, estadoGenero };
            parametros = new string[] { "@cveGenero", "@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_GENERO]", datos, parametros);
            return result;
        }

        public int updateDescGenero()
        {
            datos = new object[] { cveGenero, descGenero, estadoGenero };
            parametros = new string[] { "@cveGenero", "@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_GENERO]", datos, parametros);
            return result;
        }
<<<<<<< HEAD
>>>>>>> ea01c4fed8ce2ef9f9d42c28ffb91264715aa9fd
=======
>>>>>>> ea01c4fed8ce2ef9f9d42c28ffb91264715aa9fd
    }
}
