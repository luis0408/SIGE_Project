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
    public partial class DatosModalidad : DevExpress.XtraEditors.XtraForm
    {
        ClsModalidad objModalidad;
        bool nuevo = true;
        public DatosModalidad()
        {
            InitializeComponent();
            objModalidad = new ClsModalidad();
            nuevo = true;
        }

        private void DatosModalidad_Load(object sender, EventArgs e)
        {

        }

        public DatosModalidad(string _cveModalidad, string _descripcion, int _estado)
        {
            // ESTE CONSTRUCTOR SE OCUPARA PARA CUANDO SE EDITE UN REGISTRO
            InitializeComponent();
            objModalidad = new ClsModalidad();
            objModalidad.cveModalidad = _cveModalidad;
            objModalidad.descripcion = _descripcion;
            objModalidad.estado = _estado;
            setValores();
            nuevo = false;
        }

        private void setValores()
        {
            ////ESTE METODO SE OCUPA PARA COLOCAR LOS VALORES EN LOS CONTROLES 
            textEdit_cveModalidad.Text = objModalidad.cveModalidad;
            textEdit_descripcion.Text = objModalidad.descripcion;
            checkEdit_estado.Checked = objModalidad.estado == 1 ? true : false;

            textEdit_cveModalidad.ReadOnly = true;///SE BLOQUEA CAMPO DE CLAVE MEDIO
        }

        private void simpleButton_cencelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Esta seguro de querer cerrar esta ventana sin guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void simpleButton_aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEdit_cveModalidad.Text))
            {
                XtraMessageBox.Show("Ingrese una clave para la modalidad.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_descripcion.Text))
            {
                XtraMessageBox.Show("Ingrese una descripción para la modalidad.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            objModalidad.cveModalidad = textEdit_cveModalidad.Text;
            objModalidad.descripcion = textEdit_descripcion.Text;
            objModalidad.estado = checkEdit_estado.Checked == true ? 1 : 0;

            int result = nuevo == true ? objModalidad.insertDatoModalidad() : objModalidad.updateDescModalidad();
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
    }
}