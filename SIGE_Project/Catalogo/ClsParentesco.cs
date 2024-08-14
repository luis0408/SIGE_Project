using DevExpress.XtraRichEdit.Import.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Catalogo
{
    internal class ClsParentesco
    {
        public int idParentesco { get; set; }
        public string descripcion {  get; set; }
        public int estado { get; set; }

        public ClsParentesco()
        { }

        public void setDatosParentesco(int _idParentesco, string _descripcion, int _estado)
        {
            idParentesco = _idParentesco;
            descripcion = _descripcion;
            estado = _estado;
        }

        object[] datos = { };
        string[] parametros = { };

        public int insertDatosParentesco()
        {
            datos = new object[] { descripcion, estado };
            parametros = new string[] { "@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_PARENTESCO]", datos, parametros);
            return result;
        }

        public int updateDatosParentesco()
        {
            datos = new object[] { idParentesco, descripcion, estado };
            parametros = new string[] { "@idParentesco","@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_PARENTESCO]", datos, parametros);
            return result;
        }


    }
}
