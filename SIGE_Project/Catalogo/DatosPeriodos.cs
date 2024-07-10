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

        private string mesInicio;
        private int anioInicio;
        private string mesFin;
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

            switch (objPeriodos.cveMesInicio)
            {
                case "ENE":
                    objPeriodos.cveMesInicio = "1";
                    break;
                case "FEB":
                    objPeriodos.cveMesInicio = "2";
                    break;
                case "MAR":
                    objPeriodos.cveMesInicio = "3";
                    break;
                case "ABR":
                    objPeriodos.cveMesInicio = "4";
                    break;
                case "MAY":
                    objPeriodos.cveMesInicio = "5";
                    break;
                case "JUN":
                    objPeriodos.cveMesInicio = "6";
                    break;
                case "JUL":
                    objPeriodos.cveMesInicio = "7";
                    break;
                case "AGO":
                    objPeriodos.cveMesInicio = "8";
                    break;
                case "SEP":
                    objPeriodos.cveMesInicio = "9";
                    break;
                case "OCT":
                    objPeriodos.cveMesInicio = "10";
                    break;
                case "NOV":
                    objPeriodos.cveMesInicio = "12";
                    break;
                case "DIC":
                    objPeriodos.cveMesInicio = "12";
                    break;
            }
            switch (objPeriodos.cveMesFin)
            {
                case "ENE":
                    objPeriodos.cveMesFin = "1";
                    break;
                case "FEB":
                    objPeriodos.cveMesFin = "2";
                    break;
                case "MAR":
                    objPeriodos.cveMesFin = "3";
                    break;
                case "ABR":
                    objPeriodos.cveMesFin = "4";
                    break;
                case "MAY":
                    objPeriodos.cveMesFin = "5";
                    break;
                case "JUN":
                    objPeriodos.cveMesFin = "6";
                    break;
                case "JUL":
                    objPeriodos.cveMesFin = "7";
                    break;
                case "AGO":
                    objPeriodos.cveMesFin = "8";
                    break;
                case "SEP":
                    objPeriodos.cveMesFin = "9";
                    break;
                case "OCT":
                    objPeriodos.cveMesFin = "10";
                    break;
                case "NOV":
                    objPeriodos.cveMesFin = "12";
                    break;
                case "DIC":
                    objPeriodos.cveMesFin = "12";
                    break;
            }
            setValores();
            nuevo = false;
        }

        private void setValores()
        {
            //ESTE METODO SE OCUPA PARA COLOCAR LOS VALORES EN LOS CONTROLES 

            // SE CONCATENA EL MES DE INICIO Y AÑO DE INICIO EN EL FORMATO ADECUADO
            string mesAnioInicio = $"{int.Parse(objPeriodos.cveMesInicio):00}/{objPeriodos.anioInicio}";
            DateTime fechaInicio = DateTime.ParseExact(mesAnioInicio, "MM/yyyy", null);

            // SE CONCATENA EL MES DE FINALIZACION Y AÑO DE FINALIZACION EN EL FORMATO ADECUADO
            string mesAnioFin = $"{int.Parse(objPeriodos.cveMesFin):00}/{objPeriodos.anioFin}";
            DateTime fechaFin = DateTime.ParseExact(mesAnioFin, "MM/yyyy", null);

            textEdit_idCicloEscolar.Text = objPeriodos.idCicloEscolar.ToString();
            dateEdit_inicio.DateTime = fechaInicio;
            dateEdit_fin.DateTime = fechaFin;

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

            mesInicio = selectedDate_inicio.Month.ToString();
            anioInicio = selectedDate_inicio.Year;
            mesFin = selectedDate_fin.Month.ToString();
            anioFin = selectedDate_fin.Year;

            switch (mesInicio)
            {
                case "1":
                    mesInicio = "ENE";
                    break;
                case "2":
                    mesInicio = "FEB";
                    break;
                case "3":
                    mesInicio = "MAR";
                    break;
                case "4":
                    mesInicio = "ABR";
                    break;
                case "5":
                    mesInicio = "MAY";
                    break;
                case "6":
                    mesInicio = "JUN";
                    break;
                case "7":
                    mesInicio = "JUL";
                    break;
                case "8":
                    mesInicio = "AGO";
                    break;
                case "9":
                    mesInicio = "SEP";
                    break;
                case "10":
                    mesInicio = "OCT";
                    break;
                case "11":
                    mesInicio = "NOV";
                    break;
                case "12":
                     mesInicio= "DIC";
                    break;
            }

            switch (mesFin)
            {
                case "1":
                    mesFin = "ENE";
                    break;
                case "2":
                    mesFin = "FEB";
                    break;
                case "3":
                    mesFin = "MAR";
                    break;
                case "4":
                    mesFin = "ABR";
                    break;
                case "5":
                    mesFin = "MAY";
                    break;
                case "6":
                    mesFin = "JUN";
                    break;
                case "7":
                    mesFin = "JUL";
                    break;
                case "8":
                    mesFin = "AGO";
                    break;
                case "9":
                    mesFin = "SEP";
                    break;
                case "10":
                    mesFin = "OCT";
                    break;
                case "11":
                    mesFin = "NOV";
                    break;
                case "12":
                    mesFin = "DIC";
                    break;
            }

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