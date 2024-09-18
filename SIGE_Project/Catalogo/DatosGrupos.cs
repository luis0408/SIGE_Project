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

        public DatosGrupo(int _idGrupo, char _grupo, int _cveLicenciatura, int _idGeneracion, int _estadoGrupo)
        {
            InitializeComponent();
            objGrupos = new ClsGrupos();
            objGrupos.idGrupo = _idGrupo;
            objGrupos.grupo = _grupo;
            objGrupos.cveLicenciatura = _cveLicenciatura;
            objGrupos.idGeneracion = _idGeneracion;
            objGrupos.estadoGrupo = _estadoGrupo;
            setValores();
            nuevo = false;
        }

        private void llenarLookups()
        {
            ////GENERACION
            lookUpEdit_generacion.Properties.DataSource = Utilerias.llenarlookupeditvalue("select idGeneracion,CONCAT(anioInicio,'-',anioFin)as descripcion from SIGE_Catalogo_Generaciones where estado=1 order by idGeneracion desc");
            lookUpEdit_generacion.Properties.DisplayMember = "descripcion";
            lookUpEdit_generacion.Properties.ValueMember = "idGeneracion";
            
            ////CICLO ESCOLAR
            //lookUpEdit_cicloEscolar.Properties.DataSource = Utilerias.llenarlookupeditvalue("select idCicloEscolar,CONCAT(anioInicio,'-',anioFin)as descripcion from [SIGE_Catalogo_CicloEscolar] where estado=1 order by idCicloEscolar desc");
            //lookUpEdit_cicloEscolar.Properties.DisplayMember = "descripcion";
            //lookUpEdit_cicloEscolar.Properties.ValueMember = "idCicloEscolar";


            ////LICENCIATURA
            lookUpEdit_licenciatura.Properties.DataSource = Utilerias.llenarlookupeditvalue("select cveLicenciatura,descripcionLicenciatura as descripcion FROM [SIGE_Catalogo_Licenciatura] where estado=1");
            lookUpEdit_licenciatura.Properties.DisplayMember = "descripcion";
            lookUpEdit_licenciatura.Properties.ValueMember = "cveLicenciatura";



        }
        private void setValores()
        {
            ////ESTE METODO SE OCUPA PARA COLOCAR LOS VALORES EN LOS CONTROLES 
            spinEdit_grupo.Text = objGrupos.grupo;
            lookUpEdit_licenciatura.Text = Convert.ToInt32(objGrupos.cveLicenciatura).ToString();
            lookUpEdit_generacion.Text = Convert.ToInt32(objGrupos.idGeneracion).ToString();
            checkEdit_estado.Checked = objGrupos.estadoGrupo == 1 ? true : false;

            spinEdit_grupo.ReadOnly = true;///SE BLOQUEA CAMPO DE CLAVE MEDIO
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(textEdit_claveGenero.Text))
            //{
            //    XtraMessageBox.Show("Ingrese una clave para el genero.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (string.IsNullOrEmpty(memoEdit_descripcion.Text))
            //{
            //    XtraMessageBox.Show("Ingrese una descripción para el genero.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            objGrupos.grupo = Convert.ToInt32(spinEdit_grupo.Text);
            objGrupos.cveLicenciatura = Convert.ToInt32(lookUpEdit_licenciatura.Text);
            objGrupos.idGeneracion = Convert.ToInt32(lookUpEdit_generacion.Text);
            objGrupos.estadoGrupo = checkEdit_estado.Checked == true ? 1 : 0;

            int result = nuevo == true ? objGrupos.insertarDatosGrupo() : objGrupos.updateDescGrupo();
            if (result == 1)
            {
                XtraMessageBox.Show("Los datos se guardarón correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                XtraMessageBox.Show("Se generó un error al insertar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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
    }
}