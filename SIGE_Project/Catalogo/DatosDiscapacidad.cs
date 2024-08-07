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
    public partial class DatosDiscapacidad : XtraForm
    {
        ClsDiscapacidad objDiscapacidad;
        bool nuevo = true;

        public DatosDiscapacidad()
        {
            InitializeComponent();
            objDiscapacidad = new ClsDiscapacidad();
            nuevo = true;
        }

        public DatosDiscapacidad(int _idDiscapacidad, string _descripcion, int _estado)
        {
            InitializeComponent();
            objDiscapacidad = new ClsDiscapacidad();
            objDiscapacidad.idDIscapacidad = _idDiscapacidad; 
            objDiscapacidad.descripcion = _descripcion;
            objDiscapacidad.estado = _estado;

            setValores();
            nuevo = false;
        }

        private void setValores()
        {
            
            memoEdit_descripcion.Text = objDiscapacidad.descripcion;

            
        }

        private void simpleButton_cancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Está seguro de querer cerrar esta ventana sin guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void simpleButton_aceptar_Click(object sender, EventArgs e)
        {
        
            if (string.IsNullOrEmpty(memoEdit_descripcion.Text))
            {
                XtraMessageBox.Show("Ingrese una descripción para la discapacidad.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            objDiscapacidad.descripcion = memoEdit_descripcion.Text;
            checkEdit_estado.Checked = objDiscapacidad.estado == 1 ? true : false;

            int result = nuevo == true ? objDiscapacidad.insertDatoDiscapacidad() : objDiscapacidad.updateDescDiscapacidad();
            if (result == 1)
            {
                XtraMessageBox.Show("Los datos se guardaron correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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