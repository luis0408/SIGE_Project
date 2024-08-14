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
    public partial class DatosEstado : DevExpress.XtraEditors.XtraForm
    {
        ClsEstado objEstado;
        bool nuevo = true;
        public DatosEstado()
        {
            InitializeComponent();
            objEstado = new ClsEstado();
            nuevo = true;
        }

        public DatosEstado(string _c_Estado, string _nombrePais, string _nombreEstado)
        {
            InitializeComponent();
            objEstado = new ClsEstado();
            objEstado.c_Estado = _c_Estado;
            objEstado.nombrePais = _nombrePais;
            objEstado.nombreEstado = _nombrePais;
            setValores();
            nuevo = false;
        }

        private void setValores()
        {
            textEdit_cEstado.Text = objEstado.c_Estado;
            loopUpEdit_nombrePais.Text = objEstado.nombrePais;
            textEdit_nombreEstado.Text = objEstado.nombreEstado;
        }

        private void simpleButton_agree_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEdit_cEstado.Text))
            {
                XtraMessageBox.Show("Ingrese una clave para el estado.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(loopUpEdit_nombrePais.Text))
            {
                XtraMessageBox.Show("Ingrese un pais.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_nombreEstado.Text))
            {
                XtraMessageBox.Show("Ingrese el nombre del estado.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            objEstado.c_Estado = textEdit_cEstado.Text;
            objEstado.nombrePais = loopUpEdit_nombrePais.Text;
            objEstado.nombreEstado = textEdit_nombreEstado.Text;

            int result = nuevo == true ? objEstado.insertDatoEstado() : objEstado.updateDatoEstado();
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