using DevExpress.XtraEditors;
using SIGE_Project.Catalogo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGE_Project
{
    public partial class DatosGenero : DevExpress.XtraEditors.XtraForm
    {
        ClsGenero objGenero;
        bool nuevo = true;
        public DatosGenero()
        {
            InitializeComponent();
            objGenero = new ClsGenero();
            nuevo = true;
        }
        //


        public DatosGenero(string _cveGenero, string _descGenero, int _estadoGenero)
        {
            ////ESTE CONSTRUCTOR SE OCUPARA PARA CUANDO SE EDITE UN REGISTRO
            InitializeComponent();
            objGenero = new ClsGenero();
            objGenero.cveGenero = _cveGenero;
            objGenero.descGenero = _descGenero;
            objGenero.estadoGenero = _estadoGenero;
            setValores();
            nuevo = false;
        }
        private void setValores()
        {
            ////ESTE METODO SE OCUPA PARA COLOCAR LOS VALORES EN LOS CONTROLES 
            textEdit_claveGenero.Text = objGenero.cveGenero;
            memoEdit_descripcion.Text = objGenero.descGenero;
            checkEdit_estado.Checked = objGenero.estadoGenero == 1 ? true : false;

            textEdit_claveGenero.ReadOnly = true;///SE BLOQUEA CAMPO DE CLAVE MEDIO
        }





        //
        private void simpleButton_aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEdit_claveGenero.Text))
            {
                XtraMessageBox.Show("Ingrese una clave para el genero.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(memoEdit_descripcion.Text))
            {
                XtraMessageBox.Show("Ingrese una descripción para el genero.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            objGenero.cveGenero = textEdit_claveGenero.Text;
            objGenero.descGenero = memoEdit_descripcion.Text;
            objGenero.estadoGenero = checkEdit_estado.Checked == true ? 1 : 0;

            int result = nuevo == true ? objGenero.insertarDatosGenero() : objGenero.updateDescGenero();
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

        private void DatosGenero_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton_eliminar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Esta seguro de querer cerrar esta ventana sin guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}