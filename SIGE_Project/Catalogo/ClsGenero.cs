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
        public int estadoCivil {  get; set; }
        
        public ClsGenero() { }

        public void setDatosGenero (string _cveGenero, string _descGenero, int _estadoCivil)
        {
            cveGenero = _cveGenero;
            descGenero = _descGenero;  
            estadoCivil = _estadoCivil;
        }

        object[] datos = { };
        string[] parametros = { };

        public int insertarDatosGenero()
        {
            datos = new object[] {cveGenero, descGenero, estadoCivil};
            parametros = new string[] { };

    }
}
