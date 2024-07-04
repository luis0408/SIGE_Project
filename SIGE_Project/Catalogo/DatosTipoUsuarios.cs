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
    public partial class DatosTipoUsuarios : DevExpress.XtraEditors.XtraForm
    {
        ClsTipoUsuarios objTipoUsuarios;
        bool nuevo = true;
        public DatosTipoUsuarios()
        {
            /////ESTE METODO SE OCUAPA CUANDO SE INSERTA UN NUEVO REGISTRO
            InitializeComponent();
            objTipoUsuarios = new ClsTipoUsuarios();
            nuevo = true;
        }

        private void DatosTipoUsuarios_Load(object sender, EventArgs e)
        {

        }

        public DatosTipoUsuarios(string _cveTipoUsuario, string _descTipoUsuario, int _estadoTipoUsuario)
        {
            // ESTE CONSTRUCTOR SE OCUPARA PARA CUANDO SE EDITE UN REGISTRO
            InitializeComponent();
            objTipoUsuarios = new ClsTipoUsuarios();
            objTipoUsuarios.cveTipoUsuario = _cveTipoUsuario;
            objTipoUsuarios.descTipoUsuario = _descTipoUsuario;
            objTipoUsuarios.estadoTipoUsuario= _estadoTipoUsuario;
            setValores();
            nuevo = false;
        }

        private void setValores()
        {
            ////ESTE METODO SE OCUPA PARA COLOCAR LOS VALORES EN LOS CONTROLES 
            textEdit_cveUsuario.Text = objTipoUsuarios.cveTipoUsuario;
            textEdit_descripcion.Text = objTipoUsuarios.descTipoUsuario;
            checkEdit_estado.Checked = objTipoUsuarios.estadoTipoUsuario == 1 ? true : false;

            textEdit_cveUsuario.ReadOnly = true;///SE BLOQUEA CAMPO DE CLAVE MEDIO
        }

        private void simpleButton_cancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Esta seguro de querer cerrar esta ventana sin guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void simpleButton_aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEdit_cveUsuario.Text))
            {
                XtraMessageBox.Show("Ingrese una clave para el usuario.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_descripcion.Text))
            {
                XtraMessageBox.Show("Ingrese una descripción para el usuario.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            objTipoUsuarios.cveTipoUsuario = textEdit_cveUsuario.Text;
            objTipoUsuarios.descTipoUsuario = textEdit_descripcion.Text;
            objTipoUsuarios.estadoTipoUsuario = checkEdit_estado.Checked == true ? 1 : 0;

            int result = nuevo == true ? objTipoUsuarios.insertTipoUsuarios() : objTipoUsuarios.updateDescTipoUsuarios();
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