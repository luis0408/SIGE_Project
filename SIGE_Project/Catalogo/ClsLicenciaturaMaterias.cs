using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Catalogo
{
    internal class ClsLicenciaturaMaterias
    {
        public string cveMateria { get; set; }
        public string descripcion { get; set; }
        public string cveLicenciatura { get; set; }
        public int estado { get; set; }

        public ClsLicenciaturaMaterias() { }

        public void setDatosLicenciaturaMaterias(string _cveMateria, string _descripcion, string _cveLicenciatura, int _estado)
        {
            cveMateria = _cveMateria;
            descripcion = _descripcion;
            cveLicenciatura = _cveLicenciatura;
            estado = _estado;
        }

        object[] datos = { };
        string[] parametros = { };

        public int insertDatoLicenciaturaMaterias()
        {
            datos = new object[] { cveMateria, descripcion, cveLicenciatura, estado };
            parametros = new string[] { "@cveMateria", "@descripcion", "@cveLicenciatura", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_LICENCIATURAMATERIAS]", datos, parametros);
            return result;
        }

        public int updateDatoLicenciaturaMaterias()
        {
            datos = new object[] { cveMateria, descripcion, cveLicenciatura, estado };
            parametros = new string[] { "@cveMateria", "@descripcion", "@cveLicenciatura", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_LICENCIATURAMATERIAS]", datos, parametros);
            return result;
        }
    }
}
