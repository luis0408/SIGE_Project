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
    public partial class DatosLicenciaturaMaterias : DevExpress.XtraEditors.XtraForm
    {
        ClsLicenciaturaMaterias objLicenciaturaMaterias;
        bool nuevo = true;
        public DatosLicenciaturaMaterias()
        {
            InitializeComponent();
            objLicenciaturaMaterias = new ClsLicenciaturaMaterias();
            nuevo = true;
        }

        public DatosLicenciaturaMaterias(string _cveMateria, string _descripcion, string _cveLicenciatura, int _estado)
        {
            InitializeComponent();
            objLicenciaturaMaterias = new ClsLicenciaturaMaterias();
            objLicenciaturaMaterias.cveMateria = _cveMateria;
            objLicenciaturaMaterias.descripcion = _descripcion;
            objLicenciaturaMaterias.cveLicenciatura = _cveLicenciatura;
            objLicenciaturaMaterias.estado = _estado;
            setValores();
            nuevo = false;
        }

        private void setValores()
        {
            textEdit_cveMateria.Text = objLicenciaturaMaterias.cveMateria;
            textEdit_descripcion.Text = objLicenciaturaMaterias.descripcion;
            lookUpEdit_cveLicenciatura.Text = objLicenciaturaMaterias.cveLicenciatura;
            checkEdit_status.Checked = objLicenciaturaMaterias.estado == 1 ? true : false;
        }

        private void simpleButton_agree_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEdit_cveMateria.Text))
            {
                XtraMessageBox.Show("Ingrese una clave para la materia.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_descripcion.Text))
            {
                XtraMessageBox.Show("Ingrese la materia.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(lookUpEdit_cveLicenciatura.Text))
            {
                XtraMessageBox.Show("Ingrese una licenciatura.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            objLicenciaturaMaterias.cveMateria = textEdit_cveMateria.Text;
            objLicenciaturaMaterias.descripcion = textEdit_descripcion.Text;
            objLicenciaturaMaterias.cveLicenciatura = lookUpEdit_cveLicenciatura.Text;
            objLicenciaturaMaterias.estado = checkEdit_status.Checked == true ? 1 : 0;

            int result = nuevo == true ? objLicenciaturaMaterias.insertDatoLicenciaturaMaterias() : objLicenciaturaMaterias.updateDatoLicenciaturaMaterias();
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

        private void simpleButton_cancel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Esta seguro de querer cerrar esta ventana sin guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}