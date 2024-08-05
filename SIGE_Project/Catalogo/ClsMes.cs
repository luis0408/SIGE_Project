using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Catalogo
{
    internal class ClsMes
    {
        public string cveMes { get; set; }
        public string descripcion { get; set; }
        public int numeroMes { get; set; }

        public ClsMes()
        {

        }

        public void setDatosMes(string _cveMes, string _descripcion, int _numeroMes)
        {
            cveMes = _cveMes;
            descripcion = _descripcion;
            numeroMes = _numeroMes;
        }
        object[] datos = { };
        string[] parametros = { };

        public int insertDatoMes()
        {
            datos = new object[] { cveMes, descripcion, numeroMes };
            parametros = new string[] { "@cveMes", "@descripcion", "@numeroMes" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_MES]", datos, parametros);
            return result;

        }

        public int updateDescMes ()
        {
            datos = new object[] { cveMes, descripcion, numeroMes };
            parametros = new string[] { "@cveMes", "@descripcion", "@numeroMes" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_MES]", datos, parametros);
            return result;
        }
    }
}
