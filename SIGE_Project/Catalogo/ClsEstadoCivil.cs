using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Catalogo
{
    internal class ClsEstadoCivil
    {
        public string descEstadoCivil { set; get; }
        public int estadoCivil { set; get; }

        public ClsEstadoCivil() { }
        
        public void setDatosEstadoCivil(string _descEstadoCivil, int _estadoCivil)
        {
            descEstadoCivil = _descEstadoCivil;
            estadoCivil = _estadoCivil;
        }

        object[] datos = { };
        string[] parametros = { };

        public int insertDatoEstadoCivil()
        {
            datos = new object[] {descEstadoCivil, estadoCivil };
            parametros = new string[] {"@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_ESTADOCIVIL] ", datos, parametros);
            return result;
        }

        public int updateDescEstadoCivil()
        {
            datos = new object[] { descEstadoCivil,estadoCivil };
            parametros = new string[] { "@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_ESTADOCIVIL]", datos, parametros);
            return result;
        }

    }
}
