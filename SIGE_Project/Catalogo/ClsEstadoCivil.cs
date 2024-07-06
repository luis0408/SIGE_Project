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
        public int idEstadoCivil {  get; set; } 
        public string descEstadoCivil { set; get; }
        public int estadoCivil { set; get; }

        public ClsEstadoCivil() { }
        
        public void setDatosEstadoCivil(int _idEstadoCivil, string _descEstadoCivil, int _estadoCivil)
        {
            idEstadoCivil = _idEstadoCivil;
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
            datos = new object[] { idEstadoCivil,descEstadoCivil,estadoCivil };
            parametros = new string[] { "@idEstadoCivil","@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_ESTADOCIVIL]", datos, parametros);
            return result;
        }

    }
}
