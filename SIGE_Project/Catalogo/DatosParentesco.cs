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
    public partial class DatosParentesco : DevExpress.XtraEditors.XtraForm
    {

        ClsParentesco objParentesco;
        bool nuevo = true;
        public DatosParentesco()
        {
            InitializeComponent();
            objParentesco = new ClsParentesco();
            nuevo = true;
        }

        private void DatosParentesco_Load(object sender, EventArgs e)
        {

        }

        public DatosParentesco(int _idParentesco, string _descripcion, int _estado)
        {
            ////ESTE CONSTRUCTOR SE OCUPARA PARA CUANDO SE EDITE UN REGISTRO
            InitializeComponent();
            objParentesco = new ClsParentesco();
            objParentesco.idParentesco = _idParentesco;
            objParentesco.descripcion = _descripcion;
            objParentesco.estado = _estado;
            setValores();
            nuevo = false;
        }

        private void setValores()
        {
            ////ESTE METODO SE OCUPA PARA COLOCAR LOS VALORES EN LOS CONTROLES 
            memoEdit_descripcion.Text = objParentesco.descripcion;
            checkEdit_estado.Checked = objParentesco.estado == 1 ? true : false;
        }

        private void simpleButton_aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(memoEdit_descripcion.Text))
            {
                XtraMessageBox.Show("Ingrese una descripción para el parentesco.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            objParentesco.descripcion = memoEdit_descripcion.Text;
            objParentesco.estado = checkEdit_estado.Checked == true ? 1 : 0;

            int result = nuevo == true ? objParentesco.insertDatosParentesco() : objParentesco.updateDatosParentesco();
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