using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Catalogo
{
    internal class ClsLicenciatura
    {

        public string cveLicenciatura { get; set; }
        public string descLicenciatura { get; set; }
        public int estadoLicenciatura { get; set; }

        public ClsLicenciatura() 
        {

        }
        public void setDatosLicenciatura(string _cveLicenciatura, string _descLicenciatura, int _estadoLicenciatura)
        {
            cveLicenciatura = _cveLicenciatura;
            descLicenciatura = _descLicenciatura;
            estadoLicenciatura = _estadoLicenciatura;
        }
        object[] datos = { };
        string[] parametros = { };
        public int insertDatoLicenciatura()
        {
            datos = new object[] { cveLicenciatura, descLicenciatura, estadoLicenciatura };
            parametros = new string[] { "@cveLicenciatura", "@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_LICENCIATURAS]", datos, parametros);
            return result;

        }

        public int updateDatoLicenciatura()
        {
            datos = new object[] { cveLicenciatura, descLicenciatura, estadoLicenciatura };
            parametros = new string[] { "@cveLicenciatura", "@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_LICENCIATURAS]", datos, parametros);
            return result;
        }
    }
}
