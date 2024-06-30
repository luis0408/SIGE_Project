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
    public partial class DatosMedioDifusion : DevExpress.XtraEditors.XtraForm
    {
        ClsMedioDifusion objMedioDifusion;
        bool nuevo = true;
        public DatosMedioDifusion()
        {
            /////ESTE METODO SE OCUAPA CUANDO SE INSERTA UN NUEVO REGISTRO
            InitializeComponent();
            objMedioDifusion = new ClsMedioDifusion();
            nuevo = true;
            
        }
        public DatosMedioDifusion(string _cveMedioDifusion, string _descMedioDifusion, int _estadoMedioDifusion)
        {
            ////ESTE CONSTRUCTOR SE OCUPARA PARA CUANDO SE EDITE UN REGISTRO
            InitializeComponent();
            objMedioDifusion= new ClsMedioDifusion();
            objMedioDifusion.cveMedioDifusion= _cveMedioDifusion;   
            objMedioDifusion.descMedioDifusion=_descMedioDifusion;
            objMedioDifusion.estadoMedioDifusion = _estadoMedioDifusion;
            setValores();
            nuevo= false;   
        }
        private void setValores()
        {
            ////ESTE METODO SE OCUPA PARA COLOCAR LOS VALORES EN LOS CONTROLES 
            textEdit_cveMedio.Text = objMedioDifusion.cveMedioDifusion;
            memoEdit_descMedio.Text = objMedioDifusion.descMedioDifusion;
            checkEdit_estado.Checked=objMedioDifusion.estadoMedioDifusion==1?true:false;

            textEdit_cveMedio.ReadOnly = true;///SE BLOQUEA CAMPO DE CLAVE MEDIO
        }
        private void DatosMedioDifusion_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton_cancel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Esta seguro de querer cerrar esta ventana sin guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void simpleButton_acept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEdit_cveMedio.Text))
            {
                XtraMessageBox.Show("Ingrese una clave para el medio de difusión.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(memoEdit_descMedio.Text))
            {
                XtraMessageBox.Show("Ingrese una descripción para el medio de difusión.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            objMedioDifusion.cveMedioDifusion = textEdit_cveMedio.Text;
            objMedioDifusion.descMedioDifusion = memoEdit_descMedio.Text;
            objMedioDifusion.estadoMedioDifusion = checkEdit_estado.Checked == true ? 1 : 0;

            int result = nuevo == true ? objMedioDifusion.insertDatoMedioDifusion() : objMedioDifusion.updateDescMedioDifusion();
            if (result==1)
            {
                XtraMessageBox.Show("Los datos se guardarón correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult= DialogResult.OK;
                this.Close();

            }
            else
            {
                XtraMessageBox.Show("Se generó un error al insertar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}