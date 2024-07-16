using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project.ControlEscolar
{
    internal class ClsPersona
    {
        #region tblPersona
        public string CURP { get; set; }
        public string RFC { get; set; }
        public string NSS { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string cveGenero { get; set; }
        public int? idEstadoCivil { get; set; }
        public string email { get; set; }
        public string celular { get; set; }
        public string cveTipoSangre { get; set; }
        #endregion

        #region tblPersonaDomicilio
        public string calle { get; set; }
        public string numeroExterior { get; set; }
        public string numeroInterior { get; set; }
        public string CP { get; set; }
        public string cveColonia { get; set; }
        public string cveEstado { get; set; }
        public string cveLocalidad { get; set; }
        public string cveMunicipio { get; set; }

        #endregion

        #region tblPersonaNacimiento
        public DateTime fechaNacimiento { get; set; }
        public string cvePais { get; set; }
        public string cveEstadoNacimiento { get; set; }
        public string cveMunicipioNacimiento { get; set; }
        #endregion

        #region tblPersonaLenguaIndigena
        public int hablaLenguaIndigena { get; set; }
        public string descripcionLI { get; set; }
        #endregion

        #region tblPersonaDiscapacidad
        public int idDiscapacidad { get; set; }
        #endregion
        public ClsPersona() 
        {

        }

        public void setDatosPersona(string _CURP, string _RFC, string _NSS, string _nombre, string _apellidoPaterno, string _apellidoMaterno, 
                                     string _cveGenero, int? _idEstadoCivil, string _email, string _celular, string _cveTipoSangre)
        {
            CURP = _CURP;
            RFC = _RFC; 
            NSS = _NSS;
            nombre = _nombre;
            apellidoMaterno = _apellidoMaterno;
            apellidoPaterno = _apellidoPaterno;
            cveGenero = _cveGenero;
            idEstadoCivil = _idEstadoCivil;
            email = _email; 
            celular = _celular;
            cveTipoSangre = _cveTipoSangre;
        }
        public void setDatosPersonaDomicilio(string _calle, string _numeroExterior, string _numeroInterior, string _CP, string _cveColonia,
                                              string _cveEstado, string _cveLocalidad, string _cveMunicipio)
        {
            calle = _calle; 
            numeroExterior = _numeroExterior;   
            numeroInterior = _numeroInterior;
            CP = _CP;
            cveColonia= _cveColonia;
            cveEstado = _cveEstado;
            cveLocalidad = _cveLocalidad;   
            cveMunicipio = _cveMunicipio;   
        }
        public void setDatosPersonaNacimiento(DateTime _fechaNacimiento, string _cvePais, string _cveEstadoNacimiento, string _cveMunicipioNacimiento)
        {
            fechaNacimiento = _fechaNacimiento; 
            cvePais = _cvePais;
            cveEstadoNacimiento = _cveEstadoNacimiento;
            cveMunicipioNacimiento=_cveMunicipioNacimiento;
        }
        public void setDatosPersonaLenguaIndigena(int _hablaLenguaIndigena, string _descripcionLI)
        {
            hablaLenguaIndigena= _hablaLenguaIndigena;  
            descripcionLI = _descripcionLI; 
        }
        public void setDatosPersonaDiscapacidad(int _idDiscapacidad )
        {
            idDiscapacidad = _idDiscapacidad;
        }
        object[] datos = { };
        string[] parametros = { };
        public int insertarPersona()
        {
            datos= new object[] { CURP, RFC, NSS, nombre, apellidoPaterno, apellidoMaterno, cveGenero, idEstadoCivil, email, celular, cveTipoSangre };
            parametros= new string[] { "@CURP", "@RFC", "@NSS", "@nombre", "@apellidoPaterno", "@apellidoMaterno", "@cveGenero", "@idEstadoCivil", "@email", "@celular", "@cveTipoSangre" };
            int resultadoInsert=Utilerias.ejecutarprocedimiento("SIGE_INSERTAR_PERSONA", datos,parametros);
            return resultadoInsert;
        }
        public int insertarPersonaDomicilio()
        {
            datos = new object[] { CURP, calle, numeroExterior, numeroInterior, CP, cveColonia, cveEstado, cveLocalidad, cveMunicipio };
            parametros = new string[] { "@CURP","@calle","@numeroExterior","@numeroInterior","@CP","@cveColonia","@cveEstado","@cveLocalidad","@cveMunicipio" };
            int resultadoInsert = Utilerias.ejecutarprocedimiento("SIGE_INSERTAR_PERSONADOMICILIO", datos, parametros);
            return resultadoInsert;
        }
        public int insertarPersonaNacimiento()
        {
            datos = new object[] {CURP, fechaNacimiento, cvePais, cveEstadoNacimiento, cveMunicipioNacimiento };
            parametros = new string[] { "@CURP", "@fechaNacimiento", "@cvePais", "@cveEstado", "@cveMunicipio" };
            int resultadoInsert = Utilerias.ejecutarprocedimiento("SIGE_INSERTAR_PERSONANACIMIENTO", datos, parametros);
            return resultadoInsert;
        }
        public int insertarPersonaLenguaIndigena()
        {
            datos = new object[] {CURP, hablaLenguaIndigena,descripcionLI };
            parametros = new string[] { "@CURP","@hablaLenguaIndigena", "@descripcion" };
            int resultadoInsert = Utilerias.ejecutarprocedimiento("SIGE_INSERTAR_PERSONALENGUAINDIGENA", datos, parametros);
            return resultadoInsert;
        }
        public int insertarPersonaDiscapacidad()
        {
            datos = new object[] {CURP, idDiscapacidad };
            parametros = new string[] { "@CURP", "@idDiscapacidad" };
            int resultadoInsert = Utilerias.ejecutarprocedimiento("[SIGE_INSERTAR_PERSONADISCAPACIDAD]", datos, parametros);
            return resultadoInsert;
        }
        public int updatePersona()
        {
            datos = new object[] { CURP, RFC, NSS, nombre, apellidoPaterno, apellidoMaterno, cveGenero, idEstadoCivil, email, celular, cveTipoSangre };
            parametros = new string[] { "@CURP", "@RFC", "@NSS", "@nombre", "@apellidoPaterno", "@apellidoMaterno", "@cveGenero", "@idEstadoCivil", "@email", "@celular", "@cveTipoSangre" };
            int resultadoUpdate = Utilerias.ejecutarprocedimiento("SIGE_ACTUALIZAR_PERSONA", datos, parametros);
            return resultadoUpdate;
        }
        public int updatePersonaDomicilio()
        {
            datos = new object[] {CURP, calle, numeroExterior, numeroInterior, CP, cveColonia, cveEstado, cveLocalidad, cveMunicipio };
            parametros = new string[] { "@CURP", "@calle", "@numeroExterior", "@numeroInterior", "@CP", "@cveColonia", "@cveEstado", "@cveLocalidad", "@cveMunicipio" };
            int resultadoUpdate = Utilerias.ejecutarprocedimiento("SIGE_ACTUALIZAR_PERSONADOMICILIO", datos, parametros);
            return resultadoUpdate;
        }
        public int updatePersonaNacimiento()
        {
            datos = new object[] {CURP, fechaNacimiento, cvePais, cveEstadoNacimiento, cveMunicipioNacimiento };
            parametros = new string[] { "@CURP", "@fechaNacimiento", "@cvePais", "@cveEstadoNacimiento", "@cveMunicipioNacimiento" };
            int resultadoUpdate = Utilerias.ejecutarprocedimiento("SIGE_ACTUALIZAR_PERSONANACIMIENTO", datos, parametros);
            return resultadoUpdate;
        }
        public int updatePersonaLenguaIndigena()
        {
            datos = new object[] {CURP, hablaLenguaIndigena, descripcionLI };
            parametros = new string[] { "@CURP","@hablaLenguaIndigena", "@descripcionLI" };
            int resultadoUpdate = Utilerias.ejecutarprocedimiento("SIGE_ACTUALIZAR_PERSONALENGUAINDIGENA", datos, parametros);
            return resultadoUpdate;
        }
        public int deleteDiscpacidades()
        {
            datos = new object[] { CURP };
            parametros = new string[] { "@CURP" };
            int resultadoUpdate = Utilerias.ejecutarprocedimiento("[SIGE_ELIMINAR_PERSONADISCAPACIDAD]", datos, parametros);
            return resultadoUpdate;
        }
    }
}
