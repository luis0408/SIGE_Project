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

namespace SIGE_Project.Sistemas.Alumnos
{
    public partial class datosAlumnos : DevExpress.XtraEditors.XtraForm
    {
        clsAlumno objAlumno;
        bool nuevoRegistro;
        public datosAlumnos()
        {
            InitializeComponent();
            objAlumno = new clsAlumno();
            nuevoRegistro = true;
        }
        public datosAlumnos(int _idAlumno, string _nombres, string _apellidoPaterno, string _apellidoMaterno,
                            int _estadoAlumno, string _cvModalidad, string _cveLicenciatura, int _idGeneracion, int _idSemestre
                            , string _curp, int _edad, string _noControl, string _email)
        {
            InitializeComponent();
            objAlumno = new clsAlumno();
            nuevoRegistro = false;



            ////SE SETAN VALORES EN EL FORM
            textEdit_idAlumno.Text = _idAlumno.ToString();
            textEdit_nombre.Text = _nombres;
            textEdit_apellidoPaterno.Text = _apellidoPaterno;
            textEdit_apellidoMaterno.Text = _apellidoMaterno;
            lookUpEdit_estadoAlumno.EditValue=_estadoAlumno;
            lookUpEdit_modalidad.EditValue = _cvModalidad;
            lookUpEdit_licenciatura.EditValue = _cveLicenciatura;
            lookUpEdit_generacion.EditValue=_idGeneracion.ToString();
            lookUpEdit_semestre.EditValue=_idSemestre.ToString();
            textEdit_email.Text = _email;   



        }
        
        private void datosAlumnos_Load(object sender, EventArgs e)
        {
            ////LICENCIATURA
            lookUpEdit_licenciatura.Properties.DataSource = Utilerias.llenarlookupeditvalue("select cveLicenciatura,descripcionLicenciatura as descripcion FROM [SIGE_Catalogo_Licenciatura] where estado=1");
            lookUpEdit_licenciatura.Properties.DisplayMember = "descripcion";
            lookUpEdit_licenciatura.Properties.ValueMember = "cveLicenciatura";

            ////ESTADO
            lookUpEdit_estadoAlumno.Properties.DataSource = Utilerias.llenarlookupeditvalue("select [idEstadoEstudiante],[estadoEstudiante] FROM [SIGE_Catalogo_EstadoEstudiante]");
            lookUpEdit_estadoAlumno.Properties.DisplayMember = "estadoEstudiante";
            lookUpEdit_estadoAlumno.Properties.ValueMember = "idEstadoEstudiante";

            ////MODALIDAD
            lookUpEdit_modalidad.Properties.DataSource = Utilerias.llenarlookupeditvalue("select [cveModalidad],[descripcion] FROM [SIGE_Catalogo_Modalidad] WHERE estado=1");
            lookUpEdit_modalidad.Properties.DisplayMember = "descripcion";
            lookUpEdit_modalidad.Properties.ValueMember = "cveModalidad";

            ////SEMESTRE
            lookUpEdit_semestre.Properties.DataSource = Utilerias.llenarlookupeditvalue("select [idSemestre] ,[descripcion] FROM [SIGE_Catalogo_Semestres] WHERE estado=1");
            lookUpEdit_semestre.Properties.DisplayMember = "descripcion";
            lookUpEdit_semestre.Properties.ValueMember = "idSemestre";

            ////GENERACION
            lookUpEdit_generacion.Properties.DataSource = Utilerias.llenarlookupeditvalue("select idGeneracion,CONCAT(anioInicio,'-',anioFin)as descripcion From SIGE_Catalogo_Generaciones where estado=1");
            lookUpEdit_generacion.Properties.DisplayMember = "descripcion";
            lookUpEdit_generacion.Properties.ValueMember = "idGeneracion";
            textEdit_nombre.Focus();
        }

        private void simpleButton_cancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Aún no se han guardado los cambios, ¿Desea cerrar está ventana?","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
                this.DialogResult = DialogResult.Cancel;
            }
            
        }

        private void simpleButton_aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEdit_nombre.Text))
            {
                XtraMessageBox.Show("Ingrese el nombre del alumno.", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_apellidoPaterno.Text))
            {
                XtraMessageBox.Show("Ingrese el apellido paterno del alumno.", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_apellidoMaterno.Text))
            {
                XtraMessageBox.Show("Ingrese el apellido materno del alumno.", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lookUpEdit_estadoAlumno.EditValue==null)
            {
                XtraMessageBox.Show("Ingrese el estado del alumno.", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lookUpEdit_licenciatura.EditValue == null)
            {
                XtraMessageBox.Show("Ingrese la licenciatura del alumno.", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lookUpEdit_modalidad.EditValue == null)
            {
                XtraMessageBox.Show("Ingrese la modalidad del alumno.", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lookUpEdit_semestre.EditValue == null)
            {
                XtraMessageBox.Show("Ingrese el semestre del alumno.", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lookUpEdit_generacion.EditValue == null)
            {
                XtraMessageBox.Show("Ingrese la generación del alumno.", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            


            objAlumno.setDatos(string.IsNullOrEmpty(textEdit_idAlumno.Text)?0:Convert.ToInt32(textEdit_idAlumno.Text),textEdit_nombre.Text
                              ,textEdit_apellidoPaterno.Text,textEdit_apellidoMaterno.Text,Convert.ToInt32(lookUpEdit_estadoAlumno.EditValue)
                              ,lookUpEdit_modalidad.EditValue.ToString(),lookUpEdit_licenciatura.EditValue.ToString(),Convert.ToInt32(lookUpEdit_generacion.EditValue)
                              ,Convert.ToInt32(lookUpEdit_semestre.EditValue),null,0,null,textEdit_email.Text);
            int resultado=nuevoRegistro==true?objAlumno.insertAlumno():objAlumno.updateAlumno();
            if (resultado != 0) 
            {
                XtraMessageBox.Show("Los daros se ingresaron correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                this.DialogResult = DialogResult.OK;    

            }
        }
    }
}