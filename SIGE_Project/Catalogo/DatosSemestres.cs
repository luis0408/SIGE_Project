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
    public partial class DatosSemestres : DevExpress.XtraEditors.XtraForm
    {
        ClsSemestres objSemestres;
        bool nuevo = true;

        public DatosSemestres()
        {
            InitializeComponent();
            objSemestres = new ClsSemestres();
            bool nuevo = true;
        }

        public DatosSemestres( int _idSemestre, string _descSemestres, int _estadoSemestres)
        {
            ////ESTE CONSTRUCTOR SE OCUPARA PARA CUANDO SE EDITE UN REGISTRO
            InitializeComponent();
            objSemestres = new ClsSemestres();
            objSemestres.idSemestre = _idSemestre;
            objSemestres.descSemestres = _descSemestres;
            objSemestres.estadoSemestres = _estadoSemestres;
            setValores();
            nuevo = false;
        }

        private void setValores()
        {
            ////ESTE METODO SE OCUPA PARA COLOCAR LOS VALORES EN LOS CONTROLES 
            memoEdit_descripcionSemestres.Text = objSemestres.descSemestres;
            checkEdit_estado.Checked = objSemestres.estadoSemestres == 1 ? true : false;
            // memoEdit_DescripcionRegistroCivil.ReadOnly = true;///SE BLOQUEA CAMPO DE CLAVE MEDIO
        }
        private void DatosSemestres_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton_aceptar_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(memoEdit_descripcionSemestres.Text))
            //{
            //    XtraMessageBox.Show("Ingrese una clave para el genero.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            if (string.IsNullOrEmpty(memoEdit_descripcionSemestres.Text))
            {
                XtraMessageBox.Show("Ingrese una descripción para el semestre.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //objEstadoCivil.cveGenero = textEdit_claveGenero.Text;
            objSemestres.descSemestres = memoEdit_descripcionSemestres.Text;
            objSemestres.estadoSemestres = checkEdit_estado.Checked == true ? 1 : 0;

            int result = nuevo == true ? objSemestres.insertarDatosSemestres() : objSemestres.updateDescSemestres();
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
    }
}