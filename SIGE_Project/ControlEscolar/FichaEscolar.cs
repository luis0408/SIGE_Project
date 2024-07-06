using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGE_Project.ControlEscolar
{
    public partial class FichaEscolar : DevExpress.XtraEditors.XtraForm
    {
        public FichaEscolar()
        {
            InitializeComponent();
        }

        private void FichaEscolar_Load(object sender, EventArgs e)
        {
            llenarLookups();
        }
        private void llenarLookups()
        {
            ////PERIODO
            lookUpEdit_periodo.Properties.DataSource = Utilerias.llenarlookupeditvalue("select inicioPeriodo.idPeriodo,CONCAT(inicioPeriodo.iniPerido,'-',finPeriodo.finPer)as descripcion from " 
                                                                                       +" (select  idPeriodo,CONCAT(mes.cveMes,' ',anioInicio)iniPerido from [SIGE_Catalogo_Periodos] periodos"
                                                                                       +" left join SIGE_Catalogo_Mes mes on periodos.cveMesInicio=mes.numeroMes)inicioPeriodo left join "
                                                                                       +" (select  idPeriodo,CONCAT(mes.cveMes,' ',anioFin)finPer from [SIGE_Catalogo_Periodos] periodos "
                                                                                       +" left join SIGE_Catalogo_Mes mes on periodos.cveMesFin=mes.numeroMes)finPeriodo on inicioPeriodo.idPeriodo=finPeriodo.idPeriodo");
            lookUpEdit_periodo.Properties.DisplayMember = "descripcion";
            lookUpEdit_periodo.Properties.ValueMember = "idPeriodo";

            ////CICLO ESCOLAR
            lookUpEdit_cicloEscolar.Properties.DataSource = Utilerias.llenarlookupeditvalue("select idCicloEscolar,CONCAT(anioInicio,'-',anioFin)as descripcion from [SIGE_Catalogo_CicloEscolar] where estado=1");
            lookUpEdit_cicloEscolar.Properties.DisplayMember = "descripcion";
            lookUpEdit_cicloEscolar.Properties.ValueMember = "idCicloEscolar";

            ////MODALIDAD
            lookUpEdit_modalidad.Properties.DataSource = Utilerias.llenarlookupeditvalue("select cveModalidad, descripcion from [SIGE_Catalogo_Modalidad] where estado=1");
            lookUpEdit_modalidad.Properties.DisplayMember = "descripcion";
            lookUpEdit_modalidad.Properties.ValueMember = "cveModalidad";

            ////LICENCIATURA
            lookUpEdit_licenciatura.Properties.DataSource = Utilerias.llenarlookupeditvalue("select cveLicenciatura,descripcionLicenciatura FROM [SIGE_Catalogo_Licenciatura] where estado=1");
            lookUpEdit_licenciatura.Properties.DisplayMember = "descripcion";
            lookUpEdit_licenciatura.Properties.ValueMember = "cveLicenciatura";

            ////GENERO
            lookUpEdit_genero.Properties.DataSource = Utilerias.llenarlookupeditvalue("select cveGenero, descripcion from SIGE_Catalogo_Genero where estado=1");
            lookUpEdit_genero.Properties.DisplayMember = "descripcion";
            lookUpEdit_genero.Properties.ValueMember = "cveGenero";

            ////ESTADO CIVIL
            lookUpEdit_estadoCivil.Properties.DataSource = Utilerias.llenarlookupeditvalue("select idEstadoCivil,descripcion from SIGE_Catalogo_EstadoCivil where estado=1");
            lookUpEdit_estadoCivil.Properties.DisplayMember = "descripcion";
            lookUpEdit_estadoCivil.Properties.ValueMember = "idEstadoCivil";

            ////TIPO SANDRE
            lookUpEdit_tipoSangre.Properties.DataSource = Utilerias.llenarlookupeditvalue("select cveTipoSangre,descripcion from SIGE_Catalogo_TipoSangre where estado=1");
            lookUpEdit_tipoSangre.Properties.DisplayMember = "descripcion";
            lookUpEdit_tipoSangre.Properties.ValueMember = "cveTipoSangre";

            ////PAIS
            lookUpEdit_paisNacimiento.Properties.DataSource = Utilerias.llenarlookupeditvalue("select c_Pais,descripcion  from [dbo].[SIGE_Catalogo_Pais]");
            lookUpEdit_paisNacimiento.Properties.DisplayMember = "descripcion";
            lookUpEdit_paisNacimiento.Properties.ValueMember = "c_Pais";
          
            ////BACHILLERATO
            lookUpEdit_bachillerato.Properties.DataSource = Utilerias.llenarlookupeditvalue("  select CCT,CONCAT(CCT,' | ',nombreBachillerato) as descripcion, cveEntidad as estado, cveMunicipio from [SIGE_Catalogo_Bachillerato]");
            lookUpEdit_bachillerato.Properties.DisplayMember = "descripcion";
            lookUpEdit_bachillerato.Properties.ValueMember = "CCT";
        }

        private void lookUpEdit_paisNacimiento_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ////AL SELECCIONAR EL VALOR SE FILTRA EL LOOKUP "lookUpEdit_estadoNacimiento"
                string paisLookup = lookUpEdit_paisNacimiento.EditValue.ToString();///SE OBTIENE EL VALOR SELECCIONADO
                lookUpEdit_estadoNacimiento.Properties.DataSource = Utilerias.llenarlookupeditvalue("select c_Estado,nombreEstado as descripcion from SIGE_Catalogo_Estado where c_Pais='" + paisLookup + "'");
                lookUpEdit_estadoNacimiento.Properties.DisplayMember = "descripcion";
                lookUpEdit_estadoNacimiento.Properties.ValueMember = "c_Estado";
            }
            catch (Exception ex) { }
            
        }

        private void lookUpEdit_estadoNacimiento_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ////AL SELECCIONAR EL VALOR SE FILTRA EL LOOKUP "lookUpEdit_municipioNacimiento"
                string estadoLookup = lookUpEdit_estadoNacimiento.EditValue.ToString();///SE OBTIENE EL VALOR SELECCIONADO
                lookUpEdit_municipioNacimiento.Properties.DataSource = Utilerias.llenarlookupeditvalue(" select c_Municipio,descripcion  from SIGE_Catalogo_Municipio where c_Estado='" + estadoLookup + "'");
                lookUpEdit_municipioNacimiento.Properties.DisplayMember = "descripcion";
                lookUpEdit_municipioNacimiento.Properties.ValueMember = "c_Municipio";
            }
            catch (Exception ex) { }
        }

        private void textEdit_codigoPostal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ////AL INGRESAR UN CODIGO POSTAL SE CARGA EL LOOKUP "lookUpEdit_colonia"
                string cpIngresado = textEdit_codigoPostal.Text;///SE OBTIENE EL VALOR SELECCIONADO
                lookUpEdit_colonia.Properties.DataSource = Utilerias.llenarlookupeditvalue("select c_Colonia,nombreColonia as descripcion  from SIGE_Catalogo_Colonia where c_CodigoPostal='" + cpIngresado + "'");
                lookUpEdit_colonia.Properties.DisplayMember = "descripcion";
                lookUpEdit_colonia.Properties.ValueMember = "c_Colonia";
            }
            catch (Exception ex) { }
        }
    }
}