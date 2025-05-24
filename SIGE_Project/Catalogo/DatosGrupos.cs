using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGE_Project.Catalogo
{
    public partial class DatosGrupos : DevExpress.XtraEditors.XtraForm
    {
        ClsGrupos objGrupos;
        bool nuevo;
        public DatosGrupos()
        {
            InitializeComponent();
            objGrupos = new ClsGrupos();
            nuevo = true;

        }
        public DatosGrupos(int _idGrupo, int _alumnos, string _cveLicenciatura, int _idGeneracion, int _estadoGrup, int _semestre, string _grupo )
        {
            InitializeComponent();
            objGrupos = new ClsGrupos();
            nuevo = false;

            objGrupos.idGrupo = _idGrupo;
            objGrupos.alumnos = _alumnos;
            objGrupos.cveLicenciatura= _cveLicenciatura;
            objGrupos.idGeneracion= _idGeneracion;
            objGrupos.estadoGrupo = _estadoGrup;
            objGrupos.idSemestre = _semestre;
            objGrupos.grupo = _grupo;

            setValores();

        }
        


        private void llenarLookups()
        {
            ////GENERACION
            lookUpEdit_generacion.Properties.DataSource = Utilerias.llenarlookupeditvalue("select idGeneracion,CONCAT(anioInicio,'-',anioFin)as descripcion from SIGE_Catalogo_Generaciones where estado=1 order by idGeneracion desc");
            lookUpEdit_generacion.Properties.DisplayMember = "descripcion";
            lookUpEdit_generacion.Properties.ValueMember = "idGeneracion";

            ////CICLO ESCOLAR
            lookUpEdit_semestre.Properties.DataSource = Utilerias.llenarlookupeditvalue("select idSemestre,descripcion from [SIGE_Catalogo_Semestres] where estado=1 order by idSemestre desc");
            lookUpEdit_semestre.Properties.DisplayMember = "descripcion";
            lookUpEdit_semestre.Properties.ValueMember = "idSemestre";


            ////LICENCIATURA
            lookUpEdit_licenciatura.Properties.DataSource = Utilerias.llenarlookupeditvalue("select cveLicenciatura,descripcionLicenciatura as descripcion FROM [SIGE_Catalogo_Licenciatura] where estado=1");
            lookUpEdit_licenciatura.Properties.DisplayMember = "descripcion";
            lookUpEdit_licenciatura.Properties.ValueMember = "cveLicenciatura";



        }
        private void setValores()
        {
            ////ESTE METODO SE OCUPA PARA COLOCAR LOS VALORES EN LOS CONTROLES 
            spinEdit_numAlumnos.Text = objGrupos.alumnos.ToString();
            lookUpEdit_licenciatura.Text = objGrupos.cveLicenciatura.ToString();
            lookUpEdit_generacion.Text = objGrupos.idGeneracion.ToString();
            lookUpEdit_semestre.Text = objGrupos.idSemestre.ToString();
            checkEdit_estado.Checked = objGrupos.estadoGrupo == 1 ? true : false;
            textEdit_grupo.Text = objGrupos.grupo;
            textEdit_idGrupo.ReadOnly = true;///SE BLOQUEA CAMPO DE CLAVE 
            
        }
        
        private void simpleButton_cancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Esta seguro de querer cerrar esta ventana sin guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
        private void lookUpEdit_generacion_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void DatosGrupos_Load(object sender, EventArgs e)
        {
            llenarLookups();
        }

        private void simpleButton_aceptar_Click(object sender, EventArgs e)
        {

            if (lookUpEdit_generacion.EditValue==null)
            {
                XtraMessageBox.Show("Seleccione la generación a la que pertenecera el grupo.", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lookUpEdit_licenciatura.EditValue==null)
            {
                XtraMessageBox.Show("Seleccione la licenciatura del grupo.", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lookUpEdit_semestre.EditValue==null)
            {
                XtraMessageBox.Show("Seleccione el semestre destinado para el grupo.", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToInt32(spinEdit_numAlumnos.EditValue)<=0)
            {
                XtraMessageBox.Show("El número de alumnos debe ser mayor a cero.", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_grupo.Text))
            {
                XtraMessageBox.Show("Ingrese la descripción del grupo (Ejem. 'A,B,C,etc.')", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idGrupo = nuevo==true?0:Convert.ToInt32(textEdit_idGrupo.Text);
            string cveLicenciatura = lookUpEdit_licenciatura.EditValue.ToString();
            int idGeneracion= Convert.ToInt32(lookUpEdit_generacion.EditValue);
            int idSemestre= Convert.ToInt32(lookUpEdit_semestre.EditValue);
            int alumnos = Convert.ToInt32(spinEdit_numAlumnos.EditValue);
            int estado = checkEdit_estado.Checked == true ? 1 : 0;
            string grupo = textEdit_grupo.Text;
            objGrupos.setDatosGrupo(idGrupo, alumnos, cveLicenciatura, idGeneracion, estado,idSemestre,grupo);
            int result = nuevo==true?objGrupos.insertarDatosGrupo():objGrupos.updateDescGrupo();
            if (result !=0)
            {
                XtraMessageBox.Show("Los datos se ingresaron correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                XtraMessageBox.Show("Ocurrió un error al intentar ingresar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}