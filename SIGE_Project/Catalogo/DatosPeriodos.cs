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
    public partial class DatosPeriodos : DevExpress.XtraEditors.XtraForm
    {
        ClsPeriodos objPeriodos;
        bool nuevo = true;
        public DatosPeriodos()
        {
            InitializeComponent();

            objPeriodos = new ClsPeriodos();
            nuevo = true;
        }

        private void DatosPeriodos_Load(object sender, EventArgs e)
        {

        }

        public DatosPeriodos(int _idCicloEscolar, string _cveMesInicio, int _anioInicio, string _cveMesFin, int _anioFin)
        {
            //ESTE CONSTRUCTOR SE OCUPARA PARA CUANDO SE EDITE UN REGISTRO
            InitializeComponent();
            objPeriodos = new ClsPeriodos();
            objPeriodos.idCicloEscolar = _idCicloEscolar;
            objPeriodos.cveMesInicio = _cveMesInicio;
            objPeriodos.anioInicio = _anioInicio;
            objPeriodos.cveMesFin = _cveMesFin;
            objPeriodos.anioFin = _anioFin;
            nuevo = false;
        }

        private void setValores()
        {
            //ESTE METODO SE OCUPA PARA COLOCAR LOS VALORES EN LOS CONTROLES 
            textEdit_idCicloEscolar.Text = objPeriodos.idCicloEscolar.ToString();
            textEdit_cveMesInicio.Text = objPeriodos.cveMesInicio;
            textEdit_anioInicio.Text = objPeriodos.anioInicio.ToString();
            textEdit_cveMesFin.Text = objPeriodos.cveMesFin;
            textEdit_anioFin.Text = objPeriodos.anioFin.ToString();

            textEdit_idCicloEscolar.ReadOnly = true;///SE BLOQUEA CAMPO DE CLAVE MEDIO
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
            if (string.IsNullOrEmpty(textEdit_idCicloEscolar.Text))
            {
                XtraMessageBox.Show("Ingrese un id para el periodo.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_cveMesInicio.Text))
            {
                XtraMessageBox.Show("Ingrese una clave de mes de inicio para el periodo.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_anioInicio.Text))
            {
                XtraMessageBox.Show("Ingrese un año de inicio para el periodo.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_cveMesFin.Text))
            {
                XtraMessageBox.Show("Ingrese una clave de mes de finalización para el periodo.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_anioFin.Text))
            {
                XtraMessageBox.Show("Ingrese un año de finalización para el periodo.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            objPeriodos.idCicloEscolar = Convert.ToInt32(textEdit_idCicloEscolar.Text);
            objPeriodos.cveMesInicio = textEdit_cveMesInicio.Text;
            objPeriodos.anioInicio = Convert.ToInt32(textEdit_anioFin.Text);
            objPeriodos.cveMesFin = textEdit_cveMesFin.Text;
            objPeriodos.anioFin = Convert.ToInt32(textEdit_anioFin.Text);

            int result = nuevo == true ? objPeriodos.insertDatoPeriodos() : objPeriodos.updateDescPeriodos();
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