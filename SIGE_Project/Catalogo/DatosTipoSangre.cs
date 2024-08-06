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
    public partial class DatosTipoSangre : DevExpress.XtraEditors.XtraForm
    {

        ClsTipoSangre objTipoSangre;
        bool nuevo = true;

        public DatosTipoSangre()
        {
            InitializeComponent();
            objTipoSangre = new ClsTipoSangre();
            nuevo = true;
        }

        public DatosTipoSangre(string _cveGenero, string _descGenero, int _estadoGenero)
        {
            ////ESTE CONSTRUCTOR SE OCUPARA PARA CUANDO SE EDITE UN REGISTRO
            InitializeComponent();
            objTipoSangre = new ClsTipoSangre();
            objTipoSangre.cveTipoSangre = _cveGenero;
            objTipoSangre.descTipoSangre = _descGenero;
            objTipoSangre.estadoTipoSangre = _estadoGenero;
            setValores();
            nuevo = false;
        }

        private void setValores()
        {
            ////ESTE METODO SE OCUPA PARA COLOCAR LOS VALORES EN LOS CONTROLES 
            textEdit_TipoSangre.Text = objTipoSangre.cveTipoSangre;
            memoEdit_descripcion.Text = objTipoSangre.descTipoSangre;
            checkEdit_estado.Checked = objTipoSangre.estadoTipoSangre == 1 ? true : false;

            textEdit_TipoSangre.ReadOnly = true;///SE BLOQUEA CAMPO DE CLAVE MEDIO
        }

        private void simpleButton_aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEdit_TipoSangre.Text))
            {
                XtraMessageBox.Show("Ingrese una clave para el tipo de sangre.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(memoEdit_descripcion.Text))
            {
                XtraMessageBox.Show("Ingrese una descripción para el genero.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            objTipoSangre.cveTipoSangre = textEdit_TipoSangre.Text;
            objTipoSangre.descTipoSangre = memoEdit_descripcion.Text;
            objTipoSangre.estadoTipoSangre = checkEdit_estado.Checked == true ? 1 : 0;

            int result = nuevo == true ? objTipoSangre.insertarDatosTipoSangre() : objTipoSangre.updateDescTipoSangre();
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



        private void DatosTipoSangre_Load(object sender, EventArgs e)
        {

        }

    }
}