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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SIGE_Project.Configuraciones
{
    public partial class AgregarPestanias : DevExpress.XtraEditors.XtraForm
    {
        string idPestania, nombrePestania;

        public AgregarPestanias()
        {
            InitializeComponent();
        }
        public AgregarPestanias(string _idPestania, string _nombrePestania)
        {
            InitializeComponent();
            idPestania = _idPestania;
            nombrePestania = _nombrePestania;
        }
        private void AgregarPestanias_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(idPestania))
            {
                ////Si es difenre de nulo o vacio quiere decir que trae un valor y se va a editar
                ////Se cargan datos para editar
                textEdit_idPestania.Text = idPestania;
                textEdit_descripcion.Text = nombrePestania;
                textEdit_idPestania.ReadOnly = true;
            }
        }
        private void simpleButton_aceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
        private void simpleButton_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        
    }
}