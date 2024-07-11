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
        ClsPersona objPersona;
        ClsApirante objApirante;
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
            

            ////CICLO ESCOLAR
            lookUpEdit_cicloEscolar.Properties.DataSource = Utilerias.llenarlookupeditvalue("select idCicloEscolar,CONCAT(anioInicio,'-',anioFin)as descripcion from [SIGE_Catalogo_CicloEscolar] where estado=1 order by idCicloEscolar desc");
            lookUpEdit_cicloEscolar.Properties.DisplayMember = "descripcion";
            lookUpEdit_cicloEscolar.Properties.ValueMember = "idCicloEscolar";

            ////MODALIDAD
            lookUpEdit_modalidad.Properties.DataSource = Utilerias.llenarlookupeditvalue("select cveModalidad, descripcion from [SIGE_Catalogo_Modalidad] where estado=1");
            lookUpEdit_modalidad.Properties.DisplayMember = "descripcion";
            lookUpEdit_modalidad.Properties.ValueMember = "cveModalidad";

            ////LICENCIATURA
            lookUpEdit_licenciatura.Properties.DataSource = Utilerias.llenarlookupeditvalue("select cveLicenciatura,descripcionLicenciatura as descripcion FROM [SIGE_Catalogo_Licenciatura] where estado=1");
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


            ////ESTADO BACHILLERATO
            textEdit_estadoBachillerato.Properties.DataSource = Utilerias.llenarlookupeditvalue("select c_Estado,nombreEstado as descripcion from SIGE_Catalogo_Estado where c_Pais='MEX'");
            textEdit_estadoBachillerato.Properties.DisplayMember = "descripcion";
            textEdit_estadoBachillerato.Properties.ValueMember = "c_Estado";
            ////ESTADO DOMICILIO
            lookUpEdit_estado.Properties.DataSource = Utilerias.llenarlookupeditvalue("select c_Estado,nombreEstado as descripcion from SIGE_Catalogo_Estado where c_Pais='MEX'");
            lookUpEdit_estado.Properties.DisplayMember = "descripcion";
            lookUpEdit_estado.Properties.ValueMember = "c_Estado";

            ////PARENTESCO
            lookUpEdit_parentesco.Properties.DataSource = Utilerias.llenarlookupeditvalue("SELECT idParentesco,descripcion FROM SIGE_Catalogo_Parentesco where estado=1");
            lookUpEdit_parentesco.Properties.DisplayMember = "descripcion";
            lookUpEdit_parentesco.Properties.ValueMember = "idParentesco";

            ////MEDIO DE DIFUSION
            textEdit_medioDifusion.Properties.DataSource = Utilerias.llenarlookupeditvalue("SELECT cveMedio,descripcion FROM SIGE_Catalogo_MediosDifusion WHERE estado=1");
            textEdit_medioDifusion.Properties.DisplayMember = "descripcion";
            textEdit_medioDifusion.Properties.ValueMember = "cveMedio";

            
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
        private void lookUpEdit_cicloEscolar_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ////AL SELECCIONAR EL VALOR SE FILTRA EL LOOKUP "lookUpEdit_cicloEscolar"
                string idCicloEscolar = lookUpEdit_cicloEscolar.EditValue.ToString();///SE OBTIENE EL VALOR SELECCIONADO

                ////PERIODO
                lookUpEdit_periodo.Properties.DataSource = Utilerias.llenarlookupeditvalue("  select CONCAT(cveMesInicio,' ',anioInicio,'-',cveMesFin,' ',anioFin)as descripcion from SIGE_Catalogo_Periodos periodo where idCicloEscolar=" + idCicloEscolar + " order by idPeriodo desc ");
                lookUpEdit_periodo.Properties.DisplayMember = "descripcion";
                lookUpEdit_periodo.Properties.ValueMember = "idPeriodo";


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

        private void lookUpEdit_estado_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ////AL SELECCIONAR EL VALOR SE FILTRA EL LOOKUP "lookUpEdit_municipio"
                string estadoLookup = lookUpEdit_estado.EditValue.ToString();///SE OBTIENE EL VALOR SELECCIONADO

                lookUpEdit_municipio.Properties.DataSource = Utilerias.llenarlookupeditvalue("select c_Municipio,descripcion from SIGE_Catalogo_Municipio where c_Estado='" + estadoLookup + "'");
                lookUpEdit_municipio.Properties.DisplayMember = "descripcion";
                lookUpEdit_municipio.Properties.ValueMember = "c_Municipio";

                lookUpEdit_localidad.Properties.DataSource = Utilerias.llenarlookupeditvalue("select c_Localidad,descripcion  from SIGE_Catalogo_Localidad where c_Estado='" + estadoLookup + "'");
                lookUpEdit_localidad.Properties.DisplayMember = "descripcion";
                lookUpEdit_localidad.Properties.ValueMember = "c_Localidad";
            }
            catch (Exception ex) { }
        }

        private void textEdit_estadoBachillerato_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ////AL SELECCIONAR EL VALOR SE FILTRA EL LOOKUP "lookUpEdit_municipio"
                string estadoLookup = textEdit_estadoBachillerato.EditValue.ToString();///SE OBTIENE EL VALOR SELECCIONADO

                textEdit_municipioBachillerato.Properties.DataSource = Utilerias.llenarlookupeditvalue("select c_Municipio,descripcion from SIGE_Catalogo_Municipio where c_Estado='" + estadoLookup + "'");
                textEdit_municipioBachillerato.Properties.DisplayMember = "descripcion";
                textEdit_municipioBachillerato.Properties.ValueMember = "c_Municipio";


            }
            catch (Exception ex) { }
        }

        private void textEdit_municipioBachillerato_EditValueChanged(object sender, EventArgs e)
        {
            ///AL SELECCIONAR EL VALOR SE FILTRA EL LOOKUP "lookUpEdit_municipio"
            string estadoBachillerato = textEdit_estadoBachillerato.EditValue.ToString();///SE OBTIENE EL VALOR SELECCIONADO
            string municipioBachillerato = textEdit_municipioBachillerato.EditValue.ToString();///SE OBTIENE EL VALOR SELECCIONADO

            lookUpEdit_bachillerato.Properties.DataSource = Utilerias.llenarlookupeditvalue("select CCT,nombreBachillerato, CONCAT(CCT,' | ',nombreBachillerato)as descripcion from SIGE_Catalogo_Bachillerato where cveEntidad='"+estadoBachillerato+"' and cveMunicipio='"+municipioBachillerato+"'");
            lookUpEdit_bachillerato.Properties.DisplayMember = "descripcion";
            lookUpEdit_bachillerato.Properties.ValueMember = "CCT";
        }

        private void radioGroup_lenguaIndigena_EditValueChanged(object sender, EventArgs e)
        {
            if (radioGroup_lenguaIndigena.SelectedIndex==0)////SE VALIDA QUE LA POSICION 0 SEA SELECCIONA (SI)
            {
                memoEdit_especifique.ReadOnly = false;
            }
            else if (radioGroup_lenguaIndigena.SelectedIndex == 1)////POSICION 1 ES (NO)
            {
                memoEdit_especifique.ReadOnly = true;
            }
        }

        private void simpleButton_save_Click(object sender, EventArgs e)
        {

            if (lookUpEdit_modalidad.EditValue == null)
            {
                XtraMessageBox.Show("Seleccione una modalidad.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (lookUpEdit_licenciatura.EditValue == null)
            {
                XtraMessageBox.Show("Seleccione una licenciatura.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            if (string.IsNullOrEmpty(textEdit_nombre.Text))
            {
                XtraMessageBox.Show("Ingrese un nombre valido.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_apellidoMaterno.Text))
            {
                XtraMessageBox.Show("Ingrese un apellido materno valido.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_apellidoPaterno.Text))
            {
                XtraMessageBox.Show("Ingrese un apellido paterno valido.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_CURP.Text))
            {
                XtraMessageBox.Show("Ingrese la CURP.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_RFC.Text))
            {
                XtraMessageBox.Show("Ingrese su RFC.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (string.IsNullOrEmpty(textEdit_NSS.Text))
            {
                XtraMessageBox.Show("Ingrese su número de seguro social.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (lookUpEdit_genero.EditValue == null)
            {
                XtraMessageBox.Show("Seleccione un género", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (lookUpEdit_estadoCivil.EditValue == null)
            {
                XtraMessageBox.Show("Seleccione un estado civil.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(textEdit_numTelefono.Text))
            {
                XtraMessageBox.Show("Ingrese su número telefónico.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (radioGroup_lenguaIndigena.EditValue == null)
            {
                XtraMessageBox.Show("Seleccione si habla o no una lengua indigena.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (radioGroup_lenguaIndigena.SelectedIndex == 0)////SE VALIDA QUE LA POSICION 0 SEA SELECCIONA (SI)
            {
                if (string.IsNullOrEmpty(memoEdit_especifique.Text))
                {
                    XtraMessageBox.Show("Ingrese que lengua indigena habla.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (string.IsNullOrEmpty(textEdit_correoElectronico.Text))
            {
                XtraMessageBox.Show("Ingrese un correo electronico.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dateEdit_fechaNacimiento.EditValue == null)
            {
                XtraMessageBox.Show("Ingrese su fecha de nacimiento.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_calle.Text))
            {
                XtraMessageBox.Show("Ingrese la calle de su domicilio.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_numExterior.Text))
            {
                XtraMessageBox.Show("Ingrese el número exterior de su domicilio.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_codigoPostal.Text))
            {
                XtraMessageBox.Show("Ingrese su código postal.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (lookUpEdit_colonia.EditValue == null)
            {
                XtraMessageBox.Show("Seleccione la colonia de su domicilio.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (lookUpEdit_estado.EditValue == null)
            {
                XtraMessageBox.Show("Seleccione el estado donde reside actualmente.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (lookUpEdit_localidad.EditValue == null)
            {
                XtraMessageBox.Show("Seleccione la localidad donde reside actualmente.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (lookUpEdit_municipio.EditValue == null)
            {
                XtraMessageBox.Show("Seleccione el municipio donde reside actualmente.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (textEdit_estadoBachillerato.EditValue == null)
            {
                XtraMessageBox.Show("Seleccione el estado de su bachillerato.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (textEdit_municipioBachillerato.EditValue == null)
            {
                XtraMessageBox.Show("Seleccione el municipio de su bachillerato.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (lookUpEdit_bachillerato.EditValue == null)
            {
                XtraMessageBox.Show("Seleccione su bachillerato.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_promedio.Text))
            {
                XtraMessageBox.Show("Ingrese el promedio que salio de su bachillerato.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            

            if (textEdit_medioDifusion.EditValue==null)
            {
                XtraMessageBox.Show("Seleccione le medio por el cual se entero de la institución.", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                //objPersona = new ClsPersona();
                objApirante = new ClsApirante();
                objApirante.setDatosPersona(textEdit_CURP.Text, textEdit_RFC.Text, textEdit_NSS.Text, textEdit_nombre.Text, textEdit_apellidoPaterno.Text
                                           , textEdit_apellidoMaterno.Text, lookUpEdit_genero.EditValue.ToString(), Convert.ToInt32(lookUpEdit_estadoCivil.EditValue), textEdit_correoElectronico.Text
                                           , textEdit_numTelefono.Text, lookUpEdit_tipoSangre.EditValue.ToString());

                objApirante.setDatosPersonaDomicilio(textEdit_calle.Text, textEdit_numExterior.Text, textEdit_numInterior.Text, textEdit_codigoPostal.Text, lookUpEdit_colonia.EditValue.ToString()
                                                    , lookUpEdit_estado.EditValue.ToString(), lookUpEdit_localidad.EditValue.ToString(), lookUpEdit_municipio.EditValue.ToString());

                objApirante.setDatosPersonaNacimiento(Convert.ToDateTime(dateEdit_fechaNacimiento.EditValue), lookUpEdit_paisNacimiento.EditValue.ToString()
                                                     , lookUpEdit_estadoNacimiento.EditValue.ToString(), lookUpEdit_municipioNacimiento.EditValue.ToString());

                objApirante.setDatosPersonaLenguaIndigena(Convert.ToInt32(radioGroup_lenguaIndigena.EditValue), memoEdit_especifique.Text);


                if (objApirante.insertarPersona() == 1)
                {
                    if (objApirante.insertarPersonaDomicilio() == 1)
                    {
                        if (objApirante.insertarPersonaNacimiento() == 1)
                        {
                            if (objApirante.insertarPersonaLenguaIndigena() == 1)
                            {
                                insertarAspirante();
                            }
                            else
                            { throw new Exception("Error al insertar los datos de lengua indigena."); }
                        }
                        else { throw new Exception("Error al insertar datos de nacimiento."); }
                    }
                    else { throw new Exception("Error al insertar datos de domicilio."); }
                }
                else { throw new Exception("Error al insertar datos de la persona."); }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Se ha generado un error al realizar el registro. \nDetalles: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void insertarAspirante()
        {
            
            objApirante.setDatosAspirante(lookUpEdit_licenciatura.EditValue.ToString(), lookUpEdit_modalidad.EditValue.ToString(),
                                         Convert.ToInt32(lookUpEdit_cicloEscolar.EditValue), Convert.ToInt32(lookUpEdit_periodo.EditValue), lookUpEdit_bachillerato.EditValue.ToString()
                                         , Convert.ToDecimal(textEdit_promedio.Text), textEdit_medioDifusion.EditValue.ToString(), variables.varUser);
            int result = objApirante.insertarAspirante();
            if (result==1)
            {

                XtraMessageBox.Show("El aspirante se registró corerctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();

            }
            else
            {
                throw new Exception("Error al insertar datos del aspirante.");
            }
        }
        private void limpiar()
        {
            lookUpEdit_cicloEscolar.EditValue = null;
            lookUpEdit_periodo.EditValue = null;
            lookUpEdit_modalidad = null;
            lookUpEdit_licenciatura = null;
            /////DATOS PERSONALES 
            textEdit_nombre.Text = "";
            textEdit_apellidoPaterno.Text = "";
            textEdit_apellidoMaterno.Text = "";
            textEdit_CURP.Text = "";
            textEdit_RFC.Text = "";
            textEdit_NSS.Text = "";
            lookUpEdit_genero.EditValue = null;
            lookUpEdit_estadoCivil.EditValue = null;
            textEdit_numTelefono.Text = "";
            radioGroup_lenguaIndigena.SelectedIndex = 1;
            textEdit_correoElectronico.Text = "";
            lookUpEdit_tipoSangre.EditValue = null;
            ////DATPS NACIMIENTO
            dateEdit_fechaNacimiento.EditValue = null;  
            lookUpEdit_paisNacimiento.EditValue= null;
            lookUpEdit_estadoNacimiento.EditValue=null;
            lookUpEdit_municipioNacimiento.EditValue=null;
            ////DATOS DOMICILIO
            textEdit_calle.Text = "";
            textEdit_numExterior.Text = "";
            textEdit_numInterior.Text = "";
            textEdit_codigoPostal.Text = "";
            lookUpEdit_colonia.EditValue= null;
            lookUpEdit_estado.EditValue= null;
            lookUpEdit_localidad.EditValue= null;
            lookUpEdit_municipio.EditValue= null;
            ////DATOS BACHILLERATO
            textEdit_estadoBachillerato.EditValue= null;    
            textEdit_municipioBachillerato.EditValue = null;
            lookUpEdit_bachillerato.EditValue= null;
            textEdit_promedio.Text = "";
            ////DATOS TUTOR
            textEdit_nombreTutor.Text = "";
            textEdit_apellidoPaternoTutor.Text = "";
            textEdit_apellidoMaternoTutor.Text = "";
            textEdit_numeroTelfonoTutor.Text = "";
            textEdit_correoElectronicoTutor.Text = "";
            lookUpEdit_parentesco.EditValue= null;  
            textEdit_medioDifusion.EditValue= null;


        }

        private void simpleButton_cancel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("La información aún no se guarda, si cierra el formulario la información se perdera. ¿Desea salir? ","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}