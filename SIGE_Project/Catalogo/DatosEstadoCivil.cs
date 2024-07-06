using DevExpress.XtraEditors;
using SIGE_Project.Catalogo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGE_Project
{
    public partial class DatosEstadoCivil : DevExpress.XtraEditors.XtraForm
    {
        ClsEstadoCivil objEstadoCivil;
        bool nuevo = true;
        public DatosEstadoCivil()
        {
            InitializeComponent();
            objEstadoCivil = new ClsEstadoCivil();
            nuevo = true;
        }

        public DatosEstadoCivil(int idEstadoCivil,string _descEstadoCivil, int _estadoCivil)
        {
            ////ESTE CONSTRUCTOR SE OCUPARA PARA CUANDO SE EDITE UN REGISTRO
            InitializeComponent();
            objEstadoCivil = new ClsEstadoCivil();
            objEstadoCivil.idEstadoCivil=idEstadoCivil; 
            objEstadoCivil.descEstadoCivil = _descEstadoCivil;
            objEstadoCivil.estadoCivil = _estadoCivil;
            setValores();
            nuevo = false;
        }

        private void setValores()
        {
            ////ESTE METODO SE OCUPA PARA COLOCAR LOS VALORES EN LOS CONTROLES 
            memoEdit_DescripcionRegistroCivil.Text = objEstadoCivil.descEstadoCivil;
            checkEdit_estado.Checked = objEstadoCivil.estadoCivil == 1 ? true : false;

           // memoEdit_DescripcionRegistroCivil.ReadOnly = true;///SE BLOQUEA CAMPO DE CLAVE MEDIO
        }
        private void DatosEstadoCivil_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton_aceptar_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(memoEdit_DescripcionRegistroCivil.Text))
            //{
            //    XtraMessageBox.Show("Ingrese una clave para el genero.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            if (string.IsNullOrEmpty(memoEdit_DescripcionRegistroCivil.Text))
            {
                XtraMessageBox.Show("Ingrese una descripción para el estado civil.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //objEstadoCivil.cveGenero = textEdit_claveGenero.Text;
            objEstadoCivil.descEstadoCivil = memoEdit_DescripcionRegistroCivil.Text;
            objEstadoCivil.estadoCivil = checkEdit_estado.Checked == true ? 1 : 0;

            int result = nuevo == true ? objEstadoCivil.insertDatoEstadoCivil() : objEstadoCivil.updateDescEstadoCivil();
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

        private void simpleButton_cancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Esta seguro de querer cerrar esta ventana sin guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}