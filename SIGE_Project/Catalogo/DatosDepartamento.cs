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
    public partial class DatosDepartamento : DevExpress.XtraEditors.XtraForm
    {
        ClsDepartamento objDepartamento;
        bool nuevo = true;
        public DatosDepartamento()
        {
            InitializeComponent();
            objDepartamento = new ClsDepartamento();
            nuevo = true;
        }

        private void DatosDepartamento_Load(object sender, EventArgs e)
        {

        }

        public DatosDepartamento(string _cveDepartamento, string _descripcion, string _encargado, int _estado)
        {
            InitializeComponent();
            objDepartamento = new ClsDepartamento();
            objDepartamento.cveDepartamento = _cveDepartamento;
            objDepartamento.descripcion = _descripcion;
            objDepartamento.encargado = _encargado;
            objDepartamento.estado = _estado;
            setValores();
            nuevo = false;
        }

        private void setValores()
        {
            textEdit_cveDepartamento.Text = objDepartamento.cveDepartamento;
            textEdit_descripcion.Text = objDepartamento.descripcion;
            lookUpEdit_encargadoCurp.Text = objDepartamento.encargado;
            checkEdit_status.Checked = objDepartamento.estado == 1 ? true : false;
        }

        private void simpleButton_agree_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEdit_cveDepartamento.Text))
            {
                XtraMessageBox.Show("Ingrese una clave para el departamento.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_descripcion.Text))
            {
                XtraMessageBox.Show("Ingrese una descripción para el departamento.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(lookUpEdit_encargadoCurp.Text))
            {
                XtraMessageBox.Show("Ingrese la CURP del encargado del departamento.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            objDepartamento.cveDepartamento = textEdit_cveDepartamento.Text;
            objDepartamento.descripcion = textEdit_descripcion.Text;
            objDepartamento.encargado = lookUpEdit_encargadoCurp.Text;
            objDepartamento.estado = checkEdit_status.Checked == true ? 1 : 0;

            int result = nuevo == true ? objDepartamento.insertDatoDepartamento() : objDepartamento.updateDatoDepartamento();
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