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
    public partial class DatosMes : DevExpress.XtraEditors.XtraForm
    {
        ClsMes objMes;
        bool nuevo = true;
        public DatosMes()
        {
            InitializeComponent();
            objMes = new ClsMes();
            nuevo = true;
        }
        private void DatosMes_Load(object sender, EventArgs e)
        {

        }
        public DatosMes(string _cveMes, string _descripcion)
        {
            ////ESTE CONSTRUCTOR SE OCUPARA PARA CUANDO SE EDITE UN REGISTRO
            InitializeComponent();
            objMes = new ClsMes();
            objMes.cveMes = _cveMes;
            objMes.descripcion = _descripcion;

            setValores();
            nuevo = false;
        }

        private void setValores()
        {
            ////ESTE METODO SE OCUPA PARA COLOCAR LOS VALORES EN LOS CONTROLES 
            textEdit_cveMes.Text = objMes.cveMes;
            textEdit_descripcion.Text = objMes.descripcion;

            textEdit_cveMes.ReadOnly = true;///SE BLOQUEA CAMPO DE CLAVE MEDIO
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
            if (string.IsNullOrEmpty(textEdit_cveMes.Text))
            {
                XtraMessageBox.Show("Ingrese una clave para el mes.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_descripcion.Text))
            {
                XtraMessageBox.Show("Ingrese una descripción para el mes.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            objMes.cveMes = textEdit_cveMes.Text;
            objMes.descripcion = textEdit_descripcion.Text;

            switch (objMes.descripcion)
            {
                case "Enero":
                    objMes.numeroMes = 1;
                    break;
                case "Febrero":
                    objMes.numeroMes = 2;
                    break;
                case "Marzo":
                    objMes.numeroMes = 3;
                    break;
                case "Abril":
                    objMes.numeroMes = 4;
                    break;
                case "Mayo":
                    objMes.numeroMes = 5;
                    break;
                case "Junio":
                    objMes.numeroMes = 6;
                    break;
                case "Julio":
                    objMes.numeroMes = 7;
                    break;
                case "Agosto":
                    objMes.numeroMes = 8;
                    break;
                case "Septiembre":
                    objMes.numeroMes = 9;
                    break;
                case "Octubre":
                    objMes.numeroMes = 10;
                    break;
                case "Noviembre":
                    objMes.numeroMes = 11;
                    break;
                case "Diciembre":
                    objMes.numeroMes = 12;
                    break;
            }

            int result = nuevo == true ? objMes.insertDatoMes() : objMes.updateDescMes();
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