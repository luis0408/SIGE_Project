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
    public partial class DatosLicenciatura : DevExpress.XtraEditors.XtraForm
    {
        ClsLicenciatura objLicenciatura;
        bool nuevo = true;
        public DatosLicenciatura()
        {
            InitializeComponent();
            objLicenciatura = new ClsLicenciatura();
            nuevo = true;
        }
        public DatosLicenciatura(string _cveLicenciatura, string _descLicenciatura, int _estadoLicenciatura)
        {
            ////ESTE CONSTRUCTOR SE OCUPARA PARA CUANDO SE EDITE UN REGISTRO
            InitializeComponent();
            objLicenciatura = new ClsLicenciatura();
            objLicenciatura.cveLicenciatura = _cveLicenciatura;
            objLicenciatura.descLicenciatura = _descLicenciatura;
            objLicenciatura.estadoLicenciatura = _estadoLicenciatura;
            setValores();
            nuevo = false;
        }
        private void setValores()
        {
            ////ESTE METODO SE OCUPA PARA COLOCAR LOS VALORES EN LOS CONTROLES 
            textEdit_cveLicenciatura.Text = objLicenciatura.cveLicenciatura;
            memoEdit_descLicenciatura.Text = objLicenciatura.descLicenciatura;
            checkEdit_estado.Checked = objLicenciatura.estadoLicenciatura == 1 ? true : false;

            textEdit_cveLicenciatura.ReadOnly = true;///SE BLOQUEA CAMPO DE CLAVE MEDIO
        }

        private void simpleButton_cancel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Esta seguro de querer cerrar esta ventana sin guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void simpleButton_acept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEdit_cveLicenciatura.Text))
            {
                XtraMessageBox.Show("Ingrese una clave para el medio de difusión.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(memoEdit_descLicenciatura.Text))
            {
                XtraMessageBox.Show("Ingrese una descripción para el medio de difusión.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            objLicenciatura.cveLicenciatura = textEdit_cveLicenciatura.Text;
            objLicenciatura.descLicenciatura = memoEdit_descLicenciatura.Text;
            objLicenciatura.estadoLicenciatura = checkEdit_estado.Checked == true ? 1 : 0;

            int result = nuevo == true ? objLicenciatura.insertDatoLicenciatura() : objLicenciatura.updateDatoLicenciatura();
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