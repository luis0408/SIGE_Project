using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Catalogo
{
    internal class ClsEstado
    {
        public string c_Estado { get; set; }
        public string nombrePais { get; set; }
        public string nombreEstado {  get; set; }

        public ClsEstado() { }

        public void setDatosEstado(string _c_Estado, string _nombrePais, string _nombreEstado)
        {
            c_Estado = _c_Estado;
            nombrePais = _nombrePais;
            nombreEstado = _nombreEstado;
        }

        object[] datos = { };
        string[] parametros = { };

        public int insertDatoEstado()
        {
            datos = new object[] { c_Estado, nombrePais, nombreEstado };
            parametros = new string[] { "@c_Estado", "@nombrePais", "@nombreEstado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_ESTADO]", datos, parametros);
            return result;
        }

        public int updateDatoEstado()
        {
            datos = new object[] { c_Estado, nombrePais, nombreEstado };
            parametros = new string[] { "@c_Estado", "@nombrePais", "@nombreEstado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_ESTADO]", datos, parametros);
            return result;
        }
    }
}
