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

        private int mesInicio;
        private int anioInicio;
        private int mesFin;
        private int anioFin;
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
            mesInicio = Convert.ToInt32(objPeriodos.cveMesInicio);
            anioInicio = objPeriodos.anioInicio;
            mesFin = Convert.ToInt32(objPeriodos.cveMesFin);
            anioFin = objPeriodos.anioFin;

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
            if (dateEdit_inicio.EditValue == null)
            {
                XtraMessageBox.Show("Por favor, seleccione una fecha de inicio", "Fecha vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dateEdit_fin.EditValue == null)
            {
                XtraMessageBox.Show("Por favor, seleccione una fecha de finalización", "Fecha vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //if (string.IsNullOrEmpty(textEdit_cveMesFin.Text))
            //{
            //    XtraMessageBox.Show("Ingrese una clave de mes de finalización para el periodo.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (string.IsNullOrEmpty(textEdit_anioFin.Text))
            //{
            //    XtraMessageBox.Show("Ingrese un año de finalización para el periodo.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            // Obtener el mes y el año de los controles DateEdit
            DateTime selectedDate_inicio = dateEdit_inicio.DateTime;
            DateTime selectedDate_fin = dateEdit_fin.DateTime;

            mesInicio = selectedDate_inicio.Month;
            anioInicio = selectedDate_inicio.Year;
            mesFin = selectedDate_fin.Month;
            anioFin = selectedDate_fin.Year;

            objPeriodos.idCicloEscolar = Convert.ToInt32(textEdit_idCicloEscolar.Text);
            objPeriodos.cveMesInicio = mesInicio.ToString();
            objPeriodos.anioInicio = anioInicio;
            objPeriodos.cveMesFin = mesFin.ToString();
            objPeriodos.anioFin = anioFin;

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