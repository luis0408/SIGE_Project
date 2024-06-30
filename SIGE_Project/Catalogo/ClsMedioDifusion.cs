using DevExpress.DocumentServices.ServiceModel.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.Catalogo
{
    internal class ClsMedioDifusion
    {
        public string cveMedioDifusion  { get; set; }
        public string descMedioDifusion { get; set; }
        public int estadoMedioDifusion { get; set; }

        public ClsMedioDifusion()
        {

        }
        
        public void setDatosMedio(string _cveMedioDifusion, string _descMedioDifusion, int _estadoMedioDifusion)
        {
            cveMedioDifusion = _cveMedioDifusion;
            descMedioDifusion = _descMedioDifusion;
            estadoMedioDifusion= _estadoMedioDifusion;  
        }
        object[] datos = { };
        string[] parametros = { };
        public int insertDatoMedioDifusion()
        {
            datos= new object[] {cveMedioDifusion,descMedioDifusion,estadoMedioDifusion };
            parametros= new string[] { "@cveMedioDifusion", "@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_MEDIOSDIFUSION]",datos,parametros);
            return result;  
            
        }

        public int updateDescMedioDifusion()
        {
            datos = new object[] { cveMedioDifusion, descMedioDifusion, estadoMedioDifusion };
            parametros = new string[] { "@cveMedioDifusion", "@descripcion", "@estado" };
            int result = Utilerias.ejecutarprocedimiento("[SIGE_ACTUALIZAR_MEDIOSDIFUSION]", datos, parametros);
            return result;
        }


    }
}
