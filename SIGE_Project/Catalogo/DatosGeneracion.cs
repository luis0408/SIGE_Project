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
    public partial class DatosGeneracion : DevExpress.XtraEditors.XtraForm
    {
        ClsGeneracion objGeneracion;
        bool nuevo = true;
        public DatosGeneracion()
        {
            InitializeComponent();
            objGeneracion = new ClsGeneracion();
            nuevo = true;
        }

        public DatosGeneracion(int _anioInicio, int _anioFin, int _estado, int _idGeneracion)
        {
            InitializeComponent();
            objGeneracion = new ClsGeneracion();
            objGeneracion.anioInicio = _anioInicio;
            objGeneracion.anioFin = _anioFin;
            objGeneracion.estado = _estado;
            objGeneracion.idGeneracion = _idGeneracion;
            setValores();
            nuevo = false;
        }

        private void setValores()
        {
            string inicio = "01/01/" + objGeneracion.anioInicio.ToString();
            dateEdit_anioInicio.EditValue = Convert.ToDateTime(inicio);
            string fin = "01/01/" + objGeneracion.anioFin.ToString();
            dateEdit_anioFin.EditValue = Convert.ToDateTime(fin);
            checkEdit_status.Checked = objGeneracion.estado == 1 ? true : false;
            textEdit_idGeneracion.Text=objGeneracion.idGeneracion.ToString();
        }

        private void DatosGeneracion_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton_agree_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dateEdit_anioInicio.Text))
            {
                XtraMessageBox.Show("Ingrese una clave para el medio de difusión.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(dateEdit_anioFin.Text))
            {
                XtraMessageBox.Show("Ingrese una descripción para el medio de difusión.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            objGeneracion.anioInicio = Convert.ToInt32(dateEdit_anioInicio.Text);
            objGeneracion.anioFin = Convert.ToInt32(dateEdit_anioFin.Text);
            objGeneracion.estado = checkEdit_status.Checked == true ? 1 : 0;
            if (nuevo == false)
                objGeneracion.idGeneracion = Convert.ToInt32(textEdit_idGeneracion.Text.ToString());

            int result = nuevo == true ? objGeneracion.insertDatoGeneracion() : objGeneracion.updateDatoGeneracion();
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