using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Catalogo
{
    internal class ClsDepartamento
    {
        public string cveDepartamento {  get; set; }
        public string descripcion { get; set; }
        public string encargado { get; set; }
        public int estado { get; set; }

        public ClsDepartamento()
        { }

        public void setDatosDepartamento(string _cveDepartamento, string _descripcion, string _encargado, int _estado)
        {
            cveDepartamento = _cveDepartamento;
            descripcion = _descripcion;
            encargado = _encargado;
            estado = _estado;
        }
        object[] datos = { };
        string[] parametros = { };
        public int insertDatoDepartamento()
        {
            datos = new object[] { cveDepartamento, descripcion, encargado, estado };
            parametros = new string[] { "@cveDepartamento", "@descripcion", "@encargado", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_DEPARTAMENTO]", datos, parametros);
            return result;
        }
        public int updateDatoDepartamento()
        {
            datos = new object[] { cveDepartamento, descripcion, encargado, estado };
            parametros = new string[] { "@cveDepartamento", "@descripcion", "@encargado", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_DEPARTAMENTO]", datos, parametros);
            return result;
        }
    }
}
