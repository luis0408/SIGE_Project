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
    public partial class DatosCicloEscolar : DevExpress.XtraEditors.XtraForm
    {
        ClsCicloEscolar objCicloEscolar;
        bool nuevo = true;
        public DatosCicloEscolar()
        {
            InitializeComponent();
            objCicloEscolar = new ClsCicloEscolar();
            nuevo = true;
        }

        public DatosCicloEscolar(int _anioInicio, int _anioFin, int _estado)
        {
            InitializeComponent();
            objCicloEscolar = new ClsCicloEscolar();
            objCicloEscolar.anioInicio = _anioInicio;
            objCicloEscolar.anioFin = _anioFin;
            objCicloEscolar.estado = _estado;
            setValores();
            nuevo = false;
        }
        private void setValores()
        {
            string inicio = "01/01/" + objCicloEscolar.anioInicio.ToString();
            dateEdit_anioInicio.EditValue = Convert.ToDateTime(inicio);
            string fin = "01/01/" + objCicloEscolar.anioFin.ToString();
            dateEdit_anioFin.EditValue = Convert.ToDateTime(fin);
            checkEdit_status.Checked = objCicloEscolar.estado == 1 ? true : false;
        }

        private void DatosCicloEscolar_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton_agree_Click_1(object sender, EventArgs e)
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

            objCicloEscolar.anioInicio = Convert.ToInt32(dateEdit_anioInicio.Text);
            objCicloEscolar.anioFin = Convert.ToInt32(dateEdit_anioFin.Text);
            objCicloEscolar.estado = checkEdit_status.Checked == true ? 1 : 0;

            int result = nuevo == true ? objCicloEscolar.insertDatoCicloEscolar() : objCicloEscolar.updateDatoCicloEscolar();
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

        private void simpleButton_cancel_Click_1(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Esta seguro de querer cerrar esta ventana sin guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}